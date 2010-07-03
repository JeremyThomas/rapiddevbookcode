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
	
	/// <summary>Entity base class which represents the base class for the entity 'PurchaseOrderDetail'.<br/><br/>
	/// 
	/// MS_Description: Individual products associated with a specific purchase order. See PurchaseOrderHeader.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class PurchaseOrderDetailEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;
		private PurchaseOrderHeaderEntity _purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader, _purchaseOrderHeaderReturnsNewIfNotFound;

		
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
			/// <summary>Member name PurchaseOrderHeader</summary>
			public static readonly string PurchaseOrderHeader = "PurchaseOrderHeader";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderDetailEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PurchaseOrderDetailEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		public PurchaseOrderDetailEntityBase(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderDetailEntityBase(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		public PurchaseOrderDetailEntityBase(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IValidator validator)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderDetailEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_purchaseOrderHeader = (PurchaseOrderHeaderEntity)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderEntity));
			if(_purchaseOrderHeader!=null)
			{
				_purchaseOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_purchaseOrderHeaderReturnsNewIfNotFound = info.GetBoolean("_purchaseOrderHeaderReturnsNewIfNotFound");
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((PurchaseOrderDetailFieldIndex)fieldIndex)
			{
				case PurchaseOrderDetailFieldIndex.PurchaseOrderID:
					DesetupSyncPurchaseOrderHeader(true, false);
					_alreadyFetchedPurchaseOrderHeader = false;
					break;
				case PurchaseOrderDetailFieldIndex.ProductID:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
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
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return PurchaseOrderDetailEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID);
					break;
				case "PurchaseOrderHeader":
					toReturn.Add(PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
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
			info.AddValue("_purchaseOrderHeader", (!this.MarkedForDeletion?_purchaseOrderHeader:null));
			info.AddValue("_purchaseOrderHeaderReturnsNewIfNotFound", _purchaseOrderHeaderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);

			
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
				case "PurchaseOrderHeader":
					_alreadyFetchedPurchaseOrderHeader = true;
					this.PurchaseOrderHeader = (PurchaseOrderHeaderEntity)entity;
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
				case "PurchaseOrderHeader":
					SetupSyncPurchaseOrderHeader(relatedEntity);
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
				case "PurchaseOrderHeader":
					DesetupSyncPurchaseOrderHeader(false, true);
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
			if(_purchaseOrderHeader!=null)
			{
				toReturn.Add(_purchaseOrderHeader);
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
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID)
		{
			return FetchUsingPK(purchaseOrderID, purchaseOrderDetailID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(purchaseOrderID, purchaseOrderDetailID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(purchaseOrderID, purchaseOrderDetailID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(purchaseOrderID, purchaseOrderDetailID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.PurchaseOrderID, this.PurchaseOrderDetailID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(PurchaseOrderDetailFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(PurchaseOrderDetailFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderDetailRelations().GetAllRelations();
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID);

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

		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader()
		{
			return GetSinglePurchaseOrderHeader(false);
		}

		/// <summary> Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader(bool forceFetch)
		{
			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);

				PurchaseOrderHeaderEntity newEntity = new PurchaseOrderHeaderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.PurchaseOrderID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (PurchaseOrderHeaderEntity)base.ActiveContext.Get(newEntity);
					}
					this.PurchaseOrderHeader = newEntity;
				}
				else
				{
					if(_purchaseOrderHeaderReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_purchaseOrderHeader == null)))
						{
							this.PurchaseOrderHeader = newEntity;
						}
					}
					else
					{
						this.PurchaseOrderHeader = null;
					}
				}
				_alreadyFetchedPurchaseOrderHeader = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _purchaseOrderHeader;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			PurchaseOrderDetailDAO dao = (PurchaseOrderDetailDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_product!=null)
			{
				_product.ActiveContext = base.ActiveContext;
			}
			if(_purchaseOrderHeader!=null)
			{
				_purchaseOrderHeader.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			PurchaseOrderDetailDAO dao = (PurchaseOrderDetailDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			PurchaseOrderDetailDAO dao = (PurchaseOrderDetailDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.PurchaseOrderDetailEntity);
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
			toReturn.Add("PurchaseOrderHeader", _purchaseOrderHeader);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The validator object for this PurchaseOrderDetailEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(purchaseOrderID, purchaseOrderDetailID, prefetchPathToUse, null, null);
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
			_purchaseOrderHeader = null;
			_purchaseOrderHeaderReturnsNewIfNotFound = true;
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;


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
			_customProperties.Add("MS_Description", @"Individual products associated with a specific purchase order. See PurchaseOrderHeader.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("PurchaseOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. One line number per purchased product.");
			_fieldsCustomProperties.Add("PurchaseOrderDetailID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product is expected to be received.");
			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity ordered.");
			_fieldsCustomProperties.Add("OrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product identification number. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor's selling price of a single product.");
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Per product subtotal. Computed as OrderQty * UnitPrice.");
			_fieldsCustomProperties.Add("LineTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity actually received from the vendor.");
			_fieldsCustomProperties.Add("ReceivedQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity rejected during inspection.");
			_fieldsCustomProperties.Add("RejectedQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.");
			_fieldsCustomProperties.Add("StockedQty", fieldHashtable);
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
			base.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID, true, signalRelatedEntity, "PurchaseOrderDetail", resetFKFields, new int[] { (int)PurchaseOrderDetailFieldIndex.ProductID } );		
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
				base.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID, true, ref _alreadyFetchedProduct, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _purchaseOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPurchaseOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _purchaseOrderHeader, new PropertyChangedEventHandler( OnPurchaseOrderHeaderPropertyChanged ), "PurchaseOrderHeader", PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID, true, signalRelatedEntity, "PurchaseOrderDetail", resetFKFields, new int[] { (int)PurchaseOrderDetailFieldIndex.PurchaseOrderID } );		
			_purchaseOrderHeader = null;
		}
		
		/// <summary> setups the sync logic for member _purchaseOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPurchaseOrderHeader(IEntity relatedEntity)
		{
			if(_purchaseOrderHeader!=relatedEntity)
			{		
				DesetupSyncPurchaseOrderHeader(true, true);
				_purchaseOrderHeader = (PurchaseOrderHeaderEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _purchaseOrderHeader, new PropertyChangedEventHandler( OnPurchaseOrderHeaderPropertyChanged ), "PurchaseOrderHeader", PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID, true, ref _alreadyFetchedPurchaseOrderHeader, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPurchaseOrderHeaderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)PurchaseOrderDetailFieldIndex.PurchaseOrderID].ForcedCurrentValueWrite(purchaseOrderID);
				base.Fields[(int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID].ForcedCurrentValueWrite(purchaseOrderDetailID);
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
			return DAOFactory.CreatePurchaseOrderDetailDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PurchaseOrderDetailEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PurchaseOrderDetailRelations Relations
		{
			get	{ return new PurchaseOrderDetailRelations(); }
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
					(IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.PurchaseOrderDetailEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("PurchaseOrderHeader")[0], (int)AW.Data.EntityType.PurchaseOrderDetailEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "PurchaseOrderDetailEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return PurchaseOrderDetailEntity.CustomProperties;}
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
			get { return PurchaseOrderDetailEntity.FieldsCustomProperties;}
		}

		/// <summary> The PurchaseOrderID property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PurchaseOrderID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, value, true); }
		}
		/// <summary> The PurchaseOrderDetailID property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Primary key. One line number per purchased product.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."PurchaseOrderDetailID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderDetailID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, value, true); }
		}
		/// <summary> The DueDate property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Date the product is expected to be received.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.DueDate, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.DueDate, value, true); }
		}
		/// <summary> The OrderQty property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Quantity ordered.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."OrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQty
		{
			get { return (System.Int16)GetValue((int)PurchaseOrderDetailFieldIndex.OrderQty, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.OrderQty, value, true); }
		}
		/// <summary> The ProductID property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Product identification number. Foreign key to Product.ProductID.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderDetailFieldIndex.ProductID, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ProductID, value, true); }
		}
		/// <summary> The UnitPrice property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Vendor's selling price of a single product.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, value, true); }
		}
		/// <summary> The LineTotal property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Per product subtotal. Computed as OrderQty * UnitPrice.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."LineTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.LineTotal, true); }

		}
		/// <summary> The ReceivedQty property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Quantity actually received from the vendor.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ReceivedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ReceivedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty, value, true); }
		}
		/// <summary> The RejectedQty property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Quantity rejected during inspection.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."RejectedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal RejectedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.RejectedQty, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.RejectedQty, value, true); }
		}
		/// <summary> The StockedQty property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."StockedQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StockedQty
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderDetailFieldIndex.StockedQty, true); }

		}
		/// <summary> The ModifiedDate property of the Entity PurchaseOrderDetail<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderDetail"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, value, true); }
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
							_product.UnsetRelatedEntity(this, "PurchaseOrderDetail");
						}
					}
					else
					{
						if(_product!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderDetail");
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
		/// <summary> Gets / sets related entity of type 'PurchaseOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PurchaseOrderHeaderEntity PurchaseOrderHeader
		{
			get	{ return GetSinglePurchaseOrderHeader(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncPurchaseOrderHeader(value);
				}
				else
				{
					if(value==null)
					{
						if(_purchaseOrderHeader != null)
						{
							_purchaseOrderHeader.UnsetRelatedEntity(this, "PurchaseOrderDetail");
						}
					}
					else
					{
						if(_purchaseOrderHeader!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "PurchaseOrderDetail");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetSinglePurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get	{ return _alwaysFetchPurchaseOrderHeader; }
			set	{ _alwaysFetchPurchaseOrderHeader = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeader already has been fetched. Setting this property to false when PurchaseOrderHeader has been fetched
		/// will set PurchaseOrderHeader to null as well. Setting this property to true while PurchaseOrderHeader hasn't been fetched disables lazy loading for PurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeader
		{
			get { return _alreadyFetchedPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeader && !value)
				{
					this.PurchaseOrderHeader = null;
				}
				_alreadyFetchedPurchaseOrderHeader = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property PurchaseOrderHeader is not found
		/// in the database. When set to true, PurchaseOrderHeader will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool PurchaseOrderHeaderReturnsNewIfNotFound
		{
			get	{ return _purchaseOrderHeaderReturnsNewIfNotFound; }
			set { _purchaseOrderHeaderReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.PurchaseOrderDetailEntity; }
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
