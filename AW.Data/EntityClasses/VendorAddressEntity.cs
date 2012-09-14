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

	/// <summary>Entity class which represents the entity 'VendorAddress'. <br/><br/>
	/// 
	/// MS_Description: Cross-reference mapping vendors and addresses.<br/>
	/// </summary>
	[Serializable]
	public partial class VendorAddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress, _addressReturnsNewIfNotFound;
		private AddressTypeEntity _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType, _addressTypeReturnsNewIfNotFound;
		private VendorEntity _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor, _vendorReturnsNewIfNotFound;

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
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VendorAddressEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public VendorAddressEntity() :base("VendorAddressEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		public VendorAddressEntity(System.Int32 addressID, System.Int32 vendorID):base("VendorAddressEntity")
		{
			InitClassFetch(addressID, vendorID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public VendorAddressEntity(System.Int32 addressID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse):base("VendorAddressEntity")
		{
			InitClassFetch(addressID, vendorID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="validator">The custom validator object for this VendorAddressEntity</param>
		public VendorAddressEntity(System.Int32 addressID, System.Int32 vendorID, IValidator validator):base("VendorAddressEntity")
		{
			InitClassFetch(addressID, vendorID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VendorAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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

			_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
			if(_vendor!=null)
			{
				_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_vendorReturnsNewIfNotFound = info.GetBoolean("_vendorReturnsNewIfNotFound");
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((VendorAddressFieldIndex)fieldIndex)
			{
				case VendorAddressFieldIndex.AddressID:
					DesetupSyncAddress(true, false);
					_alreadyFetchedAddress = false;
					break;
				case VendorAddressFieldIndex.AddressTypeID:
					DesetupSyncAddressType(true, false);
					_alreadyFetchedAddressType = false;
					break;
				case VendorAddressFieldIndex.VendorID:
					DesetupSyncVendor(true, false);
					_alreadyFetchedVendor = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddressType = (_addressType != null);
			_alreadyFetchedVendor = (_vendor != null);
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
				case "Address":
					toReturn.Add(Relations.AddressEntityUsingAddressID);
					break;
				case "AddressType":
					toReturn.Add(Relations.AddressTypeEntityUsingAddressTypeID);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorID);
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
			info.AddValue("_address", (!this.MarkedForDeletion?_address:null));
			info.AddValue("_addressReturnsNewIfNotFound", _addressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_addressType", (!this.MarkedForDeletion?_addressType:null));
			info.AddValue("_addressTypeReturnsNewIfNotFound", _addressTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			info.AddValue("_vendorReturnsNewIfNotFound", _vendorReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);

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
				case "Address":
					_alreadyFetchedAddress = true;
					this.Address = (AddressEntity)entity;
					break;
				case "AddressType":
					_alreadyFetchedAddressType = true;
					this.AddressType = (AddressTypeEntity)entity;
					break;
				case "Vendor":
					_alreadyFetchedVendor = true;
					this.Vendor = (VendorEntity)entity;
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
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "AddressType":
					SetupSyncAddressType(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
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
				case "Address":
					DesetupSyncAddress(false, true);
					break;
				case "AddressType":
					DesetupSyncAddressType(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
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
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_addressType!=null)
			{
				toReturn.Add(_addressType);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
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
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, System.Int32 vendorID)
		{
			return FetchUsingPK(addressID, vendorID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(addressID, vendorID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(addressID, vendorID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(addressID, vendorID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AddressID, this.VendorID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new VendorAddressRelations().GetAllRelations();
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
			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AddressEntityUsingAddressID);
				AddressEntity newEntity = new AddressEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.AddressID);
				}
				if(fetchResult)
				{
					newEntity = (AddressEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_addressReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Address = newEntity;
				_alreadyFetchedAddress = fetchResult;
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
			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AddressTypeEntityUsingAddressTypeID);
				AddressTypeEntity newEntity = new AddressTypeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.AddressTypeID);
				}
				if(fetchResult)
				{
					newEntity = (AddressTypeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_addressTypeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AddressType = newEntity;
				_alreadyFetchedAddressType = fetchResult;
			}
			return _addressType;
		}


		/// <summary> Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public VendorEntity GetSingleVendor()
		{
			return GetSingleVendor(false);
		}

		/// <summary> Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public virtual VendorEntity GetSingleVendor(bool forceFetch)
		{
			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.VendorEntityUsingVendorID);
				VendorEntity newEntity = new VendorEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.VendorID);
				}
				if(fetchResult)
				{
					newEntity = (VendorEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_vendorReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Vendor = newEntity;
				_alreadyFetchedVendor = fetchResult;
			}
			return _vendor;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Address", _address);
			toReturn.Add("AddressType", _addressType);
			toReturn.Add("Vendor", _vendor);
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
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="validator">The validator object for this VendorAddressEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 addressID, System.Int32 vendorID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(addressID, vendorID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_addressReturnsNewIfNotFound = true;
			_addressTypeReturnsNewIfNotFound = true;
			_vendorReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Cross-reference mapping vendors and addresses.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to Address.AddressID.");
			_fieldsCustomProperties.Add("AddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Address type. Foreign key to AddressType.AddressTypeID.");
			_fieldsCustomProperties.Add("AddressTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AW.Data.RelationClasses.StaticVendorAddressRelations.AddressEntityUsingAddressIDStatic, true, signalRelatedEntity, "VendorAddresses", resetFKFields, new int[] { (int)VendorAddressFieldIndex.AddressID } );		
			_address = null;
		}
		
		/// <summary> setups the sync logic for member _address</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntityCore relatedEntity)
		{
			if(_address!=relatedEntity)
			{		
				DesetupSyncAddress(true, true);
				_address = (AddressEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AW.Data.RelationClasses.StaticVendorAddressRelations.AddressEntityUsingAddressIDStatic, true, ref _alreadyFetchedAddress, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", AW.Data.RelationClasses.StaticVendorAddressRelations.AddressTypeEntityUsingAddressTypeIDStatic, true, signalRelatedEntity, "VendorAddresses", resetFKFields, new int[] { (int)VendorAddressFieldIndex.AddressTypeID } );		
			_addressType = null;
		}
		
		/// <summary> setups the sync logic for member _addressType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddressType(IEntityCore relatedEntity)
		{
			if(_addressType!=relatedEntity)
			{		
				DesetupSyncAddressType(true, true);
				_addressType = (AddressTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", AW.Data.RelationClasses.StaticVendorAddressRelations.AddressTypeEntityUsingAddressTypeIDStatic, true, ref _alreadyFetchedAddressType, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AW.Data.RelationClasses.StaticVendorAddressRelations.VendorEntityUsingVendorIDStatic, true, signalRelatedEntity, "VendorAddresses", resetFKFields, new int[] { (int)VendorAddressFieldIndex.VendorID } );		
			_vendor = null;
		}
		
		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{		
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AW.Data.RelationClasses.StaticVendorAddressRelations.VendorEntityUsingVendorIDStatic, true, ref _alreadyFetchedVendor, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="addressID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="vendorID">PK value for VendorAddress which data should be fetched into this VendorAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)VendorAddressFieldIndex.AddressID].ForcedCurrentValueWrite(addressID);
				this.Fields[(int)VendorAddressFieldIndex.VendorID].ForcedCurrentValueWrite(vendorID);
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
			return DAOFactory.CreateVendorAddressDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new VendorAddressEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static VendorAddressRelations Relations
		{
			get	{ return new VendorAddressRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), (IEntityRelation)GetRelationsForField("Address")[0], (int)AW.Data.EntityType.VendorAddressEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressType
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(), (IEntityRelation)GetRelationsForField("AddressType")[0], (int)AW.Data.EntityType.VendorAddressEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, null, "AddressType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendor
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), (IEntityRelation)GetRelationsForField("Vendor")[0], (int)AW.Data.EntityType.VendorAddressEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AddressID property of the Entity VendorAddress<br/><br/>
		/// MS_Description: Primary key. Foreign key to Address.AddressID.<br/>Primary key. Foreign key to Address.AddressID.</summary>
		/// <remarks>Mapped on  table field: "VendorAddress"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressID
		{
			get { return (System.Int32)GetValue((int)VendorAddressFieldIndex.AddressID, true); }
			set	{ SetValue((int)VendorAddressFieldIndex.AddressID, value, true); }
		}

		/// <summary> The AddressTypeID property of the Entity VendorAddress<br/><br/>
		/// MS_Description: Address type. Foreign key to AddressType.AddressTypeID.<br/>Address type. Foreign key to AddressType.AddressTypeID.</summary>
		/// <remarks>Mapped on  table field: "VendorAddress"."AddressTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.AddressType AddressTypeID
		{
			get { return (AW.Data.AddressType)GetValue((int)VendorAddressFieldIndex.AddressTypeID, true); }
			set	{ SetValue((int)VendorAddressFieldIndex.AddressTypeID, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity VendorAddress<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "VendorAddress"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorAddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorAddressFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The VendorID property of the Entity VendorAddress<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "VendorAddress"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)VendorAddressFieldIndex.VendorID, true); }
			set	{ SetValue((int)VendorAddressFieldIndex.VendorID, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual AddressEntity Address
		{
			get	{ return GetSingleAddress(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorAddresses", "Address", _address, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute a forced fetch by calling GetSingleAddress(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddressType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual AddressTypeEntity AddressType
		{
			get	{ return GetSingleAddressType(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAddressType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorAddresses", "AddressType", _addressType, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AddressType. When set to true, AddressType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType is accessed. You can always execute a forced fetch by calling GetSingleAddressType(true).</summary>
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

		/// <summary> Gets / sets related entity of type 'VendorEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual VendorEntity Vendor
		{
			get	{ return GetSingleVendor(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorAddresses", "Vendor", _vendor, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute a forced fetch by calling GetSingleVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendor
		{
			get	{ return _alwaysFetchVendor; }
			set	{ _alwaysFetchVendor = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Vendor already has been fetched. Setting this property to false when Vendor has been fetched
		/// will set Vendor to null as well. Setting this property to true while Vendor hasn't been fetched disables lazy loading for Vendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendor
		{
			get { return _alreadyFetchedVendor;}
			set 
			{
				if(_alreadyFetchedVendor && !value)
				{
					this.Vendor = null;
				}
				_alreadyFetchedVendor = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Vendor is not found
		/// in the database. When set to true, Vendor will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool VendorReturnsNewIfNotFound
		{
			get	{ return _vendorReturnsNewIfNotFound; }
			set { _vendorReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.VendorAddressEntity; }
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
