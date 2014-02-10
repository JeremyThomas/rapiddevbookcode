using System;
using System.Globalization;
using Microsoft.Win32;

namespace JeremyThomas.EnumerableVisualizerVSPackage
{
  /// <summary>
  ///   Represents the several visual studio versions.
  ///   Internally the value is stored as the VS internal number multiplied by 10 (eg: VS2010 is 100 since it's internal
  ///   version number is 10.0)
  /// </summary>
  public enum VisualStudioVersion
  {
    VS2013 = 120,
    VS2012 = 110,
    VS2010 = 100,
    VS2008 = 90,
    VS2005 = 80,
    VSNet2003 = 71,
    VSNet2002 = 70,
    Other = 0
  };

  /// <summary>
  ///   Gets the installation path of a given VS version.
  ///   http://pascoal.net/2011/04/getting-visual-studio-installation-directory/
  ///   Supported versions 2005, 2008 and 2010, .Net 2003 and .Net 2002
  /// </summary>
  internal static class VisualStudioHelper
  {
    /// <summary>
    ///   Gets the installation (Common7) directory of a given Visual Studio Version
    /// </summary>
    /// <param name="version">Visual Studio Version</param>
    /// <returns>Null if not installed the installation directory otherwise</returns>
    internal static string GetVisualStudioInstallationCommonDir(VisualStudioVersion version)
    {
      var registryKeyString = String.Format(@"SOFTWARE{0}Microsoft\VisualStudio\{1}",
        Environment.Is64BitProcess ? @"\Wow6432Node\" : "\\",
        GetVersionNumber(version));

      using (var localMachineKey = Registry.LocalMachine.OpenSubKey(registryKeyString))
        if (localMachineKey != null)
        {
          var installDirIde = Convert.ToString(localMachineKey.GetValue("InstallDir"));
          if (installDirIde != null) return installDirIde.Remove(installDirIde.Length - 4, 4); //Remove /IDE
        }
      var vscomntoolsDir = Environment.GetEnvironmentVariable("VS" + (int)version + "COMNTOOLS");
      return vscomntoolsDir == null ? null : vscomntoolsDir.Remove(vscomntoolsDir.Length - 6, 6); //Remove /Tools
    }

    internal static string GetVisualStudioDebuggerVisualizersDir(VisualStudioVersion version)
    {
      return GetVisualStudioInstallationCommonDir(version) + @"Packages\Debugger\Visualizers";
    }

    /// <summary>
    ///   Gets the version number as used by Visual Studio to identify it's version internally.
    ///   eg: Visual Studio 2010 is 10.0 and Visual Studio 2008 is 9.0
    /// </summary>
    /// <param name="version">Visual Studio Version</param>
    /// <returns>A string with the VS internal number version</returns>
    private static string GetVersionNumber(VisualStudioVersion version)
    {
      if (version == VisualStudioVersion.Other) throw new Exception("Not supported version");

      return ((int) version/10).ToString("00.0", CultureInfo.InvariantCulture);
    }
  }
}