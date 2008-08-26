using System;
using System.Diagnostics;
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
      comboBoxTraceLevel.DataSource = Enum.GetValues(typeof (TraceLevel));
    }

    private void FrmTrace_Load(object sender, EventArgs e)
    {
      LLBLTraceLevel = Settings.Default.TraceLevel;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.TraceWindowSizeLocation);
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
        LLBLTraceLevel = (TraceLevel) comboBoxTraceLevel.SelectedItem;
    }

    private void frmTrace_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.TraceWindowSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.TraceLevel = LLBLTraceLevel;
    }

    private void frmTrace_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    private void buttonClearTrace_Click(object sender, EventArgs e)
    {
      textBoxTrace.Clear();
    }
  }
}