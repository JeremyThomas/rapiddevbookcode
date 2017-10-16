using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Setup.Configuration;
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
    // ReSharper disable InconsistentNaming
    VS2017 = 150,
    VS2015 = 140,
    VS2013 = 120,
    VS2012 = 110,
    VS2010 = 100,
    VS2008 = 90,
    VS2005 = 80,
    VSNet2003 = 71,
    VSNet2002 = 70,
    Other = 0
  }

// ReSharper restore InconsistentNaming

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

      if (vscomntoolsDir == null)
      {
        var query = GetQuery();
        var query2 = (ISetupConfiguration2)query;
        var e = query2.EnumAllInstances();
        int fetched;
        var instances = new ISetupInstance[1];
        do
        {
          e.Next(1, instances, out fetched);
          if (fetched > 0)
          {
            var instance2 = (ISetupInstance2)instances[0];
            return Path.Combine(instance2.GetInstallationPath(), "Common7");
          }
        }
        while (fetched > 0);
        return null;
      }
      var toolsLength = @"/Tools".Length;
      return vscomntoolsDir.Remove(vscomntoolsDir.Length - toolsLength, toolsLength);
    }

    // ReSharper disable once InconsistentNaming
    private const int REGDB_E_CLASSNOTREG = unchecked((int)0x80040154);

    [DllImport("Microsoft.VisualStudio.Setup.Configuration.Native.dll", ExactSpelling = true, PreserveSig = true)]
    private static extern int GetSetupConfiguration(
    [MarshalAs(UnmanagedType.Interface), Out] out ISetupConfiguration configuration,
    IntPtr reserved);

    private static ISetupConfiguration GetQuery()
    {
      try
      {
        // Try to CoCreate the class object.
        return new SetupConfiguration();
      }
      catch (COMException ex) when (ex.HResult == REGDB_E_CLASSNOTREG)
      {
        // Try to get the class object using app-local call.
        ISetupConfiguration query;
        var result = GetSetupConfiguration(out query, IntPtr.Zero);

        if (result < 0)
        {
          throw new COMException("Failed to get query", result);
        }

        return query;
      }
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
      return Path.Combine(GetVisualStudioInstallationCommonDir(version), @"Packages\Debugger\Visualizers");
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
      visualStudioUserDir = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), version.EnumToString().Replace("VS", "Visual Studio"));
      return Directory.Exists(visualStudioUserDir) ? visualStudioUserDir : null;
    }

    public static string GetVisualStudioDebuggerVisualizersUserDir(VisualStudioVersion version)
    {
      var visualStudioUserDir = GetVisualStudioUserDir(version);
      if (String.IsNullOrWhiteSpace(visualStudioUserDir))
        return "Visualizers Dir not found";
      var visualStudioDebuggerVisualizersUserDir = visualStudioUserDir + @"\Visualizers";
      if (!Directory.Exists(visualStudioDebuggerVisualizersUserDir))
        return String.Format("Visualizers Dir, <{0}>, not found", visualStudioDebuggerVisualizersUserDir);
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
      return ((int) version / 10).ToString("00.0", CultureInfo.InvariantCulture);
    }

    public static VisualStudioVersion GetVisualStudioVersion(int productMajorPart, object fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly)
    {
      var visualStudioVersion = VisualStudioHelper.GetVisualStudioVersion(productMajorPart);
      if (visualStudioVersion == VisualStudioVersion.Other)
        throw new Exception("Not supported version: " +
                            productMajorPart + " from " +
                            fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly);
      return visualStudioVersion;
    }

    public static VisualStudioVersion GetVisualStudioVersion(int versionNumber)
    {
      var enumType = typeof(VisualStudioVersion);
      if (Enum.IsDefined(enumType, versionNumber))
        return (VisualStudioVersion) versionNumber;
      versionNumber = versionNumber * 10;
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
          result = sourceVisualizerFileInfo.FullName + " does not exist";
      }
      else
        result = String.Format("{0} or {1} does not exist", debuggerVisualizersDir, debuggerVisualizerSourceDir);
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