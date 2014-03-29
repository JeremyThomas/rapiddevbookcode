﻿using System;
using System.Collections;
using System.Collections.Generic;
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

    public static readonly string[] AdditionalAssemblies = new[]
    {
      "SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll",
      "SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll",
      "AW.Helper.dll", "AW.Helper.LLBL.dll", "System.Windows.Forms.dll",
      "AW.Winforms.Helpers.dll", "AW.Winforms.Helpers.LLBL.dll",
      "AW.LinqPadExtensions.dll"
    };

    public static readonly string[] AdditionalNamespaces = new[]
    {
      "SD.LLBLGen.Pro.ORMSupportClasses",
      "SD.LLBLGen.Pro.LinqSupportClasses",
      "AW.Helper",
      "AW.Helper.LLBL",
      "AW.Winforms.Helpers.DataEditor",
      "AW.Winforms.Helpers.LLBL",
      "AW.LinqPadExtensions",
      "AW.LLBLGen.DataContextDriver",
      "AW.LLBLGen.DataContextDriver.Static"
    };

    #endregion

    static LLBLGenStaticDriver()
    {
      if (IsSupportAssemblyVersionMismatch())
      {
        var driverAssembly = typeof (LLBLGenStaticDriver).Assembly;
        var awHelperLLBLAssembly = typeof (EntityHelper).Assembly;
        var localHelperLLBLAssemblyPath = Path.Combine(Path.GetDirectoryName(driverAssembly.Location), Path.GetFileName(awHelperLLBLAssembly.Location));
        if (File.Exists(localHelperLLBLAssemblyPath))
          Assembly.LoadFrom(localHelperLLBLAssemblyPath);
        //    AW.Helper.LLBL.EntityHelper.
        //AW.Helper.LLBL.EntityHelper.GetDataAccessAdapter(Enumerable.Empty<string>());
      }
    }

    private static bool IsSupportAssemblyVersionMismatch()
    {
      if (_awHelperLLBLAssemblyName == null)
      {
        var entityHelperType = typeof (EntityHelper);
        _awHelperLLBLAssemblyName = entityHelperType.Assembly.GetName();
      }
      if (_awWinformsHelpersLlblAssemblyName == null)
      {
        var lLblWinformHelperType = typeof (LLBLWinformHelper);
        _awWinformsHelpersLlblAssemblyName = lLblWinformHelperType.Assembly.GetName();
      }
      var assemblyVersionMismatch = _awHelperLLBLAssemblyName.Version != _awWinformsHelpersLlblAssemblyName.Version;
      return assemblyVersionMismatch;
    }

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
                                (p.Name.StartsWith("AlreadyFetched") || p.Name.StartsWith("AlwaysFetch")))
                    .Select(p => p.Name));
              }
              options.MembersToExclude = membersToExclude.Distinct().ToArray();
            }
            break;
          case DisplayInGrid.UseEditableGrid:
          case DisplayInGrid.UseEditableGridPaged:
            var toDisplay = objectToDisplay as IEnumerable;
            if (toDisplay != null)
            {
              var pageSize = _howToDisplayInGrid == DisplayInGrid.UseEditableGrid ? (ushort) 0 : LinqPadExtensions.CustomVisualizers.DefaultPageSize;
              try
              {
                CustomVisualizers.DisplayInGrid(toDisplay, pageSize);
              }
              catch (MissingMethodException e)
              {
                if (IsSupportAssemblyVersionMismatch())
                {
                  throw new Exception("Cannot load CustomVisualizers.DisplayInGrid due to Assembly Version Mismatch" 
                    + _awHelperLLBLAssemblyName + " vs "+ _awWinformsHelpersLlblAssemblyName, e);
                }
                throw;
              }

              return;
            }
            break;
        }
      base.DisplayObjectInGrid(objectToDisplay, options);
    }

    private DisplayInGrid _howToDisplayInGrid;

    public override void InitializeContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
    {
      try
      {
        LLBLWinformHelper.ForceInitialization();
        _howToDisplayInGrid = ConnectionDialog.GetHowToDisplayInGrid(cxInfo).GetValueOrDefault(_howToDisplayInGrid);
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
      var dataAccessAdapterBase = LLBLGenDriverHelper.GetAdapter(context);
      if (dataAccessAdapterBase == null) return;
      dataAccessAdapterBase.Dispose();
      LLBLGenDriverHelper.MostRecentAdapter = null;
    }

    // Return the objects with which to populate the Schema Explorer by reflecting over customType.
    // We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
    public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
    {
      try
      {
        MetaDataHelper.AddDirectoryAssemblyResolverIfNeeded(customType.Assembly);
        var usefieldsElement = cxInfo.DriverData.Element(ConnectionDialog.ElementNameUseFields);
        return usefieldsElement != null && usefieldsElement.Value == true.ToString(CultureInfo.InvariantCulture) ? LLBLGenDriverHelper.GetSchemaFromEntities(cxInfo, customType) : LLBLGenDriverHelper.GetSchemaByReflection(customType);
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
    private static AssemblyName _awHelperLLBLAssemblyName;
    private static AssemblyName _awWinformsHelpersLlblAssemblyName;

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
            var adapterToUseProperty = linqMetaData.GetType().GetProperty("AdapterToUse");
            adapterToUseProperty.SetValue(linqMetaData, adapter, null);
          }
          SetSQLTranslationWriter(adapter, executionManager);
        }
      }
    }

    #endregion
  }
}