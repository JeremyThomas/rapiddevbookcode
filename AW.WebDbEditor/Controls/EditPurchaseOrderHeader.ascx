
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditPurchaseOrderHeader.ascx.cs" Inherits="Controls_EditPurchaseOrderHeader" %>
<llblgenpro:LLBLGenProDataSource ID="_PurchaseOrderHeaderDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.PurchaseOrderHeaderCollection, AW.Data" LivePersistence="False" OnPerformSelect="_PurchaseOrderHeaderDS_PerformSelect" OnPerformWork="_PurchaseOrderHeaderDS_PerformWork"/>
<asp:FormView ID="frmEditPurchaseOrderHeader" DataKeyNames="PurchaseOrderID" runat="server" DefaultMode="insert" DataSourceID="_PurchaseOrderHeaderDS" Cellpadding="0" OnItemCommand="frmEditPurchaseOrderHeader_ItemCommand" OnItemCreated="frmEditPurchaseOrderHeader_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				EmployeeID:
			</td>
			<td class="content">
				<asp:textbox id="tbxEmployeeID" runat="server" maxlength="11" size="11" Text='<%# Bind("EmployeeID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Freight:
			</td>
			<td class="content">
				<asp:textbox id="tbxFreight" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Freight") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqFreight" runat="server" ControlToValidate="tbxFreight" Display="Dynamic" ErrorMessage="Required" />
				
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
				OrderDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxOrderDate" runat="server" Required="True" Value='<%# Bind("OrderDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqOrderDate" runat="server" ControlToValidate="dtxOrderDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PurchaseOrderID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RevisionNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxRevisionNumber" runat="server" maxlength="3" size="3" Text='<%# Bind("RevisionNumber") %>'  CssClass="required" ValidationGroup="InsertValidations"/> * <asp:RangeValidator ID="valRevisionNumber" runat="server" ValidationGroup="InsertValidations" ControlToValidate="tbxRevisionNumber" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRevisionNumber" runat="server" ControlToValidate="tbxRevisionNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxShipDate" runat="server" Required="False" Value='<%# Bind("ShipDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipMethodID:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipMethodID" runat="server" maxlength="11" size="11" Text='<%# Bind("ShipMethodID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valShipMethodID" runat="server" ControlToValidate="tbxShipMethodID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqShipMethodID" runat="server" ControlToValidate="tbxShipMethodID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Status:
			</td>
			<td class="content">
				<asp:textbox id="tbxStatus" runat="server" maxlength="3" size="3" Text='<%# Bind("Status") %>'  CssClass="required" ValidationGroup="InsertValidations"/> * <asp:RangeValidator ID="valStatus" runat="server" ValidationGroup="InsertValidations" ControlToValidate="tbxStatus" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqStatus" runat="server" ControlToValidate="tbxStatus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SubTotal:
			</td>
			<td class="content">
				<asp:textbox id="tbxSubTotal" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SubTotal") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSubTotal" runat="server" ControlToValidate="tbxSubTotal" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TaxAmt:
			</td>
			<td class="content">
				<asp:textbox id="tbxTaxAmt" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("TaxAmt") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTaxAmt" runat="server" ControlToValidate="tbxTaxAmt" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TotalDue:
			</td>
			<td class="content">
				Field is read-only
				
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
				EmployeeID:
			</td>
			<td class="content">
				<asp:textbox id="tbxEmployeeID" runat="server" maxlength="11" size="11" Text='<%# Bind("EmployeeID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Freight:
			</td>
			<td class="content">
				<asp:textbox id="tbxFreight" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Freight") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqFreight" runat="server" ControlToValidate="tbxFreight" Display="Dynamic" ErrorMessage="Required" />
				
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
				OrderDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxOrderDate" runat="server" Required="True" Value='<%# Bind("OrderDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqOrderDate" runat="server" ControlToValidate="dtxOrderDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PurchaseOrderID:
			</td>
			<td class="content">
				<asp:Label ID="lblPurchaseOrderID" runat="server" Text='<%# Bind("PurchaseOrderID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RevisionNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxRevisionNumber" runat="server" maxlength="3" size="3" Text='<%# Bind("RevisionNumber") %>'  CssClass="required" ValidationGroup="EditValidations"/> * <asp:RangeValidator ID="valRevisionNumber" runat="server" ValidationGroup="EditValidations" ControlToValidate="tbxRevisionNumber" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqRevisionNumber" runat="server" ControlToValidate="tbxRevisionNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxShipDate" runat="server" Required="False" Value='<%# Bind("ShipDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ShipMethodID:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipMethodID" runat="server" maxlength="11" size="11" Text='<%# Bind("ShipMethodID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valShipMethodID" runat="server" ControlToValidate="tbxShipMethodID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqShipMethodID" runat="server" ControlToValidate="tbxShipMethodID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Status:
			</td>
			<td class="content">
				<asp:textbox id="tbxStatus" runat="server" maxlength="3" size="3" Text='<%# Bind("Status") %>'  CssClass="required" ValidationGroup="EditValidations"/> * <asp:RangeValidator ID="valStatus" runat="server" ValidationGroup="EditValidations" ControlToValidate="tbxStatus" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqStatus" runat="server" ControlToValidate="tbxStatus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SubTotal:
			</td>
			<td class="content">
				<asp:textbox id="tbxSubTotal" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SubTotal") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSubTotal" runat="server" ControlToValidate="tbxSubTotal" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TaxAmt:
			</td>
			<td class="content">
				<asp:textbox id="tbxTaxAmt" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("TaxAmt") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqTaxAmt" runat="server" ControlToValidate="tbxTaxAmt" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TotalDue:
			</td>
			<td class="content">
				<asp:label id="lblTotalDue" runat="server" text='<%# Bind("TotalDue") %>' />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VendorID:
			</td>
			<td class="content">
				<asp:textbox id="tbxVendorID" runat="server" maxlength="11" size="11" Text='<%# Bind("VendorID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valVendorID" runat="server" ControlToValidate="tbxVendorID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqVendorID" runat="server" ControlToValidate="tbxVendorID" Display="Dynamic" ErrorMessage="Required" />
				
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
				EmployeeID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkEmployeeID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.EmployeeEntity).ToString() + "&EmployeeID=" + Eval("EmployeeID")%>' Text='<%# Bind("EmployeeID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Freight:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblFreight" runat="server" Text='<%# Bind("Freight", "{0:0.##}") %>'/></td>
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
				OrderDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblOrderDate" runat="server" Text='<%# Bind("OrderDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PurchaseOrderID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPurchaseOrderID" runat="server" Text='<%# Bind("PurchaseOrderID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				RevisionNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRevisionNumber" runat="server" Text='<%# Bind("RevisionNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblShipDate" runat="server" Text='<%# Bind("ShipDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ShipMethodID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkShipMethodID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ShipMethodEntity).ToString() + "&ShipMethodID=" + Eval("ShipMethodID")%>' Text='<%# Bind("ShipMethodID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Status:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SubTotal:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSubTotal" runat="server" Text='<%# Bind("SubTotal", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TaxAmt:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTaxAmt" runat="server" Text='<%# Bind("TaxAmt", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TotalDue:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTotalDue" runat="server" Text='<%# Bind("TotalDue", "{0:0.##}") %>'/></td>
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
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this PurchaseOrderHeader instance with PK values: "  + "PurchaseOrderID: " + Eval("PurchaseOrderID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>