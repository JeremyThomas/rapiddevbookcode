using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data;
using AW.Data.HelperClasses;
using System.Collections.Generic;
using AW.Data.EntityClasses;

/// <summary>
/// Control class to edit a 'StoreContact' entity instance
/// </summary>
public partial class Controls_EditStoreContact : System.Web.UI.UserControl, IEditControl
{
	#region Class Member Declarations
	private FormViewMode _editMode = FormViewMode.Insert;
	private string _pkValuesAfterInsert = string.Empty;
	private bool _inDeleteMode = false;
	#endregion
	
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{	
		frmEditStoreContact.DefaultMode = _editMode;
		
		if (_editMode == FormViewMode.ReadOnly)
        {
			PrefetchPath path = new PrefetchPath((int)EntityType.StoreContactEntity);
			_StoreContactDS.PrefetchPathToUse = path;
		}
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
	/// Handles the ItemCommand event of the frmEditStoreContact control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.FormViewCommandEventArgs"/> instance containing the event data.</param>
	protected void frmEditStoreContact_ItemCommand(object sender, FormViewCommandEventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		
		switch(e.CommandName)
		{
			case "InsertAndNew":
				frmEditStoreContact.InsertItem(true);
				break;
			case "InsertAndHome":
				frmEditStoreContact.InsertItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "UpdateAndHome":
				frmEditStoreContact.UpdateItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "InsertAndView":
				frmEditStoreContact.InsertItem(true);
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.StoreContactEntity + _pkValuesAfterInsert);
				break;
			case "EditExisting":
				frmEditStoreContact.ChangeMode(FormViewMode.Edit);
				break;
			case "DeleteExisting":
				frmEditStoreContact.DeleteItem();
				Response.Redirect("~/default.aspx");
				break;
		}
	}

	
	/// <summary>
	/// Handles the ItemCreated event of the frmEditStoreContact control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void frmEditStoreContact_ItemCreated(object sender, EventArgs e)
	{
		switch(frmEditStoreContact.CurrentMode)
		{
			case FormViewMode.Insert:
				// set filters for fk fields, if applicable. 
				if(Request.QueryString["20FkField"]=="ContactID")
				{
					TextBox control = (TextBox)frmEditStoreContact.FindControl("tbxContactID");
					if(control!=null)
					{
						control.Text = Request.QueryString["ContactID"];
						control.ReadOnly = true;
					}
				}
				if(Request.QueryString["20FkField"]=="ContactTypeID")
				{
					TextBox control = (TextBox)frmEditStoreContact.FindControl("tbxContactTypeID");
					if(control!=null)
					{
						control.Text = Request.QueryString["ContactTypeID"];
						control.ReadOnly = true;
					}
				}
				if(Request.QueryString["20FkField"]=="CustomerID")
				{
					TextBox control = (TextBox)frmEditStoreContact.FindControl("tbxCustomerID");
					if(control!=null)
					{
						control.Text = Request.QueryString["CustomerID"];
						control.ReadOnly = true;
					}
				}
				break;
			case FormViewMode.ReadOnly:
				Button btnDelete = (Button)frmEditStoreContact.FindControl("btnDelete");
				Button btnEdit = (Button)frmEditStoreContact.FindControl("btnEdit");
				if(btnDelete!=null)
				{
					btnDelete.Visible = _inDeleteMode;
				}
				if(btnEdit!=null)
				{
					btnEdit.Visible = !_inDeleteMode;
				}
				break;
		}
	}
	
	
	/// <summary>Eventhandler for the PerformWork event on the _StoreContactDS datasourcecontrol</summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _StoreContactDS_PerformSelect(object sender, PerformSelectEventArgs e)
	{
		e.ContainedCollection.GetMulti(e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.Relations, e.PrefetchPath, e.PageNumber, e.PageSize);
	}

	
	/// <summary>Eventhandler for the PerformWork event on the _StoreContactDS datasourcecontrol</summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _StoreContactDS_PerformWork(object sender, PerformWorkEventArgs e)
	{
		// as we're using a formview, there's just 1 entity in the UoW.
		StoreContactEntity entityToProcess = null;
		List<UnitOfWorkElement> elementsToInsert = e.Uow.GetEntityElementsToInsert();
		if(elementsToInsert.Count > 0)
		{
			// it's an insert operation. grab the entity so we can determine the PK later on. 
			entityToProcess = (StoreContactEntity)elementsToInsert[0].Entity;
		}
		using(Transaction trans = new Transaction(IsolationLevel.ReadCommitted, "PerformWork"))
		{
			e.Uow.Commit(trans, true);
		}
		if(entityToProcess != null)
		{
			// store the PK values so a redirect can use these. 
			_pkValuesAfterInsert = "&ContactID=" + entityToProcess.ContactID + "&CustomerID=" + entityToProcess.CustomerID;
		}
	}
	
	
	#region Class Property Declarations
	
	/// <summary>Gets / sets the edit mode of the control</summary>	
	public FormViewMode EditMode
	{
		get { return _editMode; }
		set { _editMode = value; }
	}
	
	
	/// <summary>Sets the filter to use for the editcontrol's datasource control.</summary>
	public PredicateExpression FilterToUse 
	{
		set
		{
			if(value!=null)
			{
				_StoreContactDS.FilterToUse = value;
			}
		}
	}
	
	/// <summary>
	/// Sets a value indicating whether the delete mode is active. This is effective in FormViewMode.ReadOnly only, and it controls whether the delete button is
	/// active or the edit button. 
	/// </summary>
	public bool DeleteMode 
	{ 
		set { _inDeleteMode = value; }
	}
	#endregion
}
