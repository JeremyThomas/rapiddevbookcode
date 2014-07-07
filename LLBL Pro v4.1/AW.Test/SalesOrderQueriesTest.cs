using System.Linq;
using AW.Data.Queries;
using AW.Data.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for SalesOrderQueries and is intended
  ///   to contain all SalesOrderQueries Unit Tests
  /// </summary>
  [TestClass]
  public class SalesOrderQueriesTest
  {
    /// <summary>
    ///   Gets or sets the test context which provides
    ///   information about and functionality for the current test run.
    /// </summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes      

    private static readonly OrderSearchCriteria OrderSearchCriteria = new OrderSearchCriteria {StateName = "California", FirstName = "Jon"};
    private const int MaxNumberOfItemsToReturn = 5;
    private const bool Prefetch = true;

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

    /// <summary>
    ///   A test for GetSalesOrderHeaderCollectionWithLinq
    /// </summary>
    [TestMethod]
    public void GetSalesOrderHeaderCollectionWithLinqTest()
    {
      var actual = SalesOrderQueries.GetSalesOrderHeaderCollectionWithLinq(OrderSearchCriteria, MaxNumberOfItemsToReturn, Prefetch);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
      //Assert.IsNotNull(actual[0].CustomerViewRelated);
    }

    /// <summary>
    ///   A test for GetSalesOrderHeaderCollection
    /// </summary>
    [TestMethod]
    public void GetSalesOrderHeaderCollectionTest()
    {
      var actual = SalesOrderQueries.GetSalesOrderHeaderCollection(OrderSearchCriteria, MaxNumberOfItemsToReturn, Prefetch);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
      //Assert.IsNotNull(actual[0].CustomerViewRelated);
    }

    /// <summary>
    ///   A test for GetSalesOrderHeaderCollectionQuerySpec
    /// </summary>
    [TestMethod]
    public void GetSalesOrderHeaderCollectionQuerySpecTest()
    {
      var actual = SalesOrderQueries.GetSalesOrderHeaderCollectionQuerySpec(OrderSearchCriteria, MaxNumberOfItemsToReturn, Prefetch);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
      //Assert.IsNotNull(actual[0].CustomerViewRelated);
    }

    /// <summary>
    ///   A test for DoSalesOrderHeaderLinqQueryCustomerViewRelated
    /// </summary>
    [TestMethod]
    public void DoSalesOrderHeaderLinqQueryTest()
    {
      var actual = SalesOrderQueries.DoSalesOrderHeaderLinqQueryCustomerViewRelated(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.ToList().Count());
    }
  }
}