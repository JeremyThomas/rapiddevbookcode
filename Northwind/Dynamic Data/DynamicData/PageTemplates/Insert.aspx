<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="Insert.aspx.cs" Inherits="Dynamic_Data.Insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true" />

    <h2>Add new entry to table <%= table.DisplayName %></h2>

    <asp:ScriptManagerProxy runat="server" ID="ScriptManagerProxy1" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
			<asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
				HeaderText="List of validation errors" />
			<asp:DynamicValidator runat="server" ID="DetailsViewValidator" ControlToValidate="DetailsView1" Display="None" />

			<asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="DetailsDataSource" DefaultMode="Insert"
				AutoGenerateInsertButton="True" OnItemCommand="DetailsView1_ItemCommand" OnItemInserted="DetailsView1_ItemInserted">
			</asp:DetailsView>

			<llblgen:LLBLGenProDynamicDataSource2 runat="server" ID="DetailsDataSource" 
				DataContainerType="EntityCollection" CacheLocation="Session"
				EnableDelete="True" EnableInsert="True" EnableUpdate="True">
			</llblgen:LLBLGenProDynamicDataSource2>
        </ContentTemplate>
    </asp:UpdatePanel>			
</asp:Content>
