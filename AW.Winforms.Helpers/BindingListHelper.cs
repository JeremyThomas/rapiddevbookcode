using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JesseJohnston;

namespace AW.Winforms.Helpers
{
  public static class BindingListHelper
  {
    public static IBindingListView ToBindingListView(this IEnumerable enumerable)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string) && enumerable.ToString() != "System.Collections.Hashtable+KeyCollection";
      if (showenEnumerable)
      {
        if (enumerable is IBindingListView)
          return (IBindingListView) enumerable;
        if (enumerable is IListSource)
        {
          var bindingListView = ListSourceToBindingListView((IListSource) enumerable);
          if (bindingListView != null)
            return bindingListView;
        }
        return ToObjectListView(enumerable);
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

    private static IBindingListView ToObjectListView(this IList list)
    {
      if (list != null)
      {
        if (list is IBindingListView)
          return (IBindingListView)list;
        var objectListView = new ObjectListView(list);
        if (objectListView.ItemType != null)
          return objectListView;
      }
      return null;
    }

    private static IBindingListView ToObjectListView(this IEnumerable enumerable)
    {
      var itemType = GetEnumerableItemType(enumerable);
      if (itemType == typeof(string))
        return null;
      enumerable = (IEnumerable)ListBindingHelper.GetList(enumerable);
      if (enumerable is IList)
      {
        var objectListView = ((IList) enumerable).ToObjectListView();
        if (objectListView != null)
          return objectListView;
      }
      return CreateObjectListViewViaBindingSource(enumerable);
    }

    public static Type GetEnumerableItemType(IEnumerable enumerable)
    {
      var queryable = enumerable as IQueryable;
      if (queryable != null)
        return queryable.ElementType;
      Type itemType;
      try
      {
        itemType = ListBindingHelper.GetListItemType(enumerable);
      }
      catch (NotImplementedException)
      {
        itemType = null;
      }
      if (itemType == null)
      {
        queryable = enumerable.AsQueryable();
        return queryable.ElementType;
      }
      return itemType;
    }

    private static IBindingListView CreateObjectListViewViaBindingSource(IEnumerable enumerable)
    {
      var bindingSource = new BindingSource(enumerable, null);
      return bindingSource.Count > 0 ? bindingSource.List.ToObjectListView() : null;
    }

    public static bool BindEnumerable<T>(this BindingSource bindingSource, IEnumerable<T> enumerable, bool setReadonly)
    {
      var showenEnumerable = BindEnumerable(bindingSource, enumerable);
      if (showenEnumerable)
        if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
        {
          if (!(SetReadonly<T>((IBindingList) bindingSource.DataSource)))
            bindingSource.DataSource = new ObjectListView<T>(enumerable.ToList().AsReadOnly());
        }
        else
          bindingSource.AllowNew = !setReadonly;
      return showenEnumerable;
    }

    public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly)
    {
      var showenEnumerable = BindEnumerable(bindingSource, enumerable);
      if (showenEnumerable)
        if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
          SetReadonly(((IBindingList) bindingSource.DataSource));
        else
          bindingSource.AllowNew = !setReadonly;
      return showenEnumerable;
    }

    private static bool BindEnumerable(BindingSource bindingSource, IEnumerable enumerable)
    {
      bool showenEnumerable;
      try
      {
        bindingSource.DataSource = enumerable.ToBindingListView();
        showenEnumerable = bindingSource.Count > 0;
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
        showenEnumerable = bindingSource.Count > 0;
      }
      return showenEnumerable;
    }

    public static bool SetReadonly(IBindingList bindingList)
    {
      var result = bindingList is ObjectListView;
      if (result)
      {
        ((ObjectListView) bindingList).AllowEdit = false;
        ((ObjectListView) bindingList).AllowRemove = false;
        ((ObjectListView) bindingList).AllowNew = false;
      }
      else
      {
        result = bindingList is DataView;
        if (result)
        {
          ((DataView) bindingList).AllowEdit = false;
          ((DataView) bindingList).AllowNew = false;
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
      if (propertyInfo.CanWrite)
        propertyInfo.SetValue(bindingList, false, null);
    }

    public static bool SetReadonly<T>(IBindingList bindingList)
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

    public static object GetDataSource(this BindingSource bindingSource)
    {
      if (bindingSource.DataSource is BindingSource)
        return GetDataSource((BindingSource) bindingSource.DataSource);
      var objectListView = bindingSource.DataSource as ObjectListView;
      return objectListView == null ? bindingSource.DataSource : GetDataSource(objectListView);
    }

    public static object GetDataSource(this ObjectListView objectListView)
    {
      var bindingSource = objectListView.List as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource);
      var objectListViewSource = objectListView.List as ObjectListView;
      return objectListViewSource == null ? objectListView.List : GetDataSource(objectListViewSource);
    }
  }
}