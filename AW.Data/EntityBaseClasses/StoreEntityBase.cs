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
	
	/// <summary>Entity base class which represents the base class for the entity 'Store'.<br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class StoreEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaStoreContact;
		private bool	_alwaysFetchContactCollectionViaStoreContact, _alreadyFetchedContactCollectionViaStoreContact;
		private AW.Data.CollectionClasses.ContactTypeCollection _contactTypeCollectionViaStoreContact;
		private bool	_alwaysFetchContactTypeCollectionViaStoreContact, _alreadyFetchedContactTypeCollectionViaStoreContact;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson, _salesPersonReturnsNewIfNotFound;
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
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name StoreContact</summary>
			public static readonly string StoreContact = "StoreContact";
			/// <summary>Member name ContactCollectionViaStoreContact</summary>
			public static readonly string ContactCollectionViaStoreContact = "ContactCollectionViaStoreContact";
			/// <summary>Member name ContactTypeCollectionViaStoreContact</summary>
			public static readonly string ContactTypeCollectionViaStoreContact = "ContactTypeCollectionViaStoreContact";
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StoreEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StoreEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		public StoreEntityBase(System.Int32 customerID)
		{
			InitClassFetch(customerID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StoreEntityBase(System.Int32 customerID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(customerID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		public StoreEntityBase(System.Int32 customerID, IValidator validator)
		{
			InitClassFetch(customerID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StoreEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_storeContact = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContact", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");
			_contactCollectionViaStoreContact = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaStoreContact = info.GetBoolean("_alwaysFetchContactCollectionViaStoreContact");
			_alreadyFetchedContactCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedContactCollectionViaStoreContact");
			_contactTypeCollectionViaStoreContact = (AW.Data.CollectionClasses.ContactTypeCollection)info.GetValue("_contactTypeCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.ContactTypeCollection));
			_alwaysFetchContactTypeCollectionViaStoreContact = info.GetBoolean("_alwaysFetchContactTypeCollectionViaStoreContact");
			_alreadyFetchedContactTypeCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedContactTypeCollectionViaStoreContact");
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesPersonReturnsNewIfNotFound = info.GetBoolean("_salesPersonReturnsNewIfNotFound");
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
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
			switch((StoreFieldIndex)fieldIndex)
			{
				case StoreFieldIndex.CustomerID:
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					break;
				case StoreFieldIndex.SalesPersonID:
					DesetupSyncSalesPerson(true, false);
					_alreadyFetchedSalesPerson = false;
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
			_alreadyFetchedStoreContact = (_storeContact.Count > 0);
			_alreadyFetchedContactCollectionViaStoreContact = (_contactCollectionViaStoreContact.Count > 0);
			_alreadyFetchedContactTypeCollectionViaStoreContact = (_contactTypeCollectionViaStoreContact.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
			_alreadyFetchedCustomer = (_customer != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return StoreEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "SalesPerson":
					toReturn.Add(StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID);
					break;
				case "StoreContact":
					toReturn.Add(StoreEntity.Relations.StoreContactEntityUsingCustomerID);
					break;
				case "ContactCollectionViaStoreContact":
					toReturn.Add(StoreEntity.Relations.StoreContactEntityUsingCustomerID, "StoreEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.ContactEntityUsingContactID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "ContactTypeCollectionViaStoreContact":
					toReturn.Add(StoreEntity.Relations.StoreContactEntityUsingCustomerID, "StoreEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.ContactTypeEntityUsingContactTypeID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "Customer":
					toReturn.Add(StoreEntity.Relations.CustomerEntityUsingCustomerID);
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
			info.AddValue("_storeContact", (!this.MarkedForDeletion?_storeContact:null));
			info.AddValue("_alwaysFetchStoreContact", _alwaysFetchStoreContact);
			info.AddValue("_alreadyFetchedStoreContact", _alreadyFetchedStoreContact);
			info.AddValue("_contactCollectionViaStoreContact", (!this.MarkedForDeletion?_contactCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchContactCollectionViaStoreContact", _alwaysFetchContactCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedContactCollectionViaStoreContact", _alreadyFetchedContactCollectionViaStoreContact);
			info.AddValue("_contactTypeCollectionViaStoreContact", (!this.MarkedForDeletion?_contactTypeCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchContactTypeCollectionViaStoreContact", _alwaysFetchContactTypeCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedContactTypeCollectionViaStoreContact", _alreadyFetchedContactTypeCollectionViaStoreContact);
			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_salesPersonReturnsNewIfNotFound", _salesPersonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
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
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					this.SalesPerson = (SalesPersonEntity)entity;
					break;
				case "StoreContact":
					_alreadyFetchedStoreContact = true;
					if(entity!=null)
					{
						this.StoreContact.Add((StoreContactEntity)entity);
					}
					break;
				case "ContactCollectionViaStoreContact":
					_alreadyFetchedContactCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.ContactCollectionViaStoreContact.Add((ContactEntity)entity);
					}
					break;
				case "ContactTypeCollectionViaStoreContact":
					_alreadyFetchedContactTypeCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.ContactTypeCollectionViaStoreContact.Add((ContactTypeEntity)entity);
					}
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
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "StoreContact":
					_storeContact.Add((StoreContactEntity)relatedEntity);
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
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
					break;
				case "StoreContact":
					base.PerformRelatedEntityRemoval(_storeContact, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
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
			toReturn.Add(_storeContact);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID)
		{
			return FetchUsingPK(customerID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(customerID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(StoreFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(StoreFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new StoreRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch)
		{
			return GetMultiStoreContact(forceFetch, _storeContact.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStoreContact(forceFetch, _storeContact.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStoreContact(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_storeContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_storeContact.GetMultiManyToOne(null, null, this, filter);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'StoreContact'. These settings will be taken into account
		/// when the property StoreContact is requested or GetMultiStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeContact.SortClauses=sortClauses;
			_storeContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaStoreContact(bool forceFetch)
		{
			return GetMultiContactCollectionViaStoreContact(forceFetch, _contactCollectionViaStoreContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaStoreContact || forceFetch || _alwaysFetchContactCollectionViaStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaStoreContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaStoreContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(StoreFields.CustomerID, ComparisonOperator.Equal, this.CustomerID, "StoreEntity__"));
				_contactCollectionViaStoreContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaStoreContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaStoreContact.GetMulti(filter, GetRelationsForField("ContactCollectionViaStoreContact"));
				_contactCollectionViaStoreContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaStoreContact = true;
			}
			return _contactCollectionViaStoreContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaStoreContact'. These settings will be taken into account
		/// when the property ContactCollectionViaStoreContact is requested or GetMultiContactCollectionViaStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaStoreContact.SortClauses=sortClauses;
			_contactCollectionViaStoreContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaStoreContact(bool forceFetch)
		{
			return GetMultiContactTypeCollectionViaStoreContact(forceFetch, _contactTypeCollectionViaStoreContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactTypeCollectionViaStoreContact || forceFetch || _alwaysFetchContactTypeCollectionViaStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactTypeCollectionViaStoreContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactTypeCollectionViaStoreContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(StoreFields.CustomerID, ComparisonOperator.Equal, this.CustomerID, "StoreEntity__"));
				_contactTypeCollectionViaStoreContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactTypeCollectionViaStoreContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactTypeCollectionViaStoreContact.GetMulti(filter, GetRelationsForField("ContactTypeCollectionViaStoreContact"));
				_contactTypeCollectionViaStoreContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactTypeCollectionViaStoreContact = true;
			}
			return _contactTypeCollectionViaStoreContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactTypeCollectionViaStoreContact'. These settings will be taken into account
		/// when the property ContactTypeCollectionViaStoreContact is requested or GetMultiContactTypeCollectionViaStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactTypeCollectionViaStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactTypeCollectionViaStoreContact.SortClauses=sortClauses;
			_contactTypeCollectionViaStoreContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID);

				SalesPersonEntity newEntity = new SalesPersonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.SalesPersonID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesPersonEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesPerson = newEntity;
				}
				else
				{
					if(_salesPersonReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesPerson == null)))
						{
							this.SalesPerson = newEntity;
						}
					}
					else
					{
						this.SalesPerson = null;
					}
				}
				_alreadyFetchedSalesPerson = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesPerson;
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}
		
		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode )
			{
				CustomerEntity newEntity = new CustomerEntity();
				IEntityRelation relation = StoreEntity.Relations.CustomerEntityUsingCustomerID;
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(relation))
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerID);
				}
				if(!_customerReturnsNewIfNotFound && !fetchResult)
				{
					this.Customer = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (CustomerEntity)base.ActiveContext.Get(newEntity);
					}
					this.Customer = newEntity;
					_alreadyFetchedCustomer = fetchResult;
				}
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
			StoreDAO dao = (StoreDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_storeContact.ActiveContext = base.ActiveContext;
			_contactCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			_contactTypeCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			if(_salesPerson!=null)
			{
				_salesPerson.ActiveContext = base.ActiveContext;
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
			StoreDAO dao = (StoreDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			StoreDAO dao = (StoreDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.StoreEntity);
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
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("StoreContact", _storeContact);
			toReturn.Add("ContactCollectionViaStoreContact", _contactCollectionViaStoreContact);
			toReturn.Add("ContactTypeCollectionViaStoreContact", _contactTypeCollectionViaStoreContact);
			toReturn.Add("Customer", _customer);
			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The validator object for this StoreEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 customerID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(customerID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_storeContact = new AW.Data.CollectionClasses.StoreContactCollection(new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "Store");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_contactCollectionViaStoreContact = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaStoreContact = false;
			_alreadyFetchedContactCollectionViaStoreContact = false;
			_contactTypeCollectionViaStoreContact = new AW.Data.CollectionClasses.ContactTypeCollection(new ContactTypeEntityFactory());
			_alwaysFetchContactTypeCollectionViaStoreContact = false;
			_alreadyFetchedContactTypeCollectionViaStoreContact = false;
			_salesPerson = null;
			_salesPersonReturnsNewIfNotFound = true;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
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
			_customProperties.Add("MS_Description", @"Primary XML index.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to Customer.CustomerID.");
			_fieldsCustomProperties.Add("CustomerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ID of the sales person assigned to the customer. Foreign key to SalesPerson.SalesPersonID.");
			_fieldsCustomProperties.Add("SalesPersonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Demographic informationg about the store such as the number of employees, annual sales and store type.");
			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _salesPerson</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID, true, signalRelatedEntity, "Store", resetFKFields, new int[] { (int)StoreFieldIndex.SalesPersonID } );		
			_salesPerson = null;
		}
		
		/// <summary> setups the sync logic for member _salesPerson</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntity relatedEntity)
		{
			if(_salesPerson!=relatedEntity)
			{		
				DesetupSyncSalesPerson(true, true);
				_salesPerson = (SalesPersonEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID, true, ref _alreadyFetchedSalesPerson, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", StoreEntity.Relations.CustomerEntityUsingCustomerID, true, signalRelatedEntity, "Store", false, new int[] { (int)StoreFieldIndex.CustomerID } );
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
				base.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", StoreEntity.Relations.CustomerEntityUsingCustomerID, true, ref _alreadyFetchedCustomer, new string[] {  } );
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
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)StoreFieldIndex.CustomerID].ForcedCurrentValueWrite(customerID);
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
			return DAOFactory.CreateStoreDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new StoreEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static StoreRelations Relations
		{
			get	{ return new StoreRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(),
					(IEntityRelation)GetRelationsForField("StoreContact")[0], (int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = StoreEntity.Relations.StoreContactEntityUsingCustomerID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaStoreContact"), "ContactCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactTypeCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = StoreEntity.Relations.StoreContactEntityUsingCustomerID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.ContactTypeEntity, 0, null, null, GetRelationsForField("ContactTypeCollectionViaStoreContact"), "ContactTypeCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPerson
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(),
					(IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Customer")[0], (int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "StoreEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return StoreEntity.CustomProperties;}
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
			get { return StoreEntity.FieldsCustomProperties;}
		}

		/// <summary> The CustomerID property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: Primary key. Foreign key to Customer.CustomerID.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerID
		{
			get { return (System.Int32)GetValue((int)StoreFieldIndex.CustomerID, true); }
			set	{ SetValue((int)StoreFieldIndex.CustomerID, value, true); }
		}
		/// <summary> The Name property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Name, true); }
			set	{ SetValue((int)StoreFieldIndex.Name, value, true); }
		}
		/// <summary> The SalesPersonID property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: ID of the sales person assigned to the customer. Foreign key to SalesPerson.SalesPersonID.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonID
		{
			get { return (Nullable<System.Int32>)GetValue((int)StoreFieldIndex.SalesPersonID, false); }
			set	{ SetValue((int)StoreFieldIndex.SalesPersonID, value, true); }
		}
		/// <summary> The Demographics property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: Demographic informationg about the store such as the number of employees, annual sales and store type.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."Demographics"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Demographics, true); }
			set	{ SetValue((int)StoreFieldIndex.Demographics, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)StoreFieldIndex.Rowguid, true); }
			set	{ SetValue((int)StoreFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Store<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Store"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)StoreFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)StoreFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreContactCollection StoreContact
		{
			get	{ return GetMultiStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StoreContact. When set to true, StoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreContact
		{
			get	{ return _alwaysFetchStoreContact; }
			set	{ _alwaysFetchStoreContact = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreContact already has been fetched. Setting this property to false when StoreContact has been fetched
		/// will clear the StoreContact collection well. Setting this property to true while StoreContact hasn't been fetched disables lazy loading for StoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreContact
		{
			get { return _alreadyFetchedStoreContact;}
			set 
			{
				if(_alreadyFetchedStoreContact && !value && (_storeContact != null))
				{
					_storeContact.Clear();
				}
				_alreadyFetchedStoreContact = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaStoreContact
		{
			get { return GetMultiContactCollectionViaStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaStoreContact. When set to true, ContactCollectionViaStoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaStoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaStoreContact
		{
			get	{ return _alwaysFetchContactCollectionViaStoreContact; }
			set	{ _alwaysFetchContactCollectionViaStoreContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaStoreContact already has been fetched. Setting this property to false when ContactCollectionViaStoreContact has been fetched
		/// will clear the ContactCollectionViaStoreContact collection well. Setting this property to true while ContactCollectionViaStoreContact hasn't been fetched disables lazy loading for ContactCollectionViaStoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaStoreContact
		{
			get { return _alreadyFetchedContactCollectionViaStoreContact;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaStoreContact && !value && (_contactCollectionViaStoreContact != null))
				{
					_contactCollectionViaStoreContact.Clear();
				}
				_alreadyFetchedContactCollectionViaStoreContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactTypeCollectionViaStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactTypeCollection ContactTypeCollectionViaStoreContact
		{
			get { return GetMultiContactTypeCollectionViaStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactTypeCollectionViaStoreContact. When set to true, ContactTypeCollectionViaStoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactTypeCollectionViaStoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactTypeCollectionViaStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactTypeCollectionViaStoreContact
		{
			get	{ return _alwaysFetchContactTypeCollectionViaStoreContact; }
			set	{ _alwaysFetchContactTypeCollectionViaStoreContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactTypeCollectionViaStoreContact already has been fetched. Setting this property to false when ContactTypeCollectionViaStoreContact has been fetched
		/// will clear the ContactTypeCollectionViaStoreContact collection well. Setting this property to true while ContactTypeCollectionViaStoreContact hasn't been fetched disables lazy loading for ContactTypeCollectionViaStoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactTypeCollectionViaStoreContact
		{
			get { return _alreadyFetchedContactTypeCollectionViaStoreContact;}
			set 
			{
				if(_alreadyFetchedContactTypeCollectionViaStoreContact && !value && (_contactTypeCollectionViaStoreContact != null))
				{
					_contactTypeCollectionViaStoreContact.Clear();
				}
				_alreadyFetchedContactTypeCollectionViaStoreContact = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'SalesPersonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get	{ return GetSingleSalesPerson(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesPerson != null)
						{
							_salesPerson.UnsetRelatedEntity(this, "Store");
						}
					}
					else
					{
						if(_salesPerson!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Store");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesPerson(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson
		{
			get	{ return _alwaysFetchSalesPerson; }
			set	{ _alwaysFetchSalesPerson = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPerson already has been fetched. Setting this property to false when SalesPerson has been fetched
		/// will set SalesPerson to null as well. Setting this property to true while SalesPerson hasn't been fetched disables lazy loading for SalesPerson</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPerson
		{
			get { return _alreadyFetchedSalesPerson;}
			set 
			{
				if(_alreadyFetchedSalesPerson && !value)
				{
					this.SalesPerson = null;
				}
				_alreadyFetchedSalesPerson = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesPerson is not found
		/// in the database. When set to true, SalesPerson will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesPersonReturnsNewIfNotFound
		{
			get	{ return _salesPersonReturnsNewIfNotFound; }
			set { _salesPersonReturnsNewIfNotFound = value; }	
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
						bool raisePropertyChanged = (_customer !=null);
						DesetupSyncCustomer(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Customer");
						}
					}
					else
					{
						if(_customer!=value)
						{
							IEntity relatedEntity = (IEntity)value;
							relatedEntity.SetRelatedEntity(this, "Store");
							SetupSyncCustomer(relatedEntity);
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
			set	{ _customerReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.StoreEntity; }
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
