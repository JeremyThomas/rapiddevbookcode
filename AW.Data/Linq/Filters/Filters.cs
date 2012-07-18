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
	}
}