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

	/// <summary>Entity class which represents the entity 'WorkOrderRouting'. <br/><br/>
	/// 
	/// MS_Description: Work order details.<br/>
	/// </summary>
	[Serializable]
	public partial class WorkOrderRoutingEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private LocationEntity _location;
		private bool	_alwaysFetchLocation, _alreadyFetchedLocation, _locationReturnsNewIfNotFound;
		private WorkOrderEntity _workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder, _workOrderReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Location</summary>
			public static readonly string Location = "Location";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderRoutingEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderRoutingEntity() :base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID):base("WorkOrderRoutingEntity")
		{
			InitClassFetch(operationSequence, productID, workOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IPrefetchPath prefetchPathToUse):base("WorkOrderRoutingEntity")
		{
			InitClassFetch(operationSequence, productID, workOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IValidator validator):base("WorkOrderRoutingEntity")
		{
			InitClassFetch(operationSequence, productID, workOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderRoutingEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_location = (LocationEntity)info.GetValue("_location", typeof(LocationEntity));
			if(_location!=null)
			{
				_location.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_locationReturnsNewIfNotFound = info.GetBoolean("_locationReturnsNewIfNotFound");
			_alwaysFetchLocation = info.GetBoolean("_alwaysFetchLocation");
			_alreadyFetchedLocation = info.GetBoolean("_alreadyFetchedLocation");

			_workOrder = (WorkOrderEntity)info.GetValue("_workOrder", typeof(WorkOrderEntity));
			if(_workOrder!=null)
			{
				_workOrder.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderReturnsNewIfNotFound = info.GetBoolean("_workOrderReturnsNewIfNotFound");
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((WorkOrderRoutingFieldIndex)fieldIndex)
			{
				case WorkOrderRoutingFieldIndex.LocationID:
					DesetupSyncLocation(true, false);
					_alreadyFetchedLocation = false;
					break;
				case WorkOrderRoutingFieldIndex.WorkOrderID:
					DesetupSyncWorkOrder(true, false);
					_alreadyFetchedWorkOrder = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedLocation = (_location != null);
			_alreadyFetchedWorkOrder = (_workOrder != null);
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
				case "Location":
					toReturn.Add(Relations.LocationEntityUsingLocationID);
					break;
				case "WorkOrder":
					toReturn.Add(Relations.WorkOrderEntityUsingWorkOrderID);
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
			info.AddValue("_location", (!this.MarkedForDeletion?_location:null));
			info.AddValue("_locationReturnsNewIfNotFound", _locationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchLocation", _alwaysFetchLocation);
			info.AddValue("_alreadyFetchedLocation", _alreadyFetchedLocation);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_workOrderReturnsNewIfNotFound", _workOrderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);

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
				case "Location":
					_alreadyFetchedLocation = true;
					this.Location = (LocationEntity)entity;
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					this.WorkOrder = (WorkOrderEntity)entity;
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
				case "Location":
					SetupSyncLocation(relatedEntity);
					break;
				case "WorkOrder":
					SetupSyncWorkOrder(relatedEntity);
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
				case "Location":
					DesetupSyncLocation(false, true);
					break;
				case "WorkOrder":
					DesetupSyncWorkOrder(false, true);
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
			if(_location!=null)
			{
				toReturn.Add(_location);
			}
			if(_workOrder!=null)
			{
				toReturn.Add(_workOrder);
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
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID)
		{
			return FetchUsingPK(operationSequence, productID, workOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(operationSequence, productID, workOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(operationSequence, productID, workOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(operationSequence, productID, workOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.OperationSequence, this.ProductID, this.WorkOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderRoutingRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'LocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'LocationEntity' which is related to this entity.</returns>
		public LocationEntity GetSingleLocation()
		{
			return GetSingleLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'LocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'LocationEntity' which is related to this entity.</returns>
		public virtual LocationEntity GetSingleLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.LocationEntityUsingLocationID);
				LocationEntity newEntity = new LocationEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.LocationID);
				}
				if(fetchResult)
				{
					newEntity = (LocationEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_locationReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Location = newEntity;
				_alreadyFetchedLocation = fetchResult;
			}
			return _location;
		}


		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public WorkOrderEntity GetSingleWorkOrder()
		{
			return GetSingleWorkOrder(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public virtual WorkOrderEntity GetSingleWorkOrder(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.WorkOrderEntityUsingWorkOrderID);
				WorkOrderEntity newEntity = new WorkOrderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderID);
				}
				if(fetchResult)
				{
					newEntity = (WorkOrderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_workOrderReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.WorkOrder = newEntity;
				_alreadyFetchedWorkOrder = fetchResult;
			}
			return _workOrder;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Location", _location);
			toReturn.Add("WorkOrder", _workOrder);
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
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The validator object for this WorkOrderRoutingEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(operationSequence, productID, workOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_locationReturnsNewIfNotFound = true;
			_workOrderReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Work order details.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual manufacturing cost.");
			_fieldsCustomProperties.Add("ActualCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual end date.");
			_fieldsCustomProperties.Add("ActualEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of manufacturing hours used.");
			_fieldsCustomProperties.Add("ActualResourceHrs", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual start date.");
			_fieldsCustomProperties.Add("ActualStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Manufacturing location where the part is processed. Foreign key to Location.LocationID.");
			_fieldsCustomProperties.Add("LocationID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Indicates the manufacturing process sequence.");
			_fieldsCustomProperties.Add("OperationSequence", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Estimated manufacturing cost.");
			_fieldsCustomProperties.Add("PlannedCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Planned manufacturing end date.");
			_fieldsCustomProperties.Add("ScheduledEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Planned manufacturing start date.");
			_fieldsCustomProperties.Add("ScheduledStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("WorkOrderID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _location</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", AW.Data.RelationClasses.StaticWorkOrderRoutingRelations.LocationEntityUsingLocationIDStatic, true, signalRelatedEntity, "WorkOrderRoutings", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.LocationID } );		
			_location = null;
		}
		
		/// <summary> setups the sync logic for member _location</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLocation(IEntityCore relatedEntity)
		{
			if(_location!=relatedEntity)
			{		
				DesetupSyncLocation(true, true);
				_location = (LocationEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", AW.Data.RelationClasses.StaticWorkOrderRoutingRelations.LocationEntityUsingLocationIDStatic, true, ref _alreadyFetchedLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AW.Data.RelationClasses.StaticWorkOrderRoutingRelations.WorkOrderEntityUsingWorkOrderIDStatic, true, signalRelatedEntity, "WorkOrderRoutings", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.WorkOrderID } );		
			_workOrder = null;
		}
		
		/// <summary> setups the sync logic for member _workOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrder(IEntityCore relatedEntity)
		{
			if(_workOrder!=relatedEntity)
			{		
				DesetupSyncWorkOrder(true, true);
				_workOrder = (WorkOrderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AW.Data.RelationClasses.StaticWorkOrderRoutingRelations.WorkOrderEntityUsingWorkOrderIDStatic, true, ref _alreadyFetchedWorkOrder, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 operationSequence, System.Int32 productID, System.Int32 workOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)WorkOrderRoutingFieldIndex.OperationSequence].ForcedCurrentValueWrite(operationSequence);
				this.Fields[(int)WorkOrderRoutingFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				this.Fields[(int)WorkOrderRoutingFieldIndex.WorkOrderID].ForcedCurrentValueWrite(workOrderID);
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
			return DAOFactory.CreateWorkOrderRoutingDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new WorkOrderRoutingEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static WorkOrderRoutingRelations Relations
		{
			get	{ return new WorkOrderRoutingRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Location'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLocation
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.LocationCollection(), (IEntityRelation)GetRelationsForField("Location")[0], (int)AW.Data.EntityType.WorkOrderRoutingEntity, (int)AW.Data.EntityType.LocationEntity, 0, null, null, null, "Location", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(), (IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)AW.Data.EntityType.WorkOrderRoutingEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ActualCost property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Actual manufacturing cost.<br/>Actual manufacturing cost.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualCost, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualCost, value, true); }
		}

		/// <summary> The ActualEndDate property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Actual end date.<br/>Actual end date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, value, true); }
		}

		/// <summary> The ActualResourceHrs property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Number of manufacturing hours used.<br/>Number of manufacturing hours used.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualResourceHrs"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 9, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualResourceHrs
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, value, true); }
		}

		/// <summary> The ActualStartDate property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Actual start date.<br/>Actual start date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualStartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, value, true); }
		}

		/// <summary> The LocationID property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Manufacturing location where the part is processed. Foreign key to Location.LocationID.<br/>Manufacturing location where the part is processed. Foreign key to Location.LocationID.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."LocationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 LocationID
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.LocationID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.LocationID, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OperationSequence property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Primary key. Indicates the manufacturing process sequence.<br/>Primary key. Indicates the manufacturing process sequence.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."OperationSequence"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 OperationSequence
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, value, true); }
		}

		/// <summary> The PlannedCost property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Estimated manufacturing cost.<br/>Estimated manufacturing cost.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."PlannedCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PlannedCost
		{
			get { return (System.Decimal)GetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, value, true); }
		}

		/// <summary> The ProductID property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Primary key. Foreign key to Product.ProductID.<br/>Primary key. Foreign key to Product.ProductID.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.ProductID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ProductID, value, true); }
		}

		/// <summary> The ScheduledEndDate property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Planned manufacturing end date.<br/>Planned manufacturing end date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledEndDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, value, true); }
		}

		/// <summary> The ScheduledStartDate property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Planned manufacturing start date.<br/>Planned manufacturing start date.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledStartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, value, true); }
		}

		/// <summary> The WorkOrderID property of the Entity WorkOrderRouting<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."WorkOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 WorkOrderID
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.WorkOrderID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.WorkOrderID, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'LocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual LocationEntity Location
		{
			get	{ return GetSingleLocation(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncLocation(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrderRoutings", "Location", _location, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Location. When set to true, Location is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Location is accessed. You can always execute a forced fetch by calling GetSingleLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLocation
		{
			get	{ return _alwaysFetchLocation; }
			set	{ _alwaysFetchLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Location already has been fetched. Setting this property to false when Location has been fetched
		/// will set Location to null as well. Setting this property to true while Location hasn't been fetched disables lazy loading for Location</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLocation
		{
			get { return _alreadyFetchedLocation;}
			set 
			{
				if(_alreadyFetchedLocation && !value)
				{
					this.Location = null;
				}
				_alreadyFetchedLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Location is not found
		/// in the database. When set to true, Location will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool LocationReturnsNewIfNotFound
		{
			get	{ return _locationReturnsNewIfNotFound; }
			set { _locationReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'WorkOrderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual WorkOrderEntity WorkOrder
		{
			get	{ return GetSingleWorkOrder(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncWorkOrder(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrderRoutings", "WorkOrder", _workOrder, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute a forced fetch by calling GetSingleWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get	{ return _alwaysFetchWorkOrder; }
			set	{ _alwaysFetchWorkOrder = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrder already has been fetched. Setting this property to false when WorkOrder has been fetched
		/// will set WorkOrder to null as well. Setting this property to true while WorkOrder hasn't been fetched disables lazy loading for WorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrder
		{
			get { return _alreadyFetchedWorkOrder;}
			set 
			{
				if(_alreadyFetchedWorkOrder && !value)
				{
					this.WorkOrder = null;
				}
				_alreadyFetchedWorkOrder = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrder is not found
		/// in the database. When set to true, WorkOrder will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderReturnsNewIfNotFound
		{
			get	{ return _workOrderReturnsNewIfNotFound; }
			set { _workOrderReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.WorkOrderRoutingEntity; }
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
