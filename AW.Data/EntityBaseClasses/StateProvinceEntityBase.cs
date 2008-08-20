///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:27 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Data;
using System.Xml.Serialization;

using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.ValidatorClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity base class which represents the base class for the entity 'StateProvince'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract class StateProvinceEntityBase : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.AddressCollection	_address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;

		private CountryRegionEntity _countryRegion;
		private bool	_alwaysFetchCountryRegion, _alreadyFetchedCountryRegion, _countryRegionReturnsNewIfNotFound;

		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary>Event which is thrown when StateProvinceId changes value. Databinding related.</summary>
		public event EventHandler StateProvinceIdChanged;
		/// <summary>Event which is thrown when StateProvinceCode changes value. Databinding related.</summary>
		public event EventHandler StateProvinceCodeChanged;
		/// <summary>Event which is thrown when CountryRegionCode changes value. Databinding related.</summary>
		public event EventHandler CountryRegionCodeChanged;
		/// <summary>Event which is thrown when IsOnlyStateProvinceFlag changes value. Databinding related.</summary>
		public event EventHandler IsOnlyStateProvinceFlagChanged;
		/// <summary>Event which is thrown when Name changes value. Databinding related.</summary>
		public event EventHandler NameChanged;
		/// <summary>Event which is thrown when TerritoryId changes value. Databinding related.</summary>
		public event EventHandler TerritoryIdChanged;
		/// <summary>Event which is thrown when Rowguid changes value. Databinding related.</summary>
		public event EventHandler RowguidChanged;
		/// <summary>Event which is thrown when ModifiedDate changes value. Databinding related.</summary>
		public event EventHandler ModifiedDateChanged;

		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StateProvinceEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StateProvinceEntityBase()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), CreateValidator());
		}

	
		/// <summary>CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		public StateProvinceEntityBase(System.Int32 stateProvinceId)
		{
			InitClassFetch(stateProvinceId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StateProvinceEntityBase(System.Int32 stateProvinceId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(stateProvinceId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		public StateProvinceEntityBase(System.Int32 stateProvinceId, StateProvinceValidator validator)
		{
			InitClassFetch(stateProvinceId, validator, new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StateProvinceEntityBase(System.Int32 stateProvinceId, StateProvinceValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(stateProvinceId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse, null);
		}
	

		/// <summary>CTor</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StateProvinceEntityBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse, CreateValidator());
		}

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StateProvinceEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_address = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_address", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
			if(_countryRegion!=null)
			{
				_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_countryRegionReturnsNewIfNotFound = info.GetBoolean("_countryRegionReturnsNewIfNotFound");
			_alwaysFetchCountryRegion = info.GetBoolean("_alwaysFetchCountryRegion");
			_alreadyFetchedCountryRegion = info.GetBoolean("_alreadyFetchedCountryRegion");

			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.</summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);
			_alreadyFetchedAddress = (_address.Count > 0);

			_alreadyFetchedCountryRegion = (_countryRegion != null);

		}
		
		/// <summary> Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new </param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <remarks>Do not call this routine directly, use the overloaded version in a derived class as this version doesn't construct a
		/// local transaction during recursive save, this is done in the overloaded version in a derived class.</remarks>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse || ((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType))
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				bool result = base.Save(updateRestriction, recurse);
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return result;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}
		


		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);

			info.AddValue("_countryRegion", _countryRegion);
			info.AddValue("_countryRegionReturnsNewIfNotFound", _countryRegionReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCountryRegion", _alwaysFetchCountryRegion);
			info.AddValue("_alreadyFetchedCountryRegion", _alreadyFetchedCountryRegion);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "CountryRegion":
					_alreadyFetchedCountryRegion = true;
					this.CountryRegion = (CountryRegionEntity)entity;
					break;
				case "Address":
					_alreadyFetchedAddress = true;
					if(entity!=null)
					{
						this.Address.Add((AddressEntity)entity);
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "Address":
					_address.Add(relatedEntity);
					break;

				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "CountryRegion":
					DesetupSyncCountryRegion(false);
					break;
				case "Address":
					_address.Remove(relatedEntity);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependingRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependentRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();
			if(_countryRegion!=null)
			{
				toReturn.Add(_countryRegion);
			}


			return toReturn;
		}
		
		/// <summary> Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(_address);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceId)
		{
			return FetchUsingPK(stateProvinceId, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(stateProvinceId, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 stateProvinceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(stateProvinceId, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.StateProvinceId, null, null);
		}


		/// <summary> Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.</summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		public override bool Delete(IPredicate deleteRestriction)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;
			if((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType)
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "DeleteEntity");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				OnDelete();
				IDao dao = CreateDAOInstance();
				bool wasSuccesful = dao.DeleteExisting(base.Fields, base.Transaction, deleteRestriction);
				if(wasSuccesful)
				{
					base.Delete(deleteRestriction);
				}
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return wasSuccesful;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
				OnDeleteComplete();
			}
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(StateProvinceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(StateProvinceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("StateProvinceEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}


		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddress(bool forceFetch)
		{
			return GetMultiAddress(forceFetch, _address.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAddress(forceFetch, _address.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.AddressCollection GetMultiAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_address.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address);
					}
				}
				_address.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_address.EntityFactoryToUse = entityFactoryToUse;
				}
				_address.GetMultiManyToOne(this, filter);
				_address.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress = true;
			}
			return _address;
		}

		/// <summary> Sets the collection parameters for the collection for 'Address'. These settings will be taken into account
		/// when the property Address is requested or GetMultiAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_address.SortClauses=sortClauses;
			_address.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedCountryRegion || forceFetch || _alwaysFetchCountryRegion) && !base.IsSerializing && !base.IsDeserializing )
			{

				CountryRegionEntity newEntity = new CountryRegionEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.CountryRegionCode);
				if(!_countryRegionReturnsNewIfNotFound && !fetchResult)
				{
					this.CountryRegion = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (CountryRegionEntity)base.ActiveContext.Get(newEntity);
					}
					this.CountryRegion = newEntity;
					_alreadyFetchedCountryRegion = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _countryRegion;
		}

	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the StateProvinceIdChanged event, which is thrown when StateProvinceId changes value. Databinding related.</summary>
		protected virtual void OnStateProvinceIdChanged()
		{
			if(StateProvinceIdChanged!=null)
			{
				StateProvinceIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the StateProvinceCodeChanged event, which is thrown when StateProvinceCode changes value. Databinding related.</summary>
		protected virtual void OnStateProvinceCodeChanged()
		{
			if(StateProvinceCodeChanged!=null)
			{
				StateProvinceCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CountryRegionCodeChanged event, which is thrown when CountryRegionCode changes value. Databinding related.</summary>
		protected virtual void OnCountryRegionCodeChanged()
		{
			if(CountryRegionCodeChanged!=null)
			{
				CountryRegionCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the IsOnlyStateProvinceFlagChanged event, which is thrown when IsOnlyStateProvinceFlag changes value. Databinding related.</summary>
		protected virtual void OnIsOnlyStateProvinceFlagChanged()
		{
			if(IsOnlyStateProvinceFlagChanged!=null)
			{
				IsOnlyStateProvinceFlagChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the NameChanged event, which is thrown when Name changes value. Databinding related.</summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the TerritoryIdChanged event, which is thrown when TerritoryId changes value. Databinding related.</summary>
		protected virtual void OnTerritoryIdChanged()
		{
			if(TerritoryIdChanged!=null)
			{
				TerritoryIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the RowguidChanged event, which is thrown when Rowguid changes value. Databinding related.</summary>
		protected virtual void OnRowguidChanged()
		{
			if(RowguidChanged!=null)
			{
				RowguidChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ModifiedDateChanged event, which is thrown when ModifiedDate changes value. Databinding related.</summary>
		protected virtual void OnModifiedDateChanged()
		{
			if(ModifiedDateChanged!=null)
			{
				ModifiedDateChanged(this, new EventArgs());
			}
		}

		#endregion
		
		/// <summary> Sets the field on index fieldIndex to the new value value. Marks also the fields object as dirty. </summary>
		/// <param name="fieldIndex">Index of field to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <param name="checkForRefetch">If set to true, it will check if this entity is out of sync and will refetch it first if it is. Use true in normal behavior, false for framework specific code.</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <remarks>Dereferences a related object in an 1:1/m:1 relation if the field is an FK field and responsible for the reference of that particular related object.</remarks>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the number of fields in the fields collection.</exception>
		protected override bool SetNewFieldValue(int fieldIndex, object value, bool checkForRefetch)
		{
			bool toReturn = base.SetNewFieldValue (fieldIndex, value, checkForRefetch, false);
			if(toReturn)
			{
				switch((StateProvinceFieldIndex)fieldIndex)
				{
					case StateProvinceFieldIndex.CountryRegionCode:
						DecoupleEventsCountryRegion();
						_countryRegion = null;
						_alreadyFetchedCountryRegion = false;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((StateProvinceFieldIndex)fieldIndex)
				{
					case StateProvinceFieldIndex.StateProvinceId:
						OnStateProvinceIdChanged();
						break;
					case StateProvinceFieldIndex.StateProvinceCode:
						OnStateProvinceCodeChanged();
						break;
					case StateProvinceFieldIndex.CountryRegionCode:
						OnCountryRegionCodeChanged();
						break;
					case StateProvinceFieldIndex.IsOnlyStateProvinceFlag:
						OnIsOnlyStateProvinceFlagChanged();
						break;
					case StateProvinceFieldIndex.Name:
						OnNameChanged();
						break;
					case StateProvinceFieldIndex.TerritoryId:
						OnTerritoryIdChanged();
						break;
					case StateProvinceFieldIndex.Rowguid:
						OnRowguidChanged();
						break;
					case StateProvinceFieldIndex.ModifiedDate:
						OnModifiedDateChanged();
						break;
					default:
						break;
				}
			}
			return toReturn;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			StateProvinceDAO dao = (StateProvinceDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_address.ActiveContext = base.ActiveContext;

			if(_countryRegion!=null)
			{
				_countryRegion.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			StateProvinceDAO dao = (StateProvinceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			StateProvinceDAO dao = (StateProvinceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IValidator validatorToUse)
		{
			base.Fields = CreateFields();
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = validatorToUse;

			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> A method which calls all OnFieldnameChanged methods to signal that the field has been changed
		/// to bound controls. This is required after a RollbackFields() call.</summary>
		protected override void FlagAllFieldsAsChanged()
		{
			OnStateProvinceIdChanged();
			OnStateProvinceCodeChanged();
			OnCountryRegionCodeChanged();
			OnIsOnlyStateProvinceFlagChanged();
			OnNameChanged();
			OnTerritoryIdChanged();
			OnRowguidChanged();
			OnModifiedDateChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.StateProvinceEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new StateProvinceValidator();
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this StateProvinceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 stateProvinceId, IValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(stateProvinceId, prefetchPathToUse, null);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;
			base.EntityFactoryToUse = entityFactoryToUse;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassMembers(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			_address = new AW.Data.CollectionClasses.AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_address.SetContainingEntityInfo(this, "StateProvince");
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;

			_countryRegion = null;
			_countryRegionReturnsNewIfNotFound = true;
			_alwaysFetchCountryRegion = false;
			_alreadyFetchedCountryRegion = false;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();

			Hashtable fieldHashtable = null;
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("StateProvinceId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("StateProvinceCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("IsOnlyStateProvinceFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity)
		{
			if(_countryRegion != null)
			{

				_countryRegion.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("CountryRegion", _countryRegion, StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode);
				if(signalRelatedEntity)
				{
					_countryRegion.UnsetRelatedEntity(this, "StateProvince");
				}
				SetNewFieldValue((int)StateProvinceFieldIndex.CountryRegionCode, null, false);
				_countryRegion = null;
			}
		}
		
		/// <summary> Decouples events from member _countryRegion</summary>
		private void DecoupleEventsCountryRegion()
		{
			if(_countryRegion != null)
			{

				
				_countryRegion.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("CountryRegion", _countryRegion, StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode);
			}
		}
		
		/// <summary> setups the sync logic for member _countryRegion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCountryRegion(IEntity relatedEntity)
		{
			DesetupSyncCountryRegion(true);
			if(relatedEntity!=null)
			{
				_countryRegion = (CountryRegionEntity)relatedEntity;
				_countryRegion.ActiveContext = base.ActiveContext;
				_alreadyFetchedCountryRegion = true;
				_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("CountryRegion", _countryRegion, StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode);

			}
			else
			{
				_alreadyFetchedCountryRegion = false;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 stateProvinceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)StateProvinceFieldIndex.StateProvinceId].ForcedCurrentValueWrite(stateProvinceId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse);
				bool fetchResult = false;
				if(base.Fields.State == EntityState.Fetched)
				{
					base.IsNew = false;
					fetchResult = true;
					if(contextToUse!=null)
					{
						base.ActiveContext = contextToUse;
						IEntity dummy = contextToUse.Get(this);
					}
				}
				return fetchResult;
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
		protected override IEntityFactory CreateEntityFactoryInstance()
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
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					StateProvinceEntity.Relations.AddressEntityUsingStateProvinceId, 
					(int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address", RelationType.OneToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegion
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(),
					StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode, 
					(int)AW.Data.EntityType.StateProvinceEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, null, "CountryRegion", RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return StateProvinceEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return StateProvinceEntity.FieldsCustomProperties;}
		}

		/// <summary> The StateProvinceId property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.StateProvinceId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.StateProvinceId, value); }
		}
		/// <summary> The StateProvinceCode property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String StateProvinceCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.StateProvinceCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.StateProvinceCode, value); }
		}
		/// <summary> The CountryRegionCode property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.CountryRegionCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.CountryRegionCode, value); }
		}
		/// <summary> The IsOnlyStateProvinceFlag property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."IsOnlyStateProvinceFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsOnlyStateProvinceFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, value); }
		}
		/// <summary> The Name property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.Name);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.Name, value); }
		}
		/// <summary> The TerritoryId property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 TerritoryId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.TerritoryId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.TerritoryId, value); }
		}
		/// <summary> The Rowguid property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Guid));
				}
				return (System.Guid)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.Rowguid, value); }
		}
		/// <summary> The ModifiedDate property of the Entity StateProvince<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "StateProvince"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StateProvinceFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)StateProvinceFieldIndex.ModifiedDate, value); }
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection Address
		{
			get	{ return GetMultiAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get	{ return _alwaysFetchAddress; }
			set	{ _alwaysFetchAddress = value; }	
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
							_countryRegion.UnsetRelatedEntity(this, "StateProvince");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "StateProvince");
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
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CountryRegion is not found
		/// in the database. When set to true, CountryRegion will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CountryRegionReturnsNewIfNotFound
		{
			get	{ return _countryRegionReturnsNewIfNotFound; }
			set { _countryRegionReturnsNewIfNotFound = value; }	
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
		
		/// <summary>Returns the EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.StateProvinceEntity; }
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
