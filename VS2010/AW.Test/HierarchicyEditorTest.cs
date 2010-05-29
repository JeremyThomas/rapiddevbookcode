using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	[TestClass]
	public class HierarchicyEditorTest
	{
		[TestMethod]
		public void TestShowInTree()
		{
			var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
			TestShowInTree(employeeEntities, EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
		}

		private static void TestShowInTree<T>(IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
		{
			var actual = enumerable.ShowHierarchicyInTree(iDPropertyName, parentIDPropertyName, nameColumn);
			Assert.AreEqual(enumerable, actual);
		}
	}
}
