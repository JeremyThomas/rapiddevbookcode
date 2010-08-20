using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	///<summary>
	///	This is a test class for DataEditorExtensionsTest and is intended
	///	to contain all DataEditorExtensionsTest Unit Tests
	///</summary>
	[TestClass]
	public class DataEditorExtensionsTest
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
			TestShowInGrid(NonSerializableClass.GenerateList(), 3);
			TestShowInGrid(SerializableClass.GenerateList(), 4);
			TestShowInGrid(SerializableClass.GenerateListWithBoth(), 3);
			TestShowInGrid(SerializableBaseClass.GenerateList(), 1);
			TestShowInGrid(SerializableBaseClass2.GenerateListWithBothSerializableClasses(), 1);
			TestEditInDataGridView(null);
			TestShowInGrid(Enumerable.Range(1, 100));
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
			TestEditInDataGridView(arrayList);
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
			TestShowInGrid(enumerable);
			enumerable = null;
			TestShowInGrid(enumerable);
			TestShowInGrid(new string[0]);
		}

		[TestMethod]
		public void EditEmptyInDataGridViewTest()
		{
			TestShowInGrid(new SerializableClass[0]);
		}

		[TestMethod]
		public void EditPagedQueryInDataGridViewTest()
		{
			var addressEntities = MetaSingletons.MetaData.Address.SkipTake(1, 15);
			addressEntities.ShowSelfServicingInGrid(20);
			addressEntities.ShowSelfServicingInGrid(0);
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
			MetaSingletons.MetaData.Address.ShowSelfServicingInGrid();
			MetaSingletons.MetaData.AddressType.ShowSelfServicingInGrid();
			TestShowInGrid(MetaSingletons.MetaData.Address, 9, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
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
			TestShowInGrid(awDataClassesDataContext.AddressTypes);
			var addressTypesQuery = awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID);
			addressTypesQuery.ShowInGrid(awDataClassesDataContext);
			addressTypesQuery.ShowInGrid();
			var actual = awDataClassesDataContext.AddressTypes.ShowInGrid();
			Assert.AreEqual(awDataClassesDataContext.AddressTypes, actual);
		}

		[TestMethod]
		public void Xml_test()
		{
			var xml = TestData.GetTestxmlString();

			var xElement = XElement.Parse(xml);
			TestShowInGrid(xElement.Elements());

			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			TestEditInDataGridView(xmlDoc.FirstChild.ChildNodes);
		}

		private static void TestShowInGrid<T>(IEnumerable<T> enumerable, int numProperties = 0, IDataEditorPersister dataEditorPersister = null)
		{
			var actual = enumerable.ShowInGrid(dataEditorPersister);
			Assert.AreEqual(enumerable, actual);
			TestEditInDataGridView(enumerable, numProperties, dataEditorPersister);
		}

		private static void TestEditInDataGridView(IEnumerable enumerable, int numProperties = 0, IDataEditorPersister dataEditorPersister = null)
		{
			var actual = enumerable.ShowInGrid(dataEditorPersister);
			Assert.AreEqual(enumerable, actual);
			if (numProperties > 0)
			{
				var properties = MetaDataHelper.GetPropertiesToDisplay(enumerable);
				Assert.AreEqual(numProperties, properties.Count());
			}
		}
	}
}