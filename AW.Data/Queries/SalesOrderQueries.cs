using System;
using System.Collections.Generic;
using System.Linq;
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
      var predicate = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddressLambda(orderSearchCriteria);

      if (prefetch)
        predicate = predicate.PrefetchCustomerViewRelated();
      if (maxNumberOfItemsToReturn > 0)
        predicate = predicate.Take(maxNumberOfItemsToReturn);
      //return ((ILLBLGenProQuery)predicate).Execute<SalesOrderHeaderCollection>();
      return predicate.ToEntityCollection();
    }

    public static IQueryable<SalesOrderHeaderEntity> DoSalesOrderHeaderLinqQuery
      (
       OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn
      )
    {
      var query = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddress(orderSearchCriteria);

      if (maxNumberOfItemsToReturn > 0)
        query = query.Take(maxNumberOfItemsToReturn);
      return query;
    }
  }
}