
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EditDocument.ascx.cs" Inherits="Controls_EditDocument" %>
<llblgenpro:LLBLGenProDataSource ID="_DocumentDS" runat="server" MaxNumberOfItemsToReturn="1" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.DocumentCollection, AW.Data" LivePersistence="False" OnPerformSelect="_DocumentDS_PerformSelect" OnPerformWork="_DocumentDS_PerformWork"/>
<asp:FormView ID="frmEditDocument" DataKeyNames="DocumentID" runat="server" DefaultMode="insert" DataSourceID="_DocumentDS" Cellpadding="0" OnItemCommand="frmEditDocument_ItemCommand" OnItemCreated="frmEditDocument_ItemCreated">
<InsertItemTemplate>
	<table cellpadding="3" border="0" cellspacing="1" class="formtexts">
	
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ChangeNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxChangeNumber" runat="server" maxlength="11" size="11" Text='<%# Bind("ChangeNumber") %>' ValidationGroup="InsertValidations"  CssClass="required"/> * <asp:RangeValidator ID="valChangeNumber" runat="server" ControlToValidate="tbxChangeNumber" ValidationGroup="InsertValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqChangeNumber" runat="server" ControlToValidate="tbxChangeNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Document:
			</td>
			<td class="content">
				<asp:FileUpload ID="fuDocument" class="fileUpload" runat="server" size="50" ValidationGroup="InsertValidations" FileBytes='<%# Bind("Document") %>' /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DocumentID:
			</td>
			<td class="content">
				Auto generated
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				DocumentSummary:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDocumentSummary" runat="server" maxlength="2147483647" Text='<%# Bind("DocumentSummary") %>' ValidationGroup="InsertValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FileExtension:
			</td>
			<td class="content">
				<asp:textbox id="tbxFileExtension" runat="server" maxlength="8" size="8" Text='<%# Bind("FileExtension") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqFileExtension" runat="server" ControlToValidate="tbxFileExtension" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				FileName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="9" id="tbxFileName" runat="server" maxlength="400" Text='<%# Bind("FileName") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqFileName" runat="server" ControlToValidate="tbxFileName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ModifiedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxModifiedDate" runat="server" Required="True" Value='<%# Bind("ModifiedDate") %>' ValidationGroup="InsertValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqModifiedDate" runat="server" ControlToValidate="dtxModifiedDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Revision:
			</td>
			<td class="content">
				<asp:textbox id="tbxRevision" runat="server" maxlength="5" size="5" Text='<%# Bind("Revision") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqRevision" runat="server" ControlToValidate="tbxRevision" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Status:
			</td>
			<td class="content">
				<asp:textbox id="tbxStatus" runat="server" maxlength="3" size="3" Text='<%# Bind("Status") %>'  CssClass="required" ValidationGroup="InsertValidations"/> * <asp:RangeValidator ID="valStatus" runat="server" ValidationGroup="InsertValidations" ControlToValidate="tbxStatus" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqStatus" runat="server" ControlToValidate="tbxStatus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Title:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxTitle" runat="server" maxlength="50" Text='<%# Bind("Title") %>' ValidationGroup="InsertValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="InsertValidations" ID="reqTitle" runat="server" ControlToValidate="tbxTitle" Display="Dynamic" ErrorMessage="Required" />
				
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
				ChangeNumber:
			</td>
			<td class="content">
				<asp:textbox id="tbxChangeNumber" runat="server" maxlength="11" size="11" Text='<%# Bind("ChangeNumber") %>' ValidationGroup="EditValidations"  CssClass="required"/> * <asp:RangeValidator ID="valChangeNumber" runat="server" ControlToValidate="tbxChangeNumber" ValidationGroup="EditValidations" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="-2147483648" MaximumValue="2147483647" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqChangeNumber" runat="server" ControlToValidate="tbxChangeNumber" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Document:
			</td>
			<td class="content">
				Binary lob
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				DocumentID:
			</td>
			<td class="content">
				<asp:Label ID="lblDocumentID" runat="server" Text='<%# Bind("DocumentID") %>'/>			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				DocumentSummary:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="10" id="tbxDocumentSummary" runat="server" maxlength="2147483647" Text='<%# Bind("DocumentSummary") %>' ValidationGroup="EditValidations" /> 
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				FileExtension:
			</td>
			<td class="content">
				<asp:textbox id="tbxFileExtension" runat="server" maxlength="8" size="8" Text='<%# Bind("FileExtension") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqFileExtension" runat="server" ControlToValidate="tbxFileExtension" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				FileName:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="9" id="tbxFileName" runat="server" maxlength="400" Text='<%# Bind("FileName") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqFileName" runat="server" ControlToValidate="tbxFileName" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				ModifiedDate:
			</td>
			<td class="content">
				<cc:datetextbox id="dtxModifiedDate" runat="server" Required="True" Value='<%# Bind("ModifiedDate") %>' ValidationGroup="EditValidations" /> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqModifiedDate" runat="server" ControlToValidate="dtxModifiedDate" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Revision:
			</td>
			<td class="content">
				<asp:textbox id="tbxRevision" runat="server" maxlength="5" size="5" Text='<%# Bind("Revision") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqRevision" runat="server" ControlToValidate="tbxRevision" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" >
				Status:
			</td>
			<td class="content">
				<asp:textbox id="tbxStatus" runat="server" maxlength="3" size="3" Text='<%# Bind("Status") %>'  CssClass="required" ValidationGroup="EditValidations"/> * <asp:RangeValidator ID="valStatus" runat="server" ValidationGroup="EditValidations" ControlToValidate="tbxStatus" Display="dynamic" ErrorMessage="Valor no valido" MinimumValue="0" MaximumValue="255" Type="integer"/> <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqStatus" runat="server" ControlToValidate="tbxStatus" Display="Dynamic" ErrorMessage="Required" />
				
			</td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
			
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts"  valign="top" >
				Title:
			</td>
			<td class="content">
				<asp:textbox TextMode="MultiLine" Columns="50" Rows="2" id="tbxTitle" runat="server" maxlength="50" Text='<%# Bind("Title") %>' ValidationGroup="EditValidations"  CssClass="required"/> *  <asp:RequiredFieldValidator ValidationGroup="EditValidations" ID="reqTitle" runat="server" ControlToValidate="tbxTitle" Display="Dynamic" ErrorMessage="Required" />
				
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
				ChangeNumber:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblChangeNumber" runat="server" Text='<%# Bind("ChangeNumber") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Document:
			</td>
			<td class="content" width="100%">
						Binary lob </td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DocumentID:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDocumentID" runat="server" Text='<%# Bind("DocumentID") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				DocumentSummary:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblDocumentSummary" runat="server" Text='<%# Bind("DocumentSummary") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				FileExtension:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblFileExtension" runat="server" Text='<%# Bind("FileExtension") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				FileName:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblFileName" runat="server" Text='<%# Bind("FileName") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				ModifiedDate:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Revision:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblRevision" runat="server" Text='<%# Bind("Revision") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Status:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblStatus" runat="server" Text='<%# Bind("Status") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td width="20"  nowrap="nowrap" class="content">&nbsp;</td>
			<td class="formtexts" valign="top" nowrap="nowrap">
				Title:
			</td>
			<td class="content" width="100%">
			<asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'/></td>
			<td width="20" nowrap="nowrap" class="content">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="3" class="content">
				<br/>
				<hr align="left" size="1" />
				<asp:Button ID="btnEdit" runat="server" CausesValidation="True" CommandName="EditExisting" Text="Edit" SkinId="ButtonSkin"/>
				<asp:Button ID="btnDelete" runat="server" CausesValidation="True" CommandName="DeleteExisting" Text="Delete and Home" SkinId="ButtonSkin" visible="false" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this Document instance with PK values: "  + "DocumentID: " + Eval("DocumentID") + " ?\");" %>'/>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

				<asp:Button ID="btnCancel" runat="server" Text="Cancel" SkinId="ButtonSkin" OnClick="btnCancel_Click" CausesValidation="false"/>
			</td>
			<td width="20" nowrap class="content">&nbsp;</td>
		</tr>
	</table>
</ItemTemplate>
</asp:FormView>