
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditEmployeePayHistory.ascx.cs" Inherits="Controls_EditEmployeePayHistory" %>
<llblgenpro:LLBLGenProDataSource ID="_EmployeePayHistoryDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.EmployeePayHistoryCollection, AW.Data" LivePersistence="False" OnPerformSelect="_EmployeePayHistoryDS_PerformSelect" OnPerformWork="_EmployeePayHistoryDS_PerformWork"/>
<asp:FormView ID="frmEditEmployeePayHistory" DataKeyNames="EmployeeID, RateChangeDate" runat="server" DefaultMode="insert" DataSourceID="_EmployeePayHistoryDS" Cellpadding="0" OnItemCommand="frmEditEmployeePayHistory_ItemCommand" OnItemCreated="frmEditEmployeePayHistory_ItemCreated">
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
				PayFrequency:
			</td>
			<td class="content">
				<asp:textbox id="tbxPayFrequency" runat="server" maxlength="3" size="3" Text='<%# Bind("PayFrequency") %>'  CssClass="required" ValidationGroup="InsertValidations"/> * <asp:RangeValidator ID="valPayFrequency" runat="server" ValidationGroup="InsertValidations" ControlToValidate="tbxPayFrequency" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqPayFrequency" runat="server" ControlToValidate="tbxPayFrequency" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rate:
			</td>
			<td class="content">
				<asp:textbox id="tbxRate" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Rate") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRate" runat="server" ControlToValidate="tbxRate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RateChangeDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxRateChangeDate" runat="server" Required="True" Value='<%# Bind("RateChangeDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRateChangeDate" runat="server" ControlToValidate="dtxRateChangeDate" Display="Dynamic" ErrorMessage="Required" />
				
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
				<asp:Label ID="lblEmployeeID" runat="server" Text='<%# Bind("EmployeeID") %>'/>			</td>
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
				PayFrequency:
			</td>
			<td class="content">
				<asp:textbox id="tbxPayFrequency" runat="server" maxlength="3" size="3" Text='<%# Bind("PayFrequency") %>'  CssClass="required" ValidationGroup="EditValidations"/> * <asp:RangeValidator ID="valPayFrequency" runat="server" ValidationGroup="EditValidations" ControlToValidate="tbxPayFrequency" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqPayFrequency" runat="server" ControlToValidate="tbxPayFrequency" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rate:
			</td>
			<td class="content">
				<asp:textbox id="tbxRate" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Rate") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqRate" runat="server" ControlToValidate="tbxRate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				RateChangeDate:
			</td>
			<td class="content">
				<asp:Label ID="lblRateChangeDate" runat="server" Text='<%# Bind("RateChangeDate", "{0:dd-MMM-yyyy}") %>'/>			</td>
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
				ModifiedDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PayFrequency:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPayFrequency" runat="server" Text='<%# Bind("PayFrequency") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Rate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRate" runat="server" Text='<%# Bind("Rate", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				RateChangeDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRateChangeDate" runat="server" Text='<%# Bind("RateChangeDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this EmployeePayHistory instance with PK values: "  + "EmployeeID: " + Eval("EmployeeID") + "RateChangeDate: " + Eval("RateChangeDate") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>