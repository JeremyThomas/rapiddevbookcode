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
	
	/// <summary>Entity base class which represents the base class for the entity 'ContactType'.<br/><br/>
	/// 
	/// MS_Description: Lookup table containing the types of contacts stored in Contact.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ContactTypeEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaStoreContact;
		private bool	_alwaysFetchContactCollectionViaStoreContact, _alreadyFetchedContactCollectionViaStoreContact;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaVendorContact;
		private bool	_alwaysFetchContactCollectionViaVendorContact, _alreadyFetchedContactCollectionViaVendorContact;
		private AW.Data.CollectionClasses.StoreCollection _storeCollectionViaStoreContact;
		private bool	_alwaysFetchStoreCollectionViaStoreContact, _alreadyFetchedStoreCollectionViaStoreContact;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaVendorContact;
		private bool	_alwaysFetchVendorCollectionViaVendorContact, _alreadyFetchedVendorCollectionViaVendorContact;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name StoreContact</summary>
			public static readonly string StoreContact = "StoreContact";
			/// <summary>Member name VendorContact</summary>
			public static readonly string VendorContact = "VendorContact";
			/// <summary>Member name ContactCollectionViaStoreContact</summary>
			public static readonly string ContactCollectionViaStoreContact = "ContactCollectionViaStoreContact";
			/// <summary>Member name ContactCollectionViaVendorContact</summary>
			public static readonly string ContactCollectionViaVendorContact = "ContactCollectionViaVendorContact";
			/// <summary>Member name StoreCollectionViaStoreContact</summary>
			public static readonly string StoreCollectionViaStoreContact = "StoreCollectionViaStoreContact";
			/// <summary>Member name VendorCollectionViaVendorContact</summary>
			public static readonly string VendorCollectionViaVendorContact = "VendorCollectionViaVendorContact";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ContactTypeEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ContactTypeEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		public ContactTypeEntityBase(System.Int32 contactTypeID)
		{
			InitClassFetch(contactTypeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactTypeEntityBase(System.Int32 contactTypeID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(contactTypeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		public ContactTypeEntityBase(System.Int32 contactTypeID, IValidator validator)
		{
			InitClassFetch(contactTypeID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactTypeEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_storeContact = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContact", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");
			_vendorContact = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContact", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");
			_contactCollectionViaStoreContact = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaStoreContact = info.GetBoolean("_alwaysFetchContactCollectionViaStoreContact");
			_alreadyFetchedContactCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedContactCollectionViaStoreContact");
			_contactCollectionViaVendorContact = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaVendorContact = info.GetBoolean("_alwaysFetchContactCollectionViaVendorContact");
			_alreadyFetchedContactCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedContactCollectionViaVendorContact");
			_storeCollectionViaStoreContact = (AW.Data.CollectionClasses.StoreCollection)info.GetValue("_storeCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.StoreCollection));
			_alwaysFetchStoreCollectionViaStoreContact = info.GetBoolean("_alwaysFetchStoreCollectionViaStoreContact");
			_alreadyFetchedStoreCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedStoreCollectionViaStoreContact");
			_vendorCollectionViaVendorContact = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaVendorContact = info.GetBoolean("_alwaysFetchVendorCollectionViaVendorContact");
			_alreadyFetchedVendorCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedVendorCollectionViaVendorContact");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ContactTypeFieldIndex)fieldIndex)
			{
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
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedContactCollectionViaStoreContact = (_contactCollectionViaStoreContact.Count > 0);
			_alreadyFetchedContactCollectionViaVendorContact = (_contactCollectionViaVendorContact.Count > 0);
			_alreadyFetchedStoreCollectionViaStoreContact = (_storeCollectionViaStoreContact.Count > 0);
			_alreadyFetchedVendorCollectionViaVendorContact = (_vendorCollectionViaVendorContact.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ContactTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "StoreContact":
					toReturn.Add(ContactTypeEntity.Relations.StoreContactEntityUsingContactTypeID);
					break;
				case "VendorContact":
					toReturn.Add(ContactTypeEntity.Relations.VendorContactEntityUsingContactTypeID);
					break;
				case "ContactCollectionViaStoreContact":
					toReturn.Add(ContactTypeEntity.Relations.StoreContactEntityUsingContactTypeID, "ContactTypeEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.ContactEntityUsingContactID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaVendorContact":
					toReturn.Add(ContactTypeEntity.Relations.VendorContactEntityUsingContactTypeID, "ContactTypeEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.ContactEntityUsingContactID, "VendorContact_", string.Empty, JoinHint.None);
					break;
				case "StoreCollectionViaStoreContact":
					toReturn.Add(ContactTypeEntity.Relations.StoreContactEntityUsingContactTypeID, "ContactTypeEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.StoreEntityUsingCustomerID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaVendorContact":
					toReturn.Add(ContactTypeEntity.Relations.VendorContactEntityUsingContactTypeID, "ContactTypeEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.VendorEntityUsingVendorID, "VendorContact_", string.Empty, JoinHint.None);
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
			info.AddValue("_vendorContact", (!this.MarkedForDeletion?_vendorContact:null));
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_contactCollectionViaStoreContact", (!this.MarkedForDeletion?_contactCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchContactCollectionViaStoreContact", _alwaysFetchContactCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedContactCollectionViaStoreContact", _alreadyFetchedContactCollectionViaStoreContact);
			info.AddValue("_contactCollectionViaVendorContact", (!this.MarkedForDeletion?_contactCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchContactCollectionViaVendorContact", _alwaysFetchContactCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedContactCollectionViaVendorContact", _alreadyFetchedContactCollectionViaVendorContact);
			info.AddValue("_storeCollectionViaStoreContact", (!this.MarkedForDeletion?_storeCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchStoreCollectionViaStoreContact", _alwaysFetchStoreCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedStoreCollectionViaStoreContact", _alreadyFetchedStoreCollectionViaStoreContact);
			info.AddValue("_vendorCollectionViaVendorContact", (!this.MarkedForDeletion?_vendorCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchVendorCollectionViaVendorContact", _alwaysFetchVendorCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedVendorCollectionViaVendorContact", _alreadyFetchedVendorCollectionViaVendorContact);


			
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

				case "StoreContact":
					_alreadyFetchedStoreContact = true;
					if(entity!=null)
					{
						this.StoreContact.Add((StoreContactEntity)entity);
					}
					break;
				case "VendorContact":
					_alreadyFetchedVendorContact = true;
					if(entity!=null)
					{
						this.VendorContact.Add((VendorContactEntity)entity);
					}
					break;
				case "ContactCollectionViaStoreContact":
					_alreadyFetchedContactCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.ContactCollectionViaStoreContact.Add((ContactEntity)entity);
					}
					break;
				case "ContactCollectionViaVendorContact":
					_alreadyFetchedContactCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.ContactCollectionViaVendorContact.Add((ContactEntity)entity);
					}
					break;
				case "StoreCollectionViaStoreContact":
					_alreadyFetchedStoreCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.StoreCollectionViaStoreContact.Add((StoreEntity)entity);
					}
					break;
				case "VendorCollectionViaVendorContact":
					_alreadyFetchedVendorCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.VendorCollectionViaVendorContact.Add((VendorEntity)entity);
					}
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

				case "StoreContact":
					_storeContact.Add((StoreContactEntity)relatedEntity);
					break;
				case "VendorContact":
					_vendorContact.Add((VendorContactEntity)relatedEntity);
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

				case "StoreContact":
					base.PerformRelatedEntityRemoval(_storeContact, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorContact":
					base.PerformRelatedEntityRemoval(_vendorContact, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_storeContact);
			toReturn.Add(_vendorContact);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactTypeID)
		{
			return FetchUsingPK(contactTypeID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactTypeID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactTypeID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(contactTypeID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactTypeID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactTypeID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ContactTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ContactTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ContactTypeRelations().GetAllRelations();
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
				_storeContact.GetMultiManyToOne(null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorContact(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorContact.GetMultiManyToOne(null, this, null, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorContact'. These settings will be taken into account
		/// when the property VendorContact is requested or GetMultiVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContact.SortClauses=sortClauses;
			_vendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(ContactTypeFields.ContactTypeID, ComparisonOperator.Equal, this.ContactTypeID, "ContactTypeEntity__"));
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

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiContactCollectionViaVendorContact(forceFetch, _contactCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaVendorContact || forceFetch || _alwaysFetchContactCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactTypeFields.ContactTypeID, ComparisonOperator.Equal, this.ContactTypeID, "ContactTypeEntity__"));
				_contactCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("ContactCollectionViaVendorContact"));
				_contactCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaVendorContact = true;
			}
			return _contactCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaVendorContact'. These settings will be taken into account
		/// when the property ContactCollectionViaVendorContact is requested or GetMultiContactCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaVendorContact.SortClauses=sortClauses;
			_contactCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStoreCollectionViaStoreContact(bool forceFetch)
		{
			return GetMultiStoreCollectionViaStoreContact(forceFetch, _storeCollectionViaStoreContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStoreCollectionViaStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStoreCollectionViaStoreContact || forceFetch || _alwaysFetchStoreCollectionViaStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_storeCollectionViaStoreContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeCollectionViaStoreContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactTypeFields.ContactTypeID, ComparisonOperator.Equal, this.ContactTypeID, "ContactTypeEntity__"));
				_storeCollectionViaStoreContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_storeCollectionViaStoreContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_storeCollectionViaStoreContact.GetMulti(filter, GetRelationsForField("StoreCollectionViaStoreContact"));
				_storeCollectionViaStoreContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreCollectionViaStoreContact = true;
			}
			return _storeCollectionViaStoreContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'StoreCollectionViaStoreContact'. These settings will be taken into account
		/// when the property StoreCollectionViaStoreContact is requested or GetMultiStoreCollectionViaStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreCollectionViaStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeCollectionViaStoreContact.SortClauses=sortClauses;
			_storeCollectionViaStoreContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiVendorCollectionViaVendorContact(forceFetch, _vendorCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorCollectionViaVendorContact || forceFetch || _alwaysFetchVendorCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactTypeFields.ContactTypeID, ComparisonOperator.Equal, this.ContactTypeID, "ContactTypeEntity__"));
				_vendorCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("VendorCollectionViaVendorContact"));
				_vendorCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorCollectionViaVendorContact = true;
			}
			return _vendorCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorCollectionViaVendorContact'. These settings will be taken into account
		/// when the property VendorCollectionViaVendorContact is requested or GetMultiVendorCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorCollectionViaVendorContact.SortClauses=sortClauses;
			_vendorCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ContactTypeDAO dao = (ContactTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_storeContact.ActiveContext = base.ActiveContext;
			_vendorContact.ActiveContext = base.ActiveContext;
			_contactCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			_contactCollectionViaVendorContact.ActiveContext = base.ActiveContext;
			_storeCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			_vendorCollectionViaVendorContact.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactTypeDAO dao = (ContactTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactTypeDAO dao = (ContactTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ContactTypeEntity);
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

			toReturn.Add("StoreContact", _storeContact);
			toReturn.Add("VendorContact", _vendorContact);
			toReturn.Add("ContactCollectionViaStoreContact", _contactCollectionViaStoreContact);
			toReturn.Add("ContactCollectionViaVendorContact", _contactCollectionViaVendorContact);
			toReturn.Add("StoreCollectionViaStoreContact", _storeCollectionViaStoreContact);
			toReturn.Add("VendorCollectionViaVendorContact", _vendorCollectionViaVendorContact);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The validator object for this ContactTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 contactTypeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(contactTypeID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_storeContact = new AW.Data.CollectionClasses.StoreContactCollection(new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "ContactType");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_vendorContact = new AW.Data.CollectionClasses.VendorContactCollection(new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "ContactType");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_contactCollectionViaStoreContact = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaStoreContact = false;
			_alreadyFetchedContactCollectionViaStoreContact = false;
			_contactCollectionViaVendorContact = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaVendorContact = false;
			_alreadyFetchedContactCollectionViaVendorContact = false;
			_storeCollectionViaStoreContact = new AW.Data.CollectionClasses.StoreCollection(new StoreEntityFactory());
			_alwaysFetchStoreCollectionViaStoreContact = false;
			_alreadyFetchedStoreCollectionViaStoreContact = false;
			_vendorCollectionViaVendorContact = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaVendorContact = false;
			_alreadyFetchedVendorCollectionViaVendorContact = false;



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
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ContactTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Contact type description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
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
		private bool Fetch(System.Int32 contactTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ContactTypeFieldIndex.ContactTypeID].ForcedCurrentValueWrite(contactTypeID);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(),
					(IEntityRelation)GetRelationsForField("StoreContact")[0], (int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(),
					(IEntityRelation)GetRelationsForField("VendorContact")[0], (int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactTypeEntity.Relations.StoreContactEntityUsingContactTypeID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaStoreContact"), "ContactCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactTypeEntity.Relations.VendorContactEntityUsingContactTypeID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaVendorContact"), "ContactCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactTypeEntity.Relations.StoreContactEntityUsingContactTypeID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.StoreEntity, 0, null, null, GetRelationsForField("StoreCollectionViaStoreContact"), "StoreCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactTypeEntity.Relations.VendorContactEntityUsingContactTypeID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactTypeEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaVendorContact"), "VendorCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ContactTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ContactTypeEntity.CustomProperties;}
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
			get { return ContactTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The ContactTypeID property of the Entity ContactType<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."ContactTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ContactTypeID
		{
			get { return (System.Int32)GetValue((int)ContactTypeFieldIndex.ContactTypeID, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.ContactTypeID, value, true); }
		}
		/// <summary> The Name property of the Entity ContactType<br/><br/>
		/// 
		/// MS_Description: Contact type description.<br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ContactTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ContactType<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.ModifiedDate, value, true); }
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
		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorContactCollection VendorContact
		{
			get	{ return GetMultiVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorContact. When set to true, VendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContact
		{
			get	{ return _alwaysFetchVendorContact; }
			set	{ _alwaysFetchVendorContact = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorContact already has been fetched. Setting this property to false when VendorContact has been fetched
		/// will clear the VendorContact collection well. Setting this property to true while VendorContact hasn't been fetched disables lazy loading for VendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorContact
		{
			get { return _alreadyFetchedVendorContact;}
			set 
			{
				if(_alreadyFetchedVendorContact && !value && (_vendorContact != null))
				{
					_vendorContact.Clear();
				}
				_alreadyFetchedVendorContact = value;
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
		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaVendorContact
		{
			get { return GetMultiContactCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaVendorContact. When set to true, ContactCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaVendorContact
		{
			get	{ return _alwaysFetchContactCollectionViaVendorContact; }
			set	{ _alwaysFetchContactCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaVendorContact already has been fetched. Setting this property to false when ContactCollectionViaVendorContact has been fetched
		/// will clear the ContactCollectionViaVendorContact collection well. Setting this property to true while ContactCollectionViaVendorContact hasn't been fetched disables lazy loading for ContactCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaVendorContact
		{
			get { return _alreadyFetchedContactCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaVendorContact && !value && (_contactCollectionViaVendorContact != null))
				{
					_contactCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedContactCollectionViaVendorContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreCollectionViaStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreCollection StoreCollectionViaStoreContact
		{
			get { return GetMultiStoreCollectionViaStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StoreCollectionViaStoreContact. When set to true, StoreCollectionViaStoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreCollectionViaStoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiStoreCollectionViaStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreCollectionViaStoreContact
		{
			get	{ return _alwaysFetchStoreCollectionViaStoreContact; }
			set	{ _alwaysFetchStoreCollectionViaStoreContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreCollectionViaStoreContact already has been fetched. Setting this property to false when StoreCollectionViaStoreContact has been fetched
		/// will clear the StoreCollectionViaStoreContact collection well. Setting this property to true while StoreCollectionViaStoreContact hasn't been fetched disables lazy loading for StoreCollectionViaStoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreCollectionViaStoreContact
		{
			get { return _alreadyFetchedStoreCollectionViaStoreContact;}
			set 
			{
				if(_alreadyFetchedStoreCollectionViaStoreContact && !value && (_storeCollectionViaStoreContact != null))
				{
					_storeCollectionViaStoreContact.Clear();
				}
				_alreadyFetchedStoreCollectionViaStoreContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorCollection VendorCollectionViaVendorContact
		{
			get { return GetMultiVendorCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorCollectionViaVendorContact. When set to true, VendorCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorCollectionViaVendorContact
		{
			get	{ return _alwaysFetchVendorCollectionViaVendorContact; }
			set	{ _alwaysFetchVendorCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorCollectionViaVendorContact already has been fetched. Setting this property to false when VendorCollectionViaVendorContact has been fetched
		/// will clear the VendorCollectionViaVendorContact collection well. Setting this property to true while VendorCollectionViaVendorContact hasn't been fetched disables lazy loading for VendorCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorCollectionViaVendorContact
		{
			get { return _alreadyFetchedVendorCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedVendorCollectionViaVendorContact && !value && (_vendorCollectionViaVendorContact != null))
				{
					_vendorCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedVendorCollectionViaVendorContact = value;
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
		public override int LLBLGenProEntityTypeValue 
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
