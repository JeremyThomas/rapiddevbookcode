#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class ExtendedPropertyTests
  {
    [Test]
    public void Construct()
    {
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total");
      Assert.IsNull(prop.Default);
      Assert.AreEqual("Total", prop.Name);
      Assert.IsNotNull(prop.PropertyDescriptor);
      Assert.AreEqual(typeof (string), prop.PropertyType);
      Assert.IsTrue(prop.IsReadOnly);
    }

    [Test]
    public void ConstructTyped()
    {
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (int));
      Assert.IsNull(prop.Default);
      Assert.AreEqual("Total", prop.Name);
      Assert.IsNotNull(prop.PropertyDescriptor);
      Assert.AreEqual(typeof (int), prop.PropertyType);
      Assert.IsTrue(prop.IsReadOnly);
    }

    [Test]
    public void ConstructWritable()
    {
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (int), true, null);
      Assert.IsNull(prop.Default);
      Assert.AreEqual("Total", prop.Name);
      Assert.IsNotNull(prop.PropertyDescriptor);
      Assert.AreEqual(typeof (int), prop.PropertyType);
      Assert.IsFalse(prop.IsReadOnly);
    }

    [Test]
    public void ConstructDefaultValue()
    {
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (int), true, 42);
      Assert.AreEqual(42, prop.Default);
      Assert.AreEqual("Total", prop.Name);
      Assert.IsNotNull(prop.PropertyDescriptor);
      Assert.AreEqual(typeof (int), prop.PropertyType);
      Assert.IsFalse(prop.IsReadOnly);
    }

    [Test]
    public void GetValue()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total");

      var callbacks = 0;
      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args)
                         {
                           callbacks++;
                           Assert.AreEqual("Total", args.PropertyName);
                           Assert.AreSame(item, args.Target);
                           Assert.AreEqual(null, args.Value);

                           args.Value = string.Format("{0}: {1}", ((SimpleClass) args.Target).StringValue, ((SimpleClass) args.Target).IntegerValue);
                         };

      var propValue = prop.PropertyDescriptor.GetValue(item);

      Assert.AreEqual(1, callbacks);
      Assert.IsNotNull(propValue);
      Assert.AreEqual(typeof (string), propValue.GetType());
      Assert.AreEqual("Orders: 42", propValue);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void GetValueWrongTypeReferenceType()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (string), true, null);

      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args) { args.Value = 42; };

      var propValue = prop.PropertyDescriptor.GetValue(item);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void GetValueWrongTypeValueType()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (DateTime), true, null);

      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args) { args.Value = 42; };

      var propValue = prop.PropertyDescriptor.GetValue(item);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void GetValueNullValueType()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (int), true, null);

      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args) { args.Value = null; };

      var propValue = prop.PropertyDescriptor.GetValue(item);
    }

    [Test]
    public void GetValueNullNullableValueType()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (int?), true, null);

      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args) { args.Value = null; };

      var propValue = prop.PropertyDescriptor.GetValue(item);

      Assert.IsNull(propValue);
    }

    [Test]
    public void GetValueNullReferenceType()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (string), true, null);

      var callbacks = 0;
      prop.GetValue += delegate(object sender, ExtendedPropertyEventArgs args)
                         {
                           callbacks++;
                           args.Value = null;
                         };

      var propValue = prop.PropertyDescriptor.GetValue(item);

      Assert.IsNull(propValue);
    }

    [Test]
    public void SetValue()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total", typeof (string), true, null);

      var callbacks = 0;
      prop.SetValue += delegate(object sender, ExtendedPropertyEventArgs args)
                         {
                           callbacks++;
                           Assert.AreEqual("Total", args.PropertyName);
                           Assert.AreSame(item, args.Target);
                           Assert.IsNotNull(args.Value);
                           Assert.AreEqual(typeof (string), args.Value.GetType());
                           Assert.AreEqual("Orders: 57", args.Value);
                         };

      prop.PropertyDescriptor.SetValue(item, "Orders: 57");

      Assert.AreEqual(1, callbacks);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void SetValueReadOnly()
    {
      var item = new SimpleClass(42, "Orders", DateTime.Now);
      var prop = new ExtendedProperty(typeof (SimpleClass), "Total");
      prop.PropertyDescriptor.SetValue(item, "Orders: 57");
    }
  }
}

#endif