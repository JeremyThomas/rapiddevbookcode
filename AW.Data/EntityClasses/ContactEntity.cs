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

	/// <summary>Entity class which represents the entity 'Contact'. <br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public partial class ContactEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeCollection	_employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees;
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContacts;
		private bool	_alwaysFetchVendorContacts, _alreadyFetchedVendorContacts;
		private AW.Data.CollectionClasses.ContactCreditCardCollection	_contactCreditCards;
		private bool	_alwaysFetchContactCreditCards, _alreadyFetchedContactCreditCards;
		private AW.Data.CollectionClasses.IndividualCollection	_individuals;
		private bool	_alwaysFetchIndividuals, _alreadyFetchedIndividuals;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContacts;
		private bool	_alwaysFetchStoreContacts, _alreadyFetchedStoreContacts;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCards;
		private bool	_alwaysFetchCreditCards, _alreadyFetchedCreditCards;
		private AW.Data.CollectionClasses.StoreCollection _stores;
		private bool	_alwaysFetchStores, _alreadyFetchedStores;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name VendorContacts</summary>
			public static readonly string VendorContacts = "VendorContacts";
			/// <summary>Member name ContactCreditCards</summary>
			public static readonly string ContactCreditCards = "ContactCreditCards";
			/// <summary>Member name Individuals</summary>
			public static readonly string Individuals = "Individuals";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name StoreContacts</summary>
			public static readonly string StoreContacts = "StoreContacts";
			/// <summary>Member name CreditCards</summary>
			public static readonly string CreditCards = "CreditCards";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ContactEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ContactEntity() :base("ContactEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		public ContactEntity(System.Int32 contactID):base("ContactEntity")
		{
			InitClassFetch(contactID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactEntity(System.Int32 contactID, IPrefetchPath prefetchPathToUse):base("ContactEntity")
		{
			InitClassFetch(contactID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		public ContactEntity(System.Int32 contactID, IValidator validator):base("ContactEntity")
		{
			InitClassFetch(contactID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employees = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employees", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");

			_vendorContacts = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContacts", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContacts = info.GetBoolean("_alwaysFetchVendorContacts");
			_alreadyFetchedVendorContacts = info.GetBoolean("_alreadyFetchedVendorContacts");

			_contactCreditCards = (AW.Data.CollectionClasses.ContactCreditCardCollection)info.GetValue("_contactCreditCards", typeof(AW.Data.CollectionClasses.ContactCreditCardCollection));
			_alwaysFetchContactCreditCards = info.GetBoolean("_alwaysFetchContactCreditCards");
			_alreadyFetchedContactCreditCards = info.GetBoolean("_alreadyFetchedContactCreditCards");

			_individuals = (AW.Data.CollectionClasses.IndividualCollection)info.GetValue("_individuals", typeof(AW.Data.CollectionClasses.IndividualCollection));
			_alwaysFetchIndividuals = info.GetBoolean("_alwaysFetchIndividuals");
			_alreadyFetchedIndividuals = info.GetBoolean("_alreadyFetchedIndividuals");

			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");

			_storeContacts = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContacts", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContacts = info.GetBoolean("_alwaysFetchStoreContacts");
			_alreadyFetchedStoreContacts = info.GetBoolean("_alreadyFetchedStoreContacts");
			_creditCards = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCards", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCards = info.GetBoolean("_alwaysFetchCreditCards");
			_alreadyFetchedCreditCards = info.GetBoolean("_alreadyFetchedCreditCards");

			_stores = (AW.Data.CollectionClasses.StoreCollection)info.GetValue("_stores", typeof(AW.Data.CollectionClasses.StoreCollection));
			_alwaysFetchStores = info.GetBoolean("_alwaysFetchStores");
			_alreadyFetchedStores = info.GetBoolean("_alreadyFetchedStores");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployees = (_employees.Count > 0);
			_alreadyFetchedVendorContacts = (_vendorContacts.Count > 0);
			_alreadyFetchedContactCreditCards = (_contactCreditCards.Count > 0);
			_alreadyFetchedIndividuals = (_individuals.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedStoreContacts = (_storeContacts.Count > 0);
			_alreadyFetchedCreditCards = (_creditCards.Count > 0);
			_alreadyFetchedStores = (_stores.Count > 0);
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
				case "Employees":
					toReturn.Add(Relations.EmployeeEntityUsingContactID);
					break;
				case "VendorContacts":
					toReturn.Add(Relations.VendorContactEntityUsingContactID);
					break;
				case "ContactCreditCards":
					toReturn.Add(Relations.ContactCreditCardEntityUsingContactID);
					break;
				case "Individuals":
					toReturn.Add(Relations.IndividualEntityUsingContactID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingContactID);
					break;
				case "StoreContacts":
					toReturn.Add(Relations.StoreContactEntityUsingContactID);
					break;
				case "CreditCards":
					toReturn.Add(Relations.ContactCreditCardEntityUsingContactID, "ContactEntity__", "ContactCreditCard_", JoinHint.None);
					toReturn.Add(ContactCreditCardEntity.Relations.CreditCardEntityUsingCreditCardID, "ContactCreditCard_", string.Empty, JoinHint.None);
					break;
				case "Stores":
					toReturn.Add(Relations.StoreContactEntityUsingContactID, "ContactEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.StoreEntityUsingCustomerID, "StoreContact_", string.Empty, JoinHint.None);
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
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_vendorContacts", (!this.MarkedForDeletion?_vendorContacts:null));
			info.AddValue("_alwaysFetchVendorContacts", _alwaysFetchVendorContacts);
			info.AddValue("_alreadyFetchedVendorContacts", _alreadyFetchedVendorContacts);
			info.AddValue("_contactCreditCards", (!this.MarkedForDeletion?_contactCreditCards:null));
			info.AddValue("_alwaysFetchContactCreditCards", _alwaysFetchContactCreditCards);
			info.AddValue("_alreadyFetchedContactCreditCards", _alreadyFetchedContactCreditCards);
			info.AddValue("_individuals", (!this.MarkedForDeletion?_individuals:null));
			info.AddValue("_alwaysFetchIndividuals", _alwaysFetchIndividuals);
			info.AddValue("_alreadyFetchedIndividuals", _alreadyFetchedIndividuals);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_storeContacts", (!this.MarkedForDeletion?_storeContacts:null));
			info.AddValue("_alwaysFetchStoreContacts", _alwaysFetchStoreContacts);
			info.AddValue("_alreadyFetchedStoreContacts", _alreadyFetchedStoreContacts);
			info.AddValue("_creditCards", (!this.MarkedForDeletion?_creditCards:null));
			info.AddValue("_alwaysFetchCreditCards", _alwaysFetchCreditCards);
			info.AddValue("_alreadyFetchedCreditCards", _alreadyFetchedCreditCards);
			info.AddValue("_stores", (!this.MarkedForDeletion?_stores:null));
			info.AddValue("_alwaysFetchStores", _alwaysFetchStores);
			info.AddValue("_alreadyFetchedStores", _alreadyFetchedStores);

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
				case "Employees":
					_alreadyFetchedEmployees = true;
					if(entity!=null)
					{
						this.Employees.Add((EmployeeEntity)entity);
					}
					break;
				case "VendorContacts":
					_alreadyFetchedVendorContacts = true;
					if(entity!=null)
					{
						this.VendorContacts.Add((VendorContactEntity)entity);
					}
					break;
				case "ContactCreditCards":
					_alreadyFetchedContactCreditCards = true;
					if(entity!=null)
					{
						this.ContactCreditCards.Add((ContactCreditCardEntity)entity);
					}
					break;
				case "Individuals":
					_alreadyFetchedIndividuals = true;
					if(entity!=null)
					{
						this.Individuals.Add((IndividualEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "StoreContacts":
					_alreadyFetchedStoreContacts = true;
					if(entity!=null)
					{
						this.StoreContacts.Add((StoreContactEntity)entity);
					}
					break;
				case "CreditCards":
					_alreadyFetchedCreditCards = true;
					if(entity!=null)
					{
						this.CreditCards.Add((CreditCardEntity)entity);
					}
					break;
				case "Stores":
					_alreadyFetchedStores = true;
					if(entity!=null)
					{
						this.Stores.Add((StoreEntity)entity);
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
				case "Employees":
					_employees.Add((EmployeeEntity)relatedEntity);
					break;
				case "VendorContacts":
					_vendorContacts.Add((VendorContactEntity)relatedEntity);
					break;
				case "ContactCreditCards":
					_contactCreditCards.Add((ContactCreditCardEntity)relatedEntity);
					break;
				case "Individuals":
					_individuals.Add((IndividualEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "Employees":
					this.PerformRelatedEntityRemoval(_employees, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorContacts":
					this.PerformRelatedEntityRemoval(_vendorContacts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ContactCreditCards":
					this.PerformRelatedEntityRemoval(_contactCreditCards, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Individuals":
					this.PerformRelatedEntityRemoval(_individuals, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_employees);
			toReturn.Add(_vendorContacts);
			toReturn.Add(_contactCreditCards);
			toReturn.Add(_individuals);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_storeContacts);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID)
		{
			return FetchUsingPK(contactID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(contactID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ContactRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployees(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployees || forceFetch || _alwaysFetchEmployees) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employees);
				_employees.SuppressClearInGetMulti=!forceFetch;
				_employees.EntityFactoryToUse = entityFactoryToUse;
				_employees.GetMultiManyToOne(null, this, filter);
				_employees.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployees = true;
			}
			return _employees;
		}

		/// <summary> Sets the collection parameters for the collection for 'Employees'. These settings will be taken into account
		/// when the property Employees is requested or GetMultiEmployees is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployees(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employees.SortClauses=sortClauses;
			_employees.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendorContacts.GetMultiManyToOne(this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch)
		{
			return GetMultiContactCreditCards(forceFetch, _contactCreditCards.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiContactCreditCards(forceFetch, _contactCreditCards.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiContactCreditCards(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedContactCreditCards || forceFetch || _alwaysFetchContactCreditCards) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCreditCards);
				_contactCreditCards.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCards.EntityFactoryToUse = entityFactoryToUse;
				_contactCreditCards.GetMultiManyToOne(this, null, filter);
				_contactCreditCards.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCards = true;
			}
			return _contactCreditCards;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCreditCards'. These settings will be taken into account
		/// when the property ContactCreditCards is requested or GetMultiContactCreditCards is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCreditCards(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCreditCards.SortClauses=sortClauses;
			_contactCreditCards.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch)
		{
			return GetMultiIndividuals(forceFetch, _individuals.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIndividuals(forceFetch, _individuals.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIndividuals(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIndividuals || forceFetch || _alwaysFetchIndividuals) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_individuals);
				_individuals.SuppressClearInGetMulti=!forceFetch;
				_individuals.EntityFactoryToUse = entityFactoryToUse;
				_individuals.GetMultiManyToOne(this, null, filter);
				_individuals.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividuals = true;
			}
			return _individuals;
		}

		/// <summary> Sets the collection parameters for the collection for 'Individuals'. These settings will be taken into account
		/// when the property Individuals is requested or GetMultiIndividuals is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIndividuals(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_individuals.SortClauses=sortClauses;
			_individuals.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaders || forceFetch || _alwaysFetchSalesOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaders);
				_salesOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaders.GetMultiManyToOne(null, null, this, null, null, null, null, null, null, null, filter);
				_salesOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaders = true;
			}
			return _salesOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaders'. These settings will be taken into account
		/// when the property SalesOrderHeaders is requested or GetMultiSalesOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaders.SortClauses=sortClauses;
			_salesOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_storeContacts.GetMultiManyToOne(this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCards(bool forceFetch)
		{
			return GetMultiCreditCards(forceFetch, _creditCards.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCards(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCards || forceFetch || _alwaysFetchCreditCards) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_creditCards);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_creditCards.SuppressClearInGetMulti=!forceFetch;
				_creditCards.EntityFactoryToUse = entityFactoryToUse;
				_creditCards.GetMulti(filter, GetRelationsForField("CreditCards"));
				_creditCards.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCards = true;
			}
			return _creditCards;
		}

		/// <summary> Sets the collection parameters for the collection for 'CreditCards'. These settings will be taken into account
		/// when the property CreditCards is requested or GetMultiCreditCards is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCards(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCards.SortClauses=sortClauses;
			_creditCards.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch)
		{
			return GetMultiStores(forceFetch, _stores.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStores || forceFetch || _alwaysFetchStores) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_stores);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_stores.SuppressClearInGetMulti=!forceFetch;
				_stores.EntityFactoryToUse = entityFactoryToUse;
				_stores.GetMulti(filter, GetRelationsForField("Stores"));
				_stores.SuppressClearInGetMulti=false;
				_alreadyFetchedStores = true;
			}
			return _stores;
		}

		/// <summary> Sets the collection parameters for the collection for 'Stores'. These settings will be taken into account
		/// when the property Stores is requested or GetMultiStores is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStores(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stores.SortClauses=sortClauses;
			_stores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employees", _employees);
			toReturn.Add("VendorContacts", _vendorContacts);
			toReturn.Add("ContactCreditCards", _contactCreditCards);
			toReturn.Add("Individuals", _individuals);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("StoreContacts", _storeContacts);
			toReturn.Add("CreditCards", _creditCards);
			toReturn.Add("Stores", _stores);
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
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The validator object for this ContactEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 contactID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(contactID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employees = new AW.Data.CollectionClasses.EmployeeCollection();
			_employees.SetContainingEntityInfo(this, "Contact");

			_vendorContacts = new AW.Data.CollectionClasses.VendorContactCollection();
			_vendorContacts.SetContainingEntityInfo(this, "Contact");

			_contactCreditCards = new AW.Data.CollectionClasses.ContactCreditCardCollection();
			_contactCreditCards.SetContainingEntityInfo(this, "Contact");

			_individuals = new AW.Data.CollectionClasses.IndividualCollection();
			_individuals.SetContainingEntityInfo(this, "Contact");

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "Contact");

			_storeContacts = new AW.Data.CollectionClasses.StoreContactCollection();
			_storeContacts.SetContainingEntityInfo(this, "Contact");
			_creditCards = new AW.Data.CollectionClasses.CreditCardCollection();
			_stores = new AW.Data.CollectionClasses.StoreCollection();
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Additional contact information about the person stored in xml format. ");
			_fieldsCustomProperties.Add("AdditionalContactInfo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key for Contact records.");
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"E-mail address for the person.");
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");
			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"First name of the person.");
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Last name of the person.");
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Middle name or middle initial of the person.");
			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("NameStyle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Password for the e-mail account.");
			_fieldsCustomProperties.Add("PasswordHash", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Random value concatenated with the password string before the password is hashed.");
			_fieldsCustomProperties.Add("PasswordSalt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Phone number associated with the person.");
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Surname suffix. For example, Sr. or Jr.");
			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"A courtesy title. For example, Mr. or Ms.");
			_fieldsCustomProperties.Add("Title", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ContactFieldIndex.ContactID].ForcedCurrentValueWrite(contactID);
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
			return DAOFactory.CreateContactDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ContactEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ContactRelations Relations
		{
			get	{ return new ContactRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employees")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(), (IEntityRelation)GetRelationsForField("VendorContacts")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactCreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCreditCards
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCreditCardCollection(), (IEntityRelation)GetRelationsForField("ContactCreditCards")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ContactCreditCardEntity, 0, null, null, null, "ContactCreditCards", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Individual' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIndividuals
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.IndividualCollection(), (IEntityRelation)GetRelationsForField("Individuals")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.IndividualEntity, 0, null, null, null, "Individuals", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(), (IEntityRelation)GetRelationsForField("StoreContacts")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCards
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ContactCreditCardEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "ContactCreditCard_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,	(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCards"), "CreditCards", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStores
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.StoreContactEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreCollection(), intermediateRelation,	(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.StoreEntity, 0, null, null, GetRelationsForField("Stores"), "Stores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The AdditionalContactInfo property of the Entity Contact<br/><br/>
		/// MS_Description: Additional contact information about the person stored in xml format. <br/>Additional contact information about the person stored in xml format. </summary>
		/// <remarks>Mapped on  table field: "Contact"."AdditionalContactInfo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AdditionalContactInfo
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.AdditionalContactInfo, true); }
			set	{ SetValue((int)ContactFieldIndex.AdditionalContactInfo, value, true); }
		}

		/// <summary> The ContactID property of the Entity Contact<br/><br/>
		/// MS_Description: Primary key for Contact records.<br/>Primary key for Contact records.</summary>
		/// <remarks>Mapped on  table field: "Contact"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)ContactFieldIndex.ContactID, true); }
			set	{ SetValue((int)ContactFieldIndex.ContactID, value, true); }
		}

		/// <summary> The EmailAddress property of the Entity Contact<br/><br/>
		/// MS_Description: E-mail address for the person.<br/>E-mail address for the person.</summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[DataType(DataType.EmailAddress)]
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailAddress, value, true); }
		}

		/// <summary> The EmailPromotion property of the Entity Contact<br/><br/>
		/// MS_Description: 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. <br/>0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. </summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailPromotion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.EmailPromotion EmailPromotion
		{
			get { return (AW.Data.EmailPromotion)GetValue((int)ContactFieldIndex.EmailPromotion, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailPromotion, value, true); }
		}

		/// <summary> The FirstName property of the Entity Contact<br/><br/>
		/// MS_Description: First name of the person.<br/>First name of the person.</summary>
		/// <remarks>Mapped on  table field: "Contact"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.FirstName, true); }
			set	{ SetValue((int)ContactFieldIndex.FirstName, value, true); }
		}

		/// <summary> The LastName property of the Entity Contact<br/><br/>
		/// MS_Description: Last name of the person.<br/>Last name of the person.</summary>
		/// <remarks>Mapped on  table field: "Contact"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.LastName, true); }
			set	{ SetValue((int)ContactFieldIndex.LastName, value, true); }
		}

		/// <summary> The MiddleName property of the Entity Contact<br/><br/>
		/// MS_Description: Middle name or middle initial of the person.<br/>Middle name or middle initial of the person.</summary>
		/// <remarks>Mapped on  table field: "Contact"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.MiddleName, true); }
			set	{ SetValue((int)ContactFieldIndex.MiddleName, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Contact<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "Contact"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The NameStyle property of the Entity Contact<br/><br/>
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/>Unique nonclustered index. Used to support replication samples.</summary>
		/// <remarks>Mapped on  table field: "Contact"."NameStyle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean NameStyle
		{
			get { return (System.Boolean)GetValue((int)ContactFieldIndex.NameStyle, true); }
			set	{ SetValue((int)ContactFieldIndex.NameStyle, value, true); }
		}

		/// <summary> The PasswordHash property of the Entity Contact<br/><br/>
		/// MS_Description: Password for the e-mail account.<br/>Password for the e-mail account.</summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordHash"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordHash, value, true); }
		}

		/// <summary> The PasswordSalt property of the Entity Contact<br/><br/>
		/// MS_Description: Random value concatenated with the password string before the password is hashed.<br/>Random value concatenated with the password string before the password is hashed.</summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordSalt"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordSalt, value, true); }
		}

		/// <summary> The Phone property of the Entity Contact<br/><br/>
		/// MS_Description: Phone number associated with the person.<br/>Phone number associated with the person.</summary>
		/// <remarks>Mapped on  table field: "Contact"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Phone, true); }
			set	{ SetValue((int)ContactFieldIndex.Phone, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Contact<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "Contact"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ContactFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ContactFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The Suffix property of the Entity Contact<br/><br/>
		/// MS_Description: Surname suffix. For example, Sr. or Jr.<br/>Surname suffix. For example, Sr. or Jr.</summary>
		/// <remarks>Mapped on  table field: "Contact"."Suffix"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Suffix
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Suffix, true); }
			set	{ SetValue((int)ContactFieldIndex.Suffix, value, true); }
		}

		/// <summary> The Title property of the Entity Contact<br/><br/>
		/// MS_Description: A courtesy title. For example, Mr. or Ms.<br/>A courtesy title. For example, Mr. or Ms.</summary>
		/// <remarks>Mapped on  table field: "Contact"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Title, true); }
			set	{ SetValue((int)ContactFieldIndex.Title, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployees()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection Employees
		{
			get	{ return GetMultiEmployees(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Employees. When set to true, Employees is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employees is accessed. You can always execute/ a forced fetch by calling GetMultiEmployees(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployees
		{
			get	{ return _alwaysFetchEmployees; }
			set	{ _alwaysFetchEmployees = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employees already has been fetched. Setting this property to false when Employees has been fetched
		/// will clear the Employees collection well. Setting this property to true while Employees hasn't been fetched disables lazy loading for Employees</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployees
		{
			get { return _alreadyFetchedEmployees;}
			set 
			{
				if(_alreadyFetchedEmployees && !value && (_employees != null))
				{
					_employees.Clear();
				}
				_alreadyFetchedEmployees = value;
			}
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
		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCreditCards()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection ContactCreditCards
		{
			get	{ return GetMultiContactCreditCards(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCreditCards. When set to true, ContactCreditCards is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCreditCards is accessed. You can always execute/ a forced fetch by calling GetMultiContactCreditCards(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCreditCards
		{
			get	{ return _alwaysFetchContactCreditCards; }
			set	{ _alwaysFetchContactCreditCards = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCreditCards already has been fetched. Setting this property to false when ContactCreditCards has been fetched
		/// will clear the ContactCreditCards collection well. Setting this property to true while ContactCreditCards hasn't been fetched disables lazy loading for ContactCreditCards</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCreditCards
		{
			get { return _alreadyFetchedContactCreditCards;}
			set 
			{
				if(_alreadyFetchedContactCreditCards && !value && (_contactCreditCards != null))
				{
					_contactCreditCards.Clear();
				}
				_alreadyFetchedContactCreditCards = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIndividuals()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.IndividualCollection Individuals
		{
			get	{ return GetMultiIndividuals(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Individuals. When set to true, Individuals is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individuals is accessed. You can always execute/ a forced fetch by calling GetMultiIndividuals(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividuals
		{
			get	{ return _alwaysFetchIndividuals; }
			set	{ _alwaysFetchIndividuals = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Individuals already has been fetched. Setting this property to false when Individuals has been fetched
		/// will clear the Individuals collection well. Setting this property to true while Individuals hasn't been fetched disables lazy loading for Individuals</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIndividuals
		{
			get { return _alreadyFetchedIndividuals;}
			set 
			{
				if(_alreadyFetchedIndividuals && !value && (_individuals != null))
				{
					_individuals.Clear();
				}
				_alreadyFetchedIndividuals = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders
		{
			get	{ return GetMultiSalesOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders. When set to true, SalesOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaders
		{
			get	{ return _alwaysFetchSalesOrderHeaders; }
			set	{ _alwaysFetchSalesOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaders already has been fetched. Setting this property to false when SalesOrderHeaders has been fetched
		/// will clear the SalesOrderHeaders collection well. Setting this property to true while SalesOrderHeaders hasn't been fetched disables lazy loading for SalesOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaders
		{
			get { return _alreadyFetchedSalesOrderHeaders;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaders && !value && (_salesOrderHeaders != null))
				{
					_salesOrderHeaders.Clear();
				}
				_alreadyFetchedSalesOrderHeaders = value;
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

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCards()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCards
		{
			get { return GetMultiCreditCards(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCards. When set to true, CreditCards is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCards is accessed. You can always execute a forced fetch by calling GetMultiCreditCards(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCards
		{
			get	{ return _alwaysFetchCreditCards; }
			set	{ _alwaysFetchCreditCards = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CreditCards already has been fetched. Setting this property to false when CreditCards has been fetched
		/// will clear the CreditCards collection well. Setting this property to true while CreditCards hasn't been fetched disables lazy loading for CreditCards</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCreditCards
		{
			get { return _alreadyFetchedCreditCards;}
			set 
			{
				if(_alreadyFetchedCreditCards && !value && (_creditCards != null))
				{
					_creditCards.Clear();
				}
				_alreadyFetchedCreditCards = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStores()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreCollection Stores
		{
			get { return GetMultiStores(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Stores. When set to true, Stores is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Stores is accessed. You can always execute a forced fetch by calling GetMultiStores(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStores
		{
			get	{ return _alwaysFetchStores; }
			set	{ _alwaysFetchStores = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Stores already has been fetched. Setting this property to false when Stores has been fetched
		/// will clear the Stores collection well. Setting this property to true while Stores hasn't been fetched disables lazy loading for Stores</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStores
		{
			get { return _alreadyFetchedStores;}
			set 
			{
				if(_alreadyFetchedStores && !value && (_stores != null))
				{
					_stores.Clear();
				}
				_alreadyFetchedStores = value;
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
			get { return (int)AW.Data.EntityType.ContactEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        //public static ContactCollection GetContactCollection()
        //{
        //    ISortExpression Sort = new SortExpression();
        //    Sort.Add(ContactFields.LastName | SortOperator.Ascending);
        //    Sort.Add(ContactFields.FirstName | SortOperator.Ascending);
        //    ContactCollection Contacts = new ContactCollection();
        //    Contacts.GetMulti(null, 1000, Sort);
        //    return Contacts;
        //}
        public string DisplayName
        {
            get { return this.LastName + ", " + this.FirstName; }
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
