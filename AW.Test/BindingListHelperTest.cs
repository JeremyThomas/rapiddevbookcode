using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for BindingListHelperTest and is intended
  ///to contain all BindingListHelperTest Unit Tests
  ///</summary>
  [TestClass]
  public class BindingListHelperTest
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
    ///A test for Bind
    ///</summary>
    [TestMethod]
    public void BindTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestBindEnumerable(addressTypeEntityCollection.DefaultView, false);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

      TestBindEnumerable(MetaSingletons.MetaData.AddressType, false);

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection, false));
    }

    private static IList TestBindEnumerable<T>(IEnumerable<T> enumerable, bool setReadonly)
    {
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
      Assert.IsInstanceOfType(bindingSource.List, typeof (IBindingListView));
      return bindingSource.List;
    }

    /// <summary>
    ///A test for BindEnumerable
    ///</summary>
    [TestMethod]
    public void BindEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection.DefaultView));
      TestBindEnumerable(MetaSingletons.MetaData.AddressType);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection));

      var dt = new DataSet();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      TestBindEnumerable(dt.Tables[0].DefaultView);
    }

    private static IList TestBindEnumerable(IEnumerable enumerable)
    {
      TestBindEnumerable(enumerable, true);
      var bindingSource = TestBindEnumerable(enumerable, false);
      return bindingSource.List;
    }

    private static BindingSource TestBindEnumerable(IEnumerable enumerable, bool setReadonly)
    {
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
      Assert.IsInstanceOfType(bindingSource.List, typeof (IBindingListView));
      // Assert.AreNotEqual(bindingSource.AllowEdit, setReadonly);
      return bindingSource;
    }

    [TestMethod]
    public void ToBindingListViewTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestToBindingListView(addressTypeEntityCollection.DefaultView);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestToBindingListView(addressTypeEntityCollection));
      CollectionAssert.AreEqual(addressTypeEntityCollection, TestToBindingListView(addressTypeEntityCollection.AsQueryable()));
      CollectionAssert.AreEqual(addressTypeEntityCollection, TestToBindingListView(addressTypeEntityCollection.Cast<CommonEntityBase>()));

      TestToBindingListView(MetaSingletons.MetaData.AddressType);

      var dt = new DataSet();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      var dataTable = dt.Tables[0];
      Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));

      var enumerable = Enumerable.Range(1, 100);
      var actual = TestToBindingListView(enumerable);
      CollectionAssert.AreEqual(enumerable.ToList(), actual);

      Assert.IsNull("A string".ToBindingListView());

      Assert.IsNull((new[] {"s1", "s2", "s3"}).ToBindingListView());
    }

    private static IBindingListView TestToBindingListView(IEnumerable enumerable)
    {
      var bindingListView = enumerable.ToBindingListView();
      Assert.IsInstanceOfType(bindingListView, typeof (IBindingListView));
      Assert.IsTrue(bindingListView.Count > 0);
      return bindingListView;
    }

    [TestMethod]
    public void ListSourceToBindingListViewTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();

      var dt = new DataSet();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      var dataTable = dt.Tables[0];
      Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));
    }

    private static IBindingListView TestListSourceToBindingListView(IListSource enumerable)
    {
      var bindingListView = BindingListHelper.ListSourceToBindingListView(enumerable);
      Assert.IsInstanceOfType(bindingListView, typeof (IBindingListView));
      Assert.IsTrue(bindingListView.Count > 0);
      return bindingListView;
    }

  }
}