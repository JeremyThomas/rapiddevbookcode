using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for SalesOrderManagerTest and is intended
  ///to contain all SalesOrderManagerTest Unit Tests
  ///</summary>
  [TestClass]
  public class SalesOrderManagerTest
  {
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes      

    private static readonly DateTime FromDate; // TODO: Initialize to an appropriate value
    private static readonly DateTime ToDate; // TODO: Initialize to an appropriate value
    private static readonly string FirstName = string.Empty; // TODO: Initialize to an appropriate value
    private static readonly string LastName = string.Empty; // TODO: Initialize to an appropriate value
    private const int OrderID = 0;
    private static readonly string OrderNumber = string.Empty; // TODO: Initialize to an appropriate value
    private static readonly string CityName = string.Empty; // TODO: Initialize to an appropriate value
    private static readonly string StateName = string.Empty; // TODO: Initialize to an appropriate value
    private static readonly string CountryName = string.Empty; // TODO: Initialize to an appropriate value
    private static readonly string Zip = string.Empty; // TODO: Initialize to an appropriate value
    private const int maxNumberOfItemsToReturn = 5;
    private bool prefetch = true;

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
    ///A test for GetSalesOrderHeaderCollectionWithLinq
    ///</summary>
    [TestMethod]
    public void GetSalesOrderHeaderCollectionWithLinqTest()
    {
      var actual = SalesOrderManager.GetSalesOrderHeaderCollectionWithLinq(FromDate, ToDate, FirstName, LastName, OrderID, OrderNumber, CityName, StateName, CountryName, Zip, maxNumberOfItemsToReturn, prefetch);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count);
      //Assert.IsNotNull(actual[0].CustomerViewRelated);
    }

    /// <summary>
    ///A test for GetSalesOrderHeaderCollection
    ///</summary>
    [TestMethod]
    public void GetSalesOrderHeaderCollectionTest()
    {
      var actual = SalesOrderManager.GetSalesOrderHeaderCollection(FromDate, ToDate, FirstName, LastName, OrderID, OrderNumber, CityName, StateName, CountryName, Zip, maxNumberOfItemsToReturn, prefetch);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.Count);
      //Assert.IsNotNull(actual[0].CustomerViewRelated);
    }

    /// <summary>
    ///A test for DoSalesOrderHeaderLinqQuery
    ///</summary>
    [TestMethod]
    public void DoSalesOrderHeaderLinqQueryTest()
    {
      var countries = new List<string>(); 
      var actual = SalesOrderManager.DoSalesOrderHeaderLinqQuery(FromDate, ToDate, FirstName, LastName, OrderID, OrderNumber, CityName, StateName, countries, Zip, maxNumberOfItemsToReturn);
      Assert.AreEqual(maxNumberOfItemsToReturn, actual.ToList().Count());
    }
  }
}