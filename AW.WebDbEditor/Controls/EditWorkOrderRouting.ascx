
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditWorkOrderRouting.ascx.cs" Inherits="Controls_EditWorkOrderRouting" %>
<llblgenpro:LLBLGenProDataSource ID="_WorkOrderRoutingDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.WorkOrderRoutingCollection, AW.Data" LivePersistence="False" OnPerformSelect="_WorkOrderRoutingDS_PerformSelect" OnPerformWork="_WorkOrderRoutingDS_PerformWork"/>
<asp:FormView ID="frmEditWorkOrderRouting" DataKeyNames="OperationSequence, ProductID, WorkOrderID" runat="server" DefaultMode="insert" DataSourceID="_WorkOrderRoutingDS" Cellpadding="0" OnItemCommand="frmEditWorkOrderRouting_ItemCommand" OnItemCreated="frmEditWorkOrderRouting_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualCost" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ActualCost") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActualEndDate" runat="server" Required="False" Value='<%# Bind("ActualEndDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualResourceHrs:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualResourceHrs" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ActualResourceHrs") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActualStartDate" runat="server" Required="False" Value='<%# Bind("ActualStartDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LocationID:
			</td>
			<td class="content">
				<asp:textbox id="tbxLocationID" runat="server" maxlength="6" size="6" Text='<%# Bind("LocationID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valLocationID" runat="server" ControlToValidate="tbxLocationID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqLocationID" runat="server" ControlToValidate="tbxLocationID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ModifiedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxModifiedDate" runat="server" Required="True" Value='<%# Bind("ModifiedDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqModifiedDate" runat="server" ControlToValidate="dtxModifiedDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OperationSequence:
			</td>
			<td class="content">
				<asp:textbox id="tbxOperationSequence" runat="server" maxlength="6" size="6" Text='<%# Bind("OperationSequence") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valOperationSequence" runat="server" ControlToValidate="tbxOperationSequence" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqOperationSequence" runat="server" ControlToValidate="tbxOperationSequence" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PlannedCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxPlannedCost" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("PlannedCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqPlannedCost" runat="server" ControlToValidate="tbxPlannedCost" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valProductID" runat="server" ControlToValidate="tbxProductID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqProductID" runat="server" ControlToValidate="tbxProductID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ScheduledEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxScheduledEndDate" runat="server" Required="True" Value='<%# Bind("ScheduledEndDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqScheduledEndDate" runat="server" ControlToValidate="dtxScheduledEndDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ScheduledStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxScheduledStartDate" runat="server" Required="True" Value='<%# Bind("ScheduledStartDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqScheduledStartDate" runat="server" ControlToValidate="dtxScheduledStartDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				WorkOrderID:
			</td>
			<td class="content">
				<asp:textbox id="tbxWorkOrderID" runat="server" maxlength="11" size="11" Text='<%# Bind("WorkOrderID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valWorkOrderID" runat="server" ControlToValidate="tbxWorkOrderID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqWorkOrderID" runat="server" ControlToValidate="tbxWorkOrderID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br />
				<hr align="left" size="1" />
				<asp:Button ID="btnInsertAndNew" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndNew" Text="Insert and New" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndHome" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndHome" Text="Insert and Home" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndView" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndView" Text="Insert and View" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</InsertItemTemplate>
<EditItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualCost" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ActualCost") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActualEndDate" runat="server" Required="False" Value='<%# Bind("ActualEndDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualResourceHrs:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualResourceHrs" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ActualResourceHrs") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxActualStartDate" runat="server" Required="False" Value='<%# Bind("ActualStartDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LocationID:
			</td>
			<td class="content">
				<asp:textbox id="tbxLocationID" runat="server" maxlength="6" size="6" Text='<%# Bind("LocationID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valLocationID" runat="server" ControlToValidate="tbxLocationID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqLocationID" runat="server" ControlToValidate="tbxLocationID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ModifiedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxModifiedDate" runat="server" Required="True" Value='<%# Bind("ModifiedDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqModifiedDate" runat="server" ControlToValidate="dtxModifiedDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				OperationSequence:
			</td>
			<td class="content">
				<asp:Label ID="lblOperationSequence" runat="server" Text='<%# Bind("OperationSequence") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PlannedCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxPlannedCost" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("PlannedCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqPlannedCost" runat="server" ControlToValidate="tbxPlannedCost" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductID:
			</td>
			<td class="content">
				<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ScheduledEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxScheduledEndDate" runat="server" Required="True" Value='<%# Bind("ScheduledEndDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqScheduledEndDate" runat="server" ControlToValidate="dtxScheduledEndDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ScheduledStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxScheduledStartDate" runat="server" Required="True" Value='<%# Bind("ScheduledStartDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqScheduledStartDate" runat="server" ControlToValidate="dtxScheduledStartDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				WorkOrderID:
			</td>
			<td class="content">
				<asp:Label ID="lblWorkOrderID" runat="server" Text='<%# Bind("WorkOrderID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnUpdateAndHome" runat="server" ValidationGroup="EditValidations" CausesValidation="True" CommandName="UpdateAndHome" Text="Update and Home" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</EditItemTemplate>
<ItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts" width="700">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActualCost:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActualCost" runat="server" Text='<%# Bind("ActualCost", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActualEndDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActualEndDate" runat="server" Text='<%# Bind("ActualEndDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActualResourceHrs:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActualResourceHrs" runat="server" Text='<%# Bind("ActualResourceHrs", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActualStartDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActualStartDate" runat="server" Text='<%# Bind("ActualStartDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				LocationID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkLocationID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.LocationEntity).ToString() + "&LocationID=" + Eval("LocationID")%>' Text='<%# Bind("LocationID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ModifiedDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				OperationSequence:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblOperationSequence" runat="server" Text='<%# Bind("OperationSequence") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PlannedCost:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPlannedCost" runat="server" Text='<%# Bind("PlannedCost", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ScheduledEndDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblScheduledEndDate" runat="server" Text='<%# Bind("ScheduledEndDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ScheduledStartDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblScheduledStartDate" runat="server" Text='<%# Bind("ScheduledStartDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				WorkOrderID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkWorkOrderID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.WorkOrderEntity).ToString() + "&WorkOrderID=" + Eval("WorkOrderID")%>' Text='<%# Bind("WorkOrderID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this WorkOrderRouting instance with PK values: "  + "OperationSequence: " + Eval("OperationSequence") + "ProductID: " + Eval("ProductID") + "WorkOrderID: " + Eval("WorkOrderID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>