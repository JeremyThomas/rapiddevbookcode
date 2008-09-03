using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Win.Properties;

namespace AW.Win
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

      listBoxCountry.DataSource = CountryRegionEntity.GetCountryRegionCollection();
      listBoxCountry.DisplayMember = CountryRegionFieldIndex.Name.ToString();
      listBoxCountry.ValueMember = CountryRegionFieldIndex.CountryRegionCode.ToString();

      cbState.DataSource = StateProvinceEntity.GetStateProvinceCollection();
      cbState.DisplayMember = StateProvinceFieldIndex.Name.ToString();
      cbState.ValueMember = StateProvinceFieldIndex.StateProvinceId.ToString();

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
        Barf();
      }
      else if (sender == buttonBarf2)
      {
        LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder();
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
      var Order = new SalesOrderHeaderEntity {CustomerId = 17018, ContactId = 4975, BillToAddressId = 14810, ShipToAddressId = 14810};
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
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    private void Barf()
    {
      var query = AWHelper.MetaData.SalesOrderHeader.AsQueryable();

      if (firstName != "")
        query = query.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains(firstName));

      if (state != "")
        // query = query.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.Name == state));
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.Name == state)
                select soh;

      if (cityName != "")
      {
        //query = query.Where(soh => soh.Customer.CustomerAddress.Any(ca => ca.Address.City == cityName));
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.City == cityName)
                select soh;
      }

      if (countries.Count > 0)
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                select soh;

      if (MaxNumberOfItemsToReturn > 0)
        query = query.Take(MaxNumberOfItemsToReturn);
      salesOrderHeaderEntityBindingSource.DataSource = query;
    }

    /// <summary>
    /// Test which uses DefaultIfEmpty and 'into' (so GroupJoin + SelectMany + DefaultIfEmpty) to fetch all customers which have no orders
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14210
    /// </summary>
    public void LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder()
    {
      //var q = AWHelper.MetaData.Customer.GroupJoin(AWHelper.MetaData.SalesOrderHeader, c => c.CustomerId, o => o.CustomerId, (c, oc) => new {c, oc}).SelectMany(@t => @t.oc.DefaultIfEmpty(), (@t, x) => new {@t, x}).Where(@t => @t.x.SalesOrderId == null).Select(@t => @t.@t.c);
      var q = from c in AWHelper.MetaData.Customer
              join o in AWHelper.MetaData.SalesOrderHeader on c.CustomerId equals o.CustomerId into oc
              from x in oc.DefaultIfEmpty()
              where x.SalesOrderId == null
              select c;
      if (MaxNumberOfItemsToReturn > 0)
        q = q.Take(MaxNumberOfItemsToReturn);
      salesOrderHeaderEntityBindingSource.DataSource = q;

      //var q1 = AWHelper.MetaData.Customer.SelectMany(customer => customer.SalesOrderHeader.DefaultIfEmpty(), (customer, soh) => new {customer, soh}).Where(@t => @t.soh.SalesOrderId == null).Select(@t => @t.customer);
      var q1 = from customer in AWHelper.MetaData.Customer
               from soh in customer.SalesOrderHeader.DefaultIfEmpty()
               where soh.SalesOrderId == null
               select customer;
      if (MaxNumberOfItemsToReturn > 0)
        q1 = q1.Take(MaxNumberOfItemsToReturn);
      var z = q1.ToList();

      //Now fetch all customers which have no orders but have Addresses
      //var q2 = AWHelper.MetaData.Customer.SelectMany(customer => customer.CustomerAddress, (customer, ca) => new {customer, ca}).SelectMany(@t => @t.customer.SalesOrderHeader.DefaultIfEmpty(), (@t, soh) => new {@t, soh}).Where(@t => @t.soh.SalesOrderId == null).Where(@t => @t.@t.ca.AddressId != null).Select(@t => @t.@t.customer);
      var q2 = from customer in AWHelper.MetaData.Customer
               from ca in customer.CustomerAddress
               from soh in customer.SalesOrderHeader.DefaultIfEmpty()
               where soh.SalesOrderId == null
               where ca.AddressId != null
               select customer;
      if (MaxNumberOfItemsToReturn > 0)
        q2 = q2.Take(MaxNumberOfItemsToReturn);
      var w = q2.ToList();
    }

    /// <summary>
    /// Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var query = from soh in AWHelper.MetaData.SalesOrderHeader select soh;

      if (fromDate != DateTime.MinValue)
      {
        query = query.Where(q => q.OrderDate >= fromDate);
      }
      if (toDate != DateTime.MinValue)
      {
        query = query.Where(q => q.OrderDate <= toDate);
      }
      if (firstName != "")
      {
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        query = query.Where(q => q.Customer.Individual.Contact.FirstName.Contains(firstName));
      }
      if (lastName != "")
      {
        query = query.Where(q => q.Customer.Individual.Contact.LastName.Contains(lastName));
      }

      if (cityName != "")
      {
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.City == cityName)
                select soh;
      }
      if (state != "")
      {
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.Name == state)
                select soh;
      }
      if (countries.Count > 0)
      {
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                select soh;
      }
      if (zip != "")
      {
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.PostalCode == zip)
                select soh;
      }
      if (orderID != 0)
      {
        query = query.Where(q => q.SalesOrderId == orderID);
      }
      if (orderName != "")
      {
        query = query.Where(q => q.SalesOrderNumber == orderName);
      }
      var salesOrderHeader = query;
      salesOrderHeader = salesOrderHeader.OrderBy(s => s.OrderDate);

      if (MaxNumberOfItemsToReturn > 0)
        salesOrderHeader = salesOrderHeader.Take(MaxNumberOfItemsToReturn);
      results = salesOrderHeader;
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
  }
}