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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (21 + 1));
			InitAddressEntityInfos();
			InitAddressTypeEntityInfos();
			InitContactEntityInfos();
			InitCountryRegionEntityInfos();
			InitCreditCardEntityInfos();
			InitCurrencyEntityInfos();
			InitCurrencyRateEntityInfos();
			InitCustomerEntityInfos();
			InitCustomerAddressEntityInfos();
			InitCustomerViewRelatedEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeAddressEntityInfos();
			InitIndividualEntityInfos();
			InitProductEntityInfos();
			InitSalesOrderDetailEntityInfos();
			InitSalesOrderHeaderEntityInfos();
			InitSalesTerritoryEntityInfos();
			InitShipMethodEntityInfos();
			InitSpecialOfferEntityInfos();
			InitSpecialOfferProductEntityInfos();
			InitStateProvinceEntityInfos();
			InitCustomerViewTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AddressEntity's FieldInfo objects</summary>
		private void InitAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AddressFieldIndex), "AddressEntity");
			this.AddElementFieldInfo("AddressEntity", "AddressID", typeof(System.Int32), true, false, true, false,  (int)AddressFieldIndex.AddressID, 0, 0, 10);
			this.AddElementFieldInfo("AddressEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "AddressLine2", typeof(System.String), false, false, false, true,  (int)AddressFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "City", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "StateProvinceID", typeof(System.Int32), false, true, false, false,  (int)AddressFieldIndex.StateProvinceID, 0, 0, 10);
		}
		/// <summary>Inits AddressTypeEntity's FieldInfo objects</summary>
		private void InitAddressTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AddressTypeFieldIndex), "AddressTypeEntity");
			this.AddElementFieldInfo("AddressTypeEntity", "AddressTypeID", typeof(System.Int32), true, false, true, false,  (int)AddressTypeFieldIndex.AddressTypeID, 0, 0, 10);
			this.AddElementFieldInfo("AddressTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressTypeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("AddressTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AddressTypeFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("AddressTypeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressTypeFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ContactEntity's FieldInfo objects</summary>
		private void InitContactEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ContactFieldIndex), "ContactEntity");
			this.AddElementFieldInfo("ContactEntity", "AdditionalContactInfo", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.AdditionalContactInfo, 2147483647, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "ContactID", typeof(System.Int32), true, false, true, false,  (int)ContactFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("ContactEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)ContactFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("ContactEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "LastName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "NameStyle", typeof(System.Boolean), false, false, false, false,  (int)ContactFieldIndex.NameStyle, 0, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "PasswordHash", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordHash, 128, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "PasswordSalt", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordSalt, 10, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Phone, 25, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ContactFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "Suffix", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("ContactEntity", "Title", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Title, 8, 0, 0);
		}
		/// <summary>Inits CountryRegionEntity's FieldInfo objects</summary>
		private void InitCountryRegionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CountryRegionFieldIndex), "CountryRegionEntity");
			this.AddElementFieldInfo("CountryRegionEntity", "CountryRegionCode", typeof(System.String), true, false, false, false,  (int)CountryRegionFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "Name", typeof(System.String), false, false, false, false,  (int)CountryRegionFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CreditCardEntity's FieldInfo objects</summary>
		private void InitCreditCardEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CreditCardFieldIndex), "CreditCardEntity");
			this.AddElementFieldInfo("CreditCardEntity", "CardNumber", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardNumber, 25, 0, 0);
			this.AddElementFieldInfo("CreditCardEntity", "CardType", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardType, 50, 0, 0);
			this.AddElementFieldInfo("CreditCardEntity", "CreditCardID", typeof(System.Int32), true, false, true, false,  (int)CreditCardFieldIndex.CreditCardID, 0, 0, 10);
			this.AddElementFieldInfo("CreditCardEntity", "ExpMonth", typeof(System.Byte), false, false, false, false,  (int)CreditCardFieldIndex.ExpMonth, 0, 0, 3);
			this.AddElementFieldInfo("CreditCardEntity", "ExpYear", typeof(System.Int16), false, false, false, false,  (int)CreditCardFieldIndex.ExpYear, 0, 0, 5);
			this.AddElementFieldInfo("CreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CurrencyEntity's FieldInfo objects</summary>
		private void InitCurrencyEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CurrencyFieldIndex), "CurrencyEntity");
			this.AddElementFieldInfo("CurrencyEntity", "CurrencyCode", typeof(System.String), true, false, false, false,  (int)CurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyEntity", "Name", typeof(System.String), false, false, false, false,  (int)CurrencyFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CurrencyRateEntity's FieldInfo objects</summary>
		private void InitCurrencyRateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CurrencyRateFieldIndex), "CurrencyRateEntity");
			this.AddElementFieldInfo("CurrencyRateEntity", "AverageRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.AverageRate, 0, 4, 19);
			this.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.CurrencyRateDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateID", typeof(System.Int32), true, false, true, false,  (int)CurrencyRateFieldIndex.CurrencyRateID, 0, 0, 10);
			this.AddElementFieldInfo("CurrencyRateEntity", "EndOfDayRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.EndOfDayRate, 0, 4, 19);
			this.AddElementFieldInfo("CurrencyRateEntity", "FromCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.FromCurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "ToCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.ToCurrencyCode, 3, 0, 0);
		}
		/// <summary>Inits CustomerEntity's FieldInfo objects</summary>
		private void InitCustomerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerFieldIndex), "CustomerEntity");
			this.AddElementFieldInfo("CustomerEntity", "AccountNumber", typeof(System.String), false, false, true, false,  (int)CustomerFieldIndex.AccountNumber, 10, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CustomerID", typeof(System.Int32), true, false, true, false,  (int)CustomerFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerEntity", "CustomerType", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.CustomerType, 1, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.TerritoryID, 0, 0, 10);
		}
		/// <summary>Inits CustomerAddressEntity's FieldInfo objects</summary>
		private void InitCustomerAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerAddressFieldIndex), "CustomerAddressEntity");
			this.AddElementFieldInfo("CustomerAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.AddressID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerAddressEntity", "AddressTypeID", typeof(System.Int32), false, true, false, false,  (int)CustomerAddressFieldIndex.AddressTypeID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerAddressEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CustomerAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerAddressFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits CustomerViewRelatedEntity's FieldInfo objects</summary>
		private void InitCustomerViewRelatedEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerViewRelatedFieldIndex), "CustomerViewRelatedEntity");
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine2", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressType", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressType, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "City", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "CountryRegionName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.CountryRegionName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "CustomerId", typeof(System.Int32), true, false, true, false,  (int)CustomerViewRelatedFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Demographics", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailAddress", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "LastName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "MiddleName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Phone", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Phone, 25, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "StateProvinceName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.StateProvinceName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Suffix", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Title", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Title, 8, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "CurrentFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.CurrentFlag, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "EmployeeID", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Gender", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Gender, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LoginID", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LoginID, 256, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ManagerID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ManagerID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "MaritalStatus", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.MaritalStatus, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "NationalIdnumber", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.NationalIdnumber, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "SalariedFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.SalariedFlag, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "SickLeaveHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.SickLeaveHours, 0, 0, 5);
			this.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Title, 50, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "VacationHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.VacationHours, 0, 0, 5);
		}
		/// <summary>Inits EmployeeAddressEntity's FieldInfo objects</summary>
		private void InitEmployeeAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeAddressFieldIndex), "EmployeeAddressEntity");
			this.AddElementFieldInfo("EmployeeAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.AddressID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeAddressEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeAddressFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits IndividualEntity's FieldInfo objects</summary>
		private void InitIndividualEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IndividualFieldIndex), "IndividualEntity");
			this.AddElementFieldInfo("IndividualEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)IndividualFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("IndividualEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)IndividualFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("IndividualEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)IndividualFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("IndividualEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IndividualFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "Class", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Class, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Color", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Color, 15, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "DaysToManufacture", typeof(System.Int32), false, false, false, false,  (int)ProductFieldIndex.DaysToManufacture, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "DiscontinuedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.DiscontinuedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "FinishedGoodsFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.FinishedGoodsFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.ListPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "MakeFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.MakeFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductID", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductLine", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.ProductLine, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductModelID", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.ProductModelID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductNumber", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductNumber, 25, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductSubcategoryID", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.ProductSubcategoryID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ReorderPoint", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.ReorderPoint, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SafetyStockLevel", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.SafetyStockLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SellEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.SellEndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SellStartDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.SellStartDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Size", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Size, 5, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SizeUnitMeasureCode", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.SizeUnitMeasureCode, 3, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.StandardCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "Style", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Style, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Weight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.Weight, 0, 2, 8);
			this.AddElementFieldInfo("ProductEntity", "WeightUnitMeasureCode", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.WeightUnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits SalesOrderDetailEntity's FieldInfo objects</summary>
		private void InitSalesOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderDetailFieldIndex), "SalesOrderDetailEntity");
			this.AddElementFieldInfo("SalesOrderDetailEntity", "CarrierTrackingNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderDetailFieldIndex.LineTotal, 0, 6, 38);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)SalesOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderDetailFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderDetailID", typeof(System.Int32), true, false, true, false,  (int)SalesOrderDetailFieldIndex.SalesOrderDetailID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderDetailFieldIndex.SalesOrderID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SpecialOfferID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.SpecialOfferID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPriceDiscount", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPriceDiscount, 0, 4, 19);
		}
		/// <summary>Inits SalesOrderHeaderEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderHeaderFieldIndex), "SalesOrderHeaderEntity");
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "AccountNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "BillToAddressID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.BillToAddressID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Comment", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.Comment, 128, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardApprovalCode", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CurrencyRateID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CurrencyRateID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CustomerID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "OnlineOrderFlag", typeof(System.Boolean), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "PurchaseOrderNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderID", typeof(System.Int32), true, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderNumber", typeof(System.String), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesPersonID", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.SalesPersonID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipMethodID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipMethodID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipToAddressID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipToAddressID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.TerritoryID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
		}
		/// <summary>Inits SalesTerritoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTerritoryFieldIndex), "SalesTerritoryEntity");
			this.AddElementFieldInfo("SalesTerritoryEntity", "CostLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "CostYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "CountryRegionCode", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Group", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Group, 50, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "TerritoryID", typeof(System.Int32), true, false, true, false,  (int)SalesTerritoryFieldIndex.TerritoryID, 0, 0, 10);
		}
		/// <summary>Inits ShipMethodEntity's FieldInfo objects</summary>
		private void InitShipMethodEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShipMethodFieldIndex), "ShipMethodEntity");
			this.AddElementFieldInfo("ShipMethodEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShipMethodFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShipMethodFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ShipMethodFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipBase", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipBase, 0, 4, 19);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipMethodID", typeof(System.Int32), true, false, true, false,  (int)ShipMethodFieldIndex.ShipMethodID, 0, 0, 10);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipRate", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipRate, 0, 4, 19);
		}
		/// <summary>Inits SpecialOfferEntity's FieldInfo objects</summary>
		private void InitSpecialOfferEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SpecialOfferFieldIndex), "SpecialOfferEntity");
			this.AddElementFieldInfo("SpecialOfferEntity", "Category", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Category, 50, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Description", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Description, 255, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "DiscountPct", typeof(System.Decimal), false, false, false, false,  (int)SpecialOfferFieldIndex.DiscountPct, 0, 4, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "MaxQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SpecialOfferFieldIndex.MaxQty, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "MinQty", typeof(System.Int32), false, false, false, false,  (int)SpecialOfferFieldIndex.MinQty, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "SpecialOfferID", typeof(System.Int32), true, false, true, false,  (int)SpecialOfferFieldIndex.SpecialOfferID, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Type", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Type, 50, 0, 0);
		}
		/// <summary>Inits SpecialOfferProductEntity's FieldInfo objects</summary>
		private void InitSpecialOfferProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SpecialOfferProductFieldIndex), "SpecialOfferProductEntity");
			this.AddElementFieldInfo("SpecialOfferProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferProductFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferProductFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "SpecialOfferID", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.SpecialOfferID, 0, 0, 10);
		}
		/// <summary>Inits StateProvinceEntity's FieldInfo objects</summary>
		private void InitStateProvinceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StateProvinceFieldIndex), "StateProvinceEntity");
			this.AddElementFieldInfo("StateProvinceEntity", "CountryRegionCode", typeof(System.String), false, true, false, false,  (int)StateProvinceFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "IsOnlyStateProvinceFlag", typeof(System.Boolean), false, false, false, false,  (int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StateProvinceFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "Name", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StateProvinceFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "StateProvinceCode", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.StateProvinceCode, 3, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "StateProvinceID", typeof(System.Int32), true, false, true, false,  (int)StateProvinceFieldIndex.StateProvinceID, 0, 0, 10);
			this.AddElementFieldInfo("StateProvinceEntity", "TerritoryID", typeof(System.Int32), false, true, false, false,  (int)StateProvinceFieldIndex.TerritoryID, 0, 0, 10);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCustomerViewTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerViewFieldIndex), "CustomerViewTypedView");
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressLine1", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressLine2", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressType", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressType, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "City", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "CountryRegionName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.CountryRegionName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)CustomerViewFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewTypedView", "Demographics", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "EmailAddress", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "EmailPromotion", typeof(System.Int32), false, false, true, false, (int)CustomerViewFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewTypedView", "FirstName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "LastName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "MiddleName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Phone", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Phone, 25, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "PostalCode", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "StateProvinceName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.StateProvinceName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Suffix", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Title", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Title, 8, 0, 0);
		}		
	}
}




