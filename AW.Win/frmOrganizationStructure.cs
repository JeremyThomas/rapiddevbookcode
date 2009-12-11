using System;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;

namespace AW.Win
{
  public partial class FrmOrganizationStructure : Form
  {
    public FrmOrganizationStructure()
    {
      InitializeComponent();
    }

    private void frmOrganizationStructure_Load(object sender, EventArgs e)
    {
      employeeEntityBindingSource.DataSource = EmployeeEntity.GetEmployees();
    }

    private void employeeEntityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }
  }
}