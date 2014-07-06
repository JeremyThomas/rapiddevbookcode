using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.Linq.Filters;
using AW.Data.Queries;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.EntityViewer;

namespace AW.Win
{
  public partial class FrmCustomers : FrmPersistantLocation
  {
    public FrmCustomers()
    {
      InitializeComponent();
    }

    private int MaxNumberOfItemsToReturn
    {
      get { return Convert.ToInt32(numericUpDownNumRows.Value); }
      set { numericUpDownNumRows.Value = value; }
    }

    private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void frmCustomers_Load(object sender, EventArgs e)
    {
      dgvResults.AutoGenerateColumns = true;
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonPlaintypedview control. Example 5.18. pg59.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonPlaintypedview_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewTypedView(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    private void toolStripButtonTypedViewQuerySpec_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewTypedViewQuerySpec(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonViewAsEntity control. Example 5.27 pg63.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonViewAsEntity_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewRelatedCollection();
    }

    private void toolStripButtonViewAsEntity_Click_1(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewViaEntity(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    private void toolStripButtonViewAsEntityQuerySpec_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewViaEntityQuerySpec(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonTypedList control. Example 5.29. pg64.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonTypedList_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerListTypedList(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    private void toolStripButtonTypedListQuerySpec_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.BindEnumerable(CustomerQueries.GetCustomerListTypedListQuerySpec(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn),true,true);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonLinq control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonLinq_Click(object sender, EventArgs e)
    {
      BindingListHelper.BindEnumerable(bindingSourceCustomerList,CustomerQueries.GetCustomerListLinqedTypedList(orderSearchCriteria1.GetCriteria(), 0).ToList().Distinct().Take(MaxNumberOfItemsToReturn));
    }

    private void toolStripButtonLinqFilterFirst_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.BindEnumerable(CustomerQueries.GetCustomerListLinqedTypedListFilterFirst(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn),true,true);
    }

    private void toolStripButtonLinqTypedview_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewTypedViewLinq(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn);
    }

    private void toolStripButtonTypedListLinq_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerListLinqTypedList(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn); ;
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonLinqBarf control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonLinqBarf_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.BindEnumerable(CustomerQueries.GetCustomerListAnonymousLinq(orderSearchCriteria1.GetCriteria(), MaxNumberOfItemsToReturn),true,true);
    }

    private void toolStripButtonViewAsEntityLinq_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = MetaSingletons.MetaData.CustomerViewRelated
        .FilterByDateOrderIDOrderNumberCustomerNameAddress(orderSearchCriteria1.GetCriteria())
        .Take(MaxNumberOfItemsToReturn).ToEntityCollection();
    }

    private void View()
    {
      ((FrmMain) MdiParent).LaunchChildForm(typeof (FrmEntityViewer), bindingSourceCustomerList.Current);
    }

    private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      View();
    }

    private void dgvResults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      View();
    }

    private void dgvResults_SortStringChanged(object sender, EventArgs e)
    {
      bindingSourceCustomerList.Sort = dgvResults.SortString;
    }

    private void dgvResults_FilterStringChanged(object sender, EventArgs e)
    {
      if (bindingSourceCustomerList.SupportsFiltering)
        bindingSourceCustomerList.Filter = dgvResults.FilterString;
    }

    private void toolStripButtonClearSort_Click(object sender, EventArgs e)
    {
      dgvResults.ClearSort(true);
      if (bindingSourceCustomerList.SupportsSorting)
        bindingSourceCustomerList.RemoveSort();
    }

    private void toolStripButtonClearFilters_Click(object sender, EventArgs e)
    {
      dgvResults.ClearFilter(true);
      if (bindingSourceCustomerList.SupportsFiltering)
        bindingSourceCustomerList.RemoveFilter();
    }
  }
}