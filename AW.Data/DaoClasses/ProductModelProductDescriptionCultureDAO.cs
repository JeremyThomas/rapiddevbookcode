///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.HelperClasses;
using AW.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace AW.Data.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>General DAO class for the ProductModelProductDescriptionCulture Entity. It will perform database oriented actions for a entity of type 'ProductModelProductDescriptionCultureEntity'.</summary>
	public partial class ProductModelProductDescriptionCultureDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public ProductModelProductDescriptionCultureDAO() : base(InheritanceHierarchyType.None, "ProductModelProductDescriptionCultureEntity", new ProductModelProductDescriptionCultureEntityFactory())
		{
		}



		/// <summary>Retrieves in the calling ProductModelProductDescriptionCultureCollection object all ProductModelProductDescriptionCultureEntity objects which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter. </summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="cultureInstance">CultureEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to return</param>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to return</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to return</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		public bool GetMulti(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IPredicateExpression filter, IEntity cultureInstance, IEntity productDescriptionInstance, IEntity productModelInstance, int pageNumber, int pageSize)
		{
			this.EntityFactoryToUse = entityFactoryToUse;
			IEntityFields fieldsToReturn = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductModelProductDescriptionCultureEntity);
			IPredicateExpression selectFilter = CreateFilterUsingForeignKeys(cultureInstance, productDescriptionInstance, productModelInstance, fieldsToReturn);
			if(filter!=null)
			{
				selectFilter.AddWithAnd(filter);
			}
			return this.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, null, null, pageNumber, pageSize);
		}




		/// <summary>Deletes from the persistent storage all 'ProductModelProductDescriptionCulture' entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="cultureInstance">CultureEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to delete</param>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to delete</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to delete</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(ITransaction containingTransaction, IEntity cultureInstance, IEntity productDescriptionInstance, IEntity productModelInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductModelProductDescriptionCultureEntity);
			IPredicateExpression deleteFilter = CreateFilterUsingForeignKeys(cultureInstance, productDescriptionInstance, productModelInstance, fields);
			return this.DeleteMulti(containingTransaction, deleteFilter);
		}

		/// <summary>Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		/// of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated.</summary>
		/// <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="cultureInstance">CultureEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to update</param>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to update</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects to update</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(IEntity entityWithNewValues, ITransaction containingTransaction, IEntity cultureInstance, IEntity productDescriptionInstance, IEntity productModelInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductModelProductDescriptionCultureEntity);
			IPredicateExpression updateFilter = CreateFilterUsingForeignKeys(cultureInstance, productDescriptionInstance, productModelInstance, fields);
			return this.UpdateMulti(entityWithNewValues, containingTransaction, updateFilter);
		}

		/// <summary>Creates a PredicateExpression which should be used as a filter when any combination of available foreign keys is specified.</summary>
		/// <param name="cultureInstance">CultureEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects</param>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductModelProductDescriptionCultureEntity objects</param>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		/// <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		private IPredicateExpression CreateFilterUsingForeignKeys(IEntity cultureInstance, IEntity productDescriptionInstance, IEntity productModelInstance, IEntityFields fieldsToReturn)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			
			if(cultureInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)ProductModelProductDescriptionCultureFieldIndex.CultureID], ComparisonOperator.Equal, ((CultureEntity)cultureInstance).CultureID));
			}
			if(productDescriptionInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID], ComparisonOperator.Equal, ((ProductDescriptionEntity)productDescriptionInstance).ProductDescriptionID));
			}
			if(productModelInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID], ComparisonOperator.Equal, ((ProductModelEntity)productModelInstance).ProductModelID));
			}
			return selectFilter;
		}
		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
