///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesOrderHeaderSalesReason'. <br/><br/>
	/// 
	/// MS_Description: Cross-reference table mapping sales orders to sales reason codes.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesOrderHeaderSalesReasonEntity : CommonEntityBase
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
		static SalesOrderHeaderSalesReasonEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderHeaderSalesReasonEntity() :base("SalesOrderHeaderSalesReasonEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID):base("SalesOrderHeaderSalesReasonEntity")
		{
			InitClassFetch(salesOrderID, salesReasonID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse):base("SalesOrderHeaderSalesReasonEntity")
		{
			InitClassFetch(salesOrderID, salesReasonID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderSalesReasonEntity</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID, IValidator validator):base("SalesOrderHeaderSalesReasonEntity")
		{
			InitClassFetch(salesOrderID, salesReasonID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderSalesReasonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
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

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader != null);
			_alreadyFetchedSalesReason = (_salesReason != null);
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
				case "SalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesOrderID);
					break;
				case "SalesReason":
					toReturn.Add(Relations.SalesReasonEntityUsingSalesReasonID);
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
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
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
			return FetchUsingPK(salesOrderID, salesReasonID, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderID, this.SalesReasonID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
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
			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesOrderHeaderEntityUsingSalesOrderID);
				SalesOrderHeaderEntity newEntity = new SalesOrderHeaderEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SalesOrderID);
				}
				if(fetchResult)
				{
					newEntity = (SalesOrderHeaderEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesOrderHeaderReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesOrderHeader = newEntity;
				_alreadyFetchedSalesOrderHeader = fetchResult;
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
			if( ( !_alreadyFetchedSalesReason || forceFetch || _alwaysFetchSalesReason) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesReasonEntityUsingSalesReasonID);
				SalesReasonEntity newEntity = new SalesReasonEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SalesReasonID);
				}
				if(fetchResult)
				{
					newEntity = (SalesReasonEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesReasonReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesReason = newEntity;
				_alreadyFetchedSalesReason = fetchResult;
			}
			return _salesReason;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("SalesReason", _salesReason);
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
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderSalesReasonEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 salesOrderID, System.Int32 salesReasonID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(salesOrderID, salesReasonID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderHeaderReturnsNewIfNotFound = true;
			_salesReasonReturnsNewIfNotFound = true;
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key. Foreign key to SalesReason.SalesReasonID.");
			_fieldsCustomProperties.Add("SalesReasonID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AW.Data.RelationClasses.StaticSalesOrderHeaderSalesReasonRelations.SalesOrderHeaderEntityUsingSalesOrderIDStatic, true, signalRelatedEntity, "SalesOrderHeaderSalesReasons", resetFKFields, new int[] { (int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID } );		
			_salesOrderHeader = null;
		}
		
		/// <summary> setups the sync logic for member _salesOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesOrderHeader(IEntityCore relatedEntity)
		{
			if(_salesOrderHeader!=relatedEntity)
			{		
				DesetupSyncSalesOrderHeader(true, true);
				_salesOrderHeader = (SalesOrderHeaderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AW.Data.RelationClasses.StaticSalesOrderHeaderSalesReasonRelations.SalesOrderHeaderEntityUsingSalesOrderIDStatic, true, ref _alreadyFetchedSalesOrderHeader, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _salesReason, new PropertyChangedEventHandler( OnSalesReasonPropertyChanged ), "SalesReason", AW.Data.RelationClasses.StaticSalesOrderHeaderSalesReasonRelations.SalesReasonEntityUsingSalesReasonIDStatic, true, signalRelatedEntity, "SalesOrderHeaderSalesReasons", resetFKFields, new int[] { (int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID } );		
			_salesReason = null;
		}
		
		/// <summary> setups the sync logic for member _salesReason</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesReason(IEntityCore relatedEntity)
		{
			if(_salesReason!=relatedEntity)
			{		
				DesetupSyncSalesReason(true, true);
				_salesReason = (SalesReasonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesReason, new PropertyChangedEventHandler( OnSalesReasonPropertyChanged ), "SalesReason", AW.Data.RelationClasses.StaticSalesOrderHeaderSalesReasonRelations.SalesReasonEntityUsingSalesReasonIDStatic, true, ref _alreadyFetchedSalesReason, new string[] {  } );
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
				this.Fields[(int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID].ForcedCurrentValueWrite(salesOrderID);
				this.Fields[(int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID].ForcedCurrentValueWrite(salesReasonID);
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

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesReason'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesReason
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesReasonCollection(), (IEntityRelation)GetRelationsForField("SalesReason")[0], (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, (int)AW.Data.EntityType.SalesReasonEntity, 0, null, null, null, "SalesReason", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ModifiedDate property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The SalesOrderID property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesOrderID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, value, true); }
		}

		/// <summary> The SalesReasonID property of the Entity SalesOrderHeaderSalesReason<br/><br/>
		/// MS_Description: Primary key. Foreign key to SalesReason.SalesReasonID.<br/>Primary key. Foreign key to SalesReason.SalesReasonID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeaderSalesReason"."SalesReasonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesReasonID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, true); }
			set	{ SetValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'SalesOrderHeaderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get	{ return GetSingleSalesOrderHeader(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesOrderHeader(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaderSalesReasons", "SalesOrderHeader", _salesOrderHeader, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute a forced fetch by calling GetSingleSalesOrderHeader(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesReasonEntity SalesReason
		{
			get	{ return GetSingleSalesReason(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesReason(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaderSalesReasons", "SalesReason", _salesReason, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesReason. When set to true, SalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesReason is accessed. You can always execute a forced fetch by calling GetSingleSalesReason(true).</summary>
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
		protected override int LLBLGenProEntityTypeValue 
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
