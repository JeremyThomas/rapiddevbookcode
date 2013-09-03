using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.ViewModels
{
  public class OrderSearchCriteria
  {
    public OrderSearchCriteria(DateTime fromDate, DateTime toDate, string firstName, string lastName, int orderID,
      string orderNumber, string cityName, string stateName, IEnumerable<string> countries, string zip)
    {
      FromDate = fromDate;
      ToDate = toDate;
      FirstName = firstName;
      LastName = lastName;
      OrderID = orderID;
      OrderNumber = orderNumber;
      CityName = cityName;
      StateName = stateName;
      Countries = countries;
      Zip = zip;
    }

    public OrderSearchCriteria()
    {
      Countries = Enumerable.Empty<string>();
    }

    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int OrderID { get; set; }
    public string OrderNumber { get; set; }
    public string CityName { get; set; }
    public string StateName { get; set; }
    public IEnumerable<string> Countries { get; set; }
    public string Zip { get; set; }
    public string CountryName { get; set; }

    public bool HasCustomerViewRelatedCriteria()
    {
      return (!String.IsNullOrEmpty(FirstName)) ||
             (!String.IsNullOrEmpty(LastName)) ||
             (!String.IsNullOrEmpty(CityName)) ||
             (!String.IsNullOrEmpty(StateName)) ||
             (!String.IsNullOrEmpty(CountryName)) ||
             (!String.IsNullOrEmpty(Zip));
    }

    public bool HasSalesOrderRelatedCriteria()
    {
      return (
        FromDate != DateTime.MinValue ||
        ToDate != DateTime.MinValue ||
        OrderID != 0 ||
        !String.IsNullOrEmpty(OrderNumber)
        );
    }

    public IPredicateExpression GetPredicateExpressionCustomerView(bool includeSalesOrderHeader = true)
    {
      var filter = new PredicateExpression();
      if (includeSalesOrderHeader)
      {
        if (FromDate != DateTime.MinValue)
          filter.Add(SalesOrderHeaderFields.OrderDate >= FromDate);
        if (ToDate != DateTime.MinValue)
          filter.Add(SalesOrderHeaderFields.OrderDate <= ToDate);
        if (OrderID != 0)
          filter.Add(SalesOrderHeaderFields.SalesOrderID == OrderID);
        if (!String.IsNullOrEmpty(OrderNumber))
          filter.Add(SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
      }
      if (!String.IsNullOrEmpty(FirstName))
        filter.Add(CustomerViewRelatedFields.FirstName%FirstName);
      if (!String.IsNullOrEmpty(LastName))
        filter.Add(CustomerViewRelatedFields.LastName%LastName);
      if (!String.IsNullOrEmpty(CityName))
        filter.Add(CustomerViewRelatedFields.City%CityName);
      if (!String.IsNullOrEmpty(StateName))
        filter.Add(CustomerViewRelatedFields.StateProvinceName == StateName);
      if (!String.IsNullOrEmpty(CountryName))
        filter.Add(CustomerViewRelatedFields.CountryRegionName == CountryName);
      if (!String.IsNullOrEmpty(Zip))
        filter.Add(CustomerViewRelatedFields.PostalCode == Zip);
      return filter;
    }

    public IPredicateExpression GetPredicateExpression(bool includeSalesOrderHeader = true)
    {
      var filter = new PredicateExpression();
      if (includeSalesOrderHeader)
      {
        if (FromDate != DateTime.MinValue)
          filter.Add(SalesOrderHeaderFields.OrderDate >= FromDate);
        if (ToDate != DateTime.MinValue)
          filter.Add(SalesOrderHeaderFields.OrderDate <= ToDate);
        if (OrderID != 0)
          filter.Add(SalesOrderHeaderFields.SalesOrderID == OrderID);
        if (!String.IsNullOrEmpty(OrderNumber))
          filter.Add(SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
      }
      if (!String.IsNullOrEmpty(FirstName))
        filter.Add(ContactFields.FirstName % FirstName);
      if (!String.IsNullOrEmpty(LastName))
        filter.Add(ContactFields.LastName % LastName);
      if (!String.IsNullOrEmpty(CityName))
        filter.Add(AddressFields.City % CityName);
      if (!String.IsNullOrEmpty(StateName))
        filter.Add(StateProvinceFields.Name == StateName);
      if (!String.IsNullOrEmpty(CountryName))
        filter.Add(CountryRegionFields.Name == CountryName);
      if (!String.IsNullOrEmpty(Zip))
        filter.Add(AddressFields.PostalCode == Zip);
      return filter;
    }
  }
}