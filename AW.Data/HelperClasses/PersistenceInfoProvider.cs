///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
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
			this.InitClass(75);
			InitAwbuildVersionEntityMappings();
			InitDatabaseLogEntityMappings();
			InitErrorLogEntityMappings();
			InitDepartmentEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeAddressEntityMappings();
			InitEmployeeDepartmentHistoryEntityMappings();
			InitEmployeePayHistoryEntityMappings();
			InitJobCandidateEntityMappings();
			InitShiftEntityMappings();
			InitAddressEntityMappings();
			InitAddressTypeEntityMappings();
			InitContactEntityMappings();
			InitContactTypeEntityMappings();
			InitCountryRegionEntityMappings();
			InitStateProvinceEntityMappings();
			InitBillOfMaterialEntityMappings();
			InitCultureEntityMappings();
			InitDocumentEntityMappings();
			InitIllustrationEntityMappings();
			InitLocationEntityMappings();
			InitProductEntityMappings();
			InitProductCategoryEntityMappings();
			InitProductCostHistoryEntityMappings();
			InitProductDescriptionEntityMappings();
			InitProductDocumentEntityMappings();
			InitProductInventoryEntityMappings();
			InitProductListPriceHistoryEntityMappings();
			InitProductModelEntityMappings();
			InitProductModelIllustrationEntityMappings();
			InitProductModelProductDescriptionCultureEntityMappings();
			InitProductPhotoEntityMappings();
			InitProductProductPhotoEntityMappings();
			InitProductReviewEntityMappings();
			InitProductSubcategoryEntityMappings();
			InitPurchaseOrderHistoryEntityMappings();
			InitSalesOrderHistoryEntityMappings();
			InitScrapReasonEntityMappings();
			InitTransactionHistoryEntityMappings();
			InitTransactionHistoryArchiveEntityMappings();
			InitUnitMeasureEntityMappings();
			InitWorkOrderEntityMappings();
			InitWorkOrderHistoryEntityMappings();
			InitWorkOrderRoutingEntityMappings();
			InitProductVendorEntityMappings();
			InitPurchaseOrderDetailEntityMappings();
			InitPurchaseOrderHeaderEntityMappings();
			InitShipMethodEntityMappings();
			InitVendorEntityMappings();
			InitVendorAddressEntityMappings();
			InitVendorContactEntityMappings();
			InitContactCreditCardEntityMappings();
			InitCountryRegionCurrencyEntityMappings();
			InitCreditCardEntityMappings();
			InitCurrencyEntityMappings();
			InitCurrencyRateEntityMappings();
			InitCustomerEntityMappings();
			InitCustomerAddressEntityMappings();
			InitCustomerViewRelatedEntityMappings();
			InitIndividualEntityMappings();
			InitSalesOrderDetailEntityMappings();
			InitSalesOrderHeaderEntityMappings();
			InitSalesOrderHeaderSalesReasonEntityMappings();
			InitSalesPersonEntityMappings();
			InitSalesPersonQuotaHistoryEntityMappings();
			InitSalesReasonEntityMappings();
			InitSalesTaxRateEntityMappings();
			InitSalesTerritoryEntityMappings();
			InitSalesTerritoryHistoryEntityMappings();
			InitShoppingCartItemEntityMappings();
			InitSpecialOfferEntityMappings();
			InitSpecialOfferProductEntityMappings();
			InitStoreEntityMappings();
			InitStoreContactEntityMappings();
			InitCustomerViewTypedViewMappings();
		}

		/// <summary>Inits AwbuildVersionEntity's mappings</summary>
		private void InitAwbuildVersionEntityMappings()
		{
			this.AddElementMapping("AwbuildVersionEntity", @"AdventureWorks", @"dbo", "AWBuildVersion", 4);
			this.AddElementFieldMapping("AwbuildVersionEntity", "DatabaseVersion", "Database Version", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("AwbuildVersionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AwbuildVersionEntity", "SystemInformationID", "SystemInformationID", false, "TinyInt", 0, 3, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 2);
			this.AddElementFieldMapping("AwbuildVersionEntity", "VersionDate", "VersionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
		}

		/// <summary>Inits DatabaseLogEntity's mappings</summary>
		private void InitDatabaseLogEntityMappings()
		{
			this.AddElementMapping("DatabaseLogEntity", @"AdventureWorks", @"dbo", "DatabaseLog", 8);
			this.AddElementFieldMapping("DatabaseLogEntity", "DatabaseLogID", "DatabaseLogID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DatabaseLogEntity", "DatabaseUser", "DatabaseUser", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("DatabaseLogEntity", "Event", "Event", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("DatabaseLogEntity", "Object", "Object", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("DatabaseLogEntity", "PostTime", "PostTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("DatabaseLogEntity", "Schema", "Schema", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("DatabaseLogEntity", "Tsql", "TSQL", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("DatabaseLogEntity", "XmlEvent", "XmlEvent", false, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits ErrorLogEntity's mappings</summary>
		private void InitErrorLogEntityMappings()
		{
			this.AddElementMapping("ErrorLogEntity", @"AdventureWorks", @"dbo", "ErrorLog", 9);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorLine", "ErrorLine", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorLogID", "ErrorLogID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorMessage", "ErrorMessage", false, "NVarChar", 4000, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorNumber", "ErrorNumber", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorProcedure", "ErrorProcedure", true, "NVarChar", 126, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorSeverity", "ErrorSeverity", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorState", "ErrorState", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("ErrorLogEntity", "ErrorTime", "ErrorTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ErrorLogEntity", "UserName", "UserName", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits DepartmentEntity's mappings</summary>
		private void InitDepartmentEntityMappings()
		{
			this.AddElementMapping("DepartmentEntity", @"AdventureWorks", @"HumanResources", "Department", 4);
			this.AddElementFieldMapping("DepartmentEntity", "DepartmentID", "DepartmentID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 0);
			this.AddElementFieldMapping("DepartmentEntity", "GroupName", "GroupName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("DepartmentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("DepartmentEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"AdventureWorks", @"HumanResources", "Employee", 16);
			this.AddElementFieldMapping("EmployeeEntity", "BirthDate", "BirthDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("EmployeeEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("EmployeeEntity", "Gender", "Gender", false, "NChar", 1, 0, 0, false, "", new AW.Data.GenderDBConverter(), typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "HireDate", "HireDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("EmployeeEntity", "IsCurrent", "CurrentFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("EmployeeEntity", "IsSalaried", "SalariedFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("EmployeeEntity", "LoginID", "LoginID", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("EmployeeEntity", "ManagerID", "ManagerID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("EmployeeEntity", "MaritalStatus", "MaritalStatus", false, "NChar", 1, 0, 0, false, "", new AW.Data.MaritalStatusDBConverter(), typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("EmployeeEntity", "NationalIdnumber", "NationalIDNumber", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("EmployeeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12);
			this.AddElementFieldMapping("EmployeeEntity", "SickLeaveHours", "SickLeaveHours", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 13);
			this.AddElementFieldMapping("EmployeeEntity", "Title", "Title", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("EmployeeEntity", "VacationHours", "VacationHours", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 15);
		}

		/// <summary>Inits EmployeeAddressEntity's mappings</summary>
		private void InitEmployeeAddressEntityMappings()
		{
			this.AddElementMapping("EmployeeAddressEntity", @"AdventureWorks", @"HumanResources", "EmployeeAddress", 4);
			this.AddElementFieldMapping("EmployeeAddressEntity", "AddressID", "AddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeeAddressEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeAddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("EmployeeAddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits EmployeeDepartmentHistoryEntity's mappings</summary>
		private void InitEmployeeDepartmentHistoryEntityMappings()
		{
			this.AddElementMapping("EmployeeDepartmentHistoryEntity", @"AdventureWorks", @"HumanResources", "EmployeeDepartmentHistory", 6);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "DepartmentID", "DepartmentID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 0);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "ShiftID", "ShiftID", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 4);
			this.AddElementFieldMapping("EmployeeDepartmentHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
		}

		/// <summary>Inits EmployeePayHistoryEntity's mappings</summary>
		private void InitEmployeePayHistoryEntityMappings()
		{
			this.AddElementMapping("EmployeePayHistoryEntity", @"AdventureWorks", @"HumanResources", "EmployeePayHistory", 5);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "PayFrequency", "PayFrequency", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 2);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "Rate", "Rate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("EmployeePayHistoryEntity", "RateChangeDate", "RateChangeDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits JobCandidateEntity's mappings</summary>
		private void InitJobCandidateEntityMappings()
		{
			this.AddElementMapping("JobCandidateEntity", @"AdventureWorks", @"HumanResources", "JobCandidate", 4);
			this.AddElementFieldMapping("JobCandidateEntity", "EmployeeID", "EmployeeID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("JobCandidateEntity", "JobCandidateID", "JobCandidateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("JobCandidateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("JobCandidateEntity", "Resume", "Resume", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits ShiftEntity's mappings</summary>
		private void InitShiftEntityMappings()
		{
			this.AddElementMapping("ShiftEntity", @"AdventureWorks", @"HumanResources", "Shift", 5);
			this.AddElementFieldMapping("ShiftEntity", "EndTime", "EndTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ShiftEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ShiftEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ShiftEntity", "ShiftID", "ShiftID", false, "TinyInt", 0, 3, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 3);
			this.AddElementFieldMapping("ShiftEntity", "StartTime", "StartTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits AddressEntity's mappings</summary>
		private void InitAddressEntityMappings()
		{
			this.AddElementMapping("AddressEntity", @"AdventureWorks", @"Person", "Address", 8);
			this.AddElementFieldMapping("AddressEntity", "AddressID", "AddressID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AddressEntity", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("AddressEntity", "AddressLine2", "AddressLine2", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AddressEntity", "City", "City", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("AddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("AddressEntity", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("AddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6);
			this.AddElementFieldMapping("AddressEntity", "StateProvinceID", "StateProvinceID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
		}

		/// <summary>Inits AddressTypeEntity's mappings</summary>
		private void InitAddressTypeEntityMappings()
		{
			this.AddElementMapping("AddressTypeEntity", @"AdventureWorks", @"Person", "AddressType", 4);
			this.AddElementFieldMapping("AddressTypeEntity", "AddressTypeID", "AddressTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AddressTypeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("AddressTypeEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("AddressTypeEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ContactEntity's mappings</summary>
		private void InitContactEntityMappings()
		{
			this.AddElementMapping("ContactEntity", @"AdventureWorks", @"Person", "Contact", 15);
			this.AddElementFieldMapping("ContactEntity", "AdditionalContactInfo", "AdditionalContactInfo", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ContactEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ContactEntity", "EmailAddress", "EmailAddress", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ContactEntity", "EmailPromotion", "EmailPromotion", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ContactEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ContactEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("ContactEntity", "MiddleName", "MiddleName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("ContactEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ContactEntity", "NameStyle", "NameStyle", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8);
			this.AddElementFieldMapping("ContactEntity", "PasswordHash", "PasswordHash", false, "VarChar", 128, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("ContactEntity", "PasswordSalt", "PasswordSalt", false, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("ContactEntity", "Phone", "Phone", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("ContactEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 12);
			this.AddElementFieldMapping("ContactEntity", "Suffix", "Suffix", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("ContactEntity", "Title", "Title", true, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 14);
		}

		/// <summary>Inits ContactTypeEntity's mappings</summary>
		private void InitContactTypeEntityMappings()
		{
			this.AddElementMapping("ContactTypeEntity", @"AdventureWorks", @"Person", "ContactType", 3);
			this.AddElementFieldMapping("ContactTypeEntity", "ContactTypeID", "ContactTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ContactTypeEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ContactTypeEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CountryRegionEntity's mappings</summary>
		private void InitCountryRegionEntityMappings()
		{
			this.AddElementMapping("CountryRegionEntity", @"AdventureWorks", @"Person", "CountryRegion", 3);
			this.AddElementFieldMapping("CountryRegionEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CountryRegionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CountryRegionEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits StateProvinceEntity's mappings</summary>
		private void InitStateProvinceEntityMappings()
		{
			this.AddElementMapping("StateProvinceEntity", @"AdventureWorks", @"Person", "StateProvince", 8);
			this.AddElementFieldMapping("StateProvinceEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StateProvinceEntity", "IsOnlyStateProvinceFlag", "IsOnlyStateProvinceFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("StateProvinceEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("StateProvinceEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("StateProvinceEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("StateProvinceEntity", "StateProvinceCode", "StateProvinceCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("StateProvinceEntity", "StateProvinceID", "StateProvinceID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("StateProvinceEntity", "TerritoryID", "TerritoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
		}

		/// <summary>Inits BillOfMaterialEntity's mappings</summary>
		private void InitBillOfMaterialEntityMappings()
		{
			this.AddElementMapping("BillOfMaterialEntity", @"AdventureWorks", @"Production", "BillOfMaterials", 9);
			this.AddElementFieldMapping("BillOfMaterialEntity", "BillOfMaterialsID", "BillOfMaterialsID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("BillOfMaterialEntity", "Bomlevel", "BOMLevel", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ComponentID", "ComponentID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("BillOfMaterialEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("BillOfMaterialEntity", "PerAssemblyQuantity", "PerAssemblyQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("BillOfMaterialEntity", "ProductAssemblyID", "ProductAssemblyID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("BillOfMaterialEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("BillOfMaterialEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits CultureEntity's mappings</summary>
		private void InitCultureEntityMappings()
		{
			this.AddElementMapping("CultureEntity", @"AdventureWorks", @"Production", "Culture", 3);
			this.AddElementFieldMapping("CultureEntity", "CultureID", "CultureID", false, "NChar", 6, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CultureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CultureEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits DocumentEntity's mappings</summary>
		private void InitDocumentEntityMappings()
		{
			this.AddElementMapping("DocumentEntity", @"AdventureWorks", @"Production", "Document", 10);
			this.AddElementFieldMapping("DocumentEntity", "ChangeNumber", "ChangeNumber", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DocumentEntity", "Document", "Document", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1);
			this.AddElementFieldMapping("DocumentEntity", "DocumentID", "DocumentID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("DocumentEntity", "DocumentSummary", "DocumentSummary", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("DocumentEntity", "FileExtension", "FileExtension", false, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("DocumentEntity", "FileName", "FileName", false, "NVarChar", 400, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("DocumentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("DocumentEntity", "Revision", "Revision", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("DocumentEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 8);
			this.AddElementFieldMapping("DocumentEntity", "Title", "Title", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 9);
		}

		/// <summary>Inits IllustrationEntity's mappings</summary>
		private void InitIllustrationEntityMappings()
		{
			this.AddElementMapping("IllustrationEntity", @"AdventureWorks", @"Production", "Illustration", 3);
			this.AddElementFieldMapping("IllustrationEntity", "Diagram", "Diagram", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("IllustrationEntity", "IllustrationID", "IllustrationID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("IllustrationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
		}

		/// <summary>Inits LocationEntity's mappings</summary>
		private void InitLocationEntityMappings()
		{
			this.AddElementMapping("LocationEntity", @"AdventureWorks", @"Production", "Location", 5);
			this.AddElementFieldMapping("LocationEntity", "Availability", "Availability", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("LocationEntity", "CostRate", "CostRate", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("LocationEntity", "LocationID", "LocationID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2);
			this.AddElementFieldMapping("LocationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("LocationEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"AdventureWorks", @"Production", "Product", 25);
			this.AddElementFieldMapping("ProductEntity", "Class", "Class", true, "NChar", 2, 0, 0, false, "", new AW.Data.ProductClassDBConverter(), typeof(System.String), 0);
			this.AddElementFieldMapping("ProductEntity", "Color", "Color", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductEntity", "DaysToManufacture", "DaysToManufacture", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductEntity", "DiscontinuedDate", "DiscontinuedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("ProductEntity", "FinishedGoodsFlag", "FinishedGoodsFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4);
			this.AddElementFieldMapping("ProductEntity", "ListPrice", "ListPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("ProductEntity", "MakeFlag", "MakeFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("ProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ProductEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("ProductEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("ProductEntity", "ProductLine", "ProductLine", true, "NChar", 2, 0, 0, false, "", new AW.Data.ProductLineDBConverter(), typeof(System.String), 10);
			this.AddElementFieldMapping("ProductEntity", "ProductModelID", "ProductModelID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
			this.AddElementFieldMapping("ProductEntity", "ProductNumber", "ProductNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("ProductEntity", "ProductSubcategoryID", "ProductSubcategoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 13);
			this.AddElementFieldMapping("ProductEntity", "ReorderPoint", "ReorderPoint", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 14);
			this.AddElementFieldMapping("ProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15);
			this.AddElementFieldMapping("ProductEntity", "SafetyStockLevel", "SafetyStockLevel", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 16);
			this.AddElementFieldMapping("ProductEntity", "SellEndDate", "SellEndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 17);
			this.AddElementFieldMapping("ProductEntity", "SellStartDate", "SellStartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 18);
			this.AddElementFieldMapping("ProductEntity", "Size", "Size", true, "NVarChar", 5, 0, 0, false, "", null, typeof(System.String), 19);
			this.AddElementFieldMapping("ProductEntity", "SizeUnitMeasureCode", "SizeUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 20);
			this.AddElementFieldMapping("ProductEntity", "StandardCost", "StandardCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 21);
			this.AddElementFieldMapping("ProductEntity", "Style", "Style", true, "NChar", 2, 0, 0, false, "", new AW.Data.ProductStyleDBConverter(), typeof(System.String), 22);
			this.AddElementFieldMapping("ProductEntity", "Weight", "Weight", true, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 23);
			this.AddElementFieldMapping("ProductEntity", "WeightUnitMeasureCode", "WeightUnitMeasureCode", true, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 24);
		}

		/// <summary>Inits ProductCategoryEntity's mappings</summary>
		private void InitProductCategoryEntityMappings()
		{
			this.AddElementMapping("ProductCategoryEntity", @"AdventureWorks", @"Production", "ProductCategory", 4);
			this.AddElementFieldMapping("ProductCategoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductCategoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductCategoryEntity", "ProductCategoryID", "ProductCategoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductCategoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ProductCostHistoryEntity's mappings</summary>
		private void InitProductCostHistoryEntityMappings()
		{
			this.AddElementMapping("ProductCostHistoryEntity", @"AdventureWorks", @"Production", "ProductCostHistory", 5);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "StandardCost", "StandardCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("ProductCostHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits ProductDescriptionEntity's mappings</summary>
		private void InitProductDescriptionEntityMappings()
		{
			this.AddElementMapping("ProductDescriptionEntity", @"AdventureWorks", @"Production", "ProductDescription", 4);
			this.AddElementFieldMapping("ProductDescriptionEntity", "Description", "Description", false, "NVarChar", 400, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductDescriptionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductDescriptionEntity", "ProductDescriptionID", "ProductDescriptionID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductDescriptionEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 3);
		}

		/// <summary>Inits ProductDocumentEntity's mappings</summary>
		private void InitProductDocumentEntityMappings()
		{
			this.AddElementMapping("ProductDocumentEntity", @"AdventureWorks", @"Production", "ProductDocument", 3);
			this.AddElementFieldMapping("ProductDocumentEntity", "DocumentID", "DocumentID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductDocumentEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductDocumentEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits ProductInventoryEntity's mappings</summary>
		private void InitProductInventoryEntityMappings()
		{
			this.AddElementMapping("ProductInventoryEntity", @"AdventureWorks", @"Production", "ProductInventory", 7);
			this.AddElementFieldMapping("ProductInventoryEntity", "Bin", "Bin", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 0);
			this.AddElementFieldMapping("ProductInventoryEntity", "LocationID", "LocationID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 1);
			this.AddElementFieldMapping("ProductInventoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductInventoryEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductInventoryEntity", "Quantity", "Quantity", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("ProductInventoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
			this.AddElementFieldMapping("ProductInventoryEntity", "Shelf", "Shelf", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits ProductListPriceHistoryEntity's mappings</summary>
		private void InitProductListPriceHistoryEntityMappings()
		{
			this.AddElementMapping("ProductListPriceHistoryEntity", @"AdventureWorks", @"Production", "ProductListPriceHistory", 5);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ListPrice", "ListPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductListPriceHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
		}

		/// <summary>Inits ProductModelEntity's mappings</summary>
		private void InitProductModelEntityMappings()
		{
			this.AddElementMapping("ProductModelEntity", @"AdventureWorks", @"Production", "ProductModel", 6);
			this.AddElementFieldMapping("ProductModelEntity", "CatalogDescription", "CatalogDescription", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductModelEntity", "Instructions", "Instructions", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductModelEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductModelEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductModelEntity", "ProductModelID", "ProductModelID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductModelEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
		}

		/// <summary>Inits ProductModelIllustrationEntity's mappings</summary>
		private void InitProductModelIllustrationEntityMappings()
		{
			this.AddElementMapping("ProductModelIllustrationEntity", @"AdventureWorks", @"Production", "ProductModelIllustration", 3);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "IllustrationID", "IllustrationID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductModelIllustrationEntity", "ProductModelID", "ProductModelID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits ProductModelProductDescriptionCultureEntity's mappings</summary>
		private void InitProductModelProductDescriptionCultureEntityMappings()
		{
			this.AddElementMapping("ProductModelProductDescriptionCultureEntity", @"AdventureWorks", @"Production", "ProductModelProductDescriptionCulture", 4);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "CultureID", "CultureID", false, "NChar", 6, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ProductDescriptionID", "ProductDescriptionID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductModelProductDescriptionCultureEntity", "ProductModelID", "ProductModelID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits ProductPhotoEntity's mappings</summary>
		private void InitProductPhotoEntityMappings()
		{
			this.AddElementMapping("ProductPhotoEntity", @"AdventureWorks", @"Production", "ProductPhoto", 6);
			this.AddElementFieldMapping("ProductPhotoEntity", "LargePhoto", "LargePhoto", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 0);
			this.AddElementFieldMapping("ProductPhotoEntity", "LargePhotoFileName", "LargePhotoFileName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductPhotoEntity", "ProductPhotoID", "ProductPhotoID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductPhotoEntity", "ThumbNailPhoto", "ThumbNailPhoto", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 4);
			this.AddElementFieldMapping("ProductPhotoEntity", "ThumbnailPhotoFileName", "ThumbnailPhotoFileName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
		}

		/// <summary>Inits ProductProductPhotoEntity's mappings</summary>
		private void InitProductProductPhotoEntityMappings()
		{
			this.AddElementMapping("ProductProductPhotoEntity", @"AdventureWorks", @"Production", "ProductProductPhoto", 4);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "Primary", "Primary", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductProductPhotoEntity", "ProductPhotoID", "ProductPhotoID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits ProductReviewEntity's mappings</summary>
		private void InitProductReviewEntityMappings()
		{
			this.AddElementMapping("ProductReviewEntity", @"AdventureWorks", @"Production", "ProductReview", 8);
			this.AddElementFieldMapping("ProductReviewEntity", "Comments", "Comments", true, "NVarChar", 3850, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductReviewEntity", "EmailAddress", "EmailAddress", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductReviewEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductReviewEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductReviewEntity", "ProductReviewID", "ProductReviewID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductReviewEntity", "Rating", "Rating", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ProductReviewEntity", "ReviewDate", "ReviewDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("ProductReviewEntity", "ReviewerName", "ReviewerName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits ProductSubcategoryEntity's mappings</summary>
		private void InitProductSubcategoryEntityMappings()
		{
			this.AddElementMapping("ProductSubcategoryEntity", @"AdventureWorks", @"Production", "ProductSubcategory", 5);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ProductCategoryID", "ProductCategoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "ProductSubcategoryID", "ProductSubcategoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductSubcategoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
		}

		/// <summary>Inits PurchaseOrderHistoryEntity's mappings</summary>
		private void InitPurchaseOrderHistoryEntityMappings()
		{
			this.AddElementMapping("PurchaseOrderHistoryEntity", @"AdventureWorks", @"Production", "TransactionHistory", 0);
		}

		/// <summary>Inits SalesOrderHistoryEntity's mappings</summary>
		private void InitSalesOrderHistoryEntityMappings()
		{
			this.AddElementMapping("SalesOrderHistoryEntity", @"AdventureWorks", @"Production", "TransactionHistory", 0);
		}

		/// <summary>Inits ScrapReasonEntity's mappings</summary>
		private void InitScrapReasonEntityMappings()
		{
			this.AddElementMapping("ScrapReasonEntity", @"AdventureWorks", @"Production", "ScrapReason", 3);
			this.AddElementFieldMapping("ScrapReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ScrapReasonEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ScrapReasonEntity", "ScrapReasonID", "ScrapReasonID", false, "SmallInt", 0, 5, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2);
		}

		/// <summary>Inits TransactionHistoryEntity's mappings</summary>
		private void InitTransactionHistoryEntityMappings()
		{
			this.AddElementMapping("TransactionHistoryEntity", @"AdventureWorks", @"Production", "TransactionHistory", 9);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ActualCost", "ActualCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("TransactionHistoryEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ReferenceOrderID", "ReferenceOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("TransactionHistoryEntity", "ReferenceOrderLineID", "ReferenceOrderLineID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionDate", "TransactionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionID", "TransactionID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("TransactionHistoryEntity", "TransactionType", "TransactionType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits TransactionHistoryArchiveEntity's mappings</summary>
		private void InitTransactionHistoryArchiveEntityMappings()
		{
			this.AddElementMapping("TransactionHistoryArchiveEntity", @"AdventureWorks", @"Production", "TransactionHistoryArchive", 9);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ActualCost", "ActualCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ReferenceOrderID", "ReferenceOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "ReferenceOrderLineID", "ReferenceOrderLineID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionDate", "TransactionDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionID", "TransactionID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("TransactionHistoryArchiveEntity", "TransactionType", "TransactionType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 8);
		}

		/// <summary>Inits UnitMeasureEntity's mappings</summary>
		private void InitUnitMeasureEntityMappings()
		{
			this.AddElementMapping("UnitMeasureEntity", @"AdventureWorks", @"Production", "UnitMeasure", 3);
			this.AddElementFieldMapping("UnitMeasureEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("UnitMeasureEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("UnitMeasureEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits WorkOrderEntity's mappings</summary>
		private void InitWorkOrderEntityMappings()
		{
			this.AddElementMapping("WorkOrderEntity", @"AdventureWorks", @"Production", "WorkOrder", 10);
			this.AddElementFieldMapping("WorkOrderEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("WorkOrderEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("WorkOrderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("WorkOrderEntity", "OrderQuantity", "OrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("WorkOrderEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("WorkOrderEntity", "ScrappedQuantity", "ScrappedQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 5);
			this.AddElementFieldMapping("WorkOrderEntity", "ScrapReasonID", "ScrapReasonID", true, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 6);
			this.AddElementFieldMapping("WorkOrderEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("WorkOrderEntity", "StockedQuantity", "StockedQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("WorkOrderEntity", "WorkOrderID", "WorkOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits WorkOrderHistoryEntity's mappings</summary>
		private void InitWorkOrderHistoryEntityMappings()
		{
			this.AddElementMapping("WorkOrderHistoryEntity", @"AdventureWorks", @"Production", "TransactionHistory", 0);
		}

		/// <summary>Inits WorkOrderRoutingEntity's mappings</summary>
		private void InitWorkOrderRoutingEntityMappings()
		{
			this.AddElementMapping("WorkOrderRoutingEntity", @"AdventureWorks", @"Production", "WorkOrderRouting", 12);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualCost", "ActualCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualEndDate", "ActualEndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualResourceHrs", "ActualResourceHrs", true, "Decimal", 0, 9, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ActualStartDate", "ActualStartDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "LocationID", "LocationID", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "OperationSequence", "OperationSequence", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 6);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "PlannedCost", "PlannedCost", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ScheduledEndDate", "ScheduledEndDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "ScheduledStartDate", "ScheduledStartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("WorkOrderRoutingEntity", "WorkOrderID", "WorkOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
		}

		/// <summary>Inits ProductVendorEntity's mappings</summary>
		private void InitProductVendorEntityMappings()
		{
			this.AddElementMapping("ProductVendorEntity", @"AdventureWorks", @"Purchasing", "ProductVendor", 11);
			this.AddElementFieldMapping("ProductVendorEntity", "AverageLeadTime", "AverageLeadTime", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductVendorEntity", "LastReceiptCost", "LastReceiptCost", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("ProductVendorEntity", "LastReceiptDate", "LastReceiptDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("ProductVendorEntity", "MaxOrderQuantity", "MaxOrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ProductVendorEntity", "MinOrderQuantity", "MinOrderQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ProductVendorEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("ProductVendorEntity", "OnOrderQuantity", "OnOrderQty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("ProductVendorEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("ProductVendorEntity", "StandardPrice", "StandardPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("ProductVendorEntity", "UnitMeasureCode", "UnitMeasureCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("ProductVendorEntity", "VendorID", "VendorID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 10);
		}

		/// <summary>Inits PurchaseOrderDetailEntity's mappings</summary>
		private void InitPurchaseOrderDetailEntityMappings()
		{
			this.AddElementMapping("PurchaseOrderDetailEntity", @"AdventureWorks", @"Purchasing", "PurchaseOrderDetail", 11);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "LineTotal", "LineTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "OrderQuantity", "OrderQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "PurchaseOrderDetailID", "PurchaseOrderDetailID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "PurchaseOrderID", "PurchaseOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "ReceivedQuantity", "ReceivedQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "RejectedQuantity", "RejectedQty", false, "Decimal", 0, 8, 2, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "StockedQuantity", "StockedQty", false, "Decimal", 0, 9, 2, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("PurchaseOrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
		}

		/// <summary>Inits PurchaseOrderHeaderEntity's mappings</summary>
		private void InitPurchaseOrderHeaderEntityMappings()
		{
			this.AddElementMapping("PurchaseOrderHeaderEntity", @"AdventureWorks", @"Purchasing", "PurchaseOrderHeader", 13);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "EmployeeID", "EmployeeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "Freight", "Freight", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "PurchaseOrderID", "PurchaseOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 5);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ShipDate", "ShipDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "ShipMethodID", "ShipMethodID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 8);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "SubTotal", "SubTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "TaxAmt", "TaxAmt", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "TotalDue", "TotalDue", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 11);
			this.AddElementFieldMapping("PurchaseOrderHeaderEntity", "VendorID", "VendorID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 12);
		}

		/// <summary>Inits ShipMethodEntity's mappings</summary>
		private void InitShipMethodEntityMappings()
		{
			this.AddElementMapping("ShipMethodEntity", @"AdventureWorks", @"Purchasing", "ShipMethod", 6);
			this.AddElementFieldMapping("ShipMethodEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ShipMethodEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ShipMethodEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipBase", "ShipBase", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipMethodID", "ShipMethodID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ShipMethodEntity", "ShipRate", "ShipRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
		}

		/// <summary>Inits VendorEntity's mappings</summary>
		private void InitVendorEntityMappings()
		{
			this.AddElementMapping("VendorEntity", @"AdventureWorks", @"Purchasing", "Vendor", 8);
			this.AddElementFieldMapping("VendorEntity", "AccountNumber", "AccountNumber", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("VendorEntity", "ActiveFlag", "ActiveFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("VendorEntity", "CreditRating", "CreditRating", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 2);
			this.AddElementFieldMapping("VendorEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("VendorEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("VendorEntity", "PreferredVendorStatus", "PreferredVendorStatus", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("VendorEntity", "PurchasingWebServiceUrl", "PurchasingWebServiceURL", true, "NVarChar", 1024, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("VendorEntity", "VendorID", "VendorID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 7);
		}

		/// <summary>Inits VendorAddressEntity's mappings</summary>
		private void InitVendorAddressEntityMappings()
		{
			this.AddElementMapping("VendorAddressEntity", @"AdventureWorks", @"Purchasing", "VendorAddress", 4);
			this.AddElementFieldMapping("VendorAddressEntity", "AddressID", "AddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("VendorAddressEntity", "AddressTypeID", "AddressTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("VendorAddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("VendorAddressEntity", "VendorID", "VendorID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits VendorContactEntity's mappings</summary>
		private void InitVendorContactEntityMappings()
		{
			this.AddElementMapping("VendorContactEntity", @"AdventureWorks", @"Purchasing", "VendorContact", 4);
			this.AddElementFieldMapping("VendorContactEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("VendorContactEntity", "ContactTypeID", "ContactTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("VendorContactEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("VendorContactEntity", "VendorID", "VendorID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits ContactCreditCardEntity's mappings</summary>
		private void InitContactCreditCardEntityMappings()
		{
			this.AddElementMapping("ContactCreditCardEntity", @"AdventureWorks", @"Sales", "ContactCreditCard", 3);
			this.AddElementFieldMapping("ContactCreditCardEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ContactCreditCardEntity", "CreditCardID", "CreditCardID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ContactCreditCardEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
		}

		/// <summary>Inits CountryRegionCurrencyEntity's mappings</summary>
		private void InitCountryRegionCurrencyEntityMappings()
		{
			this.AddElementMapping("CountryRegionCurrencyEntity", @"AdventureWorks", @"Sales", "CountryRegionCurrency", 3);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "CurrencyCode", "CurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CountryRegionCurrencyEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
		}

		/// <summary>Inits CreditCardEntity's mappings</summary>
		private void InitCreditCardEntityMappings()
		{
			this.AddElementMapping("CreditCardEntity", @"AdventureWorks", @"Sales", "CreditCard", 6);
			this.AddElementFieldMapping("CreditCardEntity", "CardNumber", "CardNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CreditCardEntity", "CardType", "CardType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CreditCardEntity", "CreditCardID", "CreditCardID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CreditCardEntity", "ExpMonth", "ExpMonth", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 3);
			this.AddElementFieldMapping("CreditCardEntity", "ExpYear", "ExpYear", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 4);
			this.AddElementFieldMapping("CreditCardEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
		}

		/// <summary>Inits CurrencyEntity's mappings</summary>
		private void InitCurrencyEntityMappings()
		{
			this.AddElementMapping("CurrencyEntity", @"AdventureWorks", @"Sales", "Currency", 3);
			this.AddElementFieldMapping("CurrencyEntity", "CurrencyCode", "CurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CurrencyEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CurrencyEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CurrencyRateEntity's mappings</summary>
		private void InitCurrencyRateEntityMappings()
		{
			this.AddElementMapping("CurrencyRateEntity", @"AdventureWorks", @"Sales", "CurrencyRate", 7);
			this.AddElementFieldMapping("CurrencyRateEntity", "AverageRate", "AverageRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("CurrencyRateEntity", "CurrencyRateDate", "CurrencyRateDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("CurrencyRateEntity", "CurrencyRateID", "CurrencyRateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CurrencyRateEntity", "EndOfDayRate", "EndOfDayRate", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("CurrencyRateEntity", "FromCurrencyCode", "FromCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CurrencyRateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("CurrencyRateEntity", "ToCurrencyCode", "ToCurrencyCode", false, "NChar", 3, 0, 0, false, "", null, typeof(System.String), 6);
		}

		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping("CustomerEntity", @"AdventureWorks", @"Sales", "Customer", 6);
			this.AddElementFieldMapping("CustomerEntity", "AccountNumber", "AccountNumber", false, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CustomerEntity", "CustomerType", "CustomerType", false, "NChar", 1, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("CustomerEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
			this.AddElementFieldMapping("CustomerEntity", "TerritoryID", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits CustomerAddressEntity's mappings</summary>
		private void InitCustomerAddressEntityMappings()
		{
			this.AddElementMapping("CustomerAddressEntity", @"AdventureWorks", @"Sales", "CustomerAddress", 5);
			this.AddElementFieldMapping("CustomerAddressEntity", "AddressID", "AddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CustomerAddressEntity", "AddressTypeID", "AddressTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CustomerAddressEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CustomerAddressEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("CustomerAddressEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
		}

		/// <summary>Inits CustomerViewRelatedEntity's mappings</summary>
		private void InitCustomerViewRelatedEntityMappings()
		{
			this.AddElementMapping("CustomerViewRelatedEntity", @"AdventureWorks", @"Sales", "vIndividualCustomer", 17);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "AddressLine2", "AddressLine2", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "AddressType", "AddressType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "City", "City", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "CountryRegionName", "CountryRegionName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "CustomerId", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "Demographics", "Demographics", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "EmailAddress", "EmailAddress", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "EmailPromotion", "EmailPromotion", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "MiddleName", "MiddleName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "Phone", "Phone", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "StateProvinceName", "StateProvinceName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "Suffix", "Suffix", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 15);
			this.AddElementFieldMapping("CustomerViewRelatedEntity", "Title", "Title", true, "NVarChar", 8, 0, 0, false, "", null, typeof(System.String), 16);
		}

		/// <summary>Inits IndividualEntity's mappings</summary>
		private void InitIndividualEntityMappings()
		{
			this.AddElementMapping("IndividualEntity", @"AdventureWorks", @"Sales", "Individual", 3);
			this.AddElementFieldMapping("IndividualEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("IndividualEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("IndividualEntity", "Demographics", "Demographics", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits SalesOrderDetailEntity's mappings</summary>
		private void InitSalesOrderDetailEntityMappings()
		{
			this.AddElementMapping("SalesOrderDetailEntity", @"AdventureWorks", @"Sales", "SalesOrderDetail", 11);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "CarrierTrackingNumber", "CarrierTrackingNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "LineTotal", "LineTotal", false, "Decimal", 0, 38, 6, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "OrderQty", "OrderQty", false, "SmallInt", 0, 5, 0, false, "", null, typeof(System.Int16), 3);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 5);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SalesOrderDetailID", "SalesOrderDetailID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SalesOrderID", "SalesOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("SalesOrderDetailEntity", "UnitPriceDiscount", "UnitPriceDiscount", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 10);
		}

		/// <summary>Inits SalesOrderHeaderEntity's mappings</summary>
		private void InitSalesOrderHeaderEntityMappings()
		{
			this.AddElementMapping("SalesOrderHeaderEntity", @"AdventureWorks", @"Sales", "SalesOrderHeader", 27);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "AccountNumber", "AccountNumber", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "BillToAddressID", "BillToAddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Comment", "Comment", true, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CreditCardApprovalCode", "CreditCardApprovalCode", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CreditCardID", "CreditCardID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CurrencyRateID", "CurrencyRateID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "DueDate", "DueDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Freight", "Freight", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 9);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "OnlineOrderFlag", "OnlineOrderFlag", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 12);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "PurchaseOrderNumber", "PurchaseOrderNumber", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 14);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 15);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesOrderID", "SalesOrderID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 16);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesOrderNumber", "SalesOrderNumber", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 17);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SalesPersonID", "SalesPersonID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 18);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipDate", "ShipDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 19);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipMethodID", "ShipMethodID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 20);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "ShipToAddressID", "ShipToAddressID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 21);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "Status", "Status", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 22);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "SubTotal", "SubTotal", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 23);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TaxAmt", "TaxAmt", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 24);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TerritoryID", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 25);
			this.AddElementFieldMapping("SalesOrderHeaderEntity", "TotalDue", "TotalDue", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 26);
		}

		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's mappings</summary>
		private void InitSalesOrderHeaderSalesReasonEntityMappings()
		{
			this.AddElementMapping("SalesOrderHeaderSalesReasonEntity", @"AdventureWorks", @"Sales", "SalesOrderHeaderSalesReason", 3);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "SalesOrderID", "SalesOrderID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesOrderHeaderSalesReasonEntity", "SalesReasonID", "SalesReasonID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits SalesPersonEntity's mappings</summary>
		private void InitSalesPersonEntityMappings()
		{
			this.AddElementMapping("SalesPersonEntity", @"AdventureWorks", @"Sales", "SalesPerson", 7);
			this.AddElementFieldMapping("SalesPersonEntity", "EmployeeID", "SalesPersonID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SalesPersonEntity", "Bonus", "Bonus", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("SalesPersonEntity", "CommissionPct", "CommissionPct", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesLastYear", "SalesLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesQuota", "SalesQuota", true, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 4);
			this.AddElementFieldMapping("SalesPersonEntity", "SalesYtd", "SalesYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("SalesPersonEntity", "TerritoryID", "TerritoryID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
		}

		/// <summary>Inits SalesPersonQuotaHistoryEntity's mappings</summary>
		private void InitSalesPersonQuotaHistoryEntityMappings()
		{
			this.AddElementMapping("SalesPersonQuotaHistoryEntity", @"AdventureWorks", @"Sales", "SalesPersonQuotaHistory", 5);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "QuotaDate", "QuotaDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "SalesPersonID", "SalesPersonID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("SalesPersonQuotaHistoryEntity", "SalesQuota", "SalesQuota", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 4);
		}

		/// <summary>Inits SalesReasonEntity's mappings</summary>
		private void InitSalesReasonEntityMappings()
		{
			this.AddElementMapping("SalesReasonEntity", @"AdventureWorks", @"Sales", "SalesReason", 4);
			this.AddElementFieldMapping("SalesReasonEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesReasonEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesReasonEntity", "ReasonType", "ReasonType", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesReasonEntity", "SalesReasonID", "SalesReasonID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits SalesTaxRateEntity's mappings</summary>
		private void InitSalesTaxRateEntityMappings()
		{
			this.AddElementMapping("SalesTaxRateEntity", @"AdventureWorks", @"Sales", "SalesTaxRate", 7);
			this.AddElementFieldMapping("SalesTaxRateEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesTaxRateEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesTaxRateEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SalesTaxRateEntity", "SalesTaxRateID", "SalesTaxRateID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("SalesTaxRateEntity", "StateProvinceID", "StateProvinceID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SalesTaxRateEntity", "TaxRate", "TaxRate", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 5);
			this.AddElementFieldMapping("SalesTaxRateEntity", "TaxType", "TaxType", false, "TinyInt", 0, 3, 0, false, "", null, typeof(System.Byte), 6);
		}

		/// <summary>Inits SalesTerritoryEntity's mappings</summary>
		private void InitSalesTerritoryEntityMappings()
		{
			this.AddElementMapping("SalesTerritoryEntity", @"AdventureWorks", @"Sales", "SalesTerritory", 10);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CostLastYear", "CostLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 0);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CostYtd", "CostYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("SalesTerritoryEntity", "CountryRegionCode", "CountryRegionCode", false, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Group", "Group", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("SalesTerritoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("SalesTerritoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 6);
			this.AddElementFieldMapping("SalesTerritoryEntity", "SalesLastYear", "SalesLastYear", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("SalesTerritoryEntity", "SalesYtd", "SalesYTD", false, "Money", 0, 19, 4, false, "", null, typeof(System.Decimal), 8);
			this.AddElementFieldMapping("SalesTerritoryEntity", "TerritoryID", "TerritoryID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 9);
		}

		/// <summary>Inits SalesTerritoryHistoryEntity's mappings</summary>
		private void InitSalesTerritoryHistoryEntityMappings()
		{
			this.AddElementMapping("SalesTerritoryHistoryEntity", @"AdventureWorks", @"Sales", "SalesTerritoryHistory", 6);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "EndDate", "EndDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "SalesPersonID", "SalesPersonID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("SalesTerritoryHistoryEntity", "TerritoryID", "TerritoryID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits ShoppingCartItemEntity's mappings</summary>
		private void InitShoppingCartItemEntityMappings()
		{
			this.AddElementMapping("ShoppingCartItemEntity", @"AdventureWorks", @"Sales", "ShoppingCartItem", 6);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "DateCreated", "DateCreated", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "Quantity", "Quantity", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ShoppingCartID", "ShoppingCartID", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ShoppingCartItemEntity", "ShoppingCartItemID", "ShoppingCartItemID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits SpecialOfferEntity's mappings</summary>
		private void InitSpecialOfferEntityMappings()
		{
			this.AddElementMapping("SpecialOfferEntity", @"AdventureWorks", @"Sales", "SpecialOffer", 11);
			this.AddElementFieldMapping("SpecialOfferEntity", "Category", "Category", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SpecialOfferEntity", "Description", "Description", false, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SpecialOfferEntity", "DiscountPct", "DiscountPct", false, "SmallMoney", 0, 10, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("SpecialOfferEntity", "EndDate", "EndDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("SpecialOfferEntity", "MaxQty", "MaxQty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("SpecialOfferEntity", "MinQty", "MinQty", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("SpecialOfferEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("SpecialOfferEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 7);
			this.AddElementFieldMapping("SpecialOfferEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("SpecialOfferEntity", "StartDate", "StartDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9);
			this.AddElementFieldMapping("SpecialOfferEntity", "Type", "Type", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits SpecialOfferProductEntity's mappings</summary>
		private void InitSpecialOfferProductEntityMappings()
		{
			this.AddElementMapping("SpecialOfferProductEntity", @"AdventureWorks", @"Sales", "SpecialOfferProduct", 4);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "ProductID", "ProductID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("SpecialOfferProductEntity", "SpecialOfferID", "SpecialOfferID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits StoreEntity's mappings</summary>
		private void InitStoreEntityMappings()
		{
			this.AddElementMapping("StoreEntity", @"AdventureWorks", @"Sales", "Store", 4);
			this.AddElementFieldMapping("StoreEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("StoreEntity", "Demographics", "Demographics", true, "Xml", 2147483647, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("StoreEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("StoreEntity", "SalesPersonID", "SalesPersonID", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
		}

		/// <summary>Inits StoreContactEntity's mappings</summary>
		private void InitStoreContactEntityMappings()
		{
			this.AddElementMapping("StoreContactEntity", @"AdventureWorks", @"Sales", "StoreContact", 5);
			this.AddElementFieldMapping("StoreContactEntity", "ContactID", "ContactID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("StoreContactEntity", "ContactTypeID", "ContactTypeID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("StoreContactEntity", "CustomerID", "CustomerID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("StoreContactEntity", "ModifiedDate", "ModifiedDate", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("StoreContactEntity", "Rowguid", "rowguid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4);
		}


		/// <summary>Inits CustomerViewView's mappings</summary>
		private void InitCustomerViewTypedViewMappings()
		{
			this.AddElementMapping("CustomerViewTypedView", @"AdventureWorks", @"Sales", "vIndividualCustomer", 17);
			this.AddElementFieldMapping("CustomerViewTypedView", "CustomerId", "CustomerID", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CustomerViewTypedView", "Title", "Title", false, "NVarChar", 8, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerViewTypedView", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerViewTypedView", "MiddleName", "MiddleName", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("CustomerViewTypedView", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomerViewTypedView", "Suffix", "Suffix", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 5);
			this.AddElementFieldMapping("CustomerViewTypedView", "Phone", "Phone", false, "NVarChar", 25, 0, 0, false, string.Empty, null, typeof(System.String), 6);
			this.AddElementFieldMapping("CustomerViewTypedView", "EmailAddress", "EmailAddress", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 7);
			this.AddElementFieldMapping("CustomerViewTypedView", "EmailPromotion", "EmailPromotion", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("CustomerViewTypedView", "AddressType", "AddressType", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 9);
			this.AddElementFieldMapping("CustomerViewTypedView", "AddressLine1", "AddressLine1", false, "NVarChar", 60, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("CustomerViewTypedView", "AddressLine2", "AddressLine2", false, "NVarChar", 60, 0, 0, false, string.Empty, null, typeof(System.String), 11);
			this.AddElementFieldMapping("CustomerViewTypedView", "City", "City", false, "NVarChar", 30, 0, 0, false, string.Empty, null, typeof(System.String), 12);
			this.AddElementFieldMapping("CustomerViewTypedView", "StateProvinceName", "StateProvinceName", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 13);
			this.AddElementFieldMapping("CustomerViewTypedView", "PostalCode", "PostalCode", false, "NVarChar", 15, 0, 0, false, string.Empty, null, typeof(System.String), 14);
			this.AddElementFieldMapping("CustomerViewTypedView", "CountryRegionName", "CountryRegionName", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 15);
			this.AddElementFieldMapping("CustomerViewTypedView", "Demographics", "Demographics", false, "Xml", 2147483647, 0, 0, false, string.Empty, null, typeof(System.String), 16);
		}

	}
}
