using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.HelperClasses;

/// <summary>
/// Control class to search one or more 'SalesTerritory' entity instances
/// </summary>
public partial class Controls_SearchSalesTerritory : System.Web.UI.UserControl, ISearchControl
{
	#region Events
	/// <summary>
	/// Event which is raised when the user clicked a search button. After this event, the 'Filter' property is valid.
	/// </summary>
	public event EventHandler SearchClicked;
	#endregion
	
	#region Class Member Declarations
	private PredicateExpression _filter;
	#endregion
		
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{
        if (!IsPostBack)
        {
            sortLookupDropDownList();
        }
	}
	
	/// <summary>
	/// Creates a predicate expression filter based on the query string passed in. 
	/// </summary>
	/// <param name="queryString">The query string with PK field names and values.</param>
	/// <returns>a predicate expression with a filter on the pk fields and values.</returns>
	public PredicateExpression CreateFilter(NameValueCollection queryString)
	{
		PredicateExpression toReturn = new PredicateExpression();
		string valueFromQueryString = null;
		valueFromQueryString = queryString["TerritoryID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SalesTerritoryFields.TerritoryID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		return toReturn;
	}

	/// <summary>
	/// Handles the Click event of the btnCancel control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnCancel_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}


	/// <summary>
	/// Handles the Click event of the btnSearchPK control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchPk_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		_filter = new PredicateExpression();
		_filter.AddWithAnd(SalesTerritoryFields.TerritoryID==Convert.ChangeType(tbxTerritoryID.Text, typeof(System.Int32)));
		if((SearchClicked!=null) && (_filter.Count>0))
		{
			SearchClicked(this, new EventArgs());
		}
	}


	/// <summary>
	/// Handles the Click event of the btnSearchSubSet control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnSearchSubSet_Click(object sender, EventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}

		_filter = new PredicateExpression();
		IPredicate toAdd = null;
		if(chkEnableCostLastYear.Checked)
		{
			string fromValueAsString = tbxCostLastYearMiFrom.Text;
			string toValueAsString = tbxCostLastYearMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.CostLastYear, Convert.ToInt32(opCostLastYear.SelectedValue), chkNotCostLastYear.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCostYtd.Checked)
		{
			string fromValueAsString = tbxCostYtdMiFrom.Text;
			string toValueAsString = tbxCostYtdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.CostYtd, Convert.ToInt32(opCostYtd.SelectedValue), chkNotCostYtd.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCountryRegionCode.Checked)
		{
			string fromValueAsString = tbxCountryRegionCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.CountryRegionCode, Convert.ToInt32(opCountryRegionCode.SelectedValue), chkNotCountryRegionCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableGroup.Checked)
		{
			string fromValueAsString = tbxGroupMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.Group, Convert.ToInt32(opGroup.SelectedValue), chkNotGroup.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableModifiedDate.Checked)
		{
			object fromValue = dtxModifiedDateMiFrom.Value;
			object toValue = dtxModifiedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableName.Checked)
		{
			string fromValueAsString = tbxNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.Name, Convert.ToInt32(opName.SelectedValue), chkNotName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableRowguid.Checked)
		{
			string fromValueAsString = tbxRowguidMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesLastYear.Checked)
		{
			string fromValueAsString = tbxSalesLastYearMiFrom.Text;
			string toValueAsString = tbxSalesLastYearMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.SalesLastYear, Convert.ToInt32(opSalesLastYear.SelectedValue), chkNotSalesLastYear.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesYtd.Checked)
		{
			string fromValueAsString = tbxSalesYtdMiFrom.Text;
			string toValueAsString = tbxSalesYtdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.SalesYtd, Convert.ToInt32(opSalesYtd.SelectedValue), chkNotSalesYtd.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTerritoryID.Checked)
		{
			string fromValueAsString = tbxTerritoryIDMiFrom.Text;
			string toValueAsString = tbxTerritoryIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesTerritoryFields.TerritoryID, Convert.ToInt32(opTerritoryID.SelectedValue), chkNotTerritoryID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(SearchClicked != null)
		{
			SearchClicked(this, new EventArgs());
		}
	}
  
	/// <summary>
	/// Method called at Page_Load to sort defined LookupDropDownList results
	/// </summary>
	private void sortLookupDropDownList()
	{
		
 	}
	
	#region Class Property Declarations
	/// <summary>
	/// Gets the filter formulated with the values specified in the search control. Valid after SearchClicked has been raised. 
	/// </summary>
	public PredicateExpression Filter 
	{ 
		get { return _filter;}
	}
	
	/// <summary>
	/// Sets the flag for allowing single entity searches. If set to true, the search control will show PK fields and if applicable, UC fields.
	/// </summary>
	public bool AllowSingleEntitySearches
	{ 
		set
		{
			phSingleInstance.Visible=value;
		}
	}
	
	/// <summary>
	/// Sets the flag for allowing multi entity searches. If set to true, the search control will show fields to formulate a search over all fields, and 
	/// thus a filter which could lead to multiple results.
	/// </summary>
	public bool AllowMultiEntitySearches 
	{ 
		set
		{
			phMultiInstance.Visible=value;
		}
	}
	#endregion
}
