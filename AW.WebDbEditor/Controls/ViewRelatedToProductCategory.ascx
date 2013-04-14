
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProductCategory.ascx.cs" Inherits="Controls_ViewRelatedToProductCategory" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductSubcategoriesInstances" Src="ListProductSubcategoryInstances.ascx"%>
	<tr>
		<td class="headers">
			Related ProductSubcategory instances (field mapped: ProductSubcategories)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductSubcategoriesInstances ID="laProductSubcategories" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	