
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToStateProvince.ascx.cs" Inherits="Controls_ViewRelatedToStateProvince" %>
<%@ Register TagPrefix="dbeditor" TagName="AddressesInstances" Src="ListAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesTaxRatesInstances" Src="ListSalesTaxRateInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Address instances (field mapped: Addresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:AddressesInstances ID="laAddresses" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related SalesTaxRate instances (field mapped: SalesTaxRates)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesTaxRatesInstances ID="laSalesTaxRates" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	