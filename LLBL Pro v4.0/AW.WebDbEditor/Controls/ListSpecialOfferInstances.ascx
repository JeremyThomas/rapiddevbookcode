
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListSpecialOfferInstances.ascx.cs" Inherits="Controls_ListSpecialOfferInstances" %>
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
<llblgenpro:LLBLGenProDataSource ID="_SpecialOfferDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SpecialOfferCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataKeyNames="SpecialOfferID" 
					DataSourceID="_SpecialOfferDS" OnRowCommand="theGrid_RowCommand">
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
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this SpecialOffer instance with PK values: "  + "SpecialOfferID: " + Eval("SpecialOfferID") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Category" SortExpression="Category"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblCategory" runat="server" Text='<%# Bind("Category") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="DiscountPct" SortExpression="DiscountPct" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblDiscountPct" runat="server" Text='<%# Bind("DiscountPct", "{0:0.##}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="EndDate" SortExpression="EndDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblEndDate" runat="server" Text='<%# Bind("EndDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="MaxQty" SortExpression="MaxQty" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblMaxQty" runat="server" Text='<%# Bind("MaxQty") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="MinQty" SortExpression="MinQty" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblMinQty" runat="server" Text='<%# Bind("MinQty") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ModifiedDate" SortExpression="ModifiedDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Rowguid" SortExpression="Rowguid"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblRowguid" runat="server" Text='<%# Bind("Rowguid") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="SpecialOfferID" SortExpression="SpecialOfferID" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblSpecialOfferID" runat="server" Text='<%# Bind("SpecialOfferID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="StartDate" SortExpression="StartDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblStartDate" runat="server" Text='<%# Bind("StartDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="Type" SortExpression="Type"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblType" runat="server" Text='<%# Bind("Type") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
