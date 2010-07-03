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
	
	/// <summary>Entity base class which represents the base class for the entity 'ProductPhoto'.<br/><br/>
	/// 
	/// MS_Description: Product images.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductPhotoEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductProductPhotoCollection	_productProductPhoto;
		private bool	_alwaysFetchProductProductPhoto, _alreadyFetchedProductProductPhoto;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaProductProductPhoto;
		private bool	_alwaysFetchProductCollectionViaProductProductPhoto, _alreadyFetchedProductCollectionViaProductProductPhoto;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductProductPhoto</summary>
			public static readonly string ProductProductPhoto = "ProductProductPhoto";
			/// <summary>Member name ProductCollectionViaProductProductPhoto</summary>
			public static readonly string ProductCollectionViaProductProductPhoto = "ProductCollectionViaProductProductPhoto";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductPhotoEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductPhotoEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		public ProductPhotoEntityBase(System.Int32 productPhotoID)
		{
			InitClassFetch(productPhotoID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductPhotoEntityBase(System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productPhotoID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="validator">The custom validator object for this ProductPhotoEntity</param>
		public ProductPhotoEntityBase(System.Int32 productPhotoID, IValidator validator)
		{
			InitClassFetch(productPhotoID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductPhotoEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productProductPhoto = (AW.Data.CollectionClasses.ProductProductPhotoCollection)info.GetValue("_productProductPhoto", typeof(AW.Data.CollectionClasses.ProductProductPhotoCollection));
			_alwaysFetchProductProductPhoto = info.GetBoolean("_alwaysFetchProductProductPhoto");
			_alreadyFetchedProductProductPhoto = info.GetBoolean("_alreadyFetchedProductProductPhoto");
			_productCollectionViaProductProductPhoto = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaProductProductPhoto", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaProductProductPhoto = info.GetBoolean("_alwaysFetchProductCollectionViaProductProductPhoto");
			_alreadyFetchedProductCollectionViaProductProductPhoto = info.GetBoolean("_alreadyFetchedProductCollectionViaProductProductPhoto");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductPhotoFieldIndex)fieldIndex)
			{
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
			_alreadyFetchedProductProductPhoto = (_productProductPhoto.Count > 0);
			_alreadyFetchedProductCollectionViaProductProductPhoto = (_productCollectionViaProductProductPhoto.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductPhotoEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductProductPhoto":
					toReturn.Add(ProductPhotoEntity.Relations.ProductProductPhotoEntityUsingProductPhotoID);
					break;
				case "ProductCollectionViaProductProductPhoto":
					toReturn.Add(ProductPhotoEntity.Relations.ProductProductPhotoEntityUsingProductPhotoID, "ProductPhotoEntity__", "ProductProductPhoto_", JoinHint.None);
					toReturn.Add(ProductProductPhotoEntity.Relations.ProductEntityUsingProductID, "ProductProductPhoto_", string.Empty, JoinHint.None);
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
			info.AddValue("_productProductPhoto", (!this.MarkedForDeletion?_productProductPhoto:null));
			info.AddValue("_alwaysFetchProductProductPhoto", _alwaysFetchProductProductPhoto);
			info.AddValue("_alreadyFetchedProductProductPhoto", _alreadyFetchedProductProductPhoto);
			info.AddValue("_productCollectionViaProductProductPhoto", (!this.MarkedForDeletion?_productCollectionViaProductProductPhoto:null));
			info.AddValue("_alwaysFetchProductCollectionViaProductProductPhoto", _alwaysFetchProductCollectionViaProductProductPhoto);
			info.AddValue("_alreadyFetchedProductCollectionViaProductProductPhoto", _alreadyFetchedProductCollectionViaProductProductPhoto);


			
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

				case "ProductProductPhoto":
					_alreadyFetchedProductProductPhoto = true;
					if(entity!=null)
					{
						this.ProductProductPhoto.Add((ProductProductPhotoEntity)entity);
					}
					break;
				case "ProductCollectionViaProductProductPhoto":
					_alreadyFetchedProductCollectionViaProductProductPhoto = true;
					if(entity!=null)
					{
						this.ProductCollectionViaProductProductPhoto.Add((ProductEntity)entity);
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
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "ProductProductPhoto":
					_productProductPhoto.Add((ProductProductPhotoEntity)relatedEntity);
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

				case "ProductProductPhoto":
					base.PerformRelatedEntityRemoval(_productProductPhoto, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_productProductPhoto);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productPhotoID)
		{
			return FetchUsingPK(productPhotoID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productPhotoID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productPhotoID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productPhotoID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductPhotoID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductPhotoFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductPhotoFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductPhotoRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch)
		{
			return GetMultiProductProductPhoto(forceFetch, _productProductPhoto.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductProductPhoto(forceFetch, _productProductPhoto.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductProductPhoto(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				}
				_productProductPhoto.GetMultiManyToOne(null, this, filter);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductProductPhoto'. These settings will be taken into account
		/// when the property ProductProductPhoto is requested or GetMultiProductProductPhoto is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productProductPhoto.SortClauses=sortClauses;
			_productProductPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductProductPhoto(bool forceFetch)
		{
			return GetMultiProductCollectionViaProductProductPhoto(forceFetch, _productCollectionViaProductProductPhoto.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaProductProductPhoto || forceFetch || _alwaysFetchProductCollectionViaProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaProductProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaProductProductPhoto);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductPhotoFields.ProductPhotoID, ComparisonOperator.Equal, this.ProductPhotoID, "ProductPhotoEntity__"));
				_productCollectionViaProductProductPhoto.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaProductProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaProductProductPhoto.GetMulti(filter, GetRelationsForField("ProductCollectionViaProductProductPhoto"));
				_productCollectionViaProductProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaProductProductPhoto = true;
			}
			return _productCollectionViaProductProductPhoto;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaProductProductPhoto'. These settings will be taken into account
		/// when the property ProductCollectionViaProductProductPhoto is requested or GetMultiProductCollectionViaProductProductPhoto is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaProductProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaProductProductPhoto.SortClauses=sortClauses;
			_productCollectionViaProductProductPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ProductPhotoDAO dao = (ProductPhotoDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productProductPhoto.ActiveContext = base.ActiveContext;
			_productCollectionViaProductProductPhoto.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductPhotoDAO dao = (ProductPhotoDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductPhotoDAO dao = (ProductPhotoDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductPhotoEntity);
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

			toReturn.Add("ProductProductPhoto", _productProductPhoto);
			toReturn.Add("ProductCollectionViaProductProductPhoto", _productCollectionViaProductProductPhoto);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="validator">The validator object for this ProductPhotoEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productPhotoID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productPhotoID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productProductPhoto = new AW.Data.CollectionClasses.ProductProductPhotoCollection(new ProductProductPhotoEntityFactory());
			_productProductPhoto.SetContainingEntityInfo(this, "ProductPhoto");
			_alwaysFetchProductProductPhoto = false;
			_alreadyFetchedProductProductPhoto = false;
			_productCollectionViaProductProductPhoto = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaProductProductPhoto = false;
			_alreadyFetchedProductCollectionViaProductProductPhoto = false;



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
			_customProperties.Add("MS_Description", @"Product images.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductPhotoID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Small image of the product.");
			_fieldsCustomProperties.Add("ThumbNailPhoto", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Small image file name.");
			_fieldsCustomProperties.Add("ThumbnailPhotoFileName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Large image of the product.");
			_fieldsCustomProperties.Add("LargePhoto", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Large image file name.");
			_fieldsCustomProperties.Add("LargePhotoFileName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductPhotoFieldIndex.ProductPhotoID].ForcedCurrentValueWrite(productPhotoID);
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
			return DAOFactory.CreateProductPhotoDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductPhotoEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductPhotoRelations Relations
		{
			get	{ return new ProductPhotoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductProductPhoto
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductProductPhotoCollection(),
					(IEntityRelation)GetRelationsForField("ProductProductPhoto")[0], (int)AW.Data.EntityType.ProductPhotoEntity, (int)AW.Data.EntityType.ProductProductPhotoEntity, 0, null, null, null, "ProductProductPhoto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaProductProductPhoto
		{
			get
			{
				IEntityRelation intermediateRelation = ProductPhotoEntity.Relations.ProductProductPhotoEntityUsingProductPhotoID;
				intermediateRelation.SetAliases(string.Empty, "ProductProductPhoto_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductPhotoEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductProductPhoto"), "ProductCollectionViaProductProductPhoto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductPhotoEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductPhotoEntity.CustomProperties;}
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
			get { return ProductPhotoEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductPhotoID property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ProductPhotoID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductPhotoID
		{
			get { return (System.Int32)GetValue((int)ProductPhotoFieldIndex.ProductPhotoID, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ProductPhotoID, value, true); }
		}
		/// <summary> The ThumbNailPhoto property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Small image of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ThumbNailPhoto"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] ThumbNailPhoto
		{
			get { return (System.Byte[])GetValue((int)ProductPhotoFieldIndex.ThumbNailPhoto, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ThumbNailPhoto, value, true); }
		}
		/// <summary> The ThumbnailPhotoFileName property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Small image file name.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ThumbnailPhotoFileName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ThumbnailPhotoFileName
		{
			get { return (System.String)GetValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, value, true); }
		}
		/// <summary> The LargePhoto property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Large image of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."LargePhoto"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] LargePhoto
		{
			get { return (System.Byte[])GetValue((int)ProductPhotoFieldIndex.LargePhoto, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.LargePhoto, value, true); }
		}
		/// <summary> The LargePhotoFileName property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Large image file name.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."LargePhotoFileName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LargePhotoFileName
		{
			get { return (System.String)GetValue((int)ProductPhotoFieldIndex.LargePhotoFileName, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.LargePhotoFileName, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ProductPhoto<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductPhoto"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductPhotoFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductPhotoFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection ProductProductPhoto
		{
			get	{ return GetMultiProductProductPhoto(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductProductPhoto. When set to true, ProductProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductProductPhoto(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductProductPhoto
		{
			get	{ return _alwaysFetchProductProductPhoto; }
			set	{ _alwaysFetchProductProductPhoto = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductProductPhoto already has been fetched. Setting this property to false when ProductProductPhoto has been fetched
		/// will clear the ProductProductPhoto collection well. Setting this property to true while ProductProductPhoto hasn't been fetched disables lazy loading for ProductProductPhoto</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductProductPhoto
		{
			get { return _alreadyFetchedProductProductPhoto;}
			set 
			{
				if(_alreadyFetchedProductProductPhoto && !value && (_productProductPhoto != null))
				{
					_productProductPhoto.Clear();
				}
				_alreadyFetchedProductProductPhoto = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaProductProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaProductProductPhoto
		{
			get { return GetMultiProductCollectionViaProductProductPhoto(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaProductProductPhoto. When set to true, ProductCollectionViaProductProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaProductProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaProductProductPhoto(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaProductProductPhoto
		{
			get	{ return _alwaysFetchProductCollectionViaProductProductPhoto; }
			set	{ _alwaysFetchProductCollectionViaProductProductPhoto = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaProductProductPhoto already has been fetched. Setting this property to false when ProductCollectionViaProductProductPhoto has been fetched
		/// will clear the ProductCollectionViaProductProductPhoto collection well. Setting this property to true while ProductCollectionViaProductProductPhoto hasn't been fetched disables lazy loading for ProductCollectionViaProductProductPhoto</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaProductProductPhoto
		{
			get { return _alreadyFetchedProductCollectionViaProductProductPhoto;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaProductProductPhoto && !value && (_productCollectionViaProductProductPhoto != null))
				{
					_productCollectionViaProductProductPhoto.Clear();
				}
				_alreadyFetchedProductCollectionViaProductProductPhoto = value;
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
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.ProductPhotoEntity; }
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
