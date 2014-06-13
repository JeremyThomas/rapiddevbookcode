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
                              + "00240000048000009400000006020000002400005253413100040000010001" 
                              + "00617C527F26977F11BF44A006FA17B0E76B3B733474167628978F3EFCBBA78591E491CA015B8D9F06C7A820218C0353BE65E59C4D26455723EC3CAA09273A7F88323" 
                              + "A8F789B83B0FC9EEC3DC648B2ECBF42F56A1627E1327A129A4620044FA2F5B9CCC13E56CFB1D125D14799642F358CB45D56C305C033F77E5ACD93479576C7")]


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