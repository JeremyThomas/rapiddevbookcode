using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.CollectionClasses;

namespace AW.Win
{
    public partial class frmOrderEdit : Form
    {
        SalesOrderHeaderEntity _order;
        public frmOrderEdit()
        {
            InitializeComponent();
        }
        public frmOrderEdit(SalesOrderHeaderEntity Order)
        {
            InitializeComponent();
            _order = Order;
        }
        private void frmOrderEdit_Load(object sender, EventArgs e)
        {
            PopulateListBoxes();
            if (_order.IsNew == false)
            {
                PopulateOrderData();
                PopulateOrderDetailData();
            }
        }
        private void PopulateListBoxes()
        {
            cbShipMethod.DataSource = ShipMethodEntity.GetShipMethodCollection();
            cbShipMethod.DisplayMember = ShipMethodFieldIndex.Name.ToString();
            cbShipMethod.ValueMember = ShipMethodFieldIndex.ShipMethodId.ToString();
        }
        private void PopulateOrderData()
        {
            tbPurchaseOrder.Text = _order.PurchaseOrderNumber;
            tbSubtotal.Text = _order.SubTotal.ToString("N2");
            tbTax.Text = _order.TaxAmt.ToString("N2");
            tbFreight.Text = _order.Freight.ToString("N2");
            lblTotal.Text = _order.TotalDue.ToString("N2");
            tbContact.Text = _order.Contact.DisplayName;
            //note tbCustomer.Text = _order.CustomerView_.DisplayName;
            cbOnlineOrder.Checked = _order.OnlineOrderFlag;
            dtpOrderDate.Value = _order.OrderDate;
            dtpDueDate.Value = _order.DueDate;
            if (_order.ShipDate != DateTime.MinValue)
                dtpShipDate.Value = _order.ShipDate.Value;
            else
                dtpShipDate.Checked = false;
            cbShipMethod.SelectedValue = _order.ShipMethodId;
        }
        private void PopulateOrderDetailData()
        {
            this.dgvDetail.DataSource = _order.SalesOrderDetail;
        }
        //private void tspSave_Click(object sender, EventArgs e)
        //{
        //    if (SaveData())
        //    {
        //        this.Close();
        //    }
        //}
        private void tspSave_Click(object sender, EventArgs e)
        {
            if (AW.Data.WinForms.Validation.ValidateForm(this, myError))
            {
                if (SaveData())
                {
                    this.Close();
                }
            }
            else
            {
               MessageBox.Show(
                   "Please correct errors before saving.",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        //private bool SaveData()
        //{
        //    try
        //    {
        //        _order.Freight = Convert.ToDecimal(tbFreight.Text);
        //        _order.PurchaseOrderNumber = tbPurchaseOrder.Text;
        //        _order.SubTotal = Convert.ToDecimal(tbSubtotal.Text);
        //        _order.TaxAmt = Convert.ToDecimal(tbTax.Text);
        //        _order.OnlineOrderFlag = cbOnlineOrder.Checked;
        //        _order.OrderDate = dtpOrderDate.Value;
        //        _order.DueDate = dtpDueDate.Value;
        //        if (dtpShipDate.Checked)
        //            _order.ShipDate = dtpShipDate.Value;
        //        else
        //            _order.SetNewFieldValue(
        //                (int)SalesOrderHeaderFieldIndex.ShipDate, null);
        //        _order.ShipMethodId = Convert.ToInt32(cbShipMethod.SelectedValue);
        //        _order.Save();
        //        return true;
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //        return false;
        //    }
        //}
        private bool SaveData()
        {
            try
            {
                _order.Freight = Convert.ToDecimal(tbFreight.Text);
                _order.PurchaseOrderNumber = tbPurchaseOrder.Text;
                _order.SubTotal = Convert.ToDecimal(tbSubtotal.Text);
                _order.TaxAmt = Convert.ToDecimal(tbTax.Text);
                _order.OnlineOrderFlag = cbOnlineOrder.Checked;
                _order.OrderDate = dtpOrderDate.Value;
                _order.DueDate = dtpDueDate.Value;
                if (dtpShipDate.Checked)
                    _order.ShipDate = dtpShipDate.Value;
                else
                    _order.SetNewFieldValue(
                        (int)SalesOrderHeaderFieldIndex.ShipDate, null);
                _order.ShipMethodId = Convert.ToInt32(cbShipMethod.SelectedValue);
                if (_order.Validate())
                {
                    _order.Save();
                    return true;
                }
                else
                {
                    //note SalesOrderHeaderEntityValidator val = 
                    //    (SalesOrderHeaderEntityValidator)
                    //    _order.EntityValidatorToUse;
                    //MessageBox.Show(
                    //    val.ErrorMessage,
                    //    "Error",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Stop);
                    return false;
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
        private void tspClose_Click(object sender, EventArgs e)
        {
            _order.Refetch();
            this.Close(); 
        }
        private void tspDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to delete this order?",
                "Confirm delete", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _order.Delete();
                this.Close();
            }
        }

        private void tbPurchaseOrder_TextChanged(object sender, EventArgs e)
        {
            //note AW.Data.WinForms.Validation.ValidatePropertyAssignment<string>
            //(tbPurchaseOrder,
            //(int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber,
            //tbPurchaseOrder.Text,
            //SalesOrderHeaderValidator.PurchaseOrderError,
            //myError,
            //_order);
        }


    }
}