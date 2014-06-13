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

	/// <summary>Entity class which represents the entity 'PurchaseOrderDetail'. <br/><br/>
	/// 
	/// MS_Description: Individual products associated with a specific purchase order. See PurchaseOrderHeader.<br/>
	/// </summary>
	[Serializable]
	public partial class PurchaseOrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private PurchaseOrderHeaderEntity _purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader, _purchaseOrderHeaderReturnsNewIfNotFound;

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
			/// <summary>Member name PurchaseOrderHeader</summary>
			public static readonly string PurchaseOrderHeader = "PurchaseOrderHeader";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderDetailEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PurchaseOrderDetailEntity() :base("PurchaseOrderDetailEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID):base("PurchaseOrderDetailEntity")
		{
			InitClassFetch(purchaseOrderDetailID, purchaseOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse):base("PurchaseOrderDetailEntity")
		{
			InitClassFetch(purchaseOrderDetailID, purchaseOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IValidator validator):base("PurchaseOrderDetailEntity")
		{
			InitClassFetch(purchaseOrderDetailID, purchaseOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_purchaseOrderHeader = (PurchaseOrderHeaderEntity)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderEntity));
			if(_purchaseOrderHeader!=null)
			{
				_purchaseOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_purchaseOrderHeaderReturnsNewIfNotFound = info.GetBoolean("_purchaseOrderHeaderReturnsNewIfNotFound");
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((PurchaseOrderDetailFieldIndex)fieldIndex)
			{
				case PurchaseOrderDetailFieldIndex.ProductID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				case PurchaseOrderDetailFieldIndex.PurchaseOrderID:
					DesetupSyncPurchaseOrderHeader(true, false);
					_alreadyFetchedPurchaseOrderHeader = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader != null);
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
				case "PurchaseOrderHeader":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
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
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_productReturnsNewIfNotFound", _productReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_purchaseOrderHeader", (!this.MarkedForDeletion?_purchaseOrderHeader:null));
			info.AddValue("_purchaseOrderHeaderReturnsNewIfNotFound", _purchaseOrderHeaderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);

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
				case "PurchaseOrderHeader":
					_alreadyFetchedPurchaseOrderHeader = true;
					this.PurchaseOrderHeader = (PurchaseOrderHeaderEntity)entity;
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
				case "PurchaseOrderHeader":
					SetupSyncPurchaseOrderHeader(relatedEntity);
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
				case "PurchaseOrderHeader":
					DesetupSyncPurchaseOrderHeader(false, true);
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
			if(_purchaseOrderHeader!=null)
			{
				toReturn.Add(_purchaseOrderHeader);
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
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID)
		{
			return FetchUsingPK(purchaseOrderDetailID, purchaseOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(purchaseOrderDetailID, purchaseOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(purchaseOrderDetailID, purchaseOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(purchaseOrderDetailID, purchaseOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.PurchaseOrderDetailID, this.PurchaseOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderDetailRelations().GetAllRelations();
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


		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader()
		{
			return GetSinglePurchaseOrderHeader(false);
		}

		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader(bool forceFetch)
		{
			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
				PurchaseOrderHeaderEntity newEntity = new PurchaseOrderHeaderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.PurchaseOrderID);
				}
				if(fetchResult)
				{
					newEntity = (PurchaseOrderHeaderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_purchaseOrderHeaderReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.PurchaseOrderHeader = newEntity;
				_alreadyFetchedPurchaseOrderHeader = fetchResult;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("PurchaseOrderHeader", _purchaseOrderHeader);
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
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The validator object for this PurchaseOrderDetailEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(purchaseOrderDetailID, purchaseOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productReturnsNewIfNotFound = true;
			_purchaseOrderHeaderReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Individual products associated with a specific purchase order. See PurchaseOrderHeader.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product is expected to be received.");
			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Per product subtotal. Computed as OrderQty * UnitPrice.");
			_fieldsCustomProperties.Add("LineTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity ordered.");
			_fieldsCustomProperties.Add("OrderQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product identification number. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. One line number per purchased product.");
			_fieldsCustomProperties.Add("PurchaseOrderDetailID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("PurchaseOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity actually received from the vendor.");
			_fieldsCustomProperties.Add("ReceivedQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity rejected during inspection.");
			_fieldsCustomProperties.Add("RejectedQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.");
			_fieldsCustomProperties.Add("StockedQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor's selling price of a single product.");
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AW.Data.RelationClasses.StaticPurchaseOrderDetailRelations.ProductEntityUsingProductIDStatic, true, signalRelatedEntity, "PurchaseOrderDetails", resetFKFields, new int[] { (int)PurchaseOrderDetailFieldIndex.ProductID } );		
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
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AW.Data.RelationClasses.StaticPurchaseOrderDetailRelations.ProductEntityUsingProductIDStatic, true, ref _alreadyFetchedProduct, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _purchaseOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPurchaseOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _purchaseOrderHeader, new PropertyChangedEventHandler( OnPurchaseOrderHeaderPropertyChanged ), "PurchaseOrderHeader", AW.Data.RelationClasses.StaticPurchaseOrderDetailRelations.PurchaseOrderHeaderEntityUsingPurchaseOrderIDStatic, true, signalRelatedEntity, "PurchaseOrderDetails", resetFKFields, new int[] { (int)PurchaseOrderDetailFieldIndex.PurchaseOrderID } );		
			_purchaseOrderHeader = null;
		}
		
		/// <summary> setups the sync logic for member _purchaseOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPurchaseOrderHeader(IEntityCore relatedEntity)
		{
			if(_purchaseOrderHeader!=relatedEntity)
			{		
				DesetupSyncPurchaseOrderHeader(true, true);
				_purchaseOrderHeader = (PurchaseOrderHeaderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _purchaseOrderHeader, new PropertyChangedEventHandler( OnPurchaseOrderHeaderPropertyChanged ), "PurchaseOrderHeader", AW.Data.RelationClasses.StaticPurchaseOrderDetailRelations.PurchaseOrderHeaderEntityUsingPurchaseOrderIDStatic, true, ref _alreadyFetchedPurchaseOrderHeader, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPurchaseOrderHeaderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 purchaseOrderDetailID, System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID].ForcedCurrentValueWrite(purchaseOrderDetailID);
				this.Fields[(int)PurchaseOrderDetailFieldIndex.PurchaseOrderID].ForcedCurrentValueWrite(purchaseOrderID);
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
			return DAOFactory.CreatePurchaseOrderDetailDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PurchaseOrderDetailEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PurchaseOrderDetailRelations Relations
		{
			get	{ return new PurchaseOrderDetailRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.PurchaseOrderDetailEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeader
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderHeader")[0], (int)AW.Data.EntityType.PurchaseOrderDetailEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The DueDate property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Date the product is expected to be received.<br/>Date the product is expected to be received.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.DueDate, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.DueDate, value, true); }
		}

		/// <summary> The LineTotal property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Per product subtotal. Computed as OrderQty * UnitPrice.<br/>Per product subtotal. Computed as OrderQty * UnitPrice.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."LineTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.LineTotal, true); }

		}

		/// <summary> The ModifiedDate property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OrderQuantity property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Quantity ordered.<br/>Quantity ordered.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."OrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQuantity
		{
			get { return (System.Int16)GetValue((int)PurchaseOrderDetailFieldIndex.OrderQuantity, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.OrderQuantity, value, true); }
		}

		/// <summary> The ProductID property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Product identification number. Foreign key to Product.ProductID.<br/>Product identification number. Foreign key to Product.ProductID.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.ProductID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ProductID, value, true); }
		}

		/// <summary> The PurchaseOrderDetailID property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Primary key. One line number per purchased product.<br/>Primary key. One line number per purchased product.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderDetailID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderDetailID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, value, true); }
		}

		/// <summary> The PurchaseOrderID property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PurchaseOrderID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, value, true); }
		}

		/// <summary> The ReceivedQuantity property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Quantity actually received from the vendor.<br/>Quantity actually received from the vendor.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ReceivedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ReceivedQuantity
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQuantity, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQuantity, value, true); }
		}

		/// <summary> The RejectedQuantity property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Quantity rejected during inspection.<br/>Quantity rejected during inspection.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."RejectedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal RejectedQuantity
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.RejectedQuantity, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.RejectedQuantity, value, true); }
		}

		/// <summary> The StockedQuantity property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.<br/>Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."StockedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StockedQuantity
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.StockedQuantity, true); }

		}

		/// <summary> The UnitPrice property of the Entity PurchaseOrderDetail<br/><br/>
		/// MS_Description: Vendor's selling price of a single product.<br/>Vendor's selling price of a single product.</summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, value, true); }
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
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderDetails", "Product", _product, true); 
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

		/// <summary> Gets / sets related entity of type 'PurchaseOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PurchaseOrderHeaderEntity PurchaseOrderHeader
		{
			get	{ return GetSinglePurchaseOrderHeader(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncPurchaseOrderHeader(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderDetails", "PurchaseOrderHeader", _purchaseOrderHeader, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute a forced fetch by calling GetSinglePurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get	{ return _alwaysFetchPurchaseOrderHeader; }
			set	{ _alwaysFetchPurchaseOrderHeader = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeader already has been fetched. Setting this property to false when PurchaseOrderHeader has been fetched
		/// will set PurchaseOrderHeader to null as well. Setting this property to true while PurchaseOrderHeader hasn't been fetched disables lazy loading for PurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeader
		{
			get { return _alreadyFetchedPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeader && !value)
				{
					this.PurchaseOrderHeader = null;
				}
				_alreadyFetchedPurchaseOrderHeader = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property PurchaseOrderHeader is not found
		/// in the database. When set to true, PurchaseOrderHeader will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool PurchaseOrderHeaderReturnsNewIfNotFound
		{
			get	{ return _purchaseOrderHeaderReturnsNewIfNotFound; }
			set { _purchaseOrderHeaderReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.PurchaseOrderDetailEntity; }
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
