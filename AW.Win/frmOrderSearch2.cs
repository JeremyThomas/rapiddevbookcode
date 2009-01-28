using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.WinForms;
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
      var query = from soh in Validation.MetaData.SalesOrderHeader
              from sod in soh.SalesOrderDetail
              select soh;

      var x = (from soh in query
               select new { soh.SalesOrderId, soh.Customer.AccountNumber, soh.CreditCard.CardNumber }).ToList();


      query = from soh in Validation.MetaData.SalesOrderHeader select soh;

      var w = (from soh in query
               from sod in soh.SalesOrderDetail
               select new { soh.SalesOrderId, soh.Customer.AccountNumber, soh.CreditCard.CardNumber }).ToList();
    }

    /// <summary>
    /// Test fetching the CustomerId, SalesOrderId, AddressId of all customers which have addresses and may have orders
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14210
    /// </summary>
    public void LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder()
    {
      var customers = Validation.MetaData.Customer.AsQueryable();
      //var customersDerivedTable = customers.Select(customer => customer);
      var customersDerivedTable = from customer in customers select customer; //Using this to force a derived table causes a crash
      customersDerivedTable = customers.Where(c => c.CustomerId > 10); //To force a derived table

//      var q = AWHelper.MetaData.Customer.SelectMany(customer => customer.CustomerAddress, (customer, ca) => new {customer, ca}).GroupJoin(AWHelper.MetaData.SalesOrderHeader, @t => @t.customer.CustomerId, soh => soh.CustomerId, (@t, oc) => new {@t, oc}).SelectMany(@t => @t.oc.DefaultIfEmpty(), (@t, nullableSOH) => new {@t.@t.customer.CustomerId, @t.@t.ca.AddressId, nullableSOH.SalesOrderId});
      AWHelper.TraceOut("ExplicitJoin with Derived Table");
      var q = from customer in customersDerivedTable             
              join soh in (from s in Validation.MetaData.SalesOrderHeader where s.SalesPersonId > 22 select s) on customer.CustomerId equals soh.CustomerId into oc
              from nullableSOH in oc.DefaultIfEmpty()

              from ca in customer.CustomerAddress.DefaultIfEmpty()
              select new { customer.CustomerId, ca.AddressId, nullableSOH.SalesOrderId, customer.SalesTerritory.Name };
      if (MaxNumberOfItemsToReturn > 0)
        q = q.Take(MaxNumberOfItemsToReturn);
      salesOrderHeaderEntityBindingSource.DataSource = q;

      var q4 = from customer in customers
               from soh in customer.SalesOrderHeader.Where(soh => soh.SalesOrderId < 10).DefaultIfEmpty()
               select new {customer.CustomerId, soh.SalesOrderId};
      if (MaxNumberOfItemsToReturn > 0)
        q4 = q4.Take(MaxNumberOfItemsToReturn);
      var x = q4.ToList();
    }

    /// <summary>
    /// Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var query = Validation.MetaData.SalesOrderHeader.AsQueryable();

      if (fromDate != DateTime.MinValue)
        query = query.Where(q => q.OrderDate >= fromDate);
      if (toDate != DateTime.MinValue)
        query = query.Where(q => q.OrderDate <= toDate);
      if (firstName != "")
      {
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        query = query.Where(q => q.Customer.Individual.Contact.FirstName.Contains(firstName));
      }
      if (lastName != "")
        query = query.Where(q => q.Customer.Individual.Contact.LastName.Contains(lastName));

      if (cityName != "")
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.City == cityName)
                select soh;
      if (state != "")
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.StateProvince.Name == state)
                select soh;
      if (countries.Count > 0)
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => countries.Contains(ca.Address.StateProvince.CountryRegion.Name))
                select soh;
      if (zip != "")
        query = from soh in query
                where soh.Customer.CustomerAddress.Any(ca => ca.Address.PostalCode == zip)
                select soh;
      if (orderID != 0)
        query = query.Where(q => q.SalesOrderId == orderID);
      if (orderName != "")
        query = query.Where(q => q.SalesOrderNumber == orderName);

      query = query.OrderBy(s => s.OrderDate);

      if (MaxNumberOfItemsToReturn > 0)
        query = query.Take(MaxNumberOfItemsToReturn);
      results = query.ToList();
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
      var c = from Address in Validation.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              from Individual in EmployeeAddress.Employee.Contact.Individual
              select Address;

      c.ToList();  //ORMRelationException: Relation at index 1 doesn't contain an entity already added to the FROM clause. Bad alias?
      //http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15159

      var x = from CountryRegion in Validation.MetaData.CountryRegion
              from StateProvince in CountryRegion.StateProvince
              from Address in StateProvince.Address
              from EmployeeAddress in Address.EmployeeAddress
              from Individual in EmployeeAddress.Employee.Contact.Individual
              select CountryRegion;
      x.ToList();

      var f = from Address in Validation.MetaData.Address
              select new { Address.StateProvince.Name };

      f.ToList();
      
      //var d = from address in Validation.MetaData.Address
      //        join employeeAddress in Validation.MetaData.EmployeeAddress on address.AddressId equals employeeAddress.AddressId
      //        join individual in Validation.MetaData.Individual on employeeAddress.Employee.Contact.ContactId equals individual.ContactId
      //        //where employeeAddress.Employee.Contact != null
      //        select address;
      //d.ToList();

      var q = from Address in Validation.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              select EmployeeAddress.Employee.Contact;
      q.ToList();

      var g = from Address in Validation.MetaData.Address
              from EmployeeAddress in Address.EmployeeAddress
              select EmployeeAddress.Employee.Contact.Phone;

      g.ToList();

      var k = from employeeAddress in Validation.MetaData.EmployeeAddress
              select employeeAddress.Employee.Contact.Individual;

      k.ToList();//Application_ThreadException: SD.LLBLGen.Pro.ORMSupportClasses.ORMQueryConstructionException: A nested query relies on a correlation filter which refers to the field 'EmployeeId', however this field wasn't found in the projection of the entity.

      var h = from address in Validation.MetaData.Address
              from employeeAddress in address.EmployeeAddress
              select employeeAddress.Employee.Contact.Individual;

      h.ToList();  
    }

    private static void BarfonMultipleTableJoins()
    {
      var query = from soh in Validation.MetaData.SalesOrderHeader
                  from sod in soh.SalesOrderDetail
                  from sod2 in soh.SalesOrderDetail
                  where sod.SalesOrderId > 10 && sod2.SalesOrderId >1
                  select soh;

      var x = query.ToList();

      var w = (from soh in query
               from sod3 in soh.SalesOrderDetail
               select soh).ToList();
    }

    private void buttonBarf2_Click(object sender, EventArgs e)
    {
      BarfonMultipleTableJoins();
    }
  }
}