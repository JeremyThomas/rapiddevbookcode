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
	
	/// <summary>Entity base class which represents the base class for the entity 'SalesReason'.<br/><br/>
	/// 
	/// MS_Description: Lookup table of customer purchase reasons.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class SalesReasonEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection	_salesOrderHeaderSalesReason;
		private bool	_alwaysFetchSalesOrderHeaderSalesReason, _alreadyFetchedSalesOrderHeaderSalesReason;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection _salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason;
		private bool	_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason, _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name SalesOrderHeaderSalesReason</summary>
			public static readonly string SalesOrderHeaderSalesReason = "SalesOrderHeaderSalesReason";
			/// <summary>Member name SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason</summary>
			public static readonly string SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = "SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesReasonEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesReasonEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		public SalesReasonEntityBase(System.Int32 salesReasonID)
		{
			InitClassFetch(salesReasonID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesReasonEntityBase(System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(salesReasonID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesReasonEntity</param>
		public SalesReasonEntityBase(System.Int32 salesReasonID, IValidator validator)
		{
			InitClassFetch(salesReasonID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesReasonEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeaderSalesReason = (AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection)info.GetValue("_salesOrderHeaderSalesReason", typeof(AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection));
			_alwaysFetchSalesOrderHeaderSalesReason = info.GetBoolean("_alwaysFetchSalesOrderHeaderSalesReason");
			_alreadyFetchedSalesOrderHeaderSalesReason = info.GetBoolean("_alreadyFetchedSalesOrderHeaderSalesReason");
			_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = info.GetBoolean("_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason");
			_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = info.GetBoolean("_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesReasonFieldIndex)fieldIndex)
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
			_alreadyFetchedSalesOrderHeaderSalesReason = (_salesOrderHeaderSalesReason.Count > 0);
			_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = (_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SalesReasonEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "SalesOrderHeaderSalesReason":
					toReturn.Add(SalesReasonEntity.Relations.SalesOrderHeaderSalesReasonEntityUsingSalesReasonID);
					break;
				case "SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason":
					toReturn.Add(SalesReasonEntity.Relations.SalesOrderHeaderSalesReasonEntityUsingSalesReasonID, "SalesReasonEntity__", "SalesOrderHeaderSalesReason_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID, "SalesOrderHeaderSalesReason_", string.Empty, JoinHint.None);
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
			info.AddValue("_salesOrderHeaderSalesReason", (!this.MarkedForDeletion?_salesOrderHeaderSalesReason:null));
			info.AddValue("_alwaysFetchSalesOrderHeaderSalesReason", _alwaysFetchSalesOrderHeaderSalesReason);
			info.AddValue("_alreadyFetchedSalesOrderHeaderSalesReason", _alreadyFetchedSalesOrderHeaderSalesReason);
			info.AddValue("_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", (!this.MarkedForDeletion?_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason:null));
			info.AddValue("_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason);
			info.AddValue("_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason);


			
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

				case "SalesOrderHeaderSalesReason":
					_alreadyFetchedSalesOrderHeaderSalesReason = true;
					if(entity!=null)
					{
						this.SalesOrderHeaderSalesReason.Add((SalesOrderHeaderSalesReasonEntity)entity);
					}
					break;
				case "SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason":
					_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = true;
					if(entity!=null)
					{
						this.SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.Add((SalesOrderHeaderEntity)entity);
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

				case "SalesOrderHeaderSalesReason":
					_salesOrderHeaderSalesReason.Add((SalesOrderHeaderSalesReasonEntity)relatedEntity);
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

				case "SalesOrderHeaderSalesReason":
					base.PerformRelatedEntityRemoval(_salesOrderHeaderSalesReason, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_salesOrderHeaderSalesReason);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesReasonID)
		{
			return FetchUsingPK(salesReasonID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesReasonID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(salesReasonID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesReasonID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesReasonID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesReasonFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesReasonFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SalesReasonRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch)
		{
			return GetMultiSalesOrderHeaderSalesReason(forceFetch, _salesOrderHeaderSalesReason.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaderSalesReason(forceFetch, _salesOrderHeaderSalesReason.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaderSalesReason(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderSalesReason);
					}
				}
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeaderSalesReason.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeaderSalesReason.GetMultiManyToOne(null, this, filter);
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderSalesReason;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaderSalesReason'. These settings will be taken into account
		/// when the property SalesOrderHeaderSalesReason is requested or GetMultiSalesOrderHeaderSalesReason is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaderSalesReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaderSalesReason.SortClauses=sortClauses;
			_salesOrderHeaderSalesReason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(bool forceFetch)
		{
			return GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(forceFetch, _salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesReasonFields.SalesReasonID, ComparisonOperator.Equal, this.SalesReasonID, "SalesReasonEntity__"));
				_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.GetMulti(filter, GetRelationsForField("SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason"));
				_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason'. These settings will be taken into account
		/// when the property SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason is requested or GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.SortClauses=sortClauses;
			_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesReasonDAO dao = (SalesReasonDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderHeaderSalesReason.ActiveContext = base.ActiveContext;
			_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesReasonDAO dao = (SalesReasonDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesReasonDAO dao = (SalesReasonDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesReasonEntity);
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

			toReturn.Add("SalesOrderHeaderSalesReason", _salesOrderHeaderSalesReason);
			toReturn.Add("SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", _salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="validator">The validator object for this SalesReasonEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 salesReasonID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(salesReasonID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderHeaderSalesReason = new AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection(new SalesOrderHeaderSalesReasonEntityFactory());
			_salesOrderHeaderSalesReason.SetContainingEntityInfo(this, "SalesReason");
			_alwaysFetchSalesOrderHeaderSalesReason = false;
			_alreadyFetchedSalesOrderHeaderSalesReason = false;
			_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = false;
			_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = false;



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
			_customProperties.Add("MS_Description", @"Lookup table of customer purchase reasons.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesReasonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales reason description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Category the sales reason belongs to.");
			_fieldsCustomProperties.Add("ReasonType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesReasonID">PK value for SalesReason which data should be fetched into this SalesReason object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesReasonID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesReasonFieldIndex.SalesReasonID].ForcedCurrentValueWrite(salesReasonID);
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
			return DAOFactory.CreateSalesReasonDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesReasonEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesReasonRelations Relations
		{
			get	{ return new SalesReasonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeaderSalesReason' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaderSalesReason
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeaderSalesReason")[0], (int)AW.Data.EntityType.SalesReasonEntity, (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, 0, null, null, null, "SalesOrderHeaderSalesReason", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason
		{
			get
			{
				IEntityRelation intermediateRelation = SalesReasonEntity.Relations.SalesOrderHeaderSalesReasonEntityUsingSalesReasonID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeaderSalesReason_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesReasonEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, GetRelationsForField("SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason"), "SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SalesReasonEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SalesReasonEntity.CustomProperties;}
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
			get { return SalesReasonEntity.FieldsCustomProperties;}
		}

		/// <summary> The SalesReasonID property of the Entity SalesReason<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."SalesReasonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesReasonID
		{
			get { return (System.Int32)GetValue((int)SalesReasonFieldIndex.SalesReasonID, true); }
			set	{ SetValue((int)SalesReasonFieldIndex.SalesReasonID, value, true); }
		}
		/// <summary> The Name property of the Entity SalesReason<br/><br/>
		/// 
		/// MS_Description: Sales reason description.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesReasonFieldIndex.Name, true); }
			set	{ SetValue((int)SalesReasonFieldIndex.Name, value, true); }
		}
		/// <summary> The ReasonType property of the Entity SalesReason<br/><br/>
		/// 
		/// MS_Description: Category the sales reason belongs to.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."ReasonType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ReasonType
		{
			get { return (System.String)GetValue((int)SalesReasonFieldIndex.ReasonType, true); }
			set	{ SetValue((int)SalesReasonFieldIndex.ReasonType, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesReason<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesReason"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesReasonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesReasonFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaderSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection SalesOrderHeaderSalesReason
		{
			get	{ return GetMultiSalesOrderHeaderSalesReason(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaderSalesReason. When set to true, SalesOrderHeaderSalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaderSalesReason is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeaderSalesReason(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaderSalesReason
		{
			get	{ return _alwaysFetchSalesOrderHeaderSalesReason; }
			set	{ _alwaysFetchSalesOrderHeaderSalesReason = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaderSalesReason already has been fetched. Setting this property to false when SalesOrderHeaderSalesReason has been fetched
		/// will clear the SalesOrderHeaderSalesReason collection well. Setting this property to true while SalesOrderHeaderSalesReason hasn't been fetched disables lazy loading for SalesOrderHeaderSalesReason</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaderSalesReason
		{
			get { return _alreadyFetchedSalesOrderHeaderSalesReason;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaderSalesReason && !value && (_salesOrderHeaderSalesReason != null))
				{
					_salesOrderHeaderSalesReason.Clear();
				}
				_alreadyFetchedSalesOrderHeaderSalesReason = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason
		{
			get { return GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason. When set to true, SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason
		{
			get	{ return _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason; }
			set	{ _alwaysFetchSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason already has been fetched. Setting this property to false when SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason has been fetched
		/// will clear the SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason collection well. Setting this property to true while SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason hasn't been fetched disables lazy loading for SalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason
		{
			get { return _alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason && !value && (_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason != null))
				{
					_salesOrderHeaderCollectionViaSalesOrderHeaderSalesReason.Clear();
				}
				_alreadyFetchedSalesOrderHeaderCollectionViaSalesOrderHeaderSalesReason = value;
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
			get { return (int)AW.Data.EntityType.SalesReasonEntity; }
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
