
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class IListTests
	{
		[Test]
		public void Add()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			Assert.AreEqual(3, view.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9))));
			Assert.AreEqual(4, list.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);

			object item = list[3];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}

		[Test]
		public void AddIBindingList()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			Assert.AreEqual(3, factory.View.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9))));
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
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			view.Clear();

			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(0, list.Count);
		}

		[Test]
		public void ClearIBindingList()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			object item = factory.CreateItem();
			factory.List.Add(item);
			factory.ClearEventCounts();

			factory.View.Clear();
			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.List.Count);
		}

		[Test]
		public void ContainsItemInList()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.IsTrue(view.Contains(bbb));
		}

		[Test]
		public void ContainsItemNotInList()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.IsFalse(view.Contains(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1))));	// reference compare only for SimpleClass
		}

		[Test]
		public void IndexOf()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.AreEqual(1, view.IndexOf(bbb));
		}

		[Test]
		public void Insert()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			view.Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			object item = list[1];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}

		[Test]
		public void InsertIBindingList()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			factory.View.Insert(1, new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));
			Assert.AreEqual(4, factory.View.Count);
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			object item = factory.List[1];
			Assert.IsTrue(item is SimpleClass);
			Assert.AreEqual(200, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual("ddd", ((SimpleClass)item).StringValue);
			Assert.AreEqual(new DateTime(1963, 3, 9), ((SimpleClass)item).DateTimeValue);
		}

		[Test]
		public void IsFixedSize()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			Assert.AreEqual(list.IsFixedSize, view.IsFixedSize);
		}

		[Test]
		public void IsReadOnly()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			Assert.AreEqual(list.IsReadOnly, view.IsReadOnly);
		}

		[Test]
		public void Remove()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

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

			view.Remove(bbb);
			Assert.AreEqual(2, list.Count);
			Assert.AreEqual("ccc", ((SimpleClass)list[1]).StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(1, removingIndex);
		}

		[Test]
		public void RemoveNotInList()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			SimpleClass ddd = new SimpleClass(66, "ddd", new DateTime(1980, 12, 12));
			view.Remove(ddd);

			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.RemovingItemCount);
		}

		[Test]
		public void RemoveIBindingList()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			factory.List.Add(bbb);
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			factory.View.Remove(bbb);

			Assert.AreEqual(2, factory.List.Count);
			Assert.AreEqual("ccc", ((SimpleClass)factory.List[1]).StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(1, removingIndex);
		}

		[Test]
		public void RemoveAt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			view.RemoveAt(0);

			Assert.AreEqual(2, list.Count);
			Assert.AreEqual("bbb", ((SimpleClass)list[0]).StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(0, removingIndex);
		}

		[Test]
		public void RemoveAtIBindingList()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			factory.List.Add(bbb);
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			factory.View.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			factory.View.RemoveAt(0);

			Assert.AreEqual(2, factory.List.Count);
			Assert.AreEqual("bbb", ((SimpleClass)factory.List[0]).StringValue);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(0, removingIndex);
		}

		[Test]
		public void ItemGet()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			IList list = factory.List;
			ObjectListView view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			factory.List.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			object item = view[1];
			Assert.AreEqual(bbb, item);
		}

		[Test]
		public void ItemSet()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			factory.View[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

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
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			factory.View[1] = new SimpleClass(200, "ddd", new DateTime(1963, 3, 9));

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