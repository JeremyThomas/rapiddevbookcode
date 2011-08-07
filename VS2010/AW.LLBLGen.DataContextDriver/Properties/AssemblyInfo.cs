using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AW.LLBLGen.DataContextDriver;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle(Constants.DriverName)]
[assembly: AssemblyDescription(Constants.AssemblyDescription)]
[assembly: AssemblyProduct(Constants.AssemblyProduct)]
[assembly: AssemblyCompany(Constants.AssemblyCompany)]
[assembly: AssemblyCopyright(Constants.AssemblyCopyright)]
[assembly: InternalsVisibleTo("AW.LLBLGen.DataContextDriver.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001007d800709f8676f"
															+ "e5986fc7818b30ce8693b45184b69b1cfb4b311b0fb90d5852c11d7cff4e7b6e68af070ee5cfc5"
															+ "bd70d92e236eb771f2729a2844f63474868ef1fbbc2e55d784240a0d360e7a706fb2a68eaf6fc2"
															+ "7effb4a7a5666fe41e363bc0c61aa23840f57cc71f3048da0a94d300429e23951bb4fb5a0a766b4dd9eaa5")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion(Constants.AssemblyVersion)]

// The AssemblyFileVersion appears to users when they import Data Context Drivers.

[assembly: AssemblyFileVersion(Constants.AssemblyVersion)]