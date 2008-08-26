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

    /// <summary>
    /// Handles the Click event of the toolStripButtonPlaintypedview control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <remarks>
    /// SELECT [SALES].[VINDIVIDUALCUSTOMER].[CUSTOMERID]        AS [CUSTOMERID],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    ///FROM   [SALES].[VINDIVIDUALCUSTOMER]
    /// </remarks>
    private void toolStripButtonPlaintypedview_Click(object sender, EventArgs e)
    {
      var Customers = new CustomerViewTypedView();
      Customers.Fill(MaxNumberOfItemsToReturn, null);
      bindingSource1.DataSource = Customers;
    }

    /// <summary>
    /// Handles the Click event of the toolStripButtonViewAsEntity control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <remarks>
    ///SELECT [SALES].[SALESORDERHEADER].[SALESORDERID]           AS [SALESORDERID],
    ///       [SALES].[SALESORDERHEADER].[REVISIONNUMBER],
    ///       [SALES].[SALESORDERHEADER].[ORDERDATE],
    ///       [SALES].[SALESORDERHEADER].[DUEDATE],
    ///       [SALES].[SALESORDERHEADER].[SHIPDATE],
    ///       [SALES].[SALESORDERHEADER].[STATUS],
    ///       [SALES].[SALESORDERHEADER].[ONLINEORDERFLAG],
    ///       [SALES].[SALESORDERHEADER].[SALESORDERNUMBER],
    ///       [SALES].[SALESORDERHEADER].[PURCHASEORDERNUMBER],
    ///       [SALES].[SALESORDERHEADER].[ACCOUNTNUMBER],
    ///       [SALES].[SALESORDERHEADER].[CUSTOMERID]             AS [CUSTOMERID],
    ///       [SALES].[SALESORDERHEADER].[CONTACTID]              AS [CONTACTID],
    ///       [SALES].[SALESORDERHEADER].[SALESPERSONID]          AS [SALESPERSONID],
    ///       [SALES].[SALESORDERHEADER].[TERRITORYID]            AS [TERRITORYID],
    ///       [SALES].[SALESORDERHEADER].[BILLTOADDRESSID]        AS [BILLTOADDRESSID],
    ///       [SALES].[SALESORDERHEADER].[SHIPTOADDRESSID]        AS [SHIPTOADDRESSID],
    ///       [SALES].[SALESORDERHEADER].[SHIPMETHODID]           AS [SHIPMETHODID],
    ///       [SALES].[SALESORDERHEADER].[CREDITCARDID]           AS [CREDITCARDID],
    ///       [SALES].[SALESORDERHEADER].[CREDITCARDAPPROVALCODE],
    ///       [SALES].[SALESORDERHEADER].[CURRENCYRATEID]         AS [CURRENCYRATEID],
    ///       [SALES].[SALESORDERHEADER].[SUBTOTAL],
    ///       [SALES].[SALESORDERHEADER].[TAXAMT],
    ///       [SALES].[SALESORDERHEADER].[FREIGHT],
    ///       [SALES].[SALESORDERHEADER].[TOTALDUE],
    ///       [SALES].[SALESORDERHEADER].[COMMENT],
    ///       [SALES].[SALESORDERHEADER].[ROWGUID]                AS [ROWGUID],
    ///       [SALES].[SALESORDERHEADER].[MODIFIEDDATE]
    ///FROM   [SALES].[SALESORDERHEADER]
    ///WHERE  (([SALES].[SALESORDERHEADER].[SALESORDERID] = @SalesOrderId1))

    ///    SELECT [SALES].[VINDIVIDUALCUSTOMER].[CUSTOMERID]        AS [CUSTOMERID],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    ///       [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    ///FROM   [SALES].[VINDIVIDUALCUSTOMER]
    ///WHERE  (([SALES].[VINDIVIDUALCUSTOMER].[CUSTOMERID] = @CustomerId1))
    /// </remarks>
    private void toolStripButtonViewAsEntity_Click(object sender, EventArgs e)
    {
      var Order = new SalesOrderHeaderEntity(46117);
      var CustomerView = Order.CustomerViewRelated;
      var CustomerCollection = new CustomerViewRelatedCollection {CustomerView};
      bindingSource1.DataSource = CustomerCollection;
    }

    /// <summary>
    /// Handles the Click event of the toolStripButtonTypedList control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <remarks>SQL Output:
    /// SELECT     Person.Address.AddressLine1, Person.Address.AddressLine2, Person.Address.City, Person.AddressType.Name AS AddressType, Person.Contact.Title, 
    ///                      , Person.CountryRegion.Name AS CountryRegionName, Person.StateProvince.Name AS StateProvinceName, 
    ///                      Sales.Customer.CustomerID AS CustomerId
    /// FROM         Sales.Customer INNER JOIN
    ///                      Sales.Individual ON Sales.Customer.CustomerID = Sales.Individual.CustomerID INNER JOIN
    ///                      Person.Contact ON Person.Contact.ContactID = Sales.Individual.ContactID INNER JOIN
    ///                      Sales.CustomerAddress ON Sales.Customer.CustomerID = Sales.CustomerAddress.CustomerID INNER JOIN
    ///                      Person.AddressType ON Person.AddressType.AddressTypeID = Sales.CustomerAddress.AddressTypeID INNER JOIN
    ///                      Person.Address ON Person.Address.AddressID = Sales.CustomerAddress.AddressID INNER JOIN
    ///                      Person.StateProvince ON Person.StateProvince.StateProvinceID = Person.Address.StateProvinceID INNER JOIN
    ///                      Person.CountryRegion ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode</remarks>
    private void toolStripButtonTypedList_Click(object sender, EventArgs e)
    {
      var Customers = new CustomerListTypedList();
      Customers.Fill(MaxNumberOfItemsToReturn, null);
      bindingSource1.DataSource = Customers;
    }

    /// <summary>
    /// Handles the Click event of the toolStripButtonLinq control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <remarks>
    /// SELECT DISTINCT TOP 5 [LPLA_4].[ADDRESSLINE1],
    ///                      [LPLA_4].[ADDRESSLINE2],
    ///                      [LPLA_4].[CITY],
    ///                      [LPLA_5].[NAME]           AS [ADDRESSTYPE],
    ///                      [LPLA_7].[TITLE],
    ///                      [LPLA_7].[FIRSTNAME],
    ///                      [LPLA_7].[MIDDLENAME],
    ///                      [LPLA_7].[LASTNAME],
    ///                      [LPLA_7].[SUFFIX],
    ///                      [LPLA_7].[EMAILADDRESS],
    ///                      [LPLA_7].[EMAILPROMOTION],
    ///                      [LPLA_9].[NAME]           AS [COUNTRYREGIONNAME],
    ///                      [LPLA_8].[NAME]           AS [STATEPROVINCENAME],
    ///                      [LPA_L1].[CUSTOMERID]     AS [CUSTOMERID]
    /// FROM   ([ADVENTUREWORKS].[SALES].[CUSTOMER] [LPA_L1]
    ///        INNER JOIN [ADVENTUREWORKS].[SALES].[CUSTOMERADDRESS] [LPA_L2]
    ///          ON ([LPA_L1].[CUSTOMERID] = [LPA_L2].[CUSTOMERID]))</remarks>
    private void toolStripButtonLinq_Click(object sender, EventArgs e)
    {
      var customerlist = from customer in AWHelper.MetaData.Customer
                         from customerAddress in customer.CustomerAddress
                         where customerAddress.Address.AddressLine1 == customerAddress.Address.AddressLine1
                         select new
                                  {
                                    customerAddress.Address.AddressLine1, customerAddress.Address.AddressLine2, customerAddress.Address.City,
                                    AddressType = customerAddress.AddressType.Name, customer.Individual.Contact.Title,
                                    customer.Individual.Contact.FirstName, customer.Individual.Contact.MiddleName, customer.Individual.Contact.LastName,
                                    customer.Individual.Contact.Suffix, customer.Individual.Contact.EmailAddress, customer.Individual.Contact.EmailPromotion,
                                    CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
                                    StateProvinceName = customerAddress.Address.StateProvince.Name,
                                    customer.CustomerId
                                  };
      if (MaxNumberOfItemsToReturn > 0)
        customerlist = customerlist.Take(MaxNumberOfItemsToReturn);
      bindingSource1.DataSource = customerlist;
    }

    public int MaxNumberOfItemsToReturn
    {
      get { return Convert.ToInt32(numericUpDownNumRows.Value); }
      set { numericUpDownNumRows.Value = value; }
    }
  }
}