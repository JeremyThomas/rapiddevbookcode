using System.Reflection;

[assembly: AssemblyCompany(ToolsAssemblyInfoConstants.AssemblyCompany)]
[assembly: AssemblyCopyright(ToolsAssemblyInfoConstants.AssemblyCopyright)]
[assembly: AssemblyProduct(ToolsAssemblyInfoConstants.AssemblyProduct)]

internal static class ToolsAssemblyInfoConstants
{
	public const string Author = "Jeremy Thomas";
	public const string AssemblyCompany = Author;
	public const string CopyrightYear = "2014";
	public const string AssemblyCopyright = "Copyright " + CopyrightYear + " " + AssemblyCompany;
	public const string AssemblyProduct = AssemblyCompany + "'s Helper libraries";
}

