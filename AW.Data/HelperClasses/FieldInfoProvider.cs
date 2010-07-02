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
			base.InitClass( (68 + 1));
			InitAddressEntityInfos();
			InitAddressTypeEntityInfos();
			InitBillOfMaterialsEntityInfos();
			InitContactEntityInfos();
			InitContactCreditCardEntityInfos();
			InitContactTypeEntityInfos();
			InitCountryRegionEntityInfos();
			InitCountryRegionCurrencyEntityInfos();
			InitCreditCardEntityInfos();
			InitCultureEntityInfos();
			InitCurrencyEntityInfos();
			InitCurrencyRateEntityInfos();
			InitCustomerEntityInfos();
			InitCustomerAddressEntityInfos();
			InitCustomerViewRelatedEntityInfos();
			InitDepartmentEntityInfos();
			InitDocumentEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeAddressEntityInfos();
			InitEmployeeDepartmentHistoryEntityInfos();
			InitEmployeePayHistoryEntityInfos();
			InitIllustrationEntityInfos();
			InitIndividualEntityInfos();
			InitJobCandidateEntityInfos();
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
			InitProductVendorEntityInfos();
			InitPurchaseOrderDetailEntityInfos();
			InitPurchaseOrderHeaderEntityInfos();
			InitSalesOrderDetailEntityInfos();
			InitSalesOrderHeaderEntityInfos();
			InitSalesOrderHeaderSalesReasonEntityInfos();
			InitSalesPersonEntityInfos();
			InitSalesPersonQuotaHistoryEntityInfos();
			InitSalesReasonEntityInfos();
			InitSalesTaxRateEntityInfos();
			InitSalesTerritoryEntityInfos();
			InitSalesTerritoryHistoryEntityInfos();
			InitScrapReasonEntityInfos();
			InitShiftEntityInfos();
			InitShipMethodEntityInfos();
			InitShoppingCartItemEntityInfos();
			InitSpecialOfferEntityInfos();
			InitSpecialOfferProductEntityInfos();
			InitStateProvinceEntityInfos();
			InitStoreEntityInfos();
			InitStoreContactEntityInfos();
			InitTransactionHistoryEntityInfos();
			InitTransactionHistoryArchiveEntityInfos();
			InitUnitMeasureEntityInfos();
			InitVendorEntityInfos();
			InitVendorAddressEntityInfos();
			InitVendorContactEntityInfos();
			InitWorkOrderEntityInfos();
			InitWorkOrderRoutingEntityInfos();
			InitCustomerViewTypedViewInfos();
			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AddressEntity's FieldInfo objects</summary>
		private void InitAddressEntityInfos()
		{
			base.AddElementFieldInfo("AddressEntity", "AddressID", typeof(System.Int32), true, false, true, false,  (int)AddressFieldIndex.AddressID, 0, 0, 10);
			base.AddElementFieldInfo("AddressEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.AddressLine1, 60, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "AddressLine2", typeof(System.String), false, false, false, true,  (int)AddressFieldIndex.AddressLine2, 60, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "City", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.City, 30, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "StateProvinceID", typeof(System.Int32), false, true, false, false,  (int)AddressFieldIndex.StateProvinceID, 0, 0, 10);
			base.AddElementFieldInfo("AddressEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.PostalCode, 15, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("AddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits AddressTypeEntity's FieldInfo objects</summary>
		private void InitAddressTypeEntityInfos()
		{
			base.AddElementFieldInfo("AddressTypeEntity", "AddressTypeID", typeof(System.Int32), true, false, true, false,  (int)AddressTypeFieldIndex.AddressTypeID, 0, 0, 10);
			base.AddElementFieldInfo("AddressTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AddressTypeFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("AddressTypeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressTypeFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("AddressTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressTypeFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits BillOfMaterialsEntity's FieldInfo objects</summary>
		private void InitBillOfMaterialsEntityInfos()
		{
			base.AddElementFieldInfo("BillOfMaterialsEntity", "BillOfMaterialsID", typeof(System.Int32), true, false, true, false,  (int)BillOfMaterialsFieldIndex.BillOfMaterialsID, 0, 0, 10);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "ProductAssemblyID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)BillOfMaterialsFieldIndex.ProductAssemblyID, 0, 0, 10);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "ComponentID", typeof(System.Int32), false, true, false, false,  (int)BillOfMaterialsFieldIndex.ComponentID, 0, 0, 10);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialsFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BillOfMaterialsFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)BillOfMaterialsFieldIndex.UnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "Bomlevel", typeof(System.Int16), false, false, false, false,  (int)BillOfMaterialsFieldIndex.Bomlevel, 0, 0, 5);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "PerAssemblyQty", typeof(System.Decimal), false, false, false, false,  (int)BillOfMaterialsFieldIndex.PerAssemblyQty, 0, 2, 8);
			base.AddElementFieldInfo("BillOfMaterialsEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialsFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ContactEntity's FieldInfo objects</summary>
		private void InitContactEntityInfos()
		{
			base.AddElementFieldInfo("ContactEntity", "ContactID", typeof(System.Int32), true, false, true, false,  (int)ContactFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("ContactEntity", "NameStyle", typeof(System.Boolean), false, false, false, false,  (int)ContactFieldIndex.NameStyle, 0, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Title", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Title, 8, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "LastName", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Suffix", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Suffix, 10, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.EmailAddress, 50, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)ContactFieldIndex.EmailPromotion, 0, 0, 10);
			base.AddElementFieldInfo("ContactEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.Phone, 25, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "PasswordHash", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordHash, 128, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "PasswordSalt", typeof(System.String), false, false, false, false,  (int)ContactFieldIndex.PasswordSalt, 10, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "AdditionalContactInfo", typeof(System.String), false, false, false, true,  (int)ContactFieldIndex.AdditionalContactInfo, 2147483647, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ContactFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ContactCreditCardEntity's FieldInfo objects</summary>
		private void InitContactCreditCardEntityInfos()
		{
			base.AddElementFieldInfo("ContactCreditCardEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("ContactCreditCardEntity", "CreditCardID", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.CreditCardID, 0, 0, 10);
			base.AddElementFieldInfo("ContactCreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactCreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ContactTypeEntity's FieldInfo objects</summary>
		private void InitContactTypeEntityInfos()
		{
			base.AddElementFieldInfo("ContactTypeEntity", "ContactTypeID", typeof(System.Int32), true, false, true, false,  (int)ContactTypeFieldIndex.ContactTypeID, 0, 0, 10);
			base.AddElementFieldInfo("ContactTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)ContactTypeFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ContactTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactTypeFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CountryRegionEntity's FieldInfo objects</summary>
		private void InitCountryRegionEntityInfos()
		{
			base.AddElementFieldInfo("CountryRegionEntity", "CountryRegionCode", typeof(System.String), true, false, false, false,  (int)CountryRegionFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("CountryRegionEntity", "Name", typeof(System.String), false, false, false, false,  (int)CountryRegionFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("CountryRegionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CountryRegionCurrencyEntity's FieldInfo objects</summary>
		private void InitCountryRegionCurrencyEntityInfos()
		{
			base.AddElementFieldInfo("CountryRegionCurrencyEntity", "CountryRegionCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("CountryRegionCurrencyEntity", "CurrencyCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			base.AddElementFieldInfo("CountryRegionCurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionCurrencyFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CreditCardEntity's FieldInfo objects</summary>
		private void InitCreditCardEntityInfos()
		{
			base.AddElementFieldInfo("CreditCardEntity", "CreditCardID", typeof(System.Int32), true, false, true, false,  (int)CreditCardFieldIndex.CreditCardID, 0, 0, 10);
			base.AddElementFieldInfo("CreditCardEntity", "CardType", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardType, 50, 0, 0);
			base.AddElementFieldInfo("CreditCardEntity", "CardNumber", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardNumber, 25, 0, 0);
			base.AddElementFieldInfo("CreditCardEntity", "ExpMonth", typeof(System.Byte), false, false, false, false,  (int)CreditCardFieldIndex.ExpMonth, 0, 0, 3);
			base.AddElementFieldInfo("CreditCardEntity", "ExpYear", typeof(System.Int16), false, false, false, false,  (int)CreditCardFieldIndex.ExpYear, 0, 0, 5);
			base.AddElementFieldInfo("CreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CultureEntity's FieldInfo objects</summary>
		private void InitCultureEntityInfos()
		{
			base.AddElementFieldInfo("CultureEntity", "CultureID", typeof(System.String), true, false, false, false,  (int)CultureFieldIndex.CultureID, 6, 0, 0);
			base.AddElementFieldInfo("CultureEntity", "Name", typeof(System.String), false, false, false, false,  (int)CultureFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("CultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CultureFieldIndex.ModifiedDate, 0, 0, 0);
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
			base.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateID", typeof(System.Int32), true, false, true, false,  (int)CurrencyRateFieldIndex.CurrencyRateID, 0, 0, 10);
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
			base.AddElementFieldInfo("CustomerEntity", "CustomerID", typeof(System.Int32), true, false, true, false,  (int)CustomerFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("CustomerEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.TerritoryID, 0, 0, 10);
			base.AddElementFieldInfo("CustomerEntity", "AccountNumber", typeof(System.String), false, false, true, false,  (int)CustomerFieldIndex.AccountNumber, 10, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "CustomerType", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.CustomerType, 1, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("CustomerEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CustomerAddressEntity's FieldInfo objects</summary>
		private void InitCustomerAddressEntityInfos()
		{
			base.AddElementFieldInfo("CustomerAddressEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("CustomerAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)CustomerAddressFieldIndex.AddressID, 0, 0, 10);
			base.AddElementFieldInfo("CustomerAddressEntity", "AddressTypeID", typeof(System.Int32), false, true, false, false,  (int)CustomerAddressFieldIndex.AddressTypeID, 0, 0, 10);
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
		/// <summary>Inits DepartmentEntity's FieldInfo objects</summary>
		private void InitDepartmentEntityInfos()
		{
			base.AddElementFieldInfo("DepartmentEntity", "DepartmentID", typeof(System.Int16), true, false, true, false,  (int)DepartmentFieldIndex.DepartmentID, 0, 0, 5);
			base.AddElementFieldInfo("DepartmentEntity", "Name", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("DepartmentEntity", "GroupName", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.GroupName, 50, 0, 0);
			base.AddElementFieldInfo("DepartmentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DepartmentFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits DocumentEntity's FieldInfo objects</summary>
		private void InitDocumentEntityInfos()
		{
			base.AddElementFieldInfo("DocumentEntity", "DocumentID", typeof(System.Int32), true, false, true, false,  (int)DocumentFieldIndex.DocumentID, 0, 0, 10);
			base.AddElementFieldInfo("DocumentEntity", "Title", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Title, 50, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "FileName", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileName, 400, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "FileExtension", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileExtension, 8, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "Revision", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Revision, 5, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "ChangeNumber", typeof(System.Int32), false, false, false, false,  (int)DocumentFieldIndex.ChangeNumber, 0, 0, 10);
			base.AddElementFieldInfo("DocumentEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)DocumentFieldIndex.Status, 0, 0, 3);
			base.AddElementFieldInfo("DocumentEntity", "DocumentSummary", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.DocumentSummary, 2147483647, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "Document", typeof(System.Byte[]), false, false, false, true,  (int)DocumentFieldIndex.Document, 2147483647, 0, 0);
			base.AddElementFieldInfo("DocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DocumentFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			base.AddElementFieldInfo("EmployeeEntity", "EmployeeID", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "NationalIdnumber", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.NationalIdnumber, 15, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)EmployeeFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "LoginID", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LoginID, 256, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ManagerID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeeFieldIndex.ManagerID, 0, 0, 10);
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
			base.AddElementFieldInfo("EmployeeAddressEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)EmployeeAddressFieldIndex.AddressID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeAddressFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeAddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeeDepartmentHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeeDepartmentHistoryEntityInfos()
		{
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "DepartmentID", typeof(System.Int16), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.DepartmentID, 0, 0, 5);
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ShiftID", typeof(System.Byte), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ShiftID, 0, 0, 3);
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeDepartmentHistoryFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeePayHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeePayHistoryEntityInfos()
		{
			base.AddElementFieldInfo("EmployeePayHistoryEntity", "EmployeeID", typeof(System.Int32), true, true, false, false,  (int)EmployeePayHistoryFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("EmployeePayHistoryEntity", "RateChangeDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeePayHistoryFieldIndex.RateChangeDate, 0, 0, 0);
			base.AddElementFieldInfo("EmployeePayHistoryEntity", "Rate", typeof(System.Decimal), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.Rate, 0, 4, 19);
			base.AddElementFieldInfo("EmployeePayHistoryEntity", "PayFrequency", typeof(System.Byte), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.PayFrequency, 0, 0, 3);
			base.AddElementFieldInfo("EmployeePayHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits IllustrationEntity's FieldInfo objects</summary>
		private void InitIllustrationEntityInfos()
		{
			base.AddElementFieldInfo("IllustrationEntity", "IllustrationID", typeof(System.Int32), true, false, true, false,  (int)IllustrationFieldIndex.IllustrationID, 0, 0, 10);
			base.AddElementFieldInfo("IllustrationEntity", "Diagram", typeof(System.String), false, false, false, true,  (int)IllustrationFieldIndex.Diagram, 2147483647, 0, 0);
			base.AddElementFieldInfo("IllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IllustrationFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits IndividualEntity's FieldInfo objects</summary>
		private void InitIndividualEntityInfos()
		{
			base.AddElementFieldInfo("IndividualEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)IndividualFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("IndividualEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)IndividualFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("IndividualEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)IndividualFieldIndex.Demographics, 2147483647, 0, 0);
			base.AddElementFieldInfo("IndividualEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IndividualFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits JobCandidateEntity's FieldInfo objects</summary>
		private void InitJobCandidateEntityInfos()
		{
			base.AddElementFieldInfo("JobCandidateEntity", "JobCandidateID", typeof(System.Int32), true, false, true, false,  (int)JobCandidateFieldIndex.JobCandidateID, 0, 0, 10);
			base.AddElementFieldInfo("JobCandidateEntity", "EmployeeID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)JobCandidateFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("JobCandidateEntity", "Resume", typeof(System.String), false, false, false, true,  (int)JobCandidateFieldIndex.Resume, 2147483647, 0, 0);
			base.AddElementFieldInfo("JobCandidateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)JobCandidateFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits LocationEntity's FieldInfo objects</summary>
		private void InitLocationEntityInfos()
		{
			base.AddElementFieldInfo("LocationEntity", "LocationID", typeof(System.Int16), true, false, true, false,  (int)LocationFieldIndex.LocationID, 0, 0, 5);
			base.AddElementFieldInfo("LocationEntity", "Name", typeof(System.String), false, false, false, false,  (int)LocationFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("LocationEntity", "CostRate", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.CostRate, 0, 4, 10);
			base.AddElementFieldInfo("LocationEntity", "Availability", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.Availability, 0, 2, 8);
			base.AddElementFieldInfo("LocationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)LocationFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			base.AddElementFieldInfo("ProductEntity", "ProductID", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductID, 0, 0, 10);
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
			base.AddElementFieldInfo("ProductEntity", "SizeUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.SizeUnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "WeightUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.WeightUnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Weight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.Weight, 0, 2, 8);
			base.AddElementFieldInfo("ProductEntity", "DaysToManufacture", typeof(System.Int32), false, false, false, false,  (int)ProductFieldIndex.DaysToManufacture, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "ProductLine", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.ProductLine, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Class", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Class, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Style", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Style, 2, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "ProductSubcategoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductSubcategoryID, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "ProductModelID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductModelID, 0, 0, 10);
			base.AddElementFieldInfo("ProductEntity", "SellStartDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.SellStartDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "SellEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.SellEndDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "DiscontinuedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.DiscontinuedDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductCategoryEntity's FieldInfo objects</summary>
		private void InitProductCategoryEntityInfos()
		{
			base.AddElementFieldInfo("ProductCategoryEntity", "ProductCategoryID", typeof(System.Int32), true, false, true, false,  (int)ProductCategoryFieldIndex.ProductCategoryID, 0, 0, 10);
			base.AddElementFieldInfo("ProductCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductCategoryFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ProductCategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductCategoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductCategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCategoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductCostHistoryEntity's FieldInfo objects</summary>
		private void InitProductCostHistoryEntityInfos()
		{
			base.AddElementFieldInfo("ProductCostHistoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductCostHistoryFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductCostHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductCostHistoryFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductCostHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductCostHistoryFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductCostHistoryEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductCostHistoryFieldIndex.StandardCost, 0, 4, 19);
			base.AddElementFieldInfo("ProductCostHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCostHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductDescriptionEntity's FieldInfo objects</summary>
		private void InitProductDescriptionEntityInfos()
		{
			base.AddElementFieldInfo("ProductDescriptionEntity", "ProductDescriptionID", typeof(System.Int32), true, false, true, false,  (int)ProductDescriptionFieldIndex.ProductDescriptionID, 0, 0, 10);
			base.AddElementFieldInfo("ProductDescriptionEntity", "Description", typeof(System.String), false, false, false, false,  (int)ProductDescriptionFieldIndex.Description, 400, 0, 0);
			base.AddElementFieldInfo("ProductDescriptionEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductDescriptionFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductDescriptionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDescriptionFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductDocumentEntity's FieldInfo objects</summary>
		private void InitProductDocumentEntityInfos()
		{
			base.AddElementFieldInfo("ProductDocumentEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductDocumentFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductDocumentEntity", "DocumentID", typeof(System.Int32), true, true, false, false,  (int)ProductDocumentFieldIndex.DocumentID, 0, 0, 10);
			base.AddElementFieldInfo("ProductDocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDocumentFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductInventoryEntity's FieldInfo objects</summary>
		private void InitProductInventoryEntityInfos()
		{
			base.AddElementFieldInfo("ProductInventoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductInventoryFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductInventoryEntity", "LocationID", typeof(System.Int16), true, true, false, false,  (int)ProductInventoryFieldIndex.LocationID, 0, 0, 5);
			base.AddElementFieldInfo("ProductInventoryEntity", "Shelf", typeof(System.String), false, false, false, false,  (int)ProductInventoryFieldIndex.Shelf, 10, 0, 0);
			base.AddElementFieldInfo("ProductInventoryEntity", "Bin", typeof(System.Byte), false, false, false, false,  (int)ProductInventoryFieldIndex.Bin, 0, 0, 3);
			base.AddElementFieldInfo("ProductInventoryEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)ProductInventoryFieldIndex.Quantity, 0, 0, 5);
			base.AddElementFieldInfo("ProductInventoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductInventoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductInventoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductInventoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductListPriceHistoryEntity's FieldInfo objects</summary>
		private void InitProductListPriceHistoryEntityInfos()
		{
			base.AddElementFieldInfo("ProductListPriceHistoryEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductListPriceHistoryFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductListPriceHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductListPriceHistoryFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductListPriceHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductListPriceHistoryFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductListPriceHistoryEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ListPrice, 0, 4, 19);
			base.AddElementFieldInfo("ProductListPriceHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductModelEntity's FieldInfo objects</summary>
		private void InitProductModelEntityInfos()
		{
			base.AddElementFieldInfo("ProductModelEntity", "ProductModelID", typeof(System.Int32), true, false, true, false,  (int)ProductModelFieldIndex.ProductModelID, 0, 0, 10);
			base.AddElementFieldInfo("ProductModelEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductModelFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ProductModelEntity", "CatalogDescription", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.CatalogDescription, 2147483647, 0, 0);
			base.AddElementFieldInfo("ProductModelEntity", "Instructions", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.Instructions, 2147483647, 0, 0);
			base.AddElementFieldInfo("ProductModelEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductModelFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductModelEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductModelIllustrationEntity's FieldInfo objects</summary>
		private void InitProductModelIllustrationEntityInfos()
		{
			base.AddElementFieldInfo("ProductModelIllustrationEntity", "ProductModelID", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.ProductModelID, 0, 0, 10);
			base.AddElementFieldInfo("ProductModelIllustrationEntity", "IllustrationID", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.IllustrationID, 0, 0, 10);
			base.AddElementFieldInfo("ProductModelIllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelIllustrationFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductModelProductDescriptionCultureEntity's FieldInfo objects</summary>
		private void InitProductModelProductDescriptionCultureEntityInfos()
		{
			base.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductModelID", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID, 0, 0, 10);
			base.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductDescriptionID", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID, 0, 0, 10);
			base.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "CultureID", typeof(System.String), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.CultureID, 6, 0, 0);
			base.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductPhotoEntityInfos()
		{
			base.AddElementFieldInfo("ProductPhotoEntity", "ProductPhotoID", typeof(System.Int32), true, false, true, false,  (int)ProductPhotoFieldIndex.ProductPhotoID, 0, 0, 10);
			base.AddElementFieldInfo("ProductPhotoEntity", "ThumbNailPhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbNailPhoto, 2147483647, 0, 0);
			base.AddElementFieldInfo("ProductPhotoEntity", "ThumbnailPhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, 50, 0, 0);
			base.AddElementFieldInfo("ProductPhotoEntity", "LargePhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhoto, 2147483647, 0, 0);
			base.AddElementFieldInfo("ProductPhotoEntity", "LargePhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhotoFileName, 50, 0, 0);
			base.AddElementFieldInfo("ProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductProductPhotoEntityInfos()
		{
			base.AddElementFieldInfo("ProductProductPhotoEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductProductPhotoEntity", "ProductPhotoID", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductPhotoID, 0, 0, 10);
			base.AddElementFieldInfo("ProductProductPhotoEntity", "Primary", typeof(System.Boolean), false, false, false, false,  (int)ProductProductPhotoFieldIndex.Primary, 0, 0, 0);
			base.AddElementFieldInfo("ProductProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductReviewEntity's FieldInfo objects</summary>
		private void InitProductReviewEntityInfos()
		{
			base.AddElementFieldInfo("ProductReviewEntity", "ProductReviewID", typeof(System.Int32), true, false, true, false,  (int)ProductReviewFieldIndex.ProductReviewID, 0, 0, 10);
			base.AddElementFieldInfo("ProductReviewEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)ProductReviewFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductReviewEntity", "ReviewerName", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewerName, 50, 0, 0);
			base.AddElementFieldInfo("ProductReviewEntity", "ReviewDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductReviewEntity", "EmailAddress", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.EmailAddress, 50, 0, 0);
			base.AddElementFieldInfo("ProductReviewEntity", "Rating", typeof(System.Int32), false, false, false, false,  (int)ProductReviewFieldIndex.Rating, 0, 0, 10);
			base.AddElementFieldInfo("ProductReviewEntity", "Comments", typeof(System.String), false, false, false, true,  (int)ProductReviewFieldIndex.Comments, 3850, 0, 0);
			base.AddElementFieldInfo("ProductReviewEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductSubcategoryEntity's FieldInfo objects</summary>
		private void InitProductSubcategoryEntityInfos()
		{
			base.AddElementFieldInfo("ProductSubcategoryEntity", "ProductSubcategoryID", typeof(System.Int32), true, false, true, false,  (int)ProductSubcategoryFieldIndex.ProductSubcategoryID, 0, 0, 10);
			base.AddElementFieldInfo("ProductSubcategoryEntity", "ProductCategoryID", typeof(System.Int32), false, true, false, false,  (int)ProductSubcategoryFieldIndex.ProductCategoryID, 0, 0, 10);
			base.AddElementFieldInfo("ProductSubcategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ProductSubcategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ProductSubcategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductSubcategoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ProductVendorEntity's FieldInfo objects</summary>
		private void InitProductVendorEntityInfos()
		{
			base.AddElementFieldInfo("ProductVendorEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.VendorID, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "AverageLeadTime", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.AverageLeadTime, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "StandardPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductVendorFieldIndex.StandardPrice, 0, 4, 19);
			base.AddElementFieldInfo("ProductVendorEntity", "LastReceiptCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptCost, 0, 4, 19);
			base.AddElementFieldInfo("ProductVendorEntity", "LastReceiptDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptDate, 0, 0, 0);
			base.AddElementFieldInfo("ProductVendorEntity", "MinOrderQty", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MinOrderQty, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "MaxOrderQty", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MaxOrderQty, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "OnOrderQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductVendorFieldIndex.OnOrderQty, 0, 0, 10);
			base.AddElementFieldInfo("ProductVendorEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)ProductVendorFieldIndex.UnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("ProductVendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductVendorFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits PurchaseOrderDetailEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderDetailEntityInfos()
		{
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderID", typeof(System.Int32), true, true, false, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderDetailID", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.DueDate, 0, 0, 0);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderDetailFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.LineTotal, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "ReceivedQty", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ReceivedQty, 0, 2, 8);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "RejectedQty", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.RejectedQty, 0, 2, 8);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "StockedQty", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.StockedQty, 0, 2, 9);
			base.AddElementFieldInfo("PurchaseOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits PurchaseOrderHeaderEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderHeaderEntityInfos()
		{
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "PurchaseOrderID", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Status, 0, 0, 3);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "EmployeeID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.EmployeeID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "VendorID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.VendorID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipMethodID", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.ShipMethodID, 0, 0, 10);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PurchaseOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Freight, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
			base.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesOrderDetailEntity's FieldInfo objects</summary>
		private void InitSalesOrderDetailEntityInfos()
		{
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderDetailFieldIndex.SalesOrderID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderDetailID", typeof(System.Int32), true, false, true, false,  (int)SalesOrderDetailFieldIndex.SalesOrderDetailID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "CarrierTrackingNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)SalesOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "SpecialOfferID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.SpecialOfferID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPriceDiscount", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPriceDiscount, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderDetailFieldIndex.LineTotal, 0, 6, 38);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderDetailFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesOrderHeaderEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderEntityInfos()
		{
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderID", typeof(System.Int32), true, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.DueDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Status, 0, 0, 3);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "OnlineOrderFlag", typeof(System.Boolean), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderNumber", typeof(System.String), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "PurchaseOrderNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "AccountNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.AccountNumber, 15, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CustomerID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ContactID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesPersonID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.SalesPersonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.TerritoryID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "BillToAddressID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.BillToAddressID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipToAddressID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipToAddressID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipMethodID", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipMethodID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardApprovalCode", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "CurrencyRateID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CurrencyRateID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Freight, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Comment", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.Comment, 128, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderSalesReasonEntityInfos()
		{
			base.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesOrderID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesReasonID", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesPersonEntity's FieldInfo objects</summary>
		private void InitSalesPersonEntityInfos()
		{
			base.AddElementFieldInfo("SalesPersonEntity", "SalesPersonID", typeof(System.Int32), true, true, false, false,  (int)SalesPersonFieldIndex.SalesPersonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesPersonEntity", "TerritoryID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesPersonFieldIndex.TerritoryID, 0, 0, 10);
			base.AddElementFieldInfo("SalesPersonEntity", "SalesQuota", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SalesPersonFieldIndex.SalesQuota, 0, 4, 19);
			base.AddElementFieldInfo("SalesPersonEntity", "Bonus", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.Bonus, 0, 4, 19);
			base.AddElementFieldInfo("SalesPersonEntity", "CommissionPct", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.CommissionPct, 0, 4, 10);
			base.AddElementFieldInfo("SalesPersonEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesYtd, 0, 4, 19);
			base.AddElementFieldInfo("SalesPersonEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesLastYear, 0, 4, 19);
			base.AddElementFieldInfo("SalesPersonEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesPersonFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesPersonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesPersonFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesPersonQuotaHistoryEntity's FieldInfo objects</summary>
		private void InitSalesPersonQuotaHistoryEntityInfos()
		{
			base.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesPersonID", typeof(System.Int32), true, true, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesPersonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "QuotaDate", typeof(System.DateTime), true, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.QuotaDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesQuota", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesQuota, 0, 4, 19);
			base.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesReasonEntityInfos()
		{
			base.AddElementFieldInfo("SalesReasonEntity", "SalesReasonID", typeof(System.Int32), true, false, true, false,  (int)SalesReasonFieldIndex.SalesReasonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("SalesReasonEntity", "ReasonType", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.ReasonType, 50, 0, 0);
			base.AddElementFieldInfo("SalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesTaxRateEntity's FieldInfo objects</summary>
		private void InitSalesTaxRateEntityInfos()
		{
			base.AddElementFieldInfo("SalesTaxRateEntity", "SalesTaxRateID", typeof(System.Int32), true, false, true, false,  (int)SalesTaxRateFieldIndex.SalesTaxRateID, 0, 0, 10);
			base.AddElementFieldInfo("SalesTaxRateEntity", "StateProvinceID", typeof(System.Int32), false, true, false, false,  (int)SalesTaxRateFieldIndex.StateProvinceID, 0, 0, 10);
			base.AddElementFieldInfo("SalesTaxRateEntity", "TaxType", typeof(System.Byte), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxType, 0, 0, 3);
			base.AddElementFieldInfo("SalesTaxRateEntity", "TaxRate", typeof(System.Decimal), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxRate, 0, 4, 10);
			base.AddElementFieldInfo("SalesTaxRateEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTaxRateFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("SalesTaxRateEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTaxRateFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesTaxRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTaxRateFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SalesTerritoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryEntityInfos()
		{
			base.AddElementFieldInfo("SalesTerritoryEntity", "TerritoryID", typeof(System.Int32), true, false, true, false,  (int)SalesTerritoryFieldIndex.TerritoryID, 0, 0, 10);
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
		/// <summary>Inits SalesTerritoryHistoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryHistoryEntityInfos()
		{
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "SalesPersonID", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.SalesPersonID, 0, 0, 10);
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "TerritoryID", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.TerritoryID, 0, 0, 10);
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesTerritoryHistoryFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SalesTerritoryHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ScrapReasonEntity's FieldInfo objects</summary>
		private void InitScrapReasonEntityInfos()
		{
			base.AddElementFieldInfo("ScrapReasonEntity", "ScrapReasonID", typeof(System.Int16), true, false, true, false,  (int)ScrapReasonFieldIndex.ScrapReasonID, 0, 0, 5);
			base.AddElementFieldInfo("ScrapReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)ScrapReasonFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ScrapReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ScrapReasonFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ShiftEntity's FieldInfo objects</summary>
		private void InitShiftEntityInfos()
		{
			base.AddElementFieldInfo("ShiftEntity", "ShiftID", typeof(System.Byte), true, false, true, false,  (int)ShiftFieldIndex.ShiftID, 0, 0, 3);
			base.AddElementFieldInfo("ShiftEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShiftFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ShiftEntity", "StartTime", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.StartTime, 0, 0, 0);
			base.AddElementFieldInfo("ShiftEntity", "EndTime", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.EndTime, 0, 0, 0);
			base.AddElementFieldInfo("ShiftEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ShipMethodEntity's FieldInfo objects</summary>
		private void InitShipMethodEntityInfos()
		{
			base.AddElementFieldInfo("ShipMethodEntity", "ShipMethodID", typeof(System.Int32), true, false, true, false,  (int)ShipMethodFieldIndex.ShipMethodID, 0, 0, 10);
			base.AddElementFieldInfo("ShipMethodEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShipMethodFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("ShipMethodEntity", "ShipBase", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipBase, 0, 4, 19);
			base.AddElementFieldInfo("ShipMethodEntity", "ShipRate", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipRate, 0, 4, 19);
			base.AddElementFieldInfo("ShipMethodEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ShipMethodFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("ShipMethodEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShipMethodFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ShoppingCartItemEntity's FieldInfo objects</summary>
		private void InitShoppingCartItemEntityInfos()
		{
			base.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartItemID", typeof(System.Int32), true, false, true, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartItemID, 0, 0, 10);
			base.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartID", typeof(System.String), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartID, 50, 0, 0);
			base.AddElementFieldInfo("ShoppingCartItemEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)ShoppingCartItemFieldIndex.Quantity, 0, 0, 10);
			base.AddElementFieldInfo("ShoppingCartItemEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)ShoppingCartItemFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("ShoppingCartItemEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.DateCreated, 0, 0, 0);
			base.AddElementFieldInfo("ShoppingCartItemEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits SpecialOfferEntity's FieldInfo objects</summary>
		private void InitSpecialOfferEntityInfos()
		{
			base.AddElementFieldInfo("SpecialOfferEntity", "SpecialOfferID", typeof(System.Int32), true, false, true, false,  (int)SpecialOfferFieldIndex.SpecialOfferID, 0, 0, 10);
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
			base.AddElementFieldInfo("SpecialOfferProductEntity", "SpecialOfferID", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.SpecialOfferID, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "ProductID", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferProductFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("SpecialOfferProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferProductFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits StateProvinceEntity's FieldInfo objects</summary>
		private void InitStateProvinceEntityInfos()
		{
			base.AddElementFieldInfo("StateProvinceEntity", "StateProvinceID", typeof(System.Int32), true, false, true, false,  (int)StateProvinceFieldIndex.StateProvinceID, 0, 0, 10);
			base.AddElementFieldInfo("StateProvinceEntity", "StateProvinceCode", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.StateProvinceCode, 3, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "CountryRegionCode", typeof(System.String), false, true, false, false,  (int)StateProvinceFieldIndex.CountryRegionCode, 3, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "IsOnlyStateProvinceFlag", typeof(System.Boolean), false, false, false, false,  (int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, 0, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "Name", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "TerritoryID", typeof(System.Int32), false, true, false, false,  (int)StateProvinceFieldIndex.TerritoryID, 0, 0, 10);
			base.AddElementFieldInfo("StateProvinceEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StateProvinceFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("StateProvinceEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StateProvinceFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits StoreEntity's FieldInfo objects</summary>
		private void InitStoreEntityInfos()
		{
			base.AddElementFieldInfo("StoreEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)StoreFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("StoreEntity", "Name", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("StoreEntity", "SalesPersonID", typeof(Nullable<System.Int32>), false, true, false, true,  (int)StoreFieldIndex.SalesPersonID, 0, 0, 10);
			base.AddElementFieldInfo("StoreEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)StoreFieldIndex.Demographics, 2147483647, 0, 0);
			base.AddElementFieldInfo("StoreEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StoreFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("StoreEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StoreFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits StoreContactEntity's FieldInfo objects</summary>
		private void InitStoreContactEntityInfos()
		{
			base.AddElementFieldInfo("StoreContactEntity", "CustomerID", typeof(System.Int32), true, true, false, false,  (int)StoreContactFieldIndex.CustomerID, 0, 0, 10);
			base.AddElementFieldInfo("StoreContactEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)StoreContactFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("StoreContactEntity", "ContactTypeID", typeof(System.Int32), false, true, false, false,  (int)StoreContactFieldIndex.ContactTypeID, 0, 0, 10);
			base.AddElementFieldInfo("StoreContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StoreContactFieldIndex.Rowguid, 0, 0, 0);
			base.AddElementFieldInfo("StoreContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StoreContactFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits TransactionHistoryEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryEntityInfos()
		{
			base.AddElementFieldInfo("TransactionHistoryEntity", "TransactionID", typeof(System.Int32), true, false, true, false,  (int)TransactionHistoryFieldIndex.TransactionID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)TransactionHistoryFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderLineID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderLineID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.TransactionDate, 0, 0, 0);
			base.AddElementFieldInfo("TransactionHistoryEntity", "TransactionType", typeof(System.String), false, false, false, false,  (int)TransactionHistoryFieldIndex.TransactionType, 1, 0, 0);
			base.AddElementFieldInfo("TransactionHistoryEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.Quantity, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryFieldIndex.ActualCost, 0, 4, 19);
			base.AddElementFieldInfo("TransactionHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits TransactionHistoryArchiveEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryArchiveEntityInfos()
		{
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionID", typeof(System.Int32), true, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ProductID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderLineID", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderLineID, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionDate, 0, 0, 0);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionType", typeof(System.String), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionType, 1, 0, 0);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.Quantity, 0, 0, 10);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ActualCost, 0, 4, 19);
			base.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits UnitMeasureEntity's FieldInfo objects</summary>
		private void InitUnitMeasureEntityInfos()
		{
			base.AddElementFieldInfo("UnitMeasureEntity", "UnitMeasureCode", typeof(System.String), true, false, false, false,  (int)UnitMeasureFieldIndex.UnitMeasureCode, 3, 0, 0);
			base.AddElementFieldInfo("UnitMeasureEntity", "Name", typeof(System.String), false, false, false, false,  (int)UnitMeasureFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("UnitMeasureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)UnitMeasureFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits VendorEntity's FieldInfo objects</summary>
		private void InitVendorEntityInfos()
		{
			base.AddElementFieldInfo("VendorEntity", "VendorID", typeof(System.Int32), true, false, true, false,  (int)VendorFieldIndex.VendorID, 0, 0, 10);
			base.AddElementFieldInfo("VendorEntity", "AccountNumber", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.AccountNumber, 15, 0, 0);
			base.AddElementFieldInfo("VendorEntity", "Name", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("VendorEntity", "CreditRating", typeof(System.Byte), false, false, false, false,  (int)VendorFieldIndex.CreditRating, 0, 0, 3);
			base.AddElementFieldInfo("VendorEntity", "PreferredVendorStatus", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.PreferredVendorStatus, 0, 0, 0);
			base.AddElementFieldInfo("VendorEntity", "ActiveFlag", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.ActiveFlag, 0, 0, 0);
			base.AddElementFieldInfo("VendorEntity", "PurchasingWebServiceUrl", typeof(System.String), false, false, false, true,  (int)VendorFieldIndex.PurchasingWebServiceUrl, 1024, 0, 0);
			base.AddElementFieldInfo("VendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits VendorAddressEntity's FieldInfo objects</summary>
		private void InitVendorAddressEntityInfos()
		{
			base.AddElementFieldInfo("VendorAddressEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)VendorAddressFieldIndex.VendorID, 0, 0, 10);
			base.AddElementFieldInfo("VendorAddressEntity", "AddressID", typeof(System.Int32), true, true, false, false,  (int)VendorAddressFieldIndex.AddressID, 0, 0, 10);
			base.AddElementFieldInfo("VendorAddressEntity", "AddressTypeID", typeof(System.Int32), false, true, false, false,  (int)VendorAddressFieldIndex.AddressTypeID, 0, 0, 10);
			base.AddElementFieldInfo("VendorAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorAddressFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits VendorContactEntity's FieldInfo objects</summary>
		private void InitVendorContactEntityInfos()
		{
			base.AddElementFieldInfo("VendorContactEntity", "VendorID", typeof(System.Int32), true, true, false, false,  (int)VendorContactFieldIndex.VendorID, 0, 0, 10);
			base.AddElementFieldInfo("VendorContactEntity", "ContactID", typeof(System.Int32), true, true, false, false,  (int)VendorContactFieldIndex.ContactID, 0, 0, 10);
			base.AddElementFieldInfo("VendorContactEntity", "ContactTypeID", typeof(System.Int32), false, true, false, false,  (int)VendorContactFieldIndex.ContactTypeID, 0, 0, 10);
			base.AddElementFieldInfo("VendorContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorContactFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits WorkOrderEntity's FieldInfo objects</summary>
		private void InitWorkOrderEntityInfos()
		{
			base.AddElementFieldInfo("WorkOrderEntity", "WorkOrderID", typeof(System.Int32), true, false, true, false,  (int)WorkOrderFieldIndex.WorkOrderID, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "ProductID", typeof(System.Int32), false, true, false, false,  (int)WorkOrderFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "OrderQty", typeof(System.Int32), false, false, false, false,  (int)WorkOrderFieldIndex.OrderQty, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "StockedQty", typeof(System.Int32), false, false, true, false,  (int)WorkOrderFieldIndex.StockedQty, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "ScrappedQty", typeof(System.Int16), false, false, false, false,  (int)WorkOrderFieldIndex.ScrappedQty, 0, 0, 5);
			base.AddElementFieldInfo("WorkOrderEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.StartDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderFieldIndex.EndDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.DueDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "ScrapReasonID", typeof(Nullable<System.Int16>), false, true, false, true,  (int)WorkOrderFieldIndex.ScrapReasonID, 0, 0, 5);
			base.AddElementFieldInfo("WorkOrderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits WorkOrderRoutingEntity's FieldInfo objects</summary>
		private void InitWorkOrderRoutingEntityInfos()
		{
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "WorkOrderID", typeof(System.Int32), true, true, false, false,  (int)WorkOrderRoutingFieldIndex.WorkOrderID, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ProductID", typeof(System.Int32), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.ProductID, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "OperationSequence", typeof(System.Int16), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.OperationSequence, 0, 0, 5);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "LocationID", typeof(System.Int16), false, true, false, false,  (int)WorkOrderRoutingFieldIndex.LocationID, 0, 0, 5);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledStartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledStartDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledEndDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledEndDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualStartDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualStartDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualEndDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualResourceHrs", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualResourceHrs, 0, 4, 9);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "PlannedCost", typeof(System.Decimal), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.PlannedCost, 0, 4, 19);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualCost, 0, 4, 19);
			base.AddElementFieldInfo("WorkOrderRoutingEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ModifiedDate, 0, 0, 0);
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




