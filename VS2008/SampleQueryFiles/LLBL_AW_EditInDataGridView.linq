<Query Kind="Statements">
	<Connection>
		<ID>ef8747dd-2566-4173-a9e3-fedb42963675</ID>
		<Persist>true</Persist>
		<Driver Assembly="AW.LLBLGen.DataContextDriver" PublicKeyToken="d500980a8809e663">AW.LLBLGen.DataContextDriver.Static.LLBLGenStaticDriver</Driver>
		<CustomAssemblyPath>C:\Users\jeremy.thomas\Documents\Visual Studio 2010\Projects\Codeplex\RapidDevBookCode\AW.Win\bin\Debug\AW.Data.dll</CustomAssemblyPath>
		<CustomTypeName>AW.Data.Linq.LinqMetaData</CustomTypeName>
		<Server>AW 3.0  connection string</Server>
		<CustomCxString>data source=(local)\sqlexpress;initial catalog=AdventureWorks;integrated security=SSPI</CustomCxString>
		<DisplayName>AW 3.0 - connection string</DisplayName>
	</Connection>
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

var contacts =  from contact in Contact
				where contact.FirstName.Contains("Albert") 
				select contact;
					
contacts.ShowSelfServicingInGrid().Dump();
