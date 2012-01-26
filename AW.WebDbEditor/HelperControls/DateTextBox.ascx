<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DateTextBox.ascx.cs" Inherits="HelperControls_DateTextBox" %>
<asp:TextBox ID="tbxMonth" CssClass="required" runat="server" MaxLength="2" Size="2"/><asp:RangeValidator ID="valMonth" runat="server" ControlToValidate="tbxMonth" Display="dynamic" ErrorMessage="*" MinimumValue="1" MaximumValue="12" Type="integer"/>
 / <asp:TextBox ID="tbxDay" CssClass="required" runat="server" MaxLength="2" Size="2"/><asp:RangeValidator ID="valDay" runat="server" ControlToValidate="tbxDay" Display="dynamic" ErrorMessage="*" MinimumValue="1" MaximumValue="31" Type="integer"/>
 / <asp:TextBox ID="tbxYear" CssClass="required" runat="server" MaxLength="4" Size="4"/><asp:RegularExpressionValidator ID="valYear" runat="server" ControlToValidate="tbxYear" Display="dynamic" ValidationExpression="(\d){4}" ErrorMessage="*"/> <asp:Label ID="lblDateDescription" runat="server" Text="(mm/dd/yyyy)" SkinID="DateDescriptionLabelSkin"/>
</asp:PlaceHolder>
