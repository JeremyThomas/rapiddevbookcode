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

	/// <summary>Entity class which represents the entity 'PurchaseOrderHeader'. <br/><br/>
	/// 
	/// MS_Description: General purchase order information. See PurchaseOrderDetail.<br/>
	/// </summary>
	[Serializable]
	public partial class PurchaseOrderHeaderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.PurchaseOrderDetailCollection	_purchaseOrderDetails;
		private bool	_alwaysFetchPurchaseOrderDetails, _alreadyFetchedPurchaseOrderDetails;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod, _shipMethodReturnsNewIfNotFound;
		private VendorEntity _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor, _vendorReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ShipMethod</summary>
			public static readonly string ShipMethod = "ShipMethod";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
			/// <summary>Member name PurchaseOrderDetails</summary>
			public static readonly string PurchaseOrderDetails = "PurchaseOrderDetails";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderHeaderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PurchaseOrderHeaderEntity() :base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID):base("PurchaseOrderHeaderEntity")
		{
			InitClassFetch(purchaseOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse):base("PurchaseOrderHeaderEntity")
		{
			InitClassFetch(purchaseOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, IValidator validator):base("PurchaseOrderHeaderEntity")
		{
			InitClassFetch(purchaseOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_purchaseOrderDetails = (AW.Data.CollectionClasses.PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetails", typeof(AW.Data.CollectionClasses.PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetails = info.GetBoolean("_alwaysFetchPurchaseOrderDetails");
			_alreadyFetchedPurchaseOrderDetails = info.GetBoolean("_alreadyFetchedPurchaseOrderDetails");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shipMethodReturnsNewIfNotFound = info.GetBoolean("_shipMethodReturnsNewIfNotFound");
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
			if(_vendor!=null)
			{
				_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_vendorReturnsNewIfNotFound = info.GetBoolean("_vendorReturnsNewIfNotFound");
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((PurchaseOrderHeaderFieldIndex)fieldIndex)
			{
				case PurchaseOrderHeaderFieldIndex.EmployeeID:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case PurchaseOrderHeaderFieldIndex.ShipMethodID:
					DesetupSyncShipMethod(true, false);
					_alreadyFetchedShipMethod = false;
					break;
				case PurchaseOrderHeaderFieldIndex.VendorID:
					DesetupSyncVendor(true, false);
					_alreadyFetchedVendor = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedPurchaseOrderDetails = (_purchaseOrderDetails.Count > 0);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);
			_alreadyFetchedVendor = (_vendor != null);
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
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeID);
					break;
				case "ShipMethod":
					toReturn.Add(Relations.ShipMethodEntityUsingShipMethodID);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorID);
					break;
				case "PurchaseOrderDetails":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingPurchaseOrderID);
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
			info.AddValue("_purchaseOrderDetails", (!this.MarkedForDeletion?_purchaseOrderDetails:null));
			info.AddValue("_alwaysFetchPurchaseOrderDetails", _alwaysFetchPurchaseOrderDetails);
			info.AddValue("_alreadyFetchedPurchaseOrderDetails", _alreadyFetchedPurchaseOrderDetails);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shipMethod", (!this.MarkedForDeletion?_shipMethod:null));
			info.AddValue("_shipMethodReturnsNewIfNotFound", _shipMethodReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			info.AddValue("_vendorReturnsNewIfNotFound", _vendorReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);

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
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ShipMethod":
					_alreadyFetchedShipMethod = true;
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "Vendor":
					_alreadyFetchedVendor = true;
					this.Vendor = (VendorEntity)entity;
					break;
				case "PurchaseOrderDetails":
					_alreadyFetchedPurchaseOrderDetails = true;
					if(entity!=null)
					{
						this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)entity);
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
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
					break;
				case "PurchaseOrderDetails":
					_purchaseOrderDetails.Add((PurchaseOrderDetailEntity)relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
					break;
				case "PurchaseOrderDetails":
					this.PerformRelatedEntityRemoval(_purchaseOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_purchaseOrderDetails);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID)
		{
			return FetchUsingPK(purchaseOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(purchaseOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(purchaseOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(purchaseOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.PurchaseOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderHeaderRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, _purchaseOrderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, _purchaseOrderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetails || forceFetch || _alwaysFetchPurchaseOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_purchaseOrderDetails);
				_purchaseOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetails.GetMultiManyToOne(null, this, filter);
				_purchaseOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetails = true;
			}
			return _purchaseOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderDetails'. These settings will be taken into account
		/// when the property PurchaseOrderDetails is requested or GetMultiPurchaseOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetails.SortClauses=sortClauses;
			_purchaseOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.EmployeeEntityUsingEmployeeID);
				EmployeeEntity newEntity = (EmployeeEntity)GeneralEntityFactory.Create(AW.Data.EntityType.EmployeeEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = EmployeeEntity.FetchPolymorphic(this.Transaction, this.EmployeeID, this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (EmployeeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_employeeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Employee = newEntity;
				_alreadyFetchedEmployee = fetchResult;
			}
			return _employee;
		}


		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public ShipMethodEntity GetSingleShipMethod()
		{
			return GetSingleShipMethod(false);
		}

		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public virtual ShipMethodEntity GetSingleShipMethod(bool forceFetch)
		{
			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ShipMethodEntityUsingShipMethodID);
				ShipMethodEntity newEntity = new ShipMethodEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ShipMethodID);
				}
				if(fetchResult)
				{
					newEntity = (ShipMethodEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_shipMethodReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ShipMethod = newEntity;
				_alreadyFetchedShipMethod = fetchResult;
			}
			return _shipMethod;
		}


		/// <summary> Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public VendorEntity GetSingleVendor()
		{
			return GetSingleVendor(false);
		}

		/// <summary> Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public virtual VendorEntity GetSingleVendor(bool forceFetch)
		{
			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.VendorEntityUsingVendorID);
				VendorEntity newEntity = new VendorEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.VendorID);
				}
				if(fetchResult)
				{
					newEntity = (VendorEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_vendorReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Vendor = newEntity;
				_alreadyFetchedVendor = fetchResult;
			}
			return _vendor;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employee", _employee);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("Vendor", _vendor);
			toReturn.Add("PurchaseOrderDetails", _purchaseOrderDetails);
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
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The validator object for this PurchaseOrderHeaderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 purchaseOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(purchaseOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_purchaseOrderDetails = new AW.Data.CollectionClasses.PurchaseOrderDetailCollection();
			_purchaseOrderDetails.SetContainingEntityInfo(this, "PurchaseOrderHeader");
			_employeeReturnsNewIfNotFound = true;
			_shipMethodReturnsNewIfNotFound = true;
			_vendorReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"General purchase order information. See PurchaseOrderDetail.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Employee who created the purchase order. Foreign key to Employee.EmployeeID.");
			_fieldsCustomProperties.Add("EmployeeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping cost.");
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Purchase order creation date.");
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("PurchaseOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Incremental number to track changes to the purchase order over time.");
			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Estimated shipment date from the vendor.");
			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping method. Foreign key to ShipMethod.ShipMethodID.");
			_fieldsCustomProperties.Add("ShipMethodID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.");
			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Tax amount.");
			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Total due to vendor. Computed as Subtotal + TaxAmt + Freight.");
			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.EmployeeEntityUsingEmployeeIDStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.EmployeeID } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntityCore relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.EmployeeEntityUsingEmployeeIDStatic, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.ShipMethodEntityUsingShipMethodIDStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.ShipMethodID } );		
			_shipMethod = null;
		}
		
		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntityCore relatedEntity)
		{
			if(_shipMethod!=relatedEntity)
			{		
				DesetupSyncShipMethod(true, true);
				_shipMethod = (ShipMethodEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.ShipMethodEntityUsingShipMethodIDStatic, true, ref _alreadyFetchedShipMethod, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShipMethodPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.VendorEntityUsingVendorIDStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.VendorID } );		
			_vendor = null;
		}
		
		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{		
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AW.Data.RelationClasses.StaticPurchaseOrderHeaderRelations.VendorEntityUsingVendorIDStatic, true, ref _alreadyFetchedVendor, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID].ForcedCurrentValueWrite(purchaseOrderID);
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
			return DAOFactory.CreatePurchaseOrderHeaderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PurchaseOrderHeaderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PurchaseOrderHeaderRelations Relations
		{
			get	{ return new PurchaseOrderHeaderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderDetails
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderDetails")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, "PurchaseOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employee")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethod
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), (IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendor
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), (IEntityRelation)GetRelationsForField("Vendor")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The EmployeeID property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Employee who created the purchase order. Foreign key to Employee.EmployeeID.<br/>Employee who created the purchase order. Foreign key to Employee.EmployeeID.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmployeeID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID, value, true); }
		}

		/// <summary> The Freight property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Shipping cost.<br/>Shipping cost.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Freight, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OrderDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Purchase order creation date.<br/>Purchase order creation date.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, value, true); }
		}

		/// <summary> The PurchaseOrderID property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."PurchaseOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, value, true); }
		}

		/// <summary> The RevisionNumber property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Incremental number to track changes to the purchase order over time.<br/>Incremental number to track changes to the purchase order over time.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, value, true); }
		}

		/// <summary> The ShipDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Estimated shipment date from the vendor.<br/>Estimated shipment date from the vendor.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, value, true); }
		}

		/// <summary> The ShipMethodID property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Shipping method. Foreign key to ShipMethod.ShipMethodID.<br/>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID, value, true); }
		}

		/// <summary> The Status property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.PurchaseOrderStatus Status
		{
			get { return (AW.Data.PurchaseOrderStatus)GetValue((int)PurchaseOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Status, value, true); }
		}

		/// <summary> The SubTotal property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.<br/>Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, value, true); }
		}

		/// <summary> The TaxAmt property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Tax amount.<br/>Tax amount.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, value, true); }
		}

		/// <summary> The TotalDue property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Total due to vendor. Computed as Subtotal + TaxAmt + Freight.<br/>Total due to vendor. Computed as Subtotal + TaxAmt + Freight.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TotalDue, true); }

		}

		/// <summary> The VendorID property of the Entity PurchaseOrderHeader<br/><br/>
		/// MS_Description: Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.<br/>Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.VendorID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.VendorID, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection PurchaseOrderDetails
		{
			get	{ return GetMultiPurchaseOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderDetails. When set to true, PurchaseOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiPurchaseOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetails
		{
			get	{ return _alwaysFetchPurchaseOrderDetails; }
			set	{ _alwaysFetchPurchaseOrderDetails = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderDetails already has been fetched. Setting this property to false when PurchaseOrderDetails has been fetched
		/// will clear the PurchaseOrderDetails collection well. Setting this property to true while PurchaseOrderDetails hasn't been fetched disables lazy loading for PurchaseOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderDetails
		{
			get { return _alreadyFetchedPurchaseOrderDetails;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderDetails && !value && (_purchaseOrderDetails != null))
				{
					_purchaseOrderDetails.Clear();
				}
				_alreadyFetchedPurchaseOrderDetails = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "Employee", _employee, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ShipMethodEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return GetSingleShipMethod(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "ShipMethod", _shipMethod, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute a forced fetch by calling GetSingleShipMethod(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod
		{
			get	{ return _alwaysFetchShipMethod; }
			set	{ _alwaysFetchShipMethod = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethod already has been fetched. Setting this property to false when ShipMethod has been fetched
		/// will set ShipMethod to null as well. Setting this property to true while ShipMethod hasn't been fetched disables lazy loading for ShipMethod</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethod
		{
			get { return _alreadyFetchedShipMethod;}
			set 
			{
				if(_alreadyFetchedShipMethod && !value)
				{
					this.ShipMethod = null;
				}
				_alreadyFetchedShipMethod = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ShipMethod is not found
		/// in the database. When set to true, ShipMethod will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShipMethodReturnsNewIfNotFound
		{
			get	{ return _shipMethodReturnsNewIfNotFound; }
			set { _shipMethodReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'VendorEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get	{ return GetSingleVendor(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "Vendor", _vendor, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute a forced fetch by calling GetSingleVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendor
		{
			get	{ return _alwaysFetchVendor; }
			set	{ _alwaysFetchVendor = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Vendor already has been fetched. Setting this property to false when Vendor has been fetched
		/// will set Vendor to null as well. Setting this property to true while Vendor hasn't been fetched disables lazy loading for Vendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendor
		{
			get { return _alreadyFetchedVendor;}
			set 
			{
				if(_alreadyFetchedVendor && !value)
				{
					this.Vendor = null;
				}
				_alreadyFetchedVendor = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Vendor is not found
		/// in the database. When set to true, Vendor will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool VendorReturnsNewIfNotFound
		{
			get	{ return _vendorReturnsNewIfNotFound; }
			set { _vendorReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.PurchaseOrderHeaderEntity; }
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
