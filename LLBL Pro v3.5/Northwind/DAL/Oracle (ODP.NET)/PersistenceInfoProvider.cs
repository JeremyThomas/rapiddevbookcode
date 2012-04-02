///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
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
			this.InitClass((13 + 0));
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

		}


		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping( "CategoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CATEGORIES", 4 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryId", "CATEGORYID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.CATEGORIES_CATEGORYID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryName", "CATEGORYNAME", false, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CategoryEntity", "Description", "DESCRIPTION", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CategoryEntity", "Picture", "PICTURE", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
		}
		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping( "CustomerEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERS", 11 );
			this.AddElementFieldMapping( "CustomerEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomerEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactName", "CONTACTNAME", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactTitle", "CONTACTTITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomerEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "CustomerEntity", "CustomerId", "CUSTOMERID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomerEntity", "Fax", "FAX", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomerEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "CustomerEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomerEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits CustomerCustomerDemoEntity's mappings</summary>
		private void InitCustomerCustomerDemoEntityMappings()
		{
			this.AddElementMapping( "CustomerCustomerDemoEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERCUSTOMERDEMO", 2 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerId", "CUSTOMERID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerTypeId", "CUSTOMERTYPEID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CustomerDemographicEntity's mappings</summary>
		private void InitCustomerDemographicEntityMappings()
		{
			this.AddElementMapping( "CustomerDemographicEntity", @"//localhost/xe", @"DBO_NORTHWIND", "CUSTOMERDEMOGRAPHICS", 2 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerDesc", "CUSTOMERDESC", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerTypeId", "CUSTOMERTYPEID", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping( "EmployeeEntity", @"//localhost/xe", @"DBO_NORTHWIND", "EMPLOYEES", 18 );
			this.AddElementFieldMapping( "EmployeeEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "EmployeeEntity", "BirthDate", "BIRTHDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "EmployeeEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "EmployeeEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "EmployeeEntity", "EmployeeId", "EMPLOYEEID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.EMPLOYEES_EMPLOYEEID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "EmployeeEntity", "Extension", "EXTENSION", true, "NVarchar2", 4, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "EmployeeEntity", "FirstName", "FIRSTNAME", false, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "EmployeeEntity", "HireDate", "HIREDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "EmployeeEntity", "HomePhone", "HOMEPHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "EmployeeEntity", "LastName", "LASTNAME", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "EmployeeEntity", "Notes", "NOTES", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "EmployeeEntity", "Photo", "PHOTO", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11 );
			this.AddElementFieldMapping( "EmployeeEntity", "PhotoPath", "PHOTOPATH", true, "NVarchar2", 255, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "EmployeeEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "EmployeeEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "EmployeeEntity", "ReportsTo", "REPORTSTO", true, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 15 );
			this.AddElementFieldMapping( "EmployeeEntity", "Title", "TITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "EmployeeEntity", "TitleOfCourtesy", "TITLEOFCOURTESY", true, "NVarchar2", 25, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits EmployeeTerritoryEntity's mappings</summary>
		private void InitEmployeeTerritoryEntityMappings()
		{
			this.AddElementMapping( "EmployeeTerritoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "EMPLOYEETERRITORIES", 2 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "EmployeeId", "EMPLOYEEID", false, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "TerritoryId", "TERRITORYID", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping( "OrderEntity", @"//localhost/xe", @"DBO_NORTHWIND", "ORDERS", 14 );
			this.AddElementFieldMapping( "OrderEntity", "CustomerId", "CUSTOMERID", true, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "OrderEntity", "EmployeeId", "EMPLOYEEID", true, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "OrderEntity", "Freight", "FREIGHT", true, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "OrderEntity", "OrderDate", "ORDERDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "OrderEntity", "OrderId", "ORDERID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.ORDERS_ORDERID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "OrderEntity", "RequiredDate", "REQUIREDDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "OrderEntity", "ShipAddress", "SHIPADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCity", "SHIPCITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCountry", "SHIPCOUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "OrderEntity", "ShipName", "SHIPNAME", true, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "OrderEntity", "ShippedDate", "SHIPPEDDATE", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "OrderEntity", "ShipPostalCode", "SHIPPOSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "OrderEntity", "ShipRegion", "SHIPREGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "OrderEntity", "ShipVia", "SHIPVIA", true, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 13 );
		}
		/// <summary>Inits OrderDetailEntity's mappings</summary>
		private void InitOrderDetailEntityMappings()
		{
			this.AddElementMapping( "OrderDetailEntity", @"//localhost/xe", @"DBO_NORTHWIND", "ORDER_DETAILS", 5 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Discount", "DISCOUNT", false, "Decimal", 0, 38, 38, false, "",  new AW.Helper.LLBL.TypeConverters.SingleNumericConverter(), typeof(System.Decimal), 0 );
			this.AddElementFieldMapping( "OrderDetailEntity", "OrderId", "ORDERID", false, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "OrderDetailEntity", "ProductId", "PRODUCTID", false, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Quantity", "QUANTITY", false, "Decimal", 0, 0, 5, false, "",  new AW.Helper.LLBL.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "OrderDetailEntity", "UnitPrice", "UNITPRICE", false, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping( "ProductEntity", @"//localhost/xe", @"DBO_NORTHWIND", "PRODUCTS", 10 );
			this.AddElementFieldMapping( "ProductEntity", "CategoryId", "CATEGORYID", true, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "ProductEntity", "Discontinued", "DISCONTINUED", false, "Decimal", 0, 0, 1, false, "",  new SD.LLBLGen.Pro.ORMSupportClasses.BooleanNumericConverter(), typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "ProductEntity", "ProductId", "PRODUCTID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.PRODUCTS_PRODUCTID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "ProductEntity", "ProductName", "PRODUCTNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ProductEntity", "QuantityPerUnit", "QUANTITYPERUNIT", true, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ProductEntity", "ReorderLevel", "REORDERLEVEL", true, "Decimal", 0, 0, 5, false, "",  new AW.Helper.LLBL.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 5 );
			this.AddElementFieldMapping( "ProductEntity", "SupplierId", "SUPPLIERID", true, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 6 );
			this.AddElementFieldMapping( "ProductEntity", "UnitPrice", "UNITPRICE", true, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsInStock", "UNITSINSTOCK", true, "Decimal", 0, 0, 5, false, "",  new AW.Helper.LLBL.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 8 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsOnOrder", "UNITSONORDER", true, "Decimal", 0, 0, 5, false, "",  new AW.Helper.LLBL.TypeConverters.SmallIntegerNumericConverter(), typeof(System.Int32), 9 );
		}
		/// <summary>Inits RegionEntity's mappings</summary>
		private void InitRegionEntityMappings()
		{
			this.AddElementMapping( "RegionEntity", @"//localhost/xe", @"DBO_NORTHWIND", "REGION", 2 );
			this.AddElementFieldMapping( "RegionEntity", "RegionDescription", "REGIONDESCRIPTION", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RegionEntity", "RegionId", "REGIONID", false, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 1 );
		}
		/// <summary>Inits ShipperEntity's mappings</summary>
		private void InitShipperEntityMappings()
		{
			this.AddElementMapping( "ShipperEntity", @"//localhost/xe", @"DBO_NORTHWIND", "SHIPPERS", 3 );
			this.AddElementFieldMapping( "ShipperEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ShipperEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ShipperEntity", "ShipperId", "SHIPPERID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.SHIPPERS_SHIPPERID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 2 );
		}
		/// <summary>Inits SupplierEntity's mappings</summary>
		private void InitSupplierEntityMappings()
		{
			this.AddElementMapping( "SupplierEntity", @"//localhost/xe", @"DBO_NORTHWIND", "SUPPLIERS", 12 );
			this.AddElementFieldMapping( "SupplierEntity", "Address", "ADDRESS", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SupplierEntity", "City", "CITY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SupplierEntity", "CompanyName", "COMPANYNAME", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactName", "CONTACTNAME", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactTitle", "CONTACTTITLE", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SupplierEntity", "Country", "COUNTRY", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SupplierEntity", "Fax", "FAX", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SupplierEntity", "HomePage", "HOMEPAGE", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SupplierEntity", "Phone", "PHONE", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SupplierEntity", "PostalCode", "POSTALCODE", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "SupplierEntity", "Region", "REGION", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "SupplierEntity", "SupplierId", "SUPPLIERID", false, "Decimal", 0, 0, 10, true, "DBO_NORTHWIND.SUPPLIERS_SUPPLIERID_SEQ",  new AW.Helper.LLBL.TypeConverters.IntegerNonNullNumericConverter(), typeof(System.Int64), 11 );
		}
		/// <summary>Inits TerritoryEntity's mappings</summary>
		private void InitTerritoryEntityMappings()
		{
			this.AddElementMapping( "TerritoryEntity", @"//localhost/xe", @"DBO_NORTHWIND", "TERRITORIES", 3 );
			this.AddElementFieldMapping( "TerritoryEntity", "RegionId", "REGIONID", false, "Decimal", 0, 0, 10, false, "",  new AW.Helper.LLBL.TypeConverters.IntegerNumericConverter(), typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryDescription", "TERRITORYDESCRIPTION", false, "NChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryId", "TERRITORYID", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 2 );
		}

	}
}