///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
using System.ComponentModel.DataAnnotations;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	using AW.Data.EntityValidators;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesOrderHeader'. <br/><br/>
	/// 
	/// MS_Description: General sales order information.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesOrderHeaderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderDetailCollection	_salesOrderDetails;
		private bool	_alwaysFetchSalesOrderDetails, _alreadyFetchedSalesOrderDetails;
		private AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection	_salesOrderHeaderSalesReasons;
		private bool	_alwaysFetchSalesOrderHeaderSalesReasons, _alreadyFetchedSalesOrderHeaderSalesReasons;
		private AW.Data.CollectionClasses.SalesReasonCollection _salesReasons;
		private bool	_alwaysFetchSalesReasons, _alreadyFetchedSalesReasons;
		private AW.Data.CollectionClasses.SpecialOfferProductCollection _specialOffers;
		private bool	_alwaysFetchSpecialOffers, _alreadyFetchedSpecialOffers;
		private AddressEntity _billingAddress;
		private bool	_alwaysFetchBillingAddress, _alreadyFetchedBillingAddress, _billingAddressReturnsNewIfNotFound;
		private AddressEntity _shippingAddress;
		private bool	_alwaysFetchShippingAddress, _alreadyFetchedShippingAddress, _shippingAddressReturnsNewIfNotFound;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod, _shipMethodReturnsNewIfNotFound;
		private CreditCardEntity _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard, _creditCardReturnsNewIfNotFound;
		private CurrencyRateEntity _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate, _currencyRateReturnsNewIfNotFound;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		private CustomerViewRelatedEntity _customerViewRelated;
		private bool	_alwaysFetchCustomerViewRelated, _alreadyFetchedCustomerViewRelated, _customerViewRelatedReturnsNewIfNotFound;
		private IndividualEntity _individual;
		private bool	_alwaysFetchIndividual, _alreadyFetchedIndividual, _individualReturnsNewIfNotFound;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson, _salesPersonReturnsNewIfNotFound;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory, _salesTerritoryReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BillingAddress</summary>
			public static readonly string BillingAddress = "BillingAddress";
			/// <summary>Member name ShippingAddress</summary>
			public static readonly string ShippingAddress = "ShippingAddress";
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name ShipMethod</summary>
			public static readonly string ShipMethod = "ShipMethod";
			/// <summary>Member name CreditCard</summary>
			public static readonly string CreditCard = "CreditCard";
			/// <summary>Member name CurrencyRate</summary>
			public static readonly string CurrencyRate = "CurrencyRate";
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name CustomerViewRelated</summary>
			public static readonly string CustomerViewRelated = "CustomerViewRelated";
			/// <summary>Member name Individual</summary>
			public static readonly string Individual = "Individual";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name SalesOrderDetails</summary>
			public static readonly string SalesOrderDetails = "SalesOrderDetails";
			/// <summary>Member name SalesOrderHeaderSalesReasons</summary>
			public static readonly string SalesOrderHeaderSalesReasons = "SalesOrderHeaderSalesReasons";
			/// <summary>Member name SalesReasons</summary>
			public static readonly string SalesReasons = "SalesReasons";
			/// <summary>Member name SpecialOffers</summary>
			public static readonly string SpecialOffers = "SpecialOffers";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderHeaderEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderHeaderEntity() :base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID):base("SalesOrderHeaderEntity")
		{
			InitClassFetch(salesOrderID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse):base("SalesOrderHeaderEntity")
		{
			InitClassFetch(salesOrderID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IValidator validator):base("SalesOrderHeaderEntity")
		{
			InitClassFetch(salesOrderID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderDetails = (AW.Data.CollectionClasses.SalesOrderDetailCollection)info.GetValue("_salesOrderDetails", typeof(AW.Data.CollectionClasses.SalesOrderDetailCollection));
			_alwaysFetchSalesOrderDetails = info.GetBoolean("_alwaysFetchSalesOrderDetails");
			_alreadyFetchedSalesOrderDetails = info.GetBoolean("_alreadyFetchedSalesOrderDetails");

			_salesOrderHeaderSalesReasons = (AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection)info.GetValue("_salesOrderHeaderSalesReasons", typeof(AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection));
			_alwaysFetchSalesOrderHeaderSalesReasons = info.GetBoolean("_alwaysFetchSalesOrderHeaderSalesReasons");
			_alreadyFetchedSalesOrderHeaderSalesReasons = info.GetBoolean("_alreadyFetchedSalesOrderHeaderSalesReasons");
			_salesReasons = (AW.Data.CollectionClasses.SalesReasonCollection)info.GetValue("_salesReasons", typeof(AW.Data.CollectionClasses.SalesReasonCollection));
			_alwaysFetchSalesReasons = info.GetBoolean("_alwaysFetchSalesReasons");
			_alreadyFetchedSalesReasons = info.GetBoolean("_alreadyFetchedSalesReasons");

			_specialOffers = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOffers", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOffers = info.GetBoolean("_alwaysFetchSpecialOffers");
			_alreadyFetchedSpecialOffers = info.GetBoolean("_alreadyFetchedSpecialOffers");
			_billingAddress = (AddressEntity)info.GetValue("_billingAddress", typeof(AddressEntity));
			if(_billingAddress!=null)
			{
				_billingAddress.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_billingAddressReturnsNewIfNotFound = info.GetBoolean("_billingAddressReturnsNewIfNotFound");
			_alwaysFetchBillingAddress = info.GetBoolean("_alwaysFetchBillingAddress");
			_alreadyFetchedBillingAddress = info.GetBoolean("_alreadyFetchedBillingAddress");

			_shippingAddress = (AddressEntity)info.GetValue("_shippingAddress", typeof(AddressEntity));
			if(_shippingAddress!=null)
			{
				_shippingAddress.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shippingAddressReturnsNewIfNotFound = info.GetBoolean("_shippingAddressReturnsNewIfNotFound");
			_alwaysFetchShippingAddress = info.GetBoolean("_alwaysFetchShippingAddress");
			_alreadyFetchedShippingAddress = info.GetBoolean("_alreadyFetchedShippingAddress");

			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");

			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shipMethodReturnsNewIfNotFound = info.GetBoolean("_shipMethodReturnsNewIfNotFound");
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_creditCard = (CreditCardEntity)info.GetValue("_creditCard", typeof(CreditCardEntity));
			if(_creditCard!=null)
			{
				_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_creditCardReturnsNewIfNotFound = info.GetBoolean("_creditCardReturnsNewIfNotFound");
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_currencyRate = (CurrencyRateEntity)info.GetValue("_currencyRate", typeof(CurrencyRateEntity));
			if(_currencyRate!=null)
			{
				_currencyRate.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_currencyRateReturnsNewIfNotFound = info.GetBoolean("_currencyRateReturnsNewIfNotFound");
			_alwaysFetchCurrencyRate = info.GetBoolean("_alwaysFetchCurrencyRate");
			_alreadyFetchedCurrencyRate = info.GetBoolean("_alreadyFetchedCurrencyRate");

			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerReturnsNewIfNotFound = info.GetBoolean("_customerReturnsNewIfNotFound");
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_customerViewRelated = (CustomerViewRelatedEntity)info.GetValue("_customerViewRelated", typeof(CustomerViewRelatedEntity));
			if(_customerViewRelated!=null)
			{
				_customerViewRelated.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerViewRelatedReturnsNewIfNotFound = info.GetBoolean("_customerViewRelatedReturnsNewIfNotFound");
			_alwaysFetchCustomerViewRelated = info.GetBoolean("_alwaysFetchCustomerViewRelated");
			_alreadyFetchedCustomerViewRelated = info.GetBoolean("_alreadyFetchedCustomerViewRelated");

			_individual = (IndividualEntity)info.GetValue("_individual", typeof(IndividualEntity));
			if(_individual!=null)
			{
				_individual.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_individualReturnsNewIfNotFound = info.GetBoolean("_individualReturnsNewIfNotFound");
			_alwaysFetchIndividual = info.GetBoolean("_alwaysFetchIndividual");
			_alreadyFetchedIndividual = info.GetBoolean("_alreadyFetchedIndividual");

			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesPersonReturnsNewIfNotFound = info.GetBoolean("_salesPersonReturnsNewIfNotFound");
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");

			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesTerritoryReturnsNewIfNotFound = info.GetBoolean("_salesTerritoryReturnsNewIfNotFound");
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesOrderHeaderFieldIndex)fieldIndex)
			{
				case SalesOrderHeaderFieldIndex.BillToAddressID:
					DesetupSyncBillingAddress(true, false);
					_alreadyFetchedBillingAddress = false;
					break;
				case SalesOrderHeaderFieldIndex.ContactID:
					DesetupSyncContact(true, false);
					_alreadyFetchedContact = false;
					break;
				case SalesOrderHeaderFieldIndex.CreditCardID:
					DesetupSyncCreditCard(true, false);
					_alreadyFetchedCreditCard = false;
					break;
				case SalesOrderHeaderFieldIndex.CurrencyRateID:
					DesetupSyncCurrencyRate(true, false);
					_alreadyFetchedCurrencyRate = false;
					break;
				case SalesOrderHeaderFieldIndex.CustomerID:
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					DesetupSyncCustomerViewRelated(true, false);
					_alreadyFetchedCustomerViewRelated = false;
					DesetupSyncIndividual(true, false);
					_alreadyFetchedIndividual = false;
					break;
				case SalesOrderHeaderFieldIndex.SalesPersonID:
					DesetupSyncSalesPerson(true, false);
					_alreadyFetchedSalesPerson = false;
					break;
				case SalesOrderHeaderFieldIndex.ShipMethodID:
					DesetupSyncShipMethod(true, false);
					_alreadyFetchedShipMethod = false;
					break;
				case SalesOrderHeaderFieldIndex.ShipToAddressID:
					DesetupSyncShippingAddress(true, false);
					_alreadyFetchedShippingAddress = false;
					break;
				case SalesOrderHeaderFieldIndex.TerritoryID:
					DesetupSyncSalesTerritory(true, false);
					_alreadyFetchedSalesTerritory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderDetails = (_salesOrderDetails.Count > 0);
			_alreadyFetchedSalesOrderHeaderSalesReasons = (_salesOrderHeaderSalesReasons.Count > 0);
			_alreadyFetchedSalesReasons = (_salesReasons.Count > 0);
			_alreadyFetchedSpecialOffers = (_specialOffers.Count > 0);
			_alreadyFetchedBillingAddress = (_billingAddress != null);
			_alreadyFetchedShippingAddress = (_shippingAddress != null);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);
			_alreadyFetchedCreditCard = (_creditCard != null);
			_alreadyFetchedCurrencyRate = (_currencyRate != null);
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedCustomerViewRelated = (_customerViewRelated != null);
			_alreadyFetchedIndividual = (_individual != null);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
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
				case "BillingAddress":
					toReturn.Add(Relations.AddressEntityUsingBillToAddressID);
					break;
				case "ShippingAddress":
					toReturn.Add(Relations.AddressEntityUsingShipToAddressID);
					break;
				case "Contact":
					toReturn.Add(Relations.ContactEntityUsingContactID);
					break;
				case "ShipMethod":
					toReturn.Add(Relations.ShipMethodEntityUsingShipMethodID);
					break;
				case "CreditCard":
					toReturn.Add(Relations.CreditCardEntityUsingCreditCardID);
					break;
				case "CurrencyRate":
					toReturn.Add(Relations.CurrencyRateEntityUsingCurrencyRateID);
					break;
				case "Customer":
					toReturn.Add(Relations.CustomerEntityUsingCustomerID);
					break;
				case "CustomerViewRelated":
					toReturn.Add(Relations.CustomerViewRelatedEntityUsingCustomerID);
					break;
				case "Individual":
					toReturn.Add(Relations.IndividualEntityUsingCustomerID);
					break;
				case "SalesPerson":
					toReturn.Add(Relations.SalesPersonEntityUsingSalesPersonID);
					break;
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryID);
					break;
				case "SalesOrderDetails":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingSalesOrderID);
					break;
				case "SalesOrderHeaderSalesReasons":
					toReturn.Add(Relations.SalesOrderHeaderSalesReasonEntityUsingSalesOrderID);
					break;
				case "SalesReasons":
					toReturn.Add(Relations.SalesOrderHeaderSalesReasonEntityUsingSalesOrderID, "SalesOrderHeaderEntity__", "SalesOrderHeaderSalesReason_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID, "SalesOrderHeaderSalesReason_", string.Empty, JoinHint.None);
					break;
				case "SpecialOffers":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingSalesOrderID, "SalesOrderHeaderEntity__", "SalesOrderDetail_", JoinHint.None);
					toReturn.Add(SalesOrderDetailEntity.Relations.SpecialOfferProductEntityUsingProductIDSpecialOfferID, "SalesOrderDetail_", string.Empty, JoinHint.None);
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
			info.AddValue("_salesOrderDetails", (!this.MarkedForDeletion?_salesOrderDetails:null));
			info.AddValue("_alwaysFetchSalesOrderDetails", _alwaysFetchSalesOrderDetails);
			info.AddValue("_alreadyFetchedSalesOrderDetails", _alreadyFetchedSalesOrderDetails);
			info.AddValue("_salesOrderHeaderSalesReasons", (!this.MarkedForDeletion?_salesOrderHeaderSalesReasons:null));
			info.AddValue("_alwaysFetchSalesOrderHeaderSalesReasons", _alwaysFetchSalesOrderHeaderSalesReasons);
			info.AddValue("_alreadyFetchedSalesOrderHeaderSalesReasons", _alreadyFetchedSalesOrderHeaderSalesReasons);
			info.AddValue("_salesReasons", (!this.MarkedForDeletion?_salesReasons:null));
			info.AddValue("_alwaysFetchSalesReasons", _alwaysFetchSalesReasons);
			info.AddValue("_alreadyFetchedSalesReasons", _alreadyFetchedSalesReasons);
			info.AddValue("_specialOffers", (!this.MarkedForDeletion?_specialOffers:null));
			info.AddValue("_alwaysFetchSpecialOffers", _alwaysFetchSpecialOffers);
			info.AddValue("_alreadyFetchedSpecialOffers", _alreadyFetchedSpecialOffers);
			info.AddValue("_billingAddress", (!this.MarkedForDeletion?_billingAddress:null));
			info.AddValue("_billingAddressReturnsNewIfNotFound", _billingAddressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBillingAddress", _alwaysFetchBillingAddress);
			info.AddValue("_alreadyFetchedBillingAddress", _alreadyFetchedBillingAddress);
			info.AddValue("_shippingAddress", (!this.MarkedForDeletion?_shippingAddress:null));
			info.AddValue("_shippingAddressReturnsNewIfNotFound", _shippingAddressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShippingAddress", _alwaysFetchShippingAddress);
			info.AddValue("_alreadyFetchedShippingAddress", _alreadyFetchedShippingAddress);
			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_shipMethod", (!this.MarkedForDeletion?_shipMethod:null));
			info.AddValue("_shipMethodReturnsNewIfNotFound", _shipMethodReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_creditCard", (!this.MarkedForDeletion?_creditCard:null));
			info.AddValue("_creditCardReturnsNewIfNotFound", _creditCardReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
			info.AddValue("_currencyRate", (!this.MarkedForDeletion?_currencyRate:null));
			info.AddValue("_currencyRateReturnsNewIfNotFound", _currencyRateReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCurrencyRate", _alwaysFetchCurrencyRate);
			info.AddValue("_alreadyFetchedCurrencyRate", _alreadyFetchedCurrencyRate);
			info.AddValue("_customer", (!this.MarkedForDeletion?_customer:null));
			info.AddValue("_customerReturnsNewIfNotFound", _customerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_customerViewRelated", (!this.MarkedForDeletion?_customerViewRelated:null));
			info.AddValue("_customerViewRelatedReturnsNewIfNotFound", _customerViewRelatedReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomerViewRelated", _alwaysFetchCustomerViewRelated);
			info.AddValue("_alreadyFetchedCustomerViewRelated", _alreadyFetchedCustomerViewRelated);
			info.AddValue("_individual", (!this.MarkedForDeletion?_individual:null));
			info.AddValue("_individualReturnsNewIfNotFound", _individualReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchIndividual", _alwaysFetchIndividual);
			info.AddValue("_alreadyFetchedIndividual", _alreadyFetchedIndividual);
			info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			info.AddValue("_salesPersonReturnsNewIfNotFound", _salesPersonReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
			info.AddValue("_salesTerritoryReturnsNewIfNotFound", _salesTerritoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "BillingAddress":
					_alreadyFetchedBillingAddress = true;
					this.BillingAddress = (AddressEntity)entity;
					break;
				case "ShippingAddress":
					_alreadyFetchedShippingAddress = true;
					this.ShippingAddress = (AddressEntity)entity;
					break;
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
					break;
				case "ShipMethod":
					_alreadyFetchedShipMethod = true;
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "CreditCard":
					_alreadyFetchedCreditCard = true;
					this.CreditCard = (CreditCardEntity)entity;
					break;
				case "CurrencyRate":
					_alreadyFetchedCurrencyRate = true;
					this.CurrencyRate = (CurrencyRateEntity)entity;
					break;
				case "Customer":
					_alreadyFetchedCustomer = true;
					this.Customer = (CustomerEntity)entity;
					break;
				case "CustomerViewRelated":
					_alreadyFetchedCustomerViewRelated = true;
					this.CustomerViewRelated = (CustomerViewRelatedEntity)entity;
					break;
				case "Individual":
					_alreadyFetchedIndividual = true;
					this.Individual = (IndividualEntity)entity;
					break;
				case "SalesPerson":
					_alreadyFetchedSalesPerson = true;
					this.SalesPerson = (SalesPersonEntity)entity;
					break;
				case "SalesTerritory":
					_alreadyFetchedSalesTerritory = true;
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "SalesOrderDetails":
					_alreadyFetchedSalesOrderDetails = true;
					if(entity!=null)
					{
						this.SalesOrderDetails.Add((SalesOrderDetailEntity)entity);
					}
					break;
				case "SalesOrderHeaderSalesReasons":
					_alreadyFetchedSalesOrderHeaderSalesReasons = true;
					if(entity!=null)
					{
						this.SalesOrderHeaderSalesReasons.Add((SalesOrderHeaderSalesReasonEntity)entity);
					}
					break;
				case "SalesReasons":
					_alreadyFetchedSalesReasons = true;
					if(entity!=null)
					{
						this.SalesReasons.Add((SalesReasonEntity)entity);
					}
					break;
				case "SpecialOffers":
					_alreadyFetchedSpecialOffers = true;
					if(entity!=null)
					{
						this.SpecialOffers.Add((SpecialOfferProductEntity)entity);
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
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "BillingAddress":
					SetupSyncBillingAddress(relatedEntity);
					break;
				case "ShippingAddress":
					SetupSyncShippingAddress(relatedEntity);
					break;
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "CreditCard":
					SetupSyncCreditCard(relatedEntity);
					break;
				case "CurrencyRate":
					SetupSyncCurrencyRate(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;
				case "CustomerViewRelated":
					SetupSyncCustomerViewRelated(relatedEntity);
					break;
				case "Individual":
					SetupSyncIndividual(relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "SalesOrderDetails":
					_salesOrderDetails.Add((SalesOrderDetailEntity)relatedEntity);
					break;
				case "SalesOrderHeaderSalesReasons":
					_salesOrderHeaderSalesReasons.Add((SalesOrderHeaderSalesReasonEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "BillingAddress":
					DesetupSyncBillingAddress(false, true);
					break;
				case "ShippingAddress":
					DesetupSyncShippingAddress(false, true);
					break;
				case "Contact":
					DesetupSyncContact(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "CreditCard":
					DesetupSyncCreditCard(false, true);
					break;
				case "CurrencyRate":
					DesetupSyncCurrencyRate(false, true);
					break;
				case "Customer":
					DesetupSyncCustomer(false, true);
					break;
				case "CustomerViewRelated":
					DesetupSyncCustomerViewRelated(false, true);
					break;
				case "Individual":
					DesetupSyncIndividual(false, true);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "SalesOrderDetails":
					this.PerformRelatedEntityRemoval(_salesOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaderSalesReasons":
					this.PerformRelatedEntityRemoval(_salesOrderHeaderSalesReasons, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_billingAddress!=null)
			{
				toReturn.Add(_billingAddress);
			}
			if(_shippingAddress!=null)
			{
				toReturn.Add(_shippingAddress);
			}
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			if(_creditCard!=null)
			{
				toReturn.Add(_creditCard);
			}
			if(_currencyRate!=null)
			{
				toReturn.Add(_currencyRate);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}
			if(_customerViewRelated!=null)
			{
				toReturn.Add(_customerViewRelated);
			}
			if(_individual!=null)
			{
				toReturn.Add(_individual);
			}
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_salesOrderDetails);
			toReturn.Add(_salesOrderHeaderSalesReasons);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID)
		{
			return FetchUsingPK(salesOrderID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesOrderID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(salesOrderID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesOrderID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderHeaderRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch)
		{
			return GetMultiSalesOrderDetails(forceFetch, _salesOrderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderDetails(forceFetch, _salesOrderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetails || forceFetch || _alwaysFetchSalesOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderDetails);
				_salesOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderDetails.GetMultiManyToOne(this, null, filter);
				_salesOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetails = true;
			}
			return _salesOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderDetails'. These settings will be taken into account
		/// when the property SalesOrderDetails is requested or GetMultiSalesOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderDetails.SortClauses=sortClauses;
			_salesOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReasons(bool forceFetch)
		{
			return GetMultiSalesOrderHeaderSalesReasons(forceFetch, _salesOrderHeaderSalesReasons.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReasons(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaderSalesReasons(forceFetch, _salesOrderHeaderSalesReasons.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReasons(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaderSalesReasons(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReasons(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReasons || forceFetch || _alwaysFetchSalesOrderHeaderSalesReasons) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaderSalesReasons);
				_salesOrderHeaderSalesReasons.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderSalesReasons.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaderSalesReasons.GetMultiManyToOne(this, null, filter);
				_salesOrderHeaderSalesReasons.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReasons = true;
			}
			return _salesOrderHeaderSalesReasons;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaderSalesReasons'. These settings will be taken into account
		/// when the property SalesOrderHeaderSalesReasons is requested or GetMultiSalesOrderHeaderSalesReasons is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaderSalesReasons(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaderSalesReasons.SortClauses=sortClauses;
			_salesOrderHeaderSalesReasons.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesReasonEntity'</returns>
		public AW.Data.CollectionClasses.SalesReasonCollection GetMultiSalesReasons(bool forceFetch)
		{
			return GetMultiSalesReasons(forceFetch, _salesReasons.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesReasonCollection GetMultiSalesReasons(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesReasons || forceFetch || _alwaysFetchSalesReasons) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesReasons);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesOrderID, ComparisonOperator.Equal, this.SalesOrderID, "SalesOrderHeaderEntity__"));
				_salesReasons.SuppressClearInGetMulti=!forceFetch;
				_salesReasons.EntityFactoryToUse = entityFactoryToUse;
				_salesReasons.GetMulti(filter, GetRelationsForField("SalesReasons"));
				_salesReasons.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesReasons = true;
			}
			return _salesReasons;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesReasons'. These settings will be taken into account
		/// when the property SalesReasons is requested or GetMultiSalesReasons is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesReasons(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesReasons.SortClauses=sortClauses;
			_salesReasons.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOffers(bool forceFetch)
		{
			return GetMultiSpecialOffers(forceFetch, _specialOffers.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOffers(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOffers || forceFetch || _alwaysFetchSpecialOffers) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_specialOffers);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesOrderID, ComparisonOperator.Equal, this.SalesOrderID, "SalesOrderHeaderEntity__"));
				_specialOffers.SuppressClearInGetMulti=!forceFetch;
				_specialOffers.EntityFactoryToUse = entityFactoryToUse;
				_specialOffers.GetMulti(filter, GetRelationsForField("SpecialOffers"));
				_specialOffers.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOffers = true;
			}
			return _specialOffers;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOffers'. These settings will be taken into account
		/// when the property SpecialOffers is requested or GetMultiSpecialOffers is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOffers(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOffers.SortClauses=sortClauses;
			_specialOffers.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleBillingAddress()
		{
			return GetSingleBillingAddress(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleBillingAddress(bool forceFetch)
		{
			if( ( !_alreadyFetchedBillingAddress || forceFetch || _alwaysFetchBillingAddress) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AddressEntityUsingBillToAddressID);
				AddressEntity newEntity = new AddressEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.BillToAddressID);
				}
				if(fetchResult)
				{
					newEntity = (AddressEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_billingAddressReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.BillingAddress = newEntity;
				_alreadyFetchedBillingAddress = fetchResult;
			}
			return _billingAddress;
		}


		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleShippingAddress()
		{
			return GetSingleShippingAddress(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleShippingAddress(bool forceFetch)
		{
			if( ( !_alreadyFetchedShippingAddress || forceFetch || _alwaysFetchShippingAddress) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AddressEntityUsingShipToAddressID);
				AddressEntity newEntity = new AddressEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ShipToAddressID);
				}
				if(fetchResult)
				{
					newEntity = (AddressEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_shippingAddressReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ShippingAddress = newEntity;
				_alreadyFetchedShippingAddress = fetchResult;
			}
			return _shippingAddress;
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


		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public ShipMethodEntity GetSingleShipMethod()
		{
			return GetSingleShipMethod(false);
		}

		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public virtual ShipMethodEntity GetSingleShipMethod(bool forceFetch)
		{
			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ShipMethodEntityUsingShipMethodID);
				ShipMethodEntity newEntity = new ShipMethodEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ShipMethodID);
				}
				if(fetchResult)
				{
					newEntity = (ShipMethodEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_shipMethodReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ShipMethod = newEntity;
				_alreadyFetchedShipMethod = fetchResult;
			}
			return _shipMethod;
		}


		/// <summary> Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public CreditCardEntity GetSingleCreditCard()
		{
			return GetSingleCreditCard(false);
		}

		/// <summary> Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public virtual CreditCardEntity GetSingleCreditCard(bool forceFetch)
		{
			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CreditCardEntityUsingCreditCardID);
				CreditCardEntity newEntity = new CreditCardEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CreditCardID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CreditCardEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_creditCardReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CreditCard = newEntity;
				_alreadyFetchedCreditCard = fetchResult;
			}
			return _creditCard;
		}


		/// <summary> Retrieves the related entity of type 'CurrencyRateEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CurrencyRateEntity' which is related to this entity.</returns>
		public CurrencyRateEntity GetSingleCurrencyRate()
		{
			return GetSingleCurrencyRate(false);
		}

		/// <summary> Retrieves the related entity of type 'CurrencyRateEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyRateEntity' which is related to this entity.</returns>
		public virtual CurrencyRateEntity GetSingleCurrencyRate(bool forceFetch)
		{
			if( ( !_alreadyFetchedCurrencyRate || forceFetch || _alwaysFetchCurrencyRate) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CurrencyRateEntityUsingCurrencyRateID);
				CurrencyRateEntity newEntity = new CurrencyRateEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CurrencyRateID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CurrencyRateEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_currencyRateReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CurrencyRate = newEntity;
				_alreadyFetchedCurrencyRate = fetchResult;
			}
			return _currencyRate;
		}


		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CustomerEntityUsingCustomerID);
				CustomerEntity newEntity = (CustomerEntity)GeneralEntityFactory.Create(AW.Data.EntityType.CustomerEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = CustomerEntity.FetchPolymorphic(this.Transaction, this.CustomerID.GetValueOrDefault(), this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (CustomerEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_customerReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Customer = newEntity;
				_alreadyFetchedCustomer = fetchResult;
			}
			return _customer;
		}


		/// <summary> Retrieves the related entity of type 'CustomerViewRelatedEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerViewRelatedEntity' which is related to this entity.</returns>
		public CustomerViewRelatedEntity GetSingleCustomerViewRelated()
		{
			return GetSingleCustomerViewRelated(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerViewRelatedEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerViewRelatedEntity' which is related to this entity.</returns>
		public virtual CustomerViewRelatedEntity GetSingleCustomerViewRelated(bool forceFetch)
		{
			if( ( !_alreadyFetchedCustomerViewRelated || forceFetch || _alwaysFetchCustomerViewRelated) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CustomerViewRelatedEntityUsingCustomerID);
				CustomerViewRelatedEntity newEntity = new CustomerViewRelatedEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CustomerID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CustomerViewRelatedEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_customerViewRelatedReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CustomerViewRelated = newEntity;
				_alreadyFetchedCustomerViewRelated = fetchResult;
			}
			return _customerViewRelated;
		}


		/// <summary> Retrieves the related entity of type 'IndividualEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public IndividualEntity GetSingleIndividual()
		{
			return GetSingleIndividual(false);
		}

		/// <summary> Retrieves the related entity of type 'IndividualEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public virtual IndividualEntity GetSingleIndividual(bool forceFetch)
		{
			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.IndividualEntityUsingCustomerID);
				IndividualEntity newEntity = (IndividualEntity)GeneralEntityFactory.Create(AW.Data.EntityType.IndividualEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = IndividualEntity.FetchPolymorphic(this.Transaction, this.CustomerID.GetValueOrDefault(), this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (IndividualEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_individualReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Individual = newEntity;
				_alreadyFetchedIndividual = fetchResult;
			}
			return _individual;
		}


		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesPersonEntityUsingSalesPersonID);
				SalesPersonEntity newEntity = (SalesPersonEntity)GeneralEntityFactory.Create(AW.Data.EntityType.SalesPersonEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = SalesPersonEntity.FetchPolymorphic(this.Transaction, this.SalesPersonID.GetValueOrDefault(), this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (SalesPersonEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesPersonReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesPerson = newEntity;
				_alreadyFetchedSalesPerson = fetchResult;
			}
			return _salesPerson;
		}


		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public SalesTerritoryEntity GetSingleSalesTerritory()
		{
			return GetSingleSalesTerritory(false);
		}

		/// <summary> Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public virtual SalesTerritoryEntity GetSingleSalesTerritory(bool forceFetch)
		{
			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.SalesTerritoryEntityUsingTerritoryID);
				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.TerritoryID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (SalesTerritoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_salesTerritoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SalesTerritory = newEntity;
				_alreadyFetchedSalesTerritory = fetchResult;
			}
			return _salesTerritory;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BillingAddress", _billingAddress);
			toReturn.Add("ShippingAddress", _shippingAddress);
			toReturn.Add("Contact", _contact);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("CreditCard", _creditCard);
			toReturn.Add("CurrencyRate", _currencyRate);
			toReturn.Add("Customer", _customer);
			toReturn.Add("CustomerViewRelated", _customerViewRelated);
			toReturn.Add("Individual", _individual);
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("SalesOrderDetails", _salesOrderDetails);
			toReturn.Add("SalesOrderHeaderSalesReasons", _salesOrderHeaderSalesReasons);
			toReturn.Add("SalesReasons", _salesReasons);
			toReturn.Add("SpecialOffers", _specialOffers);
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
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 salesOrderID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(salesOrderID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_salesOrderDetails = new AW.Data.CollectionClasses.SalesOrderDetailCollection();
			_salesOrderDetails.SetContainingEntityInfo(this, "SalesOrderHeader");

			_salesOrderHeaderSalesReasons = new AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection();
			_salesOrderHeaderSalesReasons.SetContainingEntityInfo(this, "SalesOrderHeader");
			_salesReasons = new AW.Data.CollectionClasses.SalesReasonCollection();
			_specialOffers = new AW.Data.CollectionClasses.SpecialOfferProductCollection();
			_billingAddressReturnsNewIfNotFound = true;
			_shippingAddressReturnsNewIfNotFound = true;
			_contactReturnsNewIfNotFound = true;
			_shipMethodReturnsNewIfNotFound = true;
			_creditCardReturnsNewIfNotFound = true;
			_currencyRateReturnsNewIfNotFound = true;
			_customerReturnsNewIfNotFound = true;
			_customerViewRelatedReturnsNewIfNotFound = true;
			_individualReturnsNewIfNotFound = true;
			_salesPersonReturnsNewIfNotFound = true;
			_salesTerritoryReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"General sales order information.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Financial accounting number reference.");
			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Customer billing address. Foreign key to Address.AddressID.");
			_fieldsCustomProperties.Add("BillToAddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales representative comments.");
			_fieldsCustomProperties.Add("Comment", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Customer contact identification number. Foreign key to Contact.ContactID.");
			_fieldsCustomProperties.Add("ContactID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Approval code provided by the credit card company.");
			_fieldsCustomProperties.Add("CreditCardApprovalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card identification number. Foreign key to CreditCard.CreditCardID.");
			_fieldsCustomProperties.Add("CreditCardID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.");
			_fieldsCustomProperties.Add("CurrencyRateID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Customer identification number. Foreign key to Customer.CustomerID.");
			_fieldsCustomProperties.Add("CustomerID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the order is due to the customer.");
			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping cost.");
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Order placed by sales person. 1 = Order placed online by customer.");
			_fieldsCustomProperties.Add("OnlineOrderFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Customer purchase order number reference. ");
			_fieldsCustomProperties.Add("PurchaseOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Incremental number to track changes to the sales order over time.");
			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesOrderID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique sales order identification number.");
			_fieldsCustomProperties.Add("SalesOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales person who created the sales order. Foreign key to SalesPerson.SalePersonID.");
			_fieldsCustomProperties.Add("SalesPersonID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shipping method. Foreign key to ShipMethod.ShipMethodID.");
			_fieldsCustomProperties.Add("ShipMethodID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Customer shipping address. Foreign key to Address.AddressID.");
			_fieldsCustomProperties.Add("ShipToAddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled");
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.");
			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Tax amount.");
			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.");
			_fieldsCustomProperties.Add("TerritoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Total due from customer. Computed as Subtotal + TaxAmt + Freight.");
			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _billingAddress</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBillingAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _billingAddress, new PropertyChangedEventHandler( OnBillingAddressPropertyChanged ), "BillingAddress", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingBillToAddressIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.BillToAddressID } );		
			_billingAddress = null;
		}
		
		/// <summary> setups the sync logic for member _billingAddress</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBillingAddress(IEntityCore relatedEntity)
		{
			if(_billingAddress!=relatedEntity)
			{		
				DesetupSyncBillingAddress(true, true);
				_billingAddress = (AddressEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _billingAddress, new PropertyChangedEventHandler( OnBillingAddressPropertyChanged ), "BillingAddress", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingBillToAddressIDStatic, true, ref _alreadyFetchedBillingAddress, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBillingAddressPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _shippingAddress</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShippingAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shippingAddress, new PropertyChangedEventHandler( OnShippingAddressPropertyChanged ), "ShippingAddress", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingShipToAddressIDStatic, true, signalRelatedEntity, "SalesOrderHeadersShipped", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipToAddressID } );		
			_shippingAddress = null;
		}
		
		/// <summary> setups the sync logic for member _shippingAddress</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShippingAddress(IEntityCore relatedEntity)
		{
			if(_shippingAddress!=relatedEntity)
			{		
				DesetupSyncShippingAddress(true, true);
				_shippingAddress = (AddressEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shippingAddress, new PropertyChangedEventHandler( OnShippingAddressPropertyChanged ), "ShippingAddress", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingShipToAddressIDStatic, true, ref _alreadyFetchedShippingAddress, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShippingAddressPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.ContactEntityUsingContactIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ContactID } );		
			_contact = null;
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntityCore relatedEntity)
		{
			if(_contact!=relatedEntity)
			{		
				DesetupSyncContact(true, true);
				_contact = (ContactEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.ContactEntityUsingContactIDStatic, true, ref _alreadyFetchedContact, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.ShipMethodEntityUsingShipMethodIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipMethodID } );		
			_shipMethod = null;
		}
		
		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntityCore relatedEntity)
		{
			if(_shipMethod!=relatedEntity)
			{		
				DesetupSyncShipMethod(true, true);
				_shipMethod = (ShipMethodEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.ShipMethodEntityUsingShipMethodIDStatic, true, ref _alreadyFetchedShipMethod, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShipMethodPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _creditCard</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCreditCard(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CreditCardEntityUsingCreditCardIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CreditCardID } );		
			_creditCard = null;
		}
		
		/// <summary> setups the sync logic for member _creditCard</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCreditCard(IEntityCore relatedEntity)
		{
			if(_creditCard!=relatedEntity)
			{		
				DesetupSyncCreditCard(true, true);
				_creditCard = (CreditCardEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CreditCardEntityUsingCreditCardIDStatic, true, ref _alreadyFetchedCreditCard, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCreditCardPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _currencyRate</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrencyRate(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CurrencyRateEntityUsingCurrencyRateIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CurrencyRateID } );		
			_currencyRate = null;
		}
		
		/// <summary> setups the sync logic for member _currencyRate</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrencyRate(IEntityCore relatedEntity)
		{
			if(_currencyRate!=relatedEntity)
			{		
				DesetupSyncCurrencyRate(true, true);
				_currencyRate = (CurrencyRateEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CurrencyRateEntityUsingCurrencyRateIDStatic, true, ref _alreadyFetchedCurrencyRate, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrencyRatePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CustomerEntityUsingCustomerIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerID } );		
			_customer = null;
		}
		
		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntityCore relatedEntity)
		{
			if(_customer!=relatedEntity)
			{		
				DesetupSyncCustomer(true, true);
				_customer = (CustomerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CustomerEntityUsingCustomerIDStatic, true, ref _alreadyFetchedCustomer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _customerViewRelated</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomerViewRelated(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customerViewRelated, new PropertyChangedEventHandler( OnCustomerViewRelatedPropertyChanged ), "CustomerViewRelated", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CustomerViewRelatedEntityUsingCustomerIDStatic, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerID } );		
			_customerViewRelated = null;
		}
		
		/// <summary> setups the sync logic for member _customerViewRelated</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomerViewRelated(IEntityCore relatedEntity)
		{
			if(_customerViewRelated!=relatedEntity)
			{		
				DesetupSyncCustomerViewRelated(true, true);
				_customerViewRelated = (CustomerViewRelatedEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customerViewRelated, new PropertyChangedEventHandler( OnCustomerViewRelatedPropertyChanged ), "CustomerViewRelated", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.CustomerViewRelatedEntityUsingCustomerIDStatic, true, ref _alreadyFetchedCustomerViewRelated, new string[] { "CustomerCity", "CustomerCountry", "CustomerFirstName", "CustomerLastName", "CustomerState", "CustomerZip" } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerViewRelatedPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				case "City":
					this.OnPropertyChanged("CustomerCity");
					break;
				case "CountryRegionName":
					this.OnPropertyChanged("CustomerCountry");
					break;
				case "FirstName":
					this.OnPropertyChanged("CustomerFirstName");
					break;
				case "LastName":
					this.OnPropertyChanged("CustomerLastName");
					break;
				case "StateProvinceName":
					this.OnPropertyChanged("CustomerState");
					break;
				case "PostalCode":
					this.OnPropertyChanged("CustomerZip");
					break;
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _individual</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncIndividual(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _individual, new PropertyChangedEventHandler( OnIndividualPropertyChanged ), "Individual", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.IndividualEntityUsingCustomerIDStatic, true, signalRelatedEntity, "", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerID } );		
			_individual = null;
		}
		
		/// <summary> setups the sync logic for member _individual</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncIndividual(IEntityCore relatedEntity)
		{
			if(_individual!=relatedEntity)
			{		
				DesetupSyncIndividual(true, true);
				_individual = (IndividualEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _individual, new PropertyChangedEventHandler( OnIndividualPropertyChanged ), "Individual", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.IndividualEntityUsingCustomerIDStatic, true, ref _alreadyFetchedIndividual, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnIndividualPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.SalesPersonEntityUsingSalesPersonIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.SalesPersonID } );		
			_salesPerson = null;
		}
		
		/// <summary> setups the sync logic for member _salesPerson</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntityCore relatedEntity)
		{
			if(_salesPerson!=relatedEntity)
			{		
				DesetupSyncSalesPerson(true, true);
				_salesPerson = (SalesPersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.SalesPersonEntityUsingSalesPersonIDStatic, true, ref _alreadyFetchedSalesPerson, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.SalesTerritoryEntityUsingTerritoryIDStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.TerritoryID } );		
			_salesTerritory = null;
		}
		
		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntityCore relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{		
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AW.Data.RelationClasses.StaticSalesOrderHeaderRelations.SalesTerritoryEntityUsingTerritoryIDStatic, true, ref _alreadyFetchedSalesTerritory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SalesOrderHeaderFieldIndex.SalesOrderID].ForcedCurrentValueWrite(salesOrderID);
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
			return DAOFactory.CreateSalesOrderHeaderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesOrderHeaderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesOrderHeaderRelations Relations
		{
			get	{ return new SalesOrderHeaderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderDetails
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderDetailCollection(), (IEntityRelation)GetRelationsForField("SalesOrderDetails")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesOrderDetailEntity, 0, null, null, null, "SalesOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeaderSalesReason' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaderSalesReasons
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaderSalesReasons")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity, 0, null, null, null, "SalesOrderHeaderSalesReasons", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesReason'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesReasons
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderHeaderSalesReasonEntityUsingSalesOrderID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeaderSalesReason_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesReasonCollection(), intermediateRelation,	(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesReasonEntity, 0, null, null, GetRelationsForField("SalesReasons"), "SalesReasons", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOffers
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.SalesOrderDetailEntityUsingSalesOrderID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderDetail_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(), intermediateRelation,	(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, GetRelationsForField("SpecialOffers"), "SpecialOffers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillingAddress
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), (IEntityRelation)GetRelationsForField("BillingAddress")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "BillingAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShippingAddress
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), (IEntityRelation)GetRelationsForField("ShippingAddress")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "ShippingAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), (IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethod
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), (IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCard
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(), (IEntityRelation)GetRelationsForField("CreditCard")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, null, "CreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRate
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), (IEntityRelation)GetRelationsForField("CurrencyRate")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), (IEntityRelation)GetRelationsForField("Customer")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelated
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), (IEntityRelation)GetRelationsForField("CustomerViewRelated")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, null, "CustomerViewRelated", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Individual'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIndividual
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.IndividualCollection(), (IEntityRelation)GetRelationsForField("Individual")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.IndividualEntity, 0, null, null, null, "Individual", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPerson
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), (IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), (IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AccountNumber property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Financial accounting number reference.<br/>Financial accounting number reference.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, value, true); }
		}

		/// <summary> The BillToAddressID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Customer billing address. Foreign key to Address.AddressID.<br/>Customer billing address. Foreign key to Address.AddressID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."BillToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 BillToAddressID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.BillToAddressID, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.BillToAddressID, value, true); }
		}

		/// <summary> The Comment property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Sales representative comments.<br/>Sales representative comments.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Comment"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Comment
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.Comment, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Comment, value, true); }
		}

		/// <summary> The ContactID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Customer contact identification number. Foreign key to Contact.ContactID.<br/>Customer contact identification number. Foreign key to Contact.ContactID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ContactID, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ContactID, value, true); }
		}

		/// <summary> The CreditCardApprovalCode property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Approval code provided by the credit card company.<br/>Approval code provided by the credit card company.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardApprovalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CreditCardApprovalCode
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, value, true); }
		}

		/// <summary> The CreditCardID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Credit card identification number. Foreign key to CreditCard.CreditCardID.<br/>Credit card identification number. Foreign key to CreditCard.CreditCardID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CreditCardID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardID, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardID, value, true); }
		}

		/// <summary> The CurrencyRateID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.<br/>Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CurrencyRateID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateID, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateID, value, true); }
		}

		/// <summary> The CustomerID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Customer identification number. Foreign key to Customer.CustomerID.<br/>Customer identification number. Foreign key to Customer.CustomerID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual Nullable<System.Int32> CustomerID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CustomerID, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CustomerID, value, true); }
		}

		/// <summary> The DueDate property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Date the order is due to the customer.<br/>Date the order is due to the customer.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.DueDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.DueDate, value, true); }
		}

		/// <summary> The Freight property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Shipping cost.<br/>Shipping cost.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Freight, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The OnlineOrderFlag property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: 0 = Order placed by sales person. 1 = Order placed online by customer.<br/>0 = Order placed by sales person. 1 = Order placed online by customer.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OnlineOrderFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean OnlineOrderFlag
		{
			get { return (System.Boolean)GetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, value, true); }
		}

		/// <summary> The OrderDate property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Unique nonclustered index.<br/>Unique nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OrderDate, value, true); }
		}

		/// <summary> The PurchaseOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Customer purchase order number reference. <br/>Customer purchase order number reference. </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."PurchaseOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchaseOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, value, true); }
		}

		/// <summary> The RevisionNumber property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Incremental number to track changes to the sales order over time.<br/>Incremental number to track changes to the sales order over time.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, value, true); }
		}

		/// <summary> The Rowguid property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderHeaderFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SalesOrderID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderID, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesOrderID, value, true); }
		}

		/// <summary> The SalesOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Unique sales order identification number.<br/>Unique sales order identification number.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String SalesOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber, true); }

		}

		/// <summary> The SalesPersonID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Sales person who created the sales order. Foreign key to SalesPerson.SalePersonID.<br/>Sales person who created the sales order. Foreign key to SalesPerson.SalePersonID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.SalesPersonID, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesPersonID, value, true); }
		}

		/// <summary> The ShipDate property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SalesOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipDate, value, true); }
		}

		/// <summary> The ShipMethodID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Shipping method. Foreign key to ShipMethod.ShipMethodID.<br/>Shipping method. Foreign key to ShipMethod.ShipMethodID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipMethodID, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipMethodID, value, true); }
		}

		/// <summary> The ShipToAddressID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Customer shipping address. Foreign key to Address.AddressID.<br/>Customer shipping address. Foreign key to Address.AddressID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipToAddressID
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressID, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressID, value, true); }
		}

		/// <summary> The Status property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled<br/>Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.OrderStatus Status
		{
			get { return (AW.Data.OrderStatus)GetValue((int)SalesOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Status, value, true); }
		}

		/// <summary> The SubTotal property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.<br/>Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SubTotal, value, true); }
		}

		/// <summary> The TaxAmt property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Tax amount.<br/>Tax amount.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, value, true); }
		}

		/// <summary> The TerritoryID property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.<br/>Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryID
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.TerritoryID, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TerritoryID, value, true); }
		}

		/// <summary> The TotalDue property of the Entity SalesOrderHeader<br/><br/>
		/// MS_Description: Total due from customer. Computed as Subtotal + TaxAmt + Freight.<br/>Total due from customer. Computed as Subtotal + TaxAmt + Freight.</summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TotalDue, true); }

		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection SalesOrderDetails
		{
			get	{ return GetMultiSalesOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderDetails. When set to true, SalesOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderDetails
		{
			get	{ return _alwaysFetchSalesOrderDetails; }
			set	{ _alwaysFetchSalesOrderDetails = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderDetails already has been fetched. Setting this property to false when SalesOrderDetails has been fetched
		/// will clear the SalesOrderDetails collection well. Setting this property to true while SalesOrderDetails hasn't been fetched disables lazy loading for SalesOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderDetails
		{
			get { return _alreadyFetchedSalesOrderDetails;}
			set 
			{
				if(_alreadyFetchedSalesOrderDetails && !value && (_salesOrderDetails != null))
				{
					_salesOrderDetails.Clear();
				}
				_alreadyFetchedSalesOrderDetails = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaderSalesReasons()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderSalesReasonCollection SalesOrderHeaderSalesReasons
		{
			get	{ return GetMultiSalesOrderHeaderSalesReasons(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaderSalesReasons. When set to true, SalesOrderHeaderSalesReasons is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaderSalesReasons is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaderSalesReasons(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaderSalesReasons
		{
			get	{ return _alwaysFetchSalesOrderHeaderSalesReasons; }
			set	{ _alwaysFetchSalesOrderHeaderSalesReasons = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaderSalesReasons already has been fetched. Setting this property to false when SalesOrderHeaderSalesReasons has been fetched
		/// will clear the SalesOrderHeaderSalesReasons collection well. Setting this property to true while SalesOrderHeaderSalesReasons hasn't been fetched disables lazy loading for SalesOrderHeaderSalesReasons</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaderSalesReasons
		{
			get { return _alreadyFetchedSalesOrderHeaderSalesReasons;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaderSalesReasons && !value && (_salesOrderHeaderSalesReasons != null))
				{
					_salesOrderHeaderSalesReasons.Clear();
				}
				_alreadyFetchedSalesOrderHeaderSalesReasons = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesReasons()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesReasonCollection SalesReasons
		{
			get { return GetMultiSalesReasons(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesReasons. When set to true, SalesReasons is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesReasons is accessed. You can always execute a forced fetch by calling GetMultiSalesReasons(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesReasons
		{
			get	{ return _alwaysFetchSalesReasons; }
			set	{ _alwaysFetchSalesReasons = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesReasons already has been fetched. Setting this property to false when SalesReasons has been fetched
		/// will clear the SalesReasons collection well. Setting this property to true while SalesReasons hasn't been fetched disables lazy loading for SalesReasons</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesReasons
		{
			get { return _alreadyFetchedSalesReasons;}
			set 
			{
				if(_alreadyFetchedSalesReasons && !value && (_salesReasons != null))
				{
					_salesReasons.Clear();
				}
				_alreadyFetchedSalesReasons = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOffers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOffers
		{
			get { return GetMultiSpecialOffers(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOffers. When set to true, SpecialOffers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOffers is accessed. You can always execute a forced fetch by calling GetMultiSpecialOffers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOffers
		{
			get	{ return _alwaysFetchSpecialOffers; }
			set	{ _alwaysFetchSpecialOffers = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOffers already has been fetched. Setting this property to false when SpecialOffers has been fetched
		/// will clear the SpecialOffers collection well. Setting this property to true while SpecialOffers hasn't been fetched disables lazy loading for SpecialOffers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOffers
		{
			get { return _alreadyFetchedSpecialOffers;}
			set 
			{
				if(_alreadyFetchedSpecialOffers && !value && (_specialOffers != null))
				{
					_specialOffers.Clear();
				}
				_alreadyFetchedSpecialOffers = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBillingAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity BillingAddress
		{
			get	{ return GetSingleBillingAddress(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBillingAddress(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "BillingAddress", _billingAddress, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for BillingAddress. When set to true, BillingAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillingAddress is accessed. You can always execute a forced fetch by calling GetSingleBillingAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillingAddress
		{
			get	{ return _alwaysFetchBillingAddress; }
			set	{ _alwaysFetchBillingAddress = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillingAddress already has been fetched. Setting this property to false when BillingAddress has been fetched
		/// will set BillingAddress to null as well. Setting this property to true while BillingAddress hasn't been fetched disables lazy loading for BillingAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillingAddress
		{
			get { return _alreadyFetchedBillingAddress;}
			set 
			{
				if(_alreadyFetchedBillingAddress && !value)
				{
					this.BillingAddress = null;
				}
				_alreadyFetchedBillingAddress = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property BillingAddress is not found
		/// in the database. When set to true, BillingAddress will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool BillingAddressReturnsNewIfNotFound
		{
			get	{ return _billingAddressReturnsNewIfNotFound; }
			set { _billingAddressReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShippingAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity ShippingAddress
		{
			get	{ return GetSingleShippingAddress(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShippingAddress(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeadersShipped", "ShippingAddress", _shippingAddress, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShippingAddress. When set to true, ShippingAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShippingAddress is accessed. You can always execute a forced fetch by calling GetSingleShippingAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShippingAddress
		{
			get	{ return _alwaysFetchShippingAddress; }
			set	{ _alwaysFetchShippingAddress = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShippingAddress already has been fetched. Setting this property to false when ShippingAddress has been fetched
		/// will set ShippingAddress to null as well. Setting this property to true while ShippingAddress hasn't been fetched disables lazy loading for ShippingAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShippingAddress
		{
			get { return _alreadyFetchedShippingAddress;}
			set 
			{
				if(_alreadyFetchedShippingAddress && !value)
				{
					this.ShippingAddress = null;
				}
				_alreadyFetchedShippingAddress = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ShippingAddress is not found
		/// in the database. When set to true, ShippingAddress will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShippingAddressReturnsNewIfNotFound
		{
			get	{ return _shippingAddressReturnsNewIfNotFound; }
			set { _shippingAddressReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
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
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "Contact", _contact, true); 
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

		/// <summary> Gets / sets related entity of type 'ShipMethodEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return GetSingleShipMethod(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "ShipMethod", _shipMethod, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute a forced fetch by calling GetSingleShipMethod(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod
		{
			get	{ return _alwaysFetchShipMethod; }
			set	{ _alwaysFetchShipMethod = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethod already has been fetched. Setting this property to false when ShipMethod has been fetched
		/// will set ShipMethod to null as well. Setting this property to true while ShipMethod hasn't been fetched disables lazy loading for ShipMethod</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethod
		{
			get { return _alreadyFetchedShipMethod;}
			set 
			{
				if(_alreadyFetchedShipMethod && !value)
				{
					this.ShipMethod = null;
				}
				_alreadyFetchedShipMethod = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ShipMethod is not found
		/// in the database. When set to true, ShipMethod will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShipMethodReturnsNewIfNotFound
		{
			get	{ return _shipMethodReturnsNewIfNotFound; }
			set { _shipMethodReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CreditCardEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CreditCardEntity CreditCard
		{
			get	{ return GetSingleCreditCard(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCreditCard(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "CreditCard", _creditCard, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCard. When set to true, CreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard is accessed. You can always execute a forced fetch by calling GetSingleCreditCard(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCard
		{
			get	{ return _alwaysFetchCreditCard; }
			set	{ _alwaysFetchCreditCard = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CreditCard already has been fetched. Setting this property to false when CreditCard has been fetched
		/// will set CreditCard to null as well. Setting this property to true while CreditCard hasn't been fetched disables lazy loading for CreditCard</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCreditCard
		{
			get { return _alreadyFetchedCreditCard;}
			set 
			{
				if(_alreadyFetchedCreditCard && !value)
				{
					this.CreditCard = null;
				}
				_alreadyFetchedCreditCard = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CreditCard is not found
		/// in the database. When set to true, CreditCard will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CreditCardReturnsNewIfNotFound
		{
			get	{ return _creditCardReturnsNewIfNotFound; }
			set { _creditCardReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CurrencyRateEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrencyRate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CurrencyRateEntity CurrencyRate
		{
			get	{ return GetSingleCurrencyRate(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCurrencyRate(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "CurrencyRate", _currencyRate, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRate. When set to true, CurrencyRate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRate is accessed. You can always execute a forced fetch by calling GetSingleCurrencyRate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRate
		{
			get	{ return _alwaysFetchCurrencyRate; }
			set	{ _alwaysFetchCurrencyRate = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CurrencyRate already has been fetched. Setting this property to false when CurrencyRate has been fetched
		/// will set CurrencyRate to null as well. Setting this property to true while CurrencyRate hasn't been fetched disables lazy loading for CurrencyRate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCurrencyRate
		{
			get { return _alreadyFetchedCurrencyRate;}
			set 
			{
				if(_alreadyFetchedCurrencyRate && !value)
				{
					this.CurrencyRate = null;
				}
				_alreadyFetchedCurrencyRate = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CurrencyRate is not found
		/// in the database. When set to true, CurrencyRate will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CurrencyRateReturnsNewIfNotFound
		{
			get	{ return _currencyRateReturnsNewIfNotFound; }
			set { _currencyRateReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get	{ return GetSingleCustomer(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "Customer", _customer, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute a forced fetch by calling GetSingleCustomer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer
		{
			get	{ return _alwaysFetchCustomer; }
			set	{ _alwaysFetchCustomer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Customer already has been fetched. Setting this property to false when Customer has been fetched
		/// will set Customer to null as well. Setting this property to true while Customer hasn't been fetched disables lazy loading for Customer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomer
		{
			get { return _alreadyFetchedCustomer;}
			set 
			{
				if(_alreadyFetchedCustomer && !value)
				{
					this.Customer = null;
				}
				_alreadyFetchedCustomer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Customer is not found
		/// in the database. When set to true, Customer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerReturnsNewIfNotFound
		{
			get	{ return _customerReturnsNewIfNotFound; }
			set { _customerReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CustomerViewRelatedEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomerViewRelated()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerViewRelatedEntity CustomerViewRelated
		{
			get	{ return GetSingleCustomerViewRelated(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCustomerViewRelated(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeader", "CustomerViewRelated", _customerViewRelated, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelated. When set to true, CustomerViewRelated is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelated is accessed. You can always execute a forced fetch by calling GetSingleCustomerViewRelated(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelated
		{
			get	{ return _alwaysFetchCustomerViewRelated; }
			set	{ _alwaysFetchCustomerViewRelated = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelated already has been fetched. Setting this property to false when CustomerViewRelated has been fetched
		/// will set CustomerViewRelated to null as well. Setting this property to true while CustomerViewRelated hasn't been fetched disables lazy loading for CustomerViewRelated</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelated
		{
			get { return _alreadyFetchedCustomerViewRelated;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelated && !value)
				{
					this.CustomerViewRelated = null;
				}
				_alreadyFetchedCustomerViewRelated = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CustomerViewRelated is not found
		/// in the database. When set to true, CustomerViewRelated will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerViewRelatedReturnsNewIfNotFound
		{
			get	{ return _customerViewRelatedReturnsNewIfNotFound; }
			set { _customerViewRelatedReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'IndividualEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleIndividual()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual IndividualEntity Individual
		{
			get	{ return GetSingleIndividual(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncIndividual(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "", "Individual", _individual, false); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Individual. When set to true, Individual is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individual is accessed. You can always execute a forced fetch by calling GetSingleIndividual(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividual
		{
			get	{ return _alwaysFetchIndividual; }
			set	{ _alwaysFetchIndividual = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Individual already has been fetched. Setting this property to false when Individual has been fetched
		/// will set Individual to null as well. Setting this property to true while Individual hasn't been fetched disables lazy loading for Individual</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIndividual
		{
			get { return _alreadyFetchedIndividual;}
			set 
			{
				if(_alreadyFetchedIndividual && !value)
				{
					this.Individual = null;
				}
				_alreadyFetchedIndividual = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Individual is not found
		/// in the database. When set to true, Individual will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool IndividualReturnsNewIfNotFound
		{
			get	{ return _individualReturnsNewIfNotFound; }
			set { _individualReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SalesPersonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get	{ return GetSingleSalesPerson(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "SalesPerson", _salesPerson, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute a forced fetch by calling GetSingleSalesPerson(true).</summary>
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
			set { _salesPersonReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return GetSingleSalesTerritory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "SalesTerritory", _salesTerritory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute a forced fetch by calling GetSingleSalesTerritory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory
		{
			get	{ return _alwaysFetchSalesTerritory; }
			set	{ _alwaysFetchSalesTerritory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesTerritory already has been fetched. Setting this property to false when SalesTerritory has been fetched
		/// will set SalesTerritory to null as well. Setting this property to true while SalesTerritory hasn't been fetched disables lazy loading for SalesTerritory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesTerritory
		{
			get { return _alreadyFetchedSalesTerritory;}
			set 
			{
				if(_alreadyFetchedSalesTerritory && !value)
				{
					this.SalesTerritory = null;
				}
				_alreadyFetchedSalesTerritory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SalesTerritory is not found
		/// in the database. When set to true, SalesTerritory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SalesTerritoryReturnsNewIfNotFound
		{
			get	{ return _salesTerritoryReturnsNewIfNotFound; }
			set { _salesTerritoryReturnsNewIfNotFound = value; }	
		}

 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.City.<br/><br/></summary>
		public virtual System.String CustomerCity
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.City;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.City = value;
				}				
			}
		}
 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.CountryRegionName.<br/><br/></summary>
		public virtual System.String CustomerCountry
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.CountryRegionName;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.CountryRegionName = value;
				}				
			}
		}
 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.FirstName.<br/><br/></summary>
		public virtual System.String CustomerFirstName
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.FirstName;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.FirstName = value;
				}				
			}
		}
 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.LastName.<br/><br/></summary>
		public virtual System.String CustomerLastName
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.LastName;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.LastName = value;
				}				
			}
		}
 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.StateProvinceName.<br/><br/></summary>
		public virtual System.String CustomerState
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.StateProvinceName;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.StateProvinceName = value;
				}				
			}
		}
 
		/// <summary> Gets / Sets the value of the related field this.CustomerViewRelated.PostalCode.<br/><br/></summary>
		public virtual System.String CustomerZip
		{
			get
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				return relatedEntity==null ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : relatedEntity.PostalCode;
			}
			set
			{
				CustomerViewRelatedEntity relatedEntity = this.CustomerViewRelated;
				if(relatedEntity!=null)
				{
					relatedEntity.PostalCode = value;
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
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.SalesOrderHeaderEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode


    /// <summary>
    /// Called at the end of the initialization routine. Raises Initialized event.
    /// </summary>
    protected override void OnInitialized()
    {
      // Set the validator to this customer instance.
      Validator = new SalesOrderHeaderEntityValidator();
    }

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
