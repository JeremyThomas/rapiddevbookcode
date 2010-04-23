<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Helper.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.LLBL.dll</Reference>
</Query>

// In LINQPad we're *inside* the DataContext, so don't need to instantiate it:

AW.Winforms.Helpers.DataEditor.DataEditorExtensions.EditInDataGridView(Customers, null).Dump ("All customers");