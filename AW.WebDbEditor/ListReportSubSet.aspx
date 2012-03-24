<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListReportSubSet.aspx.cs" Inherits="ListReportSubSet"  MasterPageFile="~/Main.master" Title="List Report Sub-set of " ValidateRequest="false"%>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			List report sub-set of <asp:Label ID="lblEntityName" runat="server"/> instances
		</td>
	</tr>
	<tr>
		<td class="content">
		<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
			<asp:PlaceHolder ID="phSearchControls" runat="server"/>
			<br/><br/>
		</asp:PlaceHolder>
		<asp:PlaceHolder ID="phListArea" runat="server" Visible="false">
			<br/><br/>
            <asp:Button ID="btnNewSearch" runat="server" Text="New Search" OnClick="btnNewSearch_Click" SkinID="ButtonSkin"/>
            <asp:Button ID="btnRefineSearch" runat="server" Text="Refine Search" OnClick="btnRefineSearch_Click" SkinID="ButtonSkin"/>
			<asp:PlaceHolder ID="phListControls" runat="server"/>
			<br/><br/>
		</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>