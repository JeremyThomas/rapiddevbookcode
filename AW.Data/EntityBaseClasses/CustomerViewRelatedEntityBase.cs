///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:29 PM
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
	/// <summary>Entity base class which represents the base class for the entity 'CustomerViewRelated'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract class CustomerViewRelatedEntityBase : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;



		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary>Event which is thrown when CustomerId changes value. Databinding related.</summary>
		public event EventHandler CustomerIdChanged;
		/// <summary>Event which is thrown when Title changes value. Databinding related.</summary>
		public event EventHandler TitleChanged;
		/// <summary>Event which is thrown when FirstName changes value. Databinding related.</summary>
		public event EventHandler FirstNameChanged;
		/// <summary>Event which is thrown when MiddleName changes value. Databinding related.</summary>
		public event EventHandler MiddleNameChanged;
		/// <summary>Event which is thrown when LastName changes value. Databinding related.</summary>
		public event EventHandler LastNameChanged;
		/// <summary>Event which is thrown when Suffix changes value. Databinding related.</summary>
		public event EventHandler SuffixChanged;
		/// <summary>Event which is thrown when Phone changes value. Databinding related.</summary>
		public event EventHandler PhoneChanged;
		/// <summary>Event which is thrown when EmailAddress changes value. Databinding related.</summary>
		public event EventHandler EmailAddressChanged;
		/// <summary>Event which is thrown when EmailPromotion changes value. Databinding related.</summary>
		public event EventHandler EmailPromotionChanged;
		/// <summary>Event which is thrown when AddressType changes value. Databinding related.</summary>
		public event EventHandler AddressTypeChanged;
		/// <summary>Event which is thrown when AddressLine1 changes value. Databinding related.</summary>
		public event EventHandler AddressLine1Changed;
		/// <summary>Event which is thrown when AddressLine2 changes value. Databinding related.</summary>
		public event EventHandler AddressLine2Changed;
		/// <summary>Event which is thrown when City changes value. Databinding related.</summary>
		public event EventHandler CityChanged;
		/// <summary>Event which is thrown when StateProvinceName changes value. Databinding related.</summary>
		public event EventHandler StateProvinceNameChanged;
		/// <summary>Event which is thrown when PostalCode changes value. Databinding related.</summary>
		public event EventHandler PostalCodeChanged;
		/// <summary>Event which is thrown when CountryRegionName changes value. Databinding related.</summary>
		public event EventHandler CountryRegionNameChanged;
		/// <summary>Event which is thrown when Demographics changes value. Databinding related.</summary>
		public event EventHandler DemographicsChanged;

		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerViewRelatedEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerViewRelatedEntityBase()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), CreateValidator());
		}

	
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		public CustomerViewRelatedEntityBase(System.Int32 customerId)
		{
			InitClassFetch(customerId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerViewRelatedEntityBase(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(customerId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="validator">The custom validator object for this CustomerViewRelatedEntity</param>
		public CustomerViewRelatedEntityBase(System.Int32 customerId, CustomerViewRelatedValidator validator)
		{
			InitClassFetch(customerId, validator, new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="validator">The custom validator object for this CustomerViewRelatedEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerViewRelatedEntityBase(System.Int32 customerId, CustomerViewRelatedValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(customerId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse, null);
		}
	

		/// <summary>CTor</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerViewRelatedEntityBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse, CreateValidator());
		}

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerViewRelatedEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeader = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");



			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.</summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);



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
			info.AddValue("_salesOrderHeader", _salesOrderHeader);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);



			
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

				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesOrderHeader.Add((SalesOrderHeaderEntity)entity);
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

				case "SalesOrderHeader":
					_salesOrderHeader.Add(relatedEntity);
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

				case "SalesOrderHeader":
					_salesOrderHeader.Remove(relatedEntity);
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



			return toReturn;
		}
		
		/// <summary> Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(_salesOrderHeader);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId)
		{
			return FetchUsingPK(customerId, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, null, null);
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
		public bool TestOriginalFieldValueForNull(CustomerViewRelatedFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CustomerViewRelatedFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("CustomerViewRelatedEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}


		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch)
		{
			return GetMultiSalesOrderHeader(forceFetch, _salesOrderHeader.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeader(forceFetch, _salesOrderHeader.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeader(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, this, filter);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeader'. These settings will be taken into account
		/// when the property SalesOrderHeader is requested or GetMultiSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeader.SortClauses=sortClauses;
			_salesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the CustomerIdChanged event, which is thrown when CustomerId changes value. Databinding related.</summary>
		protected virtual void OnCustomerIdChanged()
		{
			if(CustomerIdChanged!=null)
			{
				CustomerIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the TitleChanged event, which is thrown when Title changes value. Databinding related.</summary>
		protected virtual void OnTitleChanged()
		{
			if(TitleChanged!=null)
			{
				TitleChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the FirstNameChanged event, which is thrown when FirstName changes value. Databinding related.</summary>
		protected virtual void OnFirstNameChanged()
		{
			if(FirstNameChanged!=null)
			{
				FirstNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the MiddleNameChanged event, which is thrown when MiddleName changes value. Databinding related.</summary>
		protected virtual void OnMiddleNameChanged()
		{
			if(MiddleNameChanged!=null)
			{
				MiddleNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the LastNameChanged event, which is thrown when LastName changes value. Databinding related.</summary>
		protected virtual void OnLastNameChanged()
		{
			if(LastNameChanged!=null)
			{
				LastNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SuffixChanged event, which is thrown when Suffix changes value. Databinding related.</summary>
		protected virtual void OnSuffixChanged()
		{
			if(SuffixChanged!=null)
			{
				SuffixChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PhoneChanged event, which is thrown when Phone changes value. Databinding related.</summary>
		protected virtual void OnPhoneChanged()
		{
			if(PhoneChanged!=null)
			{
				PhoneChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the EmailAddressChanged event, which is thrown when EmailAddress changes value. Databinding related.</summary>
		protected virtual void OnEmailAddressChanged()
		{
			if(EmailAddressChanged!=null)
			{
				EmailAddressChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the EmailPromotionChanged event, which is thrown when EmailPromotion changes value. Databinding related.</summary>
		protected virtual void OnEmailPromotionChanged()
		{
			if(EmailPromotionChanged!=null)
			{
				EmailPromotionChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the AddressTypeChanged event, which is thrown when AddressType changes value. Databinding related.</summary>
		protected virtual void OnAddressTypeChanged()
		{
			if(AddressTypeChanged!=null)
			{
				AddressTypeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the AddressLine1Changed event, which is thrown when AddressLine1 changes value. Databinding related.</summary>
		protected virtual void OnAddressLine1Changed()
		{
			if(AddressLine1Changed!=null)
			{
				AddressLine1Changed(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the AddressLine2Changed event, which is thrown when AddressLine2 changes value. Databinding related.</summary>
		protected virtual void OnAddressLine2Changed()
		{
			if(AddressLine2Changed!=null)
			{
				AddressLine2Changed(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CityChanged event, which is thrown when City changes value. Databinding related.</summary>
		protected virtual void OnCityChanged()
		{
			if(CityChanged!=null)
			{
				CityChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the StateProvinceNameChanged event, which is thrown when StateProvinceName changes value. Databinding related.</summary>
		protected virtual void OnStateProvinceNameChanged()
		{
			if(StateProvinceNameChanged!=null)
			{
				StateProvinceNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PostalCodeChanged event, which is thrown when PostalCode changes value. Databinding related.</summary>
		protected virtual void OnPostalCodeChanged()
		{
			if(PostalCodeChanged!=null)
			{
				PostalCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CountryRegionNameChanged event, which is thrown when CountryRegionName changes value. Databinding related.</summary>
		protected virtual void OnCountryRegionNameChanged()
		{
			if(CountryRegionNameChanged!=null)
			{
				CountryRegionNameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DemographicsChanged event, which is thrown when Demographics changes value. Databinding related.</summary>
		protected virtual void OnDemographicsChanged()
		{
			if(DemographicsChanged!=null)
			{
				DemographicsChanged(this, new EventArgs());
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
				switch((CustomerViewRelatedFieldIndex)fieldIndex)
				{
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((CustomerViewRelatedFieldIndex)fieldIndex)
				{
					case CustomerViewRelatedFieldIndex.CustomerId:
						OnCustomerIdChanged();
						break;
					case CustomerViewRelatedFieldIndex.Title:
						OnTitleChanged();
						break;
					case CustomerViewRelatedFieldIndex.FirstName:
						OnFirstNameChanged();
						break;
					case CustomerViewRelatedFieldIndex.MiddleName:
						OnMiddleNameChanged();
						break;
					case CustomerViewRelatedFieldIndex.LastName:
						OnLastNameChanged();
						break;
					case CustomerViewRelatedFieldIndex.Suffix:
						OnSuffixChanged();
						break;
					case CustomerViewRelatedFieldIndex.Phone:
						OnPhoneChanged();
						break;
					case CustomerViewRelatedFieldIndex.EmailAddress:
						OnEmailAddressChanged();
						break;
					case CustomerViewRelatedFieldIndex.EmailPromotion:
						OnEmailPromotionChanged();
						break;
					case CustomerViewRelatedFieldIndex.AddressType:
						OnAddressTypeChanged();
						break;
					case CustomerViewRelatedFieldIndex.AddressLine1:
						OnAddressLine1Changed();
						break;
					case CustomerViewRelatedFieldIndex.AddressLine2:
						OnAddressLine2Changed();
						break;
					case CustomerViewRelatedFieldIndex.City:
						OnCityChanged();
						break;
					case CustomerViewRelatedFieldIndex.StateProvinceName:
						OnStateProvinceNameChanged();
						break;
					case CustomerViewRelatedFieldIndex.PostalCode:
						OnPostalCodeChanged();
						break;
					case CustomerViewRelatedFieldIndex.CountryRegionName:
						OnCountryRegionNameChanged();
						break;
					case CustomerViewRelatedFieldIndex.Demographics:
						OnDemographicsChanged();
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
			CustomerViewRelatedDAO dao = (CustomerViewRelatedDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderHeader.ActiveContext = base.ActiveContext;




		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CustomerViewRelatedDAO dao = (CustomerViewRelatedDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CustomerViewRelatedDAO dao = (CustomerViewRelatedDAO)CreateDAOInstance();
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
			OnCustomerIdChanged();
			OnTitleChanged();
			OnFirstNameChanged();
			OnMiddleNameChanged();
			OnLastNameChanged();
			OnSuffixChanged();
			OnPhoneChanged();
			OnEmailAddressChanged();
			OnEmailPromotionChanged();
			OnAddressTypeChanged();
			OnAddressLine1Changed();
			OnAddressLine2Changed();
			OnCityChanged();
			OnStateProvinceNameChanged();
			OnPostalCodeChanged();
			OnCountryRegionNameChanged();
			OnDemographicsChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerViewRelatedEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new CustomerViewRelatedValidator();
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this CustomerViewRelatedEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 customerId, IValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(customerId, prefetchPathToUse, null);
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
			_salesOrderHeader = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "CustomerView_");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;



			
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

			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("AddressType", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("StateProvinceName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CountryRegionName", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CustomerViewRelatedFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
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
			return DAOFactory.CreateCustomerViewRelatedDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactoryInstance()
		{
			return new CustomerViewRelatedEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerViewRelatedRelations Relations
		{
			get	{ return new CustomerViewRelatedRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
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
					CustomerViewRelatedEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, 
					(int)AW.Data.EntityType.CustomerViewRelatedEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", RelationType.OneToMany);
			}
		}




		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return CustomerViewRelatedEntity.CustomProperties;}
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
			get { return CustomerViewRelatedEntity.FieldsCustomProperties;}
		}

		/// <summary> The CustomerId property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."CustomerID"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.CustomerId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.CustomerId, value); }
		}
		/// <summary> The Title property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Title"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.Title);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.Title, value); }
		}
		/// <summary> The FirstName property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."FirstName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.FirstName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.FirstName, value); }
		}
		/// <summary> The MiddleName property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."MiddleName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MiddleName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.MiddleName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.MiddleName, value); }
		}
		/// <summary> The LastName property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."LastName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.LastName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.LastName, value); }
		}
		/// <summary> The Suffix property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Suffix"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Suffix
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.Suffix);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.Suffix, value); }
		}
		/// <summary> The Phone property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Phone"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Phone
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.Phone);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.Phone, value); }
		}
		/// <summary> The EmailAddress property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."EmailAddress"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.EmailAddress);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.EmailAddress, value); }
		}
		/// <summary> The EmailPromotion property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."EmailPromotion"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmailPromotion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.EmailPromotion);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.EmailPromotion, value); }
		}
		/// <summary> The AddressType property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressType"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressType
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.AddressType);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.AddressType, value); }
		}
		/// <summary> The AddressLine1 property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressLine1"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.AddressLine1);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.AddressLine1, value); }
		}
		/// <summary> The AddressLine2 property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressLine2"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.AddressLine2);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.AddressLine2, value); }
		}
		/// <summary> The City property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."City"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.City);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.City, value); }
		}
		/// <summary> The StateProvinceName property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."StateProvinceName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String StateProvinceName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.StateProvinceName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.StateProvinceName, value); }
		}
		/// <summary> The PostalCode property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."PostalCode"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.PostalCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.PostalCode, value); }
		}
		/// <summary> The CountryRegionName property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."CountryRegionName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.CountryRegionName);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.CountryRegionName, value); }
		}
		/// <summary> The Demographics property of the Entity CustomerViewRelated<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Demographics"<br/>
		/// View field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Demographics
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerViewRelatedFieldIndex.Demographics);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)CustomerViewRelatedFieldIndex.Demographics, value); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeader
		{
			get	{ return GetMultiSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesOrderHeader; }
			set	{ _alwaysFetchSalesOrderHeader = value; }	
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
			get { return (int)AW.Data.EntityType.CustomerViewRelatedEntity; }
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
