<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchErrorLog.ascx.cs" Inherits="Controls_SearchErrorLog" %>
<asp:PlaceHolder id="phSingleInstance" runat="server" visible="true">
<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	<tr>
		<td colspan="4" class="content">
			<hr align="left" size="1">
			<b>Fill in the primary key field(s)</b><br/><br/>
		</td>
	</tr>
	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" >
			ErrorLogID:
		</td>
		<td class="content">
			<asp:textbox id="tbxErrorLogID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valErrorLogID" runat="server" ControlToValidate="tbxErrorLogID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqErrorLogID" runat="server" ControlToValidate="tbxErrorLogID" Display="Dynamic" ErrorMessage="Required" />
		</td>
		<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" nowrap="nowrap" class="content">&nbsp;</td>
		<td class="content">
			<br/>
			<asp:Button ID="btnSearchPk" runat="server" CausesValidation="True" ValidationGroup="PkSearchValidation" Text="Search..." SkinId="ButtonSkin" OnClick="btnSearchPk_Click"/>
			&nbsp;&nbsp;&nbsp;
			<asp:Button ID="btnCancelSearchPK" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			<br/><br/>
		</td>
		<td width="20" nowrap class="content">&nbsp;</td>
	</tr>

</table>
</asp:PlaceHolder>
<asp:PlaceHolder id="phMultiInstance" runat="server" visible="true">
<table cellpadding="2" border="0" cellspacing="0" class="formtexts">
	<tr>
		<td colspan="5" class="content">
			<b>Fill in one or more fields to find a subset.</b><br/>
			To enable a filter on a field, check the checkbox in front of the field. Only if you use a Between operator, you have to fill in the second value textbox(es).
			If you use the Null operator, you can leave both textbox(es) empty. If you use the Like operator, you should use the '%' character as wildcard character.
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;">&nbsp;</td>
		<td class="content tableborder"><b>Fieldname</b></td>
		<td class="content tableborder"><b>Not</b></td>
		<td class="content tableborder"><b>Operator</b></td>
		<td class="content tableborder"><b>Values</b></td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorLine" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorLine:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorLine" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorLine" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorLineMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorLineMiFrom" runat="server" ControlToValidate="tbxErrorLineMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxErrorLineMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorLineMiTo" runat="server" ControlToValidate="tbxErrorLineMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorLogID" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorLogID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorLogID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorLogID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorLogIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorLogIDMiFrom" runat="server" ControlToValidate="tbxErrorLogIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxErrorLogIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorLogIDMiTo" runat="server" ControlToValidate="tbxErrorLogIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorMessage" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorMessage:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorMessage" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorMessage" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorMessageMiFrom" runat="server" maxlength="4000" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorNumber" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorNumber:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorNumber" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorNumber" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorNumberMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorNumberMiFrom" runat="server" ControlToValidate="tbxErrorNumberMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxErrorNumberMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorNumberMiTo" runat="server" ControlToValidate="tbxErrorNumberMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorProcedure" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorProcedure:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorProcedure" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorProcedure" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorProcedureMiFrom" runat="server" maxlength="126" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorSeverity" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorSeverity:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorSeverity" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorSeverity" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorSeverityMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorSeverityMiFrom" runat="server" ControlToValidate="tbxErrorSeverityMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxErrorSeverityMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorSeverityMiTo" runat="server" ControlToValidate="tbxErrorSeverityMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorState" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorState:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorState" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorState" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
				<asp:ListItem Value="6" Text="Null"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxErrorStateMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorStateMiFrom" runat="server" ControlToValidate="tbxErrorStateMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxErrorStateMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiErrorStateMiTo" runat="server" ControlToValidate="tbxErrorStateMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableErrorTime" runat="server" /></td>
		<td class="formtexts tableborder">
			ErrorTime:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotErrorTime" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opErrorTime" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxErrorTimeMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxErrorTimeMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableUserName" runat="server" /></td>
		<td class="formtexts tableborder">
			UserName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotUserName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opUserName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxUserNameMiFrom" runat="server" maxlength="128" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td colspan="2" nowrap="nowrap" class="content">&nbsp;</td>
		<td colspan="3" class="content">
			<br/>
			<asp:Button ID="btnSearchSubSet" runat="server" CausesValidation="True" ValidationGroup="SubSetSearchValidation" Text="Search..." SkinId="ButtonSkin" OnClick="btnSearchSubSet_Click"/>
			&nbsp;&nbsp;&nbsp;
			<asp:Button ID="btnCancelSearchSubSet" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			<br/><br/>
		</td>
	</tr>
</table>
</asp:PlaceHolder>
