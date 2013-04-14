
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCountryRegion.ascx.cs" Inherits="Controls_ViewRelatedToCountryRegion" %>
<%@ Register TagPrefix="dbeditor" TagName="StateProvincesInstances" Src="ListStateProvinceInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CountryRegionCurrenciesInstances" Src="ListCountryRegionCurrencyInstances.ascx"%>
	<tr>
		<td class="headers">
			Related StateProvince instances (field mapped: StateProvinces)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StateProvincesInstances ID="laStateProvinces" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related CountryRegionCurrency instances (field mapped: CountryRegionCurrencies)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CountryRegionCurrenciesInstances ID="laCountryRegionCurrencies" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	