using AW.Data.CollectionClasses;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;
using ProductFields = Northwind.DAL.HelperClasses.ProductFields;

namespace AW.Tests
{
  [TestClass]
  public class QuerySpecUnitTest
  {
    [TestMethod]
    public void FetchEntityWithRenamedPkField()
    {
      var qf = new QueryFactory();
      var q = qf.Address.Where(AddressFields.AddressID == 3);
      var addresses = new AddressCollection();
      addresses.GetMulti(q);
      Assert.AreEqual(1, addresses.Count);
    }

    [TestMethod]
    public void GetCustomersWithProductFilter()
    {
      using (var adapter = new DataAccessAdapter())
      {
        var qf = new Northwind.DAL.FactoryClasses.QueryFactory();
        var q = qf.Customer
          .From(QueryTarget.InnerJoin(CustomerEntity.Relations.OrderEntityUsingCustomerId)
            .InnerJoin(OrderEntity.Relations.OrderDetailEntityUsingOrderId)
            .InnerJoin(OrderDetailEntity.Relations.ProductEntityUsingProductId))
          .Where(ProductFields.ProductId == 1);

        Assert.AreEqual(31, adapter.FetchQuery(q).Count);
      }
    }
  }
}