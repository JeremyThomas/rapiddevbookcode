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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesOrderDetail'. <br/><br/>
	/// 
	/// MS_Description: Individual products associated with a specific sales order. See SalesOrderHeader.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesOrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SalesOrderHeaderEntity _salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader, _salesOrderHeaderReturnsNewIfNotFound;
		private SpecialOfferProductEntity _specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct, _specialOfferProductReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name SpecialOfferProduct</summary>
			public static readonly string SpecialOfferProduct = "SpecialOfferProduct";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderDetailEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderDetailEntity() :base("SalesOrderDetailEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID):base("SalesOrderDetailEntity")
		{
			InitClassFetch(salesOrderDetailID, salesOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse):base("SalesOrderDetailEntity")
		{
			InitClassFetch(salesOrderDetailID, salesOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IValidator validator):base("SalesOrderDetailEntity")
		{
			InitClassFetch(salesOrderDetailID, salesOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeader = (SalesOrderHeaderEntity)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderEntity));
			if(_salesOrderHeader!=null)
			{
				_salesOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesOrderHeaderReturnsNewIfNotFound = info.GetBoolean("_salesOrderHeaderReturnsNewIfNotFound");
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_specialOfferProduct = (SpecialOfferProductEntity)info.GetValue("_specialOfferProduct", typeof(SpecialOfferProductEntity));
			if(_specialOfferProduct!=null)
			{
				_specialOfferProduct.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_specialOfferProductReturnsNewIfNotFound = info.GetBoolean("_specialOfferProductReturnsNewIfNotFound");
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesOrderDetailFieldIndex)fieldIndex)
			{
				case SalesOrderDetailFieldIndex.ProductID:
					DesetupSyncSpecialOfferProduct(true, false);
					_alreadyFetchedSpecialOfferProduct = false;
					break;
				case SalesOrderDetailFieldIndex.SalesOrderID:
					DesetupSyncSalesOrderHeader(true, false);
					_alreadyFetchedSalesOrderHeader = false;
					break;
				case SalesOrderDetailFieldIndex.SpecialOfferID:
					DesetupSyncSpecialOfferProduct(true, false);
					_alreadyFetchedSpecialOfferProduct = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader != null);
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct != null);
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
				case "SalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesOrderID);
					break;
				case "SpecialOfferProduct":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductIDSpecialOfferID);
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
			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_salesOrderHeaderReturnsNewIfNotFound", _salesOrderHeaderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_specialOfferProduct", (!this.MarkedForDeletion?_specialOfferProduct:null));
			info.AddValue("_specialOfferProductReturnsNewIfNotFound", _specialOfferProductReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);

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
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					this.SalesOrderHeader = (SalesOrderHeaderEntity)entity;
					break;
				case "SpecialOfferProduct":
					_alreadyFetchedSpecialOfferProduct = true;
					this.SpecialOfferProduct = (SpecialOfferProductEntity)entity;
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
				case "SalesOrderHeader":
					SetupSyncSalesOrderHeader(relatedEntity);
					break;
				case "SpecialOfferProduct":
					SetupSyncSpecialOfferProduct(relatedEntity);
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
				case "SalesOrderHeader":
					DesetupSyncSalesOrderHeader(false, true);
					break;
				case "SpecialOfferProduct":
					DesetupSyncSpecialOfferProduct(false, true);
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
			if(_salesOrderHeader!=null)
			{
				toReturn.Add(_salesOrderHeader);
			}
			if(_specialOfferProduct!=null)
			{
				toReturn.Add(_specialOfferProduct);
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
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderDetailID, System.Int32 salesOrderID)
		{
			return FetchUsingPK(salesOrderDetailID, salesOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesOrderDetailID, salesOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(salesOrderDetailID, salesOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesOrderDetailID, salesOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderDetailID, this.SalesOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderDetailRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public SalesOrderHeaderEntity GetSingleSalesOrderHeader()
		{
			return GetSingleSalesOrderHeader(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public virtual SalesOrderHeaderEntity GetSingleSalesOrderHeader(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesOrderHeaderEntityUsingSalesOrderID);
				SalesOrderHeaderEntity newEntity = new SalesOrderHeaderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SalesOrderID);
				}
				if(fetchResult)
				{
					newEntity = (SalesOrderHeaderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesOrderHeaderReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesOrderHeader = newEntity;
				_alreadyFetchedSalesOrderHeader = fetchResult;
			}
			return _salesOrderHeader;
		}


		/// <summary> Retrieves the related entity of type 'SpecialOfferProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SpecialOfferProductEntity' which is related to this entity.</returns>
		public SpecialOfferProductEntity GetSingleSpecialOfferProduct()
		{
			return GetSingleSpecialOfferProduct(false);
		}

		/// <summary> Retrieves the related entity of type 'SpecialOfferProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SpecialOfferProductEntity' which is related to this entity.</returns>
		public virtual SpecialOfferProductEntity GetSingleSpecialOfferProduct(bool forceFetch)
		{
			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SpecialOfferProductEntityUsingProductIDSpecialOfferID);
				SpecialOfferProductEntity newEntity = new SpecialOfferProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductID, this.SpecialOfferID);
				}
				if(fetchResult)
				{
					newEntity = (SpecialOfferProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_specialOfferProductReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SpecialOfferProduct = newEntity;
				_alreadyFetchedSpecialOfferProduct = fetchResult;
			}
			return _specialOfferProduct;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("SpecialOfferProduct", _specialOfferProduct);
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
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="validator">The validator object for this SalesOrderDetailEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(salesOrderDetailID, salesOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderHeaderReturnsNewIfNotFound = true;
			_specialOfferProductReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Individual products associated with a specific sales order. See SalesOrderHeader.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("CarrierTrackingNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.");
			_fieldsCustomProperties.Add("LineTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity ordered per product.");
			_fieldsCustomProperties.Add("OrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product sold to customer. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. One incremental unique number per product sold.");
			_fieldsCustomProperties.Add("SalesOrderDetailID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");
			_fieldsCustomProperties.Add("SpecialOfferID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Selling price of a single product.");
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Discount amount.");
			_fieldsCustomProperties.Add("UnitPriceDiscount", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AW.Data.RelationClasses.StaticSalesOrderDetailRelations.SalesOrderHeaderEntityUsingSalesOrderIDStatic, true, signalRelatedEntity, "SalesOrderDetails", resetFKFields, new int[] { (int)SalesOrderDetailFieldIndex.SalesOrderID } );		
			_salesOrderHeader = null;
		}
		
		/// <summary> setups the sync logic for member _salesOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesOrderHeader(IEntityCore relatedEntity)
		{
			if(_salesOrderHeader!=relatedEntity)
			{		
				DesetupSyncSalesOrderHeader(true, true);
				_salesOrderHeader = (SalesOrderHeaderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AW.Data.RelationClasses.StaticSalesOrderDetailRelations.SalesOrderHeaderEntityUsingSalesOrderIDStatic, true, ref _alreadyFetchedSalesOrderHeader, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesOrderHeaderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _specialOfferProduct</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSpecialOfferProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _specialOfferProduct, new PropertyChangedEventHandler( OnSpecialOfferProductPropertyChanged ), "SpecialOfferProduct", AW.Data.RelationClasses.StaticSalesOrderDetailRelations.SpecialOfferProductEntityUsingProductIDSpecialOfferIDStatic, true, signalRelatedEntity, "SalesOrderDetails", resetFKFields, new int[] { (int)SalesOrderDetailFieldIndex.ProductID, (int)SalesOrderDetailFieldIndex.SpecialOfferID } );		
			_specialOfferProduct = null;
		}
		
		/// <summary> setups the sync logic for member _specialOfferProduct</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSpecialOfferProduct(IEntityCore relatedEntity)
		{
			if(_specialOfferProduct!=relatedEntity)
			{		
				DesetupSyncSpecialOfferProduct(true, true);
				_specialOfferProduct = (SpecialOfferProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _specialOfferProduct, new PropertyChangedEventHandler( OnSpecialOfferProductPropertyChanged ), "SpecialOfferProduct", AW.Data.RelationClasses.StaticSalesOrderDetailRelations.SpecialOfferProductEntityUsingProductIDSpecialOfferIDStatic, true, ref _alreadyFetchedSpecialOfferProduct, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSpecialOfferProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SalesOrderDetailFieldIndex.SalesOrderDetailID].ForcedCurrentValueWrite(salesOrderDetailID);
				this.Fields[(int)SalesOrderDetailFieldIndex.SalesOrderID].ForcedCurrentValueWrite(salesOrderID);
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
			return DAOFactory.CreateSalesOrderDetailDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesOrderDetailEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesOrderDetailRelations Relations
		{
			get	{ return new SalesOrderDetailRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.SalesOrderDetailEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProduct
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(), (IEntityRelation)GetRelationsForField("SpecialOfferProduct")[0], (int)AW.Data.EntityType.SalesOrderDetailEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CarrierTrackingNumber property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."CarrierTrackingNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CarrierTrackingNumber
		{
			get { return (System.String)GetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, value, true); }
		}

		/// <summary> The LineTotal property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.<br/>Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."LineTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 38, 6, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.LineTotal, true); }

		}

		/// <summary> The ModifiedDate property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OrderQty property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Quantity ordered per product.<br/>Quantity ordered per product.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."OrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQty
		{
			get { return (System.Int16)GetValue((int)SalesOrderDetailFieldIndex.OrderQty, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.OrderQty, value, true); }
		}

		/// <summary> The ProductID property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Product sold to customer. Foreign key to Product.ProductID.<br/>Product sold to customer. Foreign key to Product.ProductID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.ProductID, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ProductID, value, true); }
		}

		/// <summary> The Rowguid property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderDetailFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SalesOrderDetailID property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Primary key. One incremental unique number per product sold.<br/>Primary key. One incremental unique number per product sold.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderDetailID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderDetailID
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailID, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailID, value, true); }
		}

		/// <summary> The SalesOrderID property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesOrderID
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderID, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SalesOrderID, value, true); }
		}

		/// <summary> The SpecialOfferID property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Promotional code. Foreign key to SpecialOffer.SpecialOfferID.<br/>Promotional code. Foreign key to SpecialOffer.SpecialOfferID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SpecialOfferID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 SpecialOfferID
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SpecialOfferID, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SpecialOfferID, value, true); }
		}

		/// <summary> The UnitPrice property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Selling price of a single product.<br/>Selling price of a single product.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPrice, value, true); }
		}

		/// <summary> The UnitPriceDiscount property of the Entity SalesOrderDetail<br/><br/>
		/// MS_Description: Discount amount.<br/>Discount amount.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPriceDiscount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPriceDiscount
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'SalesOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get	{ return GetSingleSalesOrderHeader(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesOrderHeader(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderDetails", "SalesOrderHeader", _salesOrderHeader, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute a forced fetch by calling GetSingleSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesOrderHeader; }
			set	{ _alwaysFetchSalesOrderHeader = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeader already has been fetched. Setting this property to false when SalesOrderHeader has been fetched
		/// will set SalesOrderHeader to null as well. Setting this property to true while SalesOrderHeader hasn't been fetched disables lazy loading for SalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeader
		{
			get { return _alreadyFetchedSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeader && !value)
				{
					this.SalesOrderHeader = null;
				}
				_alreadyFetchedSalesOrderHeader = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesOrderHeader is not found
		/// in the database. When set to true, SalesOrderHeader will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesOrderHeaderReturnsNewIfNotFound
		{
			get	{ return _salesOrderHeaderReturnsNewIfNotFound; }
			set { _salesOrderHeaderReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SpecialOfferProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SpecialOfferProductEntity SpecialOfferProduct
		{
			get	{ return GetSingleSpecialOfferProduct(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSpecialOfferProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderDetails", "SpecialOfferProduct", _specialOfferProduct, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProduct. When set to true, SpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProduct is accessed. You can always execute a forced fetch by calling GetSingleSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferProduct = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferProduct already has been fetched. Setting this property to false when SpecialOfferProduct has been fetched
		/// will set SpecialOfferProduct to null as well. Setting this property to true while SpecialOfferProduct hasn't been fetched disables lazy loading for SpecialOfferProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferProduct
		{
			get { return _alreadyFetchedSpecialOfferProduct;}
			set 
			{
				if(_alreadyFetchedSpecialOfferProduct && !value)
				{
					this.SpecialOfferProduct = null;
				}
				_alreadyFetchedSpecialOfferProduct = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SpecialOfferProduct is not found
		/// in the database. When set to true, SpecialOfferProduct will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SpecialOfferProductReturnsNewIfNotFound
		{
			get	{ return _specialOfferProductReturnsNewIfNotFound; }
			set { _specialOfferProductReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.SalesOrderDetailEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public string ProductName
        {
            get {return this.SpecialOfferProduct.Product.Name; }
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
