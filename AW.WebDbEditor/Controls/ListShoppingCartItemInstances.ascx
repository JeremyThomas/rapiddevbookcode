
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListShoppingCartItemInstances.ascx.cs" Inherits="Controls_ListShoppingCartItemInstances" %>
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
<llblgenpro:LLBLGenProDataSource ID="_ShoppingCartItemDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.ShoppingCartItemCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataKeyNames="ShoppingCartItemID" 
					DataSourceID="_ShoppingCartItemDS" OnRowCommand="theGrid_RowCommand">
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
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this ShoppingCartItem instance with PK values: "  + "ShoppingCartItemID: " + Eval("ShoppingCartItemID") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="DateCreated" SortExpression="DateCreated"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblDateCreated" runat="server" Text='<%# Bind("DateCreated", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ModifiedDate" SortExpression="ModifiedDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ProductID" SortExpression="ProductID"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:HyperLink ID="lnkProductID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.ProductEntity).ToString() + "&ProductID=" + Eval("ProductID")%>' Text='<%# Bind("ProductID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Quantity" SortExpression="Quantity" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblQuantity" runat="server" Text='<%# Bind("Quantity") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ShoppingCartID" SortExpression="ShoppingCartID"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblShoppingCartID" runat="server" Text='<%# Bind("ShoppingCartID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ShoppingCartItemID" SortExpression="ShoppingCartItemID" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblShoppingCartItemID" runat="server" Text='<%# Bind("ShoppingCartItemID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
