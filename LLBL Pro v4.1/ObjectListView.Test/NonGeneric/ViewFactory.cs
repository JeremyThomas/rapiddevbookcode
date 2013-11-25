#pragma warning disable 1591	// Missing XML comment


using System;
using System.Collections;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
  public class ViewFactory
  {
    #region Fields

    private ObjectListView view;
    private IList list;
    private Type itemType;
    private int listChangedAddedRaised;
    private int listChangedDeletedRaised;
    private int listChangedResetRaised;
    private int listChangedItemChangedRaised;
    private int addingNewRaised;
    private int removingItemRaised;
    private int sortedRaised;
    private int beforeListChangedRaised;
    private int afterListChangedRaised;

    #endregion

    #region Properties

    public int AddingNewCount
    {
      get { return addingNewRaised; }
    }

    public int AfterListChangedCount
    {
      get { return afterListChangedRaised; }
    }

    public int BeforeListChangedCount
    {
      get { return beforeListChangedRaised; }
    }

    public IList List
    {
      get { return list; }
    }

    public int ListChangedAddedCount
    {
      get { return listChangedAddedRaised; }
    }

    public int ListChangedDeletedCount
    {
      get { return listChangedDeletedRaised; }
    }

    public int ListChangedItemChangedCount
    {
      get { return listChangedItemChangedRaised; }
    }

    public int ListChangedResetCount
    {
      get { return listChangedResetRaised; }
    }

    public Type ListItemType
    {
      get { return itemType; }
    }

    public int RemovingItemCount
    {
      get { return removingItemRaised; }
    }

    public int SortedCount
    {
      get { return sortedRaised; }
    }

    public ObjectListView View
    {
      get { return view; }
    }

    #endregion

    private ViewFactory()
    {
    }

    public void ClearEventCounts()
    {
      listChangedAddedRaised = 0;
      listChangedDeletedRaised = 0;
      listChangedResetRaised = 0;
      listChangedItemChangedRaised = 0;
      addingNewRaised = 0;
      removingItemRaised = 0;
      sortedRaised = 0;
      beforeListChangedRaised = 0;
      afterListChangedRaised = 0;
    }

    public object CreateItem()
    {
      return Activator.CreateInstance(itemType);
    }

    public static ViewFactory IListSimpleItems()
    {
      var factory = new ViewFactory();

      factory.list = new ArrayList();
      factory.itemType = typeof (SimpleClass);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IListIEditableObjectItems()
    {
      var factory = new ViewFactory();

      factory.list = new ArrayList();
      factory.itemType = typeof (SimpleEditableObject);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IListINotifyPropertyChangedItems()
    {
      var factory = new ViewFactory();

      factory.list = new ArrayList();
      factory.itemType = typeof (NotifyingListItem);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IListOrders()
    {
      var factory = new ViewFactory();

      factory.list = new ArrayList();
      factory.itemType = typeof (Order);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IListPropertyChangedEventsItems()
    {
      var factory = new ViewFactory();

      factory.list = new ArrayList();
      factory.itemType = typeof (NotifyingListItemEvents);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IBindingListSimpleItems()
    {
      var factory = new ViewFactory();

      factory.list = new BindingList<SimpleClass>();
      factory.itemType = typeof (SimpleClass);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IBindingListIEditableObjectItems()
    {
      var factory = new ViewFactory();

      factory.list = new BindingList<SimpleEditableObject>();
      factory.itemType = typeof (SimpleEditableObject);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IBindingListINotifyPropertyChangedItems()
    {
      var factory = new ViewFactory();

      factory.list = new BindingList<NotifyingListItem>();
      factory.itemType = typeof (NotifyingListItem);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IBindingListOrders()
    {
      var factory = new ViewFactory();

      factory.list = new BindingList<Order>();
      factory.itemType = typeof (Order);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory IBindingListPropertyChangedEventsItems()
    {
      var factory = new ViewFactory();

      factory.list = new BindingList<NotifyingListItemEvents>();
      factory.itemType = typeof (NotifyingListItemEvents);
      factory.view = new ObjectListView(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    private void SetupListEventHandlers()
    {
      ClearEventCounts();

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

      view.RemovingItem += delegate { removingItemRaised++; };

      view.Sorted += delegate { sortedRaised++; };

      view.BeforeListChanged += delegate { beforeListChangedRaised++; };

      view.AfterListChanged += delegate { afterListChangedRaised++; };
    }
  }
}

