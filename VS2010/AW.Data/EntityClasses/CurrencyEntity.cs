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

	/// <summary>Entity class which represents the entity 'Currency'. <br/><br/>
	/// 
	/// MS_Description: Lookup table containing standard ISO currencies.<br/>
	/// </summary>
	[Serializable]
	public partial class CurrencyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CountryRegionCurrencyCollection	_countryRegionCurrencies;
		private bool	_alwaysFetchCountryRegionCurrencies, _alreadyFetchedCountryRegionCurrencies;
		private AW.Data.CollectionClasses.CurrencyRateCollection	_currencyRates;
		private bool	_alwaysFetchCurrencyRates, _alreadyFetchedCurrencyRates;
		private AW.Data.CollectionClasses.CurrencyRateCollection	_currencyRates_;
		private bool	_alwaysFetchCurrencyRates_, _alreadyFetchedCurrencyRates_;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name CurrencyRates</summary>
			public static readonly string CurrencyRates = "CurrencyRates";
			/// <summary>Member name CurrencyRates_</summary>
			public static readonly string CurrencyRates_ = "CurrencyRates_";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CurrencyEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CurrencyEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		public CurrencyEntity(System.String currencyCode)
		{
			InitClassFetch(currencyCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CurrencyEntity(System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(currencyCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		public CurrencyEntity(System.String currencyCode, IValidator validator)
		{
			InitClassFetch(currencyCode, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_countryRegionCurrencies = (AW.Data.CollectionClasses.CountryRegionCurrencyCollection)info.GetValue("_countryRegionCurrencies", typeof(AW.Data.CollectionClasses.CountryRegionCurrencyCollection));
			_alwaysFetchCountryRegionCurrencies = info.GetBoolean("_alwaysFetchCountryRegionCurrencies");
			_alreadyFetchedCountryRegionCurrencies = info.GetBoolean("_alreadyFetchedCountryRegionCurrencies");

			_currencyRates = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRates", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRates = info.GetBoolean("_alwaysFetchCurrencyRates");
			_alreadyFetchedCurrencyRates = info.GetBoolean("_alreadyFetchedCurrencyRates");

			_currencyRates_ = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRates_", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRates_ = info.GetBoolean("_alwaysFetchCurrencyRates_");
			_alreadyFetchedCurrencyRates_ = info.GetBoolean("_alreadyFetchedCurrencyRates_");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedCountryRegionCurrencies = (_countryRegionCurrencies.Count > 0);
			_alreadyFetchedCurrencyRates = (_currencyRates.Count > 0);
			_alreadyFetchedCurrencyRates_ = (_currencyRates_.Count > 0);
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
				case "CountryRegionCurrencies":
					toReturn.Add(Relations.CountryRegionCurrencyEntityUsingCurrencyCode);
					break;
				case "CurrencyRates":
					toReturn.Add(Relations.CurrencyRateEntityUsingFromCurrencyCode);
					break;
				case "CurrencyRates_":
					toReturn.Add(Relations.CurrencyRateEntityUsingToCurrencyCode);
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
			info.AddValue("_countryRegionCurrencies", (!this.MarkedForDeletion?_countryRegionCurrencies:null));
			info.AddValue("_alwaysFetchCountryRegionCurrencies", _alwaysFetchCountryRegionCurrencies);
			info.AddValue("_alreadyFetchedCountryRegionCurrencies", _alreadyFetchedCountryRegionCurrencies);
			info.AddValue("_currencyRates", (!this.MarkedForDeletion?_currencyRates:null));
			info.AddValue("_alwaysFetchCurrencyRates", _alwaysFetchCurrencyRates);
			info.AddValue("_alreadyFetchedCurrencyRates", _alreadyFetchedCurrencyRates);
			info.AddValue("_currencyRates_", (!this.MarkedForDeletion?_currencyRates_:null));
			info.AddValue("_alwaysFetchCurrencyRates_", _alwaysFetchCurrencyRates_);
			info.AddValue("_alreadyFetchedCurrencyRates_", _alreadyFetchedCurrencyRates_);

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
				case "CountryRegionCurrencies":
					_alreadyFetchedCountryRegionCurrencies = true;
					if(entity!=null)
					{
						this.CountryRegionCurrencies.Add((CountryRegionCurrencyEntity)entity);
					}
					break;
				case "CurrencyRates":
					_alreadyFetchedCurrencyRates = true;
					if(entity!=null)
					{
						this.CurrencyRates.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CurrencyRates_":
					_alreadyFetchedCurrencyRates_ = true;
					if(entity!=null)
					{
						this.CurrencyRates_.Add((CurrencyRateEntity)entity);
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
				case "CountryRegionCurrencies":
					_countryRegionCurrencies.Add((CountryRegionCurrencyEntity)relatedEntity);
					break;
				case "CurrencyRates":
					_currencyRates.Add((CurrencyRateEntity)relatedEntity);
					break;
				case "CurrencyRates_":
					_currencyRates_.Add((CurrencyRateEntity)relatedEntity);
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
				case "CountryRegionCurrencies":
					this.PerformRelatedEntityRemoval(_countryRegionCurrencies, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates":
					this.PerformRelatedEntityRemoval(_currencyRates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates_":
					this.PerformRelatedEntityRemoval(_currencyRates_, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_countryRegionCurrencies);
			toReturn.Add(_currencyRates);
			toReturn.Add(_currencyRates_);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String currencyCode)
		{
			return FetchUsingPK(currencyCode, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(currencyCode, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(currencyCode, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(currencyCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CurrencyCode, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CurrencyRelations().GetAllRelations();
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
				_countryRegionCurrencies.GetMultiManyToOne(null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates(bool forceFetch)
		{
			return GetMultiCurrencyRates(forceFetch, _currencyRates.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCurrencyRates(forceFetch, _currencyRates.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCurrencyRates(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCurrencyRates || forceFetch || _alwaysFetchCurrencyRates) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_currencyRates);
				_currencyRates.SuppressClearInGetMulti=!forceFetch;
				_currencyRates.EntityFactoryToUse = entityFactoryToUse;
				_currencyRates.GetMultiManyToOne(this, null, filter);
				_currencyRates.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRates = true;
			}
			return _currencyRates;
		}

		/// <summary> Sets the collection parameters for the collection for 'CurrencyRates'. These settings will be taken into account
		/// when the property CurrencyRates is requested or GetMultiCurrencyRates is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRates(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRates.SortClauses=sortClauses;
			_currencyRates.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates_(bool forceFetch)
		{
			return GetMultiCurrencyRates_(forceFetch, _currencyRates_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCurrencyRates_(forceFetch, _currencyRates_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCurrencyRates_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRates_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCurrencyRates_ || forceFetch || _alwaysFetchCurrencyRates_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_currencyRates_);
				_currencyRates_.SuppressClearInGetMulti=!forceFetch;
				_currencyRates_.EntityFactoryToUse = entityFactoryToUse;
				_currencyRates_.GetMultiManyToOne(null, this, filter);
				_currencyRates_.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRates_ = true;
			}
			return _currencyRates_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CurrencyRates_'. These settings will be taken into account
		/// when the property CurrencyRates_ is requested or GetMultiCurrencyRates_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRates_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRates_.SortClauses=sortClauses;
			_currencyRates_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_countryRegionCurrencies.ActiveContext = this.ActiveContext;
			_currencyRates.ActiveContext = this.ActiveContext;
			_currencyRates_.ActiveContext = this.ActiveContext;
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegionCurrencies", _countryRegionCurrencies);
			toReturn.Add("CurrencyRates", _currencyRates);
			toReturn.Add("CurrencyRates_", _currencyRates_);
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
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The validator object for this CurrencyEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String currencyCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(currencyCode, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_countryRegionCurrencies = new AW.Data.CollectionClasses.CountryRegionCurrencyCollection();
			_countryRegionCurrencies.SetContainingEntityInfo(this, "Currency");

			_currencyRates = new AW.Data.CollectionClasses.CurrencyRateCollection();
			_currencyRates.SetContainingEntityInfo(this, "Currency");

			_currencyRates_ = new AW.Data.CollectionClasses.CurrencyRateCollection();
			_currencyRates_.SetContainingEntityInfo(this, "Currency_");
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
			_customProperties.Add("MS_Description", @"Lookup table containing standard ISO currencies.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Currency name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CurrencyFieldIndex.CurrencyCode].ForcedCurrentValueWrite(currencyCode);
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
			return DAOFactory.CreateCurrencyDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CurrencyEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CurrencyRelations Relations
		{
			get	{ return new CurrencyRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCurrencies
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(), (IEntityRelation)GetRelationsForField("CountryRegionCurrencies")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, "CountryRegionCurrencies", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRates
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), (IEntityRelation)GetRelationsForField("CurrencyRates")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRates_
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), (IEntityRelation)GetRelationsForField("CurrencyRates_")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRates_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "CurrencyEntity";}
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

		/// <summary> The CurrencyCode property of the Entity Currency<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CurrencyFieldIndex.CurrencyCode, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Currency<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity Currency<br/><br/>
		/// MS_Description: Currency name.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.Name, true); }
			set	{ SetValue((int)CurrencyFieldIndex.Name, value, true); }
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
		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRates()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRates
		{
			get	{ return GetMultiCurrencyRates(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRates. When set to true, CurrencyRates is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRates is accessed. You can always execute/ a forced fetch by calling GetMultiCurrencyRates(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRates
		{
			get	{ return _alwaysFetchCurrencyRates; }
			set	{ _alwaysFetchCurrencyRates = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyRates already has been fetched. Setting this property to false when CurrencyRates has been fetched
		/// will clear the CurrencyRates collection well. Setting this property to true while CurrencyRates hasn't been fetched disables lazy loading for CurrencyRates</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyRates
		{
			get { return _alreadyFetchedCurrencyRates;}
			set 
			{
				if(_alreadyFetchedCurrencyRates && !value && (_currencyRates != null))
				{
					_currencyRates.Clear();
				}
				_alreadyFetchedCurrencyRates = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRates_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRates_
		{
			get	{ return GetMultiCurrencyRates_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRates_. When set to true, CurrencyRates_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRates_ is accessed. You can always execute/ a forced fetch by calling GetMultiCurrencyRates_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRates_
		{
			get	{ return _alwaysFetchCurrencyRates_; }
			set	{ _alwaysFetchCurrencyRates_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyRates_ already has been fetched. Setting this property to false when CurrencyRates_ has been fetched
		/// will clear the CurrencyRates_ collection well. Setting this property to true while CurrencyRates_ hasn't been fetched disables lazy loading for CurrencyRates_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyRates_
		{
			get { return _alreadyFetchedCurrencyRates_;}
			set 
			{
				if(_alreadyFetchedCurrencyRates_ && !value && (_currencyRates_ != null))
				{
					_currencyRates_.Clear();
				}
				_alreadyFetchedCurrencyRates_ = value;
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
			get { return (int)AW.Data.EntityType.CurrencyEntity; }
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
