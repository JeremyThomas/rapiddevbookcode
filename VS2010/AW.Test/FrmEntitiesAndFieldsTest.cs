using System;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Extensions.Forms;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for FrmEntitiesAndFieldsTest and is intended
	///to contain all FrmEntitiesAndFieldsTest Unit Tests
	///</summary>
	[TestClass]
	public class FrmEntitiesAndFieldsTest : NUnitFormMSTest
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
		///A test for ShowEntitiesAndFields
		///</summary>
		[TestMethod]
		public void ShowEntitiesAndFieldsTest()
		{
			//typeof (CommonEntityBase), MetaSingletons.MetaData
			//AW.Winforms.Helpers.LLBL.FrmEntitiesAndFields.ShowEntitiesAndFields(typeof(AQD.Model.EntityClasses.CommonEntityBase),this);
			var baseType = typeof (CommonEntityBase);
			ILinqMetaData linqMetaData = MetaSingletons.MetaData;
			ModalFormHandler = Handler;
			FrmEntitiesAndFields.ShowEntitiesAndFields(baseType, linqMetaData);
		}

		public void Handler(string name, IntPtr hWnd, Form form)
		{
		}
	}
}