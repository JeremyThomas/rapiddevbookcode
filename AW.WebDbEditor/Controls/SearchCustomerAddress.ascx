<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchCustomerAddress.ascx.cs" Inherits="Controls_SearchCustomerAddress" %>
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
			AddressID:
		</td>
		<td class="content">
			<asp:textbox id="tbxAddressID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valAddressID" runat="server" ControlToValidate="tbxAddressID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqAddressID" runat="server" ControlToValidate="tbxAddressID" Display="Dynamic" ErrorMessage="Required" />
		</td>
		<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>
	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" >
			CustomerID:
		</td>
		<td class="content">
			<asp:textbox id="tbxCustomerID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valCustomerID" runat="server" ControlToValidate="tbxCustomerID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqCustomerID" runat="server" ControlToValidate="tbxCustomerID" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddressID" runat="server" /></td>
		<td class="formtexts tableborder">
			AddressID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddressID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddressID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAddressIDMiFrom" runat="server" ControlToValidate="tbxAddressIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxAddressIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAddressIDMiTo" runat="server" ControlToValidate="tbxAddressIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddressTypeID" runat="server" /></td>
		<td class="formtexts tableborder">
			AddressTypeID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddressTypeID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddressTypeID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressTypeIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAddressTypeIDMiFrom" runat="server" ControlToValidate="tbxAddressTypeIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxAddressTypeIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiAddressTypeIDMiTo" runat="server" ControlToValidate="tbxAddressTypeIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCustomerID" runat="server" /></td>
		<td class="formtexts tableborder">
			CustomerID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCustomerID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCustomerID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCustomerIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCustomerIDMiFrom" runat="server" ControlToValidate="tbxCustomerIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxCustomerIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCustomerIDMiTo" runat="server" ControlToValidate="tbxCustomerIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableModifiedDate" runat="server" /></td>
		<td class="formtexts tableborder">
			ModifiedDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotModifiedDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opModifiedDate" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxModifiedDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxModifiedDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableRowguid" runat="server" /></td>
		<td class="formtexts tableborder">
			Rowguid:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotRowguid" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opRowguid" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxRowguidMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" maxlength="38" size="40" /> 
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
