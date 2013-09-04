﻿using System;
using System.Linq;
using AW.Data.EntityClasses;
using AW.Data.ViewModels;

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

    public static IQueryable<CustomerViewRelatedEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<CustomerViewRelatedEntity> customerViewQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        customerViewQuery = customerViewQuery.Where(cv => cv.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        customerViewQuery = customerViewQuery.Where(cv => cv.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        customerViewQuery = customerViewQuery.Where(cv => cv.City == orderSearchCriteria.CityName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        customerViewQuery = customerViewQuery.Where(cv => cv.StateProvinceName == orderSearchCriteria.StateName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.CountryName))
        customerViewQuery = customerViewQuery.Where(cv => cv.CountryRegionName == orderSearchCriteria.CountryName);
      if (orderSearchCriteria.Countries.Any())
        customerViewQuery = from soh in customerViewQuery
          where orderSearchCriteria.Countries.Contains(soh.CountryRegionName)
          select soh;
      if (orderSearchCriteria.OrderID != 0)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.SalesOrderID == orderSearchCriteria.OrderID
          select cv;

      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.SalesOrderNumber == orderSearchCriteria.OrderNumber
          select cv;

      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.OrderDate >= orderSearchCriteria.FromDate
          select cv;

      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.OrderDate <= orderSearchCriteria.ToDate
          select cv;

      return customerViewQuery;
    }

    public static IQueryable<CustomerListLinqedTypedList> FilterByDateCustomerNameAddress(this IQueryable<CustomerListLinqedTypedList> customerViewQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        customerViewQuery = customerViewQuery.Where(cv => cv.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        customerViewQuery = customerViewQuery.Where(cv => cv.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        customerViewQuery = customerViewQuery.Where(cv => cv.City == orderSearchCriteria.CityName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        customerViewQuery = customerViewQuery.Where(cv => cv.StateProvinceName == orderSearchCriteria.StateName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.CountryName))
        customerViewQuery = customerViewQuery.Where(cv => cv.CountryRegionName == orderSearchCriteria.CountryName);
      if (orderSearchCriteria.Countries.Any())
        customerViewQuery = from soh in customerViewQuery
          where orderSearchCriteria.Countries.Contains(soh.CountryRegionName)
          select soh;
      return customerViewQuery;
    }

    public static IQueryable<IndividualEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<IndividualEntity> individualQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        individualQuery = individualQuery.Where(i => i.Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        individualQuery = individualQuery.Where(i => i.Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CountryName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == orderSearchCriteria.CountryName));
      if (orderSearchCriteria.Countries.Any())
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => orderSearchCriteria.Countries.Contains(ca.Address.StateProvince.CountryRegion.Name)));
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));
        if (orderSearchCriteria.FromDate != DateTime.MinValue)
          individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.OrderDate >= orderSearchCriteria.FromDate));
        if (orderSearchCriteria.ToDate != DateTime.MinValue)
          individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.OrderDate <= orderSearchCriteria.ToDate));
        if (orderSearchCriteria.OrderID != 0)
          individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.SalesOrderID == orderSearchCriteria.OrderID));
        if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
          individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.SalesOrderNumber == orderSearchCriteria.OrderNumber));
      return individualQuery;
    }
  }
}