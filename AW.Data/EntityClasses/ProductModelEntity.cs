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
using AW.Helper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'ProductModel'. <br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public partial class ProductModelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductCollection	_products;
		private bool	_alwaysFetchProducts, _alreadyFetchedProducts;
		private AW.Data.CollectionClasses.ProductModelIllustrationCollection	_productModelIllustrations;
		private bool	_alwaysFetchProductModelIllustrations, _alreadyFetchedProductModelIllustrations;
		private AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection	_productModelProductDescriptionCultures;
		private bool	_alwaysFetchProductModelProductDescriptionCultures, _alreadyFetchedProductModelProductDescriptionCultures;
		private AW.Data.CollectionClasses.IllustrationCollection _illustrations;
		private bool	_alwaysFetchIllustrations, _alreadyFetchedIllustrations;
		private AW.Data.CollectionClasses.ProductDescriptionCollection _descriptions;
		private bool	_alwaysFetchDescriptions, _alreadyFetchedDescriptions;
		private AW.Data.CollectionClasses.ProductSubcategoryCollection _subcategories;
		private bool	_alwaysFetchSubcategories, _alreadyFetchedSubcategories;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
			/// <summary>Member name ProductModelIllustrations</summary>
			public static readonly string ProductModelIllustrations = "ProductModelIllustrations";
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
			/// <summary>Member name Illustrations</summary>
			public static readonly string Illustrations = "Illustrations";
			/// <summary>Member name Descriptions</summary>
			public static readonly string Descriptions = "Descriptions";
			/// <summary>Member name Subcategories</summary>
			public static readonly string Subcategories = "Subcategories";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductModelEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductModelEntity() :base("ProductModelEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		public ProductModelEntity(System.Int32 productModelID):base("ProductModelEntity")
		{
			InitClassFetch(productModelID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductModelEntity(System.Int32 productModelID, IPrefetchPath prefetchPathToUse):base("ProductModelEntity")
		{
			InitClassFetch(productModelID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntity(System.Int32 productModelID, IValidator validator):base("ProductModelEntity")
		{
			InitClassFetch(productModelID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_products = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_products", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProducts = info.GetBoolean("_alwaysFetchProducts");
			_alreadyFetchedProducts = info.GetBoolean("_alreadyFetchedProducts");

			_productModelIllustrations = (AW.Data.CollectionClasses.ProductModelIllustrationCollection)info.GetValue("_productModelIllustrations", typeof(AW.Data.CollectionClasses.ProductModelIllustrationCollection));
			_alwaysFetchProductModelIllustrations = info.GetBoolean("_alwaysFetchProductModelIllustrations");
			_alreadyFetchedProductModelIllustrations = info.GetBoolean("_alreadyFetchedProductModelIllustrations");

			_productModelProductDescriptionCultures = (AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection)info.GetValue("_productModelProductDescriptionCultures", typeof(AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection));
			_alwaysFetchProductModelProductDescriptionCultures = info.GetBoolean("_alwaysFetchProductModelProductDescriptionCultures");
			_alreadyFetchedProductModelProductDescriptionCultures = info.GetBoolean("_alreadyFetchedProductModelProductDescriptionCultures");
			_illustrations = (AW.Data.CollectionClasses.IllustrationCollection)info.GetValue("_illustrations", typeof(AW.Data.CollectionClasses.IllustrationCollection));
			_alwaysFetchIllustrations = info.GetBoolean("_alwaysFetchIllustrations");
			_alreadyFetchedIllustrations = info.GetBoolean("_alreadyFetchedIllustrations");

			_descriptions = (AW.Data.CollectionClasses.ProductDescriptionCollection)info.GetValue("_descriptions", typeof(AW.Data.CollectionClasses.ProductDescriptionCollection));
			_alwaysFetchDescriptions = info.GetBoolean("_alwaysFetchDescriptions");
			_alreadyFetchedDescriptions = info.GetBoolean("_alreadyFetchedDescriptions");

			_subcategories = (AW.Data.CollectionClasses.ProductSubcategoryCollection)info.GetValue("_subcategories", typeof(AW.Data.CollectionClasses.ProductSubcategoryCollection));
			_alwaysFetchSubcategories = info.GetBoolean("_alwaysFetchSubcategories");
			_alreadyFetchedSubcategories = info.GetBoolean("_alreadyFetchedSubcategories");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProducts = (_products.Count > 0);
			_alreadyFetchedProductModelIllustrations = (_productModelIllustrations.Count > 0);
			_alreadyFetchedProductModelProductDescriptionCultures = (_productModelProductDescriptionCultures.Count > 0);
			_alreadyFetchedIllustrations = (_illustrations.Count > 0);
			_alreadyFetchedDescriptions = (_descriptions.Count > 0);
			_alreadyFetchedSubcategories = (_subcategories.Count > 0);
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
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingProductModelID);
					break;
				case "ProductModelIllustrations":
					toReturn.Add(Relations.ProductModelIllustrationEntityUsingProductModelID);
					break;
				case "ProductModelProductDescriptionCultures":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID);
					break;
				case "Illustrations":
					toReturn.Add(Relations.ProductModelIllustrationEntityUsingProductModelID, "ProductModelEntity__", "ProductModelIllustration_", JoinHint.None);
					toReturn.Add(ProductModelIllustrationEntity.Relations.IllustrationEntityUsingIllustrationID, "ProductModelIllustration_", string.Empty, JoinHint.None);
					break;
				case "Descriptions":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID, "ProductModelEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "Subcategories":
					toReturn.Add(Relations.ProductEntityUsingProductModelID, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, "Product_", string.Empty, JoinHint.None);
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
			info.AddValue("_productModelIllustrations", (!this.MarkedForDeletion?_productModelIllustrations:null));
			info.AddValue("_alwaysFetchProductModelIllustrations", _alwaysFetchProductModelIllustrations);
			info.AddValue("_alreadyFetchedProductModelIllustrations", _alreadyFetchedProductModelIllustrations);
			info.AddValue("_productModelProductDescriptionCultures", (!this.MarkedForDeletion?_productModelProductDescriptionCultures:null));
			info.AddValue("_alwaysFetchProductModelProductDescriptionCultures", _alwaysFetchProductModelProductDescriptionCultures);
			info.AddValue("_alreadyFetchedProductModelProductDescriptionCultures", _alreadyFetchedProductModelProductDescriptionCultures);
			info.AddValue("_illustrations", (!this.MarkedForDeletion?_illustrations:null));
			info.AddValue("_alwaysFetchIllustrations", _alwaysFetchIllustrations);
			info.AddValue("_alreadyFetchedIllustrations", _alreadyFetchedIllustrations);
			info.AddValue("_descriptions", (!this.MarkedForDeletion?_descriptions:null));
			info.AddValue("_alwaysFetchDescriptions", _alwaysFetchDescriptions);
			info.AddValue("_alreadyFetchedDescriptions", _alreadyFetchedDescriptions);
			info.AddValue("_subcategories", (!this.MarkedForDeletion?_subcategories:null));
			info.AddValue("_alwaysFetchSubcategories", _alwaysFetchSubcategories);
			info.AddValue("_alreadyFetchedSubcategories", _alreadyFetchedSubcategories);

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
				case "Products":
					_alreadyFetchedProducts = true;
					if(entity!=null)
					{
						this.Products.Add((ProductEntity)entity);
					}
					break;
				case "ProductModelIllustrations":
					_alreadyFetchedProductModelIllustrations = true;
					if(entity!=null)
					{
						this.ProductModelIllustrations.Add((ProductModelIllustrationEntity)entity);
					}
					break;
				case "ProductModelProductDescriptionCultures":
					_alreadyFetchedProductModelProductDescriptionCultures = true;
					if(entity!=null)
					{
						this.ProductModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)entity);
					}
					break;
				case "Illustrations":
					_alreadyFetchedIllustrations = true;
					if(entity!=null)
					{
						this.Illustrations.Add((IllustrationEntity)entity);
					}
					break;
				case "Descriptions":
					_alreadyFetchedDescriptions = true;
					if(entity!=null)
					{
						this.Descriptions.Add((ProductDescriptionEntity)entity);
					}
					break;
				case "Subcategories":
					_alreadyFetchedSubcategories = true;
					if(entity!=null)
					{
						this.Subcategories.Add((ProductSubcategoryEntity)entity);
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
				case "Products":
					_products.Add((ProductEntity)relatedEntity);
					break;
				case "ProductModelIllustrations":
					_productModelIllustrations.Add((ProductModelIllustrationEntity)relatedEntity);
					break;
				case "ProductModelProductDescriptionCultures":
					_productModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)relatedEntity);
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
				case "Products":
					this.PerformRelatedEntityRemoval(_products, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductModelIllustrations":
					this.PerformRelatedEntityRemoval(_productModelIllustrations, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductModelProductDescriptionCultures":
					this.PerformRelatedEntityRemoval(_productModelProductDescriptionCultures, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_products);
			toReturn.Add(_productModelIllustrations);
			toReturn.Add(_productModelProductDescriptionCultures);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID)
		{
			return FetchUsingPK(productModelID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productModelID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productModelID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productModelID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductModelID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductModelRelations().GetAllRelations();
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
				_products.GetMultiManyToOne(this, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustrations(bool forceFetch)
		{
			return GetMultiProductModelIllustrations(forceFetch, _productModelIllustrations.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustrations(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelIllustrations(forceFetch, _productModelIllustrations.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustrations(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelIllustrations(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustrations(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelIllustrations || forceFetch || _alwaysFetchProductModelIllustrations) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productModelIllustrations);
				_productModelIllustrations.SuppressClearInGetMulti=!forceFetch;
				_productModelIllustrations.EntityFactoryToUse = entityFactoryToUse;
				_productModelIllustrations.GetMultiManyToOne(null, this, filter);
				_productModelIllustrations.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustrations = true;
			}
			return _productModelIllustrations;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelIllustrations'. These settings will be taken into account
		/// when the property ProductModelIllustrations is requested or GetMultiProductModelIllustrations is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelIllustrations(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelIllustrations.SortClauses=sortClauses;
			_productModelIllustrations.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCultures(bool forceFetch)
		{
			return GetMultiProductModelProductDescriptionCultures(forceFetch, _productModelProductDescriptionCultures.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCultures(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelProductDescriptionCultures(forceFetch, _productModelProductDescriptionCultures.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCultures(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelProductDescriptionCultures(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCultures(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCultures || forceFetch || _alwaysFetchProductModelProductDescriptionCultures) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productModelProductDescriptionCultures);
				_productModelProductDescriptionCultures.SuppressClearInGetMulti=!forceFetch;
				_productModelProductDescriptionCultures.EntityFactoryToUse = entityFactoryToUse;
				_productModelProductDescriptionCultures.GetMultiManyToOne(null, null, this, filter);
				_productModelProductDescriptionCultures.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCultures = true;
			}
			return _productModelProductDescriptionCultures;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelProductDescriptionCultures'. These settings will be taken into account
		/// when the property ProductModelProductDescriptionCultures is requested or GetMultiProductModelProductDescriptionCultures is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelProductDescriptionCultures(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelProductDescriptionCultures.SortClauses=sortClauses;
			_productModelProductDescriptionCultures.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IllustrationEntity'</returns>
		public AW.Data.CollectionClasses.IllustrationCollection GetMultiIllustrations(bool forceFetch)
		{
			return GetMultiIllustrations(forceFetch, _illustrations.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.IllustrationCollection GetMultiIllustrations(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedIllustrations || forceFetch || _alwaysFetchIllustrations) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_illustrations);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_illustrations.SuppressClearInGetMulti=!forceFetch;
				_illustrations.EntityFactoryToUse = entityFactoryToUse;
				_illustrations.GetMulti(filter, GetRelationsForField("Illustrations"));
				_illustrations.SuppressClearInGetMulti=false;
				_alreadyFetchedIllustrations = true;
			}
			return _illustrations;
		}

		/// <summary> Sets the collection parameters for the collection for 'Illustrations'. These settings will be taken into account
		/// when the property Illustrations is requested or GetMultiIllustrations is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIllustrations(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_illustrations.SortClauses=sortClauses;
			_illustrations.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDescriptionEntity'</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiDescriptions(bool forceFetch)
		{
			return GetMultiDescriptions(forceFetch, _descriptions.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiDescriptions(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDescriptions || forceFetch || _alwaysFetchDescriptions) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_descriptions);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_descriptions.SuppressClearInGetMulti=!forceFetch;
				_descriptions.EntityFactoryToUse = entityFactoryToUse;
				_descriptions.GetMulti(filter, GetRelationsForField("Descriptions"));
				_descriptions.SuppressClearInGetMulti=false;
				_alreadyFetchedDescriptions = true;
			}
			return _descriptions;
		}

		/// <summary> Sets the collection parameters for the collection for 'Descriptions'. These settings will be taken into account
		/// when the property Descriptions is requested or GetMultiDescriptions is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDescriptions(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_descriptions.SortClauses=sortClauses;
			_descriptions.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSubcategoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiSubcategories(bool forceFetch)
		{
			return GetMultiSubcategories(forceFetch, _subcategories.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiSubcategories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSubcategories || forceFetch || _alwaysFetchSubcategories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_subcategories);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_subcategories.SuppressClearInGetMulti=!forceFetch;
				_subcategories.EntityFactoryToUse = entityFactoryToUse;
				_subcategories.GetMulti(filter, GetRelationsForField("Subcategories"));
				_subcategories.SuppressClearInGetMulti=false;
				_alreadyFetchedSubcategories = true;
			}
			return _subcategories;
		}

		/// <summary> Sets the collection parameters for the collection for 'Subcategories'. These settings will be taken into account
		/// when the property Subcategories is requested or GetMultiSubcategories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSubcategories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_subcategories.SortClauses=sortClauses;
			_subcategories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Products", _products);
			toReturn.Add("ProductModelIllustrations", _productModelIllustrations);
			toReturn.Add("ProductModelProductDescriptionCultures", _productModelProductDescriptionCultures);
			toReturn.Add("Illustrations", _illustrations);
			toReturn.Add("Descriptions", _descriptions);
			toReturn.Add("Subcategories", _subcategories);
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
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The validator object for this ProductModelEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productModelID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productModelID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_products = new AW.Data.CollectionClasses.ProductCollection();
			_products.SetContainingEntityInfo(this, "ProductModel");

			_productModelIllustrations = new AW.Data.CollectionClasses.ProductModelIllustrationCollection();
			_productModelIllustrations.SetContainingEntityInfo(this, "ProductModel");

			_productModelProductDescriptionCultures = new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection();
			_productModelProductDescriptionCultures.SetContainingEntityInfo(this, "ProductModel");
			_illustrations = new AW.Data.CollectionClasses.IllustrationCollection();
			_descriptions = new AW.Data.CollectionClasses.ProductDescriptionCollection();
			_subcategories = new AW.Data.CollectionClasses.ProductSubcategoryCollection();
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
			_customProperties.Add("MS_Description", @"Primary XML index.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Detailed product catalog information in xml format.");
			_fieldsCustomProperties.Add("CatalogDescription", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Manufacturing instructions in xml format.");
			_fieldsCustomProperties.Add("Instructions", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key for ProductModel records.");
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductModelFieldIndex.ProductModelID].ForcedCurrentValueWrite(productModelID);
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
			return DAOFactory.CreateProductModelDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductModelEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductModelRelations Relations
		{
			get	{ return new ProductModelRelations(); }
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
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Products")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelIllustrations
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelIllustrationCollection(), (IEntityRelation)GetRelationsForField("ProductModelIllustrations")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductModelIllustrationEntity, 0, null, null, null, "ProductModelIllustrations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelProductDescriptionCultures
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(), (IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCultures")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, "ProductModelProductDescriptionCultures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Illustration'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIllustrations
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelIllustrationEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelIllustration_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.IllustrationCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.IllustrationEntity, 0, null, null, GetRelationsForField("Illustrations"), "Illustrations", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDescription'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDescriptions
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDescriptionCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductDescriptionEntity, 0, null, null, GetRelationsForField("Descriptions"), "Descriptions", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSubcategories
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("Subcategories"), "Subcategories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The CatalogDescription property of the Entity ProductModel<br/><br/>
		/// MS_Description: Detailed product catalog information in xml format.<br/>Detailed product catalog information in xml format.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."CatalogDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CatalogDescription
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.CatalogDescription, true); }
			set	{ SetValue((int)ProductModelFieldIndex.CatalogDescription, value, true); }
		}

		/// <summary> The Instructions property of the Entity ProductModel<br/><br/>
		/// MS_Description: Manufacturing instructions in xml format.<br/>Manufacturing instructions in xml format.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Instructions"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Instructions
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Instructions, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Instructions, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity ProductModel<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity ProductModel<br/><br/>
		/// MS_Description: Unique nonclustered index.<br/>Unique nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Name, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Name, value, true); }
		}

		/// <summary> The ProductModelID property of the Entity ProductModel<br/><br/>
		/// MS_Description: Primary key for ProductModel records.<br/>Primary key for ProductModel records.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductModelID
		{
			get { return (System.Int32)GetValue((int)ProductModelFieldIndex.ProductModelID, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ProductModelID, value, true); }
		}

		/// <summary> The Rowguid property of the Entity ProductModel<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "ProductModel"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductModelFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Rowguid, value, true); }
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
		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelIllustrations()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection ProductModelIllustrations
		{
			get	{ return GetMultiProductModelIllustrations(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelIllustrations. When set to true, ProductModelIllustrations is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelIllustrations is accessed. You can always execute/ a forced fetch by calling GetMultiProductModelIllustrations(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelIllustrations
		{
			get	{ return _alwaysFetchProductModelIllustrations; }
			set	{ _alwaysFetchProductModelIllustrations = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelIllustrations already has been fetched. Setting this property to false when ProductModelIllustrations has been fetched
		/// will clear the ProductModelIllustrations collection well. Setting this property to true while ProductModelIllustrations hasn't been fetched disables lazy loading for ProductModelIllustrations</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelIllustrations
		{
			get { return _alreadyFetchedProductModelIllustrations;}
			set 
			{
				if(_alreadyFetchedProductModelIllustrations && !value && (_productModelIllustrations != null))
				{
					_productModelIllustrations.Clear();
				}
				_alreadyFetchedProductModelIllustrations = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelProductDescriptionCultures()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection ProductModelProductDescriptionCultures
		{
			get	{ return GetMultiProductModelProductDescriptionCultures(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelProductDescriptionCultures. When set to true, ProductModelProductDescriptionCultures is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelProductDescriptionCultures is accessed. You can always execute/ a forced fetch by calling GetMultiProductModelProductDescriptionCultures(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelProductDescriptionCultures
		{
			get	{ return _alwaysFetchProductModelProductDescriptionCultures; }
			set	{ _alwaysFetchProductModelProductDescriptionCultures = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelProductDescriptionCultures already has been fetched. Setting this property to false when ProductModelProductDescriptionCultures has been fetched
		/// will clear the ProductModelProductDescriptionCultures collection well. Setting this property to true while ProductModelProductDescriptionCultures hasn't been fetched disables lazy loading for ProductModelProductDescriptionCultures</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelProductDescriptionCultures
		{
			get { return _alreadyFetchedProductModelProductDescriptionCultures;}
			set 
			{
				if(_alreadyFetchedProductModelProductDescriptionCultures && !value && (_productModelProductDescriptionCultures != null))
				{
					_productModelProductDescriptionCultures.Clear();
				}
				_alreadyFetchedProductModelProductDescriptionCultures = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIllustrations()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.IllustrationCollection Illustrations
		{
			get { return GetMultiIllustrations(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Illustrations. When set to true, Illustrations is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Illustrations is accessed. You can always execute a forced fetch by calling GetMultiIllustrations(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIllustrations
		{
			get	{ return _alwaysFetchIllustrations; }
			set	{ _alwaysFetchIllustrations = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Illustrations already has been fetched. Setting this property to false when Illustrations has been fetched
		/// will clear the Illustrations collection well. Setting this property to true while Illustrations hasn't been fetched disables lazy loading for Illustrations</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIllustrations
		{
			get { return _alreadyFetchedIllustrations;}
			set 
			{
				if(_alreadyFetchedIllustrations && !value && (_illustrations != null))
				{
					_illustrations.Clear();
				}
				_alreadyFetchedIllustrations = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDescriptions()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDescriptionCollection Descriptions
		{
			get { return GetMultiDescriptions(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Descriptions. When set to true, Descriptions is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Descriptions is accessed. You can always execute a forced fetch by calling GetMultiDescriptions(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDescriptions
		{
			get	{ return _alwaysFetchDescriptions; }
			set	{ _alwaysFetchDescriptions = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Descriptions already has been fetched. Setting this property to false when Descriptions has been fetched
		/// will clear the Descriptions collection well. Setting this property to true while Descriptions hasn't been fetched disables lazy loading for Descriptions</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDescriptions
		{
			get { return _alreadyFetchedDescriptions;}
			set 
			{
				if(_alreadyFetchedDescriptions && !value && (_descriptions != null))
				{
					_descriptions.Clear();
				}
				_alreadyFetchedDescriptions = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSubcategories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductSubcategoryCollection Subcategories
		{
			get { return GetMultiSubcategories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Subcategories. When set to true, Subcategories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Subcategories is accessed. You can always execute a forced fetch by calling GetMultiSubcategories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSubcategories
		{
			get	{ return _alwaysFetchSubcategories; }
			set	{ _alwaysFetchSubcategories = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Subcategories already has been fetched. Setting this property to false when Subcategories has been fetched
		/// will clear the Subcategories collection well. Setting this property to true while Subcategories hasn't been fetched disables lazy loading for Subcategories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSubcategories
		{
			get { return _alreadyFetchedSubcategories;}
			set 
			{
				if(_alreadyFetchedSubcategories && !value && (_subcategories != null))
				{
					_subcategories.Clear();
				}
				_alreadyFetchedSubcategories = value;
			}
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
			get { return (int)AW.Data.EntityType.ProductModelEntity; }
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
