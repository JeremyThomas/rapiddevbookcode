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
	/// <summary>Entity base class which represents the base class for the entity 'SpecialOffer'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class SpecialOfferEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SpecialOfferProductCollection	_specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaSpecialOfferProduct;
		private bool	_alwaysFetchProductCollectionViaSpecialOfferProduct, _alreadyFetchedProductCollectionViaSpecialOfferProduct;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name SpecialOfferProduct</summary>
			public static readonly string SpecialOfferProduct = "SpecialOfferProduct";
			/// <summary>Member name ProductCollectionViaSpecialOfferProduct</summary>
			public static readonly string ProductCollectionViaSpecialOfferProduct = "ProductCollectionViaSpecialOfferProduct";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SpecialOfferEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SpecialOfferEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		public SpecialOfferEntityBase(System.Int32 specialOfferId)
		{
			InitClassFetch(specialOfferId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SpecialOfferEntityBase(System.Int32 specialOfferId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(specialOfferId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferEntity</param>
		public SpecialOfferEntityBase(System.Int32 specialOfferId, IValidator validator)
		{
			InitClassFetch(specialOfferId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SpecialOfferEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_specialOfferProduct = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProduct", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");
			_productCollectionViaSpecialOfferProduct = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaSpecialOfferProduct", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaSpecialOfferProduct = info.GetBoolean("_alwaysFetchProductCollectionViaSpecialOfferProduct");
			_alreadyFetchedProductCollectionViaSpecialOfferProduct = info.GetBoolean("_alreadyFetchedProductCollectionViaSpecialOfferProduct");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SpecialOfferFieldIndex)fieldIndex)
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
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct.Count > 0);
			_alreadyFetchedProductCollectionViaSpecialOfferProduct = (_productCollectionViaSpecialOfferProduct.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SpecialOfferEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "SpecialOfferProduct":
					toReturn.Add(SpecialOfferEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferId);
					break;
				case "ProductCollectionViaSpecialOfferProduct":
					toReturn.Add(SpecialOfferEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferId, "SpecialOfferEntity__", "SpecialOfferProduct_", JoinHint.None);
					toReturn.Add(SpecialOfferProductEntity.Relations.ProductEntityUsingProductId, "SpecialOfferProduct_", string.Empty, JoinHint.None);
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
			info.AddValue("_specialOfferProduct", (!this.MarkedForDeletion?_specialOfferProduct:null));
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);
			info.AddValue("_productCollectionViaSpecialOfferProduct", (!this.MarkedForDeletion?_productCollectionViaSpecialOfferProduct:null));
			info.AddValue("_alwaysFetchProductCollectionViaSpecialOfferProduct", _alwaysFetchProductCollectionViaSpecialOfferProduct);
			info.AddValue("_alreadyFetchedProductCollectionViaSpecialOfferProduct", _alreadyFetchedProductCollectionViaSpecialOfferProduct);


			
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

				case "SpecialOfferProduct":
					_alreadyFetchedSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.SpecialOfferProduct.Add((SpecialOfferProductEntity)entity);
					}
					break;
				case "ProductCollectionViaSpecialOfferProduct":
					_alreadyFetchedProductCollectionViaSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.ProductCollectionViaSpecialOfferProduct.Add((ProductEntity)entity);
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

				case "SpecialOfferProduct":
					_specialOfferProduct.Add((SpecialOfferProductEntity)relatedEntity);
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

				case "SpecialOfferProduct":
					base.PerformRelatedEntityRemoval(_specialOfferProduct, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_specialOfferProduct);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 specialOfferId)
		{
			return FetchUsingPK(specialOfferId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 specialOfferId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(specialOfferId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 specialOfferId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(specialOfferId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 specialOfferId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(specialOfferId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SpecialOfferId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SpecialOfferFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SpecialOfferFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SpecialOfferRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiSpecialOfferProduct(forceFetch, _specialOfferProduct.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSpecialOfferProduct(forceFetch, _specialOfferProduct.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSpecialOfferProduct(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferProduct.GetMultiManyToOne(null, this, filter);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferProduct is requested or GetMultiSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProduct.SortClauses=sortClauses;
			_specialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiProductCollectionViaSpecialOfferProduct(forceFetch, _productCollectionViaSpecialOfferProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaSpecialOfferProduct || forceFetch || _alwaysFetchProductCollectionViaSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaSpecialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaSpecialOfferProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SpecialOfferFields.SpecialOfferId, ComparisonOperator.Equal, this.SpecialOfferId, "SpecialOfferEntity__"));
				_productCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaSpecialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaSpecialOfferProduct.GetMulti(filter, GetRelationsForField("ProductCollectionViaSpecialOfferProduct"));
				_productCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaSpecialOfferProduct = true;
			}
			return _productCollectionViaSpecialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaSpecialOfferProduct'. These settings will be taken into account
		/// when the property ProductCollectionViaSpecialOfferProduct is requested or GetMultiProductCollectionViaSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaSpecialOfferProduct.SortClauses=sortClauses;
			_productCollectionViaSpecialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SpecialOfferDAO dao = (SpecialOfferDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_specialOfferProduct.ActiveContext = base.ActiveContext;
			_productCollectionViaSpecialOfferProduct.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SpecialOfferDAO dao = (SpecialOfferDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SpecialOfferDAO dao = (SpecialOfferDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SpecialOfferEntity);
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

			toReturn.Add("SpecialOfferProduct", _specialOfferProduct);
			toReturn.Add("ProductCollectionViaSpecialOfferProduct", _productCollectionViaSpecialOfferProduct);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="validator">The validator object for this SpecialOfferEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 specialOfferId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(specialOfferId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_specialOfferProduct = new AW.Data.CollectionClasses.SpecialOfferProductCollection(new SpecialOfferProductEntityFactory());
			_specialOfferProduct.SetContainingEntityInfo(this, "SpecialOffer");
			_alwaysFetchSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferProduct = false;
			_productCollectionViaSpecialOfferProduct = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaSpecialOfferProduct = false;
			_alreadyFetchedProductCollectionViaSpecialOfferProduct = false;



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

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SpecialOfferId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DiscountPct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Type", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Category", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MinQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MaxQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="specialOfferId">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 specialOfferId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SpecialOfferFieldIndex.SpecialOfferId].ForcedCurrentValueWrite(specialOfferId);
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
			return DAOFactory.CreateSpecialOfferDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SpecialOfferEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SpecialOfferRelations Relations
		{
			get	{ return new SpecialOfferRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProduct
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(),
					(IEntityRelation)GetRelationsForField("SpecialOfferProduct")[0], (int)AW.Data.EntityType.SpecialOfferEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaSpecialOfferProduct
		{
			get
			{
				IEntityRelation intermediateRelation = SpecialOfferEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferId;
				intermediateRelation.SetAliases(string.Empty, "SpecialOfferProduct_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SpecialOfferEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaSpecialOfferProduct"), "ProductCollectionViaSpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SpecialOfferEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SpecialOfferEntity.CustomProperties;}
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
			get { return SpecialOfferEntity.FieldsCustomProperties;}
		}

		/// <summary> The SpecialOfferId property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."SpecialOfferID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferFieldIndex.SpecialOfferId, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.SpecialOfferId, value, true); }
		}
		/// <summary> The Description property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Description, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.Description, value, true); }
		}
		/// <summary> The DiscountPct property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."DiscountPct"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal DiscountPct
		{
			get { return (System.Decimal)GetValue((int)SpecialOfferFieldIndex.DiscountPct, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.DiscountPct, value, true); }
		}
		/// <summary> The Type property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Type"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Type
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Type, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.Type, value, true); }
		}
		/// <summary> The Category property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."Category"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Category
		{
			get { return (System.String)GetValue((int)SpecialOfferFieldIndex.Category, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.Category, value, true); }
		}
		/// <summary> The StartDate property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.StartDate, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.StartDate, value, true); }
		}
		/// <summary> The EndDate property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.EndDate, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.EndDate, value, true); }
		}
		/// <summary> The MinQty property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."MinQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MinQty
		{
			get { return (System.Int32)GetValue((int)SpecialOfferFieldIndex.MinQty, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.MinQty, value, true); }
		}
		/// <summary> The MaxQty property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."MaxQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MaxQty
		{
			get { return (Nullable<System.Int32>)GetValue((int)SpecialOfferFieldIndex.MaxQty, false); }
			set	{ SetValue((int)SpecialOfferFieldIndex.MaxQty, value, true); }
		}
		/// <summary> The Rowguid property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SpecialOfferFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SpecialOffer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SpecialOffer"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SpecialOfferFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProduct
		{
			get	{ return GetMultiSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProduct. When set to true, SpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferProduct = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferProduct already has been fetched. Setting this property to false when SpecialOfferProduct has been fetched
		/// will clear the SpecialOfferProduct collection well. Setting this property to true while SpecialOfferProduct hasn't been fetched disables lazy loading for SpecialOfferProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferProduct
		{
			get { return _alreadyFetchedSpecialOfferProduct;}
			set 
			{
				if(_alreadyFetchedSpecialOfferProduct && !value && (_specialOfferProduct != null))
				{
					_specialOfferProduct.Clear();
				}
				_alreadyFetchedSpecialOfferProduct = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaSpecialOfferProduct
		{
			get { return GetMultiProductCollectionViaSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaSpecialOfferProduct. When set to true, ProductCollectionViaSpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaSpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaSpecialOfferProduct
		{
			get	{ return _alwaysFetchProductCollectionViaSpecialOfferProduct; }
			set	{ _alwaysFetchProductCollectionViaSpecialOfferProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaSpecialOfferProduct already has been fetched. Setting this property to false when ProductCollectionViaSpecialOfferProduct has been fetched
		/// will clear the ProductCollectionViaSpecialOfferProduct collection well. Setting this property to true while ProductCollectionViaSpecialOfferProduct hasn't been fetched disables lazy loading for ProductCollectionViaSpecialOfferProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaSpecialOfferProduct
		{
			get { return _alreadyFetchedProductCollectionViaSpecialOfferProduct;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaSpecialOfferProduct && !value && (_productCollectionViaSpecialOfferProduct != null))
				{
					_productCollectionViaSpecialOfferProduct.Clear();
				}
				_alreadyFetchedProductCollectionViaSpecialOfferProduct = value;
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
			get { return (int)AW.Data.EntityType.SpecialOfferEntity; }
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
