
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditDatabaseLog.ascx.cs" Inherits="Controls_EditDatabaseLog" %>
<llblgenpro:LLBLGenProDataSource ID="_DatabaseLogDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.DatabaseLogCollection, AW.Data" LivePersistence="False" OnPerformSelect="_DatabaseLogDS_PerformSelect" OnPerformWork="_DatabaseLogDS_PerformWork"/>
<asp:FormView ID="frmEditDatabaseLog" DataKeyNames="DatabaseLogID" runat="server" DefaultMode="insert" DataSourceID="_DatabaseLogDS" Cellpadding="0" OnItemCommand="frmEditDatabaseLog_ItemCommand" OnItemCreated="frmEditDatabaseLog_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DatabaseLogID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				DatabaseUser:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxDatabaseUser" runat="server" maxlength="128" Text='<%# Bind("DatabaseUser") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqDatabaseUser" runat="server" ControlToValidate="tbxDatabaseUser" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Event:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxEvent" runat="server" maxlength="128" Text='<%# Bind("Event") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqEvent" runat="server" ControlToValidate="tbxEvent" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Object:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxObject" runat="server" maxlength="128" Text='<%# Bind("Object") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PostTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxPostTime" runat="server" Required="True" Value='<%# Bind("PostTime") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqPostTime" runat="server" ControlToValidate="dtxPostTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Schema:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxSchema" runat="server" maxlength="128" Text='<%# Bind("Schema") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Tsql:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxTsql" runat="server" maxlength="2147483647" Text='<%# Bind("Tsql") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTsql" runat="server" ControlToValidate="tbxTsql" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				XmlEvent:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxXmlEvent" runat="server" maxlength="2147483647" Text='<%# Bind("XmlEvent") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqXmlEvent" runat="server" ControlToValidate="tbxXmlEvent" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br />
				<hr align="left" size="1" />
				<asp:Button ID="btnInsertAndNew" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndNew" Text="Insert and New" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndHome" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndHome" Text="Insert and Home" SkinId="ButtonSkin"/>
				<asp:Button ID="btnInsertAndView" runat="server" CausesValidation="True" ValidationGroup="InsertValidations" CommandName="InsertAndView" Text="Insert and View" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</InsertItemTemplate>
<EditItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DatabaseLogID:
			</td>
			<td class="content">
				<asp:Label ID="lblDatabaseLogID" runat="server" Text='<%# Bind("DatabaseLogID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				DatabaseUser:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxDatabaseUser" runat="server" maxlength="128" Text='<%# Bind("DatabaseUser") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqDatabaseUser" runat="server" ControlToValidate="tbxDatabaseUser" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Event:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxEvent" runat="server" maxlength="128" Text='<%# Bind("Event") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqEvent" runat="server" ControlToValidate="tbxEvent" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Object:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxObject" runat="server" maxlength="128" Text='<%# Bind("Object") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				PostTime:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxPostTime" runat="server" Required="True" Value='<%# Bind("PostTime") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqPostTime" runat="server" ControlToValidate="dtxPostTime" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Schema:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="3" id="tbxSchema" runat="server" maxlength="128" Text='<%# Bind("Schema") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Tsql:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxTsql" runat="server" maxlength="2147483647" Text='<%# Bind("Tsql") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqTsql" runat="server" ControlToValidate="tbxTsql" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				XmlEvent:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxXmlEvent" runat="server" maxlength="2147483647" Text='<%# Bind("XmlEvent") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqXmlEvent" runat="server" ControlToValidate="tbxXmlEvent" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br>
				<hr align="left" size="1" />
				<asp:Button ID="btnUpdateAndHome" runat="server" ValidationGroup="EditValidations" CausesValidation="True" CommandName="UpdateAndHome" Text="Update and Home" SkinId="ButtonSkin"/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</EditItemTemplate>
<ItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts" width="700">
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DatabaseLogID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDatabaseLogID" runat="server" Text='<%# Bind("DatabaseLogID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DatabaseUser:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDatabaseUser" runat="server" Text='<%# Bind("DatabaseUser") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Event:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblEvent" runat="server" Text='<%# Bind("Event") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Object:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblObject" runat="server" Text='<%# Bind("Object") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				PostTime:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblPostTime" runat="server" Text='<%# Bind("PostTime", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Schema:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblSchema" runat="server" Text='<%# Bind("Schema") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Tsql:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTsql" runat="server" Text='<%# Bind("Tsql") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				XmlEvent:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblXmlEvent" runat="server" Text='<%# Bind("XmlEvent") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this DatabaseLog instance with PK values: "  + "DatabaseLogID: " + Eval("DatabaseLogID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>