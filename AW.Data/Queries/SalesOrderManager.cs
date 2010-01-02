using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Queries
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
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var relations = new RelationCollection();
      IPredicateExpression Filter = new PredicateExpression();
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
        Filter.Add(SalesOrderHeaderFields.OrderDate >= FromDate);
      if (ToDate != DateTime.MinValue)
        Filter.Add(SalesOrderHeaderFields.OrderDate <= ToDate);
      if (FirstName != "")
        Filter.Add(CustomerViewRelatedFields.FirstName%FirstName);
      if (LastName != "")
        Filter.Add(CustomerViewRelatedFields.LastName%LastName);
      if (CityName != "")
        Filter.Add(CustomerViewRelatedFields.City%CityName);
      if (StateName != "")
        Filter.Add(CustomerViewRelatedFields.StateProvinceName == StateName);
      if (CountryName != "")
        Filter.Add(CustomerViewRelatedFields.CountryRegionName == CountryName);
      if (Zip != "")
        Filter.Add(CustomerViewRelatedFields.PostalCode == Zip);
      if (OrderID != 0)
        Filter.Add(SalesOrderHeaderFields.SalesOrderID == OrderID);
      if (OrderNumber != "")
        Filter.Add(SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
      ISortExpression Sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      var Orders = new SalesOrderHeaderCollection();
      //note      Orders.SupportsSorting = true;

      IPrefetchPath Prefetch = prefetch ? new PrefetchPath((int) EntityType.SalesOrderHeaderEntity) {SalesOrderHeaderEntityBase.PrefetchPathCustomerViewRelated}:null;
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
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var predicate = MetaSingletons.MetaData.SalesOrderHeader.AsQueryable();
      if (FromDate != DateTime.MinValue)
        predicate = predicate.Where(soh => soh.OrderDate >= FromDate);
      if (ToDate != DateTime.MinValue)
        predicate = predicate.Where(soh => soh.OrderDate <= ToDate);
      if (FirstName != "")
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains(FirstName));
      if (LastName != "")
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.LastName.Contains(LastName));
      if (CityName != "")
        predicate = predicate.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == CityName));
      if (StateName != "")
        predicate = predicate.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == StateName));
      if (CountryName != "")
        predicate = predicate.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == CountryName));
      if (Zip != "")
        predicate = predicate.Where(soh => soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == Zip));
      if (OrderID != 0)
        predicate = predicate.Where(soh => soh.SalesOrderID == OrderID);
      if (OrderNumber != "")
        predicate = predicate.Where(soh => soh.SalesOrderNumber == OrderNumber);
      if (prefetch)
        predicate = predicate.WithPath(p => p.Prefetch(c => c.CustomerViewRelated));
      predicate= predicate.OrderBy(s => s.OrderDate);
      if (maxNumberOfItemsToReturn > 0)
        predicate = predicate.Take(maxNumberOfItemsToReturn);
      return ((ILLBLGenProQuery) predicate).Execute<SalesOrderHeaderCollection>();
    }

    public static IQueryable<SalesOrderHeaderEntity> DoSalesOrderHeaderLinqQuery
      (
      DateTime fromDate,
      DateTime toDate,
      string firstName,
      string lastName,
      int orderID,
      string orderNumber,
      string cityName,
      string stateName,
      List<string> countries,
      string zip,
      int maxNumberOfItemsToReturn
      )
    {
      var query = MetaSingletons.MetaData.SalesOrderHeader.AsQueryable();

      if (fromDate != DateTime.MinValue)
        query = query.Where(q => q.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        query = query.Where(q => q.OrderDate <= toDate);
      if (firstName != "")
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        query = query.Where(q => q.Customer.Individual.Contact.FirstName.Contains(firstName));
      if (lastName != "")
        query = query.Where(q => q.Customer.Individual.Contact.LastName.Contains(lastName));

      if (cityName != "")
        query = from soh in query
                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == cityName)
                select soh;
      if (stateName != "")
        query = from soh in query
                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == stateName)
                select soh;
      if (countries.Count > 0)
        query = from soh in query
                where soh.Customer.CustomerAddresses.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                select soh;
      if (zip != "")
        query = from soh in query
                where soh.Customer.CustomerAddresses.Any(ca => ca.Address.PostalCode == zip)
                select soh;
      if (orderID != 0)
        query = query.Where(q => q.SalesOrderID == orderID);
      if (orderNumber != "")
        query = query.Where(q => q.SalesOrderNumber == orderNumber);

      query = query.OrderBy(s => s.OrderDate);

      if (maxNumberOfItemsToReturn > 0)
        query = query.Take(maxNumberOfItemsToReturn);
      return query;
    }
  }
}