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

public partial class Controls_ViewRelatedToProduct : System.Web.UI.UserControl, IViewRelatedControl
{
	private PredicateExpression _filterToUse;

	protected void Page_Load(object sender, EventArgs e)
	{
		if(_filterToUse != null)
		{
			ProductEntity instance = null;
			ProductCollection collection = new ProductCollection();
			collection.GetMulti(_filterToUse, 1);
			if(collection.Count>0)
			{
				instance = collection[0];			
			}
			if(instance != null)
			{
				laBillOfAssemblyMaterials.SetContainingEntity(instance, "BillOfAssemblyMaterials");
				laBillOfComponentMaterials.SetContainingEntity(instance, "BillOfComponentMaterials");
				laProductCostHistories.SetContainingEntity(instance, "ProductCostHistories");
				laProductDocuments.SetContainingEntity(instance, "ProductDocuments");
				laProductInventories.SetContainingEntity(instance, "ProductInventories");
				laProductListPriceHistories.SetContainingEntity(instance, "ProductListPriceHistories");
				laProductProductPhotos.SetContainingEntity(instance, "ProductProductPhotos");
				laProductReviews.SetContainingEntity(instance, "ProductReviews");
				laTransactionHistories.SetContainingEntity(instance, "TransactionHistories");
				laWorkOrders.SetContainingEntity(instance, "WorkOrders");
				laProductVendors.SetContainingEntity(instance, "ProductVendors");
				laPurchaseOrderDetails.SetContainingEntity(instance, "PurchaseOrderDetails");
				laShoppingCartItems.SetContainingEntity(instance, "ShoppingCartItems");
				laSpecialOfferProducts.SetContainingEntity(instance, "SpecialOfferProducts");
			}
		}
	}

	/// <summary>Sets the filter to use for the control's entity fetch routine</summary>
	public PredicateExpression FilterToUse 
	{
		set { _filterToUse = value; }
	}
}
