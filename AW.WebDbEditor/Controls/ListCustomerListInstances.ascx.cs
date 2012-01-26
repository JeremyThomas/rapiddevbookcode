	
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.TypedListClasses;
using AW.Data.HelperClasses;
using AW.Data;

public partial class Controls_ListCustomerListInstances : System.Web.UI.UserControl, IListControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}


    /// <summary>
	/// Handles the Click event of the btnHome control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnHome_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}
			
	
	/// </summary>
    /// <param name="sender">The source of the event</param>
    /// <param name="e">The EventArgs instance containing the event arguments</param>
    protected void btnExportToExcel_Click(object sender, EventArgs e)
    {        
        // get all rows
        theGrid.AllowPaging = false;
        theGrid.DataBind();
		
		// export to excel
        GridViewExportUtils.Export( "CustomerList.xls", theGrid);
    }

    /// <summary>
    /// Handles the Click event of the btnDetails control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnDetails_Click(object sender, EventArgs e)
    {
        phDetails.Visible = false;
        phDetailsButton.Visible = false;
    }
			
	/// <summary>
	/// Handles the RowCommand event of the theGrid control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewCommandEventArgs"/> instance containing the event data.</param>
	protected void theGrid_RowCommand(object sender, GridViewCommandEventArgs e)
	{
		switch(e.CommandName)
		{
			case "ViewExisting":
				break;
			default:
				// apparently another command, return
				return;
		}
		int index = Convert.ToInt32(e.CommandArgument);
		CustomerListTypedList selectedTypedList = (CustomerListTypedList)_CustomerListDS.TypedList;
        CustomerListRow selectedRow = selectedTypedList[index];

		vlblAddressLine1.Text = selectedRow.AddressLine1.ToString();
		vlblAddressLine2.Text = selectedRow.AddressLine2.ToString();
		vlblCity.Text = selectedRow.City.ToString();
		vlblName.Text = selectedRow.Name.ToString();
		vlblTitle.Text = selectedRow.Title.ToString();
		vlblFirstName.Text = selectedRow.FirstName.ToString();
		vlblMiddleName.Text = selectedRow.MiddleName.ToString();
		vlblLastName.Text = selectedRow.LastName.ToString();
		vlblSuffix.Text = selectedRow.Suffix.ToString();
		vlblEmailAddress.Text = selectedRow.EmailAddress.ToString();
		vlblEmailPromotion.Text = selectedRow.EmailPromotion.ToString();
		vlblCountryRegionName.Text = selectedRow.CountryRegionName.ToString();
		vlblStateProvinceName.Text = selectedRow.StateProvinceName.ToString();
		vlnkCustomerId.NavigateUrl = "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CustomerEntity).ToString() + "&CustomerID=" + selectedRow.CustomerId; 
				vlnkCustomerId.Text = selectedRow.CustomerId.ToString();

        phDetails.Visible = true;
        phDetailsButton.Visible = true;		
	}


	/// <summary>
	/// Sets the containing entity for the entities enlisted in this control. When a particular containing entity is set (e.g. 'Customer' for orders), the
	/// set entity is used to obtain the filter for the entities to show, and FilterToUse is then overruled. The entity is also used to produce FK field values
	/// for AddNew, so for example when a list of orders is shown, which are related to customer, the AddNew button should make the order's AddNew form preselect
	/// the Customer.
	/// </summary>
	/// <param name="containingEntity">The containing entity instance</param>
	/// <param name="name">the field name mapped on the relation from the containing entity with this entity</param>
	public void SetContainingEntity(IEntityCore containingEntity, string name)
	{		
	}


	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
		public IPredicateExpression FilterToUse 
	{
		set { _CustomerListDS.FilterToUse = value; }
	}

    /// <summary>
    /// Ask the Grid to reload its data
    /// </summary>
    public void GridDataBind()
    {
        theGrid.DataBind();
    }

	/// <summary>
	/// Sets the flag to show the Home button or not. The home button is hidden when the control is shown inside a form with other information.
	/// </summary>
	public bool ShowHomeButton 
	{
		set { phHomeButton.Visible = value; }
	}	
	
}