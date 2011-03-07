#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NUnit.Framework;

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
      addingNewRaised = 0;
      listChangedAddedRaised = 0;
      listChangedDeletedRaised = 0;
      listChangedResetRaised = 0;
      listChangedItemChangedRaised = 0;

      view.AddingNew += delegate { addingNewRaised++; };

      view.ListChanged += delegate(object sender, ListChangedEventArgs e)
                            {
                              switch (e.ListChangedType)
                              {
                                case ListChangedType.ItemAdded:
                                  listChangedAddedRaised++;
                                  break;
                                case ListChangedType.ItemDeleted:
                                  listChangedDeletedRaised++;
                                  break;
                                case ListChangedType.Reset:
                                  listChangedResetRaised++;
                                  break;
                                case ListChangedType.ItemChanged:
                                  listChangedItemChangedRaised++;
                                  break;
                              }
                            };
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void AddIndexNull()
    {
      ((IBindingList) view).AddIndex(null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void AddIndexNotInType()
    {
      var dateProps = TypeDescriptor.GetProperties(typeof (DateTime));
      ((IBindingList) view).AddIndex(dateProps[0]);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AddIndexListItemTypeNotSet()
    {
      view = new ObjectListView(new ArrayList());
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) view).AddIndex(simpleProps[0]);
    }

    [Test]
    public void AddIndexPopulatedList()
    {
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) view).AddIndex(simpleProps[0]);
    }

    [Test]
    public void AddIndexListItemTypeSet()
    {
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ItemType = typeof (SimpleClass);
      ((IBindingList) view).AddIndex(simpleProps[0]);
    }

    [Test]
    public void AddNew()
    {
      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView);

      var item = ((ObjectView) added).Object;
      Assert.IsNotNull(item);
      Assert.IsTrue(item is SimpleClass);

      Assert.AreEqual(-1, ((SimpleClass) item).IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, addingNewRaised);
      Assert.AreEqual(1, listChangedAddedRaised);
    }

    [Test]
    public void AddNewUserObject()
    {
      view.AddingNew += delegate(object sender, AddingNewEventArgs e) { e.NewObject = new SimpleClass(5, "55", new DateTime(1955, 5, 5)); };

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView);

      var item = ((ObjectView) added).Object;
      Assert.IsNotNull(item);
      Assert.IsTrue(item is SimpleClass);

      Assert.AreEqual(5, ((SimpleClass) item).IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, addingNewRaised);
      Assert.AreEqual(1, listChangedAddedRaised);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void AddNewUserObjectInvalidType()
    {
      view.AddingNew += delegate(object sender, AddingNewEventArgs e) { e.NewObject = DateTime.Now; };

      var added = view.AddNew();
    }

    [Test]
    [ExpectedException(typeof (NotSupportedException))]
    public void AddNewAndEndEdit()
    {
      var added = (ObjectView) view.AddNew();
      added.EndEdit();
    }

    [Test]
    [ExpectedException(typeof (NotSupportedException))]
    public void AddNewAndCancelEdit()
    {
      var added = (ObjectView) view.AddNew();
      added.CancelEdit();
    }

    [Test]
    public void AddNewEditableObject()
    {
      view = new ObjectListView(new ArrayList());
      SetupListEventHandlers(view);

      view.ItemType = typeof (SimpleEditableObject);

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView);

      var item = ((ObjectView) added).Object;
      Assert.IsNotNull(item);
      Assert.IsTrue(item is SimpleEditableObject);

      Assert.AreEqual(-1, ((SimpleEditableObject) item).IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, addingNewRaised);
      Assert.AreEqual(4, listChangedAddedRaised);
    }

    [Test]
    public void AddNewExplicitEditableObject()
    {
      view = new ObjectListView(new ArrayList());
      SetupListEventHandlers(view);

      view.ItemType = typeof (ExplicitEditableObject);

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView);

      var item = ((ObjectView) added).Object;
      Assert.IsNotNull(item);
      Assert.IsTrue(item is ExplicitEditableObject);

      Assert.AreEqual(-1, ((ExplicitEditableObject) item).IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, addingNewRaised);
      Assert.AreEqual(4, listChangedAddedRaised);
    }

    [Test]
    public void AddNewEditableObjectAndEndEdit()
    {
      view = new ObjectListView(new ArrayList());
      SetupListEventHandlers(view);

      view.ItemType = typeof (SimpleEditableObject);

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var item = (ObjectView) view.AddNew();

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
      SetupListEventHandlers(view);

      view.ItemType = typeof (ExplicitEditableObject);

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var item = (ObjectView) view.AddNew();
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
      SetupListEventHandlers(view);

      view.ItemType = typeof (SimpleEditableObject);

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var item = (ObjectView) view.AddNew();

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
      SetupListEventHandlers(view);

      view.ItemType = typeof (ExplicitEditableObject);

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, listChangedAddedRaised);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, listChangedAddedRaised);

      var item = (ObjectView) view.AddNew();

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
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      // Until the added item is committed, it should be at the end of the collection.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedEndNew()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, it should be placed into the sort.
      Assert.AreEqual(0, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectFiltered()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject) listItem).IntegerValue > -1; };

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectFilteredEndNew()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject) listItem).IntegerValue > -1; };

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedFiltered()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject) listItem).IntegerValue > -1; };

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedFilteredEndNew()
    {
      var factory = ViewFactory.IListIEditableObjectItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(object listItem) { return ((SimpleEditableObject) listItem).IntegerValue > -1; };

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleEditableObject) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewSorted()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      // Until the added item is committed, it should be at the end of the collection.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedEndNew()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, it should be placed into the sort.
      Assert.AreEqual(0, view.IndexOf(item));
    }

    [Test]
    public void AddNewFiltered()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));
      view.Add(new SimpleClass(-1, "1", DateTime.Now));
      view.Add(new SimpleClass(-2, "1", DateTime.Now));
      view.Add(new SimpleClass(-3, "1", DateTime.Now));

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue > -1; };

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewFilteredEndNew()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue > -1; };

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedFiltered()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      view.Filter = "IntegerValue > -1";

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedFilteredEndNew()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      view.ItemType = factory.ListItemType;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      view.Filter = "IntegerValue > -1";

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = (SimpleClass) ((ObjectView) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AllowEditDefault()
    {
      Assert.IsTrue(view.AllowEdit);
    }

    [Test]
    public void AllowEditDefaultReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      Assert.IsFalse(view.AllowEdit);
    }

    [Test]
    public void AllowEditDefaultFixedSize()
    {
      view = new ObjectListView(new int[5]);
      Assert.IsTrue(view.AllowEdit);
    }

    [Test]
    public void AllowEditSetTrue()
    {
      view.AllowEdit = true;
      Assert.IsTrue(view.AllowEdit);
    }

    [Test]
    public void AllowEditSetFalse()
    {
      view.AllowEdit = false;
      Assert.IsFalse(view.AllowEdit);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowEditSetTrueReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowEdit = true;
    }

    [Test]
    public void AllowEditSetFalseReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowEdit = false;
      Assert.IsFalse(view.AllowEdit);
    }

    [Test]
    public void AllowEditSetTrueFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowEdit = true;
      Assert.IsTrue(view.AllowEdit);
    }

    [Test]
    public void AllowEditSetFalseFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowEdit = false;
      Assert.IsFalse(view.AllowEdit);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowEditSetFalseEdit()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      factory.List.Add(new SimpleClass());
      factory.View.AllowEdit = false;
      factory.View[0] = new SimpleClass();
    }

    [Test]
    public void AllowNewDefault()
    {
      Assert.IsTrue(view.AllowNew);
    }

    [Test]
    public void AllowNewDefaultReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      Assert.IsFalse(view.AllowNew);
    }

    [Test]
    public void AllowNewDefaultFixedSize()
    {
      view = new ObjectListView(new int[5]);
      Assert.IsFalse(view.AllowNew);
    }

    [Test]
    public void AllowNewSetTrue()
    {
      view.AllowNew = true;
      Assert.IsTrue(view.AllowNew);
    }

    [Test]
    public void AllowNewSetFalse()
    {
      view.AllowNew = false;
      Assert.IsFalse(view.AllowNew);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowNewSetTrueReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowNew = true;
    }

    [Test]
    public void AllowNewSetFalseReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowNew = false;
      Assert.IsFalse(view.AllowNew);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowNewSetTrueFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowNew = true;
    }

    [Test]
    public void AllowNewSetFalseFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowNew = false;
      Assert.IsFalse(view.AllowNew);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseAdd()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      factory.View.AllowNew = false;
      factory.View.Add(new SimpleClass());
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseAddNew()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      factory.View.AllowNew = false;
      factory.View.AddNew();
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseInsert()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      factory.View.AllowNew = false;
      factory.View.Insert(0, new SimpleClass());
    }

    [Test]
    public void AllowRemoveDefault()
    {
      Assert.IsTrue(view.AllowRemove);
    }

    [Test]
    public void AllowRemoveDefaultReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      Assert.IsFalse(view.AllowRemove);
    }

    [Test]
    public void AllowRemoveDefaultFixedSize()
    {
      view = new ObjectListView(new int[5]);
      Assert.IsFalse(view.AllowRemove);
    }

    [Test]
    public void AllowRemoveSetTrue()
    {
      view.AllowRemove = true;
      Assert.IsTrue(view.AllowRemove);
    }

    [Test]
    public void AllowRemoveSetFalse()
    {
      view.AllowRemove = false;
      Assert.IsFalse(view.AllowRemove);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowRemoveSetTrueReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowRemove = true;
    }

    [Test]
    public void AllowRemoveSetFalseReadOnly()
    {
      view = new ObjectListView(ArrayList.ReadOnly(new ArrayList()));
      view.AllowRemove = false;
      Assert.IsFalse(view.AllowRemove);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowRemoveSetTrueFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowRemove = true;
    }

    [Test]
    public void AllowRemoveSetFalseFixedSize()
    {
      view = new ObjectListView(new int[5]);
      view.AllowRemove = false;
      Assert.IsFalse(view.AllowRemove);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowRemoveSetFalseRemove()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var item = new SimpleClass();
      factory.View.Add(item);
      factory.View.AllowRemove = false;
      factory.View.Remove(item);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowRemoveSetFalseRemoveAt()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var item = new SimpleClass();
      factory.View.Add(item);
      factory.View.AllowRemove = false;
      factory.View.RemoveAt(0);
    }

    [Test]
    public void ApplySort()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      Assert.AreEqual(1, listChangedResetRaised);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(60, ((SimpleClass) val).IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(80, ((SimpleClass) val).IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(100, ((SimpleClass) val).IntegerValue);
    }

    [Test]
    public void ApplySortDescending()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["StringValue"], ListSortDirection.Descending);
      Assert.AreEqual(1, listChangedResetRaised);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual("ccc", ((SimpleClass) val).StringValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual("bbb", ((SimpleClass) val).StringValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual("aaa", ((SimpleClass) val).StringValue);
    }

    [Test]
    public void ApplySortNullable()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now, new DateTime(1992, 3, 5)));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now, null));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now, new DateTime(1991, 1, 2)));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now, new DateTime(1991, 3, 5)));
      list.Add(new SimpleClass(5, "eee", DateTime.Now, new DateTime(1993, 11, 12)));

      view.ItemType = typeof (SimpleClass);

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["NullableDateTimeValue"], ListSortDirection.Ascending);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.AreEqual(null, ((SimpleClass) val).NullableDateTimeValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(((SimpleClass) val).NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1991, 1, 2), ((SimpleClass) val).NullableDateTimeValue.Value);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(((SimpleClass) val).NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1991, 3, 5), ((SimpleClass) val).NullableDateTimeValue.Value);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(((SimpleClass) val).NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1992, 3, 5), ((SimpleClass) val).NullableDateTimeValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(((SimpleClass) val).NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1993, 11, 12), ((SimpleClass) val).NullableDateTimeValue);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ApplySortInvalidProperty()
    {
      var props = TypeDescriptor.GetProperties(typeof (DateTime));
      view.ApplySort(props["Day"], ListSortDirection.Ascending);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ApplySortIncomparableProperty()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      view.ItemType = typeof (SimpleClass);
      view.ApplySort(props["IncomparableValue"], ListSortDirection.Ascending);
    }

    [Test]
    public void ApplySortNull()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(null, ListSortDirection.Ascending);
      Assert.AreEqual(0, listChangedResetRaised);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(100, ((SimpleClass) val).IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(80, ((SimpleClass) val).IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.IsTrue(val is SimpleClass);
      Assert.AreEqual(60, ((SimpleClass) val).IntegerValue);
    }

    [Test]
    public void Find()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var index = ((IBindingList) view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
      Assert.AreEqual(2, index);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void FindNullProp()
    {
      ((IBindingList) view).Find(null, new DateTime(1975, 6, 6));
    }

    [Test]
    public void FindSorted()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      var index = ((IBindingList) view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
      Assert.AreEqual(1, index);
    }

    [Test]
    public void IsSortedUnsorted()
    {
      Assert.IsFalse(view.IsSorted);
    }

    [Test]
    public void IsSortedSorted()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      Assert.IsTrue(view.IsSorted);
    }

    [Test]
    public void IsSortedSortedRemoveSort()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.IsFalse(view.IsSorted);
    }

    [Test]
    public void IsSortedUnsortedRemoveSort()
    {
      view.RemoveSort();
      Assert.IsFalse(view.IsSorted);
    }

    [Test]
    public void RemoveIndex()
    {
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) view).RemoveIndex(simpleProps[0]);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void RemoveIndexNull()
    {
      ((IBindingList) view).RemoveIndex(null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void RemoveIndexNotInType()
    {
      var dateProps = TypeDescriptor.GetProperties(typeof (DateTime));
      ((IBindingList) view).RemoveIndex(dateProps[0]);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void RemoveIndexListItemTypeNotSet()
    {
      view = new ObjectListView(new ArrayList());
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) view).RemoveIndex(simpleProps[0]);
    }

    [Test]
    public void RemoveSort()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      view.RemoveSort();
      Assert.AreEqual(2, listChangedResetRaised); // once for apply, once for remove

      Assert.AreEqual(100, ((SimpleClass) view[0]).IntegerValue);
    }

    [Test]
    public void RemoveSortNoApplySort()
    {
      view.RemoveSort();
      Assert.AreEqual(0, listChangedResetRaised); // no sort prior to remove; no-op

      Assert.AreEqual(100, ((SimpleClass) view[0]).IntegerValue);
    }

    [Test]
    public void RemoveSortMultiple()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      view.RemoveSort();
      view.RemoveSort();
      Assert.AreEqual(2, listChangedResetRaised); // once for the apply, and once for the first remove

      Assert.AreEqual(100, ((SimpleClass) view[0]).IntegerValue);
    }

    [Test]
    public void SortDirectionAscending()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
    }

    [Test]
    public void SortDirectionDescending()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      Assert.AreEqual(ListSortDirection.Descending, view.SortDirection);
    }

    [Test]
    public void SortDirectionNoSort()
    {
      Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
    }

    [Test]
    public void SortDirectionAfterRemoveSort()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
    }

    [Test]
    public void SortProperty()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);
      Assert.AreEqual(intProp, view.SortProperty);
    }

    [Test]
    public void SortPropertyNoSort()
    {
      Assert.IsNull(view.SortProperty);
    }

    [Test]
    public void SortPropertyAfterRemoveSort()
    {
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.IsNull(view.SortProperty);
    }

    [Test]
    public void SortAddItem()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(1, "aaa", DateTime.Now));
      view.Add(new SimpleClass(4, "bbb", DateTime.Now));
      view.Add(new SimpleClass(3, "ccc", DateTime.Now));
      view.Add(new SimpleClass(2, "ddd", DateTime.Now));
      view.Add(new SimpleClass(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[4]).StringValue);

      view.Add(new SimpleClass(5, "fff", DateTime.Now));

      Assert.AreEqual(6, view.Count);
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("fff", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[5]).StringValue);
    }

    [Test]
    public void SortAddItemListDirect()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(1, "aaa", DateTime.Now));
      view.Add(new SimpleClass(4, "bbb", DateTime.Now));
      view.Add(new SimpleClass(3, "ccc", DateTime.Now));
      view.Add(new SimpleClass(2, "ddd", DateTime.Now));
      view.Add(new SimpleClass(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[4]).StringValue);

      factory.List.Add(new SimpleClass(5, "fff", DateTime.Now));

      // This works because as soon as we access the view again, the sort indexes are found dirty and are rebuilt.
      // Dirty detection works only for add/delete, not item change.
      Assert.AreEqual(6, view.Count);
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("fff", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[5]).StringValue);
    }

    [Test]
    public void SortChangeItem()
    {
      var factory = ViewFactory.IListINotifyPropertyChangedItems();
      var view = factory.View;

      view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
      view.Add(new NotifyingListItem(4, "bbb", DateTime.Now));
      view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
      view.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
      view.Add(new NotifyingListItem(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (NotifyingListItem));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", ((NotifyingListItem) view[0]).StringValue);
      Assert.AreEqual("bbb", ((NotifyingListItem) view[1]).StringValue);
      Assert.AreEqual("ccc", ((NotifyingListItem) view[2]).StringValue);
      Assert.AreEqual("ddd", ((NotifyingListItem) view[3]).StringValue);
      Assert.AreEqual("aaa", ((NotifyingListItem) view[4]).StringValue);

      // Change bbb from 4 to -1 (putting it at the end of the sort.
      ((NotifyingListItem) factory.List[1]).IntegerValue = -1;

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", ((NotifyingListItem) view[0]).StringValue);
      Assert.AreEqual("ccc", ((NotifyingListItem) view[1]).StringValue);
      Assert.AreEqual("ddd", ((NotifyingListItem) view[2]).StringValue);
      Assert.AreEqual("aaa", ((NotifyingListItem) view[3]).StringValue);
      Assert.AreEqual("bbb", ((NotifyingListItem) view[4]).StringValue);
    }

    [Test]
    public void SupportsChangeNotification()
    {
      // List<> does not implement ListChanged, but the wrapper must report true.
      Assert.IsTrue(((IBindingListView) view).SupportsChangeNotification);
    }

    [Test]
    public void SupportsChangeNotificationIBindingList()
    {
      var view = new ObjectListView(new BindingList<SimpleClass>());

      // BindingList<> implements ListChanged via IBindingList.
      Assert.IsTrue(((IBindingListView) view).SupportsChangeNotification);
    }

    [Test]
    public void SupportsChangeNotificationNotifyingList()
    {
      var view = new ObjectListView(new NotifyingList());

      // BindingList<> implements ListChanged via matching event declaration.
      Assert.IsTrue(((IBindingListView) view).SupportsChangeNotification);
    }

    /// <summary>
    /// List items that don't support INotifyPropertyChanged or xxxChanged shouldn't cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedSimpleItemChanged()
    {
      var list = new BindingList<SimpleEditableObject>();
      var item = new SimpleEditableObject();
      list.Add(item);

      var view = new ObjectListView(list);
      SetupListEventHandlers(view);

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(0, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);

      item.IntegerValue++;

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(0, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);
    }

    /// <summary>
    /// List items that support INotifyPropertyChanged will cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedNotifyingItemChanged()
    {
      var list = new BindingList<NotifyingListItem>();
      var item = new NotifyingListItem();
      list.Add(item);

      var view = new ObjectListView(list);
      SetupListEventHandlers(view);

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(0, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);

      item.IntegerValue++;

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(1, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);
    }

    /// <summary>
    /// List items that support xxxChanged events will cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedNotifyingEventItemChanged()
    {
      var list = new BindingList<NotifyingListItemEvents>();
      var item = new NotifyingListItemEvents();
      list.Add(item);

      var view = new ObjectListView(list);
      SetupListEventHandlers(view);

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(0, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);

      item.IntegerValue++;

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(1, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);
    }

    [Test]
    public void ListChangedItemReplaced()
    {
      var list = new BindingList<SimpleClass>();

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var view = new ObjectListView(list);
      SetupListEventHandlers(view);

      var item = new SimpleClass(50, "555", new DateTime(1955, 5, 5));

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(0, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);

      list[2] = item;

      Assert.AreEqual(0, listChangedAddedRaised);
      Assert.AreEqual(0, listChangedDeletedRaised);
      Assert.AreEqual(1, listChangedItemChangedRaised);
      Assert.AreEqual(0, listChangedResetRaised);
    }

    [Test]
    public void ListChangedItemReplacedAndUpdated()
    {
      var list = new BindingList<NotifyingListItem>();

      list.Add(new NotifyingListItem(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new NotifyingListItem(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new NotifyingListItem(60, "ccc", new DateTime(1975, 6, 6)));

      var view = new ObjectListView(list);
      SetupListEventHandlers(view);

      var item = new NotifyingListItem(50, "555", new DateTime(1955, 5, 5));
      list[2] = item;
      Assert.AreEqual(1, listChangedItemChangedRaised);

      item.IntegerValue = 60;
      Assert.AreEqual(2, listChangedItemChangedRaised);
    }

    [Test]
    public void SupportsSearching()
    {
      Assert.IsTrue(((IBindingListView) view).SupportsSearching);
    }

    [Test]
    public void SupportsSorting()
    {
      Assert.IsTrue(((IBindingListView) view).SupportsSorting);
    }

    [Test]
    public void SupportsSortingNoItemType()
    {
      var view = new ObjectListView(new ArrayList());
      Assert.IsFalse(((IBindingListView) view).SupportsSorting);
    }

    [Test]
    public void SupportsSortingNoProps()
    {
      var view = new ObjectListView(new List<int>());
      Assert.IsFalse(((IBindingListView) view).SupportsSorting);
    }
  }
}

#endif