<Query Kind="Statements">
	<Connection>
		<ID>555af9c4-5f4a-49bb-bd33-689cc1ecec90</ID>
		<Server>.\SQLEXPRESS</Server>
		<Database>Northwind</Database>
		<ShowServer>true</ShowServer>
	</Connection>
	<Reference Relative="..\..\..\Visual Studio 2010\Visualizers\AW.EnumerableVisualizer.dll">&lt;Personal&gt;\Visual Studio 2010\Visualizers\AW.EnumerableVisualizer.dll</Reference>
	<Namespace>AW.Winforms.Helpers.DataEditor</Namespace>
</Query>

var contacts = from c in Customers
	where c.ContactName.StartsWith("A") 
	select c;

contacts.ShowInGrid().Dump();	
//contacts.ShowInGrid(Customers.Context).Dump();
//((IEnumerable)contacts).ShowInGrid(null).Dump();