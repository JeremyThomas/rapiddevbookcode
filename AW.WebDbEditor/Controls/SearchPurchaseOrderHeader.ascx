<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchPurchaseOrderHeader.ascx.cs" Inherits="Controls_SearchPurchaseOrderHeader" %>
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
			PurchaseOrderID:
		</td>
		<td class="content">
			<asp:textbox id="tbxPurchaseOrderID" runat="server" maxlength="11" size="11" Text="" ValidationGroup="PkSearchValidation"  CssClass="required"/>  <asp:RangeValidator ID="valPurchaseOrderID" runat="server" ControlToValidate="tbxPurchaseOrderID" ValidationGroup="PkSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="PkSearchValidation" ID="reqPurchaseOrderID" runat="server" ControlToValidate="tbxPurchaseOrderID" Display="Dynamic" ErrorMessage="Required" />
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableFreight" runat="server" /></td>
		<td class="formtexts tableborder">
			Freight:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotFreight" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opFreight" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxFreightMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxFreightMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
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
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableOrderDate" runat="server" /></td>
		<td class="formtexts tableborder">
			OrderDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotOrderDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opOrderDate" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<cc:datetextbox id="dtxOrderDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxOrderDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnablePurchaseOrderID" runat="server" /></td>
		<td class="formtexts tableborder">
			PurchaseOrderID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotPurchaseOrderID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opPurchaseOrderID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxPurchaseOrderIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiPurchaseOrderIDMiFrom" runat="server" ControlToValidate="tbxPurchaseOrderIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxPurchaseOrderIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiPurchaseOrderIDMiTo" runat="server" ControlToValidate="tbxPurchaseOrderIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableRevisionNumber" runat="server" /></td>
		<td class="formtexts tableborder">
			RevisionNumber:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotRevisionNumber" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opRevisionNumber" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxRevisionNumberMiFrom" runat="server" maxlength="3" size="3" Text=""  ValidationGroup="SubSetSearchValidation"/> <asp:RangeValidator ID="valMiRevisionNumberMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" ControlToValidate="tbxRevisionNumberMiFrom" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/>
			and
			<asp:textbox id="tbxRevisionNumberMiTo" runat="server" maxlength="3" size="3" Text=""  ValidationGroup="SubSetSearchValidation"/> <asp:RangeValidator ID="valMiRevisionNumberMiTo" runat="server" ValidationGroup="SubSetSearchValidation" ControlToValidate="tbxRevisionNumberMiTo" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableShipDate" runat="server" /></td>
		<td class="formtexts tableborder">
			ShipDate:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotShipDate" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opShipDate" runat="server">
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
			<cc:datetextbox id="dtxShipDateMiFrom" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
			and
			<cc:datetextbox id="dtxShipDateMiTo" runat="server" Required="False" ValidationGroup="SubSetSearchValidation" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableShipMethodID" runat="server" /></td>
		<td class="formtexts tableborder">
			ShipMethodID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotShipMethodID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opShipMethodID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxShipMethodIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiShipMethodIDMiFrom" runat="server" ControlToValidate="tbxShipMethodIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxShipMethodIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiShipMethodIDMiTo" runat="server" ControlToValidate="tbxShipMethodIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableStatus" runat="server" /></td>
		<td class="formtexts tableborder">
			Status:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotStatus" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opStatus" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxStatusMiFrom" runat="server" maxlength="3" size="3" Text=""  ValidationGroup="SubSetSearchValidation"/> <asp:RangeValidator ID="valMiStatusMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" ControlToValidate="tbxStatusMiFrom" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/>
			and
			<asp:textbox id="tbxStatusMiTo" runat="server" maxlength="3" size="3" Text=""  ValidationGroup="SubSetSearchValidation"/> <asp:RangeValidator ID="valMiStatusMiTo" runat="server" ValidationGroup="SubSetSearchValidation" ControlToValidate="tbxStatusMiTo" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/>
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableSubTotal" runat="server" /></td>
		<td class="formtexts tableborder">
			SubTotal:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotSubTotal" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opSubTotal" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxSubTotalMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxSubTotalMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableTaxAmt" runat="server" /></td>
		<td class="formtexts tableborder">
			TaxAmt:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotTaxAmt" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opTaxAmt" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxTaxAmtMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxTaxAmtMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableTotalDue" runat="server" /></td>
		<td class="formtexts tableborder">
			TotalDue:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotTotalDue" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opTotalDue" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxTotalDueMiFrom" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
			and
			<asp:textbox id="tbxTotalDueMiTo" runat="server" ValidationGroup="SubSetSearchValidation" Text="" /> 
		</td>
	</tr>
	<tr>
		<td width="20" class="content tableborder" style="border-left:none;"><asp:CheckBox ID="chkEnableVendorID" runat="server" /></td>
		<td class="formtexts tableborder">
			VendorID:
		</td>
		<td class="content tableborder">
			<asp:CheckBox ID="chkNotVendorID" runat="server" />
		</td>
		<td class="content tableborder">
			<asp:DropDownList ID="opVendorID" runat="server">
				<asp:ListItem Value="0" Selected="True" Text="Equal"/>
				<asp:ListItem Value="1" Text="Greater"/>
				<asp:ListItem Value="2" Text="Greater / Equal"/>
				<asp:ListItem Value="3" Text="Lesser"/>
				<asp:ListItem Value="4" Text="Lesser / Equal"/>
				<asp:ListItem Value="5" Text="Between"/>
			</asp:DropDownList>
		</td>
		
		<td class="content" tableborder" nowrap="nowrap">
			<asp:textbox id="tbxVendorIDMiFrom" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiVendorIDMiFrom" runat="server" ControlToValidate="tbxVendorIDMiFrom" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
			and
			<asp:textbox id="tbxVendorIDMiTo" runat="server" maxlength="11" size="11" Text="" ValidationGroup="SubSetSearchValidation" /> <asp:RangeValidator ID="valMiVendorIDMiTo" runat="server" ControlToValidate="tbxVendorIDMiTo" ValidationGroup="SubSetSearchValidation" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
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
