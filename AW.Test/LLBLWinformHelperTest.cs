using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  /// <summary>
  ///This is a test class for LLBLWinformHelperTest and is intended
  ///to contain all LLBLWinformHelperTest Unit Tests
  ///</summary>
  [TestClass]
  public class LLBLWinformHelperTest
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
    ///A test for ShowInGrid
    ///</summary>
    public void EditInDataGridViewTestHelper<T>(ushort pageSize)where T : EntityBase
    {
      var enumerable = EntityHelper.GetQueryableForEntity<T>(MetaSingletons.MetaData).AsEnumerable();
      var expected = enumerable;
      var actual = enumerable.ShowSelfServicingInGrid(pageSize);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void EditInDataGridViewTest()
    {
      EditInDataGridViewTestHelper<AddressEntity>(20);

      var addressTypes = from at in MetaSingletons.MetaData.AddressType
                         orderby at.AddressTypeID
                         select at;
      var addressTypeEntities = addressTypes.ToEntityCollection();
      addressTypeEntities.ShowSelfServicingInGrid(2);
      addressTypeEntities.DefaultView.ShowSelfServicingInGrid(3);

      addressTypes.AsEnumerable().ShowSelfServicingInGrid(3);

      addressTypeEntities.AsQueryable().ShowInGrid();
    }
  }
}