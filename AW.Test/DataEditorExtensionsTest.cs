using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Linq;
using System.DirectoryServices;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Helper.PropertyDescriptors;
using AW.Helper.TypeConverters;
using AW.LinqToSQL;
using AW.Test.Helpers;
using AW.Tests.Properties;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using JesseJohnston;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for DataEditorExtensionsTest and is intended
  ///   to contain all DataEditorExtensionsTest Unit Tests
  /// </summary>
  [TestClass]
  public class DataEditorExtensionsTest : GridDataEditorTestBase
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
    [TestInitialize]
    public void MyTestInitialize()
    {
      Init();
    }

    //Use TestCleanup to run code after each test has run
    [TestCleanup]
    public void MyTestCleanup()
    {
      Verify();
    }

    #endregion

    /// <summary>
    ///   A test for ShowInGrid
    /// </summary>
    [TestCategory("Winforms"), TestMethod]
    public void EditPropertiesInDataGridViewTest()
    {
      TestShowInGrid(((IEntity) MetaSingletons.MetaData.AddressType.First()).CustomPropertiesOfType, 2);
      TestShowInGrid(MetaDataHelper.GetPropertiesToDisplay(typeof(AddressTypeEntity)), 14);
    }

    /// <summary>
    ///   A test for ShowInGrid
    /// </summary>
    [TestCategory("Winforms"), TestCategory("Slow"), TestMethod]
    public void EditInDataGridViewTest()
    {
      TestShowInGrid(NonSerializableClass.GenerateList(), NonSerializableClass.NumberOfNonSerializableClassProperties, NonSerializableClass.NumberOfNonSerializableClassProperties);
      TestShowInGrid(NonSerializableClass.GenerateList(), NonSerializableClass.NumberOfNonSerializableClassProperties, NonSerializableClass.NumberOfNonSerializableClassProperties);
      TestShowInGrid(SerializableClass.GenerateList(), 4, 4);
      TestShowInGrid(SerializableClass.GenerateListWithBoth(), 3, 3);
      TestShowInGrid(SerializableBaseClass.GenerateList(), 1, 1);
      TestShowInGrid(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 1, 1);
    }

    [TestMethod]
    public void ShowDictionaryInGrid()
    {
      var dictionary = NonSerializableClass.GenerateList().ToDictionary(ns => ns.IntProperty, ns => ns);
      TestShowInGrid(dictionary, 2);
      TestShowInGrid(dictionary.Values, NonSerializableClass.NumberOfNonSerializableClassProperties, NonSerializableClass.NumberOfNonSerializableClassProperties);
      TestShowInGrid(dictionary.Keys, 1);
    }

    private static FieldsToPropertiesTypeDescriptionProvider _fieldsToPropertiesTypeDescriptionProvider;
    private static readonly Attribute[] BrowsableAttributeList = {new BrowsableAttribute(true)};

    private static void AddFieldsToPropertiesTypeDescriptionProvider(Type typeToEdit)
    {
      if (_fieldsToPropertiesTypeDescriptionProvider == null && typeToEdit != null)
      {
        _fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeToEdit, FieldBindingFlags);
        TypeDescriptor.AddProvider(_fieldsToPropertiesTypeDescriptionProvider, typeToEdit);
      }
    }

    private static void TidyUp(Type itemType)
    {
      if (_fieldsToPropertiesTypeDescriptionProvider != null && itemType != null)
      {
        TypeDescriptor.RemoveProvider(_fieldsToPropertiesTypeDescriptionProvider, itemType);
        _fieldsToPropertiesTypeDescriptionProvider = null;
      }
    }

    [TestMethod]
    public void FieldsToPropertiesTypeDescriptionProviderTest()
    {
      var properties = MetaDataHelper.GetPropertiesToDisplay(typeof(NonSerializableClass));
      Assert.AreEqual(NonSerializableClass.NumberOfNonSerializableClassProperties, properties.Count());
      AddFieldsToPropertiesTypeDescriptionProvider(typeof(NonSerializableClass));
      try
      {
        properties = MetaDataHelper.GetPropertiesToDisplay(typeof(NonSerializableClass));
        Assert.AreEqual(NonSerializableClass.NumberOfNonSerializableClassProperties*2, properties.Count());
      }
      finally
      {
        TidyUp(typeof(NonSerializableClass));
      }
    }

    [TestCategory("Winforms"), TestMethod]
    public void ShowArrayListInGrid()
    {
      var arrayList = new ArrayList {1, 2, "3"};
      TestEditInDataGridView(arrayList, 1);
    }
    
    [TestCategory("Winforms"), TestMethod]
    public void ShowListOfArraysInGrid()
    {
      var listOfArrays = new List<string[]> {new[] {"1", "2", "3"}, new[] {"a", "b", "c"}};
      TestShowInGrid(listOfArrays, 3);
    }

    [TestCategory("Winforms"), TestCategory("Interactive"), TestMethod]
    public void ShowListOfListOfStringsInGrid()
    {
     // ModalFormHandler = NullHandler;
      var listOfArrays = new List<List<string> > { new List<string> { "1", "2", "3" }, new List<string> { "a", "b", "c" } };
      TestShowInGrid(listOfArrays, 3);
    //  FrmDataEditor.ShowInGrid(listOfArrays);
    }

    [TestMethod]
    public void SettingsPropertyTest()
    {
      TestEditInDataGridView(Settings.Default.Properties, 9);
      if (Settings.Default.PropertyValues.Count == 0)
      {
        var x = Settings.Default.StringSetting;
      }
      Assert.AreNotEqual(0, Settings.Default.PropertyValues.Count);
      TestShowInGrid(Settings.Default.PropertyValues.Cast<SettingsPropertyValue>());
      TestEditInDataGridView(Settings.Default.PropertyValues, 7);
    }

    [TestMethod]
    public void GridDataEditorBindEnumerableTest()
    {
      var gridDataEditor = new GridDataEditor();
      gridDataEditor.BindEnumerable(null, 1);

      var arrayList = new ArrayList {1, 2, "3"};
      gridDataEditor.BindEnumerable(arrayList);

      gridDataEditor.BindEnumerable(arrayList, 1);
    }

    [TestCategory("Winforms"), TestMethod]
    public void ShowStringEnumerationInGridTest()
    {
      var enumerable = new[] {"s1", "s2", "s3"};
      //      GridDataEditorTestBase.ShowInGrid(enumerable);
      TestShowInGrid(enumerable, 1);
      enumerable = null;
      // ReSharper disable once ExpressionIsAlwaysNull
      TestShowInGrid(enumerable, 1);
      TestEditInDataGridView(new string[0], 1);
      //TestShowInGrid(new string[0], 0);
    }

    [TestMethod]
    public void ShowIntegerEnumerationInGridTest()
    {
      var enumerable = Enumerable.Range(1, 100);
      TestShowInGrid(ValueTypeWrapper<int>.CreateWrapperForBinding(enumerable), 1);
      TestShowInGrid(enumerable, 1);
      enumerable = null;
      TestShowInGrid(enumerable, 1);
      TestEditInDataGridView(new int[0], 1);
    }

    [TestMethod]
    public void NullInDataGridViewTest()
    {
      TestEditInDataGridView(null);
    }

    [TestCategory("Winforms"), TestMethod]
    public void EditEmptyInDataGridViewTest()
    {
      TestShowInGrid(new SerializableClass[0], 4, 4);
    }

    [TestCategory("Winforms"), TestMethod]
    public void QueryInGridIsReadonlyTest()
    {
      TestShowInGrid(MetaSingletons.MetaData.Address);
      TestShowInGrid(MetaSingletons.MetaData.AddressType);
    }

    [TestCategory("Winforms"), TestMethod]
    public void ShowEntityCollectionInGridTest()
    {
      TestShowInGrid(MetaSingletons.MetaData.Address.ToEntityCollection());
      var addressTypeEntities = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      TestShowInGrid(addressTypeEntities);
    }

    public static IEnumerable ShowInGrid<T>(IEnumerable<T> enumerable)
    {
      var contextField = enumerable.GetType().GetField("context", BindingFlags.Instance | BindingFlags.NonPublic);
      if (contextField != null)
      {
        var queryContext = contextField.GetValue(enumerable) as DataContext;
        if (queryContext != null)
          return ShowInGrid(enumerable, queryContext);
      }
      return FrmDataEditor.ShowInGrid(enumerable, null);
    }

    public static IEnumerable ShowInGrid<T>(Table<T> table, ushort pageSize = GridDataEditor.DefaultPageSize) where T : class
    {
      return ShowInGrid(table, table.Context, pageSize);
    }

    /// <summary>
    ///   Edits the DataQuery in a DataGridView.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="dataQuery"> The data query (System.Data.Linq.DataQuery`1). </param>
    /// <param name="dataContext"> The data context. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable ShowInGrid<T>(IEnumerable<T> dataQuery, DataContext dataContext, ushort pageSize = GridDataEditor.DefaultPageSize)
    {
      return FrmDataEditor.ShowInGrid(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
    }

    [TestCategory("Winforms"), TestMethod]
    public void EditLinqtoSQLInDataGridViewTest()
    {
      var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
      //		awDataClassesDataContext. = DbUtils.ActualConnectionString;
      //awDataClassesDataContext.Connection.ConnectionString
      TestShowInGrid(awDataClassesDataContext.AddressTypes, 4);
      var addressTypesQuery = awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID);
      ModalFormHandler = Handler;
      ShowInGrid(addressTypesQuery, awDataClassesDataContext);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      ModalFormHandler = Handler;
      ShowInGrid(addressTypesQuery);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      ModalFormHandler = Handler;
      var actual = ShowInGrid(awDataClassesDataContext.AddressTypes);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
      Assert.AreEqual(awDataClassesDataContext.AddressTypes, actual);
    }

    [TestCategory("Winforms"), TestCategory("Slow"), TestMethod]
    public void Xml_test()
    {
      var xml = TestData.TestXmlString;

      var xElement = XElement.Parse(xml);
      var xElements = xElement.Elements().ToList();
      TestShowInGrid(xElements, GeneralHelperTest.NumXElementProperties, ObjectListView.IncludeNonBrowseable ? GeneralHelperTest.NumXElementOtherToShow : 0);
      //var propertyDescriptorCollection = ListBindingHelper.GetListItemProperties(xElements);
      //var bindingListView = xElements.ToBindingListView();
      // var dataGridView = new DataGridView {DataSource = bindingListView};
      //var controlBindingsCollection = dataGridView.DataBindings;
      //FrmDataEditor.ShowInGrid(xElements.CopyToDataTable().DefaultView);

      var xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(xml);
      TestEditInDataGridView(xmlDoc.FirstChild.ChildNodes, 24, 1);
    }

    [TestCategory("Winforms"), TestCategory("LDAP"), TestCategory("Slow"), TestMethod]
    public void ResultPropertyCollectionTest()
    {
      using (var entry = TestData.CreateLdapDirectoryEntry())
      using (var searcher = new DirectorySearcher(entry))
      {
        searcher.Filter = "(uid=" + TestData.LdapUserName + ")";
        var searchResult = searcher.FindOne();
        SingleValueCollectionConverter.AddConverter(typeof(ICollection));
        var dictionaryEntries = searchResult.Properties.OfType<DictionaryEntry>();
        var dictionaryEntry = dictionaryEntries.First();
        var typeConverter = TypeDescriptor.GetConverter(dictionaryEntry.Value.GetType());
        var convertToString = typeConverter.ConvertToString(dictionaryEntry.Value);
        //dictionaryEntry.Value
        //TestShowInGrid(dictionaryEntries);
        // searchResult.Properties.ShowInGrid();
      }
    }

    [TestProperty("Winforms", "Interactive"), TestMethod]
    public void NonComparableTest()
    {
      ModalFormHandler = NullHandler;
      var nonSerializableClassWithSerializableClassProperties = NonSerializableClassWithSerializableClassProperty.GenerateList();
      //  FrmDataEditor.ShowInGrid(nonSerializableClassWithSerializableClassProperties);
      var propertyDescriptors = MetaDataHelper.GetPropertiesToDisplay(typeof(AddressTypeEntity));
      var copyToDataTable = propertyDescriptors.CopyToDataTable();
      //var propertyDescriptorCollection = TypeDescriptor.GetProperties(copyToDataTable.DefaultView);
      //CollectionAssert.AreEquivalent(propertyDescriptors.ToList(), propertyDescriptorCollection);
      FrmDataEditor.ShowInGrid(copyToDataTable.DefaultView);
    }


    [TestProperty("Winforms", "Interactive"), TestMethod]
    public void PropertiesToDisplayTest()
    {
      // ObjectListView.IncludeNonBrowseable = true;
      // ObjectListView<CategoryEntity>.IncludeNonBrowseable = true;
      TestPropertiesToDisplay<CategoryEntity>(17, 12);
      TestPropertiesToDisplay<XElement>(GeneralHelperTest.NumXElementOtherToShow + GeneralHelperTest.NumXElementProperties, 0, GeneralHelperTest.NumXElementOtherToShow);
      var propertyDescriptorCollectionXElement = TypeDescriptor.GetProperties(typeof(XElement), BrowsableAttributeList);
      AddFieldsToPropertiesTypeDescriptionProvider(typeof(NonSerializableClass));
      try
      {
        TestPropertiesToDisplay<NonSerializableClass>(NonSerializableClass.NumberOfNonSerializableClassProperties*2);
        var propertyDescriptorCollectionNonSerializableClass = TypeDescriptor.GetProperties(typeof(NonSerializableClass), BrowsableAttributeList);
      }
      finally
      {
        TidyUp(typeof(NonSerializableClass));
      }
    }

    private static void TestPropertiesToDisplay<T>(int expectedTotlal, int expectedNumNonBrowsable = 0, int numTypeDescriptionProviderDescriptors = 0)
    {
      var propertyDescriptors = TypeDescriptor.GetProperties(typeof(T)).AsEnumerable();
      Assert.AreEqual(expectedTotlal, propertyDescriptors.Count());
      Assert.AreEqual(expectedNumNonBrowsable, propertyDescriptors.Count(p => !p.IsBrowsable));
      var categoryEntities = new List<T>();
      var propertyDescriptorCollection = ListBindingHelper.GetListItemProperties(categoryEntities);
      var olvCategory = new ObjectListView(categoryEntities);
      var propertyDescriptorCollectionOlv = ListBindingHelper.GetListItemProperties(olvCategory);
      var actual = propertyDescriptorCollectionOlv.Count;
      if (ObjectListView.IncludeNonBrowseable)
        actual = actual - expectedNumNonBrowsable - numTypeDescriptionProviderDescriptors;
      Assert.AreEqual(propertyDescriptorCollection.Count, actual);
      Assert.AreEqual(propertyDescriptorCollection.Count, propertyDescriptors.Count(p => p.IsBrowsable) - numTypeDescriptionProviderDescriptors);
      if (ObjectListView.IncludeNonBrowseable)
        Assert.AreEqual(expectedNumNonBrowsable, propertyDescriptorCollectionOlv.AsEnumerable().Count(p => !p.IsBrowsable));
    }
  }

  [TestClass]
  public class DataEditorExtensionsRunner
  {
    [TestCategory("Winforms"), TestMethod]
    public void XmlRun()
    {
      var xml = TestData.TestXmlString;

      var xElement = XElement.Parse(xml);
      var xElements = xElement.Elements().ToList();
      var olv = new ObjectListView(xElements);
      var olvt = new ObjectListView<XElement>(xElements);
      var propertyDescriptorCollectionXElements = ListBindingHelper.GetListItemProperties(xElements);
      var propertyDescriptorCollection = ListBindingHelper.GetListItemProperties(olv);
      var propertyDescriptorCollectionT = ListBindingHelper.GetListItemProperties(olvt);

      var BrowsableAttributeList = new Attribute[] {new BrowsableAttribute(true)};
      var descriptorCollection = TypeDescriptor.GetProperties(typeof(XElement));
      var descriptorCollectionB = TypeDescriptor.GetProperties(typeof(XElement), BrowsableAttributeList);
      var descriptorCollectionO = TypeDescriptor.GetProperties(ListBindingHelper.GetListItemType(olv), BrowsableAttributeList);
      var dataGridView = new DataGridView {DataSource = new ObjectListView(new List<CategoryEntity>())};
      //dataGridView.DataConnection.GetCollectionOfBoundDataGridViewColumns()
      //var f = new Form();
      //dataGridView.Parent = f;
      //f.ShowDialog();

      //AWHelper.ShowForm(f);
      //   FrmDataEditor.ShowInGrid(xElements);
      //FrmDataEditor.ShowInGrid(xElements.CopyToDataTable().DefaultView);

      //var xmlDoc = new XmlDocument();
      //xmlDoc.LoadXml(xml);
      //TestEditInDataGridView(xmlDoc.FirstChild.ChildNodes, 23, 1);
    }
  }
}