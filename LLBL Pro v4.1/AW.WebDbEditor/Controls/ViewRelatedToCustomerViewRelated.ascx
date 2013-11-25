
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCustomerViewRelated.ascx.cs" Inherits="Controls_ViewRelatedToCustomerViewRelated" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeaderInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
	<tr>
		<td class="headers">
			Related SalesOrderHeader instances (field mapped: SalesOrderHeader)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderHeaderInstances ID="laSalesOrderHeader" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	