using System;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.Queries;

namespace AW.Win
{
  public partial class FrmOrganizationStructure : Form
  {
    public FrmOrganizationStructure()
    {
      InitializeComponent();
    }

    public EmployeeCollection EmployeeCollection
    {
      get { return ((EmployeeCollection)employeeEntityBindingSource.DataSource); }
      set { employeeEntityBindingSource.DataSource = value; }
    }

    private void FrmOrganizationStructureLoad(object sender, EventArgs e)
    {
      EmployeeCollection = LookUpQueries.GetEmployees();
    }

    private void employeeEntityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void employeeEntityBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
    {
      if (employeeEntityBindingSource.DataSource is EmployeeCollection)
      employeeEntityBindingNavigatorSaveItem.Enabled = EmployeeCollection.ContainsDirtyContents;
    }

    private void employeeEntityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      EmployeeCollection.SaveMulti(true);
      employeeEntityBindingNavigatorSaveItem.Enabled = false;
    }
  }
}