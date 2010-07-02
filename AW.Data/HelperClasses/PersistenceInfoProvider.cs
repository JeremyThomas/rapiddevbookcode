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
			base.InitClass((68 + 1));
			InitAddressEntityMappings();
			InitAddressTypeEntityMappings();
			InitBillOfMaterialsEntityMappings();
			InitContactEntityMappings();
			InitContactCreditCardEntityMappings();
			InitContactTypeEntityMappings();
			InitCountryRegionEntityMappings();
			InitCountryRegionCurrencyEntityMappings();
			InitCreditCardEntityMappings();
			InitCultureEntityMappings();
			InitCurrencyEntityMappings();
			InitCurrencyRateEntityMappings();
			InitCustomerEntityMappings();
			InitCustomerAddressEntityMappings();
			InitCustomerViewRelatedEntityMappings();
			InitDepartmentEntityMappings();
			InitDocumentEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeAddressEntityMappings();
			InitEmployeeDepartmentHistoryEntityMappings();
			InitEmployeePayHistoryEntityMappings();
			InitIllustrationEntityMappings();
			InitIndividualEntityMappings();
			InitJobCandidateEntityMappings();
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
			InitProductVendorEntityMappings();
			InitPurchaseOrderDetailEntityMappings();
			InitPurchaseOrderHeaderEntityMappings();
			InitSalesOrderDetailEntityMappings();
			InitSalesOrderHeaderEntityMappings();
			InitSalesOrderHeaderSalesReasonEntityMappings();
			InitSalesPersonEntityMappings();
			InitSalesPersonQuotaHistoryEntityMappings();
			InitSalesReasonEntityMappings();
			InitSalesTaxRateEntityMappings();
			InitSalesTerritoryEntityMappings();
			InitSalesTerritoryHistoryEntityMappings();
			InitScrapReasonEntityMappings();
			InitShiftEntityMappings();
			InitShipMethodEntityMappings();
			InitShoppingCartItemEntityMappings();
			InitSpecialOfferEntityMappings();
			InitSpecialOfferProductEntityMappings();
			InitStateProvinceEntityMappings();
			InitStoreEntityMappings();
			InitStoreContactEntityMappings();
			InitTransactionHistoryEntityMappings();
			InitTransactionHistoryArchiveEntityMappings();
			InitUnitMeasureEntityMappings();
			InitVendorEntityMappings();
			InitVendorAddressEntityMappings();
			InitVendorContactEntityMappings();
			InitWorkOrderEntityMappings();
			InitWorkOrderRoutingEntityMappings();
			InitCustomerViewTypedViewMappings();
		}


		/// <summary>Inits AddressEntity's mappings</summary>
		private void InitAddressEntityMappings()
		{
			base.AddElementMapping( "AddressEntity", "AdventureWorks", @"Person", "Address", 8 );
			base.AddElementFieldMapping( "AddressEntity", "AddressID", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AddressEntity", "AddressLine1", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AddressEntity", "AddressLine2", "AddressLine2", true, (int)SqlDbType.NVarChar, 60, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AddressEntity", "City", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "AddressEntity", "StateProvinceID", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "AddressEntity", "PostalCode", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "AddressEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			base.AddElementFieldMapping( "AddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits AddressTypeEntity's mappings</summary>
		private void InitAddressTypeEntityMappings()
		{
			base.AddElementMapping( "AddressTypeEntity", "AdventureWorks", @"Person", "AddressType", 4 );
			base.AddElementFieldMapping( "AddressTypeEntity", "AddressTypeID", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AddressTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AddressTypeEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "AddressTypeEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits BillOfMaterialsEntity's mappings</summary>
		private void InitBillOfMaterialsEntityMappings()
		{
			base.AddElementMapping( "BillOfMaterialsEntity", "AdventureWorks", @"Production", "BillOfMaterials", 9 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "BillOfMaterialsID", "BillOfMaterialsID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "ProductAssemblyID", "ProductAssemblyID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "ComponentID", "ComponentID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "UnitMeasureCode", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "Bomlevel", "BOMLevel", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "PerAssemblyQty", "PerAssemblyQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "BillOfMaterialsEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
		}
		/// <summary>Inits ContactEntity's mappings</summary>
		private void InitContactEntityMappings()
		{
			base.AddElementMapping( "ContactEntity", "AdventureWorks", @"Person", "Contact", 15 );
			base.AddElementFieldMapping( "ContactEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ContactEntity", "NameStyle", "NameStyle", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			base.AddElementFieldMapping( "ContactEntity", "Title", "Title", true, (int)SqlDbType.NVarChar, 8, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ContactEntity", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ContactEntity", "MiddleName", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ContactEntity", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ContactEntity", "Suffix", "Suffix", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ContactEntity", "EmailAddress", "EmailAddress", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ContactEntity", "EmailPromotion", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "ContactEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ContactEntity", "PasswordHash", "PasswordHash", false, (int)SqlDbType.VarChar, 128, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ContactEntity", "PasswordSalt", "PasswordSalt", false, (int)SqlDbType.VarChar, 10, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ContactEntity", "AdditionalContactInfo", "AdditionalContactInfo", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "ContactEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 13 );
			base.AddElementFieldMapping( "ContactEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
		}
		/// <summary>Inits ContactCreditCardEntity's mappings</summary>
		private void InitContactCreditCardEntityMappings()
		{
			base.AddElementMapping( "ContactCreditCardEntity", "AdventureWorks", @"Sales", "ContactCreditCard", 3 );
			base.AddElementFieldMapping( "ContactCreditCardEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ContactCreditCardEntity", "CreditCardID", "CreditCardID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ContactCreditCardEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits ContactTypeEntity's mappings</summary>
		private void InitContactTypeEntityMappings()
		{
			base.AddElementMapping( "ContactTypeEntity", "AdventureWorks", @"Person", "ContactType", 3 );
			base.AddElementFieldMapping( "ContactTypeEntity", "ContactTypeID", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ContactTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ContactTypeEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits CountryRegionEntity's mappings</summary>
		private void InitCountryRegionEntityMappings()
		{
			base.AddElementMapping( "CountryRegionEntity", "AdventureWorks", @"Person", "CountryRegion", 3 );
			base.AddElementFieldMapping( "CountryRegionEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CountryRegionEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CountryRegionEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits CountryRegionCurrencyEntity's mappings</summary>
		private void InitCountryRegionCurrencyEntityMappings()
		{
			base.AddElementMapping( "CountryRegionCurrencyEntity", "AdventureWorks", @"Sales", "CountryRegionCurrency", 3 );
			base.AddElementFieldMapping( "CountryRegionCurrencyEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CountryRegionCurrencyEntity", "CurrencyCode", "CurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CountryRegionCurrencyEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits CreditCardEntity's mappings</summary>
		private void InitCreditCardEntityMappings()
		{
			base.AddElementMapping( "CreditCardEntity", "AdventureWorks", @"Sales", "CreditCard", 6 );
			base.AddElementFieldMapping( "CreditCardEntity", "CreditCardID", "CreditCardID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CreditCardEntity", "CardType", "CardType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CreditCardEntity", "CardNumber", "CardNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CreditCardEntity", "ExpMonth", "ExpMonth", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "CreditCardEntity", "ExpYear", "ExpYear", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			base.AddElementFieldMapping( "CreditCardEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits CultureEntity's mappings</summary>
		private void InitCultureEntityMappings()
		{
			base.AddElementMapping( "CultureEntity", "AdventureWorks", @"Production", "Culture", 3 );
			base.AddElementFieldMapping( "CultureEntity", "CultureID", "CultureID", false, (int)SqlDbType.NChar, 6, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CultureEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CultureEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
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
			base.AddElementFieldMapping( "CurrencyRateEntity", "CurrencyRateID", "CurrencyRateID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
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
			base.AddElementFieldMapping( "CustomerEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerEntity", "TerritoryID", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "CustomerEntity", "AccountNumber", "AccountNumber", false, (int)SqlDbType.VarChar, 10, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CustomerEntity", "CustomerType", "CustomerType", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CustomerEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "CustomerEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits CustomerAddressEntity's mappings</summary>
		private void InitCustomerAddressEntityMappings()
		{
			base.AddElementMapping( "CustomerAddressEntity", "AdventureWorks", @"Sales", "CustomerAddress", 5 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "AddressID", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "CustomerAddressEntity", "AddressTypeID", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
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
		/// <summary>Inits DepartmentEntity's mappings</summary>
		private void InitDepartmentEntityMappings()
		{
			base.AddElementMapping( "DepartmentEntity", "AdventureWorks", @"HumanResources", "Department", 4 );
			base.AddElementFieldMapping( "DepartmentEntity", "DepartmentID", "DepartmentID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 0 );
			base.AddElementFieldMapping( "DepartmentEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DepartmentEntity", "GroupName", "GroupName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DepartmentEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits DocumentEntity's mappings</summary>
		private void InitDocumentEntityMappings()
		{
			base.AddElementMapping( "DocumentEntity", "AdventureWorks", @"Production", "Document", 10 );
			base.AddElementFieldMapping( "DocumentEntity", "DocumentID", "DocumentID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DocumentEntity", "Title", "Title", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DocumentEntity", "FileName", "FileName", false, (int)SqlDbType.NVarChar, 400, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DocumentEntity", "FileExtension", "FileExtension", false, (int)SqlDbType.NVarChar, 8, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DocumentEntity", "Revision", "Revision", false, (int)SqlDbType.NChar, 5, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DocumentEntity", "ChangeNumber", "ChangeNumber", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "DocumentEntity", "Status", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 6 );
			base.AddElementFieldMapping( "DocumentEntity", "DocumentSummary", "DocumentSummary", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DocumentEntity", "Document", "Document", true, (int)SqlDbType.VarBinary, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 8 );
			base.AddElementFieldMapping( "DocumentEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			base.AddElementMapping( "EmployeeEntity", "AdventureWorks", @"HumanResources", "Employee", 16 );
			base.AddElementFieldMapping( "EmployeeEntity", "EmployeeID", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeEntity", "NationalIdnumber", "NationalIDNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "EmployeeEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "EmployeeEntity", "LoginID", "LoginID", false, (int)SqlDbType.NVarChar, 256, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "EmployeeEntity", "ManagerID", "ManagerID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
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
			base.AddElementFieldMapping( "EmployeeAddressEntity", "EmployeeID", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "AddressID", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "EmployeeAddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits EmployeeDepartmentHistoryEntity's mappings</summary>
		private void InitEmployeeDepartmentHistoryEntityMappings()
		{
			base.AddElementMapping( "EmployeeDepartmentHistoryEntity", "AdventureWorks", @"HumanResources", "EmployeeDepartmentHistory", 6 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "EmployeeID", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "DepartmentID", "DepartmentID", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "ShiftID", "ShiftID", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 2 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "EmployeeDepartmentHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits EmployeePayHistoryEntity's mappings</summary>
		private void InitEmployeePayHistoryEntityMappings()
		{
			base.AddElementMapping( "EmployeePayHistoryEntity", "AdventureWorks", @"HumanResources", "EmployeePayHistory", 5 );
			base.AddElementFieldMapping( "EmployeePayHistoryEntity", "EmployeeID", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeePayHistoryEntity", "RateChangeDate", "RateChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "EmployeePayHistoryEntity", "Rate", "Rate", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "EmployeePayHistoryEntity", "PayFrequency", "PayFrequency", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "EmployeePayHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits IllustrationEntity's mappings</summary>
		private void InitIllustrationEntityMappings()
		{
			base.AddElementMapping( "IllustrationEntity", "AdventureWorks", @"Production", "Illustration", 3 );
			base.AddElementFieldMapping( "IllustrationEntity", "IllustrationID", "IllustrationID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "IllustrationEntity", "Diagram", "Diagram", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "IllustrationEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits IndividualEntity's mappings</summary>
		private void InitIndividualEntityMappings()
		{
			base.AddElementMapping( "IndividualEntity", "AdventureWorks", @"Sales", "Individual", 4 );
			base.AddElementFieldMapping( "IndividualEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "IndividualEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "IndividualEntity", "Demographics", "Demographics", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "IndividualEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits JobCandidateEntity's mappings</summary>
		private void InitJobCandidateEntityMappings()
		{
			base.AddElementMapping( "JobCandidateEntity", "AdventureWorks", @"HumanResources", "JobCandidate", 4 );
			base.AddElementFieldMapping( "JobCandidateEntity", "JobCandidateID", "JobCandidateID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "JobCandidateEntity", "EmployeeID", "EmployeeID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "JobCandidateEntity", "Resume", "Resume", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "JobCandidateEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits LocationEntity's mappings</summary>
		private void InitLocationEntityMappings()
		{
			base.AddElementMapping( "LocationEntity", "AdventureWorks", @"Production", "Location", 5 );
			base.AddElementFieldMapping( "LocationEntity", "LocationID", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 0 );
			base.AddElementFieldMapping( "LocationEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "LocationEntity", "CostRate", "CostRate", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "LocationEntity", "Availability", "Availability", false, (int)SqlDbType.Decimal, 0, 2, 8, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "LocationEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			base.AddElementMapping( "ProductEntity", "AdventureWorks", @"Production", "Product", 25 );
			base.AddElementFieldMapping( "ProductEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
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
			base.AddElementFieldMapping( "ProductEntity", "ProductSubcategoryID", "ProductSubcategoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 18 );
			base.AddElementFieldMapping( "ProductEntity", "ProductModelID", "ProductModelID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 19 );
			base.AddElementFieldMapping( "ProductEntity", "SellStartDate", "SellStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 20 );
			base.AddElementFieldMapping( "ProductEntity", "SellEndDate", "SellEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 21 );
			base.AddElementFieldMapping( "ProductEntity", "DiscontinuedDate", "DiscontinuedDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 22 );
			base.AddElementFieldMapping( "ProductEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 23 );
			base.AddElementFieldMapping( "ProductEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 24 );
		}
		/// <summary>Inits ProductCategoryEntity's mappings</summary>
		private void InitProductCategoryEntityMappings()
		{
			base.AddElementMapping( "ProductCategoryEntity", "AdventureWorks", @"Production", "ProductCategory", 4 );
			base.AddElementFieldMapping( "ProductCategoryEntity", "ProductCategoryID", "ProductCategoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductCategoryEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ProductCategoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "ProductCategoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductCostHistoryEntity's mappings</summary>
		private void InitProductCostHistoryEntityMappings()
		{
			base.AddElementMapping( "ProductCostHistoryEntity", "AdventureWorks", @"Production", "ProductCostHistory", 5 );
			base.AddElementFieldMapping( "ProductCostHistoryEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductCostHistoryEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "ProductCostHistoryEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ProductCostHistoryEntity", "StandardCost", "StandardCost", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "ProductCostHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ProductDescriptionEntity's mappings</summary>
		private void InitProductDescriptionEntityMappings()
		{
			base.AddElementMapping( "ProductDescriptionEntity", "AdventureWorks", @"Production", "ProductDescription", 4 );
			base.AddElementFieldMapping( "ProductDescriptionEntity", "ProductDescriptionID", "ProductDescriptionID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductDescriptionEntity", "Description", "Description", false, (int)SqlDbType.NVarChar, 400, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ProductDescriptionEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "ProductDescriptionEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductDocumentEntity's mappings</summary>
		private void InitProductDocumentEntityMappings()
		{
			base.AddElementMapping( "ProductDocumentEntity", "AdventureWorks", @"Production", "ProductDocument", 3 );
			base.AddElementFieldMapping( "ProductDocumentEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductDocumentEntity", "DocumentID", "DocumentID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductDocumentEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits ProductInventoryEntity's mappings</summary>
		private void InitProductInventoryEntityMappings()
		{
			base.AddElementMapping( "ProductInventoryEntity", "AdventureWorks", @"Production", "ProductInventory", 7 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "LocationID", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "Shelf", "Shelf", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "Bin", "Bin", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "Quantity", "Quantity", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			base.AddElementFieldMapping( "ProductInventoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits ProductListPriceHistoryEntity's mappings</summary>
		private void InitProductListPriceHistoryEntityMappings()
		{
			base.AddElementMapping( "ProductListPriceHistoryEntity", "AdventureWorks", @"Production", "ProductListPriceHistory", 5 );
			base.AddElementFieldMapping( "ProductListPriceHistoryEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductListPriceHistoryEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "ProductListPriceHistoryEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ProductListPriceHistoryEntity", "ListPrice", "ListPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "ProductListPriceHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ProductModelEntity's mappings</summary>
		private void InitProductModelEntityMappings()
		{
			base.AddElementMapping( "ProductModelEntity", "AdventureWorks", @"Production", "ProductModel", 6 );
			base.AddElementFieldMapping( "ProductModelEntity", "ProductModelID", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductModelEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ProductModelEntity", "CatalogDescription", "CatalogDescription", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductModelEntity", "Instructions", "Instructions", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ProductModelEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "ProductModelEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits ProductModelIllustrationEntity's mappings</summary>
		private void InitProductModelIllustrationEntityMappings()
		{
			base.AddElementMapping( "ProductModelIllustrationEntity", "AdventureWorks", @"Production", "ProductModelIllustration", 3 );
			base.AddElementFieldMapping( "ProductModelIllustrationEntity", "ProductModelID", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductModelIllustrationEntity", "IllustrationID", "IllustrationID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductModelIllustrationEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits ProductModelProductDescriptionCultureEntity's mappings</summary>
		private void InitProductModelProductDescriptionCultureEntityMappings()
		{
			base.AddElementMapping( "ProductModelProductDescriptionCultureEntity", "AdventureWorks", @"Production", "ProductModelProductDescriptionCulture", 4 );
			base.AddElementFieldMapping( "ProductModelProductDescriptionCultureEntity", "ProductModelID", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductModelProductDescriptionCultureEntity", "ProductDescriptionID", "ProductDescriptionID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductModelProductDescriptionCultureEntity", "CultureID", "CultureID", false, (int)SqlDbType.NChar, 6, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductModelProductDescriptionCultureEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductPhotoEntity's mappings</summary>
		private void InitProductPhotoEntityMappings()
		{
			base.AddElementMapping( "ProductPhotoEntity", "AdventureWorks", @"Production", "ProductPhoto", 6 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "ProductPhotoID", "ProductPhotoID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "ThumbNailPhoto", "ThumbNailPhoto", true, (int)SqlDbType.VarBinary, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 1 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "ThumbnailPhotoFileName", "ThumbnailPhotoFileName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "LargePhoto", "LargePhoto", true, (int)SqlDbType.VarBinary, 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "LargePhotoFileName", "LargePhotoFileName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits ProductProductPhotoEntity's mappings</summary>
		private void InitProductProductPhotoEntityMappings()
		{
			base.AddElementMapping( "ProductProductPhotoEntity", "AdventureWorks", @"Production", "ProductProductPhoto", 4 );
			base.AddElementFieldMapping( "ProductProductPhotoEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductProductPhotoEntity", "ProductPhotoID", "ProductPhotoID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductProductPhotoEntity", "Primary", "Primary", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			base.AddElementFieldMapping( "ProductProductPhotoEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ProductReviewEntity's mappings</summary>
		private void InitProductReviewEntityMappings()
		{
			base.AddElementMapping( "ProductReviewEntity", "AdventureWorks", @"Production", "ProductReview", 8 );
			base.AddElementFieldMapping( "ProductReviewEntity", "ProductReviewID", "ProductReviewID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductReviewEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductReviewEntity", "ReviewerName", "ReviewerName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductReviewEntity", "ReviewDate", "ReviewDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "ProductReviewEntity", "EmailAddress", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ProductReviewEntity", "Rating", "Rating", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "ProductReviewEntity", "Comments", "Comments", true, (int)SqlDbType.NVarChar, 3850, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ProductReviewEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits ProductSubcategoryEntity's mappings</summary>
		private void InitProductSubcategoryEntityMappings()
		{
			base.AddElementMapping( "ProductSubcategoryEntity", "AdventureWorks", @"Production", "ProductSubcategory", 5 );
			base.AddElementFieldMapping( "ProductSubcategoryEntity", "ProductSubcategoryID", "ProductSubcategoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductSubcategoryEntity", "ProductCategoryID", "ProductCategoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductSubcategoryEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ProductSubcategoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			base.AddElementFieldMapping( "ProductSubcategoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ProductVendorEntity's mappings</summary>
		private void InitProductVendorEntityMappings()
		{
			base.AddElementMapping( "ProductVendorEntity", "AdventureWorks", @"Purchasing", "ProductVendor", 11 );
			base.AddElementFieldMapping( "ProductVendorEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ProductVendorEntity", "VendorID", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ProductVendorEntity", "AverageLeadTime", "AverageLeadTime", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ProductVendorEntity", "StandardPrice", "StandardPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "ProductVendorEntity", "LastReceiptCost", "LastReceiptCost", true, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "ProductVendorEntity", "LastReceiptDate", "LastReceiptDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "ProductVendorEntity", "MinOrderQty", "MinOrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "ProductVendorEntity", "MaxOrderQty", "MaxOrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "ProductVendorEntity", "OnOrderQty", "OnOrderQty", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "ProductVendorEntity", "UnitMeasureCode", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ProductVendorEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
		}
		/// <summary>Inits PurchaseOrderDetailEntity's mappings</summary>
		private void InitPurchaseOrderDetailEntityMappings()
		{
			base.AddElementMapping( "PurchaseOrderDetailEntity", "AdventureWorks", @"Purchasing", "PurchaseOrderDetail", 11 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "PurchaseOrderID", "PurchaseOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "PurchaseOrderDetailID", "PurchaseOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "DueDate", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "OrderQty", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "UnitPrice", "UnitPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "LineTotal", "LineTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "ReceivedQty", "ReceivedQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "RejectedQty", "RejectedQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "StockedQty", "StockedQty", false, (int)SqlDbType.Decimal, 0, 2, 9, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "PurchaseOrderDetailEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
		}
		/// <summary>Inits PurchaseOrderHeaderEntity's mappings</summary>
		private void InitPurchaseOrderHeaderEntityMappings()
		{
			base.AddElementMapping( "PurchaseOrderHeaderEntity", "AdventureWorks", @"Purchasing", "PurchaseOrderHeader", 13 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "PurchaseOrderID", "PurchaseOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 1 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "Status", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 2 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "EmployeeID", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "VendorID", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "ShipMethodID", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "OrderDate", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "ShipDate", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "SubTotal", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "TaxAmt", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "Freight", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "TotalDue", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "PurchaseOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
		}
		/// <summary>Inits SalesOrderDetailEntity's mappings</summary>
		private void InitSalesOrderDetailEntityMappings()
		{
			base.AddElementMapping( "SalesOrderDetailEntity", "AdventureWorks", @"Sales", "SalesOrderDetail", 11 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderID", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SalesOrderDetailID", "SalesOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "CarrierTrackingNumber", "CarrierTrackingNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "OrderQty", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "SalesOrderDetailEntity", "SpecialOfferID", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
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
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderID", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "RevisionNumber", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 1 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "OrderDate", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "DueDate", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipDate", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Status", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 5 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "OnlineOrderFlag", "OnlineOrderFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesOrderNumber", "SalesOrderNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "PurchaseOrderNumber", "PurchaseOrderNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "AccountNumber", "AccountNumber", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SalesPersonID", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TerritoryID", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "BillToAddressID", "BillToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipToAddressID", "ShipToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 15 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ShipMethodID", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 16 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardID", "CreditCardID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 17 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CreditCardApprovalCode", "CreditCardApprovalCode", true, (int)SqlDbType.VarChar, 15, 0, 0, false, "", null, typeof(System.String), 18 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "CurrencyRateID", "CurrencyRateID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 19 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "SubTotal", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TaxAmt", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Freight", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "TotalDue", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 23 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Comment", "Comment", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 25 );
			base.AddElementFieldMapping( "SalesOrderHeaderEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 26 );
		}
		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's mappings</summary>
		private void InitSalesOrderHeaderSalesReasonEntityMappings()
		{
			base.AddElementMapping( "SalesOrderHeaderSalesReasonEntity", "AdventureWorks", @"Sales", "SalesOrderHeaderSalesReason", 3 );
			base.AddElementFieldMapping( "SalesOrderHeaderSalesReasonEntity", "SalesOrderID", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesOrderHeaderSalesReasonEntity", "SalesReasonID", "SalesReasonID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesOrderHeaderSalesReasonEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits SalesPersonEntity's mappings</summary>
		private void InitSalesPersonEntityMappings()
		{
			base.AddElementMapping( "SalesPersonEntity", "AdventureWorks", @"Sales", "SalesPerson", 9 );
			base.AddElementFieldMapping( "SalesPersonEntity", "SalesPersonID", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesPersonEntity", "TerritoryID", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesPersonEntity", "SalesQuota", "SalesQuota", true, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "SalesPersonEntity", "Bonus", "Bonus", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "SalesPersonEntity", "CommissionPct", "CommissionPct", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "SalesPersonEntity", "SalesYtd", "SalesYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "SalesPersonEntity", "SalesLastYear", "SalesLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "SalesPersonEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 7 );
			base.AddElementFieldMapping( "SalesPersonEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
		}
		/// <summary>Inits SalesPersonQuotaHistoryEntity's mappings</summary>
		private void InitSalesPersonQuotaHistoryEntityMappings()
		{
			base.AddElementMapping( "SalesPersonQuotaHistoryEntity", "AdventureWorks", @"Sales", "SalesPersonQuotaHistory", 5 );
			base.AddElementFieldMapping( "SalesPersonQuotaHistoryEntity", "SalesPersonID", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesPersonQuotaHistoryEntity", "QuotaDate", "QuotaDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "SalesPersonQuotaHistoryEntity", "SalesQuota", "SalesQuota", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "SalesPersonQuotaHistoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			base.AddElementFieldMapping( "SalesPersonQuotaHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits SalesReasonEntity's mappings</summary>
		private void InitSalesReasonEntityMappings()
		{
			base.AddElementMapping( "SalesReasonEntity", "AdventureWorks", @"Sales", "SalesReason", 4 );
			base.AddElementFieldMapping( "SalesReasonEntity", "SalesReasonID", "SalesReasonID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesReasonEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SalesReasonEntity", "ReasonType", "ReasonType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "SalesReasonEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits SalesTaxRateEntity's mappings</summary>
		private void InitSalesTaxRateEntityMappings()
		{
			base.AddElementMapping( "SalesTaxRateEntity", "AdventureWorks", @"Sales", "SalesTaxRate", 7 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "SalesTaxRateID", "SalesTaxRateID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "StateProvinceID", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "TaxType", "TaxType", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 2 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "TaxRate", "TaxRate", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 5 );
			base.AddElementFieldMapping( "SalesTaxRateEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits SalesTerritoryEntity's mappings</summary>
		private void InitSalesTerritoryEntityMappings()
		{
			base.AddElementMapping( "SalesTerritoryEntity", "AdventureWorks", @"Sales", "SalesTerritory", 10 );
			base.AddElementFieldMapping( "SalesTerritoryEntity", "TerritoryID", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
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
		/// <summary>Inits SalesTerritoryHistoryEntity's mappings</summary>
		private void InitSalesTerritoryHistoryEntityMappings()
		{
			base.AddElementMapping( "SalesTerritoryHistoryEntity", "AdventureWorks", @"Sales", "SalesTerritoryHistory", 6 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "SalesPersonID", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "TerritoryID", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "SalesTerritoryHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits ScrapReasonEntity's mappings</summary>
		private void InitScrapReasonEntityMappings()
		{
			base.AddElementMapping( "ScrapReasonEntity", "AdventureWorks", @"Production", "ScrapReason", 3 );
			base.AddElementFieldMapping( "ScrapReasonEntity", "ScrapReasonID", "ScrapReasonID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 0 );
			base.AddElementFieldMapping( "ScrapReasonEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ScrapReasonEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits ShiftEntity's mappings</summary>
		private void InitShiftEntityMappings()
		{
			base.AddElementMapping( "ShiftEntity", "AdventureWorks", @"HumanResources", "Shift", 5 );
			base.AddElementFieldMapping( "ShiftEntity", "ShiftID", "ShiftID", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, "SCOPE_IDENTITY()", null, typeof(System.Byte), 0 );
			base.AddElementFieldMapping( "ShiftEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ShiftEntity", "StartTime", "StartTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ShiftEntity", "EndTime", "EndTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "ShiftEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ShipMethodEntity's mappings</summary>
		private void InitShipMethodEntityMappings()
		{
			base.AddElementMapping( "ShipMethodEntity", "AdventureWorks", @"Purchasing", "ShipMethod", 6 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipMethodID", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ShipMethodEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipBase", "ShipBase", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ShipRate", "ShipRate", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "ShipMethodEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "ShipMethodEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits ShoppingCartItemEntity's mappings</summary>
		private void InitShoppingCartItemEntityMappings()
		{
			base.AddElementMapping( "ShoppingCartItemEntity", "AdventureWorks", @"Sales", "ShoppingCartItem", 6 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "ShoppingCartItemID", "ShoppingCartItemID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "ShoppingCartID", "ShoppingCartID", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "Quantity", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "DateCreated", "DateCreated", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "ShoppingCartItemEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits SpecialOfferEntity's mappings</summary>
		private void InitSpecialOfferEntityMappings()
		{
			base.AddElementMapping( "SpecialOfferEntity", "AdventureWorks", @"Sales", "SpecialOffer", 11 );
			base.AddElementFieldMapping( "SpecialOfferEntity", "SpecialOfferID", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
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
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "SpecialOfferID", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			base.AddElementFieldMapping( "SpecialOfferProductEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits StateProvinceEntity's mappings</summary>
		private void InitStateProvinceEntityMappings()
		{
			base.AddElementMapping( "StateProvinceEntity", "AdventureWorks", @"Person", "StateProvince", 8 );
			base.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceID", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "StateProvinceEntity", "StateProvinceCode", "StateProvinceCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "StateProvinceEntity", "CountryRegionCode", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "StateProvinceEntity", "IsOnlyStateProvinceFlag", "IsOnlyStateProvinceFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "StateProvinceEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "StateProvinceEntity", "TerritoryID", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "StateProvinceEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 6 );
			base.AddElementFieldMapping( "StateProvinceEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits StoreEntity's mappings</summary>
		private void InitStoreEntityMappings()
		{
			base.AddElementMapping( "StoreEntity", "AdventureWorks", @"Sales", "Store", 6 );
			base.AddElementFieldMapping( "StoreEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "StoreEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "StoreEntity", "SalesPersonID", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "StoreEntity", "Demographics", "Demographics", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "StoreEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
			base.AddElementFieldMapping( "StoreEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits StoreContactEntity's mappings</summary>
		private void InitStoreContactEntityMappings()
		{
			base.AddElementMapping( "StoreContactEntity", "AdventureWorks", @"Sales", "StoreContact", 5 );
			base.AddElementFieldMapping( "StoreContactEntity", "CustomerID", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "StoreContactEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "StoreContactEntity", "ContactTypeID", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "StoreContactEntity", "Rowguid", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 3 );
			base.AddElementFieldMapping( "StoreContactEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits TransactionHistoryEntity's mappings</summary>
		private void InitTransactionHistoryEntityMappings()
		{
			base.AddElementMapping( "TransactionHistoryEntity", "AdventureWorks", @"Production", "TransactionHistory", 9 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "TransactionID", "TransactionID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "ReferenceOrderID", "ReferenceOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "ReferenceOrderLineID", "ReferenceOrderLineID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "TransactionDate", "TransactionDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "TransactionType", "TransactionType", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "Quantity", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "ActualCost", "ActualCost", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "TransactionHistoryEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
		}
		/// <summary>Inits TransactionHistoryArchiveEntity's mappings</summary>
		private void InitTransactionHistoryArchiveEntityMappings()
		{
			base.AddElementMapping( "TransactionHistoryArchiveEntity", "AdventureWorks", @"Production", "TransactionHistoryArchive", 9 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "TransactionID", "TransactionID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "ReferenceOrderID", "ReferenceOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "ReferenceOrderLineID", "ReferenceOrderLineID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "TransactionDate", "TransactionDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "TransactionType", "TransactionType", false, (int)SqlDbType.NChar, 1, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "Quantity", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "ActualCost", "ActualCost", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "TransactionHistoryArchiveEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
		}
		/// <summary>Inits UnitMeasureEntity's mappings</summary>
		private void InitUnitMeasureEntityMappings()
		{
			base.AddElementMapping( "UnitMeasureEntity", "AdventureWorks", @"Production", "UnitMeasure", 3 );
			base.AddElementFieldMapping( "UnitMeasureEntity", "UnitMeasureCode", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "UnitMeasureEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "UnitMeasureEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits VendorEntity's mappings</summary>
		private void InitVendorEntityMappings()
		{
			base.AddElementMapping( "VendorEntity", "AdventureWorks", @"Purchasing", "Vendor", 8 );
			base.AddElementFieldMapping( "VendorEntity", "VendorID", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "VendorEntity", "AccountNumber", "AccountNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "VendorEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "VendorEntity", "CreditRating", "CreditRating", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, "", null, typeof(System.Byte), 3 );
			base.AddElementFieldMapping( "VendorEntity", "PreferredVendorStatus", "PreferredVendorStatus", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "VendorEntity", "ActiveFlag", "ActiveFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "VendorEntity", "PurchasingWebServiceUrl", "PurchasingWebServiceURL", true, (int)SqlDbType.NVarChar, 1024, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "VendorEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits VendorAddressEntity's mappings</summary>
		private void InitVendorAddressEntityMappings()
		{
			base.AddElementMapping( "VendorAddressEntity", "AdventureWorks", @"Purchasing", "VendorAddress", 4 );
			base.AddElementFieldMapping( "VendorAddressEntity", "VendorID", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "VendorAddressEntity", "AddressID", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "VendorAddressEntity", "AddressTypeID", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "VendorAddressEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits VendorContactEntity's mappings</summary>
		private void InitVendorContactEntityMappings()
		{
			base.AddElementMapping( "VendorContactEntity", "AdventureWorks", @"Purchasing", "VendorContact", 4 );
			base.AddElementFieldMapping( "VendorContactEntity", "VendorID", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "VendorContactEntity", "ContactID", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "VendorContactEntity", "ContactTypeID", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "VendorContactEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits WorkOrderEntity's mappings</summary>
		private void InitWorkOrderEntityMappings()
		{
			base.AddElementMapping( "WorkOrderEntity", "AdventureWorks", @"Production", "WorkOrder", 10 );
			base.AddElementFieldMapping( "WorkOrderEntity", "WorkOrderID", "WorkOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WorkOrderEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WorkOrderEntity", "OrderQty", "OrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "WorkOrderEntity", "StockedQty", "StockedQty", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "WorkOrderEntity", "ScrappedQty", "ScrappedQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			base.AddElementFieldMapping( "WorkOrderEntity", "StartDate", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "WorkOrderEntity", "EndDate", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "WorkOrderEntity", "DueDate", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "WorkOrderEntity", "ScrapReasonID", "ScrapReasonID", true, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
			base.AddElementFieldMapping( "WorkOrderEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
		}
		/// <summary>Inits WorkOrderRoutingEntity's mappings</summary>
		private void InitWorkOrderRoutingEntityMappings()
		{
			base.AddElementMapping( "WorkOrderRoutingEntity", "AdventureWorks", @"Production", "WorkOrderRouting", 12 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "WorkOrderID", "WorkOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ProductID", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "OperationSequence", "OperationSequence", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "LocationID", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ScheduledStartDate", "ScheduledStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ScheduledEndDate", "ScheduledEndDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ActualStartDate", "ActualStartDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ActualEndDate", "ActualEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ActualResourceHrs", "ActualResourceHrs", true, (int)SqlDbType.Decimal, 0, 4, 9, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "PlannedCost", "PlannedCost", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ActualCost", "ActualCost", true, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "WorkOrderRoutingEntity", "ModifiedDate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
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