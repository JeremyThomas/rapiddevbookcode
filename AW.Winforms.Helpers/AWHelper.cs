using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
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
    ///   Sets the window location only if the point exists on one of the screens.
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

    private static Form CreateForm(Type formType, params Object[] args)
    {
      return MetaDataHelper.CreateInstanceOf(typeof (Form), formType, args) as Form;
    }

    private static void ShowForm(Type formType, bool modal)
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
      if (mdiParent == null) throw new ArgumentNullException("mdiParent");
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

    private static Form GetMdiParent()
    {
      return Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.IsMdiContainer);
    }

    public static int GetIndexOfForm(Form form)
    {
      for (var i = 0; i < Application.OpenForms.Count; i++)
        if (Application.OpenForms[i] == form)
          return i;
      return -1;
    }

    private static void ShowChildForm(Form childForm, Control parent)
    {
      var mdiParent = parent as Form;
      if (mdiParent != null && mdiParent.IsMdiContainer)
        childForm.MdiParent = mdiParent;
      else if (!childForm.TopLevel)
        childForm.Parent = parent;
      childForm.WindowState = FormWindowState.Normal;
      childForm.Show();
    }

    public static Form ShowForm(Form form)
    {
      return ShowForm(form, GetMdiParent());
    }

    public static Form ShowForm(Form form, Control parent)
    {
      if (Application.MessageLoop)
        ShowChildForm(form, parent);
      else
        form.ShowDialog();
      return form;
    }

    #endregion

    #region Controls

    private static Control GetFocusedControl(IEnumerable controls)
    {
      // store focused control...
      foreach (Control clsControl in controls)
      {
        if (clsControl.Focused)
        {
          return clsControl;
        }
        if (clsControl.ContainsFocus)
        {
          return clsControl.Controls.Count == 0 ? clsControl : GetFocusedControl(clsControl.Controls);
        }
      }
      // no focus...
      return null;
    }

    /// <summary>
    ///   Recursively gets the focused control.
    /// </summary>
    /// <param name="control">A parent control.</param>
    /// <returns>The child control(if any) that has focus</returns>
    public static Control GetFocusedControl(Control control)
    {
      if (control == null || control.Focused)
      {
        return control;
      }
      if (control.ContainsFocus)
      {
        if (control is ContainerControl && ((ContainerControl) control).ActiveControl.ContainsFocus)
          return GetFocusedControl(((ContainerControl) control).ActiveControl);
        return GetFocusedControl(control.Controls);
      }
      return null;
    }

    /// <summary>
    ///   Recursivly gets all the contained controls.
    /// </summary>
    /// <param name="controls">The controls.</param>
    /// <see cref="http://weblogs.asp.net/dfindley/archive/2007/06/29/linq-the-uber-findcontrol.aspx" />
    /// ///
    /// <see cref="http://stackoverflow.com/questions/253937/recursive-control-search-with-linq" />
    /// <returns>All the contained controls.</returns>
    public static IEnumerable<Control> All(this Control.ControlCollection controls)
    {
      foreach (Control control in controls)
      {
        foreach (var grandChild in control.Controls.All())
          yield return grandChild;

        yield return control;
      }
    }

    /// <summary>
    ///   Recursivly gets all the contained controls.
    /// </summary>
    /// <param name="control">The control.</param>
    /// <returns>All the contained controls.</returns>
    public static IEnumerable<Control> GetAllContainedControls(this Control control)
    {
      return control.Controls.All();
    }

    #endregion

    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <param name="queryable">The queryable.</param>
    /// <param name="pageIndex">Index of the page.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IQueryable SkipTakeDynamic(this IQueryable queryable, int pageIndex, int pageSize)
    {
      return queryable.Skip(pageIndex*pageSize).Take(pageSize);
    }

    public static IQueryable WhereDynamic(this IQueryable source, Expression lambdaExpression)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (lambdaExpression == null)
        throw new ArgumentNullException("lambdaExpression");
      return source.Provider.CreateQuery(Expression.Call(typeof (Queryable), "Where", new[]
      {
        source.ElementType
      }, source.Expression, (Expression) Expression.Quote(lambdaExpression)));
    }

    public static IQueryable OrderByDynamic(this IQueryable source, Expression expression, bool ascending = true)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (expression == null)
        throw new ArgumentNullException("expression");
      const string str1 = "OrderBy";
      const string str2 = "OrderByDescending";
      var newExpression = (Expression) Expression.Call(typeof (Queryable), ascending ? str1 : str2, new[]
      {
        source.ElementType,
        expression.Type
      }, new[]
      {
        source.Expression, Expression.Quote(expression)
      });
      return source.Provider.CreateQuery(newExpression);
    }
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