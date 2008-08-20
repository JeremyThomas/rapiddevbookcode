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
    public partial class frmOrderSearch : Form
    {
        frmStatusBar _frmStatusBar;
        DateTime _fromDate;
        DateTime _toDate;
        string _firstName;
        string _lastName;
        int _orderID;
        string _orderName;
        string _cityName;
        string _state;
        string _country;
        string _zip;
        SalesOrderHeaderCollection _results;
        public frmOrderSearch()
        {
            InitializeComponent();
        }

        private void frmOrderSearch_Load(object sender, EventArgs e)
        {
            this.cbCountry.DataSource =
                CountryRegionEntity.GetCountryRegionCollection();
            this.cbCountry.DisplayMember =
                CountryRegionFieldIndex.Name.ToString();
            this.cbCountry.ValueMember =
                CountryRegionFieldIndex.CountryRegionCode.ToString();
            this.cbCountry.Text = "";
            this.cbState.DataSource =
                StateProvinceEntity.GetStateProvinceCollection();
            this.cbState.DisplayMember =
                StateProvinceFieldIndex.Name.ToString();
            this.cbState.ValueMember =
                StateProvinceFieldIndex.StateProvinceId.ToString();
            this.cbState.Text = "";
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    DateTime DateFrom = DateTime.MinValue;
        //    if (dtpDateFrom.Checked)
        //        DateFrom = dtpDateFrom.Value;
        //    DateTime DateTo = DateTime.MinValue;
        //    if (dtpDateTo.Checked)
        //        DateTo = dtpDateTo.Value;
        //    int OrderID = 0;
        //    string OrderNumber = "";
        //    if (tbOrderID.Text != "")
        //    {
        //        try
        //        {
        //            OrderID = Convert.ToInt32(tbOrderID.Text);
        //        }
        //        catch
        //        {
        //            OrderNumber = tbOrderID.Text;
        //        }
        //    }
        //    this.dgResults.DataSource =
        //        SalesOrderHeaderEntity.GetSalesOrderHeaderCollection(
        //        DateFrom,
        //        DateTo,
        //        tbFirstName.Text,
        //        tbLastName.Text,
        //        OrderID,
        //        OrderNumber,
        //        tbCity.Text,
        //        cbState.Text,
        //        cbCountry.Text,
        //        tbZip.Text);                
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _fromDate = DateTime.MinValue;
            if (dtpDateFrom.Checked)
                _fromDate = dtpDateFrom.Value;
            _toDate = DateTime.MinValue;
            if (dtpDateTo.Checked)
                _toDate = dtpDateTo.Value;
            _orderID = 0;
            _orderName = "";
            if (tbOrderID.Text != "")
            {
                try
                {
                    _orderID = Convert.ToInt32(tbOrderID.Text);
                }
                catch
                {
                    _orderName = tbOrderID.Text;
                }
            }
            _firstName = tbFirstName.Text;
            _lastName = tbLastName.Text;
            _cityName = tbCity.Text;
            _state = cbState.Text;
            _country = cbCountry.Text;
            _zip = tbZip.Text;
            btnSearch.Enabled = false;
            _frmStatusBar = new frmStatusBar();
            _frmStatusBar.Show();
            _frmStatusBar.CancelButtonClicked += 
                new CancelButtonEventHandler(_frmStatusBar_CancelButtonClicked);
            searchWorker.RunWorkerAsync();
        }
        void _frmStatusBar_CancelButtonClicked(object sender, CancelEventArgs e)
        {
            searchWorker.CancelAsync();
            btnSearch.Enabled = true;
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrderHeaderEntity Order = new SalesOrderHeaderEntity();
            Order.CustomerId = 17018;
            Order.ContactId = 4975;
            Order.BillToAddressId = 14810;
            Order.ShipToAddressId = 14810;
            frmOrderEdit frm = new frmOrderEdit(Order);
            ((frmMain)this.MdiParent).LaunchChildForm(frm);
        }

        void dgResults_CellContentDoubleClick(
            object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            SalesOrderHeaderEntity Order =
                dgResults.Rows[e.RowIndex].DataBoundItem
                as SalesOrderHeaderEntity;
            frmOrderEdit frm = new frmOrderEdit(Order);
            ((frmMain)this.MdiParent).LaunchChildForm(frm);
        }

        private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _results = SalesOrderHeaderEntity.
                GetSalesOrderHeaderCollection(
                _fromDate,
                _toDate,
                _firstName,
                _lastName,
                _orderID,
                _orderName,
                _cityName,
                _state,
                _country,
                _zip);
        }

        private void searchWorker_RunWorkerCompleted(object sender, 
            RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            if (_frmStatusBar != null)
            {
                _frmStatusBar.Close();
            }
            btnSearch.Enabled = true;
            dgResults.DataSource = _results;
            
            
        }
    }
}