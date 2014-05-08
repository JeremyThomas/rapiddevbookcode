using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace AW.Helper
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
  public static class VisualStudioHelper
  {
    /// <summary>
    ///   Gets the installation (Common7) directory of a given Visual Studio Version
    /// </summary>
    /// <param name="version">Visual Studio Version</param>
    /// <returns>Null if not installed the installation directory otherwise</returns>
    internal static string GetVisualStudioInstallationCommonDir(VisualStudioVersion version)
    {
      var registryKeyString = GetRegistryKeyString(version, Environment.Is64BitProcess);

      using (var localMachineKey = Registry.LocalMachine.OpenSubKey(registryKeyString))
        if (localMachineKey != null)
        {
          var installDirIde = Convert.ToString(localMachineKey.GetValue("InstallDir"));
          var ideLength = @"/IDE".Length;
          if (installDirIde.Length > ideLength)
            return installDirIde.Remove(installDirIde.Length - ideLength, ideLength); //Remove /IDE
        }
      var vscomntoolsDir = Environment.GetEnvironmentVariable("VS" + (int) version + "COMNTOOLS");
      var toolsLength = @"/Tools".Length;
      return vscomntoolsDir == null ? null : vscomntoolsDir.Remove(vscomntoolsDir.Length - toolsLength, toolsLength); //Remove /Tools
    }

    private static string GetRegistryKeyString(VisualStudioVersion version, bool is64BitProcess)
    {
      var registryKeyString = String.Format(@"SOFTWARE{0}Microsoft\VisualStudio\{1}",
        is64BitProcess ? @"\Wow6432Node\" : "\\",
        GetVersionNumber(version));
      return registryKeyString;
    }

    public static string GetVisualStudioDebuggerVisualizersDir(VisualStudioVersion version)
    {
      return GetVisualStudioInstallationCommonDir(version) + @"Packages\Debugger\Visualizers";
    }

    internal static string GetVisualStudioUserDir(VisualStudioVersion version)
    {
      //HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\11.0
      var registryKeyString = GetRegistryKeyString(version, false);

      string visualStudioUserDir;
      using (var currentUserKey = Registry.CurrentUser.OpenSubKey(registryKeyString))
        if (currentUserKey != null)
        {
          var visualStudioLocation = Convert.ToString(currentUserKey.GetValue("VisualStudioLocation"));
          visualStudioUserDir = Environment.ExpandEnvironmentVariables(visualStudioLocation);
          if (Directory.Exists(visualStudioUserDir))
            return visualStudioUserDir;
        }
      visualStudioUserDir = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), version.EnumToString().Replace("VS", "Visual Studio"));
      return Directory.Exists(visualStudioUserDir) ? visualStudioUserDir : null;
    }

    public static string GetVisualStudioDebuggerVisualizersUserDir(VisualStudioVersion version)
    {
      var visualStudioUserDir = GetVisualStudioUserDir(version);
      if (string.IsNullOrWhiteSpace(visualStudioUserDir))
        return "Visualizers Dir not found";
      var visualStudioDebuggerVisualizersUserDir = visualStudioUserDir + @"\Visualizers";
      if (!Directory.Exists(visualStudioDebuggerVisualizersUserDir))
        return string.Format("Visualizers Dir, <{0}>, not found", visualStudioDebuggerVisualizersUserDir);
      return visualStudioDebuggerVisualizersUserDir;
    }

    /// <summary>
    ///   Gets the version number as used by Visual Studio to identify it's version internally.
    ///   eg: Visual Studio 2010 is 10.0 and Visual Studio 2008 is 9.0
    /// </summary>
    /// <param name="version">Visual Studio Version</param>
    /// <returns>A string with the VS internal number version</returns>
    private static string GetVersionNumber(VisualStudioVersion version)
    {
      if (version == VisualStudioVersion.Other)
        throw new Exception("Not supported version");
      return ((int) version/10).ToString("00.0", CultureInfo.InvariantCulture);
    }

    public static VisualStudioVersion GetVisualStudioVersion(int versionNumber)
    {
      var enumType = typeof (VisualStudioVersion);
      if (Enum.IsDefined(enumType, versionNumber))
        return (VisualStudioVersion) versionNumber;
      versionNumber = versionNumber*10;
      if (Enum.IsDefined(enumType, versionNumber))
        return (VisualStudioVersion) versionNumber;
      //GeneralHelper.EnumAsEnumerable<VisualStudioVersion>().FirstOrDefault()
      return VisualStudioVersion.Other;
    }

    public static string InstallDebuggerVisualizer(string debuggerVisualizerFileName, string debuggerVisualizerSourceDir, VisualStudioVersion visualStudioVersion)
    {
      string result = null;
      var debuggerVisualizersDir = GetVisualStudioDebuggerVisualizersDir(visualStudioVersion);
      if (Directory.Exists(debuggerVisualizersDir) && Directory.Exists(debuggerVisualizerSourceDir))
      {
        var target = Path.Combine(debuggerVisualizersDir, debuggerVisualizerFileName);
        var source = Path.Combine(debuggerVisualizerSourceDir, debuggerVisualizerFileName);

        var sourceVisualizerFileInfo = new FileInfo(source);
        var targetVisualizerFileInfo = new FileInfo(target);

        if (sourceVisualizerFileInfo.Exists)
          if (targetVisualizerFileInfo.Exists)
          {
            if (sourceVisualizerFileInfo.LastWriteTime != targetVisualizerFileInfo.LastWriteTime)
              File.Copy(source, target, true);
          }
          else
            File.Copy(source, target);
        else
        {
          result = sourceVisualizerFileInfo.FullName + " does not exist";
        }
      }
      else
      {
        result = string.Format("{0} or {1} does not exist", debuggerVisualizersDir, debuggerVisualizerSourceDir);
      }
      if (result != null)
        Trace.WriteLine(result);
      return result;
    }

    public static string GetDebuggerVisualizerSourceDir(Assembly assembly)
    {
      var debuggerVisualizerSourceDir = "";
      try
      {
        var location = assembly.Location;
        debuggerVisualizerSourceDir = Path.GetDirectoryName(location);
      }
      catch (NotSupportedException ex)
      {
        Debug.WriteLine(ex.Message);
      }
      return debuggerVisualizerSourceDir;
    }
  }
}