<Query Kind="Statements">
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

//DbUtils.ActualConnectionString = @"data source=DELL-8600\SQLEXPRESS;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096";

		var customerlist = from customer in MetaSingletons.MetaData.Customer
						 from customerAddress in customer.CustomerAddresses
						 select new
								  {
									customerAddress.Address.AddressLine1,
									customerAddress.Address.AddressLine2,
									customerAddress.Address.City,
									AddressType = customerAddress.AddressType.Name,
									customer.Individual.Contact.Title,
									customer.Individual.Contact.FirstName,
									customer.Individual.Contact.MiddleName,
									customer.Individual.Contact.LastName,
									customer.Individual.Contact.Suffix,
									customer.Individual.Contact.EmailAddress,
									customer.Individual.Contact.EmailPromotion,
									CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
									StateProvinceName = customerAddress.Address.StateProvince.Name,
									customer.CustomerID
								  };
	  customerlist.Take(5).Dump ();