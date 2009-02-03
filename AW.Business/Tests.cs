using System.Linq;
using AW.Data;

namespace AW.Business
{
  public static class Tests
  {
    /// <summary>
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    public static void Barf()
    {
      var query = from soh in MetaSingletons.MetaData.SalesOrderHeader
                  from sod in soh.SalesOrderDetail
                  select soh;

      var x = (from soh in query
               select new {soh.SalesOrderId, soh.Customer.AccountNumber, soh.CreditCard.CardNumber}).ToList();


      query = from soh in MetaSingletons.MetaData.SalesOrderHeader select soh;

      var w = (from soh in query
               from sod in soh.SalesOrderDetail
               select new {soh.SalesOrderId, soh.Customer.AccountNumber, soh.CreditCard.CardNumber}).ToList();
    }

    public static void BarfonMultipleTableJoins()
    {
      var query = from soh in MetaSingletons.MetaData.SalesOrderHeader
                  from sod in soh.SalesOrderDetail
                  where sod.SalesOrderId > 10
                  select soh;

      var w = (from soh in query
               from sod3 in soh.SalesOrderDetail
               select soh).Take(1).ToList();

      var c = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              select Address;

      var x = from Address in c
              from EmployeeAddress in Address.EmployeeAddress
              from SalesOrderHeader in Address.SalesOrderHeader.DefaultIfEmpty()
              select Address;
      x.ToList();
    }

    public static void Barf1()
    {
      var c = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              from Individual in EmployeeAddress.Employee.Contact.Individual
              select Address;

      c.ToList(); //ORMRelationException: Relation at index 1 doesn't contain an entity already added to the FROM clause. Bad alias?
      //http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15159

      var x = from CountryRegion in MetaSingletons.MetaData.CountryRegion
              from StateProvince in CountryRegion.StateProvince
              from Address in StateProvince.Address
              from EmployeeAddress in Address.EmployeeAddress
              from Individual in EmployeeAddress.Employee.Contact.Individual
              select CountryRegion;
      x.ToList();

      var f = from Address in MetaSingletons.MetaData.Address
              select new {Address.StateProvince.Name};

      f.ToList();

      //var d = from address in Validation.MetaData.Address
      //        join employeeAddress in Validation.MetaData.EmployeeAddress on address.AddressId equals employeeAddress.AddressId
      //        join individual in Validation.MetaData.Individual on employeeAddress.Employee.Contact.ContactId equals individual.ContactId
      //        //where employeeAddress.Employee.Contact != null
      //        select address;
      //d.ToList();

      var q = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              select EmployeeAddress.Employee.Contact;
      q.ToList();

      var g = from Address in MetaSingletons.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              select EmployeeAddress.Employee.Contact.Phone;

      g.ToList();

      var k = from employeeAddress in MetaSingletons.MetaData.EmployeeAddress
              select employeeAddress.Employee.Contact.Individual;

      k.ToList(); //Application_ThreadException: SD.LLBLGen.Pro.ORMSupportClasses.ORMQueryConstructionException: A nested query relies on a correlation filter which refers to the field 'EmployeeId', however this field wasn't found in the projection of the entity.

      var h = from address in MetaSingletons.MetaData.Address
              from employeeAddress in address.EmployeeAddress
              select employeeAddress.Employee.Contact.Individual;

      h.ToList();
    }

    /// <summary>
    /// Test fetching the CustomerId, SalesOrderId, AddressId of all customers which have addresses and may have orders
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14210
    /// </summary>
    public static object LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder(int maxNumberOfItemsToReturn)
    {
      var customers = MetaSingletons.MetaData.Customer.AsQueryable();
      //var customersDerivedTable = customers.Select(customer => customer);
      var customersDerivedTable = from customer in customers select customer; //Using this to force a derived table causes a crash
      customersDerivedTable = customers.Where(c => c.CustomerId > 10); //To force a derived table

//      var q = AWHelper.MetaData.Customer.SelectMany(customer => customer.CustomerAddress, (customer, ca) => new {customer, ca}).GroupJoin(AWHelper.MetaData.SalesOrderHeader, @t => @t.customer.CustomerId, soh => soh.CustomerId, (@t, oc) => new {@t, oc}).SelectMany(@t => @t.oc.DefaultIfEmpty(), (@t, nullableSOH) => new {@t.@t.customer.CustomerId, @t.@t.ca.AddressId, nullableSOH.SalesOrderId});
      GlobalHelper.TraceOut("ExplicitJoin with Derived Table");
      var q = from customer in customersDerivedTable
              join soh in (from s in MetaSingletons.MetaData.SalesOrderHeader where s.SalesPersonId > 22 select s) on customer.CustomerId equals soh.CustomerId into oc
              from nullableSOH in oc.DefaultIfEmpty()
              from ca in customer.CustomerAddress.DefaultIfEmpty()
              select new {customer.CustomerId, ca.AddressId, nullableSOH.SalesOrderId, customer.SalesTerritory.Name};
      if (maxNumberOfItemsToReturn > 0)
        q = q.Take(maxNumberOfItemsToReturn);

      var q4 = from customer in customers
               from soh in customer.SalesOrderHeader.Where(soh => soh.SalesOrderId < 10).DefaultIfEmpty()
               select new {customer.CustomerId, soh.SalesOrderId};
      if (maxNumberOfItemsToReturn > 0)
        q4 = q4.Take(maxNumberOfItemsToReturn);
      var x = q4.ToList();

      return q;
    }
  }
}