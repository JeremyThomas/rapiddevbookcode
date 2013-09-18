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
[assembly: InternalsVisibleTo("AW.LLBLGen.DataContextDriver.Tests, PublicKey="
                              + "0024000004800000940000000602000000240000525341310004000001000100b7ca1ffad3dde8"
                              + "8292c0d17093ac90812579d80cacffbd97c9c7c61db7f65bea9ade61e8f3ddfb19704bdc653c8f"
                              + "40917a46a0d5439f966f05e0917e90b79ed42743afc1bded5b691fd75c2f4e4b8a70914c7ac27f"
                              + "2c0f9575393453f4ed2173d7cbb3259cc8216ceb4b6020b25e033c7207b53024187d05fcb11497"
                              + "281fd0c3")]


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