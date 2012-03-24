
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSalesOrderDetail.ascx.cs" Inherits="Controls_EditSalesOrderDetail" %>
<llblgenpro:LLBLGenProDataSource ID="_SalesOrderDetailDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SalesOrderDetailCollection, AW.Data" LivePersistence="False" OnPerformSelect="_SalesOrderDetailDS_PerformSelect" OnPerformWork="_SalesOrderDetailDS_PerformWork"/>
<asp:FormView ID="frmEditSalesOrderDetail" DataKeyNames="SalesOrderDetailID, SalesOrderID" runat="server" DefaultMode="insert" DataSourceID="_SalesOrderDetailDS" Cellpadding="0" OnItemCommand="frmEditSalesOrderDetail_ItemCommand" OnItemCreated="frmEditSalesOrderDetail_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CarrierTrackingNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxCarrierTrackingNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("CarrierTrackingNumber") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LineTotal:
			</td>
			<td class="content">
				Field is read-only
				
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
				OrderQty:
			</td>
			<td class="content">
				<asp:textbox id="tbxOrderQty" runat="server" maxlength="6" size="6" Text='<%# Bind("OrderQty") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valOrderQty" runat="server" ControlToValidate="tbxOrderQty" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqOrderQty" runat="server" ControlToValidate="tbxOrderQty" Display="Dynamic" ErrorMessage="Required" />
				
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
				SalesOrderDetailID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesOrderID:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesOrderID" runat="server" maxlength="11" size="11" Text='<%# Bind("SalesOrderID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSalesOrderID" runat="server" ControlToValidate="tbxSalesOrderID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSalesOrderID" runat="server" ControlToValidate="tbxSalesOrderID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SpecialOfferID:
			</td>
			<td class="content">
				<asp:textbox id="tbxSpecialOfferID" runat="server" maxlength="11" size="11" Text='<%# Bind("SpecialOfferID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSpecialOfferID" runat="server" ControlToValidate="tbxSpecialOfferID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSpecialOfferID" runat="server" ControlToValidate="tbxSpecialOfferID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("UnitPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUnitPrice" runat="server" ControlToValidate="tbxUnitPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPriceDiscount:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPriceDiscount" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("UnitPriceDiscount") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUnitPriceDiscount" runat="server" ControlToValidate="tbxUnitPriceDiscount" Display="Dynamic" ErrorMessage="Required" />
				
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
				CarrierTrackingNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxCarrierTrackingNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("CarrierTrackingNumber") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				LineTotal:
			</td>
			<td class="content">
				<asp:label id="lblLineTotal" runat="server" text='<%# Bind("LineTotal") %>' />
				
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
				OrderQty:
			</td>
			<td class="content">
				<asp:textbox id="tbxOrderQty" runat="server" maxlength="6" size="6" Text='<%# Bind("OrderQty") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valOrderQty" runat="server" ControlToValidate="tbxOrderQty" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqOrderQty" runat="server" ControlToValidate="tbxOrderQty" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valProductID" runat="server" ControlToValidate="tbxProductID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqProductID" runat="server" ControlToValidate="tbxProductID" Display="Dynamic" ErrorMessage="Required" />
				
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
				SalesOrderDetailID:
			</td>
			<td class="content">
				<asp:Label ID="lblSalesOrderDetailID" runat="server" Text='<%# Bind("SalesOrderDetailID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesOrderID:
			</td>
			<td class="content">
				<asp:Label ID="lblSalesOrderID" runat="server" Text='<%# Bind("SalesOrderID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SpecialOfferID:
			</td>
			<td class="content">
				<asp:textbox id="tbxSpecialOfferID" runat="server" maxlength="11" size="11" Text='<%# Bind("SpecialOfferID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSpecialOfferID" runat="server" ControlToValidate="tbxSpecialOfferID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSpecialOfferID" runat="server" ControlToValidate="tbxSpecialOfferID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPrice" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("UnitPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUnitPrice" runat="server" ControlToValidate="tbxUnitPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				UnitPriceDiscount:
			</td>
			<td class="content">
				<asp:textbox id="tbxUnitPriceDiscount" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("UnitPriceDiscount") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUnitPriceDiscount" runat="server" ControlToValidate="tbxUnitPriceDiscount" Display="Dynamic" ErrorMessage="Required" />
				
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
				CarrierTrackingNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCarrierTrackingNumber" runat="server" Text='<%# Bind("CarrierTrackingNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				LineTotal:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblLineTotal" runat="server" Text='<%# Bind("LineTotal", "{0:0.##}") %>'/></td>
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
				OrderQty:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblOrderQty" runat="server" Text='<%# Bind("OrderQty") %>'/></td>
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
				Rowguid:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesOrderDetailID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesOrderDetailID" runat="server" Text='<%# Bind("SalesOrderDetailID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesOrderID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkSalesOrderID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SalesOrderHeaderEntity).ToString() + "&SalesOrderID=" + Eval("SalesOrderID")%>' Text='<%# Bind("SalesOrderID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SpecialOfferID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSpecialOfferID" runat="server" Text='<%# Bind("SpecialOfferID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UnitPrice:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblUnitPrice" runat="server" Text='<%# Bind("UnitPrice", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UnitPriceDiscount:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblUnitPriceDiscount" runat="server" Text='<%# Bind("UnitPriceDiscount", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this SalesOrderDetail instance with PK values: "  + "SalesOrderDetailID: " + Eval("SalesOrderDetailID") + "SalesOrderID: " + Eval("SalesOrderID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>