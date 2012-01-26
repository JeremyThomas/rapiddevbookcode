
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToLocation.ascx.cs" Inherits="Controls_ViewRelatedToLocation" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductInventoriesInstances" Src="ListProductInventoryInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="WorkOrderRoutingsInstances" Src="ListWorkOrderRoutingInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ProductInventory instances (field mapped: ProductInventories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductInventoriesInstances ID="laProductInventories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
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
	