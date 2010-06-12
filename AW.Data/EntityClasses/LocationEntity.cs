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

	/// <summary>Entity class which represents the entity 'Location'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class LocationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductInventoryCollection	_productInventories;
		private bool	_alwaysFetchProductInventories, _alreadyFetchedProductInventories;
		private AW.Data.CollectionClasses.WorkOrderRoutingCollection	_workOrderRoutings;
		private bool	_alwaysFetchWorkOrderRoutings, _alreadyFetchedWorkOrderRoutings;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductInventories</summary>
			public static readonly string ProductInventories = "ProductInventories";
			/// <summary>Member name WorkOrderRoutings</summary>
			public static readonly string WorkOrderRoutings = "WorkOrderRoutings";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LocationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LocationEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		public LocationEntity(System.Int16 locationID)
		{
			InitClassFetch(locationID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LocationEntity(System.Int16 locationID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(locationID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="validator">The custom validator object for this LocationEntity</param>
		public LocationEntity(System.Int16 locationID, IValidator validator)
		{
			InitClassFetch(locationID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LocationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productInventories = (AW.Data.CollectionClasses.ProductInventoryCollection)info.GetValue("_productInventories", typeof(AW.Data.CollectionClasses.ProductInventoryCollection));
			_alwaysFetchProductInventories = info.GetBoolean("_alwaysFetchProductInventories");
			_alreadyFetchedProductInventories = info.GetBoolean("_alreadyFetchedProductInventories");

			_workOrderRoutings = (AW.Data.CollectionClasses.WorkOrderRoutingCollection)info.GetValue("_workOrderRoutings", typeof(AW.Data.CollectionClasses.WorkOrderRoutingCollection));
			_alwaysFetchWorkOrderRoutings = info.GetBoolean("_alwaysFetchWorkOrderRoutings");
			_alreadyFetchedWorkOrderRoutings = info.GetBoolean("_alreadyFetchedWorkOrderRoutings");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedProductInventories = (_productInventories.Count > 0);
			_alreadyFetchedWorkOrderRoutings = (_workOrderRoutings.Count > 0);
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
				case "ProductInventories":
					toReturn.Add(Relations.ProductInventoryEntityUsingLocationID);
					break;
				case "WorkOrderRoutings":
					toReturn.Add(Relations.WorkOrderRoutingEntityUsingLocationID);
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
			info.AddValue("_productInventories", (!this.MarkedForDeletion?_productInventories:null));
			info.AddValue("_alwaysFetchProductInventories", _alwaysFetchProductInventories);
			info.AddValue("_alreadyFetchedProductInventories", _alreadyFetchedProductInventories);
			info.AddValue("_workOrderRoutings", (!this.MarkedForDeletion?_workOrderRoutings:null));
			info.AddValue("_alwaysFetchWorkOrderRoutings", _alwaysFetchWorkOrderRoutings);
			info.AddValue("_alreadyFetchedWorkOrderRoutings", _alreadyFetchedWorkOrderRoutings);

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
				case "ProductInventories":
					_alreadyFetchedProductInventories = true;
					if(entity!=null)
					{
						this.ProductInventories.Add((ProductInventoryEntity)entity);
					}
					break;
				case "WorkOrderRoutings":
					_alreadyFetchedWorkOrderRoutings = true;
					if(entity!=null)
					{
						this.WorkOrderRoutings.Add((WorkOrderRoutingEntity)entity);
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
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductInventories":
					_productInventories.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "WorkOrderRoutings":
					_workOrderRoutings.Add((WorkOrderRoutingEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ProductInventories":
					this.PerformRelatedEntityRemoval(_productInventories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderRoutings":
					this.PerformRelatedEntityRemoval(_workOrderRoutings, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_productInventories);
			toReturn.Add(_workOrderRoutings);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID)
		{
			return FetchUsingPK(locationID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(locationID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(locationID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(locationID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.LocationID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new LocationRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch)
		{
			return GetMultiProductInventories(forceFetch, _productInventories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductInventories(forceFetch, _productInventories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductInventories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventories || forceFetch || _alwaysFetchProductInventories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productInventories);
				_productInventories.SuppressClearInGetMulti=!forceFetch;
				_productInventories.EntityFactoryToUse = entityFactoryToUse;
				_productInventories.GetMultiManyToOne(this, null, filter);
				_productInventories.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventories = true;
			}
			return _productInventories;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductInventories'. These settings will be taken into account
		/// when the property ProductInventories is requested or GetMultiProductInventories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductInventories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productInventories.SortClauses=sortClauses;
			_productInventories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRoutings(bool forceFetch)
		{
			return GetMultiWorkOrderRoutings(forceFetch, _workOrderRoutings.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRoutings(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderRoutings(forceFetch, _workOrderRoutings.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRoutings(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderRoutings(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRoutings(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderRoutings || forceFetch || _alwaysFetchWorkOrderRoutings) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_workOrderRoutings);
				_workOrderRoutings.SuppressClearInGetMulti=!forceFetch;
				_workOrderRoutings.EntityFactoryToUse = entityFactoryToUse;
				_workOrderRoutings.GetMultiManyToOne(this, null, filter);
				_workOrderRoutings.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRoutings = true;
			}
			return _workOrderRoutings;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderRoutings'. These settings will be taken into account
		/// when the property WorkOrderRoutings is requested or GetMultiWorkOrderRoutings is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderRoutings(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderRoutings.SortClauses=sortClauses;
			_workOrderRoutings.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productInventories.ActiveContext = this.ActiveContext;
			_workOrderRoutings.ActiveContext = this.ActiveContext;
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductInventories", _productInventories);
			toReturn.Add("WorkOrderRoutings", _workOrderRoutings);
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
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="validator">The validator object for this LocationEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 locationID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(locationID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productInventories = new AW.Data.CollectionClasses.ProductInventoryCollection();
			_productInventories.SetContainingEntityInfo(this, "Location");

			_workOrderRoutings = new AW.Data.CollectionClasses.WorkOrderRoutingCollection();
			_workOrderRoutings.SetContainingEntityInfo(this, "Location");
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Availability", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CostRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LocationID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)LocationFieldIndex.LocationID].ForcedCurrentValueWrite(locationID);
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
			return DAOFactory.CreateLocationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LocationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LocationRelations Relations
		{
			get	{ return new LocationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductInventory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductInventories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductInventoryCollection(), (IEntityRelation)GetRelationsForField("ProductInventories")[0], (int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.ProductInventoryEntity, 0, null, null, null, "ProductInventories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderRouting' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderRoutings
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderRoutingCollection(), (IEntityRelation)GetRelationsForField("WorkOrderRoutings")[0], (int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.WorkOrderRoutingEntity, 0, null, null, null, "WorkOrderRoutings", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "LocationEntity";}
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

		/// <summary> The Availability property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Availability"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Availability
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.Availability, true); }
			set	{ SetValue((int)LocationFieldIndex.Availability, value, true); }
		}

		/// <summary> The CostRate property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."CostRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostRate
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.CostRate, true); }
			set	{ SetValue((int)LocationFieldIndex.CostRate, value, true); }
		}

		/// <summary> The LocationID property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."LocationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 LocationID
		{
			get { return (System.Int16)GetValue((int)LocationFieldIndex.LocationID, true); }
			set	{ SetValue((int)LocationFieldIndex.LocationID, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)LocationFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)LocationFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity Location<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)LocationFieldIndex.Name, true); }
			set	{ SetValue((int)LocationFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductInventories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection ProductInventories
		{
			get	{ return GetMultiProductInventories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductInventories. When set to true, ProductInventories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductInventories is accessed. You can always execute/ a forced fetch by calling GetMultiProductInventories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductInventories
		{
			get	{ return _alwaysFetchProductInventories; }
			set	{ _alwaysFetchProductInventories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductInventories already has been fetched. Setting this property to false when ProductInventories has been fetched
		/// will clear the ProductInventories collection well. Setting this property to true while ProductInventories hasn't been fetched disables lazy loading for ProductInventories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductInventories
		{
			get { return _alreadyFetchedProductInventories;}
			set 
			{
				if(_alreadyFetchedProductInventories && !value && (_productInventories != null))
				{
					_productInventories.Clear();
				}
				_alreadyFetchedProductInventories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderRoutings()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.WorkOrderRoutingCollection WorkOrderRoutings
		{
			get	{ return GetMultiWorkOrderRoutings(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderRoutings. When set to true, WorkOrderRoutings is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderRoutings is accessed. You can always execute/ a forced fetch by calling GetMultiWorkOrderRoutings(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderRoutings
		{
			get	{ return _alwaysFetchWorkOrderRoutings; }
			set	{ _alwaysFetchWorkOrderRoutings = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderRoutings already has been fetched. Setting this property to false when WorkOrderRoutings has been fetched
		/// will clear the WorkOrderRoutings collection well. Setting this property to true while WorkOrderRoutings hasn't been fetched disables lazy loading for WorkOrderRoutings</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderRoutings
		{
			get { return _alreadyFetchedWorkOrderRoutings;}
			set 
			{
				if(_alreadyFetchedWorkOrderRoutings && !value && (_workOrderRoutings != null))
				{
					_workOrderRoutings.Clear();
				}
				_alreadyFetchedWorkOrderRoutings = value;
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
			get { return (int)AW.Data.EntityType.LocationEntity; }
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
