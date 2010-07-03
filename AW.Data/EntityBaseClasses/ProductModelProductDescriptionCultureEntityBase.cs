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
	
	/// <summary>Entity base class which represents the base class for the entity 'ProductModelProductDescriptionCulture'.<br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping product descriptions and the language the description is written in.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductModelProductDescriptionCultureEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private CultureEntity _culture;
		private bool	_alwaysFetchCulture, _alreadyFetchedCulture, _cultureReturnsNewIfNotFound;
		private ProductDescriptionEntity _productDescription;
		private bool	_alwaysFetchProductDescription, _alreadyFetchedProductDescription, _productDescriptionReturnsNewIfNotFound;
		private ProductModelEntity _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel, _productModelReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Culture</summary>
			public static readonly string Culture = "Culture";
			/// <summary>Member name ProductDescription</summary>
			public static readonly string ProductDescription = "ProductDescription";
			/// <summary>Member name ProductModel</summary>
			public static readonly string ProductModel = "ProductModel";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductModelProductDescriptionCultureEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductModelProductDescriptionCultureEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		public ProductModelProductDescriptionCultureEntityBase(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductModelProductDescriptionCultureEntityBase(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		public ProductModelProductDescriptionCultureEntityBase(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IValidator validator)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelProductDescriptionCultureEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_culture = (CultureEntity)info.GetValue("_culture", typeof(CultureEntity));
			if(_culture!=null)
			{
				_culture.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_cultureReturnsNewIfNotFound = info.GetBoolean("_cultureReturnsNewIfNotFound");
			_alwaysFetchCulture = info.GetBoolean("_alwaysFetchCulture");
			_alreadyFetchedCulture = info.GetBoolean("_alreadyFetchedCulture");
			_productDescription = (ProductDescriptionEntity)info.GetValue("_productDescription", typeof(ProductDescriptionEntity));
			if(_productDescription!=null)
			{
				_productDescription.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productDescriptionReturnsNewIfNotFound = info.GetBoolean("_productDescriptionReturnsNewIfNotFound");
			_alwaysFetchProductDescription = info.GetBoolean("_alwaysFetchProductDescription");
			_alreadyFetchedProductDescription = info.GetBoolean("_alreadyFetchedProductDescription");
			_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
			if(_productModel!=null)
			{
				_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productModelReturnsNewIfNotFound = info.GetBoolean("_productModelReturnsNewIfNotFound");
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductModelProductDescriptionCultureFieldIndex)fieldIndex)
			{
				case ProductModelProductDescriptionCultureFieldIndex.ProductModelID:
					DesetupSyncProductModel(true, false);
					_alreadyFetchedProductModel = false;
					break;
				case ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID:
					DesetupSyncProductDescription(true, false);
					_alreadyFetchedProductDescription = false;
					break;
				case ProductModelProductDescriptionCultureFieldIndex.CultureID:
					DesetupSyncCulture(true, false);
					_alreadyFetchedCulture = false;
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


			_alreadyFetchedCulture = (_culture != null);
			_alreadyFetchedProductDescription = (_productDescription != null);
			_alreadyFetchedProductModel = (_productModel != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductModelProductDescriptionCultureEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Culture":
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID);
					break;
				case "ProductDescription":
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID);
					break;
				case "ProductModel":
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID);
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


			info.AddValue("_culture", (!this.MarkedForDeletion?_culture:null));
			info.AddValue("_cultureReturnsNewIfNotFound", _cultureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCulture", _alwaysFetchCulture);
			info.AddValue("_alreadyFetchedCulture", _alreadyFetchedCulture);
			info.AddValue("_productDescription", (!this.MarkedForDeletion?_productDescription:null));
			info.AddValue("_productDescriptionReturnsNewIfNotFound", _productDescriptionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductDescription", _alwaysFetchProductDescription);
			info.AddValue("_alreadyFetchedProductDescription", _alreadyFetchedProductDescription);
			info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
			info.AddValue("_productModelReturnsNewIfNotFound", _productModelReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);

			
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
				case "Culture":
					_alreadyFetchedCulture = true;
					this.Culture = (CultureEntity)entity;
					break;
				case "ProductDescription":
					_alreadyFetchedProductDescription = true;
					this.ProductDescription = (ProductDescriptionEntity)entity;
					break;
				case "ProductModel":
					_alreadyFetchedProductModel = true;
					this.ProductModel = (ProductModelEntity)entity;
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
				case "Culture":
					SetupSyncCulture(relatedEntity);
					break;
				case "ProductDescription":
					SetupSyncProductDescription(relatedEntity);
					break;
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
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
				case "Culture":
					DesetupSyncCulture(false, true);
					break;
				case "ProductDescription":
					DesetupSyncProductDescription(false, true);
					break;
				case "ProductModel":
					DesetupSyncProductModel(false, true);
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
			if(_culture!=null)
			{
				toReturn.Add(_culture);
			}
			if(_productDescription!=null)
			{
				toReturn.Add(_productDescription);
			}
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
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
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID)
		{
			return FetchUsingPK(productModelID, productDescriptionID, cultureID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productModelID, productDescriptionID, cultureID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productModelID, productDescriptionID, cultureID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productModelID, productDescriptionID, cultureID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductModelID, this.ProductDescriptionID, this.CultureID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductModelProductDescriptionCultureFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductModelProductDescriptionCultureFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductModelProductDescriptionCultureRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'CultureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CultureEntity' which is related to this entity.</returns>
		public CultureEntity GetSingleCulture()
		{
			return GetSingleCulture(false);
		}

		/// <summary> Retrieves the related entity of type 'CultureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CultureEntity' which is related to this entity.</returns>
		public virtual CultureEntity GetSingleCulture(bool forceFetch)
		{
			if( ( !_alreadyFetchedCulture || forceFetch || _alwaysFetchCulture) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID);

				CultureEntity newEntity = new CultureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CultureID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CultureEntity)base.ActiveContext.Get(newEntity);
					}
					this.Culture = newEntity;
				}
				else
				{
					if(_cultureReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_culture == null)))
						{
							this.Culture = newEntity;
						}
					}
					else
					{
						this.Culture = null;
					}
				}
				_alreadyFetchedCulture = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _culture;
		}

		/// <summary> Retrieves the related entity of type 'ProductDescriptionEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductDescriptionEntity' which is related to this entity.</returns>
		public ProductDescriptionEntity GetSingleProductDescription()
		{
			return GetSingleProductDescription(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductDescriptionEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductDescriptionEntity' which is related to this entity.</returns>
		public virtual ProductDescriptionEntity GetSingleProductDescription(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductDescription || forceFetch || _alwaysFetchProductDescription) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID);

				ProductDescriptionEntity newEntity = new ProductDescriptionEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductDescriptionID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductDescriptionEntity)base.ActiveContext.Get(newEntity);
					}
					this.ProductDescription = newEntity;
				}
				else
				{
					if(_productDescriptionReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_productDescription == null)))
						{
							this.ProductDescription = newEntity;
						}
					}
					else
					{
						this.ProductDescription = null;
					}
				}
				_alreadyFetchedProductDescription = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _productDescription;
		}

		/// <summary> Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public ProductModelEntity GetSingleProductModel()
		{
			return GetSingleProductModel(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public virtual ProductModelEntity GetSingleProductModel(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID);

				ProductModelEntity newEntity = new ProductModelEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductModelID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductModelEntity)base.ActiveContext.Get(newEntity);
					}
					this.ProductModel = newEntity;
				}
				else
				{
					if(_productModelReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_productModel == null)))
						{
							this.ProductModel = newEntity;
						}
					}
					else
					{
						this.ProductModel = null;
					}
				}
				_alreadyFetchedProductModel = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _productModel;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ProductModelProductDescriptionCultureDAO dao = (ProductModelProductDescriptionCultureDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_culture!=null)
			{
				_culture.ActiveContext = base.ActiveContext;
			}
			if(_productDescription!=null)
			{
				_productDescription.ActiveContext = base.ActiveContext;
			}
			if(_productModel!=null)
			{
				_productModel.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductModelProductDescriptionCultureDAO dao = (ProductModelProductDescriptionCultureDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductModelProductDescriptionCultureDAO dao = (ProductModelProductDescriptionCultureDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductModelProductDescriptionCultureEntity);
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
			toReturn.Add("Culture", _culture);
			toReturn.Add("ProductDescription", _productDescription);
			toReturn.Add("ProductModel", _productModel);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The validator object for this ProductModelProductDescriptionCultureEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productModelID, productDescriptionID, cultureID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_culture = null;
			_cultureReturnsNewIfNotFound = true;
			_alwaysFetchCulture = false;
			_alreadyFetchedCulture = false;
			_productDescription = null;
			_productDescriptionReturnsNewIfNotFound = true;
			_alwaysFetchProductDescription = false;
			_alreadyFetchedProductDescription = false;
			_productModel = null;
			_productModelReturnsNewIfNotFound = true;
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;


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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping product descriptions and the language the description is written in.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to ProductDescription.ProductDescriptionID.");
			_fieldsCustomProperties.Add("ProductDescriptionID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Culture identification number. Foreign key to Culture.CultureID.");
			_fieldsCustomProperties.Add("CultureID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _culture</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCulture(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _culture, new PropertyChangedEventHandler( OnCulturePropertyChanged ), "Culture", ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID, true, signalRelatedEntity, "ProductModelProductDescriptionCulture", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.CultureID } );		
			_culture = null;
		}
		
		/// <summary> setups the sync logic for member _culture</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCulture(IEntity relatedEntity)
		{
			if(_culture!=relatedEntity)
			{		
				DesetupSyncCulture(true, true);
				_culture = (CultureEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _culture, new PropertyChangedEventHandler( OnCulturePropertyChanged ), "Culture", ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID, true, ref _alreadyFetchedCulture, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCulturePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productDescription</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductDescription(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _productDescription, new PropertyChangedEventHandler( OnProductDescriptionPropertyChanged ), "ProductDescription", ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, true, signalRelatedEntity, "ProductModelProductDescriptionCulture", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID } );		
			_productDescription = null;
		}
		
		/// <summary> setups the sync logic for member _productDescription</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductDescription(IEntity relatedEntity)
		{
			if(_productDescription!=relatedEntity)
			{		
				DesetupSyncProductDescription(true, true);
				_productDescription = (ProductDescriptionEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _productDescription, new PropertyChangedEventHandler( OnProductDescriptionPropertyChanged ), "ProductDescription", ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, true, ref _alreadyFetchedProductDescription, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductDescriptionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID, true, signalRelatedEntity, "ProductModelProductDescriptionCulture", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID } );		
			_productModel = null;
		}
		
		/// <summary> setups the sync logic for member _productModel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntity relatedEntity)
		{
			if(_productModel!=relatedEntity)
			{		
				DesetupSyncProductModel(true, true);
				_productModel = (ProductModelEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID, true, ref _alreadyFetchedProductModel, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductModelPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID].ForcedCurrentValueWrite(productModelID);
				base.Fields[(int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID].ForcedCurrentValueWrite(productDescriptionID);
				base.Fields[(int)ProductModelProductDescriptionCultureFieldIndex.CultureID].ForcedCurrentValueWrite(cultureID);
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
			return DAOFactory.CreateProductModelProductDescriptionCultureDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductModelProductDescriptionCultureEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductModelProductDescriptionCultureRelations Relations
		{
			get	{ return new ProductModelProductDescriptionCultureRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Culture' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCulture
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CultureCollection(),
					(IEntityRelation)GetRelationsForField("Culture")[0], (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, (int)AW.Data.EntityType.CultureEntity, 0, null, null, null, "Culture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDescription' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDescription
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDescriptionCollection(),
					(IEntityRelation)GetRelationsForField("ProductDescription")[0], (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, (int)AW.Data.EntityType.ProductDescriptionEntity, 0, null, null, null, "ProductDescription", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModel
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(),
					(IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductModelProductDescriptionCultureEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductModelProductDescriptionCultureEntity.CustomProperties;}
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
			get { return ProductModelProductDescriptionCultureEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductModelID property of the Entity ProductModelProductDescriptionCulture<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductModelID
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID, value, true); }
		}
		/// <summary> The ProductDescriptionID property of the Entity ProductModelProductDescriptionCulture<br/><br/>
		/// 
		/// MS_Description: Primary key. Foreign key to ProductDescription.ProductDescriptionID.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductDescriptionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductDescriptionID
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID, value, true); }
		}
		/// <summary> The CultureID property of the Entity ProductModelProductDescriptionCulture<br/><br/>
		/// 
		/// MS_Description: Culture identification number. Foreign key to Culture.CultureID.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."CultureID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 6<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CultureID
		{
			get { return (System.String)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureID, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureID, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ProductModelProductDescriptionCulture<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'CultureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CultureEntity Culture
		{
			get	{ return GetSingleCulture(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCulture(value);
				}
				else
				{
					if(value==null)
					{
						if(_culture != null)
						{
							_culture.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						if(_culture!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Culture. When set to true, Culture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Culture is accessed. You can always execute
		/// a forced fetch by calling GetSingleCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCulture
		{
			get	{ return _alwaysFetchCulture; }
			set	{ _alwaysFetchCulture = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Culture already has been fetched. Setting this property to false when Culture has been fetched
		/// will set Culture to null as well. Setting this property to true while Culture hasn't been fetched disables lazy loading for Culture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCulture
		{
			get { return _alreadyFetchedCulture;}
			set 
			{
				if(_alreadyFetchedCulture && !value)
				{
					this.Culture = null;
				}
				_alreadyFetchedCulture = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Culture is not found
		/// in the database. When set to true, Culture will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CultureReturnsNewIfNotFound
		{
			get	{ return _cultureReturnsNewIfNotFound; }
			set { _cultureReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ProductDescriptionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductDescription()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductDescriptionEntity ProductDescription
		{
			get	{ return GetSingleProductDescription(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductDescription(value);
				}
				else
				{
					if(value==null)
					{
						if(_productDescription != null)
						{
							_productDescription.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						if(_productDescription!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDescription. When set to true, ProductDescription is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDescription is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductDescription(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDescription
		{
			get	{ return _alwaysFetchProductDescription; }
			set	{ _alwaysFetchProductDescription = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDescription already has been fetched. Setting this property to false when ProductDescription has been fetched
		/// will set ProductDescription to null as well. Setting this property to true while ProductDescription hasn't been fetched disables lazy loading for ProductDescription</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDescription
		{
			get { return _alreadyFetchedProductDescription;}
			set 
			{
				if(_alreadyFetchedProductDescription && !value)
				{
					this.ProductDescription = null;
				}
				_alreadyFetchedProductDescription = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductDescription is not found
		/// in the database. When set to true, ProductDescription will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductDescriptionReturnsNewIfNotFound
		{
			get	{ return _productDescriptionReturnsNewIfNotFound; }
			set { _productDescriptionReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ProductModelEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductModel()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return GetSingleProductModel(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					if(value==null)
					{
						if(_productModel != null)
						{
							_productModel.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						if(_productModel!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModel. When set to true, ProductModel is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductModel(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModel
		{
			get	{ return _alwaysFetchProductModel; }
			set	{ _alwaysFetchProductModel = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModel already has been fetched. Setting this property to false when ProductModel has been fetched
		/// will set ProductModel to null as well. Setting this property to true while ProductModel hasn't been fetched disables lazy loading for ProductModel</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModel
		{
			get { return _alreadyFetchedProductModel;}
			set 
			{
				if(_alreadyFetchedProductModel && !value)
				{
					this.ProductModel = null;
				}
				_alreadyFetchedProductModel = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductModel is not found
		/// in the database. When set to true, ProductModel will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductModelReturnsNewIfNotFound
		{
			get	{ return _productModelReturnsNewIfNotFound; }
			set { _productModelReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity; }
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
