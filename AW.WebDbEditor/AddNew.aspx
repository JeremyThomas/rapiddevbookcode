<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNew.aspx.cs" Inherits="AddNew" MasterPageFile="~/Main.master" Title="Add new " ValidateRequest="false" %>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Add new <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<br/><br/>
			<strong>Please note:</strong> Required fields have a different background color and are marked with a <b>*</b>!
			<br/><br/>
			<asp:PlaceHolder ID="phControls" runat="server"/>
			<br/><br/>
		</td>
	</tr>
</table>
</asp:Content>