
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class ICollectionTTests
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

			view.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

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

			factory.View.Add(new SimpleClass(200, "ddd", new DateTime(1963, 3, 9)));

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

			factory.View.Clear();
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

			factory.View.Clear();
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

			Assert.IsTrue(view.Contains(bbb));
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

			Assert.IsFalse(view.Contains(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1))));	// reference compare only for SimpleClass
		}

		[Test]
		public void CopyTo()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			SimpleClass[] array = new SimpleClass[3];
			factory.View.CopyTo(array, 0);

			SimpleClass item = array[0];
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
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			SimpleClass[] array = new SimpleClass[0];
			factory.View.CopyTo(array, 0);
		}

		[Test]
		public void Count()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.AreEqual(list.Count, factory.View.Count);
		}

		[Test]
		public void CountEmptyList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.AreEqual(0, factory.View.Count);
		}

		[Test]
		public void IsReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.AreEqual(factory.List.IsReadOnly, factory.View.IsReadOnly);
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
			view.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

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
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			SimpleClass bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			int removingIndex = -1;
			view.RemovingItem += delegate(object sender, RemovingItemEventArgs args)
			{
				removingIndex = args.Index;
			};

			Assert.IsTrue(factory.View.Remove(bbb));
			Assert.AreEqual(2, factory.List.Count);
			Assert.AreEqual("ccc", factory.List[1].StringValue);
			Assert.AreEqual(1, factory.RemovingItemCount);
			Assert.AreEqual(1, removingIndex);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}
	}
}
#endif