using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Win.Properties;
using SD.LLBLGen.Pro.LinqSupportClasses;

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
    private string country;
    private string zip;
    private SalesOrderHeaderCollection results;

    public frmOrderSearch2()
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
      country = cbCountry.Text;
      zip = tbZip.Text;
      if (sender == buttonBarf)
      {
        Barf();
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

    private void dgResults_CellContentDoubleClick(
      object sender, DataGridViewCellEventArgs e)
    {
      var Order = dgResults.Rows[e.RowIndex].DataBoundItem as SalesOrderHeaderEntity;
      var frm = new frmOrderEdit(Order);
      ((frmMain) MdiParent).LaunchChildForm(frm);
    }

    private void Barf()
    {
      var query = from soh in AWHelper.MetaData.SalesOrderHeader
                      from customerAddress in soh.Customer.CustomerAddress
                      select soh;

      var x = query.ToList();
      //dgResults.DataSource = ((ILLBLGenProQuery)predicate).Execute<SalesOrderHeaderCollection>();
    }

    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var predicate = from soh in AWHelper.MetaData.SalesOrderHeader select soh;

      if (fromDate != DateTime.MinValue)
      {
        predicate = predicate.Where(soh => soh.OrderDate >= fromDate);
      }
      if (toDate != DateTime.MinValue)
      {
        predicate = predicate.Where(soh => soh.OrderDate <= toDate);
      }
      if (firstName != "")
      {
        //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.FirstName.Contains(firstName));
      }
      if (lastName != "")
      {
        predicate = predicate.Where(soh => soh.Customer.Individual.Contact.LastName.Contains(lastName));
      }
      if (cityName != "")
      {
        predicate = from soh in predicate
                    from customerAddress in soh.Customer.CustomerAddress
                    where customerAddress.Address.City.Contains(cityName)
                    select soh;
      }
      if (state != "")
      {
        predicate = from soh in predicate
                    from customerAddress in soh.Customer.CustomerAddress
                    where customerAddress.Address.StateProvince.Name == state
                    select soh;
        //predicate = predicate.Where(soh => soh.CustomerState == state);
      }
      if (country != "")
      {
        predicate = from soh in predicate
                    from customerAddress in soh.Customer.CustomerAddress
                    where customerAddress.Address.StateProvince.CountryRegion.Name == country
                    select soh;
        //predicate = predicate.Where(soh => soh.CustomerCountry == country);
      }
      if (zip != "")
      {
        predicate = from soh in predicate
                    from customerAddress in soh.Customer.CustomerAddress
                    where customerAddress.Address.PostalCode == zip
                    select soh;
        //predicate = predicate.Where(soh => soh.CustomerZip == zip);
      }
      if (orderID != 0)
      {
        predicate = predicate.Where(soh => soh.SalesOrderId == orderID);
      }
      if (orderName != "")
      {
        predicate = predicate.Where(soh => soh.SalesOrderNumber == orderName);
      }

      predicate = predicate.OrderBy(s => s.OrderDate);

      if (MaxNumberOfItemsToReturn > 0)
        predicate = predicate.Take(MaxNumberOfItemsToReturn);
      results = ((ILLBLGenProQuery)predicate).Execute<SalesOrderHeaderCollection>();
    }

    public int MaxNumberOfItemsToReturn
    {
      get { return Convert.ToInt32(numericUpDownNumRows.Value); }
      set { numericUpDownNumRows.Value = value; }
    }

    private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        Application.OnThreadException(e.Error);
      }
      if (frmStatusBar != null)
      {
        frmStatusBar.Close();
      }
      btnSearch.Enabled = true;
      dgResults.DataSource = results;
    }

  }
}