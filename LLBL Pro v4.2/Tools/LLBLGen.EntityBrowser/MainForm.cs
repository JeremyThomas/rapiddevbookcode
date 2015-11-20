using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.ConnectionUI;
using AW.Winforms.Helpers.LLBL;
using LLBLGen.EntityBrowser.Properties;
using Microsoft.Data.ConnectionUI;
using Microsoft.VisualBasic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

// ReSharper disable BuiltInTypeReferenceStyle

namespace LLBLGen.EntityBrowser
{
  public partial class MainForm : FrmPersistantLocation
  {
    private static Type _linqMetaDataType;
    private static Type _adapterType;

    /// <summary>
    ///   The <see cref="ConnectionString" /> property's name.
    /// </summary>
    public const string ConnectionStringPropertyName = "ConnectionString";

    private const string SystemDataSqlClient = "System.Data.SqlClient";
    private const string OracleDataAccessClient = "Oracle.DataAccess.Client";
    private const string SystemDataOracleClient = "System.Data.OracleClient";

    private static readonly DataConnectionDialog DataConnectionDialog;

    static MainForm()
    {
      ProfilerHelper.InitializeOrmProfiler();
      DataConnectionDialog = new DataConnectionDialog();
      var dataConnectionConfiguration = new DataConnectionConfiguration(null);
      dataConnectionConfiguration.LoadConfiguration(DataConnectionDialog);
      Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      UserSettings = GeneralHelper.GetClientSettingsSection(Configuration, "userSettings");
      ConnectionStringSettingsCollection = Configuration.ConnectionStrings.ConnectionStrings;
    }

