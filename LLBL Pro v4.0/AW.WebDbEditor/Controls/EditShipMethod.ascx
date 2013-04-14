
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditShipMethod.ascx.cs" Inherits="Controls_EditShipMethod" %>
<llblgenpro:LLBLGenProDataSource ID="_ShipMethodDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ShipMethodCollection, AW.Data" LivePersistence="False" OnPerformSelect="_ShipMethodDS_PerformSelect" OnPerformWork="_ShipMethodDS_PerformWork"/>
<asp:FormView ID="frmEditShipMethod" DataKeyNames="ShipMethodID" runat="server" DefaultMode="insert" DataSourceID="_ShipMethodDS" Cellpadding="0" OnItemCommand="frmEditShipMethod_ItemCommand" OnItemCreated="frmEditShipMethod_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
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
			<td class="formtexts"  valign="top" >
				Name:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxName" runat="server" maxlength="50" Text='<%# Bind("Name") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqName" runat="server" ControlToValidate="tbxName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rowguid:
			</td>
			<td class="content">
				<asp:textbox id="tbxRowguid" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Rowguid") %>' maxlength="38" size="40"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRowguid" runat="server" ControlToValidate="tbxRowguid" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipBase:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipBase" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ShipBase") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqShipBase" runat="server" ControlToValidate="tbxShipBase" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipMethodID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipRate:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipRate" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ShipRate") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqShipRate" runat="server" ControlToValidate="tbxShipRate" Display="Dynamic" ErrorMessage="Required" />
				
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
				ModifiedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxModifiedDate" runat="server" Required="True" Value='<%# Bind("ModifiedDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqModifiedDate" runat="server" ControlToValidate="dtxModifiedDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Name:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxName" runat="server" maxlength="50" Text='<%# Bind("Name") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqName" runat="server" ControlToValidate="tbxName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rowguid:
			</td>
			<td class="content">
				<asp:textbox id="tbxRowguid" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Rowguid") %>' maxlength="38" size="40"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqRowguid" runat="server" ControlToValidate="tbxRowguid" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipBase:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipBase" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ShipBase") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqShipBase" runat="server" ControlToValidate="tbxShipBase" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipMethodID:
			</td>
			<td class="content">
				<asp:Label ID="lblShipMethodID" runat="server" Text='<%# Bind("ShipMethodID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipRate:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipRate" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ShipRate") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqShipRate" runat="server" ControlToValidate="tbxShipRate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
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
				ModifiedDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Name:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Rowguid:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipBase:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblShipBase" runat="server" Text='<%# Bind("ShipBase", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipMethodID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblShipMethodID" runat="server" Text='<%# Bind("ShipMethodID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipRate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblShipRate" runat="server" Text='<%# Bind("ShipRate", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this ShipMethod instance with PK values: "  + "ShipMethodID: " + Eval("ShipMethodID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>