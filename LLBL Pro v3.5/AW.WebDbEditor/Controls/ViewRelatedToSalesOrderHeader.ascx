
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSalesOrderHeader.ascx.cs" Inherits="Controls_ViewRelatedToSalesOrderHeader" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderDetailsInstances" Src="ListSalesOrderDetailInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeaderSalesReasonsInstances" Src="ListSalesOrderHeaderSalesReasonInstances.ascx"%>
	<tr>
		<td class="headers">
			Related SalesOrderDetail instances (field mapped: SalesOrderDetails)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderDetailsInstances ID="laSalesOrderDetails" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related SalesOrderHeaderSalesReason instances (field mapped: SalesOrderHeaderSalesReasons)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderHeaderSalesReasonsInstances ID="laSalesOrderHeaderSalesReasons" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	