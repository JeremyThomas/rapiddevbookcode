
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToScrapReason.ascx.cs" Inherits="Controls_ViewRelatedToScrapReason" %>
<%@ Register TagPrefix="dbeditor" TagName="WorkOrdersInstances" Src="ListWorkOrderInstances.ascx"%>
	<tr>
		<td class="headers">
			Related WorkOrder instances (field mapped: WorkOrders)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:WorkOrdersInstances ID="laWorkOrders" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	