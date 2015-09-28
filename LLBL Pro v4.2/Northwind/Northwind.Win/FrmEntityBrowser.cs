using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

      var linqMetaData = Factories.CreateLinqMetaData();
      usrCntrlEntityBrowser1.Initialize(linqMetaData,ensureFilteringEnabled:false);
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
      ShowEmployeeHierarchyInTree();
    }

    private void ShowEmployeeHierarchyInTree()
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      ShowControlInForm(LLBLWinformHelper.HierarchyEditorFactory(linqMetaData.Employee, e => e.EmployeeId, e => e.ReportsTo.HasValue, 
        e => e.ReportsTo.GetValueOrDefault(), (e, m) => e.Manager = m, em => em.FirstName, em => em.Staff), "EmployeeHierarchyInTree", this);
    }

    private void toolStripButtonShowEmployeeHierarchyInTreeByID_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      ShowControlInForm(LLBLWinformHelper.HierarchyEditorFactory(linqMetaData.Employee, "EmployeeId", "ReportsTo", "FirstName"), "EmployeeHierarchyInTree", this);
    }

    private void toolStripButtonCustomerGroupedByCountry_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      var groupBy = linqMetaData.Customer.PrefetchOrders()
        .ToEntityCollection2()
        .GroupBy(c => c.Country);
      ShowControlInForm(new HierarchyEditor(groupBy, "CompanyName", "Orders"));
    }
  }
}