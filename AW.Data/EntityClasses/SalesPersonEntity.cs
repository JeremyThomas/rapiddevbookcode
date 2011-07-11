///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
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

	/// <summary>Entity class which represents the entity 'SalesPerson'. <br/><br/>
	/// 
	/// MS_Description: Sales representative current information.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesPersonEntity : EmployeeEntity
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection	_salesPersonQuotaHistories;
		private bool	_alwaysFetchSalesPersonQuotaHistories, _alreadyFetchedSalesPersonQuotaHistories;
		private AW.Data.CollectionClasses.SalesTerritoryHistoryCollection	_salesTerritoryHistories;
		private bool	_alwaysFetchSalesTerritoryHistories, _alreadyFetchedSalesTerritoryHistories;
		private AW.Data.CollectionClasses.StoreCollection	_stores;
		private bool	_alwaysFetchStores, _alreadyFetchedStores;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory, _salesTerritoryReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static new partial class MemberNames
		{
			/// <summary>Member name Manager</summary>
			public static readonly string Manager = "Manager";
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name Manages</summary>
			public static readonly string Manages = "Manages";
			/// <summary>Member name EmployeeAddresses</summary>
			public static readonly string EmployeeAddresses = "EmployeeAddresses";
			/// <summary>Member name EmployeeDepartmentHistories</summary>
			public static readonly string EmployeeDepartmentHistories = "EmployeeDepartmentHistories";
			/// <summary>Member name EmployeePayHistories</summary>
			public static readonly string EmployeePayHistories = "EmployeePayHistories";
			/// <summary>Member name JobCandidates</summary>
			public static readonly string JobCandidates = "JobCandidates";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPersonQuotaHistories</summary>
			public static readonly string SalesPersonQuotaHistories = "SalesPersonQuotaHistories";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesPersonEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesPersonEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		public SalesPersonEntity(System.Int32 employeeID):base(employeeID)
		{
			InitClassFetch(employeeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesPersonEntity(System.Int32 employeeID, IPrefetchPath prefetchPathToUse):base(employeeID, prefetchPathToUse)
		{
			InitClassFetch(employeeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(System.Int32 employeeID, IValidator validator):base(employeeID, validator)
		{
			InitClassFetch(employeeID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesPersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");

			_salesPersonQuotaHistories = (AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection)info.GetValue("_salesPersonQuotaHistories", typeof(AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection));
			_alwaysFetchSalesPersonQuotaHistories = info.GetBoolean("_alwaysFetchSalesPersonQuotaHistories");
			_alreadyFetchedSalesPersonQuotaHistories = info.GetBoolean("_alreadyFetchedSalesPersonQuotaHistories");

			_salesTerritoryHistories = (AW.Data.CollectionClasses.SalesTerritoryHistoryCollection)info.GetValue("_salesTerritoryHistories", typeof(AW.Data.CollectionClasses.SalesTerritoryHistoryCollection));
			_alwaysFetchSalesTerritoryHistories = info.GetBoolean("_alwaysFetchSalesTerritoryHistories");
			_alreadyFetchedSalesTerritoryHistories = info.GetBoolean("_alreadyFetchedSalesTerritoryHistories");

			_stores = (AW.Data.CollectionClasses.StoreCollection)info.GetValue("_stores", typeof(AW.Data.CollectionClasses.StoreCollection));
			_alwaysFetchStores = info.GetBoolean("_alwaysFetchStores");
			_alreadyFetchedStores = info.GetBoolean("_alreadyFetchedStores");
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesTerritoryReturnsNewIfNotFound = info.GetBoolean("_salesTerritoryReturnsNewIfNotFound");
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesPersonFieldIndex)fieldIndex)
			{
				case SalesPersonFieldIndex.TerritoryID:
					DesetupSyncSalesTerritory(true, false);
					_alreadyFetchedSalesTerritory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedSalesPersonQuotaHistories = (_salesPersonQuotaHistories.Count > 0);
			_alreadyFetchedSalesTerritoryHistories = (_salesTerritoryHistories.Count > 0);
			_alreadyFetchedStores = (_stores.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
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
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonID);
					break;
				case "SalesPersonQuotaHistories":
					toReturn.Add(Relations.SalesPersonQuotaHistoryEntityUsingSalesPersonID);
					break;
				case "SalesTerritoryHistories":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingSalesPersonID);
					break;
				case "Stores":
					toReturn.Add(Relations.StoreEntityUsingSalesPersonID);
					break;
				default:
					toReturn = EmployeeEntity.GetRelationsForField(fieldName);
					break;				
			}
			return toReturn;
		}

		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter()
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("SalesPersonEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("SalesPersonEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_salesPersonQuotaHistories", (!this.MarkedForDeletion?_salesPersonQuotaHistories:null));
			info.AddValue("_alwaysFetchSalesPersonQuotaHistories", _alwaysFetchSalesPersonQuotaHistories);
			info.AddValue("_alreadyFetchedSalesPersonQuotaHistories", _alreadyFetchedSalesPersonQuotaHistories);
			info.AddValue("_salesTerritoryHistories", (!this.MarkedForDeletion?_salesTerritoryHistories:null));
			info.AddValue("_alwaysFetchSalesTerritoryHistories", _alwaysFetchSalesTerritoryHistories);
			info.AddValue("_alreadyFetchedSalesTerritoryHistories", _alreadyFetchedSalesTerritoryHistories);
			info.AddValue("_stores", (!this.MarkedForDeletion?_stores:null));
			info.AddValue("_alwaysFetchStores", _alwaysFetchStores);
			info.AddValue("_alreadyFetchedStores", _alreadyFetchedStores);
			info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
			info.AddValue("_salesTerritoryReturnsNewIfNotFound", _salesTerritoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "SalesTerritory":
					_alreadyFetchedSalesTerritory = true;
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesPersonQuotaHistories":
					_alreadyFetchedSalesPersonQuotaHistories = true;
					if(entity!=null)
					{
						this.SalesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)entity);
					}
					break;
				case "SalesTerritoryHistories":
					_alreadyFetchedSalesTerritoryHistories = true;
					if(entity!=null)
					{
						this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)entity);
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
					base.SetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPersonQuotaHistories":
					_salesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)relatedEntity);
					break;
				case "SalesTerritoryHistories":
					_salesTerritoryHistories.Add((SalesTerritoryHistoryEntity)relatedEntity);
					break;
				case "Stores":
					_stores.Add((StoreEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPersonQuotaHistories":
					this.PerformRelatedEntityRemoval(_salesPersonQuotaHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistories":
					this.PerformRelatedEntityRemoval(_salesTerritoryHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Stores":
					this.PerformRelatedEntityRemoval(_stores, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			toReturn.AddRange(base.GetDependentRelatedEntities());
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_salesPersonQuotaHistories);
			toReturn.Add(_salesTerritoryHistories);
			toReturn.Add(_stores);
			toReturn.AddRange(base.GetMemberEntityCollections());
			return toReturn;
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new SalesPersonEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 employeeID, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, employeeID, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new SalesPersonEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 employeeID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesPersonEntity);
			fields[(int)SalesPersonFieldIndex.EmployeeID].ForcedCurrentValueWrite(employeeID);
			return (SalesPersonEntity)new SalesPersonDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}


		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the AW.Data.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("SalesPersonEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesPersonRelations().GetAllRelations();
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
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, null, null, null, null, null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonQuotaHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistories(bool forceFetch)
		{
			return GetMultiSalesPersonQuotaHistories(forceFetch, _salesPersonQuotaHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonQuotaHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesPersonQuotaHistories(forceFetch, _salesPersonQuotaHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesPersonQuotaHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesPersonQuotaHistories || forceFetch || _alwaysFetchSalesPersonQuotaHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesPersonQuotaHistories);
				_salesPersonQuotaHistories.SuppressClearInGetMulti=!forceFetch;
				_salesPersonQuotaHistories.EntityFactoryToUse = entityFactoryToUse;
				_salesPersonQuotaHistories.GetMultiManyToOne(this, filter);
				_salesPersonQuotaHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonQuotaHistories = true;
			}
			return _salesPersonQuotaHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesPersonQuotaHistories'. These settings will be taken into account
		/// when the property SalesPersonQuotaHistories is requested or GetMultiSalesPersonQuotaHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPersonQuotaHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPersonQuotaHistories.SortClauses=sortClauses;
			_salesPersonQuotaHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistories(bool forceFetch)
		{
			return GetMultiSalesTerritoryHistories(forceFetch, _salesTerritoryHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesTerritoryHistories(forceFetch, _salesTerritoryHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesTerritoryHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistories || forceFetch || _alwaysFetchSalesTerritoryHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesTerritoryHistories);
				_salesTerritoryHistories.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryHistories.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritoryHistories.GetMultiManyToOne(this, null, filter);
				_salesTerritoryHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistories = true;
			}
			return _salesTerritoryHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTerritoryHistories'. These settings will be taken into account
		/// when the property SalesTerritoryHistories is requested or GetMultiSalesTerritoryHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryHistories.SortClauses=sortClauses;
			_salesTerritoryHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch)
		{
			return GetMultiStores(forceFetch, _stores.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStores(forceFetch, _stores.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStores(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStores || forceFetch || _alwaysFetchStores) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_stores);
				_stores.SuppressClearInGetMulti=!forceFetch;
				_stores.EntityFactoryToUse = entityFactoryToUse;
				_stores.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public SalesTerritoryEntity GetSingleSalesTerritory()
		{
			return GetSingleSalesTerritory(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public virtual SalesTerritoryEntity GetSingleSalesTerritory(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesTerritoryEntityUsingTerritoryID);
				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.TerritoryID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (SalesTerritoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesTerritoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesTerritory = newEntity;
				_alreadyFetchedSalesTerritory = fetchResult;
			}
			return _salesTerritory;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderHeaders.ActiveContext = this.ActiveContext;
			_salesPersonQuotaHistories.ActiveContext = this.ActiveContext;
			_salesTerritoryHistories.ActiveContext = this.ActiveContext;
			_stores.ActiveContext = this.ActiveContext;
			if(_salesTerritory!=null)
			{
				_salesTerritory.ActiveContext = this.ActiveContext;
			}
			base.AddInternalsToContext();
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = base.GetRelatedData();
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPersonQuotaHistories", _salesPersonQuotaHistories);
			toReturn.Add("SalesTerritoryHistories", _salesTerritoryHistories);
			toReturn.Add("Stores", _stores);
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
		/// <param name="employeeID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The validator object for this SalesPersonEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 employeeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{

			InitClassMembers();	

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "SalesPerson");

			_salesPersonQuotaHistories = new AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection();
			_salesPersonQuotaHistories.SetContainingEntityInfo(this, "SalesPerson");

			_salesTerritoryHistories = new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection();
			_salesTerritoryHistories.SetContainingEntityInfo(this, "SalesPerson");

			_stores = new AW.Data.CollectionClasses.StoreCollection();
			_stores.SetContainingEntityInfo(this, "SalesPerson");
			_salesTerritoryReturnsNewIfNotFound = true;

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			_customProperties.Add("MS_Description", @"Sales representative current information.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Bonus due if quota is met.");
			_fieldsCustomProperties.Add("Bonus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Commision percent received per sale.");
			_fieldsCustomProperties.Add("CommissionPct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales total of previous year.");
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Projected yearly sales.");
			_fieldsCustomProperties.Add("SalesQuota", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales total year to date.");
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesPersonEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, signalRelatedEntity, "SalesPeople", resetFKFields, new int[] { (int)SalesPersonFieldIndex.TerritoryID } );		
			_salesTerritory = null;
		}
		
		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntity relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{		
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesPersonEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, ref _alreadyFetchedSalesTerritory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			return DAOFactory.CreateSalesPersonDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesPersonEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public new static SalesPersonRelations Relations
		{
			get	{ return new SalesPersonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public new static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.SalesPersonEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPersonQuotaHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPersonQuotaHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection(), (IEntityRelation)GetRelationsForField("SalesPersonQuotaHistories")[0], (int)AW.Data.EntityType.SalesPersonEntity, (int)AW.Data.EntityType.SalesPersonQuotaHistoryEntity, 0, null, null, null, "SalesPersonQuotaHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection(), (IEntityRelation)GetRelationsForField("SalesTerritoryHistories")[0], (int)AW.Data.EntityType.SalesPersonEntity, (int)AW.Data.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, "SalesTerritoryHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStores
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreCollection(), (IEntityRelation)GetRelationsForField("Stores")[0], (int)AW.Data.EntityType.SalesPersonEntity, (int)AW.Data.EntityType.StoreEntity, 0, null, null, null, "Stores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), (IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AW.Data.EntityType.SalesPersonEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "SalesPersonEntity";}
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

		/// <summary> The Bonus property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Bonus due if quota is met.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."Bonus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Bonus
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.Bonus, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Bonus, value, true); }
		}

		/// <summary> The CommissionPct property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Commision percent received per sale.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."CommissionPct"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CommissionPct
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.CommissionPct, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.CommissionPct, value, true); }
		}

		/// <summary> The SalesLastYear property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Sales total of previous year.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesLastYear, value, true); }
		}

		/// <summary> The SalesQuota property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Projected yearly sales.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesQuota"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SalesQuota
		{
			get { return (Nullable<System.Decimal>)GetValue((int)SalesPersonFieldIndex.SalesQuota, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesQuota, value, true); }
		}

		/// <summary> The SalesYtd property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Sales total year to date.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesYtd, value, true); }
		}

		/// <summary> The TerritoryID property of the Entity SalesPerson<br/><br/>
		/// MS_Description: Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesPersonFieldIndex.TerritoryID, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.TerritoryID, value, true); }
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
		/// <summary> Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPersonQuotaHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesPersonQuotaHistoryCollection SalesPersonQuotaHistories
		{
			get	{ return GetMultiSalesPersonQuotaHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPersonQuotaHistories. When set to true, SalesPersonQuotaHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPersonQuotaHistories is accessed. You can always execute/ a forced fetch by calling GetMultiSalesPersonQuotaHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPersonQuotaHistories
		{
			get	{ return _alwaysFetchSalesPersonQuotaHistories; }
			set	{ _alwaysFetchSalesPersonQuotaHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPersonQuotaHistories already has been fetched. Setting this property to false when SalesPersonQuotaHistories has been fetched
		/// will clear the SalesPersonQuotaHistories collection well. Setting this property to true while SalesPersonQuotaHistories hasn't been fetched disables lazy loading for SalesPersonQuotaHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPersonQuotaHistories
		{
			get { return _alreadyFetchedSalesPersonQuotaHistories;}
			set 
			{
				if(_alreadyFetchedSalesPersonQuotaHistories && !value && (_salesPersonQuotaHistories != null))
				{
					_salesPersonQuotaHistories.Clear();
				}
				_alreadyFetchedSalesPersonQuotaHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryHistoryCollection SalesTerritoryHistories
		{
			get	{ return GetMultiSalesTerritoryHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryHistories. When set to true, SalesTerritoryHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryHistories is accessed. You can always execute/ a forced fetch by calling GetMultiSalesTerritoryHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryHistories
		{
			get	{ return _alwaysFetchSalesTerritoryHistories; }
			set	{ _alwaysFetchSalesTerritoryHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritoryHistories already has been fetched. Setting this property to false when SalesTerritoryHistories has been fetched
		/// will clear the SalesTerritoryHistories collection well. Setting this property to true while SalesTerritoryHistories hasn't been fetched disables lazy loading for SalesTerritoryHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritoryHistories
		{
			get { return _alreadyFetchedSalesTerritoryHistories;}
			set 
			{
				if(_alreadyFetchedSalesTerritoryHistories && !value && (_salesTerritoryHistories != null))
				{
					_salesTerritoryHistories.Clear();
				}
				_alreadyFetchedSalesTerritoryHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStores()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreCollection Stores
		{
			get	{ return GetMultiStores(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Stores. When set to true, Stores is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Stores is accessed. You can always execute/ a forced fetch by calling GetMultiStores(true).</summary>
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

		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return GetSingleSalesTerritory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesPeople", "SalesTerritory", _salesTerritory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute a forced fetch by calling GetSingleSalesTerritory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory
		{
			get	{ return _alwaysFetchSalesTerritory; }
			set	{ _alwaysFetchSalesTerritory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritory already has been fetched. Setting this property to false when SalesTerritory has been fetched
		/// will set SalesTerritory to null as well. Setting this property to true while SalesTerritory hasn't been fetched disables lazy loading for SalesTerritory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritory
		{
			get { return _alreadyFetchedSalesTerritory;}
			set 
			{
				if(_alreadyFetchedSalesTerritory && !value)
				{
					this.SalesTerritory = null;
				}
				_alreadyFetchedSalesTerritory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesTerritory is not found
		/// in the database. When set to true, SalesTerritory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesTerritoryReturnsNewIfNotFound
		{
			get	{ return _salesTerritoryReturnsNewIfNotFound; }
			set { _salesTerritoryReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.SalesPersonEntity; }
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
