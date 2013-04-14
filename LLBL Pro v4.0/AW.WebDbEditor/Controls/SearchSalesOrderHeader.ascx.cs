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
/// Control class to search one or more 'SalesOrderHeader' entity instances
/// </summary>
public partial class Controls_SearchSalesOrderHeader : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["SalesOrderID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SalesOrderHeaderFields.SalesOrderID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(SalesOrderHeaderFields.SalesOrderID==Convert.ChangeType(tbxSalesOrderID.Text, typeof(System.Int32)));
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
		if(chkEnableAccountNumber.Checked)
		{
			string fromValueAsString = tbxAccountNumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.AccountNumber, Convert.ToInt32(opAccountNumber.SelectedValue), chkNotAccountNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableBillToAddressID.Checked)
		{
			string fromValueAsString = tbxBillToAddressIDMiFrom.Text;
			string toValueAsString = tbxBillToAddressIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.BillToAddressID, Convert.ToInt32(opBillToAddressID.SelectedValue), chkNotBillToAddressID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableComment.Checked)
		{
			string fromValueAsString = tbxCommentMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.Comment, Convert.ToInt32(opComment.SelectedValue), chkNotComment.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableContactID.Checked)
		{
			string fromValueAsString = tbxContactIDMiFrom.Text;
			string toValueAsString = tbxContactIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.ContactID, Convert.ToInt32(opContactID.SelectedValue), chkNotContactID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCreditCardApprovalCode.Checked)
		{
			string fromValueAsString = tbxCreditCardApprovalCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.CreditCardApprovalCode, Convert.ToInt32(opCreditCardApprovalCode.SelectedValue), chkNotCreditCardApprovalCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCreditCardID.Checked)
		{
			string fromValueAsString = tbxCreditCardIDMiFrom.Text;
			string toValueAsString = tbxCreditCardIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.CreditCardID, Convert.ToInt32(opCreditCardID.SelectedValue), chkNotCreditCardID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCurrencyRateID.Checked)
		{
			string fromValueAsString = tbxCurrencyRateIDMiFrom.Text;
			string toValueAsString = tbxCurrencyRateIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.CurrencyRateID, Convert.ToInt32(opCurrencyRateID.SelectedValue), chkNotCurrencyRateID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCustomerID.Checked)
		{
			string fromValueAsString = tbxCustomerIDMiFrom.Text;
			string toValueAsString = tbxCustomerIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.CustomerID, Convert.ToInt32(opCustomerID.SelectedValue), chkNotCustomerID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableDueDate.Checked)
		{
			object fromValue = dtxDueDateMiFrom.Value;
			object toValue = dtxDueDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.DueDate, Convert.ToInt32(opDueDate.SelectedValue), chkNotDueDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableFreight.Checked)
		{
			string fromValueAsString = tbxFreightMiFrom.Text;
			string toValueAsString = tbxFreightMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.Freight, Convert.ToInt32(opFreight.SelectedValue), chkNotFreight.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOnlineOrderFlag.Checked)
		{
			object fromValue = chkOnlineOrderFlagMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.OnlineOrderFlag, Convert.ToInt32(opOnlineOrderFlag.SelectedValue), chkNotOnlineOrderFlag.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOrderDate.Checked)
		{
			object fromValue = dtxOrderDateMiFrom.Value;
			object toValue = dtxOrderDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.OrderDate, Convert.ToInt32(opOrderDate.SelectedValue), chkNotOrderDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePurchaseOrderNumber.Checked)
		{
			string fromValueAsString = tbxPurchaseOrderNumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.PurchaseOrderNumber, Convert.ToInt32(opPurchaseOrderNumber.SelectedValue), chkNotPurchaseOrderNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableRevisionNumber.Checked)
		{
			string fromValueAsString = tbxRevisionNumberMiFrom.Text;
			string toValueAsString = tbxRevisionNumberMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.RevisionNumber, Convert.ToInt32(opRevisionNumber.SelectedValue), chkNotRevisionNumber.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.SalesOrderID, Convert.ToInt32(opSalesOrderID.SelectedValue), chkNotSalesOrderID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesOrderNumber.Checked)
		{
			string fromValueAsString = tbxSalesOrderNumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.SalesOrderNumber, Convert.ToInt32(opSalesOrderNumber.SelectedValue), chkNotSalesOrderNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesPersonID.Checked)
		{
			string fromValueAsString = tbxSalesPersonIDMiFrom.Text;
			string toValueAsString = tbxSalesPersonIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.SalesPersonID, Convert.ToInt32(opSalesPersonID.SelectedValue), chkNotSalesPersonID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableShipDate.Checked)
		{
			object fromValue = dtxShipDateMiFrom.Value;
			object toValue = dtxShipDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.ShipDate, Convert.ToInt32(opShipDate.SelectedValue), chkNotShipDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableShipMethodID.Checked)
		{
			string fromValueAsString = tbxShipMethodIDMiFrom.Text;
			string toValueAsString = tbxShipMethodIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.ShipMethodID, Convert.ToInt32(opShipMethodID.SelectedValue), chkNotShipMethodID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableShipToAddressID.Checked)
		{
			string fromValueAsString = tbxShipToAddressIDMiFrom.Text;
			string toValueAsString = tbxShipToAddressIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.ShipToAddressID, Convert.ToInt32(opShipToAddressID.SelectedValue), chkNotShipToAddressID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStatus.Checked)
		{
			string fromValueAsString = tbxStatusMiFrom.Text;
			string toValueAsString = tbxStatusMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.Status, Convert.ToInt32(opStatus.SelectedValue), chkNotStatus.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSubTotal.Checked)
		{
			string fromValueAsString = tbxSubTotalMiFrom.Text;
			string toValueAsString = tbxSubTotalMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.SubTotal, Convert.ToInt32(opSubTotal.SelectedValue), chkNotSubTotal.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTaxAmt.Checked)
		{
			string fromValueAsString = tbxTaxAmtMiFrom.Text;
			string toValueAsString = tbxTaxAmtMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.TaxAmt, Convert.ToInt32(opTaxAmt.SelectedValue), chkNotTaxAmt.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.TerritoryID, Convert.ToInt32(opTerritoryID.SelectedValue), chkNotTerritoryID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTotalDue.Checked)
		{
			string fromValueAsString = tbxTotalDueMiFrom.Text;
			string toValueAsString = tbxTotalDueMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesOrderHeaderFields.TotalDue, Convert.ToInt32(opTotalDue.SelectedValue), chkNotTotalDue.Checked, 
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
