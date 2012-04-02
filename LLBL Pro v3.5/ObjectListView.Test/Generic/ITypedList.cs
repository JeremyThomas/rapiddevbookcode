#pragma warning disable 1591	// Missing XML comment


using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class ITypedListTests
  {
    [Test]
    public void GetListName()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      Assert.IsTrue(view is ITypedList);
      Assert.AreEqual("", ((ITypedList) view).GetListName(null));
    }

    [Test]
    public void GetListNameAccessors()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      // Get some random property descriptors.
      var accessors = TypeDescriptor.GetProperties(typeof (ISite));
      var listAccessors = new PropertyDescriptor[accessors.Count];
      accessors.CopyTo(listAccessors, 0);

      Assert.AreEqual("", ((ITypedList) view).GetListName(listAccessors));
    }

    [Test]
    public void GetItemProperties()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = ((ITypedList) view).GetItemProperties(null);
      var typeProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      Assert.AreEqual(typeProps, props);
    }

    [Test]
    public void GetItemPropertiesAccessors()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

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

