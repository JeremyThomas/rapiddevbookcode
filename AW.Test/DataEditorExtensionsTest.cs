using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using AW.Data;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for DataEditorExtensionsTest and is intended
  ///to contain all DataEditorExtensionsTest Unit Tests
  ///</summary>
  [TestClass]
  public class DataEditorExtensionsTest
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
    ///A test for BindEnumerable
    ///</summary>
    [TestMethod]
    public void BindEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestBindEnumerable(addressTypeEntityCollection.DefaultView, false);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

      TestBindEnumerable(MetaSingletons.MetaData.AddressType, false);

      Assert.AreEqual(addressTypeEntityCollection.DefaultView,TestBindEnumerable(addressTypeEntityCollection, false));
      
      var dt = new DataSet();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      TestBindEnumerable(dt.Tables[0].DefaultView, false);
    }

    private static IList TestBindEnumerable(IEnumerable enumerable, bool setReadonly)
    {
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
      Assert.IsInstanceOfType(bindingSource.List, typeof (IBindingListView));
      return bindingSource.List;
    }

    [TestMethod]
    public void ToBindingListViewTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestToBindingListView(addressTypeEntityCollection.DefaultView);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestToBindingListView(addressTypeEntityCollection));

      TestToBindingListView(MetaSingletons.MetaData.AddressType);

      var dt = new DataSet();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      var dataTable = dt.Tables[0];
      Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));
    }

    private static IBindingListView TestToBindingListView(IEnumerable enumerable)
    {
      var bindingListView = enumerable.ToBindingListView();
      Assert.IsInstanceOfType(bindingListView, typeof(IBindingListView));
      Assert.IsTrue(bindingListView.Count>0);
      return bindingListView;
    }

    private static IBindingListView TestListSourceToBindingListView(IListSource enumerable)
    {
      var bindingListView = DataEditorExtensions.ListSourceToBindingListView(enumerable);
      Assert.IsInstanceOfType(bindingListView, typeof(IBindingListView));
      Assert.IsTrue(bindingListView.Count > 0);
      return bindingListView;
    }
  }
}