using System;
using System.ServiceModel;
using Northwind.DAL.DTO;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.Interfaces;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace Northwind.Business
{
  /// <summary>
  /// The implementation of our Northwind service. This service is started by the Host application. 
  /// From https://github.com/SolutionsDesign/LLBLGenProExamples_4.x/
  /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class NorthwindService : INorthwindService
    {
    /// <summary>
    /// Gets the statistics for the start screen.
    /// </summary>
    /// <returns>filled NWStatistics object</returns>
    public NWStatistics GetStatistics()
    {
      var toReturn = new NWStatistics();
      var qf = new QueryFactory();
      using(var adapter = new DataAccessAdapter())
      {
        toReturn.NumberOfCustomers = adapter.FetchScalar<int>(qf.Create().Select(qf.Customer.CountRow()));

        // calculate average order price in the DB.
        var avgQ = qf.Create()
                .Select(() => new { AvgPrice = qf.Field("OrderPrice").Source("T").Avg().As("AvgPrice").ToValue<Decimal>()})
                .From(qf.Create("T")
                      .Select(OrderDetailFields.OrderId, 
                          (OrderDetailFields.Quantity * OrderDetailFields.UnitPrice).Sum().As("OrderPrice"))
                      .GroupBy(OrderDetailFields.OrderId));
        var avgResults = adapter.FetchQuery(avgQ);
        toReturn.AverageOrderPrice = avgResults[0].AvgPrice;

        // calculate max, the orderid with that max, the customer of that order in 1 query on the DB using a desc order + limit 1 query.
        var maxQ = qf.Create()
                .Select(() => new
                {
                  OrderPrice = qf.Field("OrderPrice").Source("T").ToValue<decimal>(),
                  CustomerId = CustomerFields.CustomerId.ToValue<string>(),
                  CompanyName = CustomerFields.CompanyName.ToValue<string>()
                })
                .From(qf.Create("T")
                      .Select(OrderDetailFields.OrderId,
                          (OrderDetailFields.Quantity * OrderDetailFields.UnitPrice).Sum().As("OrderPrice"))
                      .GroupBy(OrderDetailFields.OrderId)
                    .InnerJoin(qf.Order).On(OrderFields.OrderId == OrderDetailFields.OrderId.Source("T"))
                    .InnerJoin(qf.Customer).On(CustomerFields.CustomerId == OrderFields.CustomerId))
                .OrderBy(qf.Field("OrderPrice").Source("T").Descending())
                .Limit(1);

        var maxResults = adapter.FetchFirst(maxQ);
        toReturn.MaxOrderPrice = maxResults.OrderPrice;
        toReturn.MaxOrderCustomerCustomerId = maxResults.CustomerId;
        toReturn.MaxOrderCustomerCompanyName = maxResults.CompanyName;

        // get number of max orders of one customer + the customerid of that customer in 1 query on the DB.
        var mostOrdersQ = qf.Create()
                  .Select(() => new
                  {
                    NumberOfOrders = qf.Field("NumberOfOrders").Source("T").ToValue<int>(),
                    CustomerId = CustomerFields.CustomerId.ToValue<string>(),
                    CompanyName = CustomerFields.CompanyName.ToValue<string>()
                  })
                  .From(qf.Create("T")
                        .Select(OrderFields.CustomerId, Functions.CountRow().As("NumberOfOrders"))
                        .GroupBy(OrderFields.CustomerId)
                      .InnerJoin(qf.Customer).On(OrderFields.CustomerId.Source("T") == CustomerFields.CustomerId))
                  .OrderBy(qf.Field("NumberOfOrders").Source("T").Descending())
                  .Limit(1);

        var mostOrdersResults = adapter.FetchFirst(mostOrdersQ);
        toReturn.MostOrdersCustomerCustomerId = mostOrdersResults.CustomerId;
        toReturn.MostOrdersCustomerCompanyName = mostOrdersResults.CompanyName;
        toReturn.MostOrdersForOneCustomer = mostOrdersResults.NumberOfOrders;
      }
      return toReturn;
    }


        /// <summary>
        /// Gets all customer entities
        /// </summary>
        /// <returns>entity collection with all customers</returns>
        public IEntityCollection2 GetAllCustomers()
        {
            var toReturn = new EntityCollection(new CustomerEntityFactory());
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // simply fetch all customer entities into the collection.
                adapter.FetchEntityCollection(toReturn, null);
            }
            return toReturn;
        }


        /// <summary>
        /// Gets all customers who have bought the product with the product id specified.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>an entity collection with 0 or more customers who have purchased the product with the id specified</returns>
        public IEntityCollection2 GetAllCustomersFilteredOnProduct(int productId)
        {
      var qf = new QueryFactory();
      var q = qf.Customer
            .From(QueryTarget
                .InnerJoin(qf.Order).On(CustomerFields.CustomerId == OrderFields.CustomerId)
                .InnerJoin(qf.OrderDetail).On(OrderFields.OrderId == OrderDetailFields.OrderId))
            .Where(OrderDetailFields.ProductId == productId);

      var customers = new EntityCollection(new CustomerEntityFactory());
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
        adapter.FetchQuery(q, customers);
            }
            return customers;
        }


    /// <summary>
    /// Gets a collection of Products sorted by the passed in field, and direction of sort.
    /// </summary>
    /// <param name="sortFieldName">Name of the sort field.</param>
    /// <param name="direction">direction of sort</param>
    /// <returns>a sorted products collection</returns>
    /// <remarks>Shows how to use message parameters to specify sorting.
    /// </remarks>
        public IEntityCollection2 GetProductsSortedBy(EntityField2 sortField, SortOperator direction)
        {
            var toReturn = new EntityCollection(new ProductEntityFactory());
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // fetch all products, sorted on the sort expression passed in
                adapter.FetchEntityCollection(toReturn, null, 0, new SortExpression(new SortClause(sortField, null, direction)));
            }
            return toReturn;        
        }


        /// <summary>
        /// Gets the numer of times product was sold.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns>the number of times the product was sold.</returns>
        public int GetNumerOfTimesProductWasSold(int productId)
        {
            if (productId == 0)
            {
                return 0;
            }

            int toReturn = 0;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // get scalar for amount of times this product is sold.
                object scalarValue = adapter.GetScalar(OrderDetailFields.Quantity, null, AggregateFunction.Sum, (OrderDetailFields.ProductId == productId));
                if (scalarValue != DBNull.Value)
                {
                    toReturn = (int)scalarValue;
                }
            }
            return toReturn;
        }


    /// <summary>
        /// Gets the customer entity + orders + order details for the customer of the customer id passed in.
        /// </summary>
        /// <param name="customerId">The customer id.</param>
        /// <returns>Customer entity with its order entities + order details entities per order for the customer passed in.</returns>
        //public IEntity2 GetCustomerWithFullOrders(string customerId)
        public CustomerEntity GetCustomerWithFullOrders(string customerId)
        {
            // fetch customer, orders and order details in one go with a prefetch path.
      var qf = new QueryFactory();
      var q = qf.Customer
            .Where(CustomerFields.CustomerId == customerId)
            .WithPath(CustomerEntity.PrefetchPathOrders
                  .WithSubPath(OrderEntity.PrefetchPathOrderDetails.WithOrdering(OrderDetailFields.OrderId.Ascending())));

      CustomerEntity toReturn = null;
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
        toReturn = adapter.FetchFirst(q);
            }

            return toReturn;
        }


    /// <summary>
    /// Commits the customer manager changes specified in the unit of work passed in.
    /// </summary>
    /// <param name="uow">The unit of work with the work to commit.</param>
    /// <returns>true if commit succeeded, false otherwise</returns>
    public bool CommitCustomerManagerChanges(UnitOfWork2 uow)
    {
      if(uow == null)
      {
        return false;
      }
      int numberOfElementsProcessed = 0;
      using(var adapter = new DataAccessAdapter())
      {
        numberOfElementsProcessed= uow.Commit(adapter);
      }
      return numberOfElementsProcessed > 0;
    }
    }
}
