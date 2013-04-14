<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/Main.master" Title="Database editor"%>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
	<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Please select the entity type and the action to perform.
		</td>
	</tr>
	<tr>
		<td class="content">
			<br/><br/>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Entity type: &nbsp;&nbsp; <asp:DropDownList ID="cbxEntity" runat="server"/>
			<br/><br/><br/>			
			<asp:Button ID="btnListAll" runat="server" Text="List all" SkinID="ButtonSkin" OnClick="btnListAll_Click" />&nbsp; &nbsp;
			<asp:Button ID="btnViewReport" runat="server" Text="View report" SkinID="ButtonSkin" OnClick="btnViewReport_Click" />&nbsp; &nbsp;
			<asp:Button ID="bntListSubSet" runat="server" Text="List SubSet" SkinID="ButtonSkin" OnClick="btnListSubSet_Click" />&nbsp; &nbsp;
			<asp:Button ID="btnListReportSubSet" runat="server" Text="List Report SubSet" SkinID="ButtonSkin" OnClick="btnListReportSubSet_Click" />&nbsp; &nbsp;
		</td>
	</tr>
	</table>
</asp:Content>