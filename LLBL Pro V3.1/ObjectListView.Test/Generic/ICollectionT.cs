#pragma warning disable 1591	// Missing XML comment


using System;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class ICollectionTTests
  {
    [Test]
    public void Add()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      view.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

      Assert.AreEqual(4, list.Count);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);

      var item = list[3];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }

    [Test]
    public void AddIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      factory.View.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

      Assert.AreEqual(4, factory.List.Count);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);

      object item = factory.List[3];
      Assert.IsTrue(item is SimpleClass);
      Assert.AreEqual(200, ((SimpleClass) item).IntegerValue);
      Assert.AreEqual("ddd", ((SimpleClass) item).StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass) item).DateTimeValue);
    }

    [Test]
    public void Clear()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      var item = factory.CreateItem();
      factory.List.Add(item);
      factory.ClearEventCounts();

      factory.View.Clear();
      Assert.AreEqual(1, factory.ListChangedResetCount);
      Assert.AreEqual(0, factory.List.Count);
    }

    [Test]
    public void ClearIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      var item = factory.CreateItem();
      factory.List.Add(item);
      factory.ClearEventCounts();

      factory.View.Clear();
      Assert.AreEqual(1, factory.ListChangedResetCount);
      Assert.AreEqual(0, factory.List.Count);
    }

    [Test]
    public void ContainsItemInList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.IsTrue(view.Contains(bbb));
    }

    [Test]
    public void ContainsItemNotInList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.IsFalse(view.Contains(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)))); // reference compare only for SimpleClass
    }

    [Test]
    public void CopyTo()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var array = new SimpleClass[3];
      factory.View.CopyTo(array, 0);

      var item = array[0];
      Assert.IsNotNull(item);
      Assert.AreEqual(100, item.IntegerValue);
      Assert.AreEqual("aaa", item.StringValue);
      Assert.AreEqual(new DateTime(1970, 1, 1), item.DateTimeValue);

      item = array[1];
      Assert.AreEqual(80, item.IntegerValue);
      Assert.AreEqual("bbb", item.StringValue);
      Assert.AreEqual(new DateTime(1980, 12, 12), item.DateTimeValue);

      item = array[2];
      Assert.AreEqual(60, item.IntegerValue);
      Assert.AreEqual("ccc", item.StringValue);
      Assert.AreEqual(new DateTime(1975, 6, 6), item.DateTimeValue);
    }

    [Test]
    public void CopyToEmptyList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var array = new SimpleClass[0];
      factory.View.CopyTo(array, 0);
    }

    [Test]
    public void Count()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.AreEqual(list.Count, factory.View.Count);
    }

    [Test]
    public void CountEmptyList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.AreEqual(0, factory.View.Count);
    }

    [Test]
    public void IsReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.AreEqual(factory.List.IsReadOnly, factory.View.IsReadOnly);
    }

    [Test]
    public void Remove()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var removingIndex = -1;
      view.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      Assert.IsTrue(view.Remove(bbb));
      Assert.AreEqual(2, list.Count);
      Assert.AreEqual("ccc", list[1].StringValue);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(1, removingIndex);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }

    [Test]
    public void RemoveIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var removingIndex = -1;
      view.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      Assert.IsTrue(factory.View.Remove(bbb));
      Assert.AreEqual(2, factory.List.Count);
      Assert.AreEqual("ccc", factory.List[1].StringValue);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(1, removingIndex);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }
  }
}

