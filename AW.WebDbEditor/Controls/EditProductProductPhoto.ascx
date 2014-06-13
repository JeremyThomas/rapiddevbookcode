
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditProductProductPhoto.ascx.cs" Inherits="Controls_EditProductProductPhoto" %>
<llblgenpro:LLBLGenProDataSource ID="_ProductProductPhotoDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ProductProductPhotoCollection, AW.Data" LivePersistence="False" OnPerformSelect="_ProductProductPhotoDS_PerformSelect" OnPerformWork="_ProductProductPhotoDS_PerformWork"/>
<asp:FormView ID="frmEditProductProductPhoto" DataKeyNames="ProductID, ProductPhotoID" runat="server" DefaultMode="insert" DataSourceID="_ProductProductPhotoDS" Cellpadding="0" OnItemCommand="frmEditProductProductPhoto_ItemCommand" OnItemCreated="frmEditProductProductPhoto_ItemCreated">
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
			<td class="formtexts" >
				Primary:
			</td>
			<td class="content">
				<asp:checkbox id="chkPrimary" runat="server" Checked='<%# Bind("Primary") %>' CssClass="required"/>
				
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
				ProductPhotoID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductPhotoID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductPhotoID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valProductPhotoID" runat="server" ControlToValidate="tbxProductPhotoID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqProductPhotoID" runat="server" ControlToValidate="tbxProductPhotoID" Display="Dynamic" ErrorMessage="Required" />
				
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
			<td class="formtexts" >
				Primary:
			</td>
			<td class="content">
				<asp:checkbox id="chkPrimary" runat="server" Checked='<%# Bind("Primary") %>' CssClass="required"/>
				
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
				ProductPhotoID:
			</td>
			<td class="content">
				<asp:Label ID="lblProductPhotoID" runat="server" Text='<%# Bind("ProductPhotoID") %>'/>			</td>
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
				Primary:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPrimary" runat="server" Text='<%# Bind("Primary") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkProductID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ProductEntity).ToString() + "&ProductID=" + Eval("ProductID")%>' Text='<%# Bind("ProductID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductPhotoID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkProductPhotoID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ProductPhotoEntity).ToString() + "&ProductPhotoID=" + Eval("ProductPhotoID")%>' Text='<%# Bind("ProductPhotoID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this ProductProductPhoto instance with PK values: "  + "ProductID: " + Eval("ProductID") + "ProductPhotoID: " + Eval("ProductPhotoID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>