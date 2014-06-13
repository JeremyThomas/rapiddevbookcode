
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSalesOrderHeader.ascx.cs" Inherits="Controls_EditSalesOrderHeader" %>
<llblgenpro:LLBLGenProDataSource ID="_SalesOrderHeaderDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SalesOrderHeaderCollection, AW.Data" LivePersistence="False" OnPerformSelect="_SalesOrderHeaderDS_PerformSelect" OnPerformWork="_SalesOrderHeaderDS_PerformWork"/>
<asp:FormView ID="frmEditSalesOrderHeader" DataKeyNames="SalesOrderID" runat="server" DefaultMode="insert" DataSourceID="_SalesOrderHeaderDS" Cellpadding="0" OnItemCommand="frmEditSalesOrderHeader_ItemCommand" OnItemCreated="frmEditSalesOrderHeader_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AccountNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxAccountNumber" runat="server" maxlength="15" size="15" Text='<%# Bind("AccountNumber") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				BillToAddressID:
			</td>
			<td class="content">
				<asp:textbox id="tbxBillToAddressID" runat="server" maxlength="11" size="11" Text='<%# Bind("BillToAddressID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valBillToAddressID" runat="server" ControlToValidate="tbxBillToAddressID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqBillToAddressID" runat="server" ControlToValidate="tbxBillToAddressID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Comment:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxComment" runat="server" maxlength="128" Text='<%# Bind("Comment") %>' ValidationGroup="InsertValidations" /> 
				
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
				CreditCardApprovalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditCardApprovalCode" runat="server" maxlength="15" size="15" Text='<%# Bind("CreditCardApprovalCode") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CreditCardID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditCardID" runat="server" maxlength="11" size="11" Text='<%# Bind("CreditCardID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valCreditCardID" runat="server" ControlToValidate="tbxCreditCardID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CurrencyRateID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCurrencyRateID" runat="server" maxlength="11" size="11" Text='<%# Bind("CurrencyRateID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valCurrencyRateID" runat="server" ControlToValidate="tbxCurrencyRateID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCustomerID" runat="server" maxlength="11" size="11" Text='<%# Bind("CustomerID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valCustomerID" runat="server" ControlToValidate="tbxCustomerID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCustomerID" runat="server" ControlToValidate="tbxCustomerID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DueDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxDueDate" runat="server" Required="True" Value='<%# Bind("DueDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqDueDate" runat="server" ControlToValidate="dtxDueDate" Display="Dynamic" ErrorMessage="Required" />
				
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
				OnlineOrderFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkOnlineOrderFlag" runat="server" Checked='<%# Bind("OnlineOrderFlag") %>' CssClass="required"/>
				
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
				PurchaseOrderNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxPurchaseOrderNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("PurchaseOrderNumber") %>' ValidationGroup="InsertValidations" /> 
				
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
				SalesOrderID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesOrderNumber:
			</td>
			<td class="content">
				Field is read-only
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesPersonID:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesPersonID" runat="server" maxlength="11" size="11" Text='<%# Bind("SalesPersonID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valSalesPersonID" runat="server" ControlToValidate="tbxSalesPersonID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				ShipToAddressID:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipToAddressID" runat="server" maxlength="11" size="11" Text='<%# Bind("ShipToAddressID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valShipToAddressID" runat="server" ControlToValidate="tbxShipToAddressID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqShipToAddressID" runat="server" ControlToValidate="tbxShipToAddressID" Display="Dynamic" ErrorMessage="Required" />
				
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
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				<asp:textbox id="tbxAccountNumber" runat="server" maxlength="15" size="15" Text='<%# Bind("AccountNumber") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				BillToAddressID:
			</td>
			<td class="content">
				<asp:textbox id="tbxBillToAddressID" runat="server" maxlength="11" size="11" Text='<%# Bind("BillToAddressID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valBillToAddressID" runat="server" ControlToValidate="tbxBillToAddressID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqBillToAddressID" runat="server" ControlToValidate="tbxBillToAddressID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Comment:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxComment" runat="server" maxlength="128" Text='<%# Bind("Comment") %>' ValidationGroup="EditValidations" /> 
				
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
				CreditCardApprovalCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditCardApprovalCode" runat="server" maxlength="15" size="15" Text='<%# Bind("CreditCardApprovalCode") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CreditCardID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditCardID" runat="server" maxlength="11" size="11" Text='<%# Bind("CreditCardID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valCreditCardID" runat="server" ControlToValidate="tbxCreditCardID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CurrencyRateID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCurrencyRateID" runat="server" maxlength="11" size="11" Text='<%# Bind("CurrencyRateID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valCurrencyRateID" runat="server" ControlToValidate="tbxCurrencyRateID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CustomerID:
			</td>
			<td class="content">
				<asp:textbox id="tbxCustomerID" runat="server" maxlength="11" size="11" Text='<%# Bind("CustomerID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valCustomerID" runat="server" ControlToValidate="tbxCustomerID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCustomerID" runat="server" ControlToValidate="tbxCustomerID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DueDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxDueDate" runat="server" Required="True" Value='<%# Bind("DueDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqDueDate" runat="server" ControlToValidate="dtxDueDate" Display="Dynamic" ErrorMessage="Required" />
				
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
				OnlineOrderFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkOnlineOrderFlag" runat="server" Checked='<%# Bind("OnlineOrderFlag") %>' CssClass="required"/>
				
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
				PurchaseOrderNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxPurchaseOrderNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("PurchaseOrderNumber") %>' ValidationGroup="EditValidations" /> 
				
			</td>
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
				SalesOrderID:
			</td>
			<td class="content">
				<asp:Label ID="lblSalesOrderID" runat="server" Text='<%# Bind("SalesOrderID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesOrderNumber:
			</td>
			<td class="content">
				<asp:label id="lblSalesOrderNumber" runat="server" text='<%# Bind("SalesOrderNumber") %>' />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesPersonID:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesPersonID" runat="server" maxlength="11" size="11" Text='<%# Bind("SalesPersonID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valSalesPersonID" runat="server" ControlToValidate="tbxSalesPersonID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				ShipToAddressID:
			</td>
			<td class="content">
				<asp:textbox id="tbxShipToAddressID" runat="server" maxlength="11" size="11" Text='<%# Bind("ShipToAddressID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valShipToAddressID" runat="server" ControlToValidate="tbxShipToAddressID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqShipToAddressID" runat="server" ControlToValidate="tbxShipToAddressID" Display="Dynamic" ErrorMessage="Required" />
				
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
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
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
				BillToAddressID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkBillToAddressID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.AddressEntity).ToString() + "&AddressID=" + Eval("BillToAddressID")%>' Text='<%# Bind("BillToAddressID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Comment:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblComment" runat="server" Text='<%# Bind("Comment") %>'/></td>
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
				CreditCardApprovalCode:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCreditCardApprovalCode" runat="server" Text='<%# Bind("CreditCardApprovalCode") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CreditCardID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkCreditCardID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CreditCardEntity).ToString() + "&CreditCardID=" + Eval("CreditCardID")%>' Text='<%# Bind("CreditCardID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CurrencyRateID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkCurrencyRateID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CurrencyRateEntity).ToString() + "&CurrencyRateID=" + Eval("CurrencyRateID")%>' Text='<%# Bind("CurrencyRateID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CustomerID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkCustomerID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CustomerEntity).ToString() + "&CustomerID=" + Eval("CustomerID")%>' Text='<%# Bind("CustomerID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DueDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDueDate" runat="server" Text='<%# Bind("DueDate", "{0:mm/dd/yyyy}") %>'/></td>
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
				OnlineOrderFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblOnlineOrderFlag" runat="server" Text='<%# Bind("OnlineOrderFlag") %>'/></td>
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
				PurchaseOrderNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPurchaseOrderNumber" runat="server" Text='<%# Bind("PurchaseOrderNumber") %>'/></td>
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
				Rowguid:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesOrderID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesOrderID" runat="server" Text='<%# Bind("SalesOrderID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesOrderNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesOrderNumber" runat="server" Text='<%# Bind("SalesOrderNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesPersonID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkSalesPersonID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SalesPersonEntity).ToString() + "&EmployeeID=" + Eval("SalesPersonID")%>' Text='<%# Bind("SalesPersonID") %>'/></td>
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
				ShipToAddressID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkShipToAddressID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.AddressEntity).ToString() + "&AddressID=" + Eval("ShipToAddressID")%>' Text='<%# Bind("ShipToAddressID") %>'/></td>
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
				TerritoryID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkTerritoryID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SalesTerritoryEntity).ToString() + "&TerritoryID=" + Eval("TerritoryID")%>' Text='<%# Bind("TerritoryID") %>'/></td>
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
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this SalesOrderHeader instance with PK values: "  + "SalesOrderID: " + Eval("SalesOrderID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>