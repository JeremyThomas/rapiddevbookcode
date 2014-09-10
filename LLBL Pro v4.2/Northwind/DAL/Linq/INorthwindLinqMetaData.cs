using System.ServiceModel;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Linq
{
  [ServiceContract]
  [ServiceKnownType(typeof(CustomerEntity))]
  [ServiceKnownType(typeof(OrderEntity))]
  [ServiceKnownType(typeof(EntityCollection))]
  [ServiceKnownType(typeof(EntityField2))]
  [ServiceKnownType(typeof(UnitOfWork2))]
  public interface INorthwindLinqMetaData
  {

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CategoryEntity instances in the database.</summary>
    DataSource2<CategoryEntity> Category { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CustomerEntity instances in the database.</summary>
    DataSource2<CustomerEntity> Customer { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CustomerCustomerDemoEntity instances in the database.</summary>
    DataSource2<CustomerCustomerDemoEntity> CustomerCustomerDemo { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CustomerDemographicEntity instances in the database.</summary>
    DataSource2<CustomerDemographicEntity> CustomerDemographic { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting EmployeeEntity instances in the database.</summary>
    DataSource2<EmployeeEntity> Employee { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting EmployeeTerritoryEntity instances in the database.</summary>
    DataSource2<EmployeeTerritoryEntity> EmployeeTerritory { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting OrderEntity instances in the database.</summary>
    DataSource2<OrderEntity> Order { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting OrderDetailEntity instances in the database.</summary>
    DataSource2<OrderDetailEntity> OrderDetail { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting ProductEntity instances in the database.</summary>
    DataSource2<ProductEntity> Product { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting RegionEntity instances in the database.</summary>
    DataSource2<RegionEntity> Region { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting ShipperEntity instances in the database.</summary>
    DataSource2<ShipperEntity> Shipper { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting SupplierEntity instances in the database.</summary>
    DataSource2<SupplierEntity> Supplier { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting TerritoryEntity instances in the database.</summary>
    DataSource2<TerritoryEntity> Territory { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting AlphabeticalListOfProduct instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.AlphabeticalListOfProductRow> AlphabeticalListOfProduct { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CategorySalesFor1997 instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.CategorySalesFor1997Row> CategorySalesFor1997 { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CurrentProductList instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.CurrentProductListRow> CurrentProductList { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting CustomerAndSuppliersByCity instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.CustomerAndSuppliersByCityRow> CustomerAndSuppliersByCity { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting Invoice instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.InvoiceRow> Invoice { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting OrderDetailsExtended instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.OrderDetailsExtendedRow> OrderDetailsExtended { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting OrdersQry instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.OrdersQryRow> OrdersQry { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting OrderSubtotal instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.OrderSubtotalRow> OrderSubtotal { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting ProductsAboveAveragePrice instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.ProductsAboveAveragePriceRow> ProductsAboveAveragePrice { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting ProductSalesFor1997 instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.ProductSalesFor1997Row> ProductSalesFor1997 { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting ProductsByCategory instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.ProductsByCategoryRow> ProductsByCategory { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting QuarterlyOrder instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.QuarterlyOrderRow> QuarterlyOrder { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting SalesByCategory instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.SalesByCategoryRow> SalesByCategory { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting SalesTotalsByAmount instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.SalesTotalsByAmountRow> SalesTotalsByAmount { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting SummaryOfSalesByQuarter instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByQuarterRow> SummaryOfSalesByQuarter { [OperationContract]get; }

    /// <summary>returns the datasource to use in a Linq query when tar[OperationContract]geting SummaryOfSalesByYear instances in the database.</summary>
    DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByYearRow> SummaryOfSalesByYear { [OperationContract]get; }

  }
}