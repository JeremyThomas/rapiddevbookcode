<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditExisting.aspx.cs" Inherits="EditExisting"  MasterPageFile="~/Main.master" Title="Edit existing " ValidateRequest="false"%>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Edit existing <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
			<div class="formHelp">
				<br/>
				Please choose one of the following ways to find the entity/entities:
				<br/>
			</div>
			<asp:PlaceHolder ID="phSearchControls" runat="server"/>
			<br/><br/>
		</asp:PlaceHolder>
		<asp:PlaceHolder ID="phEditArea" runat="server" Visible="false">
			<div class="formHelp">
				<br/>
				<b>Please note:</b> Required fields have a different background color and are marked with a <b>*</b>!
				<br/><br/>
			</div>
			<asp:PlaceHolder ID="phEditControls" runat="server"/>
			<br/><br/>
		</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>