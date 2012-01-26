
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToDepartment.ascx.cs" Inherits="Controls_ViewRelatedToDepartment" %>
<%@ Register TagPrefix="dbeditor" TagName="EmployeeDepartmentHistoriesInstances" Src="ListEmployeeDepartmentHistoryInstances.ascx"%>
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
	