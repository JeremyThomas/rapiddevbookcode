<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchDatabaseLog.ascx.cs" Inherits="Controls_SearchDatabaseLog" %>
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
			DatabaseLogID:
		</td>
		<td class="content">
			<asp:textbox id="tbxDatabaseLogID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valDatabaseLogID" runat="server" ControlToValidate="tbxDatabaseLogID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqDatabaseLogID" runat="server" ControlToValidate="tbxDatabaseLogID" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDatabaseLogID" runat="server" /></td>
		<td class="formtexts tableborder">
			DatabaseLogID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDatabaseLogID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDatabaseLogID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxDatabaseLogIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiDatabaseLogIDMiFrom" runat="server" ControlToValidate="tbxDatabaseLogIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxDatabaseLogIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiDatabaseLogIDMiTo" runat="server" ControlToValidate="tbxDatabaseLogIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDatabaseUser" runat="server" /></td>
		<td class="formtexts tableborder">
			DatabaseUser:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDatabaseUser" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDatabaseUser" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxDatabaseUserMiFrom" runat="server" maxlength="128" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableEvent" runat="server" /></td>
		<td class="formtexts tableborder">
			Event:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotEvent" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opEvent" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxEventMiFrom" runat="server" maxlength="128" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableObject" runat="server" /></td>
		<td class="formtexts tableborder">
			Object:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotObject" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opObject" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxObjectMiFrom" runat="server" maxlength="128" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePostTime" runat="server" /></td>
		<td class="formtexts tableborder">
			PostTime:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPostTime" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPostTime" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxPostTimeMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxPostTimeMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSchema" runat="server" /></td>
		<td class="formtexts tableborder">
			Schema:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSchema" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSchema" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSchemaMiFrom" runat="server" maxlength="128" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableTsql" runat="server" /></td>
		<td class="formtexts tableborder">
			Tsql:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotTsql" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opTsql" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxTsqlMiFrom" runat="server" maxlength="2147483647" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableXmlEvent" runat="server" /></td>
		<td class="formtexts tableborder">
			XmlEvent:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotXmlEvent" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opXmlEvent" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxXmlEventMiFrom" runat="server" maxlength="2147483647" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
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
