
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToShipMethod.ascx.cs" Inherits="Controls_ViewRelatedToShipMethod" %>
<%@ Register TagPrefix="dbeditor" TagName="PurchaseOrderHeadersInstances" Src="ListPurchaseOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
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
			Related SalesOrderHeader instances (field mapped: SalesOrderHeaders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderHeadersInstances ID="laSalesOrderHeaders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	