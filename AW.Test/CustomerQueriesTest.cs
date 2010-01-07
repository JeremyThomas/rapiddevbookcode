using System.Linq;
using System.Linq.Dynamic;
using AW.Data.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for CustomerQueries and is intended
  ///to contain all CustomerQueries Unit Tests
  ///</summary>
  [TestClass]
  public class CustomerQueriesTest
  {
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
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

    const int MaxNumberOfItemsToReturn = 5;

    /// <summary>
    /// A test for GetCustomerViewTypedView
    /// </summary>
    [TestMethod]
    public void GetCustomerViewTypedViewTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedView(MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
    }

    /// <summary>
    ///A test for GetCustomerViewRelatedLinq
    ///</summary>
    [TestMethod]
    public void GetCustomerViewRelatedLinqTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedLinq();
      Assert.AreEqual(46117, actual.SalesOrderHeader[0].SalesOrderID);
    }

    /// <summary>
    ///A test for GetCustomerViewRelatedCollection
    ///</summary>
    [TestMethod]
    public void GetCustomerViewRelatedCollectionTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedCollection();
      Assert.AreEqual(1, actual.Count);
      Assert.AreEqual(46117, actual[0].SalesOrderHeader[0].SalesOrderID);
    }

    /// <summary>
    ///A test for GetCustomerListAnonymousLinq
    ///</summary>
    [TestMethod]
    public void GetCustomerListAnonymousLinqTest()
    {
      Assert.AreEqual(MaxNumberOfItemsToReturn, CustomerQueries.GetCustomerListAnonymousLinq(MaxNumberOfItemsToReturn).Count());
    }

    /// <summary>
    ///A test for GetCustomerListLinqedTypedList
    ///</summary>
    [TestMethod]
    public void GetCustomerListLinqedTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListLinqedTypedList(MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    /// <summary>
    ///A test for GetCustomerListTypedList
    ///</summary>
    [TestMethod]
    public void GetCustomerListTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListTypedList(MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }
  }
}