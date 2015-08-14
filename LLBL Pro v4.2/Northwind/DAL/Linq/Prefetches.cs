using System.Linq;
using LLBLGen.Linq.Prefetch;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace Northwind.DAL.Linq
{
  public static class Prefetches
  {
    public static IQueryable<CustomerEntity> PrefetchCustomerCustomerDemosCustomerDemographic(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.WithPath(cp => cp.Prefetch<CustomerCustomerDemoEntity>(c => c.CustomerCustomerDemos).SubPath(p => p.Prefetch(c => c.CustomerDemographic)));
    }

    public static IQueryable<CustomerEntity> PrefetchCustomerDemographics(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.WithPath(new PathEdge<CustomerDemographicEntity>(CustomerEntity.PrefetchPathCustomerDemographics));
    }

    public static IQueryable<CustomerEntity> PrefetchOrdersOrderDetailsProduct(this IQueryable<CustomerEntity> customerEntities)
    {
      //	return customerEntities.WithPath(new PathEdge<EmployeeEntity>(CustomerEntity.o));
      return customerEntities.WithPath(cp => cp.Prefetch<OrderEntity>(c => c.Orders).SubPath(i => i.Prefetch<OrderDetailEntity>(inv => inv.OrderDetails).SubPath(f => f.Prefetch(f1 => f1.Product))));
    }

    public static IQueryable<CustomerEntity> PrefetchOrdersEmployee(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.WithPath(new PathEdge<OrderEntity>(CustomerEntity.PrefetchPathOrders, new PathEdge<EmployeeEntity>(OrderEntity.PrefetchPathEmployee)));
    }

    public static IQueryable<CustomerEntity> PrefetchOrders(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.WithPath(new PathEdge<OrderEntity>(CustomerEntity.PrefetchPathOrders));
    }

    public static IQueryable<CustomerEntity> PrefetchEmployeesViaOrders(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.WithPath(new PathEdge<EmployeeEntity>(CustomerEntity.PrefetchPathEmployeesViaOrders));
    }

    public static IQueryable<ProductEntity> PrefetchOrderDetailOrderCustomer(this IQueryable<ProductEntity> productEntities)
    {
      return productEntities.WithPath(cp => cp.Prefetch<OrderDetailEntity>(c => c.OrderDetails).SubPath(p => p.Prefetch<OrderEntity>(c => c.Order).SubPath(o => o.Prefetch(or => or.Customer))));
    }

    public static IQueryable<ProductEntity> PrefetchCategorySupplier(this IQueryable<ProductEntity> productEntities)
    {
      return productEntities.With(cp => cp.Supplier, cp => cp.Category);
    }

    public static IQueryable<OrderEntity> PrefetchAll(this IQueryable<OrderEntity> orderEntities)
    {
      return orderEntities.With(o => o.Customer, o => o.Employee.With(e => e.Manager), o => o.Shipper, o => o.OrderDetails);
    }

    public static IQueryable<EmployeeEntity> PrefetchAll(this IQueryable<EmployeeEntity> employeeEntities)
    {
      return employeeEntities.With(o => o.EmployeeTerritories, e => e.Manager, o => o.Orders, o => o.Staff
        //, o => o.CustomersViaOrders, o => o.Territories
        );
    }
  }
}