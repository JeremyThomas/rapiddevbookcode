using System;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AW.Helper;

namespace AW.Winforms.Helpers.Controls
{
  /// <summary>
  /// From https://github.com/AdamsLair/duality/blob/master/DualityEditor/Controls/ToolStrip/ToolStripCheckBox.cs
  /// </summary>
  [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
  public class ToolStripCheckBox : ToolStripControlHost
  {
    public CheckBox CheckBox { get; private set; }

    public event EventHandler CheckedChanged
    {
      add { CheckBox.CheckedChanged += value; }
      remove { CheckBox.CheckedChanged -= value; }
    }

    public event EventHandler CheckStateChanged
    {
      add { CheckBox.CheckStateChanged += value; }
      remove { CheckBox.CheckStateChanged -= value; }
    }

    public override string Text
    {
      get { return CheckBox.Text; }
      set
      {
        CheckBox.Text = value;
        UpdateAutoSize();
      }
    }

    public bool Checked
    {
      get { return CheckBox.Checked; }
      set { CheckBox.Checked = value; }
    }

    public CheckState CheckState
    {
      get { return CheckBox.CheckState; }
      set { CheckBox.CheckState = value; }
    }

    public ToolStripCheckBox() : base(new CheckBox())
    {
      // Set up the FlowLayouPanel.
      CheckBox = (CheckBox) Control;
      CheckBox.AutoSize = true;
    }

    protected void UpdateAutoSize()
    {
      if (!AutoSize) return;
      AutoSize = false;
      AutoSize = true;
    }

    public void DataBind(ApplicationSettingsBase settings)
    {
      CheckBox.DataBindings.Add(new Binding("Checked", settings, Name.After("CheckBox"), true, DataSourceUpdateMode.OnPropertyChanged));
    }
  }
}