using System;
using System.ComponentModel;
using System.Windows.Forms;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;

namespace Northwind.Client.Winforms
{
  /// <summary>
  ///   The customer manager. It allows you to manage a customer's data and its orders and that orders' orderdetails.
  ///   It illustrates complex databinding (master-detail), events, sorting, fields mapped on relations (Customer.Orders ..),
  ///   transactions and validation.
  /// </summary>
  public class CustomerManager : Form
  {
    #region Components

    private GroupBox groupBox1;
    private TextBox customerIDTextBox;
    private Label label1;
    private TextBox companyNameTextBox;
    private Label label2;
    private TextBox contactNameTextBox;
    private Label label3;
    private TextBox contactTitleTextBox;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private Button selectCustomerButton;
    private Button _saveCustomerButton;
    private TextBox postalCodeTextBox;
    private TextBox regionTextBox;
    private TextBox addressTextBox;
    private GroupBox groupBox2;
    private DataGrid ordersDataGrid;
    private GroupBox groupBox3;
    private DataGrid orderDetailsDataGrid;
    private Splitter splitter1;
    private TextBox faxTextBox;
    private TextBox phoneTextBox;
    private TextBox countryTextBox;
    private IContainer components;
    private TextBox cityTextBox;
    private Label label32;
    private BindingSource _customerBindingSource;
    private BindingSource _ordersBindingSource;
    private BindingSource _orderDetailsBindingSource;

    #endregion

    #region Class Member Declarations

    private readonly CustomerWithOrdersDataScope _customerScope;
    private readonly INorthwindService _dalService;

    #endregion

    /// <summary>
    ///   CTor
    /// </summary>
    public CustomerManager(INorthwindService service)
      : this(service, string.Empty)
    {
    }


    /// <summary>
    ///   CTor
    /// </summary>
    /// <param name="customer">the customer to manage</param>
    public CustomerManager(INorthwindService service, string customerId)
    {
      InitializeComponent();
      _dalService = service;

      _customerScope = new CustomerWithOrdersDataScope(_dalService);
      _customerScope.ContainedDataChanged += new EventHandler(_customerScope_ScopedDataChanged);
      MinimumSize = Size;

      if (!string.IsNullOrEmpty(customerId))
      {
        // load customer and set as active.
        SetCustomerAsCurrent(customerId);
      }
    }


    /// <summary>
    ///   Binds the current set customer (in _currentCustomer) to the gui's controls so data entered is validated directly.
    /// </summary>
    private void BindCustomerToGui()
    {
      if (_customerScope == null)
      {
        return;
      }
      _customerBindingSource.DataSource = _customerScope.Customer;
      _saveCustomerButton.Enabled = false;
    }


