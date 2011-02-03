using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.Linq;

namespace AW.Tests
{
	/// <summary>
	/// Summary description for NorthwindTest
	/// </summary>
	[TestClass]
	public class NorthwindTest
	{
		public NorthwindTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		public static LinqMetaData GetNorthwindLinqMetaData()
		{
			return new LinqMetaData { AdapterToUse = new Northwind.DAL.SqlServer.DataAccessAdapter() };
		}

		[TestMethod]
		public void CustomerAnonProjection()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                select new {c.Address, c.City, c.CompanyName, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region};
			queryable.ToList();
		}
	}
}
