using System;
using System.Diagnostics;
using System.Windows.Forms;
using AW.Data.DaoClasses;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses.ExpressionHandlers;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
	public partial class FrmTrace : Form
	{
		private int _textBoxTraceListenerIndex;
		private TextBoxTraceListener _textBoxTraceListener;

		public FrmTrace()
		{
			InitializeComponent();
			var dummy = DynamicQueryEngine.ArithAbortOn;
			comboBoxDQETraceLevel.DataSource = Enum.GetValues(typeof (TraceLevel));
			comboBoxLinqTraceLevel.DataSource = Enum.GetValues(typeof (TraceLevel));
			comboBoxDQETraceLevel.DataBindings.Add(new Binding("SelectedValue", Settings.Default, "TraceLevel", true, DataSourceUpdateMode.OnPropertyChanged));
			comboBoxLinqTraceLevel.DataBindings.Add(new Binding("SelectedValue", Settings.Default, "LinqTraceLevel", true, DataSourceUpdateMode.OnPropertyChanged));
		}

		private void FrmTrace_Load(object sender, EventArgs e)
		{
			DQETraceLevel = Settings.Default.TraceLevel;
			LinqTraceLevel = Settings.Default.LinqTraceLevel;
			AWHelper.SetWindowSizeAndLocation(this, Settings.Default.TraceWindowSizeLocation);
			checkBoxSQLTrace_CheckedChanged(checkBoxSQLTrace, e);
		}

		private void frmTrace_Shown(object sender, EventArgs e)
		{
			_textBoxTraceListener = new TextBoxTraceListener(textBoxTrace);
			_textBoxTraceListenerIndex = Trace.Listeners.Add(_textBoxTraceListener);
		}

		private void frmTrace_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.TraceWindowSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
		}

		private void frmTrace_FormClosed(object sender, FormClosedEventArgs e)
		{
			Trace.Listeners.RemoveAt(_textBoxTraceListenerIndex);
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

		private void comboBoxTraceLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxDQETraceLevel.SelectedItem != null && CanFocus)
				DQETraceLevel = (TraceLevel) comboBoxDQETraceLevel.SelectedItem;
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

		private void comboBoxLinqTraceLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLinqTraceLevel.SelectedItem != null && CanFocus)
				LinqTraceLevel = (TraceLevel) comboBoxLinqTraceLevel.SelectedItem;
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
			//if (traceON)
			//  CommonDaoBase.SQLTraceEvent += CommonDaoBase_SQLTraceEvent;
			//else
			//  CommonDaoBase.SQLTraceEvent -= CommonDaoBase_SQLTraceEvent;
		}

		private void CommonDaoBase_SQLTraceEvent(object sender, SQLTraceEventArgs e)
		{
			_textBoxTraceListener.WriteLine(e.SQLTrace);
		}
	}
}