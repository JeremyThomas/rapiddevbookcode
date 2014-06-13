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
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;

public partial class Controls_ViewRelatedToSalesTerritory : System.Web.UI.UserControl, IViewRelatedControl
{
	private PredicateExpression _filterToUse;

	protected void Page_Load(object sender, EventArgs e)
	{
		if(_filterToUse != null)
		{
			SalesTerritoryEntity instance = null;
			SalesTerritoryCollection collection = new SalesTerritoryCollection();
			collection.GetMulti(_filterToUse, 1);
			if(collection.Count>0)
			{
				instance = collection[0];			
			}
			if(instance != null)
			{
				laStateProvinces.SetContainingEntity(instance, "StateProvinces");
				laCustomers.SetContainingEntity(instance, "Customers");
				laSalesOrderHeaders.SetContainingEntity(instance, "SalesOrderHeaders");
				laSalesPeople.SetContainingEntity(instance, "SalesPeople");
				laSalesTerritoryHistories.SetContainingEntity(instance, "SalesTerritoryHistories");
			}
		}
	}

	/// <summary>Sets the filter to use for the control's entity fetch routine</summary>
	public PredicateExpression FilterToUse 
	{
		set { _filterToUse = value; }
	}
}
