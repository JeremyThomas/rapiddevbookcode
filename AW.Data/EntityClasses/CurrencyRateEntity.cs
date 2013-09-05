///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'CurrencyRate'. <br/><br/>
	/// 
	/// MS_Description: Currency exchange rates.<br/>
	/// </summary>
	[Serializable]
	public partial class CurrencyRateEntity : CommonEntityBase, IModifiedTracking
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private CurrencyEntity _currency;
		private bool	_alwaysFetchCurrency, _alreadyFetchedCurrency, _currencyReturnsNewIfNotFound;
		private CurrencyEntity _currency_;
		private bool	_alwaysFetchCurrency_, _alreadyFetchedCurrency_, _currency_ReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";
			/// <summary>Member name Currency_</summary>
			public static readonly string Currency_ = "Currency_";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CurrencyRateEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CurrencyRateEntity() :base("CurrencyRateEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		public CurrencyRateEntity(System.Int32 currencyRateID):base("CurrencyRateEntity")
		{
			InitClassFetch(currencyRateID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CurrencyRateEntity(System.Int32 currencyRateID, IPrefetchPath prefetchPathToUse):base("CurrencyRateEntity")
		{
			InitClassFetch(currencyRateID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		public CurrencyRateEntity(System.Int32 currencyRateID, IValidator validator):base("CurrencyRateEntity")
		{
			InitClassFetch(currencyRateID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CurrencyRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");
			_currency = (CurrencyEntity)info.GetValue("_currency", typeof(CurrencyEntity));
			if(_currency!=null)
			{
				_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_currencyReturnsNewIfNotFound = info.GetBoolean("_currencyReturnsNewIfNotFound");
			_alwaysFetchCurrency = info.GetBoolean("_alwaysFetchCurrency");
			_alreadyFetchedCurrency = info.GetBoolean("_alreadyFetchedCurrency");

			_currency_ = (CurrencyEntity)info.GetValue("_currency_", typeof(CurrencyEntity));
			if(_currency_!=null)
			{
				_currency_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_currency_ReturnsNewIfNotFound = info.GetBoolean("_currency_ReturnsNewIfNotFound");
			_alwaysFetchCurrency_ = info.GetBoolean("_alwaysFetchCurrency_");
			_alreadyFetchedCurrency_ = info.GetBoolean("_alreadyFetchedCurrency_");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CurrencyRateFieldIndex)fieldIndex)
			{
				case CurrencyRateFieldIndex.FromCurrencyCode:
					DesetupSyncCurrency(true, false);
					_alreadyFetchedCurrency = false;
					break;
				case CurrencyRateFieldIndex.ToCurrencyCode:
					DesetupSyncCurrency_(true, false);
					_alreadyFetchedCurrency_ = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedCurrency = (_currency != null);
			_alreadyFetchedCurrency_ = (_currency_ != null);
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
				case "Currency":
					toReturn.Add(Relations.CurrencyEntityUsingFromCurrencyCode);
					break;
				case "Currency_":
					toReturn.Add(Relations.CurrencyEntityUsingToCurrencyCode);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCurrencyRateID);
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
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_currency", (!this.MarkedForDeletion?_currency:null));
			info.AddValue("_currencyReturnsNewIfNotFound", _currencyReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCurrency", _alwaysFetchCurrency);
			info.AddValue("_alreadyFetchedCurrency", _alreadyFetchedCurrency);
			info.AddValue("_currency_", (!this.MarkedForDeletion?_currency_:null));
			info.AddValue("_currency_ReturnsNewIfNotFound", _currency_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCurrency_", _alwaysFetchCurrency_);
			info.AddValue("_alreadyFetchedCurrency_", _alreadyFetchedCurrency_);

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
				case "Currency":
					_alreadyFetchedCurrency = true;
					this.Currency = (CurrencyEntity)entity;
					break;
				case "Currency_":
					_alreadyFetchedCurrency_ = true;
					this.Currency_ = (CurrencyEntity)entity;
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
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
				case "Currency":
					SetupSyncCurrency(relatedEntity);
					break;
				case "Currency_":
					SetupSyncCurrency_(relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "Currency":
					DesetupSyncCurrency(false, true);
					break;
				case "Currency_":
					DesetupSyncCurrency_(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_currency!=null)
			{
				toReturn.Add(_currency);
			}
			if(_currency_!=null)
			{
				toReturn.Add(_currency_);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_salesOrderHeaders);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 currencyRateID)
		{
			return FetchUsingPK(currencyRateID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 currencyRateID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(currencyRateID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 currencyRateID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(currencyRateID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 currencyRateID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(currencyRateID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CurrencyRateID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CurrencyRateRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaders || forceFetch || _alwaysFetchSalesOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaders);
				_salesOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, null, null, this, null, null, null, null, null, filter);
				_salesOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaders = true;
			}
			return _salesOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaders'. These settings will be taken into account
		/// when the property SalesOrderHeaders is requested or GetMultiSalesOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaders.SortClauses=sortClauses;
			_salesOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CurrencyEntityUsingFromCurrencyCode);
				CurrencyEntity newEntity = new CurrencyEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FromCurrencyCode);
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


		/// <summary> Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public CurrencyEntity GetSingleCurrency_()
		{
			return GetSingleCurrency_(false);
		}

		/// <summary> Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency_(bool forceFetch)
		{
			if( ( !_alreadyFetchedCurrency_ || forceFetch || _alwaysFetchCurrency_) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CurrencyEntityUsingToCurrencyCode);
				CurrencyEntity newEntity = new CurrencyEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ToCurrencyCode);
				}
				if(fetchResult)
				{
					newEntity = (CurrencyEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_currency_ReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Currency_ = newEntity;
				_alreadyFetchedCurrency_ = fetchResult;
			}
			return _currency_;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Currency", _currency);
			toReturn.Add("Currency_", _currency_);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
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
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The validator object for this CurrencyRateEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 currencyRateID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(currencyRateID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "CurrencyRate");
			_currencyReturnsNewIfNotFound = true;
			_currency_ReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Currency exchange rates.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Average exchange rate for the day.");
			_fieldsCustomProperties.Add("AverageRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the exchange rate was obtained.");
			_fieldsCustomProperties.Add("CurrencyRateDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CurrencyRateID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Final exchange rate for the day.");
			_fieldsCustomProperties.Add("EndOfDayRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Exchange rate was converted from this currency code.");
			_fieldsCustomProperties.Add("FromCurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Exchange rate was converted to this currency code.");
			_fieldsCustomProperties.Add("ToCurrencyCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _currency</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AW.Data.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingFromCurrencyCodeStatic, true, signalRelatedEntity, "CurrencyRates", resetFKFields, new int[] { (int)CurrencyRateFieldIndex.FromCurrencyCode } );		
			_currency = null;
		}
		
		/// <summary> setups the sync logic for member _currency</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency(IEntityCore relatedEntity)
		{
			if(_currency!=relatedEntity)
			{		
				DesetupSyncCurrency(true, true);
				_currency = (CurrencyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AW.Data.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingFromCurrencyCodeStatic, true, ref _alreadyFetchedCurrency, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _currency_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency_(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currency_, new PropertyChangedEventHandler( OnCurrency_PropertyChanged ), "Currency_", AW.Data.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingToCurrencyCodeStatic, true, signalRelatedEntity, "CurrencyRates_", resetFKFields, new int[] { (int)CurrencyRateFieldIndex.ToCurrencyCode } );		
			_currency_ = null;
		}
		
		/// <summary> setups the sync logic for member _currency_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency_(IEntityCore relatedEntity)
		{
			if(_currency_!=relatedEntity)
			{		
				DesetupSyncCurrency_(true, true);
				_currency_ = (CurrencyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currency_, new PropertyChangedEventHandler( OnCurrency_PropertyChanged ), "Currency_", AW.Data.RelationClasses.StaticCurrencyRateRelations.CurrencyEntityUsingToCurrencyCodeStatic, true, ref _alreadyFetchedCurrency_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrency_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 currencyRateID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CurrencyRateFieldIndex.CurrencyRateID].ForcedCurrentValueWrite(currencyRateID);
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
			return DAOFactory.CreateCurrencyRateDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CurrencyRateEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CurrencyRateRelations Relations
		{
			get	{ return new CurrencyRateRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.CurrencyRateEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrency
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(), (IEntityRelation)GetRelationsForField("Currency")[0], (int)AW.Data.EntityType.CurrencyRateEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, null, "Currency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Currency'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrency_
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyCollection(), (IEntityRelation)GetRelationsForField("Currency_")[0], (int)AW.Data.EntityType.CurrencyRateEntity, (int)AW.Data.EntityType.CurrencyEntity, 0, null, null, null, "Currency_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AverageRate property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Average exchange rate for the day.<br/>Average exchange rate for the day.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."AverageRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal AverageRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.AverageRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.AverageRate, value, true); }
		}

		/// <summary> The CurrencyRateDate property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Date and time the exchange rate was obtained.<br/>Date and time the exchange rate was obtained.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CurrencyRateDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.CurrencyRateDate, value, true); }
		}

		/// <summary> The CurrencyRateID property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CurrencyRateID
		{
			get { return (System.Int32)GetValue((int)CurrencyRateFieldIndex.CurrencyRateID, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.CurrencyRateID, value, true); }
		}

		/// <summary> The EndOfDayRate property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Final exchange rate for the day.<br/>Final exchange rate for the day.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."EndOfDayRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal EndOfDayRate
		{
			get { return (System.Decimal)GetValue((int)CurrencyRateFieldIndex.EndOfDayRate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.EndOfDayRate, value, true); }
		}

		/// <summary> The FromCurrencyCode property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Exchange rate was converted from this currency code.<br/>Exchange rate was converted from this currency code.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."FromCurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FromCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.FromCurrencyCode, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyRateFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The ToCurrencyCode property of the Entity CurrencyRate<br/><br/>
		/// MS_Description: Exchange rate was converted to this currency code.<br/>Exchange rate was converted to this currency code.</summary>
		/// <remarks>Mapped on  table field: "CurrencyRate"."ToCurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ToCurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, true); }
			set	{ SetValue((int)CurrencyRateFieldIndex.ToCurrencyCode, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders
		{
			get	{ return GetMultiSalesOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders. When set to true, SalesOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaders
		{
			get	{ return _alwaysFetchSalesOrderHeaders; }
			set	{ _alwaysFetchSalesOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaders already has been fetched. Setting this property to false when SalesOrderHeaders has been fetched
		/// will clear the SalesOrderHeaders collection well. Setting this property to true while SalesOrderHeaders hasn't been fetched disables lazy loading for SalesOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaders
		{
			get { return _alreadyFetchedSalesOrderHeaders;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaders && !value && (_salesOrderHeaders != null))
				{
					_salesOrderHeaders.Clear();
				}
				_alreadyFetchedSalesOrderHeaders = value;
			}
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
					SetSingleRelatedEntityNavigator(value, "CurrencyRates", "Currency", _currency, true); 
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

		/// <summary> Gets / sets related entity of type 'CurrencyEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrency_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual CurrencyEntity Currency_
		{
			get	{ return GetSingleCurrency_(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCurrency_(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CurrencyRates_", "Currency_", _currency_, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Currency_. When set to true, Currency_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency_ is accessed. You can always execute a forced fetch by calling GetSingleCurrency_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrency_
		{
			get	{ return _alwaysFetchCurrency_; }
			set	{ _alwaysFetchCurrency_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Currency_ already has been fetched. Setting this property to false when Currency_ has been fetched
		/// will set Currency_ to null as well. Setting this property to true while Currency_ hasn't been fetched disables lazy loading for Currency_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrency_
		{
			get { return _alreadyFetchedCurrency_;}
			set 
			{
				if(_alreadyFetchedCurrency_ && !value)
				{
					this.Currency_ = null;
				}
				_alreadyFetchedCurrency_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Currency_ is not found
		/// in the database. When set to true, Currency_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Currency_ReturnsNewIfNotFound
		{
			get	{ return _currency_ReturnsNewIfNotFound; }
			set { _currency_ReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.CurrencyRateEntity; }
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
