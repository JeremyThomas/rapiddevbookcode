using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using JesseJohnston;

namespace AW.Winforms.Helpers
{
  public static class BindingListHelper
  {
    private static readonly Dictionary<Type, Func<IEnumerable, Type, IBindingListView>> BindingListViewCreaters = new Dictionary<Type, Func<IEnumerable, Type, IBindingListView>>();

    public static void RegisterbindingListViewCreater(Type itemType, Func<IEnumerable, Type, IBindingListView> bindingListViewCreater)
    {
      if (BindingListViewCreaters.ContainsKey(itemType))
        BindingListViewCreaters[itemType] = bindingListViewCreater;
      else
        BindingListViewCreaters.Add(itemType, bindingListViewCreater);
    }

    private static readonly Dictionary<Type, Func<IBindingList, IEnumerable>> BindingListViewSources
      = new Dictionary<Type, Func<IBindingList, IEnumerable>>();

    public static void RegisterBindingListSourceProvider(Type itemType, Func<IBindingList, IEnumerable> bindingListViewCreater)
    {
      if (BindingListViewCreaters.ContainsKey(itemType))
        BindingListViewSources[itemType] = bindingListViewCreater;
      else
        BindingListViewSources.Add(itemType, bindingListViewCreater);
    }

    //&& enumerable.ToString() != "System.Collections.Hashtable+KeyCollection"
    public static IBindingListView ToBindingListView(this IEnumerable enumerable, bool ensureFilteringEnabled = false)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string);
      if (showenEnumerable)
      {
        var iBindingListView = enumerable as IBindingListView;
        if (iBindingListView != null && (!ensureFilteringEnabled || iBindingListView.SupportsFiltering))
          return iBindingListView;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
            return bindingListView;
        }
        return MaybeCreateBindingListView(enumerable, ensureFilteringEnabled);
      }
      return null;
    }

    public static IBindingListView ToBindingListView<T>(this IEnumerable<T> enumerable)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string);
      if (showenEnumerable)
      {
        var view = enumerable as IBindingListView;
        if (view != null)
          return view;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null)
            return bindingListView;
        }
        return CreateBindingListView(enumerable);
      }
      return null;
    }

    public static IBindingListView ListSourceToBindingListView(IListSource listSource)
    {
      if (listSource != null)
      {
        var list = listSource.GetList();
        if (list != null)
          return list.ToBindingListView();
      }
      return null;
    }

    private static IBindingListView CreateBindingListView<T>(IEnumerable<T> enumerable, bool ensureFilteringEnabled = false)
    {
      var itemType = typeof (T);
      if (itemType == typeof (object))
        return CreateBindingListView((IEnumerable) enumerable, ensureFilteringEnabled); //else ListBindingHelper.GetListItemProperties doesn't get the properties

      var potentialBindingListViews = BindingListViewCreaters
  .Where(bindingListViewCreator => bindingListViewCreator.Key.IsAssignableFrom(itemType))
  .Select(bindingListViewCreator => bindingListViewCreator.Value(enumerable, itemType)).ToList();

      var validBindingListViews = from bindingListViewCreator in potentialBindingListViews
                                  where bindingListViewCreator != null && (!ensureFilteringEnabled || bindingListViewCreator.SupportsFiltering)
                                  select bindingListViewCreator;

      foreach (var iBindingListView in validBindingListViews)
        return iBindingListView; //Return first

      return ToObjectListView((IEnumerable<T>)GetDataSource(potentialBindingListViews.FirstOrDefault()) ?? enumerable);
    }

    private static IBindingListView MaybeCreateBindingListView(dynamic enumerable, bool ensureFilteringEnabled = false)
    {
      return CreateBindingListView(enumerable, ensureFilteringEnabled);
    }

    private static IBindingListView CreateBindingListView(IEnumerable enumerable, bool ensureFilteringEnabled = false)
    {
      var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
      return CreateBindingListView(enumerable, itemType, ensureFilteringEnabled);
    }

    private static IBindingListView CreateBindingListView(IEnumerable enumerable, Type itemType, bool ensureFilteringEnabled = false)
    {
      var potentialBindingListViews = BindingListViewCreaters
        .Where(bindingListViewCreator => bindingListViewCreator.Key.IsAssignableFrom(itemType))
        .Select(bindingListViewCreator => bindingListViewCreator.Value(enumerable, itemType)).ToList();

      var validBindingListViews = from bindingListViewCreator in potentialBindingListViews
        where bindingListViewCreator != null && (!ensureFilteringEnabled || bindingListViewCreator.SupportsFiltering)
        select bindingListViewCreator;

      foreach (var iBindingListView in validBindingListViews)
        return iBindingListView; //Return first

      return CreateObjectListView(GetDataSource(potentialBindingListViews.FirstOrDefault()) ?? enumerable, itemType);
    }

    private static ObjectListView CreateObjectListView(ICollection collection)
    {
      return new ObjectListView(new ArrayList(collection));
    }

    /// <summary>
    ///   Creates the object list view.
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="itemType">Type of the item.</param>
    /// <returns></returns>
    public static ObjectListView CreateObjectListView(IEnumerable enumerable, Type itemType)
    {
      enumerable = (IEnumerable) ListBindingHelper.GetList(enumerable);
      return CreateObjectListViewDirect(enumerable, itemType);
    }

    private static IBindingListView ToObjectListView<T>(IEnumerable<T> enumerable)
    {
      var list = enumerable as IList<T>;
      if (list != null)
        return ToObjectListView(list);
      enumerable = (IEnumerable<T>) ListBindingHelper.GetList(enumerable);
      return ToObjectListView(enumerable as IList<T> ?? enumerable.ToList());
    }

    private static ObjectListView<T> ToObjectListView<T>(IList<T> list)
    {
      if (list != null)
      {
        var objectListView = new ObjectListView<T>(list);
        return objectListView;
      }
      return null;
    }

    private static ObjectListView CreateObjectListViewDirect(IEnumerable enumerable, Type itemType)
    {
      var bindingList = enumerable as IBindingList;
      ObjectListView objectListView;
      if (bindingList == null)
      {
        var list = enumerable as IList;
        if (list == null)
        {
          var collection = enumerable as ICollection;
          if (collection == null)
          {
            objectListView = CreateObjectListView();
            foreach (var item in enumerable)
              objectListView.Add(item);
          }
          else
            objectListView = CreateObjectListView(collection);
        }
        else
          objectListView = new ObjectListView(list);
      }
      else
      {
        var dataSource = GetDataSource(bindingList);
        if (dataSource == bindingList)
          objectListView = new ObjectListView(bindingList);
        else
          return CreateObjectListViewDirect(dataSource, itemType);
      }
      if (objectListView.ItemType == null)
        objectListView.ItemType = itemType;
      return objectListView;
    }

    public static IBindingListView CreateObjectListViewGeneric(Type type)
    {
      return (IBindingListView) MetaDataHelper.CreateGeneric(typeof (ObjectListView<>), type, MetaDataHelper.CreateList(type));
    }

    public static IBindingListView CreateObjectListView(Type type)
    {
      var objectListView = CreateObjectListView();
      objectListView.ItemType = type;
      return objectListView;
    }

    private static ObjectListView CreateObjectListView()
    {
      return new ObjectListView(new ArrayList());
    }

    public static bool BindEnumerable<T>(this BindingSource bindingSource, IEnumerable<T> enumerable, bool setReadonly)
    {
      var showenEnumerable = BindEnumerable(bindingSource, enumerable);
      if (showenEnumerable)
        if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
        {
          SetReadonly<T>(bindingSource);
        }
        else
          bindingSource.AllowNew = !setReadonly;
      return showenEnumerable;
    }

    private static void SetReadonly<T>(BindingSource bindingSource)
    {
      var bindingList = (IBindingList) bindingSource.DataSource;
      if (!(SetReadonly<T>(bindingList)))
      {
        var list = ((IEnumerable<T>) bindingList).ToList();
        bindingSource.DataSource = new ObjectListView<T>(list.AsReadOnly());
      }
    }

    public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly, bool ensureFilteringEnabled = false)
    {
      var showenEnumerable = BindEnumerableInternal(bindingSource, enumerable, ensureFilteringEnabled);
      if (showenEnumerable)
      {
        var list = bindingSource.DataSource as IBindingList;
        if (setReadonly && (bindingSource.AllowEdit || bindingSource.AllowRemove) && list != null && SetReadonly(list))
        {
          bindingSource.ResetBindings(true); //To update UI for bindingSource.AllowRemove
        }
        else
          try
          {
            bindingSource.AllowNew = !setReadonly;
          }
          catch (InvalidOperationException e)
          {
            e.TraceOut();
          }
      }

      return showenEnumerable;
    }

    public static bool BindEnumerable<T>(BindingSource bindingSource, IEnumerable<T> enumerable)
    {
      bool showenEnumerable;
      try
      {
        bindingSource.DataSource = enumerable.ToBindingListView();
        showenEnumerable = bindingSource.List != null;
      }
      catch (Exception)
      {
        try
        {
          bindingSource.DataSource = enumerable;
        }
        catch (Exception)
        {
          bindingSource.DataSource = null;
        }
        showenEnumerable = bindingSource.List != null;
      }
      return showenEnumerable;
    }

    private static bool BindEnumerableInternal(BindingSource bindingSource, IEnumerable enumerable, bool ensureFilteringEnabled = false)
    {
      try
      {
        bindingSource.SuspendBinding();
        var raiseListChangedEvents = bindingSource.RaiseListChangedEvents;
        bindingSource.RaiseListChangedEvents = false;
        try
        {
          if (bindingSource.SupportsSorting && bindingSource.IsSorted)
            bindingSource.RemoveSort();
          if (bindingSource.SupportsFiltering && !string.IsNullOrWhiteSpace(bindingSource.Filter))
            bindingSource.RemoveFilter();
        }
        finally
        {
          bindingSource.ResumeBinding();
          bindingSource.RaiseListChangedEvents = raiseListChangedEvents;
        }
      }
      catch (Exception e)
      {
        e.TraceOut();
      }
      bool shownEnumerable;
      try
      {
        var bindingListView = enumerable.ToBindingListView(ensureFilteringEnabled);
        bindingSource.DataSource = bindingListView;
        shownEnumerable = bindingSource.DataSource != null;
      }
      catch (ArgumentException) //From ObjectListView constructor
      {
        bindingSource.DataSource = enumerable; //To use default
        shownEnumerable = bindingSource.DataSource != null;
      }

      return shownEnumerable;
    }

    private static bool SetReadonly(IBindingList bindingList)
    {
      var objectListView = bindingList as ObjectListView;
      var result = objectListView != null;
      if (result)
      {
        objectListView.AllowEdit = false;
        objectListView.AllowRemove = false;
        objectListView.AllowNew = false;
      }
      else
      {
        var dataView = bindingList as DataView;
        result = dataView != null;
        if (result)
        {
          dataView.AllowEdit = false;
          dataView.AllowNew = false;
          dataView.AllowDelete = false;
        }
        else
        {
          SetPropertyFalse(bindingList, "AllowEdit");
          SetPropertyFalse(bindingList, "AllowRemove");
          SetPropertyFalse(bindingList, "AllowNew");
        }
      }
      return result;
    }

    private static void SetPropertyFalse(IEnumerable bindingList, string name)
    {
      var propertyInfo = bindingList.GetType().GetProperty(name);
      if (propertyInfo != null && propertyInfo.CanWrite)
        propertyInfo.SetValue(bindingList, false, null);
    }

    private static bool SetReadonly<T>(IBindingList bindingList)
    {
      var result = bindingList is ObjectListView<T>;
      if (result)
      {
        ((ObjectListView<T>) bindingList).AllowEdit = false;
        ((ObjectListView<T>) bindingList).AllowRemove = false;
        ((ObjectListView<T>) bindingList).AllowNew = false;
      }
      else
      {
        result = bindingList is BindingList<T>;
        if (result)
        {
          ((BindingList<T>) bindingList).AllowEdit = false;
          ((BindingList<T>) bindingList).AllowRemove = false;
          ((BindingList<T>) bindingList).AllowNew = false;
        }
        else
          result = SetReadonly(bindingList);
      }
      return result && !bindingList.AllowEdit;
    }

    public static bool IsObjectListView(object anObject)
    {
      return anObject != null && (anObject is ObjectListView || anObject.GetType().GetGenericTypeDefinition() == typeof (ObjectListView<>));
    }

    public static IEnumerable GetDataSource(this BindingSource bindingSource)
    {
      var dataSource = bindingSource.List as BindingSource;
      if (dataSource != null)
        return GetDataSource(dataSource);
      var bindingList = bindingSource.List as IBindingList;
      return bindingList == null ? bindingSource.List : GetDataSource(bindingList);
    }

    public static IEnumerable GetDataSource(IBindingList bindingList)
    {
      if (bindingList == null)
        return null;
      var bindingSource = bindingList as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource);
      return MaybeGetObjectListViewDataSourcedynamic(bindingList);
    }

    private static IEnumerable GetObjectListViewDataSource(IBindingList bindingList)
    {
      var bindingListSourceProvider = BindingListViewSources.FirstOrDefault(b => b.Key.IsInstanceOfType(bindingList)).Value;
      if (bindingListSourceProvider != null)
        return bindingListSourceProvider(bindingList);
      return bindingList;
    }

    private static IEnumerable MaybeGetObjectListViewDataSourcedynamic(dynamic dataSource)
    {
      return GetObjectListViewDataSource(dataSource);
    }

    private static IEnumerable GetObjectListViewDataSource<T>(ObjectListView<T> objectListView)
    {
      var objectListViewSource = objectListView.List as ObjectListView<T>;
      return objectListViewSource == null ? objectListView.List : GetObjectListViewDataSource(objectListViewSource);
    }

    private static IEnumerable GetObjectListViewDataSource(ObjectListView objectListView)
    {
      var bindingSource = objectListView.List as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource);
      var objectListViewSource = objectListView.List as ObjectListView;
      return objectListViewSource == null ? objectListView.List : GetObjectListViewDataSource(objectListViewSource);
    }
  }
}