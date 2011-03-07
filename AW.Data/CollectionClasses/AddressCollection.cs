///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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

	/// <summary>Collection class for storing and retrieving collections of AddressEntity objects. </summary>
	[Serializable]
	public partial class AddressCollection : EntityCollectionBase<AddressEntity>
	{
		/// <summary> CTor</summary>
		public AddressCollection():base(new AddressEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public AddressCollection(IEnumerable<AddressEntity> initialContents):base(new AddressEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public AddressCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity stateProvinceInstance)
		{
			return GetMultiManyToOne(stateProvinceInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity stateProvinceInstance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(stateProvinceInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity stateProvinceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(stateProvinceInstance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity stateProvinceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (stateProvinceInstance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMulti(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, filter, stateProvinceInstance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all Address entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity stateProvinceInstance)
		{
			return DAOFactory.CreateAddressDAO().DeleteMulti(this.Transaction, stateProvinceInstance);
		}

		/// <summary> Updates in the persistent storage all Address entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">AddressEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="stateProvinceInstance">StateProvinceEntity instance to use as a filter for the AddressEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(AddressEntity entityWithNewValues, IEntity stateProvinceInstance)
		{
			return DAOFactory.CreateAddressDAO().UpdateMulti(entityWithNewValues, this.Transaction, stateProvinceInstance);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(employeeInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(employeeInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingEmployeeCollectionViaEmployeeAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, employeeInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaEmployeeAddres(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingEmployeeCollectionViaEmployeeAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, employeeInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in AddressTypeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressTypeInstance">AddressTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(IEntity addressTypeInstance)
		{
			return GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(addressTypeInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in AddressTypeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressTypeInstance">AddressTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(IEntity addressTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(addressTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in AddressTypeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressTypeInstance">AddressTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(IEntity addressTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(addressTypeInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in AddressTypeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressTypeInstance">AddressTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(IEntity addressTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingAddressTypeCollectionViaCustomerAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressTypeInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in AddressTypeEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="addressTypeInstance">AddressTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAddressTypeCollectionViaCustomerAddres(IEntity addressTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingAddressTypeCollectionViaCustomerAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, addressTypeInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(IEntity contactInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingContactCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingContactCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(IEntity contactInstance)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(contactInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(IEntity contactInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(contactInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingContactCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ContactEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="contactInstance">ContactEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingContactCollectionViaSalesOrderHeader_(IEntity contactInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingContactCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, contactInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(IEntity shipMethodInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(IEntity shipMethodInstance)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(shipMethodInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(IEntity shipMethodInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(shipMethodInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in ShipMethodEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="shipMethodInstance">ShipMethodEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingShipMethodCollectionViaSalesOrderHeader_(IEntity shipMethodInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingShipMethodCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, shipMethodInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(creditCardInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCreditCardCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, creditCardInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCreditCardCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, creditCardInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(IEntity creditCardInstance)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(creditCardInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(creditCardInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(IEntity creditCardInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(creditCardInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCreditCardCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, creditCardInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CreditCardEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="creditCardInstance">CreditCardEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCreditCardCollectionViaSalesOrderHeader_(IEntity creditCardInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCreditCardCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, creditCardInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(IEntity currencyRateInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(IEntity currencyRateInstance)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(currencyRateInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(IEntity currencyRateInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(currencyRateInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CurrencyRateEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="currencyRateInstance">CurrencyRateEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCurrencyRateCollectionViaSalesOrderHeader_(IEntity currencyRateInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCurrencyRateCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, currencyRateInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(IEntity customerInstance)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(customerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(IEntity customerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaCustomerAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaCustomerAddres(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaCustomerAddres(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(IEntity customerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(IEntity customerInstance)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(customerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(IEntity customerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(customerInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerInstance">CustomerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerCollectionViaSalesOrderHeader_(IEntity customerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(IEntity customerViewRelatedInstance)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(customerViewRelatedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(IEntity customerViewRelatedInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(IEntity customerViewRelatedInstance)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(customerViewRelatedInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(IEntity customerViewRelatedInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(customerViewRelatedInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in CustomerViewRelatedEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="customerViewRelatedInstance">CustomerViewRelatedEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(IEntity customerViewRelatedInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingCustomerViewRelatedCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, customerViewRelatedInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(IEntity salesTerritoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
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
			return DAOFactory.CreateAddressDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, prefetchPathToUse, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(IEntity salesTerritoryInstance)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(salesTerritoryInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a Relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(IEntity salesTerritoryInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(salesTerritoryInstance, this.MaxNumberOfItemsToReturn, this.SortClauses, prefetchPathToUse);
		}
		
		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, null, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this AddressCollection object all AddressEntity objects which are related via a  relation of type 'm:n' with the passed in SalesTerritoryEntity. All current elements in the collection are removed from the collection.</summary>
		/// <param name="salesTerritoryInstance">SalesTerritoryEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSalesTerritoryCollectionViaSalesOrderHeader_(IEntity salesTerritoryInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!this.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			return DAOFactory.CreateAddressDAO().GetMultiUsingSalesTerritoryCollectionViaSalesOrderHeader_(this.Transaction, this, maxNumberOfItemsToReturn, sortClauses, this.EntityFactoryToUse, salesTerritoryInstance, prefetchPathToUse, 0, 0);
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
			AddressDAO dao = DAOFactory.CreateAddressDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(AddressFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(AddressFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(AddressFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(AddressFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(AddressFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			return DAOFactory.CreateAddressDAO().GetScalar(fields, this.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateAddressDAO();
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
