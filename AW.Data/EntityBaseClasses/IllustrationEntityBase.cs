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
	
	/// <summary>Entity base class which represents the base class for the entity 'Illustration'.<br/><br/>
	/// 
	/// MS_Description: Bicycle assembly diagrams.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class IllustrationEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductModelIllustrationCollection	_productModelIllustration;
		private bool	_alwaysFetchProductModelIllustration, _alreadyFetchedProductModelIllustration;
		private AW.Data.CollectionClasses.ProductModelCollection _productModelCollectionViaProductModelIllustration;
		private bool	_alwaysFetchProductModelCollectionViaProductModelIllustration, _alreadyFetchedProductModelCollectionViaProductModelIllustration;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductModelIllustration</summary>
			public static readonly string ProductModelIllustration = "ProductModelIllustration";
			/// <summary>Member name ProductModelCollectionViaProductModelIllustration</summary>
			public static readonly string ProductModelCollectionViaProductModelIllustration = "ProductModelCollectionViaProductModelIllustration";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static IllustrationEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public IllustrationEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		public IllustrationEntityBase(System.Int32 illustrationID)
		{
			InitClassFetch(illustrationID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public IllustrationEntityBase(System.Int32 illustrationID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(illustrationID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="validator">The custom validator object for this IllustrationEntity</param>
		public IllustrationEntityBase(System.Int32 illustrationID, IValidator validator)
		{
			InitClassFetch(illustrationID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IllustrationEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productModelIllustration = (AW.Data.CollectionClasses.ProductModelIllustrationCollection)info.GetValue("_productModelIllustration", typeof(AW.Data.CollectionClasses.ProductModelIllustrationCollection));
			_alwaysFetchProductModelIllustration = info.GetBoolean("_alwaysFetchProductModelIllustration");
			_alreadyFetchedProductModelIllustration = info.GetBoolean("_alreadyFetchedProductModelIllustration");
			_productModelCollectionViaProductModelIllustration = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_productModelCollectionViaProductModelIllustration", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchProductModelCollectionViaProductModelIllustration = info.GetBoolean("_alwaysFetchProductModelCollectionViaProductModelIllustration");
			_alreadyFetchedProductModelCollectionViaProductModelIllustration = info.GetBoolean("_alreadyFetchedProductModelCollectionViaProductModelIllustration");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((IllustrationFieldIndex)fieldIndex)
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
			_alreadyFetchedProductModelIllustration = (_productModelIllustration.Count > 0);
			_alreadyFetchedProductModelCollectionViaProductModelIllustration = (_productModelCollectionViaProductModelIllustration.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return IllustrationEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductModelIllustration":
					toReturn.Add(IllustrationEntity.Relations.ProductModelIllustrationEntityUsingIllustrationID);
					break;
				case "ProductModelCollectionViaProductModelIllustration":
					toReturn.Add(IllustrationEntity.Relations.ProductModelIllustrationEntityUsingIllustrationID, "IllustrationEntity__", "ProductModelIllustration_", JoinHint.None);
					toReturn.Add(ProductModelIllustrationEntity.Relations.ProductModelEntityUsingProductModelID, "ProductModelIllustration_", string.Empty, JoinHint.None);
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
			info.AddValue("_productModelIllustration", (!this.MarkedForDeletion?_productModelIllustration:null));
			info.AddValue("_alwaysFetchProductModelIllustration", _alwaysFetchProductModelIllustration);
			info.AddValue("_alreadyFetchedProductModelIllustration", _alreadyFetchedProductModelIllustration);
			info.AddValue("_productModelCollectionViaProductModelIllustration", (!this.MarkedForDeletion?_productModelCollectionViaProductModelIllustration:null));
			info.AddValue("_alwaysFetchProductModelCollectionViaProductModelIllustration", _alwaysFetchProductModelCollectionViaProductModelIllustration);
			info.AddValue("_alreadyFetchedProductModelCollectionViaProductModelIllustration", _alreadyFetchedProductModelCollectionViaProductModelIllustration);


			
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

				case "ProductModelIllustration":
					_alreadyFetchedProductModelIllustration = true;
					if(entity!=null)
					{
						this.ProductModelIllustration.Add((ProductModelIllustrationEntity)entity);
					}
					break;
				case "ProductModelCollectionViaProductModelIllustration":
					_alreadyFetchedProductModelCollectionViaProductModelIllustration = true;
					if(entity!=null)
					{
						this.ProductModelCollectionViaProductModelIllustration.Add((ProductModelEntity)entity);
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

				case "ProductModelIllustration":
					_productModelIllustration.Add((ProductModelIllustrationEntity)relatedEntity);
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

				case "ProductModelIllustration":
					base.PerformRelatedEntityRemoval(_productModelIllustration, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_productModelIllustration);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 illustrationID)
		{
			return FetchUsingPK(illustrationID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 illustrationID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(illustrationID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 illustrationID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(illustrationID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 illustrationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(illustrationID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.IllustrationID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(IllustrationFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(IllustrationFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new IllustrationRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch)
		{
			return GetMultiProductModelIllustration(forceFetch, _productModelIllustration.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelIllustration(forceFetch, _productModelIllustration.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelIllustration(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelIllustration.GetMultiManyToOne(this, null, filter);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelIllustration'. These settings will be taken into account
		/// when the property ProductModelIllustration is requested or GetMultiProductModelIllustration is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelIllustration.SortClauses=sortClauses;
			_productModelIllustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProductModelIllustration(bool forceFetch)
		{
			return GetMultiProductModelCollectionViaProductModelIllustration(forceFetch, _productModelCollectionViaProductModelIllustration.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelCollectionViaProductModelIllustration || forceFetch || _alwaysFetchProductModelCollectionViaProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelCollectionViaProductModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelCollectionViaProductModelIllustration);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(IllustrationFields.IllustrationID, ComparisonOperator.Equal, this.IllustrationID, "IllustrationEntity__"));
				_productModelCollectionViaProductModelIllustration.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelCollectionViaProductModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelCollectionViaProductModelIllustration.GetMulti(filter, GetRelationsForField("ProductModelCollectionViaProductModelIllustration"));
				_productModelCollectionViaProductModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelCollectionViaProductModelIllustration = true;
			}
			return _productModelCollectionViaProductModelIllustration;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelCollectionViaProductModelIllustration'. These settings will be taken into account
		/// when the property ProductModelCollectionViaProductModelIllustration is requested or GetMultiProductModelCollectionViaProductModelIllustration is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelCollectionViaProductModelIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelCollectionViaProductModelIllustration.SortClauses=sortClauses;
			_productModelCollectionViaProductModelIllustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			IllustrationDAO dao = (IllustrationDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productModelIllustration.ActiveContext = base.ActiveContext;
			_productModelCollectionViaProductModelIllustration.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			IllustrationDAO dao = (IllustrationDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			IllustrationDAO dao = (IllustrationDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.IllustrationEntity);
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

			toReturn.Add("ProductModelIllustration", _productModelIllustration);
			toReturn.Add("ProductModelCollectionViaProductModelIllustration", _productModelCollectionViaProductModelIllustration);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="validator">The validator object for this IllustrationEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 illustrationID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(illustrationID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productModelIllustration = new AW.Data.CollectionClasses.ProductModelIllustrationCollection(new ProductModelIllustrationEntityFactory());
			_productModelIllustration.SetContainingEntityInfo(this, "Illustration");
			_alwaysFetchProductModelIllustration = false;
			_alreadyFetchedProductModelIllustration = false;
			_productModelCollectionViaProductModelIllustration = new AW.Data.CollectionClasses.ProductModelCollection(new ProductModelEntityFactory());
			_alwaysFetchProductModelCollectionViaProductModelIllustration = false;
			_alreadyFetchedProductModelCollectionViaProductModelIllustration = false;



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
			_customProperties.Add("MS_Description", @"Bicycle assembly diagrams.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("IllustrationID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Illustrations used in manufacturing instructions. Stored as XML.");
			_fieldsCustomProperties.Add("Diagram", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="illustrationID">PK value for Illustration which data should be fetched into this Illustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 illustrationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)IllustrationFieldIndex.IllustrationID].ForcedCurrentValueWrite(illustrationID);
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
			return DAOFactory.CreateIllustrationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new IllustrationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static IllustrationRelations Relations
		{
			get	{ return new IllustrationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelIllustration
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelIllustrationCollection(),
					(IEntityRelation)GetRelationsForField("ProductModelIllustration")[0], (int)AW.Data.EntityType.IllustrationEntity, (int)AW.Data.EntityType.ProductModelIllustrationEntity, 0, null, null, null, "ProductModelIllustration", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelCollectionViaProductModelIllustration
		{
			get
			{
				IEntityRelation intermediateRelation = IllustrationEntity.Relations.ProductModelIllustrationEntityUsingIllustrationID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelIllustration_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,
					(int)AW.Data.EntityType.IllustrationEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProductModelIllustration"), "ProductModelCollectionViaProductModelIllustration", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "IllustrationEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return IllustrationEntity.CustomProperties;}
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
			get { return IllustrationEntity.FieldsCustomProperties;}
		}

		/// <summary> The IllustrationID property of the Entity Illustration<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."IllustrationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 IllustrationID
		{
			get { return (System.Int32)GetValue((int)IllustrationFieldIndex.IllustrationID, true); }
			set	{ SetValue((int)IllustrationFieldIndex.IllustrationID, value, true); }
		}
		/// <summary> The Diagram property of the Entity Illustration<br/><br/>
		/// 
		/// MS_Description: Illustrations used in manufacturing instructions. Stored as XML.<br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."Diagram"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diagram
		{
			get { return (System.String)GetValue((int)IllustrationFieldIndex.Diagram, true); }
			set	{ SetValue((int)IllustrationFieldIndex.Diagram, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Illustration<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Illustration"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)IllustrationFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)IllustrationFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection ProductModelIllustration
		{
			get	{ return GetMultiProductModelIllustration(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelIllustration. When set to true, ProductModelIllustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelIllustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelIllustration(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelIllustration
		{
			get	{ return _alwaysFetchProductModelIllustration; }
			set	{ _alwaysFetchProductModelIllustration = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelIllustration already has been fetched. Setting this property to false when ProductModelIllustration has been fetched
		/// will clear the ProductModelIllustration collection well. Setting this property to true while ProductModelIllustration hasn't been fetched disables lazy loading for ProductModelIllustration</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelIllustration
		{
			get { return _alreadyFetchedProductModelIllustration;}
			set 
			{
				if(_alreadyFetchedProductModelIllustration && !value && (_productModelIllustration != null))
				{
					_productModelIllustration.Clear();
				}
				_alreadyFetchedProductModelIllustration = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelCollectionViaProductModelIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection ProductModelCollectionViaProductModelIllustration
		{
			get { return GetMultiProductModelCollectionViaProductModelIllustration(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelCollectionViaProductModelIllustration. When set to true, ProductModelCollectionViaProductModelIllustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelCollectionViaProductModelIllustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelCollectionViaProductModelIllustration(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelCollectionViaProductModelIllustration
		{
			get	{ return _alwaysFetchProductModelCollectionViaProductModelIllustration; }
			set	{ _alwaysFetchProductModelCollectionViaProductModelIllustration = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelCollectionViaProductModelIllustration already has been fetched. Setting this property to false when ProductModelCollectionViaProductModelIllustration has been fetched
		/// will clear the ProductModelCollectionViaProductModelIllustration collection well. Setting this property to true while ProductModelCollectionViaProductModelIllustration hasn't been fetched disables lazy loading for ProductModelCollectionViaProductModelIllustration</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelCollectionViaProductModelIllustration
		{
			get { return _alreadyFetchedProductModelCollectionViaProductModelIllustration;}
			set 
			{
				if(_alreadyFetchedProductModelCollectionViaProductModelIllustration && !value && (_productModelCollectionViaProductModelIllustration != null))
				{
					_productModelCollectionViaProductModelIllustration.Clear();
				}
				_alreadyFetchedProductModelCollectionViaProductModelIllustration = value;
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
			get { return (int)AW.Data.EntityType.IllustrationEntity; }
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
