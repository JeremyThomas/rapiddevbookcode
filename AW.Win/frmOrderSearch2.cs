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
        BarfLambda();
      }
      else if (sender == buttonBarf3)
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
        query = from soh in query
                from customerAddress in soh.Customer.CustomerAddress
                where customerAddress.Address.StateProvince.Name == state
                select soh;

      query = from soh in query select soh;
      var x = query.ToList();
      //salesOrderHeaderEntityBindingSource.DataSource = query;
      //salesOrderHeaderEntityBindingSource.DataSource = ((ILLBLGenProQuery)query).Execute<SalesOrderHeaderCollection>();
    }

    /// <summary>
    /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    private static void BarfLambda()
    {
      var q1 = AWHelper.MetaData.SalesOrderHeader
        .Where(soh => (soh.Customer.Individual.Contact.LastName == "LastName"));

      var f1 = true;
      if (f1)

        q1 = q1.SelectMany(
          soh => soh.Customer.CustomerAddress,
          (soh, customerAddress) =>
          new
            {
              soh, customerAddress
            }
          ).Where(temp0 => (temp0.customerAddress.Address.StateProvince.Name == "State"))
          .Select(temp0 => temp0.soh);

      if (f1)
        q1 = q1
          .SelectMany(
          soh => soh.Customer.CustomerAddress,
          (soh, customerAddress) =>
          new
            {
              soh, customerAddress
            }
          )
          .Where(temp1 => (temp1.customerAddress.Address.City == "city")).Select(temp0 => temp0.soh);
      var x = q1.ToList();
      //salesOrderHeaderEntityBindingSource.DataSource = query;
      //salesOrderHeaderEntityBindingSource.DataSource = ((ILLBLGenProQuery)query).Execute<SalesOrderHeaderCollection>();
    }

    public void LeftJoinUsingDefaultIfEmptyToFetchCustomersWithoutAnOrder()
    {
      var q = from c in AWHelper.MetaData.Customer
              join o in AWHelper.MetaData.SalesOrderHeader on c.CustomerId equals o.CustomerId into oc
              from x in oc.DefaultIfEmpty()
              where x.SalesOrderId == null
              select c;
      if (MaxNumberOfItemsToReturn > 0)
        q = q.Take(MaxNumberOfItemsToReturn);
      salesOrderHeaderEntityBindingSource.DataSource = q;

      var q1 = from customer in AWHelper.MetaData.Customer
               from soh in customer.SalesOrderHeader.DefaultIfEmpty()
               where soh.SalesOrderId == null
               select new {customer};
      if (MaxNumberOfItemsToReturn > 0)
        q1 = q1.Take(MaxNumberOfItemsToReturn);
      var z = q1.ToList();
    }

    private void Barf3()
    {
      //var q2 = from customer in AWHelper.MetaData.Customer
      //         join ca in AWHelper.MetaData.CustomerAddress on customer.CustomerId equals ca.CustomerId into customerAddress
      //         from x in customerAddress.DefaultIfEmpty()
      //         //where customerAddress.AddressTypeID == null
      //         select new { customer, x };
      //if (MaxNumberOfItemsToReturn > 0)
      //  q2 = q2.Take(MaxNumberOfItemsToReturn);
      //var w = q2.ToList();

      var query = AWHelper.MetaData.SalesOrderHeader.AsQueryable();
      //var query = from soh in AWHelper.MetaData.SalesOrderHeader select soh;
      query = query.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains("Brad"));

      query = from soh in query
              //    where soh.Customer.Individual.Contact.LastName == "United Kingdom"
              select soh;

      //query = from soh in query
      //        from customerAddress in soh.Customer.CustomerAddress
      //        where customerAddress.Address.StateProvince.CountryRegion.Name == "country"
      //        select soh;

      if (MaxNumberOfItemsToReturn > 0)
        query = query.Take(MaxNumberOfItemsToReturn);

      var query2 = from s in query
                   select new
                            {
                              s.SalesOrderId,
                              s.RevisionNumber,
                              s.OrderDate,
                              s.DueDate,
                              s.ShipDate,
                              s.Status,
                              s.OnlineOrderFlag,
                              s.SalesOrderNumber,
                              s.PurchaseOrderNumber,
                              s.AccountNumber,
                              s.CustomerId,
                              s.ContactId,
                              s.SalesPersonId,
                              s.TerritoryId,
                              s.BillToAddressId,
                              s.ShipToAddressId,
                              s.ShipMethodId,
                              s.CreditCardId,
                              s.CreditCardApprovalCode,
                              s.CurrencyRateId,
                              s.SubTotal,
                              s.TaxAmt,
                              s.Freight,
                              s.TotalDue,
                              s.Comment,
                              s.Rowguid,
                              s.ModifiedDate
                            };
      //  var x = query.ToList();
      salesOrderHeaderEntityBindingSource.DataSource = query2;
      //salesOrderHeaderEntityBindingSource.DataSource = ((ILLBLGenProQuery)query).Execute<SalesOrderHeaderCollection>();
    }

    /// <summary>
    /// Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      //var query = from soh in AWHelper.MetaData.SalesOrderHeader select soh;
      var query = from soh in AWHelper.MetaData.SalesOrderHeader
                  from customerAddress in soh.Customer.CustomerAddress
                  select new {soh, customerAddress};

      if (fromDate != DateTime.MinValue)
      {
        query = query.Where(q => q.soh.OrderDate >= fromDate);
      }
      if (toDate != DateTime.MinValue)
      {
        query = query.Where(q => q.soh.OrderDate <= toDate);
      }
      if (firstName != "")
      {
        // query = query.Where(q => System.Data.Linq.SqlClient.SqlMethods.Like(q.soh.Customer.Individual.Contact.FirstName, firstName));
        query = query.Where(q => q.soh.Customer.Individual.Contact.FirstName.Contains(firstName));
      }
      if (lastName != "")
      {
        query = query.Where(q => q.soh.Customer.Individual.Contact.LastName.Contains(lastName));
      }
      if (cityName != "")
      {
        query = query.Where(q => q.customerAddress.Address.City.Contains(cityName));
        //query = from soh in query
        //            from customerAddress in soh.Customer.CustomerAddress
        //            where customerAddress
        //            select soh;
      }
      if (state != "")
      {
        query = query.Where(q => q.customerAddress.Address.StateProvince.Name == state);
        //query = from soh in query
        //            from customerAddress in soh.Customer.CustomerAddress
        //            where customerAddress.Address.StateProvince.Name == state
        //            select soh;
        //predicate = predicate.Where(soh => soh.CustomerState == state);
      }
      if (countries.Count > 0)
      {
        query = query.Where(q => countries.Contains(q.customerAddress.Address.StateProvince.CountryRegion.Name));
        //query = from soh in query
        //            from customerAddress in soh.Customer.CustomerAddress
        //            where customerAddress.Address.StateProvince.CountryRegion.Name == country
        //            select soh;
        //predicate = predicate.Where(soh => soh.CustomerCountry == country);
      }
      if (zip != "")
      {
        query = query.Where(q => q.customerAddress.Address.PostalCode == zip);
        //query = from soh in query
        //            from customerAddress in soh.Customer.CustomerAddress
        //            where customerAddress.Address.PostalCode == zip
        //            select soh;
        //predicate = predicate.Where(soh => soh.CustomerZip == zip);
      }
      if (orderID != 0)
      {
        query = query.Where(q => q.soh.SalesOrderId == orderID);
      }
      if (orderName != "")
      {
        query = query.Where(q => q.soh.SalesOrderNumber == orderName);
      }
      var salesOrderHeader = from q in query select q.soh;
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
  }
}