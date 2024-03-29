using System.Linq;
using System.Linq.Dynamic;
using AW.Data.Queries;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
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

    [TestMethod, Description("A test for GetCustomerViewTypedView. Example 5.18. pg59 maxNumberOfItemsToReturn does not result in a SQL TOP command")]
    public void GetCustomerViewTypedViewTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedView(MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
    }

    [TestMethod, Description("A test for GetCustomerViewRelatedLinq. Gets the related customer view of SalesOrder 46117 with linq. Example 5.27 pg63.")]
    public void GetCustomerViewRelatedLinqTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedLinq();
      Assert.AreEqual(46117, actual.SalesOrderHeader[0].SalesOrderID);
    }

    [TestMethod, Description("A test for GetCustomerViewRelatedCollection. Gets the related customer view of SalesOrder 46117. Example 5.27 pg63.")]
    public void GetCustomerViewRelatedCollectionTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedCollection();
   Assert.AreEqual(46117, actual.SalesOrderHeader[0].SalesOrderID);
    }

    [TestMethod, Description("A test for GetCustomerListAnonymousLinq.")]
    public void GetCustomerListAnonymousLinqTest()
    {
    	var customerListAnonymousLinq = CustomerQueries.GetCustomerListAnonymousLinq(MaxNumberOfItemsToReturn);
    	Assert.AreEqual(MaxNumberOfItemsToReturn, customerListAnonymousLinq.Count());
    }

  	[TestMethod, Description("A test for GetCustomerListLinqedTypedList")]
    public void GetCustomerListLinqedTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListLinqedTypedList(MaxNumberOfItemsToReturn);
			Assert.AreEqual(MaxNumberOfItemsToReturn, actual.ToList().Count());
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    [TestMethod, Description("A test for GetCustomerListTypedList. Example 5.29. pg64.")]
    public void GetCustomerListTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListTypedList(MaxNumberOfItemsToReturn);
			Assert.AreEqual(MaxNumberOfItemsToReturn, actual.ToList().Count());
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }
  }
}