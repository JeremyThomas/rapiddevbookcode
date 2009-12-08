using System;
using System.Collections.Generic;
using System.Linq;
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

		/// <summary>
		/// Gets a entity field enumeration from entity fields.
		/// </summary>
		/// <param name="entityFields">The entity fields.</param>
		/// <returns>entity field enumeration</returns>
		public static IEnumerable<IEntityField> GetFieldsFromEntityFields(this IEntityFields entityFields)
		{
			return entityFields.Cast<IEntityField>();
		}

		public static IEnumerable<IEntityField> GetChangedFields(IEntity entity)
		{
			return entity.IsDirty ? GetFieldsFromEntityFields(entity.Fields).Where(f => f.IsChanged) : null;
		}

		public static int GetNumberOfChangedFields(IEntity entity)
		{
			return entity.IsDirty ? GetFieldsFromEntityFields(entity.Fields).Count(f => f.IsChanged) : 0;
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
	}
}