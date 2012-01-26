
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSalesPerson.ascx.cs" Inherits="Controls_ViewRelatedToSalesPerson" %>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesPersonQuotaHistoriesInstances" Src="ListSalesPersonQuotaHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesTerritoryHistoriesInstances" Src="ListSalesTerritoryHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="StoresInstances" Src="ListStoreInstances.ascx"%>
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
	<tr>
		<td class="headers">
			Related SalesPersonQuotaHistory instances (field mapped: SalesPersonQuotaHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesPersonQuotaHistoriesInstances ID="laSalesPersonQuotaHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related SalesTerritoryHistory instances (field mapped: SalesTerritoryHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesTerritoryHistoriesInstances ID="laSalesTerritoryHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related Store instances (field mapped: Stores)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StoresInstances ID="laStores" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	