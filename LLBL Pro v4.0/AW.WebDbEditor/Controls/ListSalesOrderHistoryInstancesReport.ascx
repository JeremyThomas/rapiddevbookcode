
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListSalesOrderHistoryInstancesReport.ascx.cs" Inherits="Controls_ListSalesOrderHistoryInstancesReport" %>
<%@ Import Namespace="AW.Data"%>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>
<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>
<llblgenpro:LLBLGenProDataSource ID="_SalesOrderHistoryDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.SalesOrderHistoryCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />

<rsweb:ReportViewer ID="theReportViewer" runat="server" Width="100%"  SizeToReportContent="true">
    <LocalReport ReportPath= "Reports\\SalesOrderHistoryReport.rdlc">
        <DataSources>
            <rsweb:ReportDataSource DataSourceId="_SalesOrderHistoryDS" Name="SalesOrderHistory" />
        </DataSources>
    </LocalReport>
</rsweb:ReportViewer> 
