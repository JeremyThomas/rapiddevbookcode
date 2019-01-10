///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace Northwind.DAL
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category.</summary>
	public enum CategoryFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>CategoryName. </summary>
		CategoryName,
		///<summary>Description. </summary>
		Description,
		///<summary>Picture. </summary>
		Picture,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.</summary>
	public enum CustomerFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>City. </summary>
		City,
		///<summary>CompanyName. </summary>
		CompanyName,
		///<summary>ContactName. </summary>
		ContactName,
		///<summary>ContactTitle. </summary>
		ContactTitle,
		///<summary>Country. </summary>
		Country,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Fax. </summary>
		Fax,
		///<summary>Phone. </summary>
		Phone,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Region. </summary>
		Region,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerCustomerDemo.</summary>
	public enum CustomerCustomerDemoFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>CustomerTypeId. </summary>
		CustomerTypeId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerDemographic.</summary>
	public enum CustomerDemographicFieldIndex
	{
		///<summary>CustomerDesc. </summary>
		CustomerDesc,
		///<summary>CustomerTypeId. </summary>
		CustomerTypeId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.</summary>
	public enum EmployeeFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>City. </summary>
		City,
		///<summary>Country. </summary>
		Country,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Extension. </summary>
		Extension,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>HomePhone. </summary>
		HomePhone,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Notes. </summary>
		Notes,
		///<summary>Photo. </summary>
		Photo,
		///<summary>PhotoPath. </summary>
		PhotoPath,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Region. </summary>
		Region,
		///<summary>ReportsTo. </summary>
		ReportsTo,
		///<summary>Title. </summary>
		Title,
		///<summary>TitleOfCourtesy. </summary>
		TitleOfCourtesy,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeTerritory.</summary>
	public enum EmployeeTerritoryFieldIndex
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Order.</summary>
	public enum OrderFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Freight. </summary>
		Freight,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>RequiredDate. </summary>
		RequiredDate,
		///<summary>ShipAddress. </summary>
		ShipAddress,
		///<summary>ShipCity. </summary>
		ShipCity,
		///<summary>ShipCountry. </summary>
		ShipCountry,
		///<summary>ShipName. </summary>
		ShipName,
		///<summary>ShippedDate. </summary>
		ShippedDate,
		///<summary>ShipPostalCode. </summary>
		ShipPostalCode,
		///<summary>ShipRegion. </summary>
		ShipRegion,
		///<summary>ShipVia. </summary>
		ShipVia,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrderDetail.</summary>
	public enum OrderDetailFieldIndex
	{
		///<summary>Discount. </summary>
		Discount,
		///<summary>OrderId. </summary>
		OrderId,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>Discontinued. </summary>
		Discontinued,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductName. </summary>
		ProductName,
		///<summary>QuantityPerUnit. </summary>
		QuantityPerUnit,
		///<summary>ReorderLevel. </summary>
		ReorderLevel,
		///<summary>SupplierId. </summary>
		SupplierId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitsInStock. </summary>
		UnitsInStock,
		///<summary>UnitsOnOrder. </summary>
		UnitsOnOrder,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Region.</summary>
	public enum RegionFieldIndex
	{
		///<summary>RegionDescription. </summary>
		RegionDescription,
		///<summary>RegionId. </summary>
		RegionId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Shipper.</summary>
	public enum ShipperFieldIndex
	{
		///<summary>CompanyName. </summary>
		CompanyName,
		///<summary>Phone. </summary>
		Phone,
		///<summary>ShipperId. </summary>
		ShipperId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Supplier.</summary>
	public enum SupplierFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>City. </summary>
		City,
		///<summary>CompanyName. </summary>
		CompanyName,
		///<summary>ContactName. </summary>
		ContactName,
		///<summary>ContactTitle. </summary>
		ContactTitle,
		///<summary>Country. </summary>
		Country,
		///<summary>Fax. </summary>
		Fax,
		///<summary>HomePage. </summary>
		HomePage,
		///<summary>Phone. </summary>
		Phone,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Region. </summary>
		Region,
		///<summary>SupplierId. </summary>
		SupplierId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Territory.</summary>
	public enum TerritoryFieldIndex
	{
		///<summary>RegionId. </summary>
		RegionId,
		///<summary>TerritoryDescription. </summary>
		TerritoryDescription,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}

	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : AlphabeticalListOfProduct.</summary>
	public enum AlphabeticalListOfProductFieldIndex
	{
		///<summary>ProductId</summary>
		ProductId,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>SupplierId</summary>
		SupplierId,
		///<summary>CategoryId</summary>
		CategoryId,
		///<summary>QuantityPerUnit</summary>
		QuantityPerUnit,
		///<summary>UnitPrice</summary>
		UnitPrice,
		///<summary>UnitsInStock</summary>
		UnitsInStock,
		///<summary>UnitsOnOrder</summary>
		UnitsOnOrder,
		///<summary>ReorderLevel</summary>
		ReorderLevel,
		///<summary>Discontinued</summary>
		Discontinued,
		///<summary>CategoryName</summary>
		CategoryName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CategorySalesFor1997.</summary>
	public enum CategorySalesFor1997FieldIndex
	{
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>CategorySales</summary>
		CategorySales,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CurrentProductList.</summary>
	public enum CurrentProductListFieldIndex
	{
		///<summary>ProductId</summary>
		ProductId,
		///<summary>ProductName</summary>
		ProductName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CustomerAndSuppliersByCity.</summary>
	public enum CustomerAndSuppliersByCityFieldIndex
	{
		///<summary>City</summary>
		City,
		///<summary>CompanyName</summary>
		CompanyName,
		///<summary>ContactName</summary>
		ContactName,
		///<summary>Relationship</summary>
		Relationship,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : Invoice.</summary>
	public enum InvoiceFieldIndex
	{
		///<summary>ShipName</summary>
		ShipName,
		///<summary>ShipAddress</summary>
		ShipAddress,
		///<summary>ShipCity</summary>
		ShipCity,
		///<summary>ShipRegion</summary>
		ShipRegion,
		///<summary>ShipPostalCode</summary>
		ShipPostalCode,
		///<summary>ShipCountry</summary>
		ShipCountry,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>CustomerName</summary>
		CustomerName,
		///<summary>Address</summary>
		Address,
		///<summary>City</summary>
		City,
		///<summary>Region</summary>
		Region,
		///<summary>PostalCode</summary>
		PostalCode,
		///<summary>Country</summary>
		Country,
		///<summary>Salesperson</summary>
		Salesperson,
		///<summary>OrderId</summary>
		OrderId,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>RequiredDate</summary>
		RequiredDate,
		///<summary>ShippedDate</summary>
		ShippedDate,
		///<summary>ShipperName</summary>
		ShipperName,
		///<summary>ProductId</summary>
		ProductId,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>UnitPrice</summary>
		UnitPrice,
		///<summary>Quantity</summary>
		Quantity,
		///<summary>Discount</summary>
		Discount,
		///<summary>ExtendedPrice</summary>
		ExtendedPrice,
		///<summary>Freight</summary>
		Freight,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : OrderDetailsExtended.</summary>
	public enum OrderDetailsExtendedFieldIndex
	{
		///<summary>OrderId</summary>
		OrderId,
		///<summary>ProductId</summary>
		ProductId,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>UnitPrice</summary>
		UnitPrice,
		///<summary>Quantity</summary>
		Quantity,
		///<summary>Discount</summary>
		Discount,
		///<summary>ExtendedPrice</summary>
		ExtendedPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : OrdersQry.</summary>
	public enum OrdersQryFieldIndex
	{
		///<summary>OrderId</summary>
		OrderId,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>EmployeeId</summary>
		EmployeeId,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>RequiredDate</summary>
		RequiredDate,
		///<summary>ShippedDate</summary>
		ShippedDate,
		///<summary>ShipVia</summary>
		ShipVia,
		///<summary>Freight</summary>
		Freight,
		///<summary>ShipName</summary>
		ShipName,
		///<summary>ShipAddress</summary>
		ShipAddress,
		///<summary>ShipCity</summary>
		ShipCity,
		///<summary>ShipRegion</summary>
		ShipRegion,
		///<summary>ShipPostalCode</summary>
		ShipPostalCode,
		///<summary>ShipCountry</summary>
		ShipCountry,
		///<summary>CompanyName</summary>
		CompanyName,
		///<summary>Address</summary>
		Address,
		///<summary>City</summary>
		City,
		///<summary>Region</summary>
		Region,
		///<summary>PostalCode</summary>
		PostalCode,
		///<summary>Country</summary>
		Country,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : OrderSubtotal.</summary>
	public enum OrderSubtotalFieldIndex
	{
		///<summary>OrderId</summary>
		OrderId,
		///<summary>Subtotal</summary>
		Subtotal,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ProductsAboveAveragePrice.</summary>
	public enum ProductsAboveAveragePriceFieldIndex
	{
		///<summary>ProductName</summary>
		ProductName,
		///<summary>UnitPrice</summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ProductSalesFor1997.</summary>
	public enum ProductSalesFor1997FieldIndex
	{
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>ProductSales</summary>
		ProductSales,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ProductsByCategory.</summary>
	public enum ProductsByCategoryFieldIndex
	{
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>QuantityPerUnit</summary>
		QuantityPerUnit,
		///<summary>UnitsInStock</summary>
		UnitsInStock,
		///<summary>Discontinued</summary>
		Discontinued,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : QuarterlyOrder.</summary>
	public enum QuarterlyOrderFieldIndex
	{
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>CompanyName</summary>
		CompanyName,
		///<summary>City</summary>
		City,
		///<summary>Country</summary>
		Country,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SalesByCategory.</summary>
	public enum SalesByCategoryFieldIndex
	{
		///<summary>CategoryId</summary>
		CategoryId,
		///<summary>CategoryName</summary>
		CategoryName,
		///<summary>ProductName</summary>
		ProductName,
		///<summary>ProductSales</summary>
		ProductSales,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SalesTotalsByAmount.</summary>
	public enum SalesTotalsByAmountFieldIndex
	{
		///<summary>SaleAmount</summary>
		SaleAmount,
		///<summary>OrderId</summary>
		OrderId,
		///<summary>CompanyName</summary>
		CompanyName,
		///<summary>ShippedDate</summary>
		ShippedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SummaryOfSalesByQuarter.</summary>
	public enum SummaryOfSalesByQuarterFieldIndex
	{
		///<summary>ShippedDate</summary>
		ShippedDate,
		///<summary>OrderId</summary>
		OrderId,
		///<summary>Subtotal</summary>
		Subtotal,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SummaryOfSalesByYear.</summary>
	public enum SummaryOfSalesByYearFieldIndex
	{
		///<summary>ShippedDate</summary>
		ShippedDate,
		///<summary>OrderId</summary>
		OrderId,
		///<summary>Subtotal</summary>
		Subtotal,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Category</summary>
		CategoryEntity,
		///<summary>Customer</summary>
		CustomerEntity,
		///<summary>CustomerCustomerDemo</summary>
		CustomerCustomerDemoEntity,
		///<summary>CustomerDemographic</summary>
		CustomerDemographicEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>EmployeeTerritory</summary>
		EmployeeTerritoryEntity,
		///<summary>Order</summary>
		OrderEntity,
		///<summary>OrderDetail</summary>
		OrderDetailEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>Region</summary>
		RegionEntity,
		///<summary>Shipper</summary>
		ShipperEntity,
		///<summary>Supplier</summary>
		SupplierEntity,
		///<summary>Territory</summary>
		TerritoryEntity
	}

	/// <summary>Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.</summary>
	public enum TypedViewType
	{
		///<summary>AlphabeticalListOfProduct</summary>
		AlphabeticalListOfProductTypedView,
		///<summary>CategorySalesFor1997</summary>
		CategorySalesFor1997TypedView,
		///<summary>CurrentProductList</summary>
		CurrentProductListTypedView,
		///<summary>CustomerAndSuppliersByCity</summary>
		CustomerAndSuppliersByCityTypedView,
		///<summary>Invoice</summary>
		InvoiceTypedView,
		///<summary>OrderDetailsExtended</summary>
		OrderDetailsExtendedTypedView,
		///<summary>OrdersQry</summary>
		OrdersQryTypedView,
		///<summary>OrderSubtotal</summary>
		OrderSubtotalTypedView,
		///<summary>ProductsAboveAveragePrice</summary>
		ProductsAboveAveragePriceTypedView,
		///<summary>ProductSalesFor1997</summary>
		ProductSalesFor1997TypedView,
		///<summary>ProductsByCategory</summary>
		ProductsByCategoryTypedView,
		///<summary>QuarterlyOrder</summary>
		QuarterlyOrderTypedView,
		///<summary>SalesByCategory</summary>
		SalesByCategoryTypedView,
		///<summary>SalesTotalsByAmount</summary>
		SalesTotalsByAmountTypedView,
		///<summary>SummaryOfSalesByQuarter</summary>
		SummaryOfSalesByQuarterTypedView,
		///<summary>SummaryOfSalesByYear</summary>
		SummaryOfSalesByYearTypedView
	}

	#region Custom ConstantsEnums Code
	
  // __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
 // [DataContract]
  public enum Category
  {
    Beverages = 1,
    Condiments,
    Confections,
    Dairy,
    Grains,
    Meat,
    Produce,
    Seafood
  }

  // __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

