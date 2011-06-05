using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LinqToSQL;
using AW.Tests.Properties;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	///<summary>
	///	This is a test class for DataEditorExtensionsTest and is intended
	///	to contain all DataEditorExtensionsTest Unit Tests
	///</summary>
	[TestClass]
	public class DataEditorExtensionsTest : GridDataEditorTestBase
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
			Assert.AreEqual(NonSerializableClass.NumberOfNonSerializableClassProperties, properties.Count());
			AddFieldsToPropertiesTypeDescriptionProvider(typeof (NonSerializableClass));
			try
			{
				properties = MetaDataHelper.GetPropertiesToDisplay(typeof (NonSerializableClass));
				Assert.AreEqual(NonSerializableClass.NumberOfNonSerializableClassProperties*2, properties.Count());
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
			TestEditInDataGridView(arrayList, 1);
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

		[TestMethod]
		public void ShowStringEnumerationInGridTest()
		{
			var enumerable = new[] {"s1", "s2", "s3"};
			TestShowInGrid(enumerable, 1);
			enumerable = null;
			TestShowInGrid(enumerable, 1);
			TestEditInDataGridView(new string[0], 1);
			//TestShowInGrid(new string[0], 0);
		}

		[TestMethod]
		public void ShowIntegerEnumerationInGridTest()
		{
			var enumerable = Enumerable.Range(1, 100);
			TestShowInGrid(ValueTypeWrapper<int>.CreateListWrapperForBinding(enumerable), 1);
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
			ExpectedColumnCount = 9;
			addressEntities.ShowSelfServicingInGrid(20);
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
			ModalFormHandler = Handler;
			addressEntities.ShowSelfServicingInGrid(0);
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
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
			ExpectedColumnCount = 9;
			MetaSingletons.MetaData.Address.ShowSelfServicingInGrid();
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
			ModalFormHandler = Handler;
			ExpectedColumnCount = 4;
			MetaSingletons.MetaData.AddressType.ShowSelfServicingInGrid();
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
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
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
			ModalFormHandler = Handler;
			addressTypesQuery.ShowInGrid();
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
			ModalFormHandler = Handler;
			var actual = awDataClassesDataContext.AddressTypes.ShowInGrid();
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
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
	}
}