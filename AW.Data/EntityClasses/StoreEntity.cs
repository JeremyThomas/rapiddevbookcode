///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
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

	/// <summary>Entity class which represents the entity 'Store'. <br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public partial class StoreEntity : CustomerEntity
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContacts;
		private bool	_alwaysFetchStoreContacts, _alreadyFetchedStoreContacts;
		private AW.Data.CollectionClasses.ContactCollection _contacts;
		private bool	_alwaysFetchContacts, _alreadyFetchedContacts;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson, _salesPersonReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static new partial class MemberNames
		{
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name CustomerAddresses</summary>
			public static readonly string CustomerAddresses = "CustomerAddresses";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name StoreContacts</summary>
			public static readonly string StoreContacts = "StoreContacts";
			/// <summary>Member name AddressCollectionViaCustomerAddress</summary>
			public static readonly string AddressCollectionViaCustomerAddress = "AddressCollectionViaCustomerAddress";
			/// <summary>Member name Contacts</summary>
			public static readonly string Contacts = "Contacts";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StoreEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StoreEntity() 
		{
			InitClassEmpty(null);
			SetName("StoreEntity");
		}
		
		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		public StoreEntity(System.Int32 customerID):base(customerID)
		{
			InitClassFetch(customerID, null, null);
			SetName("StoreEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StoreEntity(System.Int32 customerID, IPrefetchPath prefetchPathToUse):base(customerID, prefetchPathToUse)
		{
			InitClassFetch(customerID, null, prefetchPathToUse);
			SetName("StoreEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		public StoreEntity(System.Int32 customerID, IValidator validator):base(customerID, validator)
		{
			InitClassFetch(customerID, validator, null);
			SetName("StoreEntity");
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StoreEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_storeContacts = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContacts", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContacts = info.GetBoolean("_alwaysFetchStoreContacts");
			_alreadyFetchedStoreContacts = info.GetBoolean("_alreadyFetchedStoreContacts");
			_contacts = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contacts", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContacts = info.GetBoolean("_alwaysFetchContacts");
			_alreadyFetchedContacts = info.GetBoolean("_alreadyFetchedContacts");
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesPersonReturnsNewIfNotFound = info.GetBoolean("_salesPersonReturnsNewIfNotFound");
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((StoreFieldIndex)fieldIndex)
			{
				case StoreFieldIndex.SalesPersonID:
					DesetupSyncSalesPerson(true, false);
					_alreadyFetchedSalesPerson = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedStoreContacts = (_storeContacts.Count > 0);
			_alreadyFetchedContacts = (_contacts.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
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
		internal static new RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "SalesPerson":
					toReturn.Add(Relations.SalesPersonEntityUsingSalesPersonID);
					break;
				case "StoreContacts":
					toReturn.Add(Relations.StoreContactEntityUsingCustomerID);
					break;
				case "Contacts":
					toReturn.Add(Relations.StoreContactEntityUsingCustomerID, "StoreEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.ContactEntityUsingContactID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				default:
					toReturn = CustomerEntity.GetRelationsForField(fieldName);
					break;				
			}
			return toReturn;
		}

		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter()
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("StoreEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("StoreEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_storeContacts", (!this.MarkedForDeletion?_storeContacts:null));
			info.AddValue("_alwaysFetchStoreContacts", _alwaysFetchStoreContacts);
			info.AddValue("_alreadyFetchedStoreContacts", _alreadyFetchedStoreContacts);
			info.AddValue("_contacts", (!this.MarkedForDeletion?_contacts:null));
			info.AddValue("_alwaysFetchContacts", _alwaysFetchContacts);
			info.AddValue("_alreadyFetchedContacts", _alreadyFetchedContacts);
			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_salesPersonReturnsNewIfNotFound", _salesPersonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);

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
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					this.SalesPerson = (SalesPersonEntity)entity;
					break;
				case "StoreContacts":
					_alreadyFetchedStoreContacts = true;
					if(entity!=null)
					{
						this.StoreContacts.Add((StoreContactEntity)entity);
					}
					break;
				case "Contacts":
					_alreadyFetchedContacts = true;
					if(entity!=null)
					{
						this.Contacts.Add((ContactEntity)entity);
					}
					break;
				default:
					base.SetRelatedEntityProperty(propertyName, entity);
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
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "StoreContacts":
					_storeContacts.Add((StoreContactEntity)relatedEntity);
					break;
				default:
					base.SetRelatedEntity(relatedEntity, fieldName);
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
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
					break;
				case "StoreContacts":
					this.PerformRelatedEntityRemoval(_storeContacts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					base.UnsetRelatedEntity(relatedEntity, fieldName, signalRelatedEntityManyToOne);
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			toReturn.AddRange(base.GetDependingRelatedEntities());
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			toReturn.AddRange(base.GetDependentRelatedEntities());
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_storeContacts);
			toReturn.AddRange(base.GetMemberEntityCollections());
			return toReturn;
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new StoreEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 customerID, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, customerID, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new StoreEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 customerID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.StoreEntity);
			fields.ForcedValueWrite((int)StoreFieldIndex.CustomerID, customerID);
			return (StoreEntity)new StoreDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}


		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the AW.Data.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("StoreEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new StoreRelations().GetAllRelations();
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
				_storeContacts.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContacts(bool forceFetch)
		{
			return GetMultiContacts(forceFetch, _contacts.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContacts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContacts || forceFetch || _alwaysFetchContacts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contacts);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(StoreFields.CustomerID, ComparisonOperator.Equal, this.CustomerID, "StoreEntity__"));
				_contacts.SuppressClearInGetMulti=!forceFetch;
				_contacts.EntityFactoryToUse = entityFactoryToUse;
				_contacts.GetMulti(filter, GetRelationsForField("Contacts"));
				_contacts.SuppressClearInGetMulti=false;
				_alreadyFetchedContacts = true;
			}
			return _contacts;
		}

		/// <summary> Sets the collection parameters for the collection for 'Contacts'. These settings will be taken into account
		/// when the property Contacts is requested or GetMultiContacts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContacts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contacts.SortClauses=sortClauses;
			_contacts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesPersonEntityUsingSalesPersonID);
				SalesPersonEntity newEntity = (SalesPersonEntity)GeneralEntityFactory.Create(AW.Data.EntityType.SalesPersonEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = SalesPersonEntity.FetchPolymorphic(this.Transaction, this.SalesPersonID.GetValueOrDefault(), this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (SalesPersonEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesPersonReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesPerson = newEntity;
				_alreadyFetchedSalesPerson = fetchResult;
			}
			return _salesPerson;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = base.GetRelatedData();
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("StoreContacts", _storeContacts);
			toReturn.Add("Contacts", _contacts);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The validator object for this StoreEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 customerID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers();	

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_storeContacts = new AW.Data.CollectionClasses.StoreContactCollection();
			_storeContacts.SetContainingEntityInfo(this, "Store");
			_contacts = new AW.Data.CollectionClasses.ContactCollection();
			_salesPersonReturnsNewIfNotFound = true;

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

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
			fieldHashtable.Add("MS_Description", @"Demographic informationg about the store such as the number of employees, annual sales and store type.");
			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the store.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("SalesPersonID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesPerson</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AW.Data.RelationClasses.StaticStoreRelations.SalesPersonEntityUsingSalesPersonIDStatic, true, signalRelatedEntity, "Stores", resetFKFields, new int[] { (int)StoreFieldIndex.SalesPersonID } );		
			_salesPerson = null;
		}
		
		/// <summary> setups the sync logic for member _salesPerson</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntityCore relatedEntity)
		{
			if(_salesPerson!=relatedEntity)
			{		
				DesetupSyncSalesPerson(true, true);
				_salesPerson = (SalesPersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AW.Data.RelationClasses.StaticStoreRelations.SalesPersonEntityUsingSalesPersonIDStatic, true, ref _alreadyFetchedSalesPerson, new string[] {  } );
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
		public new static StoreRelations Relations
		{
			get	{ return new StoreRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public new static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(), (IEntityRelation)GetRelationsForField("StoreContacts")[0], (int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContacts
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.StoreContactEntityUsingCustomerID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,	(int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("Contacts"), "Contacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPerson
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), (IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.StoreEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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
		public new static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
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

		/// <summary> The Demographics property of the Entity Store<br/><br/>
		/// MS_Description: Demographic informationg about the store such as the number of employees, annual sales and store type.<br/>Demographic informationg about the store such as the number of employees, annual sales and store type.</summary>
		/// <remarks>Mapped on  table field: "Store"."Demographics"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Demographics, true); }
			set	{ SetValue((int)StoreFieldIndex.Demographics, value, true); }
		}

		/// <summary> The Name property of the Entity Store<br/><br/>
		/// MS_Description: Name of the store.<br/>Name of the store.</summary>
		/// <remarks>Mapped on  table field: "Store"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Name, true); }
			set	{ SetValue((int)StoreFieldIndex.Name, value, true); }
		}

		/// <summary> The SalesPersonID property of the Entity Store<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "Store"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonID
		{
			get { return (Nullable<System.Int32>)GetValue((int)StoreFieldIndex.SalesPersonID, false); }
			set	{ SetValue((int)StoreFieldIndex.SalesPersonID, value, true); }
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

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContacts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection Contacts
		{
			get { return GetMultiContacts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Contacts. When set to true, Contacts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contacts is accessed. You can always execute a forced fetch by calling GetMultiContacts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContacts
		{
			get	{ return _alwaysFetchContacts; }
			set	{ _alwaysFetchContacts = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Contacts already has been fetched. Setting this property to false when Contacts has been fetched
		/// will clear the Contacts collection well. Setting this property to true while Contacts hasn't been fetched disables lazy loading for Contacts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContacts
		{
			get { return _alreadyFetchedContacts;}
			set 
			{
				if(_alreadyFetchedContacts && !value && (_contacts != null))
				{
					_contacts.Clear();
				}
				_alreadyFetchedContacts = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'SalesPersonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get	{ return GetSingleSalesPerson(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Stores", "SalesPerson", _salesPerson, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute a forced fetch by calling GetSingleSalesPerson(true).</summary>
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


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return true;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.TargetPerEntity;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
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
