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
	
	/// <summary>Entity base class which represents the base class for the entity 'ProductVendor'.<br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping vendors with the products they supply.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductVendorEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure, _unitMeasureReturnsNewIfNotFound;
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
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductVendorEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductVendorEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		public ProductVendorEntityBase(System.Int32 productID, System.Int32 vendorID)
		{
			InitClassFetch(productID, vendorID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductVendorEntityBase(System.Int32 productID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productID, vendorID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="validator">The custom validator object for this ProductVendorEntity</param>
		public ProductVendorEntityBase(System.Int32 productID, System.Int32 vendorID, IValidator validator)
		{
			InitClassFetch(productID, vendorID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductVendorEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_unitMeasureReturnsNewIfNotFound = info.GetBoolean("_unitMeasureReturnsNewIfNotFound");
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");
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
			switch((ProductVendorFieldIndex)fieldIndex)
			{
				case ProductVendorFieldIndex.ProductID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				case ProductVendorFieldIndex.VendorID:
					DesetupSyncVendor(true, false);
					_alreadyFetchedVendor = false;
					break;
				case ProductVendorFieldIndex.UnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					_alreadyFetchedUnitMeasure = false;
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


			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);
			_alreadyFetchedVendor = (_vendor != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductVendorEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Product":
					toReturn.Add(ProductVendorEntity.Relations.ProductEntityUsingProductID);
					break;
				case "UnitMeasure":
					toReturn.Add(ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode);
					break;
				case "Vendor":
					toReturn.Add(ProductVendorEntity.Relations.VendorEntityUsingVendorID);
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


			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_productReturnsNewIfNotFound", _productReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
			info.AddValue("_unitMeasureReturnsNewIfNotFound", _unitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
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
				case "Product":
					_alreadyFetchedProduct = true;
					this.Product = (ProductEntity)entity;
					break;
				case "UnitMeasure":
					_alreadyFetchedUnitMeasure = true;
					this.UnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "Vendor":
					_alreadyFetchedVendor = true;
					this.Vendor = (VendorEntity)entity;
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
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
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
				case "Product":
					DesetupSyncProduct(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
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
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
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


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 vendorID)
		{
			return FetchUsingPK(productID, vendorID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productID, vendorID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productID, vendorID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productID, vendorID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductID, this.VendorID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductVendorFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductVendorFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductVendorRelations().GetAllRelations();
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
			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductVendorEntity.Relations.ProductEntityUsingProductID);

				ProductEntity newEntity = new ProductEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductEntity)base.ActiveContext.Get(newEntity);
					}
					this.Product = newEntity;
				}
				else
				{
					if(_productReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_product == null)))
						{
							this.Product = newEntity;
						}
					}
					else
					{
						this.Product = null;
					}
				}
				_alreadyFetchedProduct = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _product;
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
			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode);

				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.UnitMeasureCode);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UnitMeasureEntity)base.ActiveContext.Get(newEntity);
					}
					this.UnitMeasure = newEntity;
				}
				else
				{
					if(_unitMeasureReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_unitMeasure == null)))
						{
							this.UnitMeasure = newEntity;
						}
					}
					else
					{
						this.UnitMeasure = null;
					}
				}
				_alreadyFetchedUnitMeasure = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _unitMeasure;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductVendorEntity.Relations.VendorEntityUsingVendorID);

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
			ProductVendorDAO dao = (ProductVendorDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_product!=null)
			{
				_product.ActiveContext = base.ActiveContext;
			}
			if(_unitMeasure!=null)
			{
				_unitMeasure.ActiveContext = base.ActiveContext;
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
			ProductVendorDAO dao = (ProductVendorDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductVendorDAO dao = (ProductVendorDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductVendorEntity);
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
			toReturn.Add("Product", _product);
			toReturn.Add("UnitMeasure", _unitMeasure);
			toReturn.Add("Vendor", _vendor);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="validator">The validator object for this ProductVendorEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productID, System.Int32 vendorID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productID, vendorID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_product = null;
			_productReturnsNewIfNotFound = true;
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_unitMeasure = null;
			_unitMeasureReturnsNewIfNotFound = true;
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping vendors with the products they supply.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to Vendor.VendorID.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("AverageLeadTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The vendor's usual selling price.");
			_fieldsCustomProperties.Add("StandardPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The selling price when last purchased.");
			_fieldsCustomProperties.Add("LastReceiptCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was last received by the vendor.");
			_fieldsCustomProperties.Add("LastReceiptDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The maximum quantity that should be ordered.");
			_fieldsCustomProperties.Add("MinOrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The minimum quantity that should be ordered.");
			_fieldsCustomProperties.Add("MaxOrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The quantity currently on order.");
			_fieldsCustomProperties.Add("OnOrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"The product's unit of measure.");
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", ProductVendorEntity.Relations.ProductEntityUsingProductID, true, signalRelatedEntity, "ProductVendor", resetFKFields, new int[] { (int)ProductVendorFieldIndex.ProductID } );		
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
				base.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", ProductVendorEntity.Relations.ProductEntityUsingProductID, true, ref _alreadyFetchedProduct, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, true, signalRelatedEntity, "ProductVendor", resetFKFields, new int[] { (int)ProductVendorFieldIndex.UnitMeasureCode } );		
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
				base.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, true, ref _alreadyFetchedUnitMeasure, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", ProductVendorEntity.Relations.VendorEntityUsingVendorID, true, signalRelatedEntity, "ProductVendor", resetFKFields, new int[] { (int)ProductVendorFieldIndex.VendorID } );		
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
				base.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", ProductVendorEntity.Relations.VendorEntityUsingVendorID, true, ref _alreadyFetchedVendor, new string[] {  } );
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
		/// <param name="productID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorID">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productID, System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductVendorFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				base.Fields[(int)ProductVendorFieldIndex.VendorID].ForcedCurrentValueWrite(vendorID);
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
			return DAOFactory.CreateProductVendorDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductVendorEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductVendorRelations Relations
		{
			get	{ return new ProductVendorRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(),
					(IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.ProductVendorEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasure
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(),
					(IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AW.Data.EntityType.ProductVendorEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Vendor")[0], (int)AW.Data.EntityType.ProductVendorEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductVendorEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductVendorEntity.CustomProperties;}
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
			get { return ProductVendorEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductID property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.ProductID, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.ProductID, value, true); }
		}
		/// <summary> The VendorID property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: Primary key. Foreign key to Vendor.VendorID.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.VendorID, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.VendorID, value, true); }
		}
		/// <summary> The AverageLeadTime property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."AverageLeadTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AverageLeadTime
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.AverageLeadTime, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.AverageLeadTime, value, true); }
		}
		/// <summary> The StandardPrice property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The vendor's usual selling price.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."StandardPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardPrice
		{
			get { return (System.Decimal)GetValue((int)ProductVendorFieldIndex.StandardPrice, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.StandardPrice, value, true); }
		}
		/// <summary> The LastReceiptCost property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The selling price when last purchased.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."LastReceiptCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> LastReceiptCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductVendorFieldIndex.LastReceiptCost, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.LastReceiptCost, value, true); }
		}
		/// <summary> The LastReceiptDate property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: Date the product was last received by the vendor.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."LastReceiptDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LastReceiptDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductVendorFieldIndex.LastReceiptDate, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.LastReceiptDate, value, true); }
		}
		/// <summary> The MinOrderQty property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The maximum quantity that should be ordered.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."MinOrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MinOrderQty
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.MinOrderQty, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.MinOrderQty, value, true); }
		}
		/// <summary> The MaxOrderQty property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The minimum quantity that should be ordered.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."MaxOrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MaxOrderQty
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.MaxOrderQty, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.MaxOrderQty, value, true); }
		}
		/// <summary> The OnOrderQty property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The quantity currently on order.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."OnOrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OnOrderQty
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductVendorFieldIndex.OnOrderQty, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.OnOrderQty, value, true); }
		}
		/// <summary> The UnitMeasureCode property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: The product's unit of measure.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductVendorFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.UnitMeasureCode, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ProductVendor<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductVendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return GetSingleProduct(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					if(value==null)
					{
						if(_product != null)
						{
							_product.UnsetRelatedEntity(this, "ProductVendor");
						}
					}
					else
					{
						if(_product!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductVendor");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetSingleProduct(true).</summary>
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
		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return GetSingleUnitMeasure(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure != null)
						{
							_unitMeasure.UnsetRelatedEntity(this, "ProductVendor");
						}
					}
					else
					{
						if(_unitMeasure!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductVendor");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure(true).</summary>
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
							_vendor.UnsetRelatedEntity(this, "ProductVendor");
						}
					}
					else
					{
						if(_vendor!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductVendor");
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
			get { return (int)AW.Data.EntityType.ProductVendorEntity; }
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
