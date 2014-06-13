
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSalesTerritory.ascx.cs" Inherits="Controls_ViewRelatedToSalesTerritory" %>
<%@ Register TagPrefix="dbeditor" TagName="StateProvincesInstances" Src="ListStateProvinceInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomersInstances" Src="ListCustomerInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesPeopleInstances" Src="ListSalesPersonInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesTerritoryHistoriesInstances" Src="ListSalesTerritoryHistoryInstances.ascx"%>
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
			Related Customer instances (field mapped: Customers)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomersInstances ID="laCustomers" runat="server" ShowHomeButton="false" />
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
	<tr>
		<td class="headers">
			Related SalesPerson instances (field mapped: SalesPeople)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesPeopleInstances ID="laSalesPeople" runat="server" ShowHomeButton="false" />
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
	