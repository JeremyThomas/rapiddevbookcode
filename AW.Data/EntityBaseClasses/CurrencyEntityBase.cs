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
	/// <summary>Entity base class which represents the base class for the entity 'Currency'.<br/><br/>
	/// 
	/// MS_Description: Lookup table containing standard ISO currencies.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class CurrencyEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CountryRegionCurrencyCollection	_countryRegionCurrency;
		private bool	_alwaysFetchCountryRegionCurrency, _alreadyFetchedCountryRegionCurrency;
		private AW.Data.CollectionClasses.CurrencyRateCollection	_currencyRates;
		private bool	_alwaysFetchCurrencyRates, _alreadyFetchedCurrencyRates;
		private AW.Data.CollectionClasses.CurrencyRateCollection	_currencyRates_;
		private bool	_alwaysFetchCurrencyRates_, _alreadyFetchedCurrencyRates_;
		private AW.Data.CollectionClasses.CountryRegionCollection _countryRegionCollectionViaCountryRegionCurrency;
		private bool	_alwaysFetchCountryRegionCollectionViaCountryRegionCurrency, _alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency;


		
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
			/// <summary>Member name CurrencyRates</summary>
			public static readonly string CurrencyRates = "CurrencyRates";
			/// <summary>Member name CurrencyRates_</summary>
			public static readonly string CurrencyRates_ = "CurrencyRates_";
			/// <summary>Member name CountryRegionCollectionViaCountryRegionCurrency</summary>
			public static readonly string CountryRegionCollectionViaCountryRegionCurrency = "CountryRegionCollectionViaCountryRegionCurrency";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CurrencyEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CurrencyEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		public CurrencyEntityBase(System.String currencyCode)
		{
			InitClassFetch(currencyCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CurrencyEntityBase(System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(currencyCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		public CurrencyEntityBase(System.String currencyCode, IValidator validator)
		{
			InitClassFetch(currencyCode, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CurrencyEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_countryRegionCurrency = (AW.Data.CollectionClasses.CountryRegionCurrencyCollection)info.GetValue("_countryRegionCurrency", typeof(AW.Data.CollectionClasses.CountryRegionCurrencyCollection));
			_alwaysFetchCountryRegionCurrency = info.GetBoolean("_alwaysFetchCountryRegionCurrency");
			_alreadyFetchedCountryRegionCurrency = info.GetBoolean("_alreadyFetchedCountryRegionCurrency");
			_currencyRates = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRates", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRates = info.GetBoolean("_alwaysFetchCurrencyRates");
			_alreadyFetchedCurrencyRates = info.GetBoolean("_alreadyFetchedCurrencyRates");
			_currencyRates_ = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRates_", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRates_ = info.GetBoolean("_alwaysFetchCurrencyRates_");
			_alreadyFetchedCurrencyRates_ = info.GetBoolean("_alreadyFetchedCurrencyRates_");
			_countryRegionCollectionViaCountryRegionCurrency = (AW.Data.CollectionClasses.CountryRegionCollection)info.GetValue("_countryRegionCollectionViaCountryRegionCurrency", typeof(AW.Data.CollectionClasses.CountryRegionCollection));
			_alwaysFetchCountryRegionCollectionViaCountryRegionCurrency = info.GetBoolean("_alwaysFetchCountryRegionCollectionViaCountryRegionCurrency");
			_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = info.GetBoolean("_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CurrencyFieldIndex)fieldIndex)
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
			_alreadyFetchedCurrencyRates = (_currencyRates.Count > 0);
			_alreadyFetchedCurrencyRates_ = (_currencyRates_.Count > 0);
			_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = (_countryRegionCollectionViaCountryRegionCurrency.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CurrencyEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(CurrencyEntity.Relations.CountryRegionCurrencyEntityUsingCurrencyCode);
					break;
				case "CurrencyRates":
					toReturn.Add(CurrencyEntity.Relations.CurrencyRateEntityUsingFromCurrencyCode);
					break;
				case "CurrencyRates_":
					toReturn.Add(CurrencyEntity.Relations.CurrencyRateEntityUsingToCurrencyCode);
					break;
				case "CountryRegionCollectionViaCountryRegionCurrency":
					toReturn.Add(CurrencyEntity.Relations.CountryRegionCurrencyEntityUsingCurrencyCode, "CurrencyEntity__", "CountryRegionCurrency_", JoinHint.None);
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, "CountryRegionCurrency_", string.Empty, JoinHint.None);
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
			info.AddValue("_currencyRates", (!this.MarkedForDeletion?_currencyRates:null));
			info.AddValue("_alwaysFetchCurrencyRates", _alwaysFetchCurrencyRates);
			info.AddValue("_alreadyFetchedCurrencyRates", _alreadyFetchedCurrencyRates);
			info.AddValue("_currencyRates_", (!this.MarkedForDeletion?_currencyRates_:null));
			info.AddValue("_alwaysFetchCurrencyRates_", _alwaysFetchCurrencyRates_);
			info.AddValue("_alreadyFetchedCurrencyRates_", _alreadyFetchedCurrencyRates_);
			info.AddValue("_countryRegionCollectionViaCountryRegionCurrency", (!this.MarkedForDeletion?_countryRegionCollectionViaCountryRegionCurrency:null));
			info.AddValue("_alwaysFetchCountryRegionCollectionViaCountryRegionCurrency", _alwaysFetchCountryRegionCollectionViaCountryRegionCurrency);
			info.AddValue("_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency", _alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency);


			
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
				case "CountryRegionCollectionViaCountryRegionCurrency":
					_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = true;
					if(entity!=null)
					{
						this.CountryRegionCollectionViaCountryRegionCurrency.Add((CountryRegionEntity)entity);
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
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{

				case "CountryRegionCurrency":
					base.PerformRelatedEntityRemoval(_countryRegionCurrency, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates":
					base.PerformRelatedEntityRemoval(_currencyRates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CurrencyRates_":
					base.PerformRelatedEntityRemoval(_currencyRates_, relatedEntity, signalRelatedEntityManyToOne);
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
			return Fetch(currencyCode, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CurrencyCode, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CurrencyFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CurrencyFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CurrencyRelations().GetAllRelations();
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
				_countryRegionCurrency.GetMultiManyToOne(null, this, filter);
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
 			if( ( !_alreadyFetchedCurrencyRates || forceFetch || _alwaysFetchCurrencyRates) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRates.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRates);
					}
				}
				_currencyRates.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_currencyRates.EntityFactoryToUse = entityFactoryToUse;
				}
				_currencyRates.GetMultiManyToOne(null, this, filter);
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
 			if( ( !_alreadyFetchedCurrencyRates_ || forceFetch || _alwaysFetchCurrencyRates_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRates_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRates_);
					}
				}
				_currencyRates_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_currencyRates_.EntityFactoryToUse = entityFactoryToUse;
				}
				_currencyRates_.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCollection GetMultiCountryRegionCollectionViaCountryRegionCurrency(bool forceFetch)
		{
			return GetMultiCountryRegionCollectionViaCountryRegionCurrency(forceFetch, _countryRegionCollectionViaCountryRegionCurrency.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CountryRegionCollection GetMultiCountryRegionCollectionViaCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCollectionViaCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCollectionViaCountryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCollectionViaCountryRegionCurrency);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, ComparisonOperator.Equal, this.CurrencyCode, "CurrencyEntity__"));
				_countryRegionCollectionViaCountryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_countryRegionCollectionViaCountryRegionCurrency.EntityFactoryToUse = entityFactoryToUse;
				}
				_countryRegionCollectionViaCountryRegionCurrency.GetMulti(filter, GetRelationsForField("CountryRegionCollectionViaCountryRegionCurrency"));
				_countryRegionCollectionViaCountryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = true;
			}
			return _countryRegionCollectionViaCountryRegionCurrency;
		}

		/// <summary> Sets the collection parameters for the collection for 'CountryRegionCollectionViaCountryRegionCurrency'. These settings will be taken into account
		/// when the property CountryRegionCollectionViaCountryRegionCurrency is requested or GetMultiCountryRegionCollectionViaCountryRegionCurrency is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegionCollectionViaCountryRegionCurrency(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegionCollectionViaCountryRegionCurrency.SortClauses=sortClauses;
			_countryRegionCollectionViaCountryRegionCurrency.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CurrencyDAO dao = (CurrencyDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_countryRegionCurrency.ActiveContext = base.ActiveContext;
			_currencyRates.ActiveContext = base.ActiveContext;
			_currencyRates_.ActiveContext = base.ActiveContext;
			_countryRegionCollectionViaCountryRegionCurrency.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CurrencyDAO dao = (CurrencyDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CurrencyDAO dao = (CurrencyDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CurrencyEntity);
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
			toReturn.Add("CurrencyRates", _currencyRates);
			toReturn.Add("CurrencyRates_", _currencyRates_);
			toReturn.Add("CountryRegionCollectionViaCountryRegionCurrency", _countryRegionCollectionViaCountryRegionCurrency);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The validator object for this CurrencyEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String currencyCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(currencyCode, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_countryRegionCurrency = new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(new CountryRegionCurrencyEntityFactory());
			_countryRegionCurrency.SetContainingEntityInfo(this, "Currency");
			_alwaysFetchCountryRegionCurrency = false;
			_alreadyFetchedCountryRegionCurrency = false;
			_currencyRates = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_currencyRates.SetContainingEntityInfo(this, "Currency");
			_alwaysFetchCurrencyRates = false;
			_alreadyFetchedCurrencyRates = false;
			_currencyRates_ = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_currencyRates_.SetContainingEntityInfo(this, "Currency_");
			_alwaysFetchCurrencyRates_ = false;
			_alreadyFetchedCurrencyRates_ = false;
			_countryRegionCollectionViaCountryRegionCurrency = new AW.Data.CollectionClasses.CountryRegionCollection(new CountryRegionEntityFactory());
			_alwaysFetchCountryRegionCollectionViaCountryRegionCurrency = false;
			_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = false;



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
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Currency name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
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
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CurrencyFieldIndex.CurrencyCode].ForcedCurrentValueWrite(currencyCode);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCurrency
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCurrencyCollection(),
					(IEntityRelation)GetRelationsForField("CountryRegionCurrency")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CountryRegionCurrencyEntity, 0, null, null, null, "CountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRates
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(),
					(IEntityRelation)GetRelationsForField("CurrencyRates")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRates_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(),
					(IEntityRelation)GetRelationsForField("CurrencyRates_")[0], (int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRates_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCollectionViaCountryRegionCurrency
		{
			get
			{
				IEntityRelation intermediateRelation = CurrencyEntity.Relations.CountryRegionCurrencyEntityUsingCurrencyCode;
				intermediateRelation.SetAliases(string.Empty, "CountryRegionCurrency_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CurrencyEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, GetRelationsForField("CountryRegionCollectionViaCountryRegionCurrency"), "CountryRegionCollectionViaCountryRegionCurrency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CurrencyEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CurrencyEntity.CustomProperties;}
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
			get { return CurrencyEntity.FieldsCustomProperties;}
		}

		/// <summary> The CurrencyCode property of the Entity Currency<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CurrencyFieldIndex.CurrencyCode, value, true); }
		}
		/// <summary> The Name property of the Entity Currency<br/><br/>
		/// 
		/// MS_Description: Currency name.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.Name, true); }
			set	{ SetValue((int)CurrencyFieldIndex.Name, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Currency<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyFieldIndex.ModifiedDate, value, true); }
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
		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRates()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRates
		{
			get	{ return GetMultiCurrencyRates(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRates. When set to true, CurrencyRates is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRates is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRates(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRates_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRates_
		{
			get	{ return GetMultiCurrencyRates_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRates_. When set to true, CurrencyRates_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRates_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRates_(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegionCollectionViaCountryRegionCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CountryRegionCollection CountryRegionCollectionViaCountryRegionCurrency
		{
			get { return GetMultiCountryRegionCollectionViaCountryRegionCurrency(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegionCollectionViaCountryRegionCurrency. When set to true, CountryRegionCollectionViaCountryRegionCurrency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegionCollectionViaCountryRegionCurrency is accessed. You can always execute
		/// a forced fetch by calling GetMultiCountryRegionCollectionViaCountryRegionCurrency(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegionCollectionViaCountryRegionCurrency
		{
			get	{ return _alwaysFetchCountryRegionCollectionViaCountryRegionCurrency; }
			set	{ _alwaysFetchCountryRegionCollectionViaCountryRegionCurrency = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CountryRegionCollectionViaCountryRegionCurrency already has been fetched. Setting this property to false when CountryRegionCollectionViaCountryRegionCurrency has been fetched
		/// will clear the CountryRegionCollectionViaCountryRegionCurrency collection well. Setting this property to true while CountryRegionCollectionViaCountryRegionCurrency hasn't been fetched disables lazy loading for CountryRegionCollectionViaCountryRegionCurrency</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCountryRegionCollectionViaCountryRegionCurrency
		{
			get { return _alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency;}
			set 
			{
				if(_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency && !value && (_countryRegionCollectionViaCountryRegionCurrency != null))
				{
					_countryRegionCollectionViaCountryRegionCurrency.Clear();
				}
				_alreadyFetchedCountryRegionCollectionViaCountryRegionCurrency = value;
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
