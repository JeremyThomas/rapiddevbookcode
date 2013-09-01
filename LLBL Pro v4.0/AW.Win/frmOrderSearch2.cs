using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.Linq;
using AW.Data.Queries;
using AW.Data.ViewModels;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using Korzh.EasyQuery;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Win
{
  public partial class FrmOrderSearch2 : FrmPersistantLocation
  {
    private FrmStatusBar _frmStatusBar;
    private Data.ViewModels.OrderSearchCriteria _orderSearchCriteria;
    private object _results;

    public FrmOrderSearch2()
    {
      InitializeComponent();
      query1.Model.LoadFromCollectionContainer(typeof (LinqMetaData), typeof (DataSource<>));
      foreach (var subEntity in query1.Model.EntityRoot.SubEntities)
      {
        subEntity.UseInConditions = subEntity.Info.Values.Contains(typeof(SalesOrderHeaderEntity)) || subEntity.Info.Values.Contains(typeof(CustomerEntity))
          || subEntity.Info.Values.Contains(typeof(CustomerAddressEntity))
          || subEntity.Info.Values.Contains(typeof(ContactEntity));
        if (subEntity.UseInConditions)
          foreach (var entityAttr in subEntity.Attributes)
          {
            if (entityAttr.DataType == DataType.Bool && entityAttr.Caption.StartsWith("AlreadyFetched")
                || entityAttr.Caption.StartsWith("AlwaysFetch")
                || entityAttr.Caption.EndsWith("ReturnsNewIfNotFound")
                || entityAttr.Caption == "IsNew" || entityAttr.Caption == "IsDirty")
              entityAttr.UseInConditions = false;
          }
      }
      QPanel.Activate();
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(Settings.Default.FrmOrderSearchPredicate))
        query1.LoadFromString(Settings.Default.FrmOrderSearchPredicate);
    }

    private void frmOrderSearch_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.FrmOrderSearchPredicate = query1.SaveToString();
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      orderSearchCriteria1.OrderSearchCriteriaOnClosing();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _orderSearchCriteria = orderSearchCriteria1.GetCriteria();

      btnSearch.Enabled = false;
      _frmStatusBar = new FrmStatusBar();
      _frmStatusBar.Show();
      _frmStatusBar.CancelButtonClicked += FrmStatusBarCancelButtonClicked;
      searchWorker.RunWorkerAsync();
    }

    private void FrmStatusBarCancelButtonClicked(object sender, CancelEventArgs e)
    {
      searchWorker.CancelAsync();
      btnSearch.Enabled = true;
    }

    private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var order = new SalesOrderHeaderEntity {CustomerID = 17018, ContactID = 4975, BillToAddressID = 14810, ShipToAddressID = 14810};
      ((FrmMain) MdiParent).LaunchChildForm(typeof (SalesOrderHeaderEntity), order);
    }

    private void dgResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var order = salesOrderHeaderEntityDataGridView.Rows[e.RowIndex].DataBoundItem as SalesOrderHeaderEntity;
      ((FrmMain) MdiParent).LaunchChildForm(typeof (FrmOrderEdit), order);
    }

    /// <summary>
    ///   Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs" /> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var predicate = PredicateBuilder.True<SalesOrderHeaderEntity>();
      IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader;
      try
      {
        predicate = predicate.AddMethodCallExpression(FrmEasyQuery.GetLinqExpression(query1) as MethodCallExpression);
      }
      catch (Exception)
      {
      }
      if (Settings.Default.UsePredicate)
      {
        predicate = predicate.FilterByDateOrderIDOrderNumberCustomerNameAddressPredicateBuilder(_orderSearchCriteria);
      }
      else
      {
        salesOrderHeaderQuery = salesOrderHeaderQuery.FilterByDateOrderIDOrderNumberCustomerNameAddress(_orderSearchCriteria);
        salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      }
      salesOrderHeaderQuery = salesOrderHeaderQuery.Where(predicate);
      if (MaxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(MaxNumberOfItemsToReturn);
      _results = salesOrderHeaderQuery.ToEntityCollection();
    }

    public int MaxNumberOfItemsToReturn
    {
      get { return Convert.ToInt32(numericUpDownNumRows.Value); }
      set { numericUpDownNumRows.Value = value; }
    }

    private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
        Application.OnThreadException(e.Error);
      if (_frmStatusBar != null)
        _frmStatusBar.Close();
      btnSearch.Enabled = true;
      salesOrderHeaderEntityBindingSource.DataSource = _results;
    }

  }
}