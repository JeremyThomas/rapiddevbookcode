using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AW.Winforms.Helpers.Controls
{
  /// <summary>
  /// From https://github.com/AdamsLair/duality/blob/master/DualityEditor/Controls/ToolStrip/ToolStripCheckBox.cs
  /// </summary>
  [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
  public class ToolStripCheckBox : ToolStripControlHost
  {
    private readonly CheckBox _checkBox;

    public event EventHandler CheckedChanged
    {
      add { _checkBox.CheckedChanged += value; }
      remove { _checkBox.CheckedChanged -= value; }
    }

    public event EventHandler CheckStateChanged
    {
      add { _checkBox.CheckStateChanged += value; }
      remove { _checkBox.CheckStateChanged -= value; }
    }

    public override string Text
    {
      get { return _checkBox.Text; }
      set
      {
        _checkBox.Text = value;
        UpdateAutoSize();
      }
    }

    public bool Checked
    {
      get { return _checkBox.Checked; }
      set { _checkBox.Checked = value; }
    }

    public CheckState CheckState
    {
      get { return _checkBox.CheckState; }
      set { _checkBox.CheckState = value; }
    }

    public ToolStripCheckBox() : base(new CheckBox())
    {
      // Set up the FlowLayouPanel.
      _checkBox = (CheckBox) Control;
      _checkBox.AutoSize = true;
    }

    protected void UpdateAutoSize()
    {
      if (!AutoSize) return;
      AutoSize = false;
      AutoSize = true;
    }
  }
}