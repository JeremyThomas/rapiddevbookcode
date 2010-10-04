using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LinqToSQL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Extensions.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	///<summary>
	///	This is a test class for DataEditorExtensionsTest and is intended
	///	to contain all DataEditorExtensionsTest Unit Tests
	///</summary>
	[TestClass]
	public class DataEditorExtensionsTest : NUnitFormMSTest
	{
		///<summary>
		///	Gets or sets the test context which provides
		///	information about and functionality for the current test run.
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

		///<summary>
		///	A test for ShowInGrid
		///</summary>
		[TestMethod]
		public void EditPropertiesInDataGridViewTest()
		{
			TestShowInGrid(((IEntity) MetaSingletons.MetaData.AddressType.First()).CustomPropertiesOfType, 2);
			TestShowInGrid(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)), 14);
		}

		///<summary>
		///	A test for ShowInGrid
		///</summary>
		[TestMethod]
		public void EditInDataGridViewTest()
		{
			TestShowInGrid(NonSerializableClass.GenerateList(), 3, 3);
			TestShowInGrid(SerializableClass.GenerateList(), 4, 4);
			TestShowInGrid(SerializableClass.GenerateListWithBoth(), 3, 3);
			TestShowInGrid(SerializableBaseClass.GenerateList(), 1, 1);
			TestShowInGrid(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 1, 1);
		}

		[TestMethod]
		public void ShowInDataGridViewTest()
		{
			TestEditInDataGridView(null);
			TestShowInGrid(Enumerable.Range(1, 100), 0);
		}

		private static FieldsToPropertiesTypeDescriptionProvider _fieldsToPropertiesTypeDescriptionProvider;

		private static void AddFieldsToPropertiesTypeDescriptionProvider(Type typeToEdit)
		{
			if (_fieldsToPropertiesTypeDescriptionProvider == null && typeToEdit != null)
			{
				_fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeToEdit, BindingFlags.Instance | BindingFlags.Public);
				TypeDescriptor.AddProvider(_fieldsToPropertiesTypeDescriptionProvider, typeToEdit);
			}
		}

		protected void TidyUp(Type itemType)
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
			var properties = MetaDataHelper.GetPropertiesToDisplay(typeof (NonSerializableClass));
			Assert.AreEqual(3, properties.Count());
			AddFieldsToPropertiesTypeDescriptionProvider(typeof (NonSerializableClass));
			try
			{
				properties = MetaDataHelper.GetPropertiesToDisplay(typeof (NonSerializableClass));
				Assert.AreEqual(6, properties.Count());
			}
			finally
			{
				TidyUp(typeof (NonSerializableClass));
			}
		}

		[TestMethod]
		public void ShowArrayListInGrid()
		{
			var arrayList = new ArrayList {1, 2, "3"};
			TestEditInDataGridView(arrayList, 0);
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

		[TestMethod]
		public void ShowStringEnumerationInGridTest()
		{
			var enumerable = new[] {"s1", "s2", "s3"};
			TestShowInGrid(enumerable, 1);
			enumerable = null;
			TestShowInGrid(enumerable, 1);
			TestEditInDataGridView(new string[0], 0);
			//TestShowInGrid(new string[0], 0);
		}

		[TestMethod]
		public void EditEmptyInDataGridViewTest()
		{
			TestShowInGrid(new SerializableClass[0], 4, 4);
		}

		[TestMethod]
		public void EditPagedQueryInDataGridViewTest()
		{
			var addressEntities = MetaSingletons.MetaData.Address.SkipTake(1, 15);
			ModalFormHandler = Handler;
			_expectedColumnCount = 9;
			addressEntities.ShowSelfServicingInGrid(20);
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			ModalFormHandler = Handler;
			addressEntities.ShowSelfServicingInGrid(0);
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
		}

		[TestMethod]
		public void QueryInGridIsReadonlyTest()
		{
			TestShowInGrid(MetaSingletons.MetaData.Address);
			TestShowInGrid(MetaSingletons.MetaData.AddressType);
		}

		[TestMethod]
		public void ShowSelfServicingInGridTest()
		{
			ModalFormHandler = Handler;
			_expectedColumnCount = 9;
			MetaSingletons.MetaData.Address.ShowSelfServicingInGrid();
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			ModalFormHandler = Handler;
			_expectedColumnCount = 4;
			MetaSingletons.MetaData.AddressType.ShowSelfServicingInGrid();
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			TestShowInGrid(MetaSingletons.MetaData.Address, 9, 0, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
		}

		[TestMethod]
		public void ShowEntityCollectionInGridTest()
		{
			TestShowInGrid(MetaSingletons.MetaData.Address.ToEntityCollection());
			var addressTypeEntities = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestShowInGrid(addressTypeEntities);
		}

		[TestMethod]
		public void EditLinqtoSQLInDataGridViewTest()
		{
			var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
			//		awDataClassesDataContext. = DbUtils.ActualConnectionString;
			//awDataClassesDataContext.Connection.ConnectionString
			TestShowInGrid(awDataClassesDataContext.AddressTypes, 4);
			var addressTypesQuery = awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID);
			ModalFormHandler = Handler;
			addressTypesQuery.ShowInGrid(awDataClassesDataContext);
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			ModalFormHandler = Handler;
			addressTypesQuery.ShowInGrid();
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			ModalFormHandler = Handler;
			var actual = awDataClassesDataContext.AddressTypes.ShowInGrid();
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			Assert.AreEqual(awDataClassesDataContext.AddressTypes, actual);
		}

		[TestMethod]
		public void Xml_test()
		{
			var xml = TestData.GetTestxmlString();

			var xElement = XElement.Parse(xml);
			TestShowInGrid(xElement.Elements(), 15, 6);

			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			TestEditInDataGridView(xmlDoc.FirstChild.ChildNodes, 23, 1);
		}

		private const BindingFlags FieldBindingFlags = BindingFlags.Instance | BindingFlags.Public;

		private void TestShowInGrid<T>(IEnumerable<T> enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
		{
			ModalFormHandler = Handler;
			_expectedColumnCount = numProperties + numFieldsToShow;
			if (_expectedColumnCount < 0)
			{
				numProperties = MetaDataHelper.GetPropertiesToDisplay(typeof (T)).Count();
				numFieldsToShow = typeof (T).GetFields(FieldBindingFlags).Count();
				_expectedColumnCount = numProperties + numFieldsToShow;
			}
			var actual = enumerable.ShowInGrid(dataEditorPersister);
			Assert.AreEqual(enumerable, actual);
			Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			TestEditInDataGridView(enumerable, numProperties, numFieldsToShow, dataEditorPersister);
		}

		private void TestEditInDataGridView(IEnumerable enumerable, int numProperties = -1, int numFieldsToShow = 0, IDataEditorPersister dataEditorPersister = null)
		{
			if (enumerable != null)
				ModalFormHandler = Handler;
			_expectedColumnCount = numProperties + numFieldsToShow;
			var actual = enumerable.ShowInGrid(dataEditorPersister);
			Assert.AreEqual(enumerable, actual);
			if (enumerable != null)
			{
				var displayPropertyCount = MetaDataHelper.GetPropertiesToDisplay(enumerable).Count();
				if (numProperties > 0)
				{
					Assert.AreEqual(numProperties, displayPropertyCount);
				}
				else if (numProperties < 0)
				{
					_expectedColumnCount = displayPropertyCount;
				}
				Assert.AreEqual(_expectedColumnCount, _actualColumnCount);
			}
		}

		private int _expectedColumnCount;
		private int _actualColumnCount;

		public void Handler(string name, IntPtr hWnd, Form form)
		{
			//Assert.AreEqual(1, ((FrmDataEditor)form). .ColumnCount);
			//var dataGridView = new DataGridViewTester("dataGridView", name);
			//	if (_expectedColumnCount > 0)
			{
				var dataGridView = ((DataGridView) ((GridDataEditor) form.Controls[0]).Controls[0]);
				_actualColumnCount = dataGridView.ColumnCount;
				if (_expectedColumnCount == _actualColumnCount)
					form.Close();
				else
				{
					Debugger.Break();
				}
			}
		}
	}
}