    public MainForm()
    {
      InitializeComponent();
      settingsBindingSource.DataSource = Settings.Default;
      if (!String.IsNullOrWhiteSpace(Settings.Default.AdapterAssemblyPath))
        try
        {
          var adapterAssemblyPath = Path.GetDirectoryName(Settings.Default.AdapterAssemblyPath);
          if (adapterAssemblyPath != null)
            linqMetaDataAssemblyPathLabel.Links.Add(0, linqMetaDataAssemblyPathLabel.Text.Length, adapterAssemblyPath);
        }
        catch (Exception)
        {
          // ignored
        }

      if (!String.IsNullOrWhiteSpace(Settings.Default.LinqMetaDataAssemblyPath))
        try
        {
          var linqMetaDataAssemblyPath = Path.GetDirectoryName(Settings.Default.LinqMetaDataAssemblyPath);
          if (linqMetaDataAssemblyPath != null) adapterAssemblyPathLabel.Links.Add(0, adapterAssemblyPathLabel.Text.Length, linqMetaDataAssemblyPath);
        }
        catch (Exception)
        {
          // ignored
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
      try
      {
        LoadAssembliesAndTabs();
        if (tabControl.TabPages.Count == 0)
        {
          panelSettings.Visible = true;
          toolStrip1.Visible = true;
        }
      }
      catch (Exception ex)
      {
        panelSettings.Visible = true;
        toolStrip1.Visible = true;
        Application.OnThreadException(ex.GetBaseException());
      }
    }

    private void toolStripButtonLoad_Click(object sender, EventArgs e)
    {
      LoadAssembliesAndTabs();
    }

    private void LoadAssembliesAndTabs()
    {
      if (!File.Exists(Settings.Default.LinqMetaDataAssemblyPath))
        throw new ApplicationException("LinqMetaData assembly: " + Settings.Default.LinqMetaDataAssemblyPath + " not found!" + Environment.NewLine);
      var linqMetaDataAssembly = LoadAssembly(Settings.Default.LinqMetaDataAssemblyPath);
      _linqMetaDataType = linqMetaDataAssembly.GetConcretePublicImplementations(typeof (ILinqMetaData)).FirstOrDefault();
      if (_linqMetaDataType == null)
        throw new ApplicationException("There are no public types in that assembly that implement ILinqMetaData. Wrong Assembly chosen.");

      _daoBaseImplementationType = EntityHelper.GetDaoBaseImplementation(linqMetaDataAssembly);

      if (_daoBaseImplementationType == null && !String.IsNullOrWhiteSpace(Settings.Default.AdapterAssemblyPath))
      {
        if (!File.Exists(Settings.Default.AdapterAssemblyPath))
          throw new ApplicationException("Adapter assembly: " + Settings.Default.AdapterAssemblyPath + " not found!" + Environment.NewLine);
        _adapterType = GetAdapterType(Settings.Default.AdapterAssemblyPath);
      }
      LoadTabs();
    }

    private void LoadTabs()
    {
      if (_linqMetaDataType != null)
      {
        if (UserConnections != null)
          foreach (var connectionStringSetting in UserConnections)
            AddEntityBrowser(connectionStringSetting);
        if (tabControl.TabPages.Count == 0)
          foreach (ConnectionStringSettings connectionStringSetting in ConnectionStringSettingsCollection)
            AddEntityBrowser(connectionStringSetting);
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        try
        {
          GeneralHelper.CopySettings(Settings.Default, UserSettings);

          // Save the configuration file.
          Configuration.Save(ConfigurationSaveMode.Minimal, true);
          // This is needed. Otherwise the updates do not show up in ConfigurationManager
          ConfigurationManager.RefreshSection("connectionStrings");
          ConfigurationManager.RefreshSection("userSettings");
        }
        catch (Exception)
        {
          if (UserConnections == null)
            Settings.Default.UserConnections = new ArrayList();
          else
            Settings.Default.UserConnections.Clear();
          foreach (var connectionString in ConnectionStringSettingsCollection.Cast<ConnectionStringSettings>().Where(connectionString => !string.IsNullOrWhiteSpace(connectionString.ConnectionString)))
            Settings.Default.UserConnections.Add(connectionString);
        }
        Settings.Default.Save();
      }
      catch (Exception ex)
      {
        Application.OnThreadException(ex.GetBaseException());
      }
    }

    private void AddEntityBrowser(ConnectionStringSettings connectionStringSetting)
    {
      tabControl.TabPages.Add(connectionStringSetting.Name, connectionStringSetting.Name);
      var tabPage = tabControl.TabPages[connectionStringSetting.Name];
      tabPage.Tag = connectionStringSetting;
      var usrCntrlEntityBrowser = new UsrCntrlEntityBrowser(null, Settings.Default.UseContext, Settings.Default.PrefixDelimiter,
        Settings.Default.EnsureFilteringEnabled, Settings.Default.UseContext, (int) Settings.Default.CacheDurationInSeconds)
      {
        Dock = DockStyle.Fill,
        PageSize = (ushort) Settings.Default.PageSize
      };
      InitializeEntityBrowser(usrCntrlEntityBrowser, connectionStringSetting);
      tabPage.Controls.Add(usrCntrlEntityBrowser);
    }

    private static void InitializeEntityBrowser(UsrCntrlEntityBrowser usrCntrlEntityBrowser, ConnectionStringSettings connectionStringSetting)
    {
      ILinqMetaData linqMetaData;
      if (_daoBaseImplementationType == null)
      {
        var adapter = GetAdapter(connectionStringSetting, null, Settings.Default.AdapterAssemblyPath, null, _adapterType);
        adapter.CommandTimeOut = (int) Settings.Default.CommandTimeOut;
        linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType, adapter);
      }
      else
      {
        linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType);
        EntityHelper.SetSelfservicingConnectionString(_daoBaseImplementationType, connectionStringSetting.ConnectionString);
        _daoBaseImplementationType.StaticMembers().CommandTimeOut = (int)Settings.Default.CommandTimeOut;
      }
      usrCntrlEntityBrowser.Initialize(linqMetaData);
    }

    private static IEnumerable<ConnectionStringSettings> UserConnections
    {
      get { return Settings.Default.UserConnections == null ? null : Settings.Default.UserConnections.Cast<ConnectionStringSettings>(); }
    }

    private void toolStripButtonAddConnection_Click(object sender, EventArgs e)
    {
      DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, SystemDataSqlClient);

