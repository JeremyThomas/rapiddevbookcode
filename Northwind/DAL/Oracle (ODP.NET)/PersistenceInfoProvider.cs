///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Oracle
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
			this.InitClass(29);
			InitCategoryEntityMappings();
			InitCustomerEntityMappings();
			InitCustomerCustomerDemoEntityMappings();
			InitCustomerDemographicEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeTerritoryEntityMappings();
			InitOrderEntityMappings();
			InitOrderDetailEntityMappings();
			InitProductEntityMappings();
			InitRegionEntityMappings();
			InitShipperEntityMappings();
			InitSupplierEntityMappings();
			InitTerritoryEntityMappings();
			InitAlphabeticalListOfProductTypedViewMappings();
			InitCategorySalesFor1997TypedViewMappings();
			InitCurrentProductListTypedViewMappings();
			InitCustomerAndSuppliersByCityTypedViewMappings();
			InitInvoiceTypedViewMappings();
			InitOrderDetailsExtendedTypedViewMappings();
			InitOrdersQryTypedViewMappings();
			InitOrderSubtotalTypedViewMappings();
			InitProductsAboveAveragePriceTypedViewMappings();
			InitProductSalesFor1997TypedViewMappings();
			InitProductsByCategoryTypedViewMappings();
			InitQuarterlyOrderTypedViewMappings();
			InitSalesByCategoryTypedViewMappings();
			InitSalesTotalsByAmountTypedViewMappings();
			InitSummaryOfSalesByQuarterTypedViewMappings();
			InitSummaryOfSalesByYearTypedViewMappings();
		}

		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping("CategoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CATEGORIES", 4, 0);
			this.AddElementFieldMapping("CategoryEntity", "CategoryId", "CATEGORYID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.CATEGORIES_CATEGORYID_SEQ", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 0);
			this.AddElementFieldMapping("CategoryEntity", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CategoryEntity", "Description", "DESCRIPTION", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CategoryEntity", "Picture", "PICTURE", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3);
		}

		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping("CustomerEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERS", 11, 0);
			this.AddElementFieldMapping("CustomerEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerEntity", "ContactName", "CONTACTNAME", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("CustomerEntity", "ContactTitle", "CONTACTTITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomerEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("CustomerEntity", "CustomerId", "CUSTOMERID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CustomerEntity", "Fax", "FAX", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("CustomerEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("CustomerEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("CustomerEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits CustomerCustomerDemoEntity's mappings</summary>
		private void InitCustomerCustomerDemoEntityMappings()
		{
			this.AddElementMapping("CustomerCustomerDemoEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERCUSTOMERDEMO", 2, 0);
			this.AddElementFieldMapping("CustomerCustomerDemoEntity", "CustomerId", "CUSTOMERID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerCustomerDemoEntity", "CustomerTypeId", "CUSTOMERTYPEID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits CustomerDemographicEntity's mappings</summary>
		private void InitCustomerDemographicEntityMappings()
		{
			this.AddElementMapping("CustomerDemographicEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERDEMOGRAPHICS", 2, 0);
			this.AddElementFieldMapping("CustomerDemographicEntity", "CustomerDesc", "CUSTOMERDESC", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerDemographicEntity", "CustomerTypeId", "CUSTOMERTYPEID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"//localhost/xe", @"DBO_NORTHWIND", "EMPLOYEES", 18, 0);
			this.AddElementFieldMapping("EmployeeEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EmployeeEntity", "BirthDate", "BIRTHDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("EmployeeEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("EmployeeEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "EmployeeId", "EMPLOYEEID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.EMPLOYEES_EMPLOYEEID_SEQ", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 4);
			this.AddElementFieldMapping("EmployeeEntity", "Extension", "EXTENSION", true, "NVarchar2", 4, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("EmployeeEntity", "FirstName", "FIRSTNAME", false, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeeEntity", "HireDate", "HIREDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("EmployeeEntity", "HomePhone", "HOMEPHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("EmployeeEntity", "LastName", "LASTNAME", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeeEntity", "Notes", "NOTES", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("EmployeeEntity", "Photo", "PHOTO", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11);
			this.AddElementFieldMapping("EmployeeEntity", "PhotoPath", "PHOTOPATH", true, "NVarchar2", 255, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("EmployeeEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("EmployeeEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("EmployeeEntity", "ReportsTo", "REPORTSTO", true, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 15);
			this.AddElementFieldMapping("EmployeeEntity", "Title", "TITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 16);
			this.AddElementFieldMapping("EmployeeEntity", "TitleOfCourtesy", "TITLEOFCOURTESY", true, "NVarchar2", 25, 0, 0, false, "", null, typeof(System.String), 17);
		}

		/// <summary>Inits EmployeeTerritoryEntity's mappings</summary>
		private void InitEmployeeTerritoryEntityMappings()
		{
			this.AddElementMapping("EmployeeTerritoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "EMPLOYEETERRITORIES", 2, 0);
			this.AddElementFieldMapping("EmployeeTerritoryEntity", "EmployeeId", "EMPLOYEEID", false, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 0);
			this.AddElementFieldMapping("EmployeeTerritoryEntity", "TerritoryId", "TERRITORYID", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping("OrderEntity", @"//localhost/xe", @"DBO_NORTHWIND", "ORDERS", 14, 0);
			this.AddElementFieldMapping("OrderEntity", "CustomerId", "CUSTOMERID", true, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("OrderEntity", "EmployeeId", "EMPLOYEEID", true, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 1);
			this.AddElementFieldMapping("OrderEntity", "Freight", "FREIGHT", true, "Decimal", 0, 19, 4, false, "", null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("OrderEntity", "OrderDate", "ORDERDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("OrderEntity", "OrderId", "ORDERID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.ORDERS_ORDERID_SEQ", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 4);
			this.AddElementFieldMapping("OrderEntity", "RequiredDate", "REQUIREDDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("OrderEntity", "ShipAddress", "SHIPADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("OrderEntity", "ShipCity", "SHIPCITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("OrderEntity", "ShipCountry", "SHIPCOUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("OrderEntity", "ShipName", "SHIPNAME", true, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("OrderEntity", "ShippedDate", "SHIPPEDDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("OrderEntity", "ShipPostalCode", "SHIPPOSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 11);
			this.AddElementFieldMapping("OrderEntity", "ShipRegion", "SHIPREGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 12);
			this.AddElementFieldMapping("OrderEntity", "ShipVia", "SHIPVIA", true, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 13);
		}

		/// <summary>Inits OrderDetailEntity's mappings</summary>
		private void InitOrderDetailEntityMappings()
		{
			this.AddElementMapping("OrderDetailEntity", @"//localhost/xe", @"DBO_NORTHWIND", "ORDER_DETAILS", 5, 0);
			this.AddElementFieldMapping("OrderDetailEntity", "Discount", "DISCOUNT", false, "Decimal", 0, 38, 38, false, "", new SD.LLBLGen.Pro.ORMSupportClasses.SingleDecimalConverter(), typeof(System.Decimal), 0);
			this.AddElementFieldMapping("OrderDetailEntity", "OrderId", "ORDERID", false, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 1);
			this.AddElementFieldMapping("OrderDetailEntity", "ProductId", "PRODUCTID", false, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 2);
			this.AddElementFieldMapping("OrderDetailEntity", "Quantity", "QUANTITY", false, "Decimal", 0, 5, 0, false, "", new AW.Helper.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 3);
			this.AddElementFieldMapping("OrderDetailEntity", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 19, 4, false, "", null, typeof(System.Decimal), 4);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"//localhost/xe", @"DBO_NORTHWIND", "PRODUCTS", 10, 0);
			this.AddElementFieldMapping("ProductEntity", "CategoryId", "CATEGORYID", true, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 0);
			this.AddElementFieldMapping("ProductEntity", "Discontinued", "DISCONTINUED", false, "Decimal", 0, 1, 0, false, "", new SD.LLBLGen.Pro.ORMSupportClasses.BooleanNumericConverter(), typeof(System.Int16), 1);
			this.AddElementFieldMapping("ProductEntity", "ProductId", "PRODUCTID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.PRODUCTS_PRODUCTID_SEQ", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 2);
			this.AddElementFieldMapping("ProductEntity", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductEntity", "QuantityPerUnit", "QUANTITYPERUNIT", true, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("ProductEntity", "ReorderLevel", "REORDERLEVEL", true, "Decimal", 0, 5, 0, false, "", new AW.Helper.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 5);
			this.AddElementFieldMapping("ProductEntity", "SupplierId", "SUPPLIERID", true, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 6);
			this.AddElementFieldMapping("ProductEntity", "UnitPrice", "UNITPRICE", true, "Decimal", 0, 19, 4, false, "", null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("ProductEntity", "UnitsInStock", "UNITSINSTOCK", true, "Decimal", 0, 5, 0, false, "", new AW.Helper.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 8);
			this.AddElementFieldMapping("ProductEntity", "UnitsOnOrder", "UNITSONORDER", true, "Decimal", 0, 5, 0, false, "", new AW.Helper.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 9);
		}

		/// <summary>Inits RegionEntity's mappings</summary>
		private void InitRegionEntityMappings()
		{
			this.AddElementMapping("RegionEntity", @"//localhost/xe", @"DBO_NORTHWIND", "REGION", 2, 0);
			this.AddElementFieldMapping("RegionEntity", "RegionDescription", "REGIONDESCRIPTION", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("RegionEntity", "RegionId", "REGIONID", false, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 1);
		}

		/// <summary>Inits ShipperEntity's mappings</summary>
		private void InitShipperEntityMappings()
		{
			this.AddElementMapping("ShipperEntity", @"//localhost/xe", @"DBO_NORTHWIND", "SHIPPERS", 3, 0);
			this.AddElementFieldMapping("ShipperEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ShipperEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ShipperEntity", "ShipperId", "SHIPPERID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.SHIPPERS_SHIPPERID_SEQ", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 2);
		}

		/// <summary>Inits SupplierEntity's mappings</summary>
		private void InitSupplierEntityMappings()
		{
			this.AddElementMapping("SupplierEntity", @"//localhost/xe", @"DBO_NORTHWIND", "SUPPLIERS", 12, 0);
			this.AddElementFieldMapping("SupplierEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("SupplierEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("SupplierEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("SupplierEntity", "ContactName", "CONTACTNAME", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("SupplierEntity", "ContactTitle", "CONTACTTITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("SupplierEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("SupplierEntity", "Fax", "FAX", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("SupplierEntity", "HomePage", "HOMEPAGE", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("SupplierEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("SupplierEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("SupplierEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("SupplierEntity", "SupplierId", "SUPPLIERID", false, "Decimal", 0, 10, 0, false, "DBO_NORTHWIND.SUPPLIERS_SUPPLIERID_SEQ", new AW.Helper.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 11);
		}

		/// <summary>Inits TerritoryEntity's mappings</summary>
		private void InitTerritoryEntityMappings()
		{
			this.AddElementMapping("TerritoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "TERRITORIES", 3, 0);
			this.AddElementFieldMapping("TerritoryEntity", "RegionId", "REGIONID", false, "Decimal", 0, 10, 0, false, "", new AW.Helper.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 0);
			this.AddElementFieldMapping("TerritoryEntity", "TerritoryDescription", "TERRITORYDESCRIPTION", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("TerritoryEntity", "TerritoryId", "TERRITORYID", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 2);
		}


		/// <summary>Inits AlphabeticalListOfProductView's mappings</summary>
		private void InitAlphabeticalListOfProductTypedViewMappings()
		{
			this.AddElementMapping("AlphabeticalListOfProductTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Alphabetical list of products", 11);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "CategoryId", "CATEGORYID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "ProductId", "PRODUCTID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "QuantityPerUnit", "QUANTITYPERUNIT", false, "NVarchar2", 20, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "ReorderLevel", "REORDERLEVEL", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 5);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "SupplierId", "SUPPLIERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "UnitsInStock", "UNITSINSTOCK", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 8);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "UnitsOnOrder", "UNITSONORDER", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 9);
			this.AddElementFieldMapping("AlphabeticalListOfProductTypedView", "Discontinued", "DISCONTINUED", false, "Decimal", 0, 1, 0, false, string.Empty, new SD.LLBLGen.Pro.ORMSupportClasses.BooleanNumericConverter(), typeof(System.Int16), 10);
		}


		/// <summary>Inits CategorySalesFor1997View's mappings</summary>
		private void InitCategorySalesFor1997TypedViewMappings()
		{
			this.AddElementMapping("CategorySalesFor1997TypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Category Sales for 1997", 2);
			this.AddElementFieldMapping("CategorySalesFor1997TypedView", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("CategorySalesFor1997TypedView", "CategorySales", "CATEGORYSALES", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 1);
		}


		/// <summary>Inits CurrentProductListView's mappings</summary>
		private void InitCurrentProductListTypedViewMappings()
		{
			this.AddElementMapping("CurrentProductListTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Current Product List", 2);
			this.AddElementFieldMapping("CurrentProductListTypedView", "ProductId", "PRODUCTID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CurrentProductListTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 1);
		}


		/// <summary>Inits CustomerAndSuppliersByCityView's mappings</summary>
		private void InitCustomerAndSuppliersByCityTypedViewMappings()
		{
			this.AddElementMapping("CustomerAndSuppliersByCityTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Customer and Suppliers by City", 4);
			this.AddElementFieldMapping("CustomerAndSuppliersByCityTypedView", "City", "CITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerAndSuppliersByCityTypedView", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerAndSuppliersByCityTypedView", "ContactName", "CONTACTNAME", false, "NVarchar2", 30, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerAndSuppliersByCityTypedView", "Relationship", "RELATIONSHIP", false, "NVarchar2", 9, 0, 0, false, string.Empty, null, typeof(System.String), 3);
		}


		/// <summary>Inits InvoiceView's mappings</summary>
		private void InitInvoiceTypedViewMappings()
		{
			this.AddElementMapping("InvoiceTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Invoices", 26);
			this.AddElementFieldMapping("InvoiceTypedView", "Address", "ADDRESS", false, "NVarchar2", 60, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("InvoiceTypedView", "City", "CITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("InvoiceTypedView", "Country", "COUNTRY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("InvoiceTypedView", "CustomerId", "CUSTOMERID", false, "NVarchar2", 5, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("InvoiceTypedView", "CustomerName", "CUSTOMERNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("InvoiceTypedView", "Discount", "DISCOUNT", false, "BinaryFloat", 0, 0, 0, false, string.Empty, null, typeof(System.Single), 5);
			this.AddElementFieldMapping("InvoiceTypedView", "ExtendedPrice", "EXTENDEDPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("InvoiceTypedView", "Freight", "FREIGHT", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 7);
			this.AddElementFieldMapping("InvoiceTypedView", "OrderDate", "ORDERDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 8);
			this.AddElementFieldMapping("InvoiceTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("InvoiceTypedView", "PostalCode", "POSTALCODE", false, "NVarchar2", 10, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("InvoiceTypedView", "ProductId", "PRODUCTID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 11);
			this.AddElementFieldMapping("InvoiceTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 12);
			this.AddElementFieldMapping("InvoiceTypedView", "Quantity", "QUANTITY", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 13);
			this.AddElementFieldMapping("InvoiceTypedView", "Region", "REGION", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 14);
			this.AddElementFieldMapping("InvoiceTypedView", "RequiredDate", "REQUIREDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 15);
			this.AddElementFieldMapping("InvoiceTypedView", "Salesperson", "SALESPERSON", false, "NVarchar2", 31, 0, 0, false, string.Empty, null, typeof(System.String), 16);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipAddress", "SHIPADDRESS", false, "NVarchar2", 60, 0, 0, false, string.Empty, null, typeof(System.String), 17);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipCity", "SHIPCITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 18);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipCountry", "SHIPCOUNTRY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 19);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipName", "SHIPNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 20);
			this.AddElementFieldMapping("InvoiceTypedView", "ShippedDate", "SHIPPEDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 21);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipperName", "SHIPPERNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 22);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipPostalCode", "SHIPPOSTALCODE", false, "NVarchar2", 10, 0, 0, false, string.Empty, null, typeof(System.String), 23);
			this.AddElementFieldMapping("InvoiceTypedView", "ShipRegion", "SHIPREGION", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 24);
			this.AddElementFieldMapping("InvoiceTypedView", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 25);
		}


		/// <summary>Inits OrderDetailsExtendedView's mappings</summary>
		private void InitOrderDetailsExtendedTypedViewMappings()
		{
			this.AddElementMapping("OrderDetailsExtendedTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Order Details Extended", 7);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "Discount", "DISCOUNT", false, "BinaryFloat", 0, 0, 0, false, string.Empty, null, typeof(System.Single), 0);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "ExtendedPrice", "EXTENDEDPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 1);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "ProductId", "PRODUCTID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "Quantity", "QUANTITY", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 5);
			this.AddElementFieldMapping("OrderDetailsExtendedTypedView", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 6);
		}


		/// <summary>Inits OrdersQryView's mappings</summary>
		private void InitOrdersQryTypedViewMappings()
		{
			this.AddElementMapping("OrdersQryTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Orders Qry", 20);
			this.AddElementFieldMapping("OrdersQryTypedView", "Address", "ADDRESS", false, "NVarchar2", 60, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("OrdersQryTypedView", "City", "CITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("OrdersQryTypedView", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("OrdersQryTypedView", "Country", "COUNTRY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("OrdersQryTypedView", "CustomerId", "CUSTOMERID", false, "NVarchar2", 5, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("OrdersQryTypedView", "EmployeeId", "EMPLOYEEID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("OrdersQryTypedView", "Freight", "FREIGHT", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("OrdersQryTypedView", "OrderDate", "ORDERDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("OrdersQryTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("OrdersQryTypedView", "PostalCode", "POSTALCODE", false, "NVarchar2", 10, 0, 0, false, string.Empty, null, typeof(System.String), 9);
			this.AddElementFieldMapping("OrdersQryTypedView", "Region", "REGION", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("OrdersQryTypedView", "RequiredDate", "REQUIREDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 11);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipAddress", "SHIPADDRESS", false, "NVarchar2", 60, 0, 0, false, string.Empty, null, typeof(System.String), 12);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipCity", "SHIPCITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 13);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipCountry", "SHIPCOUNTRY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 14);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipName", "SHIPNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 15);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShippedDate", "SHIPPEDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 16);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipPostalCode", "SHIPPOSTALCODE", false, "NVarchar2", 10, 0, 0, false, string.Empty, null, typeof(System.String), 17);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipRegion", "SHIPREGION", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 18);
			this.AddElementFieldMapping("OrdersQryTypedView", "ShipVia", "SHIPVIA", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 19);
		}


		/// <summary>Inits OrderSubtotalView's mappings</summary>
		private void InitOrderSubtotalTypedViewMappings()
		{
			this.AddElementMapping("OrderSubtotalTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Order Subtotals", 2);
			this.AddElementFieldMapping("OrderSubtotalTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("OrderSubtotalTypedView", "Subtotal", "SUBTOTAL", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 1);
		}


		/// <summary>Inits ProductsAboveAveragePriceView's mappings</summary>
		private void InitProductsAboveAveragePriceTypedViewMappings()
		{
			this.AddElementMapping("ProductsAboveAveragePriceTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Products Above Average Price", 2);
			this.AddElementFieldMapping("ProductsAboveAveragePriceTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductsAboveAveragePriceTypedView", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 1);
		}


		/// <summary>Inits ProductSalesFor1997View's mappings</summary>
		private void InitProductSalesFor1997TypedViewMappings()
		{
			this.AddElementMapping("ProductSalesFor1997TypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Product Sales for 1997", 3);
			this.AddElementFieldMapping("ProductSalesFor1997TypedView", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductSalesFor1997TypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("ProductSalesFor1997TypedView", "ProductSales", "PRODUCTSALES", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 2);
		}


		/// <summary>Inits ProductsByCategoryView's mappings</summary>
		private void InitProductsByCategoryTypedViewMappings()
		{
			this.AddElementMapping("ProductsByCategoryTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Products by Category", 5);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "Discontinued", "DISCONTINUED", false, "Decimal", 0, 1, 0, false, string.Empty, new SD.LLBLGen.Pro.ORMSupportClasses.BooleanNumericConverter(), typeof(System.Int16), 1);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "QuantityPerUnit", "QUANTITYPERUNIT", false, "NVarchar2", 20, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductsByCategoryTypedView", "UnitsInStock", "UNITSINSTOCK", false, "Decimal", 0, 4, 0, false, string.Empty, null, typeof(System.Int16), 4);
		}


		/// <summary>Inits QuarterlyOrderView's mappings</summary>
		private void InitQuarterlyOrderTypedViewMappings()
		{
			this.AddElementMapping("QuarterlyOrderTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Quarterly Orders", 4);
			this.AddElementFieldMapping("QuarterlyOrderTypedView", "City", "CITY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("QuarterlyOrderTypedView", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("QuarterlyOrderTypedView", "Country", "COUNTRY", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("QuarterlyOrderTypedView", "CustomerId", "CUSTOMERID", false, "NVarchar2", 5, 0, 0, false, string.Empty, null, typeof(System.String), 3);
		}


		/// <summary>Inits SalesByCategoryView's mappings</summary>
		private void InitSalesByCategoryTypedViewMappings()
		{
			this.AddElementMapping("SalesByCategoryTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Sales by Category", 4);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "CategoryId", "CATEGORYID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("SalesByCategoryTypedView", "ProductSales", "PRODUCTSALES", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 3);
		}


		/// <summary>Inits SalesTotalsByAmountView's mappings</summary>
		private void InitSalesTotalsByAmountTypedViewMappings()
		{
			this.AddElementMapping("SalesTotalsByAmountTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Sales Totals by Amount", 4);
			this.AddElementFieldMapping("SalesTotalsByAmountTypedView", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, string.Empty, null, typeof(System.String), 0);
			this.AddElementFieldMapping("SalesTotalsByAmountTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("SalesTotalsByAmountTypedView", "SaleAmount", "SALEAMOUNT", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 2);
			this.AddElementFieldMapping("SalesTotalsByAmountTypedView", "ShippedDate", "SHIPPEDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 3);
		}


		/// <summary>Inits SummaryOfSalesByQuarterView's mappings</summary>
		private void InitSummaryOfSalesByQuarterTypedViewMappings()
		{
			this.AddElementMapping("SummaryOfSalesByQuarterTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Summary of Sales by Quarter", 3);
			this.AddElementFieldMapping("SummaryOfSalesByQuarterTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SummaryOfSalesByQuarterTypedView", "ShippedDate", "SHIPPEDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SummaryOfSalesByQuarterTypedView", "Subtotal", "SUBTOTAL", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 2);
		}


		/// <summary>Inits SummaryOfSalesByYearView's mappings</summary>
		private void InitSummaryOfSalesByYearTypedViewMappings()
		{
			this.AddElementMapping("SummaryOfSalesByYearTypedView", @"//localhost/xe", @"DBO_NORTHWIND", "Summary of Sales by Year", 3);
			this.AddElementFieldMapping("SummaryOfSalesByYearTypedView", "OrderId", "ORDERID", false, "Decimal", 0, 9, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("SummaryOfSalesByYearTypedView", "ShippedDate", "SHIPPEDDATE", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("SummaryOfSalesByYearTypedView", "Subtotal", "SUBTOTAL", false, "Decimal", 0, 19, 4, false, string.Empty, null, typeof(System.Decimal), 2);
		}

	}
}
