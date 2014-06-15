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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesTerritory'. <br/><br/>
	/// 
	/// MS_Description: Sales territory lookup table.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesTerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.StateProvinceCollection	_stateProvinces;
		private bool	_alwaysFetchStateProvinces, _alreadyFetchedStateProvinces;
		private AW.Data.CollectionClasses.CustomerCollection	_customers;
		private bool	_alwaysFetchCustomers, _alreadyFetchedCustomers;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.SalesPersonCollection	_salesPeople;
		private bool	_alwaysFetchSalesPeople, _alreadyFetchedSalesPeople;
		private AW.Data.CollectionClasses.SalesTerritoryHistoryCollection	_salesTerritoryHistories;
		private bool	_alwaysFetchSalesTerritoryHistories, _alreadyFetchedSalesTerritoryHistories;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPeople</summary>
			public static readonly string SalesPeople = "SalesPeople";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesTerritoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesTerritoryEntity() :base("SalesTerritoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		public SalesTerritoryEntity(System.Int32 territoryID):base("SalesTerritoryEntity")
		{
			InitClassFetch(territoryID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesTerritoryEntity(System.Int32 territoryID, IPrefetchPath prefetchPathToUse):base("SalesTerritoryEntity")
		{
			InitClassFetch(territoryID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntity(System.Int32 territoryID, IValidator validator):base("SalesTerritoryEntity")
		{
			InitClassFetch(territoryID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_stateProvinces = (AW.Data.CollectionClasses.StateProvinceCollection)info.GetValue("_stateProvinces", typeof(AW.Data.CollectionClasses.StateProvinceCollection));
			_alwaysFetchStateProvinces = info.GetBoolean("_alwaysFetchStateProvinces");
			_alreadyFetchedStateProvinces = info.GetBoolean("_alreadyFetchedStateProvinces");

			_customers = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customers", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomers = info.GetBoolean("_alwaysFetchCustomers");
			_alreadyFetchedCustomers = info.GetBoolean("_alreadyFetchedCustomers");

			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");

			_salesPeople = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPeople", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPeople = info.GetBoolean("_alwaysFetchSalesPeople");
			_alreadyFetchedSalesPeople = info.GetBoolean("_alreadyFetchedSalesPeople");

			_salesTerritoryHistories = (AW.Data.CollectionClasses.SalesTerritoryHistoryCollection)info.GetValue("_salesTerritoryHistories", typeof(AW.Data.CollectionClasses.SalesTerritoryHistoryCollection));
			_alwaysFetchSalesTerritoryHistories = info.GetBoolean("_alwaysFetchSalesTerritoryHistories");
			_alreadyFetchedSalesTerritoryHistories = info.GetBoolean("_alreadyFetchedSalesTerritoryHistories");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedStateProvinces = (_stateProvinces.Count > 0);
			_alreadyFetchedCustomers = (_customers.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedSalesPeople = (_salesPeople.Count > 0);
			_alreadyFetchedSalesTerritoryHistories = (_salesTerritoryHistories.Count > 0);
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
				case "StateProvinces":
					toReturn.Add(Relations.StateProvinceEntityUsingTerritoryID);
					break;
				case "Customers":
					toReturn.Add(Relations.CustomerEntityUsingTerritoryID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingTerritoryID);
					break;
				case "SalesPeople":
					toReturn.Add(Relations.SalesPersonEntityUsingTerritoryID);
					break;
				case "SalesTerritoryHistories":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingTerritoryID);
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
			info.AddValue("_stateProvinces", (!this.MarkedForDeletion?_stateProvinces:null));
			info.AddValue("_alwaysFetchStateProvinces", _alwaysFetchStateProvinces);
			info.AddValue("_alreadyFetchedStateProvinces", _alreadyFetchedStateProvinces);
			info.AddValue("_customers", (!this.MarkedForDeletion?_customers:null));
			info.AddValue("_alwaysFetchCustomers", _alwaysFetchCustomers);
			info.AddValue("_alreadyFetchedCustomers", _alreadyFetchedCustomers);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_salesPeople", (!this.MarkedForDeletion?_salesPeople:null));
			info.AddValue("_alwaysFetchSalesPeople", _alwaysFetchSalesPeople);
			info.AddValue("_alreadyFetchedSalesPeople", _alreadyFetchedSalesPeople);
			info.AddValue("_salesTerritoryHistories", (!this.MarkedForDeletion?_salesTerritoryHistories:null));
			info.AddValue("_alwaysFetchSalesTerritoryHistories", _alwaysFetchSalesTerritoryHistories);
			info.AddValue("_alreadyFetchedSalesTerritoryHistories", _alreadyFetchedSalesTerritoryHistories);

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
				case "StateProvinces":
					_alreadyFetchedStateProvinces = true;
					if(entity!=null)
					{
						this.StateProvinces.Add((StateProvinceEntity)entity);
					}
					break;
				case "Customers":
					_alreadyFetchedCustomers = true;
					if(entity!=null)
					{
						this.Customers.Add((CustomerEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesPeople":
					_alreadyFetchedSalesPeople = true;
					if(entity!=null)
					{
						this.SalesPeople.Add((SalesPersonEntity)entity);
					}
					break;
				case "SalesTerritoryHistories":
					_alreadyFetchedSalesTerritoryHistories = true;
					if(entity!=null)
					{
						this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)entity);
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
				case "StateProvinces":
					_stateProvinces.Add((StateProvinceEntity)relatedEntity);
					break;
				case "Customers":
					_customers.Add((CustomerEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPeople":
					_salesPeople.Add((SalesPersonEntity)relatedEntity);
					break;
				case "SalesTerritoryHistories":
					_salesTerritoryHistories.Add((SalesTerritoryHistoryEntity)relatedEntity);
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
				case "StateProvinces":
					this.PerformRelatedEntityRemoval(_stateProvinces, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Customers":
					this.PerformRelatedEntityRemoval(_customers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPeople":
					this.PerformRelatedEntityRemoval(_salesPeople, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistories":
					this.PerformRelatedEntityRemoval(_salesTerritoryHistories, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_stateProvinces);
			toReturn.Add(_customers);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_salesPeople);
			toReturn.Add(_salesTerritoryHistories);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID)
		{
			return FetchUsingPK(territoryID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(territoryID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(territoryID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(territoryID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.TerritoryID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesTerritoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStateProvinces(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStateProvinces || forceFetch || _alwaysFetchStateProvinces) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_stateProvinces);
				_stateProvinces.SuppressClearInGetMulti=!forceFetch;
				_stateProvinces.EntityFactoryToUse = entityFactoryToUse;
				_stateProvinces.GetMultiManyToOne(null, this, filter);
				_stateProvinces.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvinces = true;
			}
			return _stateProvinces;
		}

		/// <summary> Sets the collection parameters for the collection for 'StateProvinces'. These settings will be taken into account
		/// when the property StateProvinces is requested or GetMultiStateProvinces is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStateProvinces(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stateProvinces.SortClauses=sortClauses;
			_stateProvinces.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch)
		{
			return GetMultiCustomers(forceFetch, _customers.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomers(forceFetch, _customers.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomers(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomers || forceFetch || _alwaysFetchCustomers) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customers);
				_customers.SuppressClearInGetMulti=!forceFetch;
				_customers.EntityFactoryToUse = entityFactoryToUse;
				_customers.GetMultiManyToOne(this, filter);
				_customers.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomers = true;
			}
			return _customers;
		}

		/// <summary> Sets the collection parameters for the collection for 'Customers'. These settings will be taken into account
		/// when the property Customers is requested or GetMultiCustomers is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomers(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customers.SortClauses=sortClauses;
			_customers.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, null, null, null, null, null, null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPeople(bool forceFetch)
		{
			return GetMultiSalesPeople(forceFetch, _salesPeople.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPeople(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesPeople(forceFetch, _salesPeople.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPeople(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesPeople(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPeople(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesPeople || forceFetch || _alwaysFetchSalesPeople) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesPeople);
				_salesPeople.SuppressClearInGetMulti=!forceFetch;
				_salesPeople.EntityFactoryToUse = entityFactoryToUse;
				_salesPeople.GetMultiManyToOne(null, null, this, filter);
				_salesPeople.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPeople = true;
			}
			return _salesPeople;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesPeople'. These settings will be taken into account
		/// when the property SalesPeople is requested or GetMultiSalesPeople is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPeople(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPeople.SortClauses=sortClauses;
			_salesPeople.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesTerritoryHistories.GetMultiManyToOne(null, this, filter);
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("Customers", _customers);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPeople", _salesPeople);
			toReturn.Add("SalesTerritoryHistories", _salesTerritoryHistories);
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
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The validator object for this SalesTerritoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 territoryID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(territoryID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_stateProvinces = new AW.Data.CollectionClasses.StateProvinceCollection();
			_stateProvinces.SetContainingEntityInfo(this, "SalesTerritory");

			_customers = new AW.Data.CollectionClasses.CustomerCollection();
			_customers.SetContainingEntityInfo(this, "SalesTerritory");

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "SalesTerritory");

			_salesPeople = new AW.Data.CollectionClasses.SalesPersonCollection();
			_salesPeople.SetContainingEntityInfo(this, "SalesTerritory");

			_salesTerritoryHistories = new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection();
			_salesTerritoryHistories.SetContainingEntityInfo(this, "SalesTerritory");
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
			_customProperties.Add("MS_Description", @"Sales territory lookup table.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Business costs in the territory the previous year.");
			_fieldsCustomProperties.Add("CostLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Business costs in the territory year to date.");
			_fieldsCustomProperties.Add("CostYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Geographic area to which the sales territory belong.");
			_fieldsCustomProperties.Add("Group", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales territory description");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales in the territory the previous year.");
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales in the territory year to date.");
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SalesTerritoryFieldIndex.TerritoryID].ForcedCurrentValueWrite(territoryID);
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
			return DAOFactory.CreateSalesTerritoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesTerritoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesTerritoryRelations Relations
		{
			get	{ return new SalesTerritoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvinces
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(), (IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomers
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customers")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPeople
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), (IEntityRelation)GetRelationsForField("SalesPeople")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPeople", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection(), (IEntityRelation)GetRelationsForField("SalesTerritoryHistories")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, "SalesTerritoryHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The CostLastYear property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Business costs in the territory the previous year.<br/>Business costs in the territory the previous year.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostLastYear, value, true); }
		}

		/// <summary> The CostYtd property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Business costs in the territory year to date.<br/>Business costs in the territory year to date.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostYtd, value, true); }
		}

		/// <summary> The CountryRegionCode property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/>Unique nonclustered index. Used to support replication samples.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, value, true); }
		}

		/// <summary> The Group property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Geographic area to which the sales territory belong.<br/>Geographic area to which the sales territory belong.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Group"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Group
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Group, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Group, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Sales territory description<br/>Sales territory description</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Name, value, true); }
		}

		/// <summary> The Rowguid property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTerritoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SalesLastYear property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Sales in the territory the previous year.<br/>Sales in the territory the previous year.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesLastYear, value, true); }
		}

		/// <summary> The SalesYtd property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Sales in the territory year to date.<br/>Sales in the territory year to date.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesYtd, value, true); }
		}

		/// <summary> The TerritoryID property of the Entity SalesTerritory<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TerritoryID
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryFieldIndex.TerritoryID, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.TerritoryID, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStateProvinces()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection StateProvinces
		{
			get	{ return GetMultiStateProvinces(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvinces. When set to true, StateProvinces is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvinces is accessed. You can always execute/ a forced fetch by calling GetMultiStateProvinces(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvinces
		{
			get	{ return _alwaysFetchStateProvinces; }
			set	{ _alwaysFetchStateProvinces = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StateProvinces already has been fetched. Setting this property to false when StateProvinces has been fetched
		/// will clear the StateProvinces collection well. Setting this property to true while StateProvinces hasn't been fetched disables lazy loading for StateProvinces</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStateProvinces
		{
			get { return _alreadyFetchedStateProvinces;}
			set 
			{
				if(_alreadyFetchedStateProvinces && !value && (_stateProvinces != null))
				{
					_stateProvinces.Clear();
				}
				_alreadyFetchedStateProvinces = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection Customers
		{
			get	{ return GetMultiCustomers(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Customers. When set to true, Customers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customers is accessed. You can always execute/ a forced fetch by calling GetMultiCustomers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomers
		{
			get	{ return _alwaysFetchCustomers; }
			set	{ _alwaysFetchCustomers = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customers already has been fetched. Setting this property to false when Customers has been fetched
		/// will clear the Customers collection well. Setting this property to true while Customers hasn't been fetched disables lazy loading for Customers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomers
		{
			get { return _alreadyFetchedCustomers;}
			set 
			{
				if(_alreadyFetchedCustomers && !value && (_customers != null))
				{
					_customers.Clear();
				}
				_alreadyFetchedCustomers = value;
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
		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPeople()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection SalesPeople
		{
			get	{ return GetMultiSalesPeople(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPeople. When set to true, SalesPeople is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPeople is accessed. You can always execute/ a forced fetch by calling GetMultiSalesPeople(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPeople
		{
			get	{ return _alwaysFetchSalesPeople; }
			set	{ _alwaysFetchSalesPeople = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPeople already has been fetched. Setting this property to false when SalesPeople has been fetched
		/// will clear the SalesPeople collection well. Setting this property to true while SalesPeople hasn't been fetched disables lazy loading for SalesPeople</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPeople
		{
			get { return _alreadyFetchedSalesPeople;}
			set 
			{
				if(_alreadyFetchedSalesPeople && !value && (_salesPeople != null))
				{
					_salesPeople.Clear();
				}
				_alreadyFetchedSalesPeople = value;
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
			get { return (int)AW.Data.EntityType.SalesTerritoryEntity; }
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
