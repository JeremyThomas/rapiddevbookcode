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
	/// <summary>Entity base class which represents the base class for the entity 'Address'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class AddressEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CustomerAddressCollection	_customerAddress;
		private bool	_alwaysFetchCustomerAddress, _alreadyFetchedCustomerAddress;
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddress;
		private bool	_alwaysFetchEmployeeAddress, _alreadyFetchedEmployeeAddress;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader_;
		private bool	_alwaysFetchSalesOrderHeader_, _alreadyFetchedSalesOrderHeader_;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private AW.Data.CollectionClasses.AddressTypeCollection _addressTypeCollectionViaCustomerAddress;
		private bool	_alwaysFetchAddressTypeCollectionViaCustomerAddress, _alreadyFetchedAddressTypeCollectionViaCustomerAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader, _alreadyFetchedContactCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader_, _alreadyFetchedContactCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader_, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaCustomerAddress;
		private bool	_alwaysFetchCustomerCollectionViaCustomerAddress, _alreadyFetchedCustomerCollectionViaCustomerAddress;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader_, _alreadyFetchedCustomerCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader___;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader____;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployeeAddress;
		private bool	_alwaysFetchEmployeeCollectionViaEmployeeAddress, _alreadyFetchedEmployeeCollectionViaEmployeeAddress;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader_, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;
		private StateProvinceEntity _stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince, _stateProvinceReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
			/// <summary>Member name CustomerAddress</summary>
			public static readonly string CustomerAddress = "CustomerAddress";
			/// <summary>Member name EmployeeAddress</summary>
			public static readonly string EmployeeAddress = "EmployeeAddress";
			/// <summary>Member name SalesOrderHeader_</summary>
			public static readonly string SalesOrderHeader_ = "SalesOrderHeader_";
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name AddressTypeCollectionViaCustomerAddress</summary>
			public static readonly string AddressTypeCollectionViaCustomerAddress = "AddressTypeCollectionViaCustomerAddress";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader = "ContactCollectionViaSalesOrderHeader";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader_</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader_ = "ContactCollectionViaSalesOrderHeader_";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader_</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader_ = "CreditCardCollectionViaSalesOrderHeader_";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader_</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader_ = "CurrencyRateCollectionViaSalesOrderHeader_";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaCustomerAddress</summary>
			public static readonly string CustomerCollectionViaCustomerAddress = "CustomerCollectionViaCustomerAddress";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader_</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader_ = "CustomerCollectionViaSalesOrderHeader_";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader___</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader___ = "CustomerViewRelatedCollectionViaSalesOrderHeader___";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader____</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader____ = "CustomerViewRelatedCollectionViaSalesOrderHeader____";
			/// <summary>Member name EmployeeCollectionViaEmployeeAddress</summary>
			public static readonly string EmployeeCollectionViaEmployeeAddress = "EmployeeCollectionViaEmployeeAddress";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader_</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader_ = "SalesTerritoryCollectionViaSalesOrderHeader_";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader_</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader_ = "ShipMethodCollectionViaSalesOrderHeader_";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AddressEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntityBase(System.Int32 addressId)
		{
			InitClassFetch(addressId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AddressEntityBase(System.Int32 addressId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(addressId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntityBase(System.Int32 addressId, IValidator validator)
		{
			InitClassFetch(addressId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customerAddress = (AW.Data.CollectionClasses.CustomerAddressCollection)info.GetValue("_customerAddress", typeof(AW.Data.CollectionClasses.CustomerAddressCollection));
			_alwaysFetchCustomerAddress = info.GetBoolean("_alwaysFetchCustomerAddress");
			_alreadyFetchedCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerAddress");
			_employeeAddress = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddress", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddress = info.GetBoolean("_alwaysFetchEmployeeAddress");
			_alreadyFetchedEmployeeAddress = info.GetBoolean("_alreadyFetchedEmployeeAddress");
			_salesOrderHeader_ = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader_", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader_ = info.GetBoolean("_alwaysFetchSalesOrderHeader_");
			_alreadyFetchedSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedSalesOrderHeader_");
			_salesOrderHeader = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			_addressTypeCollectionViaCustomerAddress = (AW.Data.CollectionClasses.AddressTypeCollection)info.GetValue("_addressTypeCollectionViaCustomerAddress", typeof(AW.Data.CollectionClasses.AddressTypeCollection));
			_alwaysFetchAddressTypeCollectionViaCustomerAddress = info.GetBoolean("_alwaysFetchAddressTypeCollectionViaCustomerAddress");
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = info.GetBoolean("_alreadyFetchedAddressTypeCollectionViaCustomerAddress");
			_contactCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader");
			_alreadyFetchedContactCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader");
			_contactCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader_");
			_alreadyFetchedContactCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader_");
			_creditCardCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader_");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_");
			_creditCardCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader");
			_currencyRateCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_");
			_currencyRateCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader");
			_customerCollectionViaCustomerAddress = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaCustomerAddress", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaCustomerAddress = info.GetBoolean("_alwaysFetchCustomerCollectionViaCustomerAddress");
			_alreadyFetchedCustomerCollectionViaCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerCollectionViaCustomerAddress");
			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");
			_customerCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader_");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader_");
			_customerViewRelatedCollectionViaSalesOrderHeader___ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader___", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___");
			_customerViewRelatedCollectionViaSalesOrderHeader____ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader____", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____");
			_employeeCollectionViaEmployeeAddress = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployeeAddress", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployeeAddress = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployeeAddress");
			_alreadyFetchedEmployeeCollectionViaEmployeeAddress = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployeeAddress");
			_salesTerritoryCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_");
			_salesTerritoryCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader");
			_shipMethodCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader_");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_");
			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");
			_stateProvince = (StateProvinceEntity)info.GetValue("_stateProvince", typeof(StateProvinceEntity));
			if(_stateProvince!=null)
			{
				_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_stateProvinceReturnsNewIfNotFound = info.GetBoolean("_stateProvinceReturnsNewIfNotFound");
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AddressFieldIndex)fieldIndex)
			{
				case AddressFieldIndex.StateProvinceId:
					DesetupSyncStateProvince(true, false);
					_alreadyFetchedStateProvince = false;
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
			_alreadyFetchedCustomerAddress = (_customerAddress.Count > 0);
			_alreadyFetchedEmployeeAddress = (_employeeAddress.Count > 0);
			_alreadyFetchedSalesOrderHeader_ = (_salesOrderHeader_.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = (_addressTypeCollectionViaCustomerAddress.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader = (_contactCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader_ = (_contactCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = (_creditCardCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = (_creditCardCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = (_currencyRateCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = (_currencyRateCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaCustomerAddress = (_customerCollectionViaCustomerAddress.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = (_customerCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = (_customerViewRelatedCollectionViaSalesOrderHeader___.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = (_customerViewRelatedCollectionViaSalesOrderHeader____.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployeeAddress = (_employeeCollectionViaEmployeeAddress.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = (_salesTerritoryCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = (_salesTerritoryCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = (_shipMethodCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedStateProvince = (_stateProvince != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AddressEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "StateProvince":
					toReturn.Add(AddressEntity.Relations.StateProvinceEntityUsingStateProvinceId);
					break;
				case "CustomerAddress":
					toReturn.Add(AddressEntity.Relations.CustomerAddressEntityUsingAddressId);
					break;
				case "EmployeeAddress":
					toReturn.Add(AddressEntity.Relations.EmployeeAddressEntityUsingAddressId);
					break;
				case "SalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId);
					break;
				case "SalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId);
					break;
				case "AddressTypeCollectionViaCustomerAddress":
					toReturn.Add(AddressEntity.Relations.CustomerAddressEntityUsingAddressId, "AddressEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeId, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaCustomerAddress":
					toReturn.Add(AddressEntity.Relations.CustomerAddressEntityUsingAddressId, "AddressEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerId, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader___":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader____":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaEmployeeAddress":
					toReturn.Add(AddressEntity.Relations.EmployeeAddressEntityUsingAddressId, "AddressEntity__", "EmployeeAddress_", JoinHint.None);
					toReturn.Add(EmployeeAddressEntity.Relations.EmployeeEntityUsingEmployeeId, "EmployeeAddress_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader_":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId, "AddressEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
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
			info.AddValue("_customerAddress", (!this.MarkedForDeletion?_customerAddress:null));
			info.AddValue("_alwaysFetchCustomerAddress", _alwaysFetchCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerAddress", _alreadyFetchedCustomerAddress);
			info.AddValue("_employeeAddress", (!this.MarkedForDeletion?_employeeAddress:null));
			info.AddValue("_alwaysFetchEmployeeAddress", _alwaysFetchEmployeeAddress);
			info.AddValue("_alreadyFetchedEmployeeAddress", _alreadyFetchedEmployeeAddress);
			info.AddValue("_salesOrderHeader_", (!this.MarkedForDeletion?_salesOrderHeader_:null));
			info.AddValue("_alwaysFetchSalesOrderHeader_", _alwaysFetchSalesOrderHeader_);
			info.AddValue("_alreadyFetchedSalesOrderHeader_", _alreadyFetchedSalesOrderHeader_);
			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_addressTypeCollectionViaCustomerAddress", (!this.MarkedForDeletion?_addressTypeCollectionViaCustomerAddress:null));
			info.AddValue("_alwaysFetchAddressTypeCollectionViaCustomerAddress", _alwaysFetchAddressTypeCollectionViaCustomerAddress);
			info.AddValue("_alreadyFetchedAddressTypeCollectionViaCustomerAddress", _alreadyFetchedAddressTypeCollectionViaCustomerAddress);
			info.AddValue("_contactCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader", _alwaysFetchContactCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader", _alreadyFetchedContactCollectionViaSalesOrderHeader);
			info.AddValue("_contactCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader_", _alwaysFetchContactCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader_", _alreadyFetchedContactCollectionViaSalesOrderHeader_);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader_", _alwaysFetchCreditCardCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader_);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader", _alwaysFetchCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaCustomerAddress", (!this.MarkedForDeletion?_customerCollectionViaCustomerAddress:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaCustomerAddress", _alwaysFetchCustomerCollectionViaCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerCollectionViaCustomerAddress", _alreadyFetchedCustomerCollectionViaCustomerAddress);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader_", _alwaysFetchCustomerCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader_", _alreadyFetchedCustomerCollectionViaSalesOrderHeader_);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader___", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader___:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader____", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader____:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____);
			info.AddValue("_employeeCollectionViaEmployeeAddress", (!this.MarkedForDeletion?_employeeCollectionViaEmployeeAddress:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployeeAddress", _alwaysFetchEmployeeCollectionViaEmployeeAddress);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployeeAddress", _alreadyFetchedEmployeeCollectionViaEmployeeAddress);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader_", _alwaysFetchShipMethodCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader_);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);
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
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "StateProvince":
					_alreadyFetchedStateProvince = true;
					this.StateProvince = (StateProvinceEntity)entity;
					break;
				case "CustomerAddress":
					_alreadyFetchedCustomerAddress = true;
					if(entity!=null)
					{
						this.CustomerAddress.Add((CustomerAddressEntity)entity);
					}
					break;
				case "EmployeeAddress":
					_alreadyFetchedEmployeeAddress = true;
					if(entity!=null)
					{
						this.EmployeeAddress.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "SalesOrderHeader_":
					_alreadyFetchedSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.SalesOrderHeader_.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesOrderHeader.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "AddressTypeCollectionViaCustomerAddress":
					_alreadyFetchedAddressTypeCollectionViaCustomerAddress = true;
					if(entity!=null)
					{
						this.AddressTypeCollectionViaCustomerAddress.Add((AddressTypeEntity)entity);
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
				case "CreditCardCollectionViaSalesOrderHeader_":
					_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaSalesOrderHeader_.Add((CreditCardEntity)entity);
					}
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CreditCardCollectionViaSalesOrderHeader.Add((CreditCardEntity)entity);
					}
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader_":
					_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CurrencyRateCollectionViaSalesOrderHeader_.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CurrencyRateCollectionViaSalesOrderHeader.Add((CurrencyRateEntity)entity);
					}
					break;
				case "CustomerCollectionViaCustomerAddress":
					_alreadyFetchedCustomerCollectionViaCustomerAddress = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaCustomerAddress.Add((CustomerEntity)entity);
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
				case "CustomerViewRelatedCollectionViaSalesOrderHeader___":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader___.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader____":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader____.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployeeAddress":
					_alreadyFetchedEmployeeCollectionViaEmployeeAddress = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployeeAddress.Add((EmployeeEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader_":
					_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaSalesOrderHeader_.Add((SalesTerritoryEntity)entity);
					}
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesTerritoryCollectionViaSalesOrderHeader.Add((SalesTerritoryEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader_":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader_.Add((ShipMethodEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
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
				case "StateProvince":
					SetupSyncStateProvince(relatedEntity);
					break;
				case "CustomerAddress":
					_customerAddress.Add((CustomerAddressEntity)relatedEntity);
					break;
				case "EmployeeAddress":
					_employeeAddress.Add((EmployeeAddressEntity)relatedEntity);
					break;
				case "SalesOrderHeader_":
					_salesOrderHeader_.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesOrderHeader":
					_salesOrderHeader.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "StateProvince":
					DesetupSyncStateProvince(false, true);
					break;
				case "CustomerAddress":
					base.PerformRelatedEntityRemoval(_customerAddress, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeAddress":
					base.PerformRelatedEntityRemoval(_employeeAddress, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeader_":
					base.PerformRelatedEntityRemoval(_salesOrderHeader_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeader":
					base.PerformRelatedEntityRemoval(_salesOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_stateProvince!=null)
			{
				toReturn.Add(_stateProvince);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_customerAddress);
			toReturn.Add(_employeeAddress);
			toReturn.Add(_salesOrderHeader_);
			toReturn.Add(_salesOrderHeader);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressId)
		{
			return FetchUsingPK(addressId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(addressId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(addressId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(addressId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AddressId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AddressFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AddressFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AddressRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch)
		{
			return GetMultiCustomerAddress(forceFetch, _customerAddress.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerAddress(forceFetch, _customerAddress.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerAddress.GetMultiManyToOne(this, null, null, filter);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerAddress'. These settings will be taken into account
		/// when the property CustomerAddress is requested or GetMultiCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerAddress.SortClauses=sortClauses;
			_customerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
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
				_employeeAddress.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiSalesOrderHeader_(forceFetch, _salesOrderHeader_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeader_(forceFetch, _salesOrderHeader_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeader_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader_ || forceFetch || _alwaysFetchSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader_);
					}
				}
				_salesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeader_.GetMultiManyToOne(null, this, null, null, null, null, null, null, null, filter);
				_salesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader_ = true;
			}
			return _salesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeader_'. These settings will be taken into account
		/// when the property SalesOrderHeader_ is requested or GetMultiSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeader_.SortClauses=sortClauses;
			_salesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
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
				_salesOrderHeader.GetMultiManyToOne(this, null, null, null, null, null, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddress(bool forceFetch)
		{
			return GetMultiAddressTypeCollectionViaCustomerAddress(forceFetch, _addressTypeCollectionViaCustomerAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressTypeCollectionViaCustomerAddress || forceFetch || _alwaysFetchAddressTypeCollectionViaCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressTypeCollectionViaCustomerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressTypeCollectionViaCustomerAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_addressTypeCollectionViaCustomerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressTypeCollectionViaCustomerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressTypeCollectionViaCustomerAddress.GetMulti(filter, GetRelationsForField("AddressTypeCollectionViaCustomerAddress"));
				_addressTypeCollectionViaCustomerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressTypeCollectionViaCustomerAddress = true;
			}
			return _addressTypeCollectionViaCustomerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressTypeCollectionViaCustomerAddress'. These settings will be taken into account
		/// when the property AddressTypeCollectionViaCustomerAddress is requested or GetMultiAddressTypeCollectionViaCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressTypeCollectionViaCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressTypeCollectionViaCustomerAddress.SortClauses=sortClauses;
			_addressTypeCollectionViaCustomerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedContactCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchContactCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_contactCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
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
 			if( ( !_alreadyFetchedContactCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchContactCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_contactCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
 			if( ( !_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCreditCardCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCardCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCardCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_creditCardCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_creditCardCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
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
 			if( ( !_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRateCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRateCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_currencyRateCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_currencyRateCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
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
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddress(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaCustomerAddress(forceFetch, _customerCollectionViaCustomerAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaCustomerAddress || forceFetch || _alwaysFetchCustomerCollectionViaCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerCollectionViaCustomerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerCollectionViaCustomerAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_customerCollectionViaCustomerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerCollectionViaCustomerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerCollectionViaCustomerAddress.GetMulti(filter, GetRelationsForField("CustomerCollectionViaCustomerAddress"));
				_customerCollectionViaCustomerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaCustomerAddress = true;
			}
			return _customerCollectionViaCustomerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaCustomerAddress'. These settings will be taken into account
		/// when the property CustomerCollectionViaCustomerAddress is requested or GetMultiCustomerCollectionViaCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaCustomerAddress.SortClauses=sortClauses;
			_customerCollectionViaCustomerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
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
 			if( ( !_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCustomerCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_customerCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader___.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader___.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader___"));
				_customerViewRelatedCollectionViaSalesOrderHeader___.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader___;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader___'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader___ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader___.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader____.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader____.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader____"));
				_customerViewRelatedCollectionViaSalesOrderHeader____.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader____;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader____'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader____ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader____.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeAddress(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaEmployeeAddress(forceFetch, _employeeCollectionViaEmployeeAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaEmployeeAddress || forceFetch || _alwaysFetchEmployeeCollectionViaEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaEmployeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaEmployeeAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_employeeCollectionViaEmployeeAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaEmployeeAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaEmployeeAddress.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaEmployeeAddress"));
				_employeeCollectionViaEmployeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaEmployeeAddress = true;
			}
			return _employeeCollectionViaEmployeeAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaEmployeeAddress'. These settings will be taken into account
		/// when the property EmployeeCollectionViaEmployeeAddress is requested or GetMultiEmployeeCollectionViaEmployeeAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaEmployeeAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaEmployeeAddress.SortClauses=sortClauses;
			_employeeCollectionViaEmployeeAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_salesTerritoryCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesTerritoryCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
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
 			if( ( !_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchShipMethodCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethodCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethodCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
				_shipMethodCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shipMethodCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
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
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressId, ComparisonOperator.Equal, this.AddressId, "AddressEntity__"));
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
			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AddressEntity.Relations.StateProvinceEntityUsingStateProvinceId);

				StateProvinceEntity newEntity = new StateProvinceEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.StateProvinceId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (StateProvinceEntity)base.ActiveContext.Get(newEntity);
					}
					this.StateProvince = newEntity;
				}
				else
				{
					if(_stateProvinceReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_stateProvince == null)))
						{
							this.StateProvince = newEntity;
						}
					}
					else
					{
						this.StateProvince = null;
					}
				}
				_alreadyFetchedStateProvince = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _stateProvince;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			AddressDAO dao = (AddressDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_customerAddress.ActiveContext = base.ActiveContext;
			_employeeAddress.ActiveContext = base.ActiveContext;
			_salesOrderHeader_.ActiveContext = base.ActiveContext;
			_salesOrderHeader.ActiveContext = base.ActiveContext;
			_addressTypeCollectionViaCustomerAddress.ActiveContext = base.ActiveContext;
			_contactCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_contactCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_creditCardCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_creditCardCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_currencyRateCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_currencyRateCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaCustomerAddress.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader___.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader____.ActiveContext = base.ActiveContext;
			_employeeCollectionViaEmployeeAddress.ActiveContext = base.ActiveContext;
			_salesTerritoryCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_salesTerritoryCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			if(_stateProvince!=null)
			{
				_stateProvince.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AddressDAO dao = (AddressDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AddressDAO dao = (AddressDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.AddressEntity);
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
			toReturn.Add("StateProvince", _stateProvince);
			toReturn.Add("CustomerAddress", _customerAddress);
			toReturn.Add("EmployeeAddress", _employeeAddress);
			toReturn.Add("SalesOrderHeader_", _salesOrderHeader_);
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("AddressTypeCollectionViaCustomerAddress", _addressTypeCollectionViaCustomerAddress);
			toReturn.Add("ContactCollectionViaSalesOrderHeader", _contactCollectionViaSalesOrderHeader);
			toReturn.Add("ContactCollectionViaSalesOrderHeader_", _contactCollectionViaSalesOrderHeader_);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader_", _creditCardCollectionViaSalesOrderHeader_);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader_", _currencyRateCollectionViaSalesOrderHeader_);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaCustomerAddress", _customerCollectionViaCustomerAddress);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader_", _customerCollectionViaSalesOrderHeader_);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader___", _customerViewRelatedCollectionViaSalesOrderHeader___);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader____", _customerViewRelatedCollectionViaSalesOrderHeader____);
			toReturn.Add("EmployeeCollectionViaEmployeeAddress", _employeeCollectionViaEmployeeAddress);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader_", _salesTerritoryCollectionViaSalesOrderHeader_);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader_", _shipMethodCollectionViaSalesOrderHeader_);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The validator object for this AddressEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 addressId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(addressId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_customerAddress = new AW.Data.CollectionClasses.CustomerAddressCollection(new CustomerAddressEntityFactory());
			_customerAddress.SetContainingEntityInfo(this, "Address");
			_alwaysFetchCustomerAddress = false;
			_alreadyFetchedCustomerAddress = false;
			_employeeAddress = new AW.Data.CollectionClasses.EmployeeAddressCollection(new EmployeeAddressEntityFactory());
			_employeeAddress.SetContainingEntityInfo(this, "Address");
			_alwaysFetchEmployeeAddress = false;
			_alreadyFetchedEmployeeAddress = false;
			_salesOrderHeader_ = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeader_.SetContainingEntityInfo(this, "Address_");
			_alwaysFetchSalesOrderHeader_ = false;
			_alreadyFetchedSalesOrderHeader_ = false;
			_salesOrderHeader = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "Address");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_addressTypeCollectionViaCustomerAddress = new AW.Data.CollectionClasses.AddressTypeCollection(new AddressTypeEntityFactory());
			_alwaysFetchAddressTypeCollectionViaCustomerAddress = false;
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = false;
			_contactCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaSalesOrderHeader = false;
			_alreadyFetchedContactCollectionViaSalesOrderHeader = false;
			_contactCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedContactCollectionViaSalesOrderHeader_ = false;
			_creditCardCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CreditCardCollection(new CreditCardEntityFactory());
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader_ = false;
			_creditCardCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CreditCardCollection(new CreditCardEntityFactory());
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = false;
			_currencyRateCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader_ = false;
			_currencyRateCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = false;
			_customerCollectionViaCustomerAddress = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaCustomerAddress = false;
			_alreadyFetchedCustomerCollectionViaCustomerAddress = false;
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = false;
			_customerCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader_ = false;
			_customerViewRelatedCollectionViaSalesOrderHeader___ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = false;
			_customerViewRelatedCollectionViaSalesOrderHeader____ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = false;
			_employeeCollectionViaEmployeeAddress = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaEmployeeAddress = false;
			_alreadyFetchedEmployeeCollectionViaEmployeeAddress = false;
			_salesTerritoryCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.SalesTerritoryCollection(new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader_ = false;
			_salesTerritoryCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesTerritoryCollection(new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = false;
			_shipMethodCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader_ = false;
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = false;
			_stateProvince = null;
			_stateProvinceReturnsNewIfNotFound = true;
			_alwaysFetchStateProvince = false;
			_alreadyFetchedStateProvince = false;


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

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("StateProvinceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _stateProvince</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AddressEntity.Relations.StateProvinceEntityUsingStateProvinceId, true, signalRelatedEntity, "Address", resetFKFields, new int[] { (int)AddressFieldIndex.StateProvinceId } );		
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
				base.PerformSetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AddressEntity.Relations.StateProvinceEntityUsingStateProvinceId, true, ref _alreadyFetchedStateProvince, new string[] { "StateProvinceCode", "Name", "CountryRegionCode" } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStateProvincePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				case "StateProvinceCode":
					base.OnPropertyChanged("StateProvinceCode");
					break;
				case "Name":
					base.OnPropertyChanged("Name");
					break;
				case "CountryRegionCode":
					base.OnPropertyChanged("CountryRegionCode");
					break;
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="addressId">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AddressFieldIndex.AddressId].ForcedCurrentValueWrite(addressId);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerAddressCollection(),
					(IEntityRelation)GetRelationsForField("CustomerAddress")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerAddressEntity, 0, null, null, null, "CustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("EmployeeAddress")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeader_")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressTypeCollectionViaCustomerAddress
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.CustomerAddressEntityUsingAddressId;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, GetRelationsForField("AddressTypeCollectionViaCustomerAddress"), "AddressTypeCollectionViaCustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader"), "ContactCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader_"), "ContactCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader_"), "CreditCardCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader_"), "CurrencyRateCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaCustomerAddress
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.CustomerAddressEntityUsingAddressId;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaCustomerAddress"), "CustomerCollectionViaCustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader_"), "CustomerCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader___
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader___"), "CustomerViewRelatedCollectionViaSalesOrderHeader___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader____
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader____"), "CustomerViewRelatedCollectionViaSalesOrderHeader____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployeeAddress
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.EmployeeAddressEntityUsingAddressId;
				intermediateRelation.SetAliases(string.Empty, "EmployeeAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployeeAddress"), "EmployeeCollectionViaEmployeeAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader_"), "SalesTerritoryCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingShipToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader_"), "ShipMethodCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = AddressEntity.Relations.SalesOrderHeaderEntityUsingBillToAddressId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvince
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(),
					(IEntityRelation)GetRelationsForField("StateProvince")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AddressEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AddressEntity.CustomProperties;}
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
			get { return AddressEntity.FieldsCustomProperties;}
		}

		/// <summary> The AddressId property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.AddressId, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressId, value, true); }
		}
		/// <summary> The AddressLine1 property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine1, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine1, value, true); }
		}
		/// <summary> The AddressLine2 property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine2, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine2, value, true); }
		}
		/// <summary> The City property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set	{ SetValue((int)AddressFieldIndex.City, value, true); }
		}
		/// <summary> The StateProvinceId property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.StateProvinceId, true); }
			set	{ SetValue((int)AddressFieldIndex.StateProvinceId, value, true); }
		}
		/// <summary> The PostalCode property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.PostalCode, true); }
			set	{ SetValue((int)AddressFieldIndex.PostalCode, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Address<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Address"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection CustomerAddress
		{
			get	{ return GetMultiCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerAddress. When set to true, CustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerAddress
		{
			get	{ return _alwaysFetchCustomerAddress; }
			set	{ _alwaysFetchCustomerAddress = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerAddress already has been fetched. Setting this property to false when CustomerAddress has been fetched
		/// will clear the CustomerAddress collection well. Setting this property to true while CustomerAddress hasn't been fetched disables lazy loading for CustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerAddress
		{
			get { return _alreadyFetchedCustomerAddress;}
			set 
			{
				if(_alreadyFetchedCustomerAddress && !value && (_customerAddress != null))
				{
					_customerAddress.Clear();
				}
				_alreadyFetchedCustomerAddress = value;
			}
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
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeAddress already has been fetched. Setting this property to false when EmployeeAddress has been fetched
		/// will clear the EmployeeAddress collection well. Setting this property to true while EmployeeAddress hasn't been fetched disables lazy loading for EmployeeAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeAddress
		{
			get { return _alreadyFetchedEmployeeAddress;}
			set 
			{
				if(_alreadyFetchedEmployeeAddress && !value && (_employeeAddress != null))
				{
					_employeeAddress.Clear();
				}
				_alreadyFetchedEmployeeAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeader_
		{
			get	{ return GetMultiSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader_. When set to true, SalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader_
		{
			get	{ return _alwaysFetchSalesOrderHeader_; }
			set	{ _alwaysFetchSalesOrderHeader_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeader_ already has been fetched. Setting this property to false when SalesOrderHeader_ has been fetched
		/// will clear the SalesOrderHeader_ collection well. Setting this property to true while SalesOrderHeader_ hasn't been fetched disables lazy loading for SalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeader_
		{
			get { return _alreadyFetchedSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeader_ && !value && (_salesOrderHeader_ != null))
				{
					_salesOrderHeader_.Clear();
				}
				_alreadyFetchedSalesOrderHeader_ = value;
			}
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
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeader already has been fetched. Setting this property to false when SalesOrderHeader has been fetched
		/// will clear the SalesOrderHeader collection well. Setting this property to true while SalesOrderHeader hasn't been fetched disables lazy loading for SalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeader
		{
			get { return _alreadyFetchedSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeader && !value && (_salesOrderHeader != null))
				{
					_salesOrderHeader.Clear();
				}
				_alreadyFetchedSalesOrderHeader = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressTypeCollectionViaCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressTypeCollection AddressTypeCollectionViaCustomerAddress
		{
			get { return GetMultiAddressTypeCollectionViaCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressTypeCollectionViaCustomerAddress. When set to true, AddressTypeCollectionViaCustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressTypeCollectionViaCustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressTypeCollectionViaCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressTypeCollectionViaCustomerAddress
		{
			get	{ return _alwaysFetchAddressTypeCollectionViaCustomerAddress; }
			set	{ _alwaysFetchAddressTypeCollectionViaCustomerAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressTypeCollectionViaCustomerAddress already has been fetched. Setting this property to false when AddressTypeCollectionViaCustomerAddress has been fetched
		/// will clear the AddressTypeCollectionViaCustomerAddress collection well. Setting this property to true while AddressTypeCollectionViaCustomerAddress hasn't been fetched disables lazy loading for AddressTypeCollectionViaCustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressTypeCollectionViaCustomerAddress
		{
			get { return _alreadyFetchedAddressTypeCollectionViaCustomerAddress;}
			set 
			{
				if(_alreadyFetchedAddressTypeCollectionViaCustomerAddress && !value && (_addressTypeCollectionViaCustomerAddress != null))
				{
					_addressTypeCollectionViaCustomerAddress.Clear();
				}
				_alreadyFetchedAddressTypeCollectionViaCustomerAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaSalesOrderHeader
		{
			get { return GetMultiContactCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaSalesOrderHeader. When set to true, ContactCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaSalesOrderHeader(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaSalesOrderHeader_
		{
			get { return GetMultiContactCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaSalesOrderHeader_. When set to true, ContactCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaSalesOrderHeader_(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCardCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CreditCardCollection CreditCardCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCreditCardCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCardCollectionViaSalesOrderHeader_. When set to true, CreditCardCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCardCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCreditCardCollectionViaSalesOrderHeader_(true).</summary>
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRateCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CurrencyRateCollection CurrencyRateCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCurrencyRateCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRateCollectionViaSalesOrderHeader_. When set to true, CurrencyRateCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRateCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRateCollectionViaSalesOrderHeader_(true).</summary>
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaCustomerAddress
		{
			get { return GetMultiCustomerCollectionViaCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaCustomerAddress. When set to true, CustomerCollectionViaCustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaCustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerCollectionViaCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaCustomerAddress
		{
			get	{ return _alwaysFetchCustomerCollectionViaCustomerAddress; }
			set	{ _alwaysFetchCustomerCollectionViaCustomerAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaCustomerAddress already has been fetched. Setting this property to false when CustomerCollectionViaCustomerAddress has been fetched
		/// will clear the CustomerCollectionViaCustomerAddress collection well. Setting this property to true while CustomerCollectionViaCustomerAddress hasn't been fetched disables lazy loading for CustomerCollectionViaCustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaCustomerAddress
		{
			get { return _alreadyFetchedCustomerCollectionViaCustomerAddress;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaCustomerAddress && !value && (_customerCollectionViaCustomerAddress != null))
				{
					_customerCollectionViaCustomerAddress.Clear();
				}
				_alreadyFetchedCustomerCollectionViaCustomerAddress = value;
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
		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCustomerCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaSalesOrderHeader_. When set to true, CustomerCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerCollectionViaSalesOrderHeader_(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader___
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader___. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader___ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader___ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader___ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader___ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader___ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader___.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader____
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader____. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader____ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader____ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader____ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader____ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader____ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader____.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaEmployeeAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaEmployeeAddress
		{
			get { return GetMultiEmployeeCollectionViaEmployeeAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaEmployeeAddress. When set to true, EmployeeCollectionViaEmployeeAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaEmployeeAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaEmployeeAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaEmployeeAddress
		{
			get	{ return _alwaysFetchEmployeeCollectionViaEmployeeAddress; }
			set	{ _alwaysFetchEmployeeCollectionViaEmployeeAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaEmployeeAddress already has been fetched. Setting this property to false when EmployeeCollectionViaEmployeeAddress has been fetched
		/// will clear the EmployeeCollectionViaEmployeeAddress collection well. Setting this property to true while EmployeeCollectionViaEmployeeAddress hasn't been fetched disables lazy loading for EmployeeCollectionViaEmployeeAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaEmployeeAddress
		{
			get { return _alreadyFetchedEmployeeCollectionViaEmployeeAddress;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaEmployeeAddress && !value && (_employeeCollectionViaEmployeeAddress != null))
				{
					_employeeCollectionViaEmployeeAddress.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaEmployeeAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryCollection SalesTerritoryCollectionViaSalesOrderHeader_
		{
			get { return GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryCollectionViaSalesOrderHeader_. When set to true, SalesTerritoryCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritoryCollectionViaSalesOrderHeader_(true).</summary>
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaSalesOrderHeader_
		{
			get { return GetMultiShipMethodCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaSalesOrderHeader_. When set to true, ShipMethodCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethodCollectionViaSalesOrderHeader_(true).</summary>
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

		/// <summary> Gets / sets related entity of type 'StateProvinceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual StateProvinceEntity StateProvince
		{
			get	{ return GetSingleStateProvince(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncStateProvince(value);
				}
				else
				{
					if(value==null)
					{
						if(_stateProvince != null)
						{
							_stateProvince.UnsetRelatedEntity(this, "Address");
						}
					}
					else
					{
						if(_stateProvince!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Address");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvince. When set to true, StateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvince is accessed. You can always execute
		/// a forced fetch by calling GetSingleStateProvince(true).</summary>
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

 
		/// <summary> Gets / Sets the value of the related field this.StateProvince.StateProvinceCode.</summary>
		public virtual System.String StateProvinceCode
		{
			get
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					return relatedEntity.StateProvinceCode;
				}
				else
				{
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
			}
			set
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					relatedEntity.StateProvinceCode = value;
				}				
			}
		} 
		/// <summary> Gets / Sets the value of the related field this.StateProvince.Name.</summary>
		public virtual System.String Name
		{
			get
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					return relatedEntity.Name;
				}
				else
				{
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
			}
			set
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					relatedEntity.Name = value;
				}				
			}
		} 
		/// <summary> Gets / Sets the value of the related field this.StateProvince.CountryRegionCode.</summary>
		public virtual System.String CountryRegionCode
		{
			get
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					return relatedEntity.CountryRegionCode;
				}
				else
				{
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
			}
			set
			{
				StateProvinceEntity relatedEntity = this.StateProvince;
				if(relatedEntity!=null)
				{
					relatedEntity.CountryRegionCode = value;
				}				
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
