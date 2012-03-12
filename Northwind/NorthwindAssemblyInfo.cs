using System.Reflection;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

[assembly: AssemblyCompany(NorthwindAssemblyInfoConstants.AssemblyCompany)]
[assembly: AssemblyCopyright(NorthwindAssemblyInfoConstants.AssemblyCopyright)]
[assembly: AssemblyProduct(NorthwindAssemblyInfoConstants.AssemblyProduct)]

internal static class NorthwindAssemblyInfoConstants
{
	public const string AssemblyCompany = "Northwind Traders";
	public const string AssemblyCopyright = "Copyright © 2012 " + AssemblyCompany;
	public const string AssemblyProduct = AssemblyCompany + " LLBL Sample";
}