using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
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

    public int MaxNumberOfItemsToReturn
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
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerViewTypedView(MaxNumberOfItemsToReturn);
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

    /// <summary>
    ///   Handles the Click event of the toolStripButtonTypedList control. Example 5.29. pg64.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonTypedList_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerListTypedList(MaxNumberOfItemsToReturn);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonLinq control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonLinq_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerListLinqedTypedList(MaxNumberOfItemsToReturn);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonLinqBarf control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonLinqBarf_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = CustomerQueries.GetCustomerListAnonymousLinq(MaxNumberOfItemsToReturn);
    }

    private void toolStripButtonViewAsEntityLinq_Click(object sender, EventArgs e)
    {
      bindingSourceCustomerList.DataSource = MetaSingletons.MetaData.CustomerViewRelated.Take(MaxNumberOfItemsToReturn).ToEntityCollection();
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
  }
}