using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using JesseJohnston;

namespace AW.Winforms.Helpers.DataEditor
{
  public static class DataEditorExtensions
  {
    public static IEnumerable ViewInDataGridViewx(this IQueryable enumerable)
    {
      return EditInDataGridViewx(enumerable, null, null);
    }

    public static IEnumerable EditInDataGridViewx(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
    {
      var dataGridView = new FrmDataEditor {Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      if (saveFunction != null)
        gridDataEditor.SaveFunction += saveFunction;
      if (deleteFunction != null)
        gridDataEditor.DeleteFunction += deleteFunction;
      gridDataEditor.BindEnumerable(enumerable);
      // AWHelper.BindEnumerable(enumerable,gridDataEditor.BindingSource);
      dataGridView.ShowDialog();
      return enumerable;
    }

    public static IEnumerable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction)
    {
      return EditInDataGridView(enumerable, saveFunction, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
    {
      if (enumerable != null)
      {
        var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
        var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
        frmDataEditor.Controls.Add(gridDataEditor);
        if (saveFunction != null)
          gridDataEditor.SaveFunction += saveFunction;
        if (deleteFunction != null)
          gridDataEditor.DeleteFunction += deleteFunction;
        gridDataEditor.BindEnumerable(enumerable);
        frmDataEditor.ShowDialog();
      }
      return enumerable;
    }

    public static bool Bind<T>(this BindingSource bindingSource, IEnumerable<T> enumerable, bool setReadonly)
    {
      var showenEnumerable = enumerable != null && typeof (T) != typeof (string); //strings just show the length
      if (showenEnumerable)
        if (enumerable is IBindingListView)
        {
          bindingSource.DataSource = enumerable;
          if (setReadonly && bindingSource.AllowEdit)
            bindingSource.DataSource = new ObjectListView<T>(enumerable.ToList().AsReadOnly());
        }
        else
        {
          var asList = enumerable.ToList();
          var objectListView = setReadonly ? new ObjectListView<T>(asList.AsReadOnly()) : new ObjectListView<T>(asList);
          bindingSource.DataSource = objectListView;
        }
      return showenEnumerable && bindingSource.Count > 0;
    }

    public static IBindingListView ToBindingListView(this IEnumerable enumerable)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string) && enumerable.ToString() != "System.Collections.Hashtable+KeyCollection";
      if (showenEnumerable)
      {
        if (enumerable is IBindingListView)
          return (IBindingListView) enumerable;
        if (enumerable is IListSource)
        {
          var bindingListView = ListSourceToBindingListView((IListSource)enumerable);
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
        var objectListView = new ObjectListView(list);
        if (objectListView.ItemType != null)
          return objectListView;
      }
      return null;
    }

    private static IBindingListView ToObjectListView(this IEnumerable enumerable)
    {
      if (enumerable is IList)
      {
        var objectListView = ((IList) enumerable).ToObjectListView();
        if (objectListView != null)
          return objectListView;
      }
      var alist = ListBindingHelper.GetList(enumerable);
      if (alist is IList)
      {
        var objectListView = ((IList) alist).ToObjectListView();
        if (objectListView != null)
          return objectListView;
      }

      if (enumerable is IQueryable)
      {
        var queryable = enumerable.AsQueryable();
        if (queryable.ElementType != typeof (string))
        {
          queryable = queryable.Take(200);
          return CreateObjectListViewViaBindingSource(queryable);
        }
      }
      else
        return CreateObjectListViewViaBindingSource(enumerable);
      return null;
    }

    private static IBindingListView CreateObjectListViewViaBindingSource(IEnumerable queryable)
    {
      var bindingSource = new BindingSource(queryable, null);
      return bindingSource.Count > 0 ? new ObjectListView(bindingSource.List) : null;
    }

    public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly)
    {
      bool showenEnumerable;
      try
      {
        bindingSource.DataSource = enumerable.ToBindingListView();
        showenEnumerable = bindingSource.DataSource != null && bindingSource.Count > 0;
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
        showenEnumerable = bindingSource.DataSource != null && bindingSource.Count > 0;
      }
      if (showenEnumerable)
        if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is ObjectListView)
        {
          ((ObjectListView) bindingSource.DataSource).AllowEdit = false;
          ((ObjectListView) bindingSource.DataSource).AllowRemove = false;
          ((ObjectListView) bindingSource.DataSource).AllowNew = false;
        }
        else
          bindingSource.AllowNew = !setReadonly;
      return showenEnumerable;
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

    //public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, params Type[] saveableTypes)
    //{
    //  return (IEnumerable<T>) EditInDataGridView((IEnumerable) enumerable, saveFunction, saveableTypes);
    //}

    public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }
  }
}