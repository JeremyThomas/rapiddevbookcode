using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Data.ViewModels;
using AW.Helper.LLBL;

namespace AW.Data.Filters
{
  public static class SalesOrderHeaderFilters
  {
    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddressCustomerViewRelated(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
      OrderSearchCriteria orderSearchCriteria)
    {

      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.CustomerViewRelated.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.CustomerViewRelated.LastName.Contains(orderSearchCriteria.LastName));

      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.CustomerViewRelated.City == orderSearchCriteria.CityName
          select soh;
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.CustomerViewRelated.StateProvinceName == orderSearchCriteria.StateName
          select soh;
      if (orderSearchCriteria.Countries.Any())
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where orderSearchCriteria.Countries.Contains(soh.CustomerViewRelated.CountryRegionName)
          select soh;
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.CustomerViewRelated.PostalCode == orderSearchCriteria.Zip
          select soh;
      
      return  FilterBySalesOrderHeaderProperties(salesOrderHeaderQuery, orderSearchCriteria);
    }

    private static IQueryable<SalesOrderHeaderEntity> FilterBySalesOrderHeaderProperties(IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery, OrderSearchCriteria orderSearchCriteria)
    {
      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate >= orderSearchCriteria.FromDate);
      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate <= orderSearchCriteria.ToDate);
      if (orderSearchCriteria.OrderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderID == orderSearchCriteria.OrderID);
      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderNumber == orderSearchCriteria.OrderNumber);
      if (orderSearchCriteria.OrderStatus.HasValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.Status == orderSearchCriteria.OrderStatus);
      if (orderSearchCriteria.IsOnlineOrder.HasValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OnlineOrderFlag == orderSearchCriteria.IsOnlineOrder);
      return salesOrderHeaderQuery;
    }

    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => ((IndividualEntity)soh.Customer).Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => ((IndividualEntity)soh.Customer).Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CountryName))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == orderSearchCriteria.CountryName));
      if (orderSearchCriteria.Countries.Any())
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => orderSearchCriteria.Countries.Contains(ca.Address.StateProvince.CountryRegion.Name)));
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));
      if (orderSearchCriteria.OrderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.SalesOrderID == orderSearchCriteria.OrderID);

      return FilterBySalesOrderHeaderProperties(salesOrderHeaderQuery, orderSearchCriteria);
    }

    public static Expression<Func<SalesOrderHeaderEntity, bool>> FilterByDateOrderIDOrderNumberCustomerNameAddress(this Expression<Func<SalesOrderHeaderEntity, bool>> salesOrderHeaderPredicate,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => ((IndividualEntity) soh.Customer).Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => ((IndividualEntity) soh.Customer).Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      var countriesList = orderSearchCriteria.Countries as IList<string> ?? orderSearchCriteria.Countries.ToList();
      if (countriesList.Any())
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => countriesList.Contains(ca.Address.StateProvince.CountryRegion.Name)));
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));

      return FilterBySalesOrderHeaderProperties(salesOrderHeaderPredicate, orderSearchCriteria);
    }

    private static Expression<Func<SalesOrderHeaderEntity, bool>> FilterBySalesOrderHeaderProperties(Expression<Func<SalesOrderHeaderEntity, bool>> salesOrderHeaderPredicate, OrderSearchCriteria orderSearchCriteria)
    {
      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.OrderDate >= orderSearchCriteria.FromDate);
      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.OrderDate <= orderSearchCriteria.ToDate);
      if (orderSearchCriteria.OrderID != 0)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.SalesOrderID == orderSearchCriteria.OrderID);
      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.SalesOrderNumber == orderSearchCriteria.OrderNumber);
      if (orderSearchCriteria.OrderStatus.HasValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(q => q.Status == orderSearchCriteria.OrderStatus);
      if (orderSearchCriteria.IsOnlineOrder.HasValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(q => q.OnlineOrderFlag == orderSearchCriteria.IsOnlineOrder);
      return salesOrderHeaderPredicate;
    }

    public static Expression<Func<SalesOrderHeaderEntity, bool>> FilterByDateOrderIDOrderNumberCustomerNameAddressCustomerViewRelated(this Expression<Func<SalesOrderHeaderEntity, bool>> salesOrderHeaderPredicate,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.CustomerViewRelated.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.CustomerViewRelated.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.CustomerViewRelated.City == orderSearchCriteria.CityName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.CustomerViewRelated.StateProvinceName == orderSearchCriteria.StateName);
      var countriesList = orderSearchCriteria.Countries as IList<string> ?? orderSearchCriteria.Countries.ToList();
      if (countriesList.Any())
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => countriesList.Contains(soh.CustomerViewRelated.CountryRegionName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.CustomerViewRelated.PostalCode == orderSearchCriteria.Zip);

      return FilterBySalesOrderHeaderProperties(salesOrderHeaderPredicate, orderSearchCriteria);
    }
  }
}