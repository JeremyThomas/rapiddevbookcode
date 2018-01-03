///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
using System.ComponentModel.DataAnnotations;
using AW.Helper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'StoreContact'. <br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping stores and their employees.<br/>
	/// </summary>
	[Serializable]
	public partial class StoreContactEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private ContactTypeEntity _contactType;
		private bool	_alwaysFetchContactType, _alreadyFetchedContactType, _contactTypeReturnsNewIfNotFound;
		private StoreEntity _store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore, _storeReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name ContactType</summary>
			public static readonly string ContactType = "ContactType";
			/// <summary>Member name Store</summary>
			public static readonly string Store = "Store";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StoreContactEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StoreContactEntity() :base("StoreContactEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		public StoreContactEntity(System.Int32 contactID, System.Int32 customerID):base("StoreContactEntity")
		{
			InitClassFetch(contactID, customerID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StoreContactEntity(System.Int32 contactID, System.Int32 customerID, IPrefetchPath prefetchPathToUse):base("StoreContactEntity")
		{
			InitClassFetch(contactID, customerID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="validator">The custom validator object for this StoreContactEntity</param>
		public StoreContactEntity(System.Int32 contactID, System.Int32 customerID, IValidator validator):base("StoreContactEntity")
		{
			InitClassFetch(contactID, customerID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StoreContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");

			_contactType = (ContactTypeEntity)info.GetValue("_contactType", typeof(ContactTypeEntity));
			if(_contactType!=null)
			{
				_contactType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactTypeReturnsNewIfNotFound = info.GetBoolean("_contactTypeReturnsNewIfNotFound");
			_alwaysFetchContactType = info.GetBoolean("_alwaysFetchContactType");
			_alreadyFetchedContactType = info.GetBoolean("_alreadyFetchedContactType");

			_store = (StoreEntity)info.GetValue("_store", typeof(StoreEntity));
			if(_store!=null)
			{
				_store.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_storeReturnsNewIfNotFound = info.GetBoolean("_storeReturnsNewIfNotFound");
			_alwaysFetchStore = info.GetBoolean("_alwaysFetchStore");
			_alreadyFetchedStore = info.GetBoolean("_alreadyFetchedStore");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((StoreContactFieldIndex)fieldIndex)
			{
				case StoreContactFieldIndex.ContactID:
					DesetupSyncContact(true, false);
					_alreadyFetchedContact = false;
					break;
				case StoreContactFieldIndex.ContactTypeID:
					DesetupSyncContactType(true, false);
					_alreadyFetchedContactType = false;
					break;
				case StoreContactFieldIndex.CustomerID:
					DesetupSyncStore(true, false);
					_alreadyFetchedStore = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedContactType = (_contactType != null);
			_alreadyFetchedStore = (_store != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Contact":
					toReturn.Add(Relations.ContactEntityUsingContactID);
					break;
				case "ContactType":
					toReturn.Add(Relations.ContactTypeEntityUsingContactTypeID);
					break;
				case "Store":
					toReturn.Add(Relations.StoreEntityUsingCustomerID);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_contactType", (!this.MarkedForDeletion?_contactType:null));
			info.AddValue("_contactTypeReturnsNewIfNotFound", _contactTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContactType", _alwaysFetchContactType);
			info.AddValue("_alreadyFetchedContactType", _alreadyFetchedContactType);
			info.AddValue("_store", (!this.MarkedForDeletion?_store:null));
			info.AddValue("_storeReturnsNewIfNotFound", _storeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStore", _alwaysFetchStore);
			info.AddValue("_alreadyFetchedStore", _alreadyFetchedStore);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
					break;
				case "ContactType":
					_alreadyFetchedContactType = true;
					this.ContactType = (ContactTypeEntity)entity;
					break;
				case "Store":
					_alreadyFetchedStore = true;
					this.Store = (StoreEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "ContactType":
					SetupSyncContactType(relatedEntity);
					break;
				case "Store":
					SetupSyncStore(relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Contact":
					DesetupSyncContact(false, true);
					break;
				case "ContactType":
					DesetupSyncContactType(false, true);
					break;
				case "Store":
					DesetupSyncStore(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_contactType!=null)
			{
				toReturn.Add(_contactType);
			}
			if(_store!=null)
			{
				toReturn.Add(_store);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, System.Int32 customerID)
		{
			return FetchUsingPK(contactID, customerID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, System.Int32 customerID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactID, customerID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(contactID, customerID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactID, customerID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactID, this.CustomerID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new StoreContactRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public ContactEntity GetSingleContact()
		{
			return GetSingleContact(false);
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact(bool forceFetch)
		{
			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ContactEntityUsingContactID);
				ContactEntity newEntity = new ContactEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ContactID);
				}
				if(fetchResult)
				{
					newEntity = (ContactEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_contactReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Contact = newEntity;
				_alreadyFetchedContact = fetchResult;
			}
			return _contact;
		}


		/// <summary> Retrieves the related entity of type 'ContactTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ContactTypeEntity' which is related to this entity.</returns>
		public ContactTypeEntity GetSingleContactType()
		{
			return GetSingleContactType(false);
		}

		/// <summary> Retrieves the related entity of type 'ContactTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactTypeEntity' which is related to this entity.</returns>
		public virtual ContactTypeEntity GetSingleContactType(bool forceFetch)
		{
			if( ( !_alreadyFetchedContactType || forceFetch || _alwaysFetchContactType) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ContactTypeEntityUsingContactTypeID);
				ContactTypeEntity newEntity = new ContactTypeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ContactTypeID);
				}
				if(fetchResult)
				{
					newEntity = (ContactTypeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_contactTypeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ContactType = newEntity;
				_alreadyFetchedContactType = fetchResult;
			}
			return _contactType;
		}


		/// <summary> Retrieves the related entity of type 'StoreEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public StoreEntity GetSingleStore()
		{
			return GetSingleStore(false);
		}

		/// <summary> Retrieves the related entity of type 'StoreEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public virtual StoreEntity GetSingleStore(bool forceFetch)
		{
			if( ( !_alreadyFetchedStore || forceFetch || _alwaysFetchStore) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StoreEntityUsingCustomerID);
				StoreEntity newEntity = (StoreEntity)GeneralEntityFactory.Create(AW.Data.EntityType.StoreEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = StoreEntity.FetchPolymorphic(this.Transaction, this.CustomerID, this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (StoreEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_storeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Store = newEntity;
				_alreadyFetchedStore = fetchResult;
			}
			return _store;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Contact", _contact);
			toReturn.Add("ContactType", _contactType);
			toReturn.Add("Store", _store);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="validator">The validator object for this StoreContactEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 contactID, System.Int32 customerID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(contactID, customerID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_contactReturnsNewIfNotFound = true;
			_contactTypeReturnsNewIfNotFound = true;
			_storeReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping stores and their employees.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Contact (store employee) identification number. Foreign key to Contact.ContactID.");
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("ContactTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CustomerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContact(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AW.Data.RelationClasses.StaticStoreContactRelations.ContactEntityUsingContactIDStatic, true, signalRelatedEntity, "StoreContacts", resetFKFields, new int[] { (int)StoreContactFieldIndex.ContactID } );		
			_contact = null;
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntityCore relatedEntity)
		{
			if(_contact!=relatedEntity)
			{		
				DesetupSyncContact(true, true);
				_contact = (ContactEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AW.Data.RelationClasses.StaticStoreContactRelations.ContactEntityUsingContactIDStatic, true, ref _alreadyFetchedContact, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnContactPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _contactType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContactType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _contactType, new PropertyChangedEventHandler( OnContactTypePropertyChanged ), "ContactType", AW.Data.RelationClasses.StaticStoreContactRelations.ContactTypeEntityUsingContactTypeIDStatic, true, signalRelatedEntity, "StoreContacts", resetFKFields, new int[] { (int)StoreContactFieldIndex.ContactTypeID } );		
			_contactType = null;
		}
		
		/// <summary> setups the sync logic for member _contactType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContactType(IEntityCore relatedEntity)
		{
			if(_contactType!=relatedEntity)
			{		
				DesetupSyncContactType(true, true);
				_contactType = (ContactTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contactType, new PropertyChangedEventHandler( OnContactTypePropertyChanged ), "ContactType", AW.Data.RelationClasses.StaticStoreContactRelations.ContactTypeEntityUsingContactTypeIDStatic, true, ref _alreadyFetchedContactType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnContactTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _store</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStore(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", AW.Data.RelationClasses.StaticStoreContactRelations.StoreEntityUsingCustomerIDStatic, true, signalRelatedEntity, "StoreContacts", resetFKFields, new int[] { (int)StoreContactFieldIndex.CustomerID } );		
			_store = null;
		}
		
		/// <summary> setups the sync logic for member _store</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStore(IEntityCore relatedEntity)
		{
			if(_store!=relatedEntity)
			{		
				DesetupSyncStore(true, true);
				_store = (StoreEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", AW.Data.RelationClasses.StaticStoreContactRelations.StoreEntityUsingCustomerIDStatic, true, ref _alreadyFetchedStore, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStorePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="contactID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="customerID">PK value for StoreContact which data should be fetched into this StoreContact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactID, System.Int32 customerID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)StoreContactFieldIndex.ContactID].ForcedCurrentValueWrite(contactID);
				this.Fields[(int)StoreContactFieldIndex.CustomerID].ForcedCurrentValueWrite(customerID);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
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
			return DAOFactory.CreateStoreContactDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new StoreContactEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static StoreContactRelations Relations
		{
			get	{ return new StoreContactRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), (IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.StoreContactEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactType
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactTypeCollection(), (IEntityRelation)GetRelationsForField("ContactType")[0], (int)AW.Data.EntityType.StoreContactEntity, (int)AW.Data.EntityType.ContactTypeEntity, 0, null, null, null, "ContactType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStore
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreCollection(), (IEntityRelation)GetRelationsForField("Store")[0], (int)AW.Data.EntityType.StoreContactEntity, (int)AW.Data.EntityType.StoreEntity, 0, null, null, null, "Store", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
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
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The ContactID property of the Entity StoreContact<br/><br/>
		/// MS_Description: Contact (store employee) identification number. Foreign key to Contact.ContactID.<br/>Contact (store employee) identification number. Foreign key to Contact.ContactID.</summary>
		/// <remarks>Mapped on  table field: "StoreContact"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)StoreContactFieldIndex.ContactID, true); }
			set	{ SetValue((int)StoreContactFieldIndex.ContactID, value, true); }
		}

		/// <summary> The ContactTypeID property of the Entity StoreContact<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "StoreContact"."ContactTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.ContactType ContactTypeID
		{
			get { return (AW.Data.ContactType)GetValue((int)StoreContactFieldIndex.ContactTypeID, true); }
			set	{ SetValue((int)StoreContactFieldIndex.ContactTypeID, value, true); }
		}

		/// <summary> The CustomerID property of the Entity StoreContact<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "StoreContact"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerID
		{
			get { return (System.Int32)GetValue((int)StoreContactFieldIndex.CustomerID, true); }
			set	{ SetValue((int)StoreContactFieldIndex.CustomerID, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity StoreContact<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "StoreContact"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)StoreContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)StoreContactFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Rowguid property of the Entity StoreContact<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "StoreContact"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)StoreContactFieldIndex.Rowguid, true); }
			set	{ SetValue((int)StoreContactFieldIndex.Rowguid, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get	{ return GetSingleContact(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StoreContacts", "Contact", _contact, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute a forced fetch by calling GetSingleContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get	{ return _alwaysFetchContact; }
			set	{ _alwaysFetchContact = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Contact already has been fetched. Setting this property to false when Contact has been fetched
		/// will set Contact to null as well. Setting this property to true while Contact hasn't been fetched disables lazy loading for Contact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContact
		{
			get { return _alreadyFetchedContact;}
			set 
			{
				if(_alreadyFetchedContact && !value)
				{
					this.Contact = null;
				}
				_alreadyFetchedContact = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Contact is not found
		/// in the database. When set to true, Contact will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ContactReturnsNewIfNotFound
		{
			get	{ return _contactReturnsNewIfNotFound; }
			set { _contactReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ContactTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContactType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactTypeEntity ContactType
		{
			get	{ return GetSingleContactType(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncContactType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StoreContacts", "ContactType", _contactType, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ContactType. When set to true, ContactType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactType is accessed. You can always execute a forced fetch by calling GetSingleContactType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactType
		{
			get	{ return _alwaysFetchContactType; }
			set	{ _alwaysFetchContactType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactType already has been fetched. Setting this property to false when ContactType has been fetched
		/// will set ContactType to null as well. Setting this property to true while ContactType hasn't been fetched disables lazy loading for ContactType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactType
		{
			get { return _alreadyFetchedContactType;}
			set 
			{
				if(_alreadyFetchedContactType && !value)
				{
					this.ContactType = null;
				}
				_alreadyFetchedContactType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ContactType is not found
		/// in the database. When set to true, ContactType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ContactTypeReturnsNewIfNotFound
		{
			get	{ return _contactTypeReturnsNewIfNotFound; }
			set { _contactTypeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'StoreEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStore()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StoreEntity Store
		{
			get	{ return GetSingleStore(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStore(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StoreContacts", "Store", _store, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Store. When set to true, Store is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Store is accessed. You can always execute a forced fetch by calling GetSingleStore(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStore
		{
			get	{ return _alwaysFetchStore; }
			set	{ _alwaysFetchStore = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Store already has been fetched. Setting this property to false when Store has been fetched
		/// will set Store to null as well. Setting this property to true while Store hasn't been fetched disables lazy loading for Store</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStore
		{
			get { return _alreadyFetchedStore;}
			set 
			{
				if(_alreadyFetchedStore && !value)
				{
					this.Store = null;
				}
				_alreadyFetchedStore = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Store is not found
		/// in the database. When set to true, Store will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool StoreReturnsNewIfNotFound
		{
			get	{ return _storeReturnsNewIfNotFound; }
			set { _storeReturnsNewIfNotFound = value; }	
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
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.StoreContactEntity; }
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
