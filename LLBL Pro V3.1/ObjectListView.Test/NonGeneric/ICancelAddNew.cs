#pragma warning disable 1591	// Missing XML comment


using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class ICancelAddNewTests
  {
    [Test]
    public void AddNewAndEndNew()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      var added = (ObjectView) view.AddNew();

      ((ICancelAddNew) view).EndNew(view.IndexOf(added.Object));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewAndCancelNew()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      var added = (ObjectView) view.AddNew();

      ((ICancelAddNew) view).CancelNew(view.IndexOf(added.Object));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }

    [Test]
    public void AddNewEditableObjectAndEndNew()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      var added = (ObjectView) view.AddNew();

      ((ICancelAddNew) view).EndNew(view.IndexOf(added.Object));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewEditableObjectAndCancelNew()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      var added = (ObjectView) view.AddNew();

      ((ICancelAddNew) view).CancelNew(view.IndexOf(added.Object));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }

    [Test]
    public void EndNewWithoutAddNew()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      ((ICancelAddNew) view).EndNew(0);
      Assert.AreEqual(0, factory.ListChangedAddedCount);
    }

    [Test]
    public void EndNewWithoutAddNewWithListAdd()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      factory.List.Add(new SimpleClass());
      Assert.AreEqual(1, factory.ListChangedAddedCount);

      ((ICancelAddNew) view).EndNew(0);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
    }

    [Test]
    public void CancelNewWithoutAddNew()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      ((ICancelAddNew) view).CancelNew(0);
      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
    }

    [Test]
    public void CancelNewWithoutAddNewWithListAdd()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      factory.List.Add(new SimpleClass());
      Assert.AreEqual(1, factory.ListChangedAddedCount);

      ((ICancelAddNew) view).CancelNew(0);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
    }
  }
}

