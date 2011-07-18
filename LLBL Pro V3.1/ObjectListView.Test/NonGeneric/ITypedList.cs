#pragma warning disable 1591	// Missing XML comment

#if TEST
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class ITypedListTests
  {
    [Test]
    public void GetListName()
    {
      var list = new List<SimpleClass>();
      var view = new ObjectListView(list);

      Assert.IsTrue(view is ITypedList);
      Assert.AreEqual("", ((ITypedList) view).GetListName(null));
    }

    [Test]
    public void GetListNameAccessors()
    {
      var list = new List<SimpleClass>();
      var view = new ObjectListView(list);

      // Get some random property descriptors.
      var accessors = TypeDescriptor.GetProperties(typeof (ISite));
      var listAccessors = new PropertyDescriptor[accessors.Count];
      accessors.CopyTo(listAccessors, 0);

      Assert.AreEqual("", ((ITypedList) view).GetListName(listAccessors));
    }

    [Test]
    public void GetItemProperties()
    {
      var list = new List<SimpleClass>();
      var view = new ObjectListView(list);

      var props = ((ITypedList) view).GetItemProperties(null);
      var typeProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      Assert.AreEqual(typeProps, props);
    }

    [Test]
    public void GetItemPropertiesAccessors()
    {
      var list = new List<SimpleClass>();
      var view = new ObjectListView(list);

      // Get some random property descriptors.
      var accessors = TypeDescriptor.GetProperties(typeof (ISite));
      var listAccessors = new PropertyDescriptor[accessors.Count];
      accessors.CopyTo(listAccessors, 0);

      var props = ((ITypedList) view).GetItemProperties(listAccessors);
      var typeProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      Assert.AreEqual(typeProps, props);
    }
  }
}

#endif