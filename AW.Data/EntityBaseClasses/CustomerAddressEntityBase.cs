///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:23 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity base class which represents the base class for the entity 'CustomerAddress'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class CustomerAddressEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress, _addressReturnsNewIfNotFound;
		private AddressTypeEntity _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType, _addressTypeReturnsNewIfNotFound;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Address</summary>
			public static readonly string Address = "Address";
			/// <summary>Member name AddressType</summary>
			public static readonly string AddressType = "AddressType";
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerAddressEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerAddressEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		public CustomerAddressEntityBase(System.Int32 customerID, System.Int32 addressID)
		{
			InitClassFetch(customerID, addressID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerAddressEntityBase(System.Int32 customerID, System.Int32 addressID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(customerID, addressID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="validator">The custom validator object for this CustomerAddressEntity</param>
		public CustomerAddressEntityBase(System.Int32 customerID, System.Int32 addressID, IValidator validator)
		{
			InitClassFetch(customerID, addressID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerAddressEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
			if(_address!=null)
			{
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_addressReturnsNewIfNotFound = info.GetBoolean("_addressReturnsNewIfNotFound");
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");
			_addressType = (AddressTypeEntity)info.GetValue("_addressType", typeof(AddressTypeEntity));
			if(_addressType!=null)
			{
				_addressType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_addressTypeReturnsNewIfNotFound = info.GetBoolean("_addressTypeReturnsNewIfNotFound");
			_alwaysFetchAddressType = info.GetBoolean("_alwaysFetchAddressType");
			_alreadyFetchedAddressType = info.GetBoolean("_alreadyFetchedAddressType");
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerReturnsNewIfNotFound = info.GetBoolean("_customerReturnsNewIfNotFound");
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CustomerAddressFieldIndex)fieldIndex)
			{
				case CustomerAddressFieldIndex.CustomerID:
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					break;
				case CustomerAddressFieldIndex.AddressID:
					DesetupSyncAddress(true, false);
					_alreadyFetchedAddress = false;
					break;
				case CustomerAddressFieldIndex.AddressTypeID:
					DesetupSyncAddressType(true, false);
					_alreadyFetchedAddressType = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{


			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddressType = (_addressType != null);
			_alreadyFetchedCustomer = (_customer != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CustomerAddressEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Address":
					toReturn.Add(CustomerAddressEntity.Relations.AddressEntityUsingAddressID);
					break;
				case "AddressType":
					toReturn.Add(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID);
					break;
				case "Customer":
					toReturn.Add(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID);
					break;



				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{


			info.AddValue("_address", (!this.MarkedForDeletion?_address:null));
			info.AddValue("_addressReturnsNewIfNotFound", _addressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_addressType", (!this.MarkedForDeletion?_addressType:null));
			info.AddValue("_addressTypeReturnsNewIfNotFound", _addressTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_customer", (!this.MarkedForDeletion?_customer:null));
			info.AddValue("_customerReturnsNewIfNotFound", _customerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Address":
					_alreadyFetchedAddress = true;
					this.Address = (AddressEntity)entity;
					break;
				case "AddressType":
					_alreadyFetchedAddressType = true;
					this.AddressType = (AddressTypeEntity)entity;
					break;
				case "Customer":
					_alreadyFetchedCustomer = true;
					this.Customer = (CustomerEntity)entity;
					break;



				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "AddressType":
					SetupSyncAddressType(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;


				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Address":
					DesetupSyncAddress(false, true);
					break;
				case "AddressType":
					DesetupSyncAddressType(false, true);
					break;
				case "Customer":
					DesetupSyncCustomer(false, true);
					break;


				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_addressType!=null)
			{
				toReturn.Add(_addressType);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, System.Int32 addressID)
		{
			return FetchUsingPK(customerID, addressID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, System.Int32 addressID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerID, addressID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(customerID, addressID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerID, addressID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerID, this.AddressID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CustomerAddressFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CustomerAddressFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerAddressRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleAddress()
		{
			return GetSingleAddress(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress(bool forceFetch)
		{
			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(CustomerAddressEntity.Relations.AddressEntityUsingAddressID);

				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AddressID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AddressEntity)base.ActiveContext.Get(newEntity);
					}
					this.Address = newEntity;
				}
				else
				{
					if(_addressReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_address == null)))
						{
							this.Address = newEntity;
						}
					}
					else
					{
						this.Address = null;
					}
				}
				_alreadyFetchedAddress = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _address;
		}

		/// <summary> Retrieves the related entity of type 'AddressTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressTypeEntity' which is related to this entity.</returns>
		public AddressTypeEntity GetSingleAddressType()
		{
			return GetSingleAddressType(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressTypeEntity' which is related to this entity.</returns>
		public virtual AddressTypeEntity GetSingleAddressType(bool forceFetch)
		{
			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID);

				AddressTypeEntity newEntity = new AddressTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AddressTypeID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AddressTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.AddressType = newEntity;
				}
				else
				{
					if(_addressTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_addressType == null)))
						{
							this.AddressType = newEntity;
						}
					}
					else
					{
						this.AddressType = null;
					}
				}
				_alreadyFetchedAddressType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _addressType;
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID);

				CustomerEntity newEntity = new CustomerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CustomerEntity)base.ActiveContext.Get(newEntity);
					}
					this.Customer = newEntity;
				}
				else
				{
					if(_customerReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_customer == null)))
						{
							this.Customer = newEntity;
						}
					}
					else
					{
						this.Customer = null;
					}
				}
				_alreadyFetchedCustomer = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _customer;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CustomerAddressDAO dao = (CustomerAddressDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_address!=null)
			{
				_address.ActiveContext = base.ActiveContext;
			}
			if(_addressType!=null)
			{
				_addressType.ActiveContext = base.ActiveContext;
			}
			if(_customer!=null)
			{
				_customer.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CustomerAddressDAO dao = (CustomerAddressDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CustomerAddressDAO dao = (CustomerAddressDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerAddressEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Address", _address);
			toReturn.Add("AddressType", _addressType);
			toReturn.Add("Customer", _customer);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="validator">The validator object for this CustomerAddressEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 customerID, System.Int32 addressID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(customerID, addressID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_address = null;
			_addressReturnsNewIfNotFound = true;
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_addressType = null;
			_addressTypeReturnsNewIfNotFound = true;
			_alwaysFetchAddressType = false;
			_alreadyFetchedAddressType = false;
			_customer = null;
			_customerReturnsNewIfNotFound = true;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CustomerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AddressTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", CustomerAddressEntity.Relations.AddressEntityUsingAddressID, true, signalRelatedEntity, "CustomerAddresses", resetFKFields, new int[] { (int)CustomerAddressFieldIndex.AddressID } );		
			_address = null;
		}
		
		/// <summary> setups the sync logic for member _address</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntity relatedEntity)
		{
			if(_address!=relatedEntity)
			{		
				DesetupSyncAddress(true, true);
				_address = (AddressEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", CustomerAddressEntity.Relations.AddressEntityUsingAddressID, true, ref _alreadyFetchedAddress, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddressPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _addressType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddressType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID, true, signalRelatedEntity, "CustomerAddresses", resetFKFields, new int[] { (int)CustomerAddressFieldIndex.AddressTypeID } );		
			_addressType = null;
		}
		
		/// <summary> setups the sync logic for member _addressType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddressType(IEntity relatedEntity)
		{
			if(_addressType!=relatedEntity)
			{		
				DesetupSyncAddressType(true, true);
				_addressType = (AddressTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID, true, ref _alreadyFetchedAddressType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddressTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, true, signalRelatedEntity, "CustomerAddresses", resetFKFields, new int[] { (int)CustomerAddressFieldIndex.CustomerID } );		
			_customer = null;
		}
		
		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntity relatedEntity)
		{
			if(_customer!=relatedEntity)
			{		
				DesetupSyncCustomer(true, true);
				_customer = (CustomerEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, true, ref _alreadyFetchedCustomer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerID, System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CustomerAddressFieldIndex.CustomerID].ForcedCurrentValueWrite(customerID);
				base.Fields[(int)CustomerAddressFieldIndex.AddressID].ForcedCurrentValueWrite(addressID);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateCustomerAddressDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerAddressEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerAddressRelations Relations
		{
			get	{ return new CustomerAddressRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					(IEntityRelation)GetRelationsForField("Address")[0], (int)AW.Data.EntityType.CustomerAddressEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressType
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(),
					(IEntityRelation)GetRelationsForField("AddressType")[0], (int)AW.Data.EntityType.CustomerAddressEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, null, "AddressType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(),
					(IEntityRelation)GetRelationsForField("Customer")[0], (int)AW.Data.EntityType.CustomerAddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CustomerAddressEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomerAddressEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return CustomerAddressEntity.FieldsCustomProperties;}
		}

		/// <summary> The CustomerID property of the Entity CustomerAddress<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CustomerAddress"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerID
		{
			get { return (System.Int32)GetValue((int)CustomerAddressFieldIndex.CustomerID, true); }
			set	{ SetValue((int)CustomerAddressFieldIndex.CustomerID, value, true); }
		}
		/// <summary> The AddressID property of the Entity CustomerAddress<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CustomerAddress"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressID
		{
			get { return (System.Int32)GetValue((int)CustomerAddressFieldIndex.AddressID, true); }
			set	{ SetValue((int)CustomerAddressFieldIndex.AddressID, value, true); }
		}
		/// <summary> The AddressTypeID property of the Entity CustomerAddress<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CustomerAddress"."AddressTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AddressTypeID
		{
			get { return (System.Int32)GetValue((int)CustomerAddressFieldIndex.AddressTypeID, true); }
			set	{ SetValue((int)CustomerAddressFieldIndex.AddressTypeID, value, true); }
		}
		/// <summary> The Rowguid property of the Entity CustomerAddress<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CustomerAddress"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)CustomerAddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)CustomerAddressFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity CustomerAddress<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "CustomerAddress"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CustomerAddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CustomerAddressFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity Address
		{
			get	{ return GetSingleAddress(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					if(value==null)
					{
						if(_address != null)
						{
							_address.UnsetRelatedEntity(this, "CustomerAddresses");
						}
					}
					else
					{
						if(_address!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "CustomerAddresses");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get	{ return _alwaysFetchAddress; }
			set	{ _alwaysFetchAddress = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Address already has been fetched. Setting this property to false when Address has been fetched
		/// will set Address to null as well. Setting this property to true while Address hasn't been fetched disables lazy loading for Address</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddress
		{
			get { return _alreadyFetchedAddress;}
			set 
			{
				if(_alreadyFetchedAddress && !value)
				{
					this.Address = null;
				}
				_alreadyFetchedAddress = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Address is not found
		/// in the database. When set to true, Address will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AddressReturnsNewIfNotFound
		{
			get	{ return _addressReturnsNewIfNotFound; }
			set { _addressReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'AddressTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddressType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressTypeEntity AddressType
		{
			get	{ return GetSingleAddressType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddressType(value);
				}
				else
				{
					if(value==null)
					{
						if(_addressType != null)
						{
							_addressType.UnsetRelatedEntity(this, "CustomerAddresses");
						}
					}
					else
					{
						if(_addressType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "CustomerAddresses");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AddressType. When set to true, AddressType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddressType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressType
		{
			get	{ return _alwaysFetchAddressType; }
			set	{ _alwaysFetchAddressType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressType already has been fetched. Setting this property to false when AddressType has been fetched
		/// will set AddressType to null as well. Setting this property to true while AddressType hasn't been fetched disables lazy loading for AddressType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressType
		{
			get { return _alreadyFetchedAddressType;}
			set 
			{
				if(_alreadyFetchedAddressType && !value)
				{
					this.AddressType = null;
				}
				_alreadyFetchedAddressType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AddressType is not found
		/// in the database. When set to true, AddressType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AddressTypeReturnsNewIfNotFound
		{
			get	{ return _addressTypeReturnsNewIfNotFound; }
			set { _addressTypeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get	{ return GetSingleCustomer(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					if(value==null)
					{
						if(_customer != null)
						{
							_customer.UnsetRelatedEntity(this, "CustomerAddresses");
						}
					}
					else
					{
						if(_customer!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "CustomerAddresses");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer
		{
			get	{ return _alwaysFetchCustomer; }
			set	{ _alwaysFetchCustomer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customer already has been fetched. Setting this property to false when Customer has been fetched
		/// will set Customer to null as well. Setting this property to true while Customer hasn't been fetched disables lazy loading for Customer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomer
		{
			get { return _alreadyFetchedCustomer;}
			set 
			{
				if(_alreadyFetchedCustomer && !value)
				{
					this.Customer = null;
				}
				_alreadyFetchedCustomer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Customer is not found
		/// in the database. When set to true, Customer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerReturnsNewIfNotFound
		{
			get	{ return _customerReturnsNewIfNotFound; }
			set { _customerReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.CustomerAddressEntity; }
		}
		#endregion

		
		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
