using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Helper.LLBL;
using AW.Data.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Linq;
using System.Collections.Generic;

namespace AW.Test
{
    
    
    /// <summary>
    ///This is a test class for EntityHelperTest and is intended
    ///to contain all EntityHelperTest Unit Tests
    ///</summary>
  [TestClass()]
  public class EntityHelperTest
  {


    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

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


    public static void ToEntityCollectionTestHelper<T>() where T : CommonEntityBase
    {
      var query = MetaSingletons.MetaData.GetQueryableForEntity<T>();
      var expected = FetchEntityCollection<T>();

      var actual = query.ToEntityCollection(); //DataSourceBase
      CollectionAssert.AreEqual(expected, actual);

      actual = query.Distinct().ToEntityCollection(); //LLBLGenProQuery
      CollectionAssert.AreEqual(expected, actual);

      CollectionAssert.AreEqual(expected, actual.Distinct().ToEntityCollection()); //IEnumerable<T> 

      var actualQueryable = actual.AsQueryable().ToEntityCollection();
      CollectionAssert.AreEqual(expected, actualQueryable); //IQueryable not ILLBLGenProQuery

      var emptyCollection = FactoryHelper.CreateEntityCollection<T>();
      CollectionAssert.AreEqual(emptyCollection, emptyCollection.Distinct().ToEntityCollection()); //IEnumerable<T> 
    }

    private static EntityCollectionBase<T> FetchEntityCollection<T>() where T : EntityBase
    {
      var expected = FactoryHelper.CreateEntityCollection<T>();
      expected.GetMulti(null);
      return expected;
    }

    [TestMethod, Description("A test for ToEntityCollection")]
    public void ToEntityCollectionTest()
    {
      ToEntityCollectionTestHelper<AddressTypeEntity>();
    }

  }
}
