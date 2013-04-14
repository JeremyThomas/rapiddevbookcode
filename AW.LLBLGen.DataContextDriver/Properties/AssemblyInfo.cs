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
[assembly: InternalsVisibleTo("AW.LLBLGen.DataContextDriver.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100db4309d4c2fb9b"
															+ "c4ba12a6d6163587d704350d54d3c13980c615bf84a4718f39999550a2aead79aada61a18de527"
															+ "a2c5200da0600c6f2c9b85b1e0a6b4c659cabeca555ce261fcbe1201ad101c18c690c4af8785e1"
															+ "4af27d33d1812da526f20e6e1c32bfb53dc536c30ee66080c645778fb49664fcaf9cddedf4b0a9517044a8")]

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