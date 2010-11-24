using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	public static class EntityHelper
	{
		/// <summary>
		/// returns the datasource to use in a Linq query for the entity type specified
		/// </summary>
		/// <typeparam name="T">the type of the entity to get the datasource for</typeparam>
		/// <param name="entity">The entity.</param>
		/// <param name="linqMetaData">The linq meta data.</param>
		/// <returns>the requested datasource</returns>
		public static DataSourceBase<T> GetQueryableForEntity<T>(this ILinqMetaData linqMetaData, T entity) where T : class, IEntityCore
		{
			return linqMetaData.GetQueryableForEntity(entity.LLBLGenProEntityTypeValue) as DataSourceBase<T>;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="T">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public static DataSourceBase<T> GetQueryableForEntity<T>(this ILinqMetaData linqMetaData) where T : class, IEntityCore
		{
			return linqMetaData.GetQueryableForEntity(CreateEntity<T>());
		}

		public static IDataSource GetQueryableForEntity(this ILinqMetaData linqMetaData, Type typeOfEntity)
		{
			try
			{
				var entityTypeValueForType = GetEntityTypeValueForType(typeOfEntity);
				return linqMetaData.GetQueryableForEntity(entityTypeValueForType);
			}
			catch (Exception)
			{
				try
				{
					for (var entityTypeValueForType = 0; entityTypeValueForType < Int32.MaxValue; entityTypeValueForType++)
					{
						var queryableForEntity = linqMetaData.GetQueryableForEntity(entityTypeValueForType);
						if (queryableForEntity.ElementType == typeOfEntity)
							return queryableForEntity;
					}
				}
				catch (Exception)
				{
					return null;
				}
			}
			return null;
		}

		/// <summary>
		/// Creates the entity from the .NET type specified. 
		/// </summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>An instance of the type.</returns>
		public static IEntityCore CreateEntity(Type typeOfEntity)
		{
			return Activator.CreateInstance(typeOfEntity) as IEntityCore;
		}

		/// <summary>
		/// Creates the entity from the .NET type specified. 
		/// </summary>
		/// <typeparam name="T">The type of entity.</typeparam>
		/// <returns>An instance of the type.</returns>
		public static T CreateEntity<T>() where T : class, IEntityCore
		{
			return CreateEntity(typeof (T)) as T;
		}

		/// <summary>
		/// Gets the EntityType value as integer for the entity type passed in
		/// </summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the EntityType value as integer for the entity type passed in</returns>
		public static int GetEntityTypeValueForType(Type typeOfEntity)
		{
			var entity = CreateEntity(typeOfEntity);
			return entity == null ? 0 : entity.LLBLGenProEntityTypeValue;
		}

		public static Type GetEntityTypeFromEntityTypeValue(IEntityFactoryCore entityFactoryCore, int entityTypeValue)
		{
			var entityFactory = entityFactoryCore as EntityFactoryCore;
			if (entityFactory != null)
			{
				var entity = entityFactory.CreateEntityFromEntityTypeValue(entityTypeValue);
				return entity == null ? null : entity.GetType();
			}
			var entityFactory2 = entityFactoryCore as EntityFactoryCore2;
			if (entityFactory2 != null)
			{
				var entity = entityFactory2.CreateEntityFromEntityTypeValue(entityTypeValue);
				return entity == null ? null : entity.GetType();
			}
			return null;
		}

		public static int GetEntityTypeValueForType<T>() where T : class, IEntityCore
		{
			return GetEntityTypeValueForType(typeof (T));
		}

		public static IEnumerable<Type> GetEntitiesTypes(Type baseType)
		{
			return MetaDataHelper.GetDescendance(baseType);
		}

		public static IEnumerable<Type> GetEntitiesTypes()
		{
			return MetaDataHelper.GetAllLoadedDescendance(typeof (IEntityCore));
		}

		public static IEnumerable<Type> GetEntitiesTypes(Assembly entityAssembly)
		{
			return typeof (IEntityCore).GetAssignable(entityAssembly.GetExportedTypes());
		}

		public static IEnumerable<Type> GetEntitiesTypes(ILinqMetaData linqMetaData)
		{
			return GetEntitiesTypes(linqMetaData.GetType().Assembly);
		}

		#region Self Servicing

		/// <summary>
		/// Executes the query this object represents and returns its results in its native container - an entity collection.
		/// </summary>
		/// <typeparam name="T">EntityBase2</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>Results of the query in an entity collection.</returns>
		public static EntityCollectionBase<T> ToEntityCollection<T>(this IQueryable<T> query) where T : EntityBase
		{
			var llblQuery = query as ILLBLGenProQuery;
			return llblQuery == null ? ((IEnumerable<T>) query).ToEntityCollection() : llblQuery.Execute<EntityCollectionBase<T>>();
		}

		/// <summary>
		/// Converts an entity enumeration to an entity collection.
		/// </summary>
		/// <typeparam name="T">EntityBase2</typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <returns></returns>
		public static EntityCollectionBase<T> ToEntityCollection<T>(this IEnumerable<T> enumerable) where T : EntityBase
		{
			if (enumerable.Count() == 0)
				return GetFactory<T>().CreateEntityCollection() as EntityCollectionBase<T>;
			var entities = ((IEntity) enumerable.First()).GetEntityFactory().CreateEntityCollection() as EntityCollectionBase<T>;
			if (entities != null)
				entities.AddRange(enumerable);
			return entities;
		}

		public static IEntityCollection ToEntityCollection(IEnumerable enumerable, Type itemType)
		{
			IEntityCollection entities = null;
			var llblQuery = enumerable as ILLBLGenProQuery;
			if (llblQuery != null)
				entities = llblQuery.Execute() as IEntityCollection;
			if (entities == null)
			{
				var enumerator = enumerable.GetEnumerator();
				if (enumerator.MoveNext())
				{
					var firstEntity = ((IEntity) enumerator.Current);
					if (firstEntity != null)
					{
						entities = firstEntity.GetEntityFactory().CreateEntityCollection();
						if (entities == null)
							return null;
						foreach (IEntity item in enumerable)
							entities.Add(item);
					}
				}
			}
			if (entities == null)
				entities = ((IEntity) CreateEntity(itemType)).GetEntityFactory().CreateEntityCollection();
			if (entities.Count > 0)
				entities.RemovedEntitiesTracker = entities.EntityFactoryToUse.CreateEntityCollection();
			return entities;
		}

		public static IBindingListView CreateEntityView(IEnumerable enumerable, Type itemType)
		{
			var entityCollection = ToEntityCollection(enumerable, itemType);
			return entityCollection == null ? null : entityCollection.DefaultView as IBindingListView;
		}

		/// <summary>
		/// Gets the entity field from the name of the field.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>the entity field</returns>
		public static IEntityField GetFieldFromFieldName(IEntity entity, string fieldName)
		{
			return entity.Fields[fieldName] ?? entity.Fields.Cast<IEntityField>().FirstOrDefault(ef => ef.Name.Equals(fieldName, StringComparison.InvariantCultureIgnoreCase));
		}

		/// <summary>
		/// Gets a entity field enumeration from entity fields.
		/// </summary>
		/// <param name="entityFields">The entity fields.</param>
		/// <returns>entity field enumeration</returns>
		public static IEnumerable<IEntityField> GetFieldsFromEntityFields(this IEntityFields entityFields)
		{
			return entityFields.Cast<IEntityField>();
		}

		/// <summary>
		/// Gets a entity field enumeration from entity fields.
		/// </summary>
		/// <param name="entityFields">The entity fields.</param>
		/// <returns>entity field enumeration</returns>
		public static IEnumerable<IEntityField2> GetFieldsFromEntityFields(this IEntityFields2 entityFields)
		{
			return entityFields.Cast<IEntityField2>();
		}

		public static IEnumerable<IEntityField> GetChangedFields(this IEntity entity)
		{
			return entity.IsDirty ? GetFieldsFromEntityFields(entity.Fields).Where(f => f.IsChanged) : new EntityFields(0);
		}

		public static IEnumerable<IEntityField2> GetChangedFields(this IEntity2 entity)
		{
			return entity.IsDirty ? GetFieldsFromEntityFields(entity.Fields).Where(f => f.IsChanged) : new EntityFields2(0);
		}

		//public static IEnumerable<T> GetChangedFields<T> (this IEntityCore entity) where T : IEntityFieldCore
		//{
		//  return entity is IEntity ? (IEnumerable<T>)GetChangedFields((IEntity)entity) : (IEnumerable<T>)GetChangedFields((IEntity2)entity);
		//}

		public static int GetNumberOfChangedFields(this IEntity entity)
		{
			return entity.IsDirty ? GetFieldsFromEntityFields(entity.Fields).Count(f => f.IsChanged) : 0;
		}

		private static void RevertChangesToDBValue(this IEntity entity)
		{
			foreach (var changedField in entity.GetChangedFields())
				changedField.ForcedCurrentValueWrite(changedField.DbValue, changedField.DbValue);
			entity.IsDirty = false;
		}

		private static void RevertChangesToDBValue(this IEntity2 entity)
		{
			foreach (var changedField in entity.GetChangedFields())
				changedField.ForcedCurrentValueWrite(changedField.DbValue, changedField.DbValue);
			entity.IsDirty = false;
		}

		public static void RevertChangesToDBValue(this IEntityCore entity)
		{
			if (entity is IEntity)
				RevertChangesToDBValue((IEntity) entity);
			else
				RevertChangesToDBValue((IEntity2) entity);
		}

		public static void RevertChangesToDBValue(this IEntityCollection entityCollection)
		{
			foreach (var dirtyEntity in entityCollection.DirtyEntities)
				dirtyEntity.RevertChangesToDBValue();
			var newEntities = entityCollection.Cast<IEntity>().Where(e => e.IsNew).ToList();
			foreach (var newEntity in newEntities)
				entityCollection.Remove(newEntity);
		}

		public static void RevertChangesToDBValue(this IEntityCollection2 entityCollection)
		{
			foreach (var dirtyEntity in entityCollection.DirtyEntities)
				dirtyEntity.RevertChangesToDBValue();
			var newEntities = entityCollection.Cast<IEntity2>().Where(e => e.IsNew).ToList();
			foreach (var newEntity in newEntities)
				entityCollection.Remove(newEntity);
		}

		public static void RevertChangesToDBValue<T>(IEnumerable<T> entities) where T : class, IEntityCore
		{
			foreach (var dirtyEntity in entities.Where(e => e.IsDirty))
				dirtyEntity.RevertChangesToDBValue();
		}

		public static void RevertChangesToDBValue(IEnumerable modifiedEntities)
		{
			if (modifiedEntities is IEntityView)
				modifiedEntities = ((IEntityView) modifiedEntities).RelatedCollection;
			if (modifiedEntities is IEntityView2)
				modifiedEntities = ((IEntityView2) modifiedEntities).RelatedCollection;
			if (modifiedEntities is IEntityCollection)
			{
				var entityCollection = (IEntityCollection) modifiedEntities;
				if (entityCollection.RemovedEntitiesTracker != null)
					entityCollection.AddRange(entityCollection.RemovedEntitiesTracker);
				RevertChangesToDBValue(entityCollection);
				if (entityCollection.RemovedEntitiesTracker != null)
					entityCollection.RemovedEntitiesTracker.Clear();
			}
			else if (modifiedEntities is IEntityCollection2)
			{
				var entityCollection = (IEntityCollection2) modifiedEntities;
				if (entityCollection.RemovedEntitiesTracker != null)
					entityCollection.AddRange(entityCollection.RemovedEntitiesTracker);
				RevertChangesToDBValue(entityCollection);
				if (entityCollection.RemovedEntitiesTracker != null)
					entityCollection.RemovedEntitiesTracker.Clear();
			}
			else
				RevertChangesToDBValue(modifiedEntities.Cast<IEntityCore>());
		}

		public static void Undo(object modifiedData)
		{
			var listItemType = ListBindingHelper.GetListItemType(modifiedData);
			if (typeof (IEntityCore).IsAssignableFrom(listItemType))
			{
				var enumerable = modifiedData as IEnumerable;
				if (enumerable == null)
				{
					if (modifiedData is IEntity)
						RevertChangesToDBValue((IEntity) modifiedData);
					else
						RevertChangesToDBValue((IEntity2) modifiedData);
				}
				else
					RevertChangesToDBValue(enumerable);
			}
		}

		/// <summary>
		/// Gets the factory of the entity with the .NET type specified
		/// </summary>
		/// <typeparam name="T">The type of entity.</typeparam>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory<T>() where T : EntityBase
		{
			return ((IEntity) CreateEntity<T>()).GetEntityFactory();
		}

		/// <summary>
		/// Deletes the entities.
		/// </summary>
		/// <param name="entitiesToDelete">The entities to delete.</param>
		/// <returns></returns>
		public static int DeleteEntities(IEnumerable entitiesToDelete)
		{
			if (entitiesToDelete is EntityCollectionBase<EntityBase>)
				return ((EntityCollectionBase<EntityBase>) entitiesToDelete).DeleteMulti();
			return entitiesToDelete.Cast<EntityBase>().Count(entity => entity.Delete() || entity.IsNew);
		}

		/// <summary>
		/// Deletes the specified data from the DB.
		/// </summary>
		/// <param name="dataToDelete">The data to delete.</param>
		/// <returns></returns>
		public static int Delete(object dataToDelete)
		{
			var listItemType = ListBindingHelper.GetListItemType(dataToDelete);
			if (typeof (IEntity).IsAssignableFrom(listItemType))
			{
				var enumerable = dataToDelete as IEnumerable;
				return enumerable == null ? Convert.ToInt32(((IEntity) dataToDelete).Delete()) : DeleteEntities(enumerable);
			}
			return 0;
		}

		/// <summary>
		/// Saves all dirty objects inside the enumeration passed to the persistent storage.
		/// </summary>
		/// <param name="entitiesToSave">The entities to save.</param>
		/// <returns>the amount of persisted entities</returns>
		public static int SaveEntities(IEnumerable entitiesToSave)
		{
			if (entitiesToSave is IEntityView)
				entitiesToSave = ((IEntityView) entitiesToSave).RelatedCollection;
			if (entitiesToSave is IEntityCollection)
			{
				var entityCollection = (IEntityCollection) entitiesToSave;
				var modifyCount = 0;
				if (entityCollection.RemovedEntitiesTracker != null)
					modifyCount = entityCollection.RemovedEntitiesTracker.DeleteMulti();
				return modifyCount + entityCollection.SaveMulti();
			}
			return entitiesToSave.Cast<EntityBase>().Count(entity => entity.IsDirty && entity.Save());
		}

		/// <summary>
		/// Saves any changes to the specified data to the DB.
		/// </summary>
		/// <param name="dataToSave">The data to save, must be a CommonEntityBase or a list of CommonEntityBase's.</param>
		/// <returns>The number of persisted entities.</returns>
		public static int Save(object dataToSave)
		{
			var listItemType = ListBindingHelper.GetListItemType(dataToSave);
			if (typeof (IEntity).IsAssignableFrom(listItemType))
			{
				var enumerable = dataToSave as IEnumerable;
				return enumerable == null ? Convert.ToInt32(((IEntity) dataToSave).Save()) : SaveEntities(enumerable);
			}
			return 0;
		}

		#endregion

		#region Adapter

		/// <summary>
		/// Saves all dirty objects inside the enumeration passed to the persistent storage.
		/// </summary>
		/// <param name="entitiesToSave">The entities to save.</param>
		/// <param name="dataAccessAdapter">The data access adapter.</param>
		/// <returns>the amount of persisted entities</returns>
		public static int SaveEntities(IEnumerable entitiesToSave, IDataAccessAdapter dataAccessAdapter)
		{
			if (entitiesToSave is IEntityView2)
				entitiesToSave = ((IEntityView2) entitiesToSave).RelatedCollection;
			if (entitiesToSave is IEntityCollection2)
			{
				var entityCollection = (IEntityCollection2) entitiesToSave;
				var modifyCount = 0;
				if (entityCollection.RemovedEntitiesTracker != null)
					modifyCount = dataAccessAdapter.DeleteEntityCollection(entityCollection.RemovedEntitiesTracker);
				return modifyCount + dataAccessAdapter.SaveEntityCollection((IEntityCollection2) entitiesToSave);
			}
			return SaveEntities(entitiesToSave.Cast<IEntity2>(), dataAccessAdapter);
		}

		/// <summary>
		/// Saves all dirty objects inside the enumeration passed to the persistent storage.
		/// </summary>
		/// <param name="entitiesToSave">The entities to save.</param>
		/// <param name="dataAccessAdapter">The data access adapter.</param>
		/// <returns>the amount of persisted entities</returns>
		public static int SaveEntities(IEnumerable<IEntity2> entitiesToSave, IDataAccessAdapter dataAccessAdapter)
		{
			return entitiesToSave.Count(entity => entity.IsDirty && dataAccessAdapter.SaveEntity(entity));
		}

		/// <summary>
		/// Saves any changes to the specified data to the DB.
		/// </summary>
		/// <param name="dataToSave">The data to save, must be a CommonEntityBase or a list of CommonEntityBase's.</param>
		/// <param name="dataAccessAdapter">The data access adapter.</param>
		/// <returns>The number of persisted entities.</returns>
		public static int Save(object dataToSave, IDataAccessAdapter dataAccessAdapter)
		{
			var listItemType = ListBindingHelper.GetListItemType(dataToSave);
			if (typeof (IEntity2).IsAssignableFrom(listItemType))
			{
				var enumerable = dataToSave as IEnumerable;
				return enumerable == null ? Convert.ToInt32(dataAccessAdapter.SaveEntity((IEntity2) dataToSave)) : SaveEntities(enumerable, dataAccessAdapter);
			}
			return 0;
		}

		/// <summary>
		/// Deletes all entities inside the enumeration passed from the DB.
		/// </summary>
		/// <param name="entitiesToDelete">The entities to delete.</param>
		/// <param name="dataAccessAdapter">The data access adapter.</param>
		/// <returns>the amount of persisted entities</returns>
		public static int DeleteEntities(IEnumerable<IEntity2> entitiesToDelete, IDataAccessAdapter dataAccessAdapter)
		{
			return entitiesToDelete.Count(dataAccessAdapter.DeleteEntity);
		}

		/// <summary>
		/// Deletes the entities.
		/// </summary>
		/// <param name="entitiesToDelete">The entities to delete.</param>
		/// <param name="dataAccessAdapter">The data access adapter.</param>
		/// <returns></returns>
		public static int DeleteEntities(IEnumerable entitiesToDelete, IDataAccessAdapter dataAccessAdapter)
		{
			if (entitiesToDelete is IEntityCollection2)
				return dataAccessAdapter.DeleteEntityCollection((IEntityCollection2) entitiesToDelete);
			return DeleteEntities(entitiesToDelete.Cast<IEntity2>(), dataAccessAdapter);
		}

		public static int Delete(object dataToDelete, IDataAccessAdapter dataAccessAdapter)
		{
			var listItemType = ListBindingHelper.GetListItemType(dataToDelete);
			if (typeof (IEntity2).IsAssignableFrom(listItemType))
			{
				var enumerable = dataToDelete as IEnumerable;
				return enumerable == null ? Convert.ToInt32(dataAccessAdapter.DeleteEntity((IEntity2) dataToDelete)) : DeleteEntities(enumerable, dataAccessAdapter);
			}
			return 0;
		}

		/// <summary>
		/// Gets the data access adapter from a ILinqMetaData.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="linqMetaData">The linq meta data.</param>
		/// <returns></returns>
		public static IDataAccessAdapter GetDataAccessAdapter<T>(ILinqMetaData linqMetaData) where T : EntityBase2
		{
			return GetDataAccessAdapter(GetQueryableForEntity<T>(linqMetaData) as DataSource2<T>);
		}

		/// <summary>
		/// 	Gets the data access adapter from a DataSource2.
		/// </summary>
		/// <typeparam name = "T"></typeparam>
		/// <param name = "query">The query.</param>
		/// <returns></returns>
		public static IDataAccessAdapter GetDataAccessAdapter<T>(DataSource2<T> query) where T : EntityBase2
		{
			return query == null ? null : GetDataAccessAdapter(query.Provider);
		}

		/// <summary>
		/// Gets the data access adapter from a query.
		/// </summary>
		/// <param name="query">The query.</param>
		/// <returns></returns>
		public static IDataAccessAdapter GetDataAccessAdapter(IQueryable query)
		{
			return GetDataAccessAdapter(query.Provider);
		}

		/// <summary>
		/// 	Gets the data access adapter from a LLBLGenProProvider2.
		/// </summary>
		/// <param name = "provider">The provider.</param>
		/// <returns></returns>
		public static IDataAccessAdapter GetDataAccessAdapter(IQueryProvider provider)
		{
			var llblGenProProvider2 = provider as LLBLGenProProvider2;
			return llblGenProProvider2 == null ? null : llblGenProProvider2.AdapterToUse;
		}

		public static IEntityCollection2 ToEntityCollection2(IEnumerable enumerable, Type itemType)
		{
			IEntityCollection2 entities = null;
			var llblQuery = enumerable as ILLBLGenProQuery;
			if (llblQuery != null)
				entities = llblQuery.Execute() as IEntityCollection2;
			if (entities == null)
			{
				var enumerator = enumerable.GetEnumerator();
				if (enumerator.MoveNext())
				{
					var firstEntity = ((IEntity2) enumerator.Current);
					if (firstEntity != null)
					{
						entities = firstEntity.GetEntityFactory().CreateEntityCollection();
						if (entities == null)
							return null;
						foreach (IEntity2 item in enumerable)
							entities.Add(item);
					}
				}
			}
			if (entities == null)
				entities = ((IEntity2) CreateEntity(itemType)).GetEntityFactory().CreateEntityCollection();
			if (entities.Count > 0)
				entities.RemovedEntitiesTracker = entities.EntityFactoryToUse.CreateEntityCollection();
			return entities;
		}

		public static IBindingListView CreateEntityView2(IEnumerable enumerable, Type itemType)
		{
			var entityCollection = ToEntityCollection2(enumerable, itemType);
			return entityCollection == null ? null : entityCollection.DefaultView as IBindingListView;
		}

		#endregion

		/// <summary>
		/// Gets the properties of type entity since sometimes these properties are not browsable so they need to be handled as a special case.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesOfTypeEntity(Type type)
		{
			return from propertyDescriptor in TypeDescriptor.GetProperties(type, null).Cast<PropertyDescriptor>()
			       where typeof (IEntityCore).IsAssignableFrom(propertyDescriptor.PropertyType)
			       select propertyDescriptor;
		}
	}
}