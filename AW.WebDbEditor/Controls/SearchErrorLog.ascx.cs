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
/// Control class to search one or more 'ErrorLog' entity instances
/// </summary>
public partial class Controls_SearchErrorLog : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["ErrorLogID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ErrorLogFields.ErrorLogID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(ErrorLogFields.ErrorLogID==Convert.ChangeType(tbxErrorLogID.Text, typeof(System.Int32)));
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
		if(chkEnableErrorLine.Checked)
		{
			string fromValueAsString = tbxErrorLineMiFrom.Text;
			string toValueAsString = tbxErrorLineMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorLine, Convert.ToInt32(opErrorLine.SelectedValue), chkNotErrorLine.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorLogID.Checked)
		{
			string fromValueAsString = tbxErrorLogIDMiFrom.Text;
			string toValueAsString = tbxErrorLogIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorLogID, Convert.ToInt32(opErrorLogID.SelectedValue), chkNotErrorLogID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorMessage.Checked)
		{
			string fromValueAsString = tbxErrorMessageMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorMessage, Convert.ToInt32(opErrorMessage.SelectedValue), chkNotErrorMessage.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorNumber.Checked)
		{
			string fromValueAsString = tbxErrorNumberMiFrom.Text;
			string toValueAsString = tbxErrorNumberMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorNumber, Convert.ToInt32(opErrorNumber.SelectedValue), chkNotErrorNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorProcedure.Checked)
		{
			string fromValueAsString = tbxErrorProcedureMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorProcedure, Convert.ToInt32(opErrorProcedure.SelectedValue), chkNotErrorProcedure.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorSeverity.Checked)
		{
			string fromValueAsString = tbxErrorSeverityMiFrom.Text;
			string toValueAsString = tbxErrorSeverityMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorSeverity, Convert.ToInt32(opErrorSeverity.SelectedValue), chkNotErrorSeverity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorState.Checked)
		{
			string fromValueAsString = tbxErrorStateMiFrom.Text;
			string toValueAsString = tbxErrorStateMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorState, Convert.ToInt32(opErrorState.SelectedValue), chkNotErrorState.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableErrorTime.Checked)
		{
			object fromValue = dtxErrorTimeMiFrom.Value;
			object toValue = dtxErrorTimeMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.ErrorTime, Convert.ToInt32(opErrorTime.SelectedValue), chkNotErrorTime.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableUserName.Checked)
		{
			string fromValueAsString = tbxUserNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ErrorLogFields.UserName, Convert.ToInt32(opUserName.SelectedValue), chkNotUserName.Checked, 
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
