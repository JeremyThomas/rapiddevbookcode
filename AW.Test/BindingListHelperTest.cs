using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.LLBL;
using JesseJohnston;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for BindingListHelperTest and is intended
  ///   to contain all BindingListHelperTest Unit Tests
  /// </summary>
  [TestClass]
  public class BindingListHelperTest
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

    [AssemblyInitialize]
    public static void TestsInitialize(TestContext testContext)
    {
      CommonEntityBase.Initialize();
      Northwind.DAL.EntityClasses.CommonEntityBase.Initialize();
      LLBLWinformHelper.ForceInitialization();
    }

    [TestMethod]
    public void DifferentItemTypesTest()
    {
      var listofNonSerializableClasses = SerializableClass.GenerateListWithBothSerializableClasses();
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable((IEnumerable) listofNonSerializableClasses, false));
      if (bindingSource.SupportsSorting)
      {
        Assert.IsInstanceOfType(bindingSource.List, typeof(ObjectListView<SerializableBaseClass>));
        var objectListView = (ObjectListView<SerializableBaseClass>) bindingSource.List;
        Assert.AreEqual(listofNonSerializableClasses, objectListView.List);
      }
      else
        Assert.AreEqual(listofNonSerializableClasses, bindingSource.List);

      TestBindEnumerable(listofNonSerializableClasses, true, 1, false);
      TestBindEnumerable(SerializableClass.GenerateListWithBoth(), true, 3, false);
    }

    /// <summary>
    ///   A test for BindEnumerable
    /// </summary>
    [TestMethod]
    public void BindEnumerableTest()
    {
      TestBindEnumerable(MetaSingletons.MetaData.AddressType);

      TestBindEnumerable(TestData.GetAddressTypeDataTable().DefaultView);

      TestBindEnumerable(((IEntity) MetaSingletons.MetaData.AddressType.First()).CustomPropertiesOfType, true, 2);
      TestBindEnumerable(MetaDataHelper.GetPropertiesToDisplay(typeof(AddressTypeEntity)), true, 14);
      TestBindEnumerable(NonSerializableClass.GenerateList(), true, 3);
      TestBindEnumerable(SerializableClass.GenerateList(), true, 4);
      TestBindEnumerable(SerializableClass.GenerateListWithBoth(), true, 3, false);
      TestBindEnumerable(SerializableBaseClass.GenerateList(), true, 1);
      TestBindEnumerable(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), true, 1, false);
    }

    [TestMethod]
    public void BindLLBLEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection));
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection.DefaultView));

      Assert.IsInstanceOfType(TestBindEnumerable(MetaSingletons.MetaData.AddressType), addressTypeEntityCollection.DefaultView.GetType());
    }

    [TestMethod]
    public void BindEmptyQueryTest()
    {
      TestBindEnumerable((IEnumerable) MetaSingletons.MetaData.AddressType.Where(at => at.Name == null), false, 4);
    }

    [TestMethod]
    public void BindNullTest()
    {
      var bindingSource = new BindingSource();
      Assert.IsFalse(bindingSource.BindEnumerable(null, false));
    }

    [TestMethod]
    public void BindInheritanceEnumerableTest()
    {
      var customerEntityCollection = MetaSingletons.MetaData.Customer.Take(5).ToEntityCollection();
      TestToBindingListView(customerEntityCollection);

      TestToBindingListView(MetaSingletons.MetaData.Customer.Where(c => c is StoreEntity || c is IndividualEntity).Take(10));
    }

    private static IEnumerable<T> TestBindEnumerable<T>(IEnumerable<T> enumerable, bool isObjectListView = false, int numProperties = 0, bool testNonGeneric = true)
    {
      TestBindEnumerableReadonly(enumerable, true);
      var bindingSource = TestBindEnumerableReadonly(enumerable, false);
      var list = bindingSource.List;
      if (isObjectListView)
      {
        MaybeAssertObjectListView(list);
      }
      if (numProperties > 0)
      {
        var properties = MetaDataHelper.GetPropertiesToDisplay(enumerable);
        Assert.AreEqual(numProperties, properties.Count());
      }
      if (testNonGeneric)
        TestBindEnumerable((IEnumerable) enumerable, isObjectListView, numProperties);
      if (list.GetType().IsGenericType)
        return (IEnumerable<T>) list;
      return null;
    }

    private static void MaybeAssertObjectListView(dynamic list, bool assertRaiseItemChangedEvents = false)
    {
      if (list.GetType().IsGenericType)
        AssertObjectListView(list, assertRaiseItemChangedEvents);
      else
        AssertObjectListViewNg(list, assertRaiseItemChangedEvents);
    }

    private static void AssertObjectListView<T>(IList<T> list, bool assertRaiseItemChangedEvents = false)
    {
      Assert.IsInstanceOfType(list, typeof(ObjectListView<T>));
      if (assertRaiseItemChangedEvents)
      {
        var objectListView = (ObjectListView<T>) list;
        var raiseItemChangedEvents = objectListView.List as IRaiseItemChangedEvents;
        Assert.IsNotNull(raiseItemChangedEvents, "objectListView.List as IRaiseItemChangedEvents");
        Assert.IsTrue(raiseItemChangedEvents.RaisesItemChangedEvents, "raiseItemChangedEvents.RaisesItemChangedEvents");
      }
    }

    private static void AssertObjectListViewNg(IList list, bool assertRaiseItemChangedEvents = false)
    {
      Assert.IsInstanceOfType(list, typeof(ObjectListView));
      if (assertRaiseItemChangedEvents)
      {
        var objectListView = (ObjectListView)list;
        var raiseItemChangedEvents = objectListView.List as IRaiseItemChangedEvents;
        Assert.IsNotNull(raiseItemChangedEvents, "objectListView.List as IRaiseItemChangedEvents");
        Assert.IsTrue(raiseItemChangedEvents.RaisesItemChangedEvents, "raiseItemChangedEvents.RaisesItemChangedEvents");
      }
    }

    private static BindingSource TestBindEnumerableReadonly<T>(IEnumerable<T> enumerable, bool setReadonly)
    {
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
      Assert.IsInstanceOfType(bindingSource.List, typeof(IBindingListView));
      return bindingSource;
    }

    private static IList TestBindEnumerable(IEnumerable enumerable, bool isObjectListView = false, int numProperties = 0)
    {
      TestBindEnumerableReadonly(enumerable, true);
      var bindingSource = TestBindEnumerableReadonly(enumerable, false);
      var list = bindingSource.List;
      if (isObjectListView)
        // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
          MaybeAssertObjectListView(list);
      if (numProperties > 0)
      {
        var properties = MetaDataHelper.GetPropertiesToDisplay(enumerable);
        Assert.AreEqual(numProperties, properties.Count());
      }
      return list;
    }

    private static BindingSource TestBindEnumerableReadonly(IEnumerable enumerable, bool setReadonly)
    {
      var bindingSource = new BindingSource();
      Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
      Assert.IsInstanceOfType(bindingSource.List, typeof(IBindingListView));
      // Assert.AreNotEqual(bindingSource.AllowEdit, setReadonly);
      return bindingSource;
    }

    [TestMethod]
    public void ToBindingListViewTest()
    {
      TestToBindingListView(MetaDataHelper.GetPropertiesToDisplay(typeof(AddressTypeEntity)));
      TestToBindingListView(((IEntity) MetaSingletons.MetaData.AddressType.First()).CustomPropertiesOfType);
      TestToBindingListView(MetaSingletons.MetaData.AddressType);

      var dataTable = TestData.GetAddressTypeDataTable();
      Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));

      var enumerable = Enumerable.Range(1, 100);
      var actual = TestToBindingListView(enumerable);
      CollectionAssert.AreEqual(enumerable.ToList(), actual);

      TestToBindingListView(SerializableClass.GenerateList().ToBindingListView());
    }

    [TestMethod]
    public void StringToBindingListViewTest()
    {
      Assert.IsNull("A string".ToBindingListView());

      CollectionAssert.AreEqual(TestData.ThreeStrings, TestData.ThreeStrings.ToBindingListView());
      CollectionAssert.AreEqual(TestData.ThreeStrings, ((IEnumerable) TestData.ThreeStrings).ToBindingListView());
      CollectionAssert.AreEqual(TestData.ThreeStringsEnumerable.ToList(), TestData.ThreeStringsEnumerable.ToBindingListView());
    }

    [TestMethod]
    public void LLBLToBindingListViewTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestToBindingListView(addressTypeEntityCollection.DefaultView);
      Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

      Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestToBindingListView(addressTypeEntityCollection));
      var addressTypeEntityCollectionQueryableAsBindingListView = TestToBindingListView(addressTypeEntityCollection.AsQueryable());
      CollectionAssert.AreEqual(addressTypeEntityCollection, addressTypeEntityCollectionQueryableAsBindingListView);
      Assert.IsInstanceOfType(addressTypeEntityCollectionQueryableAsBindingListView, addressTypeEntityCollection.DefaultView.GetType());
    }

    [TestMethod]
    public void LLBLQueryToBindingListViewTest()
    {
      TestLLBLQueryToBindingListView(MetaSingletons.MetaData.AddressType);
      TestLLBLQueryToBindingListView(MetaSingletons.MetaData.AddressType, true);
    }

    private static void TestLLBLQueryToBindingListView(IEnumerable enumerable, bool ensureFilteringEnabled = false)
    {
      var list = TestToBindingListView(enumerable, ensureFilteringEnabled);
      Assert.IsInstanceOfType(list, typeof(ICollection));
      if (ensureFilteringEnabled)
      {
        MaybeAssertObjectListView(list);
        Assert.IsTrue(list.SupportsFiltering);
        var raiseItemChangedEvents = list as IRaiseItemChangedEvents;
        Assert.IsNotNull(raiseItemChangedEvents);
        Assert.IsTrue(raiseItemChangedEvents.RaisesItemChangedEvents, "raiseItemChangedEvents.RaisesItemChangedEvents");
      }
      else
        Assert.IsInstanceOfType(list, typeof(IEntityView));
      var dataSource = (ICollection) BindingListHelper.GetDataSource(list);
      Assert.IsInstanceOfType(dataSource, typeof(IEntityCollection));
    }

    [TestMethod]
    public void LLBLFieldsToBindingListViewTest()
    {
      var addressTypeFields = new AddressTypeEntity().Fields;
      TestToBindingListViewPropertiesCounts(addressTypeFields, TestData.NumFieldProperties);
      TestToBindingListViewPropertiesCounts(addressTypeFields.ToList(), TestData.NumFieldProperties);
      TestToBindingListViewPropertiesCounts(addressTypeFields.Cast<IEntityField>(), TestData.NumFieldProperties);
      TestToBindingListViewPropertiesCounts(addressTypeFields.Cast<IEntityField>().ToList(), TestData.NumFieldProperties);

      var customerFields = new Northwind.DAL.EntityClasses.CustomerEntity().Fields;
      TestToBindingListViewPropertiesCounts(customerFields, TestData.NumField2Properties);
      TestToBindingListViewPropertiesCounts(customerFields.ToList(), TestData.NumField2Properties);
      TestToBindingListViewPropertiesCounts(customerFields.Cast<IEntityField2>(), TestData.NumField2Properties);
      TestToBindingListViewPropertiesCounts(customerFields.Cast<IEntityField2>().ToList(), TestData.NumField2Properties);
    }

    static void TestToBindingListViewPropertiesCounts(IEnumerable fields, int numProperties)
    {
      var bindingListView = TestToBindingListView(fields);
      Assert.AreEqual(numProperties, ListBindingHelper.GetListItemProperties(bindingListView).Count);
    }

    [TestMethod]
    public void GetDataSourceTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var list = TestToBindingListView(addressTypeEntityCollection, true);
      Assert.IsInstanceOfType(list, typeof(ICollection));
      Assert.IsInstanceOfType(list, typeof(ObjectListView<AddressTypeEntity>));
      var dataSource = (ICollection) BindingListHelper.GetDataSource(list);
      CollectionAssert.AreEqual(addressTypeEntityCollection, dataSource);
      var objectListView = (ObjectListView<AddressTypeEntity>) list;
      Assert.AreEqual(addressTypeEntityCollection, objectListView.List);
      Assert.AreEqual(addressTypeEntityCollection, dataSource);
      var arrayListAddressType = new ArrayList();
      arrayListAddressType.AddRange(addressTypeEntityCollection);
      var listNg = TestToBindingListView(arrayListAddressType, true);
      Assert.IsInstanceOfType(listNg, typeof(ICollection));
      Assert.IsInstanceOfType(listNg, typeof(ObjectListView));
      dataSource = (ICollection) BindingListHelper.GetDataSource(list);
      CollectionAssert.AreEqual(arrayListAddressType, dataSource);
    }

    private static IBindingListView TestToBindingListView(IEnumerable enumerable, bool ensureFilteringEnabled = false)
    {
      var bindingListView = enumerable.ToBindingListView(ensureFilteringEnabled);
      Assert.IsInstanceOfType(bindingListView, typeof(IBindingListView));
      Assert.IsTrue(bindingListView.Count > 0);
      return bindingListView;
    }

    [TestMethod]
    public void ObjectToBindingListViewTest()
    {
      var serializableClasses = SerializableClass.GenerateList();
      var bindingListView = serializableClasses.Cast<object>().ToBindingListView();
      var enumerableItemType = MetaDataHelper.GetEnumerableItemType(bindingListView);
      Assert.AreEqual(typeof(SerializableClass), enumerableItemType);
      Assert.AreEqual(4, ListBindingHelper.GetListItemProperties(bindingListView).Count);
      Assert.AreEqual(ListBindingHelper.GetListItemProperties(serializableClasses), ListBindingHelper.GetListItemProperties(bindingListView));
    }

    [TestMethod]
    public void ListSourceToBindingListViewTest()
    {
      var dataTable = TestData.GetAddressTypeDataTable();
      Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));
    }

    private static IBindingListView TestListSourceToBindingListView(IListSource enumerable)
    {
      var bindingListView = BindingListHelper.ListSourceToBindingListView(enumerable);
      Assert.IsInstanceOfType(bindingListView, typeof(IBindingListView));
      Assert.IsTrue(bindingListView.Count > 0);
      return bindingListView;
    }
  }
}