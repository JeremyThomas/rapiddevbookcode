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

	/// <summary>Collection class for storing and retrieving collections of SalesTerritoryEntity objects. </summary>
	[Serializable]
	public partial class SalesTerritoryCollection : EntityCollectionBase<SalesTerritoryEntity>
	{
		/// <summary> CTor</summary>
		public SalesTerritoryCollection():base(new SalesTerritoryEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public SalesTerritoryCollection(IList<SalesTerritoryEntity> initialContents):base(new SalesTerritoryEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesTerritoryCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTerritoryCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingAddressCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, addressInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingAddressCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, addressInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingAddressCollectionViaSalesOrderHeader_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, addressInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingAddressCollectionViaSalesOrderHeader_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, addressInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in ContactEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingContactCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, contactInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in ContactEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingContactCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, contactInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in CountryRegionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="countryRegionInstance">CountryRegionEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(IEntity countryRegionInstance)
		{
			return GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(countryRegionInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CountryRegionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="countryRegionInstance">CountryRegionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(IEntity countryRegionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(countryRegionInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CountryRegionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="countryRegionInstance">CountryRegionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(IEntity countryRegionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCountryRegionCollectionViaStateProvince(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, countryRegionInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in CountryRegionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="countryRegionInstance">CountryRegionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(IEntity countryRegionInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(countryRegionInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CountryRegionEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="countryRegionInstance">CountryRegionEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCountryRegionCollectionViaStateProvince(IEntity countryRegionInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCountryRegionCollectionViaStateProvince(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, countryRegionInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in CreditCardEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCreditCardCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, creditCardInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in CreditCardEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCreditCardCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, creditCardInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in CurrencyRateEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, currencyRateInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in CurrencyRateEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, currencyRateInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCustomerCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, customerInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCustomerCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, customerInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(IEntity customerViewRelatedInstance)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(customerViewRelatedInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(customerViewRelatedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, customerViewRelatedInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(IEntity customerViewRelatedInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(customerViewRelatedInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, customerViewRelatedInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  Relation of type 'm:n' with the passed in ShipMethodEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingShipMethodCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, shipMethodInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a Relation of type 'm:n' with the passed in ShipMethodEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this SalesTerritoryCollection object all SalesTerritoryEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiUsingShipMethodCollectionViaSalesOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, shipMethodInstance, prefetchPathToUse);
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
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(SalesTerritoryFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(SalesTerritoryFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(SalesTerritoryFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(SalesTerritoryFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(SalesTerritoryFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateSalesTerritoryDAO();
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
