
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditErrorLog.ascx.cs" Inherits="Controls_EditErrorLog" %>
<llblgenpro:LLBLGenProDataSource ID="_ErrorLogDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ErrorLogCollection, AW.Data" LivePersistence="False" OnPerformSelect="_ErrorLogDS_PerformSelect" OnPerformWork="_ErrorLogDS_PerformWork"/>
<asp:FormView ID="frmEditErrorLog" DataKeyNames="ErrorLogID" runat="server" DefaultMode="insert" DataSourceID="_ErrorLogDS" Cellpadding="0" OnItemCommand="frmEditErrorLog_ItemCommand" OnItemCreated="frmEditErrorLog_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorLine:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorLine" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorLine") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valErrorLine" runat="server" ControlToValidate="tbxErrorLine" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorLogID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ErrorMessage:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxErrorMessage" runat="server" maxlength="4000" Text='<%# Bind("ErrorMessage") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqErrorMessage" runat="server" ControlToValidate="tbxErrorMessage" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorNumber" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorNumber") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valErrorNumber" runat="server" ControlToValidate="tbxErrorNumber" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqErrorNumber" runat="server" ControlToValidate="tbxErrorNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ErrorProcedure:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxErrorProcedure" runat="server" maxlength="126" Text='<%# Bind("ErrorProcedure") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorSeverity:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorSeverity" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorSeverity") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valErrorSeverity" runat="server" ControlToValidate="tbxErrorSeverity" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorState:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorState" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorState") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valErrorState" runat="server" ControlToValidate="tbxErrorState" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxErrorTime" runat="server" Required="True" Value='<%# Bind("ErrorTime") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqErrorTime" runat="server" ControlToValidate="dtxErrorTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				UserName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxUserName" runat="server" maxlength="128" Text='<%# Bind("UserName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqUserName" runat="server" ControlToValidate="tbxUserName" Display="Dynamic" ErrorMessage="Required" />
				
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
				ErrorLine:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorLine" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorLine") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valErrorLine" runat="server" ControlToValidate="tbxErrorLine" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorLogID:
			</td>
			<td class="content">
				<asp:Label ID="lblErrorLogID" runat="server" Text='<%# Bind("ErrorLogID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ErrorMessage:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxErrorMessage" runat="server" maxlength="4000" Text='<%# Bind("ErrorMessage") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqErrorMessage" runat="server" ControlToValidate="tbxErrorMessage" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorNumber" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorNumber") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valErrorNumber" runat="server" ControlToValidate="tbxErrorNumber" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqErrorNumber" runat="server" ControlToValidate="tbxErrorNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				ErrorProcedure:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxErrorProcedure" runat="server" maxlength="126" Text='<%# Bind("ErrorProcedure") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorSeverity:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorSeverity" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorSeverity") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valErrorSeverity" runat="server" ControlToValidate="tbxErrorSeverity" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorState:
			</td>
			<td class="content">
				<asp:textbox id="tbxErrorState" runat="server" maxlength="11" size="11" Text='<%# Bind("ErrorState") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valErrorState" runat="server" ControlToValidate="tbxErrorState" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ErrorTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxErrorTime" runat="server" Required="True" Value='<%# Bind("ErrorTime") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqErrorTime" runat="server" ControlToValidate="dtxErrorTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				UserName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxUserName" runat="server" maxlength="128" Text='<%# Bind("UserName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqUserName" runat="server" ControlToValidate="tbxUserName" Display="Dynamic" ErrorMessage="Required" />
				
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
				ErrorLine:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorLine" runat="server" Text='<%# Bind("ErrorLine") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorLogID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorLogID" runat="server" Text='<%# Bind("ErrorLogID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorMessage:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorMessage" runat="server" Text='<%# Bind("ErrorMessage") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorNumber" runat="server" Text='<%# Bind("ErrorNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorProcedure:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorProcedure" runat="server" Text='<%# Bind("ErrorProcedure") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorSeverity:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorSeverity" runat="server" Text='<%# Bind("ErrorSeverity") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorState:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorState" runat="server" Text='<%# Bind("ErrorState") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ErrorTime:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblErrorTime" runat="server" Text='<%# Bind("ErrorTime", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				UserName:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblUserName" runat="server" Text='<%# Bind("UserName") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this ErrorLog instance with PK values: "  + "ErrorLogID: " + Eval("ErrorLogID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>