///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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
using System.ComponentModel.DataAnnotations;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'ProductDescription'. <br/><br/>
	/// 
	/// MS_Description: Product descriptions in several languages.<br/>
	/// </summary>
	[Serializable]
	public partial class ProductDescriptionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection	_productModelProductDescriptionCultures;
		private bool	_alwaysFetchProductModelProductDescriptionCultures, _alreadyFetchedProductModelProductDescriptionCultures;
		private AW.Data.CollectionClasses.CultureCollection _cultureCollectionViaProductModelProductDescriptionCulture;
		private bool	_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture, _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.ProductModelCollection _models;
		private bool	_alwaysFetchModels, _alreadyFetchedModels;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
			/// <summary>Member name CultureCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string CultureCollectionViaProductModelProductDescriptionCulture = "CultureCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name Models</summary>
			public static readonly string Models = "Models";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductDescriptionEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductDescriptionEntity() :base("ProductDescriptionEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		public ProductDescriptionEntity(System.Int32 productDescriptionID):base("ProductDescriptionEntity")
		{
			InitClassFetch(productDescriptionID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductDescriptionEntity(System.Int32 productDescriptionID, IPrefetchPath prefetchPathToUse):base("ProductDescriptionEntity")
		{
			InitClassFetch(productDescriptionID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="validator">The custom validator object for this ProductDescriptionEntity</param>
		public ProductDescriptionEntity(System.Int32 productDescriptionID, IValidator validator):base("ProductDescriptionEntity")
		{
			InitClassFetch(productDescriptionID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductDescriptionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productModelProductDescriptionCultures = (AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection)info.GetValue("_productModelProductDescriptionCultures", typeof(AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection));
			_alwaysFetchProductModelProductDescriptionCultures = info.GetBoolean("_alwaysFetchProductModelProductDescriptionCultures");
			_alreadyFetchedProductModelProductDescriptionCultures = info.GetBoolean("_alreadyFetchedProductModelProductDescriptionCultures");
			_cultureCollectionViaProductModelProductDescriptionCulture = (AW.Data.CollectionClasses.CultureCollection)info.GetValue("_cultureCollectionViaProductModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.CultureCollection));
			_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture");
			_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture");

			_models = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_models", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchModels = info.GetBoolean("_alwaysFetchModels");
			_alreadyFetchedModels = info.GetBoolean("_alreadyFetchedModels");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProductModelProductDescriptionCultures = (_productModelProductDescriptionCultures.Count > 0);
			_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = (_cultureCollectionViaProductModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedModels = (_models.Count > 0);
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
				case "ProductModelProductDescriptionCultures":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID, "ProductDescriptionEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "Models":
					toReturn.Add(Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID, "ProductDescriptionEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
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
			info.AddValue("_productModelProductDescriptionCultures", (!this.MarkedForDeletion?_productModelProductDescriptionCultures:null));
			info.AddValue("_alwaysFetchProductModelProductDescriptionCultures", _alwaysFetchProductModelProductDescriptionCultures);
			info.AddValue("_alreadyFetchedProductModelProductDescriptionCultures", _alreadyFetchedProductModelProductDescriptionCultures);
			info.AddValue("_cultureCollectionViaProductModelProductDescriptionCulture", (!this.MarkedForDeletion?_cultureCollectionViaProductModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture", _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture", _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_models", (!this.MarkedForDeletion?_models:null));
			info.AddValue("_alwaysFetchModels", _alwaysFetchModels);
			info.AddValue("_alreadyFetchedModels", _alreadyFetchedModels);

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
				case "ProductModelProductDescriptionCultures":
					_alreadyFetchedProductModelProductDescriptionCultures = true;
					if(entity!=null)
					{
						this.ProductModelProductDescriptionCultures.Add((ProductModelProductDescriptionCultureEntity)entity);
					}
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.CultureCollectionViaProductModelProductDescriptionCulture.Add((CultureEntity)entity);
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
			toReturn.Add(_productModelProductDescriptionCultures);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productDescriptionID)
		{
			return FetchUsingPK(productDescriptionID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productDescriptionID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productDescriptionID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productDescriptionID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productDescriptionID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productDescriptionID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productDescriptionID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductDescriptionID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductDescriptionRelations().GetAllRelations();
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
				_productModelProductDescriptionCultures.GetMultiManyToOne(null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CultureEntity'</returns>
		public AW.Data.CollectionClasses.CultureCollection GetMultiCultureCollectionViaProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiCultureCollectionViaProductModelProductDescriptionCulture(forceFetch, _cultureCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CultureCollection GetMultiCultureCollectionViaProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture || forceFetch || _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_cultureCollectionViaProductModelProductDescriptionCulture);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductDescriptionFields.ProductDescriptionID, ComparisonOperator.Equal, this.ProductDescriptionID, "ProductDescriptionEntity__"));
				_cultureCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				_cultureCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				_cultureCollectionViaProductModelProductDescriptionCulture.GetMulti(filter, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"));
				_cultureCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = true;
			}
			return _cultureCollectionViaProductModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'CultureCollectionViaProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property CultureCollectionViaProductModelProductDescriptionCulture is requested or GetMultiCultureCollectionViaProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCultureCollectionViaProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_cultureCollectionViaProductModelProductDescriptionCulture.SortClauses=sortClauses;
			_cultureCollectionViaProductModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(ProductDescriptionFields.ProductDescriptionID, ComparisonOperator.Equal, this.ProductDescriptionID, "ProductDescriptionEntity__"));
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModelProductDescriptionCultures", _productModelProductDescriptionCultures);
			toReturn.Add("CultureCollectionViaProductModelProductDescriptionCulture", _cultureCollectionViaProductModelProductDescriptionCulture);
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
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="validator">The validator object for this ProductDescriptionEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productDescriptionID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productDescriptionID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_productModelProductDescriptionCultures = new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection();
			_productModelProductDescriptionCultures.SetContainingEntityInfo(this, "ProductDescription");
			_cultureCollectionViaProductModelProductDescriptionCulture = new AW.Data.CollectionClasses.CultureCollection();
			_models = new AW.Data.CollectionClasses.ProductModelCollection();
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
			_customProperties.Add("MS_Description", @"Product descriptions in several languages.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Description of the product.");
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductDescriptionID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productDescriptionID">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productDescriptionID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductDescriptionFieldIndex.ProductDescriptionID].ForcedCurrentValueWrite(productDescriptionID);
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
			return DAOFactory.CreateProductDescriptionDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductDescriptionEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductDescriptionRelations Relations
		{
			get	{ return new ProductDescriptionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelProductDescriptionCultures
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(), (IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCultures")[0], (int)AW.Data.EntityType.ProductDescriptionEntity, (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, "ProductModelProductDescriptionCultures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Culture'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCultureCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CultureCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductDescriptionEntity, (int)AW.Data.EntityType.CultureEntity, 0, null, null, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"), "CultureCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathModels
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,	(int)AW.Data.EntityType.ProductDescriptionEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("Models"), "Models", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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

		/// <summary> The Description property of the Entity ProductDescription<br/><br/>
		/// MS_Description: Description of the product.<br/>Description of the product.</summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 400<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ProductDescriptionFieldIndex.Description, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Description, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity ProductDescription<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductDescriptionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The ProductDescriptionID property of the Entity ProductDescription<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ProductDescriptionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductDescriptionID
		{
			get { return (System.Int32)GetValue((int)ProductDescriptionFieldIndex.ProductDescriptionID, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.ProductDescriptionID, value, true); }
		}

		/// <summary> The Rowguid property of the Entity ProductDescription<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductDescriptionFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Rowguid, value, true); }
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

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCultureCollectionViaProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CultureCollection CultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetMultiCultureCollectionViaProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CultureCollectionViaProductModelProductDescriptionCulture. When set to true, CultureCollectionViaProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CultureCollectionViaProductModelProductDescriptionCulture is accessed. You can always execute a forced fetch by calling GetMultiCultureCollectionViaProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCultureCollectionViaProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CultureCollectionViaProductModelProductDescriptionCulture already has been fetched. Setting this property to false when CultureCollectionViaProductModelProductDescriptionCulture has been fetched
		/// will clear the CultureCollectionViaProductModelProductDescriptionCulture collection well. Setting this property to true while CultureCollectionViaProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for CultureCollectionViaProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture && !value && (_cultureCollectionViaProductModelProductDescriptionCulture != null))
				{
					_cultureCollectionViaProductModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = value;
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
			get { return (int)AW.Data.EntityType.ProductDescriptionEntity; }
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
