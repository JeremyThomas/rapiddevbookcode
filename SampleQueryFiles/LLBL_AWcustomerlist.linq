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
</Query>

var customerlist = from individual in Individual
												 from customerAddress in individual.CustomerAddresses
												 select new
																	{
																		customerAddress.Address.AddressLine1,
																		customerAddress.Address.AddressLine2,
																		customerAddress.Address.City,
																		AddressType = customerAddress.AddressType.Name,
																		individual.Contact.Title,
																		individual.Contact.FirstName,
																		individual.Contact.MiddleName,
																		individual.Contact.LastName,
																		individual.Contact.Suffix,
																		individual.Contact.EmailAddress,
																		individual.Contact.EmailPromotion,
																		CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
																		StateProvinceName = customerAddress.Address.StateProvince.Name,
																		individual.CustomerID
																	};
customerlist.Take(5).Dump ();