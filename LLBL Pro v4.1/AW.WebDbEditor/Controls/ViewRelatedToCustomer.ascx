
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCustomer.ascx.cs" Inherits="Controls_ViewRelatedToCustomer" %>
<%@ Register TagPrefix="dbeditor" TagName="CustomerAddressesInstances" Src="ListCustomerAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
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
	<tr>
		<td class="headers">
			Related SalesOrderHeader instances (field mapped: SalesOrderHeaders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderHeadersInstances ID="laSalesOrderHeaders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	