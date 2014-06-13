<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchSalesPerson.ascx.cs" Inherits="Controls_SearchSalesPerson" %>
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
			EmployeeID:
		</td>
		<td class="content">
			<asp:textbox id="tbxEmployeeID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqEmployeeID" runat="server" ControlToValidate="tbxEmployeeID" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableBirthDate" runat="server" /></td>
		<td class="formtexts tableborder">
			BirthDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotBirthDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opBirthDate" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxBirthDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxBirthDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableBonus" runat="server" /></td>
		<td class="formtexts tableborder">
			Bonus:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotBonus" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opBonus" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxBonusMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxBonusMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCommissionPct" runat="server" /></td>
		<td class="formtexts tableborder">
			CommissionPct:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCommissionPct" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCommissionPct" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxCommissionPctMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxCommissionPctMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableContactID" runat="server" /></td>
		<td class="formtexts tableborder">
			ContactID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotContactID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opContactID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxContactIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiContactIDMiFrom" runat="server" ControlToValidate="tbxContactIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxContactIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiContactIDMiTo" runat="server" ControlToValidate="tbxContactIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableCurrentFlag" runat="server" /></td>
		<td class="formtexts tableborder">
			CurrentFlag:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotCurrentFlag" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opCurrentFlag" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:checkbox id="chkCurrentFlagMiFrom" runat="server" Checked=""/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableEmployeeID" runat="server" /></td>
		<td class="formtexts tableborder">
			EmployeeID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotEmployeeID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opEmployeeID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxEmployeeIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiEmployeeIDMiFrom" runat="server" ControlToValidate="tbxEmployeeIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxEmployeeIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiEmployeeIDMiTo" runat="server" ControlToValidate="tbxEmployeeIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableGender" runat="server" /></td>
		<td class="formtexts tableborder">
			Gender:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotGender" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opGender" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxGenderMiFrom" runat="server" maxlength="1" size="1" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableHireDate" runat="server" /></td>
		<td class="formtexts tableborder">
			HireDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotHireDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opHireDate" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxHireDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxHireDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableLoginID" runat="server" /></td>
		<td class="formtexts tableborder">
			LoginID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotLoginID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opLoginID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxLoginIDMiFrom" runat="server" maxlength="256" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableManagerID" runat="server" /></td>
		<td class="formtexts tableborder">
			ManagerID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotManagerID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opManagerID" runat="server">
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
			<asp:textbox id="tbxManagerIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiManagerIDMiFrom" runat="server" ControlToValidate="tbxManagerIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxManagerIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiManagerIDMiTo" runat="server" ControlToValidate="tbxManagerIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableMaritalStatus" runat="server" /></td>
		<td class="formtexts tableborder">
			MaritalStatus:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotMaritalStatus" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opMaritalStatus" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxMaritalStatusMiFrom" runat="server" maxlength="1" size="1" Text="" ValidationGroup="SubSetSearchValidation" /> 
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableNationalIdnumber" runat="server" /></td>
		<td class="formtexts tableborder">
			NationalIdnumber:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotNationalIdnumber" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opNationalIdnumber" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxNationalIdnumberMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSalariedFlag" runat="server" /></td>
		<td class="formtexts tableborder">
			SalariedFlag:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSalariedFlag" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSalariedFlag" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:checkbox id="chkSalariedFlagMiFrom" runat="server" Checked=""/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSalesLastYear" runat="server" /></td>
		<td class="formtexts tableborder">
			SalesLastYear:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSalesLastYear" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSalesLastYear" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSalesLastYearMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxSalesLastYearMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSalesQuota" runat="server" /></td>
		<td class="formtexts tableborder">
			SalesQuota:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSalesQuota" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSalesQuota" runat="server">
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
			<asp:textbox id="tbxSalesQuotaMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxSalesQuotaMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSalesYtd" runat="server" /></td>
		<td class="formtexts tableborder">
			SalesYtd:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSalesYtd" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSalesYtd" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSalesYtdMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxSalesYtdMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSickLeaveHours" runat="server" /></td>
		<td class="formtexts tableborder">
			SickLeaveHours:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSickLeaveHours" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSickLeaveHours" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSickLeaveHoursMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSickLeaveHoursMiFrom" runat="server" ControlToValidate="tbxSickLeaveHoursMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxSickLeaveHoursMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSickLeaveHoursMiTo" runat="server" ControlToValidate="tbxSickLeaveHoursMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableTerritoryID" runat="server" /></td>
		<td class="formtexts tableborder">
			TerritoryID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotTerritoryID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opTerritoryID" runat="server">
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
			<asp:textbox id="tbxTerritoryIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiTerritoryIDMiFrom" runat="server" ControlToValidate="tbxTerritoryIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxTerritoryIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiTerritoryIDMiTo" runat="server" ControlToValidate="tbxTerritoryIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
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
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxTitleMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableVacationHours" runat="server" /></td>
		<td class="formtexts tableborder">
			VacationHours:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotVacationHours" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opVacationHours" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxVacationHoursMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiVacationHoursMiFrom" runat="server" ControlToValidate="tbxVacationHoursMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxVacationHoursMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiVacationHoursMiTo" runat="server" ControlToValidate="tbxVacationHoursMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
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
