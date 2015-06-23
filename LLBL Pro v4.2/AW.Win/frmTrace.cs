using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AW.Data.DaoClasses;
using AW.Helper;
using AW.Helper.Annotations;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses.ExpressionHandlers;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public sealed partial class FrmTrace : FrmPersistantLocation, INotifyPropertyChanged
  {
    private int _textBoxTraceListenerIndex;
    private TextBoxTraceListener _textBoxTraceListener;
    private readonly TraceLevel[] _traceLevelEnumerable = GeneralHelper.EnumAsEnumerable(TraceLevel.Error, TraceLevel.Warning);

    static FrmTrace()
    {
      var dummy = DynamicQueryEngine.ArithAbortOn;
    }

    public FrmTrace()
    {
      InitializeComponent();
      frmTraceBindingSource.DataSource = this;      
      _textBoxTraceListener = new TextBoxTraceListener(textBoxTrace);
    }

    private void FrmTrace_Load(object sender, EventArgs e)
    {
      DQETraceLevel = Settings.Default.TraceLevel;
      LinqTraceLevel = Settings.Default.LinqTraceLevel;
      QueryExecutionTraceLevel = Settings.Default.QueryExecutionTraceLevel;
      PersistenceExecutionTraceLevel = Settings.Default.PersistenceExecutionTraceLevel;
      checkBoxSQLTrace.Checked = Settings.Default.SQLTrace;
      //checkBoxSQLTrace_CheckedChanged(checkBoxSQLTrace, e);
    }

    private void frmTrace_Shown(object sender, EventArgs e)
    {
      _textBoxTraceListenerIndex = Trace.Listeners.Add(_textBoxTraceListener);
    }

    private void frmTrace_FormClosed(object sender, FormClosedEventArgs e)
    {
      Trace.Listeners.RemoveAt(_textBoxTraceListenerIndex);
      Settings.Default.QueryExecutionTraceLevel = QueryExecutionTraceLevel;
      Settings.Default.LinqTraceLevel = LinqTraceLevel;
      Settings.Default.TraceLevel = DQETraceLevel;
      Settings.Default.PersistenceExecutionTraceLevel = PersistenceExecutionTraceLevel;
      Settings.Default.SQLTrace = checkBoxSQLTrace.Checked;
    }

// ReSharper disable MemberCanBePrivate.Global
    public TraceLevel DQETraceLevel
    {
      get { return DynamicQueryEngineBase.Switch.Level; }
      set
      {
        DynamicQueryEngineBase.Switch.Level = value;
        OnPropertyChanged("DQETraceLevel");
      }
    }

    public TraceLevel LinqTraceLevel
    {
      get { return GenericExpressionHandler.Switch.Level; }
      set
      {
        GenericExpressionHandler.Switch.Level = value;
        OnPropertyChanged("LinqTraceLevel");
      }
    }

    public TraceLevel QueryExecutionTraceLevel
    {
      get { return TraceHelper.QueryExecutionSwitch.Level; }
      set
      {
        TraceHelper.QueryExecutionSwitch.Level = value;
        OnPropertyChanged("QueryExecutionTraceLevel");
      }
    }

    public TraceLevel PersistenceExecutionTraceLevel
    {
      get { return TraceHelper.PersistenceExecutionSwitch.Level; }
      set
      {
        TraceHelper.PersistenceExecutionSwitch.Level = value;
        OnPropertyChanged("PersistenceExecutionTraceLevel");
      }
    }

    public TraceLevel[] TraceLevelEnumerable
    {
      get { return _traceLevelEnumerable; }
    }

    // ReSharper restore MemberCanBePrivate.Global

    private void buttonClearTrace_Click(object sender, EventArgs e)
    {
      textBoxTrace.Clear();
    }

    private void checkBoxSQLTrace_CheckedChanged(object sender, EventArgs e)
    {
      SetSQLTrace(checkBoxSQLTrace.Checked);
    }

    private void SetSQLTrace(bool traceON)
    {
      if (traceON)
        CommonDaoBase.SQLTraceEvent += CommonDaoBase_SQLTraceEvent;
      else
        CommonDaoBase.SQLTraceEvent -= CommonDaoBase_SQLTraceEvent;
    }

    private void CommonDaoBase_SQLTraceEvent(object sender, SQLTraceEventArgs e)
    {
      _textBoxTraceListener.WriteLine(e.SQLTrace);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    private void OnPropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}