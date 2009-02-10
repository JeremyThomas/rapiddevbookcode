using System.Linq;
using System.Windows.Forms;
using AW.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for CustomerQueriesTest and is intended
  ///to contain all CustomerQueriesTest Unit Tests
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

    /// <summary>
    ///A test for GetCustomerViewTypedView
    ///</summary>
    [TestMethod]
    public void GetCustomerViewTypedViewTest()
    {
      var maxNumberOfItemsToReturn = 5;
      var actual = CustomerQueries.GetCustomerViewTypedView(maxNumberOfItemsToReturn);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count);
    }

    /// <summary>
    ///A test for GetCustomerViewRelatedLinq
    ///</summary>
    [TestMethod]
    public void GetCustomerViewRelatedLinqTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedLinq();
      Assert.AreEqual(46117, actual.SalesOrderHeader[0].SalesOrderId);
    }

    /// <summary>
    ///A test for GetCustomerViewRelatedCollection
    ///</summary>
    [TestMethod]
    public void GetCustomerViewRelatedCollectionTest()
    {
      var actual = CustomerQueries.GetCustomerViewRelatedCollection();
      Assert.AreEqual(1, actual.Count);
      Assert.AreEqual(46117, actual[0].SalesOrderHeader[0].SalesOrderId);
    }

    /// <summary>
    ///A test for GetCustomerListAnonymousLinq
    ///</summary>
    [TestMethod]
    public void GetCustomerListAnonymousLinqTest()
    {
      var maxNumberOfItemsToReturn = 5;
      var actual = new BindingSource(CustomerQueries.GetCustomerListAnonymousLinq(maxNumberOfItemsToReturn), "");
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count);
    }

    /// <summary>
    ///A test for GetCustomerListLinqedTypedList
    ///</summary>
    [TestMethod]
    public void GetCustomerListLinqedTypedListTest()
    {
      var maxNumberOfItemsToReturn = 5;
      var actual = CustomerQueries.GetCustomerListLinqedTypedList(maxNumberOfItemsToReturn);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count());
    }

    /// <summary>
    ///A test for GetCustomerListTypedList
    ///</summary>
    [TestMethod]
    public void GetCustomerListTypedListTest()
    {
      var maxNumberOfItemsToReturn = 5;
      var actual = CustomerQueries.GetCustomerListTypedList(maxNumberOfItemsToReturn);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count());
    }
  }
}