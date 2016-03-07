using System;
using System.Linq;
using System.Text;
using AW.Data;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.Services;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using EntityType = Northwind.DAL.EntityType;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for PersistanceDiagnosticsTest and is intended
  ///   to contain all PersistanceDiagnosticsTest Unit Tests
  /// </summary>
  [TestClass]
  public class PersistanceDiagnosticsTest
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

    private static LinqMetaData GetNorthwindLinqMetaData()
    {
      return Factories.CreateLinqMetaData();
    }

    /// <summary>
    ///   A test for CheckAllEntitiesCanBeFetchedUsingLINQ
    /// </summary>
    [TestMethod]
    public void CheckAllNorthWindEntitiesCanBeFetchedUsingLINQTest()
    {
      var errors = PersistanceDiagnostics.CheckAllEntitiesCanBeFetchedUsingLINQ<EntityType>(GetNorthwindLinqMetaData(), 1);
      Assert.AreEqual(0, errors.Length, errors.ToString());
    }

    [TestMethod]
    public void CheckAllAWEntitiesCanBeFetchedUsingLINQTest()
    {
      var errors = PersistanceDiagnostics.CheckAllEntitiesCanBeFetchedUsingLINQ<Data.EntityType>(MetaSingletons.MetaData, 30);
      Assert.AreEqual(0, errors.Length, errors.ToString());
    }

    [TestMethod, Description("A test for CheckEntitiesCanBeFetched")]
    public void CheckNorthWindEntitiesCanBeFetchedTest()
    {
      var errors = PersistanceDiagnostics.CheckEntitiesCanBeFetched<EntityType>(EntityFactoryFactory.GetFactory, new DataAccessAdapter(), 1);
      Assert.AreEqual(0, errors.Length, errors.ToString());
    }

    [TestMethod]
    public void CheckAWEntitiesCanBeFetchedTest()
    {
      var errors = PersistanceDiagnostics.CheckEntitiesCanBeFetched<Data.EntityType>(Data.FactoryClasses.EntityFactoryFactory.GetFactory, 1);
      Assert.AreEqual(0, errors.Length, errors.ToString());
    }

    /// <summary>
    ///   A test for GetEntityFieldInformation
    /// </summary>
    [TestMethod]
    public void GetNorthWindEntityFieldInformationTest()
    {
      IDataAccessAdapter adapter = new DataAccessAdapter();
      var actual = PersistanceDiagnostics.GetEntityFieldInformation<EntityType>(adapter, EntityFactoryFactory.GetFactory);
      Assert.AreEqual(Enum.GetNames(typeof (EntityType)).Length, actual.Count());
    }

    [TestMethod]
    public void GeAWEntityFieldInformationTest()
    {
      var actual = EntityInformation.EntityInfoFactory<Data.EntityType>(Data.FactoryClasses.EntityFactoryFactory.GetFactory).OrderBy(fi => fi.Entity);
      Assert.AreEqual(Enum.GetNames(typeof (Data.EntityType)).Length, actual.Count());
      var individualEntityInformation = actual.Single(ei => ei.Entity == "Individual");
      Assert.AreEqual(2, individualEntityInformation.FieldInformation.Count());

      foreach (var entityInformation in actual.Where(ei => !ei.Entity.Contains("History") && !ei.Entity.Contains("CustomerViewRelated")))
      {
        Assert.IsFalse(string.IsNullOrWhiteSpace(entityInformation.CustomProperties), entityInformation.Entity);
        foreach (var fieldAndEntityInformation in entityInformation.FieldInformation)
        {
          Assert.IsFalse(string.IsNullOrWhiteSpace(fieldAndEntityInformation.CustomProperties), fieldAndEntityInformation.FieldName);
        }
      }
    }
    
  }
}