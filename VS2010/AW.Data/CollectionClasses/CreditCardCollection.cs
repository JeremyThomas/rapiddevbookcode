///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
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

	/// <summary>Collection class for storing and retrieving collections of CreditCardEntity objects. </summary>
	[Serializable]
	public partial class CreditCardCollection : EntityCollectionBase<CreditCardEntity>
	{
		/// <summary> CTor</summary>
		public CreditCardCollection():base(new CreditCardEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public CreditCardCollection(IEnumerable<CreditCardEntity> initialContents):base(new CreditCardEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CreditCardCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CreditCardCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(addressInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingAddressCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingAddressCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(addressInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingAddressCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in AddressEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressInstance">AddressEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressCollectionViaSalesOrderHeader_(IEntity addressInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingAddressCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingContactCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingContactCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(IEntity customerViewRelatedInstance)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(customerViewRelatedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(IEntity customerViewRelatedInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader___(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this CreditCardCollection object all CreditCardEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateCreditCardDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, prefetchPathToUse, 0, 0);
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
			CreditCardDAO dao = DAOFactory.CreateCreditCardDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(CreditCardFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(CreditCardFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(CreditCardFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(CreditCardFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(CreditCardFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			return DAOFactory.CreateCreditCardDAO().GetScalar(fields, this.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateCreditCardDAO();
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
