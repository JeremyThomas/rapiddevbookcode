
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToContact.ascx.cs" Inherits="Controls_ViewRelatedToContact" %>
<%@ Register TagPrefix="dbeditor" TagName="EmployeesInstances" Src="ListEmployeeInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="VendorContactsInstances" Src="ListVendorContactInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ContactCreditCardsInstances" Src="ListContactCreditCardInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="IndividualsInstances" Src="ListIndividualInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="SalesOrderHeadersInstances" Src="ListSalesOrderHeaderInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="StoresInstances" Src="ListStoreInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="StoreContactsInstances" Src="ListStoreContactInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Employee instances (field mapped: Employees)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeesInstances ID="laEmployees" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related VendorContact instances (field mapped: VendorContacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:VendorContactsInstances ID="laVendorContacts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
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
			Related Individual instances (field mapped: Individuals)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:IndividualsInstances ID="laIndividuals" runat="server" ShowHomeButton="false" />
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
			Related Store instances (field mapped: Stores)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StoresInstances ID="laStores" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related StoreContact instances (field mapped: StoreContacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StoreContactsInstances ID="laStoreContacts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	