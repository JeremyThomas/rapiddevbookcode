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
	/// <summary>Entity base class which represents the base class for the entity 'Individual'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class IndividualEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";


			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static IndividualEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public IndividualEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		public IndividualEntityBase(System.Int32 customerId)
		{
			InitClassFetch(customerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public IndividualEntityBase(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(customerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="validator">The custom validator object for this IndividualEntity</param>
		public IndividualEntityBase(System.Int32 customerId, IValidator validator)
		{
			InitClassFetch(customerId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IndividualEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
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
			switch((IndividualFieldIndex)fieldIndex)
			{
				case IndividualFieldIndex.CustomerId:
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					break;
				case IndividualFieldIndex.ContactId:
					DesetupSyncContact(true, false);
					_alreadyFetchedContact = false;
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


			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedCustomer = (_customer != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return IndividualEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Contact":
					toReturn.Add(IndividualEntity.Relations.ContactEntityUsingContactId);
					break;


				case "Customer":
					toReturn.Add(IndividualEntity.Relations.CustomerEntityUsingCustomerId);
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


			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
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
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
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
				case "Contact":
					SetupSyncContact(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false, true);
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
			if(_contact!=null)
			{
				toReturn.Add(_contact);
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
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId)
		{
			return FetchUsingPK(customerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(IndividualFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(IndividualFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new IndividualRelations().GetAllRelations();
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
			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(IndividualEntity.Relations.ContactEntityUsingContactId);

				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ContactId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ContactEntity)base.ActiveContext.Get(newEntity);
					}
					this.Contact = newEntity;
				}
				else
				{
					if(_contactReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_contact == null)))
						{
							this.Contact = newEntity;
						}
					}
					else
					{
						this.Contact = null;
					}
				}
				_alreadyFetchedContact = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _contact;
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
				IEntityRelation relation = IndividualEntity.Relations.CustomerEntityUsingCustomerId;
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(relation))
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerId);
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
			IndividualDAO dao = (IndividualDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_contact!=null)
			{
				_contact.ActiveContext = base.ActiveContext;
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
			IndividualDAO dao = (IndividualDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			IndividualDAO dao = (IndividualDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.IndividualEntity);
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
			toReturn.Add("Contact", _contact);


			toReturn.Add("Customer", _customer);
			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="validator">The validator object for this IndividualEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 customerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(customerId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_contact = null;
			_contactReturnsNewIfNotFound = true;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
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

			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContact(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", IndividualEntity.Relations.ContactEntityUsingContactId, true, signalRelatedEntity, "Individual", resetFKFields, new int[] { (int)IndividualFieldIndex.ContactId } );		
			_contact = null;
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			if(_contact!=relatedEntity)
			{		
				DesetupSyncContact(true, true);
				_contact = (ContactEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", IndividualEntity.Relations.ContactEntityUsingContactId, true, ref _alreadyFetchedContact, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", IndividualEntity.Relations.CustomerEntityUsingCustomerId, true, signalRelatedEntity, "Individual", false, new int[] { (int)IndividualFieldIndex.CustomerId } );
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
				base.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", IndividualEntity.Relations.CustomerEntityUsingCustomerId, true, ref _alreadyFetchedCustomer, new string[] {  } );
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
		/// <param name="customerId">PK value for Individual which data should be fetched into this Individual object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)IndividualFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
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
			return DAOFactory.CreateIndividualDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new IndividualEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static IndividualRelations Relations
		{
			get	{ return new IndividualRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(),
					(IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.IndividualEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Customer")[0], (int)AW.Data.EntityType.IndividualEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "IndividualEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return IndividualEntity.CustomProperties;}
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
			get { return IndividualEntity.FieldsCustomProperties;}
		}

		/// <summary> The CustomerId property of the Entity Individual<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Individual"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)IndividualFieldIndex.CustomerId, true); }
			set	{ SetValue((int)IndividualFieldIndex.CustomerId, value, true); }
		}
		/// <summary> The ContactId property of the Entity Individual<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Individual"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactId
		{
			get { return (System.Int32)GetValue((int)IndividualFieldIndex.ContactId, true); }
			set	{ SetValue((int)IndividualFieldIndex.ContactId, value, true); }
		}
		/// <summary> The Demographics property of the Entity Individual<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Individual"."Demographics"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)IndividualFieldIndex.Demographics, true); }
			set	{ SetValue((int)IndividualFieldIndex.Demographics, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Individual<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Individual"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)IndividualFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)IndividualFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual ContactEntity Contact
		{
			get	{ return GetSingleContact(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					if(value==null)
					{
						if(_contact != null)
						{
							_contact.UnsetRelatedEntity(this, "Individual");
						}
					}
					else
					{
						if(_contact!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Individual");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetSingleContact(true).</summary>
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

		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
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
						DesetupSyncCustomer(true, true);
					}
					else
					{
						if(_customer!=value)
						{
							IEntity relatedEntity = (IEntity)value;
							relatedEntity.SetRelatedEntity(this, "Individual");
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
			get { return (int)AW.Data.EntityType.IndividualEntity; }
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
