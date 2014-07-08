using System.Linq;
using System.Linq.Dynamic;
using AW.Data.Queries;
using AW.Data.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for CustomerQueries and is intended
  ///   to contain all CustomerQueries Unit Tests
  /// </summary>
  [TestClass]
  public class CustomerQueriesTest
  {
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

    private const int MaxNumberOfItemsToReturn = 5;
    private static readonly OrderSearchCriteria OrderSearchCriteria = new OrderSearchCriteria { StateName = "California", FirstName = "Jon" };

    [TestMethod, Description("A test for GetCustomerViewTypedView. Example 5.18. pg59 maxNumberOfItemsToReturn does not result in a SQL TOP command")]
    public void GetCustomerViewTypedViewTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedView(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
    }

    [TestMethod, Description("A test for GetCustomerViewTypedViewQuerySpec.")]
    public void GetCustomerViewTypedViewQuerySpecTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedViewQuerySpec(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
    }

    [TestMethod, Description("A test for GetCustomerViewTypedViewQuerySpecPoco.")]
    public void GetCustomerViewTypedViewQuerySpecPocoTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedViewQuerySpecPoco(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
    }

    [TestMethod, Description("A test for GetCustomerViewTypedViewLinq.")]
    public void GetCustomerViewTypedViewLinqTest()
    {
      var actual = CustomerQueries.GetCustomerViewTypedViewLinq(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count);
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
      var customerListAnonymousLinq = CustomerQueries.GetCustomerListAnonymousLinq(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, customerListAnonymousLinq.Count());
    }

    [TestMethod, Description("A test for GetCustomerListLinqedTypedList")]
    public void GetCustomerListLinqedTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListLinqedTypedList(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.ToList().Count());
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }
    
    [TestMethod, Description("A test for GetCustomerListLinqedTypedList")]
    public void GetCustomerListLinqedTypedListFilterFirstTest()
    {
      var actual = CustomerQueries.GetCustomerListLinqedTypedListFilterFirst(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    [TestMethod, Description("A test for GetCustomerListGeneratedLinqTypedList")]
    public void GetCustomerListGeneratedLinqTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListGeneratedLinqTypedList(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    [TestMethod, Description("A test for GetCustomerListTypedListQuerySpec")]
    public void GetCustomerListTypedListQuerySpecTest()
    {
      var actual = CustomerQueries.GetCustomerListTypedListQuerySpec(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    [TestMethod, Description("A test for GetCustomerListTypedListQuerySpecPoco")]
    public void GetCustomerListTypedListQuerySpecPocoTest()
    {
      var actual = CustomerQueries.GetCustomerListTypedListQuerySpecPoco(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }

    [TestMethod, Description("A test for GetCustomerListTypedList. Example 5.29. pg64.")]
    public void GetCustomerListTypedListTest()
    {
      var actual = CustomerQueries.GetCustomerListTypedList(OrderSearchCriteria, MaxNumberOfItemsToReturn);
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.ToList().Count());
      Assert.AreEqual(MaxNumberOfItemsToReturn, actual.Count());
    }
  }
}