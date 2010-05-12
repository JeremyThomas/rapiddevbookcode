<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;System.Windows.Forms.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Solutions Design\LLBLGen Pro v2.6\SD.LLBLGen.Pro.ApplicationCore.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Solutions Design\LLBLGen Pro v2.6\SD.LLBLGen.Pro.DBDriverCore.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.LLBL.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Helper.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Winforms.Helpers.dll</Reference>
  <Namespace>SD.LLBLGen.Pro.ApplicationCore</Namespace>
  <Namespace>SD.LLBLGen.Pro.ApplicationCore.Entities</Namespace>
  <Namespace>AW.Winforms.Helpers.LLBL.PropGridEx</Namespace>
</Query>

var project = Project.Load(@"C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\Ancillary\AW.Data.Plural.lgp");
FrmLLBLEntityViewer.LaunchAsChildForm(project);
