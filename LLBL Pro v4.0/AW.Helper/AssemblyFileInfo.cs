using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AW.Helper
{
  public class AssemblyFileInfo
  {
    public string Name { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public string Version { get; private set; }

    public string InformationalVersion { get; private set; }

    public AssemblyFileInfo(string name, string title, string description, string version, string informationalVersion)
    {
      Name = name;
      Title = title;
      Description = description;
      Version = version;
      InformationalVersion = informationalVersion;
    }

    public AssemblyFileInfo(FileVersionInfo fileVersionInfo)
      : this(fileVersionInfo.OriginalFilename, fileVersionInfo.FileDescription, fileVersionInfo.ProductName, fileVersionInfo.FileVersion, fileVersionInfo.ProductVersion)
    {
    }

    public AssemblyFileInfo(Assembly assembly) : this(assembly.GetName().Name, assembly.GetTitle(), assembly.GetDescription(), assembly.GetVersion(), assembly.GetInformationalVersionAttribute())
    {
    }

    #region Overrides of Object

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
      return GeneralHelper.JoinDistinct(", ", Name, Title, Description, InformationalVersion, Version);
    }

    #endregion

    public static IEnumerable<AssemblyFileInfo> AssemblyInfoFactory(IEnumerable<string> assemblyFileNames)
    {
      return assemblyFileNames == null ? Enumerable.Empty<AssemblyFileInfo>() : from a in assemblyFileNames select new AssemblyFileInfo(FileVersionInfo.GetVersionInfo(a));
    }

    public static IEnumerable<AssemblyFileInfo> AssemblyInfoFactory(string binPath)
    {
      return binPath == null ? Enumerable.Empty<AssemblyFileInfo>() : AssemblyInfoFactory(Directory.GetFiles(binPath, "*.dll"));
    }

    public static IEnumerable<AssemblyFileInfo> AssemblyInfoFactory(IEnumerable<Assembly> assemblies)
    {
      return assemblies == null ? Enumerable.Empty<AssemblyFileInfo>() : from a in assemblies select new AssemblyFileInfo(a);
    }

  }
}