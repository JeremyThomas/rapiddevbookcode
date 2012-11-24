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
	public partial class FrmTrace : FrmPersistantLocation, INotifyPropertyChanged
	{
		private int _textBoxTraceListenerIndex;
		private TextBoxTraceListener _textBoxTraceListener;
    private readonly TraceLevel[] _traceLevelEnumerable = GeneralHelper.EnumAsEnumerable(TraceLevel.Error, TraceLevel.Warning);

	  public FrmTrace()
		{
			InitializeComponent();
			var dummy = DynamicQueryEngine.ArithAbortOn;
	    frmTraceBindingSource.DataSource = this;
		//	comboBoxDQETraceLevel.DataBindings.Add(new Binding("SelectedValue", Settings.Default, "TraceLevel", true, DataSourceUpdateMode.OnPropertyChanged));
	//		comboBoxLinqTraceLevel.DataBindings.Add(new Binding("SelectedValue", Settings.Default, "LinqTraceLevel", true, DataSourceUpdateMode.OnPropertyChanged));
      //comboBoxLinqTraceLevel.DataBindings.Add(new Binding("SelectedValue", Settings.Default, "QueryExecutionTraceLevel", true, DataSourceUpdateMode.OnPropertyChanged));
		}

		private void FrmTrace_Load(object sender, EventArgs e)
		{
			DQETraceLevel = Settings.Default.TraceLevel;
			LinqTraceLevel = Settings.Default.LinqTraceLevel;
      QueryExecutionTraceLevel = Settings.Default.QueryExecutionTraceLevel;
			checkBoxSQLTrace_CheckedChanged(checkBoxSQLTrace, e);
		}

		private void frmTrace_Shown(object sender, EventArgs e)
		{
			_textBoxTraceListener = new TextBoxTraceListener(textBoxTrace);
			_textBoxTraceListenerIndex = Trace.Listeners.Add(_textBoxTraceListener);
		}

	  private void frmTrace_FormClosed(object sender, FormClosedEventArgs e)
		{
			Trace.Listeners.RemoveAt(_textBoxTraceListenerIndex);
      Settings.Default.QueryExecutionTraceLevel = QueryExecutionTraceLevel;
      Settings.Default.LinqTraceLevel = LinqTraceLevel;
      Settings.Default.TraceLevel = DQETraceLevel;
		}

		public TraceLevel DQETraceLevel
		{
			get { return DynamicQueryEngineBase.Switch.Level; }
			set
			{
				DynamicQueryEngineBase.Switch.Level = value;
				if (!value.Equals(comboBoxDQETraceLevel.SelectedItem))
					comboBoxDQETraceLevel.SelectedItem = value;
			}
		}

		public TraceLevel LinqTraceLevel
		{
			get { return GenericExpressionHandler.Switch.Level; }
			set
			{
				GenericExpressionHandler.Switch.Level = value;
				if (!value.Equals(comboBoxLinqTraceLevel.SelectedItem))
					comboBoxLinqTraceLevel.SelectedItem = value;
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

	  public TraceLevel[] TraceLevelEnumerable
	  {
	    get { return _traceLevelEnumerable; }
	  }

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
	  protected virtual void OnPropertyChanged(string propertyName)
	  {
	    var handler = PropertyChanged;
	    if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
	  }
	}
}