
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCreditCard.ascx.cs" Inherits="Controls_ViewRelatedToCreditCard" %>
<%@ Register TagPrefix="dbeditor" TagName="ContactCreditCardsInstances" Src="ListContactCreditCardInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ContactCreditCard instances (field mapped: ContactCreditCards)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ContactCreditCardsInstances ID="laContactCreditCards" runat="server" ShowHomeButton="false" />
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
	