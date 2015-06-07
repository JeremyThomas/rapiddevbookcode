using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.DebugVisualizers.Tests.Properties;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Helper.TypeConverters;
using AW.LinqToSQL;
using AW.Test.Helpers;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Misc;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AddressType = AW.Data.AddressType;

namespace AW.DebugVisualizers.Tests
{
  /// <summary>
  ///   Summary description for DebugVisualizersTest
  /// </summary>
  [TestClass]
  public class DebugVisualizersTest : NUnitFormMSTest
  {
    private static dynamic _enumerableVisualizer;

    private static dynamic EnumerableVisualizer
    {
      get { return _enumerableVisualizer ?? (_enumerableVisualizer = new AccessPrivateWrapper(new EnumerableVisualizer())); }
    }

    private static DialogVisualizerServiceFake _dialogVisualizerServiceFake;
    private static DialogVisualizerServiceFake _dialogVisualizerServiceFakeForDebug;
    private static readonly EntityCollectionBase<AddressTypeEntity> AddressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
    private static Dictionary<Type, DebuggerVisualizerAttribute> _visualizerAttributes;
    private static List<DebuggerVisualizerAttribute> _visualizerAttributesNotFound;
    private static List<DebuggerVisualizerAttribute> _visualizerAttributesNotFoundInAssembly;

    private static DialogVisualizerServiceFake DialogVisualizerServiceFake
    {
      get { return _dialogVisualizerServiceFake ?? (_dialogVisualizerServiceFake = _dialogVisualizerServiceFake = new DialogVisualizerServiceFake()); }
    }

    private static DialogVisualizerServiceFake DialogVisualizerServiceFakeForDebug
    {
      get { return _dialogVisualizerServiceFakeForDebug ?? (_dialogVisualizerServiceFakeForDebug = _dialogVisualizerServiceFakeForDebug = new DialogVisualizerServiceFake(true)); }
    }

    public static Dictionary<Type, DebuggerVisualizerAttribute> VisualizerAttributes
    {
      get
      {
        if (_visualizerAttributes == null)
          LoadDebuggerVisualizerAttributes();
        return _visualizerAttributes;
      }
    }

    public static List<DebuggerVisualizerAttribute> VisualizerAttributesNotFound
    {
      get
      {
        if (_visualizerAttributesNotFound == null)
          LoadDebuggerVisualizerAttributes();
        return _visualizerAttributesNotFound;
      }
    }

    public static List<DebuggerVisualizerAttribute> VisualizerAttributesNotFoundInAssembly
    {
      get
      {
        if (_visualizerAttributesNotFoundInAssembly == null)
          LoadDebuggerVisualizerAttributes();
        return _visualizerAttributesNotFoundInAssembly;
      }
    }

    public static void LoadDebuggerVisualizerAttributes()
    {
      var enumerableVisualizerType = typeof (EnumerableVisualizer);
      var assembly = enumerableVisualizerType.Assembly;
      var debuggerVisualizerAttributes = assembly.GetCustomAttributes(typeof (DebuggerVisualizerAttribute), false);
      _visualizerAttributes = new Dictionary<Type, DebuggerVisualizerAttribute>();
      _visualizerAttributesNotFound = new List<DebuggerVisualizerAttribute>();
      _visualizerAttributesNotFoundInAssembly = new List<DebuggerVisualizerAttribute>();
      foreach (DebuggerVisualizerAttribute debuggerVisualizerAttribute in debuggerVisualizerAttributes)
        if (debuggerVisualizerAttribute.VisualizerTypeName == enumerableVisualizerType.AssemblyQualifiedName)
        {
          var type = Type.GetType(debuggerVisualizerAttribute.TargetTypeName);
          if (type == null)
          {
            type = MetaDataHelper.GetTypesContaining(debuggerVisualizerAttribute.TargetTypeName).FirstOrDefault();
          }
          if (type == null)
          {
            var parts = debuggerVisualizerAttribute.TargetTypeName.Split(',');
            var assemblyName = parts[1];
            if (MetaDataHelper.GetAssembly(assemblyName) == null) 
              _visualizerAttributesNotFound.Add(debuggerVisualizerAttribute); //This is OK
            else
              _visualizerAttributesNotFoundInAssembly.Add(debuggerVisualizerAttribute); //This is not
          }
          else
            _visualizerAttributes.Add(type, debuggerVisualizerAttribute);
        }
    }

