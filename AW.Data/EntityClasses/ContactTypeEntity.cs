///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'ContactType'. <br/><br/>
	/// 
	/// MS_Description: Lookup table containing the types of contacts stored in Contact.<br/>
	/// </summary>
	[Serializable]
	public partial class ContactTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContacts;
		private bool	_alwaysFetchVendorContacts, _alreadyFetchedVendorContacts;
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContacts;
		private bool	_alwaysFetchStoreContacts, _alreadyFetchedStoreContacts;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name VendorContacts</summary>
			public static readonly string VendorContacts = "VendorContacts";
			/// <summary>Member name StoreContacts</summary>
			public static readonly string StoreContacts = "StoreContacts";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ContactTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ContactTypeEntity() :base("ContactTypeEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		public ContactTypeEntity(AW.Data.ContactType contactTypeID):base("ContactTypeEntity")
		{
			InitClassFetch(contactTypeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactTypeEntity(AW.Data.ContactType contactTypeID, IPrefetchPath prefetchPathToUse):base("ContactTypeEntity")
		{
			InitClassFetch(contactTypeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		public ContactTypeEntity(AW.Data.ContactType contactTypeID, IValidator validator):base("ContactTypeEntity")
		{
			InitClassFetch(contactTypeID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_vendorContacts = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContacts", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContacts = info.GetBoolean("_alwaysFetchVendorContacts");
			_alreadyFetchedVendorContacts = info.GetBoolean("_alreadyFetchedVendorContacts");

			_storeContacts = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContacts", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContacts = info.GetBoolean("_alwaysFetchStoreContacts");
			_alreadyFetchedStoreContacts = info.GetBoolean("_alreadyFetchedStoreContacts");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedVendorContacts = (_vendorContacts.Count > 0);
			_alreadyFetchedStoreContacts = (_storeContacts.Count > 0);
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
				case "VendorContacts":
					toReturn.Add(Relations.VendorContactEntityUsingContactTypeID);
					break;
				case "StoreContacts":
					toReturn.Add(Relations.StoreContactEntityUsingContactTypeID);
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
			info.AddValue("_vendorContacts", (!this.MarkedForDeletion?_vendorContacts:null));
			info.AddValue("_alwaysFetchVendorContacts", _alwaysFetchVendorContacts);
			info.AddValue("_alreadyFetchedVendorContacts", _alreadyFetchedVendorContacts);
			info.AddValue("_storeContacts", (!this.MarkedForDeletion?_storeContacts:null));
			info.AddValue("_alwaysFetchStoreContacts", _alwaysFetchStoreContacts);
			info.AddValue("_alreadyFetchedStoreContacts", _alreadyFetchedStoreContacts);

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
				case "VendorContacts":
					_alreadyFetchedVendorContacts = true;
					if(entity!=null)
					{
						this.VendorContacts.Add((VendorContactEntity)entity);
					}
					break;
				case "StoreContacts":
					_alreadyFetchedStoreContacts = true;
					if(entity!=null)
					{
						this.StoreContacts.Add((StoreContactEntity)entity);
					}
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
				case "VendorContacts":
					_vendorContacts.Add((VendorContactEntity)relatedEntity);
					break;
				case "StoreContacts":
					_storeContacts.Add((StoreContactEntity)relatedEntity);
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
				case "VendorContacts":
					this.PerformRelatedEntityRemoval(_vendorContacts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "StoreContacts":
					this.PerformRelatedEntityRemoval(_storeContacts, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_vendorContacts);
			toReturn.Add(_storeContacts);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(AW.Data.ContactType contactTypeID)
		{
			return FetchUsingPK(contactTypeID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(AW.Data.ContactType contactTypeID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactTypeID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(AW.Data.ContactType contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(contactTypeID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(AW.Data.ContactType contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactTypeID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactTypeID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ContactTypeRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch)
		{
			return GetMultiVendorContacts(forceFetch, _vendorContacts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorContacts(forceFetch, _vendorContacts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorContacts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContacts || forceFetch || _alwaysFetchVendorContacts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vendorContacts);
				_vendorContacts.SuppressClearInGetMulti=!forceFetch;
				_vendorContacts.EntityFactoryToUse = entityFactoryToUse;
				_vendorContacts.GetMultiManyToOne(null, this, null, filter);
				_vendorContacts.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContacts = true;
			}
			return _vendorContacts;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorContacts'. These settings will be taken into account
		/// when the property VendorContacts is requested or GetMultiVendorContacts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContacts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContacts.SortClauses=sortClauses;
			_vendorContacts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContacts(bool forceFetch)
		{
			return GetMultiStoreContacts(forceFetch, _storeContacts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContacts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStoreContacts(forceFetch, _storeContacts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContacts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStoreContacts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContacts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStoreContacts || forceFetch || _alwaysFetchStoreContacts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_storeContacts);
				_storeContacts.SuppressClearInGetMulti=!forceFetch;
				_storeContacts.EntityFactoryToUse = entityFactoryToUse;
				_storeContacts.GetMultiManyToOne(null, this, null, filter);
				_storeContacts.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContacts = true;
			}
			return _storeContacts;
		}

		/// <summary> Sets the collection parameters for the collection for 'StoreContacts'. These settings will be taken into account
		/// when the property StoreContacts is requested or GetMultiStoreContacts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreContacts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeContacts.SortClauses=sortClauses;
			_storeContacts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("VendorContacts", _vendorContacts);
			toReturn.Add("StoreContacts", _storeContacts);
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
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The validator object for this ContactTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(AW.Data.ContactType contactTypeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(contactTypeID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_vendorContacts = new AW.Data.CollectionClasses.VendorContactCollection();
			_vendorContacts.SetContainingEntityInfo(this, "ContactType");

			_storeContacts = new AW.Data.CollectionClasses.StoreContactCollection();
			_storeContacts.SetContainingEntityInfo(this, "ContactType");
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
			_customProperties.Add("MS_Description", @"Lookup table containing the types of contacts stored in Contact.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ContactTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Contact type description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(AW.Data.ContactType contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ContactTypeFieldIndex.ContactTypeID].ForcedCurrentValueWrite(contactTypeID);
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
			return DAOFactory.CreateContactTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ContactTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ContactTypeRelations Relations
		{
			get	{ return new ContactTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(), (IEntityRelation)GetRelationsForField("VendorContacts")[0], (int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(), (IEntityRelation)GetRelationsForField("StoreContacts")[0], (int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The ContactTypeID property of the Entity ContactType<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "ContactType"."ContactTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual AW.Data.ContactType ContactTypeID
		{
			get { return (AW.Data.ContactType)GetValue((int)ContactTypeFieldIndex.ContactTypeID, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.ContactTypeID, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity ContactType<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "ContactType"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity ContactType<br/><br/>
		/// MS_Description: Contact type description.<br/>Contact type description.</summary>
		/// <remarks>Mapped on  table field: "ContactType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ContactTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContacts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorContactCollection VendorContacts
		{
			get	{ return GetMultiVendorContacts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorContacts. When set to true, VendorContacts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContacts is accessed. You can always execute/ a forced fetch by calling GetMultiVendorContacts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContacts
		{
			get	{ return _alwaysFetchVendorContacts; }
			set	{ _alwaysFetchVendorContacts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorContacts already has been fetched. Setting this property to false when VendorContacts has been fetched
		/// will clear the VendorContacts collection well. Setting this property to true while VendorContacts hasn't been fetched disables lazy loading for VendorContacts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorContacts
		{
			get { return _alreadyFetchedVendorContacts;}
			set 
			{
				if(_alreadyFetchedVendorContacts && !value && (_vendorContacts != null))
				{
					_vendorContacts.Clear();
				}
				_alreadyFetchedVendorContacts = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreContacts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreContactCollection StoreContacts
		{
			get	{ return GetMultiStoreContacts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StoreContacts. When set to true, StoreContacts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreContacts is accessed. You can always execute/ a forced fetch by calling GetMultiStoreContacts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreContacts
		{
			get	{ return _alwaysFetchStoreContacts; }
			set	{ _alwaysFetchStoreContacts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreContacts already has been fetched. Setting this property to false when StoreContacts has been fetched
		/// will clear the StoreContacts collection well. Setting this property to true while StoreContacts hasn't been fetched disables lazy loading for StoreContacts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreContacts
		{
			get { return _alreadyFetchedStoreContacts;}
			set 
			{
				if(_alreadyFetchedStoreContacts && !value && (_storeContacts != null))
				{
					_storeContacts.Clear();
				}
				_alreadyFetchedStoreContacts = value;
			}
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
			get { return (int)AW.Data.EntityType.ContactTypeEntity; }
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
