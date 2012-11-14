using System.Linq;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Linq.Filters
{
	public static class Filters
	{
		public static IQueryable<CustomerEntity> FilterByCountry(this IQueryable<CustomerEntity> customerQuery, string country = null)
		{
			return string.IsNullOrEmpty(country) ? customerQuery : customerQuery.Where(c => c.Country == country);
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

    public static IQueryable<T> FilterByDiscontinuedG<T>(this IQueryable<T> products, bool? discontinued) where T : CommonEntityBase, IProduct
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<T> FilterByDiscontinuedP<T>(this IQueryable<T> products, bool? discontinued) where T : ProductEntity
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<ProductEntity> FilterByDiscontinued(this IQueryable<ProductEntity> products, bool? discontinued)
    {
      if (discontinued.HasValue)
        return discontinued.Value ? products.Where(r => r.Discontinued) : products.Where(r => r.Discontinued);
      return products;
    }

    public static IQueryable<T> FilterByProductName<T>(this IQueryable<T> products, string productName) where T : EntityBase2, IProduct
    {
      return string.IsNullOrEmpty(productName) ? products : products.Where(r => productName.Equals(r.ProductName));
    }

    public static IQueryable<EmployeeEntity> FilterByCustomerTypeId(this IQueryable<EmployeeEntity> employees, string customerTypeId)
    {
      return from e in employees
             from c in e.CustomersViaOrders
             from ccd in c.CustomerCustomerDemos
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

	}
}