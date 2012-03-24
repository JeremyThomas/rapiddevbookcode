
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditProductVendor.ascx.cs" Inherits="Controls_EditProductVendor" %>
<llblgenpro:LLBLGenProDataSource ID="_ProductVendorDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ProductVendorCollection, AW.Data" LivePersistence="False" OnPerformSelect="_ProductVendorDS_PerformSelect" OnPerformWork="_ProductVendorDS_PerformWork"/>
<asp:FormView ID="frmEditProductVendor" DataKeyNames="ProductID, VendorID" runat="server" DefaultMode="insert" DataSourceID="_ProductVendorDS" Cellpadding="0" OnItemCommand="frmEditProductVendor_ItemCommand" OnItemCreated="frmEditProductVendor_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AverageLeadTime:
			</td>
			<td class="content">
				<asp:textbox id="tbxAverageLeadTime" runat="server" maxlength="11" size="11" Text='<%# Bind("AverageLeadTime") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valAverageLeadTime" runat="server" ControlToValidate="tbxAverageLeadTime" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqAverageLeadTime" runat="server" ControlToValidate="tbxAverageLeadTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LastReceiptCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxLastReceiptCost" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("LastReceiptCost") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LastReceiptDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxLastReceiptDate" runat="server" Required="False" Value='<%# Bind("LastReceiptDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MaxOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxMaxOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("MaxOrderQuantity") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valMaxOrderQuantity" runat="server" ControlToValidate="tbxMaxOrderQuantity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqMaxOrderQuantity" runat="server" ControlToValidate="tbxMaxOrderQuantity" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MinOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxMinOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("MinOrderQuantity") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valMinOrderQuantity" runat="server" ControlToValidate="tbxMinOrderQuantity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqMinOrderQuantity" runat="server" ControlToValidate="tbxMinOrderQuantity" Display="Dynamic" ErrorMessage="Required" />
				
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
				OnOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxOnOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("OnOrderQuantity") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valOnOrderQuantity" runat="server" ControlToValidate="tbxOnOrderQuantity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				StandardPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxStandardPrice" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("StandardPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqStandardPrice" runat="server" ControlToValidate="tbxStandardPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("UnitMeasureCode") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUnitMeasureCode" runat="server" ControlToValidate="tbxUnitMeasureCode" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VendorID:
			</td>
			<td class="content">
				<asp:textbox id="tbxVendorID" runat="server" maxlength="11" size="11" Text='<%# Bind("VendorID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valVendorID" runat="server" ControlToValidate="tbxVendorID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqVendorID" runat="server" ControlToValidate="tbxVendorID" Display="Dynamic" ErrorMessage="Required" />
				
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
				AverageLeadTime:
			</td>
			<td class="content">
				<asp:textbox id="tbxAverageLeadTime" runat="server" maxlength="11" size="11" Text='<%# Bind("AverageLeadTime") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valAverageLeadTime" runat="server" ControlToValidate="tbxAverageLeadTime" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqAverageLeadTime" runat="server" ControlToValidate="tbxAverageLeadTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LastReceiptCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxLastReceiptCost" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("LastReceiptCost") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LastReceiptDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxLastReceiptDate" runat="server" Required="False" Value='<%# Bind("LastReceiptDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MaxOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxMaxOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("MaxOrderQuantity") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valMaxOrderQuantity" runat="server" ControlToValidate="tbxMaxOrderQuantity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqMaxOrderQuantity" runat="server" ControlToValidate="tbxMaxOrderQuantity" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MinOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxMinOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("MinOrderQuantity") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valMinOrderQuantity" runat="server" ControlToValidate="tbxMinOrderQuantity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqMinOrderQuantity" runat="server" ControlToValidate="tbxMinOrderQuantity" Display="Dynamic" ErrorMessage="Required" />
				
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
				OnOrderQuantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxOnOrderQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("OnOrderQuantity") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valOnOrderQuantity" runat="server" ControlToValidate="tbxOnOrderQuantity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				StandardPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxStandardPrice" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("StandardPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqStandardPrice" runat="server" ControlToValidate="tbxStandardPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("UnitMeasureCode") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUnitMeasureCode" runat="server" ControlToValidate="tbxUnitMeasureCode" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VendorID:
			</td>
			<td class="content">
				<asp:Label ID="lblVendorID" runat="server" Text='<%# Bind("VendorID") %>'/>			</td>
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
				AverageLeadTime:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblAverageLeadTime" runat="server" Text='<%# Bind("AverageLeadTime") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				LastReceiptCost:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblLastReceiptCost" runat="server" Text='<%# Bind("LastReceiptCost", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				LastReceiptDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblLastReceiptDate" runat="server" Text='<%# Bind("LastReceiptDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				MaxOrderQuantity:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblMaxOrderQuantity" runat="server" Text='<%# Bind("MaxOrderQuantity") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				MinOrderQuantity:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblMinOrderQuantity" runat="server" Text='<%# Bind("MinOrderQuantity") %>'/></td>
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
				OnOrderQuantity:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblOnOrderQuantity" runat="server" Text='<%# Bind("OnOrderQuantity") %>'/></td>
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
				StandardPrice:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblStandardPrice" runat="server" Text='<%# Bind("StandardPrice", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UnitMeasureCode:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkUnitMeasureCode" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.UnitMeasureEntity).ToString() + "&UnitMeasureCode=" + Eval("UnitMeasureCode")%>' Text='<%# Bind("UnitMeasureCode") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				VendorID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkVendorID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.VendorEntity).ToString() + "&VendorID=" + Eval("VendorID")%>' Text='<%# Bind("VendorID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this ProductVendor instance with PK values: "  + "ProductID: " + Eval("ProductID") + "VendorID: " + Eval("VendorID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>