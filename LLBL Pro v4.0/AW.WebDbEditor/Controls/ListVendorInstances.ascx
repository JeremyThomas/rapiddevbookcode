
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListVendorInstances.ascx.cs" Inherits="Controls_ListVendorInstances" %>
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
<llblgenpro:LLBLGenProDataSource ID="_VendorDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.VendorCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataKeyNames="VendorID" 
					DataSourceID="_VendorDS" OnRowCommand="theGrid_RowCommand">
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
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Vendor instance with PK values: "  + "VendorID: " + Eval("VendorID") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="AccountNumber" SortExpression="AccountNumber"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblAccountNumber" runat="server" Text='<%# Bind("AccountNumber") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActiveFlag" SortExpression="ActiveFlag"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblActiveFlag" runat="server" Text='<%# Bind("ActiveFlag") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="CreditRating" SortExpression="CreditRating"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCreditRating" runat="server" Text='<%# Bind("CreditRating") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ModifiedDate" SortExpression="ModifiedDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Name" SortExpression="Name"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="PreferredVendorStatus" SortExpression="PreferredVendorStatus"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblPreferredVendorStatus" runat="server" Text='<%# Bind("PreferredVendorStatus") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="VendorID" SortExpression="VendorID" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblVendorID" runat="server" Text='<%# Bind("VendorID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
