using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Data.WinForms;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Business
{
  public static class SalesOrderManager
  {
    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollection
      (
      DateTime FromDate,
      DateTime ToDate,
      string FirstName,
      string LastName,
      int OrderID,
      string OrderNumber,
      string CityName,
      string StateName,
      string CountryName,
      string Zip,
      int maxNumberOfItemsToReturn
      )
    {
      var relations = new RelationCollection();
      IPredicateExpression Filter = new PredicateExpression();
      if (
        (FirstName != "") |
        (LastName != "") |
        (CityName != "") |
        (StateName != "") |
        (CountryName != "") |
        (Zip != "")
        )
      {
        relations.Add(SalesOrderHeaderEntityBase.Relations.CustomerViewRelatedEntityUsingCustomerId);
      }
      if (FromDate != DateTime.MinValue)
      {
        Filter.Add(
          SalesOrderHeaderFields.OrderDate >= FromDate);
      }
      if (ToDate != DateTime.MinValue)
      {
        Filter.Add(
          SalesOrderHeaderFields.OrderDate <= ToDate);
      }
      if (FirstName != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.FirstName%FirstName);
      }
      if (LastName != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.LastName%LastName);
      }
      if (CityName != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.City%CityName);
      }
      if (StateName != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.StateProvinceName == StateName);
      }
      if (CountryName != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.CountryRegionName == CountryName);
      }
      if (Zip != "")
      {
        Filter.Add(
          CustomerViewRelatedFields.PostalCode == Zip);
      }
      if (OrderID != 0)
      {
        Filter.Add(
          SalesOrderHeaderFields.SalesOrderId == OrderID);
      }
      if (OrderNumber != "")
      {
        Filter.Add(
          SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
      }
      ISortExpression Sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      var Orders = new SalesOrderHeaderCollection();
      //note      Orders.SupportsSorting = true;
      IPrefetchPath Prefetch = new PrefetchPath((int)EntityType.SalesOrderHeaderEntity) { SalesOrderHeaderEntityBase.PrefetchPathCustomerViewRelated };
      Orders.GetMulti(Filter, maxNumberOfItemsToReturn, Sort, relations, Prefetch);
      return Orders;
    }

    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollectionWithLinq
      (
      DateTime FromDate,
      DateTime ToDate,
      string FirstName,
      string LastName,
      int OrderID,
      string OrderNumber,
      string CityName,
      string StateName,
      string CountryName,
      string Zip,
      int maxNumberOfItemsToReturn
      )
    {
      var predicate = Validation.MetaData.SalesOrderHeader.AsQueryable();
      if (FromDate != DateTime.MinValue)
      {
        predicate = predicate.Where(soh => soh.OrderDate >= FromDate);
      }
      if (ToDate != DateTime.MinValue)
      {
        predicate = predicate.Where(soh => soh.OrderDate <= ToDate);
      }
      if (FirstName != "")
      {
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains(FirstName));
      }
      if (LastName != "")
      {
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.LastName.Contains(LastName));
      }
      if (CityName != "")
      {
        predicate = predicate.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.City == CityName));
      }
      if (StateName != "")
      {
        predicate = predicate.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.Name == StateName));
      }
      if (CountryName != "")
      {
        predicate = predicate.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.CountryRegion.Name == CountryName));
      }
      if (Zip != "")
      {
        predicate = predicate.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.PostalCode == Zip));
      }
      if (OrderID != 0)
      {
        predicate = predicate.Where(soh => soh.SalesOrderId == OrderID);
      }
      if (OrderNumber != "")
      {
        predicate = predicate.Where(soh => soh.SalesOrderNumber == OrderNumber);
      }
      var q = (from c in predicate select c).WithPath(p => p.Prefetch(c => c.CustomerViewRelated));
      q = q.OrderBy(s => s.OrderDate);
      if (maxNumberOfItemsToReturn > 0)
        q = q.Take(maxNumberOfItemsToReturn);
      return ((ILLBLGenProQuery) q).Execute<SalesOrderHeaderCollection>();
    }
  }
}
