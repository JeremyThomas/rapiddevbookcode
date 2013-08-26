using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Filters;
using AW.Data.Linq;
using AW.Data.Queries;
using AW.Data.ViewModels;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using Korzh.EasyQuery;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Win
{
  public partial class FrmOrderSearch2 : FrmPersistantLocation
  {
    private FrmStatusBar _frmStatusBar;
    private OrderSearchCriteria _orderSearchCriteria;
    private object _results;

    public FrmOrderSearch2()
    {
      InitializeComponent();
      query1.Model.LoadFromCollectionContainer(typeof (LinqMetaData), typeof (DataSource<>));
      foreach (var subEntity in query1.Model.EntityRoot.SubEntities)
      {
        subEntity.UseInConditions = subEntity.Info.Values.Contains(typeof (SalesOrderHeaderEntity));
        if (subEntity.UseInConditions)
          foreach (var entityAttr in subEntity.Attributes)
          {
            if (entityAttr.DataType == DataType.Bool && entityAttr.Caption.StartsWith("AlreadyFetched")
                || entityAttr.Caption.StartsWith("AlwaysFetch")
                || entityAttr.Caption.EndsWith("ReturnsNewIfNotFound")
                || entityAttr.Caption == "IsNew" || entityAttr.Caption == "IsDirty")
              entityAttr.UseInConditions = false;
          }
      }
      QPanel.Activate();
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

      if (!String.IsNullOrWhiteSpace(Settings.Default.FrmOrderSearchPredicate))
        query1.LoadFromString(Settings.Default.FrmOrderSearchPredicate);
    }

    private void frmOrderSearch_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.FrmOrderSearchPredicate = query1.SaveToString();
    }

    private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
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

    private void btnSearch_Click(object sender, EventArgs e)
    {
      _orderSearchCriteria = new OrderSearchCriteria ();
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
      _orderSearchCriteria.Countries = from country in listBoxCountry.SelectedItems.OfType<CountryRegionEntity>() select country.Name;
      _orderSearchCriteria.Zip = tbZip.Text;

      btnSearch.Enabled = false;
      _frmStatusBar = new FrmStatusBar();
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
    ///   Handles the DoWork event of the searchWorker control. http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14181
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs" /> instance containing the event data.</param>
    private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      var predicate = PredicateBuilder.True<SalesOrderHeaderEntity>();
      predicate = predicate.FilterByDateOrderIDOrderNumberCustomerNameAddressPredicateBuilder(_orderSearchCriteria);
      var exp = FrmEasyQuery.GetLinqExpression(query1) as MethodCallExpression;
      // predicate.And((Expression<Func<SalesOrderHeaderEntity, bool>>) exp);
      foreach (var expArg in exp.Arguments)
      {
        if (expArg.NodeType == ExpressionType.Lambda)
        {
          var x = expArg as Expression<Func<SalesOrderHeaderEntity, bool>>;
          predicate = predicate.And(x);
        }
        //
      }

      var salesOrderHeaderQuery = MetaSingletons.MetaData.SalesOrderHeader.Where(predicate);
      if (MaxNumberOfItemsToReturn > 0)
        salesOrderHeaderQuery = salesOrderHeaderQuery.Take(MaxNumberOfItemsToReturn);
      _results = salesOrderHeaderQuery.ToEntityCollection();
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