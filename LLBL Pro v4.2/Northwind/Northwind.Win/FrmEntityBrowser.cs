using System;
using System.Configuration;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.LLBL;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.Services;
using Northwind.Win.NorthwindODataSRSharedTypes;

namespace Northwind.Win
{
  public partial class FrmEntityBrowser : FrmPersistantLocation
  {
    public FrmEntityBrowser()
    {
      InitializeComponent();

      var linqMetaData = Factories.CreateLINQMetaData();
      usrCntrlEntityBrowser1.Initialize(linqMetaData);
      //Done in CommonEntityBase  CacheController.RegisterCache(dataAccessAdapter.ConnectionString, new ResultsetCache()); 
      Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
    }

    private void toolStripButtonRemote_Click(object sender, EventArgs e)
    {
      try
      {
        var baseAddress = ConfigurationManager.AppSettings["WcfDataServiceUrl"];
        var uri = new Uri(baseAddress); // + typeof(LLBLGenProODataService).Name);
        var llblGenProODataService = new LLBLGenProODataService(uri, new LinqMetaData());
        usrCntrlEntityBrowser1.Initialize(llblGenProODataService, llblGenProODataService.GetDataServiceQueryableForEntity);
      }
      catch (Exception ex)
      {
        Application.OnThreadException(ex);
      }
    }

    private void toolStripButtonShowEmployeeHierarchyInTree_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLINQMetaData();
      var employeeEntities = EmployeeEntity.WireUpSelfJoin(linqMetaData.Employee.ToEntityCollection2());
      // employeeEntities.ShowHierarchyInTree(linqMetaData.AdapterToUse, "EmployeeId", "ReportsTo", "FirstName");
      // var hierarchyEditor = new HierarchyEditor(employeeEntities, "FirstName", "Staff",(IDataEditorPersister)null);
      //ShowControlInForm(new HierarchyEditor(employeeEntities, "EmployeeId", "ReportsTo", "FirstName",  
      //  new LLBLWinformHelper.DataEditorLLBLAdapterPersister(linqMetaData.AdapterToUse)), "EmployeeHierarchyInTree", this);
      ShowControlInForm(HierarchyEditor.HierarchyEditorFactory(employeeEntities, em => em.FirstName, em => em.Staff,
        new LLBLWinformHelper.DataEditorLLBLAdapterPersister(linqMetaData.AdapterToUse)), "EmployeeHierarchyInTree", this);
    }
  }
}