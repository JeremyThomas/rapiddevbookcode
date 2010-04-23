<Query Kind="Statements">
  <Connection>
    <ID>3e384ac1-e7dc-4102-b879-666800b3d4d9</ID>
    <Server>.\SQLEXPRESS</Server>
    <ShowServer>true</ShowServer>
    <Database>Northwind</Database>
  </Connection>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Helper.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.LLBL.dll</Reference>
</Query>

var contacts = from c in Customers
	where c.ContactName.StartsWith("A") 
	select c;
AW.Winforms.Helpers.DataEditor.DataEditorExtensions.EditInDataGridView(contacts, null).Dump();