using System;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Win.Properties;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class frmOrderEdit: Form
  {
    private readonly SalesOrderHeaderEntity _order;

    public frmOrderEdit()
    {
      InitializeComponent();
    }

    public frmOrderEdit(SalesOrderHeaderEntity Order): this()
    {
      _order = Order;
    }

    private void frmOrderEdit_Load(object sender, EventArgs e)
    {
      PopulateListBoxes();

      if (_order != null && _order.IsNew == false)
      {
        PopulateOrderData();
        PopulateOrderDetailData();
      }
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.OrderEditSizeLocation);
    }

    private void PopulateListBoxes()
    {
      cbShipMethod.DataSource = ShipMethodEntity.GetShipMethodCollection();
      cbShipMethod.DisplayMember = ShipMethodFieldIndex.Name.ToString();
      cbShipMethod.ValueMember = ShipMethodFieldIndex.ShipMethodId.ToString();
    }

    private void PopulateOrderData()
    {
      salesOrderHeaderEntityBindingSource.DataSource = _order;
      //tbPurchaseOrder.Text = _order.PurchaseOrderNumber;
      //tbSubtotal.Text = _order.SubTotal.ToString("N2");
      //tbTax.Text = _order.TaxAmt.ToString("N2");
      //tbFreight.Text = _order.Freight.ToString("N2");
      //lblTotal.Text = _order.TotalDue.ToString("N2");
      //tbContact.Text = _order.Contact.DisplayName;
      //tbCustomer.Text = _order.CustomerView_.DisplayName;
      //cbOnlineOrder.Checked = _order.OnlineOrderFlag;
      //dtpOrderDate.Value = _order.OrderDate;
      //dtpDueDate.Value = _order.DueDate;
      if (_order.ShipDate != DateTime.MinValue)
        dtpShipDate.Value = _order.ShipDate.Value;
      else
        dtpShipDate.Checked = false;
      //cbShipMethod.SelectedValue = _order.ShipMethodId;
    }

    private void PopulateOrderDetailData()
    {
      dgvDetail.DataSource = _order.SalesOrderDetail;
    }

    private void tspSave_Click(object sender, EventArgs e)
    {
      // there are errors, cancel the save until the user fixes them.
      if (_order.GetEntityFieldsErrors() != string.Empty)
        MessageBox.Show("There are errors in the entity. Please fix them prior to save.", "Please fix the errors.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else if (AWHelper.ValidateForm(this, myError))
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
      var result = false;
      if (dtpShipDate.Checked)
        _order.ShipDate = dtpShipDate.Value;
      else
        _order.SetNewFieldValue(
          (int)SalesOrderHeaderFieldIndex.ShipDate, null);

      try
      {        
       // if (!_order.Save(GeneralConcurrencyPredicateFactory.ConcurrencyPredicateFactory.CreatePredicate(ConcurrencyPredicateType.Save, _order)))
        if (!_order.Save())
        {
          MessageBox.Show(
            "Record wasn't saved",
            "Save error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Stop);
        }
        result = true;
      }
      catch (ORMConcurrencyException ex)
      {
        var frm = new FrmReconcile((IEntity)ex.EntityWhichFailed);
        result = frm.ShowDialog() == DialogResult.OK;

      }
      return result;
    }

    private void tspClose_Click(object sender, EventArgs e)
    {
      if (_order != null) _order.Refetch();
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
      Validation.ValidatePropertyAssignment(tbPurchaseOrder.Text, _order, (int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber);
      // update the errors at GUI 
      myError.UpdateBinding();
    }

    private void frmOrderEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
      // salesOrderHeaderEntityBindingSource.CancelEdit();
      if (_order != null) _order.ResetErrors();
      Settings.Default.OrderEditSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }

    private void toolStripButtonViewEntity_Click(object sender, EventArgs e)
    {
      var frm = new FrmEntityViewer(_order);
      ((frmMain)MdiParent).LaunchChildForm(frm);
    }

    private void toolStripButtonRefetch_Click(object sender, EventArgs e)
    {
      salesOrderHeaderEntityBindingSource.CancelEdit();
      _order.Refetch();
      salesOrderHeaderEntityBindingSource.ResetBindings(false);
    }

    public void RevertEntity(EntityBase entity)
    {
          foreach (EntityField field in entity.Fields)
          {
            if (field.IsChanged)
            {
              //field.CurrentValue = field.DbValue;
              field.RejectChange();
            }
          }
    }

    private void toolStripButtonRevert_Click(object sender, EventArgs e)
    {
      salesOrderHeaderEntityBindingSource.CancelEdit();
      RevertEntity(_order);
    }
  }
}