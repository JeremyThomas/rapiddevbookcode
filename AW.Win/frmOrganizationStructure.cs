using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AW.Data;

namespace AW.Winforms.Helpers
{
  public partial class frmOrganizationStructure : Form
  {
    public frmOrganizationStructure()
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
