using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AW.Win.Properties;
using Logging;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class frmTrace : Form
  {
    public frmTrace()
    {
      InitializeComponent();
      var dummy = DynamicQueryEngine.ArithAbortOn;
      Trace.Listeners.Add(new TextBoxTraceListener(textBoxTrace));
      comboBoxTraceLevel.DataSource = Enum.GetValues(typeof(TraceLevel));
    }

    private void FrmTrace_Load(object sender, EventArgs e)
    {
      LLBLTraceLevel = Settings.Default.TraceLevel;
      SetWindowSizeAndLocation(this, Settings.Default.TraceWindowSizeLocation);
    }

    public TraceLevel LLBLTraceLevel
    {
      get { return DynamicQueryEngineBase.Switch.Level; }
      set
      {
        DynamicQueryEngineBase.Switch.Level = value;
        if (!value.Equals(comboBoxTraceLevel.SelectedItem))
          comboBoxTraceLevel.SelectedItem = value;
      }
    }

    private void comboBoxTraceLevel_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxTraceLevel.SelectedItem != null && CanFocus)
        LLBLTraceLevel = (TraceLevel)comboBoxTraceLevel.SelectedItem;
    }

    private void frmTrace_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.TraceWindowSizeLocation = GetWindowNormalSizeAndLocation(this);
      Settings.Default.TraceLevel = LLBLTraceLevel;
    }

    private void frmTrace_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    #region SaveControlState

    public static void RestoreColumnsState(StringCollection cols, DataGridView dataGridView)
    {
      if (cols == null || dataGridView == null)
        return;

      var MaxDisplayIndex = dataGridView.ColumnCount - 1;
      // Restore the columns' state
      for (var i = 0; i < Math.Min(cols.Count, dataGridView.ColumnCount); ++i)
      {
        var a = cols[i].Split(',');
        dataGridView.Columns[i].DisplayIndex = Math.Min(Int16.Parse(a[0]), MaxDisplayIndex);
        dataGridView.Columns[i].Width = Int16.Parse(a[1]);
        dataGridView.Columns[i].Visible = bool.Parse(a[2]);
      }
    }

    public static StringCollection SaveColumnState(DataGridView dataGridView)
    {
      // Save column state data
      // including order, column width and whether or not the column is visible
      var stringCollection = new StringCollection();
      foreach (DataGridViewColumn column in dataGridView.Columns)
      {
        stringCollection.Add(string.Format(
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

    public static void SetWindowSizeAndLocation(Form form, Rectangle SizeAndLocation)
    {
      if (!SizeAndLocation.Location.IsEmpty)
        form.Location = SizeAndLocation.Location;
      if (!SizeAndLocation.Size.IsEmpty)
        form.Size = SizeAndLocation.Size;
    }

    /// <summary>
    /// Sets the window location only if the point exists on one of the screens.
    /// </summary>
    /// <param name="form">The form.</param>
    /// <param name="location">The location.</param>
    /// <remarks>//http://net-test2/mantis/view.php?id=4390 issue #4</remarks>
    public static void SetWindowLocationSafely(Form form, Point location)
    {
      if (!location.IsEmpty)
        foreach (var screen in Screen.AllScreens)
        {
          if (screen.WorkingArea.Contains(location))
          {
            form.Location = location;
            DebugOut("setting form: '" + form + "' location to: " + location);
            break;
          }
        }
    }

    #endregion

    /// <summary>
    /// Sends a msg to the Win32 debug output and prefixs it with the name off the method that called TraceOut
    /// </summary>
    /// <param name="msg">The message.</param>
    public static void TraceOut(string msg)
    {
      Trace.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    public static void DebugOut(string msg)
    {
      Debug.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    private void buttonClearTrace_Click(object sender, EventArgs e)
    {
      textBoxTrace.Clear();
    }
  }
}
