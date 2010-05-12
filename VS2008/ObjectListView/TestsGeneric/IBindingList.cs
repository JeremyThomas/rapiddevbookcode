
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class IBindingListTests
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void AddIndexNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			((IBindingList)factory.View).AddIndex(null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void AddIndexNotInType()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			PropertyDescriptorCollection dateProps = TypeDescriptor.GetProperties(typeof(DateTime));
			((IBindingList)factory.View).AddIndex(dateProps[0]);
		}

		[Test]
		public void AddIndexPopulatedList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)factory.View).AddIndex(simpleProps[0]);
		}

		[Test]
		public void AddNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			object added = view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView<SimpleClass>);

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;
			Assert.IsNotNull(item);

			Assert.AreEqual(-1, item.IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewUserObject()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			view.AddingNew += delegate(object sender, ObjectListView<SimpleClass>.AddingNewEventArgs e)
			{
				e.NewObject = new SimpleClass(5, "55", new DateTime(1955, 5, 5));
			};

			object added = view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView<SimpleClass>);

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;
			Assert.IsNotNull(item);

			Assert.AreEqual(5, item.IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
		}

		[Test]
		[ExpectedException(typeof(NotSupportedException))]
		public void AddNewAndEndEdit()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			ObjectView<SimpleClass> added = (ObjectView<SimpleClass>)factory.View.AddNew();
			added.EndEdit();
		}

		[Test]
		[ExpectedException(typeof(NotSupportedException))]
		public void AddNewAndCancelEdit()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			ObjectView<SimpleClass> added = (ObjectView<SimpleClass>)factory.View.AddNew();
			added.CancelEdit();
		}

		[Test]
		public void AddNewEditableObject()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			object added = view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView<SimpleEditableObject>);

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;
			Assert.IsNotNull(item);

			Assert.AreEqual(-1, item.IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewExplicitEditableObject()
		{
			ViewFactory<ExplicitEditableObject> factory = ViewFactory<ExplicitEditableObject>.IList();
			ObjectListView<ExplicitEditableObject> view = factory.View;

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			object added = view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView<ExplicitEditableObject>);

			ExplicitEditableObject item = ((ObjectView<ExplicitEditableObject>)added).Object;
			Assert.IsNotNull(item);

			Assert.AreEqual(-1, item.IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewEditableObjectAndEndEdit()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			ObjectView<SimpleEditableObject> item = (ObjectView<SimpleEditableObject>)view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);

			item.EndEdit();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(5, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewExplicitEditableObjectAndEndEdit()
		{
			ViewFactory<ExplicitEditableObject> factory = ViewFactory<ExplicitEditableObject>.IList();
			ObjectListView<ExplicitEditableObject> view = factory.View;

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			ObjectView<ExplicitEditableObject> item = (ObjectView<ExplicitEditableObject>)view.AddNew();
			Assert.AreEqual(4, factory.ListChangedAddedCount);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);

			item.EndEdit();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(5, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewEditableObjectAndCancelEdit()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			ObjectView<SimpleEditableObject> item = (ObjectView<SimpleEditableObject>)view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);

			item.CancelEdit();

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}

		[Test]
		public void AddNewExplicitEditableObjectAndCancelEdit()
		{
			ViewFactory<ExplicitEditableObject> factory = ViewFactory<ExplicitEditableObject>.IList();
			ObjectListView<ExplicitEditableObject> view = factory.View;

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, factory.ListChangedAddedCount);

			ObjectView<ExplicitEditableObject> item = (ObjectView<ExplicitEditableObject>)view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);

			item.CancelEdit();

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, factory.AddingNewCount);
			Assert.AreEqual(4, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}

		[Test]
		public void AddNewEditableObjectSorted()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			// Until the added item is committed, it should be at the end of the collection.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedEndNew()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, it should be placed into the sort.
			Assert.AreEqual(0, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectFiltered()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectFilteredEndNew()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedFiltered()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedFilteredEndNew()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = ((ObjectView<SimpleEditableObject>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewSorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			// Until the added item is committed, it should be at the end of the collection.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedEndNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, it should be placed into the sort.
			Assert.AreEqual(0, view.IndexOf(item));
		}

		[Test]
		public void AddNewFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));
			view.Add(new SimpleClass(-1, "1", DateTime.Now));
			view.Add(new SimpleClass(-2, "1", DateTime.Now));
			view.Add(new SimpleClass(-3, "1", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue > -1; };

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewFilteredEndNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue > -1; };

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			view.Filter = "IntegerValue > -1";

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedFilteredEndNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			view.Filter = "IntegerValue > -1";

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = ((ObjectView<SimpleClass>)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AllowEditDefault()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsTrue(factory.View.AllowEdit);
		}

		[Test]
		public void AllowEditDefaultReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			Assert.IsFalse(factory.View.AllowEdit);
		}

		[Test]
		public void AllowEditSetTrue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowEdit = true;
			Assert.IsTrue(factory.View.AllowEdit);
		}

		[Test]
		public void AllowEditSetFalse()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowEdit = false;
			Assert.IsFalse(factory.View.AllowEdit);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowEditSetTrueReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowEdit = true;
		}

		[Test]
		public void AllowEditSetFalseReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowEdit = false;
			Assert.IsFalse(factory.View.AllowEdit);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowEditSetFalseEdit()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.List.Add(new SimpleClass());
			factory.View.AllowEdit = false;
			factory.View[0] = new SimpleClass();
		}

		[Test]
		public void AllowNewDefault()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsTrue(factory.View.AllowNew);
		}

		[Test]
		public void AllowNewDefaultReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			Assert.IsFalse(factory.View.AllowNew);
		}

		[Test]
		public void AllowNewSetTrue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowNew = true;
			Assert.IsTrue(factory.View.AllowNew);
		}

		[Test]
		public void AllowNewSetFalse()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowNew = false;
			Assert.IsFalse(factory.View.AllowNew);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowNewSetTrueReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowNew = true;
		}

		[Test]
		public void AllowNewSetFalseReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowNew = false;
			Assert.IsFalse(factory.View.AllowNew);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseAdd()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowNew = false;
			factory.View.Add(new SimpleClass());
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseAddNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowNew = false;
			factory.View.AddNew();
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseInsert()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowNew = false;
			factory.View.Insert(0, new SimpleClass());
		}

		[Test]
		public void AllowRemoveDefault()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsTrue(factory.View.AllowRemove);
		}

		[Test]
		public void AllowRemoveDefaultReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			Assert.IsFalse(factory.View.AllowRemove);
		}

		[Test]
		public void AllowRemoveSetTrue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowRemove = true;
			Assert.IsTrue(factory.View.AllowRemove);
		}

		[Test]
		public void AllowRemoveSetFalse()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			factory.View.AllowRemove = false;
			Assert.IsFalse(factory.View.AllowRemove);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowRemoveSetTrueReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowRemove = true;
		}

		[Test]
		public void AllowRemoveSetFalseReadOnly()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IListReadOnly();
			factory.View.AllowRemove = false;
			Assert.IsFalse(factory.View.AllowRemove);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowRemoveSetFalseRemove()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			SimpleClass item = new SimpleClass();
			factory.View.Add(item);
			factory.View.AllowRemove = false;
			factory.View.Remove(item);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowRemoveSetFalseRemoveAt()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			SimpleClass item = new SimpleClass();
			factory.View.Add(item);
			factory.View.AllowRemove = false;
			factory.View.RemoveAt(0);
		}

		[Test]
		public void ApplySort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			Assert.AreEqual(1, factory.ListChangedResetCount);

			IEnumerator<SimpleClass> pos = view.GetEnumerator();

			pos.MoveNext();
			SimpleClass val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(60, val.IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(80, val.IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(100, val.IntegerValue);
		}

		[Test]
		public void ApplySortDescending()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["StringValue"], ListSortDirection.Descending);
			Assert.AreEqual(1, factory.ListChangedResetCount);

			IEnumerator<SimpleClass> pos = view.GetEnumerator();

			pos.MoveNext();
			SimpleClass val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual("ccc", val.StringValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual("bbb", val.StringValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual("aaa", val.StringValue);
		}

		[Test]
		public void ApplySortNullable()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now, new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now, null));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now, new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now, new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", DateTime.Now, new DateTime(1993, 11, 12)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["NullableDateTimeValue"], ListSortDirection.Ascending);

			IEnumerator<SimpleClass> pos = view.GetEnumerator();

			pos.MoveNext();
			SimpleClass val = pos.Current;
			Assert.AreEqual(null, val.NullableDateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(val.NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1991, 1, 2), val.NullableDateTimeValue.Value);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(val.NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1991, 3, 5), val.NullableDateTimeValue.Value);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(val.NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1992, 3, 5), val.NullableDateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(val.NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1993, 11, 12), val.NullableDateTimeValue);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ApplySortInvalidProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(DateTime));
			factory.View.ApplySort(props["Day"], ListSortDirection.Ascending);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ApplySortIncomparableProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));

			factory.View.ApplySort(props["IncomparableValue"], ListSortDirection.Ascending);
		}

		[Test]
		public void ApplySortNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(null, ListSortDirection.Ascending);
			Assert.AreEqual(0, factory.ListChangedResetCount);

			IEnumerator<SimpleClass> pos = view.GetEnumerator();

			pos.MoveNext();
			SimpleClass val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(100, val.IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(80, val.IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.AreEqual(60, val.IntegerValue);
		}

		[Test]
		public void Find()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			int index = ((IBindingList)view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
			Assert.AreEqual(2, index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FindNullProp()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			((IBindingList)factory.View).Find((PropertyDescriptor)null, new DateTime(1975, 6, 6));
		}

		[Test]
		public void FindSorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			int index = ((IBindingList)view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
			Assert.AreEqual(1, index);
		}

		[Test]
		public void IsSortedUnsorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsFalse(factory.View.IsSorted);
		}

		[Test]
		public void IsSortedSorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			factory.View.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			Assert.IsTrue(factory.View.IsSorted);
		}

		[Test]
		public void IsSortedSortedRemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			view.RemoveSort();
			Assert.IsFalse(view.IsSorted);
		}

		[Test]
		public void IsSortedUnsortedRemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.RemoveSort();
			Assert.IsFalse(view.IsSorted);
		}

		[Test]
		public void RemoveIndex()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)factory.View).RemoveIndex(simpleProps[0]);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void RemoveIndexNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			((IBindingList)factory.View).RemoveIndex(null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void RemoveIndexNotInType()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			PropertyDescriptorCollection dateProps = TypeDescriptor.GetProperties(typeof(DateTime));
			((IBindingList)factory.View).RemoveIndex(dateProps[0]);
		}

		[Test]
		public void RemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			view.RemoveSort();
			Assert.AreEqual(2, factory.ListChangedResetCount);		// once for apply, once for remove

			Assert.AreEqual(100, view[0].IntegerValue);
		}

		[Test]
		public void RemoveSortNoApplySort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			view.RemoveSort();
			Assert.AreEqual(0, factory.ListChangedResetCount);		// no sort prior to remove; no-op

			Assert.AreEqual(100, view[0].IntegerValue);
		}

		[Test]
		public void RemoveSortMultiple()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			view.RemoveSort();
			view.RemoveSort();
			Assert.AreEqual(2, factory.ListChangedResetCount);		// once for the apply, and once for the first remove

			Assert.AreEqual(100, view[0].IntegerValue);
		}

		[Test]
		public void SortDirectionAscending()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
		}

		[Test]
		public void SortDirectionDescending()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			Assert.AreEqual(ListSortDirection.Descending, view.SortDirection);
		}

		[Test]
		public void SortDirectionNoSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.AreEqual(ListSortDirection.Ascending, factory.View.SortDirection);
		}

		[Test]
		public void SortDirectionAfterRemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			view.RemoveSort();
			Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
		}

		[Test]
		public void SortProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);
			Assert.AreEqual(intProp, view.SortProperty);
		}

		[Test]
		public void SortPropertyNoSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsNull(factory.View.SortProperty);
		}

		[Test]
		public void SortPropertyAfterRemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			view.RemoveSort();
			Assert.IsNull(view.SortProperty);
		}

		[Test]
		public void SortAddItem()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(1, "aaa", DateTime.Now));
			view.Add(new SimpleClass(4, "bbb", DateTime.Now));
			view.Add(new SimpleClass(3, "ccc", DateTime.Now));
			view.Add(new SimpleClass(2, "ddd", DateTime.Now));
			view.Add(new SimpleClass(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("aaa", view[4].StringValue);

			view.Add(new SimpleClass(5, "fff", DateTime.Now));

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("fff", view[1].StringValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual("ccc", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
			Assert.AreEqual("aaa", view[5].StringValue);
		}

		[Test]
		public void SortAddItemListDirect()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(1, "aaa", DateTime.Now));
			view.Add(new SimpleClass(4, "bbb", DateTime.Now));
			view.Add(new SimpleClass(3, "ccc", DateTime.Now));
			view.Add(new SimpleClass(2, "ddd", DateTime.Now));
			view.Add(new SimpleClass(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("aaa", view[4].StringValue);

			factory.List.Add(new SimpleClass(5, "fff", DateTime.Now));

			// This works because as soon as we access the view again, the sort indexes are found dirty and are rebuilt.
			// Dirty detection works only for add/delete, not item change.
			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("fff", view[1].StringValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual("ccc", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
			Assert.AreEqual("aaa", view[5].StringValue);
		}

		[Test]
		public void SortChangeItem()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IList();
			ObjectListView<NotifyingListItem> view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(4, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(NotifyingListItem));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("aaa", view[4].StringValue);

			// Change bbb from 4 to -1 (putting it at the end of the sort.
			factory.List[1].IntegerValue = -1;

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("ccc", view[1].StringValue);
			Assert.AreEqual("ddd", view[2].StringValue);
			Assert.AreEqual("aaa", view[3].StringValue);
			Assert.AreEqual("bbb", view[4].StringValue);
		}

		[Test]
		public void SupportsChangeNotification()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			// List<> does not implement ListChanged, but the wrapper must report true.
			Assert.IsTrue(((IBindingListView)factory.View).SupportsChangeNotification);
		}

		[Test]
		public void SupportsChangeNotificationIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();

			// BindingList<> implements ListChanged via IBindingList.
			Assert.IsTrue(((IBindingListView)factory.View).SupportsChangeNotification);
		}

		[Test]
		public void SupportsChangeNotificationNotifyingList()
		{
			ObjectListView<SimpleClass> view = new ObjectListView<SimpleClass>(new NotifyingList<SimpleClass>());

			// NotifyingList<> implements ListChanged via matching event declaration.
			Assert.IsTrue(((IBindingListView)view).SupportsChangeNotification);
		}

		/// <summary>
		/// List items that don't support INotifyPropertyChanged or xxxChanged shouldn't cause ListChanged to be raised.
		/// </summary>
		[Test]
		public void ListChangedSimpleItemChanged()
		{
			BindingList<SimpleEditableObject> list = new BindingList<SimpleEditableObject>();
			SimpleEditableObject item = new SimpleEditableObject();
			list.Add(item);

			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IBindingList(list);

			factory.ClearEventCounts();

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);

			item.IntegerValue++;

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		/// <summary>
		/// List items that support INotifyPropertyChanged will cause ListChanged to be raised.
		/// </summary>
		[Test]
		public void ListChangedNotifyingItemChanged()
		{
			BindingList<NotifyingListItem> list = new BindingList<NotifyingListItem>();
			NotifyingListItem item = new NotifyingListItem();
			list.Add(item);

			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList(list);

			factory.ClearEventCounts();

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);

			item.IntegerValue++;

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		/// <summary>
		/// List items that support xxxChanged events will cause ListChanged to be raised.
		/// </summary>
		[Test]
		public void ListChangedNotifyingEventItemChanged()
		{
			BindingList<NotifyingListItemEvents> list = new BindingList<NotifyingListItemEvents>();
			NotifyingListItemEvents item = new NotifyingListItemEvents();
			list.Add(item);

			ViewFactory<NotifyingListItemEvents> factory = ViewFactory<NotifyingListItemEvents>.IBindingList(list);

			factory.ClearEventCounts();

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);

			item.IntegerValue++;

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		[Test]
		public void ListChangedItemReplaced()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			SimpleClass item = new SimpleClass(50, "555", new DateTime(1955, 5, 5));

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);

			list[2] = item;

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		[Test]
		public void ListChangedItemReplacedAndUpdated()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList();
			IList<NotifyingListItem> list = factory.List;

			list.Add(new NotifyingListItem(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new NotifyingListItem(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new NotifyingListItem(60, "ccc", new DateTime(1975, 6, 6)));

			factory.ClearEventCounts();

			NotifyingListItem item = new NotifyingListItem(50, "555", new DateTime(1955, 5, 5));
			list[2] = item;
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);

			item.IntegerValue = 60;
			Assert.AreEqual(2, factory.ListChangedItemChangedCount);
		}

		[Test]
		public void SupportsSearching()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			Assert.IsTrue(((IBindingListView)factory.View).SupportsSearching);
		}

		[Test]
		public void SupportsSorting()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			Assert.IsTrue(((IBindingListView)factory.View).SupportsSorting);
		}

		[Test]
		public void SupportsSortingNoProps()
		{
			ObjectListView<int> view = new ObjectListView<int>(new List<int>());
			Assert.IsFalse(((IBindingListView)view).SupportsSorting);
		}
	}
}
#endif