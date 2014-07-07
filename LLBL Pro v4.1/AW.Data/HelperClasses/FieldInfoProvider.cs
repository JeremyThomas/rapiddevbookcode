///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
			this.InitClass( (74 + 1));
			InitAwbuildVersionEntityInfos();
			InitDatabaseLogEntityInfos();
			InitErrorLogEntityInfos();
			InitDepartmentEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeAddressEntityInfos();
			InitEmployeeDepartmentHistoryEntityInfos();
			InitEmployeePayHistoryEntityInfos();
			InitJobCandidateEntityInfos();
			InitShiftEntityInfos();
			InitAddressEntityInfos();
			InitAddressTypeEntityInfos();
			InitContactEntityInfos();
			InitContactTypeEntityInfos();
			InitCountryRegionEntityInfos();
			InitStateProvinceEntityInfos();
			InitBillOfMaterialEntityInfos();
			InitCultureEntityInfos();
			InitDocumentEntityInfos();
			InitIllustrationEntityInfos();
			InitLocationEntityInfos();
			InitProductEntityInfos();
			InitProductCategoryEntityInfos();
			InitProductCostHistoryEntityInfos();
			InitProductDescriptionEntityInfos();
			InitProductDocumentEntityInfos();
			InitProductInventoryEntityInfos();
			InitProductListPriceHistoryEntityInfos();
			InitProductModelEntityInfos();
			InitProductModelIllustrationEntityInfos();
			InitProductModelProductDescriptionCultureEntityInfos();
			InitProductPhotoEntityInfos();
			InitProductProductPhotoEntityInfos();
			InitProductReviewEntityInfos();
			InitProductSubcategoryEntityInfos();
			InitPurchaseOrderHistoryEntityInfos();
			InitSalesOrderHistoryEntityInfos();
			InitScrapReasonEntityInfos();
			InitTransactionHistoryEntityInfos();
			InitTransactionHistoryArchiveEntityInfos();
			InitUnitMeasureEntityInfos();
			InitWorkOrderEntityInfos();
			InitWorkOrderHistoryEntityInfos();
			InitWorkOrderRoutingEntityInfos();
			InitProductVendorEntityInfos();
			InitPurchaseOrderDetailEntityInfos();
			InitPurchaseOrderHeaderEntityInfos();
			InitShipMethodEntityInfos();
			InitVendorEntityInfos();
			InitVendorAddressEntityInfos();
			InitVendorContactEntityInfos();
			InitContactCreditCardEntityInfos();
			InitCountryRegionCurrencyEntityInfos();
			InitCreditCardEntityInfos();
			InitCurrencyEntityInfos();
			InitCurrencyRateEntityInfos();
			InitCustomerEntityInfos();
			InitCustomerAddressEntityInfos();
			InitCustomerViewRelatedEntityInfos();
			InitIndividualEntityInfos();
			InitSalesOrderDetailEntityInfos();
			InitSalesOrderHeaderEntityInfos();
			InitSalesOrderHeaderSalesReasonEntityInfos();
			InitSalesPersonEntityInfos();
			InitSalesPersonQuotaHistoryEntityInfos();
			InitSalesReasonEntityInfos();
			InitSalesTaxRateEntityInfos();
			InitSalesTerritoryEntityInfos();
			InitSalesTerritoryHistoryEntityInfos();
			InitShoppingCartItemEntityInfos();
			InitSpecialOfferEntityInfos();
			InitSpecialOfferProductEntityInfos();
			InitStoreEntityInfos();
			InitStoreContactEntityInfos();
			InitCustomerViewTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AwbuildVersionEntity's FieldInfo objects</summary>
		private void InitAwbuildVersionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AwbuildVersionFieldIndex), "AwbuildVersionEntity");
			this.AddElementFieldInfo("AwbuildVersionEntity", "DatabaseVersion", typeof(System.String), false, false, false, false,  (int)AwbuildVersionFieldIndex.DatabaseVersion, 25, 0, 0);
			this.AddElementFieldInfo("AwbuildVersionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AwbuildVersionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("AwbuildVersionEntity", "SystemInformationID", typeof(System.Byte), true, false, true, false,  (int)AwbuildVersionFieldIndex.SystemInformationID, 0, 0, 3);
			this.AddElementFieldInfo("AwbuildVersionEntity", "VersionDate", typeof(System.DateTime), false, false, false, false,  (int)AwbuildVersionFieldIndex.VersionDate, 0, 0, 0);
		}
		/// <summary>Inits DatabaseLogEntity's FieldInfo objects</summary>
		private void InitDatabaseLogEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DatabaseLogFieldIndex), "DatabaseLogEntity");
			this.AddElementFieldInfo("DatabaseLogEntity", "DatabaseLogID", typeof(System.Int32), true, false, true, false,  (int)DatabaseLogFieldIndex.DatabaseLogID, 0, 0, 10);
			this.AddElementFieldInfo("DatabaseLogEntity", "DatabaseUser", typeof(System.String), false, false, false, false,  (int)DatabaseLogFieldIndex.DatabaseUser, 128, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "Event", typeof(System.String), false, false, false, false,  (int)DatabaseLogFieldIndex.Event, 128, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "Object", typeof(System.String), false, false, false, true,  (int)DatabaseLogFieldIndex.Object, 128, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "PostTime", typeof(System.DateTime), false, false, false, false,  (int)DatabaseLogFieldIndex.PostTime, 0, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "Schema", typeof(System.String), false, false, false, true,  (int)DatabaseLogFieldIndex.Schema, 128, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "Tsql", typeof(System.String), false, false, false, false,  (int)DatabaseLogFieldIndex.Tsql, 2147483647, 0, 0);
			this.AddElementFieldInfo("DatabaseLogEntity", "XmlEvent", typeof(System.String), false, false, false, false,  (int)DatabaseLogFieldIndex.XmlEvent, 2147483647, 0, 0);
		}
		/// <summary>Inits ErrorLogEntity's FieldInfo objects</summary>
		private void InitErrorLogEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ErrorLogFieldIndex), "ErrorLogEntity");
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorLine", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ErrorLogFieldIndex.ErrorLine, 0, 0, 10);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorLogID", typeof(System.Int32), true, false, true, false,  (int)ErrorLogFieldIndex.ErrorLogID, 0, 0, 10);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorMessage", typeof(System.String), false, false, false, false,  (int)ErrorLogFieldIndex.ErrorMessage, 4000, 0, 0);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorNumber", typeof(System.Int32), false, false, false, false,  (int)ErrorLogFieldIndex.ErrorNumber, 0, 0, 10);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorProcedure", typeof(System.String), false, false, false, true,  (int)ErrorLogFieldIndex.ErrorProcedure, 126, 0, 0);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorSeverity", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ErrorLogFieldIndex.ErrorSeverity, 0, 0, 10);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorState", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ErrorLogFieldIndex.ErrorState, 0, 0, 10);
			this.AddElementFieldInfo("ErrorLogEntity", "ErrorTime", typeof(System.DateTime), false, false, false, false,  (int)ErrorLogFieldIndex.ErrorTime, 0, 0, 0);
			this.AddElementFieldInfo("ErrorLogEntity", "UserName", typeof(System.String), false, false, false, false,  (int)ErrorLogFieldIndex.UserName, 128, 0, 0);
		}
		/// <summary>Inits DepartmentEntity's FieldInfo objects</summary>
		private void InitDepartmentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DepartmentFieldIndex), "DepartmentEntity");
			this.AddElementFieldInfo("DepartmentEntity", "DepartmentID", typeof(System.Int16), true, false, true, false,  (int)DepartmentFieldIndex.DepartmentID, 0, 0, 5);
			this.AddElementFieldInfo("DepartmentEntity", "GroupName", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.GroupName, 50, 0, 0);
			this.AddElementFieldInfo("DepartmentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DepartmentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("DepartmentEntity", "Name", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "EmployeeID", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Gender", typeof(AW.Data.Gender), false, false, false, false,  (int)EmployeeFieldIndex.Gender, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "IsCurrent", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsCurrent, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "IsSalaried", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsSalaried, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LoginID", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LoginID, 256, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ManagerID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ManagerID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "MaritalStatus", typeof(AW.Data.MaritalStatus), false, false, false, false,  (int)EmployeeFieldIndex.MaritalStatus, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "NationalIdnumber", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.NationalIdnumber, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeFieldIndex.Rowguid, 0, 0, 0);
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
		/// <summary>Inits EmployeeDepartmentHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeeDepartmentHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeDepartmentHistoryFieldIndex), "EmployeeDepartmentHistoryEntity");
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "DepartmentID", typeof(System.Int16), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.DepartmentID, 0, 0, 5);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeDepartmentHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ShiftID", typeof(System.Byte), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ShiftID, 0, 0, 3);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeePayHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeePayHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeePayHistoryFieldIndex), "EmployeePayHistoryEntity");
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeePayHistoryFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "PayFrequency", typeof(AW.Data.PayFrequency), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.PayFrequency, 0, 0, 3);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "Rate", typeof(System.Decimal), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.Rate, 0, 4, 19);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "RateChangeDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeePayHistoryFieldIndex.RateChangeDate, 0, 0, 0);
		}
		/// <summary>Inits JobCandidateEntity's FieldInfo objects</summary>
		private void InitJobCandidateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(JobCandidateFieldIndex), "JobCandidateEntity");
			this.AddElementFieldInfo("JobCandidateEntity", "EmployeeID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)JobCandidateFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("JobCandidateEntity", "JobCandidateID", typeof(System.Int32), true, false, true, false,  (int)JobCandidateFieldIndex.JobCandidateID, 0, 0, 10);
			this.AddElementFieldInfo("JobCandidateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)JobCandidateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("JobCandidateEntity", "Resume", typeof(System.String), false, false, false, true,  (int)JobCandidateFieldIndex.Resume, 2147483647, 0, 0);
		}
		/// <summary>Inits ShiftEntity's FieldInfo objects</summary>
		private void InitShiftEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShiftFieldIndex), "ShiftEntity");
			this.AddElementFieldInfo("ShiftEntity", "EndTime", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.EndTime, 0, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShiftFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "ShiftID", typeof(System.Byte), true, false, true, false,  (int)ShiftFieldIndex.ShiftID, 0, 0, 3);
			this.AddElementFieldInfo("ShiftEntity", "StartTime", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.StartTime, 0, 0, 0);
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
			this.AddElementFieldInfo("AddressTypeEntity", "AddressTypeID", typeof(AW.Data.AddressType), true, false, true, false,  (int)AddressTypeFieldIndex.AddressTypeID, 0, 0, 10);
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
			this.AddElementFieldInfo("ContactEntity", "EmailPromotion", typeof(AW.Data.EmailPromotion), false, false, false, false,  (int)ContactFieldIndex.EmailPromotion, 0, 0, 10);
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
		/// <summary>Inits ContactTypeEntity's FieldInfo objects</summary>
		private void InitContactTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ContactTypeFieldIndex), "ContactTypeEntity");
			this.AddElementFieldInfo("ContactTypeEntity", "ContactTypeID", typeof(AW.Data.ContactType), true, false, true, false,  (int)ContactTypeFieldIndex.ContactTypeID, 0, 0, 10);
			this.AddElementFieldInfo("ContactTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactTypeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ContactTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)ContactTypeFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CountryRegionEntity's FieldInfo objects</summary>
		private void InitCountryRegionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CountryRegionFieldIndex), "CountryRegionEntity");
			this.AddElementFieldInfo("CountryRegionEntity", "CountryRegionCode", typeof(System.String), true, false, false, false,  (int)CountryRegionFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "Name", typeof(System.String), false, false, false, false,  (int)CountryRegionFieldIndex.Name, 50, 0, 0);
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
		/// <summary>Inits BillOfMaterialEntity's FieldInfo objects</summary>
		private void InitBillOfMaterialEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BillOfMaterialFieldIndex), "BillOfMaterialEntity");
			this.AddElementFieldInfo("BillOfMaterialEntity", "BillOfMaterialsID", typeof(System.Int32), true, false, true, false,  (int)BillOfMaterialFieldIndex.BillOfMaterialsID, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "Bomlevel", typeof(System.Int16), false, false, false, false,  (int)BillOfMaterialFieldIndex.Bomlevel, 0, 0, 5);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ComponentID", typeof(System.Int32), false, true, false, false,  (int)BillOfMaterialFieldIndex.ComponentID, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BillOfMaterialFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "PerAssemblyQuantity", typeof(System.Decimal), false, false, false, false,  (int)BillOfMaterialFieldIndex.PerAssemblyQuantity, 0, 2, 8);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ProductAssemblyID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)BillOfMaterialFieldIndex.ProductAssemblyID, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)BillOfMaterialFieldIndex.UnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits CultureEntity's FieldInfo objects</summary>
		private void InitCultureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CultureFieldIndex), "CultureEntity");
			this.AddElementFieldInfo("CultureEntity", "CultureID", typeof(System.String), true, false, false, false,  (int)CultureFieldIndex.CultureID, 6, 0, 0);
			this.AddElementFieldInfo("CultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CultureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CultureEntity", "Name", typeof(System.String), false, false, false, false,  (int)CultureFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits DocumentEntity's FieldInfo objects</summary>
		private void InitDocumentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DocumentFieldIndex), "DocumentEntity");
			this.AddElementFieldInfo("DocumentEntity", "ChangeNumber", typeof(System.Int32), false, false, false, false,  (int)DocumentFieldIndex.ChangeNumber, 0, 0, 10);
			this.AddElementFieldInfo("DocumentEntity", "Document", typeof(System.Byte[]), false, false, false, true,  (int)DocumentFieldIndex.Document, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "DocumentID", typeof(System.Int32), true, false, true, false,  (int)DocumentFieldIndex.DocumentID, 0, 0, 10);
			this.AddElementFieldInfo("DocumentEntity", "DocumentSummary", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.DocumentSummary, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "FileExtension", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileExtension, 8, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "FileName", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileName, 400, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DocumentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Revision", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Revision, 5, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Status", typeof(AW.Data.ProductMaintenanceDocumentStatus), false, false, false, false,  (int)DocumentFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("DocumentEntity", "Title", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Title, 50, 0, 0);
		}
		/// <summary>Inits IllustrationEntity's FieldInfo objects</summary>
		private void InitIllustrationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IllustrationFieldIndex), "IllustrationEntity");
			this.AddElementFieldInfo("IllustrationEntity", "Diagram", typeof(System.String), false, false, false, true,  (int)IllustrationFieldIndex.Diagram, 2147483647, 0, 0);
			this.AddElementFieldInfo("IllustrationEntity", "IllustrationID", typeof(System.Int32), true, false, true, false,  (int)IllustrationFieldIndex.IllustrationID, 0, 0, 10);
			this.AddElementFieldInfo("IllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IllustrationFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits LocationEntity's FieldInfo objects</summary>
		private void InitLocationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LocationFieldIndex), "LocationEntity");
			this.AddElementFieldInfo("LocationEntity", "Availability", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.Availability, 0, 2, 8);
			this.AddElementFieldInfo("LocationEntity", "CostRate", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.CostRate, 0, 4, 10);
			this.AddElementFieldInfo("LocationEntity", "LocationID", typeof(System.Int16), true, false, true, false,  (int)LocationFieldIndex.LocationID, 0, 0, 5);
			this.AddElementFieldInfo("LocationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)LocationFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("LocationEntity", "Name", typeof(System.String), false, false, false, false,  (int)LocationFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "Class", typeof(Nullable<AW.Data.ProductClass>), false, false, false, true,  (int)ProductFieldIndex.Class, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Color", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Color, 15, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "DaysToManufacture", typeof(System.Int32), false, false, false, false,  (int)ProductFieldIndex.DaysToManufacture, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "DiscontinuedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.DiscontinuedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "FinishedGoodsFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.FinishedGoodsFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.ListPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "MakeFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.MakeFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductID", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductLine", typeof(Nullable<AW.Data.ProductLine>), false, false, false, true,  (int)ProductFieldIndex.ProductLine, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductModelID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductModelID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductNumber", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductNumber, 25, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductSubcategoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductSubcategoryID, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ReorderPoint", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.ReorderPoint, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SafetyStockLevel", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.SafetyStockLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SellEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.SellEndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SellStartDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.SellStartDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Size", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Size, 5, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SizeUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.SizeUnitMeasureCode, 3, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.StandardCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "Style", typeof(Nullable<AW.Data.ProductStyle>), false, false, false, true,  (int)ProductFieldIndex.Style, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Weight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.Weight, 0, 2, 8);
			this.AddElementFieldInfo("ProductEntity", "WeightUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.WeightUnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits ProductCategoryEntity's FieldInfo objects</summary>
		private void InitProductCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductCategoryFieldIndex), "ProductCategoryEntity");
			this.AddElementFieldInfo("ProductCategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCategoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductCategoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductCategoryEntity", "ProductCategoryID", typeof(System.Int32), true, false, true, false,  (int)ProductCategoryFieldIndex.ProductCategoryID, 0, 0, 10);
			this.AddElementFieldInfo("ProductCategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductCategoryFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductCostHistoryEntity's FieldInfo objects</summary>
		private void InitProductCostHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductCostHistoryFieldIndex), "ProductCostHistoryEntity");
			this.AddElementFieldInfo("ProductCostHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductCostHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCostHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductCostHistoryFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductCostHistoryFieldIndex.StandardCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductCostHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits ProductDescriptionEntity's FieldInfo objects</summary>
		private void InitProductDescriptionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductDescriptionFieldIndex), "ProductDescriptionEntity");
			this.AddElementFieldInfo("ProductDescriptionEntity", "Description", typeof(System.String), false, false, false, false,  (int)ProductDescriptionFieldIndex.Description, 400, 0, 0);
			this.AddElementFieldInfo("ProductDescriptionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDescriptionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductDescriptionEntity", "ProductDescriptionID", typeof(System.Int32), true, false, true, false,  (int)ProductDescriptionFieldIndex.ProductDescriptionID, 0, 0, 10);
			this.AddElementFieldInfo("ProductDescriptionEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductDescriptionFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductDocumentEntity's FieldInfo objects</summary>
		private void InitProductDocumentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductDocumentFieldIndex), "ProductDocumentEntity");
			this.AddElementFieldInfo("ProductDocumentEntity", "DocumentID", typeof(System.Int32), true, true, false, false,  (int)ProductDocumentFieldIndex.DocumentID, 0, 0, 10);
			this.AddElementFieldInfo("ProductDocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDocumentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductDocumentEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductDocumentFieldIndex.ProductID, 0, 0, 10);
		}
		/// <summary>Inits ProductInventoryEntity's FieldInfo objects</summary>
		private void InitProductInventoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductInventoryFieldIndex), "ProductInventoryEntity");
			this.AddElementFieldInfo("ProductInventoryEntity", "Bin", typeof(System.Byte), false, false, false, false,  (int)ProductInventoryFieldIndex.Bin, 0, 0, 3);
			this.AddElementFieldInfo("ProductInventoryEntity", "LocationID", typeof(System.Int16), true, true, false, false,  (int)ProductInventoryFieldIndex.LocationID, 0, 0, 5);
			this.AddElementFieldInfo("ProductInventoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductInventoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductInventoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductInventoryFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductInventoryEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)ProductInventoryFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("ProductInventoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductInventoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ProductInventoryEntity", "Shelf", typeof(System.String), false, false, false, false,  (int)ProductInventoryFieldIndex.Shelf, 10, 0, 0);
		}
		/// <summary>Inits ProductListPriceHistoryEntity's FieldInfo objects</summary>
		private void InitProductListPriceHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductListPriceHistoryFieldIndex), "ProductListPriceHistoryEntity");
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductListPriceHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ListPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductListPriceHistoryFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductListPriceHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits ProductModelEntity's FieldInfo objects</summary>
		private void InitProductModelEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelFieldIndex), "ProductModelEntity");
			this.AddElementFieldInfo("ProductModelEntity", "CatalogDescription", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.CatalogDescription, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "Instructions", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.Instructions, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductModelFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "ProductModelID", typeof(System.Int32), true, false, true, false,  (int)ProductModelFieldIndex.ProductModelID, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductModelFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductModelIllustrationEntity's FieldInfo objects</summary>
		private void InitProductModelIllustrationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelIllustrationFieldIndex), "ProductModelIllustrationEntity");
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "IllustrationID", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.IllustrationID, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelIllustrationFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "ProductModelID", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.ProductModelID, 0, 0, 10);
		}
		/// <summary>Inits ProductModelProductDescriptionCultureEntity's FieldInfo objects</summary>
		private void InitProductModelProductDescriptionCultureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelProductDescriptionCultureFieldIndex), "ProductModelProductDescriptionCultureEntity");
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "CultureID", typeof(System.String), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.CultureID, 6, 0, 0);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductDescriptionID", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductModelID", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID, 0, 0, 10);
		}
		/// <summary>Inits ProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductPhotoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductPhotoFieldIndex), "ProductPhotoEntity");
			this.AddElementFieldInfo("ProductPhotoEntity", "LargePhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhoto, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "LargePhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhotoFileName, 50, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ProductPhotoID", typeof(System.Int32), true, false, true, false,  (int)ProductPhotoFieldIndex.ProductPhotoID, 0, 0, 10);
			this.AddElementFieldInfo("ProductPhotoEntity", "ThumbNailPhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbNailPhoto, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ThumbnailPhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, 50, 0, 0);
		}
		/// <summary>Inits ProductProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductProductPhotoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductProductPhotoFieldIndex), "ProductProductPhotoEntity");
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "Primary", typeof(System.Boolean), false, false, false, false,  (int)ProductProductPhotoFieldIndex.Primary, 0, 0, 0);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ProductPhotoID", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductPhotoID, 0, 0, 10);
		}
		/// <summary>Inits ProductReviewEntity's FieldInfo objects</summary>
		private void InitProductReviewEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductReviewFieldIndex), "ProductReviewEntity");
			this.AddElementFieldInfo("ProductReviewEntity", "Comments", typeof(System.String), false, false, false, true,  (int)ProductReviewFieldIndex.Comments, 3850, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "EmailAddress", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)ProductReviewFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "ProductReviewID", typeof(System.Int32), true, false, true, false,  (int)ProductReviewFieldIndex.ProductReviewID, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "Rating", typeof(System.Int32), false, false, false, false,  (int)ProductReviewFieldIndex.Rating, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "ReviewDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ReviewerName", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewerName, 50, 0, 0);
		}
		/// <summary>Inits ProductSubcategoryEntity's FieldInfo objects</summary>
		private void InitProductSubcategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductSubcategoryFieldIndex), "ProductSubcategoryEntity");
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductSubcategoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ProductCategoryID", typeof(System.Int32), false, true, false, false,  (int)ProductSubcategoryFieldIndex.ProductCategoryID, 0, 0, 10);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ProductSubcategoryID", typeof(System.Int32), true, false, true, false,  (int)ProductSubcategoryFieldIndex.ProductSubcategoryID, 0, 0, 10);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits PurchaseOrderHistoryEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PurchaseOrderHistoryFieldIndex), "PurchaseOrderHistoryEntity");

		}
		/// <summary>Inits SalesOrderHistoryEntity's FieldInfo objects</summary>
		private void InitSalesOrderHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderHistoryFieldIndex), "SalesOrderHistoryEntity");

		}
		/// <summary>Inits ScrapReasonEntity's FieldInfo objects</summary>
		private void InitScrapReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ScrapReasonFieldIndex), "ScrapReasonEntity");
			this.AddElementFieldInfo("ScrapReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ScrapReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ScrapReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)ScrapReasonFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ScrapReasonEntity", "ScrapReasonID", typeof(System.Int16), true, false, true, false,  (int)ScrapReasonFieldIndex.ScrapReasonID, 0, 0, 5);
		}
		/// <summary>Inits TransactionHistoryEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TransactionHistoryFieldIndex), "TransactionHistoryEntity");
			this.AddElementFieldInfo("TransactionHistoryEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)TransactionHistoryFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderLineID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderLineID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.TransactionDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionID", typeof(System.Int32), true, false, true, false,  (int)TransactionHistoryFieldIndex.TransactionID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionType", typeof(System.String), false, false, true, false,  (int)TransactionHistoryFieldIndex.TransactionType, 1, 0, 0);
		}
		/// <summary>Inits TransactionHistoryArchiveEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryArchiveEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TransactionHistoryArchiveFieldIndex), "TransactionHistoryArchiveEntity");
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ProductID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderLineID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderLineID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionID", typeof(System.Int32), true, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionID, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionType", typeof(System.String), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionType, 1, 0, 0);
		}
		/// <summary>Inits UnitMeasureEntity's FieldInfo objects</summary>
		private void InitUnitMeasureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UnitMeasureFieldIndex), "UnitMeasureEntity");
			this.AddElementFieldInfo("UnitMeasureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)UnitMeasureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("UnitMeasureEntity", "Name", typeof(System.String), false, false, false, false,  (int)UnitMeasureFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("UnitMeasureEntity", "UnitMeasureCode", typeof(System.String), true, false, false, false,  (int)UnitMeasureFieldIndex.UnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits WorkOrderEntity's FieldInfo objects</summary>
		private void InitWorkOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WorkOrderFieldIndex), "WorkOrderEntity");
			this.AddElementFieldInfo("WorkOrderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "OrderQuantity", typeof(System.Int32), false, false, false, false,  (int)WorkOrderFieldIndex.OrderQuantity, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)WorkOrderFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "ScrappedQuantity", typeof(System.Int16), false, false, false, false,  (int)WorkOrderFieldIndex.ScrappedQuantity, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderEntity", "ScrapReasonID", typeof(Nullable<System.Int16>), false, true, false, true,  (int)WorkOrderFieldIndex.ScrapReasonID, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "StockedQuantity", typeof(System.Int32), false, false, true, false,  (int)WorkOrderFieldIndex.StockedQuantity, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "WorkOrderID", typeof(System.Int32), true, false, true, false,  (int)WorkOrderFieldIndex.WorkOrderID, 0, 0, 10);
		}
		/// <summary>Inits WorkOrderHistoryEntity's FieldInfo objects</summary>
		private void InitWorkOrderHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WorkOrderHistoryFieldIndex), "WorkOrderHistoryEntity");

		}
		/// <summary>Inits WorkOrderRoutingEntity's FieldInfo objects</summary>
		private void InitWorkOrderRoutingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WorkOrderRoutingFieldIndex), "WorkOrderRoutingEntity");
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualEndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualResourceHrs", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualResourceHrs, 0, 4, 9);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualStartDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualStartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "LocationID", typeof(System.Int16), false, true, false, false,  (int)WorkOrderRoutingFieldIndex.LocationID, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "OperationSequence", typeof(System.Int16), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.OperationSequence, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "PlannedCost", typeof(System.Decimal), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.PlannedCost, 0, 4, 19);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ProductID", typeof(System.Int32), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledEndDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledEndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledStartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledStartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "WorkOrderID", typeof(System.Int32), true, true, false, false,  (int)WorkOrderRoutingFieldIndex.WorkOrderID, 0, 0, 10);
		}
		/// <summary>Inits ProductVendorEntity's FieldInfo objects</summary>
		private void InitProductVendorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductVendorFieldIndex), "ProductVendorEntity");
			this.AddElementFieldInfo("ProductVendorEntity", "AverageLeadTime", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.AverageLeadTime, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "LastReceiptCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductVendorEntity", "LastReceiptDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "MaxOrderQuantity", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MaxOrderQuantity, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "MinOrderQuantity", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MinOrderQuantity, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductVendorFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "OnOrderQuantity", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductVendorFieldIndex.OnOrderQuantity, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "StandardPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductVendorFieldIndex.StandardPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductVendorEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)ProductVendorFieldIndex.UnitMeasureCode, 3, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.VendorID, 0, 0, 10);
		}
		/// <summary>Inits PurchaseOrderDetailEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PurchaseOrderDetailFieldIndex), "PurchaseOrderDetailEntity");
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.LineTotal, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "OrderQuantity", typeof(System.Int16), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.OrderQuantity, 0, 0, 5);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderDetailFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderDetailID", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderID", typeof(System.Int32), true, true, false, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ReceivedQuantity", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ReceivedQuantity, 0, 2, 8);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "RejectedQuantity", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.RejectedQuantity, 0, 2, 8);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "StockedQuantity", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.StockedQuantity, 0, 2, 9);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits PurchaseOrderHeaderEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderHeaderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PurchaseOrderHeaderFieldIndex), "PurchaseOrderHeaderEntity");
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "EmployeeID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "PurchaseOrderID", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PurchaseOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipMethodID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.ShipMethodID, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Status", typeof(AW.Data.PurchaseOrderStatus), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "VendorID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.VendorID, 0, 0, 10);
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
		/// <summary>Inits VendorEntity's FieldInfo objects</summary>
		private void InitVendorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VendorFieldIndex), "VendorEntity");
			this.AddElementFieldInfo("VendorEntity", "AccountNumber", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "ActiveFlag", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.ActiveFlag, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "CreditRating", typeof(AW.Data.CreditRating), false, false, false, false,  (int)VendorFieldIndex.CreditRating, 0, 0, 3);
			this.AddElementFieldInfo("VendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "Name", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "PreferredVendorStatus", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.PreferredVendorStatus, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "PurchasingWebServiceUrl", typeof(System.String), false, false, false, true,  (int)VendorFieldIndex.PurchasingWebServiceUrl, 1024, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "VendorID", typeof(System.Int32), true, false, true, false,  (int)VendorFieldIndex.VendorID, 0, 0, 10);
		}
		/// <summary>Inits VendorAddressEntity's FieldInfo objects</summary>
		private void InitVendorAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VendorAddressFieldIndex), "VendorAddressEntity");
			this.AddElementFieldInfo("VendorAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)VendorAddressFieldIndex.AddressID, 0, 0, 10);
			this.AddElementFieldInfo("VendorAddressEntity", "AddressTypeID", typeof(AW.Data.AddressType), false, true, false, false,  (int)VendorAddressFieldIndex.AddressTypeID, 0, 0, 10);
			this.AddElementFieldInfo("VendorAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("VendorAddressEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)VendorAddressFieldIndex.VendorID, 0, 0, 10);
		}
		/// <summary>Inits VendorContactEntity's FieldInfo objects</summary>
		private void InitVendorContactEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VendorContactFieldIndex), "VendorContactEntity");
			this.AddElementFieldInfo("VendorContactEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)VendorContactFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("VendorContactEntity", "ContactTypeID", typeof(AW.Data.ContactType), false, true, false, false,  (int)VendorContactFieldIndex.ContactTypeID, 0, 0, 10);
			this.AddElementFieldInfo("VendorContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorContactFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("VendorContactEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)VendorContactFieldIndex.VendorID, 0, 0, 10);
		}
		/// <summary>Inits ContactCreditCardEntity's FieldInfo objects</summary>
		private void InitContactCreditCardEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ContactCreditCardFieldIndex), "ContactCreditCardEntity");
			this.AddElementFieldInfo("ContactCreditCardEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("ContactCreditCardEntity", "CreditCardID", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.CreditCardID, 0, 0, 10);
			this.AddElementFieldInfo("ContactCreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactCreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CountryRegionCurrencyEntity's FieldInfo objects</summary>
		private void InitCountryRegionCurrencyEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CountryRegionCurrencyFieldIndex), "CountryRegionCurrencyEntity");
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "CountryRegionCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "CurrencyCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionCurrencyFieldIndex.ModifiedDate, 0, 0, 0);
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
			this.AddElementFieldInfo("CustomerAddressEntity", "AddressTypeID", typeof(AW.Data.AddressType), false, true, false, false,  (int)CustomerAddressFieldIndex.AddressTypeID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerAddressEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("CustomerAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CustomerAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerAddressFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits CustomerViewRelatedEntity's FieldInfo objects</summary>
		private void InitCustomerViewRelatedEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerViewRelatedFieldIndex), "CustomerViewRelatedEntity");
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressLine2", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "AddressType", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.AddressType, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "City", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "CountryRegionName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.CountryRegionName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "CustomerId", typeof(System.Int32), true, false, true, false,  (int)CustomerViewRelatedFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "EmailPromotion", typeof(AW.Data.EmailPromotion), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "LastName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Phone", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.Phone, 25, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "StateProvinceName", typeof(System.String), false, false, false, false,  (int)CustomerViewRelatedFieldIndex.StateProvinceName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Suffix", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("CustomerViewRelatedEntity", "Title", typeof(System.String), false, false, false, true,  (int)CustomerViewRelatedFieldIndex.Title, 8, 0, 0);
		}
		/// <summary>Inits IndividualEntity's FieldInfo objects</summary>
		private void InitIndividualEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IndividualFieldIndex), "IndividualEntity");
			this.AddElementFieldInfo("IndividualEntity", "CustomerID", typeof(System.Int32), true, false, true, false,  (int)IndividualFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("IndividualEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)IndividualFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("IndividualEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)IndividualFieldIndex.Demographics, 2147483647, 0, 0);
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
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesPersonID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.SalesPersonID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipMethodID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipMethodID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipToAddressID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipToAddressID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Status", typeof(AW.Data.OrderStatus), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.TerritoryID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
		}
		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderSalesReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderHeaderSalesReasonFieldIndex), "SalesOrderHeaderSalesReasonEntity");
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesOrderID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesReasonID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, 0, 0, 10);
		}
		/// <summary>Inits SalesPersonEntity's FieldInfo objects</summary>
		private void InitSalesPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesPersonFieldIndex), "SalesPersonEntity");
			this.AddElementFieldInfo("SalesPersonEntity", "EmployeeID", typeof(System.Int32), true, false, true, false,  (int)SalesPersonFieldIndex.EmployeeID, 0, 0, 10);
			this.AddElementFieldInfo("SalesPersonEntity", "Bonus", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.Bonus, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "CommissionPct", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.CommissionPct, 0, 4, 10);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesQuota", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SalesPersonFieldIndex.SalesQuota, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesPersonFieldIndex.TerritoryID, 0, 0, 10);
		}
		/// <summary>Inits SalesPersonQuotaHistoryEntity's FieldInfo objects</summary>
		private void InitSalesPersonQuotaHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesPersonQuotaHistoryFieldIndex), "SalesPersonQuotaHistoryEntity");
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "QuotaDate", typeof(System.DateTime), true, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.QuotaDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesPersonID", typeof(System.Int32), true, true, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesPersonID, 0, 0, 10);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesQuota", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesQuota, 0, 4, 19);
		}
		/// <summary>Inits SalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesReasonFieldIndex), "SalesReasonEntity");
			this.AddElementFieldInfo("SalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "ReasonType", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.ReasonType, 50, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "SalesReasonID", typeof(System.Int32), true, false, true, false,  (int)SalesReasonFieldIndex.SalesReasonID, 0, 0, 10);
		}
		/// <summary>Inits SalesTaxRateEntity's FieldInfo objects</summary>
		private void InitSalesTaxRateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTaxRateFieldIndex), "SalesTaxRateEntity");
			this.AddElementFieldInfo("SalesTaxRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTaxRateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTaxRateFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTaxRateFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "SalesTaxRateID", typeof(System.Int32), true, false, true, false,  (int)SalesTaxRateFieldIndex.SalesTaxRateID, 0, 0, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "StateProvinceID", typeof(System.Int32), false, true, false, false,  (int)SalesTaxRateFieldIndex.StateProvinceID, 0, 0, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "TaxRate", typeof(System.Decimal), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxRate, 0, 4, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "TaxType", typeof(AW.Data.TaxApplication), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxType, 0, 0, 3);
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
		/// <summary>Inits SalesTerritoryHistoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTerritoryHistoryFieldIndex), "SalesTerritoryHistoryEntity");
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesTerritoryHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "SalesPersonID", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.SalesPersonID, 0, 0, 10);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "TerritoryID", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.TerritoryID, 0, 0, 10);
		}
		/// <summary>Inits ShoppingCartItemEntity's FieldInfo objects</summary>
		private void InitShoppingCartItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShoppingCartItemFieldIndex), "ShoppingCartItemEntity");
			this.AddElementFieldInfo("ShoppingCartItemEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)ShoppingCartItemFieldIndex.ProductID, 0, 0, 10);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)ShoppingCartItemFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartID", typeof(System.String), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartID, 50, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartItemID", typeof(System.Int32), true, false, true, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartItemID, 0, 0, 10);
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
		/// <summary>Inits StoreEntity's FieldInfo objects</summary>
		private void InitStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreFieldIndex), "StoreEntity");
			this.AddElementFieldInfo("StoreEntity", "CustomerID", typeof(System.Int32), true, false, true, false,  (int)StoreFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("StoreEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)StoreFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "Name", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "SalesPersonID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)StoreFieldIndex.SalesPersonID, 0, 0, 10);
		}
		/// <summary>Inits StoreContactEntity's FieldInfo objects</summary>
		private void InitStoreContactEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreContactFieldIndex), "StoreContactEntity");
			this.AddElementFieldInfo("StoreContactEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)StoreContactFieldIndex.ContactID, 0, 0, 10);
			this.AddElementFieldInfo("StoreContactEntity", "ContactTypeID", typeof(AW.Data.ContactType), false, true, false, false,  (int)StoreContactFieldIndex.ContactTypeID, 0, 0, 10);
			this.AddElementFieldInfo("StoreContactEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)StoreContactFieldIndex.CustomerID, 0, 0, 10);
			this.AddElementFieldInfo("StoreContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StoreContactFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("StoreContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StoreContactFieldIndex.Rowguid, 0, 0, 0);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCustomerViewTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerViewFieldIndex), "CustomerViewTypedView");
			this.AddElementFieldInfo("CustomerViewTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)CustomerViewFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewTypedView", "Title", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Title, 8, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "FirstName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "MiddleName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "LastName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Suffix", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Phone", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Phone, 25, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "EmailAddress", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "EmailPromotion", typeof(AW.Data.EmailPromotion), false, false, true, false, (int)CustomerViewFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressType", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressType, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressLine1", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "AddressLine2", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "City", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "StateProvinceName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.StateProvinceName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "PostalCode", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "CountryRegionName", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.CountryRegionName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerViewTypedView", "Demographics", typeof(System.String), false, false, true, false, (int)CustomerViewFieldIndex.Demographics, 2147483647, 0, 0);
		}		
	}
}




