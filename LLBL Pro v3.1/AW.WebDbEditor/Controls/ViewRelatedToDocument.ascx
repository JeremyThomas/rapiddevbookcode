
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToDocument.ascx.cs" Inherits="Controls_ViewRelatedToDocument" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductDocumentsInstances" Src="ListProductDocumentInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ProductDocument instances (field mapped: ProductDocuments)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductDocumentsInstances ID="laProductDocuments" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	