using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;

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

    #region Dynamic Form Instantiation

    public static Form CreateForm(Type formType, params Object[] args)
    {
      return MetaDataHelper.CreateInstanceOf(typeof (Form), formType, args) as Form;
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

    public static Form ShowChildForm(Form childForm, Form mdiParent)
    {
      if (mdiParent != null)
        childForm.MdiParent = mdiParent;
      childForm.WindowState = FormWindowState.Normal;
      childForm.Show();
      return childForm;
    }

    public static Form ShowChildForm(Form childForm)
    {
      return ShowChildForm(childForm, GetMdiParent());
    }

    public static Form ShowForm(Form form)
    {
      return ShowForm(form, GetMdiParent());
    }

    public static Form ShowForm(Form form, Form mdiParent)
    {
      if (Application.MessageLoop)
        ShowChildForm(form, mdiParent);
      else
        form.ShowDialog();
      return form;
    }

    public static Form ShowFormModalIfParentLess(Form form)
    {
      return ShowFormModalIfParentLess(form, GetMdiParent());
    }

    public static Form ShowFormModalIfParentLess(Form form, Control parent)
    {
      form.WindowState = FormWindowState.Normal;
      if (parent == null)
        form.ShowDialog();
      else
      {
        var mdiParent = parent as Form;
        if (mdiParent != null && mdiParent.IsMdiContainer)
          form.MdiParent = mdiParent;
        else
          form.Parent = parent;
        form.Show();
      }
      return form;
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