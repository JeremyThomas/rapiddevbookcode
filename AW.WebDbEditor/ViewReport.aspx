<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewReport.aspx.cs" Inherits="ViewReport" MasterPageFile="~/Main.master" Title="View Report" EnableEventValidation ="false" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
    		    <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			All <asp:Label ID="lblEntityName" runat="server"/> instances report
		</td>
	</tr>
	<tr height="510px">
		<td class="content">
			<asp:PlaceHolder ID="phControls" runat="server"/>

		</td>
	</tr>
</table>
</asp:Content>
