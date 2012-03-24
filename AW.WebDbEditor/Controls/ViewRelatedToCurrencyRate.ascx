
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCurrencyRate.ascx.cs" Inherits="Controls_ViewRelatedToCurrencyRate" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
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
	