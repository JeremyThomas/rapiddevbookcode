using System;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.LLBL;
using AW.Winforms.Helpers.LLBL.PropGridEx;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class FrmOrderEdit : FrmPersistantLocation
  {
    private readonly SalesOrderHeaderEntity _order;

    public FrmOrderEdit()
    {
      InitializeComponent();
    }

    public FrmOrderEdit(SalesOrderHeaderEntity order) : this()
    {
      _order = order;
    }

    private void frmOrderEdit_Load(object sender, EventArgs e)
    {
      PopulateListBoxes();

      if (_order != null && _order.IsNew == false)
      {
        PopulateOrderData();
        PopulateOrderDetailData();
      }
    }

    private void PopulateListBoxes()
    {
      cbShipMethod.DataSource = ShipMethodEntity.GetShipMethodCollection();
      cbShipMethod.DisplayMember = ShipMethodFieldIndex.Name.ToString();
      cbShipMethod.ValueMember = ShipMethodFieldIndex.ShipMethodID.ToString();
    }

    private void PopulateOrderData()
    {
      salesOrderHeaderEntityBindingSource.DataSource = _order;
      tbContact.Text = _order.Contact.DisplayName;
      if (_order.CustomerViewRelated != null) tbCustomer.Text = _order.CustomerViewRelated.DisplayName;
      if (_order.ShipDate != DateTime.MinValue)
        dtpShipDate.Value = _order.ShipDate.Value;
      else
        dtpShipDate.Checked = false;
    }

    private void PopulateOrderDetailData()
    {
      dgvDetail.DataSource = _order.SalesOrderDetails;
    }

    private void tspSave_Click(object sender, EventArgs e)
    {
      // there are errors, cancel the save until the user fixes them.
      if (_order.GetEntityFieldsErrors() != string.Empty)
        MessageBox.Show("There are errors in the entity. Please fix them prior to save.", "Please fix the errors.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else if (LLBLWinformHelper.ValidateForm(this, myError))
      {
        salesOrderHeaderEntityBindingSource.EndEdit();
        if (SaveData())
          //Close()
          salesOrderHeaderEntityBindingSource.ResetBindings(false);
      }
      else
        MessageBox.Show(
          "Please correct errors before saving.",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
    }

    private bool SaveData()
    {
      bool result;
      if (dtpShipDate.Checked)
        _order.ShipDate = dtpShipDate.Value;
      else
        _order.SetNewFieldValue(
          (int) SalesOrderHeaderFieldIndex.ShipDate, null);

      try
      {
        // if (!_order.Save(GeneralConcurrencyPredicateFactory.ConcurrencyPredicateFactory.CreatePredicate(ConcurrencyPredicateType.Save, _order)))
        if (!_order.Save())
          MessageBox.Show(
            "Record wasn't saved",
            "Save error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Stop);
        result = true;
      }
      catch (ORMConcurrencyException ex)
      {
        var frm = new FrmReconcile((IEntity) ex.EntityWhichFailed);
        result = frm.ShowDialog() == DialogResult.OK;
      }
      return result;
    }

    private void tspClose_Click(object sender, EventArgs e)
    {
      if (_order != null && !_order.IsNew)
        RevertAnyChanges(); //_order.Refetch();
      Close();
    }

    private void tspDelete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(
        "Are you sure you want to delete this order?",
        "Confirm delete", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning) == DialogResult.OK)
      {
        _order.Delete();
        Close();
      }
    }

    private void tbPurchaseOrder_TextChanged(object sender, EventArgs e)
    {
      //So we validate as we type rather than when we focus off the control
      Validation.ValidatePropertyAssignment(_order, (int) SalesOrderHeaderFieldIndex.PurchaseOrderNumber, tbPurchaseOrder.Text);
      // update the errors at GUI 
      myError.UpdateBinding();
    }

    private void frmOrderEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
      // salesOrderHeaderEntityBindingSource.CancelEdit();
      if (_order != null) _order.ResetErrors();
    }

    private void toolStripButtonViewEntity_Click(object sender, EventArgs e)
    {
      FrmLLBLEntityViewer.Show(_order);
    }

    private void toolStripButtonRefetch_Click(object sender, EventArgs e)
    {
      salesOrderHeaderEntityBindingSource.CancelEdit();
      _order.Refetch();
      salesOrderHeaderEntityBindingSource.ResetBindings(false);
    }

    private void toolStripButtonRevert_Click(object sender, EventArgs e)
    {
      RevertAnyChanges();
    }

    private void RevertAnyChanges()
    {
      salesOrderHeaderEntityBindingSource.CancelEdit();
      _order.RevertChangesToDBValue();
    }
  }
}