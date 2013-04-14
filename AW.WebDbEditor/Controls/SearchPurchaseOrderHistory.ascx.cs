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
/// Control class to search one or more 'PurchaseOrderHistory' entity instances
/// </summary>
public partial class Controls_SearchPurchaseOrderHistory : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["TransactionID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(PurchaseOrderHistoryFields.TransactionID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(PurchaseOrderHistoryFields.TransactionID==Convert.ChangeType(tbxTransactionID.Text, typeof(System.Int32)));
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
		if(chkEnableActualCost.Checked)
		{
			string fromValueAsString = tbxActualCostMiFrom.Text;
			string toValueAsString = tbxActualCostMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.ActualCost, Convert.ToInt32(opActualCost.SelectedValue), chkNotActualCost.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductID.Checked)
		{
			string fromValueAsString = tbxProductIDMiFrom.Text;
			string toValueAsString = tbxProductIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableQuantity.Checked)
		{
			string fromValueAsString = tbxQuantityMiFrom.Text;
			string toValueAsString = tbxQuantityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.Quantity, Convert.ToInt32(opQuantity.SelectedValue), chkNotQuantity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableReferenceOrderID.Checked)
		{
			string fromValueAsString = tbxReferenceOrderIDMiFrom.Text;
			string toValueAsString = tbxReferenceOrderIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.ReferenceOrderID, Convert.ToInt32(opReferenceOrderID.SelectedValue), chkNotReferenceOrderID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableReferenceOrderLineID.Checked)
		{
			string fromValueAsString = tbxReferenceOrderLineIDMiFrom.Text;
			string toValueAsString = tbxReferenceOrderLineIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.ReferenceOrderLineID, Convert.ToInt32(opReferenceOrderLineID.SelectedValue), chkNotReferenceOrderLineID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTransactionDate.Checked)
		{
			object fromValue = dtxTransactionDateMiFrom.Value;
			object toValue = dtxTransactionDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.TransactionDate, Convert.ToInt32(opTransactionDate.SelectedValue), chkNotTransactionDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTransactionID.Checked)
		{
			string fromValueAsString = tbxTransactionIDMiFrom.Text;
			string toValueAsString = tbxTransactionIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.TransactionID, Convert.ToInt32(opTransactionID.SelectedValue), chkNotTransactionID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTransactionType.Checked)
		{
			string fromValueAsString = tbxTransactionTypeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHistoryFields.TransactionType, Convert.ToInt32(opTransactionType.SelectedValue), chkNotTransactionType.Checked, 
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
