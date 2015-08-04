using System.Linq;
using System.Linq.Dynamic;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.Linq;
using AW.Data.Linq.Filters;
using AW.Data.Queries;
using AW.Data.ViewModels;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class to execute Queries that demonstrate some bugs found in the LLBL LINQ provider
  /// </summary>
  [TestClass]
  public class BugsTest
  {
    /// <summary>
    ///   Gets or sets the test context which provides
    ///   information about and functionality for the current test run.
    /// </summary>
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

    [TestProperty("Bug", "UnFixed"), TestMethod, TestCategory("Failing"),
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

    [TestProperty("Bug", "UnFixed"), TestCategory("Failing"), TestMethod, Description("The multi-part identifier LPLA_2.ContactID could not be bound.")]
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

    /// http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=18176
    [TestProperty("Bug", "UnFixed"), TestCategory("Failing"), TestMethod, Description("SQL exception on last line")]
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

    [TestProperty("Bug", "Fixed"), TestMethod, Description("NullReferenceException in LLBLGenProProvider.ExecuteEntityProjection - Remove the 'where' or the '.Name' or enable the 'orderby' and there will be no exception")]
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

    [TestProperty("Bug", "UnFixed"), TestCategory("Failing"), TestMethod, 
    Description("The multi-part identifier LPLA_4.ContactID could not be bound when doing a nested query with a predicate involving an entity hop")]
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
    ///   Problem with projection with multiple ManyToOne navigations to any entity and further ManyToOne navigation from that
    ///   entity.
    ///   http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=20148
    /// </summary>
    [TestProperty("Bug", "Fixed"), TestMethod, Description("Tests entity A with multiple ManyToOne relations to entity B" +
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

    /// <summary>
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=21371
    /// </summary>
    [TestMethod, TestProperty("Bug", "Fixed"), Description("LINQ - Invalid SQL when prefetch comes before criteria")]
    public void TestPrefetchBeforeCriteria()
    {
      MetaSingletons.MetaData.Customer.FilterBySalesPersonID(275).PrefetchCustomerAddresses().EmptySelect().ToEntityCollection(); //OK with prefetch
      MetaSingletons.MetaData.Customer.PrefetchCustomerAddresses().FilterBySalesPersonID(275).ToEntityCollection(); //OK but prefetch ignored
      MetaSingletons.MetaData.Customer.EmptySelect().PrefetchCustomerAddresses().FilterBySalesPersonID(275).ToEntityCollection(); //This one fails
    }

    /// <summary>
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=23043
    /// </summary>
    [TestMethod, TestProperty("Bug", "Fixed"), Description("LINQ - Invalid SQL when AnyOnSubtypeWithContainsAndWhere")]
    public void AnyOnSubtypeWithContainsAndWhere()
    {
      var ids = new[] { 43659, 43660, 43661};
      Assert.IsTrue(MetaSingletons.MetaData.Customer.FilterBySalesOrderIDs(ids).Where(x => x.SalesTerritory.CountryRegionCode == "US").Any());
      // Fails ORMRelationException: Relation at index 1 doesn't contain an entity already added to the FROM clause. Bad alias?
      //Assert.IsFalse(MetaSingletons.MetaData.Customer.FilterBySalesOrderIDs(ids).Any(x => x.SalesTerritory.CountryRegionCode == "US"));
    }

    [TestMethod, TestProperty("Bug", "UnFixed"), TestCategory("Failing"), Description("LINQ -  let followed by a projection followed by an ordering")]
    public void TestLetProjectionOrdering()
    {
      var transactionHistoryEntities = MetaSingletons.MetaData.TransactionHistory.FilterByProductIDWithLet(1);
      var queryable = TransactionHistoryDto.TransactionHistoryDtoFactoryPropertyProjection(transactionHistoryEntities);
      queryable.OrderBy(th => th.ModifiedDate).ToList(); //Works

      queryable = TransactionHistoryDto.TransactionHistoryDtoFactoryPropertiesViaConstructor(transactionHistoryEntities);
      queryable.OrderBy(th => th.ModifiedDate).ToList(); //Doesn't

      queryable = TransactionHistoryDto.TransactionHistoryDtoFactoryEntityInstance(transactionHistoryEntities);
      queryable.OrderBy(th => th.ModifiedDate).ToList(); //Doesn't
    }

    [TestMethod, TestProperty("Bug", "Fixed"), Description("Discriminator filter missing when Entity Instance in projection")]
    //http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=21502
    public void TestInheritanceProjectionEntityInstance()
    {
      var queryable = TransactionHistoryDto.TransactionHistoryDtoFactoryEntityInstance(MetaSingletons.MetaData.TransactionHistory);
      queryable.ToList(); //Works

      queryable = TransactionHistoryDto.TransactionHistoryDtoFactoryEntityInstance(MetaSingletons.MetaData.SalesOrderHistory);
      queryable.ToList(); //no type filter

      queryable = from t in MetaSingletons.MetaData.SalesOrderHistoryTs
        select new TransactionHistoryDto(t);
      queryable.ToList(); //System.InvalidCastException: Unable to cast object of type 'AW.Data.EntityClasses.WorkOrderHistoryEntity' to type 'AW.Data.EntityClasses.SalesOrderHistoryEntity'.
    }

    [TestMethod, TestProperty("Bug", "Fixed"), Description("LINQ - Inheritance projection followed by a count")]
    //http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=21502
    public void TestInheritanceCounts()
    {
      const int productID = 1;
      var transactionHistoryCount = MetaSingletons.MetaData.TransactionHistory.Count();
      Assert.AreEqual(transactionHistoryCount, MetaSingletons.MetaData.WorkOrderHistory.Count()
                                               + MetaSingletons.MetaData.SalesOrderHistory.Count()
                                               + MetaSingletons.MetaData.PurchaseOrderHistory.Count());

      Assert.AreEqual(transactionHistoryCount, TransactionHistoryDto.TransactionHistoryDtoFactoryPropertyProjection(MetaSingletons.MetaData.WorkOrderHistoryTs).Count()
                                               + TransactionHistoryDto.TransactionHistoryDtoFactoryPropertyProjection(MetaSingletons.MetaData.SalesOrderHistoryTs).Count()
                                               + TransactionHistoryDto.TransactionHistoryDtoFactoryPropertyProjection(MetaSingletons.MetaData.PurchaseOrderHistoryTs).Count());

      var queryableLet = MetaSingletons.MetaData.TransactionHistory.FilterByProductIDWithLet(productID);
      var expectedCountLet = queryableLet.ToEntityCollection().Count;
      Assert.AreEqual(expectedCountLet, queryableLet.Count());
      Assert.AreEqual(expectedCountLet, MetaSingletons.MetaData.WorkOrderHistoryTs.FilterByProductIDWithLet(productID).Count()
                                        + MetaSingletons.MetaData.SalesOrderHistoryTs.FilterByProductIDWithLet(productID).Count()
                                        + MetaSingletons.MetaData.PurchaseOrderHistoryTs.FilterByProductIDWithLet(productID).Count());

      const string productNumber = "AR-5381";
      var queryableProductNumberLet = MetaSingletons.MetaData.TransactionHistory.FilterByProductNumberWithLet(productNumber);
      var expectedCountProductNumberLet = queryableProductNumberLet.ToEntityCollection().Count;
      Assert.AreEqual(expectedCountProductNumberLet, queryableProductNumberLet.Count());
      Assert.AreEqual(expectedCountProductNumberLet, MetaSingletons.MetaData.WorkOrderHistory.FilterByProductNumberWithLet(productNumber).Count()
                                                     + MetaSingletons.MetaData.SalesOrderHistory.FilterByProductNumberWithLet(productNumber).Count()
                                                     + MetaSingletons.MetaData.PurchaseOrderHistory.FilterByProductNumberWithLet(productNumber).Count());

      var queryableProductNumber = MetaSingletons.MetaData.TransactionHistory.FilterByProductNumber(productNumber);
      var expectedCountProductNumber = queryableProductNumber.ToEntityCollection().Count;
      Assert.AreEqual(expectedCountProductNumber, queryableProductNumberLet.Count());
      Assert.AreEqual(expectedCountProductNumber, MetaSingletons.MetaData.WorkOrderHistory.FilterByProductNumber(productNumber).Count()
                                                     + MetaSingletons.MetaData.SalesOrderHistory.FilterByProductNumber(productNumber).Count()
                                                     + MetaSingletons.MetaData.PurchaseOrderHistory.FilterByProductNumber(productNumber).Count());

      Assert.AreEqual(expectedCountProductNumber, MetaSingletons.MetaData.WorkOrderHistory.FilterByProductNumberWithJoin(productNumber).Count()
                                               + MetaSingletons.MetaData.SalesOrderHistory.FilterByProductNumberWithJoin(productNumber).Count()
                                               + MetaSingletons.MetaData.PurchaseOrderHistory.FilterByProductNumberWithJoin(productNumber).Count());
    }

    [TestMethod, TestProperty("Bug", "UnFixed"), TestCategory("Failing"), Description("LINQ Discriminator filter missing with Count when filtering on 1:M related table.")]
    //http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=23424
    public void TestInheritanceWithJoinCounts()
    {
      Assert.AreEqual(MetaSingletons.MetaData.SalesOrderHistory.Count(), ExplicitJoinWithProduct(MetaSingletons.MetaData.SalesOrderHistory).Count(), "ExplicitJoinWithProduct");
      const string productNumber = "AR-5381";
      var queryableProductNumber = MetaSingletons.MetaData.TransactionHistory.FilterByProductNumber(productNumber);
      var expectedCountProductNumber = queryableProductNumber.ToEntityCollection().Count;
      Assert.AreEqual(expectedCountProductNumber, MetaSingletons.MetaData.WorkOrderHistory.FilterByProductNumberWithJoin(productNumber).Count()
                                               + MetaSingletons.MetaData.SalesOrderHistory.FilterByProductNumberWithJoin(productNumber).Count()
                                               + MetaSingletons.MetaData.PurchaseOrderHistory.FilterByProductNumberWithJoin(productNumber).Count());
    }

    public static IQueryable<T> ExplicitJoinWithProduct<T>(IQueryable<T> transactionHistoryEntities) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
             join p in MetaSingletons.MetaData.Product on th.ProductID equals p.ProductID
             select th;
    }

    [TestMethod, TestProperty("Bug", "UnFixed"), TestCategory("Failing"), Description("LINQ Discriminator filter missing with Count when filtering on 1:M related table.")]
    //http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=23424
    public void TestInheritanceWithJoinAny()
    {
      Assert.AreEqual(MetaSingletons.MetaData.SalesOrderHistory.Any(), ExplicitJoinWithProduct(MetaSingletons.MetaData.SalesOrderHistory).Any(), "ExplicitJoinWithProduct");
    }

  }
}