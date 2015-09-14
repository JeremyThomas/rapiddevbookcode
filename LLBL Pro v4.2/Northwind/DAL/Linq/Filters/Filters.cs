using System;
using System.Collections.Generic;
using System.Linq;
using AW.Helper;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;

namespace Northwind.DAL.Linq.Filters
{
  public static class Filters
  {
    public static IQueryable<CustomerEntity> FilterByCountry(this IQueryable<CustomerEntity> customerQuery, string country = null)
    {
      return String.IsNullOrEmpty(country) ? customerQuery : customerQuery.Where(c => c.Country.EqualsIgnoreCase(country));
    }

    public static IQueryable<CustomerEntity> FilterByEmployeeId(this IQueryable<CustomerEntity> customerQuery, params int[] employees)
    {
      if (employees != null && employees.Length > 0)
        customerQuery = from customerEntity in customerQuery
          from orderEntity in customerEntity.Orders
          where employees.Contains(orderEntity.EmployeeId.Value)
          select customerEntity;
      return customerQuery;
    }

    public static IQueryable<CustomerEntity> FilterByShipCountry(this IQueryable<CustomerEntity> customerQuery, params string[] countries)
    {
      if (countries != null && countries.Length > 0)
        customerQuery = from customerEntity in customerQuery
          from orderEntity in customerEntity.Orders
          where countries.Contains(orderEntity.ShipCountry)
          select customerEntity;
      return customerQuery;
    }

    /// <summary>
    ///   Filters the ProductEntity Query by wether the product is discontinued. Generic on IProduct
    /// </summary>
    /// <param name="products">The product query.</param>
    /// <param name="discontinued">The discontinued flag to filter by.</param>
    /// <returns></returns>
    public static IQueryable<T> FilterByDiscontinued<T>(this IQueryable<T> products, bool? discontinued) where T : class, IProduct
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<T> FilterByDiscontinuedGi<T>(this IQueryable<T> products, bool? discontinued) where T : IProduct
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<IProduct> FilterByDiscontinuedI(this IQueryable<IProduct> products, bool? discontinued)
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<IProduct> FilterBySupplierIdI(this IQueryable<IProduct> products, params int?[] suppliers)
    {
      if (suppliers.IsNullOrEmpty())
        return products;
      return products.Where(p => suppliers.Contains(p.SupplierId));
    }

    public static IQueryable<T> FilterByProductName<T>(this IQueryable<T> products, string productName) where T : class, IProduct
    {
      return String.IsNullOrEmpty(productName) ? products : products.Where(r => productName.EqualsIgnoreCase(r.ProductName));
    }

    public static IQueryable<T> FilterByUnitsInStock<T>(this IQueryable<T> products, short? unitsInStock) where T : class, IProduct
    {
      return unitsInStock.HasValue ? products.Where(r => r.UnitsInStock == unitsInStock) : products;
    }

    public static IQueryable<ProductEntity> FilterByUnitsOnOrder(this IQueryable<ProductEntity> products, short? unitsInStock)
    {
      return unitsInStock.HasValue ? products.Where(r => r.UnitsOnOrder == unitsInStock) : products;
    }

    public static IQueryable<EmployeeEntity> FilterByCustomerTypeIdViaOrders(this IQueryable<EmployeeEntity> employees, string customerTypeId)
    {
      return from e in employees
        from c in e.CustomersViaOrders
        from ccd in c.CustomerCustomerDemos
        where ccd.CustomerTypeId == customerTypeId
        select e;
    }

    public static IQueryable<EmployeeEntity> FilterByCustomerTypeId(this IQueryable<EmployeeEntity> employees, string customerTypeId)
    {
      return from e in employees
        from o in e.Orders
        from ccd in o.Customer.CustomerCustomerDemos
        where ccd.CustomerTypeId == customerTypeId
        select e;
    }

    public static IQueryable<EmployeeEntity> FilterByManagersOrder(this IQueryable<EmployeeEntity> employees, int orderId)
    {
      return from e in employees
        from mo in e.Manager.Orders
        where mo.OrderId == orderId
        select e;
    }

