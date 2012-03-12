using System.Reflection;
using System.Security;

[assembly: AssemblyCompany(ToolsAssemblyInfoConstants.AssemblyCompany)]
[assembly: AssemblyCopyright(ToolsAssemblyInfoConstants.AssemblyCopyright)]

internal static class ToolsAssemblyInfoConstants
{
	public const string Author = "Jeremy Thomas";
	public const string AssemblyCompany = Author;
	public const string CopyrightYear = "2012";
	public const string AssemblyCopyright = "Copyright " + CopyrightYear + " " + AssemblyCompany;
}

