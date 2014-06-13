using System;
using System.Windows.Forms;

namespace AW.Test.Helpers
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