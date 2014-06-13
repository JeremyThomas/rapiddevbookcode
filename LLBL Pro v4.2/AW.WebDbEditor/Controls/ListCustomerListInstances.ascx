	
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListCustomerListInstances.ascx.cs" Inherits="Controls_ListCustomerListInstances" %>

<asp:placeholder id="phDetails" runat="server" Visible="false">
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts" width="700">

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			AddressLine1:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblAddressLine1" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			AddressLine2:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblAddressLine2" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			City:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblCity" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			Name:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			Title:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblTitle" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			FirstName:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblFirstName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			MiddleName:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblMiddleName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			LastName:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblLastName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			Suffix:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblSuffix" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			EmailAddress:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblEmailAddress" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			EmailPromotion:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblEmailPromotion" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			CountryRegionName:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblCountryRegionName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			StateProvinceName:
		</td>
		<td class="content" width="100%">			<asp:Label ID="vlblStateProvinceName" runat="server" Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	<tr>
		<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
		<td class="formtexts" valign="top" nowrap="nowrap">
			CustomerId:
		</td>
		<td class="content" width="100%">			<asp:HyperLink ID="vlnkCustomerId" runat="server" NavigateUrl='' Text=''/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
	</tr>

	</table>
</asp:placeholder>
	<hr align="left" size="1" />
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts" width="700">
	<tr>
		<td colspan="3" class="content">
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>

<asp:placeholder id="phExportToExcelButton" runat="server" Visible="true">
	<asp:button ID="btnExportToExcel" runat="server" Text="Export to excel..." SkinID="ButtonSkin" OnClick="btnExportToExcel_Click"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>

<asp:placeholder id="phDetailsButton" runat="server" Visible="false">
    <asp:Button ID="btnDetails" runat="server" Text="Hide details" OnClick="btnDetails_Click" SkinID="ButtonSkin"/>
</asp:placeholder>
		</td>
	</tr>
	</table>
<llblgenpro:LLBLGenProDataSource ID="_CustomerListDS" runat="server" 
	DataContainerType="TypedList" 
	TypedListTypeName="AW.Data.TypedListClasses.CustomerListTypedList, AW.Data" 
	CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataSourceID="_CustomerListDS" 
		OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		
		<asp:TemplateField HeaderText="AddressLine1" SortExpression="AddressLine1"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblAddressLine1" runat="server" Text='<%# Bind("AddressLine1") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="AddressLine2" SortExpression="AddressLine2"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblAddressLine2" runat="server" Text='<%# Bind("AddressLine2") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="City" SortExpression="City"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="Name" SortExpression="Name"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="Title" SortExpression="Title"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="FirstName" SortExpression="FirstName"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblFirstName" runat="server" Text='<%# Bind("FirstName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="MiddleName" SortExpression="MiddleName"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblMiddleName" runat="server" Text='<%# Bind("MiddleName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="LastName" SortExpression="LastName"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblLastName" runat="server" Text='<%# Bind("LastName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="Suffix" SortExpression="Suffix"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblSuffix" runat="server" Text='<%# Bind("Suffix") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="EmailAddress" SortExpression="EmailAddress"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblEmailAddress" runat="server" Text='<%# Bind("EmailAddress") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="EmailPromotion" SortExpression="EmailPromotion" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblEmailPromotion" runat="server" Text='<%# Bind("EmailPromotion") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="CountryRegionName" SortExpression="CountryRegionName"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCountryRegionName" runat="server" Text='<%# Bind("CountryRegionName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="StateProvinceName" SortExpression="StateProvinceName"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblStateProvinceName" runat="server" Text='<%# Bind("StateProvinceName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

		<asp:TemplateField HeaderText="CustomerId" SortExpression="CustomerId"  HeaderStyle-HorizontalAlign="Left"  ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
			<asp:HyperLink ID="lnkCustomerId" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.CustomerEntity).ToString() + "&CustomerID=" + Eval("CustomerId")%>' Text='<%# Bind("CustomerId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>	

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>