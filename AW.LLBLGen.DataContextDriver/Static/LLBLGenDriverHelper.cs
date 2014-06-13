using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.LLBL;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
  public static class LLBLGenDriverHelper
  {
    #region Initialization

    static LLBLGenDriverHelper()
    {
      LLBLWinformHelper.GetFormatTypeName += LINQPad.Extensibility.DataContext.DataContextDriver.FormatTypeName;
    }

    private static Assembly LoadAssembly(string assemblyPath)
    {
      return LINQPad.Extensibility.DataContext.DataContextDriver.LoadAssemblySafely(assemblyPath);
    }

    public static DataAccessAdapterBase GetAdapter(object context)
    {
      var linqMetaData = context as ILinqMetaData;
      if (linqMetaData == null)
      {
        var elementCreator = context as IElementCreatorCore;
        if (elementCreator != null)
          return GetAdapter(elementCreator);
      }
      else
        return EntityHelper.GetDataAccessAdapter(linqMetaData) as DataAccessAdapterBase;
      return null;
    }

    internal static DataAccessAdapterBase MostRecentAdapter;

    /// <summary>
    ///   Gets the adapter.
    /// </summary>
    /// <param name="elementCreator">The element creator (ignored).</param>
    /// <returns></returns>
    public static DataAccessAdapterBase GetAdapter(IElementCreatorCore elementCreator)
    {
      return MostRecentAdapter;
    }

    public static DataAccessAdapterBase GetAdapter(IConnectionInfo cxInfo)
    {
      ConnectionDialog.UpGradeDriverDataElements(cxInfo);
      var adapterTypeName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameAdapterType);
      var factoryTypeName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryType);
      if (String.IsNullOrEmpty(adapterTypeName) && String.IsNullOrEmpty(factoryTypeName))
        throw new ApplicationException("CommonDaoBase or adapter not found!");

      var adapterAssemblyPath = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameAdapterAssembly);
      var factoryAssemblyPath = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryAssembly);
      if (!File.Exists(adapterAssemblyPath) && !File.Exists(factoryAssemblyPath))
        throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " not found!" + Environment.NewLine +
                                       "Factory assembly: " + factoryAssemblyPath + " not found!");
      int connectionTypeIndex;
      Assembly dataAccessAdapterAssembly = null;
      Type dataAccessAdapterType = null;
      if (!Int32.TryParse(ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameConnectionType), out connectionTypeIndex))
      {
        dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);
        dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
        connectionTypeIndex = typeof (DataAccessAdapterBase).IsAssignableFrom(dataAccessAdapterType) ? (int) LLBLConnectionType.Adapter : (int) LLBLConnectionType.AdapterFactory;
        cxInfo.DriverData.SetElementValue(ConnectionDialog.ElementNameConnectionType, connectionTypeIndex);
      }
      return GetAdapter(cxInfo, adapterTypeName, factoryTypeName, adapterAssemblyPath, factoryAssemblyPath, dataAccessAdapterAssembly, dataAccessAdapterType, connectionTypeIndex);
    }

    private static DataAccessAdapterBase GetAdapter(IConnectionInfo cxInfo, string adapterTypeName, string factoryTypeName, string adapterAssemblyPath, string factoryAssemblyPath, Assembly dataAccessAdapterAssembly, Type dataAccessAdapterType,
      int connectionTypeIndex)
    {
      DataAccessAdapterBase adapter;
      if (connectionTypeIndex == (int) LLBLConnectionType.Adapter)
      {
        if (dataAccessAdapterAssembly == null)
          dataAccessAdapterAssembly = LoadAssembly(adapterAssemblyPath);
        if (dataAccessAdapterAssembly == null)
          throw new ApplicationException("Adapter assembly: " + adapterAssemblyPath + " could not be loaded!");
        if (dataAccessAdapterType == null)
          dataAccessAdapterType = dataAccessAdapterAssembly.GetType(adapterTypeName);
        if (dataAccessAdapterType == null)
          throw new ApplicationException(String.Format("Adapter type: {0} could not be loaded from: {1}!", adapterTypeName, adapterAssemblyPath));
        if (String.IsNullOrEmpty(cxInfo.DatabaseInfo.CustomCxString))
        {
          adapter = dataAccessAdapterAssembly.CreateInstance(adapterTypeName) as DataAccessAdapterBase;
        }
        else
        {
          if (cxInfo.DatabaseInfo.IsSqlServer)
            adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
            {
              cxInfo.DatabaseInfo.CustomCxString,
              true, CatalogNameUsage.Clear, null
            }) as DataAccessAdapterBase;
          else
          {
            if (cxInfo.DatabaseInfo.CustomCxString.Contains("Oracle"))
              adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
              {
                cxInfo.DatabaseInfo.CustomCxString,
                true, SchemaNameUsage.Default, null
              }) as DataAccessAdapterBase;
            else
              adapter = Activator.CreateInstance(dataAccessAdapterType, new object[]
              {
                cxInfo.DatabaseInfo.CustomCxString
              }) as DataAccessAdapterBase;
          }
        }
      }
      else
      {
        var factoryMethodName = ConnectionDialog.GetDriverDataValue(cxInfo, ConnectionDialog.ElementNameFactoryMethod);
        var factoryAdapterAssembly = LoadAssembly(factoryAssemblyPath);
        if (factoryAdapterAssembly == null)
          throw new ApplicationException("Adapter assembly: " + factoryAssemblyPath + " could not be loaded!");
        if (String.IsNullOrEmpty(factoryTypeName))
          throw new ApplicationException(String.Format("Adapter type was not specified!"));
        var factoryType = factoryAdapterAssembly.GetType(factoryTypeName);
        if (factoryType == null)
          throw new ApplicationException(String.Format("Adapter type: {0} could not be loaded from: {1}!", factoryTypeName, factoryAssemblyPath));
        var fullListQueryMethod = factoryType.GetMethod(factoryMethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new[] {typeof (string)}, null);
        if (fullListQueryMethod == null)
        {
          GeneralHelper.TraceOut(factoryMethodName + " not found");
          adapter = null;
        }
        else
          try
          {
            adapter = fullListQueryMethod.Invoke(null, BindingFlags.InvokeMethod, null, new object[] {cxInfo.DatabaseInfo.CustomCxString}, null) as DataAccessAdapterBase;
          }
          catch (TargetInvocationException invocationException)
          {
            GeneralHelper.ThrowInnerException(invocationException);
            throw;
          }
      }
      return adapter;
    }

    #endregion

    #region Schema helpers

    private static ExplorerItemKind GetExplorerItemKind(ExplorerIcon explorerIcon)
    {
      switch (explorerIcon)
      {
        case ExplorerIcon.Schema:
          return ExplorerItemKind.Schema;
        case ExplorerIcon.Table:
          return ExplorerItemKind.QueryableObject;
        case ExplorerIcon.View:
          break;
        case ExplorerIcon.Column:
          return ExplorerItemKind.Property;
        case ExplorerIcon.Key:
          break;
        case ExplorerIcon.StoredProc:
          break;
        case ExplorerIcon.ScalarFunction:
          break;
        case ExplorerIcon.TableFunction:
          break;
        case ExplorerIcon.Parameter:
          break;
        case ExplorerIcon.ManyToOne:
        case ExplorerIcon.OneToOne:
          return ExplorerItemKind.ReferenceLink;
        case ExplorerIcon.OneToMany:
        case ExplorerIcon.ManyToMany:
          return ExplorerItemKind.CollectionLink;
        case ExplorerIcon.Inherited:
          break;
        case ExplorerIcon.LinkedDatabase:
          break;
        case ExplorerIcon.Box:
          break;
        default:
          throw new ArgumentOutOfRangeException("explorerIcon");
      }
      return ExplorerItemKind.CollectionLink;
    }

    #region Entities

    internal static List<ExplorerItem> GetSchemaFromEntities(IConnectionInfo cxInfo, Type customType, bool useSchema = true,
      IEnumerable<string> tablePrefixesToGroupBy = null, string prefixDelimiter = null)
    {
      var elementCreator = EntityHelper.CreateElementCreator(customType);
      var adapter = GetDataAccessAdapter(cxInfo, elementCreator is IElementCreator2);

      var topLevelProps = (from type in EntityHelper.GetEntitiesTypes(customType.Assembly)
        let entity = LinqUtils.CreateEntityInstanceFromEntityType(type, elementCreator)
        let name = EntityHelper.GetNameFromEntity(entity)
        orderby name
        select CreateTableExplorerItem(entity, name, adapter)
        ).ToList<ExplorerItem>();

      // Create a lookup keying each element type to the properties of that type. This will allow
      // us to build hyperlink targets allowing the user to click between associations:
      var elementTypeLookup = topLevelProps.ToLookup(tp => tp.Tag.GetType());

      var schemas = new Dictionary<string, ExplorerItem>();
      var prefixesAsSchemas = new Dictionary<string, ExplorerItem>();

      //Copy ToolTipText from base type fields
      foreach (var table in topLevelProps)
      {
        var entity = (IEntityCore) table.Tag;
        if (useSchema)
        {
          if (!String.IsNullOrWhiteSpace(table.SqlTypeDeclaration))
          {
            var schema = table.SqlTypeDeclaration;
            ExplorerItem value;
            if (schemas.TryGetValue(schema, out value))
            {
              if (!AddWithPrefixDelimiter(prefixDelimiter, table, value))
                value.Children.Add(table);
            }
            else
            {
              var explorerItem = new ExplorerItem(schema, ExplorerItemKind.Schema, ExplorerIcon.Schema);
              schemas.Add(schema, explorerItem);
              explorerItem.Children = new List<ExplorerItem>();
              if (!AddWithPrefixDelimiter(prefixDelimiter, table, explorerItem))
                explorerItem.Children.Add(table);
            }
          }
        }
        else if (!tablePrefixesToGroupBy.IsNullOrEmpty() && !String.IsNullOrWhiteSpace(table.SqlName))
        {
          var prefixMatch = false;
          if (tablePrefixesToGroupBy != null)
          {
            var table1 = table;
            foreach (var prefix in tablePrefixesToGroupBy.Where(prefix => table1.SqlName.StartsWith(prefix, true, null)))
            {
              ExplorerItem value;
              if (prefixesAsSchemas.TryGetValue(prefix, out value))
                value.Children.Add(table);
              else
              {
                var explorerItem = new ExplorerItem(prefix, ExplorerItemKind.Schema, ExplorerIcon.Schema);
                prefixesAsSchemas.Add(prefix, explorerItem);
                explorerItem.Children = new List<ExplorerItem> {table};
              }
              prefixMatch = true;
              break;
            }
          }
          if (!prefixMatch)
            prefixesAsSchemas.Add(table.SqlName + table.Text, table);
        }
        else AddWithPrefixDelimiter(prefixDelimiter, table, prefixesAsSchemas);
        table.SqlTypeDeclaration = String.Empty;

        if (entity.LLBLGenProIsInHierarchyOfType != InheritanceHierarchyType.None)
        {
          var baseType = entity.GetType().BaseType;
          if (baseType != null)
          {
            var explorerItems = elementTypeLookup[baseType];
            var baseItem = explorerItems.SingleOrDefault();
            if (baseItem != null)
            {
              table.Text += String.Format(" (Sub-type of '{0}')", baseItem.DragText);
              foreach (var explorerItem in baseItem.Children)
              {
                var item = table.Children.Single(c => c.Text == explorerItem.Text);
                if (explorerItem.ToolTipText.Contains(item.ToolTipText))
                  item.ToolTipText = explorerItem.ToolTipText;
                if (item.Icon == ExplorerIcon.Column)
                  item.Icon = ExplorerIcon.Inherited;
              }
            }
          }
        }
      }

      // Populate the columns (properties) of each entity:
      foreach (var table in topLevelProps)
      {
        var entity = (IEntityCore) table.Tag;
        try
        {
          var navigatorExplorerItems = EntityHelper.GetNavigatorProperties(entity).Select(navigatorProperty => CreateNavigatorExplorerItem(entity, navigatorProperty, elementTypeLookup))
            .Where(ei => ei != null).OrderBy(ei => ei.Icon).ThenBy(ei => ei.Text).ToList();
          table.Children.AddRange(navigatorExplorerItems);
        }
        catch (Exception e)
        {
          LogException(e);
        }
        table.Tag = null;
      }

      if (useSchema && schemas.Count > 1)
        return schemas.Values.ToList();
      if (prefixesAsSchemas.Any())
        return prefixesAsSchemas.Values.ToList();
      return topLevelProps;
    }

    private static bool AddWithPrefixDelimiter(string prefixDelimiter, ExplorerItem table, Dictionary<string, ExplorerItem> prefixesAsSchemas)
    {
      if (!String.IsNullOrWhiteSpace(prefixDelimiter) && !String.IsNullOrWhiteSpace(table.SqlName))
      {
        var prefix = table.SqlName.Before(prefixDelimiter);
        if (String.IsNullOrWhiteSpace(prefix))
          prefixesAsSchemas.Add(table.SqlName + table.Text, table);
        else
        {
          ExplorerItem value;
          if (prefixesAsSchemas.TryGetValue(prefix, out value))
            value.Children.Add(table);
          else
          {
            var explorerItem = new ExplorerItem(prefix, ExplorerItemKind.Schema, ExplorerIcon.Schema);
            prefixesAsSchemas.Add(prefix, explorerItem);
            explorerItem.Children = new List<ExplorerItem> {table};
          }
        }
        return true;
      }
      return false;
    }

    private static bool AddWithPrefixDelimiter(string prefixDelimiter, ExplorerItem table, ExplorerItem schema)
    {
      if (!String.IsNullOrWhiteSpace(prefixDelimiter) && !String.IsNullOrWhiteSpace(table.SqlName))
      {
        var prefix = table.SqlName.Before(prefixDelimiter);
        if (String.IsNullOrWhiteSpace(prefix))
          schema.Children.Add(table);
        else
        {
          var explorerPrefixItem = schema.Children.FirstOrDefault(p => p.Text == prefix);
          if (explorerPrefixItem != null)
            explorerPrefixItem.Children.Add(table);
          else
          {
            var explorerItem = new ExplorerItem(prefix, ExplorerItemKind.Schema, ExplorerIcon.Schema);
            schema.Children.Add(explorerItem);
            explorerItem.Children = new List<ExplorerItem> {table};
          }
        }
        return true;
      }
      return false;
    }

    private static DataAccessAdapterBase GetDataAccessAdapter(IConnectionInfo cxInfo, bool isAdapter)
    {
      if (isAdapter)
        try
        {
          return GetAdapter(cxInfo);
        }
        catch (Exception e)
        {
          LogException(e);
        }
      return null;
    }

    public static void LogException(this Exception e)
    {
      e.TraceOut();
      LogExceptionInLinqPad(e);
    }

    private static MethodInfo _writeMethodInfo;

    private static void LogExceptionInLinqPad(Exception e)
    {
      if (_writeMethodInfo == null)
      {
        var logType = typeof (IConnectionInfo).Assembly.GetType("LINQPad.Log");
        if (logType != null)
          _writeMethodInfo = logType.GetMethod("Write", BindingFlags.Public | BindingFlags.Static, null, new[] {typeof (Exception)}, null);
      }
      if (_writeMethodInfo != null)
        _writeMethodInfo.Invoke(null, BindingFlags.InvokeMethod, null, new object[] {e}, null);
    }

    private static ExplorerItem CreateTableExplorerItem(IEntityCore entity, string name, IDataAccessAdapter adapter)
    {
      MetaDataHelper.AddAssociatedMetadataProvider(entity.GetType());
      var tableExplorerItem = new ExplorerItem(name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
      {
        IsEnumerable = true,
        DragText = name,
        // Store the entity to the Tag property. We'll use it later.
        Tag = entity
      };

      tableExplorerItem.Children = CreateFieldExplorerItems(tableExplorerItem, adapter);
      return tableExplorerItem;
    }

    private static List<ExplorerItem> CreateFieldExplorerItems(ExplorerItem explorerItem, IDataAccessAdapter adapter)
    {
      var entity = (IEntityCore) explorerItem.Tag;

      IFieldPersistenceInfo fieldPersistenceInfo = null;

      var propertyDescriptors = Enumerable.Empty<PropertyDescriptor>();
      try
      {
        propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(entity.GetType());
      }
      catch (Exception e)
      {
        LogException(e);
      }
      var fieldExplorerItems = new List<ExplorerItem>();

      foreach (var field in entity.GetFields().Where(f => f.Name.Equals(f.Alias)).OrderBy(f => f.Name))
      {
        var fkNavigator = field.IsForeignKey ? "Navigator: " + EntityHelper.GetNavigatorNames(entity, field.Name).JoinAsString() : "";
        fieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfoSafely(field, adapter);
        fieldExplorerItems.Add(new ExplorerItem(LLBLWinformHelper.CreateFieldText(field), ExplorerItemKind.Property, field.IsPrimaryKey ? ExplorerIcon.Key : ExplorerIcon.Column)
        {
          DragText = field.Name,
          SqlName = fieldPersistenceInfo == null ? null : fieldPersistenceInfo.SourceColumnName,
          SqlTypeDeclaration = fieldPersistenceInfo == null ? null : fieldPersistenceInfo.SourceColumnDbType,
          ToolTipText = LLBLWinformHelper.CreateFieldToolTipText(entity, fieldPersistenceInfo, propertyDescriptors.GetFieldPropertyDescriptor(field.Name), fkNavigator)
        });
      }

      explorerItem.ToolTipText = LLBLWinformHelper.CreateTableToolTipText(entity, fieldPersistenceInfo);
      if (fieldPersistenceInfo != null)
      {
        explorerItem.SqlTypeDeclaration = fieldPersistenceInfo.SourceSchemaName;
        explorerItem.SqlName = fieldPersistenceInfo.SourceObjectName;
      }
      return fieldExplorerItems;
    }

    private static ExplorerItem CreateNavigatorExplorerItem(IEntityCore entity, PropertyDescriptor navigatorProperty, ILookup<Type, ExplorerItem> elementTypeLookup)
    {
      var elementType = MetaDataHelper.GetElementType(navigatorProperty.PropertyType);
      var explorerItems = elementTypeLookup[elementType];
      var hyperlinkTarget = explorerItems.SingleOrDefault();
      if (hyperlinkTarget == null)
      {
        GeneralHelper.TraceOut(GeneralHelper.Join(GeneralHelper.StringJoinSeparator, entity.LLBLGenProEntityName, navigatorProperty.Name, navigatorProperty.DisplayName, navigatorProperty.Description));
        return null;
      }
      var explorerIcon = GetExplorerIcon(entity, navigatorProperty.Name);
      var explorerItemKind = GetExplorerItemKind(explorerIcon);
      return new ExplorerItem(navigatorProperty.Name, explorerItemKind, explorerIcon)
      {
        DragText = navigatorProperty.Name,
        HyperlinkTarget = hyperlinkTarget,
        ToolTipText = CreateNavigatorToolTipText(entity, navigatorProperty, hyperlinkTarget),
      };
    }

    private static ExplorerIcon GetExplorerIcon(IEntityCore entity, string fieldName)
    {
      var relationsForFieldOfType = entity.GetRelationsForFieldOfType(fieldName);
      if (relationsForFieldOfType.Count > 1)
        return ExplorerIcon.ManyToMany;
      var entityRelation = relationsForFieldOfType[0] as IEntityRelation;
      return entityRelation == null ? ExplorerIcon.OneToMany : GetExplorerIcon(entityRelation.TypeOfRelation);
    }

    private static ExplorerIcon GetExplorerIcon(RelationType typeOfRelation)
    {
      switch (typeOfRelation)
      {
        case RelationType.OneToMany:
          return ExplorerIcon.OneToMany;
        case RelationType.OneToOne:
          return ExplorerIcon.OneToOne;
        case RelationType.ManyToOne:
          return ExplorerIcon.ManyToOne;
        case RelationType.ManyToMany:
          return ExplorerIcon.ManyToMany;
        default:
          throw new ArgumentOutOfRangeException("typeOfRelation");
      }
    }

    private static string CreateNavigatorToolTipText(IEntityCore entity, PropertyDescriptor navigatorProperty, ExplorerItem hyperlinkTarget)
    {
      return LLBLWinformHelper.CreateNavigatorToolTipText(entity, navigatorProperty, hyperlinkTarget.ToolTipText);
    }

    #endregion

    #region Reflection

    internal static List<ExplorerItem> GetSchemaByReflection(Type customType)
    {
      List<ExplorerItem> topLevelProps;
      if (typeof (IElementCreatorCore).IsAssignableFrom(customType))
      {
        topLevelProps = (from type in EntityHelper.GetEntitiesTypes(customType.Assembly)
          let name = EntityHelper.GetNameFromEntityName(type.Name)
          orderby name
          select CreateTableExplorerItem(name, type)
          ).ToList();
      }
      else
        topLevelProps = (from prop in MetaDataHelper.GetPropertyDescriptors(customType)
          let elementType = MetaDataHelper.GetElementType(prop.PropertyType)
          where typeof (IEntityCore).IsAssignableFrom(elementType)
          orderby prop.Name
          select CreateTableExplorerItem(prop.Name, elementType)
          ).ToList();

      // Create a lookup keying each element type to the properties of that type. This will allow
      // us to build hyperlink targets allowing the user to click between associations:
      var elementTypeLookup = topLevelProps.ToLookup(tp => (Type) tp.Tag);

      // Populate the columns (properties) of each entity:
      foreach (var table in topLevelProps)
        table.Children = CreateFieldExplorerItems(GetPropertiesToShowInSchema((Type) table.Tag), elementTypeLookup);

      return topLevelProps;
    }

    private static ExplorerItem CreateTableExplorerItem(string propertName, Type elementType)
    {
      MetaDataHelper.AddAssociatedMetadataProvider(elementType);
      return new ExplorerItem(propertName, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
      {
        IsEnumerable = true,
        ToolTipText = GeneralHelper.Join(Environment.NewLine, LINQPad.Extensibility.DataContext.DataContextDriver.FormatTypeName(elementType, true),
          MetaDataHelper.GetDisplayNameAttributes(elementType).Select(da => da.DisplayName)
            .Union(MetaDataHelper.GetDescriptionAttributes(elementType).Select(da => da.Description)).JoinAsString()),
        DragText = propertName,
        // Store the entity type to the Tag property. We'll use it later.
        Tag = elementType
      };
    }

    private static List<ExplorerItem> CreateFieldExplorerItems(IEnumerable<PropertyDescriptor> fieldsToShowInSchema, ILookup<Type, ExplorerItem> elementTypeLookup)
    {
      if (fieldsToShowInSchema != null)
        return fieldsToShowInSchema
          .Select(childProp => GetChildItem(elementTypeLookup, childProp))
          .OrderBy(childItem => childItem.Kind)
          .ToList();
      return null;
    }

    /// <summary>
    ///   Gets the properties to show in schema.
    ///   They should be all the browsable properties with the addition of self servicing entity properties.
    /// </summary>
    /// <remarks>
    ///   See MetaDataHelper.GetPropertiesToDisplay
    /// </remarks>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    internal static IEnumerable<PropertyDescriptor> GetPropertiesToShowInSchema(Type type)
    {
      return ListBindingHelper.GetListItemProperties(type).AsEnumerable().Union(EntityHelper.GetPropertiesOfTypeEntity(type));
    }

    private static ExplorerItem GetChildItem(ILookup<Type, ExplorerItem> elementTypeLookup, PropertyDescriptor childProp)
    {
      // If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
      // We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
      var explorerItem = CreateEntityExplorerItem(childProp, elementTypeLookup, childProp.PropertyType, ExplorerItemKind.ReferenceLink, ExplorerIcon.ManyToOne);
      if (explorerItem == null)
      {
        // Is the property's type a collection of entities?
        var elementType = MetaDataHelper.GetElementType(childProp.PropertyType);
        if (elementType != childProp.PropertyType)
          explorerItem = CreateEntityExplorerItem(childProp, elementTypeLookup, elementType, ExplorerItemKind.CollectionLink, ExplorerIcon.OneToMany);
      }

      if (explorerItem == null)
        // Ordinary property:
        return new ExplorerItem(childProp.Name + " (" + LINQPad.Extensibility.DataContext.DataContextDriver.FormatTypeName(childProp.PropertyType, false) + ")",
          ExplorerItemKind.Property, ExplorerIcon.Column)
        {
          DragText = childProp.Name,
          ToolTipText = LLBLWinformHelper.CreateDisplayNameDescriptionToolTipText(childProp)
        };
      return explorerItem;
    }

    private static ExplorerItem CreateEntityExplorerItem(PropertyDescriptor childProp, ILookup<Type, ExplorerItem> elementTypeLookup, Type elementType, ExplorerItemKind kind, ExplorerIcon icon)
    {
      return elementTypeLookup.Contains(elementType)
        ? CreateEntityExplorerItem2(childProp, elementTypeLookup, elementType, kind, icon)
        : null;
    }

    private static ExplorerItem CreateEntityExplorerItem2(PropertyDescriptor childProp, ILookup<Type, ExplorerItem> elementTypeLookup, Type elementType, ExplorerItemKind kind, ExplorerIcon icon)
    {
      var hyperlinkTarget = elementTypeLookup[elementType].First();
      var toolTipText = LLBLWinformHelper.CreateDisplayNameDescriptionToolTipText(childProp);
      var targetTipText = hyperlinkTarget.ToolTipText;
      if (typeof (IEnumerable).IsAssignableFrom(childProp.PropertyType))
      {
        if (childProp.PropertyType.IsGenericType)
        {
          if (elementType.FullName != null)
            targetTipText = targetTipText.Replace(elementType.FullName, "").Trim();
        }
        toolTipText = GeneralHelper.Join(Environment.NewLine, toolTipText, LINQPad.Extensibility.DataContext.DataContextDriver.FormatTypeName(childProp.PropertyType, true), targetTipText);
      }
      else
      {
        toolTipText = targetTipText.Contains(toolTipText) ? targetTipText : GeneralHelper.Join(Environment.NewLine, toolTipText, targetTipText);
      }
      return new ExplorerItem(childProp.Name, kind, icon)
      {
        HyperlinkTarget = hyperlinkTarget,
        ToolTipText = toolTipText,
        DragText = childProp.Name
      };
    }

    #endregion

    #endregion
  }
}