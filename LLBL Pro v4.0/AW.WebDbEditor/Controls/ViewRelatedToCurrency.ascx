
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToCurrency.ascx.cs" Inherits="Controls_ViewRelatedToCurrency" %>
<%@ Register TagPrefix="dbeditor" TagName="CountryRegionCurrenciesInstances" Src="ListCountryRegionCurrencyInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CurrencyRatesInstances" Src="ListCurrencyRateInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CurrencyRates_Instances" Src="ListCurrencyRateInstances.ascx"%>
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
	<tr>
		<td class="headers">
			Related CurrencyRate instances (field mapped: CurrencyRates)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CurrencyRatesInstances ID="laCurrencyRates" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related CurrencyRate instances (field mapped: CurrencyRates_)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CurrencyRates_Instances ID="laCurrencyRates_" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	