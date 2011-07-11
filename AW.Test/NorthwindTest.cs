using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	public class CustomerVM
	{
		public string Address { get; private set; }

		public string City { get; private set; }

		public string CompanyName { get; private set; }

		public string ContactName { get; private set; }

		public string ContactTitle { get; private set; }

		public string Country { get; private set; }

		public string CustomerId { get; private set; }

		public string Fax { get; private set; }

		public string Phone { get; private set; }

		public string PostalCode { get; private set; }

		public string Region { get; private set; }

		public CustomerVM(string address, string city, string companyName, string contactName, string contactTitle, string country, string customerId, string fax, string phone, string postalCode, string region)
		{
			Address = address;
			City = city;
			CompanyName = companyName;
			ContactName = contactName;
			ContactTitle = contactTitle;
			Country = country;
			CustomerId = customerId;
			Fax = fax;
			Phone = phone;
			PostalCode = postalCode;
			Region = region;
		}

		public override string ToString()
		{
			var builder = new StringBuilder();
			builder.Append("{ Address = ");
			builder.Append(Address);
			builder.Append(", City = ");
			builder.Append(City);
			builder.Append(", CompanyName = ");
			builder.Append(CompanyName);
			builder.Append(", ContactName = ");
			builder.Append(ContactName);
			builder.Append(", ContactTitle = ");
			builder.Append(ContactTitle);
			builder.Append(", Country = ");
			builder.Append(Country);
			builder.Append(", CustomerId = ");
			builder.Append(CustomerId);
			builder.Append(", Fax = ");
			builder.Append(Fax);
			builder.Append(", Phone = ");
			builder.Append(Phone);
			builder.Append(", PostalCode = ");
			builder.Append(PostalCode);
			builder.Append(", Region = ");
			builder.Append(Region);
			builder.Append(" }");
			return builder.ToString();
		}

		public override bool Equals(object value)
		{
			var type = value as CustomerVM;
			return (type != null) && EqualityComparer<string>.Default.Equals(type.Address, Address) && EqualityComparer<string>.Default.Equals(type.City, City) && EqualityComparer<string>.Default.Equals(type.CompanyName, CompanyName) &&
			       EqualityComparer<string>.Default.Equals(type.ContactName, ContactName) && EqualityComparer<string>.Default.Equals(type.ContactTitle, ContactTitle) && EqualityComparer<string>.Default.Equals(type.Country, Country) &&
			       EqualityComparer<string>.Default.Equals(type.CustomerId, CustomerId) && EqualityComparer<string>.Default.Equals(type.Fax, Fax) && EqualityComparer<string>.Default.Equals(type.Phone, Phone) &&
			       EqualityComparer<string>.Default.Equals(type.PostalCode, PostalCode) && EqualityComparer<string>.Default.Equals(type.Region, Region);
		}

		public override int GetHashCode()
		{
			var num = 0x7a2f0b42;
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Address);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(City);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(CompanyName);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(ContactName);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(ContactTitle);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Country);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(CustomerId);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Fax);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Phone);
			num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(PostalCode);
			return (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Region);
		}
	}

	/// <summary>
	/// Summary description for NorthwindTest
	/// </summary>
	[TestClass]
	public class NorthwindTest
	{
		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext { get; set; }

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
			return new LinqMetaData {AdapterToUse = new DataAccessAdapter()};
		}

		[TestMethod, Description("tests whether you can have a typed null field in a anonymous projection")]
		public void CustomerAnonProjection()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                select new {c.Address, c.City, CompanyName = (string) null, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region};
			queryable.ToList();
		}

		[TestMethod, Description("tests whether you can pass a null parameter to a constructor in a projection")]
		public void CustomerVMProjection()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                select new CustomerVM(c.Address, c.City, null, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region);
			queryable.ToList();
		}

		/// <summary>
		/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256"/>
		/// </summary>
		[TestMethod, Description("tests whether you Left Join from Customer to CustomerDemographic")]
		public void CustomerLeftJoinCustomerDemographic()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                from ccd in c.CustomerCustomerDemos.DefaultIfEmpty()
			                select new {c.ContactName, ccd.CustomerId, ccd.CustomerDemographic.CustomerDesc};
			var result = queryable.ToList();
			Assert.AreEqual(1, result.Count);
		}

		/// <summary>
		/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256"/>
		/// </summary>
		[TestMethod, Description("tests whether you Left Join from Customer to CustomerDemographic")]
		public void CustomerExpicitLeftJoinCustomerDemographic()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                from ccd in c.CustomerCustomerDemos.DefaultIfEmpty()
			                join cd in GetNorthwindLinqMetaData().CustomerDemographic on ccd.CustomerTypeId equals cd.CustomerTypeId into customerDemographics
			                from cd in customerDemographics.DefaultIfEmpty()
			                select new {c.ContactName, ccd.CustomerId, cd.CustomerDesc};
			var result = queryable.ToList();
			Assert.AreEqual(91, result.Count);
		}

		/// <summary>
		/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256"/>
		/// </summary>
		[TestMethod, Description("tests whether you Left Join from Customer to CustomerDemographic")]
		public void CustomerLeftJoinCustomerDemographicViaMany()
		{
			var queryable = from c in GetNorthwindLinqMetaData().Customer
			                from cd in c.CustomerDemographics.DefaultIfEmpty()
			                select new {c.ContactName, c.CustomerId, cd.CustomerDesc};
			var result = queryable.ToList();
			Assert.AreEqual(1, result.Count);
		}

		/// <summary>
		/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256"/>
		/// </summary>
		[TestMethod, Description("tests whether you Left Join from Customer to CustomerDemographic")]
		public void CustomerLeftJoinCustomerDemographicLinqToObject()
		{
			var cus = GetNorthwindLinqMetaData().Customer.PrefetchCustomerCustomerDemoCustomerDemographic().ToEntityCollection2();
			var cusproj = from c in cus
			              from ccd in c.CustomerCustomerDemos.DefaultIfEmpty()
			              select
			              	new
			              		{
			              			c.ContactName,
			              			CustomerId = ccd == null ? null : ccd.CustomerId,
			              			CustomerDesc = ccd == null ? null : ccd.CustomerDemographic.CustomerDesc
			              		};
			Assert.AreEqual(91, cusproj.Count());
		}

		/// <summary>
		/// Tests whether a second m:n prefetch results in duplicate
		/// </summary>
		[TestMethod]
		public void ManyToManyPrefetchContextBugTest()
		{
			AssertOneCustomerDemographicAfterSecondPrefetch(null); //Passes
			AssertOneCustomerDemographicAfterSecondPrefetch(new Context()); //Fails
		}

		/// <summary>
		/// Tests that there is only one CustomerDemographic after a second prefetch
		/// CustomerCustomerDemo Table has 1 row: ALFKI 1          
		/// CustomerDemographic Table has 1 row: xxx 1
		/// </summary>
		/// <param name="contextToUse">The context to use.</param>
		private static void AssertOneCustomerDemographicAfterSecondPrefetch(Context contextToUse)
		{
			var northwindLinqMetaData = GetNorthwindLinqMetaData();
			northwindLinqMetaData.ContextToUse = contextToUse;
			const string alfki = "ALFKI";
			AssertOneCustomerDemographicAfterPrefetch(northwindLinqMetaData, alfki);
			AssertOneCustomerDemographicAfterPrefetch(northwindLinqMetaData, alfki);
		}

		private static void AssertOneCustomerDemographicAfterPrefetch(LinqMetaData northwindLinqMetaData, string alfki)
		{
			var cus = northwindLinqMetaData.Customer.PrefetchCustomerCustomerDemographic().Where(c => c.CustomerId == alfki).Single();
			Assert.AreEqual(alfki, cus.CustomerId);
			Assert.AreEqual(1, cus.CustomerDemographics.Count());
			if (northwindLinqMetaData.ContextToUse != null) 
				northwindLinqMetaData.ContextToUse.Add(cus.CustomerDemographics);
		}

		[TestMethod]
		public void PrefetchWithContext()
		{
			var metaData = GetNorthwindLinqMetaData();
			metaData.ContextToUse = new Context();
			const string customerToSearch = "ALFKI";

			// first time
			var customer = (from c in metaData.Customer
			                where c.CustomerId == customerToSearch
			                select c)
				.WithPath(new PathEdge<EmployeeEntity>(CustomerEntity.PrefetchPathEmployeesViaOrders))
				.Single();
			Assert.AreEqual(customerToSearch, customer.CustomerId);
			var employeesCountToTest = customer.EmployeesViaOrders.Count;

			// add the related collection to the context
			metaData.ContextToUse.Add(customer.EmployeesViaOrders);

			//Assert.AreEqual(1, customer.EmployeesViaOrders.First().CustomersViaOrders);

			// second time
			customer = (from c in metaData.Customer
			            where c.CustomerId == customerToSearch
			            select c)
				.WithPath(new PathEdge<EmployeeEntity>(CustomerEntity.PrefetchPathEmployeesViaOrders))
				.Single();
			Assert.AreEqual(customerToSearch, customer.CustomerId);
			Assert.AreEqual(employeesCountToTest, customer.EmployeesViaOrders.Count);
		}

		/// <summary>
		/// http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19954
		/// </summary>
		[TestMethod, Ignore, Description("After a prefetch of a ManyToMany relationship can I navigate to an entity at the end of that relationship then navigate back to the root entity")]
		public void BiDirectionalManyToMany()
		{
			var metaData = GetNorthwindLinqMetaData();
			var customer = metaData.Customer
				.WithPath(new PathEdge<EmployeeEntity>(CustomerEntity.PrefetchPathEmployeesViaOrders))
				.First();
			Assert.AreNotEqual(0, customer.EmployeesViaOrders.Count);

			Assert.AreEqual(1, customer.EmployeesViaOrders.First().CustomersViaOrders.Count); //Fails
		}

		[TestMethod, Description("After a prefetch of a  1:n intermediate m:1 relationship can I navigate to an entity at the end of that relationship then navigate back to the root entity")]
		public void BiDirectionalManyToManyInCode()
		{
			var metaData = GetNorthwindLinqMetaData();
			var customer = metaData.Customer
				.WithPath(new PathEdge<OrderEntity>(CustomerEntity.PrefetchPathOrders, new PathEdge<EmployeeEntity>(OrderEntity.PrefetchPathEmployee)))
				.First();
			Assert.AreNotEqual(0, customer.Orders.Count);
			Assert.AreNotEqual(0, customer.EmployeesViaOrdersInCode.Count());

			Assert.AreEqual(1, customer.EmployeesViaOrdersInCode.First().CustomersViaOrdersInCode.Count());
			Assert.AreEqual(customer, customer.EmployeesViaOrdersInCode.First().CustomersViaOrdersInCode.Single());
		}

		[TestMethod]
		public void BiDirectionalOneToMany()
		{
			var metaData = GetNorthwindLinqMetaData();
			var customer = metaData.Customer
				.WithPath(new PathEdge<OrderEntity>(CustomerEntity.PrefetchPathOrders))
				.First();
			Assert.AreNotEqual(0, customer.Orders.Count);

			Assert.AreEqual(customer, customer.Orders.First().Customer);
		}
	}
}