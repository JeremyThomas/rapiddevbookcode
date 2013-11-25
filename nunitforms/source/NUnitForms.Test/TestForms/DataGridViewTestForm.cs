using System;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications.TestForms
{
	public partial class DataGridViewTestForm : Form
	{
		public DataGridViewTestForm()
		{
			InitializeComponent();
		}

		private void DataGridViewTestForm_Load(object sender, EventArgs e)
		{
			dataGridView.AutoGenerateColumns = true;
		}
	}
}