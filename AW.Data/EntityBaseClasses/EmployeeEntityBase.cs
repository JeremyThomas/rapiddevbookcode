///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:28 PM
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
	/// <summary>Entity base class which represents the base class for the entity 'Employee'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract class EmployeeEntityBase : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeCollection	_manages;
		private bool	_alwaysFetchManages, _alreadyFetchedManages;
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddress;
		private bool	_alwaysFetchEmployeeAddress, _alreadyFetchedEmployeeAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaEmployee;
		private bool	_alwaysFetchContactCollectionViaEmployee, _alreadyFetchedContactCollectionViaEmployee;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaEmployeeAddress;
		private bool	_alwaysFetchAddressCollectionViaEmployeeAddress, _alreadyFetchedAddressCollectionViaEmployeeAddress;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private EmployeeEntity _manager;
		private bool	_alwaysFetchManager, _alreadyFetchedManager, _managerReturnsNewIfNotFound;

		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary>Event which is thrown when EmployeeId changes value. Databinding related.</summary>
		public event EventHandler EmployeeIdChanged;
		/// <summary>Event which is thrown when NationalIdnumber changes value. Databinding related.</summary>
		public event EventHandler NationalIdnumberChanged;
		/// <summary>Event which is thrown when ContactId changes value. Databinding related.</summary>
		public event EventHandler ContactIdChanged;
		/// <summary>Event which is thrown when LoginId changes value. Databinding related.</summary>
		public event EventHandler LoginIdChanged;
		/// <summary>Event which is thrown when ManagerId changes value. Databinding related.</summary>
		public event EventHandler ManagerIdChanged;
		/// <summary>Event which is thrown when Title changes value. Databinding related.</summary>
		public event EventHandler TitleChanged;
		/// <summary>Event which is thrown when BirthDate changes value. Databinding related.</summary>
		public event EventHandler BirthDateChanged;
		/// <summary>Event which is thrown when MaritalStatus changes value. Databinding related.</summary>
		public event EventHandler MaritalStatusChanged;
		/// <summary>Event which is thrown when Gender changes value. Databinding related.</summary>
		public event EventHandler GenderChanged;
		/// <summary>Event which is thrown when HireDate changes value. Databinding related.</summary>
		public event EventHandler HireDateChanged;
		/// <summary>Event which is thrown when SalariedFlag changes value. Databinding related.</summary>
		public event EventHandler SalariedFlagChanged;
		/// <summary>Event which is thrown when VacationHours changes value. Databinding related.</summary>
		public event EventHandler VacationHoursChanged;
		/// <summary>Event which is thrown when SickLeaveHours changes value. Databinding related.</summary>
		public event EventHandler SickLeaveHoursChanged;
		/// <summary>Event which is thrown when CurrentFlag changes value. Databinding related.</summary>
		public event EventHandler CurrentFlagChanged;
		/// <summary>Event which is thrown when Rowguid changes value. Databinding related.</summary>
		public event EventHandler RowguidChanged;
		/// <summary>Event which is thrown when ModifiedDate changes value. Databinding related.</summary>
		public event EventHandler ModifiedDateChanged;

		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntityBase()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), CreateValidator());
		}

	
		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntityBase(System.Int32 employeeId)
		{
			InitClassFetch(employeeId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntityBase(System.Int32 employeeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(employeeId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntityBase(System.Int32 employeeId, EmployeeValidator validator)
		{
			InitClassFetch(employeeId, validator, new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntityBase(System.Int32 employeeId, EmployeeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(employeeId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse, null);
		}
	

		/// <summary>CTor</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntityBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse, CreateValidator());
		}

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_manages = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_manages", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchManages = info.GetBoolean("_alwaysFetchManages");
			_alreadyFetchedManages = info.GetBoolean("_alreadyFetchedManages");
			_employeeAddress = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddress", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddress = info.GetBoolean("_alwaysFetchEmployeeAddress");
			_alreadyFetchedEmployeeAddress = info.GetBoolean("_alreadyFetchedEmployeeAddress");
			_contactCollectionViaEmployee = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaEmployee", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaEmployee = info.GetBoolean("_alwaysFetchContactCollectionViaEmployee");
			_alreadyFetchedContactCollectionViaEmployee = info.GetBoolean("_alreadyFetchedContactCollectionViaEmployee");
			_addressCollectionViaEmployeeAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaEmployeeAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaEmployeeAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaEmployeeAddress");
			_alreadyFetchedAddressCollectionViaEmployeeAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaEmployeeAddress");
			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
			_manager = (EmployeeEntity)info.GetValue("_manager", typeof(EmployeeEntity));
			if(_manager!=null)
			{
				_manager.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_managerReturnsNewIfNotFound = info.GetBoolean("_managerReturnsNewIfNotFound");
			_alwaysFetchManager = info.GetBoolean("_alwaysFetchManager");
			_alreadyFetchedManager = info.GetBoolean("_alreadyFetchedManager");

			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.</summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);
			_alreadyFetchedManages = (_manages.Count > 0);
			_alreadyFetchedEmployeeAddress = (_employeeAddress.Count > 0);
			_alreadyFetchedContactCollectionViaEmployee = (_contactCollectionViaEmployee.Count > 0);
			_alreadyFetchedAddressCollectionViaEmployeeAddress = (_addressCollectionViaEmployeeAddress.Count > 0);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedManager = (_manager != null);

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
			info.AddValue("_manages", _manages);
			info.AddValue("_alwaysFetchManages", _alwaysFetchManages);
			info.AddValue("_alreadyFetchedManages", _alreadyFetchedManages);
			info.AddValue("_employeeAddress", _employeeAddress);
			info.AddValue("_alwaysFetchEmployeeAddress", _alwaysFetchEmployeeAddress);
			info.AddValue("_alreadyFetchedEmployeeAddress", _alreadyFetchedEmployeeAddress);
			info.AddValue("_contactCollectionViaEmployee", _contactCollectionViaEmployee);
			info.AddValue("_alwaysFetchContactCollectionViaEmployee", _alwaysFetchContactCollectionViaEmployee);
			info.AddValue("_alreadyFetchedContactCollectionViaEmployee", _alreadyFetchedContactCollectionViaEmployee);
			info.AddValue("_addressCollectionViaEmployeeAddress", _addressCollectionViaEmployeeAddress);
			info.AddValue("_alwaysFetchAddressCollectionViaEmployeeAddress", _alwaysFetchAddressCollectionViaEmployeeAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaEmployeeAddress", _alreadyFetchedAddressCollectionViaEmployeeAddress);
			info.AddValue("_contact", _contact);
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_manager", _manager);
			info.AddValue("_managerReturnsNewIfNotFound", _managerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchManager", _alwaysFetchManager);
			info.AddValue("_alreadyFetchedManager", _alreadyFetchedManager);

			
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
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
					break;
				case "Manager":
					_alreadyFetchedManager = true;
					this.Manager = (EmployeeEntity)entity;
					break;
				case "Manages":
					_alreadyFetchedManages = true;
					if(entity!=null)
					{
						this.Manages.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeAddress":
					_alreadyFetchedEmployeeAddress = true;
					if(entity!=null)
					{
						this.EmployeeAddress.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "ContactCollectionViaEmployee":
					_alreadyFetchedContactCollectionViaEmployee = true;
					if(entity!=null)
					{
						this.ContactCollectionViaEmployee.Add((ContactEntity)entity);
					}
					break;
				case "AddressCollectionViaEmployeeAddress":
					_alreadyFetchedAddressCollectionViaEmployeeAddress = true;
					if(entity!=null)
					{
						this.AddressCollectionViaEmployeeAddress.Add((AddressEntity)entity);
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
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "Manager":
					SetupSyncManager(relatedEntity);
					break;
				case "Manages":
					_manages.Add(relatedEntity);
					break;
				case "EmployeeAddress":
					_employeeAddress.Add(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false);
					break;
				case "Manager":
					DesetupSyncManager(false);
					break;
				case "Manages":
					_manages.Remove(relatedEntity);
					break;
				case "EmployeeAddress":
					_employeeAddress.Remove(relatedEntity);
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
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_manager!=null)
			{
				toReturn.Add(_manager);
			}


			return toReturn;
		}
		
		/// <summary> Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(_manages);
			toReturn.Add(_employeeAddress);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId)
		{
			return FetchUsingPK(employeeId, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(employeeId, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(employeeId, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeId, null, null);
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
		public bool TestOriginalFieldValueForNull(EmployeeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(EmployeeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("EmployeeEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}


		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiManages(bool forceFetch)
		{
			return GetMultiManages(forceFetch, _manages.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiManages(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiManages(forceFetch, _manages.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiManages(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiManages(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeCollection GetMultiManages(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedManages || forceFetch || _alwaysFetchManages) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_manages.ParticipatesInTransaction)
					{
						base.Transaction.Add(_manages);
					}
				}
				_manages.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_manages.EntityFactoryToUse = entityFactoryToUse;
				}
				_manages.GetMultiManyToOne(null, this, filter);
				_manages.SuppressClearInGetMulti=false;
				_alreadyFetchedManages = true;
			}
			return _manages;
		}

		/// <summary> Sets the collection parameters for the collection for 'Manages'. These settings will be taken into account
		/// when the property Manages is requested or GetMultiManages is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersManages(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_manages.SortClauses=sortClauses;
			_manages.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch)
		{
			return GetMultiEmployeeAddress(forceFetch, _employeeAddress.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeAddress(forceFetch, _employeeAddress.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddress);
					}
				}
				_employeeAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeAddress.GetMultiManyToOne(null, this, filter);
				_employeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddress = true;
			}
			return _employeeAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeAddress'. These settings will be taken into account
		/// when the property EmployeeAddress is requested or GetMultiEmployeeAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeAddress.SortClauses=sortClauses;
			_employeeAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaEmployee(bool forceFetch)
		{
			return GetMultiContactCollectionViaEmployee(forceFetch, _contactCollectionViaEmployee.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaEmployee || forceFetch || _alwaysFetchContactCollectionViaEmployee) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaEmployee);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerId, "Employee_");
				relations.Add(EmployeeEntity.Relations.ContactEntityUsingContactId, "Employee_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeId), ComparisonOperator.Equal, this.EmployeeId));
				_contactCollectionViaEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaEmployee.GetMulti(filter, relations);
				_contactCollectionViaEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaEmployee = true;
			}
			return _contactCollectionViaEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaEmployee'. These settings will be taken into account
		/// when the property ContactCollectionViaEmployee is requested or GetMultiContactCollectionViaEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaEmployee.SortClauses=sortClauses;
			_contactCollectionViaEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaEmployeeAddress(bool forceFetch)
		{
			return GetMultiAddressCollectionViaEmployeeAddress(forceFetch, _addressCollectionViaEmployeeAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaEmployeeAddress || forceFetch || _alwaysFetchAddressCollectionViaEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaEmployeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaEmployeeAddress);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeId, "EmployeeAddress_");
				relations.Add(EmployeeAddressEntity.Relations.AddressEntityUsingAddressId, "EmployeeAddress_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeId), ComparisonOperator.Equal, this.EmployeeId));
				_addressCollectionViaEmployeeAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaEmployeeAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaEmployeeAddress.GetMulti(filter, relations);
				_addressCollectionViaEmployeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaEmployeeAddress = true;
			}
			return _addressCollectionViaEmployeeAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaEmployeeAddress'. These settings will be taken into account
		/// when the property AddressCollectionViaEmployeeAddress is requested or GetMultiAddressCollectionViaEmployeeAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaEmployeeAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaEmployeeAddress.SortClauses=sortClauses;
			_addressCollectionViaEmployeeAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public ContactEntity GetSingleContact()
		{
			return GetSingleContact(false);
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{

				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.ContactId);
				if(!_contactReturnsNewIfNotFound && !fetchResult)
				{
					this.Contact = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ContactEntity)base.ActiveContext.Get(newEntity);
					}
					this.Contact = newEntity;
					_alreadyFetchedContact = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _contact;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleManager()
		{
			return GetSingleManager(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleManager(bool forceFetch)
		{
 			if( ( !_alreadyFetchedManager || forceFetch || _alwaysFetchManager) && !base.IsSerializing && !base.IsDeserializing )
			{

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.ManagerId);
				if(!_managerReturnsNewIfNotFound && !fetchResult)
				{
					this.Manager = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Manager = newEntity;
					_alreadyFetchedManager = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _manager;
		}

	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the EmployeeIdChanged event, which is thrown when EmployeeId changes value. Databinding related.</summary>
		protected virtual void OnEmployeeIdChanged()
		{
			if(EmployeeIdChanged!=null)
			{
				EmployeeIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the NationalIdnumberChanged event, which is thrown when NationalIdnumber changes value. Databinding related.</summary>
		protected virtual void OnNationalIdnumberChanged()
		{
			if(NationalIdnumberChanged!=null)
			{
				NationalIdnumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ContactIdChanged event, which is thrown when ContactId changes value. Databinding related.</summary>
		protected virtual void OnContactIdChanged()
		{
			if(ContactIdChanged!=null)
			{
				ContactIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the LoginIdChanged event, which is thrown when LoginId changes value. Databinding related.</summary>
		protected virtual void OnLoginIdChanged()
		{
			if(LoginIdChanged!=null)
			{
				LoginIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ManagerIdChanged event, which is thrown when ManagerId changes value. Databinding related.</summary>
		protected virtual void OnManagerIdChanged()
		{
			if(ManagerIdChanged!=null)
			{
				ManagerIdChanged(this, new EventArgs());
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

		/// <summary> Event thrower for the BirthDateChanged event, which is thrown when BirthDate changes value. Databinding related.</summary>
		protected virtual void OnBirthDateChanged()
		{
			if(BirthDateChanged!=null)
			{
				BirthDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the MaritalStatusChanged event, which is thrown when MaritalStatus changes value. Databinding related.</summary>
		protected virtual void OnMaritalStatusChanged()
		{
			if(MaritalStatusChanged!=null)
			{
				MaritalStatusChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the GenderChanged event, which is thrown when Gender changes value. Databinding related.</summary>
		protected virtual void OnGenderChanged()
		{
			if(GenderChanged!=null)
			{
				GenderChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the HireDateChanged event, which is thrown when HireDate changes value. Databinding related.</summary>
		protected virtual void OnHireDateChanged()
		{
			if(HireDateChanged!=null)
			{
				HireDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SalariedFlagChanged event, which is thrown when SalariedFlag changes value. Databinding related.</summary>
		protected virtual void OnSalariedFlagChanged()
		{
			if(SalariedFlagChanged!=null)
			{
				SalariedFlagChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the VacationHoursChanged event, which is thrown when VacationHours changes value. Databinding related.</summary>
		protected virtual void OnVacationHoursChanged()
		{
			if(VacationHoursChanged!=null)
			{
				VacationHoursChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SickLeaveHoursChanged event, which is thrown when SickLeaveHours changes value. Databinding related.</summary>
		protected virtual void OnSickLeaveHoursChanged()
		{
			if(SickLeaveHoursChanged!=null)
			{
				SickLeaveHoursChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CurrentFlagChanged event, which is thrown when CurrentFlag changes value. Databinding related.</summary>
		protected virtual void OnCurrentFlagChanged()
		{
			if(CurrentFlagChanged!=null)
			{
				CurrentFlagChanged(this, new EventArgs());
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
				switch((EmployeeFieldIndex)fieldIndex)
				{
					case EmployeeFieldIndex.ContactId:
						DecoupleEventsContact();
						_contact = null;
						_alreadyFetchedContact = false;
						break;
					case EmployeeFieldIndex.ManagerId:
						DecoupleEventsManager();
						_manager = null;
						_alreadyFetchedManager = false;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((EmployeeFieldIndex)fieldIndex)
				{
					case EmployeeFieldIndex.EmployeeId:
						OnEmployeeIdChanged();
						break;
					case EmployeeFieldIndex.NationalIdnumber:
						OnNationalIdnumberChanged();
						break;
					case EmployeeFieldIndex.ContactId:
						OnContactIdChanged();
						break;
					case EmployeeFieldIndex.LoginId:
						OnLoginIdChanged();
						break;
					case EmployeeFieldIndex.ManagerId:
						OnManagerIdChanged();
						break;
					case EmployeeFieldIndex.Title:
						OnTitleChanged();
						break;
					case EmployeeFieldIndex.BirthDate:
						OnBirthDateChanged();
						break;
					case EmployeeFieldIndex.MaritalStatus:
						OnMaritalStatusChanged();
						break;
					case EmployeeFieldIndex.Gender:
						OnGenderChanged();
						break;
					case EmployeeFieldIndex.HireDate:
						OnHireDateChanged();
						break;
					case EmployeeFieldIndex.SalariedFlag:
						OnSalariedFlagChanged();
						break;
					case EmployeeFieldIndex.VacationHours:
						OnVacationHoursChanged();
						break;
					case EmployeeFieldIndex.SickLeaveHours:
						OnSickLeaveHoursChanged();
						break;
					case EmployeeFieldIndex.CurrentFlag:
						OnCurrentFlagChanged();
						break;
					case EmployeeFieldIndex.Rowguid:
						OnRowguidChanged();
						break;
					case EmployeeFieldIndex.ModifiedDate:
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
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_manages.ActiveContext = base.ActiveContext;
			_employeeAddress.ActiveContext = base.ActiveContext;
			_contactCollectionViaEmployee.ActiveContext = base.ActiveContext;
			_addressCollectionViaEmployeeAddress.ActiveContext = base.ActiveContext;
			if(_contact!=null)
			{
				_contact.ActiveContext = base.ActiveContext;
			}
			if(_manager!=null)
			{
				_manager.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
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
			OnEmployeeIdChanged();
			OnNationalIdnumberChanged();
			OnContactIdChanged();
			OnLoginIdChanged();
			OnManagerIdChanged();
			OnTitleChanged();
			OnBirthDateChanged();
			OnMaritalStatusChanged();
			OnGenderChanged();
			OnHireDateChanged();
			OnSalariedFlagChanged();
			OnVacationHoursChanged();
			OnSickLeaveHoursChanged();
			OnCurrentFlagChanged();
			OnRowguidChanged();
			OnModifiedDateChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.EmployeeEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new EmployeeValidator();
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 employeeId, IValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(employeeId, prefetchPathToUse, null);
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
			_manages = new AW.Data.CollectionClasses.EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_manages.SetContainingEntityInfo(this, "Manager");
			_alwaysFetchManages = false;
			_alreadyFetchedManages = false;
			_employeeAddress = new AW.Data.CollectionClasses.EmployeeAddressCollection(propertyDescriptorFactoryToUse, new EmployeeAddressEntityFactory());
			_employeeAddress.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeeAddress = false;
			_alreadyFetchedEmployeeAddress = false;
			_contactCollectionViaEmployee = new AW.Data.CollectionClasses.ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContactCollectionViaEmployee = false;
			_alreadyFetchedContactCollectionViaEmployee = false;
			_addressCollectionViaEmployeeAddress = new AW.Data.CollectionClasses.AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaEmployeeAddress = false;
			_alreadyFetchedAddressCollectionViaEmployeeAddress = false;
			_contact = null;
			_contactReturnsNewIfNotFound = true;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_manager = null;
			_managerReturnsNewIfNotFound = true;
			_alwaysFetchManager = false;
			_alreadyFetchedManager = false;

			
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

			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("NationalIdnumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("LoginId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ManagerId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("MaritalStatus", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SalariedFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("VacationHours", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SickLeaveHours", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CurrentFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncContact(bool signalRelatedEntity)
		{
			if(_contact != null)
			{

				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Contact", _contact, EmployeeEntity.Relations.ContactEntityUsingContactId);
				if(signalRelatedEntity)
				{
					_contact.UnsetRelatedEntity(this, "Employee");
				}
				SetNewFieldValue((int)EmployeeFieldIndex.ContactId, null, false);
				_contact = null;
			}
		}
		
		/// <summary> Decouples events from member _contact</summary>
		private void DecoupleEventsContact()
		{
			if(_contact != null)
			{

				
				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Contact", _contact, EmployeeEntity.Relations.ContactEntityUsingContactId);
			}
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			DesetupSyncContact(true);
			if(relatedEntity!=null)
			{
				_contact = (ContactEntity)relatedEntity;
				_contact.ActiveContext = base.ActiveContext;
				_alreadyFetchedContact = true;
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Contact", _contact, EmployeeEntity.Relations.ContactEntityUsingContactId);

			}
			else
			{
				_alreadyFetchedContact = false;
			}
		}

		/// <summary> Removes the sync logic for member _manager</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncManager(bool signalRelatedEntity)
		{
			if(_manager != null)
			{

				_manager.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Manager", _manager, EmployeeEntity.Relations.EmployeeEntityUsingManagerId);
				if(signalRelatedEntity)
				{
					_manager.UnsetRelatedEntity(this, "Manages");
				}
				SetNewFieldValue((int)EmployeeFieldIndex.ManagerId, null, false);
				_manager = null;
			}
		}
		
		/// <summary> Decouples events from member _manager</summary>
		private void DecoupleEventsManager()
		{
			if(_manager != null)
			{

				
				_manager.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Manager", _manager, EmployeeEntity.Relations.EmployeeEntityUsingManagerId);
			}
		}
		
		/// <summary> setups the sync logic for member _manager</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncManager(IEntity relatedEntity)
		{
			DesetupSyncManager(true);
			if(relatedEntity!=null)
			{
				_manager = (EmployeeEntity)relatedEntity;
				_manager.ActiveContext = base.ActiveContext;
				_alreadyFetchedManager = true;
				_manager.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Manager", _manager, EmployeeEntity.Relations.EmployeeEntityUsingManagerId);

			}
			else
			{
				_alreadyFetchedManager = false;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)EmployeeFieldIndex.EmployeeId].ForcedCurrentValueWrite(employeeId);
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
			return DAOFactory.CreateEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactoryInstance()
		{
			return new EmployeeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathManages
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					EmployeeEntity.Relations.EmployeeEntityUsingManagerId, 
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manages", RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeAddressCollection(),
					EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeId, 
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddress", RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaEmployee
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerId);
				relations.Add(EmployeeEntity.Relations.ContactEntityUsingContactId);
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(),
					EmployeeEntity.Relations.EmployeeEntityUsingManagerId,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, relations, "ContactCollectionViaEmployee", RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaEmployeeAddress
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeId);
				relations.Add(EmployeeAddressEntity.Relations.AddressEntityUsingAddressId);
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeId,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, relations, "AddressCollectionViaEmployeeAddress", RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(),
					EmployeeEntity.Relations.ContactEntityUsingContactId, 
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathManager
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIdManagerId, 
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manager", RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return EmployeeEntity.CustomProperties;}
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
			get { return EmployeeEntity.FieldsCustomProperties;}
		}

		/// <summary> The EmployeeId property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.EmployeeId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.EmployeeId, value); }
		}
		/// <summary> The NationalIdnumber property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."NationalIDNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String NationalIdnumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.NationalIdnumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.NationalIdnumber, value); }
		}
		/// <summary> The ContactId property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ContactId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.ContactId, value); }
		}
		/// <summary> The LoginId property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."LoginID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LoginId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.LoginId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.LoginId, value); }
		}
		/// <summary> The ManagerId property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."ManagerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 ManagerId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ManagerId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.ManagerId, value); }
		}
		/// <summary> The Title property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Title);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.Title, value); }
		}
		/// <summary> The BirthDate property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BirthDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.BirthDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.BirthDate, value); }
		}
		/// <summary> The MaritalStatus property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."MaritalStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MaritalStatus
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.MaritalStatus);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.MaritalStatus, value); }
		}
		/// <summary> The Gender property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Gender"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Gender
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Gender);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.Gender, value); }
		}
		/// <summary> The HireDate property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HireDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.HireDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.HireDate, value); }
		}
		/// <summary> The SalariedFlag property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."SalariedFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SalariedFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.SalariedFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.SalariedFlag, value); }
		}
		/// <summary> The VacationHours property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."VacationHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 VacationHours
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.VacationHours);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				return (System.Int16)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.VacationHours, value); }
		}
		/// <summary> The SickLeaveHours property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."SickLeaveHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SickLeaveHours
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.SickLeaveHours);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				return (System.Int16)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.SickLeaveHours, value); }
		}
		/// <summary> The CurrentFlag property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."CurrentFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean CurrentFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.CurrentFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.CurrentFlag, value); }
		}
		/// <summary> The Rowguid property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Guid));
				}
				return (System.Guid)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.Rowguid, value); }
		}
		/// <summary> The ModifiedDate property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)EmployeeFieldIndex.ModifiedDate, value); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiManages()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection Manages
		{
			get	{ return GetMultiManages(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Manages. When set to true, Manages is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Manages is accessed. You can always execute
		/// a forced fetch by calling GetMultiManages(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchManages
		{
			get	{ return _alwaysFetchManages; }
			set	{ _alwaysFetchManages = value; }	
		}
		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection EmployeeAddress
		{
			get	{ return GetMultiEmployeeAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeAddress. When set to true, EmployeeAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeAddress
		{
			get	{ return _alwaysFetchEmployeeAddress; }
			set	{ _alwaysFetchEmployeeAddress = value; }	
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaEmployee
		{
			get { return GetMultiContactCollectionViaEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaEmployee. When set to true, ContactCollectionViaEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaEmployee
		{
			get	{ return _alwaysFetchContactCollectionViaEmployee; }
			set	{ _alwaysFetchContactCollectionViaEmployee = value; }	
		}
		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaEmployeeAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaEmployeeAddress
		{
			get { return GetMultiAddressCollectionViaEmployeeAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaEmployeeAddress. When set to true, AddressCollectionViaEmployeeAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaEmployeeAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaEmployeeAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaEmployeeAddress
		{
			get	{ return _alwaysFetchAddressCollectionViaEmployeeAddress; }
			set	{ _alwaysFetchAddressCollectionViaEmployeeAddress = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get	{ return GetSingleContact(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					if(value==null)
					{
						if(_contact != null)
						{
							_contact.UnsetRelatedEntity(this, "Employee");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Employee");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetSingleContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get	{ return _alwaysFetchContact; }
			set	{ _alwaysFetchContact = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Contact is not found
		/// in the database. When set to true, Contact will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ContactReturnsNewIfNotFound
		{
			get	{ return _contactReturnsNewIfNotFound; }
			set { _contactReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleManager()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Manager
		{
			get	{ return GetSingleManager(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncManager(value);
				}
				else
				{
					if(value==null)
					{
						if(_manager != null)
						{
							_manager.UnsetRelatedEntity(this, "Manages");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "Manages");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Manager. When set to true, Manager is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Manager is accessed. You can always execute
		/// a forced fetch by calling GetSingleManager(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchManager
		{
			get	{ return _alwaysFetchManager; }
			set	{ _alwaysFetchManager = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Manager is not found
		/// in the database. When set to true, Manager will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ManagerReturnsNewIfNotFound
		{
			get	{ return _managerReturnsNewIfNotFound; }
			set { _managerReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.EmployeeEntity; }
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
