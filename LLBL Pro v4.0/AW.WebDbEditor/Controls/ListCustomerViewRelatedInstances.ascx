
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListCustomerViewRelatedInstances.ascx.cs" Inherits="Controls_ListCustomerViewRelatedInstances" %>
<%@ Import Namespace="AW.Data"%>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>

<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>

<asp:placeholder id="phExportToExcelButton" runat="server" Visible="true">
	<asp:button ID="btnExportToExcel" runat="server" Text="Export to excel..." SkinID="ButtonSkin" OnClick="btnExportToExcel_Click"/>
</asp:placeholder>
<llblgenpro:LLBLGenProDataSource ID="_CustomerViewRelatedDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.CustomerViewRelatedCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataKeyNames="CustomerId" 
					DataSourceID="_CustomerViewRelatedDS" OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders">
			<ItemTemplate>
				<asp:Button ID="btnEditExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="EditExisting" Text="Edit" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>

		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left">
			<ItemTemplate>
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this CustomerViewRelated instance with PK values: "  + "CustomerId: " + Eval("CustomerId") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="AddressType" SortExpression="AddressType"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblAddressType" runat="server" Text='<%# Bind("AddressType") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="City" SortExpression="City"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="CountryRegionName" SortExpression="CountryRegionName"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCountryRegionName" runat="server" Text='<%# Bind("CountryRegionName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="CustomerId" SortExpression="CustomerId" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCustomerId" runat="server" Text='<%# Bind("CustomerId") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="EmailAddress" SortExpression="EmailAddress"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblEmailAddress" runat="server" Text='<%# Bind("EmailAddress") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="EmailPromotion" SortExpression="EmailPromotion" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblEmailPromotion" runat="server" Text='<%# Bind("EmailPromotion") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="FirstName" SortExpression="FirstName"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblFirstName" runat="server" Text='<%# Bind("FirstName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="LastName" SortExpression="LastName"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblLastName" runat="server" Text='<%# Bind("LastName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="MiddleName" SortExpression="MiddleName"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblMiddleName" runat="server" Text='<%# Bind("MiddleName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Phone" SortExpression="Phone"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="PostalCode" SortExpression="PostalCode"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblPostalCode" runat="server" Text='<%# Bind("PostalCode") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="StateProvinceName" SortExpression="StateProvinceName"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblStateProvinceName" runat="server" Text='<%# Bind("StateProvinceName") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Suffix" SortExpression="Suffix"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblSuffix" runat="server" Text='<%# Bind("Suffix") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Title" SortExpression="Title"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
