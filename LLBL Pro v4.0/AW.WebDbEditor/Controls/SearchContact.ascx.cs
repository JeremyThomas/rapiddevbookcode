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
/// Control class to search one or more 'Contact' entity instances
/// </summary>
public partial class Controls_SearchContact : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["ContactID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ContactFields.ContactID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(ContactFields.ContactID==Convert.ChangeType(tbxContactID.Text, typeof(System.Int32)));
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
		if(chkEnableAdditionalContactInfo.Checked)
		{
			string fromValueAsString = tbxAdditionalContactInfoMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.AdditionalContactInfo, Convert.ToInt32(opAdditionalContactInfo.SelectedValue), chkNotAdditionalContactInfo.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ContactFields.ContactID, Convert.ToInt32(opContactID.SelectedValue), chkNotContactID.Checked, 
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
		
		if(chkEnableModifiedDate.Checked)
		{
			object fromValue = dtxModifiedDateMiFrom.Value;
			object toValue = dtxModifiedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableNameStyle.Checked)
		{
			object fromValue = chkNameStyleMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.NameStyle, Convert.ToInt32(opNameStyle.SelectedValue), chkNotNameStyle.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePasswordHash.Checked)
		{
			string fromValueAsString = tbxPasswordHashMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.PasswordHash, Convert.ToInt32(opPasswordHash.SelectedValue), chkNotPasswordHash.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePasswordSalt.Checked)
		{
			string fromValueAsString = tbxPasswordSaltMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.PasswordSalt, Convert.ToInt32(opPasswordSalt.SelectedValue), chkNotPasswordSalt.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnablePhone.Checked)
		{
			string fromValueAsString = tbxPhoneMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ContactFields.Phone, Convert.ToInt32(opPhone.SelectedValue), chkNotPhone.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ContactFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
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
