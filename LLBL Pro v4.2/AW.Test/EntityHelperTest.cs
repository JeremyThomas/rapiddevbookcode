using System;
using System.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Helper;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
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
    public static readonly int NumberOfEntities = Enum.GetValues(typeof (EntityType)).GetLength(0);

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
      var entityCollectionBase = (EntityCollectionBase<T>) EntityHelper.ToEntityCollection(expected, typeof (T));
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
      var expected = (IEntityFactory) elementCreatorCore.GetFactory(typeof (T)).Create() as EntityCollectionBase<T>;
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

    [TestMethod, Description("A test for ToEntityCollection for abstract entities")]
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
        var commonEntityBaseEntitiesType = MetaDataHelper.GetDescendants(typeof (CommonEntityBase)).ToList();
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
      Assert.IsInstanceOfType(actual, typeof (DataSource<T>));
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
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(typeof (AddressTypeEntity));
      Assert.IsInstanceOfType(actual, MetaSingletons.MetaData.AddressType.GetType());
    }

    [TestMethod]
    public void GetQueryableForAbstractEntityTestNonGeneric()
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(typeof (TransactionHistoryEntity));
      Assert.IsInstanceOfType(actual, MetaSingletons.MetaData.TransactionHistory.GetType());
    }

    /// <summary>
    ///   A test for GetQueryableForEntity
    /// </summary>
    private void GetQueryableForEntityWithEntityTestHelper<T>(T entity) where T : class, IEntityCore
    {
      var actual = MetaSingletons.MetaData.GetQueryableForEntity(entity);
      Assert.IsInstanceOfType(actual, typeof (DataSource<T>));
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
      var actual = EntityHelper.GetEntityTypeValueForType(typeof (AddressTypeEntity));
      Assert.AreEqual((int) EntityType.AddressTypeEntity, actual);
    }

    [TestMethod]
    public void GetAbstractEntityTypeValueForTypeTest()
    {
      var actual = EntityHelper.GetEntityTypeValueForType(typeof (TransactionHistoryEntity));
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
  }
}