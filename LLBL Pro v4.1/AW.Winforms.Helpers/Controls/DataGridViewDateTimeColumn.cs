using System;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.Controls
{

  #region DataGridViewDateTimeColumn

  /// <summary>
  /// DateTimePicker with ShowUpDown on
  /// </summary>
  /// <see cref="http://www.codeproject.com/Articles/14674/Generic-DataGridView-V2-0" />
  /// <see cref="http://msdn.microsoft.com/en-us/library/7tas5c80.aspx" />
  public class DataGridViewDateTimeColumn : DataGridViewColumn
  {
    public DataGridViewDateTimeColumn()
      : base(new DateTimeCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
      get { return base.CellTemplate; }
      set
      {
        if (value != null &&
            !value.GetType().IsAssignableFrom(typeof (DateTimeCell)))
        {
          throw new InvalidCastException("Must be a DateTimeCell");
        }
        base.CellTemplate = value;
      }
    }
  }

  public class DateTimeCell : DataGridViewTextBoxCell
  {
    public DateTimeCell()
      : base()
    {
      // Use the short date format.
      Style.Format = "g";
    }

    public override void InitializeEditingControl(int rowIndex, object
      initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
    {
      // Set the value of the editing control to the current cell value.
      base.InitializeEditingControl(rowIndex, initialFormattedValue,
        dataGridViewCellStyle);
      var ctl =
        DataGridView.EditingControl as DateTimeEditingControl;

      if (Value != DBNull.Value)
      {
        ctl.Value = (DateTime) Value;
      }
    }

    public override Type EditType
    {
      get
      {
        // Return the type of the editing contol that DateTimeCell uses.
        return typeof (DateTimeEditingControl);
      }
    }

    public override Type ValueType
    {
      get
      {
        // Return the type of the value that DateTimeCell contains.
        return typeof (DateTime);
      }
    }

    public override object DefaultNewRowValue
    {
      get
      {
        // Use the current date and time as the default value.
        return DateTime.Now;
      }
    }
  }

  internal class DateTimeEditingControl : DateTimePicker, IDataGridViewEditingControl
  {
    private bool _valueChanged;

    public DateTimeEditingControl()
    {
      Format = DateTimePickerFormat.Custom;
      CustomFormat = "MM dd yyyy hh mm ss";
      ShowUpDown = true;
    }

    // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
    // property.
    public object EditingControlFormattedValue
    {
      get { return Value.ToShortDateString(); }
      set
      {
        if (value is String)
        {
          Value = DateTime.Parse((String) value);
        }
      }
    }

    // Implements the 
    // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
    public object GetEditingControlFormattedValue(
      DataGridViewDataErrorContexts context)
    {
      return EditingControlFormattedValue;
    }

    // Implements the 
    // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
    public void ApplyCellStyleToEditingControl(
      DataGridViewCellStyle dataGridViewCellStyle)
    {
      Font = dataGridViewCellStyle.Font;
      CalendarForeColor = dataGridViewCellStyle.ForeColor;
      CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
    // property.
    public int EditingControlRowIndex { get; set; }

    // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
    // method.
    public bool EditingControlWantsInputKey(
      Keys key, bool dataGridViewWantsInputKey)
    {
      // Let the DateTimePicker handle the keys listed.
      switch (key & Keys.KeyCode)
      {
        case Keys.Left:
        case Keys.Up:
        case Keys.Down:
        case Keys.Right:
        case Keys.Home:
        case Keys.End:
        case Keys.PageDown:
        case Keys.PageUp:
          return true;
        default:
          return false;
      }
    }

    // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
    // method.
    public void PrepareEditingControlForEdit(bool selectAll)
    {
      // No preparation needs to be done.
    }

    // Implements the IDataGridViewEditingControl
    // .RepositionEditingControlOnValueChange property.
    public bool RepositionEditingControlOnValueChange
    {
      get { return false; }
    }

    // Implements the IDataGridViewEditingControl
    // .EditingControlDataGridView property.
    public DataGridView EditingControlDataGridView { get; set; }

    // Implements the IDataGridViewEditingControl
    // .EditingControlValueChanged property.
    public bool EditingControlValueChanged
    {
      get { return _valueChanged; }
      set { _valueChanged = value; }
    }

    // Implements the IDataGridViewEditingControl
    // .EditingPanelCursor property.
    public Cursor EditingPanelCursor
    {
      get { return base.Cursor; }
    }

    protected override void OnValueChanged(EventArgs eventargs)
    {
      // Notify the DataGridView that the contents of the cell
      // have changed.
      _valueChanged = true;
      EditingControlDataGridView.NotifyCurrentCellDirty(true);
      base.OnValueChanged(eventargs);
    }
  }

  #endregion
}