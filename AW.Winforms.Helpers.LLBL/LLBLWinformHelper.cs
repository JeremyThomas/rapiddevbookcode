using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public static class LLBLWinformHelper
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    static LLBLWinformHelper()
    {
      BindingListHelper.RegisterbindingListViewCreater(typeof (IEntityCore), EntityHelper.CreateEntityView);
      BindingListHelper.RegisterBindingListSourceProvider(typeof (IEntityView), EntityHelper.GetRelatedCollection);
      BindingListHelper.RegisterBindingListSourceProvider(typeof (IEntityView2), EntityHelper.GetRelatedCollection);
      DataEditorPersisterFactory.Register(DataEditorLLBLDataScopePersisterFactory);
    }

    /// <summary>
    ///   Dummy method which forces the initialization of LLBLWinformHelper via it's static constructor.
    /// </summary>
    public static void ForceInitialization()
    {
    }

    private static IDataEditorPersister DataEditorLLBLDataScopePersisterFactory(object data)
    {
      var queryable = data as IQueryable<IEntityCore>;
      if (queryable == null)
      {
        var selfServcingData = data as IEnumerable<IEntity>;
        return selfServcingData == null ? null : new DataEditorLLBLSelfServicingPersister();
      }
      return new DataEditorLLBLDataScopePersister(queryable);
    }

    #region Validatation

    public static bool ValidatePropertyAssignment<T>(
      Control controltoValidate,
      int fieldToValidate,
      T value, string errorMessage,
      ErrorProvider myError,
      EntityBase entity)
    {
      var validated = true;
      try
      {
        var validator = entity.Validator;
        if (value.Equals(entity.GetCurrentFieldValue(fieldToValidate)) == false
            && validator.ValidateFieldValue(entity, fieldToValidate, value) == false
          )
        {
          myError.SetError(controltoValidate, errorMessage);
          validated = false;
        }
        else
          myError.SetError(controltoValidate, "");
      }
      catch (Exception err)
      {
        myError.SetError(controltoValidate, err.Message);
        validated = false;
      }
      return validated;
    }

    public static bool ValidateForm(Control mycontrol, ErrorProvider myError)
    {
      var isValid = true;
      foreach (Control childControl in mycontrol.Controls)
      {
        if (myError.GetError(childControl) != "")
        {
          isValid = false;
          break;
        }
        if (childControl.Controls.Count > 0)
        {
          isValid = ValidateForm(childControl, myError);
          if (isValid == false)
            break;
        }
      }
      return isValid;
    }

    #endregion

    public abstract class DataEditorLLBLPersister : IDataEditorPersisterWithCounts
    {
      public abstract int Save(object dataToSave = null, bool cascadeDeletes = false);
      public abstract int Delete(object dataToDelete, bool cascade = false);

      public virtual bool CanSave(Type typeToSave)
      {
        return typeof (IEntityCore).IsAssignableFrom(typeToSave);
      }

      public virtual bool Undo(object modifiedData)
      {
        EntityHelper.Undo(modifiedData);
        return true;
      }

      public bool IsDirty(object data)
      {
        return EntityHelper.IsDirty(data);
      }

      public abstract IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren);
    }

    public class DataEditorLLBLSelfServicingPersister : DataEditorLLBLPersister
    {
      public override int Save(object dataToSave = null, bool cascadeDeletes = false)
      {
        return EntityHelper.Save(dataToSave);
      }

      public override int Delete(object dataToDelete, bool cascade = false)
      {
        return EntityHelper.Delete(dataToDelete);
      }

      public override bool CanSave(Type typeToSave)
      {
        return typeof (EntityBase).IsAssignableFrom(typeToSave);
      }

      public override IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
      {
        return EntityHelper.GetExistingChildCounts(null, entityThatMayHaveChildren as EntityBase2);
      }
    }

    public static HierarchyEditor HierarchyEditorFactory<T, TName, TChildCollection>(IQueryable<T> query, Func<IEnumerable<T>, IEnumerable<T>> postProcessing,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : class, IEntityCore
    {
      var dataScope = new GeneralEntityCollectionDataScope();
      var processedCollection = postProcessing(dataScope.FetchData(query));
      return HierarchyEditor.HierarchyEditorFactory(processedCollection, namePropertyExpression, childCollectionPropertyExpression,
        new DataEditorLLBLDataScopePersister(dataScope));
    }

    #region Adapter

    public class DataEditorLLBLAdapterPersister : DataEditorLLBLPersister
    {
      private readonly IDataAccessAdapter _dataAccessAdapter;

      public DataEditorLLBLAdapterPersister(IDataAccessAdapter dataAccessAdapter)
      {
        _dataAccessAdapter = dataAccessAdapter;
      }

      public override int Save(object dataToSave = null, bool cascadeDeletes = false)
      {
        return EntityHelper.Save(dataToSave, _dataAccessAdapter);
      }

      public override int Delete(object dataToDelete, bool cascade = false)
      {
        return EntityHelper.Delete(dataToDelete, _dataAccessAdapter);
      }

      public override bool CanSave(Type typeToSave)
      {
        return typeof (EntityBase2).IsAssignableFrom(typeToSave);
      }

      public override IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
      {
        return EntityHelper.GetExistingChildCounts(_dataAccessAdapter, entityThatMayHaveChildren as EntityBase2);
      }
    }

    #endregion

    #region PopulateTreeViewWithSchema

    public static void PopulateTreeViewWithSchema(TreeNodeCollection schemaTreeNodeCollection, ILinqMetaData linqMetaData = null, Type baseType = null, bool useSchema = true, string prefixDelimiter = null)
    {
      var entitiesTypes = EntityHelper.GetEntitiesTypes(baseType, linqMetaData).ToList();
      PopulateTreeViewWithSchema(schemaTreeNodeCollection, entitiesTypes, useSchema, prefixDelimiter, EntityHelper.GetDataAccessAdapter(linqMetaData));
      if (schemaTreeNodeCollection.Count == 0 && linqMetaData != null)
        PopulateTreeViewWithSchema(schemaTreeNodeCollection, linqMetaData.GetType());
    }

    public static void PopulateTreeViewWithSchema(TreeView entityTreeView, IEnumerable<Type> entitiesTypes, bool useSchema = true, string prefixDelimiter = null, IDataAccessAdapter adapter = null)
    {
      entityTreeView.Nodes.Clear();
      PopulateTreeViewWithSchema(entityTreeView.Nodes, entitiesTypes, useSchema, prefixDelimiter, adapter);
    }

    public static void PopulateTreeViewWithSchema(TreeNodeCollection schemaTreeNodeCollection, IEnumerable<Type> entitiesTypes, bool useSchema = true, string prefixDelimiter = null, IDataAccessAdapter adapter = null)
    {
      IElementCreatorCore elementCreator = null;
      var schemas = new Dictionary<string, TreeNode>();
      var prefixesToGroupBy = new Dictionary<string, TreeNode>();
      var usePrefixes = !String.IsNullOrWhiteSpace(prefixDelimiter);
      var entityNodes = new Dictionary<Type, Tuple<TreeNode, IEntityCore>>();
      foreach (var entityType in entitiesTypes.OrderBy(t => t.Name).ToList())
      {
        if (elementCreator == null)
          elementCreator = EntityHelper.CreateElementCreator(entityType);
        var entity = LinqUtils.CreateEntityInstanceFromEntityType(entityType, elementCreator);
        if (entity != null)
        {
          var fieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfoSafely(entity, adapter);
          var treeNodeCollectionToAddTo = schemaTreeNodeCollection;
          if (fieldPersistenceInfo != null)
          {
            var schema = fieldPersistenceInfo.SourceSchemaName;
            if (useSchema && !String.IsNullOrWhiteSpace(schema))
            {
              TreeNode schemaTreeNode;
              if (!schemas.TryGetValue(schema, out schemaTreeNode))
              {
                schemaTreeNode = new TreeNode(schema, 6, 4);
                schemas.Add(schema, schemaTreeNode);
              }
              treeNodeCollectionToAddTo = schemaTreeNode.Nodes;
            }

            if (usePrefixes)
            {
              var prefix = fieldPersistenceInfo.SourceObjectName.Before(prefixDelimiter);
              if (!String.IsNullOrWhiteSpace(prefix))
              {
                TreeNode prefixTreeNode;
                var prefixKey = useSchema ? schema + prefix : prefix;
                if (!prefixesToGroupBy.TryGetValue(prefixKey, out prefixTreeNode))
                {
                  prefixTreeNode = new TreeNode(prefix, 5, 4);
                  prefixesToGroupBy.Add(prefixKey, prefixTreeNode);
                  treeNodeCollectionToAddTo.Add(prefixTreeNode);
                }
                treeNodeCollectionToAddTo = prefixTreeNode.Nodes;
              }
            }
          }

          var entityNodeText = GetEntityTypeName(entityType);
          if (entity.LLBLGenProIsInHierarchyOfType != InheritanceHierarchyType.None)
            if (entityType.BaseType != null && !entityType.BaseType.IsAbstract)
              entityNodeText += String.Format(" (Sub-type of '{0}')", GetEntityTypeName(entityType.BaseType));
          var entityNode = treeNodeCollectionToAddTo.Add(entityType.Name, entityNodeText);
          entityNode.Tag = entityType;

          entityNode.ToolTipText = CreateTableToolTipText(entity, fieldPersistenceInfo);
          entityNodes.Add(entityType, new Tuple<TreeNode, IEntityCore>(entityNode, entity));
        }
      }

      foreach (var entityNode in entityNodes)
      {
        PopulateEntityFields(entityNode.Value.Item1, entityNode.Value.Item2, entityNodes, adapter);
      }

      if (schemas.Count == 1)
        schemaTreeNodeCollection.AddRange(schemas.First().Value.Nodes.OfType<TreeNode>().ToArray());
      else
        foreach (var treeNode in schemas)
        {
          schemaTreeNodeCollection.Add(treeNode.Value);
        }
    }


    private static void PopulateEntityFields(TreeNode entityNode, IEntityCore entity, Dictionary<Type, Tuple<TreeNode, IEntityCore>> entityNodes, IDataAccessAdapter adapter)
    {
      var entityType = entity.GetType();
      var entityFields = entity.GetFields();

      foreach (var fieldNode in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().FilterByIsEntityCore(false, true).
        Select(browseableProperty => CreateSimpleTypeTreeNode(browseableProperty, 1)))
      {
        entityNode.Nodes.Add(fieldNode);
        var field = entityFields.FirstOrDefault(f => f.Name.Equals(fieldNode.Name));
        {
          if (field != null)
          {
            fieldNode.Text = CreateFieldText(field);
            var fieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfoSafely(field, adapter);
            var fkNavigator = field.IsForeignKey ? "Navigator: " + EntityHelper.GetNavigatorNames(entity, field.Name).JoinAsString() : "";
            fieldNode.ToolTipText = CreateFieldToolTipText(entity, fieldPersistenceInfo, fieldNode.Tag as PropertyDescriptor, fkNavigator);
          }
        }
      }

      foreach (var entityTypeProperty in EntityHelper.GetPropertiesOfTypeEntity(entityType, true))
      {
        var fieldNode = entityNode.Nodes.Add(entityTypeProperty.Name);
        fieldNode.ToolTipText = FormatTypeName(entityTypeProperty.PropertyType);
        if (EntityHelper.IsEntityCore(entityTypeProperty))
        {
          fieldNode.ImageIndex = 3;
          fieldNode.ToolTipText = CreateNavigatorToolTipText(entity, entityTypeProperty, GetTargetToolTipText(entityNodes, entityTypeProperty.PropertyType));
        }
        else
        {
          fieldNode.ImageIndex = 2;
          var typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(entityTypeProperty.PropertyType);
          string targetToolTipText = null;
          if (typeParameterOfGenericType != null) targetToolTipText = GetTargetToolTipText(entityNodes, typeParameterOfGenericType);
          fieldNode.ToolTipText = CreateNavigatorToolTipText(entity, entityTypeProperty, targetToolTipText);
        }
        //  fieldNode.Text = CreateTreeNodeText(entityTypeProperty);
        fieldNode.Tag = entityTypeProperty;
      }
    }

    private static string GetTargetToolTipText(IDictionary<Type, Tuple<TreeNode, IEntityCore>> entityNodes, Type propertyType)
    {
      Tuple<TreeNode, IEntityCore> tuple;
      var targetToolTipText = entityNodes.TryGetValue(propertyType, out tuple) ? tuple.Item1.ToolTipText : FormatTypeName(propertyType);
      return targetToolTipText;
    }

    public static string CreateTableToolTipText(IEntityCore entity, IFieldPersistenceInfo fieldPersistenceInfo)
    {
      var type = entity.GetType();
      var baseType = "";
      if (entity.LLBLGenProIsInHierarchyOfType != InheritanceHierarchyType.None)
        if (type.BaseType != null && !type.BaseType.IsAbstract)
          baseType = "Base Type: " + type.BaseType.Name;
      var toolTipText = GeneralHelper.Join(Environment.NewLine, FormatTypeName(type, true), baseType,
        MetaDataHelper.GetDisplayNameAttributes(type).Select(da => da.DisplayName).Union(MetaDataHelper.GetDescriptionAttributes(type).Select(da => da.Description)).JoinAsString(),
        entity.CustomPropertiesOfType.Values.JoinAsString());
      if (fieldPersistenceInfo != null)
      {
        var dbInfo = String.Format("Table: {0}.{1}.{2}", fieldPersistenceInfo.SourceCatalogName, fieldPersistenceInfo.SourceSchemaName, fieldPersistenceInfo.SourceObjectName);
        toolTipText += Environment.NewLine + dbInfo;
      }
      return toolTipText.Trim();
    }

    private static string CreateDisplayNameDescriptionCustomPropertiesToolTipText(IEntityCore entity, MemberDescriptor propertyDescriptor)
    {
      if (propertyDescriptor != null)
      {
        var toolTipText = CreateDisplayNameDescriptionToolTipText(propertyDescriptor);
        toolTipText += Environment.NewLine + EntityHelper.GetFieldsCustomProperties(entity, propertyDescriptor.Name).JoinAsString();
        return toolTipText.Trim();
      }
      return "";
    }

    public static string CreateDisplayNameDescriptionToolTipText(MemberDescriptor propertyDescriptor)
    {
      var displayName = String.Empty;
      try
      {
        displayName = propertyDescriptor.DisplayName;
      }
      catch (Exception e)
      {
        e.TraceOut();
      }
      displayName = displayName == propertyDescriptor.Name ? "" : displayName;
      var toolTipText = GeneralHelper.Join(GeneralHelper.StringJoinSeparator, displayName, propertyDescriptor.Description);
      return toolTipText;
    }

    public static string CreateNavigatorToolTipText(IEntityCore entity, PropertyDescriptor navigatorProperty, string targetToolTipText)
    {
      var toolTipText = CreateDisplayNameDescriptionCustomPropertiesToolTipText(entity, navigatorProperty);

      if (typeof (IEnumerable).IsAssignableFrom(navigatorProperty.PropertyType))
      {
        var targetTipText = targetToolTipText;
        if (navigatorProperty.PropertyType.IsGenericType)
        {
          var elementType = MetaDataHelper.GetElementType(navigatorProperty.PropertyType);
          targetTipText = targetTipText.Replace(FormatTypeName(elementType, true), "").Trim();
        }
        return GeneralHelper.Join(Environment.NewLine, toolTipText, FormatTypeName(navigatorProperty.PropertyType, true), targetTipText);
      }
      var relationsForFieldOfType = entity.GetRelationsForFieldOfType(navigatorProperty.Name);
      foreach (IEntityRelation relation in relationsForFieldOfType)
      {
        var allFkEntityFieldCoreObjects = relation.GetAllFKEntityFieldCoreObjects();
        var plurilizer = allFkEntityFieldCoreObjects.Count == 1 ? "" : "s";
        toolTipText = GeneralHelper.Join(Environment.NewLine, toolTipText,
          String.Format("Foreign Key field{0}: {1}", plurilizer, allFkEntityFieldCoreObjects.Select(f => f.Name).JoinAsString()));
      }
      return targetToolTipText.Contains(toolTipText) ? targetToolTipText : GeneralHelper.Join(Environment.NewLine, toolTipText, targetToolTipText);
    }

    private static bool IsNonNormalPrecision(TypeCode typeCode, byte precision)
    {
      return !(precision == 10 && typeCode == TypeCode.Int32)
             && !(precision == 5 && typeCode == TypeCode.Int16)
             && !(precision == 24 && typeCode == TypeCode.Single)
             && !(precision == 3 && typeCode == TypeCode.Byte);
    }

    public static string CreateFieldText(IFieldInfo field)
    {
      var extra = GeneralHelper.Join(GeneralHelper.StringJoinSeparator, field.IsPrimaryKey
        ? "PK"
        : "", field.IsForeignKey
          ? "FK"
          : "", field.IsReadOnly ? "RO" : "");
      var typeName = FormatTypeName(field.DataType);
      var coreDataType = MetaDataHelper.GetCoreType(field.DataType);
      var typeCode = Type.GetTypeCode(coreDataType);
      if (!coreDataType.IsEnum && typeCode != TypeCode.Boolean)
        if (field.MaxLength > 0 && field.MaxLength < 1073741823)
          typeName += "{" + field.MaxLength + "}";
        else
        {
          var scalePrecision = String.Empty;
          if (field.Scale > 0)
            scalePrecision = GeneralHelper.Join(GeneralHelper.StringJoinSeparator, scalePrecision, field.Scale.ToString());
          var precision = field.Precision;
          if (precision > 0 && IsNonNormalPrecision(typeCode, precision))
            scalePrecision = GeneralHelper.Join(GeneralHelper.StringJoinSeparator, scalePrecision, precision.ToString());
          if (!String.IsNullOrEmpty(scalePrecision))
            typeName += "{" + scalePrecision + "}";
        }
      return GeneralHelper.Join(" - ", field.Name + " (" + typeName + ")", extra);
    }

    public static string CreateFieldToolTipText(IEntityCore entity, IFieldPersistenceInfo fieldPersistenceInfo, PropertyDescriptor propertyDescriptor, string fkNavigator)
    {
      var toolTipText = GeneralHelper.Join(Environment.NewLine, CreateDisplayNameDescriptionCustomPropertiesToolTipText(entity, propertyDescriptor), fkNavigator);
      if (propertyDescriptor == null)
        GeneralHelper.TraceOut(entity.LLBLGenProEntityName + " propertyDescriptor == null");
      else
      {
        var coreType = MetaDataHelper.GetCoreType(propertyDescriptor.PropertyType);
        if (coreType.IsEnum)
          toolTipText = GeneralHelper.Join(Environment.NewLine, toolTipText,
            String.Format("Enum values: {0}", Enum.GetNames(coreType).JoinAsString()));
      }
      if (fieldPersistenceInfo != null)
      {
        var sourceColumnIsNullable = fieldPersistenceInfo.SourceColumnIsNullable ? "" : " not ";
        var sizeAndPrecision = "";
        if (fieldPersistenceInfo.SourceColumnMaxLength < UInt16.MaxValue && fieldPersistenceInfo.SourceColumnMaxLength > 0 || fieldPersistenceInfo.SourceColumnPrecision > 0)
          sizeAndPrecision = String.Format("({0})", fieldPersistenceInfo.SourceColumnMaxLength + fieldPersistenceInfo.SourceColumnPrecision);
        var dbInfo = String.Format("Column: {0} ({1}{2}, {3} null)", fieldPersistenceInfo.SourceColumnName, fieldPersistenceInfo.SourceColumnDbType,
          sizeAndPrecision, sourceColumnIsNullable);
        toolTipText += Environment.NewLine + GeneralHelper.Join(GeneralHelper.StringJoinSeparator, dbInfo, fieldPersistenceInfo.IdentityValueSequenceName);
      }
      return toolTipText.Trim();
    }

    private static string GetEntityTypeName(Type entityType)
    {
      return entityType.Name.Replace("Entity", "");
    }

    public static void PopulateTreeViewWithSchema(TreeNodeCollection schemaTreeNodeCollection, Type dataContextType)
    {
      // Return the objects with which to populate the Schema Explorer by reflecting over customType.

      // We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
      var topLevelProps =
        (
          from prop in dataContextType.GetProperties()
          where prop.PropertyType != typeof (string)
          // Display all properties of type IEnumerable<T> (except for string!)
          let ienumerableOfT = prop.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1")
          where ienumerableOfT != null
          let typeArgument = ienumerableOfT.GetGenericArguments()[0]
          orderby prop.Name
          select new TreeNode(prop.Name)
          {
            ToolTipText = FormatTypeName(prop.PropertyType),
            // Store the entity type to the Tag property. We'll use it later.
            Tag = typeArgument,
            Name = typeArgument.Name
          }
          ).ToList();

      // Create a lookup keying each element type to the properties of that type. This will allow
      // us to build hyperlink targets allowing the user to click between associations:
      var elementTypeLookup = topLevelProps.ToLookup(tp => (Type) tp.Tag);

      // Populate the columns (properties) of each entity:
      foreach (var table in topLevelProps)
        table.Nodes.AddRange(GetPropertiesToShowInSchema((Type) table.Tag)
          .Select(childProp => GetChildItem(elementTypeLookup, childProp))
          .ToArray());

      schemaTreeNodeCollection.AddRange(topLevelProps.ToArray());
    }

    /// <summary>
    ///   Gets the properties to show in schema.
    ///   They should be all the browsable properties with the addition of selfservicing entity properties.
    /// </summary>
    /// <remarks>
    ///   See MetaDataHelper.GetPropertiesToDisplay
    /// </remarks>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private static IEnumerable<PropertyDescriptor> GetPropertiesToShowInSchema(Type type)
    {
      return ListBindingHelper.GetListItemProperties(type).Cast<PropertyDescriptor>().Union(EntityHelper.GetPropertiesOfTypeEntity(type));
    }

    private static TreeNode GetChildItem(ILookup<Type, TreeNode> elementTypeLookup, PropertyDescriptor childProp)
    {
      // If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
      // We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
      if (elementTypeLookup.Contains(childProp.PropertyType))
      {
        var n = new TreeNode(childProp.Name)
        {
          //HyperlinkTarget = elementTypeLookup[childProp.PropertyType].First(),
          // FormatTypeName is a helper method that returns a nicely formatted type name.
          ToolTipText = FormatTypeName(childProp.PropertyType, true),
          Name = childProp.Name
        };
        if (typeof (IEntityCore).IsAssignableFrom(childProp.PropertyType))
        {
          n.ImageIndex = 3;
          n.Tag = childProp;
        }
        else
          n.ImageIndex = 1;
        return n;
      }

      // Is the property's type a collection of entities?
      var ienumerableOfT = childProp.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1");
      if (ienumerableOfT != null)
      {
        var elementType = ienumerableOfT.GetGenericArguments()[0];
        if (elementTypeLookup.Contains(elementType))
          return new TreeNode(childProp.Name)
          {
            //HyperlinkTarget = elementTypeLookup[elementType].First(),
            ImageIndex = 2,
            Tag = childProp,
            ToolTipText = elementType.ToString(),
            Name = childProp.Name
          };
      }

      // Ordinary property:
      return CreateSimpleTypeTreeNode(childProp, 1);
    }

    private static TreeNode CreateSimpleTypeTreeNode(PropertyDescriptor childProp, int imageIndex)
    {
      return new TreeNode(CreateTreeNodeText(childProp)) {ImageIndex = imageIndex, Name = childProp.Name, Tag = childProp, ToolTipText = FormatTypeName(childProp.PropertyType)};
    }

    private static string CreateTreeNodeText(PropertyDescriptor childProp)
    {
      return childProp.Name + " (" + FormatTypeName(childProp.PropertyType) + ")";
    }

    /// <summary>
    ///   Delegete to override to customize formatting the type name. e.g by
    ///   LINQPad.Extensibility.DataContext.DataContextDriver.FormatTypeName
    /// </summary>
    public static event Func<Type, bool, string> GetFormatTypeName;

    private static string FormatTypeName(Type propertyType, bool includeNamespace = false)
    {
      return GetFormatTypeName == null ? (includeNamespace ? propertyType.ToString() : propertyType.FriendlyName()) : GetFormatTypeName(propertyType, includeNamespace);
    }

    #endregion
  }
}