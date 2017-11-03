## Motivation
I was wanting to evaluate Linq to LLBLGen but there was no working example code anywhere including here: [LLBLGen Example projects](http://www.llblgen.com/pages/examples.aspx) nor was there any example of a enquiry/search screen with conditional filtering with even the normal LLBLGen query API. The only one I could find was in Joseph Chancellor's book. I come across an example of Dynamic Predicate Construction with LINQ to SQL on code project here: [LINQ and Dynamic Predicate Construction at Run-time](http://www.codeproject.com/KB/linq/LINQDynamicPredicate.aspx). I decided to combine the two.

## AdventureWorks links:
* [Adventure Works Cycles Business Scenarios](http://msdn.microsoft.com/en-us/library/ms124825(v=sql.100).aspx)
* [Analysis of the AdventureWorks sample database by Wilson Mar](http://www.wilsonmar.com/sql_adventureworks.htm)
* [Microsoft SQL Server Community Projects & Samples](http://sqlserversamples.codeplex.com)
* [AdventureWorks Data Dictionary](http://msdn.microsoft.com/en-us/library/ms124438(v=sql.100).aspx)
### Other AdventureWorks samples:
* [AdventureWorks Data Binding sample demonstrates data binding that uses the Entity Framework](http://code.msdn.microsoft.com/AdventureWorks-Data-702f3dea)
* Linq to SQL, WPF and AdventureWorksLT:[AdventureWorks.WPF (Part 1)](http://www.codeproject.com/KB/WPF/AdventureWorks_Part1.aspx)
* [ASP.NET MVC3 EF 4](http://unboxedsolutions.com/sean/archive/2011/01/23.aspx)

## AdventureWorks Inheritance Hierarchies
**Target Per Entity (Table Per Type - TPT)**
Sales and Individual descend from Customer.
**Target Per Entity Hierarchy (Table Per Hierarchy - TPH)**
PurchaseOrderHistory, SalesOrderHistory and WorkOrderHistory descend from TransactionHistory with a TransactionType as the discriminator column, TransactionHistory is abstract.

## Northwind Samples:
* [MVC Techniques with JQuery, JSON, Knockout and C#](http://www.codeproject.com/KB/aspnet/MVC4Techniques1.aspx)
* [Northwind Starter Kit](http://nsk.codeplex.com)
* [Northwind.NET](http://northwind.codeplex.com)