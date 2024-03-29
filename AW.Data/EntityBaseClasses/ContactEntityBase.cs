﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Entity base class which represents the base class for the entity 'Contact'.<br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ContactEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ContactCreditCardCollection	_contactCreditCard;
		private bool	_alwaysFetchContactCreditCard, _alreadyFetchedContactCreditCard;
		private AW.Data.CollectionClasses.EmployeeCollection	_employees;
		private bool	_alwaysFetchEmployees, _alreadyFetchedEmployees;
		private AW.Data.CollectionClasses.IndividualCollection	_individuals;
		private bool	_alwaysFetchIndividuals, _alreadyFetchedIndividuals;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader_, _alreadyFetchedAddressCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader, _alreadyFetchedAddressCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ContactTypeCollection _contactTypeCollectionViaStoreContact;
		private bool	_alwaysFetchContactTypeCollectionViaStoreContact, _alreadyFetchedContactTypeCollectionViaStoreContact;
		private AW.Data.CollectionClasses.ContactTypeCollection _contactTypeCollectionViaVendorContact;
		private bool	_alwaysFetchContactTypeCollectionViaVendorContact, _alreadyFetchedContactTypeCollectionViaVendorContact;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaContactCreditCard;
		private bool	_alwaysFetchCreditCardCollectionViaContactCreditCard, _alreadyFetchedCreditCardCollectionViaContactCreditCard;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader__;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployee;
		private bool	_alwaysFetchEmployeeCollectionViaEmployee, _alreadyFetchedEmployeeCollectionViaEmployee;
		private AW.Data.CollectionClasses.SalesPersonCollection _salesPersonCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesPersonCollectionViaSalesOrderHeader, _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.StoreCollection _storeCollectionViaStoreContact;
		private bool	_alwaysFetchStoreCollectionViaStoreContact, _alreadyFetchedStoreCollectionViaStoreContact;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaVendorContact;
		private bool	_alwaysFetchVendorCollectionViaVendorContact, _alreadyFetchedVendorCollectionViaVendorContact;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ContactCreditCard</summary>
			public static readonly string ContactCreditCard = "ContactCreditCard";
			/// <summary>Member name Employees</summary>
			public static readonly string Employees = "Employees";
			/// <summary>Member name Individuals</summary>
			public static readonly string Individuals = "Individuals";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name StoreContact</summary>
			public static readonly string StoreContact = "StoreContact";
			/// <summary>Member name VendorContact</summary>
			public static readonly string VendorContact = "VendorContact";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name ContactTypeCollectionViaStoreContact</summary>
			public static readonly string ContactTypeCollectionViaStoreContact = "ContactTypeCollectionViaStoreContact";
			/// <summary>Member name ContactTypeCollectionViaVendorContact</summary>
			public static readonly string ContactTypeCollectionViaVendorContact = "ContactTypeCollectionViaVendorContact";
			/// <summary>Member name CreditCardCollectionViaContactCreditCard</summary>
			public static readonly string CreditCardCollectionViaContactCreditCard = "CreditCardCollectionViaContactCreditCard";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader__</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader__ = "CustomerViewRelatedCollectionViaSalesOrderHeader__";
			/// <summary>Member name EmployeeCollectionViaEmployee</summary>
			public static readonly string EmployeeCollectionViaEmployee = "EmployeeCollectionViaEmployee";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name StoreCollectionViaStoreContact</summary>
			public static readonly string StoreCollectionViaStoreContact = "StoreCollectionViaStoreContact";
			/// <summary>Member name VendorCollectionViaVendorContact</summary>
			public static readonly string VendorCollectionViaVendorContact = "VendorCollectionViaVendorContact";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ContactEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ContactEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		public ContactEntityBase(System.Int32 contactID)
		{
			InitClassFetch(contactID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactEntityBase(System.Int32 contactID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(contactID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		public ContactEntityBase(System.Int32 contactID, IValidator validator)
		{
			InitClassFetch(contactID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_contactCreditCard = (AW.Data.CollectionClasses.ContactCreditCardCollection)info.GetValue("_contactCreditCard", typeof(AW.Data.CollectionClasses.ContactCreditCardCollection));
			_alwaysFetchContactCreditCard = info.GetBoolean("_alwaysFetchContactCreditCard");
			_alreadyFetchedContactCreditCard = info.GetBoolean("_alreadyFetchedContactCreditCard");
			_employees = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employees", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployees = info.GetBoolean("_alwaysFetchEmployees");
			_alreadyFetchedEmployees = info.GetBoolean("_alreadyFetchedEmployees");
			_individuals = (AW.Data.CollectionClasses.IndividualCollection)info.GetValue("_individuals", typeof(AW.Data.CollectionClasses.IndividualCollection));
			_alwaysFetchIndividuals = info.GetBoolean("_alwaysFetchIndividuals");
			_alreadyFetchedIndividuals = info.GetBoolean("_alreadyFetchedIndividuals");
			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");
			_storeContact = (AW.Data.CollectionClasses.StoreContactCollection)info.GetValue("_storeContact", typeof(AW.Data.CollectionClasses.StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");
			_vendorContact = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContact", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");
			_addressCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader_");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader_");
			_addressCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader");
			_contactTypeCollectionViaStoreContact = (AW.Data.CollectionClasses.ContactTypeCollection)info.GetValue("_contactTypeCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.ContactTypeCollection));
			_alwaysFetchContactTypeCollectionViaStoreContact = info.GetBoolean("_alwaysFetchContactTypeCollectionViaStoreContact");
			_alreadyFetchedContactTypeCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedContactTypeCollectionViaStoreContact");
			_contactTypeCollectionViaVendorContact = (AW.Data.CollectionClasses.ContactTypeCollection)info.GetValue("_contactTypeCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.ContactTypeCollection));
			_alwaysFetchContactTypeCollectionViaVendorContact = info.GetBoolean("_alwaysFetchContactTypeCollectionViaVendorContact");
			_alreadyFetchedContactTypeCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedContactTypeCollectionViaVendorContact");
			_creditCardCollectionViaContactCreditCard = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaContactCreditCard", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaContactCreditCard = info.GetBoolean("_alwaysFetchCreditCardCollectionViaContactCreditCard");
			_alreadyFetchedCreditCardCollectionViaContactCreditCard = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaContactCreditCard");
			_creditCardCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader");
			_currencyRateCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader");
			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");
			_customerViewRelatedCollectionViaSalesOrderHeader__ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader__", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__");
			_employeeCollectionViaEmployee = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployee", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployee = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployee");
			_alreadyFetchedEmployeeCollectionViaEmployee = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployee");
			_salesPersonCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader");
			_salesTerritoryCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader");
			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");
			_storeCollectionViaStoreContact = (AW.Data.CollectionClasses.StoreCollection)info.GetValue("_storeCollectionViaStoreContact", typeof(AW.Data.CollectionClasses.StoreCollection));
			_alwaysFetchStoreCollectionViaStoreContact = info.GetBoolean("_alwaysFetchStoreCollectionViaStoreContact");
			_alreadyFetchedStoreCollectionViaStoreContact = info.GetBoolean("_alreadyFetchedStoreCollectionViaStoreContact");
			_vendorCollectionViaVendorContact = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaVendorContact", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaVendorContact = info.GetBoolean("_alwaysFetchVendorCollectionViaVendorContact");
			_alreadyFetchedVendorCollectionViaVendorContact = info.GetBoolean("_alreadyFetchedVendorCollectionViaVendorContact");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ContactFieldIndex)fieldIndex)
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
			_alreadyFetchedContactCreditCard = (_contactCreditCard.Count > 0);
			_alreadyFetchedEmployees = (_employees.Count > 0);
			_alreadyFetchedIndividuals = (_individuals.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedStoreContact = (_storeContact.Count > 0);
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = (_addressCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = (_addressCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedContactTypeCollectionViaStoreContact = (_contactTypeCollectionViaStoreContact.Count > 0);
			_alreadyFetchedContactTypeCollectionViaVendorContact = (_contactTypeCollectionViaVendorContact.Count > 0);
			_alreadyFetchedCreditCardCollectionViaContactCreditCard = (_creditCardCollectionViaContactCreditCard.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = (_creditCardCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = (_currencyRateCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = (_customerViewRelatedCollectionViaSalesOrderHeader__.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployee = (_employeeCollectionViaEmployee.Count > 0);
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = (_salesPersonCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = (_salesTerritoryCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedStoreCollectionViaStoreContact = (_storeCollectionViaStoreContact.Count > 0);
			_alreadyFetchedVendorCollectionViaVendorContact = (_vendorCollectionViaVendorContact.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ContactEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ContactCreditCard":
					toReturn.Add(ContactEntity.Relations.ContactCreditCardEntityUsingContactID);
					break;
				case "Employees":
					toReturn.Add(ContactEntity.Relations.EmployeeEntityUsingContactID);
					break;
				case "Individuals":
					toReturn.Add(ContactEntity.Relations.IndividualEntityUsingContactID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID);
					break;
				case "StoreContact":
					toReturn.Add(ContactEntity.Relations.StoreContactEntityUsingContactID);
					break;
				case "VendorContact":
					toReturn.Add(ContactEntity.Relations.VendorContactEntityUsingContactID);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactTypeCollectionViaStoreContact":
					toReturn.Add(ContactEntity.Relations.StoreContactEntityUsingContactID, "ContactEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.ContactTypeEntityUsingContactTypeID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "ContactTypeCollectionViaVendorContact":
					toReturn.Add(ContactEntity.Relations.VendorContactEntityUsingContactID, "ContactEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.ContactTypeEntityUsingContactTypeID, "VendorContact_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaContactCreditCard":
					toReturn.Add(ContactEntity.Relations.ContactCreditCardEntityUsingContactID, "ContactEntity__", "ContactCreditCard_", JoinHint.None);
					toReturn.Add(ContactCreditCardEntity.Relations.CreditCardEntityUsingCreditCardID, "ContactCreditCard_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader__":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaEmployee":
					toReturn.Add(ContactEntity.Relations.EmployeeEntityUsingContactID, "ContactEntity__", "Employee_", JoinHint.None);
					toReturn.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerID, "Employee_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "StoreCollectionViaStoreContact":
					toReturn.Add(ContactEntity.Relations.StoreContactEntityUsingContactID, "ContactEntity__", "StoreContact_", JoinHint.None);
					toReturn.Add(StoreContactEntity.Relations.StoreEntityUsingCustomerID, "StoreContact_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaVendorContact":
					toReturn.Add(ContactEntity.Relations.VendorContactEntityUsingContactID, "ContactEntity__", "VendorContact_", JoinHint.None);
					toReturn.Add(VendorContactEntity.Relations.VendorEntityUsingVendorID, "VendorContact_", string.Empty, JoinHint.None);
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
			info.AddValue("_contactCreditCard", (!this.MarkedForDeletion?_contactCreditCard:null));
			info.AddValue("_alwaysFetchContactCreditCard", _alwaysFetchContactCreditCard);
			info.AddValue("_alreadyFetchedContactCreditCard", _alreadyFetchedContactCreditCard);
			info.AddValue("_employees", (!this.MarkedForDeletion?_employees:null));
			info.AddValue("_alwaysFetchEmployees", _alwaysFetchEmployees);
			info.AddValue("_alreadyFetchedEmployees", _alreadyFetchedEmployees);
			info.AddValue("_individuals", (!this.MarkedForDeletion?_individuals:null));
			info.AddValue("_alwaysFetchIndividuals", _alwaysFetchIndividuals);
			info.AddValue("_alreadyFetchedIndividuals", _alreadyFetchedIndividuals);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_storeContact", (!this.MarkedForDeletion?_storeContact:null));
			info.AddValue("_alwaysFetchStoreContact", _alwaysFetchStoreContact);
			info.AddValue("_alreadyFetchedStoreContact", _alreadyFetchedStoreContact);
			info.AddValue("_vendorContact", (!this.MarkedForDeletion?_vendorContact:null));
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_addressCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader_", _alwaysFetchAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader_", _alreadyFetchedAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_addressCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader", _alwaysFetchAddressCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader", _alreadyFetchedAddressCollectionViaSalesOrderHeader);
			info.AddValue("_contactTypeCollectionViaStoreContact", (!this.MarkedForDeletion?_contactTypeCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchContactTypeCollectionViaStoreContact", _alwaysFetchContactTypeCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedContactTypeCollectionViaStoreContact", _alreadyFetchedContactTypeCollectionViaStoreContact);
			info.AddValue("_contactTypeCollectionViaVendorContact", (!this.MarkedForDeletion?_contactTypeCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchContactTypeCollectionViaVendorContact", _alwaysFetchContactTypeCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedContactTypeCollectionViaVendorContact", _alreadyFetchedContactTypeCollectionViaVendorContact);
			info.AddValue("_creditCardCollectionViaContactCreditCard", (!this.MarkedForDeletion?_creditCardCollectionViaContactCreditCard:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaContactCreditCard", _alwaysFetchCreditCardCollectionViaContactCreditCard);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaContactCreditCard", _alreadyFetchedCreditCardCollectionViaContactCreditCard);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader", _alwaysFetchCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader__", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader__:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__);
			info.AddValue("_employeeCollectionViaEmployee", (!this.MarkedForDeletion?_employeeCollectionViaEmployee:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployee", _alwaysFetchEmployeeCollectionViaEmployee);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployee", _alreadyFetchedEmployeeCollectionViaEmployee);
			info.AddValue("_salesPersonCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesPersonCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader", _alwaysFetchSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader", _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_storeCollectionViaStoreContact", (!this.MarkedForDeletion?_storeCollectionViaStoreContact:null));
			info.AddValue("_alwaysFetchStoreCollectionViaStoreContact", _alwaysFetchStoreCollectionViaStoreContact);
			info.AddValue("_alreadyFetchedStoreCollectionViaStoreContact", _alreadyFetchedStoreCollectionViaStoreContact);
			info.AddValue("_vendorCollectionViaVendorContact", (!this.MarkedForDeletion?_vendorCollectionViaVendorContact:null));
			info.AddValue("_alwaysFetchVendorCollectionViaVendorContact", _alwaysFetchVendorCollectionViaVendorContact);
			info.AddValue("_alreadyFetchedVendorCollectionViaVendorContact", _alreadyFetchedVendorCollectionViaVendorContact);


			
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

				case "ContactCreditCard":
					_alreadyFetchedContactCreditCard = true;
					if(entity!=null)
					{
						this.ContactCreditCard.Add((ContactCreditCardEntity)entity);
					}
					break;
				case "Employees":
					_alreadyFetchedEmployees = true;
					if(entity!=null)
					{
						this.Employees.Add((EmployeeEntity)entity);
					}
					break;
				case "Individuals":
					_alreadyFetchedIndividuals = true;
					if(entity!=null)
					{
						this.Individuals.Add((IndividualEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "StoreContact":
					_alreadyFetchedStoreContact = true;
					if(entity!=null)
					{
						this.StoreContact.Add((StoreContactEntity)entity);
					}
					break;
				case "VendorContact":
					_alreadyFetchedVendorContact = true;
					if(entity!=null)
					{
						this.VendorContact.Add((VendorContactEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader_.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					}
					break;
				case "ContactTypeCollectionViaStoreContact":
					_alreadyFetchedContactTypeCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.ContactTypeCollectionViaStoreContact.Add((ContactTypeEntity)entity);
					}
					break;
				case "ContactTypeCollectionViaVendorContact":
					_alreadyFetchedContactTypeCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.ContactTypeCollectionViaVendorContact.Add((ContactTypeEntity)entity);
					}
					break;
				case "CreditCardCollectionViaContactCreditCard":
					_alreadyFetchedCreditCardCollectionViaContactCreditCard = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaContactCreditCard.Add((CreditCardEntity)entity);
					}
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaSalesOrderHeader.Add((CreditCardEntity)entity);
					}
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CurrencyRateCollectionViaSalesOrderHeader.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					_alreadyFetchedCustomerCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaSalesOrderHeader.Add((CustomerEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader__":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader__.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployee":
					_alreadyFetchedEmployeeCollectionViaEmployee = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployee.Add((EmployeeEntity)entity);
					}
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesPersonCollectionViaSalesOrderHeader.Add((SalesPersonEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
					}
					break;
				case "StoreCollectionViaStoreContact":
					_alreadyFetchedStoreCollectionViaStoreContact = true;
					if(entity!=null)
					{
						this.StoreCollectionViaStoreContact.Add((StoreEntity)entity);
					}
					break;
				case "VendorCollectionViaVendorContact":
					_alreadyFetchedVendorCollectionViaVendorContact = true;
					if(entity!=null)
					{
						this.VendorCollectionViaVendorContact.Add((VendorEntity)entity);
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

				case "ContactCreditCard":
					_contactCreditCard.Add((ContactCreditCardEntity)relatedEntity);
					break;
				case "Employees":
					_employees.Add((EmployeeEntity)relatedEntity);
					break;
				case "Individuals":
					_individuals.Add((IndividualEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "StoreContact":
					_storeContact.Add((StoreContactEntity)relatedEntity);
					break;
				case "VendorContact":
					_vendorContact.Add((VendorContactEntity)relatedEntity);
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

				case "ContactCreditCard":
					base.PerformRelatedEntityRemoval(_contactCreditCard, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Employees":
					base.PerformRelatedEntityRemoval(_employees, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Individuals":
					base.PerformRelatedEntityRemoval(_individuals, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					base.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "StoreContact":
					base.PerformRelatedEntityRemoval(_storeContact, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorContact":
					base.PerformRelatedEntityRemoval(_vendorContact, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_contactCreditCard);
			toReturn.Add(_employees);
			toReturn.Add(_individuals);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_storeContact);
			toReturn.Add(_vendorContact);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID)
		{
			return FetchUsingPK(contactID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(contactID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ContactFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ContactFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ContactRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch)
		{
			return GetMultiContactCreditCard(forceFetch, _contactCreditCard.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiContactCreditCard(forceFetch, _contactCreditCard.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiContactCreditCard(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedContactCreditCard || forceFetch || _alwaysFetchContactCreditCard) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCreditCard);
					}
				}
				_contactCreditCard.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCreditCard.GetMultiManyToOne(this, null, filter);
				_contactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCard = true;
			}
			return _contactCreditCard;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCreditCard'. These settings will be taken into account
		/// when the property ContactCreditCard is requested or GetMultiContactCreditCard is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCreditCard.SortClauses=sortClauses;
			_contactCreditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployees(forceFetch, _employees.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployees(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployees(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployees || forceFetch || _alwaysFetchEmployees) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employees.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employees);
					}
				}
				_employees.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employees.EntityFactoryToUse = entityFactoryToUse;
				}
				_employees.GetMultiManyToOne(this, null, filter);
				_employees.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployees = true;
			}
			return _employees;
		}

		/// <summary> Sets the collection parameters for the collection for 'Employees'. These settings will be taken into account
		/// when the property Employees is requested or GetMultiEmployees is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployees(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employees.SortClauses=sortClauses;
			_employees.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch)
		{
			return GetMultiIndividuals(forceFetch, _individuals.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIndividuals(forceFetch, _individuals.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIndividuals(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.IndividualCollection GetMultiIndividuals(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIndividuals || forceFetch || _alwaysFetchIndividuals) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_individuals.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individuals);
					}
				}
				_individuals.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_individuals.EntityFactoryToUse = entityFactoryToUse;
				}
				_individuals.GetMultiManyToOne(this, filter);
				_individuals.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividuals = true;
			}
			return _individuals;
		}

		/// <summary> Sets the collection parameters for the collection for 'Individuals'. These settings will be taken into account
		/// when the property Individuals is requested or GetMultiIndividuals is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIndividuals(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_individuals.SortClauses=sortClauses;
			_individuals.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaders || forceFetch || _alwaysFetchSalesOrderHeaders) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaders.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaders);
					}
				}
				_salesOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeaders.GetMultiManyToOne(null, null, this, null, null, null, null, null, null, null, filter);
				_salesOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaders = true;
			}
			return _salesOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaders'. These settings will be taken into account
		/// when the property SalesOrderHeaders is requested or GetMultiSalesOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaders.SortClauses=sortClauses;
			_salesOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch)
		{
			return GetMultiStoreContact(forceFetch, _storeContact.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStoreContact(forceFetch, _storeContact.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStoreContact(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_storeContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_storeContact.GetMultiManyToOne(this, null, null, filter);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'StoreContact'. These settings will be taken into account
		/// when the property StoreContact is requested or GetMultiStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeContact.SortClauses=sortClauses;
			_storeContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorContact(forceFetch, _vendorContact.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorContact(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorContact.GetMultiManyToOne(this, null, null, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorContact'. These settings will be taken into account
		/// when the property VendorContact is requested or GetMultiVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContact.SortClauses=sortClauses;
			_vendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiAddressCollectionViaSalesOrderHeader_(forceFetch, _addressCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchAddressCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_addressCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"));
				_addressCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
			}
			return _addressCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property AddressCollectionViaSalesOrderHeader_ is requested or GetMultiAddressCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_addressCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiAddressCollectionViaSalesOrderHeader(forceFetch, _addressCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchAddressCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_addressCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("AddressCollectionViaSalesOrderHeader"));
				_addressCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
			}
			return _addressCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property AddressCollectionViaSalesOrderHeader is requested or GetMultiAddressCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_addressCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaStoreContact(bool forceFetch)
		{
			return GetMultiContactTypeCollectionViaStoreContact(forceFetch, _contactTypeCollectionViaStoreContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactTypeCollectionViaStoreContact || forceFetch || _alwaysFetchContactTypeCollectionViaStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactTypeCollectionViaStoreContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactTypeCollectionViaStoreContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_contactTypeCollectionViaStoreContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactTypeCollectionViaStoreContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactTypeCollectionViaStoreContact.GetMulti(filter, GetRelationsForField("ContactTypeCollectionViaStoreContact"));
				_contactTypeCollectionViaStoreContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactTypeCollectionViaStoreContact = true;
			}
			return _contactTypeCollectionViaStoreContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactTypeCollectionViaStoreContact'. These settings will be taken into account
		/// when the property ContactTypeCollectionViaStoreContact is requested or GetMultiContactTypeCollectionViaStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactTypeCollectionViaStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactTypeCollectionViaStoreContact.SortClauses=sortClauses;
			_contactTypeCollectionViaStoreContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiContactTypeCollectionViaVendorContact(forceFetch, _contactTypeCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactTypeCollection GetMultiContactTypeCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactTypeCollectionViaVendorContact || forceFetch || _alwaysFetchContactTypeCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactTypeCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactTypeCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_contactTypeCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactTypeCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactTypeCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("ContactTypeCollectionViaVendorContact"));
				_contactTypeCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedContactTypeCollectionViaVendorContact = true;
			}
			return _contactTypeCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactTypeCollectionViaVendorContact'. These settings will be taken into account
		/// when the property ContactTypeCollectionViaVendorContact is requested or GetMultiContactTypeCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactTypeCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactTypeCollectionViaVendorContact.SortClauses=sortClauses;
			_contactTypeCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaContactCreditCard(bool forceFetch)
		{
			return GetMultiCreditCardCollectionViaContactCreditCard(forceFetch, _creditCardCollectionViaContactCreditCard.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCardCollectionViaContactCreditCard || forceFetch || _alwaysFetchCreditCardCollectionViaContactCreditCard) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCardCollectionViaContactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCardCollectionViaContactCreditCard);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_creditCardCollectionViaContactCreditCard.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_creditCardCollectionViaContactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				}
				_creditCardCollectionViaContactCreditCard.GetMulti(filter, GetRelationsForField("CreditCardCollectionViaContactCreditCard"));
				_creditCardCollectionViaContactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCardCollectionViaContactCreditCard = true;
			}
			return _creditCardCollectionViaContactCreditCard;
		}

		/// <summary> Sets the collection parameters for the collection for 'CreditCardCollectionViaContactCreditCard'. These settings will be taken into account
		/// when the property CreditCardCollectionViaContactCreditCard is requested or GetMultiCreditCardCollectionViaContactCreditCard is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCardCollectionViaContactCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCardCollectionViaContactCreditCard.SortClauses=sortClauses;
			_creditCardCollectionViaContactCreditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCreditCardCollectionViaSalesOrderHeader(forceFetch, _creditCardCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCardCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCreditCardCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCardCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCardCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_creditCardCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_creditCardCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_creditCardCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"));
				_creditCardCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = true;
			}
			return _creditCardCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CreditCardCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CreditCardCollectionViaSalesOrderHeader is requested or GetMultiCreditCardCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCardCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCardCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_creditCardCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRateCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCurrencyRateCollectionViaSalesOrderHeader(forceFetch, _currencyRateCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRateCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRateCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRateCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_currencyRateCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_currencyRateCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_currencyRateCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"));
				_currencyRateCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = true;
			}
			return _currencyRateCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CurrencyRateCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CurrencyRateCollectionViaSalesOrderHeader is requested or GetMultiCurrencyRateCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRateCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRateCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_currencyRateCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaSalesOrderHeader(forceFetch, _customerCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCustomerCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_customerCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"));
				_customerCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader = true;
			}
			return _customerCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CustomerCollectionViaSalesOrderHeader is requested or GetMultiCustomerCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_customerCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader__.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader__.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader__"));
				_customerViewRelatedCollectionViaSalesOrderHeader__.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader__;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader__'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader__ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader__.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployee(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaEmployee(forceFetch, _employeeCollectionViaEmployee.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaEmployee || forceFetch || _alwaysFetchEmployeeCollectionViaEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaEmployee);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_employeeCollectionViaEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaEmployee.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaEmployee"));
				_employeeCollectionViaEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaEmployee = true;
			}
			return _employeeCollectionViaEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaEmployee'. These settings will be taken into account
		/// when the property EmployeeCollectionViaEmployee is requested or GetMultiEmployeeCollectionViaEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaEmployee.SortClauses=sortClauses;
			_employeeCollectionViaEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPersonCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiSalesPersonCollectionViaSalesOrderHeader(forceFetch, _salesPersonCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPersonCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchSalesPersonCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_salesPersonCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesPersonCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesPersonCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"));
				_salesPersonCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = true;
			}
			return _salesPersonCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesPersonCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property SalesPersonCollectionViaSalesOrderHeader is requested or GetMultiSalesPersonCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPersonCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPersonCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_salesPersonCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiSalesTerritoryCollectionViaSalesOrderHeader(forceFetch, _salesTerritoryCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_salesTerritoryCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesTerritoryCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesTerritoryCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"));
				_salesTerritoryCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = true;
			}
			return _salesTerritoryCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTerritoryCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property SalesTerritoryCollectionViaSalesOrderHeader is requested or GetMultiSalesTerritoryCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_salesTerritoryCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiShipMethodCollectionViaSalesOrderHeader(forceFetch, _shipMethodCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethodCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchShipMethodCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethodCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethodCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_shipMethodCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shipMethodCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_shipMethodCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"));
				_shipMethodCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
			}
			return _shipMethodCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShipMethodCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property ShipMethodCollectionViaSalesOrderHeader is requested or GetMultiShipMethodCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethodCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethodCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_shipMethodCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStoreCollectionViaStoreContact(bool forceFetch)
		{
			return GetMultiStoreCollectionViaStoreContact(forceFetch, _storeCollectionViaStoreContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StoreCollection GetMultiStoreCollectionViaStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStoreCollectionViaStoreContact || forceFetch || _alwaysFetchStoreCollectionViaStoreContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_storeCollectionViaStoreContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeCollectionViaStoreContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_storeCollectionViaStoreContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_storeCollectionViaStoreContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_storeCollectionViaStoreContact.GetMulti(filter, GetRelationsForField("StoreCollectionViaStoreContact"));
				_storeCollectionViaStoreContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreCollectionViaStoreContact = true;
			}
			return _storeCollectionViaStoreContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'StoreCollectionViaStoreContact'. These settings will be taken into account
		/// when the property StoreCollectionViaStoreContact is requested or GetMultiStoreCollectionViaStoreContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreCollectionViaStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeCollectionViaStoreContact.SortClauses=sortClauses;
			_storeCollectionViaStoreContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorContact(bool forceFetch)
		{
			return GetMultiVendorCollectionViaVendorContact(forceFetch, _vendorCollectionViaVendorContact.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorCollectionViaVendorContact || forceFetch || _alwaysFetchVendorCollectionViaVendorContact) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorCollectionViaVendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorCollectionViaVendorContact);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactID, ComparisonOperator.Equal, this.ContactID, "ContactEntity__"));
				_vendorCollectionViaVendorContact.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorCollectionViaVendorContact.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorCollectionViaVendorContact.GetMulti(filter, GetRelationsForField("VendorCollectionViaVendorContact"));
				_vendorCollectionViaVendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorCollectionViaVendorContact = true;
			}
			return _vendorCollectionViaVendorContact;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorCollectionViaVendorContact'. These settings will be taken into account
		/// when the property VendorCollectionViaVendorContact is requested or GetMultiVendorCollectionViaVendorContact is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorCollectionViaVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorCollectionViaVendorContact.SortClauses=sortClauses;
			_vendorCollectionViaVendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_contactCreditCard.ActiveContext = base.ActiveContext;
			_employees.ActiveContext = base.ActiveContext;
			_individuals.ActiveContext = base.ActiveContext;
			_salesOrderHeaders.ActiveContext = base.ActiveContext;
			_storeContact.ActiveContext = base.ActiveContext;
			_vendorContact.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_contactTypeCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			_contactTypeCollectionViaVendorContact.ActiveContext = base.ActiveContext;
			_creditCardCollectionViaContactCreditCard.ActiveContext = base.ActiveContext;
			_creditCardCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_currencyRateCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader__.ActiveContext = base.ActiveContext;
			_employeeCollectionViaEmployee.ActiveContext = base.ActiveContext;
			_salesPersonCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_salesTerritoryCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_storeCollectionViaStoreContact.ActiveContext = base.ActiveContext;
			_vendorCollectionViaVendorContact.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ContactEntity);
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

			toReturn.Add("ContactCreditCard", _contactCreditCard);
			toReturn.Add("Employees", _employees);
			toReturn.Add("Individuals", _individuals);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("StoreContact", _storeContact);
			toReturn.Add("VendorContact", _vendorContact);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("ContactTypeCollectionViaStoreContact", _contactTypeCollectionViaStoreContact);
			toReturn.Add("ContactTypeCollectionViaVendorContact", _contactTypeCollectionViaVendorContact);
			toReturn.Add("CreditCardCollectionViaContactCreditCard", _creditCardCollectionViaContactCreditCard);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader__", _customerViewRelatedCollectionViaSalesOrderHeader__);
			toReturn.Add("EmployeeCollectionViaEmployee", _employeeCollectionViaEmployee);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("StoreCollectionViaStoreContact", _storeCollectionViaStoreContact);
			toReturn.Add("VendorCollectionViaVendorContact", _vendorCollectionViaVendorContact);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The validator object for this ContactEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 contactID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(contactID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_contactCreditCard = new AW.Data.CollectionClasses.ContactCreditCardCollection(new ContactCreditCardEntityFactory());
			_contactCreditCard.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchContactCreditCard = false;
			_alreadyFetchedContactCreditCard = false;
			_employees = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_employees.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchEmployees = false;
			_alreadyFetchedEmployees = false;
			_individuals = new AW.Data.CollectionClasses.IndividualCollection(new IndividualEntityFactory());
			_individuals.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchIndividuals = false;
			_alreadyFetchedIndividuals = false;
			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeaders.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchSalesOrderHeaders = false;
			_alreadyFetchedSalesOrderHeaders = false;
			_storeContact = new AW.Data.CollectionClasses.StoreContactCollection(new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_vendorContact = new AW.Data.CollectionClasses.VendorContactCollection(new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_addressCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = false;
			_addressCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = false;
			_contactTypeCollectionViaStoreContact = new AW.Data.CollectionClasses.ContactTypeCollection(new ContactTypeEntityFactory());
			_alwaysFetchContactTypeCollectionViaStoreContact = false;
			_alreadyFetchedContactTypeCollectionViaStoreContact = false;
			_contactTypeCollectionViaVendorContact = new AW.Data.CollectionClasses.ContactTypeCollection(new ContactTypeEntityFactory());
			_alwaysFetchContactTypeCollectionViaVendorContact = false;
			_alreadyFetchedContactTypeCollectionViaVendorContact = false;
			_creditCardCollectionViaContactCreditCard = new AW.Data.CollectionClasses.CreditCardCollection(new CreditCardEntityFactory());
			_alwaysFetchCreditCardCollectionViaContactCreditCard = false;
			_alreadyFetchedCreditCardCollectionViaContactCreditCard = false;
			_creditCardCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CreditCardCollection(new CreditCardEntityFactory());
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = false;
			_currencyRateCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = false;
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = false;
			_customerViewRelatedCollectionViaSalesOrderHeader__ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = false;
			_employeeCollectionViaEmployee = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaEmployee = false;
			_alreadyFetchedEmployeeCollectionViaEmployee = false;
			_salesPersonCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesPersonCollection(new SalesPersonEntityFactory());
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = false;
			_salesTerritoryCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesTerritoryCollection(new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = false;
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = false;
			_storeCollectionViaStoreContact = new AW.Data.CollectionClasses.StoreCollection(new StoreEntityFactory());
			_alwaysFetchStoreCollectionViaStoreContact = false;
			_alreadyFetchedStoreCollectionViaStoreContact = false;
			_vendorCollectionViaVendorContact = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaVendorContact = false;
			_alreadyFetchedVendorCollectionViaVendorContact = false;



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
			_customProperties.Add("MS_Description", @"Primary XML index.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key for Contact records.");
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("NameStyle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"A courtesy title. For example, Mr. or Ms.");
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"First name of the person.");
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Middle name or middle initial of the person.");
			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Last name of the person.");
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Surname suffix. For example, Sr. or Jr.");
			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"E-mail address for the person.");
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");
			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Phone number associated with the person.");
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Password for the e-mail account.");
			_fieldsCustomProperties.Add("PasswordHash", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Random value concatenated with the password string before the password is hashed.");
			_fieldsCustomProperties.Add("PasswordSalt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Additional contact information about the person stored in xml format. ");
			_fieldsCustomProperties.Add("AdditionalContactInfo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ContactFieldIndex.ContactID].ForcedCurrentValueWrite(contactID);
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
			return DAOFactory.CreateContactDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ContactEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ContactRelations Relations
		{
			get	{ return new ContactRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactCreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCreditCard
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCreditCardCollection(),
					(IEntityRelation)GetRelationsForField("ContactCreditCard")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ContactCreditCardEntity, 0, null, null, null, "ContactCreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployees
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employees")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employees", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Individual' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIndividuals
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.IndividualCollection(),
					(IEntityRelation)GetRelationsForField("Individuals")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.IndividualEntity, 0, null, null, null, "Individuals", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreContactCollection(),
					(IEntityRelation)GetRelationsForField("StoreContact")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.StoreContactEntity, 0, null, null, null, "StoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(),
					(IEntityRelation)GetRelationsForField("VendorContact")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactTypeCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.StoreContactEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ContactTypeEntity, 0, null, null, GetRelationsForField("ContactTypeCollectionViaStoreContact"), "ContactTypeCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactTypeCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.VendorContactEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ContactTypeEntity, 0, null, null, GetRelationsForField("ContactTypeCollectionViaVendorContact"), "ContactTypeCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaContactCreditCard
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.ContactCreditCardEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "ContactCreditCard_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaContactCreditCard"), "CreditCardCollectionViaContactCreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader__
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader__"), "CustomerViewRelatedCollectionViaSalesOrderHeader__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.EmployeeEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "Employee_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployee"), "EmployeeCollectionViaEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreCollectionViaStoreContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.StoreContactEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "StoreContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StoreCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.StoreEntity, 0, null, null, GetRelationsForField("StoreCollectionViaStoreContact"), "StoreCollectionViaStoreContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaVendorContact
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.VendorContactEntityUsingContactID;
				intermediateRelation.SetAliases(string.Empty, "VendorContact_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaVendorContact"), "VendorCollectionViaVendorContact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ContactEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ContactEntity.CustomProperties;}
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
			get { return ContactEntity.FieldsCustomProperties;}
		}

		/// <summary> The ContactID property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Primary key for Contact records.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)ContactFieldIndex.ContactID, true); }
			set	{ SetValue((int)ContactFieldIndex.ContactID, value, true); }
		}
		/// <summary> The NameStyle property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."NameStyle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean NameStyle
		{
			get { return (System.Boolean)GetValue((int)ContactFieldIndex.NameStyle, true); }
			set	{ SetValue((int)ContactFieldIndex.NameStyle, value, true); }
		}
		/// <summary> The Title property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: A courtesy title. For example, Mr. or Ms.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Title, true); }
			set	{ SetValue((int)ContactFieldIndex.Title, value, true); }
		}
		/// <summary> The FirstName property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: First name of the person.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.FirstName, true); }
			set	{ SetValue((int)ContactFieldIndex.FirstName, value, true); }
		}
		/// <summary> The MiddleName property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Middle name or middle initial of the person.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.MiddleName, true); }
			set	{ SetValue((int)ContactFieldIndex.MiddleName, value, true); }
		}
		/// <summary> The LastName property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Last name of the person.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.LastName, true); }
			set	{ SetValue((int)ContactFieldIndex.LastName, value, true); }
		}
		/// <summary> The Suffix property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Surname suffix. For example, Sr. or Jr.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."Suffix"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Suffix
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Suffix, true); }
			set	{ SetValue((int)ContactFieldIndex.Suffix, value, true); }
		}
		/// <summary> The EmailAddress property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: E-mail address for the person.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailAddress, value, true); }
		}
		/// <summary> The EmailPromotion property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. <br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailPromotion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmailPromotion
		{
			get { return (System.Int32)GetValue((int)ContactFieldIndex.EmailPromotion, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailPromotion, value, true); }
		}
		/// <summary> The Phone property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Phone number associated with the person.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Phone, true); }
			set	{ SetValue((int)ContactFieldIndex.Phone, value, true); }
		}
		/// <summary> The PasswordHash property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Password for the e-mail account.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordHash"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordHash, value, true); }
		}
		/// <summary> The PasswordSalt property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Random value concatenated with the password string before the password is hashed.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordSalt"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordSalt, value, true); }
		}
		/// <summary> The AdditionalContactInfo property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Additional contact information about the person stored in xml format. <br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."AdditionalContactInfo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AdditionalContactInfo
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.AdditionalContactInfo, true); }
			set	{ SetValue((int)ContactFieldIndex.AdditionalContactInfo, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ContactFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ContactFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Contact<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Contact"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection ContactCreditCard
		{
			get	{ return GetMultiContactCreditCard(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCreditCard. When set to true, ContactCreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCreditCard is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCreditCard(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCreditCard
		{
			get	{ return _alwaysFetchContactCreditCard; }
			set	{ _alwaysFetchContactCreditCard = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCreditCard already has been fetched. Setting this property to false when ContactCreditCard has been fetched
		/// will clear the ContactCreditCard collection well. Setting this property to true while ContactCreditCard hasn't been fetched disables lazy loading for ContactCreditCard</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCreditCard
		{
			get { return _alreadyFetchedContactCreditCard;}
			set 
			{
				if(_alreadyFetchedContactCreditCard && !value && (_contactCreditCard != null))
				{
					_contactCreditCard.Clear();
				}
				_alreadyFetchedContactCreditCard = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployees()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection Employees
		{
			get	{ return GetMultiEmployees(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Employees. When set to true, Employees is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employees is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployees(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployees
		{
			get	{ return _alwaysFetchEmployees; }
			set	{ _alwaysFetchEmployees = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employees already has been fetched. Setting this property to false when Employees has been fetched
		/// will clear the Employees collection well. Setting this property to true while Employees hasn't been fetched disables lazy loading for Employees</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployees
		{
			get { return _alreadyFetchedEmployees;}
			set 
			{
				if(_alreadyFetchedEmployees && !value && (_employees != null))
				{
					_employees.Clear();
				}
				_alreadyFetchedEmployees = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIndividuals()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.IndividualCollection Individuals
		{
			get	{ return GetMultiIndividuals(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Individuals. When set to true, Individuals is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individuals is accessed. You can always execute
		/// a forced fetch by calling GetMultiIndividuals(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividuals
		{
			get	{ return _alwaysFetchIndividuals; }
			set	{ _alwaysFetchIndividuals = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Individuals already has been fetched. Setting this property to false when Individuals has been fetched
		/// will clear the Individuals collection well. Setting this property to true while Individuals hasn't been fetched disables lazy loading for Individuals</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIndividuals
		{
			get { return _alreadyFetchedIndividuals;}
			set 
			{
				if(_alreadyFetchedIndividuals && !value && (_individuals != null))
				{
					_individuals.Clear();
				}
				_alreadyFetchedIndividuals = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders
		{
			get	{ return GetMultiSalesOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders. When set to true, SalesOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaders
		{
			get	{ return _alwaysFetchSalesOrderHeaders; }
			set	{ _alwaysFetchSalesOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaders already has been fetched. Setting this property to false when SalesOrderHeaders has been fetched
		/// will clear the SalesOrderHeaders collection well. Setting this property to true while SalesOrderHeaders hasn't been fetched disables lazy loading for SalesOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaders
		{
			get { return _alreadyFetchedSalesOrderHeaders;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaders && !value && (_salesOrderHeaders != null))
				{
					_salesOrderHeaders.Clear();
				}
				_alreadyFetchedSalesOrderHeaders = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreContactCollection StoreContact
		{
			get	{ return GetMultiStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StoreContact. When set to true, StoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreContact
		{
			get	{ return _alwaysFetchStoreContact; }
			set	{ _alwaysFetchStoreContact = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreContact already has been fetched. Setting this property to false when StoreContact has been fetched
		/// will clear the StoreContact collection well. Setting this property to true while StoreContact hasn't been fetched disables lazy loading for StoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreContact
		{
			get { return _alreadyFetchedStoreContact;}
			set 
			{
				if(_alreadyFetchedStoreContact && !value && (_storeContact != null))
				{
					_storeContact.Clear();
				}
				_alreadyFetchedStoreContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorContactCollection VendorContact
		{
			get	{ return GetMultiVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorContact. When set to true, VendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContact
		{
			get	{ return _alwaysFetchVendorContact; }
			set	{ _alwaysFetchVendorContact = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorContact already has been fetched. Setting this property to false when VendorContact has been fetched
		/// will clear the VendorContact collection well. Setting this property to true while VendorContact hasn't been fetched disables lazy loading for VendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorContact
		{
			get { return _alreadyFetchedVendorContact;}
			set 
			{
				if(_alreadyFetchedVendorContact && !value && (_vendorContact != null))
				{
					_vendorContact.Clear();
				}
				_alreadyFetchedVendorContact = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaSalesOrderHeader_
		{
			get { return GetMultiAddressCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaSalesOrderHeader_. When set to true, AddressCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchAddressCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchAddressCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when AddressCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the AddressCollectionViaSalesOrderHeader_ collection well. Setting this property to true while AddressCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for AddressCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedAddressCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaSalesOrderHeader_ && !value && (_addressCollectionViaSalesOrderHeader_ != null))
				{
					_addressCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaSalesOrderHeader
		{
			get { return GetMultiAddressCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaSalesOrderHeader. When set to true, AddressCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchAddressCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchAddressCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when AddressCollectionViaSalesOrderHeader has been fetched
		/// will clear the AddressCollectionViaSalesOrderHeader collection well. Setting this property to true while AddressCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for AddressCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedAddressCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaSalesOrderHeader && !value && (_addressCollectionViaSalesOrderHeader != null))
				{
					_addressCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedAddressCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactTypeCollectionViaStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactTypeCollection ContactTypeCollectionViaStoreContact
		{
			get { return GetMultiContactTypeCollectionViaStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactTypeCollectionViaStoreContact. When set to true, ContactTypeCollectionViaStoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactTypeCollectionViaStoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactTypeCollectionViaStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactTypeCollectionViaStoreContact
		{
			get	{ return _alwaysFetchContactTypeCollectionViaStoreContact; }
			set	{ _alwaysFetchContactTypeCollectionViaStoreContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactTypeCollectionViaStoreContact already has been fetched. Setting this property to false when ContactTypeCollectionViaStoreContact has been fetched
		/// will clear the ContactTypeCollectionViaStoreContact collection well. Setting this property to true while ContactTypeCollectionViaStoreContact hasn't been fetched disables lazy loading for ContactTypeCollectionViaStoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactTypeCollectionViaStoreContact
		{
			get { return _alreadyFetchedContactTypeCollectionViaStoreContact;}
			set 
			{
				if(_alreadyFetchedContactTypeCollectionViaStoreContact && !value && (_contactTypeCollectionViaStoreContact != null))
				{
					_contactTypeCollectionViaStoreContact.Clear();
				}
				_alreadyFetchedContactTypeCollectionViaStoreContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactTypeCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactTypeCollection ContactTypeCollectionViaVendorContact
		{
			get { return GetMultiContactTypeCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactTypeCollectionViaVendorContact. When set to true, ContactTypeCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactTypeCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactTypeCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactTypeCollectionViaVendorContact
		{
			get	{ return _alwaysFetchContactTypeCollectionViaVendorContact; }
			set	{ _alwaysFetchContactTypeCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactTypeCollectionViaVendorContact already has been fetched. Setting this property to false when ContactTypeCollectionViaVendorContact has been fetched
		/// will clear the ContactTypeCollectionViaVendorContact collection well. Setting this property to true while ContactTypeCollectionViaVendorContact hasn't been fetched disables lazy loading for ContactTypeCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactTypeCollectionViaVendorContact
		{
			get { return _alreadyFetchedContactTypeCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedContactTypeCollectionViaVendorContact && !value && (_contactTypeCollectionViaVendorContact != null))
				{
					_contactTypeCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedContactTypeCollectionViaVendorContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCardCollectionViaContactCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCardCollectionViaContactCreditCard
		{
			get { return GetMultiCreditCardCollectionViaContactCreditCard(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCardCollectionViaContactCreditCard. When set to true, CreditCardCollectionViaContactCreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCardCollectionViaContactCreditCard is accessed. You can always execute
		/// a forced fetch by calling GetMultiCreditCardCollectionViaContactCreditCard(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCardCollectionViaContactCreditCard
		{
			get	{ return _alwaysFetchCreditCardCollectionViaContactCreditCard; }
			set	{ _alwaysFetchCreditCardCollectionViaContactCreditCard = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CreditCardCollectionViaContactCreditCard already has been fetched. Setting this property to false when CreditCardCollectionViaContactCreditCard has been fetched
		/// will clear the CreditCardCollectionViaContactCreditCard collection well. Setting this property to true while CreditCardCollectionViaContactCreditCard hasn't been fetched disables lazy loading for CreditCardCollectionViaContactCreditCard</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCreditCardCollectionViaContactCreditCard
		{
			get { return _alreadyFetchedCreditCardCollectionViaContactCreditCard;}
			set 
			{
				if(_alreadyFetchedCreditCardCollectionViaContactCreditCard && !value && (_creditCardCollectionViaContactCreditCard != null))
				{
					_creditCardCollectionViaContactCreditCard.Clear();
				}
				_alreadyFetchedCreditCardCollectionViaContactCreditCard = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCardCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetMultiCreditCardCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCardCollectionViaSalesOrderHeader. When set to true, CreditCardCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCardCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiCreditCardCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCardCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCreditCardCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCreditCardCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CreditCardCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CreditCardCollectionViaSalesOrderHeader has been fetched
		/// will clear the CreditCardCollectionViaSalesOrderHeader collection well. Setting this property to true while CreditCardCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CreditCardCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCreditCardCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCreditCardCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCreditCardCollectionViaSalesOrderHeader && !value && (_creditCardCollectionViaSalesOrderHeader != null))
				{
					_creditCardCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRateCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetMultiCurrencyRateCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRateCollectionViaSalesOrderHeader. When set to true, CurrencyRateCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRateCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRateCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRateCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyRateCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CurrencyRateCollectionViaSalesOrderHeader has been fetched
		/// will clear the CurrencyRateCollectionViaSalesOrderHeader collection well. Setting this property to true while CurrencyRateCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CurrencyRateCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyRateCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader && !value && (_currencyRateCollectionViaSalesOrderHeader != null))
				{
					_currencyRateCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaSalesOrderHeader
		{
			get { return GetMultiCustomerCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaSalesOrderHeader. When set to true, CustomerCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCustomerCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCustomerCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CustomerCollectionViaSalesOrderHeader has been fetched
		/// will clear the CustomerCollectionViaSalesOrderHeader collection well. Setting this property to true while CustomerCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CustomerCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCustomerCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaSalesOrderHeader && !value && (_customerCollectionViaSalesOrderHeader != null))
				{
					_customerCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader__
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader__. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader__ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader__ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader__ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader__ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader__ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader__.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaEmployee
		{
			get { return GetMultiEmployeeCollectionViaEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaEmployee. When set to true, EmployeeCollectionViaEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaEmployee
		{
			get	{ return _alwaysFetchEmployeeCollectionViaEmployee; }
			set	{ _alwaysFetchEmployeeCollectionViaEmployee = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaEmployee already has been fetched. Setting this property to false when EmployeeCollectionViaEmployee has been fetched
		/// will clear the EmployeeCollectionViaEmployee collection well. Setting this property to true while EmployeeCollectionViaEmployee hasn't been fetched disables lazy loading for EmployeeCollectionViaEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaEmployee
		{
			get { return _alreadyFetchedEmployeeCollectionViaEmployee;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaEmployee && !value && (_employeeCollectionViaEmployee != null))
				{
					_employeeCollectionViaEmployee.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaEmployee = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPersonCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection SalesPersonCollectionViaSalesOrderHeader
		{
			get { return GetMultiSalesPersonCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPersonCollectionViaSalesOrderHeader. When set to true, SalesPersonCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPersonCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPersonCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPersonCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesPersonCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchSalesPersonCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPersonCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when SalesPersonCollectionViaSalesOrderHeader has been fetched
		/// will clear the SalesPersonCollectionViaSalesOrderHeader collection well. Setting this property to true while SalesPersonCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for SalesPersonCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPersonCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader && !value && (_salesPersonCollectionViaSalesOrderHeader != null))
				{
					_salesPersonCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryCollection SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetMultiSalesTerritoryCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryCollectionViaSalesOrderHeader. When set to true, SalesTerritoryCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritoryCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritoryCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when SalesTerritoryCollectionViaSalesOrderHeader has been fetched
		/// will clear the SalesTerritoryCollectionViaSalesOrderHeader collection well. Setting this property to true while SalesTerritoryCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for SalesTerritoryCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader && !value && (_salesTerritoryCollectionViaSalesOrderHeader != null))
				{
					_salesTerritoryCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetMultiShipMethodCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaSalesOrderHeader. When set to true, ShipMethodCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethodCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethodCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchShipMethodCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchShipMethodCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethodCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when ShipMethodCollectionViaSalesOrderHeader has been fetched
		/// will clear the ShipMethodCollectionViaSalesOrderHeader collection well. Setting this property to true while ShipMethodCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for ShipMethodCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethodCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedShipMethodCollectionViaSalesOrderHeader && !value && (_shipMethodCollectionViaSalesOrderHeader != null))
				{
					_shipMethodCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreCollectionViaStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StoreCollection StoreCollectionViaStoreContact
		{
			get { return GetMultiStoreCollectionViaStoreContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StoreCollectionViaStoreContact. When set to true, StoreCollectionViaStoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreCollectionViaStoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiStoreCollectionViaStoreContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreCollectionViaStoreContact
		{
			get	{ return _alwaysFetchStoreCollectionViaStoreContact; }
			set	{ _alwaysFetchStoreCollectionViaStoreContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreCollectionViaStoreContact already has been fetched. Setting this property to false when StoreCollectionViaStoreContact has been fetched
		/// will clear the StoreCollectionViaStoreContact collection well. Setting this property to true while StoreCollectionViaStoreContact hasn't been fetched disables lazy loading for StoreCollectionViaStoreContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreCollectionViaStoreContact
		{
			get { return _alreadyFetchedStoreCollectionViaStoreContact;}
			set 
			{
				if(_alreadyFetchedStoreCollectionViaStoreContact && !value && (_storeCollectionViaStoreContact != null))
				{
					_storeCollectionViaStoreContact.Clear();
				}
				_alreadyFetchedStoreCollectionViaStoreContact = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorCollectionViaVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorCollection VendorCollectionViaVendorContact
		{
			get { return GetMultiVendorCollectionViaVendorContact(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorCollectionViaVendorContact. When set to true, VendorCollectionViaVendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorCollectionViaVendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorCollectionViaVendorContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorCollectionViaVendorContact
		{
			get	{ return _alwaysFetchVendorCollectionViaVendorContact; }
			set	{ _alwaysFetchVendorCollectionViaVendorContact = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorCollectionViaVendorContact already has been fetched. Setting this property to false when VendorCollectionViaVendorContact has been fetched
		/// will clear the VendorCollectionViaVendorContact collection well. Setting this property to true while VendorCollectionViaVendorContact hasn't been fetched disables lazy loading for VendorCollectionViaVendorContact</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorCollectionViaVendorContact
		{
			get { return _alreadyFetchedVendorCollectionViaVendorContact;}
			set 
			{
				if(_alreadyFetchedVendorCollectionViaVendorContact && !value && (_vendorCollectionViaVendorContact != null))
				{
					_vendorCollectionViaVendorContact.Clear();
				}
				_alreadyFetchedVendorCollectionViaVendorContact = value;
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
			get { return (int)AW.Data.EntityType.ContactEntity; }
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
