using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

// ReSharper disable BuiltInTypeReferenceStyle

namespace LLBLGen.EntityBrowser
{
  public partial class MainForm : FrmPersistantLocation
  {
    private readonly Type _linqMetaDataType;
    private readonly Type _adapterType;

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
    }

    public MainForm()
    {
      InitializeComponent();
      settingsBindingSource.DataSource = Settings.Default;
      _adapterType = GetAdapterType(Settings.Default.AdapterAssemblyPath);
      if (!File.Exists(Settings.Default.LinqMetaDataAssemblyPath))
        throw new ApplicationException("Adapter assembly: " + Settings.Default.LinqMetaDataAssemblyPath + " not found!" + Environment.NewLine);
      var linqMetaDataAssemblyPath = LoadAssembly(Settings.Default.LinqMetaDataAssemblyPath);
      _linqMetaDataType = linqMetaDataAssemblyPath.GetConcretePublicImplementations(typeof (ILinqMetaData)).FirstOrDefault();
      if (_linqMetaDataType != null)
      {
        InitConnectionStringSettings();
        foreach (var connectionStringSetting in ConnectionStringSettingsList)
          AddEntityBrowser(connectionStringSetting);
      }
      Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
    }

    private void AddEntityBrowser(ConnectionStringSettings connectionStringSetting)
    {
      tabControl.TabPages.Add(connectionStringSetting.Name, connectionStringSetting.Name);
      var tabPage = tabControl.TabPages[connectionStringSetting.Name];
      tabPage.Tag = connectionStringSetting;
      var usrCntrlEntityBrowser = new UsrCntrlEntityBrowser();
      tabPage.Controls.Add(usrCntrlEntityBrowser);
      usrCntrlEntityBrowser.Dock = DockStyle.Fill;
      var adapter = GetAdapter(connectionStringSetting, null, Settings.Default.AdapterAssemblyPath, null, _adapterType);
      var linqMetaData = (ILinqMetaData) Activator.CreateInstance(_linqMetaDataType, adapter);
      usrCntrlEntityBrowser.Initialize(linqMetaData);
    }

    private static void InitConnectionStringSettings()
    {
      ConnectionStringSettingsList = new List<ConnectionStringSettings>();
      if (Settings.Default.Connections != null)
      {
        foreach (var connectionStringSettings in from connection
          in Settings.Default.Connections.Cast<string>()
            .Where(s => !string.IsNullOrWhiteSpace(s))
          select connection.Split(',')
          into parts
          let cs = parts[0]
          let provider = parts.Length > 1 ? parts[1] : SystemDataSqlClient
          select new ConnectionStringSettings(cs, cs, provider))
        {
          ConnectionStringSettingsList.Add(connectionStringSettings);
        }
      }
    }

    private ConnectionStringSettings AddToComboBoxRootDirectory(string connectionString)
    {
      var connectionStringSettings = new ConnectionStringSettings(connectionString, connectionString, SystemDataSqlClient);
      AddToComboBoxRootDirectory(connectionStringSettings);
      return connectionStringSettings;
    }

    private void AddToComboBoxRootDirectory(ConnectionStringSettings connectionString)
    {
      if (connectionString != null
          && (!string.IsNullOrWhiteSpace(connectionString.ConnectionString))
        //    && !ConnectionStrings.Contains(connectionString)
          && !ConnectionStringSettingsList.Any(cs => cs.ConnectionString.Equals(connectionString.ConnectionString)))
      {
        ConnectionStringSettingsList.Add(connectionString);
      }
    }

    public static List<ConnectionStringSettings> ConnectionStringSettingsList { get; set; }

    private void toolStripButtonAddConnection_Click(object sender, EventArgs e)
    {
      var browserConnection = new BrowserConnection {Provider = SystemDataSqlClient};
      DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, browserConnection.Provider);

      if (DataConnectionDialog.SelectedDataProvider != null)
        DataConnectionDialog.ConnectionString = browserConnection.ConnectionString;
      if (DataConnectionDialog.Show(DataConnectionDialog) == DialogResult.OK)
      {
        browserConnection.ConnectionString = DataConnectionDialog.ConnectionString;
        if (DataConnectionDialog.SelectedDataProvider != null)
        {
          browserConnection.Provider = DataConnectionDialog.SelectedDataProvider.Name;
          var connectionStringSetting = AddToComboBoxRootDirectory(browserConnection.ConnectionString);
          AddEntityBrowser(connectionStringSetting);
          //Settings.Default.Connections = ConnectionString;
          //var connectionStringSettings = new ConnectionStringSettings("connection" + ConfigurationManager.ConnectionStrings.Count, browserConnection.ConnectionString);
          //ConnectionStringSettingsList.Add(connectionStringSettings);
          //var linqMetaData = Factories.CreateLinqMetaData(browserConnection.ConnectionString);
          //usrCntrlEntityBrowser1.Initialize(linqMetaData);
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

      if (String.IsNullOrEmpty(adapterTypeName))
      {
        dataAccessAdapterType = dataAccessAdapterAssembly.GetConcretePublicImplementations(typeof (DataAccessAdapterBase)).FirstOrDefault();
      }
      else
      {
        dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
      }
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

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Settings.Default.Connections != null)
      {
        Settings.Default.Connections.Clear();

        foreach (var connectionString in ConnectionStringSettingsList.Where(cs => !string.IsNullOrWhiteSpace(cs.ConnectionString)))
        {
          Settings.Default.Connections.Add(GeneralHelper.Join(",", connectionString.ConnectionString, connectionString.ProviderName));
        }
        Settings.Default.Save();
      }
    }

    //Variable to store the tabpage which belongs to the headeritem
    //over which the cursor is currently hovering.
    private TabPage _currentTabItem;

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
      if (tabControl.TabPages.Count==0)
        tabControl.ContextMenuStrip = contextMenuStripTabControl;
      else
      tabControl.ContextMenuStrip = null;
    }

    private void editConnectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var connectionStringSettings = _currentTabItem.Tag as ConnectionStringSettings;
      if (connectionStringSettings != null)
      {
        var browserConnection = new BrowserConnection
        {
          Provider = SystemDataSqlClient,
          ConnectionString = connectionStringSettings.ConnectionString
        };
        DataConnectionConfiguration.SelectDataProvider(DataConnectionDialog, "System.Data.SqlClient");

        if (DataConnectionDialog.SelectedDataProvider != null)
          try
          {
      DataConnectionDialog.ConnectionString = browserConnection.ConnectionString;
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
      _currentTabItem.Text= Microsoft.VisualBasic.Interaction.InputBox("Set the name of this connection", "Title", _currentTabItem.Text);
    }
  }

  internal class BrowserConnection
  {
    public string Provider { get; set; }
    public string ConnectionString { get; set; }
  }
}