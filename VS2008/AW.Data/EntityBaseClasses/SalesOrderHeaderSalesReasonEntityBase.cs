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
	
	/// <summary>Entity base class which represents the base class for the entity 'SalesOrderHeaderSalesReason'.<br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping sales orders to sales reason codes.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class SalesOrderHeaderSalesReasonEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private SalesOrderHeaderEntity _salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader, _salesOrderHeaderReturnsNewIfNotFound;
		private SalesReasonEntity _salesReason;
		private bool	_alwaysFetchSalesReason, _alreadyFetchedSalesReason, _salesReasonReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name SalesReason</summary>
			public static readonly string SalesReason = "SalesReason";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderHeaderSalesReasonEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderHeaderSalesReasonEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		public SalesOrderHeaderSalesReasonEntityBase(System.Int32 salesOrderID, System.Int32 salesReasonID)
		{
			InitClassFetch(salesOrderID, salesReasonID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderSalesReasonEntityBase(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(salesOrderID, salesReasonID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderSalesReasonEntity</param>
		public SalesOrderHeaderSalesReasonEntityBase(System.Int32 salesOrderID, System.Int32 salesReasonID, IValidator validator)
		{
			InitClassFetch(salesOrderID, salesReasonID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderSalesReasonEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_salesOrderHeader = (SalesOrderHeaderEntity)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderEntity));
			if(_salesOrderHeader!=null)
			{
				_salesOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesOrderHeaderReturnsNewIfNotFound = info.GetBoolean("_salesOrderHeaderReturnsNewIfNotFound");
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			_salesReason = (SalesReasonEntity)info.GetValue("_salesReason", typeof(SalesReasonEntity));
			if(_salesReason!=null)
			{
				_salesReason.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesReasonReturnsNewIfNotFound = info.GetBoolean("_salesReasonReturnsNewIfNotFound");
			_alwaysFetchSalesReason = info.GetBoolean("_alwaysFetchSalesReason");
			_alreadyFetchedSalesReason = info.GetBoolean("_alreadyFetchedSalesReason");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesOrderHeaderSalesReasonFieldIndex)fieldIndex)
			{
				case SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID:
					DesetupSyncSalesOrderHeader(true, false);
					_alreadyFetchedSalesOrderHeader = false;
					break;
				case SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID:
					DesetupSyncSalesReason(true, false);
					_alreadyFetchedSalesReason = false;
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


			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader != null);
			_alreadyFetchedSalesReason = (_salesReason != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SalesOrderHeaderSalesReasonEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "SalesOrderHeader":
					toReturn.Add(SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID);
					break;
				case "SalesReason":
					toReturn.Add(SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID);
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


			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_salesOrderHeaderReturnsNewIfNotFound", _salesOrderHeaderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_salesReason", (!this.MarkedForDeletion?_salesReason:null));
			info.AddValue("_salesReasonReturnsNewIfNotFound", _salesReasonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesReason", _alwaysFetchSalesReason);
			info.AddValue("_alreadyFetchedSalesReason", _alreadyFetchedSalesReason);

			
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
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					this.SalesOrderHeader = (SalesOrderHeaderEntity)entity;
					break;
				case "SalesReason":
					_alreadyFetchedSalesReason = true;
					this.SalesReason = (SalesReasonEntity)entity;
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
				case "SalesOrderHeader":
					SetupSyncSalesOrderHeader(relatedEntity);
					break;
				case "SalesReason":
					SetupSyncSalesReason(relatedEntity);
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
				case "SalesOrderHeader":
					DesetupSyncSalesOrderHeader(false, true);
					break;
				case "SalesReason":
					DesetupSyncSalesReason(false, true);
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
			if(_salesOrderHeader!=null)
			{
				toReturn.Add(_salesOrderHeader);
			}
			if(_salesReason!=null)
			{
				toReturn.Add(_salesReason);
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
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, System.Int32 salesReasonID)
		{
			return FetchUsingPK(salesOrderID, salesReasonID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesOrderID, salesReasonID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(salesOrderID, salesReasonID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesOrderID, salesReasonID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderID, this.SalesReasonID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesOrderHeaderSalesReasonFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesOrderHeaderSalesReasonFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderHeaderSalesReasonRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public SalesOrderHeaderEntity GetSingleSalesOrderHeader()
		{
			return GetSingleSalesOrderHeader(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public virtual SalesOrderHeaderEntity GetSingleSalesOrderHeader(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID);

				SalesOrderHeaderEntity newEntity = new SalesOrderHeaderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.SalesOrderID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesOrderHeaderEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesOrderHeader = newEntity;
				}
				else
				{
					if(_salesOrderHeaderReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesOrderHeader == null)))
						{
							this.SalesOrderHeader = newEntity;
						}
					}
					else
					{
						this.SalesOrderHeader = null;
					}
				}
				_alreadyFetchedSalesOrderHeader = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesOrderHeader;
		}

		/// <summary> Retrieves the related entity of type 'SalesReasonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesReasonEntity' which is related to this entity.</returns>
		public SalesReasonEntity GetSingleSalesReason()
		{
			return GetSingleSalesReason(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesReasonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesReasonEntity' which is related to this entity.</returns>
		public virtual SalesReasonEntity GetSingleSalesReason(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesReason || forceFetch || _alwaysFetchSalesReason) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID);

				SalesReasonEntity newEntity = new SalesReasonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.SalesReasonID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesReasonEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesReason = newEntity;
				}
				else
				{
					if(_salesReasonReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesReason == null)))
						{
							this.SalesReason = newEntity;
						}
					}
					else
					{
						this.SalesReason = null;
					}
				}
				_alreadyFetchedSalesReason = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesReason;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesOrderHeaderSalesReasonDAO dao = (SalesOrderHeaderSalesReasonDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_salesOrderHeader!=null)
			{
				_salesOrderHeader.ActiveContext = base.ActiveContext;
			}
			if(_salesReason!=null)
			{
				_salesReason.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesOrderHeaderSalesReasonDAO dao = (SalesOrderHeaderSalesReasonDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesOrderHeaderSalesReasonDAO dao = (SalesOrderHeaderSalesReasonDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity);
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
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("SalesReason", _salesReason);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderSalesReasonEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 salesOrderID, System.Int32 salesReasonID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(salesOrderID, salesReasonID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_salesOrderHeader = null;
			_salesOrderHeaderReturnsNewIfNotFound = true;
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_salesReason = null;
			_salesReasonReturnsNewIfNotFound = true;
			_alwaysFetchSalesReason = false;
			_alreadyFetchedSalesReason = false;


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
			_customProperties.Add("MS_Description", @"Cross-reference table mapping sales orders to sales reason codes.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to SalesReason.SalesReasonID.");
			_fieldsCustomProperties.Add("SalesReasonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _salesOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID, true, signalRelatedEntity, "SalesOrderHeaderSalesReason", resetFKFields, new int[] { (int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID } );		
			_salesOrderHeader = null;
		}
		
		/// <summary> setups the sync logic for member _salesOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesOrderHeader(IEntity relatedEntity)
		{
			if(_salesOrderHeader!=relatedEntity)
			{		
				DesetupSyncSalesOrderHeader(true, true);
				_salesOrderHeader = (SalesOrderHeaderEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID, true, ref _alreadyFetchedSalesOrderHeader, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesOrderHeaderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _salesReason</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesReason(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _salesReason, new PropertyChangedEventHandler( OnSalesReasonPropertyChanged ), "SalesReason", SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID, true, signalRelatedEntity, "SalesOrderHeaderSalesReason", resetFKFields, new int[] { (int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID } );		
			_salesReason = null;
		}
		
		/// <summary> setups the sync logic for member _salesReason</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesReason(IEntity relatedEntity)
		{
			if(_salesReason!=relatedEntity)
			{		
				DesetupSyncSalesReason(true, true);
				_salesReason = (SalesReasonEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _salesReason, new PropertyChangedEventHandler( OnSalesReasonPropertyChanged ), "SalesReason", SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID, true, ref _alreadyFetchedSalesReason, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesReasonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID].ForcedCurrentValueWrite(salesOrderID);
				base.Fields[(int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID].ForcedCurrentValueWrite(salesReasonID);
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
			return DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesOrderHeaderSalesReasonEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesOrderHeaderSalesReasonRelations Relations
		{
			get	{ return new SalesOrderHeaderSalesReasonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesReason' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesReason
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesReasonCollection(),
					(IEntityRelation)GetRelationsForField("SalesReason")[0], (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, (int)AW.Data.EntityType.SalesReasonEntity, 0, null, null, null, "SalesReason", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SalesOrderHeaderSalesReasonEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SalesOrderHeaderSalesReasonEntity.CustomProperties;}
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
			get { return SalesOrderHeaderSalesReasonEntity.FieldsCustomProperties;}
		}

		/// <summary> The SalesOrderID property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesOrderID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, value, true); }
		}
		/// <summary> The SalesReasonID property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// 
		/// MS_Description: Primary key. Foreign key to SalesReason.SalesReasonID.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."SalesReasonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesReasonID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'SalesOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get	{ return GetSingleSalesOrderHeader(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesOrderHeader(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesOrderHeader != null)
						{
							_salesOrderHeader.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
					else
					{
						if(_salesOrderHeader!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesOrderHeader; }
			set	{ _alwaysFetchSalesOrderHeader = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeader already has been fetched. Setting this property to false when SalesOrderHeader has been fetched
		/// will set SalesOrderHeader to null as well. Setting this property to true while SalesOrderHeader hasn't been fetched disables lazy loading for SalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeader
		{
			get { return _alreadyFetchedSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeader && !value)
				{
					this.SalesOrderHeader = null;
				}
				_alreadyFetchedSalesOrderHeader = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesOrderHeader is not found
		/// in the database. When set to true, SalesOrderHeader will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesOrderHeaderReturnsNewIfNotFound
		{
			get	{ return _salesOrderHeaderReturnsNewIfNotFound; }
			set { _salesOrderHeaderReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'SalesReasonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesReasonEntity SalesReason
		{
			get	{ return GetSingleSalesReason(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesReason(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesReason != null)
						{
							_salesReason.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
					else
					{
						if(_salesReason!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesReason. When set to true, SalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesReason is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesReason(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesReason
		{
			get	{ return _alwaysFetchSalesReason; }
			set	{ _alwaysFetchSalesReason = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesReason already has been fetched. Setting this property to false when SalesReason has been fetched
		/// will set SalesReason to null as well. Setting this property to true while SalesReason hasn't been fetched disables lazy loading for SalesReason</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesReason
		{
			get { return _alreadyFetchedSalesReason;}
			set 
			{
				if(_alreadyFetchedSalesReason && !value)
				{
					this.SalesReason = null;
				}
				_alreadyFetchedSalesReason = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesReason is not found
		/// in the database. When set to true, SalesReason will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesReasonReturnsNewIfNotFound
		{
			get	{ return _salesReasonReturnsNewIfNotFound; }
			set { _salesReasonReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity; }
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
