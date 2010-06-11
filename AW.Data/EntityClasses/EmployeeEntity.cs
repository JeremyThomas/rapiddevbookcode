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
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Employee'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeCollection	_manages;
		private bool	_alwaysFetchManages, _alreadyFetchedManages;
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddresses;
		private bool	_alwaysFetchEmployeeAddresses, _alreadyFetchedEmployeeAddresses;
		private AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection	_employeeDepartmentHistories;
		private bool	_alwaysFetchEmployeeDepartmentHistories, _alreadyFetchedEmployeeDepartmentHistories;
		private AW.Data.CollectionClasses.EmployeePayHistoryCollection	_employeePayHistories;
		private bool	_alwaysFetchEmployeePayHistories, _alreadyFetchedEmployeePayHistories;
		private AW.Data.CollectionClasses.JobCandidateCollection	_jobCandidates;
		private bool	_alwaysFetchJobCandidates, _alreadyFetchedJobCandidates;
		private AW.Data.CollectionClasses.PurchaseOrderHeaderCollection	_purchaseOrderHeaders;
		private bool	_alwaysFetchPurchaseOrderHeaders, _alreadyFetchedPurchaseOrderHeaders;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaEmployeeAddress;
		private bool	_alwaysFetchAddressCollectionViaEmployeeAddress, _alreadyFetchedAddressCollectionViaEmployeeAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaEmployee;
		private bool	_alwaysFetchContactCollectionViaEmployee, _alreadyFetchedContactCollectionViaEmployee;
		private EmployeeEntity _manager;
		private bool	_alwaysFetchManager, _alreadyFetchedManager, _managerReturnsNewIfNotFound;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Manager</summary>
			public static readonly string Manager = "Manager";
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name Manages</summary>
			public static readonly string Manages = "Manages";
			/// <summary>Member name EmployeeAddresses</summary>
			public static readonly string EmployeeAddresses = "EmployeeAddresses";
			/// <summary>Member name EmployeeDepartmentHistories</summary>
			public static readonly string EmployeeDepartmentHistories = "EmployeeDepartmentHistories";
			/// <summary>Member name EmployeePayHistories</summary>
			public static readonly string EmployeePayHistories = "EmployeePayHistories";
			/// <summary>Member name JobCandidates</summary>
			public static readonly string JobCandidates = "JobCandidates";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name AddressCollectionViaEmployeeAddress</summary>
			public static readonly string AddressCollectionViaEmployeeAddress = "AddressCollectionViaEmployeeAddress";
			/// <summary>Member name ContactCollectionViaEmployee</summary>
			public static readonly string ContactCollectionViaEmployee = "ContactCollectionViaEmployee";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeID)
		{
			InitClassFetch(employeeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 employeeID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(employeeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeID, IValidator validator)
		{
			InitClassFetch(employeeID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_manages = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_manages", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchManages = info.GetBoolean("_alwaysFetchManages");
			_alreadyFetchedManages = info.GetBoolean("_alreadyFetchedManages");

			_employeeAddresses = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddresses", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddresses = info.GetBoolean("_alwaysFetchEmployeeAddresses");
			_alreadyFetchedEmployeeAddresses = info.GetBoolean("_alreadyFetchedEmployeeAddresses");

			_employeeDepartmentHistories = (AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection)info.GetValue("_employeeDepartmentHistories", typeof(AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection));
			_alwaysFetchEmployeeDepartmentHistories = info.GetBoolean("_alwaysFetchEmployeeDepartmentHistories");
			_alreadyFetchedEmployeeDepartmentHistories = info.GetBoolean("_alreadyFetchedEmployeeDepartmentHistories");

			_employeePayHistories = (AW.Data.CollectionClasses.EmployeePayHistoryCollection)info.GetValue("_employeePayHistories", typeof(AW.Data.CollectionClasses.EmployeePayHistoryCollection));
			_alwaysFetchEmployeePayHistories = info.GetBoolean("_alwaysFetchEmployeePayHistories");
			_alreadyFetchedEmployeePayHistories = info.GetBoolean("_alreadyFetchedEmployeePayHistories");

			_jobCandidates = (AW.Data.CollectionClasses.JobCandidateCollection)info.GetValue("_jobCandidates", typeof(AW.Data.CollectionClasses.JobCandidateCollection));
			_alwaysFetchJobCandidates = info.GetBoolean("_alwaysFetchJobCandidates");
			_alreadyFetchedJobCandidates = info.GetBoolean("_alreadyFetchedJobCandidates");

			_purchaseOrderHeaders = (AW.Data.CollectionClasses.PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeaders", typeof(AW.Data.CollectionClasses.PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeaders = info.GetBoolean("_alwaysFetchPurchaseOrderHeaders");
			_alreadyFetchedPurchaseOrderHeaders = info.GetBoolean("_alreadyFetchedPurchaseOrderHeaders");
			_addressCollectionViaEmployeeAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaEmployeeAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaEmployeeAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaEmployeeAddress");
			_alreadyFetchedAddressCollectionViaEmployeeAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaEmployeeAddress");

			_contactCollectionViaEmployee = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaEmployee", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaEmployee = info.GetBoolean("_alwaysFetchContactCollectionViaEmployee");
			_alreadyFetchedContactCollectionViaEmployee = info.GetBoolean("_alreadyFetchedContactCollectionViaEmployee");
			_manager = (EmployeeEntity)info.GetValue("_manager", typeof(EmployeeEntity));
			if(_manager!=null)
			{
				_manager.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_managerReturnsNewIfNotFound = info.GetBoolean("_managerReturnsNewIfNotFound");
			_alwaysFetchManager = info.GetBoolean("_alwaysFetchManager");
			_alreadyFetchedManager = info.GetBoolean("_alreadyFetchedManager");

			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeFieldIndex)fieldIndex)
			{
				case EmployeeFieldIndex.ContactID:
					DesetupSyncContact(true, false);
					_alreadyFetchedContact = false;
					break;
				case EmployeeFieldIndex.ManagerID:
					DesetupSyncManager(true, false);
					_alreadyFetchedManager = false;
					DesetupSyncManager(true, false);
					_alreadyFetchedManager = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedManages = (_manages.Count > 0);
			_alreadyFetchedEmployeeAddresses = (_employeeAddresses.Count > 0);
			_alreadyFetchedEmployeeDepartmentHistories = (_employeeDepartmentHistories.Count > 0);
			_alreadyFetchedEmployeePayHistories = (_employeePayHistories.Count > 0);
			_alreadyFetchedJobCandidates = (_jobCandidates.Count > 0);
			_alreadyFetchedPurchaseOrderHeaders = (_purchaseOrderHeaders.Count > 0);
			_alreadyFetchedAddressCollectionViaEmployeeAddress = (_addressCollectionViaEmployeeAddress.Count > 0);
			_alreadyFetchedContactCollectionViaEmployee = (_contactCollectionViaEmployee.Count > 0);
			_alreadyFetchedManager = (_manager != null);
			_alreadyFetchedContact = (_contact != null);
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
				case "Manager":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeIDManagerID);
					break;
				case "Contact":
					toReturn.Add(Relations.ContactEntityUsingContactID);
					break;
				case "Manages":
					toReturn.Add(Relations.EmployeeEntityUsingManagerID);
					break;
				case "EmployeeAddresses":
					toReturn.Add(Relations.EmployeeAddressEntityUsingEmployeeID);
					break;
				case "EmployeeDepartmentHistories":
					toReturn.Add(Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID);
					break;
				case "EmployeePayHistories":
					toReturn.Add(Relations.EmployeePayHistoryEntityUsingEmployeeID);
					break;
				case "JobCandidates":
					toReturn.Add(Relations.JobCandidateEntityUsingEmployeeID);
					break;
				case "PurchaseOrderHeaders":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingEmployeeID);
					break;
				case "AddressCollectionViaEmployeeAddress":
					toReturn.Add(Relations.EmployeeAddressEntityUsingEmployeeID, "EmployeeEntity__", "EmployeeAddress_", JoinHint.None);
					toReturn.Add(EmployeeAddressEntity.Relations.AddressEntityUsingAddressID, "EmployeeAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaEmployee":
					toReturn.Add(Relations.EmployeeEntityUsingManagerID, "EmployeeEntity__", "Employee_", JoinHint.None);
					toReturn.Add(EmployeeEntity.Relations.ContactEntityUsingContactID, "Employee_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}

		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public  static IPredicateExpression GetEntityTypeFilter()
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("EmployeeEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public  static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("EmployeeEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_manages", (!this.MarkedForDeletion?_manages:null));
			info.AddValue("_alwaysFetchManages", _alwaysFetchManages);
			info.AddValue("_alreadyFetchedManages", _alreadyFetchedManages);
			info.AddValue("_employeeAddresses", (!this.MarkedForDeletion?_employeeAddresses:null));
			info.AddValue("_alwaysFetchEmployeeAddresses", _alwaysFetchEmployeeAddresses);
			info.AddValue("_alreadyFetchedEmployeeAddresses", _alreadyFetchedEmployeeAddresses);
			info.AddValue("_employeeDepartmentHistories", (!this.MarkedForDeletion?_employeeDepartmentHistories:null));
			info.AddValue("_alwaysFetchEmployeeDepartmentHistories", _alwaysFetchEmployeeDepartmentHistories);
			info.AddValue("_alreadyFetchedEmployeeDepartmentHistories", _alreadyFetchedEmployeeDepartmentHistories);
			info.AddValue("_employeePayHistories", (!this.MarkedForDeletion?_employeePayHistories:null));
			info.AddValue("_alwaysFetchEmployeePayHistories", _alwaysFetchEmployeePayHistories);
			info.AddValue("_alreadyFetchedEmployeePayHistories", _alreadyFetchedEmployeePayHistories);
			info.AddValue("_jobCandidates", (!this.MarkedForDeletion?_jobCandidates:null));
			info.AddValue("_alwaysFetchJobCandidates", _alwaysFetchJobCandidates);
			info.AddValue("_alreadyFetchedJobCandidates", _alreadyFetchedJobCandidates);
			info.AddValue("_purchaseOrderHeaders", (!this.MarkedForDeletion?_purchaseOrderHeaders:null));
			info.AddValue("_alwaysFetchPurchaseOrderHeaders", _alwaysFetchPurchaseOrderHeaders);
			info.AddValue("_alreadyFetchedPurchaseOrderHeaders", _alreadyFetchedPurchaseOrderHeaders);
			info.AddValue("_addressCollectionViaEmployeeAddress", (!this.MarkedForDeletion?_addressCollectionViaEmployeeAddress:null));
			info.AddValue("_alwaysFetchAddressCollectionViaEmployeeAddress", _alwaysFetchAddressCollectionViaEmployeeAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaEmployeeAddress", _alreadyFetchedAddressCollectionViaEmployeeAddress);
			info.AddValue("_contactCollectionViaEmployee", (!this.MarkedForDeletion?_contactCollectionViaEmployee:null));
			info.AddValue("_alwaysFetchContactCollectionViaEmployee", _alwaysFetchContactCollectionViaEmployee);
			info.AddValue("_alreadyFetchedContactCollectionViaEmployee", _alreadyFetchedContactCollectionViaEmployee);
			info.AddValue("_manager", (!this.MarkedForDeletion?_manager:null));
			info.AddValue("_managerReturnsNewIfNotFound", _managerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchManager", _alwaysFetchManager);
			info.AddValue("_alreadyFetchedManager", _alreadyFetchedManager);
			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);

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
				case "Manager":
					_alreadyFetchedManager = true;
					this.Manager = (EmployeeEntity)entity;
					break;
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
					break;
				case "Manages":
					_alreadyFetchedManages = true;
					if(entity!=null)
					{
						this.Manages.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeAddresses":
					_alreadyFetchedEmployeeAddresses = true;
					if(entity!=null)
					{
						this.EmployeeAddresses.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "EmployeeDepartmentHistories":
					_alreadyFetchedEmployeeDepartmentHistories = true;
					if(entity!=null)
					{
						this.EmployeeDepartmentHistories.Add((EmployeeDepartmentHistoryEntity)entity);
					}
					break;
				case "EmployeePayHistories":
					_alreadyFetchedEmployeePayHistories = true;
					if(entity!=null)
					{
						this.EmployeePayHistories.Add((EmployeePayHistoryEntity)entity);
					}
					break;
				case "JobCandidates":
					_alreadyFetchedJobCandidates = true;
					if(entity!=null)
					{
						this.JobCandidates.Add((JobCandidateEntity)entity);
					}
					break;
				case "PurchaseOrderHeaders":
					_alreadyFetchedPurchaseOrderHeaders = true;
					if(entity!=null)
					{
						this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)entity);
					}
					break;
				case "AddressCollectionViaEmployeeAddress":
					_alreadyFetchedAddressCollectionViaEmployeeAddress = true;
					if(entity!=null)
					{
						this.AddressCollectionViaEmployeeAddress.Add((AddressEntity)entity);
					}
					break;
				case "ContactCollectionViaEmployee":
					_alreadyFetchedContactCollectionViaEmployee = true;
					if(entity!=null)
					{
						this.ContactCollectionViaEmployee.Add((ContactEntity)entity);
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
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Manager":
					SetupSyncManager(relatedEntity);
					break;
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "Manages":
					_manages.Add((EmployeeEntity)relatedEntity);
					break;
				case "EmployeeAddresses":
					_employeeAddresses.Add((EmployeeAddressEntity)relatedEntity);
					break;
				case "EmployeeDepartmentHistories":
					_employeeDepartmentHistories.Add((EmployeeDepartmentHistoryEntity)relatedEntity);
					break;
				case "EmployeePayHistories":
					_employeePayHistories.Add((EmployeePayHistoryEntity)relatedEntity);
					break;
				case "JobCandidates":
					_jobCandidates.Add((JobCandidateEntity)relatedEntity);
					break;
				case "PurchaseOrderHeaders":
					_purchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)relatedEntity);
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
				case "Manager":
					DesetupSyncManager(false, true);
					break;
				case "Contact":
					DesetupSyncContact(false, true);
					break;
				case "Manages":
					this.PerformRelatedEntityRemoval(_manages, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeAddresses":
					this.PerformRelatedEntityRemoval(_employeeAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeDepartmentHistories":
					this.PerformRelatedEntityRemoval(_employeeDepartmentHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeePayHistories":
					this.PerformRelatedEntityRemoval(_employeePayHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "JobCandidates":
					this.PerformRelatedEntityRemoval(_jobCandidates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeaders":
					this.PerformRelatedEntityRemoval(_purchaseOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_manager!=null)
			{
				toReturn.Add(_manager);
			}
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_manages);
			toReturn.Add(_employeeAddresses);
			toReturn.Add(_employeeDepartmentHistories);
			toReturn.Add(_employeePayHistories);
			toReturn.Add(_jobCandidates);
			toReturn.Add(_purchaseOrderHeaders);

			return toReturn;
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static  EmployeeEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 employeeID, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, employeeID, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static  EmployeeEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 employeeID, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.EmployeeEntity);
			fields[(int)EmployeeFieldIndex.EmployeeID].ForcedCurrentValueWrite(employeeID);
			return (EmployeeEntity)new EmployeeDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID)
		{
			return FetchUsingPK(employeeID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(employeeID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(employeeID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(employeeID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeID, null, null, null);
		}

		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the AW.Data.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("EmployeeEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeRelations().GetAllRelations();
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
 			if( ( !_alreadyFetchedManages || forceFetch || _alwaysFetchManages) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_manages);
				_manages.SuppressClearInGetMulti=!forceFetch;
				_manages.EntityFactoryToUse = entityFactoryToUse;
				_manages.GetMultiManyToOne(this, null, filter);
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
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch)
		{
			return GetMultiEmployeeAddresses(forceFetch, _employeeAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeAddresses(forceFetch, _employeeAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeAddresses || forceFetch || _alwaysFetchEmployeeAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeAddresses);
				_employeeAddresses.SuppressClearInGetMulti=!forceFetch;
				_employeeAddresses.EntityFactoryToUse = entityFactoryToUse;
				_employeeAddresses.GetMultiManyToOne(this, null, filter);
				_employeeAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddresses = true;
			}
			return _employeeAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeAddresses'. These settings will be taken into account
		/// when the property EmployeeAddresses is requested or GetMultiEmployeeAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeAddresses.SortClauses=sortClauses;
			_employeeAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistories(bool forceFetch)
		{
			return GetMultiEmployeeDepartmentHistories(forceFetch, _employeeDepartmentHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeDepartmentHistories(forceFetch, _employeeDepartmentHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeDepartmentHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistories || forceFetch || _alwaysFetchEmployeeDepartmentHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeDepartmentHistories);
				_employeeDepartmentHistories.SuppressClearInGetMulti=!forceFetch;
				_employeeDepartmentHistories.EntityFactoryToUse = entityFactoryToUse;
				_employeeDepartmentHistories.GetMultiManyToOne(null, this, null, filter);
				_employeeDepartmentHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistories = true;
			}
			return _employeeDepartmentHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeDepartmentHistories'. These settings will be taken into account
		/// when the property EmployeeDepartmentHistories is requested or GetMultiEmployeeDepartmentHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeDepartmentHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeDepartmentHistories.SortClauses=sortClauses;
			_employeeDepartmentHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistories(bool forceFetch)
		{
			return GetMultiEmployeePayHistories(forceFetch, _employeePayHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeePayHistories(forceFetch, _employeePayHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeePayHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeePayHistories || forceFetch || _alwaysFetchEmployeePayHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeePayHistories);
				_employeePayHistories.SuppressClearInGetMulti=!forceFetch;
				_employeePayHistories.EntityFactoryToUse = entityFactoryToUse;
				_employeePayHistories.GetMultiManyToOne(this, filter);
				_employeePayHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistories = true;
			}
			return _employeePayHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeePayHistories'. These settings will be taken into account
		/// when the property EmployeePayHistories is requested or GetMultiEmployeePayHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeePayHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeePayHistories.SortClauses=sortClauses;
			_employeePayHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidates(bool forceFetch)
		{
			return GetMultiJobCandidates(forceFetch, _jobCandidates.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidates(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiJobCandidates(forceFetch, _jobCandidates.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidates(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiJobCandidates(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidates(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedJobCandidates || forceFetch || _alwaysFetchJobCandidates) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_jobCandidates);
				_jobCandidates.SuppressClearInGetMulti=!forceFetch;
				_jobCandidates.EntityFactoryToUse = entityFactoryToUse;
				_jobCandidates.GetMultiManyToOne(this, filter);
				_jobCandidates.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidates = true;
			}
			return _jobCandidates;
		}

		/// <summary> Sets the collection parameters for the collection for 'JobCandidates'. These settings will be taken into account
		/// when the property JobCandidates is requested or GetMultiJobCandidates is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersJobCandidates(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_jobCandidates.SortClauses=sortClauses;
			_jobCandidates.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, _purchaseOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, _purchaseOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeaders || forceFetch || _alwaysFetchPurchaseOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_purchaseOrderHeaders);
				_purchaseOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeaders.GetMultiManyToOne(this, null, null, filter);
				_purchaseOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeaders = true;
			}
			return _purchaseOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderHeaders'. These settings will be taken into account
		/// when the property PurchaseOrderHeaders is requested or GetMultiPurchaseOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeaders.SortClauses=sortClauses;
			_purchaseOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedAddressCollectionViaEmployeeAddress || forceFetch || _alwaysFetchAddressCollectionViaEmployeeAddress) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_addressCollectionViaEmployeeAddress);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_addressCollectionViaEmployeeAddress.SuppressClearInGetMulti=!forceFetch;
				_addressCollectionViaEmployeeAddress.EntityFactoryToUse = entityFactoryToUse;
				_addressCollectionViaEmployeeAddress.GetMulti(filter, GetRelationsForField("AddressCollectionViaEmployeeAddress"));
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
 			if( ( !_alreadyFetchedContactCollectionViaEmployee || forceFetch || _alwaysFetchContactCollectionViaEmployee) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCollectionViaEmployee);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_contactCollectionViaEmployee.SuppressClearInGetMulti=!forceFetch;
				_contactCollectionViaEmployee.EntityFactoryToUse = entityFactoryToUse;
				_contactCollectionViaEmployee.GetMulti(filter, GetRelationsForField("ContactCollectionViaEmployee"));
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
			if( ( !_alreadyFetchedManager || forceFetch || _alwaysFetchManager) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.EmployeeEntityUsingEmployeeIDManagerID);
				EmployeeEntity newEntity = (EmployeeEntity)GeneralEntityFactory.Create(AW.Data.EntityType.EmployeeEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = EmployeeEntity.FetchPolymorphic(this.Transaction, this.ManagerID.GetValueOrDefault(), this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (EmployeeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_managerReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Manager = newEntity;
				_alreadyFetchedManager = fetchResult;
			}
			return _manager;
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
			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ContactEntityUsingContactID);
				ContactEntity newEntity = new ContactEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ContactID);
				}
				if(fetchResult)
				{
					newEntity = (ContactEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_contactReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Contact = newEntity;
				_alreadyFetchedContact = fetchResult;
			}
			return _contact;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_manages.ActiveContext = this.ActiveContext;
			_employeeAddresses.ActiveContext = this.ActiveContext;
			_employeeDepartmentHistories.ActiveContext = this.ActiveContext;
			_employeePayHistories.ActiveContext = this.ActiveContext;
			_jobCandidates.ActiveContext = this.ActiveContext;
			_purchaseOrderHeaders.ActiveContext = this.ActiveContext;
			_addressCollectionViaEmployeeAddress.ActiveContext = this.ActiveContext;
			_contactCollectionViaEmployee.ActiveContext = this.ActiveContext;
			if(_manager!=null)
			{
				_manager.ActiveContext = this.ActiveContext;
			}
			if(_contact!=null)
			{
				_contact.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Manager", _manager);
			toReturn.Add("Contact", _contact);
			toReturn.Add("Manages", _manages);
			toReturn.Add("EmployeeAddresses", _employeeAddresses);
			toReturn.Add("EmployeeDepartmentHistories", _employeeDepartmentHistories);
			toReturn.Add("EmployeePayHistories", _employeePayHistories);
			toReturn.Add("JobCandidates", _jobCandidates);
			toReturn.Add("PurchaseOrderHeaders", _purchaseOrderHeaders);
			toReturn.Add("AddressCollectionViaEmployeeAddress", _addressCollectionViaEmployeeAddress);
			toReturn.Add("ContactCollectionViaEmployee", _contactCollectionViaEmployee);
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
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 employeeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(employeeID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_manages = new AW.Data.CollectionClasses.EmployeeCollection();
			_manages.SetContainingEntityInfo(this, "Manager");

			_employeeAddresses = new AW.Data.CollectionClasses.EmployeeAddressCollection();
			_employeeAddresses.SetContainingEntityInfo(this, "Employee");

			_employeeDepartmentHistories = new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection();
			_employeeDepartmentHistories.SetContainingEntityInfo(this, "Employee");

			_employeePayHistories = new AW.Data.CollectionClasses.EmployeePayHistoryCollection();
			_employeePayHistories.SetContainingEntityInfo(this, "Employee");

			_jobCandidates = new AW.Data.CollectionClasses.JobCandidateCollection();
			_jobCandidates.SetContainingEntityInfo(this, "Employee");

			_purchaseOrderHeaders = new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection();
			_purchaseOrderHeaders.SetContainingEntityInfo(this, "Employee");
			_addressCollectionViaEmployeeAddress = new AW.Data.CollectionClasses.AddressCollection();
			_contactCollectionViaEmployee = new AW.Data.CollectionClasses.ContactCollection();
			_managerReturnsNewIfNotFound = true;
			_contactReturnsNewIfNotFound = true;
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
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrentFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmployeeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LoginID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ManagerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MaritalStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NationalIdnumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalariedFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SickLeaveHours", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VacationHours", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _manager</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncManager(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _manager, new PropertyChangedEventHandler( OnManagerPropertyChanged ), "Manager", EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID, true, signalRelatedEntity, "Manages", resetFKFields, new int[] { (int)EmployeeFieldIndex.ManagerID } );		
			_manager = null;
		}
		
		/// <summary> setups the sync logic for member _manager</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncManager(IEntity relatedEntity)
		{
			if(_manager!=relatedEntity)
			{		
				DesetupSyncManager(true, true);
				_manager = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _manager, new PropertyChangedEventHandler( OnManagerPropertyChanged ), "Manager", EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID, true, ref _alreadyFetchedManager, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnManagerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContact(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", EmployeeEntity.Relations.ContactEntityUsingContactID, true, signalRelatedEntity, "Employees", resetFKFields, new int[] { (int)EmployeeFieldIndex.ContactID } );		
			_contact = null;
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			if(_contact!=relatedEntity)
			{		
				DesetupSyncContact(true, true);
				_contact = (ContactEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", EmployeeEntity.Relations.ContactEntityUsingContactID, true, ref _alreadyFetchedContact, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnContactPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)EmployeeFieldIndex.EmployeeID].ForcedCurrentValueWrite(employeeID);
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
			return DAOFactory.CreateEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
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
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathManages
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Manages")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manages", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeAddressCollection(), (IEntityRelation)GetRelationsForField("EmployeeAddresses")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeDepartmentHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(), (IEntityRelation)GetRelationsForField("EmployeeDepartmentHistories")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, 0, null, null, null, "EmployeeDepartmentHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeePayHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeePayHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeePayHistoryCollection(), (IEntityRelation)GetRelationsForField("EmployeePayHistories")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeePayHistoryEntity, 0, null, null, null, "EmployeePayHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'JobCandidate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathJobCandidates
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.JobCandidateCollection(), (IEntityRelation)GetRelationsForField("JobCandidates")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.JobCandidateEntity, 0, null, null, null, "JobCandidates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderHeaders")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaEmployeeAddress
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.EmployeeAddressEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,	(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaEmployeeAddress"), "AddressCollectionViaEmployeeAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.EmployeeEntityUsingManagerID;
				intermediateRelation.SetAliases(string.Empty, "Employee_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,	(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaEmployee"), "ContactCollectionViaEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathManager
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Manager")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manager", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), (IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "EmployeeEntity";}
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

		/// <summary> The BirthDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BirthDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.BirthDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value, true); }
		}

		/// <summary> The ContactID property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.ContactID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ContactID, value, true); }
		}

		/// <summary> The CurrentFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."CurrentFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean CurrentFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.CurrentFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.CurrentFlag, value, true); }
		}

		/// <summary> The EmployeeID property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeID
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeID, value, true); }
		}

		/// <summary> The Gender property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Gender"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Gender
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Gender, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Gender, value, true); }
		}

		/// <summary> The HireDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HireDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.HireDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value, true); }
		}

		/// <summary> The LoginID property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."LoginID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LoginID
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LoginID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LoginID, value, true); }
		}

		/// <summary> The ManagerID property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ManagerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ManagerID
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.ManagerID, false); }
			set	{ SetValue((int)EmployeeFieldIndex.ManagerID, value, true); }
		}

		/// <summary> The MaritalStatus property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."MaritalStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MaritalStatus
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MaritalStatus, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MaritalStatus, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The NationalIdnumber property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."NationalIDNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String NationalIdnumber
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.NationalIdnumber, true); }
			set	{ SetValue((int)EmployeeFieldIndex.NationalIdnumber, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)EmployeeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SalariedFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SalariedFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SalariedFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.SalariedFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SalariedFlag, value, true); }
		}

		/// <summary> The SickLeaveHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SickLeaveHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SickLeaveHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.SickLeaveHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SickLeaveHours, value, true); }
		}

		/// <summary> The Title property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value, true); }
		}

		/// <summary> The VacationHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."VacationHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 VacationHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.VacationHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.VacationHours, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiManages()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection Manages
		{
			get	{ return GetMultiManages(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Manages. When set to true, Manages is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Manages is accessed. You can always execute/ a forced fetch by calling GetMultiManages(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchManages
		{
			get	{ return _alwaysFetchManages; }
			set	{ _alwaysFetchManages = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Manages already has been fetched. Setting this property to false when Manages has been fetched
		/// will clear the Manages collection well. Setting this property to true while Manages hasn't been fetched disables lazy loading for Manages</summary>
		[Browsable(false)]
		public bool AlreadyFetchedManages
		{
			get { return _alreadyFetchedManages;}
			set 
			{
				if(_alreadyFetchedManages && !value && (_manages != null))
				{
					_manages.Clear();
				}
				_alreadyFetchedManages = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection EmployeeAddresses
		{
			get	{ return GetMultiEmployeeAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeAddresses. When set to true, EmployeeAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeAddresses
		{
			get	{ return _alwaysFetchEmployeeAddresses; }
			set	{ _alwaysFetchEmployeeAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeAddresses already has been fetched. Setting this property to false when EmployeeAddresses has been fetched
		/// will clear the EmployeeAddresses collection well. Setting this property to true while EmployeeAddresses hasn't been fetched disables lazy loading for EmployeeAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeAddresses
		{
			get { return _alreadyFetchedEmployeeAddresses;}
			set 
			{
				if(_alreadyFetchedEmployeeAddresses && !value && (_employeeAddresses != null))
				{
					_employeeAddresses.Clear();
				}
				_alreadyFetchedEmployeeAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeDepartmentHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection EmployeeDepartmentHistories
		{
			get	{ return GetMultiEmployeeDepartmentHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeDepartmentHistories. When set to true, EmployeeDepartmentHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeDepartmentHistories is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeDepartmentHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeDepartmentHistories
		{
			get	{ return _alwaysFetchEmployeeDepartmentHistories; }
			set	{ _alwaysFetchEmployeeDepartmentHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeDepartmentHistories already has been fetched. Setting this property to false when EmployeeDepartmentHistories has been fetched
		/// will clear the EmployeeDepartmentHistories collection well. Setting this property to true while EmployeeDepartmentHistories hasn't been fetched disables lazy loading for EmployeeDepartmentHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeDepartmentHistories
		{
			get { return _alreadyFetchedEmployeeDepartmentHistories;}
			set 
			{
				if(_alreadyFetchedEmployeeDepartmentHistories && !value && (_employeeDepartmentHistories != null))
				{
					_employeeDepartmentHistories.Clear();
				}
				_alreadyFetchedEmployeeDepartmentHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeePayHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeePayHistoryCollection EmployeePayHistories
		{
			get	{ return GetMultiEmployeePayHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeePayHistories. When set to true, EmployeePayHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeePayHistories is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeePayHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeePayHistories
		{
			get	{ return _alwaysFetchEmployeePayHistories; }
			set	{ _alwaysFetchEmployeePayHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeePayHistories already has been fetched. Setting this property to false when EmployeePayHistories has been fetched
		/// will clear the EmployeePayHistories collection well. Setting this property to true while EmployeePayHistories hasn't been fetched disables lazy loading for EmployeePayHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeePayHistories
		{
			get { return _alreadyFetchedEmployeePayHistories;}
			set 
			{
				if(_alreadyFetchedEmployeePayHistories && !value && (_employeePayHistories != null))
				{
					_employeePayHistories.Clear();
				}
				_alreadyFetchedEmployeePayHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiJobCandidates()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.JobCandidateCollection JobCandidates
		{
			get	{ return GetMultiJobCandidates(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for JobCandidates. When set to true, JobCandidates is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time JobCandidates is accessed. You can always execute/ a forced fetch by calling GetMultiJobCandidates(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchJobCandidates
		{
			get	{ return _alwaysFetchJobCandidates; }
			set	{ _alwaysFetchJobCandidates = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property JobCandidates already has been fetched. Setting this property to false when JobCandidates has been fetched
		/// will clear the JobCandidates collection well. Setting this property to true while JobCandidates hasn't been fetched disables lazy loading for JobCandidates</summary>
		[Browsable(false)]
		public bool AlreadyFetchedJobCandidates
		{
			get { return _alreadyFetchedJobCandidates;}
			set 
			{
				if(_alreadyFetchedJobCandidates && !value && (_jobCandidates != null))
				{
					_jobCandidates.Clear();
				}
				_alreadyFetchedJobCandidates = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection PurchaseOrderHeaders
		{
			get	{ return GetMultiPurchaseOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeaders. When set to true, PurchaseOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiPurchaseOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeaders
		{
			get	{ return _alwaysFetchPurchaseOrderHeaders; }
			set	{ _alwaysFetchPurchaseOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeaders already has been fetched. Setting this property to false when PurchaseOrderHeaders has been fetched
		/// will clear the PurchaseOrderHeaders collection well. Setting this property to true while PurchaseOrderHeaders hasn't been fetched disables lazy loading for PurchaseOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeaders
		{
			get { return _alreadyFetchedPurchaseOrderHeaders;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeaders && !value && (_purchaseOrderHeaders != null))
				{
					_purchaseOrderHeaders.Clear();
				}
				_alreadyFetchedPurchaseOrderHeaders = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaEmployeeAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaEmployeeAddress
		{
			get { return GetMultiAddressCollectionViaEmployeeAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaEmployeeAddress. When set to true, AddressCollectionViaEmployeeAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaEmployeeAddress is accessed. You can always execute a forced fetch by calling GetMultiAddressCollectionViaEmployeeAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaEmployeeAddress
		{
			get	{ return _alwaysFetchAddressCollectionViaEmployeeAddress; }
			set	{ _alwaysFetchAddressCollectionViaEmployeeAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaEmployeeAddress already has been fetched. Setting this property to false when AddressCollectionViaEmployeeAddress has been fetched
		/// will clear the AddressCollectionViaEmployeeAddress collection well. Setting this property to true while AddressCollectionViaEmployeeAddress hasn't been fetched disables lazy loading for AddressCollectionViaEmployeeAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaEmployeeAddress
		{
			get { return _alreadyFetchedAddressCollectionViaEmployeeAddress;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaEmployeeAddress && !value && (_addressCollectionViaEmployeeAddress != null))
				{
					_addressCollectionViaEmployeeAddress.Clear();
				}
				_alreadyFetchedAddressCollectionViaEmployeeAddress = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaEmployee
		{
			get { return GetMultiContactCollectionViaEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaEmployee. When set to true, ContactCollectionViaEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaEmployee is accessed. You can always execute a forced fetch by calling GetMultiContactCollectionViaEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaEmployee
		{
			get	{ return _alwaysFetchContactCollectionViaEmployee; }
			set	{ _alwaysFetchContactCollectionViaEmployee = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaEmployee already has been fetched. Setting this property to false when ContactCollectionViaEmployee has been fetched
		/// will clear the ContactCollectionViaEmployee collection well. Setting this property to true while ContactCollectionViaEmployee hasn't been fetched disables lazy loading for ContactCollectionViaEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaEmployee
		{
			get { return _alreadyFetchedContactCollectionViaEmployee;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaEmployee && !value && (_contactCollectionViaEmployee != null))
				{
					_contactCollectionViaEmployee.Clear();
				}
				_alreadyFetchedContactCollectionViaEmployee = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleManager()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual EmployeeEntity Manager
		{
			get	{ return GetSingleManager(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncManager(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Manages", "Manager", _manager, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Manager. When set to true, Manager is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Manager is accessed. You can always execute a forced fetch by calling GetSingleManager(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchManager
		{
			get	{ return _alwaysFetchManager; }
			set	{ _alwaysFetchManager = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Manager already has been fetched. Setting this property to false when Manager has been fetched
		/// will set Manager to null as well. Setting this property to true while Manager hasn't been fetched disables lazy loading for Manager</summary>
		[Browsable(false)]
		public bool AlreadyFetchedManager
		{
			get { return _alreadyFetchedManager;}
			set 
			{
				if(_alreadyFetchedManager && !value)
				{
					this.Manager = null;
				}
				_alreadyFetchedManager = value;
			}
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

		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ContactEntity Contact
		{
			get	{ return GetSingleContact(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Employees", "Contact", _contact, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute a forced fetch by calling GetSingleContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get	{ return _alwaysFetchContact; }
			set	{ _alwaysFetchContact = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Contact already has been fetched. Setting this property to false when Contact has been fetched
		/// will set Contact to null as well. Setting this property to true while Contact hasn't been fetched disables lazy loading for Contact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContact
		{
			get { return _alreadyFetchedContact;}
			set 
			{
				if(_alreadyFetchedContact && !value)
				{
					this.Contact = null;
				}
				_alreadyFetchedContact = value;
			}
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


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.TargetPerEntity;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.EmployeeEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

        public string EmployeeDisplayName
        {
            get
            {
               return this.Contact.LastName + ", " + this.Contact.FirstName;
            }
        }
            public static int AddBonusVacationHours(
                DateTime HireDateAfter,
                int SalariedHours,
                int NonSalariedHours)
            {
                Transaction MyTransaction = new Transaction(
                    System.Data.IsolationLevel.RepeatableRead, "MyTransaction");
                int RowsAffected = 0;
                try
                {
                    EmployeeCollection Salaried = new EmployeeCollection();
                    MyTransaction.Add(Salaried);
                    IPredicateExpression SalariedPred = 
                        new PredicateExpression();
                    SalariedPred.Add(
                        (EmployeeFields.HireDate >= HireDateAfter) &
                        (EmployeeFields.SalariedFlag == true));
                    Salaried.GetMulti(SalariedPred);
                    foreach (EmployeeEntity Employee in Salaried)
                    {
                        Employee.VacationHours += Convert.ToInt16(SalariedHours);
                    }
                    RowsAffected += Salaried.SaveMulti();
                    EmployeeCollection NonSalaried = new EmployeeCollection();
                    MyTransaction.Add(NonSalaried);
                    IPredicateExpression NonSalariedPred = 
                        new PredicateExpression();
                    NonSalariedPred.Add(
                        (EmployeeFields.HireDate >= HireDateAfter) &
                        (EmployeeFields.SalariedFlag == false));
                    NonSalaried.GetMulti(NonSalariedPred);
                    foreach (EmployeeEntity Employee in NonSalaried)
                    {
                        Employee.VacationHours += Convert.ToInt16(NonSalariedHours);
                    }
                    RowsAffected += NonSalaried.SaveMulti();
                    MyTransaction.Commit();
                    }
                catch (Exception err)
                {
                    MyTransaction.Rollback();
                    throw new ApplicationException(
                        "Error adding vacation hours: " + err.Message);
                }
                finally
                {
                    MyTransaction.Dispose();
                }
                return RowsAffected;
            }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
