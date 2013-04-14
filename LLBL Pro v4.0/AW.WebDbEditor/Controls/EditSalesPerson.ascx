
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditSalesPerson.ascx.cs" Inherits="Controls_EditSalesPerson" %>
<llblgenpro:LLBLGenProDataSource ID="_SalesPersonDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SalesPersonCollection, AW.Data" LivePersistence="False" OnPerformSelect="_SalesPersonDS_PerformSelect" OnPerformWork="_SalesPersonDS_PerformWork"/>
<asp:FormView ID="frmEditSalesPerson" DataKeyNames="EmployeeID" runat="server" DefaultMode="insert" DataSourceID="_SalesPersonDS" Cellpadding="0" OnItemCommand="frmEditSalesPerson_ItemCommand" OnItemCreated="frmEditSalesPerson_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				BirthDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxBirthDate" runat="server" Required="True" Value='<%# Bind("BirthDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqBirthDate" runat="server" ControlToValidate="dtxBirthDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Bonus:
			</td>
			<td class="content">
				<asp:textbox id="tbxBonus" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Bonus") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqBonus" runat="server" ControlToValidate="tbxBonus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CommissionPct:
			</td>
			<td class="content">
				<asp:textbox id="tbxCommissionPct" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("CommissionPct") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqCommissionPct" runat="server" ControlToValidate="tbxCommissionPct" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ContactID:
			</td>
			<td class="content">
				<asp:textbox id="tbxContactID" runat="server" maxlength="11" size="11" Text='<%# Bind("ContactID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valContactID" runat="server" ControlToValidate="tbxContactID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqContactID" runat="server" ControlToValidate="tbxContactID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CurrentFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkCurrentFlag" runat="server" Checked='<%# Bind("CurrentFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				EmployeeID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Gender:
			</td>
			<td class="content">
				<asp:textbox id="tbxGender" runat="server" maxlength="1" size="1" Text='<%# Bind("Gender") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqGender" runat="server" ControlToValidate="tbxGender" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HireDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxHireDate" runat="server" Required="True" Value='<%# Bind("HireDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqHireDate" runat="server" ControlToValidate="dtxHireDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				LoginID:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxLoginID" runat="server" maxlength="256" Text='<%# Bind("LoginID") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqLoginID" runat="server" ControlToValidate="tbxLoginID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ManagerID:
			</td>
			<td class="content">
				<asp:textbox id="tbxManagerID" runat="server" maxlength="11" size="11" Text='<%# Bind("ManagerID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valManagerID" runat="server" ControlToValidate="tbxManagerID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MaritalStatus:
			</td>
			<td class="content">
				<asp:textbox id="tbxMaritalStatus" runat="server" maxlength="1" size="1" Text='<%# Bind("MaritalStatus") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqMaritalStatus" runat="server" ControlToValidate="tbxMaritalStatus" Display="Dynamic" ErrorMessage="Required" />
				
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
				NationalIdnumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxNationalIdnumber" runat="server" maxlength="15" size="15" Text='<%# Bind("NationalIdnumber") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqNationalIdnumber" runat="server" ControlToValidate="tbxNationalIdnumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rowguid:
			</td>
			<td class="content">
				<asp:textbox id="tbxRowguid" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Rowguid") %>' maxlength="38" size="40"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRowguid" runat="server" ControlToValidate="tbxRowguid" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalariedFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkSalariedFlag" runat="server" Checked='<%# Bind("SalariedFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesLastYear" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SalesLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSalesLastYear" runat="server" ControlToValidate="tbxSalesLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesQuota:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesQuota" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SalesQuota") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesYtd" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("SalesYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSalesYtd" runat="server" ControlToValidate="tbxSalesYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SickLeaveHours:
			</td>
			<td class="content">
				<asp:textbox id="tbxSickLeaveHours" runat="server" maxlength="6" size="6" Text='<%# Bind("SickLeaveHours") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSickLeaveHours" runat="server" ControlToValidate="tbxSickLeaveHours" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSickLeaveHours" runat="server" ControlToValidate="tbxSickLeaveHours" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Title:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxTitle" runat="server" maxlength="50" Text='<%# Bind("Title") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTitle" runat="server" ControlToValidate="tbxTitle" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VacationHours:
			</td>
			<td class="content">
				<asp:textbox id="tbxVacationHours" runat="server" maxlength="6" size="6" Text='<%# Bind("VacationHours") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valVacationHours" runat="server" ControlToValidate="tbxVacationHours" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqVacationHours" runat="server" ControlToValidate="tbxVacationHours" Display="Dynamic" ErrorMessage="Required" />
				
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
				BirthDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxBirthDate" runat="server" Required="True" Value='<%# Bind("BirthDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqBirthDate" runat="server" ControlToValidate="dtxBirthDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Bonus:
			</td>
			<td class="content">
				<asp:textbox id="tbxBonus" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Bonus") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqBonus" runat="server" ControlToValidate="tbxBonus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CommissionPct:
			</td>
			<td class="content">
				<asp:textbox id="tbxCommissionPct" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("CommissionPct") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqCommissionPct" runat="server" ControlToValidate="tbxCommissionPct" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ContactID:
			</td>
			<td class="content">
				<asp:textbox id="tbxContactID" runat="server" maxlength="11" size="11" Text='<%# Bind("ContactID") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valContactID" runat="server" ControlToValidate="tbxContactID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqContactID" runat="server" ControlToValidate="tbxContactID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				CurrentFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkCurrentFlag" runat="server" Checked='<%# Bind("CurrentFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
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
				Gender:
			</td>
			<td class="content">
				<asp:textbox id="tbxGender" runat="server" maxlength="1" size="1" Text='<%# Bind("Gender") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqGender" runat="server" ControlToValidate="tbxGender" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				HireDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxHireDate" runat="server" Required="True" Value='<%# Bind("HireDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqHireDate" runat="server" ControlToValidate="dtxHireDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				LoginID:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="6" id="tbxLoginID" runat="server" maxlength="256" Text='<%# Bind("LoginID") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqLoginID" runat="server" ControlToValidate="tbxLoginID" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ManagerID:
			</td>
			<td class="content">
				<asp:textbox id="tbxManagerID" runat="server" maxlength="11" size="11" Text='<%# Bind("ManagerID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valManagerID" runat="server" ControlToValidate="tbxManagerID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MaritalStatus:
			</td>
			<td class="content">
				<asp:textbox id="tbxMaritalStatus" runat="server" maxlength="1" size="1" Text='<%# Bind("MaritalStatus") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqMaritalStatus" runat="server" ControlToValidate="tbxMaritalStatus" Display="Dynamic" ErrorMessage="Required" />
				
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
			<td class="formtexts" >
				NationalIdnumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxNationalIdnumber" runat="server" maxlength="15" size="15" Text='<%# Bind("NationalIdnumber") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqNationalIdnumber" runat="server" ControlToValidate="tbxNationalIdnumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Rowguid:
			</td>
			<td class="content">
				<asp:textbox id="tbxRowguid" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Rowguid") %>' maxlength="38" size="40"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqRowguid" runat="server" ControlToValidate="tbxRowguid" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalariedFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkSalariedFlag" runat="server" Checked='<%# Bind("SalariedFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesLastYear:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesLastYear" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SalesLastYear") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSalesLastYear" runat="server" ControlToValidate="tbxSalesLastYear" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesQuota:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesQuota" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SalesQuota") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SalesYtd:
			</td>
			<td class="content">
				<asp:textbox id="tbxSalesYtd" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("SalesYtd") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSalesYtd" runat="server" ControlToValidate="tbxSalesYtd" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SickLeaveHours:
			</td>
			<td class="content">
				<asp:textbox id="tbxSickLeaveHours" runat="server" maxlength="6" size="6" Text='<%# Bind("SickLeaveHours") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSickLeaveHours" runat="server" ControlToValidate="tbxSickLeaveHours" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSickLeaveHours" runat="server" ControlToValidate="tbxSickLeaveHours" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				TerritoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxTerritoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("TerritoryID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valTerritoryID" runat="server" ControlToValidate="tbxTerritoryID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Title:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxTitle" runat="server" maxlength="50" Text='<%# Bind("Title") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqTitle" runat="server" ControlToValidate="tbxTitle" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				VacationHours:
			</td>
			<td class="content">
				<asp:textbox id="tbxVacationHours" runat="server" maxlength="6" size="6" Text='<%# Bind("VacationHours") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valVacationHours" runat="server" ControlToValidate="tbxVacationHours" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqVacationHours" runat="server" ControlToValidate="tbxVacationHours" Display="Dynamic" ErrorMessage="Required" />
				
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
				BirthDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblBirthDate" runat="server" Text='<%# Bind("BirthDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Bonus:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblBonus" runat="server" Text='<%# Bind("Bonus", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CommissionPct:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCommissionPct" runat="server" Text='<%# Bind("CommissionPct", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ContactID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblContactID" runat="server" Text='<%# Bind("ContactID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				CurrentFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblCurrentFlag" runat="server" Text='<%# Bind("CurrentFlag") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				EmployeeID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblEmployeeID" runat="server" Text='<%# Bind("EmployeeID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Gender:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblGender" runat="server" Text='<%# Bind("Gender") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				HireDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblHireDate" runat="server" Text='<%# Bind("HireDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				LoginID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblLoginID" runat="server" Text='<%# Bind("LoginID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ManagerID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblManagerID" runat="server" Text='<%# Bind("ManagerID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				MaritalStatus:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblMaritalStatus" runat="server" Text='<%# Bind("MaritalStatus") %>'/></td>
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
				NationalIdnumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblNationalIdnumber" runat="server" Text='<%# Bind("NationalIdnumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Rowguid:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalariedFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalariedFlag" runat="server" Text='<%# Bind("SalariedFlag") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesLastYear:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesLastYear" runat="server" Text='<%# Bind("SalesLastYear", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesQuota:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesQuota" runat="server" Text='<%# Bind("SalesQuota", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SalesYtd:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSalesYtd" runat="server" Text='<%# Bind("SalesYtd", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SickLeaveHours:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSickLeaveHours" runat="server" Text='<%# Bind("SickLeaveHours") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				TerritoryID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkTerritoryID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.SalesTerritoryEntity).ToString() + "&TerritoryID=" + Eval("TerritoryID")%>' Text='<%# Bind("TerritoryID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Title:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				VacationHours:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblVacationHours" runat="server" Text='<%# Bind("VacationHours") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this SalesPerson instance with PK values: "  + "EmployeeID: " + Eval("EmployeeID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>