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
/// Control class to search one or more 'CustomerList' TypedList instances
/// </summary>
public partial class Controls_SearchCustomerList : System.Web.UI.UserControl, ISearchControl
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
		sortLookupDropDownList();
	}
	
	/// <summary>
	/// Creates a predicate expression filter based on the query string passed in. 
	/// </summary>
	/// <param name="queryString">The query string with PK field names and values.</param>
	/// <returns>a predicate expression with a filter on the pk fields and values.</returns>
	public PredicateExpression CreateFilter(NameValueCollection queryString)
	{
		PredicateExpression toReturn = new PredicateExpression();
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
		if(chkEnableAddressLine1.Checked)
		{
			string fromValueAsString = tbxAddressLine1MiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(AddressFields.AddressLine1, Convert.ToInt32(opAddressLine1.SelectedValue), chkNotAddressLine1.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableAddressLine2.Checked)
		{
			string fromValueAsString = tbxAddressLine2MiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(AddressFields.AddressLine2, Convert.ToInt32(opAddressLine2.SelectedValue), chkNotAddressLine2.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCity.Checked)
		{
			string fromValueAsString = tbxCityMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(AddressFields.City, Convert.ToInt32(opCity.SelectedValue), chkNotCity.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableName.Checked)
		{
			string fromValueAsString = tbxNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(AddressTypeFields.Name, Convert.ToInt32(opName.SelectedValue), chkNotName.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ContactFields.Title, Convert.ToInt32(opTitle.SelectedValue), chkNotTitle.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableFirstName.Checked)
		{
			string fromValueAsString = tbxFirstNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.FirstName, Convert.ToInt32(opFirstName.SelectedValue), chkNotFirstName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMiddleName.Checked)
		{
			string fromValueAsString = tbxMiddleNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.MiddleName, Convert.ToInt32(opMiddleName.SelectedValue), chkNotMiddleName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableLastName.Checked)
		{
			string fromValueAsString = tbxLastNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.LastName, Convert.ToInt32(opLastName.SelectedValue), chkNotLastName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSuffix.Checked)
		{
			string fromValueAsString = tbxSuffixMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.Suffix, Convert.ToInt32(opSuffix.SelectedValue), chkNotSuffix.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEmailAddress.Checked)
		{
			string fromValueAsString = tbxEmailAddressMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.EmailAddress, Convert.ToInt32(opEmailAddress.SelectedValue), chkNotEmailAddress.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEmailPromotion.Checked)
		{
			string fromValueAsString = tbxEmailPromotionMiFrom.Text;
			string toValueAsString = tbxEmailPromotionMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.EmailPromotion, Convert.ToInt32(opEmailPromotion.SelectedValue), chkNotEmailPromotion.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCountryRegionName.Checked)
		{
			string fromValueAsString = tbxCountryRegionNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(StateProvinceFields.Name, Convert.ToInt32(opCountryRegionName.SelectedValue), chkNotCountryRegionName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStateProvinceName.Checked)
		{
			string fromValueAsString = tbxStateProvinceNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(CountryRegionFields.Name, Convert.ToInt32(opStateProvinceName.SelectedValue), chkNotStateProvinceName.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableCustomerId.Checked)
		{
			string fromValueAsString = tbxCustomerIdMiFrom.Text;
			string toValueAsString = tbxCustomerIdMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(CustomerFields.CustomerID, Convert.ToInt32(opCustomerId.SelectedValue), chkNotCustomerId.Checked, 
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
  
	
	#region Class Property Declarations
	/// <summary>
	/// Gets the filter formulated with the values specified in the search control. Valid after SearchClicked has been raised. 
	/// </summary>
	public PredicateExpression Filter 
	{ 
		get { return _filter;}
	}
	
	/// <summary>
	/// Sets the flag for allowing single TypedList searches. If set to true, the search control will show PK fields and if applicable, UC fields.
	/// </summary>
	public bool AllowSingleEntitySearches
	{ 
		set
		{
			phSingleInstance.Visible=value;
		}
	}
	
	/// <summary>
	/// Sets the flag for allowing multi TypedList searches. If set to true, the search control will show fields to formulate a search over all fields, and 
	/// thus a filter which could lead to multiple results.
	/// </summary>
	public bool AllowMultiEntitySearches 
	{ 
		set
		{
			phMultiInstance.Visible=value;
		}
	}

	/// <summary>
	/// Method called at Page_Load to sort defined LookupDropDownList results
	/// </summary>
	public void sortLookupDropDownList()
	{
		
 	}
	#endregion
}
