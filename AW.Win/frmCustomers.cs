using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.TypedViewClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.CollectionClasses;
using AW.Data.TypedListClasses;

namespace AW.Win
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        #region Plain typed view
        //private void frmCustomers_Load(object sender, EventArgs e)
        //{
        //    CustomerViewTypedView Customers = new CustomerViewTypedView();
        //    Customers.Fill();
        //    dgvResults.DataSource = Customers;
        //}
        #endregion 

        #region View as entity
        //private void frmCustomers_Load(object sender, EventArgs e)
        //{
        //    SalesOrderHeaderEntity Order = new SalesOrderHeaderEntity(46117);
        //    CustomerViewRelatedEntity CustomerView = Order.CustomerView_;
        //    CustomerViewRelatedCollection CustomerCollection =
        //        new CustomerViewRelatedCollection();
        //    CustomerCollection.Add(CustomerView);
        //    dgvResults.DataSource = CustomerCollection;
        //}
        #endregion 
        #region Typed List
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            CustomerListTypedList Customers = new CustomerListTypedList();
            Customers.Fill();
            dgvResults.DataSource = Customers;
        }
        #endregion
    }
}