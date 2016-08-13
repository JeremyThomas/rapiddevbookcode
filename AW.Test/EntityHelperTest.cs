using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Helper;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using CommonEntityBase = AW.Data.EntityClasses.CommonEntityBase;
using CustomerEntity = AW.Data.EntityClasses.CustomerEntity;
using EmployeeEntity = Northwind.DAL.EntityClasses.EmployeeEntity;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for EntityHelpe and is intended
  ///   to contain all EntityHelper Unit Tests
  /// </summary>
  [TestClass]
  public class EntityHelperTest
  {
    public static readonly int NumberOfEntities = Enum.GetValues(typeof(EntityType)).GetLength(0);

    /// <summary>
    ///   Gets or sets the test context which provides
    ///   information about and functionality for the current test run.
    /// </summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion

    private static EntityCollectionBase<T> ToEntityCollectionTestHelper<T>() where T : CommonEntityBase
    {
      var query = MetaSingletons.MetaData.GetQueryableForEntity<T>();
      var expected = FetchEntityCollection<T>();

      var actual = query.ToEntityCollection(); //DataSourceBase
      CollectionAssert.AreEqual(expected, actual);

      actual = query.Distinct().ToEntityCollection(); //LLBLGenProQuery
      CollectionAssert.AreEqual(expected, actual);

      actual = (query).ToEntityCollection(); //DataSourceBase as IEnumerable<T> 
      CollectionAssert.AreEqual(expected, actual);

      CollectionAssert.AreEqual(expected, actual.Distinct().ToEntityCollection()); //IEnumerable<T> 

      var actualQueryable = actual.AsQueryable().ToEntityCollection();
      CollectionAssert.AreEqual(expected, actualQueryable); //IQueryable not ILLBLGenProQuery

      Assert.AreEqual(expected, expected.ToEntityCollection());
      var entityCollectionBase = (EntityCollectionBase<T>) EntityHelper.ToEntityCollection(expected, typeof(T));
      CollectionAssert.AreEqual(expected, entityCollectionBase); //IEnumerable
      Assert.AreEqual(expected, entityCollectionBase);

      var emptyCollection = FactoryHelper.CreateEntityCollection<T>();
      CollectionAssert.AreEqual(emptyCollection, emptyCollection.Distinct().ToEntityCollection()); //IEnumerable<T> 
      return expected;
    }

    private static EntityCollectionBase<T> FetchEntityCollection<T>() where T : EntityBase
    {
      var expected = FactoryHelper.CreateEntityCollection<T>();
      expected.GetMulti(null);
      return expected;
    }

    private static EntityCollectionBase<T> FetchEntityCollection<T>(IElementCreatorCore elementCreatorCore) where T : EntityBase
    {
      var expected = (IEntityFactory) elementCreatorCore.GetFactory(typeof(T)).Create() as EntityCollectionBase<T>;
      if (expected != null)
      {
        expected.GetMulti(null);
        return expected;
      }
      return null;
    }

    [TestMethod, Description("A test for ToEntityCollection")]
    public void ToEntityCollectionTest()
    {
      ToEntityCollectionTestHelper<AddressTypeEntity>();
    }

    [TestMethod, TestCategory("Slow"), Description("A test for ToEntityCollection for abstract entities")]
    public void ToEntityCollectionAbstractTest()
    {
      ToEntityCollectionTestHelper<TransactionHistoryEntity>();
    }

    [TestMethod, Description("A test for ToEntityCollection for a non - abstract base entities")]
    public void ToEntityCollectionBaseClassTest()
    {
      ToEntityCollectionTestHelper<CustomerEntity>();
    }

    [TestMethod, Description("A test for GetEntitiesTypes")]
    public void GetEntitiesTypesTest()
    {
      var allLoadedDescendanceEntitiesType = EntityHelper.GetEntitiesTypes().ToList();
      if (allLoadedDescendanceEntitiesType.Count() == NumberOfEntities)
      {
        var commonEntityBaseEntitiesType = MetaDataHelper.GetDescendants(typeof(CommonEntityBase)).ToList();
        var assemblyEntitiesType = EntityHelper.GetEntitiesTypes(MetaSingletons.MetaData.GetType().Assembly).ToList();
        CollectionAssert.AreEqual(allLoadedDescendanceEntitiesType, commonEntityBaseEntitiesType);
        CollectionAssert.AreEqual(commonEntityBaseEntitiesType, assemblyEntitiesType);
        Assert.AreEqual(NumberOfEntities, allLoadedDescendanceEntitiesType.Count);
      }
    }


    /// <summary>
    ///   A test for GetQueryableForEntity
    /// </summary>
    private void GetQueryableForEntityTestHelper<T>() where T : class, IEntityCore
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity<T>();
      Assert.IsInstanceOfType(actual, typeof(DataSource<T>));
    }

    [TestMethod]
    public void GetQueryableForEntityTest()
    {
      GetQueryableForEntityTestHelper<AddressTypeEntity>();
    }

    [TestMethod]
    public void GetQueryableForAbstractEntityTest()
    {
      GetQueryableForEntityTestHelper<TransactionHistoryEntity>();
    }

    /// <summary>
    ///   A test for GetQueryableForEntity
    /// </summary>
    [TestMethod]
    public void GetQueryableForEntityTestNonGeneric()
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(typeof(AddressTypeEntity));
      Assert.IsInstanceOfType(actual, MetaSingletons.MetaData.AddressType.GetType());
    }

    [TestMethod]
    public void GetQueryableForAbstractEntityTestNonGeneric()
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(typeof(TransactionHistoryEntity));
      Assert.IsInstanceOfType(actual, MetaSingletons.MetaData.TransactionHistory.GetType());
    }

    /// <summary>
    ///   A test for GetQueryableForEntity
    /// </summary>
    private static void GetQueryableForEntityWithEntityTestHelper<T>(T entity) where T : class, IEntityCore
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(entity);
      Assert.IsInstanceOfType(actual, typeof(DataSource<T>));
    }

    [TestMethod]
    public void GetQueryableForEntityWithEntityTest()
    {
      GetQueryableForEntityWithEntityTestHelper(new AddressTypeEntity());
    }

    [TestMethod]
    public void GetQueryableForAbstractEntityWithEntityTest()
    {
      GetQueryableForEntityWithEntityTestHelper(FactoryHelper.CreateEntity<TransactionHistoryEntity>());
    }

    /// <summary>
    ///   A test for GetEntityTypeValueForType
    /// </summary>
    [TestMethod]
    public void GetEntityTypeValueForTypeTest()
    {
      var actual = EntityHelper.GetEntityTypeValueForType(typeof(AddressTypeEntity));
      Assert.AreEqual((int) EntityType.AddressTypeEntity, actual);
    }

    [TestMethod]
    public void GetAbstractEntityTypeValueForTypeTest()
    {
      var actual = EntityHelper.GetEntityTypeValueForType(typeof(TransactionHistoryEntity));
      Assert.AreEqual((int) EntityType.TransactionHistoryEntity, actual);
    }

    [TestMethod]
    public void GetNavigatorPropertiesTest()
    {
      var customer = new Northwind.DAL.EntityClasses.CustomerEntity();
      var properties = EntityHelper.GetNavigatorProperties(customer);
      Assert.AreEqual(4, properties.Count());

      var employeeEntity = new EmployeeEntity();
      properties = EntityHelper.GetNavigatorProperties(employeeEntity);
      Assert.AreEqual(6, properties.Count());

      var orderDetailEntity = new OrderDetailEntity();
      properties = EntityHelper.GetNavigatorProperties(orderDetailEntity);
      Assert.AreEqual(2, properties.Count());
    }

    [TestMethod]
    public void GetChildCountsAdapterTest()
    {
      var order = new OrderEntity(10253);
      using (var dataAccessAdapter = new DataAccessAdapter())
      {
        var childCounts = EntityHelper.GetChildCounts(dataAccessAdapter, order);
        Assert.AreEqual(1, childCounts.Count());
        Assert.AreEqual(3, childCounts.First().Item2);

        var entityTypeRelationPredicateBucketTuple = EntityHelper.CreateRelationPredicateBucket(OrderEntity.Relations.OrderDetailEntityUsingOrderId, ((IEntity2)order).PrimaryKeyFields);
        var entityFields2 = new EntityFields2(OrderEntity.Relations.OrderDetailEntityUsingOrderId.GetAllFKEntityFieldCoreObjects().ToArray(), null, null);
        Assert.AreEqual(3, dataAccessAdapter.GetDbCount(entityFields2, entityTypeRelationPredicateBucketTuple.Item2));
        
        var asEntityFieldCoreArray = entityFields2.GetAsEntityFieldCoreArray();
        var fieldPersistenceInfos = asEntityFieldCoreArray.Select(e => EntityHelper.GetFieldPersistenceInfoSafely(dataAccessAdapter, (IEntityField2)e)).ToArray();
        var dynamicQueryEngine = new DynamicQueryEngine();
        var rowCountDq = dynamicQueryEngine.CreateRowCountDQ(asEntityFieldCoreArray, fieldPersistenceInfos, null, 
          entityTypeRelationPredicateBucketTuple.Item2.PredicateExpression, entityTypeRelationPredicateBucketTuple.Item2.Relations, true, null);
        var result = dataAccessAdapter.ExecuteScalarQuery(rowCountDq);
        Assert.AreEqual(3, result);
      }
    }

    [TestMethod]
    public void GetChildCountSelfServicingTest()
    {
      var orders = new SalesOrderDetailCollection();
      var salesOrderHeaderEntityUsingSalesOrderID = SalesOrderDetailEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID;
      var relations = new RelationCollection {salesOrderHeaderEntityUsingSalesOrderID};
      var salesOrderHeaderEntity = new SalesOrderHeaderEntity(43659);
      var predicate = SalesOrderHeaderFields.SalesOrderID.Equal(salesOrderHeaderEntity.SalesOrderID);
      var amount = orders.GetDbCount(predicate, relations);
      Assert.AreEqual(12, amount);
      var salesOrderDetailDao = new SalesOrderDetailDAO();
      var salesOrderDetailEntity = new SalesOrderDetailEntity();
      var amount2 = salesOrderDetailDao.GetDbCount(salesOrderDetailEntity.Fields, null, predicate, relations, null);
      Assert.AreEqual(amount, amount2);

      var salesOrderDetailEntityUsingSalesOrderID = SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderID;
      var entityTypeRelationPredicateBucketTuple = EntityHelper.CreateRelationPredicateBucket(salesOrderDetailEntityUsingSalesOrderID, ((IEntity) salesOrderHeaderEntity).PrimaryKeyFields);
      var entityFields2 = new EntityFields(salesOrderDetailEntityUsingSalesOrderID.GetAllFKEntityFieldCoreObjects().ToArray(), null, null);
      var amount3 = salesOrderDetailDao.GetDbCount(entityFields2, null, predicate, relations, null, true);
      Assert.AreEqual(amount, amount3);

      var salesOrderDetailFieldsSalesOrderIDPredicate = SalesOrderDetailFields.SalesOrderID.Equal(salesOrderHeaderEntity.SalesOrderID);
      var amount4 = salesOrderDetailDao.GetDbCount(entityFields2, null, salesOrderDetailFieldsSalesOrderIDPredicate, null, null, true);
      Assert.AreEqual(amount, amount4);

      var fieldCompareValuePredicate = new FieldCompareValuePredicate(SalesOrderDetailFields.SalesOrderID, null, ComparisonOperator.Equal, salesOrderHeaderEntity.SalesOrderID);

      var asEntityFieldCoreArray = entityFields2.GetAsEntityFieldCoreArray();
      var dynamicQueryEngine = new DynamicQueryEngine();

      var selectFilter = entityTypeRelationPredicateBucketTuple.Item2.PredicateExpression[0].Contents as IPredicate;
      var rowCountDq = dynamicQueryEngine.CreateRowCountDQ(asEntityFieldCoreArray, entityFields2.GetAsPersistenceInfoArray(), salesOrderDetailDao.DetermineConnectionToUse(null),
        selectFilter
      //  salesOrderDetailFieldsSalesOrderIDPredicate
        , null, true, null);
     var result =  salesOrderDetailDao.ExecuteScalarQuery(rowCountDq, null);
      Assert.AreEqual(amount, result);

      var amount5 = salesOrderDetailDao.GetDbCount(entityFields2, null, entityTypeRelationPredicateBucketTuple.Item2.PredicateExpression, entityTypeRelationPredicateBucketTuple.Item2.Relations, null, true);
      Assert.AreEqual(amount, amount5);

      var amount6 = EntityHelper.GetChildCount(salesOrderDetailDao, salesOrderHeaderEntity, salesOrderDetailEntityUsingSalesOrderID, new List<string>());
      Assert.AreEqual(amount, amount6.Item2);
    }
  }
}