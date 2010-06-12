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

	/// <summary>Entity class which represents the entity 'CountryRegionCurrency'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CountryRegionCurrencyEntity : CommonEntityBase
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
		static CountryRegionCurrencyEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CountryRegionCurrencyEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode)
		{
			InitClassFetch(countryRegionCode, currencyCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(countryRegionCode, currencyCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode, IValidator validator)
		{
			InitClassFetch(countryRegionCode, currencyCode, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionCurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
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

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedCountryRegion = (_countryRegion != null);
			_alreadyFetchedCurrency = (_currency != null);
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
				case "Currency":
					toReturn.Add(Relations.CurrencyEntityUsingCurrencyCode);
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
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
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
			if(_currency!=null)
			{
				toReturn.Add(_currency);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
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
			return FetchUsingPK(countryRegionCode, currencyCode, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CountryRegionCode, this.CurrencyCode, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
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
			if( ( !_alreadyFetchedCurrency || forceFetch || _alwaysFetchCurrency) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CurrencyEntityUsingCurrencyCode);
				CurrencyEntity newEntity = new CurrencyEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CurrencyCode);
				}
				if(fetchResult)
				{
					newEntity = (CurrencyEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_currencyReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Currency = newEntity;
				_alreadyFetchedCurrency = fetchResult;
			}
			return _currency;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_countryRegion!=null)
			{
				_countryRegion.ActiveContext = this.ActiveContext;
			}
			if(_currency!=null)
			{
				_currency.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("Currency", _currency);
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
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The validator object for this CountryRegionCurrencyEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.String countryRegionCode, System.String currencyCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(countryRegionCode, currencyCode, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{			_countryRegionReturnsNewIfNotFound = true;
			_currencyReturnsNewIfNotFound = true;
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, signalRelatedEntity, "CountryRegionCurrencies", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CountryRegionCode } );		
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
				this.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", CountryRegionCurrencyEntity.Relations.CountryRegionEntityUsingCountryRegionCode, true, ref _alreadyFetchedCountryRegion, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, true, signalRelatedEntity, "CountryRegionCurrencies", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CurrencyCode } );		
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
				this.PerformSetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", CountryRegionCurrencyEntity.Relations.CurrencyEntityUsingCurrencyCode, true, ref _alreadyFetchedCurrency, new string[] {  } );
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
				this.Fields[(int)CountryRegionCurrencyFieldIndex.CountryRegionCode].ForcedCurrentValueWrite(countryRegionCode);
				this.Fields[(int)CountryRegionCurrencyFieldIndex.CurrencyCode].ForcedCurrentValueWrite(currencyCode);
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

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegion
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(), (IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AW.Data.EntityType.CountryRegionCurrencyEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrency
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(), (IEntityRelation)GetRelationsForField("Currency")[0], (int)AW.Data.EntityType.CountryRegionCurrencyEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, null, "Currency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "CountryRegionCurrencyEntity";}
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

		/// <summary> The CountryRegionCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, value, true); }
		}

		/// <summary> The CurrencyCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity CountryRegionCurrency<br/><br/></summary>
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
					SetSingleRelatedEntityNavigator(value, "CountryRegionCurrencies", "CountryRegion", _countryRegion, true); 
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

		/// <summary> Gets / sets related entity of type 'CurrencyEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CurrencyEntity Currency
		{
			get	{ return GetSingleCurrency(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCurrency(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CountryRegionCurrencies", "Currency", _currency, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Currency. When set to true, Currency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency is accessed. You can always execute a forced fetch by calling GetSingleCurrency(true).</summary>
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
		protected override int LLBLGenProEntityTypeValue 
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
