///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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

	/// <summary>Entity class which represents the entity 'PurchaseOrderHistory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class PurchaseOrderHistoryEntity : TransactionHistoryEntity
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private PurchaseOrderHeaderEntity _purchaseOrder;
		private bool	_alwaysFetchPurchaseOrder, _alreadyFetchedPurchaseOrder, _purchaseOrderReturnsNewIfNotFound;
		private PurchaseOrderDetailEntity _purchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderDetail, _alreadyFetchedPurchaseOrderDetail, _purchaseOrderDetailReturnsNewIfNotFound;

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
			/// <summary>Member name PurchaseOrder</summary>
			public static readonly string PurchaseOrder = "PurchaseOrder";
			/// <summary>Member name PurchaseOrderDetail</summary>
			public static readonly string PurchaseOrderDetail = "PurchaseOrderDetail";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderHistoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PurchaseOrderHistoryEntity() 
		{
			InitClassEmpty(null);
			SetName("PurchaseOrderHistoryEntity");
		}
		
		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		public PurchaseOrderHistoryEntity(System.Int32 transactionID):base(transactionID)
		{
			InitClassFetch(transactionID, null, null);
			SetName("PurchaseOrderHistoryEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderHistoryEntity(System.Int32 transactionID, IPrefetchPath prefetchPathToUse):base(transactionID, prefetchPathToUse)
		{
			InitClassFetch(transactionID, null, prefetchPathToUse);
			SetName("PurchaseOrderHistoryEntity");
		}

		/// <summary>CTor</summary>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHistoryEntity</param>
		public PurchaseOrderHistoryEntity(System.Int32 transactionID, IValidator validator):base(transactionID, validator)
		{
			InitClassFetch(transactionID, validator, null);
			SetName("PurchaseOrderHistoryEntity");
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_purchaseOrder = (PurchaseOrderHeaderEntity)info.GetValue("_purchaseOrder", typeof(PurchaseOrderHeaderEntity));
			if(_purchaseOrder!=null)
			{
				_purchaseOrder.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_purchaseOrderReturnsNewIfNotFound = info.GetBoolean("_purchaseOrderReturnsNewIfNotFound");
			_alwaysFetchPurchaseOrder = info.GetBoolean("_alwaysFetchPurchaseOrder");
			_alreadyFetchedPurchaseOrder = info.GetBoolean("_alreadyFetchedPurchaseOrder");
			_purchaseOrderDetail = (PurchaseOrderDetailEntity)info.GetValue("_purchaseOrderDetail", typeof(PurchaseOrderDetailEntity));
			if(_purchaseOrderDetail!=null)
			{
				_purchaseOrderDetail.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_purchaseOrderDetailReturnsNewIfNotFound = info.GetBoolean("_purchaseOrderDetailReturnsNewIfNotFound");
			_alwaysFetchPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderDetail");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedPurchaseOrder = (_purchaseOrder != null);
			_alreadyFetchedPurchaseOrderDetail = (_purchaseOrderDetail != null);
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
				case "PurchaseOrder":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingReferenceOrderID);
					break;
				case "PurchaseOrderDetail":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingReferenceOrderLineIDReferenceOrderID);
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
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("PurchaseOrderHistoryEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public new static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("PurchaseOrderHistoryEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_purchaseOrder", (!this.MarkedForDeletion?_purchaseOrder:null));
			info.AddValue("_purchaseOrderReturnsNewIfNotFound", _purchaseOrderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPurchaseOrder", _alwaysFetchPurchaseOrder);
			info.AddValue("_alreadyFetchedPurchaseOrder", _alreadyFetchedPurchaseOrder);

			info.AddValue("_purchaseOrderDetail", (!this.MarkedForDeletion?_purchaseOrderDetail:null));
			info.AddValue("_purchaseOrderDetailReturnsNewIfNotFound", _purchaseOrderDetailReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPurchaseOrderDetail", _alwaysFetchPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderDetail", _alreadyFetchedPurchaseOrderDetail);

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
				case "PurchaseOrder":
					_alreadyFetchedPurchaseOrder = true;
					this.PurchaseOrder = (PurchaseOrderHeaderEntity)entity;
					break;
				case "PurchaseOrderDetail":
					_alreadyFetchedPurchaseOrderDetail = true;
					this.PurchaseOrderDetail = (PurchaseOrderDetailEntity)entity;
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
				case "PurchaseOrder":
					SetupSyncPurchaseOrder(relatedEntity);
					break;
				case "PurchaseOrderDetail":
					SetupSyncPurchaseOrderDetail(relatedEntity);
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
				case "PurchaseOrder":
					DesetupSyncPurchaseOrder(false, true);
					break;
				case "PurchaseOrderDetail":
					DesetupSyncPurchaseOrderDetail(false, true);
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
			if(_purchaseOrder!=null)
			{
				toReturn.Add(_purchaseOrder);
			}
			if(_purchaseOrderDetail!=null)
			{
				toReturn.Add(_purchaseOrderDetail);
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
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderIDReferenceOrderLineID(System.Int32 referenceOrderID, System.Int32 referenceOrderLineID)
		{
			return FetchUsingUCReferenceOrderIDReferenceOrderLineID( referenceOrderID,  referenceOrderLineID, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderIDReferenceOrderLineID(System.Int32 referenceOrderID, System.Int32 referenceOrderLineID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCReferenceOrderIDReferenceOrderLineID( referenceOrderID,  referenceOrderLineID, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderIDReferenceOrderLineID(System.Int32 referenceOrderID, System.Int32 referenceOrderLineID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCReferenceOrderIDReferenceOrderLineID( referenceOrderID,  referenceOrderLineID, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCReferenceOrderIDReferenceOrderLineID(System.Int32 referenceOrderID, System.Int32 referenceOrderLineID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((PurchaseOrderHistoryDAO)CreateDAOInstance()).FetchPurchaseOrderHistoryUsingUCReferenceOrderIDReferenceOrderLineID(this, this.Transaction, referenceOrderID, referenceOrderLineID, prefetchPathToUse, contextToUse, excludedIncludedFields);
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
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static PurchaseOrderHistoryEntity FetchPolymorphicUsingUCReferenceOrderIDReferenceOrderLineID(ITransaction transactionToUse, System.Int32 referenceOrderID, System.Int32 referenceOrderLineID, Context contextToUse)
		{
			return FetchPolymorphicUsingUCReferenceOrderIDReferenceOrderLineID(transactionToUse, referenceOrderID, referenceOrderLineID, contextToUse, null);
		}
		
		/// <summary>Fetches the contents of this entity from the persistent storage using a polymorphic fetch on unique constraint, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="referenceOrderID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="referenceOrderLineID">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static PurchaseOrderHistoryEntity FetchPolymorphicUsingUCReferenceOrderIDReferenceOrderLineID(ITransaction transactionToUse, System.Int32 referenceOrderID, System.Int32 referenceOrderLineID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return new PurchaseOrderHistoryDAO().FetchPurchaseOrderHistoryPolyUsingUCReferenceOrderIDReferenceOrderLineID(transactionToUse, referenceOrderID, referenceOrderLineID, contextToUse, excludedIncludedFields);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new PurchaseOrderHistoryEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 transactionID, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, transactionID, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static new PurchaseOrderHistoryEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 transactionID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.PurchaseOrderHistoryEntity);
			fields.ForcedValueWrite((int)PurchaseOrderHistoryFieldIndex.TransactionID, transactionID);
			return (PurchaseOrderHistoryEntity)new PurchaseOrderHistoryDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}


		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the AW.Data.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("PurchaseOrderHistoryEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderHistoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public PurchaseOrderHeaderEntity GetSinglePurchaseOrder()
		{
			return GetSinglePurchaseOrder(false);
		}

		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderHeaderEntity GetSinglePurchaseOrder(bool forceFetch)
		{
			if( ( !_alreadyFetchedPurchaseOrder || forceFetch || _alwaysFetchPurchaseOrder) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.PurchaseOrderHeaderEntityUsingReferenceOrderID);
				PurchaseOrderHeaderEntity newEntity = new PurchaseOrderHeaderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ReferenceOrderID);
				}
				if(fetchResult)
				{
					newEntity = (PurchaseOrderHeaderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_purchaseOrderReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.PurchaseOrder = newEntity;
				_alreadyFetchedPurchaseOrder = fetchResult;
			}
			return _purchaseOrder;
		}

		/// <summary> Retrieves the related entity of type 'PurchaseOrderDetailEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'PurchaseOrderDetailEntity' which is related to this entity.</returns>
		public PurchaseOrderDetailEntity GetSinglePurchaseOrderDetail()
		{
			return GetSinglePurchaseOrderDetail(false);
		}
		
		/// <summary> Retrieves the related entity of type 'PurchaseOrderDetailEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PurchaseOrderDetailEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderDetailEntity GetSinglePurchaseOrderDetail(bool forceFetch)
		{
			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode )
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.PurchaseOrderDetailEntityUsingReferenceOrderLineIDReferenceOrderID);
				PurchaseOrderDetailEntity newEntity = new PurchaseOrderDetailEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ReferenceOrderLineID, this.ReferenceOrderID);
				}
				if(fetchResult)
				{
					newEntity = (PurchaseOrderDetailEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_purchaseOrderDetailReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.PurchaseOrderDetail = newEntity;
				_alreadyFetchedPurchaseOrderDetail = fetchResult;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = base.GetRelatedData();
			toReturn.Add("PurchaseOrder", _purchaseOrder);
			toReturn.Add("PurchaseOrderDetail", _purchaseOrderDetail);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			InitClassMembers();
			if(this.Fields.State==EntityState.New)
			{
				this.Fields.ForcedValueWrite((int)PurchaseOrderHistoryFieldIndex.TransactionType, "P");
			}
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="transactionID">PK value for PurchaseOrderHistory which data should be fetched into this PurchaseOrderHistory object</param>
		/// <param name="validator">The validator object for this PurchaseOrderHistoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 transactionID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers();	
			if(this.Fields.State==EntityState.New)
			{
				this.Fields.ForcedValueWrite((int)PurchaseOrderHistoryFieldIndex.TransactionType, "P");
			}
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_purchaseOrderReturnsNewIfNotFound = true;
			_purchaseOrderDetailReturnsNewIfNotFound = true;

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

		/// <summary> Removes the sync logic for member _purchaseOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPurchaseOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _purchaseOrder, new PropertyChangedEventHandler( OnPurchaseOrderPropertyChanged ), "PurchaseOrder", AW.Data.RelationClasses.StaticPurchaseOrderHistoryRelations.PurchaseOrderHeaderEntityUsingReferenceOrderIDStatic, true, signalRelatedEntity, "PurchaseOrderHistories", resetFKFields, new int[] { (int)PurchaseOrderHistoryFieldIndex.ReferenceOrderID } );		
			_purchaseOrder = null;
		}
		
		/// <summary> setups the sync logic for member _purchaseOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPurchaseOrder(IEntityCore relatedEntity)
		{
			if(_purchaseOrder!=relatedEntity)
			{		
				DesetupSyncPurchaseOrder(true, true);
				_purchaseOrder = (PurchaseOrderHeaderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _purchaseOrder, new PropertyChangedEventHandler( OnPurchaseOrderPropertyChanged ), "PurchaseOrder", AW.Data.RelationClasses.StaticPurchaseOrderHistoryRelations.PurchaseOrderHeaderEntityUsingReferenceOrderIDStatic, true, ref _alreadyFetchedPurchaseOrder, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPurchaseOrderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _purchaseOrderDetail</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPurchaseOrderDetail(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _purchaseOrderDetail, new PropertyChangedEventHandler( OnPurchaseOrderDetailPropertyChanged ), "PurchaseOrderDetail", AW.Data.RelationClasses.StaticPurchaseOrderHistoryRelations.PurchaseOrderDetailEntityUsingReferenceOrderLineIDReferenceOrderIDStatic, true, signalRelatedEntity, "PurchaseOrderHistory", resetFKFields, new int[] { (int)PurchaseOrderHistoryFieldIndex.ReferenceOrderLineID, (int)PurchaseOrderHistoryFieldIndex.ReferenceOrderID } );
			_purchaseOrderDetail = null;
		}
	
		/// <summary> setups the sync logic for member _purchaseOrderDetail</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPurchaseOrderDetail(IEntityCore relatedEntity)
		{
			if(_purchaseOrderDetail!=relatedEntity)
			{
				DesetupSyncPurchaseOrderDetail(true, true);
				_purchaseOrderDetail = (PurchaseOrderDetailEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _purchaseOrderDetail, new PropertyChangedEventHandler( OnPurchaseOrderDetailPropertyChanged ), "PurchaseOrderDetail", AW.Data.RelationClasses.StaticPurchaseOrderHistoryRelations.PurchaseOrderDetailEntityUsingReferenceOrderLineIDReferenceOrderIDStatic, true, ref _alreadyFetchedPurchaseOrderDetail, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPurchaseOrderDetailPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			return DAOFactory.CreatePurchaseOrderHistoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PurchaseOrderHistoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public new static PurchaseOrderHistoryRelations Relations
		{
			get	{ return new PurchaseOrderHistoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public new static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrder
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrder")[0], (int)AW.Data.EntityType.PurchaseOrderHistoryEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderDetail
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderDetail")[0], (int)AW.Data.EntityType.PurchaseOrderHistoryEntity, (int)AW.Data.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, "PurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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


		/// <summary> Gets / sets related entity of type 'PurchaseOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePurchaseOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PurchaseOrderHeaderEntity PurchaseOrder
		{
			get	{ return GetSinglePurchaseOrder(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncPurchaseOrder(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHistories", "PurchaseOrder", _purchaseOrder, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrder. When set to true, PurchaseOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrder is accessed. You can always execute a forced fetch by calling GetSinglePurchaseOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrder
		{
			get	{ return _alwaysFetchPurchaseOrder; }
			set	{ _alwaysFetchPurchaseOrder = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrder already has been fetched. Setting this property to false when PurchaseOrder has been fetched
		/// will set PurchaseOrder to null as well. Setting this property to true while PurchaseOrder hasn't been fetched disables lazy loading for PurchaseOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrder
		{
			get { return _alreadyFetchedPurchaseOrder;}
			set 
			{
				if(_alreadyFetchedPurchaseOrder && !value)
				{
					this.PurchaseOrder = null;
				}
				_alreadyFetchedPurchaseOrder = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property PurchaseOrder is not found
		/// in the database. When set to true, PurchaseOrder will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool PurchaseOrderReturnsNewIfNotFound
		{
			get	{ return _purchaseOrderReturnsNewIfNotFound; }
			set { _purchaseOrderReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'PurchaseOrderDetailEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/></summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PurchaseOrderDetailEntity PurchaseOrderDetail
		{
			get	{ return GetSinglePurchaseOrderDetail(false); }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPurchaseOrderDetail(value);
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_purchaseOrderDetail !=null);
						DesetupSyncPurchaseOrderDetail(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("PurchaseOrderDetail");
						}
					}
					else
					{
						if(_purchaseOrderDetail!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHistory");
							SetupSyncPurchaseOrderDetail(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderDetail. When set to true, PurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetail is accessed. You can always execute a forced fetch by calling GetSinglePurchaseOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetail
		{
			get	{ return _alwaysFetchPurchaseOrderDetail; }
			set	{ _alwaysFetchPurchaseOrderDetail = value; }	
		}
		
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderDetail already has been fetched. Setting this property to false when PurchaseOrderDetail has been fetched
		/// will set PurchaseOrderDetail to null as well. Setting this property to true while PurchaseOrderDetail hasn't been fetched disables lazy loading for PurchaseOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderDetail
		{
			get { return _alreadyFetchedPurchaseOrderDetail;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderDetail && !value)
				{
					this.PurchaseOrderDetail = null;
				}
				_alreadyFetchedPurchaseOrderDetail = value;
			}
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property PurchaseOrderDetail is not found
		/// in the database. When set to true, PurchaseOrderDetail will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool PurchaseOrderDetailReturnsNewIfNotFound
		{
			get	{ return _purchaseOrderDetailReturnsNewIfNotFound; }
			set	{ _purchaseOrderDetailReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.PurchaseOrderHistoryEntity; }
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
