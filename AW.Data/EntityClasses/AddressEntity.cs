///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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

	/// <summary>Entity class which represents the entity 'Address'. <br/><br/>
	/// 
	/// MS_Description: Street address information for customers, employees, and vendors.<br/>
	/// </summary>
	[Serializable]
	public partial class AddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddresses;
		private bool	_alwaysFetchEmployeeAddresses, _alreadyFetchedEmployeeAddresses;
		private AW.Data.CollectionClasses.VendorAddressCollection	_vendorAddresses;
		private bool	_alwaysFetchVendorAddresses, _alreadyFetchedVendorAddresses;
		private AW.Data.CollectionClasses.CustomerAddressCollection	_customerAddresses;
		private bool	_alwaysFetchCustomerAddresses, _alreadyFetchedCustomerAddresses;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders_;
		private bool	_alwaysFetchSalesOrderHeaders_, _alreadyFetchedSalesOrderHeaders_;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployeeAddres;
		private bool	_alwaysFetchEmployeeCollectionViaEmployeeAddres, _alreadyFetchedEmployeeCollectionViaEmployeeAddres;
		private AW.Data.CollectionClasses.AddressTypeCollection _addressTypeCollectionViaCustomerAddres;
		private bool	_alwaysFetchAddressTypeCollectionViaCustomerAddres, _alreadyFetchedAddressTypeCollectionViaCustomerAddres;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader, _alreadyFetchedContactCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader_, _alreadyFetchedContactCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader_, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader_, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaCustomerAddres;
		private bool	_alwaysFetchCustomerCollectionViaCustomerAddres, _alreadyFetchedCustomerCollectionViaCustomerAddres;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader_, _alreadyFetchedCustomerCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_;
		private StateProvinceEntity _stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince, _stateProvinceReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
			/// <summary>Member name EmployeeAddresses</summary>
			public static readonly string EmployeeAddresses = "EmployeeAddresses";
			/// <summary>Member name VendorAddresses</summary>
			public static readonly string VendorAddresses = "VendorAddresses";
			/// <summary>Member name CustomerAddresses</summary>
			public static readonly string CustomerAddresses = "CustomerAddresses";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesOrderHeaders_</summary>
			public static readonly string SalesOrderHeaders_ = "SalesOrderHeaders_";
			/// <summary>Member name EmployeeCollectionViaEmployeeAddres</summary>
			public static readonly string EmployeeCollectionViaEmployeeAddres = "EmployeeCollectionViaEmployeeAddres";
			/// <summary>Member name AddressTypeCollectionViaCustomerAddres</summary>
			public static readonly string AddressTypeCollectionViaCustomerAddres = "AddressTypeCollectionViaCustomerAddres";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader = "ContactCollectionViaSalesOrderHeader";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader_</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader_ = "ContactCollectionViaSalesOrderHeader_";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader_</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader_ = "ShipMethodCollectionViaSalesOrderHeader_";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader_</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader_ = "CreditCardCollectionViaSalesOrderHeader_";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader_</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader_ = "CurrencyRateCollectionViaSalesOrderHeader_";
			/// <summary>Member name CustomerCollectionViaCustomerAddres</summary>
			public static readonly string CustomerCollectionViaCustomerAddres = "CustomerCollectionViaCustomerAddres";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader_</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader_ = "CustomerCollectionViaSalesOrderHeader_";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader = "CustomerViewRelatedCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader_</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader_ = "CustomerViewRelatedCollectionViaSalesOrderHeader_";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader_</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader_ = "SalesTerritoryCollectionViaSalesOrderHeader_";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AddressEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntity(System.Int32 addressID)
		{
			InitClassFetch(addressID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AddressEntity(System.Int32 addressID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(addressID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(System.Int32 addressID, IValidator validator)
		{
			InitClassFetch(addressID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employeeAddresses = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddresses", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddresses = info.GetBoolean("_alwaysFetchEmployeeAddresses");
			_alreadyFetchedEmployeeAddresses = info.GetBoolean("_alreadyFetchedEmployeeAddresses");

			_vendorAddresses = (AW.Data.CollectionClasses.VendorAddressCollection)info.GetValue("_vendorAddresses", typeof(AW.Data.CollectionClasses.VendorAddressCollection));
			_alwaysFetchVendorAddresses = info.GetBoolean("_alwaysFetchVendorAddresses");
			_alreadyFetchedVendorAddresses = info.GetBoolean("_alreadyFetchedVendorAddresses");

			_customerAddresses = (AW.Data.CollectionClasses.CustomerAddressCollection)info.GetValue("_customerAddresses", typeof(AW.Data.CollectionClasses.CustomerAddressCollection));
			_alwaysFetchCustomerAddresses = info.GetBoolean("_alwaysFetchCustomerAddresses");
			_alreadyFetchedCustomerAddresses = info.GetBoolean("_alreadyFetchedCustomerAddresses");

			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");

			_salesOrderHeaders_ = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders_", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders_ = info.GetBoolean("_alwaysFetchSalesOrderHeaders_");
			_alreadyFetchedSalesOrderHeaders_ = info.GetBoolean("_alreadyFetchedSalesOrderHeaders_");
			_employeeCollectionViaEmployeeAddres = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployeeAddres", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployeeAddres = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployeeAddres");
			_alreadyFetchedEmployeeCollectionViaEmployeeAddres = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployeeAddres");

			_addressTypeCollectionViaCustomerAddres = (AW.Data.CollectionClasses.AddressTypeCollection)info.GetValue("_addressTypeCollectionViaCustomerAddres", typeof(AW.Data.CollectionClasses.AddressTypeCollection));
			_alwaysFetchAddressTypeCollectionViaCustomerAddres = info.GetBoolean("_alwaysFetchAddressTypeCollectionViaCustomerAddres");
			_alreadyFetchedAddressTypeCollectionViaCustomerAddres = info.GetBoolean("_alreadyFetchedAddressTypeCollectionViaCustomerAddres");

			_contactCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader");
			_alreadyFetchedContactCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader");

			_contactCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader_");
			_alreadyFetchedContactCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader_");

			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");

			_shipMethodCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader_");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_");

			_creditCardCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader");

			_creditCardCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader_");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_");

			_currencyRateCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader");

			_currencyRateCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_");

			_customerCollectionViaCustomerAddres = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaCustomerAddres", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaCustomerAddres = info.GetBoolean("_alwaysFetchCustomerCollectionViaCustomerAddres");
			_alreadyFetchedCustomerCollectionViaCustomerAddres = info.GetBoolean("_alreadyFetchedCustomerCollectionViaCustomerAddres");

			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");

			_customerCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader_");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader_");

			_customerViewRelatedCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader");

			_customerViewRelatedCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_");

			_salesTerritoryCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader");

			_salesTerritoryCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_");
			_stateProvince = (StateProvinceEntity)info.GetValue("_stateProvince", typeof(StateProvinceEntity));
			if(_stateProvince!=null)
			{
				_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_stateProvinceReturnsNewIfNotFound = info.GetBoolean("_stateProvinceReturnsNewIfNotFound");
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AddressFieldIndex)fieldIndex)
			{
				case AddressFieldIndex.StateProvinceID:
					DesetupSyncStateProvince(true, false);
					_alreadyFetchedStateProvince = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedEmployeeAddresses = (_employeeAddresses.Count > 0);
			_alreadyFetchedVendorAddresses = (_vendorAddresses.Count > 0);
			_alreadyFetchedCustomerAddresses = (_customerAddresses.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedSalesOrderHeaders_ = (_salesOrderHeaders_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployeeAddres = (_employeeCollectionViaEmployeeAddres.Count > 0);
			_alreadyFetchedAddressTypeCollectionViaCustomerAddres = (_addressTypeCollectionViaCustomerAddres.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader = (_contactCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader_ = (_contactCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = (_shipMethodCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = (_creditCardCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = (_creditCardCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = (_currencyRateCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = (_currencyRateCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCustomerCollectionViaCustomerAddres = (_customerCollectionViaCustomerAddres.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = (_customerCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = (_customerViewRelatedCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = (_customerViewRelatedCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = (_salesTerritoryCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = (_salesTerritoryCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedStateProvince = (_stateProvince != null);
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
				case "StateProvince":
					toReturn.Add(Relations.StateProvinceEntityUsingStateProvinceID);
					break;
				case "EmployeeAddresses":
					toReturn.Add(Relations.EmployeeAddressEntityUsingAddressID);
					break;
				case "VendorAddresses":
					toReturn.Add(Relations.VendorAddressEntityUsingAddressID);
					break;
				case "CustomerAddresses":
					toReturn.Add(Relations.CustomerAddressEntityUsingAddressID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID);
					break;
				case "SalesOrderHeaders_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID);
					break;
				case "EmployeeCollectionViaEmployeeAddres":
					toReturn.Add(Relations.EmployeeAddressEntityUsingAddressID, "AddressEntity__", "EmployeeAddress_", JoinHint.None);
					toReturn.Add(EmployeeAddressEntity.Relations.EmployeeEntityUsingEmployeeID, "EmployeeAddress_", string.Empty, JoinHint.None);
					break;
				case "AddressTypeCollectionViaCustomerAddres":
					toReturn.Add(Relations.CustomerAddressEntityUsingAddressID, "AddressEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaCustomerAddres":
					toReturn.Add(Relations.CustomerAddressEntityUsingAddressID, "AddressEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader_":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID, "SalesOrderHeader_", string.Empty, JoinHint.None);
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
			info.AddValue("_employeeAddresses", (!this.MarkedForDeletion?_employeeAddresses:null));
			info.AddValue("_alwaysFetchEmployeeAddresses", _alwaysFetchEmployeeAddresses);
			info.AddValue("_alreadyFetchedEmployeeAddresses", _alreadyFetchedEmployeeAddresses);
			info.AddValue("_vendorAddresses", (!this.MarkedForDeletion?_vendorAddresses:null));
			info.AddValue("_alwaysFetchVendorAddresses", _alwaysFetchVendorAddresses);
			info.AddValue("_alreadyFetchedVendorAddresses", _alreadyFetchedVendorAddresses);
			info.AddValue("_customerAddresses", (!this.MarkedForDeletion?_customerAddresses:null));
			info.AddValue("_alwaysFetchCustomerAddresses", _alwaysFetchCustomerAddresses);
			info.AddValue("_alreadyFetchedCustomerAddresses", _alreadyFetchedCustomerAddresses);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_salesOrderHeaders_", (!this.MarkedForDeletion?_salesOrderHeaders_:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders_", _alwaysFetchSalesOrderHeaders_);
			info.AddValue("_alreadyFetchedSalesOrderHeaders_", _alreadyFetchedSalesOrderHeaders_);
			info.AddValue("_employeeCollectionViaEmployeeAddres", (!this.MarkedForDeletion?_employeeCollectionViaEmployeeAddres:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployeeAddres", _alwaysFetchEmployeeCollectionViaEmployeeAddres);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployeeAddres", _alreadyFetchedEmployeeCollectionViaEmployeeAddres);
			info.AddValue("_addressTypeCollectionViaCustomerAddres", (!this.MarkedForDeletion?_addressTypeCollectionViaCustomerAddres:null));
			info.AddValue("_alwaysFetchAddressTypeCollectionViaCustomerAddres", _alwaysFetchAddressTypeCollectionViaCustomerAddres);
			info.AddValue("_alreadyFetchedAddressTypeCollectionViaCustomerAddres", _alreadyFetchedAddressTypeCollectionViaCustomerAddres);
			info.AddValue("_contactCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader", _alwaysFetchContactCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader", _alreadyFetchedContactCollectionViaSalesOrderHeader);
			info.AddValue("_contactCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader_", _alwaysFetchContactCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader_", _alreadyFetchedContactCollectionViaSalesOrderHeader_);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader_", _alwaysFetchShipMethodCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader_);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader", _alwaysFetchCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader_", _alwaysFetchCreditCardCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader_);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_);
			info.AddValue("_customerCollectionViaCustomerAddres", (!this.MarkedForDeletion?_customerCollectionViaCustomerAddres:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaCustomerAddres", _alwaysFetchCustomerCollectionViaCustomerAddres);
			info.AddValue("_alreadyFetchedCustomerCollectionViaCustomerAddres", _alreadyFetchedCustomerCollectionViaCustomerAddres);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader_", _alwaysFetchCustomerCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader_", _alreadyFetchedCustomerCollectionViaSalesOrderHeader_);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_);
			info.AddValue("_stateProvince", (!this.MarkedForDeletion?_stateProvince:null));
			info.AddValue("_stateProvinceReturnsNewIfNotFound", _stateProvinceReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStateProvince", _alwaysFetchStateProvince);
			info.AddValue("_alreadyFetchedStateProvince", _alreadyFetchedStateProvince);

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
				case "StateProvince":
					_alreadyFetchedStateProvince = true;
					this.StateProvince = (StateProvinceEntity)entity;
					break;
				case "EmployeeAddresses":
					_alreadyFetchedEmployeeAddresses = true;
					if(entity!=null)
					{
						this.EmployeeAddresses.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "VendorAddresses":
					_alreadyFetchedVendorAddresses = true;
					if(entity!=null)
					{
						this.VendorAddresses.Add((VendorAddressEntity)entity);
					}
					break;
				case "CustomerAddresses":
					_alreadyFetchedCustomerAddresses = true;
					if(entity!=null)
					{
						this.CustomerAddresses.Add((CustomerAddressEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesOrderHeaders_":
					_alreadyFetchedSalesOrderHeaders_ = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders_.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployeeAddres":
					_alreadyFetchedEmployeeCollectionViaEmployeeAddres = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployeeAddres.Add((EmployeeEntity)entity);
					}
					break;
				case "AddressTypeCollectionViaCustomerAddres":
					_alreadyFetchedAddressTypeCollectionViaCustomerAddres = true;
					if(entity!=null)
					{
						this.AddressTypeCollectionViaCustomerAddres.Add((AddressTypeEntity)entity);
					}
					break;
				case "ContactCollectionViaSalesOrderHeader":
					_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ContactCollectionViaSalesOrderHeader.Add((ContactEntity)entity);
					}
					break;
				case "ContactCollectionViaSalesOrderHeader_":
					_alreadyFetchedContactCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.ContactCollectionViaSalesOrderHeader_.Add((ContactEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader_":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader_.Add((ShipMethodEntity)entity);
					}
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaSalesOrderHeader.Add((CreditCardEntity)entity);
					}
					break;
				case "CreditCardCollectionViaSalesOrderHeader_":
					_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaSalesOrderHeader_.Add((CreditCardEntity)entity);
					}
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CurrencyRateCollectionViaSalesOrderHeader.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader_":
					_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CurrencyRateCollectionViaSalesOrderHeader_.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CustomerCollectionViaCustomerAddres":
					_alreadyFetchedCustomerCollectionViaCustomerAddres = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaCustomerAddres.Add((CustomerEntity)entity);
					}
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					_alreadyFetchedCustomerCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaSalesOrderHeader.Add((CustomerEntity)entity);
					}
					break;
				case "CustomerCollectionViaSalesOrderHeader_":
					_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaSalesOrderHeader_.Add((CustomerEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader_":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader_.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader_":
					_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaSalesOrderHeader_.Add((SalesTerritoryEntity)entity);
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
				case "StateProvince":
					SetupSyncStateProvince(relatedEntity);
					break;
				case "EmployeeAddresses":
					_employeeAddresses.Add((EmployeeAddressEntity)relatedEntity);
					break;
				case "VendorAddresses":
					_vendorAddresses.Add((VendorAddressEntity)relatedEntity);
					break;
				case "CustomerAddresses":
					_customerAddresses.Add((CustomerAddressEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesOrderHeaders_":
					_salesOrderHeaders_.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "StateProvince":
					DesetupSyncStateProvince(false, true);
					break;
				case "EmployeeAddresses":
					this.PerformRelatedEntityRemoval(_employeeAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorAddresses":
					this.PerformRelatedEntityRemoval(_vendorAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CustomerAddresses":
					this.PerformRelatedEntityRemoval(_customerAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders_":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders_, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_stateProvince!=null)
			{
				toReturn.Add(_stateProvince);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_employeeAddresses);
			toReturn.Add(_vendorAddresses);
			toReturn.Add(_customerAddresses);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_salesOrderHeaders_);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID)
		{
			return FetchUsingPK(addressID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(addressID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(addressID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(addressID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AddressID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AddressRelations().GetAllRelations();
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

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch)
		{
			return GetMultiVendorAddresses(forceFetch, _vendorAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorAddresses(forceFetch, _vendorAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddresses || forceFetch || _alwaysFetchVendorAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vendorAddresses);
				_vendorAddresses.SuppressClearInGetMulti=!forceFetch;
				_vendorAddresses.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddresses.GetMultiManyToOne(this, null, null, filter);
				_vendorAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddresses = true;
			}
			return _vendorAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorAddresses'. These settings will be taken into account
		/// when the property VendorAddresses is requested or GetMultiVendorAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddresses.SortClauses=sortClauses;
			_vendorAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch)
		{
			return GetMultiCustomerAddresses(forceFetch, _customerAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerAddresses(forceFetch, _customerAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddresses || forceFetch || _alwaysFetchCustomerAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerAddresses);
				_customerAddresses.SuppressClearInGetMulti=!forceFetch;
				_customerAddresses.EntityFactoryToUse = entityFactoryToUse;
				_customerAddresses.GetMultiManyToOne(this, null, null, filter);
				_customerAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddresses = true;
			}
			return _customerAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerAddresses'. These settings will be taken into account
		/// when the property CustomerAddresses is requested or GetMultiCustomerAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerAddresses.SortClauses=sortClauses;
			_customerAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedSalesOrderHeaders || forceFetch || _alwaysFetchSalesOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaders);
				_salesOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaders.GetMultiManyToOne(this, null, null, null, null, null, null, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders_(bool forceFetch)
		{
			return GetMultiSalesOrderHeaders_(forceFetch, _salesOrderHeaders_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaders_(forceFetch, _salesOrderHeaders_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaders_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaders_ || forceFetch || _alwaysFetchSalesOrderHeaders_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaders_);
				_salesOrderHeaders_.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaders_.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaders_.GetMultiManyToOne(null, this, null, null, null, null, null, null, null, null, filter);
				_salesOrderHeaders_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaders_ = true;
			}
			return _salesOrderHeaders_;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaders_'. These settings will be taken into account
		/// when the property SalesOrderHeaders_ is requested or GetMultiSalesOrderHeaders_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaders_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaders_.SortClauses=sortClauses;
			_salesOrderHeaders_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeAddres(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaEmployeeAddres(forceFetch, _employeeCollectionViaEmployeeAddres.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeAddres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaEmployeeAddres || forceFetch || _alwaysFetchEmployeeCollectionViaEmployeeAddres) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeCollectionViaEmployeeAddres);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_employeeCollectionViaEmployeeAddres.SuppressClearInGetMulti=!forceFetch;
				_employeeCollectionViaEmployeeAddres.EntityFactoryToUse = entityFactoryToUse;
				_employeeCollectionViaEmployeeAddres.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaEmployeeAddres"));
				_employeeCollectionViaEmployeeAddres.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaEmployeeAddres = true;
			}
			return _employeeCollectionViaEmployeeAddres;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaEmployeeAddres'. These settings will be taken into account
		/// when the property EmployeeCollectionViaEmployeeAddres is requested or GetMultiEmployeeCollectionViaEmployeeAddres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaEmployeeAddres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaEmployeeAddres.SortClauses=sortClauses;
			_employeeCollectionViaEmployeeAddres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddres(bool forceFetch)
		{
			return GetMultiAddressTypeCollectionViaCustomerAddres(forceFetch, _addressTypeCollectionViaCustomerAddres.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressTypeCollectionViaCustomerAddres || forceFetch || _alwaysFetchAddressTypeCollectionViaCustomerAddres) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_addressTypeCollectionViaCustomerAddres);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_addressTypeCollectionViaCustomerAddres.SuppressClearInGetMulti=!forceFetch;
				_addressTypeCollectionViaCustomerAddres.EntityFactoryToUse = entityFactoryToUse;
				_addressTypeCollectionViaCustomerAddres.GetMulti(filter, GetRelationsForField("AddressTypeCollectionViaCustomerAddres"));
				_addressTypeCollectionViaCustomerAddres.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressTypeCollectionViaCustomerAddres = true;
			}
			return _addressTypeCollectionViaCustomerAddres;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressTypeCollectionViaCustomerAddres'. These settings will be taken into account
		/// when the property AddressTypeCollectionViaCustomerAddres is requested or GetMultiAddressTypeCollectionViaCustomerAddres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressTypeCollectionViaCustomerAddres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressTypeCollectionViaCustomerAddres.SortClauses=sortClauses;
			_addressTypeCollectionViaCustomerAddres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiContactCollectionViaSalesOrderHeader(forceFetch, _contactCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchContactCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_contactCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_contactCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_contactCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("ContactCollectionViaSalesOrderHeader"));
				_contactCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
			}
			return _contactCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property ContactCollectionViaSalesOrderHeader is requested or GetMultiContactCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_contactCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiContactCollectionViaSalesOrderHeader_(forceFetch, _contactCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchContactCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_contactCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_contactCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_contactCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("ContactCollectionViaSalesOrderHeader_"));
				_contactCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaSalesOrderHeader_ = true;
			}
			return _contactCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property ContactCollectionViaSalesOrderHeader_ is requested or GetMultiContactCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_contactCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedShipMethodCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchShipMethodCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_shipMethodCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_shipMethodCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_shipMethodCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
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

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiShipMethodCollectionViaSalesOrderHeader_(forceFetch, _shipMethodCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchShipMethodCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_shipMethodCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_shipMethodCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_shipMethodCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_shipMethodCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader_"));
				_shipMethodCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = true;
			}
			return _shipMethodCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShipMethodCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property ShipMethodCollectionViaSalesOrderHeader_ is requested or GetMultiShipMethodCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethodCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethodCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_shipMethodCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedCreditCardCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCreditCardCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_creditCardCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_creditCardCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_creditCardCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
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

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiCreditCardCollectionViaSalesOrderHeader_(forceFetch, _creditCardCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CreditCardCollection GetMultiCreditCardCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCreditCardCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_creditCardCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_creditCardCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_creditCardCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_creditCardCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader_"));
				_creditCardCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = true;
			}
			return _creditCardCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CreditCardCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property CreditCardCollectionViaSalesOrderHeader_ is requested or GetMultiCreditCardCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCardCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCardCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_creditCardCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_currencyRateCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_currencyRateCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_currencyRateCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
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

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRateCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiCurrencyRateCollectionViaSalesOrderHeader_(forceFetch, _currencyRateCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CurrencyRateCollection GetMultiCurrencyRateCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_currencyRateCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_currencyRateCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_currencyRateCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_currencyRateCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader_"));
				_currencyRateCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = true;
			}
			return _currencyRateCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CurrencyRateCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property CurrencyRateCollectionViaSalesOrderHeader_ is requested or GetMultiCurrencyRateCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRateCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRateCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_currencyRateCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddres(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaCustomerAddres(forceFetch, _customerCollectionViaCustomerAddres.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaCustomerAddres || forceFetch || _alwaysFetchCustomerCollectionViaCustomerAddres) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCollectionViaCustomerAddres);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerCollectionViaCustomerAddres.SuppressClearInGetMulti=!forceFetch;
				_customerCollectionViaCustomerAddres.EntityFactoryToUse = entityFactoryToUse;
				_customerCollectionViaCustomerAddres.GetMulti(filter, GetRelationsForField("CustomerCollectionViaCustomerAddres"));
				_customerCollectionViaCustomerAddres.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaCustomerAddres = true;
			}
			return _customerCollectionViaCustomerAddres;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaCustomerAddres'. These settings will be taken into account
		/// when the property CustomerCollectionViaCustomerAddres is requested or GetMultiCustomerCollectionViaCustomerAddres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaCustomerAddres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaCustomerAddres.SortClauses=sortClauses;
			_customerCollectionViaCustomerAddres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedCustomerCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCustomerCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_customerCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
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

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaSalesOrderHeader_(forceFetch, _customerCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCustomerCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_customerCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_customerCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("CustomerCollectionViaSalesOrderHeader_"));
				_customerCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = true;
			}
			return _customerCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property CustomerCollectionViaSalesOrderHeader_ is requested or GetMultiCustomerCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_customerCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerViewRelatedCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_customerViewRelatedCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_customerViewRelatedCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader"));
				_customerViewRelatedCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerViewRelatedCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_customerViewRelatedCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_customerViewRelatedCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader_"));
				_customerViewRelatedCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader_ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesTerritoryCollectionViaSalesOrderHeader);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_salesTerritoryCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
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

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(forceFetch, _salesTerritoryCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTerritoryCollection GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesTerritoryCollectionViaSalesOrderHeader_);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_salesTerritoryCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritoryCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader_"));
				_salesTerritoryCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = true;
			}
			return _salesTerritoryCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTerritoryCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property SalesTerritoryCollectionViaSalesOrderHeader_ is requested or GetMultiSalesTerritoryCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_salesTerritoryCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public StateProvinceEntity GetSingleStateProvince()
		{
			return GetSingleStateProvince(false);
		}

		/// <summary> Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public virtual StateProvinceEntity GetSingleStateProvince(bool forceFetch)
		{
			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StateProvinceEntityUsingStateProvinceID);
				StateProvinceEntity newEntity = new StateProvinceEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.StateProvinceID);
				}
				if(fetchResult)
				{
					newEntity = (StateProvinceEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_stateProvinceReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.StateProvince = newEntity;
				_alreadyFetchedStateProvince = fetchResult;
			}
			return _stateProvince;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvince", _stateProvince);
			toReturn.Add("EmployeeAddresses", _employeeAddresses);
			toReturn.Add("VendorAddresses", _vendorAddresses);
			toReturn.Add("CustomerAddresses", _customerAddresses);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesOrderHeaders_", _salesOrderHeaders_);
			toReturn.Add("EmployeeCollectionViaEmployeeAddres", _employeeCollectionViaEmployeeAddres);
			toReturn.Add("AddressTypeCollectionViaCustomerAddres", _addressTypeCollectionViaCustomerAddres);
			toReturn.Add("ContactCollectionViaSalesOrderHeader", _contactCollectionViaSalesOrderHeader);
			toReturn.Add("ContactCollectionViaSalesOrderHeader_", _contactCollectionViaSalesOrderHeader_);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader_", _shipMethodCollectionViaSalesOrderHeader_);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader_", _creditCardCollectionViaSalesOrderHeader_);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader_", _currencyRateCollectionViaSalesOrderHeader_);
			toReturn.Add("CustomerCollectionViaCustomerAddres", _customerCollectionViaCustomerAddres);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader_", _customerCollectionViaSalesOrderHeader_);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader", _customerViewRelatedCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader_", _customerViewRelatedCollectionViaSalesOrderHeader_);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader_", _salesTerritoryCollectionViaSalesOrderHeader_);
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
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The validator object for this AddressEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 addressID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(addressID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employeeAddresses = new AW.Data.CollectionClasses.EmployeeAddressCollection();
			_employeeAddresses.SetContainingEntityInfo(this, "Address");

			_vendorAddresses = new AW.Data.CollectionClasses.VendorAddressCollection();
			_vendorAddresses.SetContainingEntityInfo(this, "Address");

			_customerAddresses = new AW.Data.CollectionClasses.CustomerAddressCollection();
			_customerAddresses.SetContainingEntityInfo(this, "Address");

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "BillingAddress");

			_salesOrderHeaders_ = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders_.SetContainingEntityInfo(this, "ShippingAddress");
			_employeeCollectionViaEmployeeAddres = new AW.Data.CollectionClasses.EmployeeCollection();
			_addressTypeCollectionViaCustomerAddres = new AW.Data.CollectionClasses.AddressTypeCollection();
			_contactCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ContactCollection();
			_contactCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.ContactCollection();
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection();
			_shipMethodCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.ShipMethodCollection();
			_creditCardCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CreditCardCollection();
			_creditCardCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CreditCardCollection();
			_currencyRateCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CurrencyRateCollection();
			_currencyRateCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CurrencyRateCollection();
			_customerCollectionViaCustomerAddres = new AW.Data.CollectionClasses.CustomerCollection();
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection();
			_customerCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CustomerCollection();
			_customerViewRelatedCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerViewRelatedCollection();
			_customerViewRelatedCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection();
			_salesTerritoryCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesTerritoryCollection();
			_salesTerritoryCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.SalesTerritoryCollection();
			_stateProvinceReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Street address information for customers, employees, and vendors.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("AddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"First street address line.");
			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the city.");
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Postal code for the street address.");
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique identification number for the state or province. Foreign key to StateProvince table.");
			_fieldsCustomProperties.Add("StateProvinceID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _stateProvince</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, signalRelatedEntity, "Addresses", resetFKFields, new int[] { (int)AddressFieldIndex.StateProvinceID } );		
			_stateProvince = null;
		}
		
		/// <summary> setups the sync logic for member _stateProvince</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStateProvince(IEntity relatedEntity)
		{
			if(_stateProvince!=relatedEntity)
			{		
				DesetupSyncStateProvince(true, true);
				_stateProvince = (StateProvinceEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, ref _alreadyFetchedStateProvince, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStateProvincePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AddressFieldIndex.AddressID].ForcedCurrentValueWrite(addressID);
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
			return DAOFactory.CreateAddressDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AddressEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AddressRelations Relations
		{
			get	{ return new AddressRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeAddressCollection(), (IEntityRelation)GetRelationsForField("EmployeeAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorAddressCollection(), (IEntityRelation)GetRelationsForField("VendorAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.VendorAddressEntity, 0, null, null, null, "VendorAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerAddressCollection(), (IEntityRelation)GetRelationsForField("CustomerAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerAddressEntity, 0, null, null, null, "CustomerAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders_
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders_")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployeeAddres
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.EmployeeAddressEntityUsingAddressID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployeeAddres"), "EmployeeCollectionViaEmployeeAddres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressTypeCollectionViaCustomerAddres
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerAddressEntityUsingAddressID;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, GetRelationsForField("AddressTypeCollectionViaCustomerAddres"), "AddressTypeCollectionViaCustomerAddres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader"), "ContactCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader_"), "ContactCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader_"), "ShipMethodCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader_"), "CreditCardCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader_"), "CurrencyRateCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaCustomerAddres
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerAddressEntityUsingAddressID;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaCustomerAddres"), "CustomerCollectionViaCustomerAddres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader_"), "CustomerCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader"), "CustomerViewRelatedCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader_"), "CustomerViewRelatedCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingBillToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderEntityUsingShipToAddressID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader_"), "SalesTerritoryCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvince
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(), (IEntityRelation)GetRelationsForField("StateProvince")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "AddressEntity";}
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

		/// <summary> The AddressID property of the Entity Address<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressID
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.AddressID, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressID, value, true); }
		}

		/// <summary> The AddressLine1 property of the Entity Address<br/><br/>
		/// MS_Description: First street address line.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine1, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine1, value, true); }
		}

		/// <summary> The AddressLine2 property of the Entity Address<br/><br/>
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine2, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine2, value, true); }
		}

		/// <summary> The City property of the Entity Address<br/><br/>
		/// MS_Description: Name of the city.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set	{ SetValue((int)AddressFieldIndex.City, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Address<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The PostalCode property of the Entity Address<br/><br/>
		/// MS_Description: Postal code for the street address.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.PostalCode, true); }
			set	{ SetValue((int)AddressFieldIndex.PostalCode, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Address<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The StateProvinceID property of the Entity Address<br/><br/>
		/// MS_Description: Unique identification number for the state or province. Foreign key to StateProvince table.<br/></summary>
		/// <remarks>Mapped on  table field: "Address"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceID
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.StateProvinceID, true); }
			set	{ SetValue((int)AddressFieldIndex.StateProvinceID, value, true); }
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
		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection VendorAddresses
		{
			get	{ return GetMultiVendorAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorAddresses. When set to true, VendorAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiVendorAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddresses
		{
			get	{ return _alwaysFetchVendorAddresses; }
			set	{ _alwaysFetchVendorAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorAddresses already has been fetched. Setting this property to false when VendorAddresses has been fetched
		/// will clear the VendorAddresses collection well. Setting this property to true while VendorAddresses hasn't been fetched disables lazy loading for VendorAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorAddresses
		{
			get { return _alreadyFetchedVendorAddresses;}
			set 
			{
				if(_alreadyFetchedVendorAddresses && !value && (_vendorAddresses != null))
				{
					_vendorAddresses.Clear();
				}
				_alreadyFetchedVendorAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection CustomerAddresses
		{
			get	{ return GetMultiCustomerAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerAddresses. When set to true, CustomerAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiCustomerAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerAddresses
		{
			get	{ return _alwaysFetchCustomerAddresses; }
			set	{ _alwaysFetchCustomerAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerAddresses already has been fetched. Setting this property to false when CustomerAddresses has been fetched
		/// will clear the CustomerAddresses collection well. Setting this property to true while CustomerAddresses hasn't been fetched disables lazy loading for CustomerAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerAddresses
		{
			get { return _alreadyFetchedCustomerAddresses;}
			set 
			{
				if(_alreadyFetchedCustomerAddresses && !value && (_customerAddresses != null))
				{
					_customerAddresses.Clear();
				}
				_alreadyFetchedCustomerAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders
		{
			get	{ return GetMultiSalesOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders. When set to true, SalesOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaders(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders_
		{
			get	{ return GetMultiSalesOrderHeaders_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders_. When set to true, SalesOrderHeaders_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders_ is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaders_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaders_
		{
			get	{ return _alwaysFetchSalesOrderHeaders_; }
			set	{ _alwaysFetchSalesOrderHeaders_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaders_ already has been fetched. Setting this property to false when SalesOrderHeaders_ has been fetched
		/// will clear the SalesOrderHeaders_ collection well. Setting this property to true while SalesOrderHeaders_ hasn't been fetched disables lazy loading for SalesOrderHeaders_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaders_
		{
			get { return _alreadyFetchedSalesOrderHeaders_;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaders_ && !value && (_salesOrderHeaders_ != null))
				{
					_salesOrderHeaders_.Clear();
				}
				_alreadyFetchedSalesOrderHeaders_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaEmployeeAddres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaEmployeeAddres
		{
			get { return GetMultiEmployeeCollectionViaEmployeeAddres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaEmployeeAddres. When set to true, EmployeeCollectionViaEmployeeAddres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaEmployeeAddres is accessed. You can always execute a forced fetch by calling GetMultiEmployeeCollectionViaEmployeeAddres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaEmployeeAddres
		{
			get	{ return _alwaysFetchEmployeeCollectionViaEmployeeAddres; }
			set	{ _alwaysFetchEmployeeCollectionViaEmployeeAddres = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaEmployeeAddres already has been fetched. Setting this property to false when EmployeeCollectionViaEmployeeAddres has been fetched
		/// will clear the EmployeeCollectionViaEmployeeAddres collection well. Setting this property to true while EmployeeCollectionViaEmployeeAddres hasn't been fetched disables lazy loading for EmployeeCollectionViaEmployeeAddres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaEmployeeAddres
		{
			get { return _alreadyFetchedEmployeeCollectionViaEmployeeAddres;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaEmployeeAddres && !value && (_employeeCollectionViaEmployeeAddres != null))
				{
					_employeeCollectionViaEmployeeAddres.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaEmployeeAddres = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressTypeCollectionViaCustomerAddres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressTypeCollection AddressTypeCollectionViaCustomerAddres
		{
			get { return GetMultiAddressTypeCollectionViaCustomerAddres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressTypeCollectionViaCustomerAddres. When set to true, AddressTypeCollectionViaCustomerAddres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressTypeCollectionViaCustomerAddres is accessed. You can always execute a forced fetch by calling GetMultiAddressTypeCollectionViaCustomerAddres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressTypeCollectionViaCustomerAddres
		{
			get	{ return _alwaysFetchAddressTypeCollectionViaCustomerAddres; }
			set	{ _alwaysFetchAddressTypeCollectionViaCustomerAddres = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressTypeCollectionViaCustomerAddres already has been fetched. Setting this property to false when AddressTypeCollectionViaCustomerAddres has been fetched
		/// will clear the AddressTypeCollectionViaCustomerAddres collection well. Setting this property to true while AddressTypeCollectionViaCustomerAddres hasn't been fetched disables lazy loading for AddressTypeCollectionViaCustomerAddres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressTypeCollectionViaCustomerAddres
		{
			get { return _alreadyFetchedAddressTypeCollectionViaCustomerAddres;}
			set 
			{
				if(_alreadyFetchedAddressTypeCollectionViaCustomerAddres && !value && (_addressTypeCollectionViaCustomerAddres != null))
				{
					_addressTypeCollectionViaCustomerAddres.Clear();
				}
				_alreadyFetchedAddressTypeCollectionViaCustomerAddres = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaSalesOrderHeader
		{
			get { return GetMultiContactCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaSalesOrderHeader. When set to true, ContactCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiContactCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchContactCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchContactCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when ContactCollectionViaSalesOrderHeader has been fetched
		/// will clear the ContactCollectionViaSalesOrderHeader collection well. Setting this property to true while ContactCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for ContactCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedContactCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaSalesOrderHeader && !value && (_contactCollectionViaSalesOrderHeader != null))
				{
					_contactCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedContactCollectionViaSalesOrderHeader = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaSalesOrderHeader_
		{
			get { return GetMultiContactCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaSalesOrderHeader_. When set to true, ContactCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiContactCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchContactCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchContactCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when ContactCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the ContactCollectionViaSalesOrderHeader_ collection well. Setting this property to true while ContactCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for ContactCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedContactCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaSalesOrderHeader_ && !value && (_contactCollectionViaSalesOrderHeader_ != null))
				{
					_contactCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedContactCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetMultiShipMethodCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaSalesOrderHeader. When set to true, ShipMethodCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiShipMethodCollectionViaSalesOrderHeader(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaSalesOrderHeader_
		{
			get { return GetMultiShipMethodCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaSalesOrderHeader_. When set to true, ShipMethodCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiShipMethodCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethodCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchShipMethodCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchShipMethodCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethodCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when ShipMethodCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the ShipMethodCollectionViaSalesOrderHeader_ collection well. Setting this property to true while ShipMethodCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for ShipMethodCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethodCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedShipMethodCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ && !value && (_shipMethodCollectionViaSalesOrderHeader_ != null))
				{
					_shipMethodCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCardCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCardCollectionViaSalesOrderHeader
		{
			get { return GetMultiCreditCardCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCardCollectionViaSalesOrderHeader. When set to true, CreditCardCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCardCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiCreditCardCollectionViaSalesOrderHeader(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCardCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCardCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCreditCardCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCardCollectionViaSalesOrderHeader_. When set to true, CreditCardCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCardCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiCreditCardCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCardCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchCreditCardCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchCreditCardCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CreditCardCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when CreditCardCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the CreditCardCollectionViaSalesOrderHeader_ collection well. Setting this property to true while CreditCardCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for CreditCardCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCreditCardCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedCreditCardCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ && !value && (_creditCardCollectionViaSalesOrderHeader_ != null))
				{
					_creditCardCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRateCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRateCollectionViaSalesOrderHeader
		{
			get { return GetMultiCurrencyRateCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRateCollectionViaSalesOrderHeader. When set to true, CurrencyRateCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRateCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiCurrencyRateCollectionViaSalesOrderHeader(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRateCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRateCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCurrencyRateCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRateCollectionViaSalesOrderHeader_. When set to true, CurrencyRateCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRateCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiCurrencyRateCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRateCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyRateCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when CurrencyRateCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the CurrencyRateCollectionViaSalesOrderHeader_ collection well. Setting this property to true while CurrencyRateCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for CurrencyRateCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ && !value && (_currencyRateCollectionViaSalesOrderHeader_ != null))
				{
					_currencyRateCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaCustomerAddres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaCustomerAddres
		{
			get { return GetMultiCustomerCollectionViaCustomerAddres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaCustomerAddres. When set to true, CustomerCollectionViaCustomerAddres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaCustomerAddres is accessed. You can always execute a forced fetch by calling GetMultiCustomerCollectionViaCustomerAddres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaCustomerAddres
		{
			get	{ return _alwaysFetchCustomerCollectionViaCustomerAddres; }
			set	{ _alwaysFetchCustomerCollectionViaCustomerAddres = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaCustomerAddres already has been fetched. Setting this property to false when CustomerCollectionViaCustomerAddres has been fetched
		/// will clear the CustomerCollectionViaCustomerAddres collection well. Setting this property to true while CustomerCollectionViaCustomerAddres hasn't been fetched disables lazy loading for CustomerCollectionViaCustomerAddres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaCustomerAddres
		{
			get { return _alreadyFetchedCustomerCollectionViaCustomerAddres;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaCustomerAddres && !value && (_customerCollectionViaCustomerAddres != null))
				{
					_customerCollectionViaCustomerAddres.Clear();
				}
				_alreadyFetchedCustomerCollectionViaCustomerAddres = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaSalesOrderHeader
		{
			get { return GetMultiCustomerCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaSalesOrderHeader. When set to true, CustomerCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiCustomerCollectionViaSalesOrderHeader(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCustomerCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaSalesOrderHeader_. When set to true, CustomerCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiCustomerCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchCustomerCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchCustomerCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when CustomerCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the CustomerCollectionViaSalesOrderHeader_ collection well. Setting this property to true while CustomerCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for CustomerCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedCustomerCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ && !value && (_customerCollectionViaSalesOrderHeader_ != null))
				{
					_customerCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader && !value && (_customerViewRelatedCollectionViaSalesOrderHeader != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader_. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader_ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader_ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryCollection SalesTerritoryCollectionViaSalesOrderHeader
		{
			get { return GetMultiSalesTerritoryCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryCollectionViaSalesOrderHeader. When set to true, SalesTerritoryCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryCollectionViaSalesOrderHeader is accessed. You can always execute a forced fetch by calling GetMultiSalesTerritoryCollectionViaSalesOrderHeader(true).</summary>
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

		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryCollection SalesTerritoryCollectionViaSalesOrderHeader_
		{
			get { return GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryCollectionViaSalesOrderHeader_. When set to true, SalesTerritoryCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryCollectionViaSalesOrderHeader_ is accessed. You can always execute a forced fetch by calling GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritoryCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when SalesTerritoryCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the SalesTerritoryCollectionViaSalesOrderHeader_ collection well. Setting this property to true while SalesTerritoryCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for SalesTerritoryCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ && !value && (_salesTerritoryCollectionViaSalesOrderHeader_ != null))
				{
					_salesTerritoryCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'StateProvinceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual StateProvinceEntity StateProvince
		{
			get	{ return GetSingleStateProvince(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStateProvince(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Addresses", "StateProvince", _stateProvince, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvince. When set to true, StateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvince is accessed. You can always execute a forced fetch by calling GetSingleStateProvince(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvince
		{
			get	{ return _alwaysFetchStateProvince; }
			set	{ _alwaysFetchStateProvince = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StateProvince already has been fetched. Setting this property to false when StateProvince has been fetched
		/// will set StateProvince to null as well. Setting this property to true while StateProvince hasn't been fetched disables lazy loading for StateProvince</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStateProvince
		{
			get { return _alreadyFetchedStateProvince;}
			set 
			{
				if(_alreadyFetchedStateProvince && !value)
				{
					this.StateProvince = null;
				}
				_alreadyFetchedStateProvince = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property StateProvince is not found
		/// in the database. When set to true, StateProvince will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool StateProvinceReturnsNewIfNotFound
		{
			get	{ return _stateProvinceReturnsNewIfNotFound; }
			set { _stateProvinceReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.AddressEntity; }
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
