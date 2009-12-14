using System;
using System.Diagnostics.CodeAnalysis;
using AW.Data.FactoryClasses;
using AW.Helper;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	public static class FactoryHelper
	{
		/// <summary>Gets the factory of the entity with the EntityTypeName specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(string typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity.ToEnum<EntityType>());
		}

		/// <summary>Gets the factory of the entity with the integer version of AQD.Model.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(int typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory((EntityType)typeOfEntity);
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

    /// <summary>
    /// Gets the factory of the entity with the .NET type specified
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <returns>factory to use or null if not found</returns>
    public static IEntityFactory GetFactory<T>() where T : class, IEntityCore
    {
      return GetFactory(typeof(T));
    }

		/// <summary>
		/// Creates the entity from the .NET type specified. Rather than use Activator.CreateInstance(typeOfEntity) directly.
		/// </summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>An instance of the type.</returns>
		public static IEntity CreateEntity(Type typeOfEntity)
		{
			return GetFactory(typeOfEntity).Create();
		}

		/// <summary>
		/// Creates the entity from the .NET type specified. Rather than use Activator.CreateInstance(typeOfEntity) directly.
		/// </summary>
		/// <typeparam name="T">The type of entity.</typeparam>
		/// <returns>An instance of the type.</returns>
		public static T CreateEntity<T>() where T : class, IEntityCore
		{
			return CreateEntity(typeof (T)) as T;
		}

		/// <summary>
		/// Gets the .NET type from the AQD.Model.EntityType specified.
		/// </summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>.NET type fo the entity or null if not found</returns>
		public static Type GetTypeFromEntityTypeEnum(EntityType typeOfEntity)
		{
			var ef = EntityFactoryFactory.GetFactory(typeOfEntity);
			return ef != null ? ef.Create().GetType() : null;
		}

		public static IEntityFields GetFieldsFromType(Type type)
		{
			var ef = GetFactory(type);
//			return ef.Create().Fields;
			return ef.CreateFields();
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

    public static EntityType GetEntityTypeValueForType<T>() where T : class, IEntityCore
    {
      return (EntityType)GetEntityTypeValueForType(typeof(T));
    }

    public static EntityCollectionBase<T> CreateEntityCollection<T>() where T : EntityBase
    {
      return GeneralEntityCollectionFactory.Create(GetEntityTypeValueForType<T>())as EntityCollectionBase<T>;
    }

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="T">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public static DataSourceBase<T> GetQueryableForEntity<T>(this ILinqMetaData linqMetaData) where T : class, IEntityCore
		{
			return linqMetaData.GetQueryableForEntity(CreateEntity<T>());
		}
	}
}