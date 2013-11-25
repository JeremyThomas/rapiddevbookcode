
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToPurchaseOrderHeader.ascx.cs" Inherits="Controls_ViewRelatedToPurchaseOrderHeader" %>
<%@ Register TagPrefix="dbeditor" TagName="PurchaseOrderDetailsInstances" Src="ListPurchaseOrderDetailInstances.ascx"%>
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
	