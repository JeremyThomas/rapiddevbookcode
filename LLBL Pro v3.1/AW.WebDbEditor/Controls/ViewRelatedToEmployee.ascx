
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToEmployee.ascx.cs" Inherits="Controls_ViewRelatedToEmployee" %>
<%@ Register TagPrefix="dbeditor" TagName="ManagesInstances" Src="ListEmployeeInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeAddressesInstances" Src="ListEmployeeAddressInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeDepartmentHistoriesInstances" Src="ListEmployeeDepartmentHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="EmployeePayHistoriesInstances" Src="ListEmployeePayHistoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="JobCandidatesInstances" Src="ListJobCandidateInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="PurchaseOrderHeadersInstances" Src="ListPurchaseOrderHeaderInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Employee instances (field mapped: Manages)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ManagesInstances ID="laManages" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
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
			Related EmployeeDepartmentHistory instances (field mapped: EmployeeDepartmentHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeeDepartmentHistoriesInstances ID="laEmployeeDepartmentHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related EmployeePayHistory instances (field mapped: EmployeePayHistories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:EmployeePayHistoriesInstances ID="laEmployeePayHistories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related JobCandidate instances (field mapped: JobCandidates)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:JobCandidatesInstances ID="laJobCandidates" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related PurchaseOrderHeader instances (field mapped: PurchaseOrderHeaders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:PurchaseOrderHeadersInstances ID="laPurchaseOrderHeaders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	