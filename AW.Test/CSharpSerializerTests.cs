using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Tests.Properties;
using Fasterflect;
using FluentAssertions;
using FluentAssertions.Equivalency;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
  [TestClass]
  public partial class CSharpSerializerTests
  {
    [TestMethod]
    public void SerializerToCSharpTest()
    {
      var order = GetOrder();
      var rootVariable = TestSerializerToCSharp(order, "Description");
      Assert.IsTrue(CompareOrders(order, rootVariable), "Error: Object Literal does not match");
      rootVariable.ShouldBeEquivalentTo(order, options => options.IgnoringCyclicReferences());
    }

    [TestMethod, Ignore]
    public void SerializeSettingsToCSharpTest()
    {
      var rootVariable = TestSerializerToCSharp(Settings.Default, "Context,Attributes,DefaultValue,PropertyType");
      rootVariable.ShouldBeEquivalentTo(Settings.Default, options => options.IgnoringCyclicReferences());
    }

    [TestMethod]
    public void SerializeControlsToCSharpTest()
    {
      var controls = new List<Control> { new Control("Control1"), new Control("Control2"), new Control("Control3") };
      var rootVariable = TestSerializerToCSharp(controls,
        "Anchor,AutoScrollOffset,BackColor,Bounds,Cursor,DataBindings,Font,ForeColor,Margin,WindowTarget,Padding,ClientSize,Location,MaximumSize,MinimumSize,Size,Handle,HandleInternal");
      rootVariable.ShouldAllBeEquivalentTo(controls, options => options.Excluding(m => m.Handle).ExcludingNestedObjects().ExcludingFields().ExcludingProperties());
    }

    private static T TestSerializerToCSharp<T>(T obj, string globalExcludeProperties = "", params Restriction[] entityRestrictions)
    {
      return CreateCompilableSourceAndCompile<T>(obj.SerializeToCSharp(OutputFormat.Snippet, globalExcludeProperties, entityRestrictions), typeof(GeneralHelper)
        , typeof(DataRow), typeof(ApplicationSettingsBase), typeof(Control), typeof(Point));
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
      var compilableSource = CreateCompilableSource(result, typeof(T));

      return CompilableSource<T>(compilableSource, GetAssemblies<T>(types));
    }

    /// <summary>
    ///   Compiles the source and executes and returns the output of CSharpSerializer.ResultMethodName.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="compilableSource">The compilable source.</param>
    /// <param name="types">The types.</param>
    /// <returns></returns>
    private static T CompilableSource<T>(string compilableSource, params Type[] types)
    {
      return CompilableSource<T>(compilableSource, GetAssemblies<T>(types));
    }

    private static string[] GetAssemblies<T>(IEnumerable<Type> types)
    {
      return types.Select(t => t.Assembly.Location).ToArray();
    }

    /// <summary>
    ///   Compiles the source and executes and returns the output of CSharpSerializer.ResultMethodName.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="compilableSource">The compilable source.</param>
    /// <param name="referencedAssemblies">The referenced assemblies.</param>
    /// <returns></returns>
    private static T CompilableSource<T>(string compilableSource, params string[] referencedAssemblies)
    {
      var expectedType = typeof(T);
      var cSharpCodeProvider = new CSharpCodeProvider();
      var compilerParameters = new CompilerParameters();
      compilerParameters.ReferencedAssemblies.Add(expectedType.Assembly.Location);
      compilerParameters.ReferencedAssemblies.AddRange(referencedAssemblies);
      foreach (var genericTypeArgument in expectedType.GenericTypeArguments)
        compilerParameters.ReferencedAssemblies.Add(genericTypeArgument.Assembly.Location);
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
      var compilableSource = CSharpSerializer.FileHeader1;
      if (expectedType.Namespace != null && !compilableSource.Contains(expectedType.Namespace))
        compilableSource += "using " + expectedType.Namespace + ";" + Environment.NewLine;
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
      rootVariable.ShouldBeEquivalentTo(customerEntity, ExcludingLlblProperties());
    }

    private static Func<EquivalencyAssertionOptions<EntityBase2>, EquivalencyAssertionOptions<EntityBase2>> ExcludingLlblProperties()
    {
      return LlblAssertionOptions;
    }

    private static EquivalencyAssertionOptions<EntityBase2> LlblAssertionOptions(EquivalencyAssertionOptions<EntityBase2> options)
    {
      return options.IncludingAllRuntimeProperties().IgnoringCyclicReferences().Excluding(o => o.Fields).Excluding(o => o.IsDirty).Excluding(o => o.IsNew)
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Fields")).Excluding(ctx => ctx.SelectedMemberPath.EndsWith("IsDirty"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("IsNew")).Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Internal"))
        .Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Picture")).Excluding(ctx => ctx.SelectedMemberPath.EndsWith("Photo"));
    }

    private static Func<EquivalencyAssertionOptions<EntityBase2>, EquivalencyAssertionOptions<EntityBase2>> ExcludingLlblProperties(params string[] memberPaths)
    {
      return options =>
      {
        var equivalencyAssertionOptions = LlblAssertionOptions(options);
        return memberPaths.Aggregate(equivalencyAssertionOptions, (current, memberPath) => current.Excluding(ctx => ctx.SelectedMemberPath.EndsWith(memberPath)));
      };
    }

    [TestMethod]
    public void SerializerAdapterToEntityCollectionToCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var expectedCustomerEntities = northwindLinqMetaData.Customer.Take(3).PrefetchOrders().ToEntityCollection2(); //.ToEntityCollection2();
      var actualCustomerEntities = TestSerializerLlbltoCSharp(expectedCustomerEntities);
      actualCustomerEntities.ShouldAllBeEquivalentTo(expectedCustomerEntities, ExcludingLlblProperties("Customer"));
      var expectedOrderEntities = expectedCustomerEntities[0].Orders;
      var actualOrderEntities = expectedCustomerEntities[0].Orders;
      Assert.AreEqual(expectedOrderEntities.Count, actualOrderEntities.Count, "Orders.Count");
      actualOrderEntities.ShouldAllBeEquivalentTo(expectedOrderEntities, ExcludingLlblProperties());
    }

    [TestMethod]
    public void SerializeAdapterEntityCollectionWithPrefetchToCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var productEntities = northwindLinqMetaData.Product.Take(3).PrefetchCategorySupplier().ToEntityCollection2();
      var productEntitiesCompiled = TestSerializerLlbltoCSharp(productEntities);
      productEntitiesCompiled.ShouldAllBeEquivalentTo(productEntities, ExcludingLlblProperties("Category", "Supplier"));
    }

    private static T TestSerializerLlbltoCSharp<T>(T obj)
    {
      var result = obj.SerializeToCSharp(OutputFormat.Compileable, "Fields,EntityFactoryToUse,Picture,Photo");
      var rootVariable = CompilableSource<T>(result, typeof(EntityBase2), typeof(IEditableObject), typeof(XmlEntity),
        typeof(GeneralHelper), typeof(DataRow));
      return rootVariable;
    }

    [TestMethod]
    public void SerializerCustomerEntityWithOrderTest()
    {
      var customer = GetCustomerEntityWithOrder();
      var actualCustomer = TestSerializerLlbltoCSharp(customer);
      actualCustomer.ShouldBeEquivalentTo(customer, ExcludingLlblProperties());
    }

    [TestMethod]
    public void SerializerCustomerEntityCollectionWithOrderTest()
    {
      var customerEntities = GetCustomerEntityCollectionWithOrder();
      var rootVariable2 = TestSerializerLlbltoCSharp(customerEntities);
      rootVariable2.ShouldAllBeEquivalentTo(customerEntities, ExcludingLlblProperties());
    }

    [TestMethod]
    public void SerializeOrdersPrefetchAlltoCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var orderEntities = northwindLinqMetaData.Order.Take(3).PrefetchAll().ToEntityCollection2();
      var actualOrders = TestSerializerLlbltoCSharp(orderEntities);
      actualOrders.ShouldAllBeEquivalentTo(orderEntities, ExcludingLlblProperties("Customer", "Employee", "Shipper", "OrderDetails"));
    }

    [TestMethod]
    public void SerializeEmployeesPrefetchAlltoCSharpTest()
    {
      var northwindLinqMetaData = GetNorthwindLinqMetaData();
      var employeeEntities = northwindLinqMetaData.Employee.Take(3).PrefetchAll().ToEntityCollection2();
      var actualEmployees = TestSerializerLlbltoCSharp(employeeEntities);
      actualEmployees.ShouldAllBeEquivalentTo(employeeEntities, ExcludingLlblProperties("Manager", "Orders", "Staff"));
    }

    [TestMethod]
    public void SerializerProductsWithCategoriesTest()
    {
      var productEntities = GetProductsWithCategories();
      var rootVariable2 = TestSerializerLlbltoCSharp(productEntities);
      rootVariable2.ShouldAllBeEquivalentTo(productEntities, ExcludingLlblProperties());
    }
  }
}