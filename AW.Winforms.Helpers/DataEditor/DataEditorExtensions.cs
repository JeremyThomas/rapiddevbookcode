using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      return EditInDataGridViewx(enumerable, null);
    }

    public static IEnumerable EditInDataGridViewx(this IEnumerable enumerable, Func<object, int> saveFunction, params Type[] saveableTypes)
    {
      var dataGridView = new FrmDataEditor {Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      if (saveFunction != null)
        gridDataEditor.SaveFunction += saveFunction;
      gridDataEditor.BindEnumerable(enumerable);
      // AWHelper.BindEnumerable(enumerable,gridDataEditor.BindingSource);
      dataGridView.ShowDialog();
      return enumerable;
    }

    public static IEnumerable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction)
    {
      var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
      frmDataEditor.Controls.Add(gridDataEditor);
      if (saveFunction != null)
        gridDataEditor.SaveFunction += saveFunction;
      gridDataEditor.BindEnumerable(enumerable);
      frmDataEditor.ShowDialog();
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

    public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string) && !(enumerable.ToString() == "System.Collections.Hashtable+KeyCollection");
      //ListBindingHelper.GetListItemType(enumerable)      
      if (showenEnumerable)
        try
        {
          showenEnumerable = enumerable is IBindingListView;
          if (showenEnumerable)
          {
            bindingSource.DataSource = enumerable;
            showenEnumerable = bindingSource.Count > 0;
          }
          else
          {
            showenEnumerable = enumerable is IList;
            if (!showenEnumerable)
            {
              var alist = ListBindingHelper.GetList(enumerable);
              showenEnumerable = enumerable is IList;
              if (showenEnumerable)
                enumerable = (IList) alist;
            }
            if (showenEnumerable)
            {
              var objectListView = new ObjectListView((IList) enumerable);
              showenEnumerable = objectListView.ItemType != null;
              if (showenEnumerable)
              {
                showenEnumerable = objectListView.ItemType != typeof (string); //strings just show the length
                if (showenEnumerable)
                  bindingSource.DataSource = objectListView;
              }
              else
                bindingSource.DataSource = enumerable;
            }
            else if (enumerable is DataTable)
            {
              bindingSource.DataSource = enumerable;
              showenEnumerable = bindingSource.Count > 0;
            }
            else
            {
              var etype = enumerable.GetType();

              if (etype.IsGenericType)
              {
                var queryable = enumerable.AsQueryable();
                showenEnumerable = queryable.ElementType != typeof (string);
                queryable = queryable.Take(50);
                bindingSource.DataSource = showenEnumerable ? new ObjectListView(new BindingSource(queryable, null)) : null;
              }
              else
              {
                bindingSource.DataSource = new ObjectListView(new BindingSource(enumerable, null));
                showenEnumerable = bindingSource.Count > 0;
              }
            }
          }
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
          showenEnumerable = bindingSource.DataSource != null;
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