    #region Additional test attributes

    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
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

    [TestMethod]
    public void DataTableTest()
    {
      var nonSerializableClassesDataTable = GeneralHelper.CopyToDataTable(NonSerializableClass.GenerateList());
      TestSerialize(nonSerializableClassesDataTable);
      TestSerialize(nonSerializableClassesDataTable.DefaultView);

      var serializableClassDataTable = GeneralHelper.CopyToDataTable(SerializableClass.GenerateList());
      TestSerialize(serializableClassDataTable);
      TestSerialize(serializableClassDataTable.DefaultView);

      var dt = new DataSet();
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      TestSerialize(dt.Tables[0]);
      TestSerialize(dt.Tables[0].DefaultView);

      var addressTypeDataTable = GeneralHelper.CopyToDataTable(MetaSingletons.MetaData.AddressType);
      TestSerialize(addressTypeDataTable);
      TestSerialize(addressTypeDataTable.DefaultView);

      var enumerableRowCollection = addressTypeDataTable.AsEnumerable();
      TestSerialize(enumerableRowCollection);

      TestSerialize(DataTableExtensions.CopyToDataTable(enumerableRowCollection));
    }

    [TestCategory("Winforms"), TestMethod]
    public void SerializableQueryTest()
    {
      TestSerialize(MetaSingletons.MetaData.AddressType);
      var addressTypeQueryable = MetaSingletons.MetaData.AddressType.Distinct();
      TestShowTransported(addressTypeQueryable, TestData.BrowseableAddressTypeProperties);
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var addressTypeEntityCollectionQueryable = addressTypeEntityCollection.AsQueryable();
      TestSerialize(addressTypeEntityCollectionQueryable);
      TestShowTransported(MetaSingletons.MetaData.AddressType, TestData.BrowseableAddressTypeProperties);
    }

    [TestCategory("Winforms"), TestMethod]
    public void WeakReferenceTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      var weakReference = new WeakReference(addressTypeEntityCollection);
      TestSerialize(weakReference);
      TestShowTransported(weakReference, TestData.BrowseableAddressTypeProperties);
    }

    [TestMethod]
    public void LookupTest()
    {
      var lookup = MetaSingletons.MetaData.AddressType.ToLookup(at => at.Name);
      //Show(lookup);
      TestShow(lookup, 1);
    }

    [TestCategory("Winforms"), TestMethod]
    public void EntityFieldsTest()
    {
      var addressType = MetaSingletons.MetaData.AddressType.First();
      //ShowObjectSourceVisualizer(addressType);
      TestShow(addressType.Fields, TestData.NumFieldProperties);
    }

    [TestCategory("Winforms"), TestMethod, Timeout(20000)]
    public void LargeSerializableQueryTest()
    {
      var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
      TestShow(awDataClassesDataContext.Addresses, 9);
      //	TestSerialize(MetaSingletons.MetaData.PurchaseOrderHeader);
      //	TestShow(MetaSingletons.MetaData.PurchaseOrderHeader);
    }

    [TestCategory("Winforms"), TestMethod]
    public void QueryWithRelatedFieldsTest()
    {
      TestShowTransported(MetaSingletons.MetaData.Address.Take(5), TestData.BrowseableAddressProperties);
    }

