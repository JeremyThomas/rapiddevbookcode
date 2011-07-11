using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Winforms.Helpers;
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
			TestShowEntitiesAndFields(null, null);
		}

		[TestMethod]
		public void ShowEntitiesAndFieldsILinqMetaDataTest()
		{
			TestShowEntitiesAndFields(null, MetaSingletons.MetaData);
		}

		[TestMethod]
		public void ShowEntitiesAndFieldsCommonEntityBaseTest()
		{
			TestShowEntitiesAndFields(typeof(CommonEntityBase), null);
		}

		private void TestShowEntitiesAndFields(Type baseType, ILinqMetaData linqMetaData)
		{
			ModalFormHandler = Handler;
			var form = baseType == null ? (linqMetaData == null ? new FrmEntitiesAndFields() : new FrmEntitiesAndFields(linqMetaData)) : new FrmEntitiesAndFields(baseType);
			AWHelper.ShowForm(form);
			Assert.AreEqual(EntityHelperTest.NumberOfEntities, _rootNodesCount, "EntityHelperTest.NumberOfEntities");
			Assert.AreEqual(LLBLWinformHelperTest.NumSchemaObjects, _nodesCount, "LLBLWinformHelperTest.NumSchemaObjects");
			_nodesCount = null;
		}

		private int? _rootNodesCount;
		private int? _nodesCount;

		public void Handler(string name, IntPtr hWnd, Form form)
		{
			_rootNodesCount = GetTreeViewEntitiesFromFrmEntitiesAndFields(form).Nodes.Count;
			_nodesCount = GetTreeViewEntitiesFromFrmEntitiesAndFields(form).Nodes.Cast<TreeNode>().Descendants(tn => tn.Nodes.Cast<TreeNode>()).Count();
			form.Close();
		}

		public static TreeView GetTreeViewEntitiesFromFrmEntitiesAndFields(Form form)
		{
			return form.GetAllContainedControls().First(c => c is TreeView) as TreeView;
		}
	}
}