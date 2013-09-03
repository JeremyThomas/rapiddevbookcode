using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class OrderSearchCriteria : UserControl
  {
    public OrderSearchCriteria()
    {
      InitializeComponent();
    }

    private void OrderSearchCriteria_Load(object sender, EventArgs e)
    {
      if (DesignMode)
        return;
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
    }

    public void OrderSearchCriteriaOnClosing()
    {
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

    private void buttonClearCountries_Click(object sender, EventArgs e)
    {
      listBoxCountry.SelectedItems.Clear();
    }

    public Data.ViewModels.OrderSearchCriteria GetCriteria()
    {
      var orderSearchCriteria = new Data.ViewModels.OrderSearchCriteria();
      if (dtpDateFrom.Checked)
        orderSearchCriteria.FromDate = dtpDateFrom.Value;
      if (dtpDateTo.Checked)
        orderSearchCriteria.ToDate = dtpDateTo.Value;
      if (tbOrderID.Text != "")
        try
        {
          orderSearchCriteria.OrderID = Convert.ToInt32(tbOrderID.Text);
        }
        catch
        {
          orderSearchCriteria.OrderNumber = tbOrderID.Text;
        }
      orderSearchCriteria.FirstName = tbFirstName.Text;
      orderSearchCriteria.LastName = tbLastName.Text;
      orderSearchCriteria.CityName = tbCity.Text;
      orderSearchCriteria.StateName = cbState.Text;
      orderSearchCriteria.Countries = from country in listBoxCountry.SelectedItems.OfType<CountryRegionEntity>() select country.Name;
      orderSearchCriteria.Zip = tbZip.Text;
      return orderSearchCriteria;
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
      dtpDateFrom.Checked = false;
      dtpDateTo.Checked = false;

      //tableLayoutPanel2.c
      var q = from ctl in tableLayoutPanelOrderSearchCriteria.Controls.OfType<TextBox>() select ctl;
      foreach (var textbox in q)
        textbox.Text = String.Empty;

      var x = from ctl in tableLayoutPanelOrderSearchCriteria.Controls.OfType<ComboBox>() select ctl;
      foreach (var comboBox in x)
        comboBox.Text = String.Empty;

      buttonClearCountries_Click(sender, e);
    }
  }
}