
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListCustomerViewInstancesReport.ascx.cs" Inherits="Controls_ListCustomerViewInstancesReport" %>
<%@ Import Namespace="AW.Data"%>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<llblgenpro:LLBLGenProDataSource ID="_CustomerViewDS" runat="server" 
	DataContainerType="TypedView" 
	TypedViewTypeName="AW.Data.TypedViewClasses.CustomerViewTypedView, AW.Data" 
	CacheLocation="Session" EnablePaging="True" />

<rsweb:ReportViewer ID="theReportViewer" runat="server" Width="100%"  SizeToReportContent="true">
    <LocalReport ReportPath= "Reports\\CustomerViewReport.rdlc">
        <DataSources>
            <rsweb:ReportDataSource DataSourceId="_CustomerViewDS" Name="CustomerView" />
        </DataSources>
    </LocalReport>
</rsweb:ReportViewer> 
