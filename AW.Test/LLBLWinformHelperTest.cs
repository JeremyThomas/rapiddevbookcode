using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Extensions.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for LLBLWinformHelperTest and is intended
	///to contain all LLBLWinformHelperTest Unit Tests
	///</summary>
	[TestClass]
	public class LLBLWinformHelperTest : GridDataEditorTestBase
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
		///A test for ShowInGrid
		///</summary>
		public void EditInDataGridViewTestHelper<T>(ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase
		{			
			ModalFormHandler = Handler;
			var enumerable = MetaSingletons.MetaData.GetQueryableForEntity<T>().AsEnumerable();
			var expected = enumerable;
			numProperties = GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
			var actual = enumerable.ShowSelfServicingInGrid(pageSize);
			Assert.AreEqual(expected, actual);
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
		}

		protected void TestShowSelfServicingInGrid<T>(IEnumerable<T> enumerable, ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase
		{
			ModalFormHandler = Handler;
			GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
			var actual = enumerable.ShowSelfServicingInGrid(pageSize);
			Assert.AreEqual(enumerable, actual);
			Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
		}

		[TestMethod]
		public void ShowSelfServicingInGridTest()
		{
			EditInDataGridViewTestHelper<AddressEntity>(20);

			var addressTypes = from at in MetaSingletons.MetaData.AddressType
			                   orderby at.AddressTypeID
			                   select at;
			var addressTypeEntities = addressTypes.ToEntityCollection();
			TestShowSelfServicingInGrid(addressTypeEntities,2);
			TestShowSelfServicingInGrid(addressTypeEntities.DefaultView, 3);
			TestShowSelfServicingInGrid(addressTypes.AsEnumerable(), 3);
			TestShowInGrid(addressTypeEntities.AsQueryable());
		}

	}
}