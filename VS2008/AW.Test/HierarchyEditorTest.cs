using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	[TestClass]
	public class HierarchyEditorTest
	{
		[TestMethod]
		public void TestShowInTree()
		{
			var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
			TestShowInTree(employeeEntities, EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
		}

		[TestMethod]
		public void CanChangeParentInTree()
		{
			var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
			const int danWilsonsID = 128;
			var danWilsonsManagerID = employeeEntities.Single(e => e.EmployeeID == danWilsonsID).ManagerID;
			var employeeEntitiesWithWilsonManagerChanged = TestShowInTree(employeeEntities, EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
			Assert.AreNotEqual(danWilsonsManagerID, employeeEntitiesWithWilsonManagerChanged.Single(e => e.EmployeeID == danWilsonsID).ManagerID);
		}

		[TestMethod]
		public void TestShowSelfServicingInTree()
		{
			var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
			employeeEntities.ShowSelfServicingHierarchyInTree(EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
		}

		private static IEnumerable<T> TestShowInTree<T>(IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
		{
			var actual = enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn);
			Assert.AreEqual(enumerable, actual);
			CollectionAssert.AreEqual(enumerable.ToList(), actual.ToList());
			return actual;
		}
	}
}