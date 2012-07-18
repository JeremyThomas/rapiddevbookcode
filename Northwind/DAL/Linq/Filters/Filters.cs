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
	}
}