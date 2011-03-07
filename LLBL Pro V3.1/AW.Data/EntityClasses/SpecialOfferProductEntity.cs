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

	/// <summary>Entity class which represents the entity 'SpecialOfferProduct'. <br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping products to special offer discounts.<br/>
	/// </summary>
	[Serializable]
	public partial class SpecialOfferProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderDetailCollection	_salesOrderDetails;
		private bool	_alwaysFetchSalesOrderDetails, _alreadyFetchedSalesOrderDetails;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection _salesOrderHeaderCollectionViaSalesOrderDetail;
		private bool	_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail, _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail;
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private SpecialOfferEntity _specialOffer;
		private bool	_alwaysFetchSpecialOffer, _alreadyFetchedSpecialOffer, _specialOfferReturnsNewIfNotFound;

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
			/// <summary>Member name SpecialOffer</summary>
			public static readonly string SpecialOffer = "SpecialOffer";
			/// <summary>Member name SalesOrderDetails</summary>
			public static readonly string SalesOrderDetails = "SalesOrderDetails";
			/// <summary>Member name SalesOrderHeaderCollectionViaSalesOrderDetail</summary>
			public static readonly string SalesOrderHeaderCollectionViaSalesOrderDetail = "SalesOrderHeaderCollectionViaSalesOrderDetail";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SpecialOfferProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SpecialOfferProductEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		public SpecialOfferProductEntity(System.Int32 productID, System.Int32 specialOfferID)
		{
			InitClassFetch(productID, specialOfferID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SpecialOfferProductEntity(System.Int32 productID, System.Int32 specialOfferID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productID, specialOfferID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		public SpecialOfferProductEntity(System.Int32 productID, System.Int32 specialOfferID, IValidator validator)
		{
			InitClassFetch(productID, specialOfferID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SpecialOfferProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderDetails = (AW.Data.CollectionClasses.SalesOrderDetailCollection)info.GetValue("_salesOrderDetails", typeof(AW.Data.CollectionClasses.SalesOrderDetailCollection));
			_alwaysFetchSalesOrderDetails = info.GetBoolean("_alwaysFetchSalesOrderDetails");
			_alreadyFetchedSalesOrderDetails = info.GetBoolean("_alreadyFetchedSalesOrderDetails");
			_salesOrderHeaderCollectionViaSalesOrderDetail = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaderCollectionViaSalesOrderDetail", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail = info.GetBoolean("_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail");
			_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail = info.GetBoolean("_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail");
			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_specialOffer = (SpecialOfferEntity)info.GetValue("_specialOffer", typeof(SpecialOfferEntity));
			if(_specialOffer!=null)
			{
				_specialOffer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_specialOfferReturnsNewIfNotFound = info.GetBoolean("_specialOfferReturnsNewIfNotFound");
			_alwaysFetchSpecialOffer = info.GetBoolean("_alwaysFetchSpecialOffer");
			_alreadyFetchedSpecialOffer = info.GetBoolean("_alreadyFetchedSpecialOffer");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SpecialOfferProductFieldIndex)fieldIndex)
			{
				case SpecialOfferProductFieldIndex.ProductID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				case SpecialOfferProductFieldIndex.SpecialOfferID:
					DesetupSyncSpecialOffer(true, false);
					_alreadyFetchedSpecialOffer = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderDetails = (_salesOrderDetails.Count > 0);
			_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail = (_salesOrderHeaderCollectionViaSalesOrderDetail.Count > 0);
			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedSpecialOffer = (_specialOffer != null);
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
				case "SpecialOffer":
					toReturn.Add(Relations.SpecialOfferEntityUsingSpecialOfferID);
					break;
				case "SalesOrderDetails":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingProductIDSpecialOfferID);
					break;
				case "SalesOrderHeaderCollectionViaSalesOrderDetail":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingProductIDSpecialOfferID, "SpecialOfferProductEntity__", "SalesOrderDetail_", JoinHint.None);
					toReturn.Add(SalesOrderDetailEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID, "SalesOrderDetail_", string.Empty, JoinHint.None);
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
			info.AddValue("_salesOrderDetails", (!this.MarkedForDeletion?_salesOrderDetails:null));
			info.AddValue("_alwaysFetchSalesOrderDetails", _alwaysFetchSalesOrderDetails);
			info.AddValue("_alreadyFetchedSalesOrderDetails", _alreadyFetchedSalesOrderDetails);
			info.AddValue("_salesOrderHeaderCollectionViaSalesOrderDetail", (!this.MarkedForDeletion?_salesOrderHeaderCollectionViaSalesOrderDetail:null));
			info.AddValue("_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail", _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail);
			info.AddValue("_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail", _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail);
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_productReturnsNewIfNotFound", _productReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_specialOffer", (!this.MarkedForDeletion?_specialOffer:null));
			info.AddValue("_specialOfferReturnsNewIfNotFound", _specialOfferReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSpecialOffer", _alwaysFetchSpecialOffer);
			info.AddValue("_alreadyFetchedSpecialOffer", _alreadyFetchedSpecialOffer);

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
				case "SpecialOffer":
					_alreadyFetchedSpecialOffer = true;
					this.SpecialOffer = (SpecialOfferEntity)entity;
					break;
				case "SalesOrderDetails":
					_alreadyFetchedSalesOrderDetails = true;
					if(entity!=null)
					{
						this.SalesOrderDetails.Add((SalesOrderDetailEntity)entity);
					}
					break;
				case "SalesOrderHeaderCollectionViaSalesOrderDetail":
					_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail = true;
					if(entity!=null)
					{
						this.SalesOrderHeaderCollectionViaSalesOrderDetail.Add((SalesOrderHeaderEntity)entity);
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
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "SpecialOffer":
					SetupSyncSpecialOffer(relatedEntity);
					break;
				case "SalesOrderDetails":
					_salesOrderDetails.Add((SalesOrderDetailEntity)relatedEntity);
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
				case "SpecialOffer":
					DesetupSyncSpecialOffer(false, true);
					break;
				case "SalesOrderDetails":
					this.PerformRelatedEntityRemoval(_salesOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_specialOffer!=null)
			{
				toReturn.Add(_specialOffer);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_salesOrderDetails);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 specialOfferID)
		{
			return FetchUsingPK(productID, specialOfferID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 specialOfferID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productID, specialOfferID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 specialOfferID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productID, specialOfferID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, System.Int32 specialOfferID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productID, specialOfferID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductID, this.SpecialOfferID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SpecialOfferProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch)
		{
			return GetMultiSalesOrderDetails(forceFetch, _salesOrderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderDetails(forceFetch, _salesOrderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetails || forceFetch || _alwaysFetchSalesOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderDetails);
				_salesOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderDetails.GetMultiManyToOne(null, this, filter);
				_salesOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetails = true;
			}
			return _salesOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderDetails'. These settings will be taken into account
		/// when the property SalesOrderDetails is requested or GetMultiSalesOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderDetails.SortClauses=sortClauses;
			_salesOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail(bool forceFetch)
		{
			return GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail(forceFetch, _salesOrderHeaderCollectionViaSalesOrderDetail.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaderCollectionViaSalesOrderDetail);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "SpecialOfferProductEntity__"));
				filter.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.SpecialOfferID, ComparisonOperator.Equal, this.SpecialOfferID, "SpecialOfferProductEntity__"));
				_salesOrderHeaderCollectionViaSalesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderCollectionViaSalesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaderCollectionViaSalesOrderDetail.GetMulti(filter, GetRelationsForField("SalesOrderHeaderCollectionViaSalesOrderDetail"));
				_salesOrderHeaderCollectionViaSalesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail = true;
			}
			return _salesOrderHeaderCollectionViaSalesOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaderCollectionViaSalesOrderDetail'. These settings will be taken into account
		/// when the property SalesOrderHeaderCollectionViaSalesOrderDetail is requested or GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaderCollectionViaSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaderCollectionViaSalesOrderDetail.SortClauses=sortClauses;
			_salesOrderHeaderCollectionViaSalesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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


		/// <summary> Retrieves the related entity of type 'SpecialOfferEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SpecialOfferEntity' which is related to this entity.</returns>
		public SpecialOfferEntity GetSingleSpecialOffer()
		{
			return GetSingleSpecialOffer(false);
		}

		/// <summary> Retrieves the related entity of type 'SpecialOfferEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SpecialOfferEntity' which is related to this entity.</returns>
		public virtual SpecialOfferEntity GetSingleSpecialOffer(bool forceFetch)
		{
			if( ( !_alreadyFetchedSpecialOffer || forceFetch || _alwaysFetchSpecialOffer) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SpecialOfferEntityUsingSpecialOfferID);
				SpecialOfferEntity newEntity = new SpecialOfferEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SpecialOfferID);
				}
				if(fetchResult)
				{
					newEntity = (SpecialOfferEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_specialOfferReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SpecialOffer = newEntity;
				_alreadyFetchedSpecialOffer = fetchResult;
			}
			return _specialOffer;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderDetails.ActiveContext = this.ActiveContext;
			_salesOrderHeaderCollectionViaSalesOrderDetail.ActiveContext = this.ActiveContext;
			if(_product!=null)
			{
				_product.ActiveContext = this.ActiveContext;
			}
			if(_specialOffer!=null)
			{
				_specialOffer.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("SpecialOffer", _specialOffer);
			toReturn.Add("SalesOrderDetails", _salesOrderDetails);
			toReturn.Add("SalesOrderHeaderCollectionViaSalesOrderDetail", _salesOrderHeaderCollectionViaSalesOrderDetail);
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
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="validator">The validator object for this SpecialOfferProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productID, System.Int32 specialOfferID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productID, specialOfferID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderDetails = new AW.Data.CollectionClasses.SalesOrderDetailCollection();
			_salesOrderDetails.SetContainingEntityInfo(this, "SpecialOfferProduct");
			_salesOrderHeaderCollectionViaSalesOrderDetail = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_productReturnsNewIfNotFound = true;
			_specialOfferReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping products to special offer discounts.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product identification number. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SpecialOfferID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", SpecialOfferProductEntity.Relations.ProductEntityUsingProductID, true, signalRelatedEntity, "SpecialOfferProducts", resetFKFields, new int[] { (int)SpecialOfferProductFieldIndex.ProductID } );		
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
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", SpecialOfferProductEntity.Relations.ProductEntityUsingProductID, true, ref _alreadyFetchedProduct, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _specialOffer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSpecialOffer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _specialOffer, new PropertyChangedEventHandler( OnSpecialOfferPropertyChanged ), "SpecialOffer", SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferID, true, signalRelatedEntity, "SpecialOfferProducts", resetFKFields, new int[] { (int)SpecialOfferProductFieldIndex.SpecialOfferID } );		
			_specialOffer = null;
		}
		
		/// <summary> setups the sync logic for member _specialOffer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSpecialOffer(IEntity relatedEntity)
		{
			if(_specialOffer!=relatedEntity)
			{		
				DesetupSyncSpecialOffer(true, true);
				_specialOffer = (SpecialOfferEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _specialOffer, new PropertyChangedEventHandler( OnSpecialOfferPropertyChanged ), "SpecialOffer", SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferID, true, ref _alreadyFetchedSpecialOffer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSpecialOfferPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productID, System.Int32 specialOfferID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SpecialOfferProductFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				this.Fields[(int)SpecialOfferProductFieldIndex.SpecialOfferID].ForcedCurrentValueWrite(specialOfferID);
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
			return DAOFactory.CreateSpecialOfferProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SpecialOfferProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SpecialOfferProductRelations Relations
		{
			get	{ return new SpecialOfferProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderDetails
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderDetailCollection(), (IEntityRelation)GetRelationsForField("SalesOrderDetails")[0], (int)AW.Data.EntityType.SpecialOfferProductEntity, (int)AW.Data.EntityType.SalesOrderDetailEntity, 0, null, null, null, "SalesOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaderCollectionViaSalesOrderDetail
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderDetailEntityUsingProductIDSpecialOfferID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderDetail_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), intermediateRelation,	(int)AW.Data.EntityType.SpecialOfferProductEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, GetRelationsForField("SalesOrderHeaderCollectionViaSalesOrderDetail"), "SalesOrderHeaderCollectionViaSalesOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.SpecialOfferProductEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOffer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOffer
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferCollection(), (IEntityRelation)GetRelationsForField("SpecialOffer")[0], (int)AW.Data.EntityType.SpecialOfferProductEntity, (int)AW.Data.EntityType.SpecialOfferEntity, 0, null, null, null, "SpecialOffer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "SpecialOfferProductEntity";}
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

		/// <summary> The ModifiedDate property of the Entity SpecialOfferProduct<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The ProductID property of the Entity SpecialOfferProduct<br/><br/>
		/// MS_Description: Product identification number. Foreign key to Product.ProductID.<br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.ProductID, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ProductID, value, true); }
		}

		/// <summary> The Rowguid property of the Entity SpecialOfferProduct<br/><br/>
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SpecialOfferProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SpecialOfferID property of the Entity SpecialOfferProduct<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."SpecialOfferID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SpecialOfferID
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.SpecialOfferID, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.SpecialOfferID, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection SalesOrderDetails
		{
			get	{ return GetMultiSalesOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderDetails. When set to true, SalesOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderDetails
		{
			get	{ return _alwaysFetchSalesOrderDetails; }
			set	{ _alwaysFetchSalesOrderDetails = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderDetails already has been fetched. Setting this property to false when SalesOrderDetails has been fetched
		/// will clear the SalesOrderDetails collection well. Setting this property to true while SalesOrderDetails hasn't been fetched disables lazy loading for SalesOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderDetails
		{
			get { return _alreadyFetchedSalesOrderDetails;}
			set 
			{
				if(_alreadyFetchedSalesOrderDetails && !value && (_salesOrderDetails != null))
				{
					_salesOrderDetails.Clear();
				}
				_alreadyFetchedSalesOrderDetails = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaderCollectionViaSalesOrderDetail
		{
			get { return GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaderCollectionViaSalesOrderDetail. When set to true, SalesOrderHeaderCollectionViaSalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaderCollectionViaSalesOrderDetail is accessed. You can always execute a forced fetch by calling GetMultiSalesOrderHeaderCollectionViaSalesOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail
		{
			get	{ return _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail; }
			set	{ _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderDetail = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaderCollectionViaSalesOrderDetail already has been fetched. Setting this property to false when SalesOrderHeaderCollectionViaSalesOrderDetail has been fetched
		/// will clear the SalesOrderHeaderCollectionViaSalesOrderDetail collection well. Setting this property to true while SalesOrderHeaderCollectionViaSalesOrderDetail hasn't been fetched disables lazy loading for SalesOrderHeaderCollectionViaSalesOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail
		{
			get { return _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail && !value && (_salesOrderHeaderCollectionViaSalesOrderDetail != null))
				{
					_salesOrderHeaderCollectionViaSalesOrderDetail.Clear();
				}
				_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderDetail = value;
			}
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
					SetSingleRelatedEntityNavigator(value, "SpecialOfferProducts", "Product", _product, true); 
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

		/// <summary> Gets / sets related entity of type 'SpecialOfferEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSpecialOffer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual SpecialOfferEntity SpecialOffer
		{
			get	{ return GetSingleSpecialOffer(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSpecialOffer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SpecialOfferProducts", "SpecialOffer", _specialOffer, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOffer. When set to true, SpecialOffer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOffer is accessed. You can always execute a forced fetch by calling GetSingleSpecialOffer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOffer
		{
			get	{ return _alwaysFetchSpecialOffer; }
			set	{ _alwaysFetchSpecialOffer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOffer already has been fetched. Setting this property to false when SpecialOffer has been fetched
		/// will set SpecialOffer to null as well. Setting this property to true while SpecialOffer hasn't been fetched disables lazy loading for SpecialOffer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOffer
		{
			get { return _alreadyFetchedSpecialOffer;}
			set 
			{
				if(_alreadyFetchedSpecialOffer && !value)
				{
					this.SpecialOffer = null;
				}
				_alreadyFetchedSpecialOffer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SpecialOffer is not found
		/// in the database. When set to true, SpecialOffer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SpecialOfferReturnsNewIfNotFound
		{
			get	{ return _specialOfferReturnsNewIfNotFound; }
			set { _specialOfferReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.SpecialOfferProductEntity; }
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
