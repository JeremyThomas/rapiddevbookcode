﻿using System.Data.Linq;
using AW.LinqToSQL;
using AW.Winforms.Helpers.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for DataEditorLinqtoSQLPersisterTest and is intended
	///to contain all DataEditorLinqtoSQLPersisterTest Unit Tests
	///</summary>
	[TestClass]
	public class DataEditorLinqtoSQLPersisterTest
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
		///A test for CanSave
		///</summary>
		[TestMethod]
		public void CanSaveTest()
		{
			DataContext dataContext = AWDataClassesDataContext.GetNew();
			var target = new DataEditorLinqtoSQLPersister(dataContext); 
			Assert.IsTrue(target.CanSave(typeof (AddressType)));
			Assert.IsFalse(target.CanSave(typeof(DataEditorLinqtoSQLPersisterTest)));
		}
	}
}