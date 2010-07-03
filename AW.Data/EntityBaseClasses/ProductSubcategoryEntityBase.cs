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
	
	/// <summary>Entity base class which represents the base class for the entity 'ProductSubcategory'.<br/><br/>
	/// 
	/// MS_Description: Product subcategories. See ProductCategory table.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductSubcategoryEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private AW.Data.CollectionClasses.ProductModelCollection _productModelCollectionViaProduct;
		private bool	_alwaysFetchProductModelCollectionViaProduct, _alreadyFetchedProductModelCollectionViaProduct;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProduct;
		private bool	_alwaysFetchUnitMeasureCollectionViaProduct, _alreadyFetchedUnitMeasureCollectionViaProduct;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProduct_;
		private bool	_alwaysFetchUnitMeasureCollectionViaProduct_, _alreadyFetchedUnitMeasureCollectionViaProduct_;
		private ProductCategoryEntity _productCategory;
		private bool	_alwaysFetchProductCategory, _alreadyFetchedProductCategory, _productCategoryReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductCategory</summary>
			public static readonly string ProductCategory = "ProductCategory";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name ProductModelCollectionViaProduct</summary>
			public static readonly string ProductModelCollectionViaProduct = "ProductModelCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct</summary>
			public static readonly string UnitMeasureCollectionViaProduct = "UnitMeasureCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct_</summary>
			public static readonly string UnitMeasureCollectionViaProduct_ = "UnitMeasureCollectionViaProduct_";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductSubcategoryEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductSubcategoryEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		public ProductSubcategoryEntityBase(System.Int32 productSubcategoryID)
		{
			InitClassFetch(productSubcategoryID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductSubcategoryEntityBase(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productSubcategoryID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The custom validator object for this ProductSubcategoryEntity</param>
		public ProductSubcategoryEntityBase(System.Int32 productSubcategoryID, IValidator validator)
		{
			InitClassFetch(productSubcategoryID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductSubcategoryEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_product = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_product", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_productModelCollectionViaProduct = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_productModelCollectionViaProduct", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchProductModelCollectionViaProduct = info.GetBoolean("_alwaysFetchProductModelCollectionViaProduct");
			_alreadyFetchedProductModelCollectionViaProduct = info.GetBoolean("_alreadyFetchedProductModelCollectionViaProduct");
			_unitMeasureCollectionViaProduct = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProduct", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProduct = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProduct");
			_alreadyFetchedUnitMeasureCollectionViaProduct = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProduct");
			_unitMeasureCollectionViaProduct_ = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProduct_", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProduct_ = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProduct_");
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProduct_");
			_productCategory = (ProductCategoryEntity)info.GetValue("_productCategory", typeof(ProductCategoryEntity));
			if(_productCategory!=null)
			{
				_productCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productCategoryReturnsNewIfNotFound = info.GetBoolean("_productCategoryReturnsNewIfNotFound");
			_alwaysFetchProductCategory = info.GetBoolean("_alwaysFetchProductCategory");
			_alreadyFetchedProductCategory = info.GetBoolean("_alreadyFetchedProductCategory");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductSubcategoryFieldIndex)fieldIndex)
			{
				case ProductSubcategoryFieldIndex.ProductCategoryID:
					DesetupSyncProductCategory(true, false);
					_alreadyFetchedProductCategory = false;
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
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedProductModelCollectionViaProduct = (_productModelCollectionViaProduct.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProduct = (_unitMeasureCollectionViaProduct.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = (_unitMeasureCollectionViaProduct_.Count > 0);
			_alreadyFetchedProductCategory = (_productCategory != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductSubcategoryEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ProductCategory":
					toReturn.Add(ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID);
					break;
				case "Product":
					toReturn.Add(ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID);
					break;
				case "ProductModelCollectionViaProduct":
					toReturn.Add(ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID, "ProductSubcategoryEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelID, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct":
					toReturn.Add(ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID, "ProductSubcategoryEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct_":
					toReturn.Add(ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID, "ProductSubcategoryEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
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
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_productModelCollectionViaProduct", (!this.MarkedForDeletion?_productModelCollectionViaProduct:null));
			info.AddValue("_alwaysFetchProductModelCollectionViaProduct", _alwaysFetchProductModelCollectionViaProduct);
			info.AddValue("_alreadyFetchedProductModelCollectionViaProduct", _alreadyFetchedProductModelCollectionViaProduct);
			info.AddValue("_unitMeasureCollectionViaProduct", (!this.MarkedForDeletion?_unitMeasureCollectionViaProduct:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProduct", _alwaysFetchUnitMeasureCollectionViaProduct);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProduct", _alreadyFetchedUnitMeasureCollectionViaProduct);
			info.AddValue("_unitMeasureCollectionViaProduct_", (!this.MarkedForDeletion?_unitMeasureCollectionViaProduct_:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProduct_", _alwaysFetchUnitMeasureCollectionViaProduct_);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProduct_", _alreadyFetchedUnitMeasureCollectionViaProduct_);
			info.AddValue("_productCategory", (!this.MarkedForDeletion?_productCategory:null));
			info.AddValue("_productCategoryReturnsNewIfNotFound", _productCategoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductCategory", _alwaysFetchProductCategory);
			info.AddValue("_alreadyFetchedProductCategory", _alreadyFetchedProductCategory);

			
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
				case "ProductCategory":
					_alreadyFetchedProductCategory = true;
					this.ProductCategory = (ProductCategoryEntity)entity;
					break;
				case "Product":
					_alreadyFetchedProduct = true;
					if(entity!=null)
					{
						this.Product.Add((ProductEntity)entity);
					}
					break;
				case "ProductModelCollectionViaProduct":
					_alreadyFetchedProductModelCollectionViaProduct = true;
					if(entity!=null)
					{
						this.ProductModelCollectionViaProduct.Add((ProductModelEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProduct":
					_alreadyFetchedUnitMeasureCollectionViaProduct = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProduct.Add((UnitMeasureEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProduct_":
					_alreadyFetchedUnitMeasureCollectionViaProduct_ = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProduct_.Add((UnitMeasureEntity)entity);
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
				case "ProductCategory":
					SetupSyncProductCategory(relatedEntity);
					break;
				case "Product":
					_product.Add((ProductEntity)relatedEntity);
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
				case "ProductCategory":
					DesetupSyncProductCategory(false, true);
					break;
				case "Product":
					base.PerformRelatedEntityRemoval(_product, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_productCategory!=null)
			{
				toReturn.Add(_productCategory);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_product);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productSubcategoryID)
		{
			return FetchUsingPK(productSubcategoryID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productSubcategoryID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productSubcategoryID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productSubcategoryID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductSubcategoryID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductSubcategoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductSubcategoryFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductSubcategoryRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch)
		{
			return GetMultiProduct(forceFetch, _product.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProduct(forceFetch, _product.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProduct(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_product.EntityFactoryToUse = entityFactoryToUse;
				}
				_product.GetMultiManyToOne(null, this, null, null, filter);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}

		/// <summary> Sets the collection parameters for the collection for 'Product'. These settings will be taken into account
		/// when the property Product is requested or GetMultiProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product.SortClauses=sortClauses;
			_product.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct(bool forceFetch)
		{
			return GetMultiProductModelCollectionViaProduct(forceFetch, _productModelCollectionViaProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelCollectionViaProduct || forceFetch || _alwaysFetchProductModelCollectionViaProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelCollectionViaProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelCollectionViaProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryID, ComparisonOperator.Equal, this.ProductSubcategoryID, "ProductSubcategoryEntity__"));
				_productModelCollectionViaProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelCollectionViaProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelCollectionViaProduct.GetMulti(filter, GetRelationsForField("ProductModelCollectionViaProduct"));
				_productModelCollectionViaProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelCollectionViaProduct = true;
			}
			return _productModelCollectionViaProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelCollectionViaProduct'. These settings will be taken into account
		/// when the property ProductModelCollectionViaProduct is requested or GetMultiProductModelCollectionViaProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelCollectionViaProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelCollectionViaProduct.SortClauses=sortClauses;
			_productModelCollectionViaProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProduct(forceFetch, _unitMeasureCollectionViaProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProduct || forceFetch || _alwaysFetchUnitMeasureCollectionViaProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryID, ComparisonOperator.Equal, this.ProductSubcategoryID, "ProductSubcategoryEntity__"));
				_unitMeasureCollectionViaProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProduct.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProduct"));
				_unitMeasureCollectionViaProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProduct = true;
			}
			return _unitMeasureCollectionViaProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProduct'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProduct is requested or GetMultiUnitMeasureCollectionViaProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProduct.SortClauses=sortClauses;
			_unitMeasureCollectionViaProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct_(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProduct_(forceFetch, _unitMeasureCollectionViaProduct_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProduct_ || forceFetch || _alwaysFetchUnitMeasureCollectionViaProduct_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProduct_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProduct_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryID, ComparisonOperator.Equal, this.ProductSubcategoryID, "ProductSubcategoryEntity__"));
				_unitMeasureCollectionViaProduct_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProduct_.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProduct_.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProduct_"));
				_unitMeasureCollectionViaProduct_.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProduct_ = true;
			}
			return _unitMeasureCollectionViaProduct_;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProduct_'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProduct_ is requested or GetMultiUnitMeasureCollectionViaProduct_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProduct_.SortClauses=sortClauses;
			_unitMeasureCollectionViaProduct_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'ProductCategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductCategoryEntity' which is related to this entity.</returns>
		public ProductCategoryEntity GetSingleProductCategory()
		{
			return GetSingleProductCategory(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductCategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductCategoryEntity' which is related to this entity.</returns>
		public virtual ProductCategoryEntity GetSingleProductCategory(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductCategory || forceFetch || _alwaysFetchProductCategory) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID);

				ProductCategoryEntity newEntity = new ProductCategoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductCategoryID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductCategoryEntity)base.ActiveContext.Get(newEntity);
					}
					this.ProductCategory = newEntity;
				}
				else
				{
					if(_productCategoryReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_productCategory == null)))
						{
							this.ProductCategory = newEntity;
						}
					}
					else
					{
						this.ProductCategory = null;
					}
				}
				_alreadyFetchedProductCategory = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _productCategory;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ProductSubcategoryDAO dao = (ProductSubcategoryDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_product.ActiveContext = base.ActiveContext;
			_productModelCollectionViaProduct.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProduct.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProduct_.ActiveContext = base.ActiveContext;
			if(_productCategory!=null)
			{
				_productCategory.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductSubcategoryDAO dao = (ProductSubcategoryDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductSubcategoryDAO dao = (ProductSubcategoryDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductSubcategoryEntity);
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
			toReturn.Add("ProductCategory", _productCategory);
			toReturn.Add("Product", _product);
			toReturn.Add("ProductModelCollectionViaProduct", _productModelCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct", _unitMeasureCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct_", _unitMeasureCollectionViaProduct_);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The validator object for this ProductSubcategoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productSubcategoryID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productSubcategoryID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_product = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_product.SetContainingEntityInfo(this, "ProductSubcategory");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_productModelCollectionViaProduct = new AW.Data.CollectionClasses.ProductModelCollection(new ProductModelEntityFactory());
			_alwaysFetchProductModelCollectionViaProduct = false;
			_alreadyFetchedProductModelCollectionViaProduct = false;
			_unitMeasureCollectionViaProduct = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProduct = false;
			_alreadyFetchedUnitMeasureCollectionViaProduct = false;
			_unitMeasureCollectionViaProduct_ = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProduct_ = false;
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = false;
			_productCategory = null;
			_productCategoryReturnsNewIfNotFound = true;
			_alwaysFetchProductCategory = false;
			_alreadyFetchedProductCategory = false;


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
			_customProperties.Add("MS_Description", @"Product subcategories. See ProductCategory table.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductSubcategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");
			_fieldsCustomProperties.Add("ProductCategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _productCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _productCategory, new PropertyChangedEventHandler( OnProductCategoryPropertyChanged ), "ProductCategory", ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID, true, signalRelatedEntity, "ProductSubcategory", resetFKFields, new int[] { (int)ProductSubcategoryFieldIndex.ProductCategoryID } );		
			_productCategory = null;
		}
		
		/// <summary> setups the sync logic for member _productCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductCategory(IEntity relatedEntity)
		{
			if(_productCategory!=relatedEntity)
			{		
				DesetupSyncProductCategory(true, true);
				_productCategory = (ProductCategoryEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _productCategory, new PropertyChangedEventHandler( OnProductCategoryPropertyChanged ), "ProductCategory", ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID, true, ref _alreadyFetchedProductCategory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductSubcategoryFieldIndex.ProductSubcategoryID].ForcedCurrentValueWrite(productSubcategoryID);
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
			return DAOFactory.CreateProductSubcategoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductSubcategoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductSubcategoryRelations Relations
		{
			get	{ return new ProductSubcategoryRelations(); }
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
					(IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProduct"), "ProductModelCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct"), "UnitMeasureCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProduct_
		{
			get
			{
				IEntityRelation intermediateRelation = ProductSubcategoryEntity.Relations.ProductEntityUsingProductSubcategoryID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct_"), "UnitMeasureCollectionViaProduct_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductCategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCategory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCategoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductCategory")[0], (int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductCategoryEntity, 0, null, null, null, "ProductCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductSubcategoryEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductSubcategoryEntity.CustomProperties;}
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
			get { return ProductSubcategoryEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductSubcategoryID property of the Entity ProductSubcategory<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductSubcategoryID
		{
			get { return (System.Int32)GetValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID, value, true); }
		}
		/// <summary> The ProductCategoryID property of the Entity ProductSubcategory<br/><br/>
		/// 
		/// MS_Description: Product category identification number. Foreign key to ProductCategory.ProductCategoryID.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ProductCategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductCategoryID
		{
			get { return (System.Int32)GetValue((int)ProductSubcategoryFieldIndex.ProductCategoryID, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ProductCategoryID, value, true); }
		}
		/// <summary> The Name property of the Entity ProductSubcategory<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductSubcategoryFieldIndex.Name, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.Name, value, true); }
		}
		/// <summary> The Rowguid property of the Entity ProductSubcategory<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductSubcategoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ProductSubcategory<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductSubcategoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection Product
		{
			get	{ return GetMultiProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get	{ return _alwaysFetchProduct; }
			set	{ _alwaysFetchProduct = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product already has been fetched. Setting this property to false when Product has been fetched
		/// will clear the Product collection well. Setting this property to true while Product hasn't been fetched disables lazy loading for Product</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct
		{
			get { return _alreadyFetchedProduct;}
			set 
			{
				if(_alreadyFetchedProduct && !value && (_product != null))
				{
					_product.Clear();
				}
				_alreadyFetchedProduct = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelCollectionViaProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection ProductModelCollectionViaProduct
		{
			get { return GetMultiProductModelCollectionViaProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelCollectionViaProduct. When set to true, ProductModelCollectionViaProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelCollectionViaProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelCollectionViaProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelCollectionViaProduct
		{
			get	{ return _alwaysFetchProductModelCollectionViaProduct; }
			set	{ _alwaysFetchProductModelCollectionViaProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelCollectionViaProduct already has been fetched. Setting this property to false when ProductModelCollectionViaProduct has been fetched
		/// will clear the ProductModelCollectionViaProduct collection well. Setting this property to true while ProductModelCollectionViaProduct hasn't been fetched disables lazy loading for ProductModelCollectionViaProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelCollectionViaProduct
		{
			get { return _alreadyFetchedProductModelCollectionViaProduct;}
			set 
			{
				if(_alreadyFetchedProductModelCollectionViaProduct && !value && (_productModelCollectionViaProduct != null))
				{
					_productModelCollectionViaProduct.Clear();
				}
				_alreadyFetchedProductModelCollectionViaProduct = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProduct
		{
			get { return GetMultiUnitMeasureCollectionViaProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProduct. When set to true, UnitMeasureCollectionViaProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProduct
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProduct; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProduct already has been fetched. Setting this property to false when UnitMeasureCollectionViaProduct has been fetched
		/// will clear the UnitMeasureCollectionViaProduct collection well. Setting this property to true while UnitMeasureCollectionViaProduct hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProduct
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProduct;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProduct && !value && (_unitMeasureCollectionViaProduct != null))
				{
					_unitMeasureCollectionViaProduct.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProduct = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProduct_
		{
			get { return GetMultiUnitMeasureCollectionViaProduct_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProduct_. When set to true, UnitMeasureCollectionViaProduct_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProduct_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProduct_
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProduct_; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProduct_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProduct_ already has been fetched. Setting this property to false when UnitMeasureCollectionViaProduct_ has been fetched
		/// will clear the UnitMeasureCollectionViaProduct_ collection well. Setting this property to true while UnitMeasureCollectionViaProduct_ hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProduct_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProduct_
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProduct_;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProduct_ && !value && (_unitMeasureCollectionViaProduct_ != null))
				{
					_unitMeasureCollectionViaProduct_.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProduct_ = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductCategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductCategoryEntity ProductCategory
		{
			get	{ return GetSingleProductCategory(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductCategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_productCategory != null)
						{
							_productCategory.UnsetRelatedEntity(this, "ProductSubcategory");
						}
					}
					else
					{
						if(_productCategory!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductSubcategory");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCategory. When set to true, ProductCategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCategory is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductCategory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCategory
		{
			get	{ return _alwaysFetchProductCategory; }
			set	{ _alwaysFetchProductCategory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCategory already has been fetched. Setting this property to false when ProductCategory has been fetched
		/// will set ProductCategory to null as well. Setting this property to true while ProductCategory hasn't been fetched disables lazy loading for ProductCategory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCategory
		{
			get { return _alreadyFetchedProductCategory;}
			set 
			{
				if(_alreadyFetchedProductCategory && !value)
				{
					this.ProductCategory = null;
				}
				_alreadyFetchedProductCategory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductCategory is not found
		/// in the database. When set to true, ProductCategory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductCategoryReturnsNewIfNotFound
		{
			get	{ return _productCategoryReturnsNewIfNotFound; }
			set { _productCategoryReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.ProductSubcategoryEntity; }
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
