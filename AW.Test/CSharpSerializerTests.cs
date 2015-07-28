﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using AW.Helper;
using AW.Helper.LLBL;
using Fasterflect;
using FluentAssertions;
using FluentAssertions.Equivalency;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  [TestClass]
  public class CSharpSerializerTests
  {
    [TestMethod]
    public void SerializerToCSharpTest()
    {
      var order = GetOrder();
      var rootVariable = TestSerializerToCSharp(order, "Description");
      Assert.IsTrue(CompareOrders(order, rootVariable), "Error: Object Literal does not match");
      //    rootVariable.ShouldBeEquivalentTo(order);
    }

    private static T TestSerializerToCSharp<T>(T obj, string globalExcludeProperties = "", params Restriction[] entityRestrictions)
    {
      return CreateCompilableSourceAndCompile<T>(obj.SerializeToCSharp(OutputFormat.Snippet, globalExcludeProperties, entityRestrictions), typeof (GeneralHelper));
    }

    /// <summary>
    ///   Tests the c sharp source code by adding file header and compiling it.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="result">The result.</param>
    /// <param name="types">The types.</param>
    /// <returns></returns>
    private static T CreateCompilableSourceAndCompile<T>(string result, params Type[] types)
    {
      var compilableSource = CreateCompilableSource(result, typeof (T));

      return CompilableSource<T>(compilableSource, GetAssemblies<T>(types));
    }

    private static T CompilableSource<T>(string compilableSource, params Type[] types)
    {
      return CompilableSource<T>(compilableSource, GetAssemblies<T>(types));
    }

    private static string[] GetAssemblies<T>(IEnumerable<Type> types)
    {
      return types.Select(t => t.Assembly.Location).ToArray();
    }

    private static T CompilableSource<T>(string compilableSource, params string[] referencedAssemblies)
    {
      var expectedType = typeof (T);
      var cSharpCodeProvider = new CSharpCodeProvider();
      var compilerParameters = new CompilerParameters();
      compilerParameters.ReferencedAssemblies.Add(expectedType.Assembly.Location);
      compilerParameters.ReferencedAssemblies.AddRange(referencedAssemblies);
      foreach (var genericTypeArgument in expectedType.GenericTypeArguments)
      {
        compilerParameters.ReferencedAssemblies.Add(genericTypeArgument.Assembly.Location);
      }
      var compileAssemblyFromSource = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, compilableSource);
      Assert.AreEqual(0, compileAssemblyFromSource.Errors.Count, compileAssemblyFromSource.Errors.OfType<CompilerError>().JoinAsString());
      var compiledAssembly = compileAssemblyFromSource.CompiledAssembly;
      var type = compiledAssembly.GetType(CSharpSerializer.ResultClassName);
      var rootVariable = type.CallMethod(CSharpSerializer.ResultMethodName);
      Assert.IsInstanceOfType(rootVariable, expectedType);
      return (T) rootVariable;
    }

    private static string CreateCompilableSource(string result, Type expectedType)
    {
      var rootVariableName = result.Before("=");
      rootVariableName = rootVariableName.After("var").Trim();
      var compilableSource = CSharpSerializer.FileHeader1 + "using " + expectedType.Namespace + ";" + Environment.NewLine;
      compilableSource = expectedType.GenericTypeArguments.Aggregate(compilableSource, (current, genericTypeArgument) => current + ("using " + genericTypeArgument.Namespace + ";" + Environment.NewLine));
      compilableSource += Environment.NewLine + CSharpSerializer.FileHeader2 + result + Environment.NewLine + "return " + rootVariableName + ";}}";
      return compilableSource;
    }

    public static LinqMetaData GetNorthwindLinqMetaData()
    {
      return new LinqMetaData(new DataAccessAdapter(), DataAccessAdapter.StaticCustomFunctionMappings);
    }

    [TestMethod]
    public void SerializerAdapterEntityToCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var customerEntity = northwindLinqMetaData.Customer.First();
      var rootVariable = TestSerializerLlbltoCSharp(customerEntity);
      rootVariable.ShouldBeEquivalentTo(customerEntity, ExcludingLLBLProperties());
    }

    private static Func<EquivalencyAssertionOptions<EntityBase2>, EquivalencyAssertionOptions<EntityBase2>> ExcludingLLBLProperties()
    {
      return options => options.IncludingAllRuntimeProperties().ExcludingNestedObjects().Excluding(o => o.Fields).Excluding(o => o.IsDirty).Excluding(o => o.IsNew)
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Fields")).Excluding(ctx => ctx.SelectedMemberPath.EndsWith("IsDirty")).Excluding(ctx => ctx.SelectedMemberPath.EndsWith("IsNew"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Category"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Internal"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Orders"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Customer"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Supplier"));
    }

    [TestMethod]
    public void SerializerAdapterToEntityCollectionToCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var entities = northwindLinqMetaData.Customer.Take(3).PrefetchOrders().ToEntityCollection2(); //.ToEntityCollection2();
      var rootVariable2 = TestSerializerLlbltoCSharp(entities);
      rootVariable2.ShouldAllBeEquivalentTo(entities, ExcludingLLBLProperties());
    }

    [TestMethod]
    public void SerializeAdapterEntityCollectionWithPrefetchToCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var productEntities = northwindLinqMetaData.Product.Take(3).PrefetchCategorySupplier().ToEntityCollection2();
      var productEntitiesCompiled = TestSerializerLlbltoCSharp(productEntities);
      productEntitiesCompiled.ShouldAllBeEquivalentTo(productEntities, ExcludingLLBLProperties());
    }

    private static T TestSerializerLlbltoCSharp<T>(T obj)
    {
      var result = obj.SerializeToCSharp(OutputFormat.Compileable, "Fields,EntityFactoryToUse,Picture");
      var rootVariable = CompilableSource<T>(result, typeof (EntityBase2), typeof (IEditableObject), typeof (XmlEntity), typeof (GeneralHelper));
      return rootVariable;
    }

    [TestMethod]
    public void SerializerCustomerEntityWithOrderTest()
    {
      var customer = GetCustomerEntityWithOrder();
      var rootVariable2 = TestSerializerLlbltoCSharp(customer);
      rootVariable2.ShouldBeEquivalentTo(customer, ExcludingLLBLProperties());
    }

    [TestMethod]
    public void SerializerCustomerEntityCollectionWithOrderTest()
    {
      var customerEntities = GetCustomerEntityCollectionWithOrder();
      var rootVariable2 = TestSerializerLlbltoCSharp(customerEntities);
      rootVariable2.ShouldAllBeEquivalentTo(customerEntities, ExcludingLLBLProperties());
    }

    [TestMethod]
    public void SerializerProductsWithCategoriesTest()
    {
      var productEntities = GetProductsWithCategories();
      var rootVariable2 = TestSerializerLlbltoCSharp(productEntities);
      rootVariable2.ShouldAllBeEquivalentTo(productEntities, ExcludingLLBLProperties());
    }

    public static EntityCollection<ProductEntity> GetProductsWithCategories()
    {
      var entityCollection12882670 = new EntityCollection<ProductEntity>
      {
        new ProductEntity
        {
          CategoryId = 1,
          Discontinued = false,
          ProductId = 1,
          ProductName = "Chai3",
          QuantityPerUnit = "10 boxes x 20 bags",
          ReorderLevel = 10,
          SupplierId = 1,
          UnitPrice = 18.0000m,
          UnitsInStock = 39,
          UnitsOnOrder = 0,
          Category = new CategoryEntity
          {
            CategoryId = 1,
            CategoryName = "Beverages",
            Description = "Soft drinks, coffees, teas, beers, and ales"
          },
          Supplier = new SupplierEntity
          {
            Address = "49 Gilbert St.",
            City = "London",
            CompanyName = "Exotic Liquids",
            ContactName = "Charlotte Cooper",
            ContactTitle = "Purchasing Manager",
            Country = "UK",
            Fax = "",
            HomePage = "",
            Phone = "(171) 555-2222",
            PostalCode = "EC1 4SD",
            Region = "",
            SupplierId = 1
          }
        },
        new ProductEntity
        {
          CategoryId = 1,
          Discontinued = false,
          ProductId = 2,
          ProductName = "Chang",
          QuantityPerUnit = "24 - 12 oz bottles",
          ReorderLevel = 25,
          SupplierId = 1,
          UnitPrice = 19.0000m,
          UnitsInStock = 17,
          UnitsOnOrder = 40
        },
        new ProductEntity
        {
          CategoryId = 2,
          Discontinued = false,
          ProductId = 3,
          ProductName = "Aniseed Syrup",
          QuantityPerUnit = "12 - 550 ml bottles",
          ReorderLevel = 25,
          SupplierId = 1,
          UnitPrice = 10.0000m,
          UnitsInStock = 13,
          UnitsOnOrder = 70,
          Category = new CategoryEntity
          {
            CategoryId = 2,
            CategoryName = "Condiments",
            Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
          }
        }
      };

      return entityCollection12882670;
    }

    public static CustomerEntity GetCustomerEntityWithOrder()
    {
      var CustomerEntity1594500641 = new CustomerEntity
      {
        Address = "Obere Str. 57",
        City = "Berlin",
        CompanyName = "Alfreds Futterkiste",
        ContactName = "Maria Anders",
        ContactTitle = "Sales Representative",
        Country = "Germany",
        CustomerId = "ALFKI",
        Fax = "030-0076545",
        Phone = "030-0074321",
        PostalCode = "12209",
        Region = "",
        Orders =
        {
          new OrderEntity
          {
            CustomerId = "ALFKI",
            EmployeeId = 4,
            Freight = 61.0200m,
            OrderDate = new DateTime(1997, 10, 3),
            OrderId = 10692,
            RequiredDate = new DateTime(1997, 10, 31),
            ShipAddress = "Obere Str. 57",
            ShipCity = "Berlin",
            ShipCountry = "Germany",
            ShipName = "Alfred's Futterkiste",
            ShippedDate = new DateTime(1997, 10, 13),
            ShipPostalCode = "12209",
            ShipRegion = "",
            ShipVia = 2
          }
        }
      };
      //CustomerEntity1594500641.Orders.AddRange(new[]
      //{
      //  new OrderEntity
      //  {
      //    CustomerId = "ALFKI",
      //    EmployeeId = 4,
      //    Freight = 61.0200m,
      //    OrderDate = new DateTime(1997, 10, 3),
      //    OrderId = 10692,
      //    RequiredDate = new DateTime(1997, 10, 31),
      //    ShipAddress = "Obere Str. 57",
      //    ShipCity = "Berlin",
      //    ShipCountry = "Germany",
      //    ShipName = "Alfred's Futterkiste",
      //    ShippedDate = new DateTime(1997, 10, 13),
      //    ShipPostalCode = "12209",
      //    ShipRegion = "",
      //    ShipVia = 2,
      //    Customer = CustomerEntity1594500641
      //  }
      //}
      //  );

      return CustomerEntity1594500641;
    }


    public static EntityCollection<CustomerEntity> GetCustomerEntityCollectionWithOrder()
    {
      var entityCollection58667681 = new EntityCollection<CustomerEntity>
      {
        new CustomerEntity
        {
          Address = "Obere Str. 57",
          City = "Berlin",
          CompanyName = "Alfreds Futterkiste",
          ContactName = "Maria Anders",
          ContactTitle = "Sales Representative",
          Country = "Germany",
          CustomerId = "ALFKI",
          Fax = "030-0076545",
          Phone = "030-0074321",
          PostalCode = "12209",
          Region = "",
          Orders =
          {
            new OrderEntity
            {
              CustomerId = "ALFKI",
              EmployeeId = 6,
              Freight = 29.4600m,
              OrderDate = new DateTime(1997, 8, 25),
              OrderId = 10643,
              RequiredDate = new DateTime(1997, 9, 22),
              ShipAddress = "Obere Str. 57",
              ShipCity = "Berlin",
              ShipCountry = "Germany",
              ShipName = "Alfreds Futterkiste",
              ShippedDate = new DateTime(1997, 9, 2),
              ShipPostalCode = "12209",
              ShipRegion = "",
              ShipVia = 1
            },
            new OrderEntity
            {
              CustomerId = "ALFKI",
              EmployeeId = 4,
              Freight = 61.0200m,
              OrderDate = new DateTime(1997, 10, 3),
              OrderId = 10692,
              RequiredDate = new DateTime(1997, 10, 31),
              ShipAddress = "Obere Str. 57",
              ShipCity = "Berlin",
              ShipCountry = "Germany",
              ShipName = "Alfred's Futterkiste",
              ShippedDate = new DateTime(1997, 10, 13),
              ShipPostalCode = "12209",
              ShipRegion = "",
              ShipVia = 2
            }
          }
        },
        new CustomerEntity
        {
          Address = "Avda. de la Constitución 2222",
          City = "México D.F.",
          CompanyName = "Ana Trujillo Emparedados y helados",
          ContactName = "Ana Trujillo",
          ContactTitle = "Owner",
          Country = "Mexico",
          CustomerId = "ANATR",
          Fax = "(5) 555-3745",
          Phone = "(5) 555-4729",
          PostalCode = "05021",
          Region = "",
          Orders =
          {
            new OrderEntity
            {
              CustomerId = "ANATR",
              EmployeeId = 7,
              Freight = 1.6100m,
              OrderDate = new DateTime(1996, 9, 18),
              OrderId = 10308,
              RequiredDate = new DateTime(1996, 10, 16),
              ShipAddress = "Avda. de la Constitución 2222",
              ShipCity = "México D.F.",
              ShipCountry = "Mexico",
              ShipName = "Ana Trujillo Emparedados y helados",
              ShippedDate = new DateTime(1996, 9, 24),
              ShipPostalCode = "05021",
              ShipRegion = "",
              ShipVia = 3
            },
            new OrderEntity
            {
              CustomerId = "ANATR",
              EmployeeId = 3,
              Freight = 43.9000m,
              OrderDate = new DateTime(1997, 8, 8),
              OrderId = 10625,
              RequiredDate = new DateTime(1997, 9, 5),
              ShipAddress = "Avda. de la Constitución 2222",
              ShipCity = "México D.F.",
              ShipCountry = "Mexico",
              ShipName = "Ana Trujillo Emparedados y helados",
              ShippedDate = new DateTime(1997, 8, 14),
              ShipPostalCode = "05021",
              ShipRegion = "",
              ShipVia = 1
            }
          }
        },
        new CustomerEntity
        {
          Address = "Mataderos  2312",
          City = "México D.F.",
          CompanyName = "Antonio Moreno Taquería",
          ContactName = "Antonio Moreno",
          ContactTitle = "Owner",
          Country = "Mexico",
          CustomerId = "ANTON",
          Fax = "",
          Phone = "(5) 555-3932",
          PostalCode = "05023",
          Region = "",
          Orders =
          {
            new OrderEntity
            {
              CustomerId = "ANTON",
              EmployeeId = 3,
              Freight = 22.0000m,
              OrderDate = new DateTime(1996, 11, 27),
              OrderId = 10365,
              RequiredDate = new DateTime(1996, 12, 25),
              ShipAddress = "Mataderos  2312",
              ShipCity = "México D.F.",
              ShipCountry = "Mexico",
              ShipName = "Antonio Moreno Taquería",
              ShippedDate = new DateTime(1996, 12, 2),
              ShipPostalCode = "05023",
              ShipRegion = "",
              ShipVia = 2
            },
            new OrderEntity
            {
              CustomerId = "ANTON",
              EmployeeId = 7,
              Freight = 47.4500m,
              OrderDate = new DateTime(1997, 4, 15),
              OrderId = 10507,
              RequiredDate = new DateTime(1997, 5, 13),
              ShipAddress = "Mataderos  2312",
              ShipCity = "México D.F.",
              ShipCountry = "Mexico",
              ShipName = "Antonio Moreno Taquería",
              ShippedDate = new DateTime(1997, 4, 22),
              ShipPostalCode = "05023",
              ShipRegion = "",
              ShipVia = 1
            }
          }
        }
      };

      return entityCollection58667681;
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
        Departments = new[] {department2, department3},
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
             // ReSharper disable once CompareOfFloatsByEqualityOperator
             lhs.Price == rhs.Price &&
             lhs.Order != null &&
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