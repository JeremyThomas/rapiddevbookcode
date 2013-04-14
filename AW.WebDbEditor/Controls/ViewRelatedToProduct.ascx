
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProduct.ascx.cs" Inherits="Controls_ViewRelatedToProduct" %>
<%@ Register TagPrefix="dbeditor" TagName="BillOfAssemblyMaterialsInstances" Src="ListBillOfMaterialInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="BillOfComponentMaterialsInstances" Src="ListBillOfMaterialInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductCostHistoriesInstances" Src="ListProductCostHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductDocumentsInstances" Src="ListProductDocumentInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductInventoriesInstances" Src="ListProductInventoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductListPriceHistoriesInstances" Src="ListProductListPriceHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductProductPhotosInstances" Src="ListProductProductPhotoInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductReviewsInstances" Src="ListProductReviewInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="TransactionHistoriesInstances" Src="ListTransactionHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="WorkOrdersInstances" Src="ListWorkOrderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductVendorsInstances" Src="ListProductVendorInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="PurchaseOrderDetailsInstances" Src="ListPurchaseOrderDetailInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ShoppingCartItemsInstances" Src="ListShoppingCartItemInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SpecialOfferProductsInstances" Src="ListSpecialOfferProductInstances.ascx"%>
	<tr>
		<td class="headers">
			Related BillOfMaterial instances (field mapped: BillOfAssemblyMaterials)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:BillOfAssemblyMaterialsInstances ID="laBillOfAssemblyMaterials" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related BillOfMaterial instances (field mapped: BillOfComponentMaterials)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:BillOfComponentMaterialsInstances ID="laBillOfComponentMaterials" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductCostHistory instances (field mapped: ProductCostHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductCostHistoriesInstances ID="laProductCostHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductDocument instances (field mapped: ProductDocuments)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductDocumentsInstances ID="laProductDocuments" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductInventory instances (field mapped: ProductInventories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductInventoriesInstances ID="laProductInventories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductListPriceHistory instances (field mapped: ProductListPriceHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductListPriceHistoriesInstances ID="laProductListPriceHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductProductPhoto instances (field mapped: ProductProductPhotos)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductProductPhotosInstances ID="laProductProductPhotos" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductReview instances (field mapped: ProductReviews)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductReviewsInstances ID="laProductReviews" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related TransactionHistory instances (field mapped: TransactionHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:TransactionHistoriesInstances ID="laTransactionHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related WorkOrder instances (field mapped: WorkOrders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:WorkOrdersInstances ID="laWorkOrders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ProductVendor instances (field mapped: ProductVendors)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductVendorsInstances ID="laProductVendors" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related PurchaseOrderDetail instances (field mapped: PurchaseOrderDetails)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:PurchaseOrderDetailsInstances ID="laPurchaseOrderDetails" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related ShoppingCartItem instances (field mapped: ShoppingCartItems)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ShoppingCartItemsInstances ID="laShoppingCartItems" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related SpecialOfferProduct instances (field mapped: SpecialOfferProducts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SpecialOfferProductsInstances ID="laSpecialOfferProducts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	