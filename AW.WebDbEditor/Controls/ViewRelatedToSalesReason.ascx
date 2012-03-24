
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSalesReason.ascx.cs" Inherits="Controls_ViewRelatedToSalesReason" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeaderSalesReasonsInstances" Src="ListSalesOrderHeaderSalesReasonInstances.ascx"%>
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
	