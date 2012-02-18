using System;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

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
			                                  select new {e.EmployeeID, i.CustomerID};
			queryableWithAliasException.ToList();
		}

		///http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=18176
		[TestMethod, Description("SQL exception on last line")]
		public void NestedQueryOnTotheSameEntityTwiceTest()
		{
			var q = (from soh in MetaSingletons.MetaData.SalesOrderHeader
			         //	where  soh.SalesOrderID < 43690
			         from sod in soh.SalesOrderDetails
			         select new
			                	{
			                		soh.SalesOrderID,
			                		sod.SalesOrderDetailID,
			                		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).ProductModel.Name
			                	});
			var result = q.Where(x => x.SalesOrderID < 43690).ToList();

			var q1 = (from soh in MetaSingletons.MetaData.SalesOrderHeader
			          from sod in soh.SalesOrderDetails
			          select new
			                 	{
			                 		soh.SalesOrderID,
			                 		sod.SalesOrderDetailID,
			                 		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).ProductModel.CatalogDescription
			                 	});

			var result1 = q1.Where(x => x.SalesOrderID < 43690).ToList();

			var qwithProductModelJoin = (from soh in MetaSingletons.MetaData.SalesOrderHeader
			                             from sod in soh.SalesOrderDetails
			                             select new
			                                    	{
			                                    		soh.SalesOrderID,
			                                    		sod.SalesOrderDetailID,
			                                    		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).ProductModel.Name,
			                                    		(
			                                    			from p in MetaSingletons.MetaData.Product
			                                    			where p.ProductID == sod.ProductID
			                                    			join pm in MetaSingletons.MetaData.ProductModel on p.ProductID equals pm.ProductModelID
			                                    			select pm
			                                    		).First().CatalogDescription			                                    		
			                                    		//MetaSingletons.MetaData.Product.Where(p => p.ProductID == sod.ProductID)
			                                    		//.Join(MetaSingletons.MetaData.ProductModel, p => p.ProductID, pm => pm.ProductModelID, (p, pm) => pm).First().CatalogDescription
			                                    	});
			qwithProductModelJoin.Where(x => x.SalesOrderID < 43690).ToList();

			var qfail = (from soh in MetaSingletons.MetaData.SalesOrderHeader
			             from sod in soh.SalesOrderDetails
			             select new
			                    	{
			                    		soh.SalesOrderID,
			                    		sod.SalesOrderDetailID,
			                    		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).ProductModel.CatalogDescription,
			                    		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).ProductModel.Name
			                    	});
			qfail.Where(x => x.SalesOrderID < 43690).ToList();
			//SD.LLBLGen.Pro.ORMSupportClasses.ORMQueryExecutionException: An exception was caught during the execution of a retrieval query: The multi-part identifier "LPLA_6.CatalogDescription" could not be bound.
		}

		[TestMethod, Description("NullReferenceException in LLBLGenProProvider.ExecuteEntityProjection - Remove the 'where' or the '.Name' or enable the 'orderby' and there will be no exception")]
		public void NullExceptionTest()
		{
			var q = (from soh in MetaSingletons.MetaData.SalesOrderHeader
			         where soh.SalesOrderID < 43690
			         from sod in soh.SalesOrderDetails
			         //orderby soh.SalesOrderID
			         select new
			                	{
			                		soh.SalesOrderID,
			                		sod.SalesOrderDetailID,
			                		MetaSingletons.MetaData.Product.First(p => p.ProductID == sod.ProductID).Name,
			                	});
			q.ToList(); //System.NullReferenceException: Object reference not set to an instance of an object.
		}

		[TestMethod, Description("The multi-part identifier LPLA_4.ContactID could not be bound when doing a nested query with a predicate involving an entity hop")]
		public void NestedQueryUsingFirst()
		{
			var k = from employeeAddress in MetaSingletons.MetaData.EmployeeAddress
			        //let employee = employeeAddress.Employee
			        select new
			               	{
			               		employeeAddress.Employee.Contact.FirstName,
			               		//this is fine
			               		//MetaSingletons.MetaData.Employee.First(e => e.EmployeeID == employeeAddress.EmployeeID).Contact.MiddleName,
			               		//MetaSingletons.MetaData.Contact.First(c => c.ContactID == employee.ContactID).LastName,
			               		MetaSingletons.MetaData.Contact.First(c => c.ContactID == employeeAddress.Employee.ContactID).LastName //getting similar field using a nested query
			               	};

			k.ToList(); //The multi-part identifier "LPLA_4.ContactID" could not be bound.
		}

		[TestMethod]
		public void BiDirectionalManyToMany()
		{
			// first time
			var contact = MetaSingletons.MetaData.Contact.WithPath(new PathEdge<ShipMethodEntity>(ContactEntity.PrefetchPathStores)).First();
			Assert.AreNotEqual(0, contact.Stores.Count);

			Assert.AreEqual(1, contact.Stores.First().Contacts.Count);
			Assert.AreEqual(contact, contact.Stores.First().Contacts.Single());
		}


		[TestMethod]
		public void TestMultipleRelationsToTheSameTable()
		{
			var productProjection = from p in MetaSingletons.MetaData.Product
			                        where p.SizeUnitMeasure != null
			                        select new
			                               	{
			                               		SizeUnitMeasureCodeViaNav = p.SizeUnitMeasure.UnitMeasureCode,
			                               		UnitMeasureName = p.SizeUnitMeasure.Name,
			                               		WeightUnitMeasureCodeViaNav = p.WeightUnitMeasure.UnitMeasureCode,
			                               		UnitMeasure_Name = p.WeightUnitMeasure.Name,
			                               		p.Name,
			                               		p.ProductID,
			                               		p.ProductNumber,
			                               		p.SizeUnitMeasureCode,
			                               		p.WeightUnitMeasureCode
			                               	};
			var firstProductProjection = productProjection.First();
			Assert.AreEqual(firstProductProjection.SizeUnitMeasureCode, firstProductProjection.SizeUnitMeasureCodeViaNav);
			Assert.AreEqual(firstProductProjection.WeightUnitMeasureCode, firstProductProjection.WeightUnitMeasureCodeViaNav);
		}

		/// <summary>
		/// Problem with projection with multiple ManyToOne navigations to any entity and further ManyToOne navigation from that entity.
		/// http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=20148
		/// </summary>
		[TestMethod, Description("Tests entity A with multiple ManyToOne relations to entity B" +
														 "(which itself has a ManyToOne relation to entity C) can navigate to C (via all the navigators to B) correctly")]
		public void TestMultipleRelationsToTheSameTableWithHopToRelated()
		{
			var billOfMaterialProjection = from b in MetaSingletons.MetaData.BillOfMaterial
			                               where b.BillOfMaterialsID == 1404
			                               select new
			                                      	{
			                                      		b.BillOfMaterialsID,
			                                      		b.UnitMeasureCode,
			                                      		b.ComponentID,
			                                      		ProductComponentSubcategoryID = b.ProductComponent.ProductSubcategoryID,
			                                      		ProductComponentSubcategoryIDViaNav = b.ProductComponent.ProductSubcategory.ProductSubcategoryID,
			                                      		b.ProductAssemblyID,
			                                      		ProductAssemblySubcategoryID = b.ProductAssembly.ProductSubcategoryID,
			                                      		ProductAssemblySubcategoryIDViaNav = b.ProductAssembly.ProductSubcategory.ProductSubcategoryID,
			                                      	};
			var firstBillOfMaterialProjectionProjection = billOfMaterialProjection.First();
			Assert.AreEqual(firstBillOfMaterialProjectionProjection.ProductComponentSubcategoryID,
			                firstBillOfMaterialProjectionProjection.ProductComponentSubcategoryIDViaNav, "ProductComponentSubcategoryID");
			Assert.AreEqual(firstBillOfMaterialProjectionProjection.ProductAssemblySubcategoryID,
			                firstBillOfMaterialProjectionProjection.ProductAssemblySubcategoryIDViaNav, "ProductAssemblySubcategoryID"); //Fails
		}

		[TestMethod]
		public void GetFactoryTest()
		{
			var programFilesPathx86 = Environment.GetEnvironmentVariable("ProgramFiles(x86)") ?? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			var interceptorAssembly = Assembly.LoadFrom(Path.Combine(Path.Combine(programFilesPathx86, ProfilerHelper.SolutionsDesignOrmProfilerPath), ProfilerHelper.OrmProfilerAssemblyFileName));
			var type = interceptorAssembly.GetType(ProfilerHelper.OrmProfilerInterceptorTypeName);
			Assert.IsNotNull(type);
			DbProviderFactories.GetFactory("System.Data.SqlClient");
			MetaDataHelper.AddLoadedAssemblyResolverIfNeeded(interceptorAssembly);
			ProfilerHelper.InterceptorCoreInitialize(type);
			DbProviderFactories.GetFactory("System.Data.SqlClient");
		}
	}
}