
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class IBindingListTests
	{
		private List<SimpleClass> list;
		private SimpleClass bbb;
		private ObjectListView view;
		private int addingNewRaised;
		private int listChangedAddedRaised;
		private int listChangedDeletedRaised;
		private int listChangedResetRaised;
		private int listChangedItemChangedRaised;

		[SetUp]
		public void Setup()
		{
			list = new List<SimpleClass>();

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));

			bbb = new SimpleClass(80, "bbb", new DateTime(1980, 12, 12));
			list.Add(bbb);

			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			view = new ObjectListView(list);

			SetupListEventHandlers(view);
		}

		private void SetupListEventHandlers(ObjectListView view)
		{
			this.addingNewRaised = 0;
			this.listChangedAddedRaised = 0;
			this.listChangedDeletedRaised = 0;
			this.listChangedResetRaised = 0;
			this.listChangedItemChangedRaised = 0;

			view.AddingNew += delegate(object sender, AddingNewEventArgs e)
			{
				this.addingNewRaised++;
			};

			view.ListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				switch (e.ListChangedType)
				{
					case ListChangedType.ItemAdded:
						this.listChangedAddedRaised++;
						break;
					case ListChangedType.ItemDeleted:
						this.listChangedDeletedRaised++;
						break;
					case ListChangedType.Reset:
						this.listChangedResetRaised++;
						break;
					case ListChangedType.ItemChanged:
						this.listChangedItemChangedRaised++;
						break;
				}
			};
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void AddIndexNull()
		{
			((IBindingList)view).AddIndex(null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void AddIndexNotInType()
		{
			PropertyDescriptorCollection dateProps = TypeDescriptor.GetProperties(typeof(DateTime));
			((IBindingList)view).AddIndex(dateProps[0]);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AddIndexListItemTypeNotSet()
		{
			view = new ObjectListView(new ArrayList());
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)view).AddIndex(simpleProps[0]);
		}

		[Test]
		public void AddIndexPopulatedList()
		{
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)view).AddIndex(simpleProps[0]);
		}

		[Test]
		public void AddIndexListItemTypeSet()
		{
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ItemType = typeof(SimpleClass);
			((IBindingList)view).AddIndex(simpleProps[0]);
		}

		[Test]
		public void AddNew()
		{
			object added = this.view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView);

			object item = ((ObjectView)added).Object;
			Assert.IsNotNull(item);
			Assert.IsTrue(item is SimpleClass);

			Assert.AreEqual(-1, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(1, listChangedAddedRaised);
		}

		[Test]
		public void AddNewUserObject()
		{
			this.view.AddingNew += delegate(object sender, AddingNewEventArgs e)
			{
				e.NewObject = new SimpleClass(5, "55", new DateTime(1955, 5, 5));
			};

			object added = this.view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView);

			object item = ((ObjectView)added).Object;
			Assert.IsNotNull(item);
			Assert.IsTrue(item is SimpleClass);

			Assert.AreEqual(5, ((SimpleClass)item).IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(1, listChangedAddedRaised);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void AddNewUserObjectInvalidType()
		{
			this.view.AddingNew += delegate(object sender, AddingNewEventArgs e)
			{
				e.NewObject = DateTime.Now;
			};

			object added = this.view.AddNew();
		}

		[Test]
		[ExpectedException(typeof(NotSupportedException))]
		public void AddNewAndEndEdit()
		{
			ObjectView added = (ObjectView)this.view.AddNew();
			added.EndEdit();
		}

		[Test]
		[ExpectedException(typeof(NotSupportedException))]
		public void AddNewAndCancelEdit()
		{
			ObjectView added = (ObjectView)this.view.AddNew();
			added.CancelEdit();
		}

		[Test]
		public void AddNewEditableObject()
		{
			view = new ObjectListView(new ArrayList());
			SetupListEventHandlers(view);

			view.ItemType = typeof(SimpleEditableObject);

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			object added = this.view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView);

			object item = ((ObjectView)added).Object;
			Assert.IsNotNull(item);
			Assert.IsTrue(item is SimpleEditableObject);

			Assert.AreEqual(-1, ((SimpleEditableObject)item).IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);
		}

		[Test]
		public void AddNewExplicitEditableObject()
		{
			view = new ObjectListView(new ArrayList());
			this.SetupListEventHandlers(view);

			view.ItemType = typeof(ExplicitEditableObject);

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			object added = this.view.AddNew();
			Assert.IsNotNull(added);
			Assert.IsTrue(added is ObjectView);

			object item = ((ObjectView)added).Object;
			Assert.IsNotNull(item);
			Assert.IsTrue(item is ExplicitEditableObject);

			Assert.AreEqual(-1, ((ExplicitEditableObject)item).IntegerValue);
			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);
		}

		[Test]
		public void AddNewEditableObjectAndEndEdit()
		{
			view = new ObjectListView(new ArrayList());
			this.SetupListEventHandlers(view);

			view.ItemType = typeof(SimpleEditableObject);

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			ObjectView item = (ObjectView)this.view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);

			item.EndEdit();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(5, listChangedAddedRaised);
		}

		[Test]
		public void AddNewExplicitEditableObjectAndEndEdit()
		{
			view = new ObjectListView(new ArrayList());
			this.SetupListEventHandlers(view);

			view.ItemType = typeof(ExplicitEditableObject);

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			ObjectView item = (ObjectView)this.view.AddNew();
			Assert.AreEqual(4, listChangedAddedRaised);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);

			item.EndEdit();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(5, listChangedAddedRaised);
		}

		[Test]
		public void AddNewEditableObjectAndCancelEdit()
		{
			view = new ObjectListView(new ArrayList());
			this.SetupListEventHandlers(view);

			view.ItemType = typeof(SimpleEditableObject);

			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			ObjectView item = (ObjectView)this.view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);

			item.CancelEdit();

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);
			Assert.AreEqual(1, listChangedDeletedRaised);
		}

		[Test]
		public void AddNewExplicitEditableObjectAndCancelEdit()
		{
			view = new ObjectListView(new ArrayList());
			this.SetupListEventHandlers(view);

			view.ItemType = typeof(ExplicitEditableObject);

			view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
			Assert.AreEqual(1, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
			Assert.AreEqual(2, listChangedAddedRaised);
			view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
			Assert.AreEqual(3, listChangedAddedRaised);

			ObjectView item = (ObjectView)this.view.AddNew();

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);

			item.CancelEdit();

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, addingNewRaised);
			Assert.AreEqual(4, listChangedAddedRaised);
			Assert.AreEqual(1, listChangedDeletedRaised);
		}

		[Test]
		public void AddNewEditableObjectSorted()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			// Until the added item is committed, it should be at the end of the collection.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedEndNew()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, it should be placed into the sort.
			Assert.AreEqual(0, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectFiltered()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject)listItem).IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectFilteredEndNew()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject)listItem).IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedFiltered()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject)listItem).IntegerValue > -1; };

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewEditableObjectSortedFilteredEndNew()
		{
			ViewFactory factory = ViewFactory.IListIEditableObjectItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
			view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
			view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

			view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject)listItem).IntegerValue > -1; };

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleEditableObject))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleEditableObject item = (SimpleEditableObject)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewSorted()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			// Until the added item is committed, it should be at the end of the collection.
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedEndNew()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, it should be placed into the sort.
			Assert.AreEqual(0, view.IndexOf(item));
		}

		[Test]
		public void AddNewFiltered()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));
			view.Add(new SimpleClass(-1, "1", DateTime.Now));
			view.Add(new SimpleClass(-2, "1", DateTime.Now));
			view.Add(new SimpleClass(-3, "1", DateTime.Now));

			view.FilterPredicate = delegate(object listItem) { return ((SimpleClass)listItem).IntegerValue > -1; };

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewFilteredEndNew()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			view.FilterPredicate = delegate(object listItem) { return ((SimpleClass)listItem).IntegerValue > -1; };

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedFiltered()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			view.Filter = "IntegerValue > -1";

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			// Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
			Assert.AreEqual(3, view.IndexOf(item));
		}

		[Test]
		public void AddNewSortedFilteredEndNew()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = factory.ListItemType;

			view.Add(new SimpleClass(3, "3", DateTime.Now));
			view.Add(new SimpleClass(2, "2", DateTime.Now));
			view.Add(new SimpleClass(1, "1", DateTime.Now));

			view.Filter = "IntegerValue > -1";

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(SimpleClass))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			object added = view.AddNew();

			SimpleClass item = (SimpleClass)((ObjectView)added).Object;

			int index = view.IndexOf(item);

			((ICancelAddNew)view).EndNew(index);

			// After committing the item, the filter should be applied and the object not visible through the view.
			Assert.AreEqual(-1, view.IndexOf(item));
		}

		[Test]
		public void AllowEditDefault()
		{
			Assert.IsTrue(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditDefaultReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			Assert.IsFalse(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditDefaultFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			Assert.IsTrue(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditSetTrue()
		{
			this.view.AllowEdit = true;
			Assert.IsTrue(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditSetFalse()
		{
			this.view.AllowEdit = false;
			Assert.IsFalse(this.view.AllowEdit);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowEditSetTrueReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowEdit = true;
		}

		[Test]
		public void AllowEditSetFalseReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowEdit = false;
			Assert.IsFalse(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditSetTrueFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowEdit = true;
			Assert.IsTrue(this.view.AllowEdit);
		}

		[Test]
		public void AllowEditSetFalseFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowEdit = false;
			Assert.IsFalse(this.view.AllowEdit);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowEditSetFalseEdit()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			factory.List.Add(new SimpleClass());
			factory.View.AllowEdit = false;
			factory.View[0] = new SimpleClass();
		}

		[Test]
		public void AllowNewDefault()
		{
			Assert.IsTrue(this.view.AllowNew);
		}

		[Test]
		public void AllowNewDefaultReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			Assert.IsFalse(this.view.AllowNew);
		}

		[Test]
		public void AllowNewDefaultFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			Assert.IsFalse(this.view.AllowNew);
		}

		[Test]
		public void AllowNewSetTrue()
		{
			this.view.AllowNew = true;
			Assert.IsTrue(this.view.AllowNew);
		}

		[Test]
		public void AllowNewSetFalse()
		{
			this.view.AllowNew = false;
			Assert.IsFalse(this.view.AllowNew);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowNewSetTrueReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowNew = true;
		}

		[Test]
		public void AllowNewSetFalseReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowNew = false;
			Assert.IsFalse(this.view.AllowNew);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowNewSetTrueFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowNew = true;
		}

		[Test]
		public void AllowNewSetFalseFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowNew = false;
			Assert.IsFalse(this.view.AllowNew);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseAdd()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			factory.View.AllowNew = false;
			factory.View.Add(new SimpleClass());
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseAddNew()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			factory.View.AllowNew = false;
			factory.View.AddNew();
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowNewSetFalseInsert()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			factory.View.AllowNew = false;
			factory.View.Insert(0, new SimpleClass());
		}

		[Test]
		public void AllowRemoveDefault()
		{
			Assert.IsTrue(this.view.AllowRemove);
		}

		[Test]
		public void AllowRemoveDefaultReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			Assert.IsFalse(this.view.AllowRemove);
		}

		[Test]
		public void AllowRemoveDefaultFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			Assert.IsFalse(this.view.AllowRemove);
		}

		[Test]
		public void AllowRemoveSetTrue()
		{
			this.view.AllowRemove = true;
			Assert.IsTrue(this.view.AllowRemove);
		}

		[Test]
		public void AllowRemoveSetFalse()
		{
			this.view.AllowRemove = false;
			Assert.IsFalse(this.view.AllowRemove);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowRemoveSetTrueReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowRemove = true;
		}

		[Test]
		public void AllowRemoveSetFalseReadOnly()
		{
			this.view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
			this.view.AllowRemove = false;
			Assert.IsFalse(this.view.AllowRemove);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AllowRemoveSetTrueFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowRemove = true;
		}

		[Test]
		public void AllowRemoveSetFalseFixedSize()
		{
			this.view = new ObjectListView(new int[5]);
			this.view.AllowRemove = false;
			Assert.IsFalse(this.view.AllowRemove);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowRemoveSetFalseRemove()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			SimpleClass item = new SimpleClass();
			factory.View.Add(item);
			factory.View.AllowRemove = false;
			factory.View.Remove(item);
		}

		[Test]
		[ExpectedException(typeof(DataException))]
		public void AllowRemoveSetFalseRemoveAt()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			SimpleClass item = new SimpleClass();
			factory.View.Add(item);
			factory.View.AllowRemove = false;
			factory.View.RemoveAt(0);
		}

		[Test]
		public void ApplySort()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			Assert.AreEqual(1, listChangedResetRaised);

			IEnumerator pos = this.view.GetEnumerator();

			pos.MoveNext();
			object val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(60, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(80, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(100, ((SimpleClass)val).IntegerValue);
		}

		[Test]
		public void ApplySortDescending()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["StringValue"], ListSortDirection.Descending);
			Assert.AreEqual(1, listChangedResetRaised);

			IEnumerator pos = this.view.GetEnumerator();

			pos.MoveNext();
			object val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual("ccc", ((SimpleClass)val).StringValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual("bbb", ((SimpleClass)val).StringValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual("aaa", ((SimpleClass)val).StringValue);
		}

		[Test]
		public void ApplySortNullable()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now, new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now, null));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now, new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now, new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", DateTime.Now, new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["NullableDateTimeValue"], ListSortDirection.Ascending);

			IEnumerator pos = view.GetEnumerator();

			pos.MoveNext();
			object val = pos.Current;
			Assert.AreEqual(null, ((SimpleClass)val).NullableDateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(((SimpleClass)val).NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1991, 1, 2), ((SimpleClass)val).NullableDateTimeValue.Value);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(((SimpleClass)val).NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1991, 3, 5), ((SimpleClass)val).NullableDateTimeValue.Value);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(((SimpleClass)val).NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1992, 3, 5), ((SimpleClass)val).NullableDateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsTrue(((SimpleClass)val).NullableDateTimeValue.HasValue);
			Assert.AreEqual(new DateTime(1993, 11, 12), ((SimpleClass)val).NullableDateTimeValue);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ApplySortInvalidProperty()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(DateTime));
			this.view.ApplySort(props["Day"], ListSortDirection.Ascending);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ApplySortIncomparableProperty()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			view.ItemType = typeof(SimpleClass);
			view.ApplySort(props["IncomparableValue"], ListSortDirection.Ascending);
		}

		[Test]
		public void ApplySortNull()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(null, ListSortDirection.Ascending);
			Assert.AreEqual(0, listChangedResetRaised);

			IEnumerator pos = this.view.GetEnumerator();

			pos.MoveNext();
			object val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(100, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(80, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(60, ((SimpleClass)val).IntegerValue);
		}

		[Test]
		public void Find()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			int index = ((IBindingList)this.view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
			Assert.AreEqual(2, index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FindNullProp()
		{
			((IBindingList)this.view).Find(null, new DateTime(1975, 6, 6));
		}

		[Test]
		public void FindSorted()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			int index = ((IBindingList)this.view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
			Assert.AreEqual(1, index);
		}

		[Test]
		public void IsSortedUnsorted()
		{
			Assert.IsFalse(this.view.IsSorted);
		}

		[Test]
		public void IsSortedSorted()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			Assert.IsTrue(this.view.IsSorted);
		}

		[Test]
		public void IsSortedSortedRemoveSort()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
			this.view.RemoveSort();
			Assert.IsFalse(this.view.IsSorted);
		}

		[Test]
		public void IsSortedUnsortedRemoveSort()
		{
			this.view.RemoveSort();
			Assert.IsFalse(this.view.IsSorted);
		}

		[Test]
		public void RemoveIndex()
		{
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)view).RemoveIndex(simpleProps[0]);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void RemoveIndexNull()
		{
			((IBindingList)view).RemoveIndex(null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void RemoveIndexNotInType()
		{
			PropertyDescriptorCollection dateProps = TypeDescriptor.GetProperties(typeof(DateTime));
			((IBindingList)view).RemoveIndex(dateProps[0]);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void RemoveIndexListItemTypeNotSet()
		{
			view = new ObjectListView(new ArrayList());
			PropertyDescriptorCollection simpleProps = TypeDescriptor.GetProperties(typeof(SimpleClass));
			((IBindingList)view).RemoveIndex(simpleProps[0]);
		}

		[Test]
		public void RemoveSort()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			this.view.RemoveSort();
			Assert.AreEqual(2, listChangedResetRaised);		// once for apply, once for remove

			Assert.AreEqual(100, ((SimpleClass)this.view[0]).IntegerValue);
		}

		[Test]
		public void RemoveSortNoApplySort()
		{
			this.view.RemoveSort();
			Assert.AreEqual(0, listChangedResetRaised);		// no sort prior to remove; no-op

			Assert.AreEqual(100, ((SimpleClass)this.view[0]).IntegerValue);
		}

		[Test]
		public void RemoveSortMultiple()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			this.view.RemoveSort();
			this.view.RemoveSort();
			Assert.AreEqual(2, listChangedResetRaised);		// once for the apply, and once for the first remove

			Assert.AreEqual(100, ((SimpleClass)this.view[0]).IntegerValue);
		}

		[Test]
		public void SortDirectionAscending()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
			Assert.AreEqual(ListSortDirection.Ascending, this.view.SortDirection);
		}

		[Test]
		public void SortDirectionDescending()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			Assert.AreEqual(ListSortDirection.Descending, this.view.SortDirection);
		}

		[Test]
		public void SortDirectionNoSort()
		{
			Assert.AreEqual(ListSortDirection.Ascending, this.view.SortDirection);
		}

		[Test]
		public void SortDirectionAfterRemoveSort()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			this.view.RemoveSort();
			Assert.AreEqual(ListSortDirection.Ascending, this.view.SortDirection);
		}

		[Test]
		public void SortProperty()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			this.view.ApplySort(intProp, ListSortDirection.Ascending);
			Assert.AreEqual(intProp, this.view.SortProperty);
		}

		[Test]
		public void SortPropertyNoSort()
		{
			Assert.IsNull(this.view.SortProperty);
		}

		[Test]
		public void SortPropertyAfterRemoveSort()
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			this.view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
			this.view.RemoveSort();
			Assert.IsNull(this.view.SortProperty);
		}

		[Test]
		public void SortAddItem()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;

			view.Add(new SimpleClass(1, "aaa", DateTime.Now));
			view.Add(new SimpleClass(4, "bbb", DateTime.Now));
			view.Add(new SimpleClass(3, "ccc", DateTime.Now));
			view.Add(new SimpleClass(2, "ddd", DateTime.Now));
			view.Add(new SimpleClass(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[4]).StringValue);

			view.Add(new SimpleClass(5, "fff", DateTime.Now));

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("fff", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[5]).StringValue);
		}

		[Test]
		public void SortAddItemListDirect()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;

			view.Add(new SimpleClass(1, "aaa", DateTime.Now));
			view.Add(new SimpleClass(4, "bbb", DateTime.Now));
			view.Add(new SimpleClass(3, "ccc", DateTime.Now));
			view.Add(new SimpleClass(2, "ddd", DateTime.Now));
			view.Add(new SimpleClass(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[4]).StringValue);

			factory.List.Add(new SimpleClass(5, "fff", DateTime.Now));

			// This works because as soon as we access the view again, the sort indexes are found dirty and are rebuilt.
			// Dirty detection works only for add/delete, not item change.
			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("fff", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[5]).StringValue);
		}

		[Test]
		public void SortChangeItem()
		{
			ViewFactory factory = ViewFactory.IListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(4, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(6, "eee", DateTime.Now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(NotifyingListItem));
			PropertyDescriptor intProp = props["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Descending);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", ((NotifyingListItem)view[0]).StringValue);
			Assert.AreEqual("bbb", ((NotifyingListItem)view[1]).StringValue);
			Assert.AreEqual("ccc", ((NotifyingListItem)view[2]).StringValue);
			Assert.AreEqual("ddd", ((NotifyingListItem)view[3]).StringValue);
			Assert.AreEqual("aaa", ((NotifyingListItem)view[4]).StringValue);

			// Change bbb from 4 to -1 (putting it at the end of the sort.
			((NotifyingListItem)factory.List[1]).IntegerValue = -1;

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", ((NotifyingListItem)view[0]).StringValue);
			Assert.AreEqual("ccc", ((NotifyingListItem)view[1]).StringValue);
			Assert.AreEqual("ddd", ((NotifyingListItem)view[2]).StringValue);
			Assert.AreEqual("aaa", ((NotifyingListItem)view[3]).StringValue);
			Assert.AreEqual("bbb", ((NotifyingListItem)view[4]).StringValue);
		}

		[Test]
		public void SupportsChangeNotification()
		{
			// List<> does not implement ListChanged, but the wrapper must report true.
			Assert.IsTrue(((IBindingListView)this.view).SupportsChangeNotification);
		}

		[Test]
		public void SupportsChangeNotificationIBindingList()
		{
			ObjectListView view = new ObjectListView(new BindingList<SimpleClass>());

			// BindingList<> implements ListChanged via IBindingList.
			Assert.IsTrue(((IBindingListView)view).SupportsChangeNotification);
		}

		[Test]
		public void SupportsChangeNotificationNotifyingList()
		{
			ObjectListView view = new ObjectListView(new NotifyingList());

			// BindingList<> implements ListChanged via matching event declaration.
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

			ObjectListView view = new ObjectListView(list);
			this.SetupListEventHandlers(view);

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(0, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);

			item.IntegerValue++;

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(0, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);
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

			ObjectListView view = new ObjectListView(list);
			this.SetupListEventHandlers(view);

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(0, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);

			item.IntegerValue++;

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(1, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);
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

			ObjectListView view = new ObjectListView(list);
			this.SetupListEventHandlers(view);

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(0, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);

			item.IntegerValue++;

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(1, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);
		}

		[Test]
		public void ListChangedItemReplaced()
		{
			BindingList<SimpleClass> list = new BindingList<SimpleClass>();

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			ObjectListView view = new ObjectListView(list);
			SetupListEventHandlers(view);

			SimpleClass item = new SimpleClass(50, "555", new DateTime(1955, 5, 5));

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(0, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);

			list[2] = item;

			Assert.AreEqual(0, this.listChangedAddedRaised);
			Assert.AreEqual(0, this.listChangedDeletedRaised);
			Assert.AreEqual(1, this.listChangedItemChangedRaised);
			Assert.AreEqual(0, this.listChangedResetRaised);
		}

		[Test]
		public void ListChangedItemReplacedAndUpdated()
		{
			BindingList<NotifyingListItem> list = new BindingList<NotifyingListItem>();

			list.Add(new NotifyingListItem(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new NotifyingListItem(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new NotifyingListItem(60, "ccc", new DateTime(1975, 6, 6)));

			ObjectListView view = new ObjectListView(list);
			SetupListEventHandlers(view);

			NotifyingListItem item = new NotifyingListItem(50, "555", new DateTime(1955, 5, 5));
			list[2] = item;
			Assert.AreEqual(1, this.listChangedItemChangedRaised);

			item.IntegerValue = 60;
			Assert.AreEqual(2, this.listChangedItemChangedRaised);
		}

		[Test]
		public void SupportsSearching()
		{
			Assert.IsTrue(((IBindingListView)this.view).SupportsSearching);
		}

		[Test]
		public void SupportsSorting()
		{
			Assert.IsTrue(((IBindingListView)this.view).SupportsSorting);
		}

		[Test]
		public void SupportsSortingNoItemType()
		{
			ObjectListView view = new ObjectListView(new ArrayList());
			Assert.IsFalse(((IBindingListView)view).SupportsSorting);
		}

		[Test]
		public void SupportsSortingNoProps()
		{
			ObjectListView view = new ObjectListView(new List<int>());
			Assert.IsFalse(((IBindingListView)view).SupportsSorting);
		}
	}
}
#endif