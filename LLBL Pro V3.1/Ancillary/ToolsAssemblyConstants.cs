using System.Reflection;
using System.Security;

internal static class ToolsAssemblyInfoConstants
{
	public const string Author = "Jeremy Thomas";
	public const string AssemblyCompany = Author;
	public const string CopyrightYear = "2012";
	public const string AssemblyCopyright = "Copyright " + CopyrightYear + " " + AssemblyCompany;
	public const string ExecutableVersion = AssemblyInformationalVersion + "." + ExecutableRevision;
	// Compile a Debug or Release flag into the assembly.
#if DEBUG
	/// <summary>
	/// Debug
	/// </summary>
	public const string AssemblyConfiguration = "Debug";
#else
	public const string AssemblyConfiguration = "Release";
#endif
	public const string ConfigurationSuffix = "\r\nBuild: " + AssemblyConfiguration;
}

