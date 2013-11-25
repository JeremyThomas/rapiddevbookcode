using System.Linq;
using AW.Helper;
using AW.Helper.LLBL;

namespace AW.Data.Queries
{
  /// <summary>
  /// Queries used to demonstrate some bugs found in the LLBL LINQ provider
  /// </summary>
  public static class Bugs
  {
    /// <summary>
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    public static void SalesOrderHeader()
    {
      var query = from soh in MetaSingletons.MetaData.SalesOrderHeader
                  from sod in soh.SalesOrderDetails
                  select soh;

      var x = (from soh in query
               select new {soh.SalesOrderID, soh.Customer.AccountNumber, soh.CreditCard.CardNumber}).ToList();


      query = from soh in MetaSingletons.MetaData.SalesOrderHeader select soh;

      var w = (from soh in query
               from sod in soh.SalesOrderDetails
               select new { soh.SalesOrderID, soh.Customer.AccountNumber, soh.CreditCard.CardNumber }).ToList();
    }

    public static void MultipleTableJoins()
    {
      var query = from soh in MetaSingletons.MetaData.SalesOrderHeader
                  from sod in soh.SalesOrderDetails
                  where sod.SalesOrderID > 10
                  select soh;

      var w = (from soh in query
               from sod3 in soh.SalesOrderDetails
               select soh).Take(1).ToEntityCollection();

      var c = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddresses in Address.EmployeeAddresses
              select Address;

      var x = from Address in c
              from EmployeeAddresses in Address.EmployeeAddresses
              from SalesOrderHeader in Address.SalesOrderHeaders.DefaultIfEmpty()
              select Address;
      x.ToEntityCollection();
    }

    public static void EmployeeAddresses()
    {
      var c = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddresses in Address.EmployeeAddresses
              from Individual in EmployeeAddresses.Employee.Contact.Individuals
              select Address;

      c.ToEntityCollection(); //ORMRelationException: Relation at index 1 doesn't contain an entity already added to the FROM clause. Bad alias?
      //http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15159

      var x = from CountryRegion in MetaSingletons.MetaData.CountryRegion
              from StateProvince in CountryRegion.StateProvinces
              from Address in StateProvince.Addresses
              from EmployeeAddresses in Address.EmployeeAddresses
              from Individual in EmployeeAddresses.Employee.Contact.Individuals
              select CountryRegion;
      x.ToEntityCollection();

      var f = from Address in MetaSingletons.MetaData.Address
              select new {Address.StateProvince.Name};

      f.ToList();

      //var d = from address in MetaSingletons.MetaData.Address
      //        join employeeAddresses in MetaSingletons.MetaData.EmployeeAddress on address.AddressID equals EmployeeAddresses.AddressID
      //        join individual in MetaSingletons.MetaData.Individual on EmployeeAddresses.Employee.Contact.ContactId equals individual.ContactID
      //        //where EmployeeAddresses.Employee.Contact != null
      //        select address;
      //d.ToEntityCollection();

      var q = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddresses in Address.EmployeeAddresses
              select EmployeeAddresses.Employee.Contact;
      q.ToEntityCollection();

      var g = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddresses in Address.EmployeeAddresses
              select EmployeeAddresses.Employee.Contact.Phone;

      g.ToList();     

    }

    /// <summary>
    /// Fails with a ORMQueryConstructionException.
    /// </summary>
    public static void EmployeeAddressesEmployeeContactIndividuals()
    {
      var k=  from EmployeeAddresses in MetaSingletons.MetaData.EmployeeAddress
             select EmployeeAddresses.Employee.Contact.Individuals;

      k.ToList(); //Application_ThreadException: SD.LLBLGen.Pro.ORMSupportClasses.ORMQueryConstructionException: A nested query relies on a correlation filter which refers to the field 'EmployeeID', however this field wasn't found in the projection of the entity.

      var h = from address in MetaSingletons.MetaData.Address
              from EmployeeAddresses in address.EmployeeAddresses
              select EmployeeAddresses.Employee.Contact.Individuals;

      h.ToList();
    }

    /// <summary>
    /// Test fetching the CustomerID, SalesOrderID, AddressId of all customers which have addresses and may have orders
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14210
    /// </summary>
    public static IQueryable LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder(int maxNumberOfItemsToReturn)
    {
      var customers = MetaSingletons.MetaData.Customer.AsQueryable();
      //var customersDerivedTable = customers.Select(customer => customer);
      var customersDerivedTable = from customer in customers select customer; //Using this to force a derived table causes a crash
      customersDerivedTable = customers.Where(c => c.CustomerID > 10); //To force a derived table

//      var q = AWHelper.MetaData.Customer.SelectMany(customer => Customer.CustomerAddresses, (customer, ca) => new {customer, ca}).GroupJoin(AWHelper.MetaData.SalesOrderHeader, @t => @t.customer.CustomerID, soh => soh.CustomerID, (@t, oc) => new {@t, oc}).SelectMany(@t => @t.oc.DefaultIfEmpty(), (@t, nullableSOH) => new {@t.@t.customer.CustomerID, @t.@t.ca.AddressId, nullableSOH.SalesOrderID});
      GeneralHelper.TraceOut("ExplicitJoin with Derived Table");
      var q = from customer in customersDerivedTable
              join soh in
                (from s in MetaSingletons.MetaData.SalesOrderHeader where s.SalesPersonID > 22 select s) on customer.CustomerID equals soh.CustomerID into oc
              from nullableSOH in oc.DefaultIfEmpty()
              from ca in customer.CustomerAddresses.DefaultIfEmpty()
              select new { customer.CustomerID, ca.AddressID, nullableSOH.SalesOrderID, customer.SalesTerritory.Name };
      if (maxNumberOfItemsToReturn > 0)
        q = q.Distinct().Take(maxNumberOfItemsToReturn);

      var q4 = from customer in customers
               from soh in customer.SalesOrderHeaders.Where(soh => soh.SalesOrderID < 10).DefaultIfEmpty()
               select new { customer.CustomerID, soh.SalesOrderID };
      if (maxNumberOfItemsToReturn > 0)
        q4 = q4.Take(maxNumberOfItemsToReturn);
      var x = q4.ToList();

      return q;
    }
  }
}