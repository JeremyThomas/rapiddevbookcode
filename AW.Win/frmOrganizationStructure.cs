using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public partial class FrmOrganizationStructure : FrmPersistantLocation
  {
    public FrmOrganizationStructure()
    {
      InitializeComponent();
    }

    public EmployeeCollection EmployeeCollection
    {
      get { return ((EmployeeCollection) employeeEntityBindingSource.DataSource); }
      set { employeeEntityBindingSource.DataSource = value; }
    }

    private void FrmOrganizationStructureLoad(object sender, EventArgs e)
    {
      EmployeeCollection = LookUpQueries.GetEmployees();
      EmployeeCollection.RemovedEntitiesTracker = new EmployeeCollection();
    }

    private void FrmOrganizationStructure_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void employeeEntityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void employeeEntityBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (employeeEntityBindingSource.DataSource is EmployeeCollection && !employeeEntityBindingNavigatorSaveItem.Enabled)
        employeeEntityBindingNavigatorSaveItem.Enabled = EmployeeCollection.ContainsDirtyContents
                                                         || (EmployeeCollection.RemovedEntitiesTracker != null && EmployeeCollection.RemovedEntitiesTracker.Count > 0);
    }

    private void employeeEntityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      EmployeeCollection.SaveMulti(true);
      EmployeeCollection.RemovedEntitiesTracker.DeleteMulti();
      employeeEntityBindingNavigatorSaveItem.Enabled = false;
    }

    private void toolStripButtonRevert_Click(object sender, EventArgs e)
    {
      EmployeeCollection.RevertChangesToDBValue();
      foreach (var employeeEntity in EmployeeCollection.RemovedEntitiesTracker.Cast<EmployeeEntity>())
      {
        EmployeeCollection.Add(employeeEntity);
      }
      EmployeeCollection.RemovedEntitiesTracker.Clear();
      dataTreeViewrOganizationStructure.ResetData();
      dataTreeViewrOganizationStructureEcho.ResetData();
    }

    private void toolStripButtonExpand_Click(object sender, EventArgs e)
    {
      dataTreeViewrOganizationStructure.ExpandAll();
      dataTreeViewrOganizationStructureEcho.ExpandAll();
    }

    private void toolStripButtonCollapse_Click(object sender, EventArgs e)
    {
      dataTreeViewrOganizationStructure.CollapseAll();
      dataTreeViewrOganizationStructureEcho.CollapseAll();
    }
  }
}