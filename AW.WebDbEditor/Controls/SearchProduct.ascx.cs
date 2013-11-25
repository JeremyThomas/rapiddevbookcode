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
/// Control class to search one or more 'Product' entity instances
/// </summary>
public partial class Controls_SearchProduct : System.Web.UI.UserControl, ISearchControl
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
		valueFromQueryString = queryString["ProductID"];
		if(valueFromQueryString!=null)
		{
			toReturn.AddWithAnd(ProductFields.ProductID==Convert.ChangeType(valueFromQueryString, typeof(System.Int32)));
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
		_filter.AddWithAnd(ProductFields.ProductID==Convert.ChangeType(tbxProductID.Text, typeof(System.Int32)));
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
		if(chkEnableClass.Checked)
		{
			string fromValueAsString = tbxClassMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Class, Convert.ToInt32(opClass.SelectedValue), chkNotClass.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableColor.Checked)
		{
			string fromValueAsString = tbxColorMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Color, Convert.ToInt32(opColor.SelectedValue), chkNotColor.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableDaysToManufacture.Checked)
		{
			string fromValueAsString = tbxDaysToManufactureMiFrom.Text;
			string toValueAsString = tbxDaysToManufactureMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.DaysToManufacture, Convert.ToInt32(opDaysToManufacture.SelectedValue), chkNotDaysToManufacture.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableDiscontinuedDate.Checked)
		{
			object fromValue = dtxDiscontinuedDateMiFrom.Value;
			object toValue = dtxDiscontinuedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.DiscontinuedDate, Convert.ToInt32(opDiscontinuedDate.SelectedValue), chkNotDiscontinuedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableFinishedGoodsFlag.Checked)
		{
			object fromValue = chkFinishedGoodsFlagMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.FinishedGoodsFlag, Convert.ToInt32(opFinishedGoodsFlag.SelectedValue), chkNotFinishedGoodsFlag.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableListPrice.Checked)
		{
			string fromValueAsString = tbxListPriceMiFrom.Text;
			string toValueAsString = tbxListPriceMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ListPrice, Convert.ToInt32(opListPrice.SelectedValue), chkNotListPrice.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableMakeFlag.Checked)
		{
			object fromValue = chkMakeFlagMiFrom.Checked;
			object toValue = null;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.MakeFlag, Convert.ToInt32(opMakeFlag.SelectedValue), chkNotMakeFlag.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableModifiedDate.Checked)
		{
			object fromValue = dtxModifiedDateMiFrom.Value;
			object toValue = dtxModifiedDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ModifiedDate, Convert.ToInt32(opModifiedDate.SelectedValue), chkNotModifiedDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableName.Checked)
		{
			string fromValueAsString = tbxNameMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Name, Convert.ToInt32(opName.SelectedValue), chkNotName.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductID, Convert.ToInt32(opProductID.SelectedValue), chkNotProductID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductLine.Checked)
		{
			string fromValueAsString = tbxProductLineMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductLine, Convert.ToInt32(opProductLine.SelectedValue), chkNotProductLine.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductModelID.Checked)
		{
			string fromValueAsString = tbxProductModelIDMiFrom.Text;
			string toValueAsString = tbxProductModelIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductModelID, Convert.ToInt32(opProductModelID.SelectedValue), chkNotProductModelID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductNumber.Checked)
		{
			string fromValueAsString = tbxProductNumberMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductNumber, Convert.ToInt32(opProductNumber.SelectedValue), chkNotProductNumber.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableProductSubcategoryID.Checked)
		{
			string fromValueAsString = tbxProductSubcategoryIDMiFrom.Text;
			string toValueAsString = tbxProductSubcategoryIDMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ProductSubcategoryID, Convert.ToInt32(opProductSubcategoryID.SelectedValue), chkNotProductSubcategoryID.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableReorderPoint.Checked)
		{
			string fromValueAsString = tbxReorderPointMiFrom.Text;
			string toValueAsString = tbxReorderPointMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.ReorderPoint, Convert.ToInt32(opReorderPoint.SelectedValue), chkNotReorderPoint.Checked, 
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
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Rowguid, Convert.ToInt32(opRowguid.SelectedValue), chkNotRowguid.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSafetyStockLevel.Checked)
		{
			string fromValueAsString = tbxSafetyStockLevelMiFrom.Text;
			string toValueAsString = tbxSafetyStockLevelMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.SafetyStockLevel, Convert.ToInt32(opSafetyStockLevel.SelectedValue), chkNotSafetyStockLevel.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSellEndDate.Checked)
		{
			object fromValue = dtxSellEndDateMiFrom.Value;
			object toValue = dtxSellEndDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.SellEndDate, Convert.ToInt32(opSellEndDate.SelectedValue), chkNotSellEndDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSellStartDate.Checked)
		{
			object fromValue = dtxSellStartDateMiFrom.Value;
			object toValue = dtxSellStartDateMiTo.Value;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.SellStartDate, Convert.ToInt32(opSellStartDate.SelectedValue), chkNotSellStartDate.Checked, 
						fromValue, toValue);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSize.Checked)
		{
			string fromValueAsString = tbxSizeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Size, Convert.ToInt32(opSize.SelectedValue), chkNotSize.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableSizeUnitMeasureCode.Checked)
		{
			string fromValueAsString = tbxSizeUnitMeasureCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.SizeUnitMeasureCode, Convert.ToInt32(opSizeUnitMeasureCode.SelectedValue), chkNotSizeUnitMeasureCode.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStandardCost.Checked)
		{
			string fromValueAsString = tbxStandardCostMiFrom.Text;
			string toValueAsString = tbxStandardCostMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.StandardCost, Convert.ToInt32(opStandardCost.SelectedValue), chkNotStandardCost.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableStyle.Checked)
		{
			string fromValueAsString = tbxStyleMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Style, Convert.ToInt32(opStyle.SelectedValue), chkNotStyle.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableWeight.Checked)
		{
			string fromValueAsString = tbxWeightMiFrom.Text;
			string toValueAsString = tbxWeightMiTo.Text;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.Weight, Convert.ToInt32(opWeight.SelectedValue), chkNotWeight.Checked, 
						fromValueAsString, toValueAsString);
			if(toAdd != null)
			{
				_filter.Add(toAdd);
			}
		}
		
		if(chkEnableWeightUnitMeasureCode.Checked)
		{
			string fromValueAsString = tbxWeightUnitMeasureCodeMiFrom.Text;
			string toValueAsString = string.Empty;
			toAdd = GeneralUtils.CreatePredicate(ProductFields.WeightUnitMeasureCode, Convert.ToInt32(opWeightUnitMeasureCode.SelectedValue), chkNotWeightUnitMeasureCode.Checked, 
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
