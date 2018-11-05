using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Runtime.InteropServices;
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
    ///   Recursively gets all the contained controls.
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
    ///   Recursively gets all the contained controls.
    /// </summary>
    /// <param name="control">The control.</param>
    /// <returns>All the contained controls.</returns>
    public static IEnumerable<Control> GetAllContainedControls(this Control control)
    {
      return control.Controls.All();
    }

    
    //https://stackoverflow.com/questions/31007145/asynchronous-ui-updates-in-winforms

    public static void Do<TControl>(TControl control, Action<TControl> action) where TControl : Control
    {
      if (control.InvokeRequired)
        control.Invoke(action, control);
      else
        action(control);
    }

    public static void SetToolStripItemVisible(object sender, bool bValue)
    {
      var menuStripItem = (ToolStripItem) sender;
      var currentParent = menuStripItem.GetCurrentParent();
      if (currentParent.InvokeRequired)
      {
        currentParent.Invoke(new AWHelper.SetMenuItemEnableHandler(SetToolStripItemVisible), sender, bValue);
      }
      else
        menuStripItem.Visible = bValue;
    }

    private delegate void SetToolstripValueCallback(ToolStripItem toolstripItem, string property, object value);

    //https://stackoverflow.com/questions/7145408/invoke-toolstripmenuitem
    //public static void DoToolStripItem<TControl>(TControl ToolStripItem, Action<TControl> action) where TControl : ToolStripItem
    //{
    //  var toolStrip = ToolStripItem.GetCurrentParent();
    //  SetToolstripValueCallback callback = new SetToolstripValueCallback(SetToolstripPropertyValue);

    //  toolstripItem.Owner.Invoke(callback, new object[] { toolstripItem, property, value });
    //}

    //https://www.codeproject.com/Questions/159320/Enabling-Disabling-menu-item-from-different-thread

    public delegate void SetMenuItemEnableHandler(object sender, bool bValue);

    #endregion

    private const int GWL_STYLE = -16;
    private const int WS_VSCROLL = 0x00200000;

    [DllImport("user32.dll", ExactSpelling = false, CharSet = CharSet.Auto)]
    private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    private static bool IsVerticleScrollVisible(Control ctl)
    {
      var style = GetWindowLong(ctl.Handle, GWL_STYLE);
      return ((style & WS_VSCROLL) != 0);
    }

    public static IEnumerable<TreeNode> GetAllNodes(this TreeNodeCollection treeNodeCollection)
    {
      return treeNodeCollection.Cast<TreeNode>().Descendants(tn => tn.Nodes.Cast<TreeNode>());
    }

    /// <summary>
    ///   Expands to fit nodes.
    /// </summary>
    /// <remarks>http://stackoverflow.com/questions/11429900/how-to-calculate-and-change-treeview-width</remarks>
    /// <param name="e">The <see cref="TreeViewEventArgs" /> instance containing the event data.</param>
    public static void ResizeToFitNodes(TreeViewEventArgs e)
    {
      if (e.Action == TreeViewAction.Unknown)
        return;
      ResizeToFitNodes(e.Node.TreeView);
    }

    public static void ResizeToFitNodes(TreeView treeView)
    {
      if (treeView != null && treeView.Nodes.Count > 0)
      {
        var allNodes = treeView.Nodes.GetAllNodes();
        var maxRight = allNodes.Max(node => node.Bounds.Right);
        // GetVisibleScrollbars(treeView);
        var padding = 10;
        if (IsVerticleScrollVisible(treeView))
          padding += SystemInformation.VerticalScrollBarWidth;
        treeView.ClientSize = new Size(maxRight + padding, treeView.ClientSize.Height);
        var splitterPanel = treeView.Parent as SplitterPanel;
        if (splitterPanel != null)
        {
          var splitContainer = splitterPanel.Parent as SplitContainer;
          if (splitContainer != null) splitContainer.SplitterDistance = treeView.ClientSize.Width;
        }
      }
    }

    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <param name="queryable">The queryable.</param>
    /// <param name="pageIndex">Index of the page.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IQueryable SkipTakeDynamic(IQueryable queryable, int pageIndex, int pageSize)
    {
      return queryable.Skip(pageIndex*pageSize).Take(pageSize);
    }

    public static IEnumerable<TreeNode> AsEnumerable(this TreeNodeCollection treeNodeCollection)
    {
      return treeNodeCollection.Cast<TreeNode>();
    }

    public static void MakeFormatUsingTypeConverter(this ListControl listControl)
    {
      if (listControl != null)
      {
        listControl.FormattingEnabled = true;
        listControl.Format += FormatUsingTypeConverter;
      }
    }

    public static void FormatUsingTypeConverter(object sender, ListControlConvertEventArgs e)
    {
      var typeConverter = TypeDescriptor.GetConverter(e.Value);
      e.Value = typeConverter.ConvertToString(e.Value);
    }

    /// <summary>
    ///   Finds if file exists, throws a FileNotFoundException if it doesn't, searches for file relative to the
    ///   Application.ExecutablePath.
    /// </summary>
    /// <param name="fileName">Name of the file.</param>
    /// <param name="fileType">Type of the file, used in the exception message.</param>
    /// <returns>
    ///   fileName or full path of if relative to the Application.ExecutablePath and Environment.CurrentDirectory is not
    ///   the executableDirectory
    /// </returns>
    /// <exception cref="FileNotFoundException">
    ///   If the file is not found
    /// </exception>
    public static string FindIfFileExists(string fileName, string fileType)
    {
      if (!File.Exists(fileName))
      {
        var executableDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        if (executableDirectory != Environment.CurrentDirectory && executableDirectory != null)
        {
          var fullPath = Path.Combine(executableDirectory, fileName);
          if (!File.Exists(fullPath))
            throw new FileNotFoundException(String.Format("{0}: {1} not found!{2}", fileType, fileName, Environment.NewLine), fileName);
          fileName = fullPath;
        }
        else
          throw new FileNotFoundException(String.Format("{0}: {1} not found!{2}", fileType, fileName, Environment.NewLine), fileName);
      }
      return fileName;
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