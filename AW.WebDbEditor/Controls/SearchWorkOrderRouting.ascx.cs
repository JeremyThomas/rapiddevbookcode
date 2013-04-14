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
/// Control class to search one or more 'WorkOrderRouting' entity instances
/// </summary>
public partial class Controls_SearchWorkOrderRouting : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["OperationSequence"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(WorkOrderRoutingFields.OperationSequence==Convert.ChangeType(valueFromQueryString, typeof(System.Int16)));
		}
		valueFromQueryString = queryString["ProductID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(WorkOrderRoutingFields.ProductID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
		}
		valueFromQueryString = queryString["WorkOrderID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(WorkOrderRoutingFields.WorkOrderID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(WorkOrderRoutingFields.OperationSequence==Convert.ChangeType(tbxOperationSequence.Text, typeof(System.Int16)));
		_filter.AddWithAnd(WorkOrderRoutingFields.ProductID==Convert.ChangeType(tbxProductID.Text, typeof(System.Int32)));
		_filter.AddWithAnd(WorkOrderRoutingFields.WorkOrderID==Convert.ChangeType(tbxWorkOrderID.Text, typeof(System.Int32)));
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
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ActualCost, Convert.ToInt32(opActualCost.SelectedValue), chkNotActualCost.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableActualEndDate.Checked)
		{
			object fromValue = dtxActualEndDateMiFrom.Value;
			object toValue = dtxActualEndDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ActualEndDate, Convert.ToInt32(opActualEndDate.SelectedValue), chkNotActualEndDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableActualResourceHrs.Checked)
		{
			string fromValueAsString = tbxActualResourceHrsMiFrom.Text;
			string toValueAsString = tbxActualResourceHrsMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ActualResourceHrs, Convert.ToInt32(opActualResourceHrs.SelectedValue), chkNotActualResourceHrs.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableActualStartDate.Checked)
		{
			object fromValue = dtxActualStartDateMiFrom.Value;
			object toValue = dtxActualStartDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ActualStartDate, Convert.ToInt32(opActualStartDate.SelectedValue), chkNotActualStartDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLocationID.Checked)
		{
			string fromValueAsString = tbxLocationIDMiFrom.Text;
			string toValueAsString = tbxLocationIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.LocationID, Convert.ToInt32(opLocationID.SelectedValue), chkNotLocationID.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableOperationSequence.Checked)
		{
			string fromValueAsString = tbxOperationSequenceMiFrom.Text;
			string toValueAsString = tbxOperationSequenceMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.OperationSequence, Convert.ToInt32(opOperationSequence.SelectedValue), chkNotOperationSequence.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePlannedCost.Checked)
		{
			string fromValueAsString = tbxPlannedCostMiFrom.Text;
			string toValueAsString = tbxPlannedCostMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.PlannedCost, Convert.ToInt32(opPlannedCost.SelectedValue), chkNotPlannedCost.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableScheduledEndDate.Checked)
		{
			object fromValue = dtxScheduledEndDateMiFrom.Value;
			object toValue = dtxScheduledEndDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ScheduledEndDate, Convert.ToInt32(opScheduledEndDate.SelectedValue), chkNotScheduledEndDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableScheduledStartDate.Checked)
		{
			object fromValue = dtxScheduledStartDateMiFrom.Value;
			object toValue = dtxScheduledStartDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.ScheduledStartDate, Convert.ToInt32(opScheduledStartDate.SelectedValue), chkNotScheduledStartDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableWorkOrderID.Checked)
		{
			string fromValueAsString = tbxWorkOrderIDMiFrom.Text;
			string toValueAsString = tbxWorkOrderIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(WorkOrderRoutingFields.WorkOrderID, Convert.ToInt32(opWorkOrderID.SelectedValue), chkNotWorkOrderID.Checked, 
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
