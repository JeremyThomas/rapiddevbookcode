///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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

	/// <summary>Entity class which represents the entity 'BillOfMaterial'. <br/><br/>
	/// 
	/// MS_Description: Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.<br/>
	/// </summary>
	[Serializable]
	public partial class BillOfMaterialEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductEntity _productAssembly;
		private bool	_alwaysFetchProductAssembly, _alreadyFetchedProductAssembly, _productAssemblyReturnsNewIfNotFound;
		private ProductEntity _productComponent;
		private bool	_alwaysFetchProductComponent, _alreadyFetchedProductComponent, _productComponentReturnsNewIfNotFound;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure, _unitMeasureReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductAssembly</summary>
			public static readonly string ProductAssembly = "ProductAssembly";
			/// <summary>Member name ProductComponent</summary>
			public static readonly string ProductComponent = "ProductComponent";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BillOfMaterialEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BillOfMaterialEntity() :base("BillOfMaterialEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID):base("BillOfMaterialEntity")
		{
			InitClassFetch(billOfMaterialsID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse):base("BillOfMaterialEntity")
		{
			InitClassFetch(billOfMaterialsID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="validator">The custom validator object for this BillOfMaterialEntity</param>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsID, IValidator validator):base("BillOfMaterialEntity")
		{
			InitClassFetch(billOfMaterialsID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BillOfMaterialEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productAssembly = (ProductEntity)info.GetValue("_productAssembly", typeof(ProductEntity));
			if(_productAssembly!=null)
			{
				_productAssembly.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productAssemblyReturnsNewIfNotFound = info.GetBoolean("_productAssemblyReturnsNewIfNotFound");
			_alwaysFetchProductAssembly = info.GetBoolean("_alwaysFetchProductAssembly");
			_alreadyFetchedProductAssembly = info.GetBoolean("_alreadyFetchedProductAssembly");

			_productComponent = (ProductEntity)info.GetValue("_productComponent", typeof(ProductEntity));
			if(_productComponent!=null)
			{
				_productComponent.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productComponentReturnsNewIfNotFound = info.GetBoolean("_productComponentReturnsNewIfNotFound");
			_alwaysFetchProductComponent = info.GetBoolean("_alwaysFetchProductComponent");
			_alreadyFetchedProductComponent = info.GetBoolean("_alreadyFetchedProductComponent");

			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_unitMeasureReturnsNewIfNotFound = info.GetBoolean("_unitMeasureReturnsNewIfNotFound");
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((BillOfMaterialFieldIndex)fieldIndex)
			{
				case BillOfMaterialFieldIndex.ComponentID:
					DesetupSyncProductComponent(true, false);
					_alreadyFetchedProductComponent = false;
					break;
				case BillOfMaterialFieldIndex.ProductAssemblyID:
					DesetupSyncProductAssembly(true, false);
					_alreadyFetchedProductAssembly = false;
					break;
				case BillOfMaterialFieldIndex.UnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					_alreadyFetchedUnitMeasure = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProductAssembly = (_productAssembly != null);
			_alreadyFetchedProductComponent = (_productComponent != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);
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
				case "ProductAssembly":
					toReturn.Add(Relations.ProductEntityUsingProductAssemblyID);
					break;
				case "ProductComponent":
					toReturn.Add(Relations.ProductEntityUsingComponentID);
					break;
				case "UnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingUnitMeasureCode);
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
			info.AddValue("_productAssembly", (!this.MarkedForDeletion?_productAssembly:null));
			info.AddValue("_productAssemblyReturnsNewIfNotFound", _productAssemblyReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductAssembly", _alwaysFetchProductAssembly);
			info.AddValue("_alreadyFetchedProductAssembly", _alreadyFetchedProductAssembly);
			info.AddValue("_productComponent", (!this.MarkedForDeletion?_productComponent:null));
			info.AddValue("_productComponentReturnsNewIfNotFound", _productComponentReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductComponent", _alwaysFetchProductComponent);
			info.AddValue("_alreadyFetchedProductComponent", _alreadyFetchedProductComponent);
			info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
			info.AddValue("_unitMeasureReturnsNewIfNotFound", _unitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);

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
				case "ProductAssembly":
					_alreadyFetchedProductAssembly = true;
					this.ProductAssembly = (ProductEntity)entity;
					break;
				case "ProductComponent":
					_alreadyFetchedProductComponent = true;
					this.ProductComponent = (ProductEntity)entity;
					break;
				case "UnitMeasure":
					_alreadyFetchedUnitMeasure = true;
					this.UnitMeasure = (UnitMeasureEntity)entity;
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
				case "ProductAssembly":
					SetupSyncProductAssembly(relatedEntity);
					break;
				case "ProductComponent":
					SetupSyncProductComponent(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
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
				case "ProductAssembly":
					DesetupSyncProductAssembly(false, true);
					break;
				case "ProductComponent":
					DesetupSyncProductComponent(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
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
			if(_productAssembly!=null)
			{
				toReturn.Add(_productAssembly);
			}
			if(_productComponent!=null)
			{
				toReturn.Add(_productComponent);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
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
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID)
		{
			return FetchUsingPK(billOfMaterialsID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(billOfMaterialsID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(billOfMaterialsID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(billOfMaterialsID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BillOfMaterialsID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BillOfMaterialRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProductAssembly()
		{
			return GetSingleProductAssembly(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProductAssembly(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductAssembly || forceFetch || _alwaysFetchProductAssembly) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingProductAssemblyID);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductAssemblyID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productAssemblyReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ProductAssembly = newEntity;
				_alreadyFetchedProductAssembly = fetchResult;
			}
			return _productAssembly;
		}


		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProductComponent()
		{
			return GetSingleProductComponent(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProductComponent(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductComponent || forceFetch || _alwaysFetchProductComponent) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingComponentID);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ComponentID);
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productComponentReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ProductComponent = newEntity;
				_alreadyFetchedProductComponent = fetchResult;
			}
			return _productComponent;
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
			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UnitMeasureEntityUsingUnitMeasureCode);
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.UnitMeasureCode);
				}
				if(fetchResult)
				{
					newEntity = (UnitMeasureEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_unitMeasureReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.UnitMeasure = newEntity;
				_alreadyFetchedUnitMeasure = fetchResult;
			}
			return _unitMeasure;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductAssembly", _productAssembly);
			toReturn.Add("ProductComponent", _productComponent);
			toReturn.Add("UnitMeasure", _unitMeasure);
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
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="validator">The validator object for this BillOfMaterialEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 billOfMaterialsID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(billOfMaterialsID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productAssemblyReturnsNewIfNotFound = true;
			_productComponentReturnsNewIfNotFound = true;
			_unitMeasureReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index.");
			_fieldsCustomProperties.Add("BillOfMaterialsID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Indicates the depth the component is from its parent (AssemblyID).");
			_fieldsCustomProperties.Add("Bomlevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("ComponentID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the component stopped being used in the assembly item.");
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Quantity of the component needed to create the assembly.");
			_fieldsCustomProperties.Add("PerAssemblyQuantity", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Parent product identification number. Foreign key to Product.ProductID.");
			_fieldsCustomProperties.Add("ProductAssemblyID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the component started being used in the assembly item.");
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Standard code identifying the unit of measure for the quantity.");
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productAssembly</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductAssembly(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productAssembly, new PropertyChangedEventHandler( OnProductAssemblyPropertyChanged ), "ProductAssembly", AW.Data.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingProductAssemblyIDStatic, true, signalRelatedEntity, "BillOfAssemblyMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ProductAssemblyID } );		
			_productAssembly = null;
		}
		
		/// <summary> setups the sync logic for member _productAssembly</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductAssembly(IEntityCore relatedEntity)
		{
			if(_productAssembly!=relatedEntity)
			{		
				DesetupSyncProductAssembly(true, true);
				_productAssembly = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productAssembly, new PropertyChangedEventHandler( OnProductAssemblyPropertyChanged ), "ProductAssembly", AW.Data.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingProductAssemblyIDStatic, true, ref _alreadyFetchedProductAssembly, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductAssemblyPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productComponent</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductComponent(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productComponent, new PropertyChangedEventHandler( OnProductComponentPropertyChanged ), "ProductComponent", AW.Data.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingComponentIDStatic, true, signalRelatedEntity, "BillOfComponentMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ComponentID } );		
			_productComponent = null;
		}
		
		/// <summary> setups the sync logic for member _productComponent</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductComponent(IEntityCore relatedEntity)
		{
			if(_productComponent!=relatedEntity)
			{		
				DesetupSyncProductComponent(true, true);
				_productComponent = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productComponent, new PropertyChangedEventHandler( OnProductComponentPropertyChanged ), "ProductComponent", AW.Data.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingComponentIDStatic, true, ref _alreadyFetchedProductComponent, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductComponentPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AW.Data.RelationClasses.StaticBillOfMaterialRelations.UnitMeasureEntityUsingUnitMeasureCodeStatic, true, signalRelatedEntity, "BillOfMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.UnitMeasureCode } );		
			_unitMeasure = null;
		}
		
		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntityCore relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{		
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AW.Data.RelationClasses.StaticBillOfMaterialRelations.UnitMeasureEntityUsingUnitMeasureCodeStatic, true, ref _alreadyFetchedUnitMeasure, new string[] {  } );
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

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 billOfMaterialsID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)BillOfMaterialFieldIndex.BillOfMaterialsID].ForcedCurrentValueWrite(billOfMaterialsID);
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
			return DAOFactory.CreateBillOfMaterialDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BillOfMaterialEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BillOfMaterialRelations Relations
		{
			get	{ return new BillOfMaterialRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductAssembly
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("ProductAssembly")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "ProductAssembly", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductComponent
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("ProductComponent")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "ProductComponent", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasure
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), (IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AW.Data.EntityType.BillOfMaterialEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The BillOfMaterialsID property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Clustered index.<br/>Clustered index.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BillOfMaterialsID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BillOfMaterialsID
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsID, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsID, value, true); }
		}

		/// <summary> The Bomlevel property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Indicates the depth the component is from its parent (AssemblyID).<br/>Indicates the depth the component is from its parent (AssemblyID).</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BOMLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Bomlevel
		{
			get { return (System.Int16)GetValue((int)BillOfMaterialFieldIndex.Bomlevel, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.Bomlevel, value, true); }
		}

		/// <summary> The ComponentID property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ComponentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ComponentID
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.ComponentID, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ComponentID, value, true); }
		}

		/// <summary> The EndDate property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Date the component stopped being used in the assembly item.<br/>Date the component stopped being used in the assembly item.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)BillOfMaterialFieldIndex.EndDate, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.EndDate, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The PerAssemblyQuantity property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Quantity of the component needed to create the assembly.<br/>Quantity of the component needed to create the assembly.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."PerAssemblyQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PerAssemblyQuantity
		{
			get { return (System.Decimal)GetValue((int)BillOfMaterialFieldIndex.PerAssemblyQuantity, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.PerAssemblyQuantity, value, true); }
		}

		/// <summary> The ProductAssemblyID property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Parent product identification number. Foreign key to Product.ProductID.<br/>Parent product identification number. Foreign key to Product.ProductID.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ProductAssemblyID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductAssemblyID
		{
			get { return (Nullable<System.Int32>)GetValue((int)BillOfMaterialFieldIndex.ProductAssemblyID, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ProductAssemblyID, value, true); }
		}

		/// <summary> The StartDate property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Date the component started being used in the assembly item.<br/>Date the component started being used in the assembly item.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.StartDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.StartDate, value, true); }
		}

		/// <summary> The UnitMeasureCode property of the Entity BillOfMaterial<br/><br/>
		/// MS_Description: Standard code identifying the unit of measure for the quantity.<br/>Standard code identifying the unit of measure for the quantity.</summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductAssembly()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductEntity ProductAssembly
		{
			get	{ return GetSingleProductAssembly(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProductAssembly(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfAssemblyMaterials", "ProductAssembly", _productAssembly, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductAssembly. When set to true, ProductAssembly is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductAssembly is accessed. You can always execute a forced fetch by calling GetSingleProductAssembly(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductAssembly
		{
			get	{ return _alwaysFetchProductAssembly; }
			set	{ _alwaysFetchProductAssembly = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductAssembly already has been fetched. Setting this property to false when ProductAssembly has been fetched
		/// will set ProductAssembly to null as well. Setting this property to true while ProductAssembly hasn't been fetched disables lazy loading for ProductAssembly</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductAssembly
		{
			get { return _alreadyFetchedProductAssembly;}
			set 
			{
				if(_alreadyFetchedProductAssembly && !value)
				{
					this.ProductAssembly = null;
				}
				_alreadyFetchedProductAssembly = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductAssembly is not found
		/// in the database. When set to true, ProductAssembly will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductAssemblyReturnsNewIfNotFound
		{
			get	{ return _productAssemblyReturnsNewIfNotFound; }
			set { _productAssemblyReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductComponent()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductEntity ProductComponent
		{
			get	{ return GetSingleProductComponent(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProductComponent(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfComponentMaterials", "ProductComponent", _productComponent, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductComponent. When set to true, ProductComponent is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductComponent is accessed. You can always execute a forced fetch by calling GetSingleProductComponent(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductComponent
		{
			get	{ return _alwaysFetchProductComponent; }
			set	{ _alwaysFetchProductComponent = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductComponent already has been fetched. Setting this property to false when ProductComponent has been fetched
		/// will set ProductComponent to null as well. Setting this property to true while ProductComponent hasn't been fetched disables lazy loading for ProductComponent</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductComponent
		{
			get { return _alreadyFetchedProductComponent;}
			set 
			{
				if(_alreadyFetchedProductComponent && !value)
				{
					this.ProductComponent = null;
				}
				_alreadyFetchedProductComponent = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductComponent is not found
		/// in the database. When set to true, ProductComponent will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductComponentReturnsNewIfNotFound
		{
			get	{ return _productComponentReturnsNewIfNotFound; }
			set { _productComponentReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return GetSingleUnitMeasure(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials", "UnitMeasure", _unitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute a forced fetch by calling GetSingleUnitMeasure(true).</summary>
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
			get { return (int)AW.Data.EntityType.BillOfMaterialEntity; }
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
