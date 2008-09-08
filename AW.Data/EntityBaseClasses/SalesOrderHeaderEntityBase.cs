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
	/// <summary>Entity base class which represents the base class for the entity 'SalesOrderHeader'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class SalesOrderHeaderEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderDetailCollection	_salesOrderDetail;
		private bool	_alwaysFetchSalesOrderDetail, _alreadyFetchedSalesOrderDetail;
		private AW.Data.CollectionClasses.SpecialOfferProductCollection _specialOfferProductCollectionViaSalesOrderDetail;
		private bool	_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail, _alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail;
		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress, _addressReturnsNewIfNotFound;
		private AddressEntity _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_, _address_ReturnsNewIfNotFound;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private CreditCardEntity _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard, _creditCardReturnsNewIfNotFound;
		private CurrencyRateEntity _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate, _currencyRateReturnsNewIfNotFound;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		private CustomerViewRelatedEntity _customerViewRelated;
		private bool	_alwaysFetchCustomerViewRelated, _alreadyFetchedCustomerViewRelated, _customerViewRelatedReturnsNewIfNotFound;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory, _salesTerritoryReturnsNewIfNotFound;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod, _shipMethodReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Address</summary>
			public static readonly string Address = "Address";
			/// <summary>Member name Address_</summary>
			public static readonly string Address_ = "Address_";
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name CreditCard</summary>
			public static readonly string CreditCard = "CreditCard";
			/// <summary>Member name CurrencyRate</summary>
			public static readonly string CurrencyRate = "CurrencyRate";
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name CustomerViewRelated</summary>
			public static readonly string CustomerViewRelated = "CustomerViewRelated";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name ShipMethod</summary>
			public static readonly string ShipMethod = "ShipMethod";
			/// <summary>Member name SalesOrderDetail</summary>
			public static readonly string SalesOrderDetail = "SalesOrderDetail";
			/// <summary>Member name SpecialOfferProductCollectionViaSalesOrderDetail</summary>
			public static readonly string SpecialOfferProductCollectionViaSalesOrderDetail = "SpecialOfferProductCollectionViaSalesOrderDetail";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderHeaderEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderHeaderEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId)
		{
			InitClassFetch(salesOrderId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(salesOrderId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId, IValidator validator)
		{
			InitClassFetch(salesOrderId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderDetail = (AW.Data.CollectionClasses.SalesOrderDetailCollection)info.GetValue("_salesOrderDetail", typeof(AW.Data.CollectionClasses.SalesOrderDetailCollection));
			_alwaysFetchSalesOrderDetail = info.GetBoolean("_alwaysFetchSalesOrderDetail");
			_alreadyFetchedSalesOrderDetail = info.GetBoolean("_alreadyFetchedSalesOrderDetail");
			_specialOfferProductCollectionViaSalesOrderDetail = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProductCollectionViaSalesOrderDetail", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = info.GetBoolean("_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail");
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = info.GetBoolean("_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail");
			_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
			if(_address!=null)
			{
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_addressReturnsNewIfNotFound = info.GetBoolean("_addressReturnsNewIfNotFound");
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");
			_address_ = (AddressEntity)info.GetValue("_address_", typeof(AddressEntity));
			if(_address_!=null)
			{
				_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_address_ReturnsNewIfNotFound = info.GetBoolean("_address_ReturnsNewIfNotFound");
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");
			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
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
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_salesTerritoryReturnsNewIfNotFound = info.GetBoolean("_salesTerritoryReturnsNewIfNotFound");
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shipMethodReturnsNewIfNotFound = info.GetBoolean("_shipMethodReturnsNewIfNotFound");
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((SalesOrderHeaderFieldIndex)fieldIndex)
			{
				case SalesOrderHeaderFieldIndex.CustomerId:
					DesetupSyncCustomer(true, false);
					_alreadyFetchedCustomer = false;
					DesetupSyncCustomerViewRelated(true, false);
					_alreadyFetchedCustomerViewRelated = false;
					break;
				case SalesOrderHeaderFieldIndex.ContactId:
					DesetupSyncContact(true, false);
					_alreadyFetchedContact = false;
					break;
				case SalesOrderHeaderFieldIndex.TerritoryId:
					DesetupSyncSalesTerritory(true, false);
					_alreadyFetchedSalesTerritory = false;
					break;
				case SalesOrderHeaderFieldIndex.BillToAddressId:
					DesetupSyncAddress(true, false);
					_alreadyFetchedAddress = false;
					break;
				case SalesOrderHeaderFieldIndex.ShipToAddressId:
					DesetupSyncAddress_(true, false);
					_alreadyFetchedAddress_ = false;
					break;
				case SalesOrderHeaderFieldIndex.ShipMethodId:
					DesetupSyncShipMethod(true, false);
					_alreadyFetchedShipMethod = false;
					break;
				case SalesOrderHeaderFieldIndex.CreditCardId:
					DesetupSyncCreditCard(true, false);
					_alreadyFetchedCreditCard = false;
					break;
				case SalesOrderHeaderFieldIndex.CurrencyRateId:
					DesetupSyncCurrencyRate(true, false);
					_alreadyFetchedCurrencyRate = false;
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
			_alreadyFetchedSalesOrderDetail = (_salesOrderDetail.Count > 0);
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = (_specialOfferProductCollectionViaSalesOrderDetail.Count > 0);
			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddress_ = (_address_ != null);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedCreditCard = (_creditCard != null);
			_alreadyFetchedCurrencyRate = (_currencyRate != null);
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedCustomerViewRelated = (_customerViewRelated != null);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return SalesOrderHeaderEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Address":
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId);
					break;
				case "Address_":
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId);
					break;
				case "Contact":
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId);
					break;
				case "CreditCard":
					toReturn.Add(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId);
					break;
				case "CurrencyRate":
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId);
					break;
				case "Customer":
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId);
					break;
				case "CustomerViewRelated":
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId);
					break;
				case "SalesTerritory":
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId);
					break;
				case "ShipMethod":
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId);
					break;
				case "SalesOrderDetail":
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId);
					break;
				case "SpecialOfferProductCollectionViaSalesOrderDetail":
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId, "SalesOrderHeaderEntity__", "SalesOrderDetail_", JoinHint.None);
					toReturn.Add(SalesOrderDetailEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferIdProductId, "SalesOrderDetail_", string.Empty, JoinHint.None);
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
			info.AddValue("_salesOrderDetail", (!this.MarkedForDeletion?_salesOrderDetail:null));
			info.AddValue("_alwaysFetchSalesOrderDetail", _alwaysFetchSalesOrderDetail);
			info.AddValue("_alreadyFetchedSalesOrderDetail", _alreadyFetchedSalesOrderDetail);
			info.AddValue("_specialOfferProductCollectionViaSalesOrderDetail", (!this.MarkedForDeletion?_specialOfferProductCollectionViaSalesOrderDetail:null));
			info.AddValue("_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail", _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail);
			info.AddValue("_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail", _alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail);
			info.AddValue("_address", (!this.MarkedForDeletion?_address:null));
			info.AddValue("_addressReturnsNewIfNotFound", _addressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_address_", (!this.MarkedForDeletion?_address_:null));
			info.AddValue("_address_ReturnsNewIfNotFound", _address_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
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
			info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
			info.AddValue("_salesTerritoryReturnsNewIfNotFound", _salesTerritoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_shipMethod", (!this.MarkedForDeletion?_shipMethod:null));
			info.AddValue("_shipMethodReturnsNewIfNotFound", _shipMethodReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);

			
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
				case "Address":
					_alreadyFetchedAddress = true;
					this.Address = (AddressEntity)entity;
					break;
				case "Address_":
					_alreadyFetchedAddress_ = true;
					this.Address_ = (AddressEntity)entity;
					break;
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
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
				case "SalesTerritory":
					_alreadyFetchedSalesTerritory = true;
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "ShipMethod":
					_alreadyFetchedShipMethod = true;
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "SalesOrderDetail":
					_alreadyFetchedSalesOrderDetail = true;
					if(entity!=null)
					{
						this.SalesOrderDetail.Add((SalesOrderDetailEntity)entity);
					}
					break;
				case "SpecialOfferProductCollectionViaSalesOrderDetail":
					_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = true;
					if(entity!=null)
					{
						this.SpecialOfferProductCollectionViaSalesOrderDetail.Add((SpecialOfferProductEntity)entity);
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
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "Address_":
					SetupSyncAddress_(relatedEntity);
					break;
				case "Contact":
					SetupSyncContact(relatedEntity);
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
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "SalesOrderDetail":
					_salesOrderDetail.Add((SalesOrderDetailEntity)relatedEntity);
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
				case "Address":
					DesetupSyncAddress(false, true);
					break;
				case "Address_":
					DesetupSyncAddress_(false, true);
					break;
				case "Contact":
					DesetupSyncContact(false, true);
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
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "SalesOrderDetail":
					base.PerformRelatedEntityRemoval(_salesOrderDetail, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_address_!=null)
			{
				toReturn.Add(_address_);
			}
			if(_contact!=null)
			{
				toReturn.Add(_contact);
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_salesOrderDetail);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId)
		{
			return FetchUsingPK(salesOrderId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesOrderId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(salesOrderId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesOrderId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesOrderHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesOrderHeaderFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderHeaderRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch)
		{
			return GetMultiSalesOrderDetail(forceFetch, _salesOrderDetail.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderDetail(forceFetch, _salesOrderDetail.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderDetail(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderDetail.GetMultiManyToOne(this, null, filter);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderDetail'. These settings will be taken into account
		/// when the property SalesOrderDetail is requested or GetMultiSalesOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderDetail.SortClauses=sortClauses;
			_salesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(bool forceFetch)
		{
			return GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(forceFetch, _specialOfferProductCollectionViaSalesOrderDetail.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail || forceFetch || _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProductCollectionViaSalesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProductCollectionViaSalesOrderDetail);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesOrderId, ComparisonOperator.Equal, this.SalesOrderId, "SalesOrderHeaderEntity__"));
				_specialOfferProductCollectionViaSalesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferProductCollectionViaSalesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferProductCollectionViaSalesOrderDetail.GetMulti(filter, GetRelationsForField("SpecialOfferProductCollectionViaSalesOrderDetail"));
				_specialOfferProductCollectionViaSalesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = true;
			}
			return _specialOfferProductCollectionViaSalesOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProductCollectionViaSalesOrderDetail'. These settings will be taken into account
		/// when the property SpecialOfferProductCollectionViaSalesOrderDetail is requested or GetMultiSpecialOfferProductCollectionViaSalesOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProductCollectionViaSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProductCollectionViaSalesOrderDetail.SortClauses=sortClauses;
			_specialOfferProductCollectionViaSalesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleAddress()
		{
			return GetSingleAddress(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress(bool forceFetch)
		{
			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId);

				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.BillToAddressId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AddressEntity)base.ActiveContext.Get(newEntity);
					}
					this.Address = newEntity;
				}
				else
				{
					if(_addressReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_address == null)))
						{
							this.Address = newEntity;
						}
					}
					else
					{
						this.Address = null;
					}
				}
				_alreadyFetchedAddress = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _address;
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleAddress_()
		{
			return GetSingleAddress_(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress_(bool forceFetch)
		{
			if( ( !_alreadyFetchedAddress_ || forceFetch || _alwaysFetchAddress_) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId);

				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ShipToAddressId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AddressEntity)base.ActiveContext.Get(newEntity);
					}
					this.Address_ = newEntity;
				}
				else
				{
					if(_address_ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_address_ == null)))
						{
							this.Address_ = newEntity;
						}
					}
					else
					{
						this.Address_ = null;
					}
				}
				_alreadyFetchedAddress_ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _address_;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId);

				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ContactId);
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
			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId);

				CreditCardEntity newEntity = new CreditCardEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CreditCardId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CreditCardEntity)base.ActiveContext.Get(newEntity);
					}
					this.CreditCard = newEntity;
				}
				else
				{
					if(_creditCardReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_creditCard == null)))
						{
							this.CreditCard = newEntity;
						}
					}
					else
					{
						this.CreditCard = null;
					}
				}
				_alreadyFetchedCreditCard = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedCurrencyRate || forceFetch || _alwaysFetchCurrencyRate) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId);

				CurrencyRateEntity newEntity = new CurrencyRateEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CurrencyRateId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CurrencyRateEntity)base.ActiveContext.Get(newEntity);
					}
					this.CurrencyRate = newEntity;
				}
				else
				{
					if(_currencyRateReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_currencyRate == null)))
						{
							this.CurrencyRate = newEntity;
						}
					}
					else
					{
						this.CurrencyRate = null;
					}
				}
				_alreadyFetchedCurrencyRate = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId);

				CustomerEntity newEntity = new CustomerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CustomerEntity)base.ActiveContext.Get(newEntity);
					}
					this.Customer = newEntity;
				}
				else
				{
					if(_customerReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_customer == null)))
						{
							this.Customer = newEntity;
						}
					}
					else
					{
						this.Customer = null;
					}
				}
				_alreadyFetchedCustomer = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
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
			if( ( !_alreadyFetchedCustomerViewRelated || forceFetch || _alwaysFetchCustomerViewRelated) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId);

				CustomerViewRelatedEntity newEntity = new CustomerViewRelatedEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (CustomerViewRelatedEntity)base.ActiveContext.Get(newEntity);
					}
					this.CustomerViewRelated = newEntity;
				}
				else
				{
					if(_customerViewRelatedReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_customerViewRelated == null)))
						{
							this.CustomerViewRelated = newEntity;
						}
					}
					else
					{
						this.CustomerViewRelated = null;
					}
				}
				_alreadyFetchedCustomerViewRelated = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _customerViewRelated;
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
			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId);

				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.TerritoryId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (SalesTerritoryEntity)base.ActiveContext.Get(newEntity);
					}
					this.SalesTerritory = newEntity;
				}
				else
				{
					if(_salesTerritoryReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_salesTerritory == null)))
						{
							this.SalesTerritory = newEntity;
						}
					}
					else
					{
						this.SalesTerritory = null;
					}
				}
				_alreadyFetchedSalesTerritory = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _salesTerritory;
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
			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId);

				ShipMethodEntity newEntity = new ShipMethodEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ShipMethodId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ShipMethodEntity)base.ActiveContext.Get(newEntity);
					}
					this.ShipMethod = newEntity;
				}
				else
				{
					if(_shipMethodReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_shipMethod == null)))
						{
							this.ShipMethod = newEntity;
						}
					}
					else
					{
						this.ShipMethod = null;
					}
				}
				_alreadyFetchedShipMethod = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _shipMethod;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderDetail.ActiveContext = base.ActiveContext;
			_specialOfferProductCollectionViaSalesOrderDetail.ActiveContext = base.ActiveContext;
			if(_address!=null)
			{
				_address.ActiveContext = base.ActiveContext;
			}
			if(_address_!=null)
			{
				_address_.ActiveContext = base.ActiveContext;
			}
			if(_contact!=null)
			{
				_contact.ActiveContext = base.ActiveContext;
			}
			if(_creditCard!=null)
			{
				_creditCard.ActiveContext = base.ActiveContext;
			}
			if(_currencyRate!=null)
			{
				_currencyRate.ActiveContext = base.ActiveContext;
			}
			if(_customer!=null)
			{
				_customer.ActiveContext = base.ActiveContext;
			}
			if(_customerViewRelated!=null)
			{
				_customerViewRelated.ActiveContext = base.ActiveContext;
			}
			if(_salesTerritory!=null)
			{
				_salesTerritory.ActiveContext = base.ActiveContext;
			}
			if(_shipMethod!=null)
			{
				_shipMethod.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesOrderHeaderEntity);
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
			toReturn.Add("Address", _address);
			toReturn.Add("Address_", _address_);
			toReturn.Add("Contact", _contact);
			toReturn.Add("CreditCard", _creditCard);
			toReturn.Add("CurrencyRate", _currencyRate);
			toReturn.Add("Customer", _customer);
			toReturn.Add("CustomerViewRelated", _customerViewRelated);
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("SalesOrderDetail", _salesOrderDetail);
			toReturn.Add("SpecialOfferProductCollectionViaSalesOrderDetail", _specialOfferProductCollectionViaSalesOrderDetail);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 salesOrderId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(salesOrderId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_salesOrderDetail = new AW.Data.CollectionClasses.SalesOrderDetailCollection(new SalesOrderDetailEntityFactory());
			_salesOrderDetail.SetContainingEntityInfo(this, "SalesOrderHeader");
			_alwaysFetchSalesOrderDetail = false;
			_alreadyFetchedSalesOrderDetail = false;
			_specialOfferProductCollectionViaSalesOrderDetail = new AW.Data.CollectionClasses.SpecialOfferProductCollection(new SpecialOfferProductEntityFactory());
			_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = false;
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = false;
			_address = null;
			_addressReturnsNewIfNotFound = true;
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_address_ = null;
			_address_ReturnsNewIfNotFound = true;
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_contact = null;
			_contactReturnsNewIfNotFound = true;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_creditCard = null;
			_creditCardReturnsNewIfNotFound = true;
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_currencyRate = null;
			_currencyRateReturnsNewIfNotFound = true;
			_alwaysFetchCurrencyRate = false;
			_alreadyFetchedCurrencyRate = false;
			_customer = null;
			_customerReturnsNewIfNotFound = true;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_customerViewRelated = null;
			_customerViewRelatedReturnsNewIfNotFound = true;
			_alwaysFetchCustomerViewRelated = false;
			_alreadyFetchedCustomerViewRelated = false;
			_salesTerritory = null;
			_salesTerritoryReturnsNewIfNotFound = true;
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_shipMethod = null;
			_shipMethodReturnsNewIfNotFound = true;
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;


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

			_fieldsCustomProperties.Add("SalesOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OnlineOrderFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SalesOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PurchaseOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SalesPersonId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BillToAddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ShipToAddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ShipMethodId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CreditCardId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CreditCardApprovalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CurrencyRateId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Comment", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.BillToAddressId } );		
			_address = null;
		}
		
		/// <summary> setups the sync logic for member _address</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntity relatedEntity)
		{
			if(_address!=relatedEntity)
			{		
				DesetupSyncAddress(true, true);
				_address = (AddressEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, true, ref _alreadyFetchedAddress, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddressPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _address_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _address_, new PropertyChangedEventHandler( OnAddress_PropertyChanged ), "Address_", SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, true, signalRelatedEntity, "SalesOrderHeader_", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipToAddressId } );		
			_address_ = null;
		}
		
		/// <summary> setups the sync logic for member _address_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress_(IEntity relatedEntity)
		{
			if(_address_!=relatedEntity)
			{		
				DesetupSyncAddress_(true, true);
				_address_ = (AddressEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _address_, new PropertyChangedEventHandler( OnAddress_PropertyChanged ), "Address_", SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, true, ref _alreadyFetchedAddress_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddress_PropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ContactId } );		
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
				base.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, true, ref _alreadyFetchedContact, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _creditCard</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCreditCard(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CreditCardId } );		
			_creditCard = null;
		}
		
		/// <summary> setups the sync logic for member _creditCard</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCreditCard(IEntity relatedEntity)
		{
			if(_creditCard!=relatedEntity)
			{		
				DesetupSyncCreditCard(true, true);
				_creditCard = (CreditCardEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardId, true, ref _alreadyFetchedCreditCard, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CurrencyRateId } );		
			_currencyRate = null;
		}
		
		/// <summary> setups the sync logic for member _currencyRate</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrencyRate(IEntity relatedEntity)
		{
			if(_currencyRate!=relatedEntity)
			{		
				DesetupSyncCurrencyRate(true, true);
				_currencyRate = (CurrencyRateEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateId, true, ref _alreadyFetchedCurrencyRate, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerId } );		
			_customer = null;
		}
		
		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntity relatedEntity)
		{
			if(_customer!=relatedEntity)
			{		
				DesetupSyncCustomer(true, true);
				_customer = (CustomerEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, true, ref _alreadyFetchedCustomer, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _customerViewRelated, new PropertyChangedEventHandler( OnCustomerViewRelatedPropertyChanged ), "CustomerViewRelated", SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerId } );		
			_customerViewRelated = null;
		}
		
		/// <summary> setups the sync logic for member _customerViewRelated</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomerViewRelated(IEntity relatedEntity)
		{
			if(_customerViewRelated!=relatedEntity)
			{		
				DesetupSyncCustomerViewRelated(true, true);
				_customerViewRelated = (CustomerViewRelatedEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _customerViewRelated, new PropertyChangedEventHandler( OnCustomerViewRelatedPropertyChanged ), "CustomerViewRelated", SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, true, ref _alreadyFetchedCustomerViewRelated, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerViewRelatedPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			base.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.TerritoryId } );		
			_salesTerritory = null;
		}
		
		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntity relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{		
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryId, true, ref _alreadyFetchedSalesTerritory, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, true, signalRelatedEntity, "SalesOrderHeader", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipMethodId } );		
			_shipMethod = null;
		}
		
		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntity relatedEntity)
		{
			if(_shipMethod!=relatedEntity)
			{		
				DesetupSyncShipMethod(true, true);
				_shipMethod = (ShipMethodEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, true, ref _alreadyFetchedShipMethod, new string[] {  } );
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


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesOrderHeaderFieldIndex.SalesOrderId].ForcedCurrentValueWrite(salesOrderId);
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderDetail
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderDetailCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderDetail")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesOrderDetailEntity, 0, null, null, null, "SalesOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProductCollectionViaSalesOrderDetail
		{
			get
			{
				IEntityRelation intermediateRelation = SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderDetail_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, GetRelationsForField("SpecialOfferProductCollectionViaSalesOrderDetail"), "SpecialOfferProductCollectionViaSalesOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					(IEntityRelation)GetRelationsForField("Address")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					(IEntityRelation)GetRelationsForField("Address_")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("Contact")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CreditCard' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCreditCard
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CreditCardCollection(),
					(IEntityRelation)GetRelationsForField("CreditCard")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CreditCardEntity, 0, null, null, null, "CreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRate
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(),
					(IEntityRelation)GetRelationsForField("CurrencyRate")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, null, "CurrencyRate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(),
					(IEntityRelation)GetRelationsForField("Customer")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelated
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(),
					(IEntityRelation)GetRelationsForField("CustomerViewRelated")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, null, "CustomerViewRelated", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(),
					(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethod
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(),
					(IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "SalesOrderHeaderEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return SalesOrderHeaderEntity.CustomProperties;}
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
			get { return SalesOrderHeaderEntity.FieldsCustomProperties;}
		}

		/// <summary> The SalesOrderId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesOrderId, value, true); }
		}
		/// <summary> The RevisionNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, value, true); }
		}
		/// <summary> The OrderDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OrderDate, value, true); }
		}
		/// <summary> The DueDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.DueDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.DueDate, value, true); }
		}
		/// <summary> The ShipDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SalesOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipDate, value, true); }
		}
		/// <summary> The Status property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)SalesOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Status, value, true); }
		}
		/// <summary> The OnlineOrderFlag property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OnlineOrderFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean OnlineOrderFlag
		{
			get { return (System.Boolean)GetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, value, true); }
		}
		/// <summary> The SalesOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String SalesOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber, true); }

		}
		/// <summary> The PurchaseOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."PurchaseOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchaseOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, value, true); }
		}
		/// <summary> The AccountNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, value, true); }
		}
		/// <summary> The CustomerId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.CustomerId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CustomerId, value, true); }
		}
		/// <summary> The ContactId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ContactId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ContactId, value, true); }
		}
		/// <summary> The SalesPersonId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.SalesPersonId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesPersonId, value, true); }
		}
		/// <summary> The TerritoryId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TerritoryId, value, true); }
		}
		/// <summary> The BillToAddressId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."BillToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 BillToAddressId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, value, true); }
		}
		/// <summary> The ShipToAddressId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipToAddressId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, value, true); }
		}
		/// <summary> The ShipMethodId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, value, true); }
		}
		/// <summary> The CreditCardId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CreditCardId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardId, value, true); }
		}
		/// <summary> The CreditCardApprovalCode property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardApprovalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CreditCardApprovalCode
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, value, true); }
		}
		/// <summary> The CurrencyRateId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CurrencyRateId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId, value, true); }
		}
		/// <summary> The SubTotal property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SubTotal, value, true); }
		}
		/// <summary> The TaxAmt property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, value, true); }
		}
		/// <summary> The Freight property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Freight, value, true); }
		}
		/// <summary> The TotalDue property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TotalDue, true); }

		}
		/// <summary> The Comment property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Comment"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Comment
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.Comment, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Comment, value, true); }
		}
		/// <summary> The Rowguid property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderHeaderFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection SalesOrderDetail
		{
			get	{ return GetMultiSalesOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderDetail. When set to true, SalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderDetail
		{
			get	{ return _alwaysFetchSalesOrderDetail; }
			set	{ _alwaysFetchSalesOrderDetail = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderDetail already has been fetched. Setting this property to false when SalesOrderDetail has been fetched
		/// will clear the SalesOrderDetail collection well. Setting this property to true while SalesOrderDetail hasn't been fetched disables lazy loading for SalesOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderDetail
		{
			get { return _alreadyFetchedSalesOrderDetail;}
			set 
			{
				if(_alreadyFetchedSalesOrderDetail && !value && (_salesOrderDetail != null))
				{
					_salesOrderDetail.Clear();
				}
				_alreadyFetchedSalesOrderDetail = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProductCollectionViaSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProductCollectionViaSalesOrderDetail
		{
			get { return GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProductCollectionViaSalesOrderDetail. When set to true, SpecialOfferProductCollectionViaSalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProductCollectionViaSalesOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail
		{
			get	{ return _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail; }
			set	{ _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferProductCollectionViaSalesOrderDetail already has been fetched. Setting this property to false when SpecialOfferProductCollectionViaSalesOrderDetail has been fetched
		/// will clear the SpecialOfferProductCollectionViaSalesOrderDetail collection well. Setting this property to true while SpecialOfferProductCollectionViaSalesOrderDetail hasn't been fetched disables lazy loading for SpecialOfferProductCollectionViaSalesOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail
		{
			get { return _alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail;}
			set 
			{
				if(_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail && !value && (_specialOfferProductCollectionViaSalesOrderDetail != null))
				{
					_specialOfferProductCollectionViaSalesOrderDetail.Clear();
				}
				_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual AddressEntity Address
		{
			get	{ return GetSingleAddress(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					if(value==null)
					{
						if(_address != null)
						{
							_address.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_address!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get	{ return _alwaysFetchAddress; }
			set	{ _alwaysFetchAddress = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Address already has been fetched. Setting this property to false when Address has been fetched
		/// will set Address to null as well. Setting this property to true while Address hasn't been fetched disables lazy loading for Address</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddress
		{
			get { return _alreadyFetchedAddress;}
			set 
			{
				if(_alreadyFetchedAddress && !value)
				{
					this.Address = null;
				}
				_alreadyFetchedAddress = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Address is not found
		/// in the database. When set to true, Address will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AddressReturnsNewIfNotFound
		{
			get	{ return _addressReturnsNewIfNotFound; }
			set { _addressReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual AddressEntity Address_
		{
			get	{ return GetSingleAddress_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress_(value);
				}
				else
				{
					if(value==null)
					{
						if(_address_ != null)
						{
							_address_.UnsetRelatedEntity(this, "SalesOrderHeader_");
						}
					}
					else
					{
						if(_address_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address_. When set to true, Address_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress_
		{
			get	{ return _alwaysFetchAddress_; }
			set	{ _alwaysFetchAddress_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Address_ already has been fetched. Setting this property to false when Address_ has been fetched
		/// will set Address_ to null as well. Setting this property to true while Address_ hasn't been fetched disables lazy loading for Address_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddress_
		{
			get { return _alreadyFetchedAddress_;}
			set 
			{
				if(_alreadyFetchedAddress_ && !value)
				{
					this.Address_ = null;
				}
				_alreadyFetchedAddress_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Address_ is not found
		/// in the database. When set to true, Address_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Address_ReturnsNewIfNotFound
		{
			get	{ return _address_ReturnsNewIfNotFound; }
			set { _address_ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
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
							_contact.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_contact!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
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
		/// <summary> Gets / sets related entity of type 'CreditCardEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual CreditCardEntity CreditCard
		{
			get	{ return GetSingleCreditCard(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCreditCard(value);
				}
				else
				{
					if(value==null)
					{
						if(_creditCard != null)
						{
							_creditCard.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_creditCard!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CreditCard. When set to true, CreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard is accessed. You can always execute
		/// a forced fetch by calling GetSingleCreditCard(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrencyRate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual CurrencyRateEntity CurrencyRate
		{
			get	{ return GetSingleCurrencyRate(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCurrencyRate(value);
				}
				else
				{
					if(value==null)
					{
						if(_currencyRate != null)
						{
							_currencyRate.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_currencyRate!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CurrencyRate. When set to true, CurrencyRate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRate is accessed. You can always execute
		/// a forced fetch by calling GetSingleCurrencyRate(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual CustomerEntity Customer
		{
			get	{ return GetSingleCustomer(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					if(value==null)
					{
						if(_customer != null)
						{
							_customer.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_customer!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomer(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomerViewRelated()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual CustomerViewRelatedEntity CustomerViewRelated
		{
			get	{ return GetSingleCustomerViewRelated(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomerViewRelated(value);
				}
				else
				{
					if(value==null)
					{
						if(_customerViewRelated != null)
						{
							_customerViewRelated.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_customerViewRelated!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelated. When set to true, CustomerViewRelated is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelated is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomerViewRelated(true).</summary>
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
		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return GetSingleSalesTerritory(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesTerritory != null)
						{
							_salesTerritory.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_salesTerritory!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesTerritory(true).</summary>
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
		/// <summary> Gets / sets related entity of type 'ShipMethodEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return GetSingleShipMethod(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					if(value==null)
					{
						if(_shipMethod != null)
						{
							_shipMethod.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						if(_shipMethod!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetSingleShipMethod(true).</summary>
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
			get { return (int)AW.Data.EntityType.SalesOrderHeaderEntity; }
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
