using System.Linq;
using System.Linq.Dynamic;
using AW.Data;
using AW.Data.Queries;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	/// <summary>
	///This is a test class to execute Queries that demonstrate some bugs found in the LLBL LINQ provider
	///</summary>
	[TestClass]
	public class BugsTest
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

		[TestMethod, Description("A test for LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder")]
		public void LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrderTest()
		{
			const int maxNumberOfItemsToReturn = 5;
			var leftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder = Bugs.LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder(maxNumberOfItemsToReturn);
			Assert.AreEqual(maxNumberOfItemsToReturn, leftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder.Count());
		}

		[TestMethod, Description("A test for MultipleTableJoins")]
		public void MultipleTableJoinsTest()
		{
			Bugs.MultipleTableJoins();
		}

		[TestMethod, Description("A test for EmployeeAddresses")]
		public void EmployeeAddressesTest()
		{
			Bugs.EmployeeAddresses();
		}

		[TestMethod, Description("A test for SalesOrderHeader")]
		public void SalesOrderHeaderTest()
		{
			Bugs.SalesOrderHeader();
		}

		[TestMethod,
		 Description("Fails with: SD.LLBLGen.Pro.ORMSupportClasses.ORMQueryConstructionException: A nested query relies on a correlation filter which refers to the field 'EmployeeID', however this field wasn't found in the projection of the entity..	")]
		public void EmployeeAddressesEmployeeContactIndividualsTest()
		{
			Bugs.EmployeeAddressesEmployeeContactIndividuals();
		}

		[TestMethod, Description("")]
		public void CountryRegionTest()
		{
			var query = from countryRegion in MetaSingletons.MetaData.CountryRegion
			            from stateProvince in countryRegion.StateProvinces
			            select new
			                   	{
			                   		countryRegion.Name,
			                   		cities = (from address in stateProvince.Addresses
			                   		          select address.City).Distinct().JoinAsString()
			                   	};
			query.ToList();
		}

		[TestMethod, Description("The multi-part identifier LPLA_2.ContactID could not be bound.")]
		public void EmployeeIndividualOuterJoinTest()
		{
			var queryableWithInnerJoin = from e in MetaSingletons.MetaData.Employee
			                             from i in e.Contact.Individuals.DefaultIfEmpty()
			                             select new {e.EmployeeID, i.CustomerID};
			queryableWithInnerJoin.ToList();

			var queryableWithLeftJoin = from e in MetaSingletons.MetaData.Employee
			                            join i in MetaSingletons.MetaData.Individual on e.ContactID equals i.ContactID into individuals
			                            from i in individuals
			                            select new {e.EmployeeID, i.CustomerID};
			queryableWithLeftJoin.ToList();

			var queryableWithAliasException = from e in MetaSingletons.MetaData.Employee
																				join i in MetaSingletons.MetaData.Individual on e.Contact.ContactID equals i.ContactID into individuals
																				from i in individuals
																				select new { e.EmployeeID, i.CustomerID };
			queryableWithAliasException.ToList();
		}
	}
}