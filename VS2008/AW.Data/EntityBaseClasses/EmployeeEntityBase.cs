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
	/// <summary>Entity base class which represents the base class for the entity 'Employee'.<br/><br/>
	/// 
	/// MS_Description: Employee information such as salary, department, and title.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class EmployeeEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeCollection	_manages;
		private bool	_alwaysFetchManages, _alreadyFetchedManages;
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddresses;
		private bool	_alwaysFetchEmployeeAddresses, _alreadyFetchedEmployeeAddresses;
		private AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection	_employeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeDepartmentHistory, _alreadyFetchedEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.EmployeePayHistoryCollection	_employeePayHistory;
		private bool	_alwaysFetchEmployeePayHistory, _alreadyFetchedEmployeePayHistory;
		private AW.Data.CollectionClasses.JobCandidateCollection	_jobCandidate;
		private bool	_alwaysFetchJobCandidate, _alreadyFetchedJobCandidate;
		private AW.Data.CollectionClasses.PurchaseOrderHeaderCollection	_purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaEmployeeAddress;
		private bool	_alwaysFetchAddressCollectionViaEmployeeAddress, _alreadyFetchedAddressCollectionViaEmployeeAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaEmployee;
		private bool	_alwaysFetchContactCollectionViaEmployee, _alreadyFetchedContactCollectionViaEmployee;
		private AW.Data.CollectionClasses.DepartmentCollection _departmentCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory, _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.ShiftCollection _shiftCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory, _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaPurchaseOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader, _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaPurchaseOrderHeader;
		private bool	_alwaysFetchVendorCollectionViaPurchaseOrderHeader, _alreadyFetchedVendorCollectionViaPurchaseOrderHeader;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private EmployeeEntity _manager;
		private bool	_alwaysFetchManager, _alreadyFetchedManager, _managerReturnsNewIfNotFound;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson, _salesPersonReturnsNewIfNotFound;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name Manager</summary>
			public static readonly string Manager = "Manager";
			/// <summary>Member name Manages</summary>
			public static readonly string Manages = "Manages";
			/// <summary>Member name EmployeeAddresses</summary>
			public static readonly string EmployeeAddresses = "EmployeeAddresses";
			/// <summary>Member name EmployeeDepartmentHistory</summary>
			public static readonly string EmployeeDepartmentHistory = "EmployeeDepartmentHistory";
			/// <summary>Member name EmployeePayHistory</summary>
			public static readonly string EmployeePayHistory = "EmployeePayHistory";
			/// <summary>Member name JobCandidate</summary>
			public static readonly string JobCandidate = "JobCandidate";
			/// <summary>Member name PurchaseOrderHeader</summary>
			public static readonly string PurchaseOrderHeader = "PurchaseOrderHeader";
			/// <summary>Member name AddressCollectionViaEmployeeAddress</summary>
			public static readonly string AddressCollectionViaEmployeeAddress = "AddressCollectionViaEmployeeAddress";
			/// <summary>Member name ContactCollectionViaEmployee</summary>
			public static readonly string ContactCollectionViaEmployee = "ContactCollectionViaEmployee";
			/// <summary>Member name DepartmentCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string DepartmentCollectionViaEmployeeDepartmentHistory = "DepartmentCollectionViaEmployeeDepartmentHistory";
			/// <summary>Member name ShiftCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string ShiftCollectionViaEmployeeDepartmentHistory = "ShiftCollectionViaEmployeeDepartmentHistory";
			/// <summary>Member name ShipMethodCollectionViaPurchaseOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaPurchaseOrderHeader = "ShipMethodCollectionViaPurchaseOrderHeader";
			/// <summary>Member name VendorCollectionViaPurchaseOrderHeader</summary>
			public static readonly string VendorCollectionViaPurchaseOrderHeader = "VendorCollectionViaPurchaseOrderHeader";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntityBase(System.Int32 employeeID)
		{
			InitClassFetch(employeeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntityBase(System.Int32 employeeID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(employeeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntityBase(System.Int32 employeeID, IValidator validator)
		{
			InitClassFetch(employeeID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_manages = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_manages", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchManages = info.GetBoolean("_alwaysFetchManages");
			_alreadyFetchedManages = info.GetBoolean("_alreadyFetchedManages");
			_employeeAddresses = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddresses", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddresses = info.GetBoolean("_alwaysFetchEmployeeAddresses");
			_alreadyFetchedEmployeeAddresses = info.GetBoolean("_alreadyFetchedEmployeeAddresses");
			_employeeDepartmentHistory = (AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection)info.GetValue("_employeeDepartmentHistory", typeof(AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection));
			_alwaysFetchEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeDepartmentHistory");
			_employeePayHistory = (AW.Data.CollectionClasses.EmployeePayHistoryCollection)info.GetValue("_employeePayHistory", typeof(AW.Data.CollectionClasses.EmployeePayHistoryCollection));
			_alwaysFetchEmployeePayHistory = info.GetBoolean("_alwaysFetchEmployeePayHistory");
			_alreadyFetchedEmployeePayHistory = info.GetBoolean("_alreadyFetchedEmployeePayHistory");
			_jobCandidate = (AW.Data.CollectionClasses.JobCandidateCollection)info.GetValue("_jobCandidate", typeof(AW.Data.CollectionClasses.JobCandidateCollection));
			_alwaysFetchJobCandidate = info.GetBoolean("_alwaysFetchJobCandidate");
			_alreadyFetchedJobCandidate = info.GetBoolean("_alreadyFetchedJobCandidate");
			_purchaseOrderHeader = (AW.Data.CollectionClasses.PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeader", typeof(AW.Data.CollectionClasses.PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");
			_addressCollectionViaEmployeeAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaEmployeeAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaEmployeeAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaEmployeeAddress");
			_alreadyFetchedAddressCollectionViaEmployeeAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaEmployeeAddress");
			_contactCollectionViaEmployee = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaEmployee", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaEmployee = info.GetBoolean("_alwaysFetchContactCollectionViaEmployee");
			_alreadyFetchedContactCollectionViaEmployee = info.GetBoolean("_alreadyFetchedContactCollectionViaEmployee");
			_departmentCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.DepartmentCollection)info.GetValue("_departmentCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.DepartmentCollection));
			_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory");
			_shiftCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.ShiftCollection)info.GetValue("_shiftCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.ShiftCollection));
			_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory");
			_shipMethodCollectionViaPurchaseOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaPurchaseOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader");
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader");
			_vendorCollectionViaPurchaseOrderHeader = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaPurchaseOrderHeader", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaPurchaseOrderHeader = info.GetBoolean("_alwaysFetchVendorCollectionViaPurchaseOrderHeader");
			_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedVendorCollectionViaPurchaseOrderHeader");
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
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesPersonReturnsNewIfNotFound = info.GetBoolean("_salesPersonReturnsNewIfNotFound");
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
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
			_alreadyFetchedManages = (_manages.Count > 0);
			_alreadyFetchedEmployeeAddresses = (_employeeAddresses.Count > 0);
			_alreadyFetchedEmployeeDepartmentHistory = (_employeeDepartmentHistory.Count > 0);
			_alreadyFetchedEmployeePayHistory = (_employeePayHistory.Count > 0);
			_alreadyFetchedJobCandidate = (_jobCandidate.Count > 0);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader.Count > 0);
			_alreadyFetchedAddressCollectionViaEmployeeAddress = (_addressCollectionViaEmployeeAddress.Count > 0);
			_alreadyFetchedContactCollectionViaEmployee = (_contactCollectionViaEmployee.Count > 0);
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = (_departmentCollectionViaEmployeeDepartmentHistory.Count > 0);
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = (_shiftCollectionViaEmployeeDepartmentHistory.Count > 0);
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = (_shipMethodCollectionViaPurchaseOrderHeader.Count > 0);
			_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = (_vendorCollectionViaPurchaseOrderHeader.Count > 0);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedManager = (_manager != null);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return EmployeeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Contact":
					toReturn.Add(EmployeeEntity.Relations.ContactEntityUsingContactID);
					break;
				case "Manager":
					toReturn.Add(EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID);
					break;
				case "Manages":
					toReturn.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerID);
					break;
				case "EmployeeAddresses":
					toReturn.Add(EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeID);
					break;
				case "EmployeeDepartmentHistory":
					toReturn.Add(EmployeeEntity.Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID);
					break;
				case "EmployeePayHistory":
					toReturn.Add(EmployeeEntity.Relations.EmployeePayHistoryEntityUsingEmployeeID);
					break;
				case "JobCandidate":
					toReturn.Add(EmployeeEntity.Relations.JobCandidateEntityUsingEmployeeID);
					break;
				case "PurchaseOrderHeader":
					toReturn.Add(EmployeeEntity.Relations.PurchaseOrderHeaderEntityUsingEmployeeID);
					break;
				case "AddressCollectionViaEmployeeAddress":
					toReturn.Add(EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeID, "EmployeeEntity__", "EmployeeAddress_", JoinHint.None);
					toReturn.Add(EmployeeAddressEntity.Relations.AddressEntityUsingAddressID, "EmployeeAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaEmployee":
					toReturn.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerID, "EmployeeEntity__", "Employee_", JoinHint.None);
					toReturn.Add(EmployeeEntity.Relations.ContactEntityUsingContactID, "Employee_", string.Empty, JoinHint.None);
					break;
				case "DepartmentCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(EmployeeEntity.Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID, "EmployeeEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
					break;
				case "ShiftCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(EmployeeEntity.Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID, "EmployeeEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaPurchaseOrderHeader":
					toReturn.Add(EmployeeEntity.Relations.PurchaseOrderHeaderEntityUsingEmployeeID, "EmployeeEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaPurchaseOrderHeader":
					toReturn.Add(EmployeeEntity.Relations.PurchaseOrderHeaderEntityUsingEmployeeID, "EmployeeEntity__", "PurchaseOrderHeader_", JoinHint.None);
					toReturn.Add(PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID, "PurchaseOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPerson":
					toReturn.Add(EmployeeEntity.Relations.SalesPersonEntityUsingSalesPersonID);
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
			info.AddValue("_manages", (!this.MarkedForDeletion?_manages:null));
			info.AddValue("_alwaysFetchManages", _alwaysFetchManages);
			info.AddValue("_alreadyFetchedManages", _alreadyFetchedManages);
			info.AddValue("_employeeAddresses", (!this.MarkedForDeletion?_employeeAddresses:null));
			info.AddValue("_alwaysFetchEmployeeAddresses", _alwaysFetchEmployeeAddresses);
			info.AddValue("_alreadyFetchedEmployeeAddresses", _alreadyFetchedEmployeeAddresses);
			info.AddValue("_employeeDepartmentHistory", (!this.MarkedForDeletion?_employeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchEmployeeDepartmentHistory", _alwaysFetchEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedEmployeeDepartmentHistory", _alreadyFetchedEmployeeDepartmentHistory);
			info.AddValue("_employeePayHistory", (!this.MarkedForDeletion?_employeePayHistory:null));
			info.AddValue("_alwaysFetchEmployeePayHistory", _alwaysFetchEmployeePayHistory);
			info.AddValue("_alreadyFetchedEmployeePayHistory", _alreadyFetchedEmployeePayHistory);
			info.AddValue("_jobCandidate", (!this.MarkedForDeletion?_jobCandidate:null));
			info.AddValue("_alwaysFetchJobCandidate", _alwaysFetchJobCandidate);
			info.AddValue("_alreadyFetchedJobCandidate", _alreadyFetchedJobCandidate);
			info.AddValue("_purchaseOrderHeader", (!this.MarkedForDeletion?_purchaseOrderHeader:null));
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);
			info.AddValue("_addressCollectionViaEmployeeAddress", (!this.MarkedForDeletion?_addressCollectionViaEmployeeAddress:null));
			info.AddValue("_alwaysFetchAddressCollectionViaEmployeeAddress", _alwaysFetchAddressCollectionViaEmployeeAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaEmployeeAddress", _alreadyFetchedAddressCollectionViaEmployeeAddress);
			info.AddValue("_contactCollectionViaEmployee", (!this.MarkedForDeletion?_contactCollectionViaEmployee:null));
			info.AddValue("_alwaysFetchContactCollectionViaEmployee", _alwaysFetchContactCollectionViaEmployee);
			info.AddValue("_alreadyFetchedContactCollectionViaEmployee", _alreadyFetchedContactCollectionViaEmployee);
			info.AddValue("_departmentCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_departmentCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory", _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory", _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_shiftCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_shiftCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory", _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory", _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_shipMethodCollectionViaPurchaseOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaPurchaseOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader", _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader", _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader);
			info.AddValue("_vendorCollectionViaPurchaseOrderHeader", (!this.MarkedForDeletion?_vendorCollectionViaPurchaseOrderHeader:null));
			info.AddValue("_alwaysFetchVendorCollectionViaPurchaseOrderHeader", _alwaysFetchVendorCollectionViaPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedVendorCollectionViaPurchaseOrderHeader", _alreadyFetchedVendorCollectionViaPurchaseOrderHeader);
			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_manager", (!this.MarkedForDeletion?_manager:null));
			info.AddValue("_managerReturnsNewIfNotFound", _managerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchManager", _alwaysFetchManager);
			info.AddValue("_alreadyFetchedManager", _alreadyFetchedManager);
			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_salesPersonReturnsNewIfNotFound", _salesPersonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			
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
				case "EmployeeAddresses":
					_alreadyFetchedEmployeeAddresses = true;
					if(entity!=null)
					{
						this.EmployeeAddresses.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "EmployeeDepartmentHistory":
					_alreadyFetchedEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.EmployeeDepartmentHistory.Add((EmployeeDepartmentHistoryEntity)entity);
					}
					break;
				case "EmployeePayHistory":
					_alreadyFetchedEmployeePayHistory = true;
					if(entity!=null)
					{
						this.EmployeePayHistory.Add((EmployeePayHistoryEntity)entity);
					}
					break;
				case "JobCandidate":
					_alreadyFetchedJobCandidate = true;
					if(entity!=null)
					{
						this.JobCandidate.Add((JobCandidateEntity)entity);
					}
					break;
				case "PurchaseOrderHeader":
					_alreadyFetchedPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.PurchaseOrderHeader.Add((PurchaseOrderHeaderEntity)entity);
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
				case "DepartmentCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.DepartmentCollectionViaEmployeeDepartmentHistory.Add((DepartmentEntity)entity);
					}
					break;
				case "ShiftCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.ShiftCollectionViaEmployeeDepartmentHistory.Add((ShiftEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaPurchaseOrderHeader":
					_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaPurchaseOrderHeader.Add((ShipMethodEntity)entity);
					}
					break;
				case "VendorCollectionViaPurchaseOrderHeader":
					_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = true;
					if(entity!=null)
					{
						this.VendorCollectionViaPurchaseOrderHeader.Add((VendorEntity)entity);
					}
					break;
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					this.SalesPerson = (SalesPersonEntity)entity;
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
					_manages.Add((EmployeeEntity)relatedEntity);
					break;
				case "EmployeeAddresses":
					_employeeAddresses.Add((EmployeeAddressEntity)relatedEntity);
					break;
				case "EmployeeDepartmentHistory":
					_employeeDepartmentHistory.Add((EmployeeDepartmentHistoryEntity)relatedEntity);
					break;
				case "EmployeePayHistory":
					_employeePayHistory.Add((EmployeePayHistoryEntity)relatedEntity);
					break;
				case "JobCandidate":
					_jobCandidate.Add((JobCandidateEntity)relatedEntity);
					break;
				case "PurchaseOrderHeader":
					_purchaseOrderHeader.Add((PurchaseOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false, true);
					break;
				case "Manager":
					DesetupSyncManager(false, true);
					break;
				case "Manages":
					base.PerformRelatedEntityRemoval(_manages, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeAddresses":
					base.PerformRelatedEntityRemoval(_employeeAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeDepartmentHistory":
					base.PerformRelatedEntityRemoval(_employeeDepartmentHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeePayHistory":
					base.PerformRelatedEntityRemoval(_employeePayHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "JobCandidate":
					base.PerformRelatedEntityRemoval(_jobCandidate, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeader":
					base.PerformRelatedEntityRemoval(_purchaseOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
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
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
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
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_manages);
			toReturn.Add(_employeeAddresses);
			toReturn.Add(_employeeDepartmentHistory);
			toReturn.Add(_employeePayHistory);
			toReturn.Add(_jobCandidate);
			toReturn.Add(_purchaseOrderHeader);

			return toReturn;
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
			return Fetch(employeeID, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeID, null, null, null);
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

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
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
 			if( ( !_alreadyFetchedManages || forceFetch || _alwaysFetchManages) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
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
 			if( ( !_alreadyFetchedEmployeeAddresses || forceFetch || _alwaysFetchEmployeeAddresses) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddresses.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddresses);
					}
				}
				_employeeAddresses.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeAddresses.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeAddresses.GetMultiManyToOne(null, this, filter);
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
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, _employeeDepartmentHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, _employeeDepartmentHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeDepartmentHistory.GetMultiManyToOne(null, this, null, filter);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property EmployeeDepartmentHistory is requested or GetMultiEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeDepartmentHistory.SortClauses=sortClauses;
			_employeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch)
		{
			return GetMultiEmployeePayHistory(forceFetch, _employeePayHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeePayHistory(forceFetch, _employeePayHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeePayHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeePayHistory || forceFetch || _alwaysFetchEmployeePayHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeePayHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeePayHistory);
					}
				}
				_employeePayHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeePayHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeePayHistory.GetMultiManyToOne(this, filter);
				_employeePayHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistory = true;
			}
			return _employeePayHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeePayHistory'. These settings will be taken into account
		/// when the property EmployeePayHistory is requested or GetMultiEmployeePayHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeePayHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeePayHistory.SortClauses=sortClauses;
			_employeePayHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidate(bool forceFetch)
		{
			return GetMultiJobCandidate(forceFetch, _jobCandidate.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiJobCandidate(forceFetch, _jobCandidate.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiJobCandidate(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedJobCandidate || forceFetch || _alwaysFetchJobCandidate) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_jobCandidate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_jobCandidate);
					}
				}
				_jobCandidate.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_jobCandidate.EntityFactoryToUse = entityFactoryToUse;
				}
				_jobCandidate.GetMultiManyToOne(this, filter);
				_jobCandidate.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidate = true;
			}
			return _jobCandidate;
		}

		/// <summary> Sets the collection parameters for the collection for 'JobCandidate'. These settings will be taken into account
		/// when the property JobCandidate is requested or GetMultiJobCandidate is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersJobCandidate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_jobCandidate.SortClauses=sortClauses;
			_jobCandidate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, _purchaseOrderHeader.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, _purchaseOrderHeader.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderHeader(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_purchaseOrderHeader.GetMultiManyToOne(this, null, null, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderHeader'. These settings will be taken into account
		/// when the property PurchaseOrderHeader is requested or GetMultiPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeader.SortClauses=sortClauses;
			_purchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedAddressCollectionViaEmployeeAddress || forceFetch || _alwaysFetchAddressCollectionViaEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaEmployeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaEmployeeAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_addressCollectionViaEmployeeAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaEmployeeAddress.EntityFactoryToUse = entityFactoryToUse;
				}
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
 			if( ( !_alreadyFetchedContactCollectionViaEmployee || forceFetch || _alwaysFetchContactCollectionViaEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaEmployee);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_contactCollectionViaEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
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

		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DepartmentEntity'</returns>
		public AW.Data.CollectionClasses.DepartmentCollection GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(forceFetch, _departmentCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.DepartmentCollection GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory || forceFetch || _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_departmentCollectionViaEmployeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_departmentCollectionViaEmployeeDepartmentHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_departmentCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_departmentCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_departmentCollectionViaEmployeeDepartmentHistory.GetMulti(filter, GetRelationsForField("DepartmentCollectionViaEmployeeDepartmentHistory"));
				_departmentCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = true;
			}
			return _departmentCollectionViaEmployeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'DepartmentCollectionViaEmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property DepartmentCollectionViaEmployeeDepartmentHistory is requested or GetMultiDepartmentCollectionViaEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDepartmentCollectionViaEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_departmentCollectionViaEmployeeDepartmentHistory.SortClauses=sortClauses;
			_departmentCollectionViaEmployeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShiftEntity'</returns>
		public AW.Data.CollectionClasses.ShiftCollection GetMultiShiftCollectionViaEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiShiftCollectionViaEmployeeDepartmentHistory(forceFetch, _shiftCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShiftCollection GetMultiShiftCollectionViaEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory || forceFetch || _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shiftCollectionViaEmployeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shiftCollectionViaEmployeeDepartmentHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_shiftCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shiftCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_shiftCollectionViaEmployeeDepartmentHistory.GetMulti(filter, GetRelationsForField("ShiftCollectionViaEmployeeDepartmentHistory"));
				_shiftCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = true;
			}
			return _shiftCollectionViaEmployeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShiftCollectionViaEmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property ShiftCollectionViaEmployeeDepartmentHistory is requested or GetMultiShiftCollectionViaEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShiftCollectionViaEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shiftCollectionViaEmployeeDepartmentHistory.SortClauses=sortClauses;
			_shiftCollectionViaEmployeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiShipMethodCollectionViaPurchaseOrderHeader(forceFetch, _shipMethodCollectionViaPurchaseOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader || forceFetch || _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethodCollectionViaPurchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethodCollectionViaPurchaseOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_shipMethodCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shipMethodCollectionViaPurchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_shipMethodCollectionViaPurchaseOrderHeader.GetMulti(filter, GetRelationsForField("ShipMethodCollectionViaPurchaseOrderHeader"));
				_shipMethodCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = true;
			}
			return _shipMethodCollectionViaPurchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShipMethodCollectionViaPurchaseOrderHeader'. These settings will be taken into account
		/// when the property ShipMethodCollectionViaPurchaseOrderHeader is requested or GetMultiShipMethodCollectionViaPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethodCollectionViaPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethodCollectionViaPurchaseOrderHeader.SortClauses=sortClauses;
			_shipMethodCollectionViaPurchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaPurchaseOrderHeader(bool forceFetch)
		{
			return GetMultiVendorCollectionViaPurchaseOrderHeader(forceFetch, _vendorCollectionViaPurchaseOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorCollectionViaPurchaseOrderHeader || forceFetch || _alwaysFetchVendorCollectionViaPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorCollectionViaPurchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorCollectionViaPurchaseOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeID, ComparisonOperator.Equal, this.EmployeeID, "EmployeeEntity__"));
				_vendorCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorCollectionViaPurchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorCollectionViaPurchaseOrderHeader.GetMulti(filter, GetRelationsForField("VendorCollectionViaPurchaseOrderHeader"));
				_vendorCollectionViaPurchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = true;
			}
			return _vendorCollectionViaPurchaseOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorCollectionViaPurchaseOrderHeader'. These settings will be taken into account
		/// when the property VendorCollectionViaPurchaseOrderHeader is requested or GetMultiVendorCollectionViaPurchaseOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorCollectionViaPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorCollectionViaPurchaseOrderHeader.SortClauses=sortClauses;
			_vendorCollectionViaPurchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(EmployeeEntity.Relations.ContactEntityUsingContactID);

				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ContactID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ContactEntity)base.ActiveContext.Get(newEntity);
					}
					this.Contact = newEntity;
				}
				else
				{
					if(_contactReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_contact == null)))
						{
							this.Contact = newEntity;
						}
					}
					else
					{
						this.Contact = null;
					}
				}
				_alreadyFetchedContact = fetchResult;
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
			if( ( !_alreadyFetchedManager || forceFetch || _alwaysFetchManager) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ManagerID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Manager = newEntity;
				}
				else
				{
					if(_managerReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_manager == null)))
						{
							this.Manager = newEntity;
						}
					}
					else
					{
						this.Manager = null;
					}
				}
				_alreadyFetchedManager = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _manager;
		}

		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}
		
		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode )
			{
				SalesPersonEntity newEntity = new SalesPersonEntity();
				IEntityRelation relation = EmployeeEntity.Relations.SalesPersonEntityUsingSalesPersonID;
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(relation))
				{
					fetchResult = newEntity.FetchUsingPK(this.EmployeeID);
				}
				if(!_salesPersonReturnsNewIfNotFound && !fetchResult)
				{
					this.SalesPerson = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (SalesPersonEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesPerson = newEntity;
					_alreadyFetchedSalesPerson = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesPerson;
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
			_employeeAddresses.ActiveContext = base.ActiveContext;
			_employeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_employeePayHistory.ActiveContext = base.ActiveContext;
			_jobCandidate.ActiveContext = base.ActiveContext;
			_purchaseOrderHeader.ActiveContext = base.ActiveContext;
			_addressCollectionViaEmployeeAddress.ActiveContext = base.ActiveContext;
			_contactCollectionViaEmployee.ActiveContext = base.ActiveContext;
			_departmentCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_shiftCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaPurchaseOrderHeader.ActiveContext = base.ActiveContext;
			_vendorCollectionViaPurchaseOrderHeader.ActiveContext = base.ActiveContext;
			if(_contact!=null)
			{
				_contact.ActiveContext = base.ActiveContext;
			}
			if(_manager!=null)
			{
				_manager.ActiveContext = base.ActiveContext;
			}
			if(_salesPerson!=null)
			{
				_salesPerson.ActiveContext = base.ActiveContext;
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.EmployeeEntity);
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
			toReturn.Add("Contact", _contact);
			toReturn.Add("Manager", _manager);
			toReturn.Add("Manages", _manages);
			toReturn.Add("EmployeeAddresses", _employeeAddresses);
			toReturn.Add("EmployeeDepartmentHistory", _employeeDepartmentHistory);
			toReturn.Add("EmployeePayHistory", _employeePayHistory);
			toReturn.Add("JobCandidate", _jobCandidate);
			toReturn.Add("PurchaseOrderHeader", _purchaseOrderHeader);
			toReturn.Add("AddressCollectionViaEmployeeAddress", _addressCollectionViaEmployeeAddress);
			toReturn.Add("ContactCollectionViaEmployee", _contactCollectionViaEmployee);
			toReturn.Add("DepartmentCollectionViaEmployeeDepartmentHistory", _departmentCollectionViaEmployeeDepartmentHistory);
			toReturn.Add("ShiftCollectionViaEmployeeDepartmentHistory", _shiftCollectionViaEmployeeDepartmentHistory);
			toReturn.Add("ShipMethodCollectionViaPurchaseOrderHeader", _shipMethodCollectionViaPurchaseOrderHeader);
			toReturn.Add("VendorCollectionViaPurchaseOrderHeader", _vendorCollectionViaPurchaseOrderHeader);
			toReturn.Add("SalesPerson", _salesPerson);
			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 employeeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(employeeID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_manages = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_manages.SetContainingEntityInfo(this, "Manager");
			_alwaysFetchManages = false;
			_alreadyFetchedManages = false;
			_employeeAddresses = new AW.Data.CollectionClasses.EmployeeAddressCollection(new EmployeeAddressEntityFactory());
			_employeeAddresses.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeeAddresses = false;
			_alreadyFetchedEmployeeAddresses = false;
			_employeeDepartmentHistory = new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(new EmployeeDepartmentHistoryEntityFactory());
			_employeeDepartmentHistory.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeDepartmentHistory = false;
			_employeePayHistory = new AW.Data.CollectionClasses.EmployeePayHistoryCollection(new EmployeePayHistoryEntityFactory());
			_employeePayHistory.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeePayHistory = false;
			_alreadyFetchedEmployeePayHistory = false;
			_jobCandidate = new AW.Data.CollectionClasses.JobCandidateCollection(new JobCandidateEntityFactory());
			_jobCandidate.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchJobCandidate = false;
			_alreadyFetchedJobCandidate = false;
			_purchaseOrderHeader = new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(new PurchaseOrderHeaderEntityFactory());
			_purchaseOrderHeader.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;
			_addressCollectionViaEmployeeAddress = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaEmployeeAddress = false;
			_alreadyFetchedAddressCollectionViaEmployeeAddress = false;
			_contactCollectionViaEmployee = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaEmployee = false;
			_alreadyFetchedContactCollectionViaEmployee = false;
			_departmentCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.DepartmentCollection(new DepartmentEntityFactory());
			_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = false;
			_shiftCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.ShiftCollection(new ShiftEntityFactory());
			_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = false;
			_shipMethodCollectionViaPurchaseOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = false;
			_vendorCollectionViaPurchaseOrderHeader = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaPurchaseOrderHeader = false;
			_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = false;
			_contact = null;
			_contactReturnsNewIfNotFound = true;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_manager = null;
			_managerReturnsNewIfNotFound = true;
			_alwaysFetchManager = false;
			_alreadyFetchedManager = false;
			_salesPerson = null;
			_salesPersonReturnsNewIfNotFound = true;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;

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
			_customProperties.Add("MS_Description", @"Employee information such as salary, department, and title.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("EmployeeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique national identification number such as a social security number.");
			_fieldsCustomProperties.Add("NationalIdnumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Network login.");
			_fieldsCustomProperties.Add("LoginID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("ManagerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Work title such as Buyer or Sales Representative.");
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date of birth.");
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"M = Married, S = Single");
			_fieldsCustomProperties.Add("MaritalStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"M = Male, F = Female");
			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Employee hired on this date.");
			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.");
			_fieldsCustomProperties.Add("SalariedFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of available vacation hours.");
			_fieldsCustomProperties.Add("VacationHours", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of available sick leave hours.");
			_fieldsCustomProperties.Add("SickLeaveHours", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Inactive, 1 = Active");
			_fieldsCustomProperties.Add("CurrentFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContact(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", EmployeeEntity.Relations.ContactEntityUsingContactID, true, signalRelatedEntity, "Employees", resetFKFields, new int[] { (int)EmployeeFieldIndex.ContactID } );		
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
				base.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", EmployeeEntity.Relations.ContactEntityUsingContactID, true, ref _alreadyFetchedContact, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _manager</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncManager(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _manager, new PropertyChangedEventHandler( OnManagerPropertyChanged ), "Manager", EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID, true, signalRelatedEntity, "Manages", resetFKFields, new int[] { (int)EmployeeFieldIndex.ManagerID } );		
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
				base.PerformSetupSyncRelatedEntity( _manager, new PropertyChangedEventHandler( OnManagerPropertyChanged ), "Manager", EmployeeEntity.Relations.EmployeeEntityUsingEmployeeIDManagerID, true, ref _alreadyFetchedManager, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _salesPerson</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", EmployeeEntity.Relations.SalesPersonEntityUsingSalesPersonID, false, signalRelatedEntity, "Employee", false, new int[] { (int)EmployeeFieldIndex.EmployeeID } );
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
				base.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", EmployeeEntity.Relations.SalesPersonEntityUsingSalesPersonID, false, ref _alreadyFetchedSalesPerson, new string[] {  } );
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
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)EmployeeFieldIndex.EmployeeID].ForcedCurrentValueWrite(employeeID);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathManages
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Manages")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manages", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeAddresses
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeAddressCollection(),
					(IEntityRelation)GetRelationsForField("EmployeeAddresses")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeDepartmentHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(),
					(IEntityRelation)GetRelationsForField("EmployeeDepartmentHistory")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, 0, null, null, null, "EmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeePayHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeePayHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeePayHistoryCollection(),
					(IEntityRelation)GetRelationsForField("EmployeePayHistory")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeePayHistoryEntity, 0, null, null, null, "EmployeePayHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'JobCandidate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathJobCandidate
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.JobCandidateCollection(),
					(IEntityRelation)GetRelationsForField("JobCandidate")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.JobCandidateEntity, 0, null, null, null, "JobCandidate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("PurchaseOrderHeader")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaEmployeeAddress
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.EmployeeAddressEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaEmployeeAddress"), "AddressCollectionViaEmployeeAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.EmployeeEntityUsingManagerID;
				intermediateRelation.SetAliases(string.Empty, "Employee_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaEmployee"), "ContactCollectionViaEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Department' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.DepartmentCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.DepartmentEntity, 0, null, null, GetRelationsForField("DepartmentCollectionViaEmployeeDepartmentHistory"), "DepartmentCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shift' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShiftCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.EmployeeDepartmentHistoryEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShiftCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ShiftEntity, 0, null, null, GetRelationsForField("ShiftCollectionViaEmployeeDepartmentHistory"), "ShiftCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.PurchaseOrderHeaderEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaPurchaseOrderHeader"), "ShipMethodCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaPurchaseOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.PurchaseOrderHeaderEntityUsingEmployeeID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaPurchaseOrderHeader"), "VendorCollectionViaPurchaseOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Manager")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Manager", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPerson
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(),
					(IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.EmployeeEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "EmployeeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return EmployeeEntity.CustomProperties;}
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
			get { return EmployeeEntity.FieldsCustomProperties;}
		}

		/// <summary> The EmployeeID property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeID
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeID, value, true); }
		}
		/// <summary> The NationalIdnumber property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Unique national identification number such as a social security number.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."NationalIDNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String NationalIdnumber
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.NationalIdnumber, true); }
			set	{ SetValue((int)EmployeeFieldIndex.NationalIdnumber, value, true); }
		}
		/// <summary> The ContactID property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.ContactID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ContactID, value, true); }
		}
		/// <summary> The LoginID property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Network login.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."LoginID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LoginID
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LoginID, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LoginID, value, true); }
		}
		/// <summary> The ManagerID property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ManagerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ManagerID
		{
			get { return (Nullable<System.Int32>)GetValue((int)EmployeeFieldIndex.ManagerID, false); }
			set	{ SetValue((int)EmployeeFieldIndex.ManagerID, value, true); }
		}
		/// <summary> The Title property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Work title such as Buyer or Sales Representative.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value, true); }
		}
		/// <summary> The BirthDate property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Date of birth.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BirthDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.BirthDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value, true); }
		}
		/// <summary> The MaritalStatus property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: M = Married, S = Single<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."MaritalStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MaritalStatus
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MaritalStatus, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MaritalStatus, value, true); }
		}
		/// <summary> The Gender property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: M = Male, F = Female<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Gender"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Gender
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Gender, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Gender, value, true); }
		}
		/// <summary> The HireDate property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Employee hired on this date.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HireDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.HireDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value, true); }
		}
		/// <summary> The SalariedFlag property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SalariedFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SalariedFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.SalariedFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SalariedFlag, value, true); }
		}
		/// <summary> The VacationHours property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Number of available vacation hours.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."VacationHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 VacationHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.VacationHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.VacationHours, value, true); }
		}
		/// <summary> The SickLeaveHours property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Number of available sick leave hours.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SickLeaveHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SickLeaveHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.SickLeaveHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SickLeaveHours, value, true); }
		}
		/// <summary> The CurrentFlag property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: 0 = Inactive, 1 = Active<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."CurrentFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean CurrentFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.CurrentFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.CurrentFlag, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)EmployeeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Employee<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ModifiedDate, value, true); }
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
		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection EmployeeAddresses
		{
			get	{ return GetMultiEmployeeAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeAddresses. When set to true, EmployeeAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeAddresses is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeAddresses(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection EmployeeDepartmentHistory
		{
			get	{ return GetMultiEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeDepartmentHistory. When set to true, EmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchEmployeeDepartmentHistory; }
			set	{ _alwaysFetchEmployeeDepartmentHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeDepartmentHistory already has been fetched. Setting this property to false when EmployeeDepartmentHistory has been fetched
		/// will clear the EmployeeDepartmentHistory collection well. Setting this property to true while EmployeeDepartmentHistory hasn't been fetched disables lazy loading for EmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedEmployeeDepartmentHistory && !value && (_employeeDepartmentHistory != null))
				{
					_employeeDepartmentHistory.Clear();
				}
				_alreadyFetchedEmployeeDepartmentHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeePayHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeePayHistoryCollection EmployeePayHistory
		{
			get	{ return GetMultiEmployeePayHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeePayHistory. When set to true, EmployeePayHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeePayHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeePayHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeePayHistory
		{
			get	{ return _alwaysFetchEmployeePayHistory; }
			set	{ _alwaysFetchEmployeePayHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeePayHistory already has been fetched. Setting this property to false when EmployeePayHistory has been fetched
		/// will clear the EmployeePayHistory collection well. Setting this property to true while EmployeePayHistory hasn't been fetched disables lazy loading for EmployeePayHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeePayHistory
		{
			get { return _alreadyFetchedEmployeePayHistory;}
			set 
			{
				if(_alreadyFetchedEmployeePayHistory && !value && (_employeePayHistory != null))
				{
					_employeePayHistory.Clear();
				}
				_alreadyFetchedEmployeePayHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiJobCandidate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.JobCandidateCollection JobCandidate
		{
			get	{ return GetMultiJobCandidate(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for JobCandidate. When set to true, JobCandidate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time JobCandidate is accessed. You can always execute
		/// a forced fetch by calling GetMultiJobCandidate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchJobCandidate
		{
			get	{ return _alwaysFetchJobCandidate; }
			set	{ _alwaysFetchJobCandidate = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property JobCandidate already has been fetched. Setting this property to false when JobCandidate has been fetched
		/// will clear the JobCandidate collection well. Setting this property to true while JobCandidate hasn't been fetched disables lazy loading for JobCandidate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedJobCandidate
		{
			get { return _alreadyFetchedJobCandidate;}
			set 
			{
				if(_alreadyFetchedJobCandidate && !value && (_jobCandidate != null))
				{
					_jobCandidate.Clear();
				}
				_alreadyFetchedJobCandidate = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection PurchaseOrderHeader
		{
			get	{ return GetMultiPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get	{ return _alwaysFetchPurchaseOrderHeader; }
			set	{ _alwaysFetchPurchaseOrderHeader = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeader already has been fetched. Setting this property to false when PurchaseOrderHeader has been fetched
		/// will clear the PurchaseOrderHeader collection well. Setting this property to true while PurchaseOrderHeader hasn't been fetched disables lazy loading for PurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeader
		{
			get { return _alreadyFetchedPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeader && !value && (_purchaseOrderHeader != null))
				{
					_purchaseOrderHeader.Clear();
				}
				_alreadyFetchedPurchaseOrderHeader = value;
			}
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
		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDepartmentCollectionViaEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.DepartmentCollection DepartmentCollectionViaEmployeeDepartmentHistory
		{
			get { return GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DepartmentCollectionViaEmployeeDepartmentHistory. When set to true, DepartmentCollectionViaEmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DepartmentCollectionViaEmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory; }
			set	{ _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DepartmentCollectionViaEmployeeDepartmentHistory already has been fetched. Setting this property to false when DepartmentCollectionViaEmployeeDepartmentHistory has been fetched
		/// will clear the DepartmentCollectionViaEmployeeDepartmentHistory collection well. Setting this property to true while DepartmentCollectionViaEmployeeDepartmentHistory hasn't been fetched disables lazy loading for DepartmentCollectionViaEmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory && !value && (_departmentCollectionViaEmployeeDepartmentHistory != null))
				{
					_departmentCollectionViaEmployeeDepartmentHistory.Clear();
				}
				_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShiftCollectionViaEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShiftCollection ShiftCollectionViaEmployeeDepartmentHistory
		{
			get { return GetMultiShiftCollectionViaEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShiftCollectionViaEmployeeDepartmentHistory. When set to true, ShiftCollectionViaEmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShiftCollectionViaEmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiShiftCollectionViaEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShiftCollectionViaEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory; }
			set	{ _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShiftCollectionViaEmployeeDepartmentHistory already has been fetched. Setting this property to false when ShiftCollectionViaEmployeeDepartmentHistory has been fetched
		/// will clear the ShiftCollectionViaEmployeeDepartmentHistory collection well. Setting this property to true while ShiftCollectionViaEmployeeDepartmentHistory hasn't been fetched disables lazy loading for ShiftCollectionViaEmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShiftCollectionViaEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory && !value && (_shiftCollectionViaEmployeeDepartmentHistory != null))
				{
					_shiftCollectionViaEmployeeDepartmentHistory.Clear();
				}
				_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaPurchaseOrderHeader
		{
			get { return GetMultiShipMethodCollectionViaPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaPurchaseOrderHeader. When set to true, ShipMethodCollectionViaPurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaPurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethodCollectionViaPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethodCollectionViaPurchaseOrderHeader
		{
			get	{ return _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader; }
			set	{ _alwaysFetchShipMethodCollectionViaPurchaseOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethodCollectionViaPurchaseOrderHeader already has been fetched. Setting this property to false when ShipMethodCollectionViaPurchaseOrderHeader has been fetched
		/// will clear the ShipMethodCollectionViaPurchaseOrderHeader collection well. Setting this property to true while ShipMethodCollectionViaPurchaseOrderHeader hasn't been fetched disables lazy loading for ShipMethodCollectionViaPurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethodCollectionViaPurchaseOrderHeader
		{
			get { return _alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader && !value && (_shipMethodCollectionViaPurchaseOrderHeader != null))
				{
					_shipMethodCollectionViaPurchaseOrderHeader.Clear();
				}
				_alreadyFetchedShipMethodCollectionViaPurchaseOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorCollectionViaPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorCollection VendorCollectionViaPurchaseOrderHeader
		{
			get { return GetMultiVendorCollectionViaPurchaseOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorCollectionViaPurchaseOrderHeader. When set to true, VendorCollectionViaPurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorCollectionViaPurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorCollectionViaPurchaseOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorCollectionViaPurchaseOrderHeader
		{
			get	{ return _alwaysFetchVendorCollectionViaPurchaseOrderHeader; }
			set	{ _alwaysFetchVendorCollectionViaPurchaseOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorCollectionViaPurchaseOrderHeader already has been fetched. Setting this property to false when VendorCollectionViaPurchaseOrderHeader has been fetched
		/// will clear the VendorCollectionViaPurchaseOrderHeader collection well. Setting this property to true while VendorCollectionViaPurchaseOrderHeader hasn't been fetched disables lazy loading for VendorCollectionViaPurchaseOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorCollectionViaPurchaseOrderHeader
		{
			get { return _alreadyFetchedVendorCollectionViaPurchaseOrderHeader;}
			set 
			{
				if(_alreadyFetchedVendorCollectionViaPurchaseOrderHeader && !value && (_vendorCollectionViaPurchaseOrderHeader != null))
				{
					_vendorCollectionViaPurchaseOrderHeader.Clear();
				}
				_alreadyFetchedVendorCollectionViaPurchaseOrderHeader = value;
			}
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
							_contact.UnsetRelatedEntity(this, "Employees");
						}
					}
					else
					{
						if(_contact!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Employees");
						}
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
						if(_manager!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Manages");
						}
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
						bool raisePropertyChanged = (_salesPerson !=null);
						DesetupSyncSalesPerson(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("SalesPerson");
						}
					}
					else
					{
						if(_salesPerson!=value)
						{
							IEntity relatedEntity = (IEntity)value;
							relatedEntity.SetRelatedEntity(this, "Employee");
							SetupSyncSalesPerson(relatedEntity);
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
			set	{ _salesPersonReturnsNewIfNotFound = value; }	
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
