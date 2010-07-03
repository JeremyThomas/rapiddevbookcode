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
	
	/// <summary>Entity base class which represents the base class for the entity 'Location'.<br/><br/>
	/// 
	/// MS_Description: Product inventory and manufacturing locations.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class LocationEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductInventoryCollection	_productInventory;
		private bool	_alwaysFetchProductInventory, _alreadyFetchedProductInventory;
		private AW.Data.CollectionClasses.WorkOrderRoutingCollection	_workOrderRouting;
		private bool	_alwaysFetchWorkOrderRouting, _alreadyFetchedWorkOrderRouting;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaProductInventory;
		private bool	_alwaysFetchProductCollectionViaProductInventory, _alreadyFetchedProductCollectionViaProductInventory;
		private AW.Data.CollectionClasses.WorkOrderCollection _workOrderCollectionViaWorkOrderRouting;
		private bool	_alwaysFetchWorkOrderCollectionViaWorkOrderRouting, _alreadyFetchedWorkOrderCollectionViaWorkOrderRouting;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductInventory</summary>
			public static readonly string ProductInventory = "ProductInventory";
			/// <summary>Member name WorkOrderRouting</summary>
			public static readonly string WorkOrderRouting = "WorkOrderRouting";
			/// <summary>Member name ProductCollectionViaProductInventory</summary>
			public static readonly string ProductCollectionViaProductInventory = "ProductCollectionViaProductInventory";
			/// <summary>Member name WorkOrderCollectionViaWorkOrderRouting</summary>
			public static readonly string WorkOrderCollectionViaWorkOrderRouting = "WorkOrderCollectionViaWorkOrderRouting";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static LocationEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public LocationEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		public LocationEntityBase(System.Int16 locationID)
		{
			InitClassFetch(locationID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public LocationEntityBase(System.Int16 locationID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(locationID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="validator">The custom validator object for this LocationEntity</param>
		public LocationEntityBase(System.Int16 locationID, IValidator validator)
		{
			InitClassFetch(locationID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LocationEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productInventory = (AW.Data.CollectionClasses.ProductInventoryCollection)info.GetValue("_productInventory", typeof(AW.Data.CollectionClasses.ProductInventoryCollection));
			_alwaysFetchProductInventory = info.GetBoolean("_alwaysFetchProductInventory");
			_alreadyFetchedProductInventory = info.GetBoolean("_alreadyFetchedProductInventory");
			_workOrderRouting = (AW.Data.CollectionClasses.WorkOrderRoutingCollection)info.GetValue("_workOrderRouting", typeof(AW.Data.CollectionClasses.WorkOrderRoutingCollection));
			_alwaysFetchWorkOrderRouting = info.GetBoolean("_alwaysFetchWorkOrderRouting");
			_alreadyFetchedWorkOrderRouting = info.GetBoolean("_alreadyFetchedWorkOrderRouting");
			_productCollectionViaProductInventory = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaProductInventory", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaProductInventory = info.GetBoolean("_alwaysFetchProductCollectionViaProductInventory");
			_alreadyFetchedProductCollectionViaProductInventory = info.GetBoolean("_alreadyFetchedProductCollectionViaProductInventory");
			_workOrderCollectionViaWorkOrderRouting = (AW.Data.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrderCollectionViaWorkOrderRouting", typeof(AW.Data.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrderCollectionViaWorkOrderRouting = info.GetBoolean("_alwaysFetchWorkOrderCollectionViaWorkOrderRouting");
			_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = info.GetBoolean("_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((LocationFieldIndex)fieldIndex)
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
			_alreadyFetchedProductInventory = (_productInventory.Count > 0);
			_alreadyFetchedWorkOrderRouting = (_workOrderRouting.Count > 0);
			_alreadyFetchedProductCollectionViaProductInventory = (_productCollectionViaProductInventory.Count > 0);
			_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = (_workOrderCollectionViaWorkOrderRouting.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return LocationEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductInventory":
					toReturn.Add(LocationEntity.Relations.ProductInventoryEntityUsingLocationID);
					break;
				case "WorkOrderRouting":
					toReturn.Add(LocationEntity.Relations.WorkOrderRoutingEntityUsingLocationID);
					break;
				case "ProductCollectionViaProductInventory":
					toReturn.Add(LocationEntity.Relations.ProductInventoryEntityUsingLocationID, "LocationEntity__", "ProductInventory_", JoinHint.None);
					toReturn.Add(ProductInventoryEntity.Relations.ProductEntityUsingProductID, "ProductInventory_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderCollectionViaWorkOrderRouting":
					toReturn.Add(LocationEntity.Relations.WorkOrderRoutingEntityUsingLocationID, "LocationEntity__", "WorkOrderRouting_", JoinHint.None);
					toReturn.Add(WorkOrderRoutingEntity.Relations.WorkOrderEntityUsingWorkOrderID, "WorkOrderRouting_", string.Empty, JoinHint.None);
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
			info.AddValue("_productInventory", (!this.MarkedForDeletion?_productInventory:null));
			info.AddValue("_alwaysFetchProductInventory", _alwaysFetchProductInventory);
			info.AddValue("_alreadyFetchedProductInventory", _alreadyFetchedProductInventory);
			info.AddValue("_workOrderRouting", (!this.MarkedForDeletion?_workOrderRouting:null));
			info.AddValue("_alwaysFetchWorkOrderRouting", _alwaysFetchWorkOrderRouting);
			info.AddValue("_alreadyFetchedWorkOrderRouting", _alreadyFetchedWorkOrderRouting);
			info.AddValue("_productCollectionViaProductInventory", (!this.MarkedForDeletion?_productCollectionViaProductInventory:null));
			info.AddValue("_alwaysFetchProductCollectionViaProductInventory", _alwaysFetchProductCollectionViaProductInventory);
			info.AddValue("_alreadyFetchedProductCollectionViaProductInventory", _alreadyFetchedProductCollectionViaProductInventory);
			info.AddValue("_workOrderCollectionViaWorkOrderRouting", (!this.MarkedForDeletion?_workOrderCollectionViaWorkOrderRouting:null));
			info.AddValue("_alwaysFetchWorkOrderCollectionViaWorkOrderRouting", _alwaysFetchWorkOrderCollectionViaWorkOrderRouting);
			info.AddValue("_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting", _alreadyFetchedWorkOrderCollectionViaWorkOrderRouting);


			
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

				case "ProductInventory":
					_alreadyFetchedProductInventory = true;
					if(entity!=null)
					{
						this.ProductInventory.Add((ProductInventoryEntity)entity);
					}
					break;
				case "WorkOrderRouting":
					_alreadyFetchedWorkOrderRouting = true;
					if(entity!=null)
					{
						this.WorkOrderRouting.Add((WorkOrderRoutingEntity)entity);
					}
					break;
				case "ProductCollectionViaProductInventory":
					_alreadyFetchedProductCollectionViaProductInventory = true;
					if(entity!=null)
					{
						this.ProductCollectionViaProductInventory.Add((ProductEntity)entity);
					}
					break;
				case "WorkOrderCollectionViaWorkOrderRouting":
					_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = true;
					if(entity!=null)
					{
						this.WorkOrderCollectionViaWorkOrderRouting.Add((WorkOrderEntity)entity);
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

				case "ProductInventory":
					_productInventory.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "WorkOrderRouting":
					_workOrderRouting.Add((WorkOrderRoutingEntity)relatedEntity);
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

				case "ProductInventory":
					base.PerformRelatedEntityRemoval(_productInventory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderRouting":
					base.PerformRelatedEntityRemoval(_workOrderRouting, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_productInventory);
			toReturn.Add(_workOrderRouting);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID)
		{
			return FetchUsingPK(locationID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(locationID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(locationID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(locationID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.LocationID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(LocationFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(LocationFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new LocationRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch)
		{
			return GetMultiProductInventory(forceFetch, _productInventory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductInventory(forceFetch, _productInventory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductInventory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productInventory.EntityFactoryToUse = entityFactoryToUse;
				}
				_productInventory.GetMultiManyToOne(this, null, filter);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductInventory'. These settings will be taken into account
		/// when the property ProductInventory is requested or GetMultiProductInventory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductInventory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productInventory.SortClauses=sortClauses;
			_productInventory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch)
		{
			return GetMultiWorkOrderRouting(forceFetch, _workOrderRouting.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderRouting(forceFetch, _workOrderRouting.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderRouting(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderRouting);
					}
				}
				_workOrderRouting.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderRouting.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderRouting.GetMultiManyToOne(this, null, filter);
				_workOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRouting = true;
			}
			return _workOrderRouting;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderRouting'. These settings will be taken into account
		/// when the property WorkOrderRouting is requested or GetMultiWorkOrderRouting is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderRouting(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderRouting.SortClauses=sortClauses;
			_workOrderRouting.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductInventory(bool forceFetch)
		{
			return GetMultiProductCollectionViaProductInventory(forceFetch, _productCollectionViaProductInventory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaProductInventory || forceFetch || _alwaysFetchProductCollectionViaProductInventory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaProductInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaProductInventory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(LocationFields.LocationID, ComparisonOperator.Equal, this.LocationID, "LocationEntity__"));
				_productCollectionViaProductInventory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaProductInventory.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaProductInventory.GetMulti(filter, GetRelationsForField("ProductCollectionViaProductInventory"));
				_productCollectionViaProductInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaProductInventory = true;
			}
			return _productCollectionViaProductInventory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaProductInventory'. These settings will be taken into account
		/// when the property ProductCollectionViaProductInventory is requested or GetMultiProductCollectionViaProductInventory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaProductInventory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaProductInventory.SortClauses=sortClauses;
			_productCollectionViaProductInventory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderRouting(bool forceFetch)
		{
			return GetMultiWorkOrderCollectionViaWorkOrderRouting(forceFetch, _workOrderCollectionViaWorkOrderRouting.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderRouting(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderCollectionViaWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderCollectionViaWorkOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderCollectionViaWorkOrderRouting);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(LocationFields.LocationID, ComparisonOperator.Equal, this.LocationID, "LocationEntity__"));
				_workOrderCollectionViaWorkOrderRouting.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderCollectionViaWorkOrderRouting.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderCollectionViaWorkOrderRouting.GetMulti(filter, GetRelationsForField("WorkOrderCollectionViaWorkOrderRouting"));
				_workOrderCollectionViaWorkOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = true;
			}
			return _workOrderCollectionViaWorkOrderRouting;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderCollectionViaWorkOrderRouting'. These settings will be taken into account
		/// when the property WorkOrderCollectionViaWorkOrderRouting is requested or GetMultiWorkOrderCollectionViaWorkOrderRouting is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderCollectionViaWorkOrderRouting(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderCollectionViaWorkOrderRouting.SortClauses=sortClauses;
			_workOrderCollectionViaWorkOrderRouting.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			LocationDAO dao = (LocationDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productInventory.ActiveContext = base.ActiveContext;
			_workOrderRouting.ActiveContext = base.ActiveContext;
			_productCollectionViaProductInventory.ActiveContext = base.ActiveContext;
			_workOrderCollectionViaWorkOrderRouting.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			LocationDAO dao = (LocationDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			LocationDAO dao = (LocationDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.LocationEntity);
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

			toReturn.Add("ProductInventory", _productInventory);
			toReturn.Add("WorkOrderRouting", _workOrderRouting);
			toReturn.Add("ProductCollectionViaProductInventory", _productCollectionViaProductInventory);
			toReturn.Add("WorkOrderCollectionViaWorkOrderRouting", _workOrderCollectionViaWorkOrderRouting);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="validator">The validator object for this LocationEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int16 locationID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(locationID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productInventory = new AW.Data.CollectionClasses.ProductInventoryCollection(new ProductInventoryEntityFactory());
			_productInventory.SetContainingEntityInfo(this, "Location");
			_alwaysFetchProductInventory = false;
			_alreadyFetchedProductInventory = false;
			_workOrderRouting = new AW.Data.CollectionClasses.WorkOrderRoutingCollection(new WorkOrderRoutingEntityFactory());
			_workOrderRouting.SetContainingEntityInfo(this, "Location");
			_alwaysFetchWorkOrderRouting = false;
			_alreadyFetchedWorkOrderRouting = false;
			_productCollectionViaProductInventory = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaProductInventory = false;
			_alreadyFetchedProductCollectionViaProductInventory = false;
			_workOrderCollectionViaWorkOrderRouting = new AW.Data.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_alwaysFetchWorkOrderCollectionViaWorkOrderRouting = false;
			_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = false;



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
			_customProperties.Add("MS_Description", @"Product inventory and manufacturing locations.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("LocationID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Location description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Standard hourly cost of the manufacturing location.");
			_fieldsCustomProperties.Add("CostRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Work capacity (in hours) of the manufacturing location.");
			_fieldsCustomProperties.Add("Availability", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="locationID">PK value for Location which data should be fetched into this Location object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 locationID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)LocationFieldIndex.LocationID].ForcedCurrentValueWrite(locationID);
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
			return DAOFactory.CreateLocationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new LocationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static LocationRelations Relations
		{
			get	{ return new LocationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductInventory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductInventory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductInventoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductInventory")[0], (int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.ProductInventoryEntity, 0, null, null, null, "ProductInventory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderRouting' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderRouting
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderRoutingCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderRouting")[0], (int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.WorkOrderRoutingEntity, 0, null, null, null, "WorkOrderRouting", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaProductInventory
		{
			get
			{
				IEntityRelation intermediateRelation = LocationEntity.Relations.ProductInventoryEntityUsingLocationID;
				intermediateRelation.SetAliases(string.Empty, "ProductInventory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductInventory"), "ProductCollectionViaProductInventory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderCollectionViaWorkOrderRouting
		{
			get
			{
				IEntityRelation intermediateRelation = LocationEntity.Relations.WorkOrderRoutingEntityUsingLocationID;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderRouting_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(), intermediateRelation,
					(int)AW.Data.EntityType.LocationEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, GetRelationsForField("WorkOrderCollectionViaWorkOrderRouting"), "WorkOrderCollectionViaWorkOrderRouting", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "LocationEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return LocationEntity.CustomProperties;}
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
			get { return LocationEntity.FieldsCustomProperties;}
		}

		/// <summary> The LocationID property of the Entity Location<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Location"."LocationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 LocationID
		{
			get { return (System.Int16)GetValue((int)LocationFieldIndex.LocationID, true); }
			set	{ SetValue((int)LocationFieldIndex.LocationID, value, true); }
		}
		/// <summary> The Name property of the Entity Location<br/><br/>
		/// 
		/// MS_Description: Location description.<br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)LocationFieldIndex.Name, true); }
			set	{ SetValue((int)LocationFieldIndex.Name, value, true); }
		}
		/// <summary> The CostRate property of the Entity Location<br/><br/>
		/// 
		/// MS_Description: Standard hourly cost of the manufacturing location.<br/></summary>
		/// <remarks>Mapped on  table field: "Location"."CostRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostRate
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.CostRate, true); }
			set	{ SetValue((int)LocationFieldIndex.CostRate, value, true); }
		}
		/// <summary> The Availability property of the Entity Location<br/><br/>
		/// 
		/// MS_Description: Work capacity (in hours) of the manufacturing location.<br/></summary>
		/// <remarks>Mapped on  table field: "Location"."Availability"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Availability
		{
			get { return (System.Decimal)GetValue((int)LocationFieldIndex.Availability, true); }
			set	{ SetValue((int)LocationFieldIndex.Availability, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Location<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Location"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)LocationFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)LocationFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductInventory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection ProductInventory
		{
			get	{ return GetMultiProductInventory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductInventory. When set to true, ProductInventory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductInventory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductInventory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductInventory
		{
			get	{ return _alwaysFetchProductInventory; }
			set	{ _alwaysFetchProductInventory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductInventory already has been fetched. Setting this property to false when ProductInventory has been fetched
		/// will clear the ProductInventory collection well. Setting this property to true while ProductInventory hasn't been fetched disables lazy loading for ProductInventory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductInventory
		{
			get { return _alreadyFetchedProductInventory;}
			set 
			{
				if(_alreadyFetchedProductInventory && !value && (_productInventory != null))
				{
					_productInventory.Clear();
				}
				_alreadyFetchedProductInventory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderRouting()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.WorkOrderRoutingCollection WorkOrderRouting
		{
			get	{ return GetMultiWorkOrderRouting(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderRouting. When set to true, WorkOrderRouting is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderRouting is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderRouting(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderRouting
		{
			get	{ return _alwaysFetchWorkOrderRouting; }
			set	{ _alwaysFetchWorkOrderRouting = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderRouting already has been fetched. Setting this property to false when WorkOrderRouting has been fetched
		/// will clear the WorkOrderRouting collection well. Setting this property to true while WorkOrderRouting hasn't been fetched disables lazy loading for WorkOrderRouting</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderRouting
		{
			get { return _alreadyFetchedWorkOrderRouting;}
			set 
			{
				if(_alreadyFetchedWorkOrderRouting && !value && (_workOrderRouting != null))
				{
					_workOrderRouting.Clear();
				}
				_alreadyFetchedWorkOrderRouting = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaProductInventory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaProductInventory
		{
			get { return GetMultiProductCollectionViaProductInventory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaProductInventory. When set to true, ProductCollectionViaProductInventory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaProductInventory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaProductInventory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaProductInventory
		{
			get	{ return _alwaysFetchProductCollectionViaProductInventory; }
			set	{ _alwaysFetchProductCollectionViaProductInventory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaProductInventory already has been fetched. Setting this property to false when ProductCollectionViaProductInventory has been fetched
		/// will clear the ProductCollectionViaProductInventory collection well. Setting this property to true while ProductCollectionViaProductInventory hasn't been fetched disables lazy loading for ProductCollectionViaProductInventory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaProductInventory
		{
			get { return _alreadyFetchedProductCollectionViaProductInventory;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaProductInventory && !value && (_productCollectionViaProductInventory != null))
				{
					_productCollectionViaProductInventory.Clear();
				}
				_alreadyFetchedProductCollectionViaProductInventory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderCollectionViaWorkOrderRouting()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.WorkOrderCollection WorkOrderCollectionViaWorkOrderRouting
		{
			get { return GetMultiWorkOrderCollectionViaWorkOrderRouting(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderCollectionViaWorkOrderRouting. When set to true, WorkOrderCollectionViaWorkOrderRouting is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderCollectionViaWorkOrderRouting is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderCollectionViaWorkOrderRouting(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderCollectionViaWorkOrderRouting
		{
			get	{ return _alwaysFetchWorkOrderCollectionViaWorkOrderRouting; }
			set	{ _alwaysFetchWorkOrderCollectionViaWorkOrderRouting = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderCollectionViaWorkOrderRouting already has been fetched. Setting this property to false when WorkOrderCollectionViaWorkOrderRouting has been fetched
		/// will clear the WorkOrderCollectionViaWorkOrderRouting collection well. Setting this property to true while WorkOrderCollectionViaWorkOrderRouting hasn't been fetched disables lazy loading for WorkOrderCollectionViaWorkOrderRouting</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderCollectionViaWorkOrderRouting
		{
			get { return _alreadyFetchedWorkOrderCollectionViaWorkOrderRouting;}
			set 
			{
				if(_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting && !value && (_workOrderCollectionViaWorkOrderRouting != null))
				{
					_workOrderCollectionViaWorkOrderRouting.Clear();
				}
				_alreadyFetchedWorkOrderCollectionViaWorkOrderRouting = value;
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
			get { return (int)AW.Data.EntityType.LocationEntity; }
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
