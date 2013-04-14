using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using AW.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>Page which shows an existing entity's data and all related entities (1:n/m:n). 
public partial class ViewExisting : System.Web.UI.Page
{
	#region Class Member Declarations
	private EntityType _selectedEntityType;
	private bool _entityTypeDefined = false;
	#endregion

	protected void Page_Init(object sender, EventArgs e)
	{
		// Get what type of view (Entity, TypedView or TypedList) is requested
		int entityTypeValue = 0;
		Int32.TryParse(Request.QueryString["EntityType"], out entityTypeValue);
		if(Enum.IsDefined(typeof(EntityType), entityTypeValue))
		{
			_selectedEntityType = (EntityType)entityTypeValue;
			_entityTypeDefined = true;
		}

        if (_entityTypeDefined)
        {
            // load edit control for given entity.
            Control controlToAdd = Page.LoadControl("~/Controls/Edit" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
            IEditControl editor = controlToAdd as IEditControl;
            if (editor != null)
            {
                editor.EditMode = FormViewMode.ReadOnly;
                phControls.Controls.Add(controlToAdd);
                controlToAdd = Page.LoadControl("~/Controls/Search" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
                ISearchControl searcher = controlToAdd as ISearchControl;
                if (searcher != null)
                {
                    if (Request.QueryString.Count > 1)
                    {
                        // get the filter based on the query string's PK fields. Use the search control for this, as it contains the logic for this.
                        PredicateExpression filter = searcher.CreateFilter(Request.QueryString);
                        editor.FilterToUse = filter;
                        controlToAdd = Page.LoadControl("~/Controls/ViewRelatedTo" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
                        IViewRelatedControl relatedViewer = controlToAdd as IViewRelatedControl;
                        if (relatedViewer != null)
                        {
                            relatedViewer.FilterToUse = filter;
                            phRelatedEntities.Controls.Add(controlToAdd);
                        }
                    }
                }
            }
        }
	}
	
	protected void Page_Load(object sender, EventArgs e)
	{
		if(!Page.IsPostBack && _entityTypeDefined)
		{
			string entityName = GeneralUtils.EntityTypeToEntityName(_selectedEntityType);
			string entityLabel = GeneralUtils.EntityNameToEntityLabel(entityName);
			this.Title += entityLabel + " instance";
			lblEntityName.Text = entityLabel;
		}
	}
}
