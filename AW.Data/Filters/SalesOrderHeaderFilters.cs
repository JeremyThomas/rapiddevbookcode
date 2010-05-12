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
      DateTime fromDate, DateTime toDate, int orderID, string orderNumber, string firstName, string lastName, string cityName, string stateName, string zip, 
      IEnumerable<string> countries)
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
      if (countries.Count() > 0)
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

    public static IPredicateExpression FilterByDateOrderIDOrderNumberCustomerNameAddress(IRelationCollection relations, DateTime fromDate, DateTime toDate, int orderID, 
      string orderNumber, string firstName, string lastName, string cityName, string stateName, string countryName, string zip)
    {
      var filter = new PredicateExpression();
      if (
        (firstName != "") ||
        (lastName != "") ||
        (cityName != "") ||
        (stateName != "") ||
        (countryName != "") ||
        (zip != "")
        )
        relations.Add(SalesOrderHeaderEntityBase.Relations.CustomerViewRelatedEntityUsingCustomerID);
      if (fromDate != DateTime.MinValue)
        filter.Add(SalesOrderHeaderFields.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        filter.Add(SalesOrderHeaderFields.OrderDate <= toDate);
      if (firstName != "")
        filter.Add(CustomerViewRelatedFields.FirstName%firstName);
      if (lastName != "")
        filter.Add(CustomerViewRelatedFields.LastName%lastName);
      if (cityName != "")
        filter.Add(CustomerViewRelatedFields.City%cityName);
      if (stateName != "")
        filter.Add(CustomerViewRelatedFields.StateProvinceName == stateName);
      if (countryName != "")
        filter.Add(CustomerViewRelatedFields.CountryRegionName == countryName);
      if (zip != "")
        filter.Add(CustomerViewRelatedFields.PostalCode == zip);
      if (orderID != 0)
        filter.Add(SalesOrderHeaderFields.SalesOrderID == orderID);
      if (orderNumber != "")
        filter.Add(SalesOrderHeaderFields.SalesOrderNumber == orderNumber);
      return filter;
    }
  }
}