
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToStore.ascx.cs" Inherits="Controls_ViewRelatedToStore" %>
<%@ Register TagPrefix="dbeditor" TagName="ContactsInstances" Src="ListContactInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="StoreContactsInstances" Src="ListStoreContactInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Contact instances (field mapped: Contacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ContactsInstances ID="laContacts" runat="server" ShowHomeButton="false"  ShowAddNewButton="false" />
			<br/><br/>
		</td>
	</tr>
	<tr>
		<td class="headers">
			Related StoreContact instances (field mapped: StoreContacts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:StoreContactsInstances ID="laStoreContacts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	