using System;
using System.ComponentModel;
using System.Windows.Forms;
using AW.Business;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class frmOrderSearch : Form
  {
    private frmStatusBar _frmStatusBar;
    private DateTime _fromDate;
    private DateTime _toDate;
    private string _firstName;
    private string _lastName;
    private int _orderID;
    private string _orderName;
    private string _cityName;
    private string _state;
    private string _country;
    private string _zip;
    private SalesOrderHeaderCollection _results;

    public frmOrderSearch()
    {
      InitializeComponent();
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
      var previousState = Settings.Default.State;
      var previousCountry = Settings.Default.Country;

      cbCountry.DataSource = CountryRegionEntity.GetCountryRegionCollection();
      cbCountry.DisplayMember = CountryRegionFieldIndex.Name.ToString();
      cbCountry.ValueMember = CountryRegionFieldIndex.CountryRegionCode.ToString();

      cbState.DataSource = StateProvinceEntity.GetStateProvinceCollection();
      cbState.DisplayMember = StateProvinceFieldIndex.Name.ToString();
      cbState.ValueMember = StateProvinceFieldIndex.StateProvinceId.ToString();

      dtpDateFrom.Checked = Settings.Default.FilterOnFromDate;
      dtpDateTo.Checked = Settings.Default.FilterOnToDate;

      cbState.Text = previousState;
      cbCountry.Text = previousCountry;

      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.OrderSearchSizeLocation);
    }

    private void frmOrderSearch_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.OrderSearchSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.FilterOnFromDate = dtpDateFrom.Checked;
      Settings.Default.FilterOnToDate = dtpDateTo.Checked;
    }

    //private void btnSearch_Click(object sender, EventArgs e)
    //{
    //    DateTime DateFrom = DateTime.MinValue;
    //    if (dtpDateFrom.Checked)
    //        DateFrom = dtpDateFrom.Value;
    //    DateTime DateTo = DateTime.MinValue;
    //    if (dtpDateTo.Checked)
    //        DateTo = dtpDateTo.Value;
    //    int OrderID = 0;
    //    string OrderNumber = "";
    //    if (tbOrderID.Text != "")
    //    {
    //        try
    //        {
    //            OrderID = Convert.ToInt32(tbOrderID.Text);
    //        }
    //        catch
    //        {
    //            OrderNumber = tbOrderID.Text;
    //        }
    //    }
    //    this.dgResults.DataSource =
    //        SalesOrderHeaderEntity.GetSalesOrderHeaderCollection(
    //        DateFrom,
    //        DateTo,
    //        tbFirstName.Text,
    //        tbLastName.Text,
    //        OrderID,
    //        OrderNumber,
    //        tbCity.Text,
    //        cbState.Text,
    //        cbCountry.Text,
    //        tbZip.Text);                
    //}

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _fromDate = DateTime.MinValue;
      if (dtpDateFrom.Checked)
        _fromDate = dtpDateFrom.Value;
      _toDate = DateTime.MinValue;
      if (dtpDateTo.Checked)
        _toDate = dtpDateTo.Value;
      _orderID = 0;
      _orderName = "";
      if (tbOrderID.Text != "")
        try
        {
          _orderID = Convert.ToInt32(tbOrderID.Text);
        }
        catch
        {
          _orderName = tbOrderID.Text;
        }
      _firstName = tbFirstName.Text;
      _lastName = tbLastName.Text;
      _cityName = tbCity.Text;
      _state = cbState.Text;
      _country = cbCountry.Text;
      _zip = tbZip.Text;
      btnSearch.Enabled = false;
      _frmStatusBar = new frmStatusBar();
      _frmStatusBar.Show();
      _frmStatusBar.CancelButtonClicked += _frmStatusBar_CancelButtonClicked;
      searchWorker.RunWorkerAsync();
    }

    private void _frmStatusBar_CancelButtonClicked(object sender, CancelEventArgs e)
    {
      searchWorker.CancelAsync();
      btnSearch.Enabled = true;
    }

    private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var Order = new SalesOrderHeaderEntity {CustomerId = 17018, ContactId = 4975, BillToAddressId = 14810, ShipToAddressId = 14810};
      var frm = new frmOrderEdit(Order);
      ((frmMain) MdiParent).LaunchChildForm(frm);
    }

    private void dgResults_CellContentDoubleClick(
      object sender, DataGridViewCellEventArgs e)
    {
      var Order = dgResults.Rows[e.RowIndex].DataBoundItem as SalesOrderHeaderEntity;
      var frm = new frmOrderEdit(Order);
      ((frmMain) MdiParent).LaunchChildForm(frm);
    }

    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      if (checkBoxUseLinq.Checked)
        _results = SalesOrderManager.GetSalesOrderHeaderCollectionWithLinq(
          _fromDate,
          _toDate,
          _firstName,
          _lastName,
          _orderID,
          _orderName,
          _cityName,
          _state,
          _country,
          _zip,
          Convert.ToInt32(numericUpDownNumRows.Value));
      else
        _results = SalesOrderManager.GetSalesOrderHeaderCollection(
          _fromDate,
          _toDate,
          _firstName,
          _lastName,
          _orderID,
          _orderName,
          _cityName,
          _state,
          _country,
          _zip,
          Convert.ToInt32(numericUpDownNumRows.Value));
    }

    private void searchWorker_RunWorkerCompleted(object sender,
                                                 RunWorkerCompletedEventArgs e)
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
      dgResults.DataSource = _results;
    }

  }
}