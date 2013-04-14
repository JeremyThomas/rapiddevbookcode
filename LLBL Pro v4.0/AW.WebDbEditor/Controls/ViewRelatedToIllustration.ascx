
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToIllustration.ascx.cs" Inherits="Controls_ViewRelatedToIllustration" %>
<%@ Register TagPrefix="dbeditor" TagName="ProductModelIllustrationsInstances" Src="ListProductModelIllustrationInstances.ascx"%>
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
	