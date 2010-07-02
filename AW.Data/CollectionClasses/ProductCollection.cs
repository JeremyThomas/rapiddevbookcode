///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
#if !CF
using System.Runtime.Serialization;
#endif

using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.CollectionClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Collection class for storing and retrieving collections of ProductEntity objects. </summary>
	[Serializable]
	public partial class ProductCollection : EntityCollectionBase<ProductEntity>
	{
		/// <summary> CTor</summary>
		public ProductCollection():base(new ProductEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public ProductCollection(IList<ProductEntity> initialContents):base(new ProductEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, base.MaxNumberOfItemsToReturn, base.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, base.MaxNumberOfItemsToReturn, base.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (productModelInstance!=null);
			validParameters |= (productSubcategoryInstance!=null);
			validParameters |= (unitMeasureInstance!=null);
			validParameters |= (unitMeasure_Instance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, filter, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all Product entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.DeleteMulti(base.Transaction, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance);
		}

		/// <summary> Updates in the persistent storage all Product entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">ProductEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(ProductEntity entityWithNewValues, IEntity productModelInstance, IEntity productSubcategoryInstance, IEntity unitMeasureInstance, IEntity unitMeasure_Instance)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocumentCollectionViaProductDocument(IEntity documentInstance)
		{
			return GetMultiManyToManyUsingDocumentCollectionViaProductDocument(documentInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocumentCollectionViaProductDocument(IEntity documentInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDocumentCollectionViaProductDocument(documentInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingDocumentCollectionViaProductDocument(IEntity documentInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingDocumentCollectionViaProductDocument(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, documentInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocumentCollectionViaProductDocument(IEntity documentInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDocumentCollectionViaProductDocument(documentInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocumentCollectionViaProductDocument(IEntity documentInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingDocumentCollectionViaProductDocument(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, documentInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocationCollectionViaProductInventory(IEntity locationInstance)
		{
			return GetMultiManyToManyUsingLocationCollectionViaProductInventory(locationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocationCollectionViaProductInventory(IEntity locationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingLocationCollectionViaProductInventory(locationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingLocationCollectionViaProductInventory(IEntity locationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingLocationCollectionViaProductInventory(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, locationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocationCollectionViaProductInventory(IEntity locationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingLocationCollectionViaProductInventory(locationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocationCollectionViaProductInventory(IEntity locationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingLocationCollectionViaProductInventory(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, locationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(IEntity productPhotoInstance)
		{
			return GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(productPhotoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(productPhotoInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingProductPhotoCollectionViaProductProductPhoto(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productPhotoInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(IEntity productPhotoInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(productPhotoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhotoCollectionViaProductProductPhoto(IEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingProductPhotoCollectionViaProductProductPhoto(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productPhotoInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(IEntity purchaseOrderHeaderInstance)
		{
			return GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(purchaseOrderHeaderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(IEntity purchaseOrderHeaderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(purchaseOrderHeaderInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(IEntity purchaseOrderHeaderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, purchaseOrderHeaderInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(IEntity purchaseOrderHeaderInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(purchaseOrderHeaderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(IEntity purchaseOrderHeaderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, purchaseOrderHeaderInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(IEntity scrapReasonInstance)
		{
			return GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(scrapReasonInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(IEntity scrapReasonInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(scrapReasonInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(IEntity scrapReasonInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingScrapReasonCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, scrapReasonInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(IEntity scrapReasonInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(scrapReasonInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReasonCollectionViaWorkOrder(IEntity scrapReasonInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingScrapReasonCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, scrapReasonInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(IEntity specialOfferInstance)
		{
			return GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(specialOfferInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(specialOfferInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingSpecialOfferCollectionViaSpecialOfferProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, specialOfferInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(IEntity specialOfferInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(specialOfferInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOfferCollectionViaSpecialOfferProduct(IEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingSpecialOfferCollectionViaSpecialOfferProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, specialOfferInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(IEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(unitMeasureInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaBillOfMaterials(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(IEntity unitMeasureInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaBillOfMaterials(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(IEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(unitMeasureInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaBillOfMaterials_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(IEntity unitMeasureInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaBillOfMaterials_(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaBillOfMaterials_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(IEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(unitMeasureInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(IEntity unitMeasureInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasureCollectionViaProductVendor(IEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasureCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, unitMeasureInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  Relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingVendorCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, vendorInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a Relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ProductCollection object all ProductEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingVendorCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, vendorInstance, prefetchPathToUse);
		}


		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, null, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0);
		}
		
		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations, int pageNumber, int pageSize)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are
		/// applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, groupByClause);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="relations">The relations to walk</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public virtual object GetScalar(ProductFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
		{
			EntityFields fields = new EntityFields(1);
			fields[0] = EntityFieldFactory.Create(fieldIndex);
			if((fields[0].ExpressionToApply == null) || (expressionToExecute != null))
			{
				fields[0].ExpressionToApply = expressionToExecute;
			}
			if((fields[0].AggregateFunctionToApply == AggregateFunction.None) || (aggregateToApply != AggregateFunction.None))
			{
				fields[0].AggregateFunctionToApply = aggregateToApply;
			}
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}


		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
