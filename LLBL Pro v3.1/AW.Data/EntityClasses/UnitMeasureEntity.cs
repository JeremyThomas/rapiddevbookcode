///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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

	/// <summary>Entity class which represents the entity 'UnitMeasure'. <br/><br/>
	/// 
	/// MS_Description: Unit of measure lookup table.<br/>
	/// </summary>
	[Serializable]
	public partial class UnitMeasureEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.BillOfMaterialCollection	_billOfMaterials;
		private bool	_alwaysFetchBillOfMaterials, _alreadyFetchedBillOfMaterials;
		private AW.Data.CollectionClasses.ProductCollection	_productsOfSize;
		private bool	_alwaysFetchProductsOfSize, _alreadyFetchedProductsOfSize;
		private AW.Data.CollectionClasses.ProductCollection	_productsOfWeight;
		private bool	_alwaysFetchProductsOfWeight, _alreadyFetchedProductsOfWeight;
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendors;
		private bool	_alwaysFetchProductVendors, _alreadyFetchedProductVendors;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name ProductsOfSize</summary>
			public static readonly string ProductsOfSize = "ProductsOfSize";
			/// <summary>Member name ProductsOfWeight</summary>
			public static readonly string ProductsOfWeight = "ProductsOfWeight";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UnitMeasureEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UnitMeasureEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		public UnitMeasureEntity(System.String unitMeasureCode)
		{
			InitClassFetch(unitMeasureCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UnitMeasureEntity(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(unitMeasureCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntity(System.String unitMeasureCode, IValidator validator)
		{
			InitClassFetch(unitMeasureCode, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UnitMeasureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_billOfMaterials = (AW.Data.CollectionClasses.BillOfMaterialCollection)info.GetValue("_billOfMaterials", typeof(AW.Data.CollectionClasses.BillOfMaterialCollection));
			_alwaysFetchBillOfMaterials = info.GetBoolean("_alwaysFetchBillOfMaterials");
			_alreadyFetchedBillOfMaterials = info.GetBoolean("_alreadyFetchedBillOfMaterials");

			_productsOfSize = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productsOfSize", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductsOfSize = info.GetBoolean("_alwaysFetchProductsOfSize");
			_alreadyFetchedProductsOfSize = info.GetBoolean("_alreadyFetchedProductsOfSize");

			_productsOfWeight = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productsOfWeight", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductsOfWeight = info.GetBoolean("_alwaysFetchProductsOfWeight");
			_alreadyFetchedProductsOfWeight = info.GetBoolean("_alreadyFetchedProductsOfWeight");

			_productVendors = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendors", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendors = info.GetBoolean("_alwaysFetchProductVendors");
			_alreadyFetchedProductVendors = info.GetBoolean("_alreadyFetchedProductVendors");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedBillOfMaterials = (_billOfMaterials.Count > 0);
			_alreadyFetchedProductsOfSize = (_productsOfSize.Count > 0);
			_alreadyFetchedProductsOfWeight = (_productsOfWeight.Count > 0);
			_alreadyFetchedProductVendors = (_productVendors.Count > 0);
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
				case "BillOfMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingUnitMeasureCode);
					break;
				case "ProductsOfSize":
					toReturn.Add(Relations.ProductEntityUsingSizeUnitMeasureCode);
					break;
				case "ProductsOfWeight":
					toReturn.Add(Relations.ProductEntityUsingWeightUnitMeasureCode);
					break;
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingUnitMeasureCode);
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
			info.AddValue("_billOfMaterials", (!this.MarkedForDeletion?_billOfMaterials:null));
			info.AddValue("_alwaysFetchBillOfMaterials", _alwaysFetchBillOfMaterials);
			info.AddValue("_alreadyFetchedBillOfMaterials", _alreadyFetchedBillOfMaterials);
			info.AddValue("_productsOfSize", (!this.MarkedForDeletion?_productsOfSize:null));
			info.AddValue("_alwaysFetchProductsOfSize", _alwaysFetchProductsOfSize);
			info.AddValue("_alreadyFetchedProductsOfSize", _alreadyFetchedProductsOfSize);
			info.AddValue("_productsOfWeight", (!this.MarkedForDeletion?_productsOfWeight:null));
			info.AddValue("_alwaysFetchProductsOfWeight", _alwaysFetchProductsOfWeight);
			info.AddValue("_alreadyFetchedProductsOfWeight", _alreadyFetchedProductsOfWeight);
			info.AddValue("_productVendors", (!this.MarkedForDeletion?_productVendors:null));
			info.AddValue("_alwaysFetchProductVendors", _alwaysFetchProductVendors);
			info.AddValue("_alreadyFetchedProductVendors", _alreadyFetchedProductVendors);

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
				case "BillOfMaterials":
					_alreadyFetchedBillOfMaterials = true;
					if(entity!=null)
					{
						this.BillOfMaterials.Add((BillOfMaterialEntity)entity);
					}
					break;
				case "ProductsOfSize":
					_alreadyFetchedProductsOfSize = true;
					if(entity!=null)
					{
						this.ProductsOfSize.Add((ProductEntity)entity);
					}
					break;
				case "ProductsOfWeight":
					_alreadyFetchedProductsOfWeight = true;
					if(entity!=null)
					{
						this.ProductsOfWeight.Add((ProductEntity)entity);
					}
					break;
				case "ProductVendors":
					_alreadyFetchedProductVendors = true;
					if(entity!=null)
					{
						this.ProductVendors.Add((ProductVendorEntity)entity);
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
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "BillOfMaterials":
					_billOfMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "ProductsOfSize":
					_productsOfSize.Add((ProductEntity)relatedEntity);
					break;
				case "ProductsOfWeight":
					_productsOfWeight.Add((ProductEntity)relatedEntity);
					break;
				case "ProductVendors":
					_productVendors.Add((ProductVendorEntity)relatedEntity);
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
				case "BillOfMaterials":
					this.PerformRelatedEntityRemoval(_billOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductsOfSize":
					this.PerformRelatedEntityRemoval(_productsOfSize, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductsOfWeight":
					this.PerformRelatedEntityRemoval(_productsOfWeight, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(_productVendors, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_billOfMaterials);
			toReturn.Add(_productsOfSize);
			toReturn.Add(_productsOfWeight);
			toReturn.Add(_productVendors);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode)
		{
			return FetchUsingPK(unitMeasureCode, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(unitMeasureCode, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(unitMeasureCode, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(unitMeasureCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.UnitMeasureCode, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new UnitMeasureRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfMaterials(bool forceFetch)
		{
			return GetMultiBillOfMaterials(forceFetch, _billOfMaterials.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfMaterials(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBillOfMaterials(forceFetch, _billOfMaterials.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBillOfMaterials(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_billOfMaterials);
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				_billOfMaterials.GetMultiManyToOne(null, null, this, filter);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'BillOfMaterials'. These settings will be taken into account
		/// when the property BillOfMaterials is requested or GetMultiBillOfMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfMaterials.SortClauses=sortClauses;
			_billOfMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfSize(bool forceFetch)
		{
			return GetMultiProductsOfSize(forceFetch, _productsOfSize.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfSize(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductsOfSize(forceFetch, _productsOfSize.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfSize(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductsOfSize(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfSize(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductsOfSize || forceFetch || _alwaysFetchProductsOfSize) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productsOfSize);
				_productsOfSize.SuppressClearInGetMulti=!forceFetch;
				_productsOfSize.EntityFactoryToUse = entityFactoryToUse;
				_productsOfSize.GetMultiManyToOne(null, null, this, null, filter);
				_productsOfSize.SuppressClearInGetMulti=false;
				_alreadyFetchedProductsOfSize = true;
			}
			return _productsOfSize;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductsOfSize'. These settings will be taken into account
		/// when the property ProductsOfSize is requested or GetMultiProductsOfSize is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductsOfSize(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productsOfSize.SortClauses=sortClauses;
			_productsOfSize.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfWeight(bool forceFetch)
		{
			return GetMultiProductsOfWeight(forceFetch, _productsOfWeight.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfWeight(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductsOfWeight(forceFetch, _productsOfWeight.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfWeight(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductsOfWeight(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProductsOfWeight(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductsOfWeight || forceFetch || _alwaysFetchProductsOfWeight) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productsOfWeight);
				_productsOfWeight.SuppressClearInGetMulti=!forceFetch;
				_productsOfWeight.EntityFactoryToUse = entityFactoryToUse;
				_productsOfWeight.GetMultiManyToOne(null, null, null, this, filter);
				_productsOfWeight.SuppressClearInGetMulti=false;
				_alreadyFetchedProductsOfWeight = true;
			}
			return _productsOfWeight;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductsOfWeight'. These settings will be taken into account
		/// when the property ProductsOfWeight is requested or GetMultiProductsOfWeight is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductsOfWeight(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productsOfWeight.SortClauses=sortClauses;
			_productsOfWeight.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch)
		{
			return GetMultiProductVendors(forceFetch, _productVendors.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductVendors(forceFetch, _productVendors.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductVendors(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendors || forceFetch || _alwaysFetchProductVendors) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productVendors);
				_productVendors.SuppressClearInGetMulti=!forceFetch;
				_productVendors.EntityFactoryToUse = entityFactoryToUse;
				_productVendors.GetMultiManyToOne(null, this, null, filter);
				_productVendors.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendors = true;
			}
			return _productVendors;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductVendors'. These settings will be taken into account
		/// when the property ProductVendors is requested or GetMultiProductVendors is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductVendors(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productVendors.SortClauses=sortClauses;
			_productVendors.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("ProductsOfSize", _productsOfSize);
			toReturn.Add("ProductsOfWeight", _productsOfWeight);
			toReturn.Add("ProductVendors", _productVendors);
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
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The validator object for this UnitMeasureEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String unitMeasureCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(unitMeasureCode, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_billOfMaterials = new AW.Data.CollectionClasses.BillOfMaterialCollection();
			_billOfMaterials.SetContainingEntityInfo(this, "UnitMeasure");

			_productsOfSize = new AW.Data.CollectionClasses.ProductCollection();
			_productsOfSize.SetContainingEntityInfo(this, "SizeUnitMeasure");

			_productsOfWeight = new AW.Data.CollectionClasses.ProductCollection();
			_productsOfWeight.SetContainingEntityInfo(this, "WeightUnitMeasure");

			_productVendors = new AW.Data.CollectionClasses.ProductVendorCollection();
			_productVendors.SetContainingEntityInfo(this, "UnitMeasure");
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
			_customProperties.Add("MS_Description", @"Unit of measure lookup table.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)UnitMeasureFieldIndex.UnitMeasureCode].ForcedCurrentValueWrite(unitMeasureCode);
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
			return DAOFactory.CreateUnitMeasureDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UnitMeasureEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UnitMeasureRelations Relations
		{
			get	{ return new UnitMeasureRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillOfMaterials
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.BillOfMaterialCollection(), (IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.BillOfMaterialEntity, 0, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductsOfSize
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("ProductsOfSize")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "ProductsOfSize", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductsOfWeight
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("ProductsOfWeight")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "ProductsOfWeight", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductVendors
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductVendorCollection(), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "UnitMeasureEntity";}
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

		/// <summary> The ModifiedDate property of the Entity UnitMeasure<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)UnitMeasureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity UnitMeasure<br/><br/>
		/// MS_Description: Unit of measure description.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.Name, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.Name, value, true); }
		}

		/// <summary> The UnitMeasureCode property of the Entity UnitMeasure<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection BillOfMaterials
		{
			get	{ return GetMultiBillOfMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BillOfMaterials. When set to true, BillOfMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfMaterials is accessed. You can always execute/ a forced fetch by calling GetMultiBillOfMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfMaterials
		{
			get	{ return _alwaysFetchBillOfMaterials; }
			set	{ _alwaysFetchBillOfMaterials = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillOfMaterials already has been fetched. Setting this property to false when BillOfMaterials has been fetched
		/// will clear the BillOfMaterials collection well. Setting this property to true while BillOfMaterials hasn't been fetched disables lazy loading for BillOfMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillOfMaterials
		{
			get { return _alreadyFetchedBillOfMaterials;}
			set 
			{
				if(_alreadyFetchedBillOfMaterials && !value && (_billOfMaterials != null))
				{
					_billOfMaterials.Clear();
				}
				_alreadyFetchedBillOfMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductsOfSize()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductsOfSize
		{
			get	{ return GetMultiProductsOfSize(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductsOfSize. When set to true, ProductsOfSize is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductsOfSize is accessed. You can always execute/ a forced fetch by calling GetMultiProductsOfSize(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductsOfSize
		{
			get	{ return _alwaysFetchProductsOfSize; }
			set	{ _alwaysFetchProductsOfSize = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductsOfSize already has been fetched. Setting this property to false when ProductsOfSize has been fetched
		/// will clear the ProductsOfSize collection well. Setting this property to true while ProductsOfSize hasn't been fetched disables lazy loading for ProductsOfSize</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductsOfSize
		{
			get { return _alreadyFetchedProductsOfSize;}
			set 
			{
				if(_alreadyFetchedProductsOfSize && !value && (_productsOfSize != null))
				{
					_productsOfSize.Clear();
				}
				_alreadyFetchedProductsOfSize = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductsOfWeight()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductsOfWeight
		{
			get	{ return GetMultiProductsOfWeight(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductsOfWeight. When set to true, ProductsOfWeight is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductsOfWeight is accessed. You can always execute/ a forced fetch by calling GetMultiProductsOfWeight(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductsOfWeight
		{
			get	{ return _alwaysFetchProductsOfWeight; }
			set	{ _alwaysFetchProductsOfWeight = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductsOfWeight already has been fetched. Setting this property to false when ProductsOfWeight has been fetched
		/// will clear the ProductsOfWeight collection well. Setting this property to true while ProductsOfWeight hasn't been fetched disables lazy loading for ProductsOfWeight</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductsOfWeight
		{
			get { return _alreadyFetchedProductsOfWeight;}
			set 
			{
				if(_alreadyFetchedProductsOfWeight && !value && (_productsOfWeight != null))
				{
					_productsOfWeight.Clear();
				}
				_alreadyFetchedProductsOfWeight = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductVendors()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection ProductVendors
		{
			get	{ return GetMultiProductVendors(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductVendors. When set to true, ProductVendors is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductVendors is accessed. You can always execute/ a forced fetch by calling GetMultiProductVendors(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductVendors
		{
			get	{ return _alwaysFetchProductVendors; }
			set	{ _alwaysFetchProductVendors = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductVendors already has been fetched. Setting this property to false when ProductVendors has been fetched
		/// will clear the ProductVendors collection well. Setting this property to true while ProductVendors hasn't been fetched disables lazy loading for ProductVendors</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductVendors
		{
			get { return _alreadyFetchedProductVendors;}
			set 
			{
				if(_alreadyFetchedProductVendors && !value && (_productVendors != null))
				{
					_productVendors.Clear();
				}
				_alreadyFetchedProductVendors = value;
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
			get { return (int)AW.Data.EntityType.UnitMeasureEntity; }
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
