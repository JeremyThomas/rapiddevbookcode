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
/// Control class to search one or more 'ProductVendor' entity instances
/// </summary>
public partial class Controls_SearchProductVendor : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["ProductID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ProductVendorFields.ProductID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		valueFromQueryString = queryString["VendorID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ProductVendorFields.VendorID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(ProductVendorFields.ProductID==Convert.ChangeType(tbxProductID.Text, typeof(System.Int32)));
		_filter.AddWithAnd(ProductVendorFields.VendorID==Convert.ChangeType(tbxVendorID.Text, typeof(System.Int32)));
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
		if(chkEnableAverageLeadTime.Checked)
		{
			string fromValueAsString = tbxAverageLeadTimeMiFrom.Text;
			string toValueAsString = tbxAverageLeadTimeMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.AverageLeadTime, Convert.ToInt32(opAverageLeadTime.SelectedValue), chkNotAverageLeadTime.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLastReceiptCost.Checked)
		{
			string fromValueAsString = tbxLastReceiptCostMiFrom.Text;
			string toValueAsString = tbxLastReceiptCostMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.LastReceiptCost, Convert.ToInt32(opLastReceiptCost.SelectedValue), chkNotLastReceiptCost.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLastReceiptDate.Checked)
		{
			object fromValue = dtxLastReceiptDateMiFrom.Value;
			object toValue = dtxLastReceiptDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.LastReceiptDate, Convert.ToInt32(opLastReceiptDate.SelectedValue), chkNotLastReceiptDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMaxOrderQuantity.Checked)
		{
			string fromValueAsString = tbxMaxOrderQuantityMiFrom.Text;
			string toValueAsString = tbxMaxOrderQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.MaxOrderQuantity, Convert.ToInt32(opMaxOrderQuantity.SelectedValue), chkNotMaxOrderQuantity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMinOrderQuantity.Checked)
		{
			string fromValueAsString = tbxMinOrderQuantityMiFrom.Text;
			string toValueAsString = tbxMinOrderQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.MinOrderQuantity, Convert.ToInt32(opMinOrderQuantity.SelectedValue), chkNotMinOrderQuantity.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOnOrderQuantity.Checked)
		{
			string fromValueAsString = tbxOnOrderQuantityMiFrom.Text;
			string toValueAsString = tbxOnOrderQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.OnOrderQuantity, Convert.ToInt32(opOnOrderQuantity.SelectedValue), chkNotOnOrderQuantity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductID.Checked)
		{
			string fromValueAsString = tbxProductIDMiFrom.Text;
			string toValueAsString = tbxProductIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStandardPrice.Checked)
		{
			string fromValueAsString = tbxStandardPriceMiFrom.Text;
			string toValueAsString = tbxStandardPriceMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.StandardPrice, Convert.ToInt32(opStandardPrice.SelectedValue), chkNotStandardPrice.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableUnitMeasureCode.Checked)
		{
			string fromValueAsString = tbxUnitMeasureCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.UnitMeasureCode, Convert.ToInt32(opUnitMeasureCode.SelectedValue), chkNotUnitMeasureCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableVendorID.Checked)
		{
			string fromValueAsString = tbxVendorIDMiFrom.Text;
			string toValueAsString = tbxVendorIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductVendorFields.VendorID, Convert.ToInt32(opVendorID.SelectedValue), chkNotVendorID.Checked, 
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
