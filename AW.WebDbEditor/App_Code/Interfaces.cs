using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Collections.Specialized;

/// <summary>
/// Interface which is implemented by every Edit<i>Entity</i> control. 
/// </summary>
public interface IEditControl
{
	/// <summary>
	/// Gets / sets the edit mode of the control
	/// </summary>
	FormViewMode EditMode { get; set;}
	/// <summary>
	/// Sets the filter to use for the editcontrol's datasource control.
	/// </summary>
	PredicateExpression FilterToUse { set; }
	/// <summary>
	/// Sets a value indicating whether the delete mode is active. This is effective in FormViewMode.ReadOnly only, and it controls whether the delete button is
	/// active or the edit button. 
	/// </summary>
	bool DeleteMode { set;}
}


/// <summary>
/// Interface which is implemented by every Search<i>Entity</i> control. 
/// </summary>
public interface ISearchControl
{
	/// <summary>
	/// Creates a predicate expression filter based on the query string passed in. 
	/// </summary>
	/// <param name="queryString">The query string with PK field names and values.</param>
	/// <returns>a predicate expression with a filter on the pk fields and values.</returns>
	PredicateExpression CreateFilter(NameValueCollection queryString);

	/// <summary>
	/// Gets the filter formulated with the values specified in the search control. Valid after SearchClicked has been raised. 
	/// </summary>
	PredicateExpression Filter { get; }
	/// <summary>
	/// Sets the flag for allowing single entity searches. If set to true, the search control will show PK fields and if applicable, UC fields.
	/// </summary>
	bool AllowSingleEntitySearches { set;}
	/// <summary>
	/// Sets the flag for allowing multi entity searches. If set to true, the search control will show fields to formulate a search over all fields, and 
	/// thus a filter which could lead to multiple results.
	/// </summary>
	bool AllowMultiEntitySearches { set;}
	
	/// <summary>
	/// Event which is raised when the user clicked a search button. After this event, the 'Filter' property is valid.
	/// </summary>
	event EventHandler SearchClicked;
}


/// <summary>
/// Interface which is implemented by every List<i>Entity</i>Instances control. 
/// </summary>
public interface IListControl
{
	/// <summary>
	/// Sets the containing entity for the entities enlisted in this control. When a particular containing entity is set (e.g. 'Customer' for orders), the
	/// set entity is used to obtain the filter for the entities to show, and FilterToUse is then overruled. The entity is also used to produce FK field values
	/// for AddNew, so for example when a list of orders is shown, which are related to customer, the AddNew button should make the order's AddNew form preselect
	/// the Customer.
	/// </summary>
	/// <param name="containingEntity">The containing entity instance</param>
	/// <param name="name">the field name mapped on the relation from the containing entity with this entity</param>
	void SetContainingEntity(IEntityCore containingEntity, string name);
	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
	IPredicateExpression FilterToUse { set; }
	/// <summary>
	/// Sets the flag to show the Home button or not. The home button is hidden when the control is shown inside a form with other information.
	/// </summary>
	bool ShowHomeButton { set;}

    /// <summary>
    /// Ask the Grid to reload its data
    /// </summary>
    void GridDataBind();
}


/// <summary>
/// Interface which is implemented by every ViewRelatedTo<i>Entity</i> control. 
/// </summary>
public interface IViewRelatedControl
{
	/// <summary>
	/// Sets the filter to use for the control's entity fetch routine
	/// </summary>
	PredicateExpression FilterToUse { set; }
}