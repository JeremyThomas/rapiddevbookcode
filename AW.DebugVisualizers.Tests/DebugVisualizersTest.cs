using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AQDPortal.UnitTestUtilities;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LinqToSQL;
using AW.Tests;
using AW.Winforms.Helpers;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			TestSerialize(addressTypeQueryable);
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			var addressTypeEntityCollectionQueryable = addressTypeEntityCollection.AsQueryable();
			TestSerialize(addressTypeEntityCollectionQueryable);
			TestShow(MetaSingletons.MetaData.AddressType, 4);
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
			TestSerialize(MetaSingletons.MetaData.Address.Take(5));
			TestShow(MetaSingletons.MetaData.Address.Take(5), 9);
		}

		[TestMethod]
		public void SerializableEnumerableTest()
		{
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestSerialize(addressTypeEntityCollection);
			TestShow(SerializableBaseClass.GenerateList(), 2);
			TestSerialize(((IEntity) addressTypeEntityCollection.First()).CustomPropertiesOfType);
			TestShow(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 2);
			TestShow(SerializableClass.GenerateList(), 2);
		}

		[TestMethod]
		public void NonSerializableEnumerationTest()
		{
			TestSerialize(MetaSingletons.MetaData.AddressType);
			TestSerialize(MetaSingletons.MetaData.AddressType.Where(at => at.AddressTypeID > 2));
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestSerialize(addressTypeEntityCollection.DefaultView);
			TestSerialize(new BindingSource(addressTypeEntityCollection, null));
			TestSerialize(addressTypeEntityCollection.Where(at => at.AddressTypeID > 2));
			TestSerialize(addressTypeEntityCollection.AsQueryable().OrderByDescending(at => at.AddressTypeID));
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
			TestShow(awDataClassesDataContext.AddressTypes, 4);
			TestSerialize(awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID));
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
			TestSerialize(sd);
			TestSerialize(sd.Keys);
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
			TestShow(xmlDoc.FirstChild.ChildNodes, 23);
		}

		public static void TestSerialize(object enumerableToVisualize)
		{
			//Assert.IsInstanceOfType(enumerableToVisualize, typeof(IEnumerable));
			var enumerableVisualizerObjectSource = new EnumerableVisualizerObjectSource();
			var memoryStream = new MemoryStream();
			enumerableVisualizerObjectSource.GetData(enumerableToVisualize, memoryStream);
			memoryStream.Position = 0;
			Assert.AreNotEqual(0, memoryStream.Length);
			var value = VisualizerObjectSource.Deserialize(memoryStream);
			if (!(value is DataTableSurrogate) && !(value is IListSource) && value.GetType() != enumerableToVisualize.GetType())
				Assert.IsInstanceOfType(value, typeof (IBindingListView));
		}

		public static void TestShow(object enumerableOrDataTableToVisualize)
		{
			var visualizerHost = new VisualizerDevelopmentHost(enumerableOrDataTableToVisualize, typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource));
			visualizerHost.ShowVisualizer();
		}

		public static void TestShow(object enumerableOrDataTableToVisualize, int expectedColumnCount)
		{
			dynamic enumerableVisualizer = new AccessPrivateWrapper(new EnumerableVisualizer());
			var dialogVisualizerServiceFake = new DialogVisualizerServiceFake();
			var visualizerObjectProviderFake = new VisualizerObjectProviderFake(enumerableOrDataTableToVisualize);
			enumerableVisualizer.Show(dialogVisualizerServiceFake, visualizerObjectProviderFake);
			var dataGridView = DataEditorExtensionsTest.GetDataGridViewFromGridDataEditor(dialogVisualizerServiceFake.VisualizerForm);
			Assert.AreEqual(expectedColumnCount, dataGridView.ColumnCount, enumerableOrDataTableToVisualize.ToString());
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