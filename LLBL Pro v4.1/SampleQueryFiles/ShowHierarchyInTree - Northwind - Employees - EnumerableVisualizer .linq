<Query Kind="Expression">
  <Connection>
    <ID>504f0219-5ccf-41fe-8e23-8ca9351286ba</ID>
    <Persist>true</Persist>
    <Server>(local)\sqlexpress</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference Relative="..\..\..\Visual Studio 2010\Visualizers\AW.EnumerableVisualizer.dll">&lt;Personal&gt;\Visual Studio 2010\Visualizers\AW.EnumerableVisualizer.dll</Reference>
  <Namespace>AW.Winforms.Helpers.DataEditor</Namespace>
</Query>

Employees.ShowHierarchyInTree("EmployeeID", "ReportsTo", "FirstName")