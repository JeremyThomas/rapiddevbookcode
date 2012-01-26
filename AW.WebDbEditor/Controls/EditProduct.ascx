
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditProduct.ascx.cs" Inherits="Controls_EditProduct" %>
<llblgenpro:LLBLGenProDataSource ID="_ProductDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ProductCollection, AW.Data" LivePersistence="False" OnPerformSelect="_ProductDS_PerformSelect" OnPerformWork="_ProductDS_PerformWork"/>
<asp:FormView ID="frmEditProduct" DataKeyNames="ProductID" runat="server" DefaultMode="insert" DataSourceID="_ProductDS" Cellpadding="0" OnItemCommand="frmEditProduct_ItemCommand" OnItemCreated="frmEditProduct_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Class:
			</td>
			<td class="content">
				<asp:textbox id="tbxClass" runat="server" maxlength="2" size="2" Text='<%# Bind("Class") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Color:
			</td>
			<td class="content">
				<asp:textbox id="tbxColor" runat="server" maxlength="15" size="15" Text='<%# Bind("Color") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DaysToManufacture:
			</td>
			<td class="content">
				<asp:textbox id="tbxDaysToManufacture" runat="server" maxlength="11" size="11" Text='<%# Bind("DaysToManufacture") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valDaysToManufacture" runat="server" ControlToValidate="tbxDaysToManufacture" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqDaysToManufacture" runat="server" ControlToValidate="tbxDaysToManufacture" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DiscontinuedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxDiscontinuedDate" runat="server" Required="False" Value='<%# Bind("DiscontinuedDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FinishedGoodsFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkFinishedGoodsFlag" runat="server" Checked='<%# Bind("FinishedGoodsFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ListPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxListPrice" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("ListPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqListPrice" runat="server" ControlToValidate="tbxListPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MakeFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkMakeFlag" runat="server" Checked='<%# Bind("MakeFlag") %>' CssClass="required"/>
				
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
			<td class="formtexts"  valign="top" >
				Name:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxName" runat="server" maxlength="50" Text='<%# Bind("Name") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqName" runat="server" ControlToValidate="tbxName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductLine:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductLine" runat="server" maxlength="2" size="2" Text='<%# Bind("ProductLine") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductModelID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductModelID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductModelID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valProductModelID" runat="server" ControlToValidate="tbxProductModelID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("ProductNumber") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqProductNumber" runat="server" ControlToValidate="tbxProductNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductSubcategoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductSubcategoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductSubcategoryID") %>' ValidationGroup="InsertValidations" /> <asp:RangeValidator ID="valProductSubcategoryID" runat="server" ControlToValidate="tbxProductSubcategoryID" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReorderPoint:
			</td>
			<td class="content">
				<asp:textbox id="tbxReorderPoint" runat="server" maxlength="6" size="6" Text='<%# Bind("ReorderPoint") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReorderPoint" runat="server" ControlToValidate="tbxReorderPoint" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqReorderPoint" runat="server" ControlToValidate="tbxReorderPoint" Display="Dynamic" ErrorMessage="Required" />
				
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
				SafetyStockLevel:
			</td>
			<td class="content">
				<asp:textbox id="tbxSafetyStockLevel" runat="server" maxlength="6" size="6" Text='<%# Bind("SafetyStockLevel") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSafetyStockLevel" runat="server" ControlToValidate="tbxSafetyStockLevel" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSafetyStockLevel" runat="server" ControlToValidate="tbxSafetyStockLevel" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SellEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxSellEndDate" runat="server" Required="False" Value='<%# Bind("SellEndDate") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SellStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxSellStartDate" runat="server" Required="True" Value='<%# Bind("SellStartDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqSellStartDate" runat="server" ControlToValidate="dtxSellStartDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Size:
			</td>
			<td class="content">
				<asp:textbox id="tbxSize" runat="server" maxlength="5" size="5" Text='<%# Bind("Size") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SizeUnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxSizeUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("SizeUnitMeasureCode") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				StandardCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxStandardCost" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("StandardCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqStandardCost" runat="server" ControlToValidate="tbxStandardCost" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Style:
			</td>
			<td class="content">
				<asp:textbox id="tbxStyle" runat="server" maxlength="2" size="2" Text='<%# Bind("Style") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Weight:
			</td>
			<td class="content">
				<asp:textbox id="tbxWeight" runat="server" ValidationGroup="InsertValidations" Text='<%# Bind("Weight") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				WeightUnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxWeightUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("WeightUnitMeasureCode") %>' ValidationGroup="InsertValidations" /> 
				
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
				Class:
			</td>
			<td class="content">
				<asp:textbox id="tbxClass" runat="server" maxlength="2" size="2" Text='<%# Bind("Class") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Color:
			</td>
			<td class="content">
				<asp:textbox id="tbxColor" runat="server" maxlength="15" size="15" Text='<%# Bind("Color") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DaysToManufacture:
			</td>
			<td class="content">
				<asp:textbox id="tbxDaysToManufacture" runat="server" maxlength="11" size="11" Text='<%# Bind("DaysToManufacture") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valDaysToManufacture" runat="server" ControlToValidate="tbxDaysToManufacture" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqDaysToManufacture" runat="server" ControlToValidate="tbxDaysToManufacture" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DiscontinuedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxDiscontinuedDate" runat="server" Required="False" Value='<%# Bind("DiscontinuedDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FinishedGoodsFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkFinishedGoodsFlag" runat="server" Checked='<%# Bind("FinishedGoodsFlag") %>' CssClass="required"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ListPrice:
			</td>
			<td class="content">
				<asp:textbox id="tbxListPrice" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("ListPrice") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqListPrice" runat="server" ControlToValidate="tbxListPrice" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				MakeFlag:
			</td>
			<td class="content">
				<asp:checkbox id="chkMakeFlag" runat="server" Checked='<%# Bind("MakeFlag") %>' CssClass="required"/>
				
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
			<td class="formtexts"  valign="top" >
				Name:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxName" runat="server" maxlength="50" Text='<%# Bind("Name") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqName" runat="server" ControlToValidate="tbxName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductID:
			</td>
			<td class="content">
				<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductLine:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductLine" runat="server" maxlength="2" size="2" Text='<%# Bind("ProductLine") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductModelID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductModelID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductModelID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valProductModelID" runat="server" ControlToValidate="tbxProductModelID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductNumber" runat="server" maxlength="25" size="25" Text='<%# Bind("ProductNumber") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqProductNumber" runat="server" ControlToValidate="tbxProductNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ProductSubcategoryID:
			</td>
			<td class="content">
				<asp:textbox id="tbxProductSubcategoryID" runat="server" maxlength="11" size="11" Text='<%# Bind("ProductSubcategoryID") %>' ValidationGroup="EditValidations" /> <asp:RangeValidator ID="valProductSubcategoryID" runat="server" ControlToValidate="tbxProductSubcategoryID" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/>
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ReorderPoint:
			</td>
			<td class="content">
				<asp:textbox id="tbxReorderPoint" runat="server" maxlength="6" size="6" Text='<%# Bind("ReorderPoint") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valReorderPoint" runat="server" ControlToValidate="tbxReorderPoint" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqReorderPoint" runat="server" ControlToValidate="tbxReorderPoint" Display="Dynamic" ErrorMessage="Required" />
				
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
				SafetyStockLevel:
			</td>
			<td class="content">
				<asp:textbox id="tbxSafetyStockLevel" runat="server" maxlength="6" size="6" Text='<%# Bind("SafetyStockLevel") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valSafetyStockLevel" runat="server" ControlToValidate="tbxSafetyStockLevel" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-32768" MaximumValue="32767" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSafetyStockLevel" runat="server" ControlToValidate="tbxSafetyStockLevel" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SellEndDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxSellEndDate" runat="server" Required="False" Value='<%# Bind("SellEndDate") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SellStartDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxSellStartDate" runat="server" Required="True" Value='<%# Bind("SellStartDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqSellStartDate" runat="server" ControlToValidate="dtxSellStartDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Size:
			</td>
			<td class="content">
				<asp:textbox id="tbxSize" runat="server" maxlength="5" size="5" Text='<%# Bind("Size") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				SizeUnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxSizeUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("SizeUnitMeasureCode") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				StandardCost:
			</td>
			<td class="content">
				<asp:textbox id="tbxStandardCost" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("StandardCost") %>'  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqStandardCost" runat="server" ControlToValidate="tbxStandardCost" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Style:
			</td>
			<td class="content">
				<asp:textbox id="tbxStyle" runat="server" maxlength="2" size="2" Text='<%# Bind("Style") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Weight:
			</td>
			<td class="content">
				<asp:textbox id="tbxWeight" runat="server" ValidationGroup="EditValidations" Text='<%# Bind("Weight") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				WeightUnitMeasureCode:
			</td>
			<td class="content">
				<asp:textbox id="tbxWeightUnitMeasureCode" runat="server" maxlength="3" size="3" Text='<%# Bind("WeightUnitMeasureCode") %>' ValidationGroup="EditValidations" /> 
				
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
				Class:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblClass" runat="server" Text='<%# Bind("Class") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Color:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblColor" runat="server" Text='<%# Bind("Color") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DaysToManufacture:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDaysToManufacture" runat="server" Text='<%# Bind("DaysToManufacture") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DiscontinuedDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDiscontinuedDate" runat="server" Text='<%# Bind("DiscontinuedDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				FinishedGoodsFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblFinishedGoodsFlag" runat="server" Text='<%# Bind("FinishedGoodsFlag") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ListPrice:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblListPrice" runat="server" Text='<%# Bind("ListPrice", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				MakeFlag:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblMakeFlag" runat="server" Text='<%# Bind("MakeFlag") %>'/></td>
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
				Name:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductLine:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblProductLine" runat="server" Text='<%# Bind("ProductLine") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductModelID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkProductModelID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ProductModelEntity).ToString() + "&ProductModelID=" + Eval("ProductModelID")%>' Text='<%# Bind("ProductModelID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblProductNumber" runat="server" Text='<%# Bind("ProductNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ProductSubcategoryID:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkProductSubcategoryID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ProductSubcategoryEntity).ToString() + "&ProductSubcategoryID=" + Eval("ProductSubcategoryID")%>' Text='<%# Bind("ProductSubcategoryID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ReorderPoint:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblReorderPoint" runat="server" Text='<%# Bind("ReorderPoint") %>'/></td>
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
				SafetyStockLevel:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSafetyStockLevel" runat="server" Text='<%# Bind("SafetyStockLevel") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SellEndDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSellEndDate" runat="server" Text='<%# Bind("SellEndDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SellStartDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSellStartDate" runat="server" Text='<%# Bind("SellStartDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Size:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSize" runat="server" Text='<%# Bind("Size") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				SizeUnitMeasureCode:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkSizeUnitMeasureCode" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.UnitMeasureEntity).ToString() + "&UnitMeasureCode=" + Eval("SizeUnitMeasureCode")%>' Text='<%# Bind("SizeUnitMeasureCode") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				StandardCost:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblStandardCost" runat="server" Text='<%# Bind("StandardCost", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Style:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblStyle" runat="server" Text='<%# Bind("Style") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Weight:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblWeight" runat="server" Text='<%# Bind("Weight", "{0:0.##}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				WeightUnitMeasureCode:
			</td>
			<td class="content" width="100%">
			<asp:HyperLink ID="lnkWeightUnitMeasureCode" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.UnitMeasureEntity).ToString() + "&UnitMeasureCode=" + Eval("WeightUnitMeasureCode")%>' Text='<%# Bind("WeightUnitMeasureCode") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Product instance with PK values: "  + "ProductID: " + Eval("ProductID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>