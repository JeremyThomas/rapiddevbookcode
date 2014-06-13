#pragma warning disable 1591	// Missing XML comment


using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston.Tests.Generic
{
  public class ViewFactory<T>
  {
    #region Fields

    private ObjectListView<T> view;
    private IList<T> list;
    private int listChangedAddedRaised;
    private int listChangedDeletedRaised;
    private int listChangedResetRaised;
    private int listChangedItemChangedRaised;
    private int addingNewRaised;
    private int sortedRaised;
    private int removingItemRaised;
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

    public IList<T> List
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

    public int RemovingItemCount
    {
      get { return removingItemRaised; }
    }

    public int SortedCount
    {
      get { return sortedRaised; }
    }

    public ObjectListView<T> View
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

    public T CreateItem()
    {
      return (T) Activator.CreateInstance(typeof (T));
    }

    public static ViewFactory<T> IList()
    {
      var factory = new ViewFactory<T>();

      factory.list = new List<T>();
      factory.view = new ObjectListView<T>(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory<T> IListReadOnly()
    {
      var factory = new ViewFactory<T>();

      factory.list = new List<T>().AsReadOnly();
      factory.view = new ObjectListView<T>(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory<T> IBindingList()
    {
      var factory = new ViewFactory<T>();

      factory.list = new BindingList<T>();
      factory.view = new ObjectListView<T>(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    public static ViewFactory<T> IBindingList(BindingList<T> list)
    {
      var factory = new ViewFactory<T>();

      factory.list = list;
      factory.view = new ObjectListView<T>(factory.list);
      factory.SetupListEventHandlers();

      return factory;
    }

    private void SetupListEventHandlers()
    {
      ClearEventCounts();

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

      view.AddingNew += delegate { addingNewRaised++; };

      view.RemovingItem += delegate { removingItemRaised++; };

      view.Sorted += delegate { sortedRaised++; };

      view.BeforeListChanged += delegate { beforeListChangedRaised++; };

      view.AfterListChanged += delegate { afterListChangedRaised++; };
    }
  }
}

