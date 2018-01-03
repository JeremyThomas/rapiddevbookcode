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
using AW.Helper;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'CountryRegion'. <br/><br/>
	/// 
	/// MS_Description: Lookup table containing the ISO standard codes for countries and regions.<br/>
	/// </summary>
	[Serializable]
	public partial class CountryRegionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.StateProvinceCollection	_stateProvinces;
		private bool	_alwaysFetchStateProvinces, _alreadyFetchedStateProvinces;
		private AW.Data.CollectionClasses.CountryRegionCurrencyCollection	_countryRegionCurrencies;
		private bool	_alwaysFetchCountryRegionCurrencies, _alreadyFetchedCountryRegionCurrencies;
		private AW.Data.CollectionClasses.CurrencyCollection _currencies;
		private bool	_alwaysFetchCurrencies, _alreadyFetchedCurrencies;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name Currencies</summary>
			public static readonly string Currencies = "Currencies";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CountryRegionEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CountryRegionEntity() :base("CountryRegionEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		public CountryRegionEntity(System.String countryRegionCode):base("CountryRegionEntity")
		{
			InitClassFetch(countryRegionCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CountryRegionEntity(System.String countryRegionCode, IPrefetchPath prefetchPathToUse):base("CountryRegionEntity")
		{
			InitClassFetch(countryRegionCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(System.String countryRegionCode, IValidator validator):base("CountryRegionEntity")
		{
			InitClassFetch(countryRegionCode, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_stateProvinces = (AW.Data.CollectionClasses.StateProvinceCollection)info.GetValue("_stateProvinces", typeof(AW.Data.CollectionClasses.StateProvinceCollection));
			_alwaysFetchStateProvinces = info.GetBoolean("_alwaysFetchStateProvinces");
			_alreadyFetchedStateProvinces = info.GetBoolean("_alreadyFetchedStateProvinces");

			_countryRegionCurrencies = (AW.Data.CollectionClasses.CountryRegionCurrencyCollection)info.GetValue("_countryRegionCurrencies", typeof(AW.Data.CollectionClasses.CountryRegionCurrencyCollection));
			_alwaysFetchCountryRegionCurrencies = info.GetBoolean("_alwaysFetchCountryRegionCurrencies");
			_alreadyFetchedCountryRegionCurrencies = info.GetBoolean("_alreadyFetchedCountryRegionCurrencies");
			_currencies = (AW.Data.CollectionClasses.CurrencyCollection)info.GetValue("_currencies", typeof(AW.Data.CollectionClasses.CurrencyCollection));
			_alwaysFetchCurrencies = info.GetBoolean("_alwaysFetchCurrencies");
			_alreadyFetchedCurrencies = info.GetBoolean("_alreadyFetchedCurrencies");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedStateProvinces = (_stateProvinces.Count > 0);
			_alreadyFetchedCountryRegionCurrencies = (_countryRegionCurrencies.Count > 0);
			_alreadyFetchedCurrencies = (_currencies.Count > 0);
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
				case "StateProvinces":
					toReturn.Add(Relations.StateProvinceEntityUsingCountryRegionCode);
					break;
				case "CountryRegionCurrencies":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCountryRegionCode);
					break;
				case "Currencies":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCountryRegionCode, "CountryRegionEntity__", "CountryRegionCurrency_", JoinHint.None);
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, "CountryRegionCurrency_", string.Empty, JoinHint.None);
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
			info.AddValue("_stateProvinces", (!this.MarkedForDeletion?_stateProvinces:null));
			info.AddValue("_alwaysFetchStateProvinces", _alwaysFetchStateProvinces);
			info.AddValue("_alreadyFetchedStateProvinces", _alreadyFetchedStateProvinces);
			info.AddValue("_countryRegionCurrencies", (!this.MarkedForDeletion?_countryRegionCurrencies:null));
			info.AddValue("_alwaysFetchCountryRegionCurrencies", _alwaysFetchCountryRegionCurrencies);
			info.AddValue("_alreadyFetchedCountryRegionCurrencies", _alreadyFetchedCountryRegionCurrencies);
			info.AddValue("_currencies", (!this.MarkedForDeletion?_currencies:null));
			info.AddValue("_alwaysFetchCurrencies", _alwaysFetchCurrencies);
			info.AddValue("_alreadyFetchedCurrencies", _alreadyFetchedCurrencies);

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
				case "StateProvinces":
					_alreadyFetchedStateProvinces = true;
					if(entity!=null)
					{
						this.StateProvinces.Add((StateProvinceEntity)entity);
					}
					break;
				case "CountryRegionCurrencies":
					_alreadyFetchedCountryRegionCurrencies = true;
					if(entity!=null)
					{
						this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)entity);
					}
					break;
				case "Currencies":
					_alreadyFetchedCurrencies = true;
					if(entity!=null)
					{
						this.Currencies.Add((CurrencyEntity)entity);
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
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "StateProvinces":
					_stateProvinces.Add((StateProvinceEntity)relatedEntity);
					break;
				case "CountryRegionCurrencies":
					_countryRegionCurrencies.Add((CountryRegionCurrencyEntity)relatedEntity);
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
				case "StateProvinces":
					this.PerformRelatedEntityRemoval(_stateProvinces, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CountryRegionCurrencies":
					this.PerformRelatedEntityRemoval(_countryRegionCurrencies, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_stateProvinces);
			toReturn.Add(_countryRegionCurrencies);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode)
		{
			return FetchUsingPK(countryRegionCode, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(countryRegionCode, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(countryRegionCode, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(countryRegionCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CountryRegionCode, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CountryRegionRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStateProvinces(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStateProvinces || forceFetch || _alwaysFetchStateProvinces) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_stateProvinces);
				_stateProvinces.SuppressClearInGetMulti=!forceFetch;
				_stateProvinces.EntityFactoryToUse = entityFactoryToUse;
				_stateProvinces.GetMultiManyToOne(this, null, filter);
				_stateProvinces.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvinces = true;
			}
			return _stateProvinces;
		}

		/// <summary> Sets the collection parameters for the collection for 'StateProvinces'. These settings will be taken into account
		/// when the property StateProvinces is requested or GetMultiStateProvinces is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStateProvinces(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stateProvinces.SortClauses=sortClauses;
			_stateProvinces.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrencies(bool forceFetch)
		{
			return GetMultiCountryRegionCurrencies(forceFetch, _countryRegionCurrencies.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrencies(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCountryRegionCurrencies(forceFetch, _countryRegionCurrencies.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrencies(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCountryRegionCurrencies(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrencies(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrencies || forceFetch || _alwaysFetchCountryRegionCurrencies) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_countryRegionCurrencies);
				_countryRegionCurrencies.SuppressClearInGetMulti=!forceFetch;
				_countryRegionCurrencies.EntityFactoryToUse = entityFactoryToUse;
				_countryRegionCurrencies.GetMultiManyToOne(this, null, filter);
				_countryRegionCurrencies.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrencies = true;
			}
			return _countryRegionCurrencies;
		}

		/// <summary> Sets the collection parameters for the collection for 'CountryRegionCurrencies'. These settings will be taken into account
		/// when the property CountryRegionCurrencies is requested or GetMultiCountryRegionCurrencies is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegionCurrencies(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegionCurrencies.SortClauses=sortClauses;
			_countryRegionCurrencies.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyCollection GetMultiCurrencies(bool forceFetch)
		{
			return GetMultiCurrencies(forceFetch, _currencies.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyCollection GetMultiCurrencies(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencies || forceFetch || _alwaysFetchCurrencies) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_currencies);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, ComparisonOperator.Equal, this.CountryRegionCode, "CountryRegionEntity__"));
				_currencies.SuppressClearInGetMulti=!forceFetch;
				_currencies.EntityFactoryToUse = entityFactoryToUse;
				_currencies.GetMulti(filter, GetRelationsForField("Currencies"));
				_currencies.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencies = true;
			}
			return _currencies;
		}

		/// <summary> Sets the collection parameters for the collection for 'Currencies'. These settings will be taken into account
		/// when the property Currencies is requested or GetMultiCurrencies is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencies(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencies.SortClauses=sortClauses;
			_currencies.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("CountryRegionCurrencies", _countryRegionCurrencies);
			toReturn.Add("Currencies", _currencies);
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
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The validator object for this CountryRegionEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String countryRegionCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(countryRegionCode, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_stateProvinces = new AW.Data.CollectionClasses.StateProvinceCollection();
			_stateProvinces.SetContainingEntityInfo(this, "CountryRegion");

			_countryRegionCurrencies = new AW.Data.CollectionClasses.CountryRegionCurrencyCollection();
			_countryRegionCurrencies.SetContainingEntityInfo(this, "CountryRegion");
			_currencies = new AW.Data.CollectionClasses.CurrencyCollection();
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
			_customProperties.Add("MS_Description", @"Lookup table containing the ISO standard codes for countries and regions.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Country or region name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String countryRegionCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CountryRegionFieldIndex.CountryRegionCode].ForcedCurrentValueWrite(countryRegionCode);
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
			return DAOFactory.CreateCountryRegionDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CountryRegionEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CountryRegionRelations Relations
		{
			get	{ return new CountryRegionRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvinces
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(), (IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCurrencies
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(), (IEntityRelation)GetRelationsForField("CountryRegionCurrencies")[0], (int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, "CountryRegionCurrencies", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencies
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CountryRegionCurrencyEntityUsingCountryRegionCode;
				intermediateRelation.SetAliases(string.Empty, "CountryRegionCurrency_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(), intermediateRelation,	(int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, GetRelationsForField("Currencies"), "Currencies", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The CountryRegionCode property of the Entity CountryRegion<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.CountryRegionCode, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity CountryRegion<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity CountryRegion<br/><br/>
		/// MS_Description: Country or region name.<br/>Country or region name.</summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.Name, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStateProvinces()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection StateProvinces
		{
			get	{ return GetMultiStateProvinces(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvinces. When set to true, StateProvinces is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvinces is accessed. You can always execute/ a forced fetch by calling GetMultiStateProvinces(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvinces
		{
			get	{ return _alwaysFetchStateProvinces; }
			set	{ _alwaysFetchStateProvinces = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StateProvinces already has been fetched. Setting this property to false when StateProvinces has been fetched
		/// will clear the StateProvinces collection well. Setting this property to true while StateProvinces hasn't been fetched disables lazy loading for StateProvinces</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStateProvinces
		{
			get { return _alreadyFetchedStateProvinces;}
			set 
			{
				if(_alreadyFetchedStateProvinces && !value && (_stateProvinces != null))
				{
					_stateProvinces.Clear();
				}
				_alreadyFetchedStateProvinces = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegionCurrencies()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CountryRegionCurrencyCollection CountryRegionCurrencies
		{
			get	{ return GetMultiCountryRegionCurrencies(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegionCurrencies. When set to true, CountryRegionCurrencies is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegionCurrencies is accessed. You can always execute/ a forced fetch by calling GetMultiCountryRegionCurrencies(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegionCurrencies
		{
			get	{ return _alwaysFetchCountryRegionCurrencies; }
			set	{ _alwaysFetchCountryRegionCurrencies = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CountryRegionCurrencies already has been fetched. Setting this property to false when CountryRegionCurrencies has been fetched
		/// will clear the CountryRegionCurrencies collection well. Setting this property to true while CountryRegionCurrencies hasn't been fetched disables lazy loading for CountryRegionCurrencies</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCountryRegionCurrencies
		{
			get { return _alreadyFetchedCountryRegionCurrencies;}
			set 
			{
				if(_alreadyFetchedCountryRegionCurrencies && !value && (_countryRegionCurrencies != null))
				{
					_countryRegionCurrencies.Clear();
				}
				_alreadyFetchedCountryRegionCurrencies = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencies()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyCollection Currencies
		{
			get { return GetMultiCurrencies(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Currencies. When set to true, Currencies is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currencies is accessed. You can always execute a forced fetch by calling GetMultiCurrencies(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencies
		{
			get	{ return _alwaysFetchCurrencies; }
			set	{ _alwaysFetchCurrencies = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Currencies already has been fetched. Setting this property to false when Currencies has been fetched
		/// will clear the Currencies collection well. Setting this property to true while Currencies hasn't been fetched disables lazy loading for Currencies</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencies
		{
			get { return _alreadyFetchedCurrencies;}
			set 
			{
				if(_alreadyFetchedCurrencies && !value && (_currencies != null))
				{
					_currencies.Clear();
				}
				_alreadyFetchedCurrencies = value;
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
			get { return (int)AW.Data.EntityType.CountryRegionEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
	  public static CountryRegionCollection GetCountryRegionCollection()
	  {
	    ISortExpression sort = new SortExpression();
	    sort.Add(CountryRegionFields.Name | SortOperator.Ascending);
	    var countries = new CountryRegionCollection();
	    var parameters = new QueryParameters()
	    {
	      SorterToUse = sort,
	      CacheResultset = true,
	      CacheDuration = new TimeSpan(1, 0, 0)
	    };
	    countries.PerformGetMulti(parameters);
	    return countries;
	  }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
