using System;
using System.Web.UI;
using System.Collections;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>Page which lists a subset based on a specified filter of a given entity</summary>
public partial class ListSubSet : System.Web.UI.Page
{
	#region Class Member Declarations
	private string _selectedObjectName;
	private bool _isControlDefined = false;
	private IListControl _lister;
	private ISearchControl _searcher;
	#endregion

	protected void Page_Init(object sender, EventArgs e)
	{
        try
        {
            _selectedObjectName = Request.QueryString["ObjectName"];
        }
        catch (Exception)
        {
        }

		if(!string.IsNullOrEmpty(_selectedObjectName))
		{
			// load list control for given entity.
			Control controlToAdd = Page.LoadControl("~/Controls/List" + _selectedObjectName + "Instances.ascx");
			_lister = controlToAdd as IListControl;
			if(_lister != null)
			{
				phListControls.Controls.Add(controlToAdd);
			}
			phListArea.Visible = false;
			
			// load search control 
			controlToAdd = Page.LoadControl("~/Controls/Search" + _selectedObjectName + ".ascx");
			_searcher = controlToAdd as ISearchControl;
			if(_searcher != null)
			{
				_searcher.AllowSingleEntitySearches = false;
				_searcher.AllowMultiEntitySearches = true;
				_searcher.SearchClicked += new EventHandler(searcher_SearchClicked);
				phSearchControls.Controls.Add(controlToAdd);
				phSearchArea.Visible = true;
			    _isControlDefined = true;
			}
		}
	}
	
	protected void Page_Load(object sender, EventArgs e)
	{
        if (_isControlDefined)
        {
            phSearchArea.Visible = true;
            btnRefineSearch.Visible = true;
            bool? showSearchArea = (bool?)ViewState["showSearchArea"];
			if(showSearchArea.HasValue)
			{ 
				// stored in viewstate, show the correct area.
				phSearchArea.Visible = showSearchArea.Value;
				phListArea.Visible = !showSearchArea.Value; // XXX _toSeeBoth		showSearchArea.Value; 
			}
			if(!Page.IsPostBack)
			{
                string entityLabel = GeneralUtils.EntityNameToEntityLabel(_selectedObjectName);
				this.Title += entityLabel + " instances";
			    lblEntityName.Text = entityLabel;
			}
        }
	}

	/// <summary>
	/// Handles the SearchClicked event of the searcher control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	private void searcher_SearchClicked(object sender, EventArgs e)
	{
        if ((_searcher != null) && (_lister != null))
		{
			_lister.FilterToUse = _searcher.Filter;
			_lister.GridDataBind();
			phSearchArea.Visible = false;
			phListArea.Visible = true;
			ViewState["showSearchArea"] = false;
		}
	}

    /// <summary>
    /// Handles the Click event of the btnNewSearch control.
    /// Allows a new search in an empty form
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnNewSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.Url.ToString());
    }

    /// <summary>
    /// Handles the Click event of the btnRefineSearch control.
    /// Allows to modify the previous search form (not available in saved & breadcrumb followed links)
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnRefineSearch_Click(object sender, EventArgs e)
    {
        if (_isControlDefined && (!phSearchArea.Visible))
        {
            phSearchArea.Visible = true;
            phListArea.Visible = false;
            ViewState["showSearchArea"] = true;
        }
    }
}
