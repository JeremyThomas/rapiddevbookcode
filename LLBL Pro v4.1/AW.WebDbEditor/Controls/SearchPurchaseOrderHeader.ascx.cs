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
/// Control class to search one or more 'PurchaseOrderHeader' entity instances
/// </summary>
public partial class Controls_SearchPurchaseOrderHeader : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["PurchaseOrderID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(PurchaseOrderHeaderFields.PurchaseOrderID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(PurchaseOrderHeaderFields.PurchaseOrderID==Convert.ChangeType(tbxPurchaseOrderID.Text, typeof(System.Int32)));
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
		if(chkEnableEmployeeID.Checked)
		{
			string fromValueAsString = tbxEmployeeIDMiFrom.Text;
			string toValueAsString = tbxEmployeeIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.EmployeeID, Convert.ToInt32(opEmployeeID.SelectedValue), chkNotEmployeeID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableFreight.Checked)
		{
			string fromValueAsString = tbxFreightMiFrom.Text;
			string toValueAsString = tbxFreightMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.Freight, Convert.ToInt32(opFreight.SelectedValue), chkNotFreight.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.OrderDate, Convert.ToInt32(opOrderDate.SelectedValue), chkNotOrderDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePurchaseOrderID.Checked)
		{
			string fromValueAsString = tbxPurchaseOrderIDMiFrom.Text;
			string toValueAsString = tbxPurchaseOrderIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.PurchaseOrderID, Convert.ToInt32(opPurchaseOrderID.SelectedValue), chkNotPurchaseOrderID.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.RevisionNumber, Convert.ToInt32(opRevisionNumber.SelectedValue), chkNotRevisionNumber.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.ShipDate, Convert.ToInt32(opShipDate.SelectedValue), chkNotShipDate.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.ShipMethodID, Convert.ToInt32(opShipMethodID.SelectedValue), chkNotShipMethodID.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.Status, Convert.ToInt32(opStatus.SelectedValue), chkNotStatus.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.SubTotal, Convert.ToInt32(opSubTotal.SelectedValue), chkNotSubTotal.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.TaxAmt, Convert.ToInt32(opTaxAmt.SelectedValue), chkNotTaxAmt.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.TotalDue, Convert.ToInt32(opTotalDue.SelectedValue), chkNotTotalDue.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(PurchaseOrderHeaderFields.VendorID, Convert.ToInt32(opVendorID.SelectedValue), chkNotVendorID.Checked, 
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
