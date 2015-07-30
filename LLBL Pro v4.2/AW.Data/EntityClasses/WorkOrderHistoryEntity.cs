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

	/// <summary>Entity class which represents the entity 'WorkOrderHistory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WorkOrderHistoryEntity : TransactionHistoryEntity
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private WorkOrderEntity _workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder, _workOrderReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static new partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderHistoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderHistoryEntity() 
		{
			InitClassEmpty(null);
			SetName("WorkOrderHistoryEntity");
		}
		
		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		public WorkOrderHistoryEntity(System.Int32 transactionID):base(transactionID)
		{
			InitClassFetch(transactionID, null, null);
			SetName("WorkOrderHistoryEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderHistoryEntity(System.Int32 transactionID, IPrefetchPath prefetchPathToUse):base(transactionID, prefetchPathToUse)
		{
			InitClassFetch(transactionID, null, prefetchPathToUse);
			SetName("WorkOrderHistoryEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		/// <param name="validator">The custom validator object for this WorkOrderHistoryEntity</param>
		public WorkOrderHistoryEntity(System.Int32 transactionID, IValidator validator):base(transactionID, validator)
		{
			InitClassFetch(transactionID, validator, null);
			SetName("WorkOrderHistoryEntity");
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
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
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
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
		internal static new RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "WorkOrder":
					toReturn.Add(Relations.WorkOrderEntityUsingReferenceOrderID);
					break;
				default:
					toReturn = TransactionHistoryEntity.GetRelationsForField(fieldName);
					break;				
			}
			return toReturn;
		}

		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter()
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("WorkOrderHistoryEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("WorkOrderHistoryEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{

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
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					this.WorkOrder = (WorkOrderEntity)entity;
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
				case "WorkOrder":
					SetupSyncWorkOrder(relatedEntity);
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
				case "WorkOrder":
					DesetupSyncWorkOrder(false, true);
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
			if(_workOrder!=null)
			{
				toReturn.Add(_workOrder);
			}
			toReturn.AddRange(base.GetDependentRelatedEntities());
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();

			toReturn.AddRange(base.GetMemberEntityCollections());
			return toReturn;
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderID(System.Int32 referenceOrderID)
		{
			return FetchUsingUCReferenceOrderID( referenceOrderID, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderID(System.Int32 referenceOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCReferenceOrderID( referenceOrderID, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderID(System.Int32 referenceOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCReferenceOrderID( referenceOrderID, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderID(System.Int32 referenceOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((WorkOrderHistoryDAO)CreateDAOInstance()).FetchWorkOrderHistoryUsingUCReferenceOrderID(this, this.Transaction, referenceOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary>Fetches the contents of this entity from the persistent storage using a polymorphic fetch on unique constraint, so the entity returned could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static WorkOrderHistoryEntity FetchPolymorphicUsingUCReferenceOrderID(ITransaction transactionToUse, System.Int32 referenceOrderID, Context contextToUse)
		{
			return FetchPolymorphicUsingUCReferenceOrderID(transactionToUse, referenceOrderID, contextToUse, null);
		}
		
		/// <summary>Fetches the contents of this entity from the persistent storage using a polymorphic fetch on unique constraint, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static WorkOrderHistoryEntity FetchPolymorphicUsingUCReferenceOrderID(ITransaction transactionToUse, System.Int32 referenceOrderID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return new WorkOrderHistoryDAO().FetchWorkOrderHistoryPolyUsingUCReferenceOrderID(transactionToUse, referenceOrderID, contextToUse, excludedIncludedFields);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new WorkOrderHistoryEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 transactionID, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, transactionID, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new WorkOrderHistoryEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 transactionID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.WorkOrderHistoryEntity);
			fields.ForcedValueWrite((int)WorkOrderHistoryFieldIndex.TransactionID, transactionID);
			return (WorkOrderHistoryEntity)new WorkOrderHistoryDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}


		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the AW.Data.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("WorkOrderHistoryEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderHistoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public WorkOrderEntity GetSingleWorkOrder()
		{
			return GetSingleWorkOrder(false);
		}
		
		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public virtual WorkOrderEntity GetSingleWorkOrder(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode )
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.WorkOrderEntityUsingReferenceOrderID);
				WorkOrderEntity newEntity = new WorkOrderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ReferenceOrderID);
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
			Dictionary<string, object> toReturn = base.GetRelatedData();
			toReturn.Add("WorkOrder", _workOrder);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			InitClassMembers();
			if(this.Fields.State==EntityState.New)
			{
				this.Fields.ForcedValueWrite((int)WorkOrderHistoryFieldIndex.TransactionType, "W");
			}
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="transactionID">PK value for WorkOrderHistory which data should be fetched into this WorkOrderHistory object</param>
		/// <param name="validator">The validator object for this WorkOrderHistoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 transactionID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers();	
			if(this.Fields.State==EntityState.New)
			{
				this.Fields.ForcedValueWrite((int)WorkOrderHistoryFieldIndex.TransactionType, "W");
			}
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_workOrderReturnsNewIfNotFound = true;

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
		}
		#endregion

		/// <summary> Removes the sync logic for member _workOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AW.Data.RelationClasses.StaticWorkOrderHistoryRelations.WorkOrderEntityUsingReferenceOrderIDStatic, true, signalRelatedEntity, "WorkOrderHistory", resetFKFields, new int[] { (int)WorkOrderHistoryFieldIndex.ReferenceOrderID } );
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
				this.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AW.Data.RelationClasses.StaticWorkOrderHistoryRelations.WorkOrderEntityUsingReferenceOrderIDStatic, true, ref _alreadyFetchedWorkOrder, new string[] {  } );
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

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateWorkOrderHistoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new WorkOrderHistoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public new static WorkOrderHistoryRelations Relations
		{
			get	{ return new WorkOrderHistoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public new static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(), (IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)AW.Data.EntityType.WorkOrderHistoryEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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


		/// <summary> Gets / sets related entity of type 'WorkOrderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
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
					if(value==null)
					{
						bool raisePropertyChanged = (_workOrder !=null);
						DesetupSyncWorkOrder(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("WorkOrder");
						}
					}
					else
					{
						if(_workOrder!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrderHistory");
							SetupSyncWorkOrder(value);
						}
					}
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
			set	{ _workOrderReturnsNewIfNotFound = value; }	
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
			get { return InheritanceHierarchyType.TargetPerEntityHierarchy;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.WorkOrderHistoryEntity; }
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