    /// <summary>
    ///   Sets the given customer as the current customer, adding values of the customer to the controls on the form and
    ///   setting
    ///   up eventhandlers so the gui is aware of changes of the customer or its contents.
    /// </summary>
    /// <param name="customer"></param>
    private void SetCustomerAsCurrent(string customerId)
    {
      _customerScope.FetchData(customerId);
      BindCustomerToGui();
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///   Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>
    ///   Required method for Designer support - do not modify
    ///   the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cityTextBox = new System.Windows.Forms.TextBox();
      this._customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label32 = new System.Windows.Forms.Label();
      this._saveCustomerButton = new System.Windows.Forms.Button();
      this.selectCustomerButton = new System.Windows.Forms.Button();
      this.faxTextBox = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.phoneTextBox = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.countryTextBox = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.postalCodeTextBox = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.regionTextBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.addressTextBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.contactTitleTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.contactNameTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.companyNameTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.customerIDTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.ordersDataGrid = new System.Windows.Forms.DataGrid();
      this._ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.orderDetailsDataGrid = new System.Windows.Forms.DataGrid();
      this._orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this._customerBindingSource)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.ordersDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this._ordersBindingSource)).BeginInit();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.orderDetailsDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this._orderDetailsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                     | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.cityTextBox);
      this.groupBox1.Controls.Add(this.label32);
      this.groupBox1.Controls.Add(this._saveCustomerButton);
      this.groupBox1.Controls.Add(this.selectCustomerButton);
      this.groupBox1.Controls.Add(this.faxTextBox);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.phoneTextBox);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.countryTextBox);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.postalCodeTextBox);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.regionTextBox);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.addressTextBox);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.contactTitleTextBox);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.contactNameTextBox);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.companyNameTextBox);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.customerIDTextBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(669, 213);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Customer information";
      // 
      // cityTextBox
      // 
      this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
      this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "City", true));
      this.cityTextBox.Location = new System.Drawing.Point(108, 129);
      this.cityTextBox.Name = "cityTextBox";
      this.cityTextBox.Size = new System.Drawing.Size(351, 20);
      this.cityTextBox.TabIndex = 6;
      // 
      // _customerBindingSource
      // 
      this._customerBindingSource.DataSource = typeof (CustomerEntity);
      // 
      // label32
      // 
      this.label32.Location = new System.Drawing.Point(12, 132);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(93, 18);
      this.label32.TabIndex = 22;
      this.label32.Text = "City";
      // 
      // _saveCustomerButton
      // 
      this._saveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this._saveCustomerButton.Enabled = false;
      this._saveCustomerButton.Location = new System.Drawing.Point(561, 180);
      this._saveCustomerButton.Name = "_saveCustomerButton";
      this._saveCustomerButton.Size = new System.Drawing.Size(99, 24);
      this._saveCustomerButton.TabIndex = 12;
      this._saveCustomerButton.Text = "Save changes";
      this._saveCustomerButton.Click += new System.EventHandler(this.saveCustomerButton_Click);
      // 
      // selectCustomerButton
      // 
      this.selectCustomerButton.Location = new System.Drawing.Point(225, 21);
      this.selectCustomerButton.Name = "selectCustomerButton";
      this.selectCustomerButton.Size = new System.Drawing.Size(66, 21);
      this.selectCustomerButton.TabIndex = 1;
      this.selectCustomerButton.Text = "Select...";
      this.selectCustomerButton.Click += new System.EventHandler(this.selectCustomerButton_Click);
      // 
      // faxTextBox
      // 
      this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "Fax", true));
      this.faxTextBox.Location = new System.Drawing.Point(330, 177);
      this.faxTextBox.Name = "faxTextBox";
      this.faxTextBox.Size = new System.Drawing.Size(111, 20);
      this.faxTextBox.TabIndex = 11;
      // 
      // label10
      // 
      this.label10.Location = new System.Drawing.Point(240, 180);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(78, 18);
      this.label10.TabIndex = 20;
      this.label10.Text = "Fax";
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "Phone", true));
      this.phoneTextBox.Location = new System.Drawing.Point(108, 177);
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(120, 20);
      this.phoneTextBox.TabIndex = 10;
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(12, 180);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(93, 18);
      this.label9.TabIndex = 18;
      this.label9.Text = "Phone";
      // 
      // countryTextBox
      // 
      this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "Country", true));
      this.countryTextBox.Location = new System.Drawing.Point(330, 153);
      this.countryTextBox.Name = "countryTextBox";
      this.countryTextBox.Size = new System.Drawing.Size(249, 20);
      this.countryTextBox.TabIndex = 9;
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(240, 156);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(87, 18);
      this.label8.TabIndex = 16;
      this.label8.Text = "Country";
      // 
      // postalCodeTextBox
      // 
      this.postalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "PostalCode", true));
      this.postalCodeTextBox.Location = new System.Drawing.Point(570, 129);
      this.postalCodeTextBox.Name = "postalCodeTextBox";
      this.postalCodeTextBox.Size = new System.Drawing.Size(87, 20);
      this.postalCodeTextBox.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label7.Location = new System.Drawing.Point(474, 132);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(93, 18);
      this.label7.TabIndex = 14;
      this.label7.Text = "Postalcode";
      // 
      // regionTextBox
      // 
      this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "Region", true));
      this.regionTextBox.Location = new System.Drawing.Point(108, 153);
      this.regionTextBox.Name = "regionTextBox";
      this.regionTextBox.Size = new System.Drawing.Size(120, 20);
      this.regionTextBox.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(12, 156);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(57, 18);
      this.label6.TabIndex = 12;
      this.label6.Text = "Region";
      // 
      // addressTextBox
      // 
      this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                          | System.Windows.Forms.AnchorStyles.Right)));
      this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "Address", true));
      this.addressTextBox.Location = new System.Drawing.Point(108, 105);
      this.addressTextBox.Name = "addressTextBox";
      this.addressTextBox.Size = new System.Drawing.Size(549, 20);
      this.addressTextBox.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 108);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(93, 18);
      this.label5.TabIndex = 10;
      this.label5.Text = "Address";
      // 
      // contactTitleTextBox
      // 
      this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "ContactTitle", true));
      this.contactTitleTextBox.Location = new System.Drawing.Point(108, 75);
      this.contactTitleTextBox.Name = "contactTitleTextBox";
      this.contactTitleTextBox.Size = new System.Drawing.Size(111, 20);
      this.contactTitleTextBox.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 78);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 18);
      this.label4.TabIndex = 8;
      this.label4.Text = "ContactTitle";
      // 
      // contactNameTextBox
      // 
      this.contactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                              | System.Windows.Forms.AnchorStyles.Right)));
      this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "ContactName", true));
      this.contactNameTextBox.Location = new System.Drawing.Point(330, 75);
      this.contactNameTextBox.Name = "contactNameTextBox";
      this.contactNameTextBox.Size = new System.Drawing.Size(327, 20);
      this.contactNameTextBox.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(240, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "Contact Name";
      // 
      // companyNameTextBox
      // 
      this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customerBindingSource, "CompanyName", true));
      this.companyNameTextBox.Location = new System.Drawing.Point(108, 51);
      this.companyNameTextBox.Name = "companyNameTextBox";
      this.companyNameTextBox.Size = new System.Drawing.Size(243, 20);
      this.companyNameTextBox.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 18);
      this.label2.TabIndex = 4;
      this.label2.Text = "Company Name";
      // 
      // customerIDTextBox
      // 
      this.customerIDTextBox.Location = new System.Drawing.Point(108, 21);
      this.customerIDTextBox.Name = "customerIDTextBox";
      this.customerIDTextBox.ReadOnly = true;
      this.customerIDTextBox.Size = new System.Drawing.Size(111, 20);
      this.customerIDTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "Customer ID";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                      | System.Windows.Forms.AnchorStyles.Left)
                                                                     | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.ordersDataGrid);
      this.groupBox2.Controls.Add(this.splitter1);
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Location = new System.Drawing.Point(9, 225);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(666, 423);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Customer\'s orders";
      // 
      // ordersDataGrid
      // 
      this.ordersDataGrid.AllowNavigation = false;
      this.ordersDataGrid.CaptionText = "Orders";
      this.ordersDataGrid.DataMember = "";
      this.ordersDataGrid.DataSource = this._ordersBindingSource;
      this.ordersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ordersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.ordersDataGrid.Location = new System.Drawing.Point(3, 16);
      this.ordersDataGrid.Name = "ordersDataGrid";
      this.ordersDataGrid.Size = new System.Drawing.Size(660, 191);
      this.ordersDataGrid.TabIndex = 0;
      // 
      // _ordersBindingSource
      // 
      this._ordersBindingSource.DataMember = "Orders";
      this._ordersBindingSource.DataSource = this._customerBindingSource;
      // 
      // splitter1
      // 
      this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(3, 207);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(660, 6);
      this.splitter1.TabIndex = 11;
      this.splitter1.TabStop = false;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.orderDetailsDataGrid);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox3.Location = new System.Drawing.Point(3, 213);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(660, 207);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Current order\'s order details";
      // 
      // orderDetailsDataGrid
      // 
      this.orderDetailsDataGrid.CaptionText = "Order Details";
      this.orderDetailsDataGrid.DataMember = "";
      this.orderDetailsDataGrid.DataSource = this._orderDetailsBindingSource;
      this.orderDetailsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.orderDetailsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.orderDetailsDataGrid.Location = new System.Drawing.Point(3, 16);
      this.orderDetailsDataGrid.Name = "orderDetailsDataGrid";
      this.orderDetailsDataGrid.Size = new System.Drawing.Size(654, 188);
      this.orderDetailsDataGrid.TabIndex = 0;
      // 
      // _orderDetailsBindingSource
      // 
      this._orderDetailsBindingSource.DataMember = "OrderDetails";
      this._orderDetailsBindingSource.DataSource = this._ordersBindingSource;
      // 
      // CustomerManagerUsingBO
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(679, 656);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "CustomerManagerUsingBO";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Northwind Customer manager form";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize) (this._customerBindingSource)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.ordersDataGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this._ordersBindingSource)).EndInit();
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.orderDetailsDataGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this._orderDetailsBindingSource)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    #region Event Handlers

    private void selectCustomerButton_Click(object sender, EventArgs e)
    {
      var selector = new CustomerSelector(_dalService);
      selector.ShowDialog(this);

      if (selector.DialogResult != DialogResult.OK)
      {
        return;
      }
      SetCustomerAsCurrent(selector.SelectedCustomer.CustomerId);
    }

    private void saveCustomerButton_Click(object sender, EventArgs e)
    {
      var result = _customerScope.SaveChanges();
      if (result)
      {
        MessageBox.Show("Save was succesful!", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _saveCustomerButton.Enabled = false;
      }
      else
      {
        MessageBox.Show(this, "Save was NOT succesful!", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }


    private void _customerScope_ScopedDataChanged(object sender, EventArgs e)
    {
      _saveCustomerButton.Enabled = true;
    }

    #endregion
  }
}