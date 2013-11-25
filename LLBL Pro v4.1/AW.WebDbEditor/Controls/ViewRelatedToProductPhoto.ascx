
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProductPhoto.ascx.cs" Inherits="Controls_ViewRelatedToProductPhoto" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductProductPhotosInstances" Src="ListProductProductPhotoInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ProductProductPhoto instances (field mapped: ProductProductPhotos)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductProductPhotosInstances ID="laProductProductPhotos" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	