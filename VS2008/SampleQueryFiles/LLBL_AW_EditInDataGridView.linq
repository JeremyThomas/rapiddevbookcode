<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;System.Windows.Forms.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Helper.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Data.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Helper.LLBL.dll</Reference>
  <Namespace>AW.Data</Namespace>
  <Namespace>AW.Data.Linq</Namespace>
  <Namespace>AW.Helper.LLBL</Namespace>
  <Namespace>AW.Winforms.Helpers.DataEditor</Namespace>
  <Namespace>SD.LLBLGen.Pro.ORMSupportClasses</Namespace>
</Query>

var contacts =  from contact in MetaSingletons.MetaData.Contact
where contact.FirstName.Contains("Albert")
select contact;

AW.Winforms.Helpers.DataEditor.DataEditorExtensions.ShowInGrid(contacts, EntityHelper.Save).Dump();