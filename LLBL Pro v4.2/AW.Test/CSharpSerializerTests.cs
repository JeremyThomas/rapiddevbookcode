using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectAsSourceCodeVisualizer;

namespace AW.Tests
{
  [TestClass]
  public class CSharpSerializerTests
  {
    private static readonly string FileHeader = "using System;" + Environment.NewLine +
                                                "using System.Collections.Generic;" + Environment.NewLine +
                                                "using AW.Tests;" + Environment.NewLine +
                                                Environment.NewLine +
                                                "public static class ResultContainer" + Environment.NewLine +
                                                "  {" + Environment.NewLine +
                                                "    static void Result() " + Environment.NewLine +
                                                "      {";

    [TestMethod]
    public void SerializerToCSharpTest()
    {
      var order = GetOrder();

      var result = order.SerializerToCSharp
        ("Description"
        );


      WriteToFile("test.txt", result);

      // Poor man's unit test, paste results into 
      // GetOrderFromObjectListeral()
      Assert.IsTrue(CompareOrders(order, GetOrderFromObjectLiteral()), "Error: Object Literal does not match");

      var cSharpCodeProvider = new CSharpCodeProvider();
      var compilableSource = FileHeader + result + "}}";
      var compilerParameters = new CompilerParameters();
      compilerParameters.ReferencedAssemblies.Add(typeof (Order).Assembly.Location);
      var compileAssemblyFromSource = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, compilableSource);
      Assert.AreEqual(0, compileAssemblyFromSource.Errors.Count);
    }

    private static void WriteToFile(string fileName, string content)
    {
      File.WriteAllText(fileName, content);
    }

    private static bool CompareOrders(Order lhs, Order rhs)
    {
      var itemDifferences = lhs.Items.Except(rhs.Items, new ItemEqualityComparer());
      if (itemDifferences.Any())
        return false;

      if (rhs.Items[0].Product.Category.Departments[0].Description != null)
      {
        return false; // Property should have been skipped
      }

      return lhs.Key == rhs.Key &&
             lhs.Items.Count == rhs.Items.Count &&
             lhs.Address.Key == rhs.Address.Key;
    }

    public static Order GetOrder()
    {
      var customer = new Customer
      {
        Key = 1,
        FirstName = "Mortimer",
        LastName = "Sneurd",
        Timestamp = "3"
      };

      var homeAddress = new Address
      {
        Key = 0,
        Customer = customer,
        Street = "1313 Mockingbird Lane",
        City = "Candy Land",
        AddressType = AddressType.Residential,
        ZipCode = 90210,
        Timestamp = "1"
      };

      var businessAddress = new Address
      {
        Key = 1,
        Customer = customer,
        Street = "411 Bonham",
        City = "Sao Antonio",
        AddressType = AddressType.Business,
        ZipCode = 66016,
        Timestamp = "2"
      };

      customer.Addresses = new List<Address> {homeAddress, businessAddress};

      var department1 = new Department {Key = 0, Name = "Electronics", Timestamp = "4"};
      var department2 = new Department {Key = 1, Name = "Computers", Timestamp = "5"};
      var department3 = new Department {Key = 2, Name = "Music", Timestamp = "6"};

      Department[] batteryDepartments =
      {department1, department2};

      var category1 = new Category
      {
        Key = 0,
        Name = "Batteries",
        SortOrder = 1,
        Departments = batteryDepartments,
        Timestamp = "7"
      };
      var category2 = new Category
      {
        Key = 2,
        Name = "Sheet Music",
        SortOrder = 2,
        Departments = new Department[2] {department2, department3},
        Timestamp = "8"
      };

      var product1 = new Product {Key = 0, Name = "Everready", Category = category1, Timestamp = "9"};
      var product2 = new Product {Key = 1, Name = "Shroeder's Theme", Category = category2, Timestamp = "10"};

      // Add a parent ref to 
      var item1 = new Item {Key = 0, Price = 13.13F, Quantity = 6, Product = product1, Timestamp = "11"};
      var item2 = new Item {Key = 1, Price = 15.00F, Quantity = 1, Product = product2, Timestamp = "12"};
      var item3 = new Item {Key = 2, Price = 5.00F, Quantity = 1, Product = product1, Timestamp = "13"};

      var order = new Order
      {
        Key = 1,
        Name = "Business Order #1",
        Customer = customer,
        Address = businessAddress,
        Items = new List<Item> {item1, item2, item3},
        SentDate = null,
        Hold = true,
        Coupons = new List<String> {"Summer", "Fall"},
        Alerts = new long[] {1234, 5678},
        ContactTimes = new[] {new DateTime(2013, 12, 25, 09, 30, 0), new DateTime(2014, 1, 1, 10, 0, 0)},
        Timestamp = "14" //,
        //Chars = new List<char?> { 'a', null, 'b', 'c' } // Not supported
      };

      item1.Order = order;
      item2.Order = order;
      item3.Order = order;

      return order;
    }

