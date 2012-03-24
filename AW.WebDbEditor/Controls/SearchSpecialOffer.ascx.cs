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
/// Control class to search one or more 'SpecialOffer' entity instances
/// </summary>
public partial class Controls_SearchSpecialOffer : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["SpecialOfferID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(SpecialOfferFields.SpecialOfferID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(SpecialOfferFields.SpecialOfferID==Convert.ChangeType(tbxSpecialOfferID.Text, typeof(System.Int32)));
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
		if(chkEnableCategory.Checked)
		{
			string fromValueAsString = tbxCategoryMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.Category, Convert.ToInt32(opCategory.SelectedValue), chkNotCategory.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableDescription.Checked)
		{
			string fromValueAsString = tbxDescriptionMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.Description, Convert.ToInt32(opDescription.SelectedValue), chkNotDescription.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableDiscountPct.Checked)
		{
			string fromValueAsString = tbxDiscountPctMiFrom.Text;
			string toValueAsString = tbxDiscountPctMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.DiscountPct, Convert.ToInt32(opDiscountPct.SelectedValue), chkNotDiscountPct.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableEndDate.Checked)
		{
			object fromValue = dtxEndDateMiFrom.Value;
			object toValue = dtxEndDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.EndDate, Convert.ToInt32(opEndDate.SelectedValue), chkNotEndDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMaxQty.Checked)
		{
			string fromValueAsString = tbxMaxQtyMiFrom.Text;
			string toValueAsString = tbxMaxQtyMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.MaxQty, Convert.ToInt32(opMaxQty.SelectedValue), chkNotMaxQty.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMinQty.Checked)
		{
			string fromValueAsString = tbxMinQtyMiFrom.Text;
			string toValueAsString = tbxMinQtyMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.MinQty, Convert.ToInt32(opMinQty.SelectedValue), chkNotMinQty.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableRowguid.Checked)
		{
			string fromValueAsString = tbxRowguidMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.SpecialOfferID, Convert.ToInt32(opSpecialOfferID.SelectedValue), chkNotSpecialOfferID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStartDate.Checked)
		{
			object fromValue = dtxStartDateMiFrom.Value;
			object toValue = dtxStartDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.StartDate, Convert.ToInt32(opStartDate.SelectedValue), chkNotStartDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableType.Checked)
		{
			string fromValueAsString = tbxTypeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(SpecialOfferFields.Type, Convert.ToInt32(opType.SelectedValue), chkNotType.Checked, 
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
