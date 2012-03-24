
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using AW.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>
/// The default start page of the application.
/// </summary>
public partial class _Default : System.Web.UI.Page 
{
	/// <summary>
	/// Handles the Init event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Init(object sender, EventArgs e)
    {
		if(!Page.IsPostBack)
		{
			// add all entity types to the combo box.
			cbxEntity.Items.Add(new ListItem("AwbuildVersion", "AwbuildVersion"));
            cbxEntity.Items.Add(new ListItem("DatabaseLog", "DatabaseLog"));
            cbxEntity.Items.Add(new ListItem("ErrorLog", "ErrorLog"));
            cbxEntity.Items.Add(new ListItem("Department", "Department"));
            cbxEntity.Items.Add(new ListItem("Employee", "Employee"));
            cbxEntity.Items.Add(new ListItem("EmployeeAddress", "EmployeeAddress"));
            cbxEntity.Items.Add(new ListItem("EmployeeDepartmentHistory", "EmployeeDepartmentHistory"));
            cbxEntity.Items.Add(new ListItem("EmployeePayHistory", "EmployeePayHistory"));
            cbxEntity.Items.Add(new ListItem("JobCandidate", "JobCandidate"));
            cbxEntity.Items.Add(new ListItem("Shift", "Shift"));
            cbxEntity.Items.Add(new ListItem("Address", "Address"));
            cbxEntity.Items.Add(new ListItem("AddressType", "AddressType"));
            cbxEntity.Items.Add(new ListItem("Contact", "Contact"));
            cbxEntity.Items.Add(new ListItem("ContactType", "ContactType"));
            cbxEntity.Items.Add(new ListItem("CountryRegion", "CountryRegion"));
            cbxEntity.Items.Add(new ListItem("StateProvince", "StateProvince"));
            cbxEntity.Items.Add(new ListItem("BillOfMaterial", "BillOfMaterial"));
            cbxEntity.Items.Add(new ListItem("Culture", "Culture"));
            cbxEntity.Items.Add(new ListItem("Document", "Document"));
            cbxEntity.Items.Add(new ListItem("Illustration", "Illustration"));
            cbxEntity.Items.Add(new ListItem("Location", "Location"));
            cbxEntity.Items.Add(new ListItem("Product", "Product"));
            cbxEntity.Items.Add(new ListItem("ProductCategory", "ProductCategory"));
            cbxEntity.Items.Add(new ListItem("ProductCostHistory", "ProductCostHistory"));
            cbxEntity.Items.Add(new ListItem("ProductDescription", "ProductDescription"));
            cbxEntity.Items.Add(new ListItem("ProductDocument", "ProductDocument"));
            cbxEntity.Items.Add(new ListItem("ProductInventory", "ProductInventory"));
            cbxEntity.Items.Add(new ListItem("ProductListPriceHistory", "ProductListPriceHistory"));
            cbxEntity.Items.Add(new ListItem("ProductModel", "ProductModel"));
            cbxEntity.Items.Add(new ListItem("ProductModelIllustration", "ProductModelIllustration"));
            cbxEntity.Items.Add(new ListItem("ProductModelProductDescriptionCulture", "ProductModelProductDescriptionCulture"));
            cbxEntity.Items.Add(new ListItem("ProductPhoto", "ProductPhoto"));
            cbxEntity.Items.Add(new ListItem("ProductProductPhoto", "ProductProductPhoto"));
            cbxEntity.Items.Add(new ListItem("ProductReview", "ProductReview"));
            cbxEntity.Items.Add(new ListItem("ProductSubcategory", "ProductSubcategory"));
            cbxEntity.Items.Add(new ListItem("PurchaseOrderHistory", "PurchaseOrderHistory"));
            cbxEntity.Items.Add(new ListItem("SalesOrderHistory", "SalesOrderHistory"));
            cbxEntity.Items.Add(new ListItem("ScrapReason", "ScrapReason"));
            cbxEntity.Items.Add(new ListItem("TransactionHistory", "TransactionHistory"));
            cbxEntity.Items.Add(new ListItem("TransactionHistoryArchive", "TransactionHistoryArchive"));
            cbxEntity.Items.Add(new ListItem("UnitMeasure", "UnitMeasure"));
            cbxEntity.Items.Add(new ListItem("WorkOrder", "WorkOrder"));
            cbxEntity.Items.Add(new ListItem("WorkOrderHistory", "WorkOrderHistory"));
            cbxEntity.Items.Add(new ListItem("WorkOrderRouting", "WorkOrderRouting"));
            cbxEntity.Items.Add(new ListItem("ProductVendor", "ProductVendor"));
            cbxEntity.Items.Add(new ListItem("PurchaseOrderDetail", "PurchaseOrderDetail"));
            cbxEntity.Items.Add(new ListItem("PurchaseOrderHeader", "PurchaseOrderHeader"));
            cbxEntity.Items.Add(new ListItem("ShipMethod", "ShipMethod"));
            cbxEntity.Items.Add(new ListItem("Vendor", "Vendor"));
            cbxEntity.Items.Add(new ListItem("VendorAddress", "VendorAddress"));
            cbxEntity.Items.Add(new ListItem("VendorContact", "VendorContact"));
            cbxEntity.Items.Add(new ListItem("ContactCreditCard", "ContactCreditCard"));
            cbxEntity.Items.Add(new ListItem("CountryRegionCurrency", "CountryRegionCurrency"));
            cbxEntity.Items.Add(new ListItem("CreditCard", "CreditCard"));
            cbxEntity.Items.Add(new ListItem("Currency", "Currency"));
            cbxEntity.Items.Add(new ListItem("CurrencyRate", "CurrencyRate"));
            cbxEntity.Items.Add(new ListItem("Customer", "Customer"));
            cbxEntity.Items.Add(new ListItem("CustomerAddress", "CustomerAddress"));
            cbxEntity.Items.Add(new ListItem("CustomerViewRelated", "CustomerViewRelated"));
            cbxEntity.Items.Add(new ListItem("Individual", "Individual"));
            cbxEntity.Items.Add(new ListItem("SalesOrderDetail", "SalesOrderDetail"));
            cbxEntity.Items.Add(new ListItem("SalesOrderHeader", "SalesOrderHeader"));
            cbxEntity.Items.Add(new ListItem("SalesOrderHeaderSalesReason", "SalesOrderHeaderSalesReason"));
            cbxEntity.Items.Add(new ListItem("SalesPerson", "SalesPerson"));
            cbxEntity.Items.Add(new ListItem("SalesPersonQuotaHistory", "SalesPersonQuotaHistory"));
            cbxEntity.Items.Add(new ListItem("SalesReason", "SalesReason"));
            cbxEntity.Items.Add(new ListItem("SalesTaxRate", "SalesTaxRate"));
            cbxEntity.Items.Add(new ListItem("SalesTerritory", "SalesTerritory"));
            cbxEntity.Items.Add(new ListItem("SalesTerritoryHistory", "SalesTerritoryHistory"));
            cbxEntity.Items.Add(new ListItem("ShoppingCartItem", "ShoppingCartItem"));
            cbxEntity.Items.Add(new ListItem("SpecialOffer", "SpecialOffer"));
            cbxEntity.Items.Add(new ListItem("SpecialOfferProduct", "SpecialOfferProduct"));
            cbxEntity.Items.Add(new ListItem("Store", "Store"));
            cbxEntity.Items.Add(new ListItem("StoreContact", "StoreContact"));
            cbxEntity.Items.Add(new ListItem("CustomerList", "CustomerList"));
			cbxEntity.Items.Add(new ListItem("CustomerView", "CustomerView"));
			
		}
	}
		
	/// <summary>
	/// Handles the Click event of the btnListAll control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnListAll_Click(object sender, EventArgs e)
	{
		Response.Redirect("ListAll.aspx?ObjectName=" + cbxEntity.SelectedValue);
	}
	
	/// <summary>
    /// Handles the Click event of the btnViewReport control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewReport.aspx?ObjectName=" + cbxEntity.SelectedValue);
    }
	
	/// <summary>
    /// Handles the Click event of the btnListSubSet control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnListSubSet_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListSubSet.aspx?ObjectName=" + cbxEntity.SelectedValue);
    }
	
    /// <summary>
    /// Handles the Click event of the btnListReportSubSet control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnListReportSubSet_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListReportSubSet.aspx?ObjectName=" + cbxEntity.SelectedValue);
    }	
}
