using System;
using System.ComponentModel;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Data.ViewModels;
using AW.Helper;
using AW.Win.Properties;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public partial class FrmOrderSearch : FrmPersistantLocation
  {
    private FrmStatusBar _frmStatusBar;
    private OrderSearchCriteria _orderSearchCriteria;
    private int _maxNumberOfItemsToReturn;
    private bool _prefetch;

    public FrmOrderSearch()
    {
      InitializeComponent();
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
      var previousState = Settings.Default.State;
      var previousCountry = Settings.Default.Country;

      cbCountry.DataSource = LookUpQueries.GetCountryRegionCollection();
      cbCountry.DisplayMember = CountryRegionFieldIndex.Name.ToString();
      cbCountry.ValueMember = CountryRegionFieldIndex.CountryRegionCode.ToString();

      cbState.DataSource = LookUpQueries.GetStateProvinceCollection();
      cbState.DisplayMember = StateProvinceFieldIndex.Name.ToString();
      cbState.ValueMember = StateProvinceFieldIndex.StateProvinceID.ToString();

      dtpDateFrom.Checked = Settings.Default.FilterOnFromDate;
      dtpDateTo.Checked = Settings.Default.FilterOnToDate;

      cbState.Text = previousState;
      cbCountry.Text = previousCountry;
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.FilterOnFromDate = dtpDateFrom.Checked;
      Settings.Default.FilterOnToDate = dtpDateTo.Checked;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _orderSearchCriteria = new OrderSearchCriteria();
      if (dtpDateFrom.Checked)
        _orderSearchCriteria.FromDate = dtpDateFrom.Value;
      if (dtpDateTo.Checked)
        _orderSearchCriteria.ToDate = dtpDateTo.Value;
      if (tbOrderID.Text != "")
        try
        {
          _orderSearchCriteria.OrderID = Convert.ToInt32(tbOrderID.Text);
        }
        catch
        {
          _orderSearchCriteria.OrderNumber = tbOrderID.Text;
        }
      _orderSearchCriteria.FirstName = tbFirstName.Text;
      _orderSearchCriteria.LastName = tbLastName.Text;
      _orderSearchCriteria.CityName = tbCity.Text;
      _orderSearchCriteria.StateName = cbState.Text;
      _orderSearchCriteria.Zip = tbZip.Text;
      _orderSearchCriteria.CountryName = cbCountry.Text;
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
      e.Result = checkBoxUseLinq.Checked
        ? SalesOrderQueries.GetSalesOrderHeaderCollectionWithLinq(
          _orderSearchCriteria,
          _maxNumberOfItemsToReturn,
          _prefetch
          )
        : SalesOrderQueries.GetSalesOrderHeaderCollection(
          _orderSearchCriteria,
          _maxNumberOfItemsToReturn,
          _prefetch);
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
  }
}