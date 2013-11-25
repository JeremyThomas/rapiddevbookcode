using System.Reflection;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyConfiguration(AssemblyInfoConstants.AssemblyConfiguration)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyInformationalVersion(AssemblyInfoConstants.AssemblyInformationalVersion)]

internal static class AssemblyInfoConstants
{
  /// <summary>
  ///   4.1
  /// </summary>
  public const string AssemblyInformationalVersion = "4.1";

  public const string AssemblyRevision = "0";

  /// <summary>
  ///   4.1.0.0
  /// </summary>
  public const string AssemblyVersion = AssemblyInformationalVersion + ".0." + AssemblyRevision;

  public const string ExecutableRevision = "0";
  public const string ExecutableVersion = AssemblyInformationalVersion + ".0." + ExecutableRevision;
  // Compile a Debug or Release flag into the assembly.
#if DEBUG
  /// <summary>
  ///   Debug
  /// </summary>
  public const string AssemblyConfiguration = "Debug";
#else
  public const string AssemblyConfiguration = "Release";
#endif
  public const string ConfigurationSuffix = "\r\nBuild: " + AssemblyConfiguration;
}

//[assembly: AllowPartiallyTrustedCallers]

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile 
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
//[assembly: AssemblyKeyName("")]