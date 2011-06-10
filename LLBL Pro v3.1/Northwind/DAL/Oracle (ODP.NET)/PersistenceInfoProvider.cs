///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
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
			this.AddElementMapping( "CategoryEntity", "Default", @"Default", "Category", 4 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryId", "CategoryId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Category", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CategoryEntity", "CategoryName", "CategoryName", false, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CategoryEntity", "Description", "Description", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CategoryEntity", "Picture", "Picture", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
		}
		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping( "CustomerEntity", "Default", @"Default", "Customer", 11 );
			this.AddElementFieldMapping( "CustomerEntity", "Address", "Address", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerEntity", "City", "City", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomerEntity", "CompanyName", "CompanyName", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactName", "ContactName", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomerEntity", "ContactTitle", "ContactTitle", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomerEntity", "Country", "Country", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "CustomerEntity", "CustomerId", "CustomerId", false, "NVarchar2", 5, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomerEntity", "Fax", "Fax", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomerEntity", "Phone", "Phone", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "CustomerEntity", "PostalCode", "PostalCode", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomerEntity", "Region", "Region", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits CustomerCustomerDemoEntity's mappings</summary>
		private void InitCustomerCustomerDemoEntityMappings()
		{
			this.AddElementMapping( "CustomerCustomerDemoEntity", "Default", @"Default", "CustomerCustomerDemo", 2 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerId", "CustomerId", false, "NVarchar2", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerCustomerDemoEntity", "CustomerTypeId", "CustomerTypeId", false, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CustomerDemographicEntity's mappings</summary>
		private void InitCustomerDemographicEntityMappings()
		{
			this.AddElementMapping( "CustomerDemographicEntity", "Default", @"Default", "CustomerDemographic", 2 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerDesc", "CustomerDesc", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomerDemographicEntity", "CustomerTypeId", "CustomerTypeId", false, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping( "EmployeeEntity", "Default", @"Default", "Employee", 18 );
			this.AddElementFieldMapping( "EmployeeEntity", "Address", "Address", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "EmployeeEntity", "BirthDate", "BirthDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "EmployeeEntity", "City", "City", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "EmployeeEntity", "Country", "Country", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "EmployeeEntity", "EmployeeId", "EmployeeId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Employee", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "EmployeeEntity", "Extension", "Extension", true, "NVarchar2", 4, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "EmployeeEntity", "FirstName", "FirstName", false, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "EmployeeEntity", "HireDate", "HireDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "EmployeeEntity", "HomePhone", "HomePhone", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "EmployeeEntity", "LastName", "LastName", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "EmployeeEntity", "Notes", "Notes", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "EmployeeEntity", "Photo", "Photo", true, "Blob", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11 );
			this.AddElementFieldMapping( "EmployeeEntity", "PhotoPath", "PhotoPath", true, "NVarchar2", 255, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "EmployeeEntity", "PostalCode", "PostalCode", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "EmployeeEntity", "Region", "Region", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "EmployeeEntity", "ReportsTo", "ReportsTo", true, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 15 );
			this.AddElementFieldMapping( "EmployeeEntity", "Title", "Title", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "EmployeeEntity", "TitleOfCourtesy", "TitleOfCourtesy", true, "NVarchar2", 25, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits EmployeeTerritoryEntity's mappings</summary>
		private void InitEmployeeTerritoryEntityMappings()
		{
			this.AddElementMapping( "EmployeeTerritoryEntity", "Default", @"Default", "EmployeeTerritory", 2 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "EmployeeId", "EmployeeId", false, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "EmployeeTerritoryEntity", "TerritoryId", "TerritoryId", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping( "OrderEntity", "Default", @"Default", "Order", 14 );
			this.AddElementFieldMapping( "OrderEntity", "CustomerId", "CustomerId", true, "NVarchar2", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "OrderEntity", "EmployeeId", "EmployeeId", true, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrderEntity", "Freight", "Freight", true, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "OrderEntity", "OrderDate", "OrderDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "OrderEntity", "OrderId", "OrderId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Order", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "OrderEntity", "RequiredDate", "RequiredDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "OrderEntity", "ShipAddress", "ShipAddress", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCity", "ShipCity", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "OrderEntity", "ShipCountry", "ShipCountry", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "OrderEntity", "ShipName", "ShipName", true, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "OrderEntity", "ShippedDate", "ShippedDate", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "OrderEntity", "ShipPostalCode", "ShipPostalCode", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "OrderEntity", "ShipRegion", "ShipRegion", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "OrderEntity", "ShipVia", "ShipVia", true, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 13 );
		}
		/// <summary>Inits OrderDetailEntity's mappings</summary>
		private void InitOrderDetailEntityMappings()
		{
			this.AddElementMapping( "OrderDetailEntity", "Default", @"Default", "OrderDetail", 5 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Discount", "Discount", false, "BinaryFloat", 0, 0, 0, false, "", null, typeof(System.Single), 0 );
			this.AddElementFieldMapping( "OrderDetailEntity", "OrderId", "OrderId", false, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrderDetailEntity", "ProductId", "ProductId", false, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "OrderDetailEntity", "Quantity", "Quantity", false, "Decimal", 0, 0, 4, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "OrderDetailEntity", "UnitPrice", "UnitPrice", false, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping( "ProductEntity", "Default", @"Default", "Product", 10 );
			this.AddElementFieldMapping( "ProductEntity", "CategoryId", "CategoryId", true, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductEntity", "Discontinued", "Discontinued", false, "Decimal", 0, 0, 1, false, "",  new SD.LLBLGen.Pro.TypeConverters.BooleanNumericConverter(), typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "ProductEntity", "ProductId", "ProductId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Product", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ProductEntity", "ProductName", "ProductName", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ProductEntity", "QuantityPerUnit", "QuantityPerUnit", true, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ProductEntity", "ReorderLevel", "ReorderLevel", true, "Decimal", 0, 0, 4, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "ProductEntity", "SupplierId", "SupplierId", true, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "ProductEntity", "UnitPrice", "UnitPrice", true, "Decimal", 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsInStock", "UnitsInStock", true, "Decimal", 0, 0, 4, false, "", null, typeof(System.Int16), 8 );
			this.AddElementFieldMapping( "ProductEntity", "UnitsOnOrder", "UnitsOnOrder", true, "Decimal", 0, 0, 4, false, "", null, typeof(System.Int16), 9 );
		}
		/// <summary>Inits RegionEntity's mappings</summary>
		private void InitRegionEntityMappings()
		{
			this.AddElementMapping( "RegionEntity", "Default", @"Default", "Region", 2 );
			this.AddElementFieldMapping( "RegionEntity", "RegionDescription", "RegionDescription", false, "NVarchar2", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RegionEntity", "RegionId", "RegionId", false, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 1 );
		}
		/// <summary>Inits ShipperEntity's mappings</summary>
		private void InitShipperEntityMappings()
		{
			this.AddElementMapping( "ShipperEntity", "Default", @"Default", "Shipper", 3 );
			this.AddElementFieldMapping( "ShipperEntity", "CompanyName", "CompanyName", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ShipperEntity", "Phone", "Phone", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ShipperEntity", "ShipperId", "ShipperId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Shipper", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits SupplierEntity's mappings</summary>
		private void InitSupplierEntityMappings()
		{
			this.AddElementMapping( "SupplierEntity", "Default", @"Default", "Supplier", 12 );
			this.AddElementFieldMapping( "SupplierEntity", "Address", "Address", true, "NVarchar2", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SupplierEntity", "City", "City", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SupplierEntity", "CompanyName", "CompanyName", false, "NVarchar2", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactName", "ContactName", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SupplierEntity", "ContactTitle", "ContactTitle", true, "NVarchar2", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "SupplierEntity", "Country", "Country", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SupplierEntity", "Fax", "Fax", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "SupplierEntity", "HomePage", "HomePage", true, "NClob", 2147483647, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SupplierEntity", "Phone", "Phone", true, "NVarchar2", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SupplierEntity", "PostalCode", "PostalCode", true, "NVarchar2", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "SupplierEntity", "Region", "Region", true, "NVarchar2", 15, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "SupplierEntity", "SupplierId", "SupplierId", false, "Decimal", 0, 0, 9, true, "Default.SEQ_Supplier", null, typeof(System.Int32), 11 );
		}
		/// <summary>Inits TerritoryEntity's mappings</summary>
		private void InitTerritoryEntityMappings()
		{
			this.AddElementMapping( "TerritoryEntity", "Default", @"Default", "Territory", 3 );
			this.AddElementFieldMapping( "TerritoryEntity", "RegionId", "RegionId", false, "Decimal", 0, 0, 9, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryDescription", "TerritoryDescription", false, "NVarchar2", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TerritoryEntity", "TerritoryId", "TerritoryId", false, "NVarchar2", 20, 0, 0, false, "", null, typeof(System.String), 2 );
		}

	}
}