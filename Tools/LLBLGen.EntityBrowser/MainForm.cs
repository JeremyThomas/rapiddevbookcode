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
    private Type _linqMetaDataType;
    private Type _adapterType;

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
      var configurationSectionGroup = Configuration.GetSectionGroup("userSettings");
      if (configurationSectionGroup != null && configurationSectionGroup.Sections.Count > 0)
      {
        UserSettings = configurationSectionGroup.Sections[0] as ClientSettingsSection;
      }
      ConnectionStringSettingsCollection = Configuration.ConnectionStrings.ConnectionStrings;
    }

    public MainForm()
    {
      InitializeComponent();
      settingsBindingSource.DataSource = Settings.Default;

      var adapterAssemblyPath = Path.GetDirectoryName(Settings.Default.AdapterAssemblyPath);
      if (adapterAssemblyPath != null) linqMetaDataAssemblyPathLabel.Links.Add(0, adapterAssemblyPath.Length, adapterAssemblyPath);
      var linqMetaDataAssemblyPath = Path.GetDirectoryName(Settings.Default.LinqMetaDataAssemblyPath);
      if (linqMetaDataAssemblyPath != null) adapterAssemblyPathLabel.Links.Add(0, linqMetaDataAssemblyPath.Length, linqMetaDataAssemblyPath);
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
      _adapterType = GetAdapterType(Settings.Default.AdapterAssemblyPath);
      if (!File.Exists(Settings.Default.LinqMetaDataAssemblyPath))
        throw new ApplicationException("Adapter assembly: " + Settings.Default.LinqMetaDataAssemblyPath + " not found!" + Environment.NewLine);
      var linqMetaDataAssemblyPath = LoadAssembly(Settings.Default.LinqMetaDataAssemblyPath);
      _linqMetaDataType = linqMetaDataAssemblyPath.GetConcretePublicImplementations(typeof (ILinqMetaData)).FirstOrDefault();
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
        SetProperty("AdapterAssemblyPath");
        SetProperty("LinqMetaDataAssemblyPath");
        SetProperty("PageSize");
        SetProperty("PrefixDelimiter");
        SetProperty("UseContext");
        SetProperty("EnsureFilteringEnabled");
        SetProperty("UseSchema");
        SetProperty("CacheDurationInSeconds");//, (Settings.Default.CacheDurationInSeconds+1).ToString());
        try
        {
          // Save the configuration file.
          Configuration.Save(ConfigurationSaveMode.Minimal, true);
          Configuration.SaveAs("Test.config", ConfigurationSaveMode.Modified);
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
          Settings.Default.Save();
        }
      }
      catch (Exception ex)
      {
        Application.OnThreadException(ex.GetBaseException());
      }
    }

    private static void SetProperty(string propertyName, string value=null)
    {
      var adapterAssemblyPathSettingElement = UserSettings.Settings.Get(propertyName);
      adapterAssemblyPathSettingElement.Value.ValueXml.InnerText = value?? Convert.ToString(Settings.Default[propertyName]);
    }

    private void AddEntityBrowser(ConnectionStringSettings connectionStringSetting)
    {
      tabControl.TabPages.Add(connectionStringSetting.Name, connectionStringSetting.Name);
      var tabPage = tabControl.TabPages[connectionStringSetting.Name];
      tabPage.Tag = connectionStringSetting;
      var usrCntrlEntityBrowser = new UsrCntrlEntityBrowser(null, Settings.Default.UseContext, Settings.Default.PrefixDelimiter,
        Settings.Default.EnsureFilteringEnabled, Settings.Default.UseContext, (int) Settings.Default.CacheDurationInSeconds);
      tabPage.Controls.Add(usrCntrlEntityBrowser);
      usrCntrlEntityBrowser.Dock = DockStyle.Fill;
      var adapter = GetAdapter(connectionStringSetting, null, Settings.Default.AdapterAssemblyPath, null, _adapterType);
      var linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType, adapter);
      usrCntrlEntityBrowser.PageSize = (ushort) Settings.Default.PageSize;
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
      Type dataAccessAdapterType;
      var dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);

      dataAccessAdapterType = String.IsNullOrEmpty(adapterTypeName) ? dataAccessAdapterAssembly.GetConcretePublicImplementations(typeof (DataAccessAdapterBase)).FirstOrDefault() : dataAccessAdapterAssembly.GetType(adapterTypeName);
      if (dataAccessAdapterType == null)
        throw new ApplicationException("CommonDaoBase or adapter not found!");

      return dataAccessAdapterType;
    }

    private static DataAccessAdapterBase GetAdapter(ConnectionStringSettings connectionStringSettings, string adapterTypeName, string adapterAssemblyPath, Assembly dataAccessAdapterAssembly, Type dataAccessAdapterType)
    {
      DataAccessAdapterBase adapter;
      if (dataAccessAdapterAssembly == null)
        dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);
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