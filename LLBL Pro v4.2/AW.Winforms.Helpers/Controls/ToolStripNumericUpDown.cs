using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AW.Helper;

namespace AW.Winforms.Helpers.Controls
{
  /// <summary>
  /// From https://github.com/AdamsLair/duality/blob/master/DualityEditor/Controls/ToolStrip/ToolStripNumericUpDown.cs
  /// </summary>
  [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
  public class ToolStripNumericUpDown : ToolStripControlHost
  {
    private readonly FlowLayoutPanel _controlPanel;
    private readonly NumericUpDown _num;
    private readonly Label _txt;

    public event EventHandler ValueChanged
    {
      add { _num.ValueChanged += value; }
      remove { _num.ValueChanged -= value; }
    }

    [DefaultValue(true)]
    public bool TextVisible
    {
      get { return _txt.Visible; }
      set
      {
        _txt.Visible = value;
        UpdateAutoSize();
      }
    }

    public override string Text
    {
      get { return _txt.Text; }
      set
      {
        _txt.Text = value;
        UpdateAutoSize();
      }
    }

    public override Size Size
    {
      get { return base.Size; }
      set
      {
        if (base.Size != value && !AutoSize)
        {
          base.Size = value;
          OnSizeChanged();
        }
      }
    }

    [DefaultValue(50)]
    public int NumericWidth
    {
      get { return _num.Width; }
      set
      {
        _num.Width = value;
        UpdateAutoSize();
      }
    }

    [DefaultValue(typeof (decimal), "100")]
    public decimal Maximum
    {
      get { return _num.Maximum; }
      set { _num.Maximum = value; }
    }

    [DefaultValue(typeof (decimal), "0")]
    public decimal Minimum
    {
      get { return _num.Minimum; }
      set { _num.Minimum = value; }
    }

    [DefaultValue(typeof (decimal), "0")]
    public decimal Value
    {
      get { return _num.Value; }
      set { _num.Value = value; }
    }

    [DefaultValue(1)]
    public int DecimalPlaces
    {
      get { return _num.DecimalPlaces; }
      set { _num.DecimalPlaces = value; }
    }

    [DefaultValue(typeof (decimal), "1")]
    public decimal Increment
    {
      get { return _num.Increment; }
      set { _num.Increment = value; }
    }

    [DefaultValue(false)]
    public bool Hexadecimal
    {
      get { return _num.Hexadecimal; }
      set { _num.Hexadecimal = value; }
    }

    [DefaultValue(typeof (HorizontalAlignment), "Center")]
    public HorizontalAlignment NumericTextAlign
    {
      get { return _num.TextAlign; }
      set { _num.TextAlign = value; }
    }

    public Color NumBackColor
    {
      get { return _num.BackColor; }
      set { _num.BackColor = value; }
    }

    public ToolStripNumericUpDown() : base(new FlowLayoutPanel())
    {
      // Set up the FlowLayouPanel.
      _controlPanel = (FlowLayoutPanel) Control;
      _controlPanel.BackColor = Color.Transparent;
      _controlPanel.WrapContents = false;
      _controlPanel.AutoSize = true;
      _controlPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

      // Add child controls.
      _num = new NumericUpDown {Width = 50};
      _num.Height = _num.PreferredHeight;
      _num.Margin = new Padding(0, 1, 3, 1);
      _num.Value = 0;
      _num.Minimum = 0;
      _num.Maximum = 100;
      _num.DecimalPlaces = 0;
      _num.Increment = 1;
      _num.Hexadecimal = false;
      _num.TextAlign = HorizontalAlignment.Center;
      _num.MouseHover += HandleMouseHover;
      _num.MouseLeave += HandleMouseLeave;
      foreach (Control child in _num.Controls)
      {
        child.MouseHover += HandleMouseHover;
        child.MouseLeave += HandleMouseLeave;
      }
      _txt = new Label
      {
        Text = "NumericUpDown",
        TextAlign = ContentAlignment.MiddleRight,
        AutoSize = true,
        Dock = DockStyle.Left
      };
      _txt.MouseHover += HandleMouseHover;
      _txt.MouseLeave += HandleMouseLeave;
     // _controlPanel
      _controlPanel.Controls.Add(_txt);
      _controlPanel.Controls.Add(_num);
    }

    /// <summary>
    /// Handles the mouse hover. Need this for tooltips
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleMouseHover(object sender, EventArgs e)
    {
      OnMouseHover(e);
    }

    private void HandleMouseLeave(object sender, EventArgs e)
    {
      OnMouseLeave(e);
    }

    protected void UpdateAutoSize()
    {
      if (!AutoSize) return;
      AutoSize = false;
      AutoSize = true;
    }

    protected void OnSizeChanged()
    {
      if (_num != null && _controlPanel != null && _txt != null)
      {
        _num.Width = _controlPanel.ClientSize.Width - _txt.Width - _controlPanel.Margin.Horizontal - _controlPanel.Margin.Horizontal;
      }
    }

    public void DataBind(ApplicationSettingsBase settings)
    {
      _num.DataBindings.Add(new Binding("Value", settings, Name.After("UpDown"), true, DataSourceUpdateMode.OnPropertyChanged));
    }

  }
}