
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSalesTerritory.ascx.cs" Inherits="Controls_EditSalesTerritory" %>
<llblgenpro:LLBLGenProDataSource ID="_SalesTerritoryDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SalesTerritoryCollection, AW.Data" LivePersistence="False" OnPerformSelect="_SalesTerritoryDS_PerformSelect" OnPerformWork="_SalesTerritoryDS_PerformWork"/>
<asp:FormView ID="frmEditSalesTerritory" DataKeyNames="TerritoryID" runat="server" DefaultMode="insert" DataSourceID="_SalesTerritoryDS" Cellpadding="0" OnItemCommand="frmEditSalesTerritory_ItemCommand" OnItemCreated="frmEditSalesTerritory_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CostLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxCostLastYear" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("CostLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCostLastYear" runat="server" ControlToValidate="tbxCostLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CostYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxCostYtd" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("CostYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCostYtd" runat="server" ControlToValidate="tbxCostYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CountryRegionCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxCountryRegionCode" runat="server" maxlength="3" size="3" Text='<%# Bind("CountryRegionCode") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCountryRegionCode" runat="server" ControlToValidate="tbxCountryRegionCode" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Group:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxGroup" runat="server" maxlength="50" Text='<%# Bind("Group") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqGroup" runat="server" ControlToValidate="tbxGroup" Display="Dynamic" ErrorMessage="Required" />
				
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
				SalesLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesLastYear" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SalesLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSalesLastYear" runat="server" ControlToValidate="tbxSalesLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesYtd" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SalesYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSalesYtd" runat="server" ControlToValidate="tbxSalesYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryID:
			</td>
			<td class="content">
				Auto generated
				
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
				CostLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxCostLastYear" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("CostLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCostLastYear" runat="server" ControlToValidate="tbxCostLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CostYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxCostYtd" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("CostYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCostYtd" runat="server" ControlToValidate="tbxCostYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CountryRegionCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxCountryRegionCode" runat="server" maxlength="3" size="3" Text='<%# Bind("CountryRegionCode") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCountryRegionCode" runat="server" ControlToValidate="tbxCountryRegionCode" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Group:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxGroup" runat="server" maxlength="50" Text='<%# Bind("Group") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqGroup" runat="server" ControlToValidate="tbxGroup" Display="Dynamic" ErrorMessage="Required" />
				
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
				SalesLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesLastYear" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SalesLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSalesLastYear" runat="server" ControlToValidate="tbxSalesLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesYtd" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SalesYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSalesYtd" runat="server" ControlToValidate="tbxSalesYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryID:
			</td>
			<td class="content">
				<asp:Label ID="lblTerritoryID" runat="server" Text='<%# Bind("TerritoryID") %>'/>			</td>
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
				CostLastYear:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCostLastYear" runat="server" Text='<%# Bind("CostLastYear", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CostYtd:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCostYtd" runat="server" Text='<%# Bind("CostYtd", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CountryRegionCode:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCountryRegionCode" runat="server" Text='<%# Bind("CountryRegionCode") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Group:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblGroup" runat="server" Text='<%# Bind("Group") %>'/></td>
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
				SalesLastYear:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesLastYear" runat="server" Text='<%# Bind("SalesLastYear", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesYtd:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesYtd" runat="server" Text='<%# Bind("SalesYtd", "{0:0.##}") %>'/></td>
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
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this SalesTerritory instance with PK values: "  + "TerritoryID: " + Eval("TerritoryID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>