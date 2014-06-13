<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchCustomerViewRelated.ascx.cs" Inherits="Controls_SearchCustomerViewRelated" %>
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
			CustomerId:
		</td>
		<td class="content">
			<asp:textbox id="tbxCustomerId" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valCustomerId" runat="server" ControlToValidate="tbxCustomerId" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqCustomerId" runat="server" ControlToValidate="tbxCustomerId" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddressLine1" runat="server" /></td>
		<td class="formtexts tableborder">
			AddressLine1:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddressLine1" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddressLine1" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressLine1MiFrom" runat="server" maxlength="60" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddressLine2" runat="server" /></td>
		<td class="formtexts tableborder">
			AddressLine2:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddressLine2" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddressLine2" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressLine2MiFrom" runat="server" maxlength="60" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableAddressType" runat="server" /></td>
		<td class="formtexts tableborder">
			AddressType:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotAddressType" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opAddressType" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxAddressTypeMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCity" runat="server" /></td>
		<td class="formtexts tableborder">
			City:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCity" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCity" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCityMiFrom" runat="server" maxlength="30" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCountryRegionName" runat="server" /></td>
		<td class="formtexts tableborder">
			CountryRegionName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCountryRegionName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCountryRegionName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCountryRegionNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCustomerId" runat="server" /></td>
		<td class="formtexts tableborder">
			CustomerId:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCustomerId" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCustomerId" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCustomerIdMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCustomerIdMiFrom" runat="server" ControlToValidate="tbxCustomerIdMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxCustomerIdMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiCustomerIdMiTo" runat="server" ControlToValidate="tbxCustomerIdMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDemographics" runat="server" /></td>
		<td class="formtexts tableborder">
			Demographics:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDemographics" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDemographics" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxDemographicsMiFrom" runat="server" maxlength="2147483647" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableEmailAddress" runat="server" /></td>
		<td class="formtexts tableborder">
			EmailAddress:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotEmailAddress" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opEmailAddress" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxEmailAddressMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableEmailPromotion" runat="server" /></td>
		<td class="formtexts tableborder">
			EmailPromotion:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotEmailPromotion" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opEmailPromotion" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxEmailPromotionMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiEmailPromotionMiFrom" runat="server" ControlToValidate="tbxEmailPromotionMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxEmailPromotionMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiEmailPromotionMiTo" runat="server" ControlToValidate="tbxEmailPromotionMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableFirstName" runat="server" /></td>
		<td class="formtexts tableborder">
			FirstName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotFirstName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opFirstName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxFirstNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableLastName" runat="server" /></td>
		<td class="formtexts tableborder">
			LastName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotLastName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opLastName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxLastNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableMiddleName" runat="server" /></td>
		<td class="formtexts tableborder">
			MiddleName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotMiddleName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opMiddleName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxMiddleNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePhone" runat="server" /></td>
		<td class="formtexts tableborder">
			Phone:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPhone" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPhone" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxPhoneMiFrom" runat="server" maxlength="25" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePostalCode" runat="server" /></td>
		<td class="formtexts tableborder">
			PostalCode:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPostalCode" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPostalCode" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxPostalCodeMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableStateProvinceName" runat="server" /></td>
		<td class="formtexts tableborder">
			StateProvinceName:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotStateProvinceName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opStateProvinceName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxStateProvinceNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSuffix" runat="server" /></td>
		<td class="formtexts tableborder">
			Suffix:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSuffix" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSuffix" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSuffixMiFrom" runat="server" maxlength="10" size="10" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableTitle" runat="server" /></td>
		<td class="formtexts tableborder">
			Title:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotTitle" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opTitle" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxTitleMiFrom" runat="server" maxlength="8" size="8" Text="" ValidationGroup="SubSetSearchValidation" /> 
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
