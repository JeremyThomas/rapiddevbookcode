<Query Kind="Expression">
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.DQE.SqlServer.NET20.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Helper\bin\Debug\AW.Helper.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Data.dll</Reference>
  <Reference>C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\AW.Win\bin\Debug\AW.Business.dll</Reference>
  <Namespace>AW.Data</Namespace>
  <Namespace>AW.Data.Linq</Namespace>
  <Namespace>AW.Data.HelperClasses</Namespace>
</Query>

from contact in MetaSingletons.MetaData.Contact
		 where contact.FirstName.Contains("Albert") 
		 select contact 