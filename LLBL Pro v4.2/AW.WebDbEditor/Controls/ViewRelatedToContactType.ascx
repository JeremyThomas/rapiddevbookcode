
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToContactType.ascx.cs" Inherits="Controls_ViewRelatedToContactType" %>
<%@ Register TagPrefix="dbeditor" TagName="VendorContactsInstances" Src="ListVendorContactInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="StoreContactsInstances" Src="ListStoreContactInstances.ascx"%>
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
	<tr>
		<td class="headers">
			Related StoreContact instances (field mapped: StoreContacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StoreContactsInstances ID="laStoreContacts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	