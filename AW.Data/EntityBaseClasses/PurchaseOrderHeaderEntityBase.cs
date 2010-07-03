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
	
	/// <summary>Entity base class which represents the base class for the entity 'PurchaseOrderHeader'.<br/><br/>
	/// 
	/// MS_Description: General purchase order information. See PurchaseOrderDetail.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class PurchaseOrderHeaderEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.PurchaseOrderDetailCollection	_purchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderDetail, _alreadyFetchedPurchaseOrderDetail;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaPurchaseOrderDetail;
		private bool	_alwaysFetchProductCollectionViaPurchaseOrderDetail, _alreadyFetchedProductCollectionViaPurchaseOrderDetail;
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
			/// <summary>Member name PurchaseOrderDetail</summary>
			public static readonly string PurchaseOrderDetail = "PurchaseOrderDetail";
			/// <summary>Member name ProductCollectionViaPurchaseOrderDetail</summary>
			public static readonly string ProductCollectionViaPurchaseOrderDetail = "ProductCollectionViaPurchaseOrderDetail";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderHeaderEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PurchaseOrderHeaderEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		public PurchaseOrderHeaderEntityBase(System.Int32 purchaseOrderID)
		{
			InitClassFetch(purchaseOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderHeaderEntityBase(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(purchaseOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		public PurchaseOrderHeaderEntityBase(System.Int32 purchaseOrderID, IValidator validator)
		{
			InitClassFetch(purchaseOrderID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderHeaderEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_purchaseOrderDetail = (AW.Data.CollectionClasses.PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetail", typeof(AW.Data.CollectionClasses.PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderDetail");
			_productCollectionViaPurchaseOrderDetail = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaPurchaseOrderDetail", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaPurchaseOrderDetail = info.GetBoolean("_alwaysFetchProductCollectionViaPurchaseOrderDetail");
			_alreadyFetchedProductCollectionViaPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedProductCollectionViaPurchaseOrderDetail");
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

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
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
				case PurchaseOrderHeaderFieldIndex.VendorID:
					DesetupSyncVendor(true, false);
					_alreadyFetchedVendor = false;
					break;
				case PurchaseOrderHeaderFieldIndex.ShipMethodID:
					DesetupSyncShipMethod(true, false);
					_alreadyFetchedShipMethod = false;
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
			_alreadyFetchedPurchaseOrderDetail = (_purchaseOrderDetail.Count > 0);
			_alreadyFetchedProductCollectionViaPurchaseOrderDetail = (_productCollectionViaPurchaseOrderDetail.Count > 0);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);
			_alreadyFetchedVendor = (_vendor != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return PurchaseOrderHeaderEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Employee":
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID);
					break;
				case "ShipMethod":
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);
					break;
				case "Vendor":
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID);
					break;
				case "PurchaseOrderDetail":
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.PurchaseOrderDetailEntityUsingPurchaseOrderID);
					break;
				case "ProductCollectionViaPurchaseOrderDetail":
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.PurchaseOrderDetailEntityUsingPurchaseOrderID, "PurchaseOrderHeaderEntity__", "PurchaseOrderDetail_", JoinHint.None);
					toReturn.Add(PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID, "PurchaseOrderDetail_", string.Empty, JoinHint.None);
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
			info.AddValue("_purchaseOrderDetail", (!this.MarkedForDeletion?_purchaseOrderDetail:null));
			info.AddValue("_alwaysFetchPurchaseOrderDetail", _alwaysFetchPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderDetail", _alreadyFetchedPurchaseOrderDetail);
			info.AddValue("_productCollectionViaPurchaseOrderDetail", (!this.MarkedForDeletion?_productCollectionViaPurchaseOrderDetail:null));
			info.AddValue("_alwaysFetchProductCollectionViaPurchaseOrderDetail", _alwaysFetchProductCollectionViaPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedProductCollectionViaPurchaseOrderDetail", _alreadyFetchedProductCollectionViaPurchaseOrderDetail);
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
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
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
				case "PurchaseOrderDetail":
					_alreadyFetchedPurchaseOrderDetail = true;
					if(entity!=null)
					{
						this.PurchaseOrderDetail.Add((PurchaseOrderDetailEntity)entity);
					}
					break;
				case "ProductCollectionViaPurchaseOrderDetail":
					_alreadyFetchedProductCollectionViaPurchaseOrderDetail = true;
					if(entity!=null)
					{
						this.ProductCollectionViaPurchaseOrderDetail.Add((ProductEntity)entity);
					}
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
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
					break;
				case "PurchaseOrderDetail":
					_purchaseOrderDetail.Add((PurchaseOrderDetailEntity)relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
					break;
				case "PurchaseOrderDetail":
					base.PerformRelatedEntityRemoval(_purchaseOrderDetail, relatedEntity, signalRelatedEntityManyToOne);
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
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_purchaseOrderDetail);

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
			return Fetch(purchaseOrderID, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.PurchaseOrderID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(PurchaseOrderHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(PurchaseOrderHeaderFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderHeaderRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, _purchaseOrderDetail.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, _purchaseOrderDetail.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_purchaseOrderDetail.GetMultiManyToOne(null, this, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderDetail'. These settings will be taken into account
		/// when the property PurchaseOrderDetail is requested or GetMultiPurchaseOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetail.SortClauses=sortClauses;
			_purchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaPurchaseOrderDetail(bool forceFetch)
		{
			return GetMultiProductCollectionViaPurchaseOrderDetail(forceFetch, _productCollectionViaPurchaseOrderDetail.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaPurchaseOrderDetail || forceFetch || _alwaysFetchProductCollectionViaPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaPurchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaPurchaseOrderDetail);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(PurchaseOrderHeaderFields.PurchaseOrderID, ComparisonOperator.Equal, this.PurchaseOrderID, "PurchaseOrderHeaderEntity__"));
				_productCollectionViaPurchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaPurchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaPurchaseOrderDetail.GetMulti(filter, GetRelationsForField("ProductCollectionViaPurchaseOrderDetail"));
				_productCollectionViaPurchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaPurchaseOrderDetail = true;
			}
			return _productCollectionViaPurchaseOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaPurchaseOrderDetail'. These settings will be taken into account
		/// when the property ProductCollectionViaPurchaseOrderDetail is requested or GetMultiProductCollectionViaPurchaseOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaPurchaseOrderDetail.SortClauses=sortClauses;
			_productCollectionViaPurchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.EmployeeID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee = newEntity;
				}
				else
				{
					if(_employeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee == null)))
						{
							this.Employee = newEntity;
						}
					}
					else
					{
						this.Employee = null;
					}
				}
				_alreadyFetchedEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);

				ShipMethodEntity newEntity = new ShipMethodEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ShipMethodID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ShipMethodEntity)base.ActiveContext.Get(newEntity);
					}
					this.ShipMethod = newEntity;
				}
				else
				{
					if(_shipMethodReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_shipMethod == null)))
						{
							this.ShipMethod = newEntity;
						}
					}
					else
					{
						this.ShipMethod = null;
					}
				}
				_alreadyFetchedShipMethod = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID);

				VendorEntity newEntity = new VendorEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.VendorID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (VendorEntity)base.ActiveContext.Get(newEntity);
					}
					this.Vendor = newEntity;
				}
				else
				{
					if(_vendorReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_vendor == null)))
						{
							this.Vendor = newEntity;
						}
					}
					else
					{
						this.Vendor = null;
					}
				}
				_alreadyFetchedVendor = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _vendor;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			PurchaseOrderHeaderDAO dao = (PurchaseOrderHeaderDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_purchaseOrderDetail.ActiveContext = base.ActiveContext;
			_productCollectionViaPurchaseOrderDetail.ActiveContext = base.ActiveContext;
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_shipMethod!=null)
			{
				_shipMethod.ActiveContext = base.ActiveContext;
			}
			if(_vendor!=null)
			{
				_vendor.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			PurchaseOrderHeaderDAO dao = (PurchaseOrderHeaderDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			PurchaseOrderHeaderDAO dao = (PurchaseOrderHeaderDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.PurchaseOrderHeaderEntity);
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
			toReturn.Add("Employee", _employee);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("Vendor", _vendor);
			toReturn.Add("PurchaseOrderDetail", _purchaseOrderDetail);
			toReturn.Add("ProductCollectionViaPurchaseOrderDetail", _productCollectionViaPurchaseOrderDetail);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The validator object for this PurchaseOrderHeaderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 purchaseOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(purchaseOrderID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_purchaseOrderDetail = new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(new PurchaseOrderDetailEntityFactory());
			_purchaseOrderDetail.SetContainingEntityInfo(this, "PurchaseOrderHeader");
			_alwaysFetchPurchaseOrderDetail = false;
			_alreadyFetchedPurchaseOrderDetail = false;
			_productCollectionViaPurchaseOrderDetail = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaPurchaseOrderDetail = false;
			_alreadyFetchedProductCollectionViaPurchaseOrderDetail = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_shipMethod = null;
			_shipMethodReturnsNewIfNotFound = true;
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_vendor = null;
			_vendorReturnsNewIfNotFound = true;
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;


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
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("PurchaseOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Incremental number to track changes to the purchase order over time.");
			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Employee who created the purchase order. Foreign key to Employee.EmployeeID.");
			_fieldsCustomProperties.Add("EmployeeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping method. Foreign key to ShipMethod.ShipMethodID.");
			_fieldsCustomProperties.Add("ShipMethodID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Purchase order creation date.");
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Estimated shipment date from the vendor.");
			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.");
			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Tax amount.");
			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping cost.");
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Total due to vendor. Computed as Subtotal + TaxAmt + Freight.");
			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID, true, signalRelatedEntity, "PurchaseOrderHeader", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.EmployeeID } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID, true, ref _alreadyFetchedEmployee, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, true, signalRelatedEntity, "PurchaseOrderHeader", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.ShipMethodID } );		
			_shipMethod = null;
		}
		
		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntity relatedEntity)
		{
			if(_shipMethod!=relatedEntity)
			{		
				DesetupSyncShipMethod(true, true);
				_shipMethod = (ShipMethodEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, true, ref _alreadyFetchedShipMethod, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID, true, signalRelatedEntity, "PurchaseOrderHeader", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.VendorID } );		
			_vendor = null;
		}
		
		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntity relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{		
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID, true, ref _alreadyFetchedVendor, new string[] {  } );
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
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID].ForcedCurrentValueWrite(purchaseOrderID);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderDetail
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(),
					(IEntityRelation)GetRelationsForField("PurchaseOrderDetail")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, "PurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaPurchaseOrderDetail
		{
			get
			{
				IEntityRelation intermediateRelation = PurchaseOrderHeaderEntity.Relations.PurchaseOrderDetailEntityUsingPurchaseOrderID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderDetail_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaPurchaseOrderDetail"), "ProductCollectionViaPurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethod
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(),
					(IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendor
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(),
					(IEntityRelation)GetRelationsForField("Vendor")[0], (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "PurchaseOrderHeaderEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return PurchaseOrderHeaderEntity.CustomProperties;}
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
			get { return PurchaseOrderHeaderEntity.FieldsCustomProperties;}
		}

		/// <summary> The PurchaseOrderID property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."PurchaseOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, value, true); }
		}
		/// <summary> The RevisionNumber property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Incremental number to track changes to the purchase order over time.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, value, true); }
		}
		/// <summary> The Status property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)PurchaseOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Status, value, true); }
		}
		/// <summary> The EmployeeID property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Employee who created the purchase order. Foreign key to Employee.EmployeeID.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmployeeID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID, value, true); }
		}
		/// <summary> The VendorID property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.VendorID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.VendorID, value, true); }
		}
		/// <summary> The ShipMethodID property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Shipping method. Foreign key to ShipMethod.ShipMethodID.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID, value, true); }
		}
		/// <summary> The OrderDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Purchase order creation date.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, value, true); }
		}
		/// <summary> The ShipDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Estimated shipment date from the vendor.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, value, true); }
		}
		/// <summary> The SubTotal property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, value, true); }
		}
		/// <summary> The TaxAmt property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Tax amount.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, value, true); }
		}
		/// <summary> The Freight property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Shipping cost.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Freight, value, true); }
		}
		/// <summary> The TotalDue property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Total due to vendor. Computed as Subtotal + TaxAmt + Freight.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TotalDue, true); }

		}
		/// <summary> The ModifiedDate property of the Entity PurchaseOrderHeader<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection PurchaseOrderDetail
		{
			get	{ return GetMultiPurchaseOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderDetail. When set to true, PurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetail
		{
			get	{ return _alwaysFetchPurchaseOrderDetail; }
			set	{ _alwaysFetchPurchaseOrderDetail = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderDetail already has been fetched. Setting this property to false when PurchaseOrderDetail has been fetched
		/// will clear the PurchaseOrderDetail collection well. Setting this property to true while PurchaseOrderDetail hasn't been fetched disables lazy loading for PurchaseOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderDetail
		{
			get { return _alreadyFetchedPurchaseOrderDetail;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderDetail && !value && (_purchaseOrderDetail != null))
				{
					_purchaseOrderDetail.Clear();
				}
				_alreadyFetchedPurchaseOrderDetail = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaPurchaseOrderDetail
		{
			get { return GetMultiProductCollectionViaPurchaseOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaPurchaseOrderDetail. When set to true, ProductCollectionViaPurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaPurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaPurchaseOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaPurchaseOrderDetail
		{
			get	{ return _alwaysFetchProductCollectionViaPurchaseOrderDetail; }
			set	{ _alwaysFetchProductCollectionViaPurchaseOrderDetail = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaPurchaseOrderDetail already has been fetched. Setting this property to false when ProductCollectionViaPurchaseOrderDetail has been fetched
		/// will clear the ProductCollectionViaPurchaseOrderDetail collection well. Setting this property to true while ProductCollectionViaPurchaseOrderDetail hasn't been fetched disables lazy loading for ProductCollectionViaPurchaseOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaPurchaseOrderDetail
		{
			get { return _alreadyFetchedProductCollectionViaPurchaseOrderDetail;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaPurchaseOrderDetail && !value && (_productCollectionViaPurchaseOrderDetail != null))
				{
					_productCollectionViaPurchaseOrderDetail.Clear();
				}
				_alreadyFetchedProductCollectionViaPurchaseOrderDetail = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee != null)
						{
							_employee.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return GetSingleShipMethod(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					if(value==null)
					{
						if(_shipMethod != null)
						{
							_shipMethod.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						if(_shipMethod!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetSingleShipMethod(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get	{ return GetSingleVendor(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					if(value==null)
					{
						if(_vendor != null)
						{
							_vendor.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						if(_vendor!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute
		/// a forced fetch by calling GetSingleVendor(true).</summary>
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
		public override int LLBLGenProEntityTypeValue 
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
