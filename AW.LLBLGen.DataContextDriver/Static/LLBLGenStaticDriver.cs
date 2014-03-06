using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LLBLGen.DataContextDriver.Properties;
using AW.Winforms.Helpers.LLBL;
using LINQPad;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
  /// <summary>
  ///   This static driver let users query any data source that looks like a Data Context - in other words, that exposes
  ///   properties of type IEnumerable of T.
  /// </summary>
  public class LLBLGenStaticDriver : StaticDataContextDriver
  {
    #region Constants

    public static readonly string[] AdditionalAssemblies =
    {
      "SD.LLBLGen.Pro.ORMSupportClasses.dll",
      "AW.Helper.dll", "AW.Helper.LLBL.dll", "System.Windows.Forms.dll",
      "AW.Winforms.Helpers.dll", "AW.Winforms.Helpers.LLBL.dll",
      "AW.LinqPadExtensions.dll"
    };

    public static readonly string[] AdditionalNamespaces =
    {
      "SD.LLBLGen.Pro.ORMSupportClasses",
      "AW.Helper",
      "AW.Helper.LLBL",
      "AW.Winforms.Helpers.DataEditor",
      "AW.Winforms.Helpers.LLBL",
      "AW.LinqPadExtensions",
      "AW.LLBLGen.DataContextDriver",
      "AW.LLBLGen.DataContextDriver.Static",
      "LLBLGen.Linq.Prefetch"
    };

    #endregion

    #region Overrides of DataContextDriver

    public override string Name
    {
      get { return Constants.DriverName; }
    }

    public override string Author
    {
      get { return Constants.Author; }
    }

    public override string GetConnectionDescription(IConnectionInfo cxInfo)
    {
      // For static drivers, we can use the description of the custom type & its assembly:
      return new[] {cxInfo.CustomTypeInfo.CustomTypeName, cxInfo.DatabaseInfo.GetDatabaseDescription(), cxInfo.AppConfigPath}.JoinAsString(" - ");
    }

    public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
    {
      // Prompt the user for a custom assembly and type name:
      try
      {
        return new ConnectionDialog(cxInfo, isNewConnection).ShowDialog() == true;
      }
      catch (Exception e)
      {
        GeneralHelper.TraceOut(e.Message);
        Application.OnThreadException(e);
      }
      return true;
    }

    //public override bool AreRepositoriesEquivalent(IConnectionInfo c1, IConnectionInfo c2)
    //{
    //  return base.AreRepositoriesEquivalent(c1, c2);
    //}

    public override IEnumerable<string> GetAssembliesToAdd(IConnectionInfo cxInfo)
    {
      var globalAdditionalAssemblies = Settings.Default.AdditionalAssemblies.AsEnumerable() ?? GeneralHelper.GetStringCollection(
        "DataContextDriver__AW.LLB_", "ShowConnectionDialog_for__", "AdditionalAssemblies") ?? Enumerable.Empty<string>();
      var cnxtAdditionalAssemblies = ConnectionDialog.GetDriverDataStringValues(cxInfo, ConnectionDialog.ElementNameAdditionalAssemblies);
      return AdditionalAssemblies.Union(globalAdditionalAssemblies).Union(cnxtAdditionalAssemblies).Union(ConnectionDialog.GetAdapterAssemblies(cxInfo));
    }

    /// <summary>
    ///   Gets the namespaces to add.
    /// </summary>
    /// <param name="cxInfo">The cx info.</param>
    /// <returns></returns>
    public override IEnumerable<string> GetNamespacesToAdd(IConnectionInfo cxInfo)
    {
      var globalAdditionalNamespaces = (Settings.Default.AdditionalNamespaces.AsEnumerable() ?? GeneralHelper.GetStringCollection(
        "DataContextDriver__AW.LLB_", "ShowConnectionDialog_for__", "AdditionalNamespaces")) ?? Enumerable.Empty<string>();

      var cnxtAdditionalNamespaces = ConnectionDialog.GetDriverDataStringValues(cxInfo, ConnectionDialog.ElementNameAdditionalNamespaces);
      return AdditionalNamespaces.Union(globalAdditionalNamespaces).Union(cnxtAdditionalNamespaces);
    }

    public override IEnumerable<string> GetNamespacesToRemove(IConnectionInfo cxInfo)
    {
      return new[] {"System.Data.Linq", "System.Data.SqlClient", "System.Data.Linq.SqlClient"};
    }

    /// <summary>
    ///   Gets the custom display member provider.
    /// </summary>
    /// <param name="objectToWrite"> The object to write. </param>
    /// <returns> </returns>
    public override ICustomMemberProvider GetCustomDisplayMemberProvider(object objectToWrite)
    {
      return LLBLMemberProvider.CreateCustomDisplayMemberProviderIfNeeded(objectToWrite);
    }

    /// <summary>
    ///   Displays the object in grid.
    /// </summary>
    /// <param name="objectToDisplay"> The object to display. </param>
    /// <param name="options"> The options. </param>
    /// <remarks>
    ///   From http://llblgenlinqpad.codeplex.com
    /// </remarks>
    public override void DisplayObjectInGrid(object objectToDisplay, GridOptions options)
    {
      if (objectToDisplay != null)
        switch (_howToDisplayInGrid)
        {
          case DisplayInGrid.ExcludeEntityBaseProperties:
            var elementType = LinqUtils.DetermineSetElementType(objectToDisplay.GetType());
            options.MembersToExclude = GetEntityBaseProperties(elementType).Union(_membersToExclude).ToArray();
            break;
          case DisplayInGrid.UseEditableGrid:
          case DisplayInGrid.UseEditableGridPaged:
            var toDisplay = objectToDisplay as IEnumerable;
            if (toDisplay == null)
            {
              var dataTable = objectToDisplay as DataTable;
              if (dataTable != null) toDisplay = dataTable.DefaultView;
            }
            if (toDisplay != null)
            {
              options.MembersToExclude = GetEntityBaseProperties(MetaDataHelper.GetObjectTypeorEnumerableItemType(objectToDisplay)).Union(_membersToExclude).ToArray();
              CustomVisualizers.DisplayInGrid(toDisplay, _howToDisplayInGrid == DisplayInGrid.UseEditableGrid ? (ushort)0 : LinqPadExtensions.CustomVisualizers.DefaultPageSize, options.MembersToExclude);
              return;
            }
            break;
        }
      base.DisplayObjectInGrid(objectToDisplay, options);
    }

    private static IEnumerable<string> GetEntityBaseProperties(Type elementType)
    {
      if (typeof (IEntityCore).IsAssignableFrom(elementType))
      {
        var membersToExclude = typeof (EntityBase).GetProperties().Select(p => p.Name)
          .Union(typeof (EntityBase2).GetProperties().Select(p => p.Name)).Distinct();
        if (typeof (IEntity).IsAssignableFrom(elementType))
        {
          // remove alwaysFetch/AlreadyFetched flag properties
          membersToExclude = membersToExclude
            .Union(elementType.GetProperties()
              .Where(p => p.PropertyType == typeof (bool) &&
                          (p.Name.StartsWith("AlreadyFetched") || p.Name.StartsWith("AlwaysFetch") || p.Name.EndsWith("NewIfNotFound")))
              .Select(p => p.Name));
        }
        return membersToExclude.Distinct();
      }
      return Enumerable.Empty<string>();
    }

    private DisplayInGrid _howToDisplayInGrid;

    public override void InitializeContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
    {
      try
      {
        LLBLWinformHelper.ForceInitialization();
        _howToDisplayInGrid = ConnectionDialog.GetHowToDisplayInGrid(cxInfo).GetValueOrDefault(_howToDisplayInGrid);
       _membersToExclude = ConnectionDialog.GetMembersToExclude(cxInfo);
        var baseType = context.GetType().BaseType;
        if (baseType != null)
        {
          var assembly = baseType.Assembly;
          //baseType.GetProperty("AdapterToUse")
          var type = assembly.GetTypes().SingleOrDefault(t => t.Name.Contains("CommonDaoBase") && t.IsClass);
          if (type == null)
          {
            InitializeAdapter(cxInfo, context, executionManager);
          }
          else
          {
            InitializeSelfservicing(cxInfo, type, context, executionManager);
          }
        }
      }
      catch (Exception e)
      {
        GeneralHelper.TraceOut(e);
      }
    }

    public override void TearDownContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager, object[] constructorArguments)
    {
      base.TearDownContext(cxInfo, context, executionManager, constructorArguments);
      DisposeAdapter(context);
    }
    
    private static void DisposeAdapter(object context)
    {
      var dataAccessAdapterBase = LLBLGenDriverHelper.GetAdapter(context);
      if (dataAccessAdapterBase == null) return;
      dataAccessAdapterBase.Dispose();
      LLBLGenDriverHelper.MostRecentAdapter = null;
    }

    public override void ClearConnectionPools(IConnectionInfo cxInfo)
    {
      if (LLBLGenDriverHelper.MostRecentAdapter != null)
      {
        LLBLGenDriverHelper.MostRecentAdapter.Dispose();
        LLBLGenDriverHelper.MostRecentAdapter = null;
      }
      base.ClearConnectionPools(cxInfo);
    }

    public override IDbConnection GetIDbConnection(IConnectionInfo cxInfo)
    {
      LLBLWinformHelper.ForceInitialization();
      _howToDisplayInGrid = ConnectionDialog.GetHowToDisplayInGrid(cxInfo).GetValueOrDefault(_howToDisplayInGrid);
      _membersToExclude = ConnectionDialog.GetMembersToExclude(cxInfo);
      return base.GetIDbConnection(cxInfo);
    }

    // Return the objects with which to populate the Schema Explorer by reflecting over customType.
    // We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
    public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
    {
      try
      {
        if (customType == null)
          throw new ArgumentNullException("customType");
        MetaDataHelper.AddDirectoryAssemblyResolverIfNeeded(customType.Assembly);
        var usefieldsElement = ConnectionDialog.GetDriverDataBooleanValue(cxInfo, ConnectionDialog.ElementNameUseFields);
        return usefieldsElement ? LLBLGenDriverHelper.GetSchemaFromEntities(cxInfo, customType,
          ConnectionDialog.GetDriverDataBooleanValue(cxInfo, ConnectionDialog.ElementNameMembersUseSchema),
          ConnectionDialog.GetDriverDataStringValues(cxInfo, ConnectionDialog.ElementNameMembersTablePrefixesToGroupBy),
          ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameMembersTablePrefixDelimiterToGroupBy)) : LLBLGenDriverHelper.GetSchemaByReflection(customType);
      }
      catch (Exception e)
      {
        var innerMostException = GeneralHelper.TraceOut(e);
        Application.OnThreadException(innerMostException);
        if (e == innerMostException)
          throw;
        throw innerMostException;
      }
    }

    #endregion

    #region SQLTranslationWriter

    private void SetSQLTranslationWriter(Type typeBeingTraced, QueryExecutionManager executionManager)
    {
      SetSQLTranslationWriter(typeBeingTraced, null, executionManager);
    }

    private void SetSQLTranslationWriter(DataAccessAdapterBase adapter, QueryExecutionManager executionManager)
    {
      SetSQLTranslationWriter(adapter.GetType(), adapter, executionManager);
    }

    private void SetSQLTranslationWriter(Type typeBeingTraced, object objectBeingTraced, QueryExecutionManager executionManager)
    {
      if (executionManager != null)
      {
        var eventInfo = typeBeingTraced.GetEvent(SQLTraceEventArgs.SqlTraceEventName);
        if (eventInfo == null)
          ORMQueryExecutionListener.AddORMQueryExecutionListener(executionManager);
        else
          try
          {
            SubscribeToSqlTraceEvent(objectBeingTraced, eventInfo, executionManager.SqlTranslationWriter);
          }
          catch (Exception e)
          {
            GeneralHelper.TraceOut(e.Message);
          }
      }
    }

    public void SubscribeToSqlTraceEvent(object objectBeingTraced, EventInfo eventInfo, TextWriter sqlTranslationWriter)
    {
      _sqlTranslationWriter = sqlTranslationWriter;
      //EventHandler<EventArgs> handler = (sender, e) => SQLTraceEventArgs.WriteSQLTranslation(_sqlTranslationWriter, e);
      //var handler = new Action<object, EventArgs>((sender, e) => SQLTraceEventArgs.WriteSQLTranslation(_sqlTranslationWriter, e));
      //var typedDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, _sqlTranslationWriter, handler.Method);

      var typedDelegate = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, HandlerSQLTraceEvent);
      eventInfo.AddEventHandler(objectBeingTraced, typedDelegate);
    }

    private static readonly MethodInfo HandlerSQLTraceEvent = MetaDataHelper.GetMethodInfo<LLBLGenStaticDriver>(x => x.SQLTraceEventHandler(null, null));
    private TextWriter _sqlTranslationWriter;
    private IEnumerable<string> _membersToExclude = Enumerable.Empty<string>();

    private void SQLTraceEventHandler(object sender, EventArgs e)
    {
      SQLTraceEventArgs.WriteSQLTranslation(_sqlTranslationWriter, e);
    }

    #endregion

    #region Initialization

    private void InitializeSelfservicing(IConnectionInfo cxInfo, Type commonDaoBaseType, object context, QueryExecutionManager executionManager)
    {
      var actualConnectionStringField = commonDaoBaseType.GetField("ActualConnectionString");
      //var actualConnectionString = actualConnectionStringField.GetValue(context) as string;
      if (!string.IsNullOrEmpty(cxInfo.DatabaseInfo.CustomCxString)) //CustomCxString overrides config value
        actualConnectionStringField.SetValue(context, cxInfo.DatabaseInfo.CustomCxString);
      SetSQLTranslationWriter(commonDaoBaseType, executionManager);
    }

    private void InitializeAdapter(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
    {
      var linqMetaData = context as ILinqMetaData;
      if (linqMetaData == null && !(context is IElementCreatorCore))
      {
        var type = context.GetType();
        type = type.BaseType ?? type;
        GeneralHelper.TraceOut(type.AssemblyQualifiedName + Environment.NewLine + "is not a" + Environment.NewLine + typeof (ILinqMetaData).AssemblyQualifiedName);
      }
      else
      {
        var adapter = LLBLGenDriverHelper.GetAdapter(cxInfo);
        if (adapter != null)
        {
          if (linqMetaData == null)
            LLBLGenDriverHelper.MostRecentAdapter = adapter;
          else
          {
            dynamic linqMetaDataDynamic = linqMetaData;
            linqMetaDataDynamic.AdapterToUse = adapter;
            var functionMappingStoreMember = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.FunctionMappingStoreMember);
            if (!string.IsNullOrWhiteSpace(functionMappingStoreMember))
            {
              var adapterType = adapter.GetType();
              var propinfo = adapterType.GetProperty(functionMappingStoreMember, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
              if (propinfo != null)
                linqMetaDataDynamic.CustomFunctionMappings = (FunctionMappingStore)propinfo.GetValue(adapter, null);
              var methodInfo = adapterType.GetMethod(functionMappingStoreMember);
              if (methodInfo != null)
                linqMetaDataDynamic.CustomFunctionMappings = (FunctionMappingStore)methodInfo.Invoke(adapter, BindingFlags.InvokeMethod, null, null, null);
              var fieldInfo = adapterType.GetField(functionMappingStoreMember, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
              if (fieldInfo != null)
                linqMetaDataDynamic.CustomFunctionMappings = (FunctionMappingStore)fieldInfo.GetValue(adapter);
            }
          }
          SetSQLTranslationWriter(adapter, executionManager);
        }
      }
    }

    #endregion
  }
}