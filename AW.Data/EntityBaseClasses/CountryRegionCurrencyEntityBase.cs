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
	
	/// <summary>Entity base class which represents the base class for the entity 'CountryRegionCurrency'.<br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping ISO currency codes to a country or region.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class CountryRegionCurrencyEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private CountryRegionEntity _countryRegion;
		private bool	_alwaysFetchCountryRegion, _alreadyFetchedCountryRegion, _countryRegionReturnsNewIfNotFound;
		private CurrencyEntity _currency;
		private bool	_alwaysFetchCurrency, _alreadyFetchedCurrency, _currencyReturnsNewIfNotFound;

		
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
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CountryRegionCurrencyEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CountryRegionCurrencyEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		public CountryRegionCurrencyEntityBase(System.String countryRegionCode, System.String currencyCode)
		{
			InitClassFetch(countryRegionCode, currencyCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CountryRegionCurrencyEntityBase(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(countryRegionCode, currencyCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		public CountryRegionCurrencyEntityBase(System.String countryRegionCode, System.String currencyCode, IValidator validator)
		{
			InitClassFetch(countryRegionCode, currencyCode, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionCurrencyEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
			if(_countryRegion!=null)
			{
				_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_countryRegionReturnsNewIfNotFound = info.GetBoolean("_countryRegionReturnsNewIfNotFound");
			_alwaysFetchCountryRegion = info.GetBoolean("_alwaysFetchCountryRegion");
			_alreadyFetchedCountryRegion = info.GetBoolean("_alreadyFetchedCountryRegion");
			_currency = (CurrencyEntity)info.GetValue("_currency", typeof(CurrencyEntity));
			if(_currency!=null)
			{
				_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_currencyReturnsNewIfNotFound = info.GetBoolean("_currencyReturnsNewIfNotFound");
			_alwaysFetchCurrency = info.GetBoolean("_alwaysFetchCurrency");
			_alreadyFetchedCurrency = info.GetBoolean("_alreadyFetchedCurrency");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CountryRegionCurrencyFieldIndex)fieldIndex)
			{
				case CountryRegionCurrencyFieldIndex.CountryRegionCode:
					DesetupSyncCountryRegion(true, false);
					_alreadyFetchedCountryRegion = false;
					break;
				case CountryRegionCurrencyFieldIndex.CurrencyCode:
					DesetupSyncCurrency(true, false);
					_alreadyFetchedCurrency = false;
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


			_alreadyFetchedCountryRegion = (_countryRegion != null);
			_alreadyFetchedCurrency = (_currency != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CountryRegionCurrencyEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "CountryRegion":
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode);
					break;
				case "Currency":
					toReturn.Add(CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode);
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


			info.AddValue("_countryRegion", (!this.MarkedForDeletion?_countryRegion:null));
			info.AddValue("_countryRegionReturnsNewIfNotFound", _countryRegionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCountryRegion", _alwaysFetchCountryRegion);
			info.AddValue("_alreadyFetchedCountryRegion", _alreadyFetchedCountryRegion);
			info.AddValue("_currency", (!this.MarkedForDeletion?_currency:null));
			info.AddValue("_currencyReturnsNewIfNotFound", _currencyReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCurrency", _alwaysFetchCurrency);
			info.AddValue("_alreadyFetchedCurrency", _alreadyFetchedCurrency);

			
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
				case "CountryRegion":
					_alreadyFetchedCountryRegion = true;
					this.CountryRegion = (CountryRegionEntity)entity;
					break;
				case "Currency":
					_alreadyFetchedCurrency = true;
					this.Currency = (CurrencyEntity)entity;
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "Currency":
					SetupSyncCurrency(relatedEntity);
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
				case "CountryRegion":
					DesetupSyncCountryRegion(false, true);
					break;
				case "Currency":
					DesetupSyncCurrency(false, true);
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
			if(_countryRegion!=null)
			{
				toReturn.Add(_countryRegion);
			}
			if(_currency!=null)
			{
				toReturn.Add(_currency);
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
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, System.String currencyCode)
		{
			return FetchUsingPK(countryRegionCode, currencyCode, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(countryRegionCode, currencyCode, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(countryRegionCode, currencyCode, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(countryRegionCode, currencyCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CountryRegionCode, this.CurrencyCode, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CountryRegionCurrencyFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CountryRegionCurrencyFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CountryRegionCurrencyRelations().GetAllRelations();
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
			if( ( !_alreadyFetchedCountryRegion || forceFetch || _alwaysFetchCountryRegion) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode);

				CountryRegionEntity newEntity = new CountryRegionEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CountryRegionCode);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CountryRegionEntity)base.ActiveContext.Get(newEntity);
					}
					this.CountryRegion = newEntity;
				}
				else
				{
					if(_countryRegionReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_countryRegion == null)))
						{
							this.CountryRegion = newEntity;
						}
					}
					else
					{
						this.CountryRegion = null;
					}
				}
				_alreadyFetchedCountryRegion = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _countryRegion;
		}

		/// <summary> Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public CurrencyEntity GetSingleCurrency()
		{
			return GetSingleCurrency(false);
		}

		/// <summary> Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency(bool forceFetch)
		{
			if( ( !_alreadyFetchedCurrency || forceFetch || _alwaysFetchCurrency) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode);

				CurrencyEntity newEntity = new CurrencyEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CurrencyCode);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CurrencyEntity)base.ActiveContext.Get(newEntity);
					}
					this.Currency = newEntity;
				}
				else
				{
					if(_currencyReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_currency == null)))
						{
							this.Currency = newEntity;
						}
					}
					else
					{
						this.Currency = null;
					}
				}
				_alreadyFetchedCurrency = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _currency;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CountryRegionCurrencyDAO dao = (CountryRegionCurrencyDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_countryRegion!=null)
			{
				_countryRegion.ActiveContext = base.ActiveContext;
			}
			if(_currency!=null)
			{
				_currency.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CountryRegionCurrencyDAO dao = (CountryRegionCurrencyDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CountryRegionCurrencyDAO dao = (CountryRegionCurrencyDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CountryRegionCurrencyEntity);
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
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("Currency", _currency);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The validator object for this CountryRegionCurrencyEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String countryRegionCode, System.String currencyCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(countryRegionCode, currencyCode, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_countryRegion = null;
			_countryRegionReturnsNewIfNotFound = true;
			_alwaysFetchCountryRegion = false;
			_alreadyFetchedCountryRegion = false;
			_currency = null;
			_currencyReturnsNewIfNotFound = true;
			_alwaysFetchCurrency = false;
			_alreadyFetchedCurrency = false;


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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping ISO currency codes to a country or region.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ISO standard currency code. Foreign key to Currency.CurrencyCode.");
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, signalRelatedEntity, "CountryRegionCurrency", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CountryRegionCode } );		
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
				base.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, ref _alreadyFetchedCountryRegion, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _currency</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, true, signalRelatedEntity, "CountryRegionCurrency", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CurrencyCode } );		
			_currency = null;
		}
		
		/// <summary> setups the sync logic for member _currency</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency(IEntity relatedEntity)
		{
			if(_currency!=relatedEntity)
			{		
				DesetupSyncCurrency(true, true);
				_currency = (CurrencyEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, true, ref _alreadyFetchedCurrency, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrencyPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CountryRegionCurrencyFieldIndex.CountryRegionCode].ForcedCurrentValueWrite(countryRegionCode);
				base.Fields[(int)CountryRegionCurrencyFieldIndex.CurrencyCode].ForcedCurrentValueWrite(currencyCode);
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
			return DAOFactory.CreateCountryRegionCurrencyDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CountryRegionCurrencyEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CountryRegionCurrencyRelations Relations
		{
			get	{ return new CountryRegionCurrencyRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegion
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(),
					(IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AW.Data.EntityType.CountryRegionCurrencyEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrency
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(),
					(IEntityRelation)GetRelationsForField("Currency")[0], (int)AW.Data.EntityType.CountryRegionCurrencyEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, null, "Currency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CountryRegionCurrencyEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CountryRegionCurrencyEntity.CustomProperties;}
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
			get { return CountryRegionCurrencyEntity.FieldsCustomProperties;}
		}

		/// <summary> The CountryRegionCode property of the Entity CountryRegionCurrency<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, value, true); }
		}
		/// <summary> The CurrencyCode property of the Entity CountryRegionCurrency<br/><br/>
		/// 
		/// MS_Description: ISO standard currency code. Foreign key to Currency.CurrencyCode.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity CountryRegionCurrency<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'CountryRegionEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCountryRegion()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CountryRegionEntity CountryRegion
		{
			get	{ return GetSingleCountryRegion(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCountryRegion(value);
				}
				else
				{
					if(value==null)
					{
						if(_countryRegion != null)
						{
							_countryRegion.UnsetRelatedEntity(this, "CountryRegionCurrency");
						}
					}
					else
					{
						if(_countryRegion!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "CountryRegionCurrency");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegion. When set to true, CountryRegion is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegion is accessed. You can always execute
		/// a forced fetch by calling GetSingleCountryRegion(true).</summary>
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
		/// <summary> Gets / sets related entity of type 'CurrencyEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get	{ return GetSingleCurrency(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCurrency(value);
				}
				else
				{
					if(value==null)
					{
						if(_currency != null)
						{
							_currency.UnsetRelatedEntity(this, "CountryRegionCurrency");
						}
					}
					else
					{
						if(_currency!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "CountryRegionCurrency");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Currency. When set to true, Currency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency is accessed. You can always execute
		/// a forced fetch by calling GetSingleCurrency(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrency
		{
			get	{ return _alwaysFetchCurrency; }
			set	{ _alwaysFetchCurrency = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Currency already has been fetched. Setting this property to false when Currency has been fetched
		/// will set Currency to null as well. Setting this property to true while Currency hasn't been fetched disables lazy loading for Currency</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrency
		{
			get { return _alreadyFetchedCurrency;}
			set 
			{
				if(_alreadyFetchedCurrency && !value)
				{
					this.Currency = null;
				}
				_alreadyFetchedCurrency = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Currency is not found
		/// in the database. When set to true, Currency will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CurrencyReturnsNewIfNotFound
		{
			get	{ return _currencyReturnsNewIfNotFound; }
			set { _currencyReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.CountryRegionCurrencyEntity; }
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
