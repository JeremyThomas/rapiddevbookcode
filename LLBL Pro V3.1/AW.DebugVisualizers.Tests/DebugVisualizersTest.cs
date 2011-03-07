using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using AQDPortal.UnitTestUtilities;
using AW.Data;
using AW.Data.EntityClasses;
using AW.DebugVisualizers.Tests.Properties;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LinqToSQL;
using AW.Tests;
using AW.Winforms.Helpers;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using NUnit.Extensions.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.DebugVisualizers.Tests
{
	/// <summary>
	/// 	Summary description for DebugVisualizersTest
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

		private static DialogVisualizerServiceFake DialogVisualizerServiceFake
		{
			get { return _dialogVisualizerServiceFake ?? (_dialogVisualizerServiceFake = _dialogVisualizerServiceFake = new DialogVisualizerServiceFake()); }
		}

		///<summary>
		///	Gets or sets the test context which provides
		///	information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext { get; set; }

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
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//

		#endregion

		[TestMethod]
		public void DataTableTest()
		{
			var nonSerializableClasseDataTable = GeneralHelper.CopyToDataTable(NonSerializableClass.GenerateList());
			TestSerialize(nonSerializableClasseDataTable);
			TestSerialize(nonSerializableClasseDataTable.DefaultView);

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

		[TestMethod]
		public void SerializableQueryTest()
		{
			TestSerialize(MetaSingletons.MetaData.AddressType);
			var addressTypeQueryable = MetaSingletons.MetaData.AddressType.Distinct();
			TestShowTransported(addressTypeQueryable, 4);
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			var addressTypeEntityCollectionQueryable = addressTypeEntityCollection.AsQueryable();
			TestSerialize(addressTypeEntityCollectionQueryable);
			TestShowTransported(MetaSingletons.MetaData.AddressType, 4);
		}

		[TestMethod]
		public void EntityFieldsTest()
		{
			var addressType = MetaSingletons.MetaData.AddressType.First();
			TestShow(addressType.Fields, 36);
		}

		[TestMethod, Timeout(10000)]
		public void LargeSerializableQueryTest()
		{
			var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
			TestShow(awDataClassesDataContext.Addresses, 9);
			//	TestSerialize(MetaSingletons.MetaData.PurchaseOrderHeader);
			//	TestShow(MetaSingletons.MetaData.PurchaseOrderHeader);
		}

		[TestMethod]
		public void QueryWithRelatedFieldsTest()
		{
			TestShowTransported(MetaSingletons.MetaData.Address.Take(5), 9);
		}

		[TestMethod]
		public void AdapterTest()
		{
			var northwindLinqMetaData = GetNorthwindLinqMetaData();
			var customerList = northwindLinqMetaData.Customer.ToList();
			TestShowTransported(customerList, 11);
			TestShowTransported(northwindLinqMetaData.Customer, 11);
			TestShowTransported(northwindLinqMetaData.Customer.ToEntityCollection2(), 11);
		}

		public static LinqMetaData GetNorthwindLinqMetaData()
		{
			return new LinqMetaData {AdapterToUse = new DataAccessAdapter()};
		}

		[TestMethod]
		public void SerializableObservableCollectionTest()
		{
			TestShowTransported(new ObservableCollection<AddressTypeEntity>(MetaSingletons.MetaData.AddressType.ToEntityCollection()), 4);
		}

		[TestMethod]
		public void SerializableCollectionViewTest()
		{
			var collectionView = (new CollectionViewSource { Source = MetaSingletons.MetaData.AddressType.ToEntityCollection() }).View;
			TestShowTransported(collectionView, 4);
		}

		[TestMethod]
		public void SerializableEnumerableTest()
		{
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestShowTransported(addressTypeEntityCollection, 4);
			TestShowTransported(SerializableBaseClass.GenerateList(), 2);
			TestShowTransported(((IEntity) addressTypeEntityCollection.First()).CustomPropertiesOfType, 2);
			TestShowTransported(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 2);
			TestShowTransported(SerializableClass.GenerateList(), 8);
		}

		[TestMethod]
		public void NonSerializableEnumerationTest()
		{
			TestShowTransported(MetaSingletons.MetaData.AddressType, 4);
			TestShowTransported(MetaSingletons.MetaData.AddressType.Where(at => at.AddressTypeID > 2), 4);
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestShowTransported(addressTypeEntityCollection.DefaultView, 4);
			TestShowTransported(new BindingSource(addressTypeEntityCollection, null), 4);
			TestShowTransported(addressTypeEntityCollection.Where(at => at.AddressTypeID > 2), 4);
			TestShowTransported(addressTypeEntityCollection.AsQueryable().OrderByDescending(at => at.AddressTypeID), 4);
		}

		[TestMethod]
		public void NonSerializableItemTest()
		{
			var listofNonSerializableClasses = NonSerializableClass.GenerateList();
			TestSerialize(listofNonSerializableClasses);
			listofNonSerializableClasses.Insert(0, new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString()});
			TestSerialize(listofNonSerializableClasses);
			TestSerialize(new ArrayList(listofNonSerializableClasses));
			TestShow(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)), 14);
		}

		[TestMethod]
		public void DifferentItemTypesTest()
		{
			var listofNonSerializableClasses = SerializableClass.GenerateListWithBothSerializableClasses();
			TestSerialize(listofNonSerializableClasses);
			TestSerialize(listofNonSerializableClasses.Distinct());
			TestSerialize(listofNonSerializableClasses.ToBindingListView());
		}

		[TestMethod]
		public void StringArrayTest()
		{
			var enumerable = new[] {"s1", "s2", "s3"};
			TestShow(enumerable, 1);
		}

		[TestMethod]
		public void LinqtoSQLTest()
		{
			var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
			TestShowTransported(awDataClassesDataContext.AddressTypes, 4);
			TestShowTransported(awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID), 4);
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
			var expectedColumnCount = NonSerializableClass.NumberOfNonSerializableClassProperties*2;
			TestShowTransported(dictionary.Values, expectedColumnCount);
			TestShowTransported(dictionary.Keys, 1);
		}

		[TestMethod]
		public void Xml_test()
		{
			var xml = TestData.GetTestxmlString();

			var xElement = XElement.Parse(xml);
			TestShow(xElement.Elements(), 21);
			//TestSerialize(xElement);

			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			TestShow(xmlDoc.FirstChild.ChildNodes, 24);
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

		public static void TestSerialize(object enumerableOrDataTableToVisualize)
		{
			//Assert.IsInstanceOfType(enumerableToVisualize, typeof(IEnumerable));
			AssertNewContanerIsBindingListView(enumerableOrDataTableToVisualize, VisualizerObjectProviderFake.SerializeDeserialize(enumerableOrDataTableToVisualize));
		}

		/// <summary>
		/// Assert that if the Serialized and Deserialized enumeration is not the same type as the source then it is a IBindingListView
		/// </summary>
		/// <param name="enumerableOrDataTableToVisualize">The enumerable or data table to visualize.</param>
		/// <param name="transportedEnumerableOrDataTable">The transported enumerable or data table.</param>
		private static void AssertNewContanerIsBindingListView(object enumerableOrDataTableToVisualize, object transportedEnumerableOrDataTable)
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

		/// <summary>
		/// Shows the enumerable or data table to visualize and asserts the number of columns displayed.
		/// </summary>
		/// <param name="enumerableOrDataTableToVisualize">The enumerable or data table to visualize.</param>
		/// <param name="expectedColumnCount">The expected column count.</param>
		public static void TestShow(object enumerableOrDataTableToVisualize, int expectedColumnCount)
		{
			Assert.IsTrue(enumerableOrDataTableToVisualize is IEnumerable || enumerableOrDataTableToVisualize is DataTableSurrogate);
			var visualizerObjectProviderFake = new VisualizerObjectProviderFake(enumerableOrDataTableToVisualize);
			//AssertNewContanerIsBindingListView(enumerableOrDataTableToVisualize, visualizerObjectProviderFake.GetObject());
			EnumerableVisualizer.Show(DialogVisualizerServiceFake, visualizerObjectProviderFake);
			var dataGridView = GridDataEditorTestBase.GetDataGridViewFromGridDataEditor(_dialogVisualizerServiceFake.VisualizerForm);
			Assert.AreEqual(expectedColumnCount, dataGridView.ColumnCount, enumerableOrDataTableToVisualize.ToString());
			Application.DoEvents();
		}

		/// <summary>
		/// Shows the enumerable or data table to visualize and asserts the number of columns displayed are that same before and after transportation.
		/// </summary>
		/// <param name="enumerableOrDataTableToVisualize">The enumerable or data table to visualize.</param>
		/// <param name="expectedColumnCount">The expected column count.</param>
		/// <param name="expectedTransportedColumnCount">The expected transported column count.</param>
		public static void TestShowTransported(object enumerableOrDataTableToVisualize, int expectedColumnCount, int expectedTransportedColumnCount = -1)
		{
			TestShow(enumerableOrDataTableToVisualize, expectedColumnCount);
			var transportedEnumerableOrDataTable = VisualizerObjectProviderFake.SerializeDeserialize(enumerableOrDataTableToVisualize);
			AssertNewContanerIsBindingListView(enumerableOrDataTableToVisualize, transportedEnumerableOrDataTable);
			if (expectedTransportedColumnCount == -1)
				expectedTransportedColumnCount = expectedColumnCount;
			TestShow(transportedEnumerableOrDataTable, expectedTransportedColumnCount);
		}
	}

	internal class DialogVisualizerServiceFake : IDialogVisualizerService
	{
		public Form VisualizerForm { get; set; }

		#region Implementation of IDialogVisualizerService

		/// <returns>
		/// Displays a Windows Form.
		/// </returns>
		/// <param name="form">Any Windows Form object derived from System.Windows.Forms.Form.</param>
		public DialogResult ShowDialog(Form form)
		{
			VisualizerForm = form;
			//form.ShowDialog(); 
			form.Show();
			return DialogResult.None;
		}

		/// <param name="dialog">Any dialog derived from System.Windows.Forms.CommonDialog.</param>
		public DialogResult ShowDialog(CommonDialog dialog)
		{
			return DialogResult.None;
		}

		/// <param name="control">Any control derived from System.Windows.Forms.Control.</param>
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
		/// A stream of data containing the contents of the object being visualized. Calling this method results in <see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData(System.Object,System.IO.Stream)"/> being called on the VisualizerObjectSource. The return value of that GetData call is then returned to the caller of this method.
		/// </returns>
		public Stream GetData()
		{
			return null;
		}

		/// <returns>
		/// The data object being visualized. This is actually a debugger-side copy of the object you are visualizing in the debuggee. If you modify the contents of this object, the changes will not be reflected back in the debuggee unless you use the <see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceData(System.IO.Stream)"/>/<see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.ReplaceObject(System.Object)"/> or <see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData(System.IO.Stream)"/>/<see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferObject(System.Object)"/>. 
		/// </returns>
		public object GetObject()
		{
			return _enumerableOrDataTableToVisualize;
		}

		/// <param name="newObjectData">A stream containing data to be used to create a new object, replacing the object currently being visualized.</param>
		public void ReplaceData(Stream newObjectData)
		{
		}

		/// <param name="newObject">The new object to replace the object currently being visualized.</param>
		public void ReplaceObject(object newObject)
		{
		}

		/// <returns>
		/// Returns the data stream filled in by VisualizerObjectSource's TransferData method. There is no two-way stream-based communication between the debugger side and debuggee side (object source.)
		/// </returns>
		/// <param name="outgoingData">A stream of data that is to be transferred back to the debuggee side.</param>
		public Stream TransferData(Stream outgoingData)
		{
			return null;
		}

		/// <returns>
		/// The result of deserializing the return value of <see cref="M:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider.TransferData(System.IO.Stream)"/>.
		/// </returns>
		/// <param name="outgoingObject">An object that is to be transferred back to the debuggee side.</param>
		public object TransferObject(object outgoingObject)
		{
			return null;
		}

		/// <returns>
		/// Determines whether the data object being visualized is replaceable (read/write) or nonreplaceable (read only).
		/// </returns>
		public bool IsObjectReplaceable
		{
			get { return false; }
		}

		#endregion
	}
}