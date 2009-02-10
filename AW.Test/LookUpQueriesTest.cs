using AW.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for LookUpQueriesTest and is intended
  ///to contain all LookUpQueriesTest Unit Tests
  ///</summary>
  [TestClass]
  public class LookUpQueriesTest
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
    ///A test for GetStateProvinceCollection
    ///</summary>
    [TestMethod]
    public void GetStateProvinceCollectionTest()
    {
      var actual = LookUpQueries.GetStateProvinceCollection();
      Assert.AreEqual(181, actual.Count);
    }

    /// <summary>
    ///A test for GetEmployees
    ///</summary>
    [TestMethod]
    public void GetEmployeesTest()
    {
      var actual = LookUpQueries.GetEmployees();
      Assert.AreEqual(290, actual.Count);
    }

    /// <summary>
    ///A test for GetCountryRegionCollection
    ///</summary>
    [TestMethod]
    public void GetCountryRegionCollectionTest()
    {
      var actual = LookUpQueries.GetCountryRegionCollection();
      Assert.AreEqual(238, actual.Count);
    }
  }
}