
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProductSubcategory.ascx.cs" Inherits="Controls_ViewRelatedToProductSubcategory" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductsInstances" Src="ListProductInstances.ascx"%>
	<tr>
		<td class="headers">
			Related Product instances (field mapped: Products)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductsInstances ID="laProducts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	