using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Controls;
using JesseJohnston;

namespace AW.Winforms.Helpers
{
  public static class AWHelper
  {
    #region SaveControlState

    public static void RestoreColumnsState(StringCollection cols, DataGridView dataGridView)
    {
      if (cols == null || dataGridView == null)
        return;

      var maxDisplayIndex = dataGridView.ColumnCount - 1;
      // Restore the columns' state
      for (var i = 0; i < Math.Min(cols.Count, dataGridView.ColumnCount); ++i)
      {
        var a = cols[i].Split(',');
        dataGridView.Columns[i].DisplayIndex = Math.Min(Int16.Parse(a[0]), maxDisplayIndex);
        dataGridView.Columns[i].Width = Int16.Parse(a[1]);
        dataGridView.Columns[i].Visible = Boolean.Parse(a[2]);
      }
    }

    public static StringCollection SaveColumnState(DataGridView dataGridView)
    {
      // Save column state data
      // including order, column width and whether or not the column is visible
      var stringCollection = new StringCollection();
      foreach (DataGridViewColumn column in dataGridView.Columns)
      {
        stringCollection.Add(String.Format(
                               "{0},{1},{2}",
                               column.DisplayIndex,
                               column.Width,
                               column.Visible));
      }
      return stringCollection;
    }

    public static Point GetWindowNormalLocation(Form form)
    {
      // RestoreBounds remembers normal position if minimized or maximized
      return form.WindowState == FormWindowState.Normal ? form.Location : form.RestoreBounds.Location;
    }

    public static Size GetWindowNormalSize(Form form)
    {
      // RestoreBounds remembers normal position if minimized or maximized
      return form.WindowState == FormWindowState.Normal ? form.Size : form.RestoreBounds.Size;
    }

    public static Rectangle GetWindowNormalSizeAndLocation(Form form)
    {
      // Save location and size data
      // RestoreBounds remembers normal position if minimized or maximized
      return form.WindowState == FormWindowState.Normal ? new Rectangle(form.Location, form.Size) : form.RestoreBounds;
    }

    public static void SetWindowSizeAndLocation(Form form, Rectangle sizeAndLocation)
    {
      if (!sizeAndLocation.Location.IsEmpty)
        form.Location = sizeAndLocation.Location;
      if (!sizeAndLocation.Size.IsEmpty)
        form.Size = sizeAndLocation.Size;
    }

    /// <summary>
    /// Sets the window location only if the point exists on one of the screens.
    /// </summary>
    /// <param name="form">The form.</param>
    /// <param name="location">The location.</param>
    public static void SetWindowLocationSafely(Form form, Point location)
    {
      if (!location.IsEmpty)
        if (Screen.AllScreens.Any(screen => screen.WorkingArea.Contains(location)))
        {
          form.Location = location;
          GeneralHelper.DebugOut("setting form: '" + form + "' location to: " + location);
        }
    }

    #endregion

