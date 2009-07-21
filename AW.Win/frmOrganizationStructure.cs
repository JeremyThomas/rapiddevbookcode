using System;
using System.Windows.Forms;
using AW.Data;

namespace AW.Winforms.Helpers
{
  public partial class FrmOrganizationStructure : Form
  {
    public FrmOrganizationStructure()
    {
      InitializeComponent();
    }

    private void frmOrganizationStructure_Load(object sender, EventArgs e)
    {
      employeeEntityBindingSource.DataSource = MetaSingletons.MetaData.Employee;
    }

    private void employeeEntityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }
  }
}