<Query Kind="Expression">
  <Connection>
    <ID>75fd4086-1459-47ce-b6a5-3e7cfc442712</ID>
    <Driver>LinqToSql</Driver>
    <Server>(local)\sqlexpress</Server>
    <CustomAssemblyPath>C:\Users\jeremy.thomas\Documents\Visual Studio 2010\Projects\Codeplex\RapidDevBookCode\AW.Test\bin\Debug\AW.LinqToSQL.dll</CustomAssemblyPath>
    <CustomTypeName>AW.LinqToSQL.AWDataClassesDataContext</CustomTypeName>
    <Database>AdventureWorks</Database>
    <Persist>true</Persist>
    <DisplayName>AW LINQToSQL</DisplayName>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;Personal&gt;\Visual Studio 2010\Projects\Codeplex\RapidDevBookCode\AW.Test\bin\Debug\AW.Helper.dll</Reference>
  <Reference>&lt;Personal&gt;\Visual Studio 2010\Projects\Codeplex\RapidDevBookCode\AW.Test\bin\Debug\AW.Winforms.Helpers.dll</Reference>
  <Reference>&lt;Personal&gt;\Visual Studio 2010\Projects\Codeplex\RapidDevBookCode\AW.Test\bin\Debug\AW.LinqToSQL.dll</Reference>
  <Namespace>AW.Winforms.Helpers.DataEditor</Namespace>
</Query>

Employees.ShowHierarchyInTree("EmployeeID", "ManagerID", "Title")