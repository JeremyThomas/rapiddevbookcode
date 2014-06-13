using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Helper;
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
      backgroundWorkerLookUps.RunWorkerAsync();
    }

    public void OrderSearchCriteriaOnClosing()
    {
      Settings.Default.FilterOnFromDate = dtpDateFrom.Checked;
      Settings.Default.FilterOnToDate = dtpDateTo.Checked;
      if (string.IsNullOrWhiteSpace(comboBoxStatus.Text))
        Settings.Default.OrderStatus = null;
      else
        Settings.Default.OrderStatus = comboBoxStatus.SelectedItem as OrderStatus?;
      Settings.Default.IsOnline = checkBoxOnline.CheckState;

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
      if (string.IsNullOrWhiteSpace(comboBoxStatus.Text))
        orderSearchCriteria.OrderStatus = null;
      else
        orderSearchCriteria.OrderStatus = comboBoxStatus.SelectedItem as OrderStatus?;
      if (checkBoxOnline.CheckState == CheckState.Indeterminate)
        orderSearchCriteria.IsOnlineOrder = null;
      else
        orderSearchCriteria.IsOnlineOrder = checkBoxOnline.Checked;
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
      checkBoxOnline.CheckState = CheckState.Indeterminate;
    }

    private void backgroundWorkerLookUps_DoWork(object sender, DoWorkEventArgs e)
    {
      e.Result = new Tuple<CountryRegionCollection, StateProvinceCollection>(LookUpQueries.GetCountryRegionCollection(), LookUpQueries.GetStateProvinceCollection());
    }

    private void backgroundWorkerLookUps_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      var lu = e.Result as Tuple<CountryRegionCollection, StateProvinceCollection>;

      var previousState = Settings.Default.State;
      listBoxCountry.DisplayMember = CountryRegionFieldIndex.Name.ToString();
      listBoxCountry.ValueMember = CountryRegionFieldIndex.CountryRegionCode.ToString();
      if (lu != null)
      {
        listBoxCountry.DataSource = lu.Item1;
        cbState.DataSource = lu.Item2;
      }
      cbState.DisplayMember = StateProvinceFieldIndex.Name.ToString();
      cbState.ValueMember = StateProvinceFieldIndex.StateProvinceID.ToString();

      dtpDateFrom.Checked = Settings.Default.FilterOnFromDate;
      dtpDateTo.Checked = Settings.Default.FilterOnToDate;

      cbState.Text = previousState;

      comboBoxStatus.DataSource = GeneralHelper.EnumAsEnumerable<OrderStatus>();

      buttonClearCountries_Click(sender, e);
      if (Settings.Default.Countries != null && listBoxCountry.Items.Count > 0)
        foreach (var selectedRow in Settings.Default.Countries)
          listBoxCountry.SelectedIndices.Add(Convert.ToInt32(selectedRow));

      comboBoxStatus.SelectedItem = Settings.Default.OrderStatus;
      checkBoxOnline.CheckState = Settings.Default.IsOnline;
    }
  }
}