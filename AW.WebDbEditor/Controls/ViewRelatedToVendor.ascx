
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToVendor.ascx.cs" Inherits="Controls_ViewRelatedToVendor" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductVendorsInstances" Src="ListProductVendorInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="PurchaseOrderHeadersInstances" Src="ListPurchaseOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="VendorAddressesInstances" Src="ListVendorAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="VendorContactsInstances" Src="ListVendorContactInstances.ascx"%>
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
			Related PurchaseOrderHeader instances (field mapped: PurchaseOrderHeaders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:PurchaseOrderHeadersInstances ID="laPurchaseOrderHeaders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related VendorAddress instances (field mapped: VendorAddresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:VendorAddressesInstances ID="laVendorAddresses" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related VendorContact instances (field mapped: VendorContacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:VendorContactsInstances ID="laVendorContacts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	