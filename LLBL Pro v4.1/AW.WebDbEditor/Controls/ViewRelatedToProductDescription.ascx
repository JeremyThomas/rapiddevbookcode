
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProductDescription.ascx.cs" Inherits="Controls_ViewRelatedToProductDescription" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductModelProductDescriptionCulturesInstances" Src="ListProductModelProductDescriptionCultureInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ProductModelProductDescriptionCulture instances (field mapped: ProductModelProductDescriptionCultures)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductModelProductDescriptionCulturesInstances ID="laProductModelProductDescriptionCultures" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	