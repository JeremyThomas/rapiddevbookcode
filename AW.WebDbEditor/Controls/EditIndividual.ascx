
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditIndividual.ascx.cs" Inherits="Controls_EditIndividual" %>
<llblgenpro:LLBLGenProDataSource ID="_IndividualDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.IndividualCollection, AW.Data" LivePersistence="False" OnPerformSelect="_IndividualDS_PerformSelect" OnPerformWork="_IndividualDS_PerformWork"/>
<asp:FormView ID="frmEditIndividual" DataKeyNames="CustomerID" runat="server" DefaultMode="insert" DataSourceID="_IndividualDS" Cellpadding="0" OnItemCommand="frmEditIndividual_ItemCommand" OnItemCreated="frmEditIndividual_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AccountNumber:
			</td>
			<td class="content">
				Field is read-only
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ContactID:
			</td>
			<td class="content">
				<asp:textbox id="tbxContactID" runat="server" maxlength="11" size="11" Text='<%# Bind("ContactID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valContactID" runat="server" ControlToValidate="tbxContactID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqContactID" runat="server" ControlToValidate="tbxContactID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerType:
			</td>
			<td class="content">
				<asp:textbox id="tbxCustomerType" runat="server" maxlength="1" size="1" Text='<%# Bind("CustomerType") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCustomerType" runat="server" ControlToValidate="tbxCustomerType" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Demographics:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDemographics" runat="server" maxlength="2147483647" Text='<%# Bind("Demographics") %>' ValidationGroup="InsertValidations" /> 
				
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
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				AccountNumber:
			</td>
			<td class="content">
				<asp:label id="lblAccountNumber" runat="server" text='<%# Bind("AccountNumber") %>' />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ContactID:
			</td>
			<td class="content">
				<asp:textbox id="tbxContactID" runat="server" maxlength="11" size="11" Text='<%# Bind("ContactID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valContactID" runat="server" ControlToValidate="tbxContactID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqContactID" runat="server" ControlToValidate="tbxContactID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerID:
			</td>
			<td class="content">
				<asp:Label ID="lblCustomerID" runat="server" Text='<%# Bind("CustomerID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerType:
			</td>
			<td class="content">
				<asp:textbox id="tbxCustomerType" runat="server" maxlength="1" size="1" Text='<%# Bind("CustomerType") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCustomerType" runat="server" ControlToValidate="tbxCustomerType" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Demographics:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDemographics" runat="server" maxlength="2147483647" Text='<%# Bind("Demographics") %>' ValidationGroup="EditValidations" /> 
				
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
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				AccountNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblAccountNumber" runat="server" Text='<%# Bind("AccountNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ContactID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkContactID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ContactEntity).ToString() + "&ContactID=" + Eval("ContactID")%>' Text='<%# Bind("ContactID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CustomerID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCustomerID" runat="server" Text='<%# Bind("CustomerID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CustomerType:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCustomerType" runat="server" Text='<%# Bind("CustomerType") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Demographics:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDemographics" runat="server" Text='<%# Bind("Demographics") %>'/></td>
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
				Rowguid:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TerritoryID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTerritoryID" runat="server" Text='<%# Bind("TerritoryID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Individual instance with PK values: "  + "CustomerID: " + Eval("CustomerID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>