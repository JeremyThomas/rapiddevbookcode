using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Filters
{
  public static class SalesOrderHeaderFilters
  {
    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
                                                                                                       DateTime fromDate, DateTime toDate, int orderID, string orderNumber,
                                                                                                       string firstName, string lastName, string cityName, string stateName,
                                                                                                       ICollection<string> countries, string zip)
    {
      if (fromDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate <= toDate);
      if (firstName != "")
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.Customer.Individual.Contact.FirstName.Contains(firstName));
      if (lastName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.Customer.Individual.Contact.LastName.Contains(lastName));

      if (cityName != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == cityName)
                                select soh;
      if (stateName != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == stateName)
                                select soh;
      if (countries.Count > 0)
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                                select soh;
      if (zip != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == zip)
                                select soh;
      if (orderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderID == orderID);
      if (orderNumber != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderNumber == orderNumber);

      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      return salesOrderHeaderQuery;
    }

    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddressLambda(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
                                                                                                             DateTime fromDate, DateTime toDate, string firstName,
                                                                                                             string lastName, string cityName, string stateName, string countryName,
                                                                                                             string zip, int orderID, string orderNumber)
    {
      if (fromDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.OrderDate <= toDate);
      if (firstName != "")
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains(firstName));
      if (lastName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.Individual.Contact.LastName.Contains(lastName));
      if (cityName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == cityName));
      if (stateName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == stateName));
      if (countryName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == countryName));
      if (zip != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == zip));
      if (orderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.SalesOrderID == orderID);
      if (orderNumber != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.SalesOrderNumber == orderNumber);

      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      return salesOrderHeaderQuery;
    }

    public static IPredicateExpression FilterByDateOrderIDOrderNumberCustomerNameAddress(IRelationCollection relations, DateTime FromDate, DateTime ToDate, int OrderID, string OrderNumber, string FirstName, string LastName, string CityName, string StateName, string CountryName, string Zip)
    {
      var filter = new PredicateExpression();
      if (
        (FirstName != "") ||
        (LastName != "") ||
        (CityName != "") ||
        (StateName != "") ||
        (CountryName != "") ||
        (Zip != "")
        )
        relations.Add(SalesOrderHeaderEntityBase.Relations.CustomerViewRelatedEntityUsingCustomerID);
      if (FromDate != DateTime.MinValue)
        filter.Add(SalesOrderHeaderFields.OrderDate >= FromDate);
      if (ToDate != DateTime.MinValue)
        filter.Add(SalesOrderHeaderFields.OrderDate <= ToDate);
      if (FirstName != "")
        filter.Add(CustomerViewRelatedFields.FirstName%FirstName);
      if (LastName != "")
        filter.Add(CustomerViewRelatedFields.LastName%LastName);
      if (CityName != "")
        filter.Add(CustomerViewRelatedFields.City%CityName);
      if (StateName != "")
        filter.Add(CustomerViewRelatedFields.StateProvinceName == StateName);
      if (CountryName != "")
        filter.Add(CustomerViewRelatedFields.CountryRegionName == CountryName);
      if (Zip != "")
        filter.Add(CustomerViewRelatedFields.PostalCode == Zip);
      if (OrderID != 0)
        filter.Add(SalesOrderHeaderFields.SalesOrderID == OrderID);
      if (OrderNumber != "")
        filter.Add(SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
      return filter;
    }
  }
}