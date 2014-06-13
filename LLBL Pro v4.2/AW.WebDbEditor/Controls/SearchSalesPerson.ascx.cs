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
/// Control class to search one or more 'SalesPerson' entity instances
/// </summary>
public partial class Controls_SearchSalesPerson : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["EmployeeID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SalesPersonFields.EmployeeID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(SalesPersonFields.EmployeeID==Convert.ChangeType(tbxEmployeeID.Text, typeof(System.Int32)));
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
		if(chkEnableBirthDate.Checked)
		{
			object fromValue = dtxBirthDateMiFrom.Value;
			object toValue = dtxBirthDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.BirthDate, Convert.ToInt32(opBirthDate.SelectedValue), chkNotBirthDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableBonus.Checked)
		{
			string fromValueAsString = tbxBonusMiFrom.Text;
			string toValueAsString = tbxBonusMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.Bonus, Convert.ToInt32(opBonus.SelectedValue), chkNotBonus.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCommissionPct.Checked)
		{
			string fromValueAsString = tbxCommissionPctMiFrom.Text;
			string toValueAsString = tbxCommissionPctMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.CommissionPct, Convert.ToInt32(opCommissionPct.SelectedValue), chkNotCommissionPct.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.ContactID, Convert.ToInt32(opContactID.SelectedValue), chkNotContactID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCurrentFlag.Checked)
		{
			object fromValue = chkCurrentFlagMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.IsCurrent, Convert.ToInt32(opCurrentFlag.SelectedValue), chkNotCurrentFlag.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEmployeeID.Checked)
		{
			string fromValueAsString = tbxEmployeeIDMiFrom.Text;
			string toValueAsString = tbxEmployeeIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.EmployeeID, Convert.ToInt32(opEmployeeID.SelectedValue), chkNotEmployeeID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableGender.Checked)
		{
			string fromValueAsString = tbxGenderMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.Gender, Convert.ToInt32(opGender.SelectedValue), chkNotGender.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableHireDate.Checked)
		{
			object fromValue = dtxHireDateMiFrom.Value;
			object toValue = dtxHireDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.HireDate, Convert.ToInt32(opHireDate.SelectedValue), chkNotHireDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLoginID.Checked)
		{
			string fromValueAsString = tbxLoginIDMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.LoginID, Convert.ToInt32(opLoginID.SelectedValue), chkNotLoginID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableManagerID.Checked)
		{
			string fromValueAsString = tbxManagerIDMiFrom.Text;
			string toValueAsString = tbxManagerIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.ManagerID, Convert.ToInt32(opManagerID.SelectedValue), chkNotManagerID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMaritalStatus.Checked)
		{
			string fromValueAsString = tbxMaritalStatusMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.MaritalStatus, Convert.ToInt32(opMaritalStatus.SelectedValue), chkNotMaritalStatus.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableNationalIdnumber.Checked)
		{
			string fromValueAsString = tbxNationalIdnumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.NationalIdnumber, Convert.ToInt32(opNationalIdnumber.SelectedValue), chkNotNationalIdnumber.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalariedFlag.Checked)
		{
			object fromValue = chkSalariedFlagMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.IsSalaried, Convert.ToInt32(opSalariedFlag.SelectedValue), chkNotSalariedFlag.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesLastYear.Checked)
		{
			string fromValueAsString = tbxSalesLastYearMiFrom.Text;
			string toValueAsString = tbxSalesLastYearMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.SalesLastYear, Convert.ToInt32(opSalesLastYear.SelectedValue), chkNotSalesLastYear.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSalesQuota.Checked)
		{
			string fromValueAsString = tbxSalesQuotaMiFrom.Text;
			string toValueAsString = tbxSalesQuotaMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.SalesQuota, Convert.ToInt32(opSalesQuota.SelectedValue), chkNotSalesQuota.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.SalesYtd, Convert.ToInt32(opSalesYtd.SelectedValue), chkNotSalesYtd.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSickLeaveHours.Checked)
		{
			string fromValueAsString = tbxSickLeaveHoursMiFrom.Text;
			string toValueAsString = tbxSickLeaveHoursMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.SickLeaveHours, Convert.ToInt32(opSickLeaveHours.SelectedValue), chkNotSickLeaveHours.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.TerritoryID, Convert.ToInt32(opTerritoryID.SelectedValue), chkNotTerritoryID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableTitle.Checked)
		{
			string fromValueAsString = tbxTitleMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.Title, Convert.ToInt32(opTitle.SelectedValue), chkNotTitle.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableVacationHours.Checked)
		{
			string fromValueAsString = tbxVacationHoursMiFrom.Text;
			string toValueAsString = tbxVacationHoursMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SalesPersonFields.VacationHours, Convert.ToInt32(opVacationHours.SelectedValue), chkNotVacationHours.Checked, 
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
