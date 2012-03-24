<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchProduct.ascx.cs" Inherits="Controls_SearchProduct" %>
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
			ProductID:
		</td>
		<td class="content">
			<asp:textbox id="tbxProductID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valProductID" runat="server" ControlToValidate="tbxProductID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqProductID" runat="server" ControlToValidate="tbxProductID" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableClass" runat="server" /></td>
		<td class="formtexts tableborder">
			Class:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotClass" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opClass" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxClassMiFrom" runat="server" maxlength="2" size="2" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableColor" runat="server" /></td>
		<td class="formtexts tableborder">
			Color:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotColor" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opColor" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxColorMiFrom" runat="server" maxlength="15" size="15" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDaysToManufacture" runat="server" /></td>
		<td class="formtexts tableborder">
			DaysToManufacture:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDaysToManufacture" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDaysToManufacture" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxDaysToManufactureMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiDaysToManufactureMiFrom" runat="server" ControlToValidate="tbxDaysToManufactureMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxDaysToManufactureMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiDaysToManufactureMiTo" runat="server" ControlToValidate="tbxDaysToManufactureMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableDiscontinuedDate" runat="server" /></td>
		<td class="formtexts tableborder">
			DiscontinuedDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotDiscontinuedDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opDiscontinuedDate" runat="server">
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
			<cc:datetextbox id="dtxDiscontinuedDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxDiscontinuedDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableFinishedGoodsFlag" runat="server" /></td>
		<td class="formtexts tableborder">
			FinishedGoodsFlag:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotFinishedGoodsFlag" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opFinishedGoodsFlag" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:checkbox id="chkFinishedGoodsFlagMiFrom" runat="server" Checked=""/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableListPrice" runat="server" /></td>
		<td class="formtexts tableborder">
			ListPrice:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotListPrice" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opListPrice" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxListPriceMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxListPriceMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableMakeFlag" runat="server" /></td>
		<td class="formtexts tableborder">
			MakeFlag:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotMakeFlag" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opMakeFlag" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:checkbox id="chkMakeFlagMiFrom" runat="server" Checked=""/>
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableName" runat="server" /></td>
		<td class="formtexts tableborder">
			Name:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotName" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opName" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxNameMiFrom" runat="server" maxlength="50" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductID" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxProductIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductIDMiFrom" runat="server" ControlToValidate="tbxProductIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxProductIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductIDMiTo" runat="server" ControlToValidate="tbxProductIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductLine" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductLine:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductLine" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductLine" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxProductLineMiFrom" runat="server" maxlength="2" size="2" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductModelID" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductModelID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductModelID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductModelID" runat="server">
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
			<asp:textbox id="tbxProductModelIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductModelIDMiFrom" runat="server" ControlToValidate="tbxProductModelIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxProductModelIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductModelIDMiTo" runat="server" ControlToValidate="tbxProductModelIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductNumber" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductNumber:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductNumber" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductNumber" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxProductNumberMiFrom" runat="server" maxlength="25" size="25" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableProductSubcategoryID" runat="server" /></td>
		<td class="formtexts tableborder">
			ProductSubcategoryID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotProductSubcategoryID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opProductSubcategoryID" runat="server">
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
			<asp:textbox id="tbxProductSubcategoryIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductSubcategoryIDMiFrom" runat="server" ControlToValidate="tbxProductSubcategoryIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxProductSubcategoryIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiProductSubcategoryIDMiTo" runat="server" ControlToValidate="tbxProductSubcategoryIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableReorderPoint" runat="server" /></td>
		<td class="formtexts tableborder">
			ReorderPoint:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotReorderPoint" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opReorderPoint" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxReorderPointMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiReorderPointMiFrom" runat="server" ControlToValidate="tbxReorderPointMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxReorderPointMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiReorderPointMiTo" runat="server" ControlToValidate="tbxReorderPointMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSafetyStockLevel" runat="server" /></td>
		<td class="formtexts tableborder">
			SafetyStockLevel:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSafetyStockLevel" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSafetyStockLevel" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSafetyStockLevelMiFrom" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSafetyStockLevelMiFrom" runat="server" ControlToValidate="tbxSafetyStockLevelMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
			and
			<asp:textbox id="tbxSafetyStockLevelMiTo" runat="server" maxlength="6" size="6" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiSafetyStockLevelMiTo" runat="server" ControlToValidate="tbxSafetyStockLevelMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSellEndDate" runat="server" /></td>
		<td class="formtexts tableborder">
			SellEndDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSellEndDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSellEndDate" runat="server">
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
			<cc:datetextbox id="dtxSellEndDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxSellEndDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSellStartDate" runat="server" /></td>
		<td class="formtexts tableborder">
			SellStartDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSellStartDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSellStartDate" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxSellStartDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxSellStartDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSize" runat="server" /></td>
		<td class="formtexts tableborder">
			Size:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSize" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSize" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSizeMiFrom" runat="server" maxlength="5" size="5" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSizeUnitMeasureCode" runat="server" /></td>
		<td class="formtexts tableborder">
			SizeUnitMeasureCode:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSizeUnitMeasureCode" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSizeUnitMeasureCode" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSizeUnitMeasureCodeMiFrom" runat="server" maxlength="3" size="3" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableStandardCost" runat="server" /></td>
		<td class="formtexts tableborder">
			StandardCost:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotStandardCost" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opStandardCost" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxStandardCostMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxStandardCostMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableStyle" runat="server" /></td>
		<td class="formtexts tableborder">
			Style:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotStyle" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opStyle" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxStyleMiFrom" runat="server" maxlength="2" size="2" Text="" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableWeight" runat="server" /></td>
		<td class="formtexts tableborder">
			Weight:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotWeight" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opWeight" runat="server">
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
			<asp:textbox id="tbxWeightMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxWeightMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableWeightUnitMeasureCode" runat="server" /></td>
		<td class="formtexts tableborder">
			WeightUnitMeasureCode:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotWeightUnitMeasureCode" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opWeightUnitMeasureCode" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="6" Text="Null"/>
				<asp:ListItem Value="7" Text="Like"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxWeightUnitMeasureCodeMiFrom" runat="server" maxlength="3" size="3" Text="" ValidationGroup="SubSetSearchValidation" /> 
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
