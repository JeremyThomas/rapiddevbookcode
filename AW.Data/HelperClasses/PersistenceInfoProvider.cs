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
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((21 + 1));
			InitAddressEntityMappings();
			InitAddressTypeEntityMappings();
			InitContactEntityMappings();
			InitCountryRegionEntityMappings();
			InitCreditCardEntityMappings();
			InitCurrencyEntityMappings();
			InitCurrencyRateEntityMappings();
			InitCustomerEntityMappings();
			InitCustomerAddressEntityMappings();
			InitCustomerViewRelatedEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeAddressEntityMappings();
			InitIndividualEntityMappings();
			InitProductEntityMappings();
			InitSalesOrderDetailEntityMappings();
			InitSalesOrderHeaderEntityMappings();
			InitSalesTerritoryEntityMappings();
			InitShipMethodEntityMappings();
			InitSpecialOfferEntityMappings();
			InitSpecialOfferProductEntityMappings();
			InitStateProvinceEntityMappings();
			InitCustomerViewTypedViewMappings();
		}


		/// <summary>Inits AddressEntity's mappings</summary>
		private void InitAddressEntityMappings()
		{
			this.AddElementMapping( "AddressEntity", "AdventureWorks", @"Person", "Address", 8 );
			this.AddElementFieldMapping( "AddressEntity", "AddressID", "AddressID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "AddressEntity", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AddressEntity", "AddressLine2", "AddressLine2", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AddressEntity", "City", "City", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "AddressEntity", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "AddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "AddressEntity", "StateProvinceID", "StateProvinceID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
		}
		/// <summary>Inits AddressTypeEntity's mappings</summary>
		private void InitAddressTypeEntityMappings()
		{
			this.AddElementMapping( "AddressTypeEntity", "AdventureWorks", @"Person", "AddressType", 4 );
			this.AddElementFieldMapping( "AddressTypeEntity", "AddressTypeID", "AddressTypeID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "AddressTypeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "AddressTypeEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AddressTypeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
		}
		/// <summary>Inits ContactEntity's mappings</summary>
		private void InitContactEntityMappings()
		{
			this.AddElementMapping( "ContactEntity", "AdventureWorks", @"Person", "Contact", 15 );
			this.AddElementFieldMapping( "ContactEntity", "AdditionalContactInfo", "AdditionalContactInfo", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ContactEntity", "ContactID", "ContactID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "ContactEntity", "EmailAddress", "EmailAddress", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ContactEntity", "EmailPromotion", "EmailPromotion", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "ContactEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ContactEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "ContactEntity", "MiddleName", "MiddleName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "ContactEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "ContactEntity", "NameStyle", "NameStyle", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "ContactEntity", "PasswordHash", "PasswordHash", false, "VarChar", 128, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "ContactEntity", "PasswordSalt", "PasswordSalt", false, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "ContactEntity", "Phone", "Phone", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "ContactEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12 );
			this.AddElementFieldMapping( "ContactEntity", "Suffix", "Suffix", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "ContactEntity", "Title", "Title", true, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 14 );
		}
		/// <summary>Inits CountryRegionEntity's mappings</summary>
		private void InitCountryRegionEntityMappings()
		{
			this.AddElementMapping( "CountryRegionEntity", "AdventureWorks", @"Person", "CountryRegion", 3 );
			this.AddElementFieldMapping( "CountryRegionEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CountryRegionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "CountryRegionEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits CreditCardEntity's mappings</summary>
		private void InitCreditCardEntityMappings()
		{
			this.AddElementMapping( "CreditCardEntity", "AdventureWorks", @"Sales", "CreditCard", 6 );
			this.AddElementFieldMapping( "CreditCardEntity", "CardNumber", "CardNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CreditCardEntity", "CardType", "CardType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CreditCardEntity", "CreditCardID", "CreditCardID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "CreditCardEntity", "ExpMonth", "ExpMonth", false, "TinyInt", 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			this.AddElementFieldMapping( "CreditCardEntity", "ExpYear", "ExpYear", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "CreditCardEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits CurrencyEntity's mappings</summary>
		private void InitCurrencyEntityMappings()
		{
			this.AddElementMapping( "CurrencyEntity", "AdventureWorks", @"Sales", "Currency", 3 );
			this.AddElementFieldMapping( "CurrencyEntity", "CurrencyCode", "CurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CurrencyEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "CurrencyEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits CurrencyRateEntity's mappings</summary>
		private void InitCurrencyRateEntityMappings()
		{
			this.AddElementMapping( "CurrencyRateEntity", "AdventureWorks", @"Sales", "CurrencyRate", 7 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "AverageRate", "AverageRate", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 0 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "CurrencyRateDate", "CurrencyRateDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "CurrencyRateID", "CurrencyRateID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "EndOfDayRate", "EndOfDayRate", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "FromCurrencyCode", "FromCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "CurrencyRateEntity", "ToCurrencyCode", "ToCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping( "CustomerEntity", "AdventureWorks", @"Sales", "Customer", 6 );
			this.AddElementFieldMapping( "CustomerEntity", "AccountNumber", "AccountNumber", false, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerEntity", "CustomerID", "CustomerID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "CustomerEntity", "CustomerType", "CustomerType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "CustomerEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "CustomerEntity", "TerritoryID", "TerritoryID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits CustomerAddressEntity's mappings</summary>
		private void InitCustomerAddressEntityMappings()
		{
			this.AddElementMapping( "CustomerAddressEntity", "AdventureWorks", @"Sales", "CustomerAddress", 5 );
			this.AddElementFieldMapping( "CustomerAddressEntity", "AddressID", "AddressID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CustomerAddressEntity", "AddressTypeID", "AddressTypeID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "CustomerAddressEntity", "CustomerID", "CustomerID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "CustomerAddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "CustomerAddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
		}
		/// <summary>Inits CustomerViewRelatedEntity's mappings</summary>
		private void InitCustomerViewRelatedEntityMappings()
		{
			this.AddElementMapping( "CustomerViewRelatedEntity", "AdventureWorks", @"Sales", "vIndividualCustomer", 17 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressLine2", "AddressLine2", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressType", "AddressType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "City", "City", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "CountryRegionName", "CountryRegionName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "CustomerId", "CustomerID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "Demographics", "Demographics", false, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "EmailAddress", "EmailAddress", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "EmailPromotion", "EmailPromotion", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "MiddleName", "MiddleName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "Phone", "Phone", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "StateProvinceName", "StateProvinceName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "Suffix", "Suffix", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "CustomerViewRelatedEntity", "Title", "Title", false, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 16 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping( "EmployeeEntity", "AdventureWorks", @"HumanResources", "Employee", 16 );
			this.AddElementFieldMapping( "EmployeeEntity", "BirthDate", "BirthDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "EmployeeEntity", "ContactID", "ContactID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "EmployeeEntity", "CurrentFlag", "CurrentFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "EmployeeEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "EmployeeEntity", "Gender", "Gender", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "EmployeeEntity", "HireDate", "HireDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "EmployeeEntity", "LoginID", "LoginID", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "EmployeeEntity", "ManagerID", "ManagerID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			this.AddElementFieldMapping( "EmployeeEntity", "MaritalStatus", "MaritalStatus", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "EmployeeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			this.AddElementFieldMapping( "EmployeeEntity", "NationalIdnumber", "NationalIDNumber", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "EmployeeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 11 );
			this.AddElementFieldMapping( "EmployeeEntity", "SalariedFlag", "SalariedFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 12 );
			this.AddElementFieldMapping( "EmployeeEntity", "SickLeaveHours", "SickLeaveHours", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 13 );
			this.AddElementFieldMapping( "EmployeeEntity", "Title", "Title", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "EmployeeEntity", "VacationHours", "VacationHours", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 15 );
		}
		/// <summary>Inits EmployeeAddressEntity's mappings</summary>
		private void InitEmployeeAddressEntityMappings()
		{
			this.AddElementMapping( "EmployeeAddressEntity", "AdventureWorks", @"HumanResources", "EmployeeAddress", 4 );
			this.AddElementFieldMapping( "EmployeeAddressEntity", "AddressID", "AddressID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "EmployeeAddressEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "EmployeeAddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "EmployeeAddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
		}
		/// <summary>Inits IndividualEntity's mappings</summary>
		private void InitIndividualEntityMappings()
		{
			this.AddElementMapping( "IndividualEntity", "AdventureWorks", @"Sales", "Individual", 4 );
			this.AddElementFieldMapping( "IndividualEntity", "ContactID", "ContactID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "IndividualEntity", "CustomerID", "CustomerID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "IndividualEntity", "Demographics", "Demographics", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "IndividualEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping( "ProductEntity", "AdventureWorks", @"Production", "Product", 25 );
			this.AddElementFieldMapping( "ProductEntity", "Class", "Class", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ProductEntity", "Color", "Color", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ProductEntity", "DaysToManufacture", "DaysToManufacture", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ProductEntity", "DiscontinuedDate", "DiscontinuedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "ProductEntity", "FinishedGoodsFlag", "FinishedGoodsFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "ProductEntity", "ListPrice", "ListPrice", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
			this.AddElementFieldMapping( "ProductEntity", "MakeFlag", "MakeFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "ProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "ProductEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "ProductEntity", "ProductID", "ProductID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9 );
			this.AddElementFieldMapping( "ProductEntity", "ProductLine", "ProductLine", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "ProductEntity", "ProductModelID", "ProductModelID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			this.AddElementFieldMapping( "ProductEntity", "ProductNumber", "ProductNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "ProductEntity", "ProductSubcategoryID", "ProductSubcategoryID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			this.AddElementFieldMapping( "ProductEntity", "ReorderPoint", "ReorderPoint", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 14 );
			this.AddElementFieldMapping( "ProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15 );
			this.AddElementFieldMapping( "ProductEntity", "SafetyStockLevel", "SafetyStockLevel", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 16 );
			this.AddElementFieldMapping( "ProductEntity", "SellEndDate", "SellEndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			this.AddElementFieldMapping( "ProductEntity", "SellStartDate", "SellStartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 18 );
			this.AddElementFieldMapping( "ProductEntity", "Size", "Size", true, "NVarChar", 5, 0, 0, false, "", null, typeof(System.String), 19 );
			this.AddElementFieldMapping( "ProductEntity", "SizeUnitMeasureCode", "SizeUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 20 );
			this.AddElementFieldMapping( "ProductEntity", "StandardCost", "StandardCost", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 21 );
			this.AddElementFieldMapping( "ProductEntity", "Style", "Style", true, "NChar", 2, 0, 0, false, "", null, typeof(System.String), 22 );
			this.AddElementFieldMapping( "ProductEntity", "Weight", "Weight", true, "Decimal", 0, 2, 8, false, "", null, typeof(System.Decimal), 23 );
			this.AddElementFieldMapping( "ProductEntity", "WeightUnitMeasureCode", "WeightUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 24 );
		}
		/// <summary>Inits SalesOrderDetailEntity's mappings</summary>
		private void InitSalesOrderDetailEntityMappings()
		{
			this.AddElementMapping( "SalesOrderDetailEntity", "AdventureWorks", @"Sales", "SalesOrderDetail", 11 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "CarrierTrackingNumber", "CarrierTrackingNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "LineTotal", "LineTotal", false, "Decimal", 0, 6, 38, false, "", null, typeof(System.Decimal), 1 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "OrderQty", "OrderQty", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "ProductID", "ProductID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderDetailID", "SalesOrderDetailID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderID", "SalesOrderID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 9 );
			this.AddElementFieldMapping( "SalesOrderDetailEntity", "UnitPriceDiscount", "UnitPriceDiscount", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 10 );
		}
		/// <summary>Inits SalesOrderHeaderEntity's mappings</summary>
		private void InitSalesOrderHeaderEntityMappings()
		{
			this.AddElementMapping( "SalesOrderHeaderEntity", "AdventureWorks", @"Sales", "SalesOrderHeader", 27 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "AccountNumber", "AccountNumber", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "BillToAddressID", "BillToAddressID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "Comment", "Comment", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "ContactID", "ContactID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardApprovalCode", "CreditCardApprovalCode", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardID", "CreditCardID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "CurrencyRateID", "CurrencyRateID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "CustomerID", "CustomerID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "Freight", "Freight", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 9 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "OnlineOrderFlag", "OnlineOrderFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "PurchaseOrderNumber", "PurchaseOrderNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, "TinyInt", 0, 0, 3, false, "", null, typeof(System.Byte), 14 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderID", "SalesOrderID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 16 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderNumber", "SalesOrderNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesPersonID", "SalesPersonID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 18 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipDate", "ShipDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 19 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipMethodID", "ShipMethodID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 20 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipToAddressID", "ShipToAddressID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 21 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "Status", "Status", false, "TinyInt", 0, 0, 3, false, "", null, typeof(System.Byte), 22 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "SubTotal", "SubTotal", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 23 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "TaxAmt", "TaxAmt", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 24 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "TerritoryID", "TerritoryID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 25 );
			this.AddElementFieldMapping( "SalesOrderHeaderEntity", "TotalDue", "TotalDue", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 26 );
		}
		/// <summary>Inits SalesTerritoryEntity's mappings</summary>
		private void InitSalesTerritoryEntityMappings()
		{
			this.AddElementMapping( "SalesTerritoryEntity", "AdventureWorks", @"Sales", "SalesTerritory", 10 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "CostLastYear", "CostLastYear", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 0 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "CostYtd", "CostYTD", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 1 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "Group", "Group", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "SalesLastYear", "SalesLastYear", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "SalesYtd", "SalesYTD", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 8 );
			this.AddElementFieldMapping( "SalesTerritoryEntity", "TerritoryID", "TerritoryID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9 );
		}
		/// <summary>Inits ShipMethodEntity's mappings</summary>
		private void InitShipMethodEntityMappings()
		{
			this.AddElementMapping( "ShipMethodEntity", "AdventureWorks", @"Purchasing", "ShipMethod", 6 );
			this.AddElementFieldMapping( "ShipMethodEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "ShipMethodEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ShipMethodEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "ShipMethodEntity", "ShipBase", "ShipBase", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			this.AddElementFieldMapping( "ShipMethodEntity", "ShipMethodID", "ShipMethodID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "ShipMethodEntity", "ShipRate", "ShipRate", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
		}
		/// <summary>Inits SpecialOfferEntity's mappings</summary>
		private void InitSpecialOfferEntityMappings()
		{
			this.AddElementMapping( "SpecialOfferEntity", "AdventureWorks", @"Sales", "SpecialOffer", 11 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "Category", "Category", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "Description", "Description", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "DiscountPct", "DiscountPct", false, "SmallMoney", 0, 4, 10, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "EndDate", "EndDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "MaxQty", "MaxQty", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "MinQty", "MinQty", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			this.AddElementFieldMapping( "SpecialOfferEntity", "Type", "Type", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits SpecialOfferProductEntity's mappings</summary>
		private void InitSpecialOfferProductEntityMappings()
		{
			this.AddElementMapping( "SpecialOfferProductEntity", "AdventureWorks", @"Sales", "SpecialOfferProduct", 4 );
			this.AddElementFieldMapping( "SpecialOfferProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "SpecialOfferProductEntity", "ProductID", "ProductID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "SpecialOfferProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "SpecialOfferProductEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
		}
		/// <summary>Inits StateProvinceEntity's mappings</summary>
		private void InitStateProvinceEntityMappings()
		{
			this.AddElementMapping( "StateProvinceEntity", "AdventureWorks", @"Person", "StateProvince", 8 );
			this.AddElementFieldMapping( "StateProvinceEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "StateProvinceEntity", "IsOnlyStateProvinceFlag", "IsOnlyStateProvinceFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "StateProvinceEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "StateProvinceEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "StateProvinceEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			this.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceCode", "StateProvinceCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceID", "StateProvinceID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "StateProvinceEntity", "TerritoryID", "TerritoryID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
		}

		/// <summary>Inits View's mappings</summary>
		private void InitCustomerViewTypedViewMappings()
		{
			this.AddElementMapping( "CustomerViewTypedView", "AdventureWorks", @"Sales", "vIndividualCustomer", 17 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "AddressLine2", "AddressLine2", false, "NVarChar", 60, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "AddressType", "AddressType", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "City", "City", false, "NVarChar", 30, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "CountryRegionName", "CountryRegionName", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "CustomerId", "CustomerID", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "Demographics", "Demographics", false, "Xml", 2147483647, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "EmailAddress", "EmailAddress", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "EmailPromotion", "EmailPromotion", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "LastName", "LastName", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "MiddleName", "MiddleName", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "Phone", "Phone", false, "NVarChar", 25, 0, 0,false, string.Empty, null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "StateProvinceName", "StateProvinceName", false, "NVarChar", 50, 0, 0,false, string.Empty, null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "Suffix", "Suffix", false, "NVarChar", 10, 0, 0,false, string.Empty, null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "CustomerViewTypedView", "Title", "Title", false, "NVarChar", 8, 0, 0,false, string.Empty, null, typeof(System.String), 16 );
		}
	}
}