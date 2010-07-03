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
	
	/// <summary>Entity base class which represents the base class for the entity 'Culture'.<br/><br/>
	/// 
	/// MS_Description: Lookup table containing the languages in which some AdventureWorks data is stored.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class CultureEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection	_productModelProductDescriptionCulture;
		private bool	_alwaysFetchProductModelProductDescriptionCulture, _alreadyFetchedProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.ProductDescriptionCollection _productDescriptionCollectionViaProductModelProductDescriptionCulture;
		private bool	_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture, _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.ProductModelCollection _productModelCollectionViaProductModelProductDescriptionCulture;
		private bool	_alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture, _alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductModelProductDescriptionCulture</summary>
			public static readonly string ProductModelProductDescriptionCulture = "ProductModelProductDescriptionCulture";
			/// <summary>Member name ProductDescriptionCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string ProductDescriptionCollectionViaProductModelProductDescriptionCulture = "ProductDescriptionCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name ProductModelCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string ProductModelCollectionViaProductModelProductDescriptionCulture = "ProductModelCollectionViaProductModelProductDescriptionCulture";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CultureEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CultureEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		public CultureEntityBase(System.String cultureID)
		{
			InitClassFetch(cultureID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CultureEntityBase(System.String cultureID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(cultureID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="validator">The custom validator object for this CultureEntity</param>
		public CultureEntityBase(System.String cultureID, IValidator validator)
		{
			InitClassFetch(cultureID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CultureEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productModelProductDescriptionCulture = (AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection)info.GetValue("_productModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection));
			_alwaysFetchProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductModelProductDescriptionCulture");
			_alreadyFetchedProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductModelProductDescriptionCulture");
			_productDescriptionCollectionViaProductModelProductDescriptionCulture = (AW.Data.CollectionClasses.ProductDescriptionCollection)info.GetValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.ProductDescriptionCollection));
			_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture");
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture");
			_productModelCollectionViaProductModelProductDescriptionCulture = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_productModelCollectionViaProductModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture");
			_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CultureFieldIndex)fieldIndex)
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
			_alreadyFetchedProductModelProductDescriptionCulture = (_productModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = (_productDescriptionCollectionViaProductModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = (_productModelCollectionViaProductModelProductDescriptionCulture.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CultureEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductModelProductDescriptionCulture":
					toReturn.Add(CultureEntity.Relations.ProductModelProductDescriptionCultureEntityUsingCultureID);
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(CultureEntity.Relations.ProductModelProductDescriptionCultureEntityUsingCultureID, "CultureEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(CultureEntity.Relations.ProductModelProductDescriptionCultureEntityUsingCultureID, "CultureEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
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
			info.AddValue("_productModelProductDescriptionCulture", (!this.MarkedForDeletion?_productModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchProductModelProductDescriptionCulture", _alwaysFetchProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductModelProductDescriptionCulture", _alreadyFetchedProductModelProductDescriptionCulture);
			info.AddValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", (!this.MarkedForDeletion?_productDescriptionCollectionViaProductModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture", _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture", _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_productModelCollectionViaProductModelProductDescriptionCulture", (!this.MarkedForDeletion?_productModelCollectionViaProductModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture", _alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture", _alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture);


			
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

				case "ProductModelProductDescriptionCulture":
					_alreadyFetchedProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.ProductModelProductDescriptionCulture.Add((ProductModelProductDescriptionCultureEntity)entity);
					}
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.ProductDescriptionCollectionViaProductModelProductDescriptionCulture.Add((ProductDescriptionEntity)entity);
					}
					break;
				case "ProductModelCollectionViaProductModelProductDescriptionCulture":
					_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.ProductModelCollectionViaProductModelProductDescriptionCulture.Add((ProductModelEntity)entity);
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

				case "ProductModelProductDescriptionCulture":
					_productModelProductDescriptionCulture.Add((ProductModelProductDescriptionCultureEntity)relatedEntity);
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

				case "ProductModelProductDescriptionCulture":
					base.PerformRelatedEntityRemoval(_productModelProductDescriptionCulture, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_productModelProductDescriptionCulture);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cultureID)
		{
			return FetchUsingPK(cultureID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cultureID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(cultureID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(cultureID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(cultureID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CultureID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CultureFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CultureFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CultureRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, _productModelProductDescriptionCulture.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, _productModelProductDescriptionCulture.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelProductDescriptionCulture.GetMultiManyToOne(this, null, null, filter);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductModelProductDescriptionCulture is requested or GetMultiProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelProductDescriptionCulture.SortClauses=sortClauses;
			_productModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDescriptionEntity'</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(forceFetch, _productDescriptionCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productDescriptionCollectionViaProductModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDescriptionCollectionViaProductModelProductDescriptionCulture);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CultureFields.CultureID, ComparisonOperator.Equal, this.CultureID, "CultureEntity__"));
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productDescriptionCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.GetMulti(filter, GetRelationsForField("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"));
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = true;
			}
			return _productDescriptionCollectionViaProductModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductDescriptionCollectionViaProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductDescriptionCollectionViaProductModelProductDescriptionCulture is requested or GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDescriptionCollectionViaProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.SortClauses=sortClauses;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiProductModelCollectionViaProductModelProductDescriptionCulture(forceFetch, _productModelCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelCollectionViaProductModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelCollectionViaProductModelProductDescriptionCulture);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CultureFields.CultureID, ComparisonOperator.Equal, this.CultureID, "CultureEntity__"));
				_productModelCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelCollectionViaProductModelProductDescriptionCulture.GetMulti(filter, GetRelationsForField("ProductModelCollectionViaProductModelProductDescriptionCulture"));
				_productModelCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = true;
			}
			return _productModelCollectionViaProductModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelCollectionViaProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductModelCollectionViaProductModelProductDescriptionCulture is requested or GetMultiProductModelCollectionViaProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelCollectionViaProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelCollectionViaProductModelProductDescriptionCulture.SortClauses=sortClauses;
			_productModelCollectionViaProductModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CultureDAO dao = (CultureDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productModelProductDescriptionCulture.ActiveContext = base.ActiveContext;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.ActiveContext = base.ActiveContext;
			_productModelCollectionViaProductModelProductDescriptionCulture.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CultureDAO dao = (CultureDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CultureDAO dao = (CultureDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CultureEntity);
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

			toReturn.Add("ProductModelProductDescriptionCulture", _productModelProductDescriptionCulture);
			toReturn.Add("ProductDescriptionCollectionViaProductModelProductDescriptionCulture", _productDescriptionCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("ProductModelCollectionViaProductModelProductDescriptionCulture", _productModelCollectionViaProductModelProductDescriptionCulture);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="validator">The validator object for this CultureEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String cultureID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(cultureID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productModelProductDescriptionCulture = new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(new ProductModelProductDescriptionCultureEntityFactory());
			_productModelProductDescriptionCulture.SetContainingEntityInfo(this, "Culture");
			_alwaysFetchProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductModelProductDescriptionCulture = false;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture = new AW.Data.CollectionClasses.ProductDescriptionCollection(new ProductDescriptionEntityFactory());
			_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = false;
			_productModelCollectionViaProductModelProductDescriptionCulture = new AW.Data.CollectionClasses.ProductModelCollection(new ProductModelEntityFactory());
			_alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = false;



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
			_customProperties.Add("MS_Description", @"Lookup table containing the languages in which some AdventureWorks data is stored.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CultureID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Culture description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="cultureID">PK value for Culture which data should be fetched into this Culture object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String cultureID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CultureFieldIndex.CultureID].ForcedCurrentValueWrite(cultureID);
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
			return DAOFactory.CreateCultureDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CultureEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CultureRelations Relations
		{
			get	{ return new CultureRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelProductDescriptionCulture
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(),
					(IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCulture")[0], (int)AW.Data.EntityType.CultureEntity, (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, "ProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDescription' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = CultureEntity.Relations.ProductModelProductDescriptionCultureEntityUsingCultureID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDescriptionCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CultureEntity, (int)AW.Data.EntityType.ProductDescriptionEntity, 0, null, null, GetRelationsForField("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"), "ProductDescriptionCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = CultureEntity.Relations.ProductModelProductDescriptionCultureEntityUsingCultureID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CultureEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProductModelProductDescriptionCulture"), "ProductModelCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CultureEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CultureEntity.CustomProperties;}
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
			get { return CultureEntity.FieldsCustomProperties;}
		}

		/// <summary> The CultureID property of the Entity Culture<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Culture"."CultureID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 6<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CultureID
		{
			get { return (System.String)GetValue((int)CultureFieldIndex.CultureID, true); }
			set	{ SetValue((int)CultureFieldIndex.CultureID, value, true); }
		}
		/// <summary> The Name property of the Entity Culture<br/><br/>
		/// 
		/// MS_Description: Culture description.<br/></summary>
		/// <remarks>Mapped on  table field: "Culture"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CultureFieldIndex.Name, true); }
			set	{ SetValue((int)CultureFieldIndex.Name, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Culture<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Culture"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CultureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CultureFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection ProductModelProductDescriptionCulture
		{
			get	{ return GetMultiProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelProductDescriptionCulture. When set to true, ProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchProductModelProductDescriptionCulture = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelProductDescriptionCulture already has been fetched. Setting this property to false when ProductModelProductDescriptionCulture has been fetched
		/// will clear the ProductModelProductDescriptionCulture collection well. Setting this property to true while ProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for ProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedProductModelProductDescriptionCulture && !value && (_productModelProductDescriptionCulture != null))
				{
					_productModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedProductModelProductDescriptionCulture = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDescriptionCollection ProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDescriptionCollectionViaProductModelProductDescriptionCulture. When set to true, ProductDescriptionCollectionViaProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDescriptionCollectionViaProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDescriptionCollectionViaProductModelProductDescriptionCulture already has been fetched. Setting this property to false when ProductDescriptionCollectionViaProductModelProductDescriptionCulture has been fetched
		/// will clear the ProductDescriptionCollectionViaProductModelProductDescriptionCulture collection well. Setting this property to true while ProductDescriptionCollectionViaProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for ProductDescriptionCollectionViaProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture && !value && (_productDescriptionCollectionViaProductModelProductDescriptionCulture != null))
				{
					_productDescriptionCollectionViaProductModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelCollectionViaProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection ProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetMultiProductModelCollectionViaProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelCollectionViaProductModelProductDescriptionCulture. When set to true, ProductModelCollectionViaProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelCollectionViaProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelCollectionViaProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchProductModelCollectionViaProductModelProductDescriptionCulture = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelCollectionViaProductModelProductDescriptionCulture already has been fetched. Setting this property to false when ProductModelCollectionViaProductModelProductDescriptionCulture has been fetched
		/// will clear the ProductModelCollectionViaProductModelProductDescriptionCulture collection well. Setting this property to true while ProductModelCollectionViaProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for ProductModelCollectionViaProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture && !value && (_productModelCollectionViaProductModelProductDescriptionCulture != null))
				{
					_productModelCollectionViaProductModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedProductModelCollectionViaProductModelProductDescriptionCulture = value;
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
			get { return (int)AW.Data.EntityType.CultureEntity; }
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
