using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Business;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers
{
  public partial class frmOrderSearch2 : Form
  {
    private frmStatusBar frmStatusBar;
    private DateTime fromDate;
    private DateTime toDate;
    private string firstName;
    private string lastName;
    private int orderID;
    private string orderName;
    private string cityName;
    private string state;
    private List<string> countries;
    private string zip;
    private object results;

    public frmOrderSearch2()
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
      fromDate = DateTime.MinValue;
      if (dtpDateFrom.Checked)
        fromDate = dtpDateFrom.Value;
      toDate = DateTime.MinValue;
      if (dtpDateTo.Checked)
        toDate = dtpDateTo.Value;
      orderID = 0;
      orderName = "";
      if (tbOrderID.Text != "")
        try
        {
          orderID = Convert.ToInt32(tbOrderID.Text);
        }
        catch
        {
          orderName = tbOrderID.Text;
        }
      firstName = tbFirstName.Text;
      lastName = tbLastName.Text;
      cityName = tbCity.Text;
      state = cbState.Text;
      countries = (from country in listBoxCountry.SelectedItems.OfType<CountryRegionEntity>() select country.Name).ToList();
      zip = tbZip.Text;
      if (sender == buttonBarf)
      {
        Tests.Barf();
      }
      else if (sender == buttonBarf2)
      {
        salesOrderHeaderEntityBindingSource.DataSource = Tests.LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder(MaxNumberOfItemsToReturn);
      }
      else
      {
        btnSearch.Enabled = false;
        frmStatusBar = new frmStatusBar();
        frmStatusBar.Show();
        frmStatusBar.CancelButtonClicked += frmStatusBar_CancelButtonClicked;
        searchWorker.RunWorkerAsync();
      }
    }

    private void frmStatusBar_CancelButtonClicked(object sender, CancelEventArgs e)
    {
      searchWorker.CancelAsync();
      btnSearch.Enabled = true;
    }

    private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var Order = new SalesOrderHeaderEntity {CustomerID = 17018, ContactID = 4975, BillToAddressID = 14810, ShipToAddressID = 14810};
      var frm = new frmOrderEdit(Order);
      ((frmMain) MdiParent).LaunchChildForm(frm);
    }

    private void dgResults_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var Order = salesOrderHeaderEntityDataGridView.Rows[e.RowIndex].DataBoundItem as SalesOrderHeaderEntity;
      var frm = new frmOrderEdit(Order);
      ((frmMain) MdiParent).LaunchChildForm(frm);
    }

    /// <summary>
    /// Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      results = SalesOrderManager.DoSalesOrderHeaderLinqQuery(fromDate,
                                                                         toDate,
                                                                         firstName,
                                                                         lastName,
                                                                         orderID,
                                                                         orderName,
                                                                         cityName,
                                                                         state,
                                                                         countries,
                                                                         zip, MaxNumberOfItemsToReturn).ToList();

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
      if (frmStatusBar != null)
        frmStatusBar.Close();
      btnSearch.Enabled = true;
      salesOrderHeaderEntityBindingSource.DataSource = results;
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

    private void buttonBarf_Click(object sender, EventArgs e)
    {
      Tests.Barf1();
    }

    private void buttonBarf2_Click(object sender, EventArgs e)
    {
      Tests.BarfonMultipleTableJoins();
    }
  }
}