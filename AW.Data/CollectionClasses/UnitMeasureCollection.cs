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
	

	/// <summary>Collection class for storing and retrieving collections of UnitMeasureEntity objects. </summary>
	[Serializable]
	public partial class UnitMeasureCollection : EntityCollectionBase<UnitMeasureEntity>
	{
		/// <summary> CTor</summary>
		public UnitMeasureCollection():base(new UnitMeasureEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public UnitMeasureCollection(IList<UnitMeasureEntity> initialContents):base(new UnitMeasureEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public UnitMeasureCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UnitMeasureCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(IEntity productInstance)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(productInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaBillOfMaterials_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(IEntity productInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials_(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaBillOfMaterials_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaProductVendor(IEntity productInstance)
		{
			return GetMultiManyToManyUsingProductCollectionViaProductVendor(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaProductVendor(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductCollectionViaProductVendor(productInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductCollectionViaProductVendor(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaProductVendor(IEntity productInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductCollectionViaProductVendor(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaProductVendor(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(IEntity productInstance)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(productInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaBillOfMaterials(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(IEntity productInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(productInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productInstance">ProductEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductCollectionViaBillOfMaterials(IEntity productInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductCollectionViaBillOfMaterials(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct_(IEntity productModelInstance)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct_(productModelInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct_(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct_(productModelInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductModelCollectionViaProduct_(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductModelCollectionViaProduct_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productModelInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct_(IEntity productModelInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct_(productModelInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct_(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductModelCollectionViaProduct_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productModelInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct(IEntity productModelInstance)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct(productModelInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct(productModelInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductModelCollectionViaProduct(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductModelCollectionViaProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productModelInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct(IEntity productModelInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductModelCollectionViaProduct(productModelInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductModelEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productModelInstance">ProductModelEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductModelCollectionViaProduct(IEntity productModelInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductModelCollectionViaProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productModelInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(IEntity productSubcategoryInstance)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(productSubcategoryInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(productSubcategoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductSubcategoryCollectionViaProduct_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productSubcategoryInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(IEntity productSubcategoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(productSubcategoryInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct_(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductSubcategoryCollectionViaProduct_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productSubcategoryInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(IEntity productSubcategoryInstance)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(productSubcategoryInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(productSubcategoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductSubcategoryCollectionViaProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productSubcategoryInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(IEntity productSubcategoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(productSubcategoryInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in ProductSubcategoryEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductSubcategoryCollectionViaProduct(IEntity productSubcategoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingProductSubcategoryCollectionViaProduct(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, productSubcategoryInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  Relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiUsingVendorCollectionViaProductVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, vendorInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a Relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendorCollectionViaProductVendor(IEntity vendorInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingVendorCollectionViaProductVendor(vendorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this UnitMeasureCollection object all UnitMeasureEntity objects which are related via a  relation of type 'm:n' with the passed in VendorEntity. 
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(UnitMeasureFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(UnitMeasureFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(UnitMeasureFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(UnitMeasureFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(UnitMeasureFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateUnitMeasureDAO();
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
