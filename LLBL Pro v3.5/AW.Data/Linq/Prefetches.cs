using System.Linq;
using AW.Data.EntityClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Data.Linq
{
  public static class Prefetches
  {
    public static IQueryable<T> PrefetchCustomerAddresses<T>(this IQueryable<T> customerEntities)where T : CustomerEntity
    {
      return customerEntities.WithPath(cp => cp.Prefetch<CustomerAddressEntity>(c => c.CustomerAddresses));
    }

    public static IQueryable<SalesOrderHeaderEntity> PrefetchCustomerViewRelated(this IQueryable<SalesOrderHeaderEntity> predicate)
    {
      return predicate.WithPath(p => p.Prefetch(c => c.CustomerViewRelated));
    }
  }
}
