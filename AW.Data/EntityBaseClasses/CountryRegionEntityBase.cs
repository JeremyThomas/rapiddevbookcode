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
	/// <summary>Entity base class which represents the base class for the entity 'CountryRegion'.<br/><br/>
	/// 
	/// MS_Description: Lookup table containing the ISO standard codes for countries and regions.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class CountryRegionEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CountryRegionCurrencyCollection	_countryRegionCurrency;
		private bool	_alwaysFetchCountryRegionCurrency, _alreadyFetchedCountryRegionCurrency;
		private AW.Data.CollectionClasses.StateProvinceCollection	_stateProvinces;
		private bool	_alwaysFetchStateProvinces, _alreadyFetchedStateProvinces;
		private AW.Data.CollectionClasses.CurrencyCollection _currencyCollectionViaCountryRegionCurrency;
		private bool	_alwaysFetchCurrencyCollectionViaCountryRegionCurrency, _alreadyFetchedCurrencyCollectionViaCountryRegionCurrency;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaStateProvince;
		private bool	_alwaysFetchSalesTerritoryCollectionViaStateProvince, _alreadyFetchedSalesTerritoryCollectionViaStateProvince;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name CountryRegionCurrency</summary>
			public static readonly string CountryRegionCurrency = "CountryRegionCurrency";
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name CurrencyCollectionViaCountryRegionCurrency</summary>
			public static readonly string CurrencyCollectionViaCountryRegionCurrency = "CurrencyCollectionViaCountryRegionCurrency";
			/// <summary>Member name SalesTerritoryCollectionViaStateProvince</summary>
			public static readonly string SalesTerritoryCollectionViaStateProvince = "SalesTerritoryCollectionViaStateProvince";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CountryRegionEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CountryRegionEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		public CountryRegionEntityBase(System.String countryRegionCode)
		{
			InitClassFetch(countryRegionCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CountryRegionEntityBase(System.String countryRegionCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(countryRegionCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntityBase(System.String countryRegionCode, IValidator validator)
		{
			InitClassFetch(countryRegionCode, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_countryRegionCurrency = (AW.Data.CollectionClasses.CountryRegionCurrencyCollection)info.GetValue("_countryRegionCurrency", typeof(AW.Data.CollectionClasses.CountryRegionCurrencyCollection));
			_alwaysFetchCountryRegionCurrency = info.GetBoolean("_alwaysFetchCountryRegionCurrency");
			_alreadyFetchedCountryRegionCurrency = info.GetBoolean("_alreadyFetchedCountryRegionCurrency");
			_stateProvinces = (AW.Data.CollectionClasses.StateProvinceCollection)info.GetValue("_stateProvinces", typeof(AW.Data.CollectionClasses.StateProvinceCollection));
			_alwaysFetchStateProvinces = info.GetBoolean("_alwaysFetchStateProvinces");
			_alreadyFetchedStateProvinces = info.GetBoolean("_alreadyFetchedStateProvinces");
			_currencyCollectionViaCountryRegionCurrency = (AW.Data.CollectionClasses.CurrencyCollection)info.GetValue("_currencyCollectionViaCountryRegionCurrency", typeof(AW.Data.CollectionClasses.CurrencyCollection));
			_alwaysFetchCurrencyCollectionViaCountryRegionCurrency = info.GetBoolean("_alwaysFetchCurrencyCollectionViaCountryRegionCurrency");
			_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = info.GetBoolean("_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency");
			_salesTerritoryCollectionViaStateProvince = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaStateProvince", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaStateProvince = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaStateProvince");
			_alreadyFetchedSalesTerritoryCollectionViaStateProvince = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaStateProvince");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CountryRegionFieldIndex)fieldIndex)
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
			_alreadyFetchedCountryRegionCurrency = (_countryRegionCurrency.Count > 0);
			_alreadyFetchedStateProvinces = (_stateProvinces.Count > 0);
			_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = (_currencyCollectionViaCountryRegionCurrency.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaStateProvince = (_salesTerritoryCollectionViaStateProvince.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CountryRegionEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "CountryRegionCurrency":
					toReturn.Add(CountryRegionEntity.Relations.CountryRegionCurrencyEntityUsingCountryRegionCode);
					break;
				case "StateProvinces":
					toReturn.Add(CountryRegionEntity.Relations.StateProvinceEntityUsingCountryRegionCode);
					break;
				case "CurrencyCollectionViaCountryRegionCurrency":
					toReturn.Add(CountryRegionEntity.Relations.CountryRegionCurrencyEntityUsingCountryRegionCode, "CountryRegionEntity__", "CountryRegionCurrency_", JoinHint.None);
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, "CountryRegionCurrency_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaStateProvince":
					toReturn.Add(CountryRegionEntity.Relations.StateProvinceEntityUsingCountryRegionCode, "CountryRegionEntity__", "StateProvince_", JoinHint.None);
					toReturn.Add(StateProvinceEntity.Relations.SalesTerritoryEntityUsingTerritoryID, "StateProvince_", string.Empty, JoinHint.None);
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
			info.AddValue("_countryRegionCurrency", (!this.MarkedForDeletion?_countryRegionCurrency:null));
			info.AddValue("_alwaysFetchCountryRegionCurrency", _alwaysFetchCountryRegionCurrency);
			info.AddValue("_alreadyFetchedCountryRegionCurrency", _alreadyFetchedCountryRegionCurrency);
			info.AddValue("_stateProvinces", (!this.MarkedForDeletion?_stateProvinces:null));
			info.AddValue("_alwaysFetchStateProvinces", _alwaysFetchStateProvinces);
			info.AddValue("_alreadyFetchedStateProvinces", _alreadyFetchedStateProvinces);
			info.AddValue("_currencyCollectionViaCountryRegionCurrency", (!this.MarkedForDeletion?_currencyCollectionViaCountryRegionCurrency:null));
			info.AddValue("_alwaysFetchCurrencyCollectionViaCountryRegionCurrency", _alwaysFetchCurrencyCollectionViaCountryRegionCurrency);
			info.AddValue("_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency", _alreadyFetchedCurrencyCollectionViaCountryRegionCurrency);
			info.AddValue("_salesTerritoryCollectionViaStateProvince", (!this.MarkedForDeletion?_salesTerritoryCollectionViaStateProvince:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaStateProvince", _alwaysFetchSalesTerritoryCollectionViaStateProvince);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaStateProvince", _alreadyFetchedSalesTerritoryCollectionViaStateProvince);


			
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

				case "CountryRegionCurrency":
					_alreadyFetchedCountryRegionCurrency = true;
					if(entity!=null)
					{
						this.CountryRegionCurrency.Add((CountryRegionCurrencyEntity)entity);
					}
					break;
				case "StateProvinces":
					_alreadyFetchedStateProvinces = true;
					if(entity!=null)
					{
						this.StateProvinces.Add((StateProvinceEntity)entity);
					}
					break;
				case "CurrencyCollectionViaCountryRegionCurrency":
					_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = true;
					if(entity!=null)
					{
						this.CurrencyCollectionViaCountryRegionCurrency.Add((CurrencyEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaStateProvince":
					_alreadyFetchedSalesTerritoryCollectionViaStateProvince = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaStateProvince.Add((SalesTerritoryEntity)entity);
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

				case "CountryRegionCurrency":
					_countryRegionCurrency.Add((CountryRegionCurrencyEntity)relatedEntity);
					break;
				case "StateProvinces":
					_stateProvinces.Add((StateProvinceEntity)relatedEntity);
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

				case "CountryRegionCurrency":
					base.PerformRelatedEntityRemoval(_countryRegionCurrency, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "StateProvinces":
					base.PerformRelatedEntityRemoval(_stateProvinces, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_countryRegionCurrency);
			toReturn.Add(_stateProvinces);

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
			return Fetch(countryRegionCode, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CountryRegionCode, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CountryRegionFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CountryRegionFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CountryRegionRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch)
		{
			return GetMultiCountryRegionCurrency(forceFetch, _countryRegionCurrency.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCountryRegionCurrency(forceFetch, _countryRegionCurrency.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCountryRegionCurrency(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCurrency);
					}
				}
				_countryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_countryRegionCurrency.EntityFactoryToUse = entityFactoryToUse;
				}
				_countryRegionCurrency.GetMultiManyToOne(this, null, filter);
				_countryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrency = true;
			}
			return _countryRegionCurrency;
		}

		/// <summary> Sets the collection parameters for the collection for 'CountryRegionCurrency'. These settings will be taken into account
		/// when the property CountryRegionCurrency is requested or GetMultiCountryRegionCurrency is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegionCurrency(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegionCurrency.SortClauses=sortClauses;
			_countryRegionCurrency.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedStateProvinces || forceFetch || _alwaysFetchStateProvinces) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvinces.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvinces);
					}
				}
				_stateProvinces.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_stateProvinces.EntityFactoryToUse = entityFactoryToUse;
				}
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

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyCollection GetMultiCurrencyCollectionViaCountryRegionCurrency(bool forceFetch)
		{
			return GetMultiCurrencyCollectionViaCountryRegionCurrency(forceFetch, _currencyCollectionViaCountryRegionCurrency.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyCollection GetMultiCurrencyCollectionViaCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency || forceFetch || _alwaysFetchCurrencyCollectionViaCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyCollectionViaCountryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyCollectionViaCountryRegionCurrency);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, ComparisonOperator.Equal, this.CountryRegionCode, "CountryRegionEntity__"));
				_currencyCollectionViaCountryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_currencyCollectionViaCountryRegionCurrency.EntityFactoryToUse = entityFactoryToUse;
				}
				_currencyCollectionViaCountryRegionCurrency.GetMulti(filter, GetRelationsForField("CurrencyCollectionViaCountryRegionCurrency"));
				_currencyCollectionViaCountryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = true;
			}
			return _currencyCollectionViaCountryRegionCurrency;
		}

		/// <summary> Sets the collection parameters for the collection for 'CurrencyCollectionViaCountryRegionCurrency'. These settings will be taken into account
		/// when the property CurrencyCollectionViaCountryRegionCurrency is requested or GetMultiCurrencyCollectionViaCountryRegionCurrency is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyCollectionViaCountryRegionCurrency(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyCollectionViaCountryRegionCurrency.SortClauses=sortClauses;
			_currencyCollectionViaCountryRegionCurrency.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaStateProvince(bool forceFetch)
		{
			return GetMultiSalesTerritoryCollectionViaStateProvince(forceFetch, _salesTerritoryCollectionViaStateProvince.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaStateProvince(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritoryCollectionViaStateProvince || forceFetch || _alwaysFetchSalesTerritoryCollectionViaStateProvince) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryCollectionViaStateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryCollectionViaStateProvince);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, ComparisonOperator.Equal, this.CountryRegionCode, "CountryRegionEntity__"));
				_salesTerritoryCollectionViaStateProvince.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesTerritoryCollectionViaStateProvince.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesTerritoryCollectionViaStateProvince.GetMulti(filter, GetRelationsForField("SalesTerritoryCollectionViaStateProvince"));
				_salesTerritoryCollectionViaStateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryCollectionViaStateProvince = true;
			}
			return _salesTerritoryCollectionViaStateProvince;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTerritoryCollectionViaStateProvince'. These settings will be taken into account
		/// when the property SalesTerritoryCollectionViaStateProvince is requested or GetMultiSalesTerritoryCollectionViaStateProvince is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryCollectionViaStateProvince(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryCollectionViaStateProvince.SortClauses=sortClauses;
			_salesTerritoryCollectionViaStateProvince.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CountryRegionDAO dao = (CountryRegionDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_countryRegionCurrency.ActiveContext = base.ActiveContext;
			_stateProvinces.ActiveContext = base.ActiveContext;
			_currencyCollectionViaCountryRegionCurrency.ActiveContext = base.ActiveContext;
			_salesTerritoryCollectionViaStateProvince.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CountryRegionDAO dao = (CountryRegionDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CountryRegionDAO dao = (CountryRegionDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CountryRegionEntity);
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

			toReturn.Add("CountryRegionCurrency", _countryRegionCurrency);
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("CurrencyCollectionViaCountryRegionCurrency", _currencyCollectionViaCountryRegionCurrency);
			toReturn.Add("SalesTerritoryCollectionViaStateProvince", _salesTerritoryCollectionViaStateProvince);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The validator object for this CountryRegionEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String countryRegionCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(countryRegionCode, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_countryRegionCurrency = new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(new CountryRegionCurrencyEntityFactory());
			_countryRegionCurrency.SetContainingEntityInfo(this, "CountryRegion");
			_alwaysFetchCountryRegionCurrency = false;
			_alreadyFetchedCountryRegionCurrency = false;
			_stateProvinces = new AW.Data.CollectionClasses.StateProvinceCollection(new StateProvinceEntityFactory());
			_stateProvinces.SetContainingEntityInfo(this, "CountryRegion");
			_alwaysFetchStateProvinces = false;
			_alreadyFetchedStateProvinces = false;
			_currencyCollectionViaCountryRegionCurrency = new AW.Data.CollectionClasses.CurrencyCollection(new CurrencyEntityFactory());
			_alwaysFetchCurrencyCollectionViaCountryRegionCurrency = false;
			_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = false;
			_salesTerritoryCollectionViaStateProvince = new AW.Data.CollectionClasses.SalesTerritoryCollection(new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritoryCollectionViaStateProvince = false;
			_alreadyFetchedSalesTerritoryCollectionViaStateProvince = false;



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
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Country or region name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
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
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CountryRegionFieldIndex.CountryRegionCode].ForcedCurrentValueWrite(countryRegionCode);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCurrency
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(),
					(IEntityRelation)GetRelationsForField("CountryRegionCurrency")[0], (int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, "CountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvinces
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(),
					(IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyCollectionViaCountryRegionCurrency
		{
			get
			{
				IEntityRelation intermediateRelation = CountryRegionEntity.Relations.CountryRegionCurrencyEntityUsingCountryRegionCode;
				intermediateRelation.SetAliases(string.Empty, "CountryRegionCurrency_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, GetRelationsForField("CurrencyCollectionViaCountryRegionCurrency"), "CurrencyCollectionViaCountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaStateProvince
		{
			get
			{
				IEntityRelation intermediateRelation = CountryRegionEntity.Relations.StateProvinceEntityUsingCountryRegionCode;
				intermediateRelation.SetAliases(string.Empty, "StateProvince_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CountryRegionEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaStateProvince"), "SalesTerritoryCollectionViaStateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CountryRegionEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CountryRegionEntity.CustomProperties;}
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
			get { return CountryRegionEntity.FieldsCustomProperties;}
		}

		/// <summary> The CountryRegionCode property of the Entity CountryRegion<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.CountryRegionCode, value, true); }
		}
		/// <summary> The Name property of the Entity CountryRegion<br/><br/>
		/// 
		/// MS_Description: Country or region name.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CountryRegionFieldIndex.Name, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.Name, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity CountryRegion<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegion"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegionCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CountryRegionCurrencyCollection CountryRegionCurrency
		{
			get	{ return GetMultiCountryRegionCurrency(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegionCurrency. When set to true, CountryRegionCurrency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegionCurrency is accessed. You can always execute
		/// a forced fetch by calling GetMultiCountryRegionCurrency(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegionCurrency
		{
			get	{ return _alwaysFetchCountryRegionCurrency; }
			set	{ _alwaysFetchCountryRegionCurrency = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CountryRegionCurrency already has been fetched. Setting this property to false when CountryRegionCurrency has been fetched
		/// will clear the CountryRegionCurrency collection well. Setting this property to true while CountryRegionCurrency hasn't been fetched disables lazy loading for CountryRegionCurrency</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCountryRegionCurrency
		{
			get { return _alreadyFetchedCountryRegionCurrency;}
			set 
			{
				if(_alreadyFetchedCountryRegionCurrency && !value && (_countryRegionCurrency != null))
				{
					_countryRegionCurrency.Clear();
				}
				_alreadyFetchedCountryRegionCurrency = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStateProvinces()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection StateProvinces
		{
			get	{ return GetMultiStateProvinces(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvinces. When set to true, StateProvinces is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvinces is accessed. You can always execute
		/// a forced fetch by calling GetMultiStateProvinces(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyCollectionViaCountryRegionCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyCollection CurrencyCollectionViaCountryRegionCurrency
		{
			get { return GetMultiCurrencyCollectionViaCountryRegionCurrency(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyCollectionViaCountryRegionCurrency. When set to true, CurrencyCollectionViaCountryRegionCurrency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyCollectionViaCountryRegionCurrency is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyCollectionViaCountryRegionCurrency(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyCollectionViaCountryRegionCurrency
		{
			get	{ return _alwaysFetchCurrencyCollectionViaCountryRegionCurrency; }
			set	{ _alwaysFetchCurrencyCollectionViaCountryRegionCurrency = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyCollectionViaCountryRegionCurrency already has been fetched. Setting this property to false when CurrencyCollectionViaCountryRegionCurrency has been fetched
		/// will clear the CurrencyCollectionViaCountryRegionCurrency collection well. Setting this property to true while CurrencyCollectionViaCountryRegionCurrency hasn't been fetched disables lazy loading for CurrencyCollectionViaCountryRegionCurrency</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyCollectionViaCountryRegionCurrency
		{
			get { return _alreadyFetchedCurrencyCollectionViaCountryRegionCurrency;}
			set 
			{
				if(_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency && !value && (_currencyCollectionViaCountryRegionCurrency != null))
				{
					_currencyCollectionViaCountryRegionCurrency.Clear();
				}
				_alreadyFetchedCurrencyCollectionViaCountryRegionCurrency = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryCollectionViaStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryCollection SalesTerritoryCollectionViaStateProvince
		{
			get { return GetMultiSalesTerritoryCollectionViaStateProvince(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryCollectionViaStateProvince. When set to true, SalesTerritoryCollectionViaStateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryCollectionViaStateProvince is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritoryCollectionViaStateProvince(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryCollectionViaStateProvince
		{
			get	{ return _alwaysFetchSalesTerritoryCollectionViaStateProvince; }
			set	{ _alwaysFetchSalesTerritoryCollectionViaStateProvince = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritoryCollectionViaStateProvince already has been fetched. Setting this property to false when SalesTerritoryCollectionViaStateProvince has been fetched
		/// will clear the SalesTerritoryCollectionViaStateProvince collection well. Setting this property to true while SalesTerritoryCollectionViaStateProvince hasn't been fetched disables lazy loading for SalesTerritoryCollectionViaStateProvince</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritoryCollectionViaStateProvince
		{
			get { return _alreadyFetchedSalesTerritoryCollectionViaStateProvince;}
			set 
			{
				if(_alreadyFetchedSalesTerritoryCollectionViaStateProvince && !value && (_salesTerritoryCollectionViaStateProvince != null))
				{
					_salesTerritoryCollectionViaStateProvince.Clear();
				}
				_alreadyFetchedSalesTerritoryCollectionViaStateProvince = value;
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
			get { return (int)AW.Data.EntityType.CountryRegionEntity; }
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
