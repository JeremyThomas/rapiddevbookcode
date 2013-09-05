using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data.EntityClasses;
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
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      orderSearchCriteria1.OrderSearchCriteriaOnClosing();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _orderSearchCriteria = orderSearchCriteria1.GetCriteria();
      _maxNumberOfItemsToReturn = Convert.ToInt32(numericUpDownNumRows.Value);
      _prefetch = checkBoxPrefetch.Checked;
      btnSearch.Enabled = false;
      _frmStatusBar = new FrmStatusBar();
      _frmStatusBar.Show();
      _frmStatusBar.CancelButtonClicked += FrmStatusBarCancelButtonClicked;
      searchWorker.RunWorkerAsync();
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
              _prefetch);
          else
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollection(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              _prefetch);
          break;
        case LLBLQueryType.QuerySpec:
          if (Settings.Default.FilterUsingCustomerViewRelated)
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionQuerySpecCustomerViewRelated(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              _prefetch);
          else
          e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionQuerySpec(
            _orderSearchCriteria,
            _maxNumberOfItemsToReturn,
            _prefetch);
          break;
        case LLBLQueryType.Linq:
          if (Settings.Default.FilterUsingCustomerViewRelated)
            e.Result = SalesOrderQueries.DoSalesOrderHeaderLinqQueryCustomerViewRelated(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              _prefetch
              ).ToEntityCollection();
          else
            e.Result = SalesOrderQueries.GetSalesOrderHeaderCollectionWithLinq(
              _orderSearchCriteria,
              _maxNumberOfItemsToReturn,
              _prefetch
              );
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
      if (!e.Cancelled)
        dgResults.DataSource = e.Result;
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
    }
  }
}