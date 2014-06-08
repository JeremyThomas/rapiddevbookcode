using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using AW.Helper;
using AW.Winforms.Helpers.ConnectionUI;
using Microsoft.Data.ConnectionUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for DataConnectionConfigurationTest and is intended
  ///   to contain all DataConnectionConfigurationTest Unit Tests
  /// </summary>
  [TestClass]
  public class DataConnectionConfigurationTest
  {
    /// <summary>
    ///   Gets or sets the test context which provides
    ///   information about and functionality for the current test run.
    /// </summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion

    /// <summary>
    ///   A test for LoadConfiguration
    /// </summary>
    [TestCategory("Not Implemented"), TestMethod, Ignore]
    public void LoadConfigurationTest()
    {
      var dcd = new DataConnectionDialog();
      var dcs = new DataConnectionConfiguration(null);
      dcs.LoadConfiguration(dcd);
      const string systemDataSqlite = "System.Data.SQLite";
      var dataSource = dcd.DataSources.FirstOrDefault(d => d.Name == systemDataSqlite);
      Assert.IsNotNull(dataSource);
      Assert.AreEqual(systemDataSqlite, dataSource.Providers.First().Name);
    }

    [TestProperty("Winforms", "Interactive"), TestMethod, Ignore]
    public void DataConnectionDialogTest()
    {
      var dcd = new DataConnectionDialog();
      var dcs = new DataConnectionConfiguration(null);
      dcs.LoadConfiguration(dcd);
      DataConnectionDialog.Show(dcd);
    }

    [TestProperty("Winforms", "Interactive"), TestMethod, Ignore]
    public void VisualStudioDataConnectionDialogTest()
    {
      var dcs = new DataConnectionConfiguration(null);
      var assembly = Assembly.LoadFile(@"C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\Microsoft.Data.ConnectionUI.Dialog.dll");

      var dataConnectionDialogType = assembly.GetType("Microsoft.Data.ConnectionUI.DataConnectionDialog");
      dynamic dcd = Activator.CreateInstance(dataConnectionDialogType);
      //dynamic dcd = assembly.CreateInstance(dataConnectionDialogType.FullName);
      dynamic dataConnectionDialogTypeDynamic = new StaticMembersDynamicWrapper(dataConnectionDialogType);

      var dataSourceType = assembly.GetType("Microsoft.Data.ConnectionUI.DataSource");
      dynamic dataSourceTypeDynamic = new StaticMembersDynamicWrapper(dataSourceType);

      dataSourceTypeDynamic.AddStandardDataSources(dcd);
      var dataProviderType = assembly.GetType("Microsoft.Data.ConnectionUI.DataProvider");
      AddDataSources(dcd, CreateSQLiteDataSource(dataSourceType, dataProviderType));
      dataConnectionDialogTypeDynamic.Show(dcd);
    }

    [TestMethod]
    public void VisualStudioDataInteropTest()
    {
      //Assembly assembly = Assembly.LoadFile(@"C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\Microsoft.VisualStudio.Data.Interop.dll");

      //dynamic objIVsDataConnectionDialogFactory ;
      //dynamic objIVsDataConnectionDialog ;
      //string sConnectionString = null;
      //object objService = null;

      //objService = GetService(objDTE, typeof(IVsDataConnectionDialogFactory));

      //objIVsDataConnectionDialogFactory = (IVsDataConnectionDialogFactory)objService;

      //objIVsDataConnectionDialog = objIVsDataConnectionDialogFactory.CreateConnectionDialog;

      //objIVsDataConnectionDialog.AddAllSources();

      //if (objIVsDataConnectionDialog.ShowDialog())
      //{
      //  sConnectionString = objIVsDataConnectionDialog.DisplayConnectionString;
      //}

      //objIVsDataConnectionDialog.Dispose();
    }

    public object GetService(object serviceProvider, Type type)
    {
      return GetService(serviceProvider, type.GUID);
    }

    private object GetService(object serviceProvider, Guid guid)
    {
      object objService = null;
      var objIntPtr = default(IntPtr);
      var hr = 0;
      var objSIDGuid = default(Guid);
      var objIIDGuid = default(Guid);

      objSIDGuid = guid;
      objIIDGuid = objSIDGuid;

      dynamic objIServiceProvider = serviceProvider;

      hr = objIServiceProvider.QueryService(objSIDGuid, objIIDGuid, objIntPtr);


      if (hr != 0)
      {
        Marshal.ThrowExceptionForHR(hr);
      }
      else if (!objIntPtr.Equals(IntPtr.Zero))
      {
        objService = Marshal.GetObjectForIUnknown(objIntPtr);
        Marshal.Release(objIntPtr);
      }

      return objService;
    }


    private static void AddDataSources(dynamic dialog, dynamic dataSource)
    {
      if (dataSource != null)
      {
        //var existing = dialog.DataSources.FirstOrDefault(ds => ds.DisplayName == dataSource.DisplayName);
        //if (existing == null)
        //{

        Type x = dialog.DataSources.GetType();
        var methodInfo = x.GetMethod("Add");
        methodInfo.Invoke(dialog.DataSources, new object[] {dataSource});
        //dialog.DataSources.Add(dataSource);
        foreach (var dataProvider in dataSource.Providers)
        {
          Type y = dialog.UnspecifiedDataSource.Providers.GetType();
          var methodInfoy = y.GetMethod("Add");
          methodInfoy.Invoke(dialog.UnspecifiedDataSource.Providers, new object[] {dataProvider});
          //	dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
        }
        //}
        //else
        //{
        //  foreach (var dataProvider in dataSource.Providers)
        //  {
        //    existing.Providers.Add(dataProvider);
        //    dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
        //  }
        //}
      }
    }

    //SQLite Data Provider .Net Framework Data Provider for SQLite System.Data.SQLite 
    private static dynamic CreateSQLiteDataSource(Type dataSourceType, Type dataProviderType)
    {
      return CreateDataSource(dataSourceType, dataProviderType, "System.Data.SQLite", ".NET Framework Data Provider for SQLite", "SQLite Database File",
        ".NET Framework Data Provider for SQLite", @"C:\Program Files (x86)\SQLite.NET\bin\Designer\SQLite.Designer.DLL");
    }

    private static dynamic CreateDataSource(Type dataSourceType, Type dataProviderType, string providerInvariantName, string displayName, string shortDisplayName,
      string description, string designerAssemblyPath)
    {
      try
      {
        //var currentDomain = AppDomain.CurrentDomain;
        //	currentDomain.CreateInstance("SQLite.Designer.DLL", "SQLiteConnectionUIControl");

        var sqLiteDesigner = Assembly.LoadFrom(designerAssemblyPath);
        if (sqLiteDesigner != null)
        {
          var types = sqLiteDesigner.GetTypes();

          var dataConnectionUIControlType = types.FilterByImplements("IDataConnectionUIControl").FirstOrDefault()
                                            ?? sqLiteDesigner.GetType("SQLite.Designer.SQLiteConnectionUIControl");
          var typeSqLiteConnectionProperties = sqLiteDesigner.GetType("SQLite.Designer.SQLiteConnectionProperties");

          var assignable = types.FilterByImplements("IDataConnectionProperties").FirstOrDefault() ?? typeSqLiteConnectionProperties;

          var dbProviderFactory = DbProviderFactories.GetFactory(providerInvariantName);
          var dbConnection = dbProviderFactory.CreateConnection();
          if (dbConnection != null)
          {
            var dataSource2 = CreateDataSource(dataSourceType, dataProviderType, providerInvariantName, displayName, shortDisplayName,
              description, dbConnection.GetType(),
              assignable, dataConnectionUIControlType);
            return dataSource2;
          }
        }
      }
      catch (Exception e)
      {
        GeneralHelper.TraceOut(e.Message);
        return null;
      }
      return null;
    }

    private static dynamic CreateDataSource(Type dataSourceType, Type dataProviderType, string name, string displayName, string shortDisplayName,
      string description, Type targetConnectionType,
      Type connectionPropertiesType, Type dataConnectionUIControlType)
    {
      dynamic dataSource = dataSourceType.Assembly.CreateInstance(dataSourceType.FullName, true,
        BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Public,
        null, new object[] {name, description}, null, null);
      if (dataSource != null)
      {
        var providers = dataSource.Providers;
        var dataProvider = CreateDataProvider(dataProviderType, name, displayName, shortDisplayName, description,
          targetConnectionType, connectionPropertiesType, dataConnectionUIControlType);
        Type x = providers.GetType();
        var methodInfo = x.GetMethod("Add");
        methodInfo.Invoke(providers, new object[] {dataProvider});
      }
      //providers.Add(dataProvider);
      return dataSource;
    }

    private static dynamic CreateDataProvider(Type dataProviderType, string name, string displayName, string shortDisplayName, string description,
      Type targetConnectionType, Type connectionPropertiesType, Type dataConnectionUIControlType)
    {
      var descriptions = new Dictionary<string, string> {{name, description}};

      var uiControls = new Dictionary<string, Type> {{String.Empty, dataConnectionUIControlType}};

      return dataProviderType.Assembly.CreateInstance(dataProviderType.FullName, true,
        BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.Public, null,
        new object[]
        {
          name,
          displayName,
          shortDisplayName,
          description,
          targetConnectionType,
          descriptions,
          uiControls,
          connectionPropertiesType
        }, null, null);
    }
  }
}