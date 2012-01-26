
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ViewRelatedToSpecialOffer.ascx.cs" Inherits="Controls_ViewRelatedToSpecialOffer" %>
<%@ Register TagPrefix="dbeditor" TagName="SpecialOfferProductsInstances" Src="ListSpecialOfferProductInstances.ascx"%>
	<tr>
		<td class="headers">
			Related SpecialOfferProduct instances (field mapped: SpecialOfferProducts)
		</td>
	</tr>
	<tr>
		<td class="content">
			<dbeditor:SpecialOfferProductsInstances ID="laSpecialOfferProducts" runat="server" ShowHomeButton="false" />
			<br/><br/>
		</td>
	</tr>
	