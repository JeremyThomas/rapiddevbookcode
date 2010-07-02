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
	/// <summary>Entity base class which represents the base class for the entity 'SalesTerritory'.<br/><br/>
	/// 
	/// MS_Description: Sales territory lookup table.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class SalesTerritoryEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CustomerCollection	_customers;
		private bool	_alwaysFetchCustomers, _alreadyFetchedCustomers;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.SalesPersonCollection	_salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private AW.Data.CollectionClasses.SalesTerritoryHistoryCollection	_salesTerritoryHistory;
		private bool	_alwaysFetchSalesTerritoryHistory, _alreadyFetchedSalesTerritoryHistory;
		private AW.Data.CollectionClasses.StateProvinceCollection	_stateProvinces;
		private bool	_alwaysFetchStateProvinces, _alreadyFetchedStateProvinces;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader, _alreadyFetchedAddressCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader_, _alreadyFetchedAddressCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader, _alreadyFetchedContactCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CountryRegionCollection _countryRegionCollectionViaStateProvince;
		private bool	_alwaysFetchCountryRegionCollectionViaStateProvince, _alreadyFetchedCountryRegionCollectionViaStateProvince;
		private AW.Data.CollectionClasses.CreditCardCollection _creditCardCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCreditCardCollectionViaSalesOrderHeader, _alreadyFetchedCreditCardCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader______;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______;
		private AW.Data.CollectionClasses.SalesPersonCollection _salesPersonCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesPersonCollectionViaSalesOrderHeader, _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.SalesPersonCollection _salesPersonCollectionViaSalesTerritoryHistory;
		private bool	_alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory, _alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name SalesTerritoryHistory</summary>
			public static readonly string SalesTerritoryHistory = "SalesTerritoryHistory";
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader = "ContactCollectionViaSalesOrderHeader";
			/// <summary>Member name CountryRegionCollectionViaStateProvince</summary>
			public static readonly string CountryRegionCollectionViaStateProvince = "CountryRegionCollectionViaStateProvince";
			/// <summary>Member name CreditCardCollectionViaSalesOrderHeader</summary>
			public static readonly string CreditCardCollectionViaSalesOrderHeader = "CreditCardCollectionViaSalesOrderHeader";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader______</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader______ = "CustomerViewRelatedCollectionViaSalesOrderHeader______";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesPersonCollectionViaSalesTerritoryHistory</summary>
			public static readonly string SalesPersonCollectionViaSalesTerritoryHistory = "SalesPersonCollectionViaSalesTerritoryHistory";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesTerritoryEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesTerritoryEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		public SalesTerritoryEntityBase(System.Int32 territoryID)
		{
			InitClassFetch(territoryID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesTerritoryEntityBase(System.Int32 territoryID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(territoryID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntityBase(System.Int32 territoryID, IValidator validator)
		{
			InitClassFetch(territoryID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTerritoryEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customers = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customers", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomers = info.GetBoolean("_alwaysFetchCustomers");
			_alreadyFetchedCustomers = info.GetBoolean("_alreadyFetchedCustomers");
			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");
			_salesPerson = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPerson", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
			_salesTerritoryHistory = (AW.Data.CollectionClasses.SalesTerritoryHistoryCollection)info.GetValue("_salesTerritoryHistory", typeof(AW.Data.CollectionClasses.SalesTerritoryHistoryCollection));
			_alwaysFetchSalesTerritoryHistory = info.GetBoolean("_alwaysFetchSalesTerritoryHistory");
			_alreadyFetchedSalesTerritoryHistory = info.GetBoolean("_alreadyFetchedSalesTerritoryHistory");
			_stateProvinces = (AW.Data.CollectionClasses.StateProvinceCollection)info.GetValue("_stateProvinces", typeof(AW.Data.CollectionClasses.StateProvinceCollection));
			_alwaysFetchStateProvinces = info.GetBoolean("_alwaysFetchStateProvinces");
			_alreadyFetchedStateProvinces = info.GetBoolean("_alreadyFetchedStateProvinces");
			_addressCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader");
			_addressCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader_");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader_");
			_contactCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader");
			_alreadyFetchedContactCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader");
			_countryRegionCollectionViaStateProvince = (AW.Data.CollectionClasses.CountryRegionCollection)info.GetValue("_countryRegionCollectionViaStateProvince", typeof(AW.Data.CollectionClasses.CountryRegionCollection));
			_alwaysFetchCountryRegionCollectionViaStateProvince = info.GetBoolean("_alwaysFetchCountryRegionCollectionViaStateProvince");
			_alreadyFetchedCountryRegionCollectionViaStateProvince = info.GetBoolean("_alreadyFetchedCountryRegionCollectionViaStateProvince");
			_creditCardCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CreditCardCollection)info.GetValue("_creditCardCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CreditCardCollection));
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCreditCardCollectionViaSalesOrderHeader");
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader");
			_currencyRateCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader");
			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");
			_customerViewRelatedCollectionViaSalesOrderHeader______ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader______", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______");
			_salesPersonCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader");
			_salesPersonCollectionViaSalesTerritoryHistory = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPersonCollectionViaSalesTerritoryHistory", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory = info.GetBoolean("_alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory");
			_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = info.GetBoolean("_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory");
			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesTerritoryFieldIndex)fieldIndex)
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
			_alreadyFetchedCustomers = (_customers.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson.Count > 0);
			_alreadyFetchedSalesTerritoryHistory = (_salesTerritoryHistory.Count > 0);
			_alreadyFetchedStateProvinces = (_stateProvinces.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = (_addressCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = (_addressCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader = (_contactCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCountryRegionCollectionViaStateProvince = (_countryRegionCollectionViaStateProvince.Count > 0);
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = (_creditCardCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = (_currencyRateCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = (_customerViewRelatedCollectionViaSalesOrderHeader______.Count > 0);
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = (_salesPersonCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = (_salesPersonCollectionViaSalesTerritoryHistory.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SalesTerritoryEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Customers":
					toReturn.Add(SalesTerritoryEntity.Relations.CustomerEntityUsingTerritoryID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID);
					break;
				case "SalesPerson":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesPersonEntityUsingTerritoryID);
					break;
				case "SalesTerritoryHistory":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesTerritoryHistoryEntityUsingTerritoryID);
					break;
				case "StateProvinces":
					toReturn.Add(SalesTerritoryEntity.Relations.StateProvinceEntityUsingTerritoryID);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CountryRegionCollectionViaStateProvince":
					toReturn.Add(SalesTerritoryEntity.Relations.StateProvinceEntityUsingTerritoryID, "SalesTerritoryEntity__", "StateProvince_", JoinHint.None);
					toReturn.Add(StateProvinceEntity.Relations.CountryRegionEntityUsingCountryRegionCode, "StateProvince_", string.Empty, JoinHint.None);
					break;
				case "CreditCardCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader______":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesTerritoryHistory":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesTerritoryHistoryEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesTerritoryHistory_", JoinHint.None);
					toReturn.Add(SalesTerritoryHistoryEntity.Relations.SalesPersonEntityUsingSalesPersonID, "SalesTerritoryHistory_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID, "SalesTerritoryEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, "SalesOrderHeader_", string.Empty, JoinHint.None);
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
			info.AddValue("_customers", (!this.MarkedForDeletion?_customers:null));
			info.AddValue("_alwaysFetchCustomers", _alwaysFetchCustomers);
			info.AddValue("_alreadyFetchedCustomers", _alreadyFetchedCustomers);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritoryHistory", (!this.MarkedForDeletion?_salesTerritoryHistory:null));
			info.AddValue("_alwaysFetchSalesTerritoryHistory", _alwaysFetchSalesTerritoryHistory);
			info.AddValue("_alreadyFetchedSalesTerritoryHistory", _alreadyFetchedSalesTerritoryHistory);
			info.AddValue("_stateProvinces", (!this.MarkedForDeletion?_stateProvinces:null));
			info.AddValue("_alwaysFetchStateProvinces", _alwaysFetchStateProvinces);
			info.AddValue("_alreadyFetchedStateProvinces", _alreadyFetchedStateProvinces);
			info.AddValue("_addressCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader", _alwaysFetchAddressCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader", _alreadyFetchedAddressCollectionViaSalesOrderHeader);
			info.AddValue("_addressCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader_", _alwaysFetchAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader_", _alreadyFetchedAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_contactCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader", _alwaysFetchContactCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader", _alreadyFetchedContactCollectionViaSalesOrderHeader);
			info.AddValue("_countryRegionCollectionViaStateProvince", (!this.MarkedForDeletion?_countryRegionCollectionViaStateProvince:null));
			info.AddValue("_alwaysFetchCountryRegionCollectionViaStateProvince", _alwaysFetchCountryRegionCollectionViaStateProvince);
			info.AddValue("_alreadyFetchedCountryRegionCollectionViaStateProvince", _alreadyFetchedCountryRegionCollectionViaStateProvince);
			info.AddValue("_creditCardCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_creditCardCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCreditCardCollectionViaSalesOrderHeader", _alwaysFetchCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCreditCardCollectionViaSalesOrderHeader", _alreadyFetchedCreditCardCollectionViaSalesOrderHeader);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader______", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader______:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______);
			info.AddValue("_salesPersonCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesPersonCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader", _alwaysFetchSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader", _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_salesPersonCollectionViaSalesTerritoryHistory", (!this.MarkedForDeletion?_salesPersonCollectionViaSalesTerritoryHistory:null));
			info.AddValue("_alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory", _alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory);
			info.AddValue("_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory", _alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);


			
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

				case "Customers":
					_alreadyFetchedCustomers = true;
					if(entity!=null)
					{
						this.Customers.Add((CustomerEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					if(entity!=null)
					{
						this.SalesPerson.Add((SalesPersonEntity)entity);
					}
					break;
				case "SalesTerritoryHistory":
					_alreadyFetchedSalesTerritoryHistory = true;
					if(entity!=null)
					{
						this.SalesTerritoryHistory.Add((SalesTerritoryHistoryEntity)entity);
					}
					break;
				case "StateProvinces":
					_alreadyFetchedStateProvinces = true;
					if(entity!=null)
					{
						this.StateProvinces.Add((StateProvinceEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader_.Add((AddressEntity)entity);
					}
					break;
				case "ContactCollectionViaSalesOrderHeader":
					_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ContactCollectionViaSalesOrderHeader.Add((ContactEntity)entity);
					}
					break;
				case "CountryRegionCollectionViaStateProvince":
					_alreadyFetchedCountryRegionCollectionViaStateProvince = true;
					if(entity!=null)
					{
						this.CountryRegionCollectionViaStateProvince.Add((CountryRegionEntity)entity);
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
				case "CustomerViewRelatedCollectionViaSalesOrderHeader______":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader______.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesPersonCollectionViaSalesOrderHeader.Add((SalesPersonEntity)entity);
					}
					break;
				case "SalesPersonCollectionViaSalesTerritoryHistory":
					_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = true;
					if(entity!=null)
					{
						this.SalesPersonCollectionViaSalesTerritoryHistory.Add((SalesPersonEntity)entity);
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

				case "Customers":
					_customers.Add((CustomerEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPerson":
					_salesPerson.Add((SalesPersonEntity)relatedEntity);
					break;
				case "SalesTerritoryHistory":
					_salesTerritoryHistory.Add((SalesTerritoryHistoryEntity)relatedEntity);
					break;
				case "StateProvinces":
					_stateProvinces.Add((StateProvinceEntity)relatedEntity);
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

				case "Customers":
					base.PerformRelatedEntityRemoval(_customers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					base.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPerson":
					base.PerformRelatedEntityRemoval(_salesPerson, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistory":
					base.PerformRelatedEntityRemoval(_salesTerritoryHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "StateProvinces":
					base.PerformRelatedEntityRemoval(_stateProvinces, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_customers);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_salesPerson);
			toReturn.Add(_salesTerritoryHistory);
			toReturn.Add(_stateProvinces);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID)
		{
			return FetchUsingPK(territoryID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(territoryID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(territoryID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(territoryID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.TerritoryID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesTerritoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesTerritoryFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SalesTerritoryRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch)
		{
			return GetMultiCustomers(forceFetch, _customers.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomers(forceFetch, _customers.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomers(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerCollection GetMultiCustomers(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomers || forceFetch || _alwaysFetchCustomers) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customers.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customers);
					}
				}
				_customers.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customers.EntityFactoryToUse = entityFactoryToUse;
				}
				_customers.GetMultiManyToOne(this, filter);
				_customers.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomers = true;
			}
			return _customers;
		}

		/// <summary> Sets the collection parameters for the collection for 'Customers'. These settings will be taken into account
		/// when the property Customers is requested or GetMultiCustomers is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomers(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customers.SortClauses=sortClauses;
			_customers.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, null, null, null, null, null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPerson(bool forceFetch)
		{
			return GetMultiSalesPerson(forceFetch, _salesPerson.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesPerson(forceFetch, _salesPerson.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesPerson(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson);
					}
				}
				_salesPerson.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesPerson.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesPerson.GetMultiManyToOne(this, filter);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesPerson'. These settings will be taken into account
		/// when the property SalesPerson is requested or GetMultiSalesPerson is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPerson(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPerson.SortClauses=sortClauses;
			_salesPerson.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch)
		{
			return GetMultiSalesTerritoryHistory(forceFetch, _salesTerritoryHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesTerritoryHistory(forceFetch, _salesTerritoryHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesTerritoryHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistory || forceFetch || _alwaysFetchSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryHistory);
					}
				}
				_salesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesTerritoryHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesTerritoryHistory.GetMultiManyToOne(null, this, filter);
				_salesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistory = true;
			}
			return _salesTerritoryHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesTerritoryHistory'. These settings will be taken into account
		/// when the property SalesTerritoryHistory is requested or GetMultiSalesTerritoryHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryHistory.SortClauses=sortClauses;
			_salesTerritoryHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStateProvinces(forceFetch, _stateProvinces.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStateProvinces(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection GetMultiStateProvinces(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStateProvinces || forceFetch || _alwaysFetchStateProvinces) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvinces.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvinces);
					}
				}
				_stateProvinces.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_stateProvinces.EntityFactoryToUse = entityFactoryToUse;
				}
				_stateProvinces.GetMultiManyToOne(null, this, filter);
				_stateProvinces.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvinces = true;
			}
			return _stateProvinces;
		}

		/// <summary> Sets the collection parameters for the collection for 'StateProvinces'. These settings will be taken into account
		/// when the property StateProvinces is requested or GetMultiStateProvinces is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStateProvinces(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stateProvinces.SortClauses=sortClauses;
			_stateProvinces.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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

		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionEntity'</returns>
		public AW.Data.CollectionClasses.CountryRegionCollection GetMultiCountryRegionCollectionViaStateProvince(bool forceFetch)
		{
			return GetMultiCountryRegionCollectionViaStateProvince(forceFetch, _countryRegionCollectionViaStateProvince.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CountryRegionCollection GetMultiCountryRegionCollectionViaStateProvince(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCountryRegionCollectionViaStateProvince || forceFetch || _alwaysFetchCountryRegionCollectionViaStateProvince) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCollectionViaStateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCollectionViaStateProvince);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
				_countryRegionCollectionViaStateProvince.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_countryRegionCollectionViaStateProvince.EntityFactoryToUse = entityFactoryToUse;
				}
				_countryRegionCollectionViaStateProvince.GetMulti(filter, GetRelationsForField("CountryRegionCollectionViaStateProvince"));
				_countryRegionCollectionViaStateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCollectionViaStateProvince = true;
			}
			return _countryRegionCollectionViaStateProvince;
		}

		/// <summary> Sets the collection parameters for the collection for 'CountryRegionCollectionViaStateProvince'. These settings will be taken into account
		/// when the property CountryRegionCollectionViaStateProvince is requested or GetMultiCountryRegionCollectionViaStateProvince is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegionCollectionViaStateProvince(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegionCollectionViaStateProvince.SortClauses=sortClauses;
			_countryRegionCollectionViaStateProvince.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader______.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader______);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader______.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader______.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader______"));
				_customerViewRelatedCollectionViaSalesOrderHeader______.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader______;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader______'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader______ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader______.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPersonCollectionViaSalesTerritoryHistory(bool forceFetch)
		{
			return GetMultiSalesPersonCollectionViaSalesTerritoryHistory(forceFetch, _salesPersonCollectionViaSalesTerritoryHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesPersonCollection GetMultiSalesPersonCollectionViaSalesTerritoryHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory || forceFetch || _alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonCollectionViaSalesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonCollectionViaSalesTerritoryHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
				_salesPersonCollectionViaSalesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesPersonCollectionViaSalesTerritoryHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesPersonCollectionViaSalesTerritoryHistory.GetMulti(filter, GetRelationsForField("SalesPersonCollectionViaSalesTerritoryHistory"));
				_salesPersonCollectionViaSalesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = true;
			}
			return _salesPersonCollectionViaSalesTerritoryHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesPersonCollectionViaSalesTerritoryHistory'. These settings will be taken into account
		/// when the property SalesPersonCollectionViaSalesTerritoryHistory is requested or GetMultiSalesPersonCollectionViaSalesTerritoryHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPersonCollectionViaSalesTerritoryHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPersonCollectionViaSalesTerritoryHistory.SortClauses=sortClauses;
			_salesPersonCollectionViaSalesTerritoryHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryID, ComparisonOperator.Equal, this.TerritoryID, "SalesTerritoryEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesTerritoryDAO dao = (SalesTerritoryDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_customers.ActiveContext = base.ActiveContext;
			_salesOrderHeaders.ActiveContext = base.ActiveContext;
			_salesPerson.ActiveContext = base.ActiveContext;
			_salesTerritoryHistory.ActiveContext = base.ActiveContext;
			_stateProvinces.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_contactCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_countryRegionCollectionViaStateProvince.ActiveContext = base.ActiveContext;
			_creditCardCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_currencyRateCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader______.ActiveContext = base.ActiveContext;
			_salesPersonCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_salesPersonCollectionViaSalesTerritoryHistory.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesTerritoryDAO dao = (SalesTerritoryDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesTerritoryDAO dao = (SalesTerritoryDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesTerritoryEntity);
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

			toReturn.Add("Customers", _customers);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("SalesTerritoryHistory", _salesTerritoryHistory);
			toReturn.Add("StateProvinces", _stateProvinces);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("ContactCollectionViaSalesOrderHeader", _contactCollectionViaSalesOrderHeader);
			toReturn.Add("CountryRegionCollectionViaStateProvince", _countryRegionCollectionViaStateProvince);
			toReturn.Add("CreditCardCollectionViaSalesOrderHeader", _creditCardCollectionViaSalesOrderHeader);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader______", _customerViewRelatedCollectionViaSalesOrderHeader______);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesPersonCollectionViaSalesTerritoryHistory", _salesPersonCollectionViaSalesTerritoryHistory);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The validator object for this SalesTerritoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 territoryID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(territoryID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_customers = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_customers.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchCustomers = false;
			_alreadyFetchedCustomers = false;
			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeaders.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesOrderHeaders = false;
			_alreadyFetchedSalesOrderHeaders = false;
			_salesPerson = new AW.Data.CollectionClasses.SalesPersonCollection(new SalesPersonEntityFactory());
			_salesPerson.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritoryHistory = new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection(new SalesTerritoryHistoryEntityFactory());
			_salesTerritoryHistory.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesTerritoryHistory = false;
			_alreadyFetchedSalesTerritoryHistory = false;
			_stateProvinces = new AW.Data.CollectionClasses.StateProvinceCollection(new StateProvinceEntityFactory());
			_stateProvinces.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchStateProvinces = false;
			_alreadyFetchedStateProvinces = false;
			_addressCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = false;
			_addressCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = false;
			_contactCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaSalesOrderHeader = false;
			_alreadyFetchedContactCollectionViaSalesOrderHeader = false;
			_countryRegionCollectionViaStateProvince = new AW.Data.CollectionClasses.CountryRegionCollection(new CountryRegionEntityFactory());
			_alwaysFetchCountryRegionCollectionViaStateProvince = false;
			_alreadyFetchedCountryRegionCollectionViaStateProvince = false;
			_creditCardCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CreditCardCollection(new CreditCardEntityFactory());
			_alwaysFetchCreditCardCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCreditCardCollectionViaSalesOrderHeader = false;
			_currencyRateCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = false;
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = false;
			_customerViewRelatedCollectionViaSalesOrderHeader______ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = false;
			_salesPersonCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesPersonCollection(new SalesPersonEntityFactory());
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = false;
			_salesPersonCollectionViaSalesTerritoryHistory = new AW.Data.CollectionClasses.SalesPersonCollection(new SalesPersonEntityFactory());
			_alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory = false;
			_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = false;
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = false;



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
			_customProperties.Add("MS_Description", @"Sales territory lookup table.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales territory description");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Geographic area to which the sales territory belong.");
			_fieldsCustomProperties.Add("Group", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales in the territory year to date.");
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales in the territory the previous year.");
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Business costs in the territory year to date.");
			_fieldsCustomProperties.Add("CostYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Business costs in the territory the previous year.");
			_fieldsCustomProperties.Add("CostLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 territoryID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesTerritoryFieldIndex.TerritoryID].ForcedCurrentValueWrite(territoryID);
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
			return DAOFactory.CreateSalesTerritoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesTerritoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesTerritoryRelations Relations
		{
			get	{ return new SalesTerritoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomers
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(),
					(IEntityRelation)GetRelationsForField("Customers")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryHistoryCollection(),
					(IEntityRelation)GetRelationsForField("SalesTerritoryHistory")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, "SalesTerritoryHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvinces
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(),
					(IEntityRelation)GetRelationsForField("StateProvinces")[0], (int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvinces", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader"), "ContactCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CountryRegion' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCountryRegionCollectionViaStateProvince
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.StateProvinceEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "StateProvince_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CountryRegionCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CountryRegionEntity, 0, null, null, GetRelationsForField("CountryRegionCollectionViaStateProvince"), "CountryRegionCollectionViaStateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCardCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, GetRelationsForField("CreditCardCollectionViaSalesOrderHeader"), "CreditCardCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader______
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader______"), "CustomerViewRelatedCollectionViaSalesOrderHeader______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPersonCollectionViaSalesTerritoryHistory
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesTerritoryHistoryEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesTerritoryHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesTerritoryHistory"), "SalesPersonCollectionViaSalesTerritoryHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = SalesTerritoryEntity.Relations.SalesOrderHeaderEntityUsingTerritoryID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesTerritoryEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SalesTerritoryEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SalesTerritoryEntity.CustomProperties;}
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
			get { return SalesTerritoryEntity.FieldsCustomProperties;}
		}

		/// <summary> The TerritoryID property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TerritoryID
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryFieldIndex.TerritoryID, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.TerritoryID, value, true); }
		}
		/// <summary> The Name property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Sales territory description<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Name, value, true); }
		}
		/// <summary> The CountryRegionCode property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, value, true); }
		}
		/// <summary> The Group property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Geographic area to which the sales territory belong.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Group"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Group
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Group, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Group, value, true); }
		}
		/// <summary> The SalesYtd property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Sales in the territory year to date.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesYtd, value, true); }
		}
		/// <summary> The SalesLastYear property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Sales in the territory the previous year.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesLastYear, value, true); }
		}
		/// <summary> The CostYtd property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Business costs in the territory year to date.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostYtd, value, true); }
		}
		/// <summary> The CostLastYear property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Business costs in the territory the previous year.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostLastYear, value, true); }
		}
		/// <summary> The Rowguid property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTerritoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesTerritory<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection Customers
		{
			get	{ return GetMultiCustomers(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Customers. When set to true, Customers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customers is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomers
		{
			get	{ return _alwaysFetchCustomers; }
			set	{ _alwaysFetchCustomers = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customers already has been fetched. Setting this property to false when Customers has been fetched
		/// will clear the Customers collection well. Setting this property to true while Customers hasn't been fetched disables lazy loading for Customers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomers
		{
			get { return _alreadyFetchedCustomers;}
			set 
			{
				if(_alreadyFetchedCustomers && !value && (_customers != null))
				{
					_customers.Clear();
				}
				_alreadyFetchedCustomers = value;
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
		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection SalesPerson
		{
			get	{ return GetMultiSalesPerson(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPerson(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson
		{
			get	{ return _alwaysFetchSalesPerson; }
			set	{ _alwaysFetchSalesPerson = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPerson already has been fetched. Setting this property to false when SalesPerson has been fetched
		/// will clear the SalesPerson collection well. Setting this property to true while SalesPerson hasn't been fetched disables lazy loading for SalesPerson</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPerson
		{
			get { return _alreadyFetchedSalesPerson;}
			set 
			{
				if(_alreadyFetchedSalesPerson && !value && (_salesPerson != null))
				{
					_salesPerson.Clear();
				}
				_alreadyFetchedSalesPerson = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesTerritoryHistoryCollection SalesTerritoryHistory
		{
			get	{ return GetMultiSalesTerritoryHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritoryHistory. When set to true, SalesTerritoryHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritoryHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryHistory
		{
			get	{ return _alwaysFetchSalesTerritoryHistory; }
			set	{ _alwaysFetchSalesTerritoryHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritoryHistory already has been fetched. Setting this property to false when SalesTerritoryHistory has been fetched
		/// will clear the SalesTerritoryHistory collection well. Setting this property to true while SalesTerritoryHistory hasn't been fetched disables lazy loading for SalesTerritoryHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritoryHistory
		{
			get { return _alreadyFetchedSalesTerritoryHistory;}
			set 
			{
				if(_alreadyFetchedSalesTerritoryHistory && !value && (_salesTerritoryHistory != null))
				{
					_salesTerritoryHistory.Clear();
				}
				_alreadyFetchedSalesTerritoryHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStateProvinces()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.StateProvinceCollection StateProvinces
		{
			get	{ return GetMultiStateProvinces(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvinces. When set to true, StateProvinces is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvinces is accessed. You can always execute
		/// a forced fetch by calling GetMultiStateProvinces(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvinces
		{
			get	{ return _alwaysFetchStateProvinces; }
			set	{ _alwaysFetchStateProvinces = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property StateProvinces already has been fetched. Setting this property to false when StateProvinces has been fetched
		/// will clear the StateProvinces collection well. Setting this property to true while StateProvinces hasn't been fetched disables lazy loading for StateProvinces</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStateProvinces
		{
			get { return _alreadyFetchedStateProvinces;}
			set 
			{
				if(_alreadyFetchedStateProvinces && !value && (_stateProvinces != null))
				{
					_stateProvinces.Clear();
				}
				_alreadyFetchedStateProvinces = value;
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
		/// <summary> Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegionCollectionViaStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CountryRegionCollection CountryRegionCollectionViaStateProvince
		{
			get { return GetMultiCountryRegionCollectionViaStateProvince(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CountryRegionCollectionViaStateProvince. When set to true, CountryRegionCollectionViaStateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegionCollectionViaStateProvince is accessed. You can always execute
		/// a forced fetch by calling GetMultiCountryRegionCollectionViaStateProvince(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegionCollectionViaStateProvince
		{
			get	{ return _alwaysFetchCountryRegionCollectionViaStateProvince; }
			set	{ _alwaysFetchCountryRegionCollectionViaStateProvince = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CountryRegionCollectionViaStateProvince already has been fetched. Setting this property to false when CountryRegionCollectionViaStateProvince has been fetched
		/// will clear the CountryRegionCollectionViaStateProvince collection well. Setting this property to true while CountryRegionCollectionViaStateProvince hasn't been fetched disables lazy loading for CountryRegionCollectionViaStateProvince</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCountryRegionCollectionViaStateProvince
		{
			get { return _alreadyFetchedCountryRegionCollectionViaStateProvince;}
			set 
			{
				if(_alreadyFetchedCountryRegionCollectionViaStateProvince && !value && (_countryRegionCollectionViaStateProvince != null))
				{
					_countryRegionCollectionViaStateProvince.Clear();
				}
				_alreadyFetchedCountryRegionCollectionViaStateProvince = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader______
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader______. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader______ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader______ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader______ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader______ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader______ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader______ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader______.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader______ = value;
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
		/// <summary> Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPersonCollectionViaSalesTerritoryHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesPersonCollection SalesPersonCollectionViaSalesTerritoryHistory
		{
			get { return GetMultiSalesPersonCollectionViaSalesTerritoryHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPersonCollectionViaSalesTerritoryHistory. When set to true, SalesPersonCollectionViaSalesTerritoryHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPersonCollectionViaSalesTerritoryHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPersonCollectionViaSalesTerritoryHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPersonCollectionViaSalesTerritoryHistory
		{
			get	{ return _alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory; }
			set	{ _alwaysFetchSalesPersonCollectionViaSalesTerritoryHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesPersonCollectionViaSalesTerritoryHistory already has been fetched. Setting this property to false when SalesPersonCollectionViaSalesTerritoryHistory has been fetched
		/// will clear the SalesPersonCollectionViaSalesTerritoryHistory collection well. Setting this property to true while SalesPersonCollectionViaSalesTerritoryHistory hasn't been fetched disables lazy loading for SalesPersonCollectionViaSalesTerritoryHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory
		{
			get { return _alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory;}
			set 
			{
				if(_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory && !value && (_salesPersonCollectionViaSalesTerritoryHistory != null))
				{
					_salesPersonCollectionViaSalesTerritoryHistory.Clear();
				}
				_alreadyFetchedSalesPersonCollectionViaSalesTerritoryHistory = value;
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
			get { return (int)AW.Data.EntityType.SalesTerritoryEntity; }
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
