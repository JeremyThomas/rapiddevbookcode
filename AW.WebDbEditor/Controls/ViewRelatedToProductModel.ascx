
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToProductModel.ascx.cs" Inherits="Controls_ViewRelatedToProductModel" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductsInstances" Src="ListProductInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductModelIllustrationsInstances" Src="ListProductModelIllustrationInstances.ascx"%>
<%@ Register TagPrefix="dbeditor" TagName="ProductModelProductDescriptionCulturesInstances" Src="ListProductModelProductDescriptionCultureInstances.ascx"%>
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
	<tr>
		<td class="headers">
			Related ProductModelIllustration instances (field mapped: ProductModelIllustrations)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:ProductModelIllustrationsInstances ID="laProductModelIllustrations" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
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
	