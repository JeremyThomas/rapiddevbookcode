
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListWorkOrderRoutingInstances.ascx.cs" Inherits="Controls_ListWorkOrderRoutingInstances" %>
<%@ Import Namespace="AW.Data"%>
<asp:placeholder id="phHomeButton" runat="server" Visible="true">
	<asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" SkinID="ButtonSkin"/>
	&nbsp;&nbsp;&nbsp;
</asp:placeholder>

<asp:placeholder id="phAddNewButton" runat="server" Visible="true">
	<asp:button ID="btnAddNew" runat="server" Text="Add new" SkinID="ButtonSkin" OnClick="btnAddNew_Click"/>
</asp:placeholder>

<asp:placeholder id="phExportToExcelButton" runat="server" Visible="true">
	<asp:button ID="btnExportToExcel" runat="server" Text="Export to excel..." SkinID="ButtonSkin" OnClick="btnExportToExcel_Click"/>
</asp:placeholder>
<llblgenpro:LLBLGenProDataSource ID="_WorkOrderRoutingDS" runat="server" DataContainerType="EntityCollection" EntityCollectionTypeName="AW.Data.CollectionClasses.WorkOrderRoutingCollection, AW.Data" CacheLocation="Session" EnablePaging="True" />
<asp:GridView ID="theGrid" runat="server" SkinID="gridviewSkin" AutoGenerateColumns="False" DataKeyNames="OperationSequence, ProductID, WorkOrderID" 
					DataSourceID="_WorkOrderRoutingDS" OnRowCommand="theGrid_RowCommand">
	<Columns>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" >
			<ItemTemplate>
				<asp:Button ID="btnViewExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="ViewExisting" Text="View" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders">
			<ItemTemplate>
				<asp:Button ID="btnEditExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="EditExisting" Text="Edit" SkinID="ButtonSkin" />
			</ItemTemplate>
		</asp:TemplateField>

		<asp:TemplateField ShowHeader="False" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" HeaderStyle-CssClass="tableheaders" HeaderStyle-HorizontalAlign="Left">
			<ItemTemplate>
				<asp:Button ID="btnDeleteExisting" runat="server" CausesValidation="false" CommandArgument='<%# DataBinder.Eval(Container,"RowIndex") %>' CommandName="Delete" Text="Delete" SkinID="ButtonSkin" OnClientClick='<%# "return confirm(\"Are you sure you want to delete this WorkOrderRouting instance with PK values: "  + "OperationSequence: " + Eval("OperationSequence") + ", " + "ProductID: " + Eval("ProductID") + ", " + "WorkOrderID: " + Eval("WorkOrderID") + " ?\");" %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActualCost" SortExpression="ActualCost" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblActualCost" runat="server" Text='<%# Bind("ActualCost", "{0:0.##}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActualEndDate" SortExpression="ActualEndDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblActualEndDate" runat="server" Text='<%# Bind("ActualEndDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActualResourceHrs" SortExpression="ActualResourceHrs" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblActualResourceHrs" runat="server" Text='<%# Bind("ActualResourceHrs", "{0:0.##}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ActualStartDate" SortExpression="ActualStartDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblActualStartDate" runat="server" Text='<%# Bind("ActualStartDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="LocationID" SortExpression="LocationID"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:HyperLink ID="lnkLocationID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.LocationEntity).ToString() + "&LocationID=" + Eval("LocationID")%>' Text='<%# Bind("LocationID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ModifiedDate" SortExpression="ModifiedDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblModifiedDate" runat="server" Text='<%# Bind("ModifiedDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="OperationSequence" SortExpression="OperationSequence" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblOperationSequence" runat="server" Text='<%# Bind("OperationSequence") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="PlannedCost" SortExpression="PlannedCost" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblPlannedCost" runat="server" Text='<%# Bind("PlannedCost", "{0:0.##}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ProductID" SortExpression="ProductID" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblProductID" runat="server" Text='<%# Bind("ProductID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ScheduledEndDate" SortExpression="ScheduledEndDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblScheduledEndDate" runat="server" Text='<%# Bind("ScheduledEndDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="ScheduledStartDate" SortExpression="ScheduledStartDate"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:Label ID="lblScheduledStartDate" runat="server" Text='<%# Bind("ScheduledStartDate", "{0:mm/dd/yyyy}") %>'/>
			</ItemTemplate>
		</asp:TemplateField>
		<asp:TemplateField HeaderText="WorkOrderID" SortExpression="WorkOrderID"  HeaderStyle-HorizontalAlign="Left" ItemStyle-CssClass="ColumnContent" ItemStyle-Wrap="false" >
			<ItemTemplate>
				<asp:HyperLink ID="lnkWorkOrderID" runat="server" NavigateUrl='<%# "~/ViewExisting.aspx?EntityType=" + ((int)EntityType.WorkOrderEntity).ToString() + "&WorkOrderID=" + Eval("WorkOrderID")%>' Text='<%# Bind("WorkOrderID") %>'/>
			</ItemTemplate>
		</asp:TemplateField>

	</Columns>
	<PagerStyle CssClass="headers" HorizontalAlign="Center" />
	<HeaderStyle CssClass="tableheaders" />
</asp:GridView>
