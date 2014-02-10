using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace JeremyThomas.EnumerableVisualizerVSPackage
{
  /// <summary>
  ///   This is the class that implements the package exposed by this assembly.
  ///   The minimum requirement for a class to be considered a valid package for Visual Studio
  ///   is to implement the IVsPackage interface and register itself with the shell.
  ///   This package uses the helper classes defined inside the Managed Package Framework (MPF)
  ///   to do it: it derives from the Package class that provides the implementation of the
  ///   IVsPackage interface and uses the registration attributes defined in the framework to
  ///   register itself and its components with the shell.
  /// </summary>
  // This attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class is
  // a package.
  [PackageRegistration(UseManagedResourcesOnly = true)]
  // This attribute is used to register the information needed to show this package
  // in the Help/About dialog of Visual Studio.
  [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
  [Guid(GuidList.guidEnumerableVisualizerVSPackagePkgString)]
  //Setting initialization to the opening of a solution file
  [ProvideAutoLoad("D2567162-F94F-4091-8798-A096E61B8B50")]
  public sealed class EnumerableVisualizerVsPackage : Package
  {
    /// <summary>
    ///   Default constructor of the package.
    ///   Inside this method you can place any initialization code that does not require
    ///   any Visual Studio service because at this point the package object is created but
    ///   not sited yet inside Visual Studio environment. The place to do all the other
    ///   initialization is the Initialize method.
    /// </summary>
    public EnumerableVisualizerVsPackage()
    {
      Debug.WriteLine(VisualStudioHelper.InstallDebuggerVisualizer("AW.EnumerableVisualizer.2013.dll",
        VisualStudioHelper.GetDebuggerVisualizerSourceDir(GetType().Assembly),
        VisualStudioVersion.VS2013));
    }

    /////////////////////////////////////////////////////////////////////////////
    // Overridden Package Implementation

    #region Package Members

    #endregion
  }
}