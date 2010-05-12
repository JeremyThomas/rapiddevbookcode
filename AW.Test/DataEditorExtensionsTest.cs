using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.LinqToSQL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
		///	A test for EditInDataGridView
		///</summary>
		[TestMethod]
		public void EditInDataGridViewTest()
		{
			TestEditInDataGridView(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)));
			TestEditInDataGridView(MetaSingletons.MetaData.AddressType.First().CustomPropertiesOfType);
			TestEditInDataGridView(NonSerializableClass.GenerateList());
			TestEditInDataGridView(SerializableClass.GenerateList());
			TestEditInDataGridView(SerializableClass.GenerateListWithBoth());
			var enumerable = new[] {"s1", "s2", "s3"};
			TestEditInDataGridView(enumerable);
			TestEditInDataGridView(null);
			enumerable = null;
			TestEditInDataGridView(enumerable);
			var gridDataEditor = new GridDataEditor();
			gridDataEditor.BindEnumerable(null, 1);

			var arrayList = new ArrayList {1, 2, "3"};
			gridDataEditor.BindEnumerable(arrayList);

			gridDataEditor.BindEnumerable(arrayList, 1);

			TestEditInDataGridView(arrayList);
		}


		[TestMethod]
		public void EditPagedQueryInDataGridViewTest()
		{
			var addressEntities = MetaSingletons.MetaData.Address.SkipTake(1, 15);
			addressEntities.EditSelfServicingInDataGridView(0);
			addressEntities.EditSelfServicingInDataGridView(20);
		}

		[TestMethod]
		public void EditLinqtoSQLInDataGridViewTest()
		{
			var awDataClassesDataContext = AWDataClassesDataContext.GetNew();
			//		awDataClassesDataContext. = DbUtils.ActualConnectionString;
			//awDataClassesDataContext.Connection.ConnectionString
			TestEditInDataGridView(awDataClassesDataContext.AddressTypes);
		  var addressTypesQuery = awDataClassesDataContext.AddressTypes.OrderByDescending(at => at.AddressTypeID);
      addressTypesQuery.EditInDataGridView(awDataClassesDataContext);
			//TestEditInDataGridView(awDataClassesDataContext.);
			var actual = awDataClassesDataContext.AddressTypes.EditInDataGridView();
			Assert.AreEqual(awDataClassesDataContext.AddressTypes, actual);
		}

		private static void TestEditInDataGridView<T>(IEnumerable<T> enumerable)
		{
			var actual = enumerable.EditInDataGridView(null);
			Assert.AreEqual(enumerable, actual);
		}

		private static void TestEditInDataGridView(IEnumerable enumerable)
		{
			var actual = enumerable.EditInDataGridView(null);
			Assert.AreEqual(enumerable, actual);
		}
	}
}