using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.Filters;
using AW.Data.HelperClasses;
using AW.Data.Linq;
using AW.Data.ViewModels;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;

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
      //note      Orders.SupportsSorting = true;
      IPrefetchPath prefetchPath = prefetch ? new PrefetchPath((int) EntityType.SalesOrderHeaderEntity) {SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated} : null;
      var relations = new RelationCollection();
      if (orderSearchCriteria.HasCustomerViewRelatedCriteria())
      {
        relations.Add(SalesOrderHeaderEntity.Relations.IndividualEntityUsingCustomerID);
        relations.Add(IndividualEntity.Relations.ContactEntityUsingContactID);
        relations.Add(IndividualEntity.Relations.CustomerAddressEntityUsingCustomerID);
      }
      var orders = new SalesOrderHeaderCollection();
      var filter = orderSearchCriteria.GetPredicateExpression();
      ISortExpression sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      orders.GetMulti(filter, maxNumberOfItemsToReturn, sort, relations, prefetchPath);
      return orders;
    }

    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollectionCustomerViewRelated
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      //note      Orders.SupportsSorting = true;
      IPrefetchPath prefetchPath = prefetch ? new PrefetchPath((int) EntityType.SalesOrderHeaderEntity) {SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated} : null;
      var relations = new RelationCollection();
      if (orderSearchCriteria.HasCustomerViewRelatedCriteria())
        relations.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID);
      var orders = new SalesOrderHeaderCollection();
      var filter = orderSearchCriteria.GetPredicateExpressionCustomerView();
      ISortExpression sort = new SortExpression {SalesOrderHeaderFields.OrderDate | SortOperator.Ascending};
      orders.GetMulti(filter, maxNumberOfItemsToReturn, sort, relations, prefetchPath);
      return orders;
    }

    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollectionQuerySpec
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var filter = orderSearchCriteria.GetPredicateExpression();
      var qf = new QueryFactory();
      var q = qf.SalesOrderHeader.Where(filter);
      q.OrderBy(SalesOrderHeaderFields.OrderDate | SortOperator.Ascending).Page(1, maxNumberOfItemsToReturn);
      if (orderSearchCriteria.HasCustomerViewRelatedCriteria())
        q.From(QueryTarget.InnerJoin(SalesOrderHeaderEntity.Relations.IndividualEntityUsingCustomerID)
          .InnerJoin(IndividualEntity.Relations.ContactEntityUsingContactID).InnerJoin(IndividualEntity.Relations.CustomerAddressEntityUsingCustomerID));
      if (prefetch)
        q.WithPath(SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated);
      var orders = new SalesOrderHeaderCollection();
      orders.GetMulti(q);
      return orders;
    }

    public static SalesOrderHeaderCollection GetSalesOrderHeaderCollectionQuerySpecCustomerViewRelated
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var filter = orderSearchCriteria.GetPredicateExpressionCustomerView();
      var qf = new QueryFactory();
      var q = qf.SalesOrderHeader.Where(filter);
      q.OrderBy(SalesOrderHeaderFields.OrderDate | SortOperator.Ascending).Page(1, maxNumberOfItemsToReturn);
      if (orderSearchCriteria.HasCustomerViewRelatedCriteria())
        q.From(QueryTarget.InnerJoin(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerID));
      if (prefetch)
        q.WithPath(SalesOrderHeaderEntity.PrefetchPathCustomerViewRelated);
      var orders = new SalesOrderHeaderCollection();
      orders.GetMulti(q);
      return orders;
    }

    public static CollectionCore<SalesOrderHeaderEntity> GetSalesOrderHeaderCollectionWithLinq
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch
      )
    {
      var salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddress(orderSearchCriteria);

      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      if (maxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(maxNumberOfItemsToReturn);
      if (prefetch)
        salesOrderHeaderQuery = salesOrderHeaderQuery.PrefetchCustomerViewRelated();
      return salesOrderHeaderQuery.ToEntityCollection();
    }

    public static IQueryable<SalesOrderHeaderEntity> DoSalesOrderHeaderLinqQueryCustomerViewRelated
      (
      OrderSearchCriteria orderSearchCriteria,
      int maxNumberOfItemsToReturn,
      bool prefetch = false
      )
    {
      var salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader.FilterByDateOrderIDOrderNumberCustomerNameAddressCustomerViewRelated(orderSearchCriteria);

      salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);

      if (maxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(maxNumberOfItemsToReturn);

      if (prefetch)
        salesOrderHeaderQuery = salesOrderHeaderQuery.PrefetchCustomerViewRelated();
      return salesOrderHeaderQuery;
    }
  }
}