
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToUnitMeasure.ascx.cs" Inherits="Controls_ViewRelatedToUnitMeasure" %>
<%@ Register TagPrefix="dbeditor" TagName="BillOfMaterialsInstances" Src="ListBillOfMaterialInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductsOfSizeInstances" Src="ListProductInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductsOfWeightInstances" Src="ListProductInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductVendorsInstances" Src="ListProductVendorInstances.ascx"%>
	<tr>
		<td class="headers">
			Related BillOfMaterial instances (field mapped: BillOfMaterials)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:BillOfMaterialsInstances ID="laBillOfMaterials" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related Product instances (field mapped: ProductsOfSize)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductsOfSizeInstances ID="laProductsOfSize" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related Product instances (field mapped: ProductsOfWeight)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductsOfWeightInstances ID="laProductsOfWeight" runat="server" ShowHomeButton="false" />
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
	