#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class IListTTests
  {
    [Test]
    public void IndexOf()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.AreEqual(1, factory.View.IndexOf(bbb));
    }

    [Test]
    public void IndexOfItemNotInList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.AreEqual(-1, factory.View.IndexOf(bbb));
    }

    [Test]
    public void Insert()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      view.Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.ListChangedAddedCount);

      var item = list[1];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }

    [Test]
    public void InsertIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      factory.View.Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
      Assert.AreEqual(4, factory.View.Count);
      Assert.AreEqual(1, factory.ListChangedAddedCount);

      var item = factory.List[1];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }

    [Test]
    public void RemoveAt()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var removingIndex = -1;
      factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      factory.View.RemoveAt(0);

      Assert.AreEqual(2, list.Count);
      Assert.AreEqual("bbb", list[0].StringValue);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(0, removingIndex);
    }

    [Test]
    public void RemoveAtIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var removingIndex = -1;
      factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      factory.View.RemoveAt(0);

      Assert.AreEqual(2, factory.List.Count);
      Assert.AreEqual("bbb", (factory.List[0]).StringValue);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(0, removingIndex);
    }

    [Test]
    public void ItemGet()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var item = factory.View[1];
      Assert.AreEqual(bbb, item);
    }

    [Test]
    public void ItemSet()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      factory.View[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

      Assert.AreEqual(1, factory.ListChangedItemChangedCount);

      var item = factory.List[1];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }

    [Test]
    public void ItemSetIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      factory.View[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

      Assert.AreEqual(1, factory.ListChangedItemChangedCount);

      var item = factory.List[1];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }
  }
}

#endif