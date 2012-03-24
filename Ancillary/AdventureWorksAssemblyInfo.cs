using System.Reflection;

[assembly: AssemblyCompany(AdventureWorksAssemblyInfoConstants.AssemblyCompany)]
[assembly: AssemblyCopyright(AdventureWorksAssemblyInfoConstants.AssemblyCopyright)]
[assembly: AssemblyProduct(AdventureWorksAssemblyInfoConstants.AssemblyProduct)]

internal static class AdventureWorksAssemblyInfoConstants
{
	public const string AssemblyCompany = "Adventure Works Cycles";
	public const string AssemblyCopyright = "Copyright © 2012 " + AssemblyCompany;
	public const string AssemblyProduct = AssemblyCompany + " LLBL Sample";
}

