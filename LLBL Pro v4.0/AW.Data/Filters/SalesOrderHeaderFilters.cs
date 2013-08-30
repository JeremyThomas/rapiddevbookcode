﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Data.ViewModels;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Filters
{
  public static class SalesOrderHeaderFilters
  {
    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery, OrderSearchCriteria orderSearchCriteria)
    {
      return FilterByDateOrderIDOrderNumberCustomerNameAddress(salesOrderHeaderQuery, orderSearchCriteria.FromDate, orderSearchCriteria.ToDate, orderSearchCriteria.OrderID,
        orderSearchCriteria.OrderNumber, orderSearchCriteria.FirstName, orderSearchCriteria.LastName, orderSearchCriteria.CityName, orderSearchCriteria.StateName, orderSearchCriteria.Zip, orderSearchCriteria.Countries);
    }

    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
                                                                                                       DateTime fromDate, DateTime toDate, int orderID, string orderNumber, 
      string firstName, string lastName, string cityName, string stateName, string zip,
                                                                                                       IEnumerable<string> countries)
    {
      if (fromDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.OrderDate <= toDate);
      if (firstName != "")
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => ((IndividualEntity) q.Customer).Contact.FirstName.Contains(firstName));
      if (lastName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => ((IndividualEntity) q.Customer).Contact.LastName.Contains(lastName));

      if (cityName != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == cityName)
                                select soh;
      if (stateName != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == stateName)
                                select soh;
      if (countries.Any())
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                                select soh;
      if (zip != "")
        salesOrderHeaderQuery = from soh in salesOrderHeaderQuery
                                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == zip)
                                select soh;
      if (orderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderID == orderID);
      if (!string.IsNullOrEmpty(orderNumber))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(q => q.SalesOrderNumber == orderNumber);

      return salesOrderHeaderQuery;
    }

    public static IQueryable<SalesOrderHeaderEntity> FilterByDateOrderIDOrderNumberCustomerNameAddressLambda(this IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery,
                                                                                                             OrderSearchCriteria orderSearchCriteria)
    {
      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.OrderDate >= orderSearchCriteria.FromDate);
      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.OrderDate <= orderSearchCriteria.ToDate);
      if (orderSearchCriteria.FirstName != "")
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => ((IndividualEntity)soh.Customer).Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (orderSearchCriteria.LastName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => ((IndividualEntity)soh.Customer).Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (orderSearchCriteria.CityName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (orderSearchCriteria.StateName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      if (orderSearchCriteria.CountryName != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == orderSearchCriteria.CountryName));
      if (orderSearchCriteria.Zip != "")
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));
      if (orderSearchCriteria.OrderID != 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.SalesOrderID == orderSearchCriteria.OrderID);
      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        salesOrderHeaderQuery = salesOrderHeaderQuery.Where(soh => soh.SalesOrderNumber == orderSearchCriteria.OrderNumber);

      return salesOrderHeaderQuery;
    }

    public static Expression<Func<SalesOrderHeaderEntity, bool>> FilterByDateOrderIDOrderNumberCustomerNameAddressPredicateBuilder(this Expression<Func<SalesOrderHeaderEntity, bool>> salesOrderHeaderPredicate,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.OrderDate >= orderSearchCriteria.FromDate);
      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.OrderDate <= orderSearchCriteria.ToDate);
      if (orderSearchCriteria.FirstName != "")
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => ((IndividualEntity)soh.Customer).Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (orderSearchCriteria.LastName != "")
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => ((IndividualEntity)soh.Customer).Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (orderSearchCriteria.CityName != "")
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (orderSearchCriteria.StateName != "")
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      var countriesList = orderSearchCriteria.Countries as IList<string> ?? orderSearchCriteria.Countries.ToList();
      if (countriesList.Any())
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => countriesList.Contains(ca.Address.StateProvince.CountryRegion.Name)));
      if (orderSearchCriteria.Zip != "")
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));
      if (orderSearchCriteria.OrderID != 0)
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.SalesOrderID == orderSearchCriteria.OrderID);
      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        salesOrderHeaderPredicate = salesOrderHeaderPredicate.And(soh => soh.SalesOrderNumber == orderSearchCriteria.OrderNumber);
      return salesOrderHeaderPredicate;
    }

    public static IPredicateExpression FilterByDateOrderIDOrderNumberCustomerNameAddress(IRelationCollection relations,OrderSearchCriteria orderSearchCriteria)
    {
      return FilterByDateOrderIDOrderNumberCustomerNameAddress(relations,orderSearchCriteria.FromDate, orderSearchCriteria.ToDate, orderSearchCriteria.OrderID,
        orderSearchCriteria.OrderNumber,orderSearchCriteria.FirstName,orderSearchCriteria.LastName,orderSearchCriteria.CityName,orderSearchCriteria.StateName,orderSearchCriteria.CountryName,orderSearchCriteria.Zip);
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
        relations.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID);
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
      if (!string.IsNullOrEmpty(orderNumber))
        filter.Add(SalesOrderHeaderFields.SalesOrderNumber == orderNumber);
      return filter;
    }

    public static IQueryable<T> FilterByProductID<T>(this IQueryable<T> transactionHistoryEntities, int productID)where T:TransactionHistoryEntity
    {
      return transactionHistoryEntities.Where(th => th.ProductID == productID);
    }

    public static IQueryable<T> FilterByProductIDWithLet<T>(this IQueryable<T> transactionHistoryEntities, int productID) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
             let soh = th as SalesOrderHistoryEntity
             where soh.ProductID == productID
             select th;
    }

    public static IQueryable<T> FilterByProductNumberWithLet<T>(this IQueryable<T> transactionHistoryEntities, string productNumber) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
             let soh = th as SalesOrderHistoryEntity
             where soh.Product.ProductNumber == productNumber
             select th;
    }
  }
}