
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToWorkOrder.ascx.cs" Inherits="Controls_ViewRelatedToWorkOrder" %>
<%@ Register TagPrefix="dbeditor" TagName="WorkOrderRoutingsInstances" Src="ListWorkOrderRoutingInstances.ascx"%>
	<tr>
		<td class="headers">
			Related WorkOrderRouting instances (field mapped: WorkOrderRoutings)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:WorkOrderRoutingsInstances ID="laWorkOrderRoutings" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	