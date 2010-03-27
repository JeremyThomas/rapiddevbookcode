using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for GeneralHelperTest and is intended
  ///to contain all GeneralHelperTest Unit Tests
  ///</summary>
  [TestClass]
  public class GeneralHelperTest
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
    ///A test for GetEnumerableItemType
    ///</summary>
    [TestMethod]
    public void GetEnumerableItemTypeTest()
    {
      Assert.AreEqual(typeof(int), MetaDataHelper.GetEnumerableItemType(new List<int>()));
      Assert.AreEqual(typeof(int), MetaDataHelper.GetEnumerableItemType((new List<int> { 1, 2, 3, 4 }).Where(i => i > 2)));
      Assert.AreEqual(typeof(AddressTypeEntity), MetaDataHelper.GetEnumerableItemType(new AddressTypeCollection()));
      Assert.AreEqual(typeof(AddressTypeEntity), MetaDataHelper.GetEnumerableItemType(MetaSingletons.MetaData.AddressType));
      Assert.AreEqual(typeof(int), MetaDataHelper.GetEnumerableItemType(new ArrayList { 1, 2, 3 }));
      Assert.AreEqual(typeof(object), MetaDataHelper.GetEnumerableItemType(new ArrayList()));
      //Assert.IsNull(BindingListHelper.GetEnumerableItemType(new ArrayList()));
    }

    public void CopyToDataTableAndAssert<T>(IEnumerable<T> source)
    {
      var actual = source.CopyToDataTable();
      Assert.AreEqual(source.Count(), actual.Rows.Count);
      var type = typeof (T);
      Assert.AreEqual(type.GetFields().Count() + type.GetProperties().Count(), actual.Columns.Count);
    }

    public void CopyToDataTableAndAssert(ICollection source, Type type)
    {
      var actual = source.CopyToDataTable();
      Assert.AreEqual(source.Count, actual.Rows.Count);
      Assert.AreEqual(type.GetFields().Count() + type.GetProperties().Count(), actual.Columns.Count);
    }

    [TestMethod, Description("A test for CopyToDataTable")]
    public void CopyToDataTableTest()
    {
			var listofNonSerializableClasses = NonSerializableClass.GenerateList();
      CopyToDataTableAndAssert(listofNonSerializableClasses);
      CopyToDataTableAndAssert(MetaSingletons.MetaData.AddressType);
      listofNonSerializableClasses.Add(new SerializableClass { DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString() });
      CopyToDataTableAndAssert(listofNonSerializableClasses, typeof(SerializableClass));
    	var d = new DataGridView {AutoGenerateColumns = true, DataSource = listofNonSerializableClasses};
    	listofNonSerializableClasses.Insert(0, new SerializableClass { DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString() });
      CopyToDataTableAndAssert(listofNonSerializableClasses, typeof(SerializableClass));
    }


  }


}