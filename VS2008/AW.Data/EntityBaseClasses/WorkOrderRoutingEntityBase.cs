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
	
	/// <summary>Entity base class which represents the base class for the entity 'WorkOrderRouting'.<br/><br/>
	/// 
	/// MS_Description: Work order details.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class WorkOrderRoutingEntityBase : CommonEntityBase, ISerializable
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
		static WorkOrderRoutingEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderRoutingEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		public WorkOrderRoutingEntityBase(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence)
		{
			InitClassFetch(workOrderID, productID, operationSequence, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderRoutingEntityBase(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(workOrderID, productID, operationSequence, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		public WorkOrderRoutingEntityBase(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IValidator validator)
		{
			InitClassFetch(workOrderID, productID, operationSequence, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderRoutingEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
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

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((WorkOrderRoutingFieldIndex)fieldIndex)
			{
				case WorkOrderRoutingFieldIndex.WorkOrderID:
					DesetupSyncWorkOrder(true, false);
					_alreadyFetchedWorkOrder = false;
					break;
				case WorkOrderRoutingFieldIndex.LocationID:
					DesetupSyncLocation(true, false);
					_alreadyFetchedLocation = false;
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


			_alreadyFetchedLocation = (_location != null);
			_alreadyFetchedWorkOrder = (_workOrder != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return WorkOrderRoutingEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Location":
					toReturn.Add(WorkOrderRoutingEntity.Relations.LocationEntityUsingLocationID);
					break;
				case "WorkOrder":
					toReturn.Add(WorkOrderRoutingEntity.Relations.WorkOrderEntityUsingWorkOrderID);
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
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
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
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence)
		{
			return FetchUsingPK(workOrderID, productID, operationSequence, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(workOrderID, productID, operationSequence, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(workOrderID, productID, operationSequence, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(workOrderID, productID, operationSequence, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.WorkOrderID, this.ProductID, this.OperationSequence, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(WorkOrderRoutingFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(WorkOrderRoutingFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
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
			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderRoutingEntity.Relations.LocationEntityUsingLocationID);

				LocationEntity newEntity = new LocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.LocationID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (LocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.Location = newEntity;
				}
				else
				{
					if(_locationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_location == null)))
						{
							this.Location = newEntity;
						}
					}
					else
					{
						this.Location = null;
					}
				}
				_alreadyFetchedLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderRoutingEntity.Relations.WorkOrderEntityUsingWorkOrderID);

				WorkOrderEntity newEntity = new WorkOrderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrder = newEntity;
				}
				else
				{
					if(_workOrderReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrder == null)))
						{
							this.WorkOrder = newEntity;
						}
					}
					else
					{
						this.WorkOrder = null;
					}
				}
				_alreadyFetchedWorkOrder = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrder;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			WorkOrderRoutingDAO dao = (WorkOrderRoutingDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_location!=null)
			{
				_location.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			WorkOrderRoutingDAO dao = (WorkOrderRoutingDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			WorkOrderRoutingDAO dao = (WorkOrderRoutingDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.WorkOrderRoutingEntity);
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
			toReturn.Add("Location", _location);
			toReturn.Add("WorkOrder", _workOrder);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The validator object for this WorkOrderRoutingEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(workOrderID, productID, operationSequence, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_location = null;
			_locationReturnsNewIfNotFound = true;
			_alwaysFetchLocation = false;
			_alreadyFetchedLocation = false;
			_workOrder = null;
			_workOrderReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;


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
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("WorkOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Indicates the manufacturing process sequence.");
			_fieldsCustomProperties.Add("OperationSequence", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Manufacturing location where the part is processed. Foreign key to Location.LocationID.");
			_fieldsCustomProperties.Add("LocationID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Planned manufacturing start date.");
			_fieldsCustomProperties.Add("ScheduledStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Planned manufacturing end date.");
			_fieldsCustomProperties.Add("ScheduledEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual start date.");
			_fieldsCustomProperties.Add("ActualStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual end date.");
			_fieldsCustomProperties.Add("ActualEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of manufacturing hours used.");
			_fieldsCustomProperties.Add("ActualResourceHrs", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Estimated manufacturing cost.");
			_fieldsCustomProperties.Add("PlannedCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Actual manufacturing cost.");
			_fieldsCustomProperties.Add("ActualCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _location</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", WorkOrderRoutingEntity.Relations.LocationEntityUsingLocationID, true, signalRelatedEntity, "WorkOrderRouting", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.LocationID } );		
			_location = null;
		}
		
		/// <summary> setups the sync logic for member _location</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLocation(IEntity relatedEntity)
		{
			if(_location!=relatedEntity)
			{		
				DesetupSyncLocation(true, true);
				_location = (LocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", WorkOrderRoutingEntity.Relations.LocationEntityUsingLocationID, true, ref _alreadyFetchedLocation, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderRoutingEntity.Relations.WorkOrderEntityUsingWorkOrderID, true, signalRelatedEntity, "WorkOrderRouting", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.WorkOrderID } );		
			_workOrder = null;
		}
		
		/// <summary> setups the sync logic for member _workOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrder(IEntity relatedEntity)
		{
			if(_workOrder!=relatedEntity)
			{		
				DesetupSyncWorkOrder(true, true);
				_workOrder = (WorkOrderEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderRoutingEntity.Relations.WorkOrderEntityUsingWorkOrderID, true, ref _alreadyFetchedWorkOrder, new string[] {  } );
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
		/// <param name="workOrderID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productID">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 workOrderID, System.Int32 productID, System.Int16 operationSequence, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)WorkOrderRoutingFieldIndex.WorkOrderID].ForcedCurrentValueWrite(workOrderID);
				base.Fields[(int)WorkOrderRoutingFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				base.Fields[(int)WorkOrderRoutingFieldIndex.OperationSequence].ForcedCurrentValueWrite(operationSequence);
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




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Location' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLocation
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.LocationCollection(),
					(IEntityRelation)GetRelationsForField("Location")[0], (int)AW.Data.EntityType.WorkOrderRoutingEntity, (int)AW.Data.EntityType.LocationEntity, 0, null, null, null, "Location", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)AW.Data.EntityType.WorkOrderRoutingEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "WorkOrderRoutingEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WorkOrderRoutingEntity.CustomProperties;}
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
			get { return WorkOrderRoutingEntity.FieldsCustomProperties;}
		}

		/// <summary> The WorkOrderID property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."WorkOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 WorkOrderID
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.WorkOrderID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.WorkOrderID, value, true); }
		}
		/// <summary> The ProductID property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Primary key. Foreign key to Product.ProductID.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.ProductID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ProductID, value, true); }
		}
		/// <summary> The OperationSequence property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Primary key. Indicates the manufacturing process sequence.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."OperationSequence"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 OperationSequence
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, value, true); }
		}
		/// <summary> The LocationID property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Manufacturing location where the part is processed. Foreign key to Location.LocationID.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."LocationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 LocationID
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.LocationID, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.LocationID, value, true); }
		}
		/// <summary> The ScheduledStartDate property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Planned manufacturing start date.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledStartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, value, true); }
		}
		/// <summary> The ScheduledEndDate property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Planned manufacturing end date.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledEndDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, value, true); }
		}
		/// <summary> The ActualStartDate property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Actual start date.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualStartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, value, true); }
		}
		/// <summary> The ActualEndDate property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Actual end date.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, value, true); }
		}
		/// <summary> The ActualResourceHrs property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Number of manufacturing hours used.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualResourceHrs"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 9, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualResourceHrs
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, value, true); }
		}
		/// <summary> The PlannedCost property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Estimated manufacturing cost.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."PlannedCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PlannedCost
		{
			get { return (System.Decimal)GetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, value, true); }
		}
		/// <summary> The ActualCost property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Actual manufacturing cost.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualCost, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualCost, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity WorkOrderRouting<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'LocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual LocationEntity Location
		{
			get	{ return GetSingleLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_location != null)
						{
							_location.UnsetRelatedEntity(this, "WorkOrderRouting");
						}
					}
					else
					{
						if(_location!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrderRouting");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Location. When set to true, Location is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Location is accessed. You can always execute
		/// a forced fetch by calling GetSingleLocation(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderEntity WorkOrder
		{
			get	{ return GetSingleWorkOrder(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrder(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrder != null)
						{
							_workOrder.UnsetRelatedEntity(this, "WorkOrderRouting");
						}
					}
					else
					{
						if(_workOrder!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrderRouting");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrder(true).</summary>
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
		public override int LLBLGenProEntityTypeValue 
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
