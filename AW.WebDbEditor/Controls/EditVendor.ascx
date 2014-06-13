
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditVendor.ascx.cs" Inherits="Controls_EditVendor" %>
<llblgenpro:LLBLGenProDataSource ID="_VendorDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.VendorCollection, AW.Data" LivePersistence="False" OnPerformSelect="_VendorDS_PerformSelect" OnPerformWork="_VendorDS_PerformWork"/>
<asp:FormView ID="frmEditVendor" DataKeyNames="VendorID" runat="server" DefaultMode="insert" DataSourceID="_VendorDS" Cellpadding="0" OnItemCommand="frmEditVendor_ItemCommand" OnItemCreated="frmEditVendor_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				AccountNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxAccountNumber" runat="server" maxlength="15" size="15" Text='<%# Bind("AccountNumber") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqAccountNumber" runat="server" ControlToValidate="tbxAccountNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActiveFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkActiveFlag" runat="server" Checked='<%# Bind("ActiveFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CreditRating:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditRating" runat="server" maxlength="3" size="3" Text='<%# Bind("CreditRating") %>'  CssClass="required" ValidationGroup="InsertValidations"/> * <asp:RangeValidator ID="valCreditRating" runat="server" ValidationGroup="InsertValidations" ControlToValidate="tbxCreditRating" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCreditRating" runat="server" ControlToValidate="tbxCreditRating" Display="Dynamic" ErrorMessage="Required" />
				
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
				PreferredVendorStatus:
			</td>
			<td class="content">
				<asp:checkbox id="chkPreferredVendorStatus" runat="server" Checked='<%# Bind("PreferredVendorStatus") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				PurchasingWebServiceUrl:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxPurchasingWebServiceUrl" runat="server" maxlength="1024" Text='<%# Bind("PurchasingWebServiceUrl") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VendorID:
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
				AccountNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxAccountNumber" runat="server" maxlength="15" size="15" Text='<%# Bind("AccountNumber") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqAccountNumber" runat="server" ControlToValidate="tbxAccountNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ActiveFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkActiveFlag" runat="server" Checked='<%# Bind("ActiveFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CreditRating:
			</td>
			<td class="content">
				<asp:textbox id="tbxCreditRating" runat="server" maxlength="3" size="3" Text='<%# Bind("CreditRating") %>'  CssClass="required" ValidationGroup="EditValidations"/> * <asp:RangeValidator ID="valCreditRating" runat="server" ValidationGroup="EditValidations" ControlToValidate="tbxCreditRating" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCreditRating" runat="server" ControlToValidate="tbxCreditRating" Display="Dynamic" ErrorMessage="Required" />
				
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
				PreferredVendorStatus:
			</td>
			<td class="content">
				<asp:checkbox id="chkPreferredVendorStatus" runat="server" Checked='<%# Bind("PreferredVendorStatus") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				PurchasingWebServiceUrl:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxPurchasingWebServiceUrl" runat="server" maxlength="1024" Text='<%# Bind("PurchasingWebServiceUrl") %>' ValidationGroup="EditValidations" /> 
				
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
				AccountNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblAccountNumber" runat="server" Text='<%# Bind("AccountNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ActiveFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblActiveFlag" runat="server" Text='<%# Bind("ActiveFlag") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CreditRating:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCreditRating" runat="server" Text='<%# Bind("CreditRating") %>'/></td>
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
				PreferredVendorStatus:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPreferredVendorStatus" runat="server" Text='<%# Bind("PreferredVendorStatus") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PurchasingWebServiceUrl:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPurchasingWebServiceUrl" runat="server" Text='<%# Bind("PurchasingWebServiceUrl") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				VendorID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblVendorID" runat="server" Text='<%# Bind("VendorID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Vendor instance with PK values: "  + "VendorID: " + Eval("VendorID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>