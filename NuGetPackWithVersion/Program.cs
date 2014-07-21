using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using SlavaGu.ConsoleAppLauncher;

namespace NuGetPackWithVersion
{
  internal class Program
  {
    // Define other methods and classes here
    private static string PackageWithVersion(string nuspecFile)
    {
      var nuspecDir = Path.GetDirectoryName(nuspecFile);
      if (nuspecDir == null) return nuspecFile + " not found";
      var xmlDocument = new XmlDocument();
      xmlDocument.Load(nuspecFile);
     var v = GetVersion(xmlDocument);
     // var xmlNodeList = xmlDocument.SelectNodes("/package/files");
      ///package/files[1]/file[1]
    //  XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("package")[0].SelectNodes();
      var doc = XDocument.Load(nuspecFile);
      var assemblyElements = from e in doc.DescendantNodes().OfType<XElement>()
        where e.Name.LocalName == "file" 
        from a in e.Attributes()
               where a.Name.LocalName == "src" && IsAssembly(a.Value)
        select e;

      var sourceFiles = from file in doc.Descendants("file")
                        select file.Attribute("src").Value;
      var firstAssemblyName = ((XElement) ((XContainer) ((XContainer) doc.FirstNode).LastNode).FirstNode).Attribute("src").Value;
      var location = Path.Combine(nuspecDir, firstAssemblyName);
      var fileVersion = FileVersionInfo.GetVersionInfo(location).FileVersion;
      //var startInfo = new ProcessStartInfo();
      //startInfo.WorkingDirectory = nuspecDir;
      //startInfo.Arguments = "Pack "+@""""+nuspecFile+@""""+" -version "+ FileVersion;
      //startInfo.FileName = @"C:\Program Files (x86)\NuGet\nuget.exe";
      //startInfo.UseShellExecute = false;
      //                  startInfo.CreateNoWindow = true;
      //                    startInfo.RedirectStandardError = true;
      //                    startInfo.RedirectStandardOutput = true;
      //                    startInfo.RedirectStandardInput = true;

      //Process proc = Process.Start(startInfo);
      //..\..\..\.nuGet\nuget.exe //C:\Program Files (x86)\NuGet\nuget.exe
      return ConsoleApp.Run(GetNugetExePath(),
        string.Format("Pack \"{0}\" -version {1} -OutputDirectory \"{2}\"", nuspecFile, fileVersion, nuspecDir))
        .Output.Trim();
    }

    private static string GetVersion(XmlDocument doc)
    {
      XmlNodeList files = doc.GetElementsByTagName("file");
      foreach (XmlNode file in files)
      {
        if (file.Attributes.Count > 0)
        {
          XmlAttribute attribute = file.Attributes["src"];

          var value = attribute.Value;
          if (IsAssembly(value))
          {
           

   
          }
        }
      }

      return String.Empty;
    }

    private static bool IsAssembly(string value)
    {
      return value.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) || value.EndsWith(".exe", StringComparison.OrdinalIgnoreCase);
    }

    private static string GetNugetExePath()
    {
      const string nugetExeRelativePathInSolution = @"..\..\..\.nuGet\nuget.exe";
      if (File.Exists(nugetExeRelativePathInSolution))
        return nugetExeRelativePathInSolution;
      var nuGetExePath = Environment.GetEnvironmentVariable("NuGetExePath");
      if (string.IsNullOrWhiteSpace(nuGetExePath) || !File.Exists(nuGetExePath))
        return "";
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