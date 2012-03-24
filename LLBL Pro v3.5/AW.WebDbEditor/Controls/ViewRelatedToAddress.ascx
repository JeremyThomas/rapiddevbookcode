
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToAddress.ascx.cs" Inherits="Controls_ViewRelatedToAddress" %>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeAddressesInstances" Src="ListEmployeeAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="VendorAddressesInstances" Src="ListVendorAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="CustomerAddressesInstances" Src="ListCustomerAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeaders_Instances" Src="ListSalesOrderHeaderInstances.ascx"%>
	<tr>
		<td class="headers">
			Related EmployeeAddress instances (field mapped: EmployeeAddresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeAddressesInstances ID="laEmployeeAddresses" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related VendorAddress instances (field mapped: VendorAddresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:VendorAddressesInstances ID="laVendorAddresses" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related CustomerAddress instances (field mapped: CustomerAddresses)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:CustomerAddressesInstances ID="laCustomerAddresses" runat="server" ShowHomeButton="false" />
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
			Related SalesOrderHeader instances (field mapped: SalesOrderHeaders_)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SalesOrderHeaders_Instances ID="laSalesOrderHeaders_" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	