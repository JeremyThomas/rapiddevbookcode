﻿using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.HelperClasses;
using AW.Data.Linq;
using AW.Data.ViewModels;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Queries
{
  public static class SalesOrderQueries
  {
    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollection
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var relations = new RelationCollection();
      var filter = SalesOrderHeaderFilters.FilterByDateOrderIDOrderNumberCustomerNameAddress(relations, orderSearchCriteria);
      ISortExpression sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      var orders = new SalesOrderHeaderCollection();
      //note      Orders.SupportsSorting = true;

      IPrefetchPath prefetchPath = prefetch ? new PrefetchPath((int) EntityType.SalesOrderHeaderEntity) {SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated} : null;
      orders.GetMulti(filter, maxNumberOfItemsToReturn, sort, relations, prefetchPath);
      return orders;
    }

    public static CollectionCore<SalesOrderHeaderEntity> GetSalesOrderHeaderCollectionWithLinq
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddressLambda(orderSearchCriteria);

      if (prefetch)
        salesOrderHeaderQuery = salesOrderHeaderQuery.PrefetchCustomerViewRelated();
      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      if (maxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(maxNumberOfItemsToReturn);
      //return ((ILLBLGenProQuery)predicate).Execute<SalesOrderHeaderCollection>();
      return salesOrderHeaderQuery.ToEntityCollection();
    }

    public static IQueryable<SalesOrderHeaderEntity> DoSalesOrderHeaderLinqQuery
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn
      )
    {
      var salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddress(orderSearchCriteria);

      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);

      if (maxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(maxNumberOfItemsToReturn);
      return salesOrderHeaderQuery;
    }
  }
}