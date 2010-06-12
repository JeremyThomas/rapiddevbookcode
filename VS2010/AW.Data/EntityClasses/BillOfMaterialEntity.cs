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

	/// <summary>Entity class which represents the entity 'BillOfMaterial'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BillOfMaterialEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private ProductEntity _product_;
		private bool	_alwaysFetchProduct_, _alreadyFetchedProduct_, _product_ReturnsNewIfNotFound;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure, _unitMeasureReturnsNewIfNotFound;

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
			/// <summary>Member name Product_</summary>
			public static readonly string Product_ = "Product_";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BillOfMaterialEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BillOfMaterialEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID)
		{
			InitClassFetch(billOfMaterialsID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(billOfMaterialsID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="validator">The custom validator object for this BillOfMaterialEntity</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID, IValidator validator)
		{
			InitClassFetch(billOfMaterialsID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BillOfMaterialEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_product_ = (ProductEntity)info.GetValue("_product_", typeof(ProductEntity));
			if(_product_!=null)
			{
				_product_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_product_ReturnsNewIfNotFound = info.GetBoolean("_product_ReturnsNewIfNotFound");
			_alwaysFetchProduct_ = info.GetBoolean("_alwaysFetchProduct_");
			_alreadyFetchedProduct_ = info.GetBoolean("_alreadyFetchedProduct_");

			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_unitMeasureReturnsNewIfNotFound = info.GetBoolean("_unitMeasureReturnsNewIfNotFound");
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((BillOfMaterialFieldIndex)fieldIndex)
			{
				case BillOfMaterialFieldIndex.ComponentID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				case BillOfMaterialFieldIndex.ProductAssemblyID:
					DesetupSyncProduct_(true, false);
					_alreadyFetchedProduct_ = false;
					break;
				case BillOfMaterialFieldIndex.UnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					_alreadyFetchedUnitMeasure = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedProduct_ = (_product_ != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);
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
					toReturn.Add(Relations.ProductEntityUsingComponentID);
					break;
				case "Product_":
					toReturn.Add(Relations.ProductEntityUsingProductAssemblyID);
					break;
				case "UnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingUnitMeasureCode);
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
			info.AddValue("_product_", (!this.MarkedForDeletion?_product_:null));
			info.AddValue("_product_ReturnsNewIfNotFound", _product_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct_", _alwaysFetchProduct_);
			info.AddValue("_alreadyFetchedProduct_", _alreadyFetchedProduct_);
			info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
			info.AddValue("_unitMeasureReturnsNewIfNotFound", _unitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);

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
				case "Product":
					_alreadyFetchedProduct = true;
					this.Product = (ProductEntity)entity;
					break;
				case "Product_":
					_alreadyFetchedProduct_ = true;
					this.Product_ = (ProductEntity)entity;
					break;
				case "UnitMeasure":
					_alreadyFetchedUnitMeasure = true;
					this.UnitMeasure = (UnitMeasureEntity)entity;
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
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "Product_":
					SetupSyncProduct_(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
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
				case "Product":
					DesetupSyncProduct(false, true);
					break;
				case "Product_":
					DesetupSyncProduct_(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
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
			if(_product_!=null)
			{
				toReturn.Add(_product_);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
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
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID)
		{
			return FetchUsingPK(billOfMaterialsID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(billOfMaterialsID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(billOfMaterialsID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(billOfMaterialsID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BillOfMaterialsID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BillOfMaterialRelations().GetAllRelations();
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
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingComponentID);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ComponentID);
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


		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProduct_()
		{
			return GetSingleProduct_(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct_(bool forceFetch)
		{
			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingProductAssemblyID);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductAssemblyID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_product_ReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Product_ = newEntity;
				_alreadyFetchedProduct_ = fetchResult;
			}
			return _product_;
		}


		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public UnitMeasureEntity GetSingleUnitMeasure()
		{
			return GetSingleUnitMeasure(false);
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure(bool forceFetch)
		{
			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UnitMeasureEntityUsingUnitMeasureCode);
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.UnitMeasureCode);
				}
				if(fetchResult)
				{
					newEntity = (UnitMeasureEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_unitMeasureReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.UnitMeasure = newEntity;
				_alreadyFetchedUnitMeasure = fetchResult;
			}
			return _unitMeasure;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_product!=null)
			{
				_product.ActiveContext = this.ActiveContext;
			}
			if(_product_!=null)
			{
				_product_.ActiveContext = this.ActiveContext;
			}
			if(_unitMeasure!=null)
			{
				_unitMeasure.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("Product_", _product_);
			toReturn.Add("UnitMeasure", _unitMeasure);
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
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="validator">The validator object for this BillOfMaterialEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 billOfMaterialsID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(billOfMaterialsID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{			_productReturnsNewIfNotFound = true;
			_product_ReturnsNewIfNotFound = true;
			_unitMeasureReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("BillOfMaterialsID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Bomlevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ComponentID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PerAssemblyQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductAssemblyID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", BillOfMaterialEntity.Relations.ProductEntityUsingComponentID, true, signalRelatedEntity, "BillOfMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ComponentID } );		
			_product = null;
		}
		
		/// <summary> setups the sync logic for member _product</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntity relatedEntity)
		{
			if(_product!=relatedEntity)
			{		
				DesetupSyncProduct(true, true);
				_product = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", BillOfMaterialEntity.Relations.ProductEntityUsingComponentID, true, ref _alreadyFetchedProduct, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _product_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct_(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product_, new PropertyChangedEventHandler( OnProduct_PropertyChanged ), "Product_", BillOfMaterialEntity.Relations.ProductEntityUsingProductAssemblyID, true, signalRelatedEntity, "BillOfMaterials_", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ProductAssemblyID } );		
			_product_ = null;
		}
		
		/// <summary> setups the sync logic for member _product_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct_(IEntity relatedEntity)
		{
			if(_product_!=relatedEntity)
			{		
				DesetupSyncProduct_(true, true);
				_product_ = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product_, new PropertyChangedEventHandler( OnProduct_PropertyChanged ), "Product_", BillOfMaterialEntity.Relations.ProductEntityUsingProductAssemblyID, true, ref _alreadyFetchedProduct_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProduct_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", BillOfMaterialEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, true, signalRelatedEntity, "BillOfMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.UnitMeasureCode } );		
			_unitMeasure = null;
		}
		
		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntity relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{		
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", BillOfMaterialEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, true, ref _alreadyFetchedUnitMeasure, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)BillOfMaterialFieldIndex.BillOfMaterialsID].ForcedCurrentValueWrite(billOfMaterialsID);
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
			return DAOFactory.CreateBillOfMaterialDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BillOfMaterialEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BillOfMaterialRelations Relations
		{
			get	{ return new BillOfMaterialRelations(); }
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
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct_
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product_")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasure
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), (IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "BillOfMaterialEntity";}
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

		/// <summary> The BillOfMaterialsID property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BillOfMaterialsID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BillOfMaterialsID
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsID, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsID, value, true); }
		}

		/// <summary> The Bomlevel property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BOMLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Bomlevel
		{
			get { return (System.Int16)GetValue((int)BillOfMaterialFieldIndex.Bomlevel, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.Bomlevel, value, true); }
		}

		/// <summary> The ComponentID property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ComponentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ComponentID
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.ComponentID, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ComponentID, value, true); }
		}

		/// <summary> The EndDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)BillOfMaterialFieldIndex.EndDate, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.EndDate, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The PerAssemblyQuantity property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."PerAssemblyQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PerAssemblyQuantity
		{
			get { return (System.Decimal)GetValue((int)BillOfMaterialFieldIndex.PerAssemblyQuantity, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.PerAssemblyQuantity, value, true); }
		}

		/// <summary> The ProductAssemblyID property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ProductAssemblyID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductAssemblyID
		{
			get { return (Nullable<System.Int32>)GetValue((int)BillOfMaterialFieldIndex.ProductAssemblyID, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ProductAssemblyID, value, true); }
		}

		/// <summary> The StartDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.StartDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.StartDate, value, true); }
		}

		/// <summary> The UnitMeasureCode property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
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
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials", "Product", _product, true); 
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

		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductEntity Product_
		{
			get	{ return GetSingleProduct_(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProduct_(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials_", "Product_", _product_, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Product_. When set to true, Product_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product_ is accessed. You can always execute a forced fetch by calling GetSingleProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct_
		{
			get	{ return _alwaysFetchProduct_; }
			set	{ _alwaysFetchProduct_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product_ already has been fetched. Setting this property to false when Product_ has been fetched
		/// will set Product_ to null as well. Setting this property to true while Product_ hasn't been fetched disables lazy loading for Product_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct_
		{
			get { return _alreadyFetchedProduct_;}
			set 
			{
				if(_alreadyFetchedProduct_ && !value)
				{
					this.Product_ = null;
				}
				_alreadyFetchedProduct_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Product_ is not found
		/// in the database. When set to true, Product_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Product_ReturnsNewIfNotFound
		{
			get	{ return _product_ReturnsNewIfNotFound; }
			set { _product_ReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return GetSingleUnitMeasure(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials", "UnitMeasure", _unitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute a forced fetch by calling GetSingleUnitMeasure(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure
		{
			get	{ return _alwaysFetchUnitMeasure; }
			set	{ _alwaysFetchUnitMeasure = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasure already has been fetched. Setting this property to false when UnitMeasure has been fetched
		/// will set UnitMeasure to null as well. Setting this property to true while UnitMeasure hasn't been fetched disables lazy loading for UnitMeasure</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasure
		{
			get { return _alreadyFetchedUnitMeasure;}
			set 
			{
				if(_alreadyFetchedUnitMeasure && !value)
				{
					this.UnitMeasure = null;
				}
				_alreadyFetchedUnitMeasure = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UnitMeasure is not found
		/// in the database. When set to true, UnitMeasure will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UnitMeasureReturnsNewIfNotFound
		{
			get	{ return _unitMeasureReturnsNewIfNotFound; }
			set { _unitMeasureReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.BillOfMaterialEntity; }
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