      if (DataConnectionDialog.Show(DataConnectionDialog) == DialogResult.OK)
      {
        var connectionStringSettings = new ConnectionStringSettings(DataConnectionDialog.ConnectionString, DataConnectionDialog.ConnectionString, SystemDataSqlClient);
        if (DataConnectionDialog.SelectedDataProvider != null)
        {
          connectionStringSettings.ProviderName = DataConnectionDialog.SelectedDataProvider.Name;
          var adoDotNetConnectionProperties = new AdoDotNetConnectionProperties(connectionStringSettings.ProviderName);
          var sqlConnectionStringBuilder = adoDotNetConnectionProperties.ConnectionStringBuilder as SqlConnectionStringBuilder;
          if (sqlConnectionStringBuilder != null)
          {
            sqlConnectionStringBuilder.ConnectionString = connectionStringSettings.ConnectionString;
            var name = sqlConnectionStringBuilder.DataSource + "-" + (sqlConnectionStringBuilder.InitialCatalog ?? sqlConnectionStringBuilder.AttachDBFilename);
            var existingConnectionStringSetting = ConnectionStringSettingsCollection[name];
            if (existingConnectionStringSetting == null)
              connectionStringSettings.Name = name;
          }
        }
        var stringSettings = ConnectionStringSettingsCollection[connectionStringSettings.Name];
        if (stringSettings == null)
        {
          try
          {
            ConnectionStringSettingsCollection.Add(connectionStringSettings);
          }
          catch (Exception ex)
          {
            Application.OnThreadException(ex.GetBaseException());
          }
          AddEntityBrowser(connectionStringSettings);
        }
        else
        {
          MessageBox.Show("See: " + stringSettings.Name + Environment.NewLine + stringSettings.ConnectionString, "Connection already present");
        }
      }
    }

    public enum LLBLConnectionType
    {
      Unknown,
      SelfServicing,
      Adapter,
      [Description("Adapter Factory")] AdapterFactory
    }

    private static Assembly LoadAssembly(string assemblyPath)
    {
      return Assembly.LoadFrom(assemblyPath);
    }

    public static Type GetAdapterType(string adapterAssemblyPath, string adapterTypeName = null)
    {
      if (!File.Exists(adapterAssemblyPath))
        throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " not found!" + Environment.NewLine);
      var dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);

      var dataAccessAdapterType = String.IsNullOrEmpty(adapterTypeName) ? dataAccessAdapterAssembly.GetConcretePublicImplementations(typeof (DataAccessAdapterBase)).FirstOrDefault() : dataAccessAdapterAssembly.GetType(adapterTypeName);
      if (dataAccessAdapterType == null)
        throw new ApplicationException("CommonDaoBase or adapter not found!");

      return dataAccessAdapterType;
    }

    private static DataAccessAdapterBase GetAdapter(ConnectionStringSettings connectionStringSettings, string adapterTypeName, string adapterAssemblyPath, Assembly dataAccessAdapterAssembly, Type dataAccessAdapterType)
    {
      DataAccessAdapterBase adapter;
      if (dataAccessAdapterAssembly == null)
      {
        if (String.IsNullOrWhiteSpace(Settings.Default.AdapterAssemblyPath))
          return null;
        dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);
      }
      if (dataAccessAdapterAssembly == null)
        throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " could not be loaded!");
      if (dataAccessAdapterType == null)
        dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
      if (dataAccessAdapterType == null)
        throw new ApplicationException(String.Format("Adapter type: {0} could not be loaded from: {1}!", adapterTypeName, adapterAssemblyPath));
      if (String.IsNullOrEmpty(connectionStringSettings.ConnectionString))
      {
        adapter = dataAccessAdapterAssembly.CreateInstance(adapterTypeName) as DataAccessAdapterBase;
      }
      else
      {
        if (connectionStringSettings.ProviderName.Contains("SqlClient"))
          adapter = Activator.CreateInstance(dataAccessAdapterType, connectionStringSettings.ConnectionString, true, CatalogNameUsage.Clear, null) as DataAccessAdapterBase;
        else
        {
          if (connectionStringSettings.ProviderName.Contains("Oracle"))
            adapter = Activator.CreateInstance(dataAccessAdapterType, connectionStringSettings.ConnectionString, true, SchemaNameUsage.Default, null) as DataAccessAdapterBase;
          else
            adapter = Activator.CreateInstance(dataAccessAdapterType, connectionStringSettings.ConnectionString) as DataAccessAdapterBase;
        }
      }
      return adapter;
    }

    //Variable to store the tabpage which belongs to the headeritem
    //over which the cursor is currently hovering.
    private TabPage _currentTabItem;
    private static readonly Configuration Configuration;
    private static readonly ConnectionStringSettingsCollection ConnectionStringSettingsCollection;
    private static readonly ClientSettingsSection UserSettings;
    private static Type _daoBaseImplementationType;

    private void tabControl_MouseMove(object sender, MouseEventArgs e)
    {
      var hoverTab = TestTab(new Point(e.X, e.Y));
      if (hoverTab >= 0)
      {
        _currentTabItem = tabControl.TabPages[hoverTab];

        if (tabControl.ContextMenuStrip == null || tabControl.ContextMenuStrip == contextMenuStripTabControl)
          tabControl.ContextMenuStrip = contextMenuStripTabPage;
      }
      else
      {
        tabControl.ContextMenuStrip = contextMenuStripTabControl;
      }
    }

    private int TestTab(Point pt)
    {
      var returnIndex = -1;
      for (var index = 0; index <= tabControl.TabCount - 1; index++)
        if (tabControl.GetTabRect(index).Contains(pt.X, pt.Y))
          returnIndex = index;
      return returnIndex;
    }

    //private void tabControl1_MouseMove(object sender, MouseEventArgs e)
    //{
    //  Rectangle mouseRect = new Rectangle(e.X, e.Y, 1, 1);
    //  for (int i = 0; i < tabControl1.TabCount; i++)
    //  {
    //    if (tabControl1.GetTabRect(i).IntersectsWith(mouseRect))
    //    {
    //      tabControl1.SelectedIndex = i;
    //      break;
    //    }
    //  }
    //}

    private void tabControl_MouseLeave(object sender, EventArgs e)
    {
      if (tabControl.TabPages.Count == 0)
        tabControl.ContextMenuStrip = contextMenuStripTabControl;
      else
        tabControl.ContextMenuStrip = null;
    }

    private void editConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var connectionStringSettings = CurrentConnectionStringSetting;
      if (connectionStringSettings != null)
      {
        DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, SystemDataSqlClient);

        if (DataConnectionDialog.SelectedDataProvider != null)
          try
          {
            DataConnectionDialog.ConnectionString = connectionStringSettings.ConnectionString;
          }
          catch (Exception)
          {
            DataConnectionDialog.SelectedDataProvider = null;
          }

        if (DataConnectionDialog.Show(DataConnectionDialog) == DialogResult.OK)
        {
          connectionStringSettings.ConnectionString = DataConnectionDialog.ConnectionString;
          var usrCntrlEntityBrowser = _currentTabItem.Controls[0] as UsrCntrlEntityBrowser;
          InitializeEntityBrowser(usrCntrlEntityBrowser, connectionStringSettings);
        }
      }
    }

    private ConnectionStringSettings CurrentConnectionStringSetting
    {
      get { return _currentTabItem.Tag as ConnectionStringSettings; }
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      tabControl.TabPages.Remove(_currentTabItem);
      if (tabControl.TabPages.Count == 0)
      {
        tabControl.ContextMenuStrip = contextMenuStripTabControl;
        ContextMenuStrip = contextMenuStripTabControl;
      }
    }

    private void renameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentTabItem.Text = Interaction.InputBox("Set the name of this connection", "Title", _currentTabItem.Text);
      if (!CurrentConnectionStringSetting.IsReadOnly())
        CurrentConnectionStringSetting.Name = _currentTabItem.Text;
    }

    private void linqMetaDataAssemblyPathLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (e.Link.LinkData != null) Process.Start(e.Link.LinkData.ToString());
    }

    private void toggleSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      panelSettings.Visible = !panelSettings.Visible;
      toolStrip1.Visible = !toolStrip1.Visible;
    }
  }

  internal class BrowserConnection
  {
    public string Provider { get; set; }
    public string ConnectionString { get; set; }
  }
}