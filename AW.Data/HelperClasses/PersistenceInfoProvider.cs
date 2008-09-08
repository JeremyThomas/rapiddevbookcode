///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

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
			base.InitClass((21 + 1));
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
			base.AddElementMapping( "AddressEntity", "AdventureWorks", @"Person", "Address", 8 );
			base.AddElementFieldMapping( "AddressEntity", "AddressId", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AddressEntity", "AddressLine1", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AddressEntity", "AddressLine2", "AddressLine2", true, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AddressEntity", "City", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "AddressEntity", "StateProvinceId", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "AddressEntity", "PostalCode", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "AddressEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			base.AddElementFieldMapping( "AddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits AddressTypeEntity's mappings</summary>
		private void InitAddressTypeEntityMappings()
		{
			base.AddElementMapping( "AddressTypeEntity", "AdventureWorks", @"Person", "AddressType", 4 );
			base.AddElementFieldMapping( "AddressTypeEntity", "AddressTypeId", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AddressTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AddressTypeEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "AddressTypeEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ContactEntity's mappings</summary>
		private void InitContactEntityMappings()
		{
			base.AddElementMapping( "ContactEntity", "AdventureWorks", @"Person", "Contact", 15 );
			base.AddElementFieldMapping( "ContactEntity", "ContactId", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ContactEntity", "NameStyle", "NameStyle", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			base.AddElementFieldMapping( "ContactEntity", "Title", "Title", true, (int)SqlDbType.NVarChar, 8, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ContactEntity", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ContactEntity", "MiddleName", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ContactEntity", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ContactEntity", "Suffix", "Suffix", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ContactEntity", "EmailAddress", "EmailAddress", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ContactEntity", "EmailPromotion", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "ContactEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ContactEntity", "PasswordHash", "PasswordHash", false, (int)SqlDbType.VarChar, 40, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ContactEntity", "PasswordSalt", "PasswordSalt", false, (int)SqlDbType.VarChar, 10, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ContactEntity", "AdditionalContactInfo", "AdditionalContactInfo", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "ContactEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			base.AddElementFieldMapping( "ContactEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
		}
		/// <summary>Inits CountryRegionEntity's mappings</summary>
		private void InitCountryRegionEntityMappings()
		{
			base.AddElementMapping( "CountryRegionEntity", "AdventureWorks", @"Person", "CountryRegion", 3 );
			base.AddElementFieldMapping( "CountryRegionEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CountryRegionEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CountryRegionEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits CreditCardEntity's mappings</summary>
		private void InitCreditCardEntityMappings()
		{
			base.AddElementMapping( "CreditCardEntity", "AdventureWorks", @"Sales", "CreditCard", 6 );
			base.AddElementFieldMapping( "CreditCardEntity", "CreditCardId", "CreditCardID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CreditCardEntity", "CardType", "CardType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CreditCardEntity", "CardNumber", "CardNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CreditCardEntity", "ExpMonth", "ExpMonth", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "CreditCardEntity", "ExpYear", "ExpYear", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			base.AddElementFieldMapping( "CreditCardEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits CurrencyEntity's mappings</summary>
		private void InitCurrencyEntityMappings()
		{
			base.AddElementMapping( "CurrencyEntity", "AdventureWorks", @"Sales", "Currency", 3 );
			base.AddElementFieldMapping( "CurrencyEntity", "CurrencyCode", "CurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CurrencyEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CurrencyEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits CurrencyRateEntity's mappings</summary>
		private void InitCurrencyRateEntityMappings()
		{
			base.AddElementMapping( "CurrencyRateEntity", "AdventureWorks", @"Sales", "CurrencyRate", 7 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "CurrencyRateId", "CurrencyRateID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "CurrencyRateDate", "CurrencyRateDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "FromCurrencyCode", "FromCurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "ToCurrencyCode", "ToCurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "AverageRate", "AverageRate", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "EndOfDayRate", "EndOfDayRate", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "CurrencyRateEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			base.AddElementMapping( "CustomerEntity", "AdventureWorks", @"Sales", "Customer", 6 );
			base.AddElementFieldMapping( "CustomerEntity", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerEntity", "TerritoryId", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "CustomerEntity", "AccountNumber", "AccountNumber", false, (int)SqlDbType.VarChar, 10, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CustomerEntity", "CustomerType", "CustomerType", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CustomerEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "CustomerEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits CustomerAddressEntity's mappings</summary>
		private void InitCustomerAddressEntityMappings()
		{
			base.AddElementMapping( "CustomerAddressEntity", "AdventureWorks", @"Sales", "CustomerAddress", 5 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "AddressId", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "AddressTypeId", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits CustomerViewRelatedEntity's mappings</summary>
		private void InitCustomerViewRelatedEntityMappings()
		{
			base.AddElementMapping( "CustomerViewRelatedEntity", "AdventureWorks", @"Sales", "vIndividualCustomer", 17 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "Title", "Title", false, (int)SqlDbType.NVarChar, 8, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "MiddleName", "MiddleName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "Suffix", "Suffix", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "Phone", "Phone", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "EmailAddress", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "EmailPromotion", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressType", "AddressType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressLine1", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "AddressLine2", "AddressLine2", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "City", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "StateProvinceName", "StateProvinceName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "PostalCode", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "CountryRegionName", "CountryRegionName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "CustomerViewRelatedEntity", "Demographics", "Demographics", false, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 16 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			base.AddElementMapping( "EmployeeEntity", "AdventureWorks", @"HumanResources", "Employee", 16 );
			base.AddElementFieldMapping( "EmployeeEntity", "EmployeeId", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeEntity", "NationalIdnumber", "NationalIDNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "EmployeeEntity", "ContactId", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "EmployeeEntity", "LoginId", "LoginID", false, (int)SqlDbType.NVarChar, 256, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "EmployeeEntity", "ManagerId", "ManagerID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "EmployeeEntity", "Title", "Title", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "EmployeeEntity", "BirthDate", "BirthDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "EmployeeEntity", "MaritalStatus", "MaritalStatus", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "EmployeeEntity", "Gender", "Gender", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "EmployeeEntity", "HireDate", "HireDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			base.AddElementFieldMapping( "EmployeeEntity", "SalariedFlag", "SalariedFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			base.AddElementFieldMapping( "EmployeeEntity", "VacationHours", "VacationHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 11 );
			base.AddElementFieldMapping( "EmployeeEntity", "SickLeaveHours", "SickLeaveHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 12 );
			base.AddElementFieldMapping( "EmployeeEntity", "CurrentFlag", "CurrentFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 13 );
			base.AddElementFieldMapping( "EmployeeEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 14 );
			base.AddElementFieldMapping( "EmployeeEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
		}
		/// <summary>Inits EmployeeAddressEntity's mappings</summary>
		private void InitEmployeeAddressEntityMappings()
		{
			base.AddElementMapping( "EmployeeAddressEntity", "AdventureWorks", @"HumanResources", "EmployeeAddress", 4 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "EmployeeId", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "AddressId", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits IndividualEntity's mappings</summary>
		private void InitIndividualEntityMappings()
		{
			base.AddElementMapping( "IndividualEntity", "AdventureWorks", @"Sales", "Individual", 4 );
			base.AddElementFieldMapping( "IndividualEntity", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "IndividualEntity", "ContactId", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "IndividualEntity", "Demographics", "Demographics", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "IndividualEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			base.AddElementMapping( "ProductEntity", "AdventureWorks", @"Production", "Product", 25 );
			base.AddElementFieldMapping( "ProductEntity", "ProductId", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ProductEntity", "ProductNumber", "ProductNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductEntity", "MakeFlag", "MakeFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "ProductEntity", "FinishedGoodsFlag", "FinishedGoodsFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "ProductEntity", "Color", "Color", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ProductEntity", "SafetyStockLevel", "SafetyStockLevel", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
			base.AddElementFieldMapping( "ProductEntity", "ReorderPoint", "ReorderPoint", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 7 );
			base.AddElementFieldMapping( "ProductEntity", "StandardCost", "StandardCost", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "ProductEntity", "ListPrice", "ListPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "ProductEntity", "Size", "Size", true, (int)SqlDbType.NVarChar, 5, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ProductEntity", "SizeUnitMeasureCode", "SizeUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ProductEntity", "WeightUnitMeasureCode", "WeightUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "ProductEntity", "Weight", "Weight", true, (int)SqlDbType.Decimal, 0, 2, 8, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "ProductEntity", "DaysToManufacture", "DaysToManufacture", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			base.AddElementFieldMapping( "ProductEntity", "ProductLine", "ProductLine", true, (int)SqlDbType.NChar, 2, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "ProductEntity", "Class", "Class", true, (int)SqlDbType.NChar, 2, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "ProductEntity", "Style", "Style", true, (int)SqlDbType.NChar, 2, 0, 0, false, "", null, typeof(System.String), 17 );
			base.AddElementFieldMapping( "ProductEntity", "ProductSubcategoryId", "ProductSubcategoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 18 );
			base.AddElementFieldMapping( "ProductEntity", "ProductModelId", "ProductModelID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 19 );
			base.AddElementFieldMapping( "ProductEntity", "SellStartDate", "SellStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 20 );
			base.AddElementFieldMapping( "ProductEntity", "SellEndDate", "SellEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 21 );
			base.AddElementFieldMapping( "ProductEntity", "DiscontinuedDate", "DiscontinuedDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 22 );
			base.AddElementFieldMapping( "ProductEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 23 );
			base.AddElementFieldMapping( "ProductEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 24 );
		}
		/// <summary>Inits SalesOrderDetailEntity's mappings</summary>
		private void InitSalesOrderDetailEntityMappings()
		{
			base.AddElementMapping( "SalesOrderDetailEntity", "AdventureWorks", @"Sales", "SalesOrderDetail", 11 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderId", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderDetailId", "SalesOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "CarrierTrackingNumber", "CarrierTrackingNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "OrderQty", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "ProductId", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SpecialOfferId", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "UnitPrice", "UnitPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "UnitPriceDiscount", "UnitPriceDiscount", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "LineTotal", "LineTotal", false, (int)SqlDbType.Decimal, 0, 6, 38, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
		}
		/// <summary>Inits SalesOrderHeaderEntity's mappings</summary>
		private void InitSalesOrderHeaderEntityMappings()
		{
			base.AddElementMapping( "SalesOrderHeaderEntity", "AdventureWorks", @"Sales", "SalesOrderHeader", 27 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderId", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 1 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "OrderDate", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "DueDate", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipDate", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Status", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 5 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "OnlineOrderFlag", "OnlineOrderFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderNumber", "SalesOrderNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "PurchaseOrderNumber", "PurchaseOrderNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "AccountNumber", "AccountNumber", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ContactId", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesPersonId", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TerritoryId", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "BillToAddressId", "BillToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipToAddressId", "ShipToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 15 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipMethodId", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 16 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardId", "CreditCardID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 17 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardApprovalCode", "CreditCardApprovalCode", true, (int)SqlDbType.VarChar, 15, 0, 0, false, "", null, typeof(System.String), 18 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CurrencyRateId", "CurrencyRateID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 19 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SubTotal", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TaxAmt", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Freight", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TotalDue", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 23 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Comment", "Comment", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 25 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 26 );
		}
		/// <summary>Inits SalesTerritoryEntity's mappings</summary>
		private void InitSalesTerritoryEntityMappings()
		{
			base.AddElementMapping( "SalesTerritoryEntity", "AdventureWorks", @"Sales", "SalesTerritory", 10 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "TerritoryId", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "Group", "Group", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "SalesYtd", "SalesYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "SalesLastYear", "SalesLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "CostYtd", "CostYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "CostLastYear", "CostLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 8 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
		}
		/// <summary>Inits ShipMethodEntity's mappings</summary>
		private void InitShipMethodEntityMappings()
		{
			base.AddElementMapping( "ShipMethodEntity", "AdventureWorks", @"Purchasing", "ShipMethod", 6 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipMethodId", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ShipMethodEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipBase", "ShipBase", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipRate", "ShipRate", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "ShipMethodEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits SpecialOfferEntity's mappings</summary>
		private void InitSpecialOfferEntityMappings()
		{
			base.AddElementMapping( "SpecialOfferEntity", "AdventureWorks", @"Sales", "SpecialOffer", 11 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "SpecialOfferId", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "Description", "Description", false, (int)SqlDbType.NVarChar, 255, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "DiscountPct", "DiscountPct", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "Type", "Type", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "Category", "Category", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "EndDate", "EndDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "MinQty", "MinQty", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "MaxQty", "MaxQty", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 9 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
		}
		/// <summary>Inits SpecialOfferProductEntity's mappings</summary>
		private void InitSpecialOfferProductEntityMappings()
		{
			base.AddElementMapping( "SpecialOfferProductEntity", "AdventureWorks", @"Sales", "SpecialOfferProduct", 4 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "SpecialOfferId", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "ProductId", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits StateProvinceEntity's mappings</summary>
		private void InitStateProvinceEntityMappings()
		{
			base.AddElementMapping( "StateProvinceEntity", "AdventureWorks", @"Person", "StateProvince", 8 );
			base.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceId", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceCode", "StateProvinceCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "StateProvinceEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "StateProvinceEntity", "IsOnlyStateProvinceFlag", "IsOnlyStateProvinceFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "StateProvinceEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "StateProvinceEntity", "TerritoryId", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "StateProvinceEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			base.AddElementFieldMapping( "StateProvinceEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}

		/// <summary>Inits View's mappings</summary>
		private void InitCustomerViewTypedViewMappings()
		{
			base.AddElementMapping( "CustomerViewTypedView", "AdventureWorks", @"Sales", "vIndividualCustomer", 17 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "CustomerId", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "Title", "Title", false, (int)SqlDbType.NVarChar, 8, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "MiddleName", "MiddleName", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "Suffix", "Suffix", false, (int)SqlDbType.NVarChar, 10, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "Phone", "Phone", false, (int)SqlDbType.NVarChar, 25, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "EmailAddress", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "EmailPromotion", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "AddressType", "AddressType", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "AddressLine1", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "AddressLine2", "AddressLine2", false, (int)SqlDbType.NVarChar, 60, 0, 0,false, string.Empty, null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "City", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0,false, string.Empty, null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "StateProvinceName", "StateProvinceName", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "PostalCode", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0,false, string.Empty, null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "CountryRegionName", "CountryRegionName", false, (int)SqlDbType.NVarChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "CustomerViewTypedView", "Demographics", "Demographics", false, (int)SqlDbType.Xml, 2147483647, 0, 0,false, string.Empty, null, typeof(System.String), 16 );
		}
	}
}