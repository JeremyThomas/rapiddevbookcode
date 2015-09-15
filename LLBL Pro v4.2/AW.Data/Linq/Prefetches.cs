using System.Linq;
using AW.Data.EntityClasses;
using LLBLGen.Linq.Prefetch;
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
    
    public static IQueryable<AddressEntity> PrefetchStateProvinceCountryRegionCustomer(this IQueryable<AddressEntity> predicate)
    {
      //return predicate.WithPath(p => p.Prefetch<StateProvinceEntity>(a=>a.StateProvince).SubPath(sp=>sp.Prefetch(s=>s.CountryRegion)).
      //  Prefetch<CustomerAddressEntity>(a => a.CustomerAddresses).SubPath(sp => sp.Prefetch(s => s.Customer)));

      return predicate.With(
        a => a.StateProvince.With(sp => sp.CountryRegion), 
        a => a.CustomerAddresses.With(ca => ca.Customer)
        );
    }

    public static IQueryable<EmployeeEntity> PrefetchAll(this IQueryable<EmployeeEntity> employeeEntities)
    {
      return employeeEntities.With(o => o.PurchaseOrderHeaders, e => e.Manager, e => e.Contact, e => e.Manages, 
        e => e.JobCandidates, e => e.EmployeePayHistories, e => e.EmployeeDepartmentHistories, e => e.EmployeeAddresses);
    }

    public static IQueryable<EmployeeEntity> PrefetchAllButManages(this IQueryable<EmployeeEntity> employeeEntities)
    {
      return employeeEntities.With(o => o.PurchaseOrderHeaders, e => e.Manager, e => e.Contact, 
        e => e.JobCandidates, e => e.EmployeePayHistories, e => e.EmployeeDepartmentHistories, e => e.EmployeeAddresses);
    }
  }
}
