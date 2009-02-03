using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using AW.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public static class AWHelper
  {
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
    public static void SetWindowLocationSafely(Form form, Point location)
    {
      if (!location.IsEmpty)
        foreach (var screen in Screen.AllScreens)
        {
          if (screen.WorkingArea.Contains(location))
          {
            form.Location = location;
            GlobalHelper.DebugOut("setting form: '" + form + "' location to: " + location);
            break;
          }
        }
    }

    #endregion

    #region Validatation

    public static bool ValidatePropertyAssignment<T>(
      Control ControltoValidate,
      int FieldToValidate,
      T Value, string ErrorMessage,
      ErrorProvider myError,
      EntityBase Entity)
    {
      var Validated = true;
      try
      {
        var Validator = Entity.Validator;
        if (Value.Equals(Entity.GetCurrentFieldValue(FieldToValidate)) == false
            && Validator.ValidateFieldValue(Entity, FieldToValidate, Value) == false
          )
        {
          myError.SetError(ControltoValidate, ErrorMessage);
          Validated = false;
        }
        else
          myError.SetError(ControltoValidate, "");
      }
      catch (Exception err)
      {
        myError.SetError(ControltoValidate, err.Message);
        Validated = false;
      }
      return Validated;
    }

    public static bool ValidateForm(Control mycontrol, ErrorProvider MyError)
    {
      var IsValid = true;
      foreach (Control ChildControl in mycontrol.Controls)
      {
        if (MyError.GetError(ChildControl) != "")
        {
          IsValid = false;
          break;
        }
        if (ChildControl.Controls.Count > 0)
        {
          IsValid = ValidateForm(ChildControl, MyError);
          if (IsValid == false)
            break;
        }
      }
      return IsValid;
    }

    #endregion
  }
}