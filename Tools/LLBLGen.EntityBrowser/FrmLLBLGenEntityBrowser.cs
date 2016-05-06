using System;
using System.Collections;
using System.Collections.Generic;
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
  public partial class FrmLLBLGenEntityBrowser : FrmPersistantLocation
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

    static FrmLLBLGenEntityBrowser()
    {
      ProfilerHelper.InitializeOrmProfiler();
      DataConnectionDialog = new DataConnectionDialog();
      var dataConnectionConfiguration = new DataConnectionConfiguration(null);
      dataConnectionConfiguration.LoadConfiguration(DataConnectionDialog);
      Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      UserSettings = GeneralHelper.GetClientSettingsSection(Configuration, "userSettings");
      ConnectionStringSettingsCollection = Configuration.ConnectionStrings.ConnectionStrings;
    }

    public FrmLLBLGenEntityBrowser()
    {
      InitializeComponent();
      settingsBindingSource.DataSource = Settings.Default;

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

      if (!String.IsNullOrWhiteSpace(Settings.Default.AdapterAssemblyPath))
        try
        {
          var adapterAssemblyPath = Path.GetDirectoryName(Settings.Default.AdapterAssemblyPath.Before(";", Settings.Default.AdapterAssemblyPath));
          if (adapterAssemblyPath != null)
            linqMetaDataAssemblyPathLabel.Links.Add(0, linqMetaDataAssemblyPathLabel.Text.Length, adapterAssemblyPath);
        }
        catch (Exception)
        {
          // ignored
        }
    }

    private void MainForm_Load(object sender, EventArgs e) 
    {
      toolStripLabelOrmProfilerStatus.Text = ProfilerHelper.OrmProfilerStatus;
      try
      {
        LoadAssembliesAndTabs(Settings.Default.LinqMetaDataAssemblyPath, Settings.Default.AdapterAssemblyPath);
        if (_linqMetaDataType!=null)
          Text += string.Format(" - {0}", _linqMetaDataType.Assembly.FullName.Before(", Culture"));
        if (tabControl.TabPages.Count == 0 || Settings.Default.ShowSettings)
        {
          panelSettings.Visible = true;
          toolStrip.Visible = true;
        }
      }
      catch (Exception ex)
      {
        panelSettings.Visible = true;
        toolStrip.Visible = true;
        Application.OnThreadException(ex.GetBaseException());
      }
    }

    private void toolStripButtonLoad_Click(object sender, EventArgs e)
    {
      LoadAssembliesAndTabs(Settings.Default.LinqMetaDataAssemblyPath, Settings.Default.AdapterAssemblyPath);
    }

    private void linqMetaDataAssemblyPathTextBox_Leave(object sender, EventArgs e)
    {
      if (_linqMetaDataType == null)
        LoadAssembliesAndTabs(linqMetaDataAssemblyPathTextBox.Text, Settings.Default.AdapterAssemblyPath);
    }

    private void LoadTabs()
    {
      if (_linqMetaDataType != null)
      {
        var countBefore = tabControl.TabPages.Count;
        if (UserConnections != null)
          foreach (var connectionStringSetting in UserConnections)
            AddEntityBrowser(connectionStringSetting);
        if (tabControl.TabPages.Count == countBefore)
        {
          tabControl.TabPages.Clear();
          foreach (ConnectionStringSettings connectionStringSetting in ConnectionStringSettingsCollection)
            AddEntityBrowser(connectionStringSetting);}
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
        PageSize = (ushort) Settings.Default.PageSize,
        CascadeDeletes = Settings.Default.CascadeDeletes
      };
      InitializeEntityBrowser(usrCntrlEntityBrowser, connectionStringSetting);
      tabPage.Controls.Add(usrCntrlEntityBrowser);
    }

    private static IEnumerable<ConnectionStringSettings> UserConnections
    {
      get { return Settings.Default.UserConnections == null ? null : Settings.Default.UserConnections.Cast<ConnectionStringSettings>(); }
    }

    private void toolStripButtonAddConnection_Click(object sender, EventArgs e)
    {
      var currentConnectionStringSetting = CurrentConnectionStringSetting;
      DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, currentConnectionStringSetting == null ? SystemDataSqlClient : currentConnectionStringSetting.ProviderName);
      if (DataConnectionDialog.Show(DataConnectionDialog) == DialogResult.OK)
      {
        var connectionStringSettings = new ConnectionStringSettings(DataConnectionDialog.ConnectionString, DataConnectionDialog.ConnectionString, SystemDataSqlClient);
        if (DataConnectionDialog.SelectedDataProvider != null)
        {
          connectionStringSettings.ProviderName = DataConnectionDialog.SelectedDataProvider.Name;
          try
          {
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
          catch (ArgumentException ex)
          {
            MessageBox.Show(connectionStringSettings.ProviderName);
            throw;
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
          MessageBox.Show(string.Format("See: {0}{1}{2}", stringSettings.Name, Environment.NewLine, stringSettings.ConnectionString), "Connection already present");
        }
      }
    }

    private void editConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var connectionStringSettings = CurrentConnectionStringSetting;
      if (connectionStringSettings != null)
      {
        DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, connectionStringSettings.ProviderName);

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
          if (_currentTabItem.Controls.Count > 0)
          {
            var usrCntrlEntityBrowser = _currentTabItem.Controls[0] as UsrCntrlEntityBrowser;
            InitializeEntityBrowser(usrCntrlEntityBrowser, connectionStringSettings);
          }
        }
      }
    }

    private static void InitializeEntityBrowser(UsrCntrlEntityBrowser usrCntrlEntityBrowser, ConnectionStringSettings connectionStringSetting)
    {
      ILinqMetaData linqMetaData;
      if (_daoBaseImplementationType == null)
      {
        var adapter = GetAdapter(connectionStringSetting);
        adapter.CommandTimeOut = (int) Settings.Default.CommandTimeOut;
        linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType, adapter);
      }
      else
      {
        linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType);
        EntityHelper.SetSelfservicingConnectionString(_daoBaseImplementationType, connectionStringSetting.ConnectionString);
        DaoBase.CommandTimeOut = (int) Settings.Default.CommandTimeOut;
        var sqlServerDqeAssemblyName = _daoBaseImplementationType.Assembly.GetReferencedAssemblies().FirstOrDefault(a => a.Name.Contains("SD.LLBLGen.Pro.DQE.SqlServer"));
        if (sqlServerDqeAssemblyName != null)
        {
          var x = Activator.CreateInstance(_daoBaseImplementationType);
          var sqlServerDqeAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName == sqlServerDqeAssemblyName.FullName);
          if (sqlServerDqeAssembly != null)
          {
            var newCatalog = DataHelper.GetSqlDatabaseName(connectionStringSetting.ConnectionString);
            if (!string.IsNullOrWhiteSpace(newCatalog))
            {
              var dynamicQueryEnginetype = sqlServerDqeAssembly.GetConcretePublicImplementations(typeof(DynamicQueryEngineBase)).FirstOrDefault();
              if (dynamicQueryEnginetype != null)
              {
                var obj = dynamicQueryEnginetype.InvokeMember("_catalogOverwrites", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Static, null, null, null);
                var overrides = obj as Dictionary<string, string>;
                var entityType = _linqMetaDataType.Assembly.GetConcretePublicImplementations(typeof(EntityBase)).FirstOrDefault();
                var elementCreator = EntityHelper.CreateElementCreator(entityType);
                var entity = LinqUtils.CreateEntityInstanceFromEntityType(entityType, elementCreator);
                if (entity != null && overrides != null)
                {
                  var fieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfoSafely(entity);
                  if (fieldPersistenceInfo != null && fieldPersistenceInfo.SourceCatalogName != newCatalog)
                    overrides[fieldPersistenceInfo.SourceCatalogName] = newCatalog;
                }
              }
            }
          }
        }
      }
      usrCntrlEntityBrowser.Initialize(linqMetaData);
    }

    private static Assembly LoadAssembly(string assemblyPath)
    {
      return Assembly.LoadFrom(assemblyPath);
    }

    private void LoadAssembliesAndTabs(string linqMetaDataAssemblyPath, string adapterAssemblyPath)
    {
      if (String.IsNullOrWhiteSpace(linqMetaDataAssemblyPath))
        return;
      if (!File.Exists(linqMetaDataAssemblyPath))
        throw new ApplicationException("LinqMetaData assembly: " + linqMetaDataAssemblyPath + " not found!" + Environment.NewLine);
      var linqMetaDataAssembly = LoadAssembly(linqMetaDataAssemblyPath);
      _linqMetaDataType = linqMetaDataAssembly.GetConcretePublicImplementations(typeof(ILinqMetaData)).FirstOrDefault();
      if (_linqMetaDataType == null)
        throw new ApplicationException("There are no public types in that assembly that implement ILinqMetaData. Wrong Assembly chosen.");
      labellinqMetaDataAssemblyVersion.Text = "Version " + linqMetaDataAssembly.GetVersion();
      _daoBaseImplementationType = EntityHelper.GetDaoBaseImplementation(linqMetaDataAssembly);

      if (_daoBaseImplementationType == null && !String.IsNullOrWhiteSpace(adapterAssemblyPath))
      {
        _adapterTypes = GetAdapterTypes().ToList();
      }
      LoadTabs();
    }

    private static IEnumerable<Type> GetAdapterTypes()
    {
      var adapterAssemblyPaths = Settings.Default.AdapterAssemblyPath.Split(';');
      return adapterAssemblyPaths.Where(p => !string.IsNullOrWhiteSpace(p)).Select(GetAdapterType);
    }

    public static Type GetAdapterType(string adapterAssemblyPath)
    {
      if (String.IsNullOrWhiteSpace(Settings.Default.AdapterAssemblyPath))
        throw new ApplicationException("Adapter assembly not specified!");
      if (!File.Exists(adapterAssemblyPath))
        throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " not found!");
      var dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);
      if (dataAccessAdapterAssembly == null)
        throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " could not be loaded!");
      return GetAdapterType(dataAccessAdapterAssembly);
    }

    private static Type GetAdapterType(Assembly dataAccessAdapterAssembly)
    {
      if (dataAccessAdapterAssembly == null)
        throw new ArgumentNullException("dataAccessAdapterAssembly");
      var concretePublicImplementations = dataAccessAdapterAssembly.GetConcretePublicImplementations(typeof(DataAccessAdapterBase));
      Type dataAccessAdapterType = null;
      foreach (var implementation in concretePublicImplementations)
      {
        dataAccessAdapterType = implementation;
        if (dataAccessAdapterType.Name.Contains("DataAccessAdapter"))
          break;
      }
      if (dataAccessAdapterType == null)
        throw new ApplicationException(String.Format("Adapter not found in {0}!", dataAccessAdapterAssembly));
      return dataAccessAdapterType;
    }

    private static DataAccessAdapterBase GetAdapter(ConnectionStringSettings connectionStringSettings)
    {
      if (_adapterTypes == null || _adapterTypes.Count == 0)
        throw new ApplicationException("Adapter type not found!");
      if (_adapterTypes.Count == 1)
        return CreateDataAccessAdapterInstance(_adapterTypes[0], connectionStringSettings);
      foreach (var adapterType in _adapterTypes)
      {
        var dqeAssemblyName = adapterType.Assembly.GetReferencedAssemblies().FirstOrDefault(a => a.Name.StartsWith("SD.LLBLGen.Pro.DQE"));
        if (dqeAssemblyName != null)
        {
          if (IsSqlServer(connectionStringSettings) && dqeAssemblyName.Name.Contains("SqlServer"))
            return CreateDataAccessAdapterInstance(adapterType, connectionStringSettings);
          var dqeName = dqeAssemblyName.Name.Substring(19, 3);
          if (connectionStringSettings.ProviderName.Contains(dqeName))
            return CreateDataAccessAdapterInstance(adapterType, connectionStringSettings);
        }
      }
      return null;
    }

    private static DataAccessAdapterBase CreateDataAccessAdapterInstance(Type dataAccessAdapterType, ConnectionStringSettings connectionStringSettings)
    {
      var adapter = EntityHelper.CreateDataAccessAdapterInstance(dataAccessAdapterType, connectionStringSettings.ConnectionString
        , () => IsSqlServer(connectionStringSettings)
        , () => connectionStringSettings.ProviderName.Contains("Oracle"));
      return adapter;
    }

    private static bool IsSqlServer(ConnectionStringSettings connectionStringSettings)
    {
      return connectionStringSettings.ProviderName.Contains("SqlClient");
    }

    //Variable to store the tabpage which belongs to the headeritem
    //over which the cursor is currently hovering.
    private TabPage _currentTabItem;
    private static readonly Configuration Configuration;
    private static readonly ConnectionStringSettingsCollection ConnectionStringSettingsCollection;
    private static readonly ClientSettingsSection UserSettings;
    private static Type _daoBaseImplementationType;
    private static List<Type> _adapterTypes;

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

    private ConnectionStringSettings CurrentConnectionStringSetting
    {
      get
      {
        if (_currentTabItem == null) return null;
        return _currentTabItem.Tag as ConnectionStringSettings;
      }
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var currentConnectionStringSetting = CurrentConnectionStringSetting;
      tabControl.TabPages.Remove(_currentTabItem);
      if (tabControl.TabPages.Count == 0)
      {
        tabControl.ContextMenuStrip = contextMenuStripTabControl;
        ContextMenuStrip = contextMenuStripTabControl;
      }
      if (currentConnectionStringSetting != null)
        ConnectionStringSettingsCollection.Remove(currentConnectionStringSetting);
    }

    private void renameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentTabItem.Text = Interaction.InputBox("Set the name of this connection", "Title", _currentTabItem.Text);
      if (!CurrentConnectionStringSetting.IsReadOnly())
        CurrentConnectionStringSetting.Name = _currentTabItem.Text;
    }

    private void linqMetaDataAssemblyPathLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (e.Link.LinkData == null)
      {
        var dialogResult = openFileDialog1.ShowDialog();
        if (dialogResult == DialogResult.OK)
          Settings.Default.LinqMetaDataAssemblyPath = openFileDialog1.FileName;
      }
      else
        Process.Start(e.Link.LinkData.ToString());
    }

    private void toggleSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      panelSettings.Visible = !panelSettings.Visible;
      toolStrip.Visible = !toolStrip.Visible;
    }
  }

  internal class BrowserConnection
  {
    public string Provider { get; set; }
    public string ConnectionString { get; set; }
  }
}