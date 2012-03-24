<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListSubSet.aspx.cs" Inherits="ListSubSet"  MasterPageFile="~/Main.master" Title="Mostrar (Filtro) - " ValidateRequest="false" %>
<%@ MasterType VirtualPath="~/Main.master" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			List sub-set of <asp:Label ID="lblEntityName" runat="server"/> instances
		</td>
	</tr>
	<tr>
		<td class="content">
		<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
    		<asp:PlaceHolder ID="phSearchControls" runat="server"/>
		</asp:PlaceHolder>
<br/>
		<asp:PlaceHolder ID="phListArea" runat="server" Visible="false">
            <asp:Button ID="btnNewSearch" runat="server" Text="New Search" OnClick="btnNewSearch_Click" SkinID="ButtonSkin"/>
            <asp:Button ID="btnRefineSearch" runat="server" Text="Refine Search" OnClick="btnRefineSearch_Click" SkinID="ButtonSkin"/>
			<asp:PlaceHolder ID="phListControls" runat="server"/>
		</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>