// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class IListTests
	{
		[Test]
		public void Add()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			((IList)view).Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

			Assert.AreEqual(4, list.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);

			SimpleClass item = list[3];
			Assert.AreEqual(200, item.IntegerValue);
			Assert.AreEqual("ddd", item.StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
		}

		[Test]
		public void AddIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			Assert.AreEqual(3, ((IList)factory.View).Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9))));
			Assert.AreEqual(4, factory.List.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);

			object item = factory.List[3];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}

		[Test]
		public void Clear()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			SimpleClass item = factory.CreateItem();
			factory.List.Add(item);
			factory.ClearEventCounts();

			((IList)factory.View).Clear();
			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.List.Count);
		}

		[Test]
		public void ClearIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();

			SimpleClass item = factory.CreateItem();
			factory.List.Add(item);
			factory.ClearEventCounts();

			((IList)factory.View).Clear();
			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.List.Count);
		}

		[Test]
		public void ContainsItemInList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.IsTrue(((IList)view).Contains(bbb));
		}

		[Test]
		public void ContainsItemNotInList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.IsFalse(((IList)view).Contains(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1))));	// reference compare only for SimpleClass
		}

		[Test]
		public void IndexOf()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.AreEqual(1, ((IList)factory.View).IndexOf(bbb));
		}

		[Test]
		public void IndexOfItemNotInList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.AreEqual(-1, ((IList)factory.View).IndexOf(bbb));
		}

		[Test]
		public void Insert()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			((IList)view).Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			SimpleClass item = list[1];
			Assert.AreEqual(200, item.IntegerValue);
			Assert.AreEqual("ddd", item.StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
		}

		[Test]
		public void InsertIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			((IList)factory.View).Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
			Assert.AreEqual(4, factory.View.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			SimpleClass item = factory.List[1];
			Assert.AreEqual(200, item.IntegerValue);
			Assert.AreEqual("ddd", item.StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), item.DateTimeValue);
		}

		[Test]
		public void IsFixedSize()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsFalse(((IList)factory.View).IsFixedSize);
		}

		[Test]
		public void IsReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsFalse(((IList)factory.View).IsReadOnly);
		}

		[Test]
		public void Remove()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			((IList)view).Remove(bbb);

			Assert.AreEqual(2, list.Count);
			Assert.AreEqual("ccc", list[1].StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(1, removingIndex);
		}

		[Test]
		public void RemoveNotInList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			SimpleClass ddd = new SimpleClass(66, "ddd", new DateTime(1980, 12, 12));
			((IList)view).Remove(ddd);
			Assert.AreEqual(0, factory.RemovingItemCount);
		}

		[Test]
		public void RemoveIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			((IList)factory.View).Remove(bbb);

			Assert.AreEqual(2, factory.List.Count);
			Assert.AreEqual("ccc", factory.List[1].StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(1, removingIndex);
		}

		[Test]
		public void RemoveAt()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			((IList)factory.View).RemoveAt(0);

			Assert.AreEqual(2, list.Count);
			Assert.AreEqual("bbb", list[0].StringValue);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(0, removingIndex);
		}

		[Test]
		public void RemoveAtIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			((IList)factory.View).RemoveAt(0);

			Assert.AreEqual(2, factory.List.Count);
			Assert.AreEqual("bbb", ((SimpleClass)factory.List[0]).StringValue);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(0, removingIndex);
		}

		[Test]
		public void ItemGet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			object item = ((IList)factory.View)[1];
			Assert.AreEqual(bbb, item);
		}

		[Test]
		public void ItemSet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			((IList)factory.View)[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

			Assert.AreEqual(1, factory.ListChangedItemChangedCount);

			object item = factory.List[1];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}

		[Test]
		public void ItemSetIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			((IList)factory.View)[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

			Assert.AreEqual(1, factory.ListChangedItemChangedCount);

			object item = factory.List[1];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}
	}
}
#endif
