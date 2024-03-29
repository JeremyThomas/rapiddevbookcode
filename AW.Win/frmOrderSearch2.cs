using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public partial class FrmOrderSearch2 : Form
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
    private IEnumerable<string> _countries;
    private string _zip;
    private object _results;

    public FrmOrderSearch2()
    {
      InitializeComponent();
    }

    private void frmOrderSearch_Load(object sender, EventArgs e)
    {
      var previousState = Settings.Default.State;

      listBoxCountry.DataSource = LookUpQueries.GetCountryRegionCollection();
      listBoxCountry.DisplayMember = CountryRegionFieldIndex.Name.ToString();
      listBoxCountry.ValueMember = CountryRegionFieldIndex.CountryRegionCode.ToString();

      cbState.DataSource = LookUpQueries.GetStateProvinceCollection();
      cbState.DisplayMember = StateProvinceFieldIndex.Name.ToString();
      cbState.ValueMember = StateProvinceFieldIndex.StateProvinceID.ToString();

      dtpDateFrom.Checked = Settings.Default.FilterOnFromDate;
      dtpDateTo.Checked = Settings.Default.FilterOnToDate;

      cbState.Text = previousState;

      buttonClearCountries_Click(sender, e);
      if (Settings.Default.Countries != null && listBoxCountry.Items.Count > 0)
        foreach (var selectedRow in Settings.Default.Countries)
          listBoxCountry.SelectedIndices.Add(Convert.ToInt32(selectedRow));

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

      if (listBoxCountry.Items.Count > 0)
      {
        if (Settings.Default.Countries == null)
          Settings.Default.Countries = new StringCollection();
        else
          Settings.Default.Countries.Clear();
        foreach (var selectedRow in listBoxCountry.SelectedIndices)
          Settings.Default.Countries.Add(selectedRow.ToString());
      }
    }

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
      _countries = from country in listBoxCountry.SelectedItems.OfType<CountryRegionEntity>() select country.Name;
      _zip = tbZip.Text;

      btnSearch.Enabled = false;
      _frmStatusBar = new frmStatusBar();
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
    /// Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      _results = SalesOrderQueries.DoSalesOrderHeaderLinqQuery(_fromDate,
                                                               _toDate,
                                                               _firstName,
                                                               _lastName,
                                                               _orderID,
                                                               _orderName,
                                                               _cityName,
                                                               _state,
                                                               _countries,
                                                               _zip, MaxNumberOfItemsToReturn).ToEntityCollection();
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

    private void buttonClear_Click(object sender, EventArgs e)
    {
      dtpDateFrom.Checked = false;
      dtpDateFrom.Checked = false;

      //tableLayoutPanel2.c
      var q = from ctl in tableLayoutPanel2.Controls.OfType<TextBox>() select ctl;
      foreach (var textbox in q)
        textbox.Text = String.Empty;

      var x = from ctl in tableLayoutPanel2.Controls.OfType<ComboBox>() select ctl;
      foreach (var comboBox in x)
        comboBox.Text = String.Empty;

      buttonClearCountries_Click(sender, e);
    }

    private void buttonClearCountries_Click(object sender, EventArgs e)
    {
      listBoxCountry.SelectedItems.Clear();
    }

  }
}