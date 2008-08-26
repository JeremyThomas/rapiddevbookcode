using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.TypedListClasses;
using AW.Data.TypedViewClasses;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class frmCustomers : Form
  {
    public frmCustomers()
    {
      InitializeComponent();
    }

    private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.CustomersSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }

    private void frmCustomers_Load(object sender, EventArgs e)
    {
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.CustomersSizeLocation);
      dgvResults.AutoGenerateColumns = true;
    }

    private void toolStripButtonPlaintypedview_Click(object sender, EventArgs e)
    {
      var Customers = new CustomerViewTypedView();
      Customers.Fill(MaxNumberOfItemsToReturn, null);
      bindingSource1.DataSource = Customers;
    }

    private void toolStripButtonViewAsEntity_Click(object sender, EventArgs e)
    {
      var Order = new SalesOrderHeaderEntity(46117);
      var CustomerView = Order.CustomerViewRelated;
      var CustomerCollection = new CustomerViewRelatedCollection {CustomerView};
      bindingSource1.DataSource = CustomerCollection;
    }

    private void toolStripButtonTypedList_Click(object sender, EventArgs e)
    {
      var Customers = new CustomerListTypedList();
      Customers.Fill(MaxNumberOfItemsToReturn, null);
      bindingSource1.DataSource = Customers;
    }

    private void toolStripButtonLinq_Click(object sender, EventArgs e)
    {
      var customerlist = from customer in AWHelper.MetaData.Customer
                         from customerAddress in customer.CustomerAddress
                         select new
                                  {
                                    customerAddress.Address.AddressLine1,customerAddress.Address.AddressLine2,customerAddress.Address.City,
                                    AddressType = customerAddress.AddressType.Name, customer.Individual.Contact.Title,
                                    customer.Individual.Contact.FirstName, customer.Individual.Contact.MiddleName, customer.Individual.Contact.LastName, 
                                    customer.Individual.Contact.Suffix, customer.Individual.Contact.EmailAddress,
                                    customer.Individual.Contact.EmailPromotion, StateProvinceName = customerAddress.Address.StateProvince.Name,
                                    customerAddress.CustomerId
                                  };
      if (MaxNumberOfItemsToReturn > 0)
        customerlist = customerlist.Take(MaxNumberOfItemsToReturn);
      bindingSource1.DataSource = customerlist;
    }

//    SELECT     Person.Address.AddressLine1, Person.Address.AddressLine2, Person.Address.City, Person.AddressType.Name AS AddressType, Person.Contact.Title, 
//                      , Person.CountryRegion.Name AS CountryRegionName, Person.StateProvince.Name AS StateProvinceName, 
//                      Sales.Customer.CustomerID AS CustomerId
//FROM         Sales.Customer INNER JOIN
//                      Sales.Individual ON Sales.Customer.CustomerID = Sales.Individual.CustomerID INNER JOIN
//                      Person.Contact ON Person.Contact.ContactID = Sales.Individual.ContactID INNER JOIN
//                      Sales.CustomerAddress ON Sales.Customer.CustomerID = Sales.CustomerAddress.CustomerID INNER JOIN
//                      Person.AddressType ON Person.AddressType.AddressTypeID = Sales.CustomerAddress.AddressTypeID INNER JOIN
//                      Person.Address ON Person.Address.AddressID = Sales.CustomerAddress.AddressID INNER JOIN
//                      Person.StateProvince ON Person.StateProvince.StateProvinceID = Person.Address.StateProvinceID INNER JOIN
//                      Person.CountryRegion ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode

    public int MaxNumberOfItemsToReturn
    {
      get { return Convert.ToInt32(numericUpDownNumRows.Value); }
      set { numericUpDownNumRows.Value = value; }
    }
  }
}