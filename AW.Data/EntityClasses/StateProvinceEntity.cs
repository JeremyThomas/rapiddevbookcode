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
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'StateProvince'. <br/><br/>
	/// 
	/// MS_Description: State and province lookup table.<br/>
	/// </summary>
	[Serializable]
	public partial class StateProvinceEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.AddressCollection	_addresses;
		private bool	_alwaysFetchAddresses, _alreadyFetchedAddresses;
		private AW.Data.CollectionClasses.SalesTaxRateCollection	_salesTaxRates;
		private bool	_alwaysFetchSalesTaxRates, _alreadyFetchedSalesTaxRates;
		private CountryRegionEntity _countryRegion;
		private bool	_alwaysFetchCountryRegion, _alreadyFetchedCountryRegion, _countryRegionReturnsNewIfNotFound;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory, _salesTerritoryReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegion</summary>
			public static readonly string CountryRegion = "CountryRegion";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name Addresses</summary>
			public static readonly string Addresses = "Addresses";
			/// <summary>Member name SalesTaxRates</summary>
			public static readonly string SalesTaxRates = "SalesTaxRates";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StateProvinceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StateProvinceEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		public StateProvinceEntity(System.Int32 stateProvinceID)
		{
			InitClassFetch(stateProvinceID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StateProvinceEntity(System.Int32 stateProvinceID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(stateProvinceID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		public StateProvinceEntity(System.Int32 stateProvinceID, IValidator validator)
		{
			InitClassFetch(stateProvinceID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StateProvinceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_addresses = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addresses", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddresses = info.GetBoolean("_alwaysFetchAddresses");
			_alreadyFetchedAddresses = info.GetBoolean("_alreadyFetchedAddresses");

			_salesTaxRates = (AW.Data.CollectionClasses.SalesTaxRateCollection)info.GetValue("_salesTaxRates", typeof(AW.Data.CollectionClasses.SalesTaxRateCollection));
			_alwaysFetchSalesTaxRates = info.GetBoolean("_alwaysFetchSalesTaxRates");
			_alreadyFetchedSalesTaxRates = info.GetBoolean("_alreadyFetchedSalesTaxRates");
			_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
			if(_countryRegion!=null)
			{
				_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_countryRegionReturnsNewIfNotFound = info.GetBoolean("_countryRegionReturnsNewIfNotFound");
			_alwaysFetchCountryRegion = info.GetBoolean("_alwaysFetchCountryRegion");
			_alreadyFetchedCountryRegion = info.GetBoolean("_alreadyFetchedCountryRegion");

			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesTerritoryReturnsNewIfNotFound = info.GetBoolean("_salesTerritoryReturnsNewIfNotFound");
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((StateProvinceFieldIndex)fieldIndex)
			{
				case StateProvinceFieldIndex.CountryRegionCode:
					DesetupSyncCountryRegion(true, false);
					_alreadyFetchedCountryRegion = false;
					break;
				case StateProvinceFieldIndex.TerritoryID:
					DesetupSyncSalesTerritory(true, false);
					_alreadyFetchedSalesTerritory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedAddresses = (_addresses.Count > 0);
			_alreadyFetchedSalesTaxRates = (_salesTaxRates.Count > 0);
			_alreadyFetchedCountryRegion = (_countryRegion != null);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
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
				case "CountryRegion":
					toReturn.Add(Relations.CountryRegionEntityUsingCountryRegionCode);
					break;
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryID);
					break;
				case "Addresses":
					toReturn.Add(Relations.AddressEntityUsingStateProvinceID);
					break;
				case "SalesTaxRates":
					toReturn.Add(Relations.SalesTaxRateEntityUsingStateProvinceID);
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
			info.AddValue("_addresses", (!this.MarkedForDeletion?_addresses:null));
			info.AddValue("_alwaysFetchAddresses", _alwaysFetchAddresses);
			info.AddValue("_alreadyFetchedAddresses", _alreadyFetchedAddresses);
			info.AddValue("_salesTaxRates", (!this.MarkedForDeletion?_salesTaxRates:null));
			info.AddValue("_alwaysFetchSalesTaxRates", _alwaysFetchSalesTaxRates);
			info.AddValue("_alreadyFetchedSalesTaxRates", _alreadyFetchedSalesTaxRates);
			info.AddValue("_countryRegion", (!this.MarkedForDeletion?_countryRegion:null));
			info.AddValue("_countryRegionReturnsNewIfNotFound", _countryRegionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCountryRegion", _alwaysFetchCountryRegion);
			info.AddValue("_alreadyFetchedCountryRegion", _alreadyFetchedCountryRegion);
			info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
			info.AddValue("_salesTerritoryReturnsNewIfNotFound", _salesTerritoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);

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
				case "CountryRegion":
					_alreadyFetchedCountryRegion = true;
					this.CountryRegion = (CountryRegionEntity)entity;
					break;
				case "SalesTerritory":
					_alreadyFetchedSalesTerritory = true;
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "Addresses":
					_alreadyFetchedAddresses = true;
					if(entity!=null)
					{
						this.Addresses.Add((AddressEntity)entity);
					}
					break;
				case "SalesTaxRates":
					_alreadyFetchedSalesTaxRates = true;
					if(entity!=null)
					{
						this.SalesTaxRates.Add((SalesTaxRateEntity)entity);
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "Addresses":
					_addresses.Add((AddressEntity)relatedEntity);
					break;
				case "SalesTaxRates":
					_salesTaxRates.Add((SalesTaxRateEntity)relatedEntity);
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
				case "CountryRegion":
					DesetupSyncCountryRegion(false, true);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "Addresses":
					this.PerformRelatedEntityRemoval(_addresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTaxRates":
					this.PerformRelatedEntityRemoval(_salesTaxRates, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_countryRegion!=null)
			{
				toReturn.Add(_countryRegion);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_addresses);
			toReturn.Add(_salesTaxRates);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceID)
		{
			return FetchUsingPK(stateProvinceID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(stateProvinceID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(stateProvinceID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(stateProvinceID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.StateProvinceID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new StateProvinceRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddresses(bool forceFetch)
		{
			return GetMultiAddresses(forceFetch, _addresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAddresses(forceFetch, _addresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.AddressCollection GetMultiAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAddresses || forceFetch || _alwaysFetchAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_addresses);
				_addresses.SuppressClearInGetMulti=!forceFetch;
				_addresses.EntityFactoryToUse = entityFactoryToUse;
				_addresses.GetMultiManyToOne(this, filter);
				_addresses.SuppressClearInGetMulti=false;
				_alreadyFetchedAddresses = true;
			}
			return _addresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'Addresses'. These settings will be taken into account
		/// when the property Addresses is requested or GetMultiAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addresses.SortClauses=sortClauses;
			_addresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesTaxRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTaxRateEntity'</returns>
		public AW.Data.CollectionClasses.SalesTaxRateCollection GetMultiSalesTaxRates(bool forceFetch)
		{
			return GetMultiSalesTaxRates(forceFetch, _salesTaxRates.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTaxRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesTaxRateEntity'</returns>
		public AW.Data.CollectionClasses.SalesTaxRateCollection GetMultiSalesTaxRates(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesTaxRates(forceFetch, _salesTaxRates.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesTaxRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTaxRateCollection GetMultiSalesTaxRates(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesTaxRates(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTaxRateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesTaxRateCollection GetMultiSalesTaxRates(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesTaxRates || forceFetch || _alwaysFetchSalesTaxRates) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesTaxRates);
				_salesTaxRates.SuppressClearInGetMulti=!forceFetch;
				_salesTaxRates.EntityFactoryToUse = entityFactoryToUse;
				_salesTaxRates.GetMultiManyToOne(this, filter);
				_salesTaxRates.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTaxRates = true;
			}
			return _salesTaxRates;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTaxRates'. These settings will be taken into account
		/// when the property SalesTaxRates is requested or GetMultiSalesTaxRates is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTaxRates(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTaxRates.SortClauses=sortClauses;
			_salesTaxRates.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CountryRegionEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CountryRegionEntity' which is related to this entity.</returns>
		public CountryRegionEntity GetSingleCountryRegion()
		{
			return GetSingleCountryRegion(false);
		}

		/// <summary> Retrieves the related entity of type 'CountryRegionEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CountryRegionEntity' which is related to this entity.</returns>
		public virtual CountryRegionEntity GetSingleCountryRegion(bool forceFetch)
		{
			if( ( !_alreadyFetchedCountryRegion || forceFetch || _alwaysFetchCountryRegion) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CountryRegionEntityUsingCountryRegionCode);
				CountryRegionEntity newEntity = new CountryRegionEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CountryRegionCode);
				}
				if(fetchResult)
				{
					newEntity = (CountryRegionEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_countryRegionReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CountryRegion = newEntity;
				_alreadyFetchedCountryRegion = fetchResult;
			}
			return _countryRegion;
		}


		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public SalesTerritoryEntity GetSingleSalesTerritory()
		{
			return GetSingleSalesTerritory(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public virtual SalesTerritoryEntity GetSingleSalesTerritory(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesTerritoryEntityUsingTerritoryID);
				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.TerritoryID);
				}
				if(fetchResult)
				{
					newEntity = (SalesTerritoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesTerritoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesTerritory = newEntity;
				_alreadyFetchedSalesTerritory = fetchResult;
			}
			return _salesTerritory;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_addresses.ActiveContext = this.ActiveContext;
			_salesTaxRates.ActiveContext = this.ActiveContext;
			if(_countryRegion!=null)
			{
				_countryRegion.ActiveContext = this.ActiveContext;
			}
			if(_salesTerritory!=null)
			{
				_salesTerritory.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("Addresses", _addresses);
			toReturn.Add("SalesTaxRates", _salesTaxRates);
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
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The validator object for this StateProvinceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 stateProvinceID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(stateProvinceID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_addresses = new AW.Data.CollectionClasses.AddressCollection();
			_addresses.SetContainingEntityInfo(this, "StateProvince");

			_salesTaxRates = new AW.Data.CollectionClasses.SalesTaxRateCollection();
			_salesTaxRates.SetContainingEntityInfo(this, "StateProvince");
			_countryRegionReturnsNewIfNotFound = true;
			_salesTerritoryReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"State and province lookup table.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.");
			_fieldsCustomProperties.Add("IsOnlyStateProvinceFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"State or province description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ISO standard state or province code.");
			_fieldsCustomProperties.Add("StateProvinceCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("StateProvinceID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, signalRelatedEntity, "StateProvinces", resetFKFields, new int[] { (int)StateProvinceFieldIndex.CountryRegionCode } );		
			_countryRegion = null;
		}
		
		/// <summary> setups the sync logic for member _countryRegion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCountryRegion(IEntity relatedEntity)
		{
			if(_countryRegion!=relatedEntity)
			{		
				DesetupSyncCountryRegion(true, true);
				_countryRegion = (CountryRegionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, ref _alreadyFetchedCountryRegion, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCountryRegionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", StateProvinceEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, signalRelatedEntity, "StateProvinces", resetFKFields, new int[] { (int)StateProvinceFieldIndex.TerritoryID } );		
			_salesTerritory = null;
		}
		
		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntity relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{		
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", StateProvinceEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, ref _alreadyFetchedSalesTerritory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="stateProvinceID">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 stateProvinceID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)StateProvinceFieldIndex.StateProvinceID].ForcedCurrentValueWrite(stateProvinceID);
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
			return DAOFactory.CreateStateProvinceDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new StateProvinceEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static StateProvinceRelations Relations
		{
			get	{ return new StateProvinceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), (IEntityRelation)GetRelationsForField("Addresses")[0], (int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Addresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTaxRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTaxRates
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTaxRateCollection(), (IEntityRelation)GetRelationsForField("SalesTaxRates")[0], (int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.SalesTaxRateEntity, 0, null, null, null, "SalesTaxRates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegion
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(), (IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), (IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "StateProvinceEntity";}
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

		/// <summary> The CountryRegionCode property of the Entity StateProvince<br/><br/>
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.CountryRegionCode, value, true); }
		}

		/// <summary> The IsOnlyStateProvinceFlag property of the Entity StateProvince<br/><br/>
		/// MS_Description: 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."IsOnlyStateProvinceFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsOnlyStateProvinceFlag
		{
			get { return (System.Boolean)GetValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity StateProvince<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)StateProvinceFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity StateProvince<br/><br/>
		/// MS_Description: State or province description.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.Name, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.Name, value, true); }
		}

		/// <summary> The Rowguid property of the Entity StateProvince<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)StateProvinceFieldIndex.Rowguid, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The StateProvinceCode property of the Entity StateProvince<br/><br/>
		/// MS_Description: ISO standard state or province code.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String StateProvinceCode
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.StateProvinceCode, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.StateProvinceCode, value, true); }
		}

		/// <summary> The StateProvinceID property of the Entity StateProvince<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 StateProvinceID
		{
			get { return (System.Int32)GetValue((int)StateProvinceFieldIndex.StateProvinceID, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.StateProvinceID, value, true); }
		}

		/// <summary> The TerritoryID property of the Entity StateProvince<br/><br/>
		/// MS_Description: ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.<br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 TerritoryID
		{
			get { return (System.Int32)GetValue((int)StateProvinceFieldIndex.TerritoryID, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.TerritoryID, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection Addresses
		{
			get	{ return GetMultiAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Addresses. When set to true, Addresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Addresses is accessed. You can always execute/ a forced fetch by calling GetMultiAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddresses
		{
			get	{ return _alwaysFetchAddresses; }
			set	{ _alwaysFetchAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Addresses already has been fetched. Setting this property to false when Addresses has been fetched
		/// will clear the Addresses collection well. Setting this property to true while Addresses hasn't been fetched disables lazy loading for Addresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddresses
		{
			get { return _alreadyFetchedAddresses;}
			set 
			{
				if(_alreadyFetchedAddresses && !value && (_addresses != null))
				{
					_addresses.Clear();
				}
				_alreadyFetchedAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTaxRateEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTaxRates()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTaxRateCollection SalesTaxRates
		{
			get	{ return GetMultiSalesTaxRates(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTaxRates. When set to true, SalesTaxRates is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTaxRates is accessed. You can always execute/ a forced fetch by calling GetMultiSalesTaxRates(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTaxRates
		{
			get	{ return _alwaysFetchSalesTaxRates; }
			set	{ _alwaysFetchSalesTaxRates = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTaxRates already has been fetched. Setting this property to false when SalesTaxRates has been fetched
		/// will clear the SalesTaxRates collection well. Setting this property to true while SalesTaxRates hasn't been fetched disables lazy loading for SalesTaxRates</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTaxRates
		{
			get { return _alreadyFetchedSalesTaxRates;}
			set 
			{
				if(_alreadyFetchedSalesTaxRates && !value && (_salesTaxRates != null))
				{
					_salesTaxRates.Clear();
				}
				_alreadyFetchedSalesTaxRates = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CountryRegionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCountryRegion()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CountryRegionEntity CountryRegion
		{
			get	{ return GetSingleCountryRegion(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCountryRegion(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StateProvinces", "CountryRegion", _countryRegion, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegion. When set to true, CountryRegion is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegion is accessed. You can always execute a forced fetch by calling GetSingleCountryRegion(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegion
		{
			get	{ return _alwaysFetchCountryRegion; }
			set	{ _alwaysFetchCountryRegion = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CountryRegion already has been fetched. Setting this property to false when CountryRegion has been fetched
		/// will set CountryRegion to null as well. Setting this property to true while CountryRegion hasn't been fetched disables lazy loading for CountryRegion</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCountryRegion
		{
			get { return _alreadyFetchedCountryRegion;}
			set 
			{
				if(_alreadyFetchedCountryRegion && !value)
				{
					this.CountryRegion = null;
				}
				_alreadyFetchedCountryRegion = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CountryRegion is not found
		/// in the database. When set to true, CountryRegion will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CountryRegionReturnsNewIfNotFound
		{
			get	{ return _countryRegionReturnsNewIfNotFound; }
			set { _countryRegionReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return GetSingleSalesTerritory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StateProvinces", "SalesTerritory", _salesTerritory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute a forced fetch by calling GetSingleSalesTerritory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory
		{
			get	{ return _alwaysFetchSalesTerritory; }
			set	{ _alwaysFetchSalesTerritory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritory already has been fetched. Setting this property to false when SalesTerritory has been fetched
		/// will set SalesTerritory to null as well. Setting this property to true while SalesTerritory hasn't been fetched disables lazy loading for SalesTerritory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritory
		{
			get { return _alreadyFetchedSalesTerritory;}
			set 
			{
				if(_alreadyFetchedSalesTerritory && !value)
				{
					this.SalesTerritory = null;
				}
				_alreadyFetchedSalesTerritory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesTerritory is not found
		/// in the database. When set to true, SalesTerritory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesTerritoryReturnsNewIfNotFound
		{
			get	{ return _salesTerritoryReturnsNewIfNotFound; }
			set { _salesTerritoryReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.StateProvinceEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static StateProvinceCollection GetStateProvinceCollection()
        {
            ISortExpression Sort = new SortExpression();
            Sort.Add(StateProvinceFields.Name | SortOperator.Ascending);
            StateProvinceCollection States = new StateProvinceCollection();
            States.GetMulti(null, 0, Sort);
            return States;
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
