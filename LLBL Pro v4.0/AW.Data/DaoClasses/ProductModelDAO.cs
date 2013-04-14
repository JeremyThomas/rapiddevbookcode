///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
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

	/// <summary>General DAO class for the ProductModel Entity. It will perform database oriented actions for a entity of type 'ProductModelEntity'.</summary>
	public partial class ProductModelDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public ProductModelDAO() : base(InheritanceHierarchyType.None, "ProductModelEntity", new ProductModelEntityFactory())
		{
		}





		/// <summary>Retrieves in the calling ProductModelCollection object all ProductModelEntity objects which are related via a relation of type 'm:n' with the passed in IllustrationEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="illustrationInstance">IllustrationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingIllustrations(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity illustrationInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(ProductModelEntity.Relations.ProductModelIllustrationEntityUsingProductModelID, "ProductModelIllustration_");
			relations.Add(ProductModelIllustrationEntity.Relations.IllustrationEntityUsingIllustrationID, "ProductModelIllustration_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(illustrationInstance.Fields[(int)IllustrationFieldIndex.IllustrationID], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}

		/// <summary>Retrieves in the calling ProductModelCollection object all ProductModelEntity objects which are related via a relation of type 'm:n' with the passed in ProductDescriptionEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="productDescriptionInstance">ProductDescriptionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingDescriptions(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity productDescriptionInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID, "ProductModelProductDescriptionCulture_");
			relations.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(productDescriptionInstance.Fields[(int)ProductDescriptionFieldIndex.ProductDescriptionID], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}

		/// <summary>Retrieves in the calling ProductModelCollection object all ProductModelEntity objects which are related via a relation of type 'm:n' with the passed in ProductSubcategoryEntity.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiUsingSubcategories(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IEntity productSubcategoryInstance, IPrefetchPath prefetchPathToUse, int pageNumber, int pageSize)
		{
			RelationCollection relations = new RelationCollection();
			relations.Add(ProductModelEntity.Relations.ProductEntityUsingProductModelID, "Product_");
			relations.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, "Product_", string.Empty, JoinHint.None);
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(productSubcategoryInstance.Fields[(int)ProductSubcategoryFieldIndex.ProductSubcategoryID], ComparisonOperator.Equal));
			return this.GetMulti(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, entityFactoryToUse, selectFilter, relations, prefetchPathToUse, pageNumber, pageSize);
		}



		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
