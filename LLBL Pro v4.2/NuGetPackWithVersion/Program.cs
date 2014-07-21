using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using SlavaGu.ConsoleAppLauncher;

namespace NuGetPackWithVersion
{
  /// <summary>
  /// Given a nuspec manifest file path it creates a nuget package with the version coming from the FileVersion (not assembly version) 
  /// of the assembly with the highest version number in the files section of the .nuspec manifest.
  /// Uses nuget.exe.
  /// This might be better as a powershell script.
  /// http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=22095
  /// </summary>
  /// <remarks>Similarish tools but mainly around project files rather than already built DLLs
  /// https://nugetversioner.codeplex.com/
  /// https://newnugetpackage.codeplex.com/documentation
  /// https://github.com/BenPhegan/NuGet.Extensions
  /// 
  /// </remarks>
  internal class Program
  {
    // Define other methods and classes here
    private static string PackageWithVersion(string nuspecFile)
    {
      if (!File.Exists(nuspecFile))
        return nuspecFile + " not found";
      var nuspecDir = Path.GetDirectoryName(nuspecFile);
      var doc = XDocument.Load(nuspecFile);
      var fileVersion = GetFileVersion(doc, nuspecDir);
      return ConsoleApp.Run(GetNugetExePath(),
        string.Format("Pack \"{0}\" -version {1} -OutputDirectory \"{2}\"", nuspecFile, fileVersion, nuspecDir))
        .Output.Trim();
    }

    private static string GetFileVersion(XContainer doc, string nuspecDir)
    {
      var assemblyElements = from e in doc.DescendantNodes().OfType<XElement>()
        where e.Name.LocalName == "file"
        from a in e.Attributes()
        where a.Name.LocalName == "src" && IsAssembly(a.Value)
        let location = Path.Combine(nuspecDir, a.Value)
        select new {a.Value, FileVersionInfo.GetVersionInfo(location).FileVersion};
      return assemblyElements.Max(ae => ae.FileVersion);
    }

    private static bool IsAssembly(string fileName)
    {
      return fileName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase);
    }

    private static string GetNugetExePath()
    {
      const string nugetExeRelativePathInSolution = @"..\..\..\.nuGet\nuget.exe";
      if (File.Exists(nugetExeRelativePathInSolution))
        return nugetExeRelativePathInSolution;
      var nuGetExePath = Environment.GetEnvironmentVariable("NuGetExePath");
      if (string.IsNullOrWhiteSpace(nuGetExePath) || !File.Exists(nuGetExePath))
        return "nuget.exe"; //Hope nuget.exe is in the PATH or in the same directory
      return nuGetExePath;
    }

    private static void Main(string[] args)
    {
      foreach (var s in args)
        Console.Write(PackageWithVersion(s));
      Console.ReadLine();
    }
  }
}