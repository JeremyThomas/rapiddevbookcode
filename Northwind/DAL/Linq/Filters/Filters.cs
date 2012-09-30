using System.Linq;
using Northwind.DAL.EntityClasses;

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

	}
}