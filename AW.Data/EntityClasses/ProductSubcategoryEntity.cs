﻿///////////////////////////////////////////////////////////////
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
using AW.Helper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'ProductSubcategory'. <br/><br/>
	/// 
	/// MS_Description: Product subcategories. See ProductCategory table.<br/>
	/// </summary>
	[Serializable]
	public partial class ProductSubcategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductCollection	_products;
		private bool	_alwaysFetchProducts, _alreadyFetchedProducts;
		private AW.Data.CollectionClasses.ProductModelCollection _models;
		private bool	_alwaysFetchModels, _alreadyFetchedModels;
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
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name Models</summary>
			public static readonly string Models = "Models";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductSubcategoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductSubcategoryEntity() :base("ProductSubcategoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID):base("ProductSubcategoryEntity")
		{
			InitClassFetch(productSubcategoryID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID, IPrefetchPath prefetchPathToUse):base("ProductSubcategoryEntity")
		{
			InitClassFetch(productSubcategoryID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The custom validator object for this ProductSubcategoryEntity</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID, IValidator validator):base("ProductSubcategoryEntity")
		{
			InitClassFetch(productSubcategoryID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductSubcategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_products = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_products", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProducts = info.GetBoolean("_alwaysFetchProducts");
			_alreadyFetchedProducts = info.GetBoolean("_alreadyFetchedProducts");
			_models = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_models", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchModels = info.GetBoolean("_alwaysFetchModels");
			_alreadyFetchedModels = info.GetBoolean("_alreadyFetchedModels");
			_productCategory = (ProductCategoryEntity)info.GetValue("_productCategory", typeof(ProductCategoryEntity));
			if(_productCategory!=null)
			{
				_productCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productCategoryReturnsNewIfNotFound = info.GetBoolean("_productCategoryReturnsNewIfNotFound");
			_alwaysFetchProductCategory = info.GetBoolean("_alwaysFetchProductCategory");
			_alreadyFetchedProductCategory = info.GetBoolean("_alreadyFetchedProductCategory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
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

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProducts = (_products.Count > 0);
			_alreadyFetchedModels = (_models.Count > 0);
			_alreadyFetchedProductCategory = (_productCategory != null);
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
				case "ProductCategory":
					toReturn.Add(Relations.ProductCategoryEntityUsingProductCategoryID);
					break;
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingProductSubcategoryID);
					break;
				case "Models":
					toReturn.Add(Relations.ProductEntityUsingProductSubcategoryID, "ProductSubcategoryEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelID, "Product_", string.Empty, JoinHint.None);
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
			info.AddValue("_products", (!this.MarkedForDeletion?_products:null));
			info.AddValue("_alwaysFetchProducts", _alwaysFetchProducts);
			info.AddValue("_alreadyFetchedProducts", _alreadyFetchedProducts);
			info.AddValue("_models", (!this.MarkedForDeletion?_models:null));
			info.AddValue("_alwaysFetchModels", _alwaysFetchModels);
			info.AddValue("_alreadyFetchedModels", _alreadyFetchedModels);
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "ProductCategory":
					_alreadyFetchedProductCategory = true;
					this.ProductCategory = (ProductCategoryEntity)entity;
					break;
				case "Products":
					_alreadyFetchedProducts = true;
					if(entity!=null)
					{
						this.Products.Add((ProductEntity)entity);
					}
					break;
				case "Models":
					_alreadyFetchedModels = true;
					if(entity!=null)
					{
						this.Models.Add((ProductModelEntity)entity);
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
				case "ProductCategory":
					SetupSyncProductCategory(relatedEntity);
					break;
				case "Products":
					_products.Add((ProductEntity)relatedEntity);
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
				case "ProductCategory":
					DesetupSyncProductCategory(false, true);
					break;
				case "Products":
					this.PerformRelatedEntityRemoval(_products, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_productCategory!=null)
			{
				toReturn.Add(_productCategory);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_products);

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
			return FetchUsingPK(productSubcategoryID, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductSubcategoryID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductSubcategoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProducts || forceFetch || _alwaysFetchProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_products);
				_products.SuppressClearInGetMulti=!forceFetch;
				_products.EntityFactoryToUse = entityFactoryToUse;
				_products.GetMultiManyToOne(null, this, null, null, filter);
				_products.SuppressClearInGetMulti=false;
				_alreadyFetchedProducts = true;
			}
			return _products;
		}

		/// <summary> Sets the collection parameters for the collection for 'Products'. These settings will be taken into account
		/// when the property Products is requested or GetMultiProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_products.SortClauses=sortClauses;
			_products.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiModels(bool forceFetch)
		{
			return GetMultiModels(forceFetch, _models.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiModels(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedModels || forceFetch || _alwaysFetchModels) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_models);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryID, ComparisonOperator.Equal, this.ProductSubcategoryID, "ProductSubcategoryEntity__"));
				_models.SuppressClearInGetMulti=!forceFetch;
				_models.EntityFactoryToUse = entityFactoryToUse;
				_models.GetMulti(filter, GetRelationsForField("Models"));
				_models.SuppressClearInGetMulti=false;
				_alreadyFetchedModels = true;
			}
			return _models;
		}

		/// <summary> Sets the collection parameters for the collection for 'Models'. These settings will be taken into account
		/// when the property Models is requested or GetMultiModels is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersModels(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_models.SortClauses=sortClauses;
			_models.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if( ( !_alreadyFetchedProductCategory || forceFetch || _alwaysFetchProductCategory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductCategoryEntityUsingProductCategoryID);
				ProductCategoryEntity newEntity = new ProductCategoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductCategoryID);
				}
				if(fetchResult)
				{
					newEntity = (ProductCategoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productCategoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ProductCategory = newEntity;
				_alreadyFetchedProductCategory = fetchResult;
			}
			return _productCategory;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductCategory", _productCategory);
			toReturn.Add("Products", _products);
			toReturn.Add("Models", _models);
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
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The validator object for this ProductSubcategoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productSubcategoryID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productSubcategoryID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_products = new AW.Data.CollectionClasses.ProductCollection();
			_products.SetContainingEntityInfo(this, "ProductSubcategory");
			_models = new AW.Data.CollectionClasses.ProductModelCollection();
			_productCategoryReturnsNewIfNotFound = true;
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");
			_fieldsCustomProperties.Add("ProductCategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductSubcategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productCategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productCategory, new PropertyChangedEventHandler( OnProductCategoryPropertyChanged ), "ProductCategory", AW.Data.RelationClasses.StaticProductSubcategoryRelations.ProductCategoryEntityUsingProductCategoryIDStatic, true, signalRelatedEntity, "ProductSubcategories", resetFKFields, new int[] { (int)ProductSubcategoryFieldIndex.ProductCategoryID } );		
			_productCategory = null;
		}
		
		/// <summary> setups the sync logic for member _productCategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductCategory(IEntityCore relatedEntity)
		{
			if(_productCategory!=relatedEntity)
			{		
				DesetupSyncProductCategory(true, true);
				_productCategory = (ProductCategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productCategory, new PropertyChangedEventHandler( OnProductCategoryPropertyChanged ), "ProductCategory", AW.Data.RelationClasses.StaticProductSubcategoryRelations.ProductCategoryEntityUsingProductCategoryIDStatic, true, ref _alreadyFetchedProductCategory, new string[] {  } );
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
				this.Fields[(int)ProductSubcategoryFieldIndex.ProductSubcategoryID].ForcedCurrentValueWrite(productSubcategoryID);
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

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProducts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Products")[0], (int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathModels
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingProductSubcategoryID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("Models"), "Models", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductCategory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCategory
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCategoryCollection(), (IEntityRelation)GetRelationsForField("ProductCategory")[0], (int)AW.Data.EntityType.ProductSubcategoryEntity, (int)AW.Data.EntityType.ProductCategoryEntity, 0, null, null, null, "ProductCategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ModifiedDate property of the Entity ProductSubcategory<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductSubcategoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity ProductSubcategory<br/><br/>
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/>Unique nonclustered index. Used to support replication samples.</summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductSubcategoryFieldIndex.Name, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.Name, value, true); }
		}

		/// <summary> The ProductCategoryID property of the Entity ProductSubcategory<br/><br/>
		/// MS_Description: Product category identification number. Foreign key to ProductCategory.ProductCategoryID.<br/>Product category identification number. Foreign key to ProductCategory.ProductCategoryID.</summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ProductCategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductCategoryID
		{
			get { return (System.Int32)GetValue((int)ProductSubcategoryFieldIndex.ProductCategoryID, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ProductCategoryID, value, true); }
		}

		/// <summary> The ProductSubcategoryID property of the Entity ProductSubcategory<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductSubcategoryID
		{
			get { return (System.Int32)GetValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID, value, true); }
		}

		/// <summary> The Rowguid property of the Entity ProductSubcategory<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "ProductSubcategory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductSubcategoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductSubcategoryFieldIndex.Rowguid, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection Products
		{
			get	{ return GetMultiProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Products. When set to true, Products is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Products is accessed. You can always execute/ a forced fetch by calling GetMultiProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProducts
		{
			get	{ return _alwaysFetchProducts; }
			set	{ _alwaysFetchProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Products already has been fetched. Setting this property to false when Products has been fetched
		/// will clear the Products collection well. Setting this property to true while Products hasn't been fetched disables lazy loading for Products</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProducts
		{
			get { return _alreadyFetchedProducts;}
			set 
			{
				if(_alreadyFetchedProducts && !value && (_products != null))
				{
					_products.Clear();
				}
				_alreadyFetchedProducts = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiModels()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection Models
		{
			get { return GetMultiModels(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Models. When set to true, Models is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Models is accessed. You can always execute a forced fetch by calling GetMultiModels(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchModels
		{
			get	{ return _alwaysFetchModels; }
			set	{ _alwaysFetchModels = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Models already has been fetched. Setting this property to false when Models has been fetched
		/// will clear the Models collection well. Setting this property to true while Models hasn't been fetched disables lazy loading for Models</summary>
		[Browsable(false)]
		public bool AlreadyFetchedModels
		{
			get { return _alreadyFetchedModels;}
			set 
			{
				if(_alreadyFetchedModels && !value && (_models != null))
				{
					_models.Clear();
				}
				_alreadyFetchedModels = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductCategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductCategoryEntity ProductCategory
		{
			get	{ return GetSingleProductCategory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProductCategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductSubcategories", "ProductCategory", _productCategory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCategory. When set to true, ProductCategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCategory is accessed. You can always execute a forced fetch by calling GetSingleProductCategory(true).</summary>
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
		protected override int LLBLGenProEntityTypeValue 
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
