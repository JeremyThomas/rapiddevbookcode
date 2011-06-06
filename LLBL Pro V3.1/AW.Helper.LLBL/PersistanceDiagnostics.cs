using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	/// <summary>
	/// Methods that can be used to check wether the entities can be read and persisted from a DB
	/// </summary>
	public static class PersistanceDiagnostics
	{

		/// <summary>
		/// Checks entities can be fetched.
		/// </summary>
		/// <param name="adapter">The adapter.</param>
		/// <param name="maxNumberOfItemsToReturn">The max number of items to return. If 0, all entities are returned.</param>
		/// <param name="entityTypes">The entity types.</param>
		/// <returns></returns>
		public static StringBuilder CheckEntitiesCanBeFetched(EntityFactoryCore2 entityFactoryCore, IDataAccessAdapter adapter, int maxNumberOfItemsToReturn, params int[] entityTypes)
		{
			var errors = new StringBuilder();
			if (adapter == null)
				errors.Append("Adapter is null");
			else
			{
				if (entityTypes.IsNullOrEmpty())
					entityTypes = GeneralHelper.EnumAsEnumerable<int>();
				var inheritanceErrors = new StringBuilder();
				foreach (var entityType in entityTypes)
				{
					var entity = EntityHelper.GetEntityTypeFromEntityTypeValue(entityFactoryCore, entityType);
					var entityCollection = entityFactoryCore.CreateEntityCollection();
					try
					{
						adapter.FetchEntityCollection(entityCollection, null, maxNumberOfItemsToReturn);
					}
					catch (ORMQueryExecutionException e)
					{
						
						errors.AppendLine(entity.ToString());
						errors.AppendLine(e.Message);
						errors.AppendLine(e.QueryExecuted);
					}
					catch (ORMInheritanceInfoException e)
					{
						
						inheritanceErrors.AppendLine(entity.ToString());
						inheritanceErrors.AppendLine(e.Message);
					}
					catch (Exception e)
					{
						
						errors.AppendLine(entity.ToString());
						errors.AppendLine(e.Message);
					}
					foreach (
						var invalidCastErrors in
							entityCollection.Cast<EntityBase2>().Select(ReadEveryBindableProperty)
								.Where(invalidCastErrors => invalidCastErrors.Length > 0))
					{
						errors.AppendLine(invalidCastErrors.ToString());
						break;
					}
				}
			}
			return errors;
		}

		/// <summary>
		/// Checks all entities can be fetched using LINQ.
		/// </summary>
		/// <param name="metaData">The meta data.</param>
		/// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
		/// <param name="entityTypes">The entity types.</param>
		/// <returns></returns>
		public static StringBuilder CheckAllEntitiesCanBeFetchedUsingLINQ(ILinqMetaData metaData, ushort maxNumberOfItemsToReturn, params int[] entityTypes)
		{
			if (entityTypes.IsNullOrEmpty())
				entityTypes = GeneralHelper.EnumAsEnumerable<int>().ToArray();
			var errors = new StringBuilder();
			var inheritanceErrors = new StringBuilder();
			foreach (var query in entityTypes
				.Select(entityType => metaData.GetQueryableForEntity((int) entityType))
				.Select(dataSource => dataSource).OfType<ILLBLGenProQuery>())
				CheckEntityCanBeFetchedUsingLINQ(query, true, maxNumberOfItemsToReturn, errors, inheritanceErrors);
			return errors;
		}

		/// <summary>
		/// Checks the entity can be fetched using LINQ.
		/// </summary>
		/// <param name="query">The query.</param>
		/// <param name="forceTableAlias">if set to <c>true</c> [force table alias].</param>
		/// <param name="maxNumberOfItemsToReturn">The max number of items to return. If less than 1 all entities are returned, if 0 a where clause is added to force an table alias.</param>
		/// <param name="errors">The errors.</param>
		/// <param name="inheritanceErrors">The inheritance errors.</param>
		/// <returns></returns>
		public static bool CheckEntityCanBeFetchedUsingLINQ(ILLBLGenProQuery query, Boolean forceTableAlias, ushort maxNumberOfItemsToReturn, StringBuilder errors, StringBuilder inheritanceErrors)
		{
			var initalErrorlength = errors.Length;
			try
			{
				var q = query;
				//if (forceTableAlias)
				//  q = q.Where("null == null") as ILLBLGenProQuery; //To force an table alias
				//if (maxNumberOfItemsToReturn != 0)
				//  q = q.Take(maxNumberOfItemsToReturn) as ILLBLGenProQuery;
				ExecuteQueryAndReadEveryBindableProperty(q, errors);
			}
			catch (ORMQueryExecutionException e)
			{
				
				errors.AppendLine(query.ElementType.ToString());
				errors.AppendLine(e.Message);
				errors.AppendLine(e.QueryExecuted);
			}
			catch (ORMInheritanceInfoException e)
			{
				
				inheritanceErrors.AppendLine(query.ElementType.ToString());
				inheritanceErrors.AppendLine(e.Message);
			}
			catch (ArgumentException e)
			{
				
				errors.AppendLine(query.ElementType.ToString());
				errors.AppendLine(e.Message);
				errors.AppendLine(e.ParamName);
			}
			catch (DbException e)
			{
				
				errors.AppendLine(query.ElementType.ToString());
				errors.AppendLine(e.ErrorCode + " - " + e.Message);
				DynamicQueryEngineBase.Switch.Level = TraceLevel.Verbose;
				if (CheckEntityCanBeFetchedUsingLINQ(query, false, maxNumberOfItemsToReturn, errors, inheritanceErrors))
					errors.AppendLine("Plain query succeded");
			}
			catch (Exception e)
			{

				errors.AppendLine(query.ElementType.ToString());
				errors.AppendLine(e.Message);
			}
			return initalErrorlength == errors.Length;
		}

		/// <summary>
		/// Executes the query and read every bindable property.
		/// </summary>
		/// <param name="query">The query.</param>
		/// <param name="errors">The errors.</param>
		public static void ExecuteQueryAndReadEveryBindableProperty(ILLBLGenProQuery query, StringBuilder errors)
		{
			if (query != null)
			{
				var entityCollection = query.Execute() as IEntityCollection2;
				ReadEveryBindableProperty(entityCollection, errors);
			}
		}

		/// <summary>
		/// Reads the every bindable property.
		/// </summary>
		/// <param name="entityCollection">The entity collection.</param>
		/// <param name="errors">The errors.</param>
		public static void ReadEveryBindableProperty(IEntityCollection2 entityCollection, StringBuilder errors)
		{
			if (entityCollection != null)
				foreach (
					var invalidCastErrors in
						entityCollection.Cast<EntityBase2>().Select(ReadEveryBindableProperty)
							.Where(invalidCastErrors => invalidCastErrors.Length > 0))
				{
					errors.AppendLine(invalidCastErrors.ToString());
					break;
				}
		}

		/// <summary>
		/// 	Reads every bindable property of an entity to check it doesn't throw an exception.
		/// </summary>
		/// <param name = "entity">The entity.</param>
		/// <returns></returns>
		public static StringBuilder ReadEveryBindableProperty(IEntity2 entity)
		{
			var errors = new StringBuilder();
			foreach (var browsableProperty in MetaDataHelper.GetPropertiesToDisplay(entity.GetType()))
				try
				{
					browsableProperty.GetValue(entity);
				}
				catch (TargetInvocationException e)
				{
					if (e.InnerException is InvalidCastException)
					{
// ReSharper disable AccessToModifiedClosure
						var field = entity.Fields.GetFieldsFromEntityFields().Where(f => f.Name == browsableProperty.Name).FirstOrDefault();
// ReSharper restore AccessToModifiedClosure
						errors.AppendLine(e.Message);
						if (field != null)
							errors.AppendFormat("{0} of type {1} has a value of {2} is attempting to being cast to a {3}",
							                    field.Name, field.CurrentValue.GetType(), field.CurrentValue, browsableProperty.PropertyType);
						errors.AppendLine();
					}
					else
						throw;
				}
			return errors;
		}

		/// <summary>
		/// Gets the field information of the auditable entities.
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<FieldAndEntityInformation> GetEntityFieldInformation(IDataAccessAdapter adapter)
		{
			return FieldAndEntityInformation.FieldAndEntityInformationFactory(adapter,null).OrderBy(fi => fi.Entity).ThenBy(fi => fi.DisplayNames);
		}
	}

	/// <summary>
	/// Class to display info about an entity and it's fields and their display names
	/// </summary>
	[Serializable]
	public class EntityInformation
	{
		/// <summary>
		/// Gets or sets the entity name.
		/// </summary>
		/// <value>The entity.</value>
		public string Entity { get; private set; }

		/// <summary>
		/// Gets or sets the name of the SQL server table.
		/// </summary>
		/// <value>The name of the SQL server table.</value>
		public string SQLServerTableName { get; private set; }

		/// <summary>
		/// Gets or sets the name of the oracle table.
		/// </summary>
		/// <value>The name of the oracle table.</value>
		public string OracleTableName { get; private set; }

		/// <summary>
		/// Gets or sets the custom properties.
		/// </summary>
		/// <value>The custom properties.</value>
		public string CustomProperties { get; private set; }

		/// <summary>
		/// FieldInformation for the entity
		/// </summary>
		public IEnumerable<FieldAndEntityInformation> FieldInformation;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Object"/> class.
		/// </summary>
		public EntityInformation(IEntity2 entity)
		{
			Entity = entity.LLBLGenProEntityName.Replace("Entity", "");
			var fieldAndEntityInformations = from field in entity.Fields.GetFieldsFromEntityFields()
			                                 where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
			                                 select new FieldAndEntityInformation(entity.GetType(), field, entity.FieldsCustomPropertiesOfType[field.Name]);
			FieldInformation = fieldAndEntityInformations;
			var fieldAndEntityInformation = fieldAndEntityInformations.FirstOrDefault();
			if (fieldAndEntityInformation != null)
			{
				SQLServerTableName = fieldAndEntityInformation.SQLServerTableName;
			}
			CustomProperties = entity.CustomPropertiesOfType.Values.JoinAsString();
		}

		/// <summary>
		/// Entities the info factory.
		/// </summary>
		/// <param name="entityTypes">The entity types.</param>
		/// <returns></returns>
		public static IEnumerable<EntityInformation> EntityInfoFactory(EntityFactoryCore2 entityFactoryCore, IDataAccessAdapter adapter, params int[] entityTypes)
		{
			LLBL.FieldInformation.SQLServerDataAccessAdapter = adapter;
			if (entityTypes.IsNullOrEmpty())
				entityTypes = GeneralHelper.EnumAsEnumerable<int>();
			return from entityType in entityTypes
			       select EntityHelper.GetEntityTypeFromEntityTypeValue(entityFactoryCore, entityType)
			       into factory
							 select new EntityInformation(EntityHelper.CreateEntity(factory) as IEntity2);
		}
	}

	/// <summary>
	/// Class to display info about fields and their display names
	/// </summary>
	[Serializable]
	public class FieldInformation
	{
		internal static IDataAccessAdapter SQLServerDataAccessAdapter;
		internal IFieldPersistenceInfo SQLServerFieldPersistenceInfo;

		/// <summary>
		/// Factory to create FieldInformation for the supplied entity types.
		/// </summary>
		/// <param name="entities">The entities.</param>
		/// <returns></returns>
		public static IEnumerable<FieldInformation> FieldInfoFactory(IDataAccessAdapter adapter, List<Type> entities)
		{
			SQLServerDataAccessAdapter = adapter;
			return from entity in entities
			       from field in EntityHelper.GetFieldsFromType(entity).GetFieldsFromEntityFields()
			       where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
			       select new FieldInformation(entity, field);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldInformation"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="field">The field.</param>
		public FieldInformation(Type entity, IEntityField2 field) : this(entity, field, "")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldInformation"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="field">The field.</param>
		/// <param name="customProperties">The custom properties.</param>
		public FieldInformation(Type entity, IEntityField2 field, Dictionary<string, string> customProperties)
			: this(entity, field, customProperties.Values.JoinAsString())
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldInformation"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="field">The field.</param>
		/// <param name="customProperties">The custom properties.</param>
		public FieldInformation(Type entity, IEntityField2 field, string customProperties)
		{
			CustomProperties = customProperties;
			FieldName = field.Name;
			var displayNameAttributes = MetaDataHelper.GetDisplayNameAttributes(entity, field.Name);
			DisplayNames = displayNameAttributes.Select(dna => dna.DisplayName).JoinAsString();
			DisplayNameAttributeTypes = displayNameAttributes.JoinAsString();
			SQLServerFieldPersistenceInfo = GetFieldPersistenceInfoPublic(SQLServerDataAccessAdapter,field);
		}

		private IFieldPersistenceInfo GetFieldPersistenceInfoPublic(IDataAccessAdapter sqlServerDataAccessAdapter, IEntityField2 field)
		{
			return null;
		}

		/// <summary>
		/// Gets or sets the name of the field.
		/// </summary>
		/// <value>The name of the field.</value>
		public string FieldName { get; private set; }

		/// <summary>
		/// Gets or sets the display names.
		/// </summary>
		/// <value>The display names.</value>
		public string DisplayNames { get; private set; }

		/// <summary>
		/// Gets or sets the display name attribute types.
		/// </summary>
		/// <value>The display name attribute types.</value>
		public string DisplayNameAttributeTypes { get; private set; }

		/// <summary>
		/// Gets the name of the SQL server column.
		/// The name of the corresponding column in a view or table for an entityfield. This name is used to map a column in a resultset onto the entity field.
		/// </summary>
		/// <value>The name of the SQL server column.</value>
		public string SQLServerColumnName
		{
			get { return SQLServerFieldPersistenceInfo.SourceColumnName; }
		}

		/// <summary>
		/// Gets or sets the custom properties.
		/// </summary>
		/// <value>The custom properties.</value>
		public string CustomProperties { get; private set; }
	}

	/// <summary>
	/// Class to display info about fields and their display names and entities
	/// </summary>
	[Serializable]
	public class FieldAndEntityInformation : FieldInformation
	{
		/// <summary>
		/// Gets or sets the entity name.
		/// </summary>
		/// <value>The entity.</value>
		internal string Entity { get; private set; }

		/// <summary>
		/// Gets the name of the SQL server table.
		/// </summary>
		/// <value>The name of the SQL server table.</value>
		internal string SQLServerTableName
		{
			get { return SQLServerFieldPersistenceInfo.SourceObjectName; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldAndEntityInformation"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="field">The field.</param>
		/// <param name="customProperties">The custom properties.</param>
		public FieldAndEntityInformation(Type entity, IEntityField2 field, Dictionary<string, string> customProperties)
			: this(entity, field, customProperties.Values.JoinAsString())
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FieldAndEntityInformation"/> class.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="field">The field.</param>
		/// <param name="customProperties">The custom properties.</param>
		public FieldAndEntityInformation(Type entity, IEntityField2 field, string customProperties)
			: base(entity, field, customProperties)
		{
			Entity = field.ActualContainingObjectName.Replace("Entity", "");
		}

		/// <summary>
		/// Factory to create FieldAndEntityInformation for the supplied entity types.
		/// </summary>
		/// <param name="entities">The entities.</param>
		/// <returns></returns>
		public static IEnumerable<FieldAndEntityInformation> FieldAndEntityInformationFactory(IDataAccessAdapter adapter, List<Type> entities)
		{
			SQLServerDataAccessAdapter = adapter;
			return from entity in entities
			       from field in EntityHelper.GetFieldsFromType(entity).GetFieldsFromEntityFields()
			       where field.ContainingObjectName.Equals(field.ActualContainingObjectName)
			       select new FieldAndEntityInformation(entity, field, "");
		}
	}
}