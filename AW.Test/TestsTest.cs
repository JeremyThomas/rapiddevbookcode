using System.Linq.Dynamic;
using AW.Data.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for TestsTest and is intended
  ///to contain all TestsTest Unit Tests
  ///</summary>
  [TestClass]
  public class TestsTest
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
    ///A test for LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder
    ///</summary>
    [TestMethod]
    public void LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrderTest()
    {
      const int maxNumberOfItemsToReturn = 5;
      Assert.AreEqual(maxNumberOfItemsToReturn, Tests.LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder(maxNumberOfItemsToReturn).Count());
    }

    /// <summary>
    ///A test for BarfonMultipleTableJoins
    ///</summary>
    [TestMethod]
    public void BarfonMultipleTableJoinsTest()
    {
      Tests.BarfonMultipleTableJoins();
    }

    /// <summary>
    ///A test for Barf1
    ///</summary>
    [TestMethod, ExpectedException(typeof(ORMQueryConstructionException))]
    public void Barf1Test()
    {
      Tests.Barf1();
    }

    /// <summary>
    ///A test for Barf
    ///</summary>
    [TestMethod]
    public void BarfTest()
    {
      Tests.Barf();
    }
  }
}