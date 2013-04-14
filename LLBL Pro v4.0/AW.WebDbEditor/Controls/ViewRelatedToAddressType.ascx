
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToAddressType.ascx.cs" Inherits="Controls_ViewRelatedToAddressType" %>
<%@ Register TagPrefix="dbeditor" TagName="VendorAddressesInstances" Src="ListVendorAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerAddressesInstances" Src="ListCustomerAddressInstances.ascx"%>
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
			Related CustomerAddress instances (field mapped: CustomerAddresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerAddressesInstances ID="laCustomerAddresses" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	