    /// <summary>
    ///   Paste the output of the Object Literal Serializer here
    /// </summary>
    /// <returns></returns>
    private static Order GetOrderFromObjectLiteral()
    {
      // Object Literal
      // Globally Excluded Properties:
      //  Description
      var Order1 = new Order
      {
        Name = "Business Order #1",
        SentDate = null,
        Hold = true,
        Key = 1L,
        Timestamp = "14",
        Customer = new Customer
        {
          FirstName = "Mortimer",
          LastName = "Sneurd",
          Key = 1L,
          Timestamp = "3"
        }
      };
      var Address0 = new Address
      {
        Street = "1313 Mockingbird Lane",
        City = "Candy Land",
        AddressType = AddressType.Residential,
        ZipCode = 90210,
        Key = 0L,
        Timestamp = "1",
        Customer = Order1.Customer
      };
      var Address1 = new Address
      {
        Key = 1L,
        Street = "411 Bonham",
        City = "Sao Antonio",
        AddressType = AddressType.Business,
        ZipCode = 66016,
        Timestamp = "2",
        Customer = Order1.Customer
      };
      Order1.Customer.Addresses = new List<Address> {Address0, Address1};
      Order1.Address = Address1;
      var Item0 = new Item
      {
        Quantity = 6,
        Price = 13.13F,
        Key = 0L,
        Timestamp = "11",
        Order = Order1,
        Product = new Product
        {
          Name = "Everready",
          Key = 0L,
          Timestamp = "9",
          Category = new Category
          {
            Name = "Batteries",
            SortOrder = 1,
            Key = 0L,
            Timestamp = "7"
          }
        }
      };
      var Department0 = new Department
      {
        Name = "Electronics",
        Key = 0L,
        Timestamp = "4"
      };
      var Department1 = new Department
      {
        Key = 1L,
        Name = "Computers",
        Timestamp = "5"
      };
      Item0.Product.Category.Departments = new[] {Department0, Department1};
      var Item1 = new Item
      {
        Key = 1L,
        Quantity = 1,
        Price = 15F,
        Timestamp = "12",
        Order = Order1,
        Product = new Product
        {
          Name = "Shroeder's Theme",
          Key = 1L,
          Timestamp = "10",
          Category = new Category
          {
            Name = "Sheet Music",
            SortOrder = 2,
            Key = 2L,
            Timestamp = "8"
          }
        }
      };
      var Department2 = new Department
      {
        Key = 2L,
        Name = "Music",
        Timestamp = "6"
      };
      Item1.Product.Category.Departments = new[] {Department1, Department2};
      var Item2 = new Item
      {
        Key = 2L,
        Quantity = 1,
        Price = 5F,
        Timestamp = "13",
        Order = Order1,
        Product = Item0.Product
      };
      Order1.Items = new List<Item> {Item0, Item1, Item2};
      Order1.Alerts = new[] {1234L, 5678L};
      Order1.ContactTimes = new[] {new DateTime(2013, 12, 25, 9, 30, 0), new DateTime(2014, 1, 1, 10, 0, 0)};
      Order1.Coupons = new List<String> {"Summer", "Fall"};

      return Order1;
    }
  }

  /***********************/
  /*    Test Classes     */
  /***********************/

  public class PersistantObject
  {
    public long Key { get; set; }
    public string Timestamp { get; set; }
  }

  public enum AddressType
  {
    Business,
    Residential
  };

  public class Address : PersistantObject
  {
    public Customer Customer { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public AddressType AddressType { get; set; }
    public int ZipCode { get; set; }
  }

  public class Customer : PersistantObject
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Address> Addresses { get; set; }
  }

  public class Department : PersistantObject
  {
    public string Name { get; set; }
    public string Description { get; set; }
  }

  public class Category : PersistantObject
  {
    public string Name { get; set; }
    public short SortOrder { get; set; }
    public Department[] Departments { get; set; }
  }

  public class Product : PersistantObject
  {
    public string Name { get; set; }
    public Category Category { get; set; }
  }

  public class ProductEqualityComparer : IEqualityComparer<Product>
  {
    public bool Equals(Product lhs, Product rhs)
    {
      return lhs.Key == rhs.Key &&
             lhs.Timestamp == rhs.Timestamp &&
             lhs.Name.Equals(rhs.Name) &&
             lhs.Category.Key == rhs.Category.Key &&
             lhs.Category.Departments.Length == rhs.Category.Departments.Length;
    }

    public int GetHashCode(Product product)
    {
      return product.Key.GetHashCode();
    }
  }

  public class Item : PersistantObject
  {
    public Order Order { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public Product Product { get; set; }
  }

  public class ItemEqualityComparer : IEqualityComparer<Item>
  {
    public bool Equals(Item lhs, Item rhs)
    {
      var productEqualityComparer = new ProductEqualityComparer();

      return lhs.Key == rhs.Key &&
             lhs.Price == rhs.Price &&
             lhs.Order.Key == rhs.Order.Key &&
             lhs.Quantity == rhs.Quantity &&
             lhs.Timestamp == rhs.Timestamp &&
             productEqualityComparer.Equals(lhs.Product, rhs.Product);
    }

    public int GetHashCode(Item item)
    {
      return item.Key.GetHashCode();
    }
  }

  public class Order : PersistantObject
  {
    public string Name { get; set; }
    public Customer Customer { get; set; }
    public Address Address { get; set; }
    public List<Item> Items { get; set; }
    public DateTime? SentDate { get; set; }
    public long[] Alerts { get; set; }
    public DateTime[] ContactTimes { get; set; }
    public List<String> Coupons { get; set; }
    public bool Hold { get; set; }
    // public List<char?> Chars { get; set; } Not Supported
  }
}