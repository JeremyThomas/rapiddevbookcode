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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

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
			base.InitClass( (21 + 1));
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
			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AddressEntity's FieldInfo objects</summary>
		private void InitAddressEntityInfos()
		{
			base.AddElementFieldInfo("AddressEntity", "AddressId", typeof(System.Int32), true, false, true, false,  (int)AddressFieldIndex.AddressId, 0, 0, 10);
			base.AddElementFieldInfo("AddressEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.AddressLine1, 60, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "AddressLine2", typeof(System.String), false, false, false, true,  (int)AddressFieldIndex.AddressLine2, 60, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "City", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.City, 30, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "StateProvinceId", typeof(System.Int32), false, true, false, false,  (int)AddressFieldIndex.StateProvinceId, 0, 0, 10);
			base.AddElementFieldInfo("AddressEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.PostalCode, 15, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits AddressTypeEntity's FieldInfo objects</summary>
		private void InitAddressTypeEntityInfos()
		{
			base.AddElementFieldInfo("AddressTypeEntity", "AddressTypeId", typeof(System.Int32), true, false, true, false,  (int)AddressTypeFieldIndex.AddressTypeId, 0, 0, 10);
			base.AddElementFieldInfo("AddressTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AddressTypeFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("AddressTypeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressTypeFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("AddressTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressTypeFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ContactEntity's FieldInfo objects</summary>
		private void InitContactEntityInfos()
		{
			base.AddElementFieldInfo("ContactEntity", "ContactId", typeof(System.Int32), true, false, true, false,  (int)ContactFieldIndex.ContactId, 0, 0, 10);
			base.AddElementFieldInfo("ContactEntity", "NameStyle", typeof(System.Boolean), false, false, false, false,  (int)ContactFieldIndex.NameStyle, 0, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Title", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Title, 8, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "LastName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Suffix", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Suffix, 10, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.EmailAddress, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)ContactFieldIndex.EmailPromotion, 0, 0, 10);
			base.AddElementFieldInfo("ContactEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Phone, 25, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "PasswordHash", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordHash, 40, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "PasswordSalt", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordSalt, 10, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "AdditionalContactInfo", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.AdditionalContactInfo, 2147483647, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ContactFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CountryRegionEntity's FieldInfo objects</summary>
		private void InitCountryRegionEntityInfos()
		{
			base.AddElementFieldInfo("CountryRegionEntity", "CountryRegionCode", typeof(System.String), true, false, false, false,  (int)CountryRegionFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("CountryRegionEntity", "Name", typeof(System.String), false, false, false, false,  (int)CountryRegionFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("CountryRegionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CreditCardEntity's FieldInfo objects</summary>
		private void InitCreditCardEntityInfos()
		{
			base.AddElementFieldInfo("CreditCardEntity", "CreditCardId", typeof(System.Int32), true, false, true, false,  (int)CreditCardFieldIndex.CreditCardId, 0, 0, 10);
			base.AddElementFieldInfo("CreditCardEntity", "CardType", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardType, 50, 0, 0);
			base.AddElementFieldInfo("CreditCardEntity", "CardNumber", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardNumber, 25, 0, 0);
			base.AddElementFieldInfo("CreditCardEntity", "ExpMonth", typeof(System.Byte), false, false, false, false,  (int)CreditCardFieldIndex.ExpMonth, 0, 0, 3);
			base.AddElementFieldInfo("CreditCardEntity", "ExpYear", typeof(System.Int16), false, false, false, false,  (int)CreditCardFieldIndex.ExpYear, 0, 0, 5);
			base.AddElementFieldInfo("CreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CurrencyEntity's FieldInfo objects</summary>
		private void InitCurrencyEntityInfos()
		{
			base.AddElementFieldInfo("CurrencyEntity", "CurrencyCode", typeof(System.String), true, false, false, false,  (int)CurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			base.AddElementFieldInfo("CurrencyEntity", "Name", typeof(System.String), false, false, false, false,  (int)CurrencyFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("CurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CurrencyRateEntity's FieldInfo objects</summary>
		private void InitCurrencyRateEntityInfos()
		{
			base.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateId", typeof(System.Int32), true, false, true, false,  (int)CurrencyRateFieldIndex.CurrencyRateId, 0, 0, 10);
			base.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.CurrencyRateDate, 0, 0, 0);
			base.AddElementFieldInfo("CurrencyRateEntity", "FromCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.FromCurrencyCode, 3, 0, 0);
			base.AddElementFieldInfo("CurrencyRateEntity", "ToCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.ToCurrencyCode, 3, 0, 0);
			base.AddElementFieldInfo("CurrencyRateEntity", "AverageRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.AverageRate, 0, 4, 19);
			base.AddElementFieldInfo("CurrencyRateEntity", "EndOfDayRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.EndOfDayRate, 0, 4, 19);
			base.AddElementFieldInfo("CurrencyRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CustomerEntity's FieldInfo objects</summary>
		private void InitCustomerEntityInfos()
		{
			base.AddElementFieldInfo("CustomerEntity", "CustomerId", typeof(System.Int32), true, false, true, false,  (int)CustomerFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerEntity", "TerritoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.TerritoryId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerEntity", "AccountNumber", typeof(System.String), false, false, true, false,  (int)CustomerFieldIndex.AccountNumber, 10, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "CustomerType", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.CustomerType, 1, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CustomerAddressEntity's FieldInfo objects</summary>
		private void InitCustomerAddressEntityInfos()
		{
			base.AddElementFieldInfo("CustomerAddressEntity", "CustomerId", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerAddressEntity", "AddressId", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.AddressId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerAddressEntity", "AddressTypeId", typeof(System.Int32), false, true, false, false,  (int)CustomerAddressFieldIndex.AddressTypeId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerAddressFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("CustomerAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerAddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CustomerViewRelatedEntity's FieldInfo objects</summary>
		private void InitCustomerViewRelatedEntityInfos()
		{
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "CustomerId", typeof(System.Int32), true, false, true, false,  (int)CustomerViewRelatedFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "Title", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Title, 8, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "MiddleName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "LastName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "Suffix", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Suffix, 10, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "Phone", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Phone, 25, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailAddress", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.EmailAddress, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.EmailPromotion, 0, 0, 10);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressType", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressType, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressLine1, 60, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine2", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressLine2, 60, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "City", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.City, 30, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "StateProvinceName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.StateProvinceName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.PostalCode, 15, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "CountryRegionName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.CountryRegionName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewRelatedEntity", "Demographics", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.Demographics, 2147483647, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			base.AddElementFieldInfo("EmployeeEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "NationalIdnumber", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.NationalIdnumber, 15, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ContactId", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.ContactId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "LoginId", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LoginId, 256, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ManagerId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ManagerId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Title, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "MaritalStatus", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.MaritalStatus, 1, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Gender", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Gender, 1, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "SalariedFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.SalariedFlag, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "VacationHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.VacationHours, 0, 0, 5);
			base.AddElementFieldInfo("EmployeeEntity", "SickLeaveHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.SickLeaveHours, 0, 0, 5);
			base.AddElementFieldInfo("EmployeeEntity", "CurrentFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.CurrentFlag, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeeAddressEntity's FieldInfo objects</summary>
		private void InitEmployeeAddressEntityInfos()
		{
			base.AddElementFieldInfo("EmployeeAddressEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.EmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeAddressEntity", "AddressId", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.AddressId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeAddressFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeAddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits IndividualEntity's FieldInfo objects</summary>
		private void InitIndividualEntityInfos()
		{
			base.AddElementFieldInfo("IndividualEntity", "CustomerId", typeof(System.Int32), true, true, false, false,  (int)IndividualFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("IndividualEntity", "ContactId", typeof(System.Int32), false, true, false, false,  (int)IndividualFieldIndex.ContactId, 0, 0, 10);
			base.AddElementFieldInfo("IndividualEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)IndividualFieldIndex.Demographics, 2147483647, 0, 0);
			base.AddElementFieldInfo("IndividualEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IndividualFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			base.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "ProductNumber", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductNumber, 25, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "MakeFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.MakeFlag, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "FinishedGoodsFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.FinishedGoodsFlag, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Color", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Color, 15, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "SafetyStockLevel", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.SafetyStockLevel, 0, 0, 5);
			base.AddElementFieldInfo("ProductEntity", "ReorderPoint", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.ReorderPoint, 0, 0, 5);
			base.AddElementFieldInfo("ProductEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.StandardCost, 0, 4, 19);
			base.AddElementFieldInfo("ProductEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.ListPrice, 0, 4, 19);
			base.AddElementFieldInfo("ProductEntity", "Size", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Size, 5, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "SizeUnitMeasureCode", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.SizeUnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "WeightUnitMeasureCode", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.WeightUnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Weight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.Weight, 0, 2, 8);
			base.AddElementFieldInfo("ProductEntity", "DaysToManufacture", typeof(System.Int32), false, false, false, false,  (int)ProductFieldIndex.DaysToManufacture, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "ProductLine", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.ProductLine, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Class", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Class, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Style", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Style, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "ProductSubcategoryId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.ProductSubcategoryId, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "ProductModelId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.ProductModelId, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "SellStartDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.SellStartDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "SellEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.SellEndDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "DiscontinuedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.DiscontinuedDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesOrderDetailEntity's FieldInfo objects</summary>
		private void InitSalesOrderDetailEntityInfos()
		{
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderId", typeof(System.Int32), true, true, false, false,  (int)SalesOrderDetailFieldIndex.SalesOrderId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderDetailId", typeof(System.Int32), true, false, true, false,  (int)SalesOrderDetailFieldIndex.SalesOrderDetailId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "CarrierTrackingNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)SalesOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.ProductId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SpecialOfferId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.SpecialOfferId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPriceDiscount", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPriceDiscount, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderDetailFieldIndex.LineTotal, 0, 6, 38);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderDetailFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesOrderHeaderEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderEntityInfos()
		{
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderId", typeof(System.Int32), true, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.DueDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Status, 0, 0, 3);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "OnlineOrderFlag", typeof(System.Boolean), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderNumber", typeof(System.String), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "PurchaseOrderNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "AccountNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.AccountNumber, 15, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CustomerId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ContactId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ContactId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesPersonId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.SalesPersonId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TerritoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.TerritoryId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "BillToAddressId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.BillToAddressId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipToAddressId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipToAddressId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipMethodId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipMethodId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardApprovalCode", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CurrencyRateId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CurrencyRateId, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Freight, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Comment", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.Comment, 128, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesTerritoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryEntityInfos()
		{
			base.AddElementFieldInfo("SalesTerritoryEntity", "TerritoryId", typeof(System.Int32), true, false, true, false,  (int)SalesTerritoryFieldIndex.TerritoryId, 0, 0, 10);
			base.AddElementFieldInfo("SalesTerritoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryEntity", "CountryRegionCode", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryEntity", "Group", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Group, 50, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesYtd, 0, 4, 19);
			base.AddElementFieldInfo("SalesTerritoryEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesLastYear, 0, 4, 19);
			base.AddElementFieldInfo("SalesTerritoryEntity", "CostYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostYtd, 0, 4, 19);
			base.AddElementFieldInfo("SalesTerritoryEntity", "CostLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostLastYear, 0, 4, 19);
			base.AddElementFieldInfo("SalesTerritoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ShipMethodEntity's FieldInfo objects</summary>
		private void InitShipMethodEntityInfos()
		{
			base.AddElementFieldInfo("ShipMethodEntity", "ShipMethodId", typeof(System.Int32), true, false, true, false,  (int)ShipMethodFieldIndex.ShipMethodId, 0, 0, 10);
			base.AddElementFieldInfo("ShipMethodEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShipMethodFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ShipMethodEntity", "ShipBase", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipBase, 0, 4, 19);
			base.AddElementFieldInfo("ShipMethodEntity", "ShipRate", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipRate, 0, 4, 19);
			base.AddElementFieldInfo("ShipMethodEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ShipMethodFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ShipMethodEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShipMethodFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SpecialOfferEntity's FieldInfo objects</summary>
		private void InitSpecialOfferEntityInfos()
		{
			base.AddElementFieldInfo("SpecialOfferEntity", "SpecialOfferId", typeof(System.Int32), true, false, true, false,  (int)SpecialOfferFieldIndex.SpecialOfferId, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferEntity", "Description", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Description, 255, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "DiscountPct", typeof(System.Decimal), false, false, false, false,  (int)SpecialOfferFieldIndex.DiscountPct, 0, 4, 10);
			base.AddElementFieldInfo("SpecialOfferEntity", "Type", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Type, 50, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "Category", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Category, 50, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "MinQty", typeof(System.Int32), false, false, false, false,  (int)SpecialOfferFieldIndex.MinQty, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferEntity", "MaxQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SpecialOfferFieldIndex.MaxQty, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SpecialOfferEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SpecialOfferProductEntity's FieldInfo objects</summary>
		private void InitSpecialOfferProductEntityInfos()
		{
			base.AddElementFieldInfo("SpecialOfferProductEntity", "SpecialOfferId", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.SpecialOfferId, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.ProductId, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferProductFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferProductFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits StateProvinceEntity's FieldInfo objects</summary>
		private void InitStateProvinceEntityInfos()
		{
			base.AddElementFieldInfo("StateProvinceEntity", "StateProvinceId", typeof(System.Int32), true, false, true, false,  (int)StateProvinceFieldIndex.StateProvinceId, 0, 0, 10);
			base.AddElementFieldInfo("StateProvinceEntity", "StateProvinceCode", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.StateProvinceCode, 3, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "CountryRegionCode", typeof(System.String), false, true, false, false,  (int)StateProvinceFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "IsOnlyStateProvinceFlag", typeof(System.Boolean), false, false, false, false,  (int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, 0, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "Name", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "TerritoryId", typeof(System.Int32), false, true, false, false,  (int)StateProvinceFieldIndex.TerritoryId, 0, 0, 10);
			base.AddElementFieldInfo("StateProvinceEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StateProvinceFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StateProvinceFieldIndex.ModifiedDate, 0, 0, 0);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCustomerViewTypedViewInfos()
		{
			base.AddElementFieldInfo("CustomerViewTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)CustomerViewFieldIndex.CustomerId, 0, 0, 10);
			base.AddElementFieldInfo("CustomerViewTypedView", "Title", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Title, 8, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "FirstName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "MiddleName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "LastName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "Suffix", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Suffix, 10, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "Phone", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Phone, 25, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "EmailAddress", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.EmailAddress, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "EmailPromotion", typeof(System.Int32), false, false, true, false, (int)CustomerViewFieldIndex.EmailPromotion, 0, 0, 10);
			base.AddElementFieldInfo("CustomerViewTypedView", "AddressType", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressType, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "AddressLine1", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine1, 60, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "AddressLine2", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine2, 60, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "City", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.City, 30, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "StateProvinceName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.StateProvinceName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "PostalCode", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.PostalCode, 15, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "CountryRegionName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.CountryRegionName, 50, 0, 0);
			base.AddElementFieldInfo("CustomerViewTypedView", "Demographics", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Demographics, 2147483647, 0, 0);
		}		
	}
}




