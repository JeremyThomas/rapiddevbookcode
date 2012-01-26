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
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Data;

public partial class Controls_ListBillOfMaterialInstances : System.Web.UI.UserControl, IListControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
		PrefetchPath path = new PrefetchPath((int)EntityType.BillOfMaterialEntity);
		_BillOfMaterialDS.PrefetchPathToUse = path;
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
	
	
	/// <summary>
	/// Handles the Click event of the btnAddNew control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnAddNew_Click(object sender, EventArgs e)
	{
		object additionalFilters = ViewState["additionalFilters"];
		string additionalFiltersAsString = string.Empty;
		if(additionalFilters != null)
		{
			additionalFiltersAsString = (string)additionalFilters;
		}
		Response.Redirect("~/AddNew.aspx?EntityType=" + (int)EntityType.BillOfMaterialEntity + additionalFiltersAsString);
	}
	
	
	
	/// </summary>
    /// <param name="sender">The source of the event</param>
    /// <param name="e">The EventArgs instance containing the event arguments</param>
    protected void btnExportToExcel_Click(object sender, EventArgs e)
    {
        // hide the 'View' column
		theGrid.Columns.RemoveAt(0);
	
		// hide the 'Edit' column
        theGrid.Columns.RemoveAt(0);

		// hide the 'Delete' column
        theGrid.Columns.RemoveAt(0);
		        

        // get all rows
        theGrid.AllowPaging = false;
        theGrid.DataBind();
		
		// export to excel
        GridViewExportUtils.Export("BillOfMaterial.xls", theGrid);
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
			case "EditExisting":
			case "ViewExisting":
				break;
			default:
				// apparently another command, return
				return;
		}
		int index = Convert.ToInt32(e.CommandArgument);
		BillOfMaterialEntity selectedEntity = (BillOfMaterialEntity)_BillOfMaterialDS.EntityCollection[index];
		StringBuilder pkFieldsAndValues = new StringBuilder();
		pkFieldsAndValues.AppendFormat("&BillOfMaterialsID={0}", selectedEntity.BillOfMaterialsID);
		switch(e.CommandName)
		{
			case "EditExisting":
				Response.Redirect("~/EditExisting.aspx?EntityType=" + (int)EntityType.BillOfMaterialEntity + pkFieldsAndValues.ToString());
				break;
			case "ViewExisting":
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.BillOfMaterialEntity + pkFieldsAndValues.ToString());
				break;
		}
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
		IPredicateExpression dsFilter;
		switch(containingEntity.LLBLGenProEntityName)
		{
			case "ProductEntity":
				switch(name)
				{
					case "BillOfAssemblyMaterials":
						dsFilter = new PredicateExpression();
						dsFilter.AddWithAnd(BillOfMaterialFields.ProductAssemblyID == ((ProductEntity)containingEntity).ProductID);
						_BillOfMaterialDS.FilterToUse = dsFilter;
						ViewState["additionalFilters"] = "&ProductAssemblyID=" + 
								((ProductEntity)containingEntity).ProductID +
								"&20FkField=ProductAssemblyID";
						break;
					case "BillOfComponentMaterials":
						dsFilter = new PredicateExpression();
						dsFilter.AddWithAnd(BillOfMaterialFields.ComponentID == ((ProductEntity)containingEntity).ProductID);
						_BillOfMaterialDS.FilterToUse = dsFilter;
						ViewState["additionalFilters"] = "&ComponentID=" + 
								((ProductEntity)containingEntity).ProductID +
								"&20FkField=ComponentID";
						break;
					default:
						break;
				}
				break;
			case "UnitMeasureEntity":
				switch(name)
				{
					case "BillOfMaterials":
						dsFilter = new PredicateExpression();
						dsFilter.AddWithAnd(BillOfMaterialFields.UnitMeasureCode == ((UnitMeasureEntity)containingEntity).UnitMeasureCode);
						_BillOfMaterialDS.FilterToUse = dsFilter;
						ViewState["additionalFilters"] = "&UnitMeasureCode=" + 
								((UnitMeasureEntity)containingEntity).UnitMeasureCode +
								"&20FkField=UnitMeasureCode";
						break;
					default:
						break;
				}
				break;
			default:
				break;
		}
	}


	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
	public IPredicateExpression FilterToUse 
	{
		set { _BillOfMaterialDS.FilterToUse = value; }
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


	/// <summary>
	/// Sets the flag to show the AddNew button or not. The AddNew button is hidden when the data in the control is the data of an m:n relation.
	/// </summary>
	public bool ShowAddNewButton 
	{
		set 
		{ 

			phAddNewButton.Visible = value; 

		}
	}	
}