    public static IQueryable<EmployeeEntity> FilterByOrder(this IQueryable<EmployeeEntity> employees, int orderId)
    {
      return from e in employees
        from o in e.Orders
        where o.OrderId == orderId
        select e;
    }

    public static IQueryable<EmployeeEntity> FilterByOrders(this IQueryable<EmployeeEntity> employees, params int[] orderIds)
    {
      if (orderIds != null && orderIds.Length > 0)
        return from e in employees
          from o in e.Orders
          where orderIds.Contains(o.OrderId)
          select e;
      return employees;
    }

    public static IQueryable<OrderEntity> FilterByProducts(this IQueryable<OrderEntity> orders, params int[] productIds)
    {
      if (productIds != null && productIds.Length > 0)
        return from e in orders
          from o in e.OrderDetails
          where productIds.Contains(o.ProductId)
          select e;
      return orders;
    }

    public static IQueryable<OrderEntity> FilterByCustomerQuery(this IQueryable<OrderEntity> orderQuery, IQueryable<CustomerEntity> customerQuery)
    {
      return from e in orderQuery
        from c in customerQuery
        where e.CustomerId == c.CustomerId
        select e;
    }

    public static IQueryable<OrderEntity> FilterByProductQuery(this IQueryable<OrderEntity> orderQuery, IQueryable<ProductEntity> productQuery)
    {
      return from p in productQuery
        from od in p.OrderDetails
        from o in orderQuery
        where o.OrderId == od.OrderId
        select o;
    }

    public static IQueryable<OrderEntity> FilterByIProductFullQuery(this IQueryable<OrderEntity> orderQuery, IQueryable<IProductFull> productQuery)
    {
      return from p in productQuery
             from od in p.OrderDetails
             from o in orderQuery
             where o.OrderId == od.OrderId
             select o;
    }

    public static IQueryable<OrderEntity> FilterByIProductFullGenericQuery<T>(this IQueryable<OrderEntity> orderQuery, IQueryable<T> productQuery)
  where T : class, IProductFull
    {
      return from p in productQuery
             from od in p.OrderDetails
             from o in orderQuery
             where o.OrderId == od.OrderId
             select o;
    }

    public static IQueryable<T> FilterByOrderQuery<T>(this IQueryable<T> products, IQueryable<OrderEntity> orderQuery) where T : ProductEntity
    {
      return from p in products
             from od in p.OrderDetails
             from o in orderQuery
             where o.OrderId == od.OrderId
             select p;
    }

    public static IQueryable<SupplierEntity> FilterByIProductQuery(this IQueryable<SupplierEntity> supplierQuery, IQueryable<IProduct> productQuery)
    {
      return from s in supplierQuery
             from p in productQuery
             where s.SupplierId == p.SupplierId
             select s;
    }

    public static IQueryable<SupplierEntity> FilterByIProductJoinQuery(this IQueryable<SupplierEntity> supplierQuery, IQueryable<IProduct> productQuery)
    {
      return from s in supplierQuery
             join p in productQuery on s.SupplierId equals p.SupplierId
             select s;
    }

    public static IQueryable<SupplierEntity> FilterByIProductGenericQuery<T>(this IQueryable<SupplierEntity> supplierQuery, IQueryable<T> productQuery)
           where T : class, IProduct
    {
      return from s in supplierQuery
             from p in productQuery
             where s.SupplierId == p.SupplierId
             select s;
    }

    public static IQueryable<SupplierEntity> FilterByIProductGenericJoinQuery<T>(this IQueryable<SupplierEntity> supplierQuery, IQueryable<T> productQuery)
       where T : IProduct
    {
      return from s in supplierQuery
             join p in productQuery on s.SupplierId equals p.SupplierId
             select s;
    }

    public static IQueryable<IGrouping<string, CustomerEntity>> GroupByCountry(this IQueryable<CustomerEntity> customerEntities)
    {
      return customerEntities.GroupBy(c => c.Country);
    }

    public static IEnumerable<IGrouping<string, CustomerEntity>> GroupByCountry(this IEnumerable<CustomerEntity> customerEntities)
    {
      return customerEntities.GroupBy(c => c.Country);
    }
  }
}