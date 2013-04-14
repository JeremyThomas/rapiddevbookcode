<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteExisting.aspx.cs" Inherits="DeleteExisting"  MasterPageFile="~/Main.master" Title="Delete existing "%>
<asp:Content ContentPlaceHolderID="phMainContent" runat="server">
<table width="100%" cellpadding="5" cellspacing="0" border="0">
	<tr>
		<td class="darkbackground">
			<h1>Database editor</h1>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Delete existing <asp:Label ID="lblEntityName" runat="server"/> entity
		</td>
	</tr>
	<tr>
		<td class="content">
			<asp:PlaceHolder ID="phSearchArea" runat="server" Visible="false">
				<br/><br/>
				Please choose one of the following ways to find the entity/entities:
				<br/><br/>
				<asp:PlaceHolder ID="phSearchControls" runat="server"/>
				<br/><br/>
			</asp:PlaceHolder>
			<asp:PlaceHolder ID="phEditArea" runat="server" Visible="false">
				<br/><br/>
				<b>Please note:</b> if there are related entities refering to this entity and cascading deletes aren't enabled in the database,
				you might run into an error. In that case, delete the related entities first. 
				<br/><br/>
				<asp:PlaceHolder ID="phEditControls" runat="server"/>
				<br/><br/>
			</asp:PlaceHolder>
		</td>
	</tr>
</table>
</asp:Content>