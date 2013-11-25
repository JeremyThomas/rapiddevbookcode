
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSpecialOfferProduct.ascx.cs" Inherits="Controls_ViewRelatedToSpecialOfferProduct" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderDetailsInstances" Src="ListSalesOrderDetailInstances.ascx"%>
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
	