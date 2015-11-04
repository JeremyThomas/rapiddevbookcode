using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.ConnectionUI;
using LLBLGen.EntityBrowser.Properties;
using Microsoft.Data.ConnectionUI;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGen.EntityBrowser
{
  public partial class MainForm : FrmPersistantLocation
  {
    public MainForm()
    {
      InitializeComponent();
      if (ConfigurationManager.ConnectionStrings.Count > 0)
      {
        var connectionStringSettings = ConfigurationManager.ConnectionStrings[ConfigurationManager.ConnectionStrings.Count - 1];
        //var linqMetaData = Factories.CreateLinqMetaData(connectionStringSettings.ConnectionString);
        var adapter = GetAdapter(connectionStringSettings, Settings.Default.AdapterAssemblyPath);
        if (!File.Exists(Settings.Default.LinqMetaDataAssemblyPath))
          throw new ApplicationException("Adapter assembly: " + Settings.Default.LinqMetaDataAssemblyPath + " not found!" + Environment.NewLine);
        var linqMetaDataAssemblyPath = LoadAssembly(Settings.Default.LinqMetaDataAssemblyPath);
        var linqMetaDataType = linqMetaDataAssemblyPath.GetConcretePublicImplementations(typeof (ILinqMetaData)).FirstOrDefault();
        if (linqMetaDataType != null)
        {
          var linqMetaData = (ILinqMetaData) Activator.CreateInstance(linqMetaDataType, adapter);
          usrCntrlEntityBrowser1.Initialize(linqMetaData);
        }
        Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
        var tabPage = tabControl.TabPages[0];
        tabPage.Name = connectionStringSettings.Name;
        tabPage.Text = tabPage.Name;
      }
    }

    private void toolStripButtonAddConnection_Click(object sender, EventArgs e)
    {
      var dcd = new DataConnectionDialog();
      var dcs = new DataConnectionConfiguration(null);
      dcs.LoadConfiguration(dcd);
      var browserConnection = new BrowserConnection();
      DataConnectionConfiguration.SelectDataProvider(dcd, browserConnection.Provider);

      if (dcd.SelectedDataProvider != null)
        dcd.ConnectionString = browserConnection.ConnectionString;
      if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
      {
        browserConnection.ConnectionString = dcd.ConnectionString;
        if (dcd.SelectedDataProvider != null)
        {
          browserConnection.Provider = dcd.SelectedDataProvider.Name;
          var connectionStringSettings = new ConnectionStringSettings("connection" + ConfigurationManager.ConnectionStrings.Count, browserConnection.ConnectionString);
          ConfigurationManager.ConnectionStrings.Add(connectionStringSettings);
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

    public static DataAccessAdapterBase GetAdapter(ConnectionStringSettings connectionStringSettings, string adapterAssemblyPath, string adapterTypeName = null)
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

      return GetAdapter(connectionStringSettings, adapterTypeName, adapterAssemblyPath, dataAccessAdapterAssembly, dataAccessAdapterType);
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
  }

  internal class BrowserConnection
  {
    public string Provider { get; set; }
    public string ConnectionString { get; set; }
  }
}