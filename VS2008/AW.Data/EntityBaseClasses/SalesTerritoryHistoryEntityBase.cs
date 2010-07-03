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
	
	/// <summary>Entity base class which represents the base class for the entity 'SalesTerritoryHistory'.<br/><br/>
	/// 
	/// MS_Description: Sales representative transfers to other sales territories.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class SalesTerritoryHistoryEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson, _salesPersonReturnsNewIfNotFound;
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
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesTerritoryHistoryEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesTerritoryHistoryEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		public SalesTerritoryHistoryEntityBase(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate)
		{
			InitClassFetch(salesPersonID, territoryID, startDate, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesTerritoryHistoryEntityBase(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(salesPersonID, territoryID, startDate, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryHistoryEntity</param>
		public SalesTerritoryHistoryEntityBase(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IValidator validator)
		{
			InitClassFetch(salesPersonID, territoryID, startDate, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTerritoryHistoryEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesPersonReturnsNewIfNotFound = info.GetBoolean("_salesPersonReturnsNewIfNotFound");
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesTerritoryReturnsNewIfNotFound = info.GetBoolean("_salesTerritoryReturnsNewIfNotFound");
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesTerritoryHistoryFieldIndex)fieldIndex)
			{
				case SalesTerritoryHistoryFieldIndex.SalesPersonID:
					DesetupSyncSalesPerson(true, false);
					_alreadyFetchedSalesPerson = false;
					break;
				case SalesTerritoryHistoryFieldIndex.TerritoryID:
					DesetupSyncSalesTerritory(true, false);
					_alreadyFetchedSalesTerritory = false;
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


			_alreadyFetchedSalesPerson = (_salesPerson != null);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SalesTerritoryHistoryEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "SalesPerson":
					toReturn.Add(SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingSalesPersonID);
					break;
				case "SalesTerritory":
					toReturn.Add(SalesTerritoryHistoryEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
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


			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_salesPersonReturnsNewIfNotFound", _salesPersonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
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
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					this.SalesPerson = (SalesPersonEntity)entity;
					break;
				case "SalesTerritory":
					_alreadyFetchedSalesTerritory = true;
					this.SalesTerritory = (SalesTerritoryEntity)entity;
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
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
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
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
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
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
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
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate)
		{
			return FetchUsingPK(salesPersonID, territoryID, startDate, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesPersonID, territoryID, startDate, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(salesPersonID, territoryID, startDate, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesPersonID, territoryID, startDate, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesPersonID, this.TerritoryID, this.StartDate, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesTerritoryHistoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesTerritoryHistoryFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SalesTerritoryHistoryRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingSalesPersonID);

				SalesPersonEntity newEntity = new SalesPersonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.SalesPersonID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesPersonEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesPerson = newEntity;
				}
				else
				{
					if(_salesPersonReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesPerson == null)))
						{
							this.SalesPerson = newEntity;
						}
					}
					else
					{
						this.SalesPerson = null;
					}
				}
				_alreadyFetchedSalesPerson = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesPerson;
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
			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesTerritoryHistoryEntity.Relations.SalesTerritoryEntityUsingTerritoryID);

				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.TerritoryID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesTerritoryEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesTerritory = newEntity;
				}
				else
				{
					if(_salesTerritoryReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesTerritory == null)))
						{
							this.SalesTerritory = newEntity;
						}
					}
					else
					{
						this.SalesTerritory = null;
					}
				}
				_alreadyFetchedSalesTerritory = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesTerritory;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesTerritoryHistoryDAO dao = (SalesTerritoryHistoryDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_salesPerson!=null)
			{
				_salesPerson.ActiveContext = base.ActiveContext;
			}
			if(_salesTerritory!=null)
			{
				_salesTerritory.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesTerritoryHistoryDAO dao = (SalesTerritoryHistoryDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesTerritoryHistoryDAO dao = (SalesTerritoryHistoryDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesTerritoryHistoryEntity);
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
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("SalesTerritory", _salesTerritory);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="validator">The validator object for this SalesTerritoryHistoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(salesPersonID, territoryID, startDate, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_salesPerson = null;
			_salesPersonReturnsNewIfNotFound = true;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritory = null;
			_salesTerritoryReturnsNewIfNotFound = true;
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;


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
			_customProperties.Add("MS_Description", @"Sales representative transfers to other sales territories.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesPersonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the sales representive started work in the territory.");
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the sales representative left work in the territory.");
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _salesPerson</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingSalesPersonID, true, signalRelatedEntity, "SalesTerritoryHistory", resetFKFields, new int[] { (int)SalesTerritoryHistoryFieldIndex.SalesPersonID } );		
			_salesPerson = null;
		}
		
		/// <summary> setups the sync logic for member _salesPerson</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntity relatedEntity)
		{
			if(_salesPerson!=relatedEntity)
			{		
				DesetupSyncSalesPerson(true, true);
				_salesPerson = (SalesPersonEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingSalesPersonID, true, ref _alreadyFetchedSalesPerson, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesTerritoryHistoryEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, signalRelatedEntity, "SalesTerritoryHistory", resetFKFields, new int[] { (int)SalesTerritoryHistoryFieldIndex.TerritoryID } );		
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
				base.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesTerritoryHistoryEntity.Relations.SalesTerritoryEntityUsingTerritoryID, true, ref _alreadyFetchedSalesTerritory, new string[] {  } );
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
		/// <param name="salesPersonID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="territoryID">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="startDate">PK value for SalesTerritoryHistory which data should be fetched into this SalesTerritoryHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesPersonID, System.Int32 territoryID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesTerritoryHistoryFieldIndex.SalesPersonID].ForcedCurrentValueWrite(salesPersonID);
				base.Fields[(int)SalesTerritoryHistoryFieldIndex.TerritoryID].ForcedCurrentValueWrite(territoryID);
				base.Fields[(int)SalesTerritoryHistoryFieldIndex.StartDate].ForcedCurrentValueWrite(startDate);
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
			return DAOFactory.CreateSalesTerritoryHistoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesTerritoryHistoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesTerritoryHistoryRelations Relations
		{
			get	{ return new SalesTerritoryHistoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPerson
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(),
					(IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.SalesTerritoryHistoryEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(),
					(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AW.Data.EntityType.SalesTerritoryHistoryEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SalesTerritoryHistoryEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SalesTerritoryHistoryEntity.CustomProperties;}
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
			get { return SalesTerritoryHistoryEntity.FieldsCustomProperties;}
		}

		/// <summary> The SalesPersonID property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesPersonID
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryHistoryFieldIndex.SalesPersonID, true); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.SalesPersonID, value, true); }
		}
		/// <summary> The TerritoryID property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 TerritoryID
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryHistoryFieldIndex.TerritoryID, true); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.TerritoryID, value, true); }
		}
		/// <summary> The StartDate property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: Date the sales representive started work in the territory.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryHistoryFieldIndex.StartDate, true); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.StartDate, value, true); }
		}
		/// <summary> The EndDate property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: Date the sales representative left work in the territory.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SalesTerritoryHistoryFieldIndex.EndDate, false); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.EndDate, value, true); }
		}
		/// <summary> The Rowguid property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTerritoryHistoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesTerritoryHistory<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritoryHistory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryHistoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTerritoryHistoryFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'SalesPersonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get	{ return GetSingleSalesPerson(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesPerson != null)
						{
							_salesPerson.UnsetRelatedEntity(this, "SalesTerritoryHistory");
						}
					}
					else
					{
						if(_salesPerson!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesTerritoryHistory");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesPerson(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson
		{
			get	{ return _alwaysFetchSalesPerson; }
			set	{ _alwaysFetchSalesPerson = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPerson already has been fetched. Setting this property to false when SalesPerson has been fetched
		/// will set SalesPerson to null as well. Setting this property to true while SalesPerson hasn't been fetched disables lazy loading for SalesPerson</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPerson
		{
			get { return _alreadyFetchedSalesPerson;}
			set 
			{
				if(_alreadyFetchedSalesPerson && !value)
				{
					this.SalesPerson = null;
				}
				_alreadyFetchedSalesPerson = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesPerson is not found
		/// in the database. When set to true, SalesPerson will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesPersonReturnsNewIfNotFound
		{
			get	{ return _salesPersonReturnsNewIfNotFound; }
			set { _salesPersonReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return GetSingleSalesTerritory(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesTerritory != null)
						{
							_salesTerritory.UnsetRelatedEntity(this, "SalesTerritoryHistory");
						}
					}
					else
					{
						if(_salesTerritory!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesTerritoryHistory");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesTerritory(true).</summary>
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
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.SalesTerritoryHistoryEntity; }
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
