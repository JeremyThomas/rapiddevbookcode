using System.Linq;
using AW.Data.EntityClasses;

namespace AW.Data.Linq.Filters
{
	public static class Filters
	{
		public static IQueryable<AddressEntity> FilterByCity(this IQueryable<AddressEntity> addressQuery, string cityName = null)
		{
			return string.IsNullOrEmpty(cityName) ? addressQuery : addressQuery.Where(c => c.City == cityName);
		}

    public static IQueryable<T> FilterBySalesPersonID<T>(this IQueryable<T> customerQuery, params int[] salesPersonIDs) where T : CustomerEntity
    {
      if (salesPersonIDs != null && salesPersonIDs.Length > 0)
        customerQuery = from customerEntity in customerQuery
                        from orderEntity in customerEntity.SalesOrderHeaders
                        where salesPersonIDs.Contains(orderEntity.SalesPersonID.Value)
                        select customerEntity;
      return customerQuery;
    }
	}
}