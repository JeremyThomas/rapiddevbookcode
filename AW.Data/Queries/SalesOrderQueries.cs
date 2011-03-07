using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.HelperClasses;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Queries
{
  public static class SalesOrderQueries
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
      var Filter = SalesOrderHeaderFilters.FilterByDateOrderIDOrderNumberCustomerNameAddress(relations, FromDate, ToDate, OrderID, OrderNumber, FirstName, LastName, CityName, StateName, CountryName, Zip);
      ISortExpression Sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      var Orders = new SalesOrderHeaderCollection();
      //note      Orders.SupportsSorting = true;

      IPrefetchPath Prefetch = prefetch ? new PrefetchPath((int) EntityType.SalesOrderHeaderEntity) {SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated} : null;
      Orders.GetMulti(Filter, maxNumberOfItemsToReturn, Sort, relations, Prefetch);
      return Orders;
    }

    public static CollectionCore<SalesOrderHeaderEntity> GetSalesOrderHeaderCollectionWithLinq
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
      var predicate = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddressLambda(FromDate, ToDate, FirstName, LastName, CityName, StateName, CountryName, Zip, OrderID, OrderNumber);

      if (prefetch)
        predicate = predicate.WithPath(p => p.Prefetch(c => c.CustomerViewRelated));
      if (maxNumberOfItemsToReturn > 0)
        predicate = predicate.Take(maxNumberOfItemsToReturn);
      //return ((ILLBLGenProQuery)predicate).Execute<SalesOrderHeaderCollection>();
      return predicate.ToEntityCollection();
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
      IEnumerable<string> countries,
      string zip,
      int maxNumberOfItemsToReturn
      )
    {
      var query = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddress(fromDate, toDate, orderID, orderNumber, firstName, lastName, cityName, stateName, zip, countries);

      if (maxNumberOfItemsToReturn > 0)
        query = query.Take(maxNumberOfItemsToReturn);
      return query;
    }
  }
}