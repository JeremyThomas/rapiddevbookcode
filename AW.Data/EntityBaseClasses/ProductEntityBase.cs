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
	/// <summary>Entity base class which represents the base class for the entity 'Product'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class ProductEntityBase : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SpecialOfferProductCollection	_specialOfferProducts;
		private bool	_alwaysFetchSpecialOfferProducts, _alreadyFetchedSpecialOfferProducts;
		private AW.Data.CollectionClasses.SpecialOfferCollection _specialOfferCollectionViaSpecialOfferProduct;
		private bool	_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct, _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
			/// <summary>Member name SpecialOfferCollectionViaSpecialOfferProduct</summary>
			public static readonly string SpecialOfferCollectionViaSpecialOfferProduct = "SpecialOfferCollectionViaSpecialOfferProduct";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		protected ProductEntityBase() : base()
		{
			InitClassEmpty(null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		protected ProductEntityBase(System.Int32 productID)
		{
			InitClassFetch(productID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected ProductEntityBase(System.Int32 productID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		protected ProductEntityBase(System.Int32 productID, IValidator validator)
		{
			InitClassFetch(productID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_specialOfferProducts = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProducts", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProducts = info.GetBoolean("_alwaysFetchSpecialOfferProducts");
			_alreadyFetchedSpecialOfferProducts = info.GetBoolean("_alreadyFetchedSpecialOfferProducts");
			_specialOfferCollectionViaSpecialOfferProduct = (AW.Data.CollectionClasses.SpecialOfferCollection)info.GetValue("_specialOfferCollectionViaSpecialOfferProduct", typeof(AW.Data.CollectionClasses.SpecialOfferCollection));
			_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct");
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}	

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedSpecialOfferProducts = (_specialOfferProducts.Count > 0);
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = (_specialOfferCollectionViaSpecialOfferProduct.Count > 0);
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
				case "SpecialOfferProducts":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductID);
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductID, "ProductEntity__", "SpecialOfferProduct_", JoinHint.None);
					toReturn.Add(SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferID, "SpecialOfferProduct_", string.Empty, JoinHint.None);
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
			info.AddValue("_specialOfferProducts", (!this.MarkedForDeletion?_specialOfferProducts:null));
			info.AddValue("_alwaysFetchSpecialOfferProducts", _alwaysFetchSpecialOfferProducts);
			info.AddValue("_alreadyFetchedSpecialOfferProducts", _alreadyFetchedSpecialOfferProducts);
			info.AddValue("_specialOfferCollectionViaSpecialOfferProduct", (!this.MarkedForDeletion?_specialOfferCollectionViaSpecialOfferProduct:null));
			info.AddValue("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct", _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct", _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct);

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
				case "SpecialOfferProducts":
					_alreadyFetchedSpecialOfferProducts = true;
					if(entity!=null)
					{
						this.SpecialOfferProducts.Add((SpecialOfferProductEntity)entity);
					}
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.SpecialOfferCollectionViaSpecialOfferProduct.Add((SpecialOfferEntity)entity);
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
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "SpecialOfferProducts":
					_specialOfferProducts.Add((SpecialOfferProductEntity)relatedEntity);
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
				case "SpecialOfferProducts":
					this.PerformRelatedEntityRemoval(_specialOfferProducts, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_specialOfferProducts);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID)
		{
			return FetchUsingPK(productID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch)
		{
			return GetMultiSpecialOfferProducts(forceFetch, _specialOfferProducts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSpecialOfferProducts(forceFetch, _specialOfferProducts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSpecialOfferProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProducts || forceFetch || _alwaysFetchSpecialOfferProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_specialOfferProducts);
				_specialOfferProducts.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProducts.EntityFactoryToUse = entityFactoryToUse;
				_specialOfferProducts.GetMultiManyToOne(this, null, filter);
				_specialOfferProducts.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProducts = true;
			}
			return _specialOfferProducts;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProducts'. These settings will be taken into account
		/// when the property SpecialOfferProducts is requested or GetMultiSpecialOfferProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProducts.SortClauses=sortClauses;
			_specialOfferProducts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(forceFetch, _specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_specialOfferCollectionViaSpecialOfferProduct);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				_specialOfferCollectionViaSpecialOfferProduct.GetMulti(filter, GetRelationsForField("SpecialOfferCollectionViaSpecialOfferProduct"));
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
			}
			return _specialOfferCollectionViaSpecialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferCollectionViaSpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferCollectionViaSpecialOfferProduct is requested or GetMultiSpecialOfferCollectionViaSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferCollectionViaSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferCollectionViaSpecialOfferProduct.SortClauses=sortClauses;
			_specialOfferCollectionViaSpecialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_specialOfferProducts.ActiveContext = this.ActiveContext;
			_specialOfferCollectionViaSpecialOfferProduct.ActiveContext = this.ActiveContext;
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SpecialOfferProducts", _specialOfferProducts);
			toReturn.Add("SpecialOfferCollectionViaSpecialOfferProduct", _specialOfferCollectionViaSpecialOfferProduct);
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
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_specialOfferProducts = new AW.Data.CollectionClasses.SpecialOfferProductCollection();
			_specialOfferProducts.SetContainingEntityInfo(this, "Product");
			_specialOfferCollectionViaSpecialOfferProduct = new AW.Data.CollectionClasses.SpecialOfferCollection();
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
			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductSubcategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
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
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProducts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(), (IEntityRelation)GetRelationsForField("SpecialOfferProducts")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOffer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferCollectionViaSpecialOfferProduct
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SpecialOfferProductEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "SpecialOfferProduct_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferEntity, 0, null, null, GetRelationsForField("SpecialOfferCollectionViaSpecialOfferProduct"), "SpecialOfferCollectionViaSpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "ProductEntity";}
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

		/// <summary> The Class property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Class, true); }
			set	{ SetValue((int)ProductFieldIndex.Class, value, true); }
		}

		/// <summary> The Color property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Color, true); }
			set	{ SetValue((int)ProductFieldIndex.Color, value, true); }
		}

		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.DaysToManufacture, true); }
			set	{ SetValue((int)ProductFieldIndex.DaysToManufacture, value, true); }
		}

		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.DiscontinuedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.DiscontinuedDate, value, true); }
		}

		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.FinishedGoodsFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.FinishedGoodsFlag, value, true); }
		}

		/// <summary> The ListPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.ListPrice, true); }
			set	{ SetValue((int)ProductFieldIndex.ListPrice, value, true); }
		}

		/// <summary> The MakeFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.MakeFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.MakeFlag, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Name, true); }
			set	{ SetValue((int)ProductFieldIndex.Name, value, true); }
		}

		/// <summary> The ProductID property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductID, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductID, value, true); }
		}

		/// <summary> The ProductLine property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductLine, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductLine, value, true); }
		}

		/// <summary> The ProductModelID property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductModelID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductModelID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductModelID, value, true); }
		}

		/// <summary> The ProductNumber property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductNumber, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductNumber, value, true); }
		}

		/// <summary> The ProductSubcategoryID property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductSubcategoryID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductSubcategoryID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductSubcategoryID, value, true); }
		}

		/// <summary> The ReorderPoint property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.ReorderPoint, true); }
			set	{ SetValue((int)ProductFieldIndex.ReorderPoint, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.SafetyStockLevel, true); }
			set	{ SetValue((int)ProductFieldIndex.SafetyStockLevel, value, true); }
		}

		/// <summary> The SellEndDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> SellEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.SellEndDate, false); }
			set	{ SetValue((int)ProductFieldIndex.SellEndDate, value, true); }
		}

		/// <summary> The SellStartDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.SellStartDate, true); }
			set	{ SetValue((int)ProductFieldIndex.SellStartDate, value, true); }
		}

		/// <summary> The Size property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Size"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Size
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Size, true); }
			set	{ SetValue((int)ProductFieldIndex.Size, value, true); }
		}

		/// <summary> The SizeUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.SizeUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.SizeUnitMeasureCode, value, true); }
		}

		/// <summary> The StandardCost property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.StandardCost, true); }
			set	{ SetValue((int)ProductFieldIndex.StandardCost, value, true); }
		}

		/// <summary> The Style property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Style, true); }
			set	{ SetValue((int)ProductFieldIndex.Style, value, true); }
		}

		/// <summary> The Weight property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Weight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.Weight, false); }
			set	{ SetValue((int)ProductFieldIndex.Weight, value, true); }
		}

		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.WeightUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.WeightUnitMeasureCode, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProducts
		{
			get	{ return GetMultiSpecialOfferProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProducts. When set to true, SpecialOfferProducts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProducts is accessed. You can always execute/ a forced fetch by calling GetMultiSpecialOfferProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProducts
		{
			get	{ return _alwaysFetchSpecialOfferProducts; }
			set	{ _alwaysFetchSpecialOfferProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferProducts already has been fetched. Setting this property to false when SpecialOfferProducts has been fetched
		/// will clear the SpecialOfferProducts collection well. Setting this property to true while SpecialOfferProducts hasn't been fetched disables lazy loading for SpecialOfferProducts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferProducts
		{
			get { return _alreadyFetchedSpecialOfferProducts;}
			set 
			{
				if(_alreadyFetchedSpecialOfferProducts && !value && (_specialOfferProducts != null))
				{
					_specialOfferProducts.Clear();
				}
				_alreadyFetchedSpecialOfferProducts = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferCollectionViaSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferCollection SpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferCollectionViaSpecialOfferProduct. When set to true, SpecialOfferCollectionViaSpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferCollectionViaSpecialOfferProduct is accessed. You can always execute a forced fetch by calling GetMultiSpecialOfferCollectionViaSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferCollectionViaSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferCollectionViaSpecialOfferProduct already has been fetched. Setting this property to false when SpecialOfferCollectionViaSpecialOfferProduct has been fetched
		/// will clear the SpecialOfferCollectionViaSpecialOfferProduct collection well. Setting this property to true while SpecialOfferCollectionViaSpecialOfferProduct hasn't been fetched disables lazy loading for SpecialOfferCollectionViaSpecialOfferProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct;}
			set 
			{
				if(_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct && !value && (_specialOfferCollectionViaSpecialOfferProduct != null))
				{
					_specialOfferCollectionViaSpecialOfferProduct.Clear();
				}
				_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = value;
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
			get { return (int)AW.Data.EntityType.ProductEntity; }
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