    [TestMethod]
    public void AdapterTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var customerList = northwindLinqMetaData.Customer.ToList();
      const int expectedColumnCount = 12;
      //Show(customerList);
      //Show(customerList.ToEntityCollection2());
      TestShowTransported(customerList, expectedColumnCount);
      TestShowTransported(northwindLinqMetaData.Customer, expectedColumnCount);
      TestShowTransported(northwindLinqMetaData.Customer.ToEntityCollection2(), expectedColumnCount);
    }

    private static LinqMetaData GetNorthwindLinqMetaData()
    {
      return new LinqMetaData {AdapterToUse = new DataAccessAdapter()};
    }

    [TestMethod]
    public void SerializableObservableCollectionTest()
    {
      TestShowTransported(new ObservableCollection<AddressTypeEntity>(MetaSingletons.MetaData.AddressType.ToEntityCollection()), TestData.BrowseableAddressTypeProperties);
    }

    [TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("Can throw null exception but doesn't when debugged")]
    public void SerializableCollectionViewTest()
    {
      var collectionView = (new CollectionViewSource {Source = MetaSingletons.MetaData.AddressType.ToEntityCollection()}).View;
      TestShowTransported(collectionView, TestData.BrowseableAddressTypeProperties);
    }

    [TestCategory("Winforms"), TestMethod]
    public void SerializableEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      TestShowTransported(addressTypeEntityCollection, TestData.BrowseableAddressTypeProperties);
      TestShowTransported(new HashSet<AddressTypeEntity>(AddressTypeEntityCollection), TestData.BrowseableAddressTypeProperties);
      TestShowTransported(SerializableBaseClass.GenerateList(), 2);
      TestShowTransported(((IEntity) addressTypeEntityCollection.First()).CustomPropertiesOfType, 2);
      TestShowTransported(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 2);
      TestShowTransported(SerializableClass.GenerateList(), 8);
    }

    [TestCategory("Winforms"), TestMethod]
    public void NonSerializableEnumerationTest()
    {
      TestShowTransported(MetaSingletons.MetaData.AddressType, TestData.BrowseableAddressTypeProperties);
      TestShowTransported(MetaSingletons.MetaData.AddressType.Where(at => at.AddressTypeID > AddressType.Home), TestData.BrowseableAddressTypeProperties);
      TestShowTransported(AddressTypeEntityCollection.DefaultView, TestData.BrowseableAddressTypeProperties);
      TestShowTransported(new BindingSource(AddressTypeEntityCollection, null), TestData.BrowseableAddressTypeProperties);
      TestShowTransported(AddressTypeEntityCollection.Where(at => at.AddressTypeID > AddressType.Home), TestData.BrowseableAddressTypeProperties);
      TestShowTransported(AddressTypeEntityCollection.AsQueryable().OrderByDescending(at => at.AddressTypeID), TestData.BrowseableAddressTypeProperties);
    }

    [TestCategory("Winforms"), TestMethod]
    public void NonSerializableItemTest()
    {
      var listofNonSerializableClasses = NonSerializableClass.GenerateList();
      TestSerialize(listofNonSerializableClasses);
      listofNonSerializableClasses.Insert(0, new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString(CultureInfo.InvariantCulture)});
      TestSerialize(listofNonSerializableClasses);
      TestSerialize(new ArrayList(listofNonSerializableClasses));
      TestShow(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)), 14);
    }

    [TestMethod]
    public void DifferentItemTypesTest()
    {
      var listofNonSerializableClasses = SerializableClass.GenerateListWithBothSerializableClasses();
      //ShowObjectSourceVisualizer(listofNonSerializableClasses.First());
      TestSerialize(listofNonSerializableClasses);
      TestSerialize(listofNonSerializableClasses.Distinct());
      TestSerialize(listofNonSerializableClasses.ToBindingListView());
    }

    [TestCategory("Winforms"), TestMethod]
    public void StringArrayTest()
    {
      var enumerable = new[] {"s1", "s2", "s3"};
      TestShow(enumerable, 1);
      //ShowWithFakeAndWait(enumerable);
      var stringEnumerable = enumerable.Where(s => s.Length > 1);
      TestShow(stringEnumerable, 1);
      TestShowTransported(stringEnumerable, 1);
      TestShowTransported(new SortedSet<string>(stringEnumerable), 1);
    }

    [TestCategory("Winforms"), TestMethod]
    public void LinqtoSQLTest()
    {
      var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
      TestShowTransported(awDataClassesDataContext.AddressTypes, TestData.BrowseableAddressTypeProperties);
      TestShowTransported(awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID), TestData.BrowseableAddressTypeProperties);
    }

    [TestMethod]
    public void KeysCollectionTest()
    {
      var nv = new NameValueCollection {{"foo", "foo"}, {"b", "b"}};
      TestSerialize(nv);
      TestSerialize(nv.Keys);
    }

    [TestMethod]
    public void StringDictionaryTest()
    {
      var sd = new StringDictionary {{"key1", "value1"}, {"key2", "value2"}};
      TestShowTransported(sd, 2);
      TestSerialize(sd.Keys);
    }

    [TestMethod]
    public void DictionaryTest()
    {
      var dictionary = NonSerializableClass.GenerateList().ToDictionary(ns => ns.IntProperty, ns => ns);
      TestShowTransported(dictionary, 2, 1);
      const int expectedColumnCount = NonSerializableClass.NumberOfNonSerializableClassProperties*2;
      TestShowTransported(dictionary.Values, expectedColumnCount);
      TestShowTransported(dictionary.Keys, 1);
    }

    [TestCategory("Winforms"), TestMethod]
    public void Xml_test()
    {
      var xml = TestData.GetTestxmlString();

      var xElement = XElement.Parse(xml);
      TestShowTransported(xElement.Elements(), 21, 7);
      //TestSerialize(xElement);

      var xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(xml);
      //Show(xmlDoc.FirstChild.ChildNodes);
      TestShowTransported(xmlDoc.FirstChild.ChildNodes, 25, 14);
    }

    [TestMethod]
    public void XmlSchemaTest()
    {
      var xmlSchema = TestData.GetTestXmlSchema();
      TestShowTransported(xmlSchema.Items, 28, 23);
      TestShowTransported(xmlSchema.Attributes.Names, 0);
      TestShowTransported(xmlSchema.Elements.Names, 3);
      TestShowTransported(xmlSchema.Elements.Values, 28, 23);
      TestShowTransported(xmlSchema.Groups.Values, 0);
      TestShowTransported(xmlSchema.SchemaTypes.Values, 0);
    }

    //[TestMethod]
    //public void XmlSchemaFromFileTest()
    //{
    //  var xmlSchema = TestData.GetTestXmlSchema(@"C:\TFSProjects\AQDPortal\Trunk\AQDPortal.MVC\AQD.ExportUtility\RASchemas\Occurrence_1_0.xsd");
    //  TestShowTransported(xmlSchema.Items, 5, 28);
    //  TestShowTransported(xmlSchema.Groups.Values, 0);
    //  var xmlSchemaComplexType = (xmlSchema.Elements.Values.Cast<XmlSchemaElement>().First(element => element.Name == "OccurrenceDetails").ElementSchemaType as XmlSchemaComplexType);
    //  TestShowTransported((xmlSchemaComplexType.Particle as XmlSchemaSequence).Items, 28, 23);
    //}

    [TestMethod]
    public void SettingsPropertyTest()
    {
      TestShowTransported(Settings.Default.Properties, 9, 7);
      if (Settings.Default.PropertyValues.Count == 0)
      {
        var x = Settings.Default.StringSetting;
      }
      Assert.AreNotEqual(0, Settings.Default.PropertyValues.Count);
      TestShowTransported(Settings.Default.PropertyValues, 7, 6);
    }

    [TestMethod]
    public void AssembliesTest()
    {
      var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.FullName.Contains("OrmProfiler")
                                                                          && !a.FullName.Contains("SD.Tools")).ToList();
      //Show(assemblies);
      TestSerialize(assemblies);
    }

    [TestCategory("Winforms"), TestMethod]
    public void PropertyCollectionTest()
    {
      using (var ctx = new PrincipalContext(ContextType.Machine))
      using (var usr = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, Environment.UserName))
      {
        var directoryEntry = usr != null ? usr.GetUnderlyingObject() as DirectoryEntry : null;
        if (directoryEntry != null) TestShowTransported(directoryEntry.Properties, 5);
      }
    }

    [TestCategory("Winforms"), TestMethod]
    public void DirectoryEntryTest()
    {
      var path = string.Format("WinNT://{0},computer", Environment.MachineName);
      using (var directoryEntry = new DirectoryEntry(path))
        TestShowTransported(directoryEntry.Children, 3);
    }

    [TestCategory("Winforms"), TestMethod]
    public void SearchResultCollectionTest()
    {
      using (var entry = new DirectoryEntry("LDAP://ldap.forumsys.com/dc=example,dc=com", "", "", AuthenticationTypes.None))
      using (var searcher = new DirectorySearcher(entry))
      {
        searcher.PageSize = 5;
        TestShowTransported(searcher.FindAll(), 2, 1);
      }
    }

    [TestCategory("Winforms"), TestMethod]
    public void ResultPropertyCollectionTest()
    {
      using (var entry = new DirectoryEntry("LDAP://ldap.forumsys.com/dc=example,dc=com", "", "", AuthenticationTypes.None))
      using (var searcher = new DirectorySearcher(entry))
      {
        searcher.Filter = "(uid=" + "tesla" + ")";
        var searchResult = searcher.FindOne();
        SingleValueCollectionConverter.AddConverter(typeof (ResultPropertyValueCollection));
        SubstitutingTypeDescriptionProvider.AddSpecificTypeConverterFor((DictionaryEntry d) => d.Value);
        //SingleValueCollectionConverter.AddConverter(typeof(ResultPropertyValueCollection));
        //SubstitutingTypeDescriptionProvider.AddFor<DictionaryEntry>(p=>p.Name == "Value", p =>  new ConverterSubstitutingPropertyDescriptor(p, new SpecificTypeConverter(p.Converter)));
        //var dictionaryEntries = searchResult.Properties.OfType<DictionaryEntry>();
        //var dictionaryEntry = dictionaryEntries.First();
        //var valueType = dictionaryEntry.Value.GetType();
        //var s = NullableConverter.(valueType);
        //var typeConverter = TypeDescriptor.GetConverter(valueType);
        //var convertToString = typeConverter.ConvertToString(dictionaryEntry.Value);
        //TypeConverter.StandardValuesCollection
        //var typeDictionaryEntry = typeof(DictionaryEntry);
        //var typeDescriptionProvider = TypeDescriptor.GetProvider(typeof(DictionaryEntry));
        //var propertiesToDisplay = MetaDataHelper.GetPropertiesToDisplay(typeDictionaryEntry);
        //var propertyDescriptor = propertiesToDisplay.Last();
        //var converter = propertyDescriptor.Converter;
        //if (converter != null)
        //{
        //  var stringToDisplay = converter.ConvertToString(dictionaryEntry.Value);
        //}
        //dictionaryEntry.Value
        //TestShowInGrid(dictionaryEntries);
        //searchResult.Properties.ShowInGrid();
        var enumerable = searchResult.Properties.OfType<DictionaryEntry>();
        // enumerable.ShowInGrid();
        // ShowWithFakeAndWait(searchResult.Properties);
        // Show(searchResult.Properties);
        //TestShow(searchResult.Properties, 2);
        TestShowTransported(searchResult.Properties, 2);
        //TestShowTransported(enumerable, 3);
      }
    }

    [TestCategory("Winforms"), TestMethod]
    public void ClaimsTest()
    {
      var claims = ClaimsPrincipal.Current.Claims;
      TestShowTransported(claims, 7);
      var identityClaims = ((GenericIdentity)ClaimsPrincipal.Current.Identity).Claims;
      TestShowTransported(identityClaims, 7);
    }

    [TestCategory("Winforms"), TestMethod]
    public void DebuggerVisualizerAttributeTest()
    {
      Assert.AreEqual(0, VisualizerAttributesNotFoundInAssembly.Count, VisualizerAttributesNotFoundInAssembly.Select(va=>va.TargetTypeName).JoinAsString());
    }

    private static void TestSerialize(object enumerableOrDataTableToVisualize)
    {
      //Assert.IsInstanceOfType(enumerableToVisualize, typeof(IEnumerable));
      AssertNewContainerIsBindingListView(enumerableOrDataTableToVisualize, VisualizerObjectProviderFake.SerializeDeserialize(enumerableOrDataTableToVisualize));
    }

    /// <summary>
    ///   Assert that if the Serialized and Deserialized enumeration is not the same type as the source then it is a
    ///   IBindingListView
    /// </summary>
    /// <param name="enumerableOrDataTableToVisualize"> The enumerable or data table to visualize. </param>
    /// <param name="transportedEnumerableOrDataTable"> The transported enumerable or data table. </param>
    private static void AssertNewContainerIsBindingListView(object enumerableOrDataTableToVisualize, object transportedEnumerableOrDataTable)
    {
      if (!(transportedEnumerableOrDataTable is DataTableSurrogate) && !(transportedEnumerableOrDataTable is IListSource)
          && transportedEnumerableOrDataTable.GetType() != enumerableOrDataTableToVisualize.GetType())
        Assert.IsInstanceOfType(transportedEnumerableOrDataTable, typeof (IBindingListView));
    }

    private static void Show(object enumerableOrDataTableToVisualize)
    {
      var visualizerHost = new VisualizerDevelopmentHost(enumerableOrDataTableToVisualize, typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource));
      visualizerHost.ShowVisualizer();
    }

    //private static void ShowObjectSourceVisualizer(object enumerableOrDataTableToVisualize)
    //{
    //  var visualizerHost = new VisualizerDevelopmentHost(enumerableOrDataTableToVisualize, typeof (ObjectSourceVisualizer.ObjectSourceVisualizer),
    //    typeof (ObjectSourceVisualizer.ObjectSourceVisualizer));
    //  visualizerHost.ShowVisualizer();
    //}

    private static void ShowWithFake(object enumerableOrDataTableToVisualize)
    {
      var visualizerObjectProviderFake = new VisualizerObjectProviderFake(enumerableOrDataTableToVisualize);
      //AssertNewContainerIsBindingListView(enumerableOrDataTableToVisualize, visualizerObjectProviderFake.GetObject());
      EnumerableVisualizer.Show(DialogVisualizerServiceFake, visualizerObjectProviderFake);
    }

    /// <summary>
    ///   Shows data directly
    /// </summary>
    /// <param name="enumerableOrDataTableToVisualize"></param>
    private static void ShowWithFakeAndWait(object enumerableOrDataTableToVisualize)
    {
      //  var visualizerObjectProviderFake = new VisualizerObjectProviderFake(enumerableOrDataTableToVisualize);
      //DialogVisualizerServiceFakeForDebug
      //  EnumerableVisualizer.Show(DialogVisualizerServiceFakeForDebug, visualizerObjectProviderFake);
      //ShowWithFake(enumerableOrDataTableToVisualize);
      //var dataGridView = GridDataEditorTestBase.GetDataGridViewFromGridDataEditor(_dialogVisualizerServiceFake.VisualizerForm);
      //   ShowWithFake(enumerableOrDataTableToVisualize);
      //    Application.DoEvents();
      ShowWithFake(enumerableOrDataTableToVisualize);
      Application.DoEvents();
      _dialogVisualizerServiceFake.VisualizerForm.BringToFront();
      while (_dialogVisualizerServiceFake.VisualizerForm.Visible)
      {
        Application.DoEvents();
      }
    }

    /// <summary>
    ///   Shows the enumerable or data table to visualize and asserts the number of columns displayed.
    /// </summary>
    /// <param name="enumerableOrDataTableToVisualize"> The enumerable or data table to visualize. </param>
    /// <param name="expectedColumnCount"> The expected column count. </param>
    private static void TestShow(object enumerableOrDataTableToVisualize, int expectedColumnCount)
    {
      Assert.IsTrue(enumerableOrDataTableToVisualize is IEnumerable
                    || enumerableOrDataTableToVisualize is DataTableSurrogate || enumerableOrDataTableToVisualize is DataTable
                    || enumerableOrDataTableToVisualize is WeakReference);
      var type = enumerableOrDataTableToVisualize.GetType();
      var rootType = type.GetTypeAndParentTypes().Last();
      if (!type.IsArray)
        Assert.IsTrue(VisualizerAttributes.ContainsKey(rootType), rootType.Name +"-"+ type.Name);
      ShowWithFake(enumerableOrDataTableToVisualize);
      var dataGridView = GridDataEditorTestBase.GetDataGridViewFromGridDataEditor(_dialogVisualizerServiceFake.VisualizerForm);
      Assert.AreEqual(expectedColumnCount, dataGridView.ColumnCount, enumerableOrDataTableToVisualize.ToString());
      Assert.IsTrue(dataGridView.ReadOnly, "dataGridView.ReadOnly");
      Assert.IsInstanceOfType(dataGridView.DataSource, typeof (BindingSource)); //make it BindingSource
      var bindingSource = (BindingSource) (dataGridView.DataSource);
      if (bindingSource.DataSource is IBindingList)
      {
        Assert.IsFalse(bindingSource.AllowRemove, "bindingSource.AllowRemove");
        Assert.IsFalse(bindingSource.AllowEdit, "bindingSource.AllowEdit");
        Assert.IsFalse(bindingSource.AllowNew, "bindingSource.AllowNew");
      }
      Application.DoEvents();
    }

    /// <summary>
    ///   Shows the enumerable or data table to visualize and asserts the number of columns displayed are that same before and
    ///   after transportation.
    /// </summary>
    /// <param name="enumerableOrDataTableToVisualize"> The enumerable or data table to visualize. </param>
    /// <param name="expectedColumnCount"> The expected column count. </param>
    /// <param name="expectedTransportedColumnCount"> The expected transported column count. </param>
    private static void TestShowTransported(object enumerableOrDataTableToVisualize, int expectedColumnCount, int expectedTransportedColumnCount = -1)
    {
      TestShow(enumerableOrDataTableToVisualize, expectedColumnCount);
      var transportedEnumerableOrDataTable = VisualizerObjectProviderFake.SerializeDeserialize(enumerableOrDataTableToVisualize);
      AssertNewContainerIsBindingListView(enumerableOrDataTableToVisualize, transportedEnumerableOrDataTable);
      if (expectedTransportedColumnCount == -1)
        expectedTransportedColumnCount = expectedColumnCount;
      TestShow(transportedEnumerableOrDataTable, expectedTransportedColumnCount);
    }
  }

  internal class DialogVisualizerServiceFake : IDialogVisualizerService
  {
    private readonly bool _debug;

    public DialogVisualizerServiceFake(bool debug = false)
    {
      _debug = debug;
    }

    public Form VisualizerForm { get; private set; }

    #region Implementation of IDialogVisualizerService

    /// <returns> Displays a Windows Form. </returns>
    /// <param name="form"> Any Windows Form object derived from System.Windows.Forms.Form. </param>
    public DialogResult ShowDialog(Form form)
    {
      VisualizerForm = form;
      if (_debug)
        form.ShowDialog(); //Doesn't do anything
      else
        form.Show();
      return DialogResult.None;
    }

    /// <param name="dialog"> Any dialog derived from System.Windows.Forms.CommonDialog. </param>
    public DialogResult ShowDialog(CommonDialog dialog)
    {
      return DialogResult.None;
    }

    /// <param name="control"> Any control derived from System.Windows.Forms.Control. </param>
    public DialogResult ShowDialog(Control control)
    {
      return DialogResult.None;
    }

    #endregion
  }

  internal class VisualizerObjectProviderFake : IVisualizerObjectProvider
  {
    private readonly object _enumerableOrDataTableToVisualize;

    public VisualizerObjectProviderFake(object enumerableOrDataTableToVisualize)
    {
      _enumerableOrDataTableToVisualize = enumerableOrDataTableToVisualize;
    }

    public static object SerializeDeserialize(object enumerableToVisualize)
    {
      var enumerableVisualizerObjectSource = new EnumerableVisualizerObjectSource();
      var memoryStream = new MemoryStream();
      enumerableVisualizerObjectSource.GetData(enumerableToVisualize, memoryStream);
      memoryStream.Position = 0;
      Assert.AreNotEqual(0, memoryStream.Length);
      return VisualizerObjectSource.Deserialize(memoryStream);
    }

    #region Implementation of IVisualizerObjectProvider

    /// <returns>
    ///   A stream of data containing the contents of the object being visualized. Calling this method results in
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData(System.Object,System.IO.Stream)" />
    ///   being called on the VisualizerObjectSource. The return value of that GetData call is then returned to the caller of
    ///   this method.
    /// </returns>
    public Stream GetData()
    {
      return null;
    }

    /// <returns>
    ///   The data object being visualized. This is actually a debugger-side copy of the object you are visualizing in the
    ///   debuggee. If you modify the contents of this object, the changes will not be reflected back in the debuggee unless
    ///   you use the
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceData(System.IO.Stream)" />
    ///   /
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceObject(System.Object)" />
    ///   or
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData(System.IO.Stream)" />
    ///   /
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferObject(System.Object)" />
    ///   .
    /// </returns>
    public object GetObject()
    {
      return _enumerableOrDataTableToVisualize;
    }

    /// <param name="newObjectData">
    ///   A stream containing data to be used to create a new object, replacing the object currently
    ///   being visualized.
    /// </param>
    public void ReplaceData(Stream newObjectData)
    {
    }

    /// <param name="newObject"> The new object to replace the object currently being visualized. </param>
    public void ReplaceObject(object newObject)
    {
    }

    /// <returns>
    ///   Returns the data stream filled in by VisualizerObjectSource's TransferData method. There is no two-way
    ///   stream-based communication between the debugger side and debuggee side (object source.)
    /// </returns>
    /// <param name="outgoingData"> A stream of data that is to be transferred back to the debuggee side. </param>
    public Stream TransferData(Stream outgoingData)
    {
      return null;
    }

    /// <returns>
    ///   The result of deserializing the return value of
    ///   <see
    ///     cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData(System.IO.Stream)" />
    ///   .
    /// </returns>
    /// <param name="outgoingObject"> An object that is to be transferred back to the debuggee side. </param>
    public object TransferObject(object outgoingObject)
    {
      return null;
    }

    /// <returns>
    ///   Determines whether the data object being visualized is replaceable (read/write) or nonreplaceable (read
    ///   only).
    /// </returns>
    public bool IsObjectReplaceable
    {
      get { return false; }
    }

    #endregion
  }
}