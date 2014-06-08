using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Text;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  /// <summary>
  ///   Methods that can be used to check wether the entities can be read and persisted from a DB
  /// </summary>
  public static class PersistanceDiagnostics
  {
    /// <summary>
    ///   Checks entities can be fetched.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// ///
    /// <param name="entityFactoryFactory">The entity factory factory.</param>
    /// <param name="adapter">The adapter.</param>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return. If 0, all entities are returned.</param>
    /// <param name="entityTypes">The entity types.</param>
    /// <returns></returns>
    public static StringBuilder CheckEntitiesCanBeFetched<TEnum>(Func<TEnum, IEntityFactory2> entityFactoryFactory, IDataAccessAdapter adapter, int maxNumberOfItemsToReturn, params TEnum[] entityTypes)
    {
      var errors = new StringBuilder();
      if (adapter == null)
        errors.Append("Adapter is null");
      else
        return CheckEntitiesCanBeFetched(entityFactoryFactory, entityCollection => adapter.FetchEntityCollection((IEntityCollection2) entityCollection, null, maxNumberOfItemsToReturn), true, entityTypes);
      return errors;
    }

    public static StringBuilder CheckEntitiesCanBeFetched<TEnum>(Func<TEnum, IEntityFactory> entityFactoryFactory, int maxNumberOfItemsToReturn, params TEnum[] entityTypes)
    {
      return CheckEntitiesCanBeFetched(entityFactoryFactory, entityCollection => ((IEntityCollection) entityCollection).GetMulti(null, maxNumberOfItemsToReturn), true, entityTypes);
    }

    /// <summary>
    ///   Checks the entities can be fetched.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <typeparam name="TFactoryType">The type of the factory type.</typeparam>
    /// <param name="entityFactoryFactory">The entity factory factory.</param>
    /// <param name="fetchEntityCollection">The fetch entity collection.</param>
    /// <param name="doReadEveryBindableProperty">if set to <c>true</c> [do read every bindable property].</param>
    /// <param name="entityTypes">The entity types.</param>
    /// <returns></returns>
    public static StringBuilder CheckEntitiesCanBeFetched<TEnum, TFactoryType>(Func<TEnum, TFactoryType> entityFactoryFactory, Action<IEntityCollectionCore> fetchEntityCollection,
      bool doReadEveryBindableProperty,
      params TEnum[] entityTypes) where TFactoryType : IEntityFactoryCore
    {
      var errors = new StringBuilder();
      if (entityFactoryFactory == null)
        errors.Append("entityFactoryFactory is null");
      if (fetchEntityCollection == null)
        errors.Append("fetchEntityCollection is null");
      if (errors.Length == 0)
      {
        if (entityTypes.IsNullOrEmpty())
          entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>();
        else
          GeneralHelper.CheckIsEnum(typeof (TEnum));
        foreach (var entityType in entityTypes)
        {
// ReSharper disable PossibleNullReferenceException
          var entityFactoryCore = entityFactoryFactory(entityType);
// ReSharper restore PossibleNullReferenceException
          var entityCollection = CreateEntityCollection(entityFactoryCore);
          var entity = entityFactoryCore.Create();
          try
          {
// ReSharper disable PossibleNullReferenceException
            fetchEntityCollection(entityCollection);
// ReSharper restore PossibleNullReferenceException
          }
          catch (ORMQueryExecutionException e)
          {
            LogError(e, errors, entity);
            errors.AppendLine(e.QueryExecuted);
          }
          catch (Exception e)
          {
            LogError(e, errors, entity);
          }
          if (doReadEveryBindableProperty)
            ReadEveryBindableProperty(entityCollection, errors);
        }
      }
      return errors;
    }

    private static void LogError(Exception e, StringBuilder errors, object entity)
    {
      errors.AppendLine(entity.ToString());
      errors.AppendLine(e.Message);
    }

    private static IEntityCollectionCore CreateEntityCollection<TFactoryType>(TFactoryType entityFactoryCore)
    {
      return typeof (TFactoryType) == typeof (IEntityFactory)
        ? (IEntityCollectionCore) ((IEntityFactory) entityFactoryCore).CreateEntityCollection()
        : ((IEntityFactory2) entityFactoryCore).CreateEntityCollection();
    }


    /// <summary>
    ///   Checks all entities can be fetched using LINQ.
    /// </summary>
    /// <param name="metaData">The meta data.</param>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <param name="entityTypes">The entity types.</param>
    /// <returns></returns>
    public static StringBuilder CheckAllEntitiesCanBeFetchedUsingLINQ<TEnum>(ILinqMetaData metaData, ushort maxNumberOfItemsToReturn, params TEnum[] entityTypes)
    {
      if (entityTypes.IsNullOrEmpty())
        entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>().ToArray();
      else
        GeneralHelper.CheckIsEnum(typeof (TEnum));
      var errors = new StringBuilder();
      foreach (var query in entityTypes
        .Select(entityType => metaData.GetQueryableForEntity(Convert.ToInt32(entityType)))
        .Select(dataSource => dataSource).OfType<ILLBLGenProQuery>())
        CheckEntityCanBeFetchedUsingLINQ(query, true, maxNumberOfItemsToReturn, errors);
      return errors;
    }

    /// <summary>
    ///   Checks the entity can be fetched using LINQ.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <param name="forceTableAlias">if set to <c>true</c> [force table alias].</param>
    /// <param name="maxNumberOfItemsToReturn">
    ///   The max number of items to return. If less than 1 all entities are returned, if
    ///   0 a where clause is added to force an table alias.
    /// </param>
    /// <param name="errors">The errors.</param>
    /// <returns></returns>
    private static bool CheckEntityCanBeFetchedUsingLINQ(ILLBLGenProQuery query, Boolean forceTableAlias, ushort maxNumberOfItemsToReturn, StringBuilder errors)
    {
      var initalErrorlength = errors.Length;
      try
      {
        var q = query;
        if (forceTableAlias)
          q = q.Where("null == null") as ILLBLGenProQuery; //To force an table alias
        if (maxNumberOfItemsToReturn != 0)
          q = q.Take(maxNumberOfItemsToReturn) as ILLBLGenProQuery;
        ExecuteQueryAndReadEveryBindableProperty(q, errors);
      }
      catch (ORMQueryExecutionException e)
      {
        LogError(query, errors, e);
        errors.AppendLine(e.QueryExecuted);
      }
      catch (ArgumentException e)
      {
        LogError(query, errors, e);
        errors.AppendLine(e.ParamName);
      }
      catch (DbException e)
      {
        errors.AppendLine(query.ElementType.ToString());
        errors.AppendLine(e.ErrorCode + " - " + e.Message);
        DynamicQueryEngineBase.Switch.Level = TraceLevel.Verbose;
        if (CheckEntityCanBeFetchedUsingLINQ(query, false, maxNumberOfItemsToReturn, errors))
          errors.AppendLine("Plain query succeeded");
      }
      catch (Exception e)
      {
        LogError(query, errors, e);
      }
      return initalErrorlength == errors.Length;
    }

    private static void LogError(IQueryable query, StringBuilder errors, Exception e)
    {
      errors.AppendLine(query.ElementType.ToString());
      errors.AppendLine(e.Message);
    }

    /// <summary>
    ///   Executes the query and read every bindable property.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <param name="errors">The errors.</param>
    public static void ExecuteQueryAndReadEveryBindableProperty(ILLBLGenProQuery query, StringBuilder errors)
    {
      if (query != null)
      {
        var entityCollection = query.Execute() as IEntityCollectionCore;
        ReadEveryBindableProperty(entityCollection, errors);
      }
    }

    /// <summary>
    ///   Reads the every bindable property.
    /// </summary>
    /// <param name="entityCollection">The entity collection.</param>
    /// <param name="errors">The errors.</param>
    public static void ReadEveryBindableProperty(IEntityCollectionCore entityCollection, StringBuilder errors)
    {
      if (entityCollection != null)
        foreach (
          var invalidCastErrors in
            entityCollection.AsEnumerable().Select(ReadEveryBindableProperty)
              .Where(invalidCastErrors => invalidCastErrors.Length > 0))
        {
          errors.AppendLine(invalidCastErrors.ToString());
          break;
        }
    }

    /// <summary>
    ///   Reads every bindable property of an entity to check it doesn't throw an exception.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    public static StringBuilder ReadEveryBindableProperty(IEntityCore entity)
    {
      var errors = new StringBuilder();

      foreach (var browseableProperty in MetaDataHelper.GetPropertiesToDisplay(entity.GetType()))
        try
        {
          var value = browseableProperty.GetValue(entity);
          if (value is Enum)
          {
            var enumConverter = new EnumConverter(browseableProperty.PropertyType);
            enumConverter.ConvertTo(value, typeof (string));
          }
        }
        catch (TargetInvocationException e)
        {
          if (e.InnerException is InvalidCastException)
          {
            var field = entity.GetFields().FirstOrDefault(f => f.Name == browseableProperty.Name);
            errors.AppendLine(e.Message);
            if (field != null)
              errors.AppendFormat("{0} of type {1} has a value of {2} is attempting to being cast to a {3}",
                field.Name, field.CurrentValue.GetType(), field.CurrentValue, browseableProperty.PropertyType);

            errors.AppendLine();
          }
          else
            throw;
        }
        catch (ArgumentException e)
        {
          errors.AppendLine(e.Message);
        }
      return errors;
    }

    /// <summary>
    ///   Gets the field information of the entities.
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<EntityInformation2> GetEntityFieldInformation<TEnum>(IDataAccessAdapter adapter, Func<TEnum, IEntityFactory2> entityFactoryFactory)
    {
      return EntityInformation2.EntityInfoFactory(adapter, entityFactoryFactory).OrderBy(fi => fi.Entity);
    }
  }

  #region EntityInformation

  /// <summary>
  ///   Class to display info about an entity and it's fields and their display names
  /// </summary>
  [Serializable]
  public class EntityInformation
  {
    /// <summary>
    ///   Gets or sets the entity name.
    /// </summary>
    /// <value>The entity.</value>
    public string Entity { get; private set; }

    /// <summary>
    ///   Gets or sets the name of the SQL server table.
    /// </summary>
    /// <value>The name of the SQL server table.</value>
    public string TableName { get; private set; }

    /// <summary>
    ///   Gets or sets the custom properties.
    /// </summary>
    /// <value>The custom properties.</value>
    public string CustomProperties { get; private set; }

    /// <summary>
    ///   FieldInformation2 for the entity
    /// </summary>
    public IEnumerable<FieldAndEntityInformation> FieldInformation;

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public EntityInformation(IEntity entity)
    {
      Entity = EntityHelper.GetNameFromEntity(entity);
      var entityFields = entity.Fields.AsEnumerable().GroupBy(f => f.Name).Select(y => y.First()).Where(field => field.ContainingObjectName.Equals(field.ActualContainingObjectName));
      //	remove duplicate field names and ancestor fields
      var fieldAndEntityInformations = from field in entityFields
        select new FieldAndEntityInformation(entity.GetType(), field,
          entity.FieldsCustomPropertiesOfType.ContainsKey(field.Name)
            ? entity.FieldsCustomPropertiesOfType[field.Name]
            : new Dictionary<string, string>());
      FieldInformation = fieldAndEntityInformations;
      var fieldAndEntityInformation = fieldAndEntityInformations.FirstOrDefault();
      if (fieldAndEntityInformation != null)
      {
        TableName = fieldAndEntityInformation.TableName;
      }
      CustomProperties = entity.CustomPropertiesOfType.Values.JoinAsString();
    }

    /// <summary>
    ///   Entities the info factory.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="entityFactoryFactory">The entity factory factory.</param>
    /// <param name="entityTypes">The entity types.</param>
    /// <returns></returns>
    public static IEnumerable<EntityInformation> EntityInfoFactory<TEnum>(Func<TEnum, IEntityFactory> entityFactoryFactory, params TEnum[] entityTypes)
    {
      if (entityTypes.IsNullOrEmpty())
        entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>();
      else
        GeneralHelper.CheckIsEnum(typeof (TEnum));
      return from entityType in entityTypes
        select entityFactoryFactory(entityType)
        into factory
        select new EntityInformation(factory.Create());
    }
  }

  /// <summary>
  ///   Class to display info about fields and their display names
  /// </summary>
  [Serializable]
  public class FieldInformation
  {
    internal IFieldPersistenceInfo SQLServerFieldPersistenceInfo;

    /// <summary>
    ///   Factory to create FieldInformation2 for the supplied entity types.
    /// </summary>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    public static IEnumerable<FieldInformation> FieldInfoFactory(List<Type> entities)
    {
      return from entity in entities
        from field in EntityHelper.GetFieldsFromType(entity).AsEnumerable()
        where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
        select new FieldInformation(entity, field);
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    public FieldInformation(Type entity, IEntityField field)
      : this(entity, field, "")
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldInformation(Type entity, IEntityField field, Dictionary<string, string> customProperties)
      : this(entity, field, customProperties.Values.JoinAsString())
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldInformation(Type entity, IEntityField field, string customProperties)
    {
      CustomProperties = customProperties;
      FieldName = field.Name;
      var displayNameAttributes = MetaDataHelper.GetDisplayNameAttributes(entity, field.Name);
      DisplayNames = displayNameAttributes.Select(dna => dna.DisplayName).JoinAsString();
      DisplayNameAttributeTypes = displayNameAttributes.JoinAsString();
      SQLServerFieldPersistenceInfo = GetFieldPersistenceInfoPublic(field);
    }

    private static IFieldPersistenceInfo GetFieldPersistenceInfoPublic(IEntityField field)
    {
      return field;
    }

    /// <summary>
    ///   Gets or sets the name of the field.
    /// </summary>
    /// <value>The name of the field.</value>
    public string FieldName { get; private set; }

    /// <summary>
    ///   Gets or sets the display names.
    /// </summary>
    /// <value>The display names.</value>
    public string DisplayNames { get; private set; }

    /// <summary>
    ///   Gets or sets the display name attribute types.
    /// </summary>
    /// <value>The display name attribute types.</value>
    public string DisplayNameAttributeTypes { get; private set; }

    /// <summary>
    ///   Gets the name of the SQL server column.
    ///   The name of the corresponding column in a view or table for an entityfield. This name is used to map a column in a
    ///   resultset onto the entity field.
    /// </summary>
    /// <value>The name of the SQL server column.</value>
    public string ColumnName
    {
      get { return SQLServerFieldPersistenceInfo == null ? null : SQLServerFieldPersistenceInfo.SourceColumnName; }
    }

    /// <summary>
    ///   Gets or sets the custom properties.
    /// </summary>
    /// <value>The custom properties.</value>
    public string CustomProperties { get; private set; }
  }

  /// <summary>
  ///   Class to display info about fields and their display names and entities
  /// </summary>
  [Serializable]
  public class FieldAndEntityInformation : FieldInformation
  {
    /// <summary>
    ///   Gets or sets the entity name.
    /// </summary>
    /// <value>The entity.</value>
    internal string Entity { get; private set; }

    /// <summary>
    ///   Gets the name of the SQL server table.
    /// </summary>
    /// <value>The name of the SQL server table.</value>
    internal string TableName
    {
      get { return SQLServerFieldPersistenceInfo == null ? null : SQLServerFieldPersistenceInfo.SourceObjectName; }
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldAndEntityInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldAndEntityInformation(Type entity, IEntityField field, Dictionary<string, string> customProperties)
      : this(entity, field, customProperties.Values.JoinAsString())
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldAndEntityInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldAndEntityInformation(Type entity, IEntityField field, string customProperties)
      : base(entity, field, customProperties)
    {
      Entity = EntityHelper.GetNameFromEntityName(field.ActualContainingObjectName);
    }

    /// <summary>
    ///   Factory to create FieldAndEntityInformation2 for the supplied entity types.
    /// </summary>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    public static IEnumerable<FieldAndEntityInformation> FieldAndEntityInformationFactory(List<Type> entities)
    {
      return from entity in entities
        from field in EntityHelper.GetFieldsFromType(entity).AsEnumerable()
        where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
        select new FieldAndEntityInformation(entity, field, "");
    }
  }

  #endregion

  #region EntityInformation2

  /// <summary>
  ///   Class to display info about an entity and it's fields and their display names
  /// </summary>
  [Serializable]
  public class EntityInformation2
  {
    /// <summary>
    ///   Gets or sets the entity name.
    /// </summary>
    /// <value>The entity.</value>
    public string Entity { get; private set; }

    /// <summary>
    ///   Gets or sets the name of the SQL server table.
    /// </summary>
    /// <value>The name of the SQL server table.</value>
    public string TableName { get; private set; }

    /// <summary>
    ///   Gets or sets the custom properties.
    /// </summary>
    /// <value>The custom properties.</value>
    public string CustomProperties { get; private set; }

    /// <summary>
    ///   FieldInformation2 for the entity
    /// </summary>
    public IEnumerable<FieldAndEntityInformation2> FieldInformation;

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public EntityInformation2(IEntity2 entity)
    {
      Entity = EntityHelper.GetNameFromEntity(entity);
      var fieldAndEntityInformations = from field in entity.Fields.AsEnumerable()
        where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
        select new FieldAndEntityInformation2(entity.GetType(), field, entity.FieldsCustomPropertiesOfType[field.Name]);
      FieldInformation = fieldAndEntityInformations;
      var fieldAndEntityInformation = fieldAndEntityInformations.FirstOrDefault();
      if (fieldAndEntityInformation != null)
      {
        TableName = fieldAndEntityInformation.TableName;
      }
      CustomProperties = entity.CustomPropertiesOfType.Values.JoinAsString();
    }

    /// <summary>
    ///   Entities the info factory.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="adapter">The adapter.</param>
    /// <param name="entityFactoryFactory">The entity factory factory.</param>
    /// <param name="entityTypes">The entity types.</param>
    /// <returns></returns>
    public static IEnumerable<EntityInformation2> EntityInfoFactory<TEnum>(IDataAccessAdapter adapter, Func<TEnum, IEntityFactory2> entityFactoryFactory, params TEnum[] entityTypes)
    {
      FieldInformation2.SQLServerDataAccessAdapter = adapter;
      if (entityTypes.IsNullOrEmpty())
        entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>();
      else
        GeneralHelper.CheckIsEnum(typeof (TEnum));
      return from entityType in entityTypes
        select entityFactoryFactory(entityType)
        into factory
        select new EntityInformation2(factory.Create());
    }
  }

  /// <summary>
  ///   Class to display info about fields and their display names
  /// </summary>
  [Serializable]
  public class FieldInformation2
  {
    internal static IDataAccessAdapter SQLServerDataAccessAdapter;
    internal IFieldPersistenceInfo SQLServerFieldPersistenceInfo;

    /// <summary>
    /// Factory to create FieldInformation2 for the supplied entity types.
    /// </summary>
    /// <param name="adapter">The adapter.</param>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    public static IEnumerable<FieldInformation2> FieldInfoFactory(IDataAccessAdapter adapter, List<Type> entities)
    {
      SQLServerDataAccessAdapter = adapter;
      return from entity in entities
        from field in EntityHelper.GetFieldsFromType2(entity).AsEnumerable()
        where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
        select new FieldInformation2(entity, field);
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    public FieldInformation2(Type entity, IEntityField2 field) : this(entity, field, "")
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldInformation2(Type entity, IEntityField2 field, Dictionary<string, string> customProperties)
      : this(entity, field, customProperties.Values.JoinAsString())
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldInformation2(Type entity, IEntityField2 field, string customProperties)
    {
      CustomProperties = customProperties;
      FieldName = field.Name;
      var displayNameAttributes = MetaDataHelper.GetDisplayNameAttributes(entity, field.Name);
      DisplayNames = displayNameAttributes.Select(dna => dna.DisplayName).JoinAsString();
      DisplayNameAttributeTypes = displayNameAttributes.JoinAsString();
      SQLServerFieldPersistenceInfo = EntityHelper.GetFieldPersistenceInfoSafely(SQLServerDataAccessAdapter, field);
    }

    /// <summary>
    ///   Gets or sets the name of the field.
    /// </summary>
    /// <value>The name of the field.</value>
    public string FieldName { get; private set; }

    /// <summary>
    ///   Gets or sets the display names.
    /// </summary>
    /// <value>The display names.</value>
    public string DisplayNames { get; private set; }

    /// <summary>
    ///   Gets or sets the display name attribute types.
    /// </summary>
    /// <value>The display name attribute types.</value>
    public string DisplayNameAttributeTypes { get; private set; }

    /// <summary>
    ///   Gets the name of the SQL server column.
    ///   The name of the corresponding column in a view or table for an entityfield. This name is used to map a column in a
    ///   resultset onto the entity field.
    /// </summary>
    /// <value>The name of the SQL server column.</value>
    public string ColumnName
    {
      get
      {
        return SQLServerFieldPersistenceInfo == null ? null : SQLServerFieldPersistenceInfo.SourceColumnName;
      }
    }

    /// <summary>
    ///   Gets or sets the custom properties.
    /// </summary>
    /// <value>The custom properties.</value>
    public string CustomProperties { get; private set; }
  }

  /// <summary>
  ///   Class to display info about fields and their display names and entities
  /// </summary>
  [Serializable]
  public class FieldAndEntityInformation2 : FieldInformation2
  {
    /// <summary>
    ///   Gets or sets the entity name.
    /// </summary>
    /// <value>The entity.</value>
    internal string Entity { get; private set; }

    /// <summary>
    ///   Gets the name of the SQL server table.
    /// </summary>
    /// <value>The name of the SQL server table.</value>
    internal string TableName
    {
      get { return SQLServerFieldPersistenceInfo == null ? null : SQLServerFieldPersistenceInfo.SourceObjectName; }
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldAndEntityInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldAndEntityInformation2(Type entity, IEntityField2 field, Dictionary<string, string> customProperties)
      : this(entity, field, customProperties.Values.JoinAsString())
    {
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="FieldAndEntityInformation2" /> class.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="field">The field.</param>
    /// <param name="customProperties">The custom properties.</param>
    public FieldAndEntityInformation2(Type entity, IEntityField2 field, string customProperties)
      : base(entity, field, customProperties)
    {
      Entity = field.ActualContainingObjectName.Replace("Entity", "");
    }

    /// <summary>
    /// Factory to create FieldAndEntityInformation2 for the supplied entity types.
    /// </summary>
    /// <param name="adapter">The adapter.</param>
    /// <param name="entities">The entities.</param>
    /// <returns></returns>
    public static IEnumerable<FieldAndEntityInformation2> FieldAndEntityInformationFactory(IDataAccessAdapter adapter, List<Type> entities)
    {
      SQLServerDataAccessAdapter = adapter;
      return from entity in entities
        from field in EntityHelper.GetFieldsFromType2(entity).AsEnumerable()
        where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
        select new FieldAndEntityInformation2(entity, field, "");
    }
  }

  #endregion
}