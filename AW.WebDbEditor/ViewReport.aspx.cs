using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>
/// Page which lists all instances (with paging) of the given entity type
/// </summary>
public partial class ViewReport : System.Web.UI.Page
{
	#region Class Member Declarations
	private string _selectedObjectName;
	private bool _isControlDefined = false;
	#endregion

	/// <summary>
	/// Handles the Init event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
			Control controlToAdd = Page.LoadControl("~/Controls/List" + _selectedObjectName + "InstancesReport.ascx");
			if(controlToAdd!=null)
			{
			    _isControlDefined = true;
				phControls.Controls.Add(controlToAdd);
			}
		}
	}
	
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{
        if (!Page.IsPostBack && _isControlDefined)
		{
            string entityLabel = GeneralUtils.EntityNameToEntityLabel(_selectedObjectName);
			this.Title += entityLabel + " instance";
			lblEntityName.Text = entityLabel;
		}
	}
	
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
	
}