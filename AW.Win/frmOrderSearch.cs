using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.Linq;
using AW.Data.Queries;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public partial class FrmOrderSearch : FrmPersistantLocation
  {
    private FrmStatusBar _frmStatusBar;
    private Data.ViewModels.OrderSearchCriteria _orderSearchCriteria;
    private int _maxNumberOfItemsToReturn;
    private bool _prefetch;

    public FrmOrderSearch()
    {
      InitializeComponent();
      foreach (var rb in groupBoxLLBLQueryType.Controls.OfType<RadioButton>())
      {
        var llblQueryType = (LLBLQueryType) rb.TabIndex;
        rb.Tag = llblQueryType;
        if (Settings.Default.LLBLQueryType == llblQueryType)
          rb.Checked = true;
        rb.Text = rb.Tag.ToString();
      }
      FrmEasyQuery.LoadFromLinqMetaData(query1);
      foreach (var subEntity in query1.Model.EntityRoot.SubEntities)
      {
        subEntity.UseInConditions = subEntity.Info.Values.Contains(typeof (SalesOrderHeaderEntity))
                                    || subEntity.Info.Values.Contains(typeof (CustomerEntity))
                                    || subEntity.Info.Values.Contains(typeof (CustomerAddressEntity))
                                    || subEntity.Info.Values.Contains(typeof (CustomerViewRelatedEntity))
                                    || subEntity.Info.Values.Contains(typeof (ContactEntity));
      }
      OnLLBLQueryTypeChange();
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(Settings.Default.FrmOrderSearchPredicate))
        query1.LoadFromString(Settings.Default.FrmOrderSearchPredicate);
      QPanel.Activate();
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      orderSearchCriteria1.OrderSearchCriteriaOnClosing();
    }

    private void FrmOrderSearch_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.FrmOrderSearchPredicate = query1.SaveToString();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _orderSearchCriteria = orderSearchCriteria1.GetCriteria();
      _maxNumberOfItemsToReturn = Convert.ToInt32(numericUpDownNumRows.Value);
      btnSearch.Enabled = false;
      _frmStatusBar = new FrmStatusBar();
      _frmStatusBar.Show();
      _frmStatusBar.CancelButtonClicked += FrmStatusBarCancelButtonClicked;
      searchWorker.RunWorkerAsync();
    }

    private void btnSearch_MouseUp(object sender, MouseEventArgs e)
    {
      _orderSearchCriteria = orderSearchCriteria1.GetCriteria();
      if (e.Button != MouseButtons.Right) return;
      switch (Settings.Default.LLBLQueryType)
      {
        case LLBLQueryType.Native:
          break;
        case LLBLQueryType.QuerySpec:
          break;
        case LLBLQueryType.Linq:
          MessageBox.Show(GetSalesOrderHeaderQuery(MetaSingletons.MetaData.SalesOrderHeader).Expression.ToString(), "Linq Expression");
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void QPanel_DoubleClick(object sender, EventArgs e)
    {
      MessageBox.Show(FrmEasyQuery.GetLinqExpression(query1).ToString(), "EasyQuery Linq Expression");
    }

    private void FrmStatusBarCancelButtonClicked(object sender, CancelEventArgs e)
    {
      searchWorker.CancelAsync();
      while (searchWorker.IsBusy)
        Application.DoEvents();
      btnSearch.Enabled = true;
    }

    private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      EditOrder(new SalesOrderHeaderEntity {CustomerID = 17018, ContactID = 4975, BillToAddressID = 14810, ShipToAddressID = 14810});
    }

    private void dgResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      EditOrder(dgResults.Rows[e.RowIndex].DataBoundItem as SalesOrderHeaderEntity);
    }

    private void EditOrder(SalesOrderHeaderEntity order)
    {
      ((FrmMain) MdiParent).LaunchChildForm(typeof (FrmOrderEdit), order);
    }

    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      switch (Settings.Default.LLBLQueryType)
      {
        case LLBLQueryType.Native:
          if (Settings.Default.FilterUsingCustomerViewRelated)
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionCustomerViewRelated(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              Settings.Default.Prefetch);
          else
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollection(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              Settings.Default.Prefetch);
          break;
        case LLBLQueryType.QuerySpec:
          if (Settings.Default.FilterUsingCustomerViewRelated)
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionQuerySpecCustomerViewRelated(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              Settings.Default.Prefetch);
          else
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionQuerySpec(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              Settings.Default.Prefetch);
          break;
        case LLBLQueryType.Linq:
          e.Result = GetSalesOrderHeaderQuery(MetaSingletons.MetaData.SalesOrderHeader).ToEntityCollection();
          break;
      }
      // Do not access the form's BackgroundWorker reference directly.
      // Instead, use the reference provided by the sender parameter.
      var bw = sender as BackgroundWorker;
      // If the operation was canceled by the user, 
      // set the DoWorkEventArgs.Cancel property to true.
      if (bw != null && bw.CancellationPending)
      {
        e.Cancel = true;
      }
    }

    private IQueryable<SalesOrderHeaderEntity> GetSalesOrderHeaderQuery(IQueryable<SalesOrderHeaderEntity> salesOrderHeaderQuery)
    {
      var predicate = PredicateBuilder.Null<SalesOrderHeaderEntity>();
      try
      {
        if (Settings.Default.UseEasyQuery)
          predicate = predicate.AddMethodCallExpression(FrmEasyQuery.GetLinqExpression(query1) as MethodCallExpression);
      }
      catch (Exception)
      {
      }
      if (Settings.Default.UsePredicate)
      {
        predicate = Settings.Default.FilterUsingCustomerViewRelated
          ? predicate.FilterByDateOrderIDOrderNumberCustomerNameAddressCustomerViewRelated(_orderSearchCriteria)
          : predicate.FilterByDateOrderIDOrderNumberCustomerNameAddress(_orderSearchCriteria);
      }
      else
      {
        salesOrderHeaderQuery = Settings.Default.FilterUsingCustomerViewRelated
          ? salesOrderHeaderQuery.FilterByDateOrderIDOrderNumberCustomerNameAddressCustomerViewRelated(_orderSearchCriteria)
          : salesOrderHeaderQuery.FilterByDateOrderIDOrderNumberCustomerNameAddress(_orderSearchCriteria);
        salesOrderHeaderQuery = salesOrderHeaderQuery.OrderBy(s => s.OrderDate);
      }
      if (predicate != null) salesOrderHeaderQuery = salesOrderHeaderQuery.Where(predicate);
      if (_maxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(_maxNumberOfItemsToReturn);
      if (Settings.Default.Prefetch)
        salesOrderHeaderQuery = salesOrderHeaderQuery.PrefetchCustomerViewRelated();
      return salesOrderHeaderQuery;
    }

    private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        Application.OnThreadException(e.Error);
      }
      if (_frmStatusBar != null)
      {
        _frmStatusBar.Close();
      }
      btnSearch.Enabled = true;
      if (e.Cancelled) return;
      if (Settings.Default.ShowCustomerViewRelatedFields)
      {
        dgResults.DataSource = salesOrderHeaderEntityBindingSource;
      }
      else
      {
        salesOrderHeaderEntityDataGridView.DataSource = salesOrderHeaderEntityBindingSource;
      }
      salesOrderHeaderEntityBindingSource.DataSource = e.Result;
    }

    private static void HideGrid(DataGridView dataGridView)
    {
      dataGridView.Visible = false;
      //  dataGridView.Height = 0;
      dataGridView.Dock = DockStyle.None;
      dataGridView.DataSource = null;
    }

    private void dgResults_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      GeneralHelper.TraceOut(e.Exception.Message);
    }

    private void radioButtonLLBLQueryType_CheckedChanged(object sender, EventArgs e)
    {
      var rb = sender as RadioButton;
      if (rb == null || !rb.Checked) return;
      if (rb.Tag is LLBLQueryType)
        Settings.Default.LLBLQueryType = (LLBLQueryType) rb.Tag;
      OnLLBLQueryTypeChange();
    }

    private void OnLLBLQueryTypeChange()
    {
      checkBoxUsePredicate.Enabled = Settings.Default.LLBLQueryType == LLBLQueryType.Linq;
      checkBoxUseEasyQuery.Enabled = checkBoxUsePredicate.Enabled;
      QPanel.Visible = checkBoxUsePredicate.Enabled;
    }

    private void checkBoxShowCustomerViewRelatedFields_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxShowCustomerViewRelatedFields.Checked)
      {
        HideGrid(salesOrderHeaderEntityDataGridView);
        dgResults.Visible = true;
        dgResults.Dock = DockStyle.Fill;
      }
      else
      {
        HideGrid(dgResults);
        salesOrderHeaderEntityDataGridView.Visible = true;
        salesOrderHeaderEntityDataGridView.Dock = DockStyle.Fill;
      }
    }

    private void checkBoxShowCustomerViewRelatedFields_Click(object sender, EventArgs e)
    {
      checkBoxShowCustomerViewRelatedFields.Checked = !checkBoxShowCustomerViewRelatedFields.Checked;
      checkBoxPrefetch.Checked = checkBoxShowCustomerViewRelatedFields.Checked;
    }

    private void checkBoxUseEasyQuery_CheckedChanged(object sender, EventArgs e)
    {
      QPanel.Enabled = checkBoxUseEasyQuery.Checked;
    }
  }
}