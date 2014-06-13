<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="Edit.aspx.cs" Inherits="AW_Dynamic_Data.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true" />

    <h2>Edit entry from table <%= table.DisplayName %></h2>

    <asp:ScriptManagerProxy runat="server" ID="ScriptManagerProxy1" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
			<asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
				HeaderText="List of validation errors" />
			<asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="DetailsView1" Display="None" />

			<asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="DetailsDataSource" DefaultMode="Edit"
				AutoGenerateEditButton="True" OnItemCommand="DetailsView1_ItemCommand" OnItemUpdated="DetailsView1_ItemUpdated"
				CssClass="detailstable" FieldHeaderStyle-CssClass="bold">
			</asp:DetailsView>

			<llblgen:LLBLGenProDynamicDataSource runat="server" ID="DetailsDataSource" 
				DataContainerType="EntityCollection" CacheLocation="Session"
				EnableDelete="True" EnableInsert="True" EnableUpdate="True">
				<WhereParameters>
					<asp:DynamicQueryStringParameter />
				</WhereParameters>
			</llblgen:LLBLGenProDynamicDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
