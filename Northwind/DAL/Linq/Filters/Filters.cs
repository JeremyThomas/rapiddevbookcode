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
      return string.IsNullOrEmpty(country) ? customerQuery : customerQuery.Where(c => c.Country.EqualsIgnoreCase(country));
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

    public static IQueryable<T> FilterByProductName<T>(this IQueryable<T> products, string productName) where T : class, IProduct
    {
      return string.IsNullOrEmpty(productName) ? products : products.Where(r => productName.EqualsIgnoreCase(r.ProductName));
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
  }
}