#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class IListTests
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

      ((IList) view).Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

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

      Assert.AreEqual(3, ((IList) factory.View).Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9))));
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

      ((IList) factory.View).Clear();
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

      ((IList) factory.View).Clear();
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

      Assert.IsTrue(((IList) view).Contains(bbb));
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

      Assert.IsFalse(((IList) view).Contains(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)))); // reference compare only for SimpleClass
    }

    [Test]
    public void IndexOf()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.AreEqual(1, ((IList) factory.View).IndexOf(bbb));
    }

    [Test]
    public void IndexOfItemNotInList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      Assert.AreEqual(-1, ((IList) factory.View).IndexOf(bbb));
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

      ((IList) view).Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
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

      ((IList) factory.View).Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
      Assert.AreEqual(4, factory.View.Count);
      Assert.AreEqual(1, factory.ListChangedAddedCount);

      var item = factory.List[1];
      Assert.AreEqual(200, item.IntegerValue);
      Assert.AreEqual("ddd", item.StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
    }

    [Test]
    public void IsFixedSize()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsFalse(((IList) factory.View).IsFixedSize);
    }

    [Test]
    public void IsReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsFalse(((IList) factory.View).IsReadOnly);
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
      factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      ((IList) view).Remove(bbb);

      Assert.AreEqual(2, list.Count);
      Assert.AreEqual("ccc", list[1].StringValue);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(1, removingIndex);
    }

    [Test]
    public void RemoveNotInList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      var bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
      list.Add(bbb);
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var ddd = new SimpleClass(66, "ddd", new DateTime(1980, 12, 12));
      ((IList) view).Remove(ddd);
      Assert.AreEqual(0, factory.RemovingItemCount);
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
      factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      ((IList) factory.View).Remove(bbb);

      Assert.AreEqual(2, factory.List.Count);
      Assert.AreEqual("ccc", factory.List[1].StringValue);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.RemovingItemCount);
      Assert.AreEqual(1, removingIndex);
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

      ((IList) factory.View).RemoveAt(0);

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

      var removingIndex = -1;
      factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args) { removingIndex = args.Index; };

      ((IList) factory.View).RemoveAt(0);

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

      var item = ((IList) factory.View)[1];
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

      ((IList) factory.View)[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

      Assert.AreEqual(1, factory.ListChangedItemChangedCount);

      object item = factory.List[1];
      Assert.IsTrue(item is SimpleClass);
      Assert.AreEqual(200, ((SimpleClass) item).IntegerValue);
      Assert.AreEqual("ddd", ((SimpleClass) item).StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass) item).DateTimeValue);
    }

    [Test]
    public void ItemSetIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      ((IList) factory.View)[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

      Assert.AreEqual(1, factory.ListChangedItemChangedCount);

      object item = factory.List[1];
      Assert.IsTrue(item is SimpleClass);
      Assert.AreEqual(200, ((SimpleClass) item).IntegerValue);
      Assert.AreEqual("ddd", ((SimpleClass) item).StringValue);
      Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass) item).DateTimeValue);
    }
  }
}

#endif