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
/// Control class to search one or more 'PurchaseOrderDetail' entity instances
/// </summary>
public partial class Controls_SearchPurchaseOrderDetail : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["PurchaseOrderDetailID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(PurchaseOrderDetailFields.PurchaseOrderDetailID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		valueFromQueryString = queryString["PurchaseOrderID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(PurchaseOrderDetailFields.PurchaseOrderID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(PurchaseOrderDetailFields.PurchaseOrderDetailID==Convert.ChangeType(tbxPurchaseOrderDetailID.Text, typeof(System.Int32)));
		_filter.AddWithAnd(PurchaseOrderDetailFields.PurchaseOrderID==Convert.ChangeType(tbxPurchaseOrderID.Text, typeof(System.Int32)));
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
		if(chkEnableDueDate.Checked)
		{
			object fromValue = dtxDueDateMiFrom.Value;
			object toValue = dtxDueDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.DueDate, Convert.ToInt32(opDueDate.SelectedValue), chkNotDueDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLineTotal.Checked)
		{
			string fromValueAsString = tbxLineTotalMiFrom.Text;
			string toValueAsString = tbxLineTotalMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.LineTotal, Convert.ToInt32(opLineTotal.SelectedValue), chkNotLineTotal.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOrderQuantity.Checked)
		{
			string fromValueAsString = tbxOrderQuantityMiFrom.Text;
			string toValueAsString = tbxOrderQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.OrderQuantity, Convert.ToInt32(opOrderQuantity.SelectedValue), chkNotOrderQuantity.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePurchaseOrderDetailID.Checked)
		{
			string fromValueAsString = tbxPurchaseOrderDetailIDMiFrom.Text;
			string toValueAsString = tbxPurchaseOrderDetailIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.PurchaseOrderDetailID, Convert.ToInt32(opPurchaseOrderDetailID.SelectedValue), chkNotPurchaseOrderDetailID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePurchaseOrderID.Checked)
		{
			string fromValueAsString = tbxPurchaseOrderIDMiFrom.Text;
			string toValueAsString = tbxPurchaseOrderIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.PurchaseOrderID, Convert.ToInt32(opPurchaseOrderID.SelectedValue), chkNotPurchaseOrderID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableReceivedQuantity.Checked)
		{
			string fromValueAsString = tbxReceivedQuantityMiFrom.Text;
			string toValueAsString = tbxReceivedQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.ReceivedQuantity, Convert.ToInt32(opReceivedQuantity.SelectedValue), chkNotReceivedQuantity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableRejectedQuantity.Checked)
		{
			string fromValueAsString = tbxRejectedQuantityMiFrom.Text;
			string toValueAsString = tbxRejectedQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.RejectedQuantity, Convert.ToInt32(opRejectedQuantity.SelectedValue), chkNotRejectedQuantity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStockedQuantity.Checked)
		{
			string fromValueAsString = tbxStockedQuantityMiFrom.Text;
			string toValueAsString = tbxStockedQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.StockedQuantity, Convert.ToInt32(opStockedQuantity.SelectedValue), chkNotStockedQuantity.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderDetailFields.UnitPrice, Convert.ToInt32(opUnitPrice.SelectedValue), chkNotUnitPrice.Checked, 
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
