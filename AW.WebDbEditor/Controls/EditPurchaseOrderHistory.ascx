
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditPurchaseOrderHistory.ascx.cs" Inherits="Controls_EditPurchaseOrderHistory" %>
<llblgenpro:LLBLGenProDataSource ID="_PurchaseOrderHistoryDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.PurchaseOrderHistoryCollection, AW.Data" LivePersistence="False" OnPerformSelect="_PurchaseOrderHistoryDS_PerformSelect" OnPerformWork="_PurchaseOrderHistoryDS_PerformWork"/>
<asp:FormView ID="frmEditPurchaseOrderHistory" DataKeyNames="TransactionID" runat="server" DefaultMode="insert" DataSourceID="_PurchaseOrderHistoryDS" Cellpadding="0" OnItemCommand="frmEditPurchaseOrderHistory_ItemCommand" OnItemCreated="frmEditPurchaseOrderHistory_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActualCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualCost" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ActualCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqActualCost" runat="server" ControlToValidate="tbxActualCost" Display="Dynamic" ErrorMessage="Required" />
				
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
				Quantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("Quantity") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valQuantity" runat="server" ControlToValidate="tbxQuantity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqQuantity" runat="server" ControlToValidate="tbxQuantity" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReferenceOrderID:
			</td>
			<td class="content">
				<asp:textbox id="tbxReferenceOrderID" runat="server" maxlength="11" size="11" Text='<%# Bind("ReferenceOrderID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReferenceOrderID" runat="server" ControlToValidate="tbxReferenceOrderID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqReferenceOrderID" runat="server" ControlToValidate="tbxReferenceOrderID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReferenceOrderLineID:
			</td>
			<td class="content">
				<asp:textbox id="tbxReferenceOrderLineID" runat="server" maxlength="11" size="11" Text='<%# Bind("ReferenceOrderLineID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReferenceOrderLineID" runat="server" ControlToValidate="tbxReferenceOrderLineID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqReferenceOrderLineID" runat="server" ControlToValidate="tbxReferenceOrderLineID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxTransactionDate" runat="server" Required="True" Value='<%# Bind("TransactionDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTransactionDate" runat="server" ControlToValidate="dtxTransactionDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionType:
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
				ActualCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxActualCost" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ActualCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqActualCost" runat="server" ControlToValidate="tbxActualCost" Display="Dynamic" ErrorMessage="Required" />
				
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
				Quantity:
			</td>
			<td class="content">
				<asp:textbox id="tbxQuantity" runat="server" maxlength="11" size="11" Text='<%# Bind("Quantity") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valQuantity" runat="server" ControlToValidate="tbxQuantity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqQuantity" runat="server" ControlToValidate="tbxQuantity" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReferenceOrderID:
			</td>
			<td class="content">
				<asp:textbox id="tbxReferenceOrderID" runat="server" maxlength="11" size="11" Text='<%# Bind("ReferenceOrderID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReferenceOrderID" runat="server" ControlToValidate="tbxReferenceOrderID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqReferenceOrderID" runat="server" ControlToValidate="tbxReferenceOrderID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReferenceOrderLineID:
			</td>
			<td class="content">
				<asp:textbox id="tbxReferenceOrderLineID" runat="server" maxlength="11" size="11" Text='<%# Bind("ReferenceOrderLineID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReferenceOrderLineID" runat="server" ControlToValidate="tbxReferenceOrderLineID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqReferenceOrderLineID" runat="server" ControlToValidate="tbxReferenceOrderLineID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxTransactionDate" runat="server" Required="True" Value='<%# Bind("TransactionDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqTransactionDate" runat="server" ControlToValidate="dtxTransactionDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionID:
			</td>
			<td class="content">
				<asp:Label ID="lblTransactionID" runat="server" Text='<%# Bind("TransactionID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TransactionType:
			</td>
			<td class="content">
				<asp:label id="lblTransactionType" runat="server" text='<%# Bind("TransactionType") %>' />
				
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
				ActualCost:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActualCost" runat="server" Text='<%# Bind("ActualCost", "{0:0.##}") %>'/></td>
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
				ProductID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Quantity:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblQuantity" runat="server" Text='<%# Bind("Quantity") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ReferenceOrderID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblReferenceOrderID" runat="server" Text='<%# Bind("ReferenceOrderID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ReferenceOrderLineID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblReferenceOrderLineID" runat="server" Text='<%# Bind("ReferenceOrderLineID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TransactionDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTransactionDate" runat="server" Text='<%# Bind("TransactionDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TransactionID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTransactionID" runat="server" Text='<%# Bind("TransactionID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TransactionType:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTransactionType" runat="server" Text='<%# Bind("TransactionType") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this PurchaseOrderHistory instance with PK values: "  + "TransactionID: " + Eval("TransactionID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>