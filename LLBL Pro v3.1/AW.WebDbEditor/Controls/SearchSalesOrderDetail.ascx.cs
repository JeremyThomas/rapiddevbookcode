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
/// Control class to search one or more 'SalesOrderDetail' entity instances
/// </summary>
public partial class Controls_SearchSalesOrderDetail : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["SalesOrderDetailID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SalesOrderDetailFields.SalesOrderDetailID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		valueFromQueryString = queryString["SalesOrderID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SalesOrderDetailFields.SalesOrderID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(SalesOrderDetailFields.SalesOrderDetailID==Convert.ChangeType(tbxSalesOrderDetailID.Text, typeof(System.Int32)));
		_filter.AddWithAnd(SalesOrderDetailFields.SalesOrderID==Convert.ChangeType(tbxSalesOrderID.Text, typeof(System.Int32)));
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
		if(chkEnableCarrierTrackingNumber.Checked)
		{
			string fromValueAsString = tbxCarrierTrackingNumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.CarrierTrackingNumber, Convert.ToInt32(opCarrierTrackingNumber.SelectedValue), chkNotCarrierTrackingNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLineTotal.Checked)
		{
			string fromValueAsString = tbxLineTotalMiFrom.Text;
			string toValueAsString = tbxLineTotalMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.LineTotal, Convert.ToInt32(opLineTotal.SelectedValue), chkNotLineTotal.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOrderQty.Checked)
		{
			string fromValueAsString = tbxOrderQtyMiFrom.Text;
			string toValueAsString = tbxOrderQtyMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.OrderQty, Convert.ToInt32(opOrderQty.SelectedValue), chkNotOrderQty.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesOrderDetailID.Checked)
		{
			string fromValueAsString = tbxSalesOrderDetailIDMiFrom.Text;
			string toValueAsString = tbxSalesOrderDetailIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.SalesOrderDetailID, Convert.ToInt32(opSalesOrderDetailID.SelectedValue), chkNotSalesOrderDetailID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesOrderID.Checked)
		{
			string fromValueAsString = tbxSalesOrderIDMiFrom.Text;
			string toValueAsString = tbxSalesOrderIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.SalesOrderID, Convert.ToInt32(opSalesOrderID.SelectedValue), chkNotSalesOrderID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSpecialOfferID.Checked)
		{
			string fromValueAsString = tbxSpecialOfferIDMiFrom.Text;
			string toValueAsString = tbxSpecialOfferIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.SpecialOfferID, Convert.ToInt32(opSpecialOfferID.SelectedValue), chkNotSpecialOfferID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableUnitPrice.Checked)
		{
			string fromValueAsString = tbxUnitPriceMiFrom.Text;
			string toValueAsString = tbxUnitPriceMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.UnitPrice, Convert.ToInt32(opUnitPrice.SelectedValue), chkNotUnitPrice.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableUnitPriceDiscount.Checked)
		{
			string fromValueAsString = tbxUnitPriceDiscountMiFrom.Text;
			string toValueAsString = tbxUnitPriceDiscountMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderDetailFields.UnitPriceDiscount, Convert.ToInt32(opUnitPriceDiscount.SelectedValue), chkNotUnitPriceDiscount.Checked, 
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
