using System;
using System.Collections.Generic;
using System.Linq;

namespace AW.Data.ViewModels
{
  public class OrderSearchCriteria
  {
    public OrderSearchCriteria(DateTime fromDate, DateTime toDate, string firstName, string lastName, int orderID, string orderNumber, string cityName, string stateName, IEnumerable<string> countries, string zip)
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
      return (!String.IsNullOrEmpty(this.FirstName)) ||
             (!String.IsNullOrEmpty(this.LastName)) ||
             (!String.IsNullOrEmpty(this.CityName)) ||
             (!String.IsNullOrEmpty(this.StateName)) ||
             (!String.IsNullOrEmpty(this.CountryName)) ||
             (!String.IsNullOrEmpty(this.Zip));
    }
  }


}