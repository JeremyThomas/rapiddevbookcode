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
	/// <summary>Entity base class which represents the base class for the entity 'CreditCard'.<br/><br/>
	/// 
	/// MS_Description: Customer credit card information.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class CreditCardEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ContactCreditCardCollection	_contactCreditCard;
		private bool	_alwaysFetchContactCreditCard, _alreadyFetchedContactCreditCard;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader_, _alreadyFetchedAddressCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader, _alreadyFetchedAddressCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader, _alreadyFetchedContactCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaContactCreditCard;
		private bool	_alwaysFetchContactCollectionViaContactCreditCard, _alreadyFetchedContactCollectionViaContactCreditCard;
		private AW.Data.CollectionClasses.CurrencyRateCollection _currencyRateCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader, _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader___;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___;
		private AW.Data.CollectionClasses.SalesPersonCollection _salesPersonCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesPersonCollectionViaSalesOrderHeader, _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.SalesTerritoryCollection _salesTerritoryCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader, _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader;
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

			/// <summary>Member name ContactCreditCard</summary>
			public static readonly string ContactCreditCard = "ContactCreditCard";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader = "ContactCollectionViaSalesOrderHeader";
			/// <summary>Member name ContactCollectionViaContactCreditCard</summary>
			public static readonly string ContactCollectionViaContactCreditCard = "ContactCollectionViaContactCreditCard";
			/// <summary>Member name CurrencyRateCollectionViaSalesOrderHeader</summary>
			public static readonly string CurrencyRateCollectionViaSalesOrderHeader = "CurrencyRateCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader___</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader___ = "CustomerViewRelatedCollectionViaSalesOrderHeader___";
			/// <summary>Member name SalesPersonCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesPersonCollectionViaSalesOrderHeader = "SalesPersonCollectionViaSalesOrderHeader";
			/// <summary>Member name SalesTerritoryCollectionViaSalesOrderHeader</summary>
			public static readonly string SalesTerritoryCollectionViaSalesOrderHeader = "SalesTerritoryCollectionViaSalesOrderHeader";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CreditCardEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CreditCardEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		public CreditCardEntityBase(System.Int32 creditCardID)
		{
			InitClassFetch(creditCardID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CreditCardEntityBase(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(creditCardID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="validator">The custom validator object for this CreditCardEntity</param>
		public CreditCardEntityBase(System.Int32 creditCardID, IValidator validator)
		{
			InitClassFetch(creditCardID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CreditCardEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_contactCreditCard = (AW.Data.CollectionClasses.ContactCreditCardCollection)info.GetValue("_contactCreditCard", typeof(AW.Data.CollectionClasses.ContactCreditCardCollection));
			_alwaysFetchContactCreditCard = info.GetBoolean("_alwaysFetchContactCreditCard");
			_alreadyFetchedContactCreditCard = info.GetBoolean("_alreadyFetchedContactCreditCard");
			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");
			_addressCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader_");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader_");
			_addressCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader");
			_contactCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader");
			_alreadyFetchedContactCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader");
			_contactCollectionViaContactCreditCard = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaContactCreditCard", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaContactCreditCard = info.GetBoolean("_alwaysFetchContactCollectionViaContactCreditCard");
			_alreadyFetchedContactCollectionViaContactCreditCard = info.GetBoolean("_alreadyFetchedContactCollectionViaContactCreditCard");
			_currencyRateCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CurrencyRateCollection)info.GetValue("_currencyRateCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CurrencyRateCollection));
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader");
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader");
			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");
			_customerViewRelatedCollectionViaSalesOrderHeader___ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader___", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___");
			_salesPersonCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesPersonCollection)info.GetValue("_salesPersonCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesPersonCollection));
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader");
			_salesTerritoryCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.SalesTerritoryCollection)info.GetValue("_salesTerritoryCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.SalesTerritoryCollection));
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader");
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader");
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
			switch((CreditCardFieldIndex)fieldIndex)
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
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = (_addressCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = (_addressCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader = (_contactCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedContactCollectionViaContactCreditCard = (_contactCollectionViaContactCreditCard.Count > 0);
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = (_currencyRateCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = (_customerViewRelatedCollectionViaSalesOrderHeader___.Count > 0);
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = (_salesPersonCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = (_salesTerritoryCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CreditCardEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(CreditCardEntity.Relations.ContactCreditCardEntityUsingCreditCardID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaContactCreditCard":
					toReturn.Add(CreditCardEntity.Relations.ContactCreditCardEntityUsingCreditCardID, "CreditCardEntity__", "ContactCreditCard_", JoinHint.None);
					toReturn.Add(ContactCreditCardEntity.Relations.ContactEntityUsingContactID, "ContactCreditCard_", string.Empty, JoinHint.None);
					break;
				case "CurrencyRateCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader___":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesPersonCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "SalesTerritoryCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID, "CreditCardEntity__", "SalesOrderHeader_", JoinHint.None);
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
			info.AddValue("_contactCreditCard", (!this.MarkedForDeletion?_contactCreditCard:null));
			info.AddValue("_alwaysFetchContactCreditCard", _alwaysFetchContactCreditCard);
			info.AddValue("_alreadyFetchedContactCreditCard", _alreadyFetchedContactCreditCard);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_addressCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader_", _alwaysFetchAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader_", _alreadyFetchedAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_addressCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader", _alwaysFetchAddressCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader", _alreadyFetchedAddressCollectionViaSalesOrderHeader);
			info.AddValue("_contactCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader", _alwaysFetchContactCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader", _alreadyFetchedContactCollectionViaSalesOrderHeader);
			info.AddValue("_contactCollectionViaContactCreditCard", (!this.MarkedForDeletion?_contactCollectionViaContactCreditCard:null));
			info.AddValue("_alwaysFetchContactCollectionViaContactCreditCard", _alwaysFetchContactCollectionViaContactCreditCard);
			info.AddValue("_alreadyFetchedContactCollectionViaContactCreditCard", _alreadyFetchedContactCollectionViaContactCreditCard);
			info.AddValue("_currencyRateCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_currencyRateCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader", _alwaysFetchCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader", _alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader___", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader___:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___);
			info.AddValue("_salesPersonCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesPersonCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesPersonCollectionViaSalesOrderHeader", _alwaysFetchSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader", _alreadyFetchedSalesPersonCollectionViaSalesOrderHeader);
			info.AddValue("_salesTerritoryCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_salesTerritoryCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader", _alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader", _alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader);
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

				case "ContactCreditCard":
					_alreadyFetchedContactCreditCard = true;
					if(entity!=null)
					{
						this.ContactCreditCard.Add((ContactCreditCardEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
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
				case "ContactCollectionViaSalesOrderHeader":
					_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ContactCollectionViaSalesOrderHeader.Add((ContactEntity)entity);
					}
					break;
				case "ContactCollectionViaContactCreditCard":
					_alreadyFetchedContactCollectionViaContactCreditCard = true;
					if(entity!=null)
					{
						this.ContactCollectionViaContactCreditCard.Add((ContactEntity)entity);
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
				case "CustomerViewRelatedCollectionViaSalesOrderHeader___":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader___.Add((CustomerViewRelatedEntity)entity);
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
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "SalesOrderHeaders":
					base.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_salesOrderHeaders);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID)
		{
			return FetchUsingPK(creditCardID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(creditCardID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(creditCardID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(creditCardID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CreditCardID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CreditCardFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CreditCardFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CreditCardRelations().GetAllRelations();
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
				_contactCreditCard.GetMultiManyToOne(null, this, filter);
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
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, this, null, null, null, null, null, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaContactCreditCard(bool forceFetch)
		{
			return GetMultiContactCollectionViaContactCreditCard(forceFetch, _contactCollectionViaContactCreditCard.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaContactCreditCard || forceFetch || _alwaysFetchContactCollectionViaContactCreditCard) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaContactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaContactCreditCard);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
				_contactCollectionViaContactCreditCard.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaContactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaContactCreditCard.GetMulti(filter, GetRelationsForField("ContactCollectionViaContactCreditCard"));
				_contactCollectionViaContactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaContactCreditCard = true;
			}
			return _contactCollectionViaContactCreditCard;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaContactCreditCard'. These settings will be taken into account
		/// when the property ContactCollectionViaContactCreditCard is requested or GetMultiContactCollectionViaContactCreditCard is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaContactCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaContactCreditCard.SortClauses=sortClauses;
			_contactCollectionViaContactCreditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
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
			CreditCardDAO dao = (CreditCardDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_contactCreditCard.ActiveContext = base.ActiveContext;
			_salesOrderHeaders.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_contactCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_contactCollectionViaContactCreditCard.ActiveContext = base.ActiveContext;
			_currencyRateCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader___.ActiveContext = base.ActiveContext;
			_salesPersonCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_salesTerritoryCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CreditCardDAO dao = (CreditCardDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CreditCardDAO dao = (CreditCardDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CreditCardEntity);
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
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("ContactCollectionViaSalesOrderHeader", _contactCollectionViaSalesOrderHeader);
			toReturn.Add("ContactCollectionViaContactCreditCard", _contactCollectionViaContactCreditCard);
			toReturn.Add("CurrencyRateCollectionViaSalesOrderHeader", _currencyRateCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader___", _customerViewRelatedCollectionViaSalesOrderHeader___);
			toReturn.Add("SalesPersonCollectionViaSalesOrderHeader", _salesPersonCollectionViaSalesOrderHeader);
			toReturn.Add("SalesTerritoryCollectionViaSalesOrderHeader", _salesTerritoryCollectionViaSalesOrderHeader);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="validator">The validator object for this CreditCardEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 creditCardID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(creditCardID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_contactCreditCard = new AW.Data.CollectionClasses.ContactCreditCardCollection(new ContactCreditCardEntityFactory());
			_contactCreditCard.SetContainingEntityInfo(this, "CreditCard");
			_alwaysFetchContactCreditCard = false;
			_alreadyFetchedContactCreditCard = false;
			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeaders.SetContainingEntityInfo(this, "CreditCard");
			_alwaysFetchSalesOrderHeaders = false;
			_alreadyFetchedSalesOrderHeaders = false;
			_addressCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = false;
			_addressCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = false;
			_contactCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaSalesOrderHeader = false;
			_alreadyFetchedContactCollectionViaSalesOrderHeader = false;
			_contactCollectionViaContactCreditCard = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaContactCreditCard = false;
			_alreadyFetchedContactCollectionViaContactCreditCard = false;
			_currencyRateCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CurrencyRateCollection(new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRateCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCurrencyRateCollectionViaSalesOrderHeader = false;
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = false;
			_customerViewRelatedCollectionViaSalesOrderHeader___ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader___ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader___ = false;
			_salesPersonCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesPersonCollection(new SalesPersonEntityFactory());
			_alwaysFetchSalesPersonCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesPersonCollectionViaSalesOrderHeader = false;
			_salesTerritoryCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.SalesTerritoryCollection(new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritoryCollectionViaSalesOrderHeader = false;
			_alreadyFetchedSalesTerritoryCollectionViaSalesOrderHeader = false;
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
			_customProperties.Add("MS_Description", @"Customer credit card information.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CreditCardID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card name.");
			_fieldsCustomProperties.Add("CardType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card number.");
			_fieldsCustomProperties.Add("CardNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card expiration month.");
			_fieldsCustomProperties.Add("ExpMonth", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card expiration year.");
			_fieldsCustomProperties.Add("ExpYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CreditCardFieldIndex.CreditCardID].ForcedCurrentValueWrite(creditCardID);
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
			return DAOFactory.CreateCreditCardDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CreditCardEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CreditCardRelations Relations
		{
			get	{ return new CreditCardRelations(); }
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
					(IEntityRelation)GetRelationsForField("ContactCreditCard")[0], (int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ContactCreditCardEntity, 0, null, null, null, "ContactCreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader"), "ContactCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaContactCreditCard
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.ContactCreditCardEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "ContactCreditCard_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaContactCreditCard"), "ContactCollectionViaContactCreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CurrencyRate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCurrencyRateCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CurrencyRateCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.CurrencyRateEntity, 0, null, null, GetRelationsForField("CurrencyRateCollectionViaSalesOrderHeader"), "CurrencyRateCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader___
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader___"), "CustomerViewRelatedCollectionViaSalesOrderHeader___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesPerson' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesPersonCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesPersonCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.SalesPersonEntity, 0, null, null, GetRelationsForField("SalesPersonCollectionViaSalesOrderHeader"), "SalesPersonCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesTerritory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesTerritoryCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesTerritoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.SalesTerritoryEntity, 0, null, null, GetRelationsForField("SalesTerritoryCollectionViaSalesOrderHeader"), "SalesTerritoryCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CreditCardEntity.Relations.SalesOrderHeaderEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CreditCardEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CreditCardEntity.CustomProperties;}
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
			get { return CreditCardEntity.FieldsCustomProperties;}
		}

		/// <summary> The CreditCardID property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CreditCardID
		{
			get { return (System.Int32)GetValue((int)CreditCardFieldIndex.CreditCardID, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CreditCardID, value, true); }
		}
		/// <summary> The CardType property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Credit card name.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CardType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CardType
		{
			get { return (System.String)GetValue((int)CreditCardFieldIndex.CardType, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CardType, value, true); }
		}
		/// <summary> The CardNumber property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Credit card number.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CardNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CardNumber
		{
			get { return (System.String)GetValue((int)CreditCardFieldIndex.CardNumber, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CardNumber, value, true); }
		}
		/// <summary> The ExpMonth property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Credit card expiration month.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ExpMonth"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte ExpMonth
		{
			get { return (System.Byte)GetValue((int)CreditCardFieldIndex.ExpMonth, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ExpMonth, value, true); }
		}
		/// <summary> The ExpYear property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Credit card expiration year.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ExpYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ExpYear
		{
			get { return (System.Int16)GetValue((int)CreditCardFieldIndex.ExpYear, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ExpYear, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity CreditCard<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CreditCardFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ModifiedDate, value, true); }
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaContactCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaContactCreditCard
		{
			get { return GetMultiContactCollectionViaContactCreditCard(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaContactCreditCard. When set to true, ContactCollectionViaContactCreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaContactCreditCard is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaContactCreditCard(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaContactCreditCard
		{
			get	{ return _alwaysFetchContactCollectionViaContactCreditCard; }
			set	{ _alwaysFetchContactCollectionViaContactCreditCard = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaContactCreditCard already has been fetched. Setting this property to false when ContactCollectionViaContactCreditCard has been fetched
		/// will clear the ContactCollectionViaContactCreditCard collection well. Setting this property to true while ContactCollectionViaContactCreditCard hasn't been fetched disables lazy loading for ContactCollectionViaContactCreditCard</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaContactCreditCard
		{
			get { return _alreadyFetchedContactCollectionViaContactCreditCard;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaContactCreditCard && !value && (_contactCollectionViaContactCreditCard != null))
				{
					_contactCollectionViaContactCreditCard.Clear();
				}
				_alreadyFetchedContactCollectionViaContactCreditCard = value;
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
			get { return (int)AW.Data.EntityType.CreditCardEntity; }
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
