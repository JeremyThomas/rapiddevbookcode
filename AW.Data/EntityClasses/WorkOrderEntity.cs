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

	/// <summary>Entity class which represents the entity 'WorkOrder'. <br/><br/>
	/// 
	/// MS_Description: Manufacturing work orders.<br/>
	/// </summary>
	[Serializable]
	public partial class WorkOrderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.WorkOrderRoutingCollection	_workOrderRoutings;
		private bool	_alwaysFetchWorkOrderRoutings, _alreadyFetchedWorkOrderRoutings;
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private ScrapReasonEntity _scrapReason;
		private bool	_alwaysFetchScrapReason, _alreadyFetchedScrapReason, _scrapReasonReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name ScrapReason</summary>
			public static readonly string ScrapReason = "ScrapReason";
			/// <summary>Member name WorkOrderRoutings</summary>
			public static readonly string WorkOrderRoutings = "WorkOrderRoutings";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderEntity() :base("WorkOrderEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		public WorkOrderEntity(System.Int32 workOrderID):base("WorkOrderEntity")
		{
			InitClassFetch(workOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderEntity(System.Int32 workOrderID, IPrefetchPath prefetchPathToUse):base("WorkOrderEntity")
		{
			InitClassFetch(workOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(System.Int32 workOrderID, IValidator validator):base("WorkOrderEntity")
		{
			InitClassFetch(workOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_workOrderRoutings = (AW.Data.CollectionClasses.WorkOrderRoutingCollection)info.GetValue("_workOrderRoutings", typeof(AW.Data.CollectionClasses.WorkOrderRoutingCollection));
			_alwaysFetchWorkOrderRoutings = info.GetBoolean("_alwaysFetchWorkOrderRoutings");
			_alreadyFetchedWorkOrderRoutings = info.GetBoolean("_alreadyFetchedWorkOrderRoutings");
			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_scrapReason = (ScrapReasonEntity)info.GetValue("_scrapReason", typeof(ScrapReasonEntity));
			if(_scrapReason!=null)
			{
				_scrapReason.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_scrapReasonReturnsNewIfNotFound = info.GetBoolean("_scrapReasonReturnsNewIfNotFound");
			_alwaysFetchScrapReason = info.GetBoolean("_alwaysFetchScrapReason");
			_alreadyFetchedScrapReason = info.GetBoolean("_alreadyFetchedScrapReason");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((WorkOrderFieldIndex)fieldIndex)
			{
				case WorkOrderFieldIndex.ProductID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				case WorkOrderFieldIndex.ScrapReasonID:
					DesetupSyncScrapReason(true, false);
					_alreadyFetchedScrapReason = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedWorkOrderRoutings = (_workOrderRoutings.Count > 0);
			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedScrapReason = (_scrapReason != null);
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
				case "Product":
					toReturn.Add(Relations.ProductEntityUsingProductID);
					break;
				case "ScrapReason":
					toReturn.Add(Relations.ScrapReasonEntityUsingScrapReasonID);
					break;
				case "WorkOrderRoutings":
					toReturn.Add(Relations.WorkOrderRoutingEntityUsingWorkOrderID);
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
			info.AddValue("_workOrderRoutings", (!this.MarkedForDeletion?_workOrderRoutings:null));
			info.AddValue("_alwaysFetchWorkOrderRoutings", _alwaysFetchWorkOrderRoutings);
			info.AddValue("_alreadyFetchedWorkOrderRoutings", _alreadyFetchedWorkOrderRoutings);
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_productReturnsNewIfNotFound", _productReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_scrapReason", (!this.MarkedForDeletion?_scrapReason:null));
			info.AddValue("_scrapReasonReturnsNewIfNotFound", _scrapReasonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchScrapReason", _alwaysFetchScrapReason);
			info.AddValue("_alreadyFetchedScrapReason", _alreadyFetchedScrapReason);

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
				case "Product":
					_alreadyFetchedProduct = true;
					this.Product = (ProductEntity)entity;
					break;
				case "ScrapReason":
					_alreadyFetchedScrapReason = true;
					this.ScrapReason = (ScrapReasonEntity)entity;
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
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "ScrapReason":
					SetupSyncScrapReason(relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Product":
					DesetupSyncProduct(false, true);
					break;
				case "ScrapReason":
					DesetupSyncScrapReason(false, true);
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
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			if(_scrapReason!=null)
			{
				toReturn.Add(_scrapReason);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_workOrderRoutings);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID)
		{
			return FetchUsingPK(workOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(workOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(workOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(workOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.WorkOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderRelations().GetAllRelations();
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
				_workOrderRoutings.GetMultiManyToOne(null, this, filter);
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

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProduct()
		{
			return GetSingleProduct(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct(bool forceFetch)
		{
			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingProductID);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductID);
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Product = newEntity;
				_alreadyFetchedProduct = fetchResult;
			}
			return _product;
		}


		/// <summary> Retrieves the related entity of type 'ScrapReasonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ScrapReasonEntity' which is related to this entity.</returns>
		public ScrapReasonEntity GetSingleScrapReason()
		{
			return GetSingleScrapReason(false);
		}

		/// <summary> Retrieves the related entity of type 'ScrapReasonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ScrapReasonEntity' which is related to this entity.</returns>
		public virtual ScrapReasonEntity GetSingleScrapReason(bool forceFetch)
		{
			if( ( !_alreadyFetchedScrapReason || forceFetch || _alwaysFetchScrapReason) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ScrapReasonEntityUsingScrapReasonID);
				ScrapReasonEntity newEntity = new ScrapReasonEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ScrapReasonID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ScrapReasonEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_scrapReasonReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ScrapReason = newEntity;
				_alreadyFetchedScrapReason = fetchResult;
			}
			return _scrapReason;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("ScrapReason", _scrapReason);
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
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The validator object for this WorkOrderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 workOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(workOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_workOrderRoutings = new AW.Data.CollectionClasses.WorkOrderRoutingCollection();
			_workOrderRoutings.SetContainingEntityInfo(this, "WorkOrder");
			_productReturnsNewIfNotFound = true;
			_scrapReasonReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Manufacturing work orders.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Work order due date.");
			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Work order end date.");
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("OrderQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product identification number. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity that failed inspection.");
			_fieldsCustomProperties.Add("ScrappedQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Reason for inspection failure.");
			_fieldsCustomProperties.Add("ScrapReasonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Work order start date.");
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity built and put in inventory.");
			_fieldsCustomProperties.Add("StockedQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("WorkOrderID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AW.Data.RelationClasses.StaticWorkOrderRelations.ProductEntityUsingProductIDStatic, true, signalRelatedEntity, "WorkOrders", resetFKFields, new int[] { (int)WorkOrderFieldIndex.ProductID } );		
			_product = null;
		}
		
		/// <summary> setups the sync logic for member _product</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntityCore relatedEntity)
		{
			if(_product!=relatedEntity)
			{		
				DesetupSyncProduct(true, true);
				_product = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AW.Data.RelationClasses.StaticWorkOrderRelations.ProductEntityUsingProductIDStatic, true, ref _alreadyFetchedProduct, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _scrapReason</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncScrapReason(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _scrapReason, new PropertyChangedEventHandler( OnScrapReasonPropertyChanged ), "ScrapReason", AW.Data.RelationClasses.StaticWorkOrderRelations.ScrapReasonEntityUsingScrapReasonIDStatic, true, signalRelatedEntity, "WorkOrders", resetFKFields, new int[] { (int)WorkOrderFieldIndex.ScrapReasonID } );		
			_scrapReason = null;
		}
		
		/// <summary> setups the sync logic for member _scrapReason</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncScrapReason(IEntityCore relatedEntity)
		{
			if(_scrapReason!=relatedEntity)
			{		
				DesetupSyncScrapReason(true, true);
				_scrapReason = (ScrapReasonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _scrapReason, new PropertyChangedEventHandler( OnScrapReasonPropertyChanged ), "ScrapReason", AW.Data.RelationClasses.StaticWorkOrderRelations.ScrapReasonEntityUsingScrapReasonIDStatic, true, ref _alreadyFetchedScrapReason, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnScrapReasonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)WorkOrderFieldIndex.WorkOrderID].ForcedCurrentValueWrite(workOrderID);
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
			return DAOFactory.CreateWorkOrderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new WorkOrderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static WorkOrderRelations Relations
		{
			get	{ return new WorkOrderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderRouting' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderRoutings
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderRoutingCollection(), (IEntityRelation)GetRelationsForField("WorkOrderRoutings")[0], (int)AW.Data.EntityType.WorkOrderEntity, (int)AW.Data.EntityType.WorkOrderRoutingEntity, 0, null, null, null, "WorkOrderRoutings", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.WorkOrderEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ScrapReason'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathScrapReason
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ScrapReasonCollection(), (IEntityRelation)GetRelationsForField("ScrapReason")[0], (int)AW.Data.EntityType.WorkOrderEntity, (int)AW.Data.EntityType.ScrapReasonEntity, 0, null, null, null, "ScrapReason", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The DueDate property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Work order due date.<br/>Work order due date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.DueDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.DueDate, value, true); }
		}

		/// <summary> The EndDate property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Work order end date.<br/>Work order end date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderFieldIndex.EndDate, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.EndDate, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OrderQuantity property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."OrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 OrderQuantity
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.OrderQuantity, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.OrderQuantity, value, true); }
		}

		/// <summary> The ProductID property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Product identification number. Foreign key to Product.ProductID.<br/>Product identification number. Foreign key to Product.ProductID.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.ProductID, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ProductID, value, true); }
		}

		/// <summary> The ScrappedQuantity property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Quantity that failed inspection.<br/>Quantity that failed inspection.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ScrappedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ScrappedQuantity
		{
			get { return (System.Int16)GetValue((int)WorkOrderFieldIndex.ScrappedQuantity, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ScrappedQuantity, value, true); }
		}

		/// <summary> The ScrapReasonID property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Reason for inspection failure.<br/>Reason for inspection failure.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ScrapReasonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ScrapReasonID
		{
			get { return (Nullable<System.Int16>)GetValue((int)WorkOrderFieldIndex.ScrapReasonID, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.ScrapReasonID, value, true); }
		}

		/// <summary> The StartDate property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Work order start date.<br/>Work order start date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.StartDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.StartDate, value, true); }
		}

		/// <summary> The StockedQuantity property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Quantity built and put in inventory.<br/>Quantity built and put in inventory.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."StockedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StockedQuantity
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.StockedQuantity, true); }

		}

		/// <summary> The WorkOrderID property of the Entity WorkOrder<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."WorkOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WorkOrderID
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.WorkOrderID, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.WorkOrderID, value, true); }
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

		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return GetSingleProduct(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrders", "Product", _product, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute a forced fetch by calling GetSingleProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get	{ return _alwaysFetchProduct; }
			set	{ _alwaysFetchProduct = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product already has been fetched. Setting this property to false when Product has been fetched
		/// will set Product to null as well. Setting this property to true while Product hasn't been fetched disables lazy loading for Product</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct
		{
			get { return _alreadyFetchedProduct;}
			set 
			{
				if(_alreadyFetchedProduct && !value)
				{
					this.Product = null;
				}
				_alreadyFetchedProduct = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Product is not found
		/// in the database. When set to true, Product will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductReturnsNewIfNotFound
		{
			get	{ return _productReturnsNewIfNotFound; }
			set { _productReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ScrapReasonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleScrapReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ScrapReasonEntity ScrapReason
		{
			get	{ return GetSingleScrapReason(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncScrapReason(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrders", "ScrapReason", _scrapReason, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ScrapReason. When set to true, ScrapReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ScrapReason is accessed. You can always execute a forced fetch by calling GetSingleScrapReason(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchScrapReason
		{
			get	{ return _alwaysFetchScrapReason; }
			set	{ _alwaysFetchScrapReason = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ScrapReason already has been fetched. Setting this property to false when ScrapReason has been fetched
		/// will set ScrapReason to null as well. Setting this property to true while ScrapReason hasn't been fetched disables lazy loading for ScrapReason</summary>
		[Browsable(false)]
		public bool AlreadyFetchedScrapReason
		{
			get { return _alreadyFetchedScrapReason;}
			set 
			{
				if(_alreadyFetchedScrapReason && !value)
				{
					this.ScrapReason = null;
				}
				_alreadyFetchedScrapReason = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ScrapReason is not found
		/// in the database. When set to true, ScrapReason will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ScrapReasonReturnsNewIfNotFound
		{
			get	{ return _scrapReasonReturnsNewIfNotFound; }
			set { _scrapReasonReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.WorkOrderEntity; }
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
