using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL;
using Northwind.DAL.DTO;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.Linq.Filters;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  public class GroupByYear
  {
    public int Year { get; set; }
    public int Month { get; set; }
  }

  public class CountryRegion : KeyCount
  {
    public string ShipCountry { get; set; }
    public string ShipRegion { get; set; }
  }

  public class KeyCount
  {
    public object Key { get; set; }
    public int Count { get; set; }
  }

  /// <summary>
  ///   Summary description for NorthwindTest
  /// </summary>
  [TestClass]
  public class NorthwindTest
  {
    /// <summary>
    ///   Gets or sets the test context which provides information about and functionality for the current test run.
    /// </summary>
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
      return new LinqMetaData(new DataAccessAdapter(), DataAccessAdapter.StaticCustomFunctionMappings);
    }

    [TestMethod, Description("tests whether you can have a typed null field in a anonymous projection")]
    public void CustomerAnonProjection()
    {
      var queryable = from c in GetNorthwindLinqMetaData().Customer
        select new {c.Address, c.City, CompanyName = (string) null, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region};
      Assert.IsNotNull(queryable.ToList());
    }

    [TestMethod, Description("tests whether you can pass a null parameter to a constructor in a projection")]
    public void CustomerVMProjection()
    {
      var queryable = from c in GetNorthwindLinqMetaData().Customer
        select new CustomerVM(c.Address, c.City, null, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region);
      Assert.IsNotNull(queryable.ToList());
    }

    [TestMethod, Description("tests whether you can OrderBy after a Projection with Entity Instance")]
    public void CustomerVMProjectionEntityInstance()
    {
      var queryable = CustomerVM.CustomerVmFactoryEntityInstance(GetNorthwindLinqMetaData().Customer).OrderBy(c => c.City);
      Assert.IsNotNull(queryable.ToList());
    }

    [TestMethod, Description("tests whether you can OrderBy after a Projection with Entity Instance")]
    public void CustomerVMProjectionConstructor()
    {
      var queryable = CustomerVM.CustomerVmFactoryConstructor(GetNorthwindLinqMetaData().Customer).OrderBy(c => c.City);
      Assert.IsNotNull(queryable.ToList());
    }

    /// <summary>
    ///   <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256" />
    /// </summary>
    [TestProperty("Bug", "UnFixed"), TestMethod, Ignore, Description("tests whether you Left Join from Customer to CustomerDemographic")]
    public void CustomerLeftJoinCustomerDemographic()
    {
      var queryable = from c in GetNorthwindLinqMetaData().Customer
        from ccd in c.CustomerCustomerDemos.DefaultIfEmpty()
        select new {c.ContactName, ccd.CustomerId, ccd.CustomerDemographic.CustomerDesc};
      var result = queryable.ToList();
      Assert.AreEqual(1, result.Count);
    }

    /// <summary>
    ///   <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256" />
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
    ///   <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256" />
    /// </summary>
    [TestProperty("Bug", "UnFixed"), TestMethod, Ignore, Description("tests whether you Left Join from Customer to CustomerDemographic")]
    public void CustomerLeftJoinCustomerDemographicViaMany()
    {
      var queryable = from c in GetNorthwindLinqMetaData().Customer
        from cd in c.CustomerDemographics.DefaultIfEmpty()
        select new {c.ContactName, c.CustomerId, cd.CustomerDesc};
      var result = queryable.ToList();
      Assert.AreEqual(1, result.Count);
    }

    /// <summary>
    ///   <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19256" />
    /// </summary>
    [TestMethod, Description("tests whether you Left Join from Customer to CustomerDemographic")]
    public void CustomerLeftJoinCustomerDemographicLinqToObject()
    {
      var cus = GetNorthwindLinqMetaData().Customer.PrefetchCustomerCustomerDemosCustomerDemographic().ToEntityCollection2();
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
    ///   Tests whether a second m:n prefetch results in duplicate
    /// </summary>
    [TestMethod]
    public void ManyToManyPrefetchContextBugTest()
    {
      AssertOneCustomerDemographicAfterSecondPrefetch(null); //Passes
      AssertOneCustomerDemographicAfterSecondPrefetch(new Context()); //Fails
    }

    /// <summary>
    ///   Tests that there is only one CustomerDemographic after a second prefetch CustomerCustomerDemo Table has 1 row: ALFKI
    ///   1 CustomerDemographic Table has 1 row: xxx 1
    /// </summary>
    /// <param name="contextToUse"> The context to use. </param>
    private static void AssertOneCustomerDemographicAfterSecondPrefetch(Context contextToUse)
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      northwindLinqMetaData.ContextToUse = contextToUse;
      const string alfki = "ALFKI";
      if (!northwindLinqMetaData.CustomerDemographic.Any())
      {
        var customerDemographicEntity = new CustomerDemographicEntity("1") {CustomerDesc = "CustomerDesc"};
        var customerCustomerDemos = customerDemographicEntity.CustomerCustomerDemos.AddNew();
        customerCustomerDemos.CustomerId = alfki;
        northwindLinqMetaData.AdapterToUse.SaveEntity(customerDemographicEntity);
      }
      AssertOneCustomerDemographicAfterPrefetch(northwindLinqMetaData, alfki);
      AssertOneCustomerDemographicAfterPrefetch(northwindLinqMetaData, alfki);
    }

    private static void AssertOneCustomerDemographicAfterPrefetch(LinqMetaData northwindLinqMetaData, string alfki)
    {
      var cus = northwindLinqMetaData.Customer.PrefetchCustomerDemographics().Single(c => c.CustomerId == alfki);
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
        .PrefetchEmployeesViaOrders()
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
        .PrefetchEmployeesViaOrders()
        .Single();
      Assert.AreEqual(customerToSearch, customer.CustomerId);
      Assert.AreEqual(employeesCountToTest, customer.EmployeesViaOrders.Count);
    }

    /// <summary>
    ///   http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=19954
    /// </summary>
    [TestProperty("Bug", "UnFixed"), TestMethod, Ignore, Description("After a prefetch of a ManyToMany relationship can I navigate to an entity at the end of that relationship then navigate back to the root entity")]
    public void BiDirectionalManyToMany()
    {
      var metaData = GetNorthwindLinqMetaData();
      var customer = metaData.Customer.PrefetchEmployeesViaOrders().First();
      Assert.AreNotEqual(0, customer.EmployeesViaOrders.Count);

      Assert.AreEqual(1, customer.EmployeesViaOrders.First().CustomersViaOrders.Count); //Fails
    }

    [TestMethod, Description("After a prefetch of a  1:n intermediate m:1 relationship can I navigate to an entity at the end of that relationship then navigate back to the root entity")]
    public void BiDirectionalManyToManyInCode()
    {
      var metaData = GetNorthwindLinqMetaData();
      var customer = metaData.Customer.PrefetchOrdersEmployee().First();
      Assert.AreNotEqual(0, customer.Orders.Count);
      Assert.AreNotEqual(0, customer.EmployeesViaOrdersInCode.Count());

      Assert.AreEqual(1, customer.EmployeesViaOrdersInCode.First().CustomersViaOrdersInCode.Count());
      Assert.AreEqual(customer, customer.EmployeesViaOrdersInCode.First().CustomersViaOrdersInCode.Single());
    }

    [TestMethod]
    public void BiDirectionalOneToMany()
    {
      var metaData = GetNorthwindLinqMetaData();
      var customerEntities = metaData.Customer;
      var customer = customerEntities.PrefetchOrders().First();
      Assert.AreNotEqual(0, customer.Orders.Count);

      Assert.AreEqual(customer, customer.Orders.First().Customer);
    }

    /// <summary>
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=20595
    /// </summary>
    [TestMethod, Description("SQL bind exception with two Where predicates with the same Entity")]
    public void SQLBindExceptionWithTwoWherePredicatesWithTheSameEntity()
    {
      var metaData = GetNorthwindLinqMetaData();
      var employees = from e in metaData.Employee
        where e.Orders.Any(o => o.ShipCity == "Reims") || e.Orders.Any(o => o.ShipCity == "Lyon")
        select e;

      const int expected = 7;
      Assert.AreEqual(expected, employees.ToEntityCollection2().Count()); //This is ok
      Assert.AreEqual(expected, employees.Count());

      employees = from e in metaData.Employee
        from order in e.Orders
        from et in e.EmployeeTerritories
        where e.Orders.Any(o => o.ShipCity == "Reims") || e.Orders.Any(o => o.ShipCity == "Lyon")
        select e;

      Assert.AreEqual(expected, employees.ToEntityCollection2().Count()); //So is this
      Assert.AreEqual(expected, employees.CountColumn(e => e.EmployeeId, true));

      // This one throws 'The multi-part identifier "LPLA_4.EmployeeID" could not be bound.'
      employees = from e in metaData.Employee
        from et in e.EmployeeTerritories
        where e.Orders.Any(o => o.ShipCity == "Reims") || e.Orders.Any(o => o.ShipCity == "Lyon")
        select e;

      Assert.AreEqual(expected, employees.ToEntityCollection2().Count());
      Assert.AreEqual(expected, employees.CountColumn(e => e.EmployeeId, true));
    }

    [TestMethod, TestProperty("Bug", "UnFixed"), Ignore]
    public void PrefetchBeforeCriterea()
    {
      var metaData = GetNorthwindLinqMetaData();
      //var productEntities = (from c in metaData.Product.PrefetchOrderDetailOrderCustomer()
      //                       where c.Supplier.City == "xx" && c.UnitPrice == 100 
      //                       select c);
      metaData.Customer.FilterByCountry("NZ").FilterByEmployeeId(100).EmptySelect().PrefetchCustomerDemographics().ToEntityCollection2();
      metaData.Customer.PrefetchCustomerDemographics().FilterByEmployeeId(100).FilterByCountry("NZ").ToEntityCollection2();
      metaData.Customer.EmptySelect().PrefetchCustomerDemographics().FilterByEmployeeId(100).FilterByCountry("NZ").ToEntityCollection2();
    }

    [TestMethod]
    public void TestFilterByDiscontinued()
    {
      var metaData = GetNorthwindLinqMetaData();
      metaData.Product.FilterByDiscontinued(true).ToEntityCollection2();
      metaData.Product.FilterByDiscontinued(false).ToEntityCollection2();
      metaData.Product.FilterByDiscontinuedP(true).ToEntityCollection2();
      metaData.Product.FilterByDiscontinuedP(false).ToEntityCollection2();
      metaData.Product.FilterByDiscontinuedG(true).ToEntityCollection2();
      metaData.Product.FilterByDiscontinuedG(false).ToEntityCollection2();
    }

    [TestMethod, TestProperty("Bug", "UnFixed"), Ignore]
    public void TestFilterByProductName()
    {
      var metaData = GetNorthwindLinqMetaData();
      metaData.Product.FilterByProductName("FilterByProductName").ToEntityCollection2();
    }

    [TestMethod, Description("tests whether you can OrderBy after a projection when the field has a different name")]
    public void TestProductViewDto()
    {
      var queryable = ProductViewDto.ProductViewDtoFactoryPropertyProjection(GetNorthwindLinqMetaData().Product).OrderBy(p => p.ReorderLevelZzz);
      Assert.IsNotNull(queryable.ToList());

      queryable = ProductViewDto.ProductViewDtoFactoryPropertiesViaConstructor(GetNorthwindLinqMetaData().Product).OrderBy(p => p.ReorderLevelZzz);
      Assert.IsNotNull(queryable.ToList());

      var pagedQueryable = ProductViewDto.ProductViewDtoFactoryEntityInstance(GetNorthwindLinqMetaData().Product).OrderBy(p => p.UnitPrice).TakePage(2, 10);
      Assert.IsNotNull(pagedQueryable.ToList());
    }

    [TestMethod, Description("tests whether you can OrderBy after a projection")]
    public void TestEmployeeViewDto()
    {
      var employeeEntities = GetNorthwindLinqMetaData().Employee;
      var queryable = EmployeeViewDto.EmployeeViewDtoFactoryPropertyProjection(employeeEntities).OrderBy(e => e.FirstName);
      Assert.IsNotNull(queryable.ToList());

      queryable = EmployeeViewDto.EmployeeViewDtoFactoryPropertiesViaConstructor(employeeEntities).OrderBy(e => e.FirstName);
      Assert.IsNotNull(queryable.ToList());

      Assert.IsNotNull(EmployeeViewDto.EmployeeViewDtoFactoryEntityInstance(employeeEntities).OrderBy(e => e.FirstName).TakePage(2, 10).ToList());

      Assert.IsNotNull(EmployeeViewDto.EmployeeViewDtoFactoryPropertiesViaConstructor(employeeEntities.Where(e => e.City != "x").Where(e => e.City != "x")).OrderBy(e => e.FirstName).ToList());
      Assert.IsNotNull(EmployeeViewDto.EmployeeViewDtoFactoryEntityInstance(employeeEntities.EmptySelect().EmptySelect()).OrderBy(e => e.FirstName).TakePage(2, 10).ToList());
    }

    [TestMethod, Description("tests FilterByCustomerTypeId().FilterByManagersOrder(1)")]
    public void TestFilterByCustomerTypeIdFilterByManagersOrder()
    {
      var employeeEntities = GetNorthwindLinqMetaData().Employee;
      employeeEntities.FilterByCustomerTypeId("ALFKI").FilterByManagersOrder(1).ToEntityCollection2();
      employeeEntities.FilterByCustomerTypeIdViaOrders("ALFKI").FilterByOrder(1).ToEntityCollection2();
      employeeEntities.FilterByOrder(1).FilterByCustomerTypeIdViaOrders("ALFKI").ToEntityCollection2();
    }

    [TestMethod, Description("http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=21560")]
    public void TestFirstInWhereAndProjection()
    {
      var linqMetaData = GetNorthwindLinqMetaData();
      var orders = from o in linqMetaData.Order
        select new
        {
          o.CustomerId,
          o.OrderId,
        };

      var customers = from c in linqMetaData.Customer
        where c.CustomerId == orders.First().CustomerId
        select new
        {
          orders.First().OrderId,
          c.Address,
          c.City,
          c.CompanyName
        };
      customers.First();
    }

    [TestMethod, Description("http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=22376")]
    public void TestGroupByOrderDateYear()
    {
      var linqMetaData = GetNorthwindLinqMetaData();
      var ordersGroupedByYear = linqMetaData.Order.GroupBy(o => o.OrderDate.Value.Year);

      Assert.AreEqual(3, ordersGroupedByYear.Select(o => o.Key).Count());
      //Fails Assert.AreEqual(3, ordersGroupedByYear.Count());

      var ordersWithYear = from o in linqMetaData.Order
        select new {o.OrderDate.Value.Year, o};
      var ordersGroupedByYear2 = from o in ordersWithYear
        group o by o.Year
        into orderYear
        select orderYear;
      /// Assert.AreEqual(1, ordersGroupedByYear2.Count());
    }

    [TestMethod]
    public void TestGroupByOrderDatesNamedType()
    {
      var linqMetaData = GetNorthwindLinqMetaData();
      //IQueryable<IGrouping<object, OrderEntity>> ordersGroupedByYear = from o in linqMetaData.Order
      //  group o by new {o.OrderDate.Value.Year, o.OrderDate.Value.Month}
      //  into orderYear
      //  select orderYear;
      IQueryable<IGrouping<object, OrderEntity>> ordersGroupedByYear = linqMetaData.Order.GroupBy(o => new {o.OrderDate.Value.Year, o.OrderDate.Value.Month});

      Assert.AreEqual(23, ordersGroupedByYear.Select(o => o.Key).Count());

      var ordersGroupedByYearNamed = linqMetaData.Order.GroupBy(o => new GroupByYear {Year = o.OrderDate.Value.Year, Month = o.OrderDate.Value.Month});

      Assert.AreEqual(23, ordersGroupedByYearNamed.Select(o => new {o.Key.Year, o.Key.Month, count = o.Count()}).Count());
    }

    [TestMethod]
    public void TestGroupByOrderNamedType()
    {
      var linqMetaData = GetNorthwindLinqMetaData();
      //var ordersGroupedByCountry = from o in linqMetaData.Order
      //  group o by new CountryRegion {ShipCountry = o.ShipCountry, ShipRegion = o.ShipRegion}
      //  into orderCountry
      //  select orderCountry;
      var ordersGroupedByCountry = linqMetaData.Order.GroupBy(o => new CountryRegion {ShipCountry = o.ShipCountry, ShipRegion = o.ShipRegion});
      var ordersGroupedByCountryAnon = linqMetaData.Order.GroupBy(o => new {ShipCountry = o.ShipCountry, ShipRegion = o.ShipRegion});

      var ordersGroupedByCountryList = ordersGroupedByCountry.Select(o => new CountryRegion {ShipCountry = o.Key.ShipCountry, ShipRegion = o.Key.ShipRegion, Count = o.Count()}).ToList();
      Assert.AreEqual(35, ordersGroupedByCountryList.Count());

      var ordersGroupedByCountryList2Anon = ordersGroupedByCountryAnon.Select(o => new CountryRegion {ShipCountry = string.IsNullOrEmpty(o.Key.ShipCountry) ? "empty" : o.Key.ShipCountry}).ToList();
      Assert.AreEqual(35, ordersGroupedByCountryList2Anon.Count());
      var ordersGroupedByCountryList2 = ordersGroupedByCountry.Select(o => new CountryRegion {ShipCountry = string.IsNullOrEmpty(o.Key.ShipCountry) ? "empty" : o.Key.ShipCountry}).ToList();
      Assert.AreEqual(35, ordersGroupedByCountryList2.Count());

      var ordersGroupedByCountryKeyList = ordersGroupedByCountry.Select(o => new CountryRegion {Key = o.Key, Count = o.Count()}).ToList();
      Assert.AreEqual(35, ordersGroupedByCountryKeyList.Count());

      var ordersGroupedByCountryDynamic = (IQueryable<IGrouping<DynamicClass, OrderEntity>>) linqMetaData.Order.GroupBy("new(ShipCountry, ShipRegion)", "it");
      var countryRegions = new List<CountryRegion>();
      foreach (var grouping in ordersGroupedByCountryDynamic)
      {
        var countryRegion = new CountryRegion();
        dynamic countryRegionDyn = grouping.Key;
        countryRegion.ShipCountry = countryRegionDyn.ShipCountry;
        countryRegion.ShipRegion = countryRegionDyn.ShipRegion;
        countryRegions.Add(countryRegion);
      }
      var groupedByCountryWithCountDynamic = (IQueryable<DynamicClass>) ordersGroupedByCountryDynamic.Select("new(Key.ShipCountry, Key.ShipRegion, Count() as Count)");
      var groupedByCountryWithCountDynamicList = groupedByCountryWithCountDynamic.ToList();
      Assert.AreEqual(35, groupedByCountryWithCountDynamicList.Count());

      var groupedByCountryWithCount = ordersGroupedByCountryDynamic.Select(x => new {Key = x.Key, Count = x.Count()});

      var groupedByCountryWithCountList = groupedByCountryWithCount.ToList();

      //Assert.AreEqual(35, groupedByCountryWithCountList.Count());

      //MapKeysToProperties(groupedByCountryWithCountList, MapKeyToProperties);
    }

    private static void MapKeysToProperties(IEnumerable<CountryRegion> dynamicClasses, Action<CountryRegion> keyMapper)
    {
      foreach (var dynamicClass in dynamicClasses)
      {
        keyMapper(dynamicClass);
      }
    }

    private static void MapKeyToProperties(CountryRegion dynamicClass)
    {
      dynamic countryRegionDyn = dynamicClass.Key;
      dynamicClass.ShipCountry = countryRegionDyn.ShipCountry;
      dynamicClass.Count = dynamicClass.Count;
    }

    [TestMethod]
    public void TestGroupByOrderDynamic()
    {
      var linqMetaData = GetNorthwindLinqMetaData();
      var ordersGroupedByCountry = from o in linqMetaData.Order
        group o by o.ShipCountry;

      Assert.AreEqual(21, ordersGroupedByCountry.Select(o => o.Key).Count());
      var ordersGroupedByCountryDynamic = (IQueryable<IGrouping<object, OrderEntity>>) linqMetaData.Order.GroupBy(OrderFieldIndex.ShipCountry.ToString(), "it");

      Assert.AreEqual(21, ordersGroupedByCountryDynamic.Select(o => o.Key).Count());

      //    var ordersGroupedByCountryDynamic = linqMetaData.Order
      //.GroupBy(o => MetaDataHelper.GetPropertyValue(o, OrderFieldIndex.ShipCountry.ToString()))
      //.Select(orderCountry => orderCountry);

      //    Assert.AreEqual(21, ordersGroupedByCountryDynamic.Select(o => o.Key).Count());
    }
  }
}