    public static IEnumerable ViewInDataGridView(this IEnumerable enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable<T> ViewInDataGridView<T>(this IEnumerable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, Func<object, int> saveFunction, params Type[] saveableTypes)
    {
      var dataGridView = new Form {Width = 700, Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditor(enumerable, saveFunction, saveableTypes) {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      dataGridView.ShowDialog();
      return enumerable;
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, params Type[] saveableTypes)
    {
      var dataGridView = new Form {Width = 700, Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditorT<T>(enumerable, saveFunction, saveableTypes) {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      dataGridView.ShowDialog();
      return enumerable;
    }

    //public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, params Type[] saveableTypes)
    //{
    //  return (IEnumerable<T>) EditInDataGridView((IEnumerable) enumerable, saveFunction, saveableTypes);
    //}

    public static bool BindIQueryable<T>(this BindingSource bindingSource, IQueryable<T> queryable, bool setReadonly)
    {
      var showenEnumerable = queryable != null;
      if (showenEnumerable)
        if (queryable is IBindingListView)
          bindingSource.DataSource = queryable;
        else
        {
          var asList = queryable.ToList();
          var objectListView = setReadonly ? new ObjectListView(asList.AsReadOnly()) : new ObjectListView(asList);
          showenEnumerable = objectListView.ItemType != typeof (string); //strings just show the length
          if (showenEnumerable)
            bindingSource.DataSource = objectListView;
        }
      return showenEnumerable && bindingSource.Count > 0;
    }

    public static bool BindEnumerable<T>(this BindingSource bindingSource, IEnumerable<T> enumerable)
    {
      var showenEnumerable = enumerable != null;

      if (showenEnumerable)
        if (enumerable is IBindingListView)
          bindingSource.DataSource = enumerable;
        else
        {
          var objectListView = new ObjectListView(enumerable.ToList());
          showenEnumerable = objectListView.ItemType != typeof (string); //strings just show the length
          if (showenEnumerable)
            bindingSource.DataSource = objectListView;
        }
      return showenEnumerable && bindingSource.Count > 0;
    }

    public static bool BindEnumerable(IEnumerable enumerable, BindingSource bindingSource)
    {
      var showenEnumerable = enumerable != null && !(enumerable is string) && !(enumerable.ToString() == "System.Collections.Hashtable+KeyCollection");

      if (showenEnumerable)
        try
        {
          showenEnumerable = enumerable is IList;
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
      return showenEnumerable;
    }

    public static object GetDataSource(BindingSource bindingSource)
    {
      if (bindingSource.DataSource is BindingSource)
        return GetDataSource((BindingSource) bindingSource.DataSource);
      var objectListView = bindingSource.DataSource as ObjectListView;
      return objectListView == null ? bindingSource.DataSource : GetDataSource(objectListView);
    }

    public static object GetDataSource(ObjectListView objectListView)
    {
      var bindingSource = objectListView.List as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource);
      var objectListViewSource = objectListView.List as ObjectListView;
      return objectListViewSource == null ? objectListView.List : GetDataSource(objectListViewSource);
    }

    public static void CopyEntireDataGridViewToClipboard(DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }

    #region Dynamic Instantiation

    /// <summary>
    /// Creates an instance of type if type is an ancestorType or a descendant
    /// </summary>
    /// <param name="ancestorType">Type of the ancestor.</param>
    /// <param name="type">The type.</param>
    /// <param name="args">The args.</param>
    /// <returns>The Instance</returns>
    public static object CreateInstanceOf(Type ancestorType, Type type, params Object[] args)
    {
      return ancestorType.IsAssignableFrom(type) ? Activator.CreateInstance(type, args) : null;
    }

    public static Form CreateForm(Type formType, params Object[] args)
    {
      return CreateInstanceOf(typeof (Form), formType, args) as Form;
    }

    public static void ShowForm(Type formType, bool modal)
    {
      var aForm = CreateForm(formType);
      if (aForm != null)
        if (modal)
          aForm.ShowDialog();
        else
          aForm.Show();
    }

    public static void ShowDialog(Type formType)
    {
      ShowForm(formType, true);
    }

    public static Form LaunchChildForm(Type formType, params Object[] args)
    {
      return formType != null ? Application.OpenForms[0].LaunchChildForm(formType, args) : null;
    }

    public static Form LaunchChildForm(this Form mdiParent, Type childFormType, params Object[] args)
    {
      if (childFormType == null) throw new ArgumentNullException("childFormType");
      var childForm = mdiParent.MdiChildren.FirstOrDefault(myForm => myForm.GetType() == childFormType);
      if (childForm != null)
      {
        if (childForm.WindowState == FormWindowState.Minimized)
          childForm.WindowState = FormWindowState.Normal;
        childForm.BringToFront();
      }
      else
      {
        childForm = CreateForm(childFormType, args);
        ShowChildForm(childForm, mdiParent);
      }
      return childForm;
    }

    #endregion

    #region Forms

    public static Form GetMdiParent()
    {
      return (from form in Application.OpenForms.Cast<Form>()
              where form.IsMdiContainer
              select form).FirstOrDefault();
    }

    public static int GetIndexOfForm(Form form)
    {
      for (var i = 0; i < Application.OpenForms.Count; i++)
        if (Application.OpenForms[i] == form)
          return i;
      return -1;
    }

    public static void ShowChildForm(Form childForm, Form mdiParent)
    {
      if (mdiParent != null)
        childForm.MdiParent = mdiParent;
      childForm.WindowState = FormWindowState.Normal;
      childForm.Show();
    }

    public static void ShowChildForm(Form childForm)
    {
      ShowChildForm(childForm, GetMdiParent());
    }

    public static void ShowForm(Form form)
    {
      ShowForm(form, GetMdiParent());
    }

    public static void ShowForm(Form form, Form mdiParent)
    {
      if (Application.MessageLoop)
      {
        if (mdiParent != null)
          form.MdiParent = mdiParent;
        form.WindowState = FormWindowState.Normal;
        form.Show();
      }
      else
        form.ShowDialog();
    }

    #endregion
  }

  public class WindowWrapper : IWin32Window
  {
    public WindowWrapper(IntPtr handle)
    {
      _hwnd = handle;
    }

    public IntPtr Handle
    {
      get { return _hwnd; }
    }

    private readonly IntPtr _hwnd;
  }
}