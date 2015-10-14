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
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace Northwind.Win
{
  public partial class FrmEntityBrowser : FrmPersistantLocation
  {
    public FrmEntityBrowser()
    {
      InitializeComponent();
      var linqMetaData = Factories.CreateLinqMetaData();
      //linqMetaData.ContextToUse=new Context();
      usrCntrlEntityBrowser1.Initialize(linqMetaData);
      ensureFilteringEnabledCheckBox.Checked = usrCntrlEntityBrowser1.EnsureFilteringEnabled;
      useContextCheckBox.Checked = usrCntrlEntityBrowser1.UseContext;
      useSchemaCheckBox.Checked = usrCntrlEntityBrowser1.UseSchema;
      prefixDelimiterTextBox.Text = usrCntrlEntityBrowser1.PrefixDelimiter;
      cacheDurationInSecondsNumericUpDown.Value = usrCntrlEntityBrowser1.CacheDurationInSeconds;
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
      var query = linqMetaData.Employee;
      ShowControlInForm(
        HierarchyEditor.HierarchyEditorFactory(query, e => e.EmployeeId, e => e.ReportsTo.HasValue,
        e => e.ReportsTo.GetValueOrDefault(), (e, m) => e.Manager = m, em => em.FirstName, em => em.Staff, new DataEditorLLBLDataScopePersister(query))
        , "EmployeeHierarchyInTree", this);
    }

    private void toolStripButtonShowEmployeeHierarchyInTreeByID_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      var query = linqMetaData.Employee;
      ShowControlInForm(new HierarchyEditor(query, "EmployeeId", "ReportsTo", "FirstName", new DataEditorLLBLDataScopePersister(query)),"EmployeeHierarchyInTree", this);
    }

    private void toolStripButtonCustomerGroupedByCountry_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      var groupBy = linqMetaData.Customer.PrefetchOrders()
        .ToEntityCollection2()
        .GroupBy(c => c.Country);
      ShowControlInForm(new HierarchyEditor(groupBy, "CompanyName", "Orders"));
    }

    private void cacheDurationInSecondsNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      usrCntrlEntityBrowser1.CacheDurationInSeconds = (int) cacheDurationInSecondsNumericUpDown.Value;
    }

    private void useContextCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      usrCntrlEntityBrowser1.UseContext = useContextCheckBox.Checked;
    }

    private void toolStripButtonShowEmployeeHierarchyInTreePostProcessing_Click(object sender, EventArgs e)
    {
      var linqMetaData = Factories.CreateLinqMetaData();
      ShowControlInForm(LLBLWinformHelper.HierarchyEditorFactory(linqMetaData.Employee,
        EmployeeEntity.WireUpSelfJoinAndRemoveChildren,
        em => em.FirstName, em => em.Staff));
    }
  }
}