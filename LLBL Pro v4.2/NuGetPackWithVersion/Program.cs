using System;
using System.Diagnostics;
using System.IO;
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
     // xmlDocument.Load(nuspecFile);
   //   XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("package")[0].SelectNodes();
      var doc = XDocument.Load(nuspecFile);
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
      return ConsoleApp.Run(@"..\..\..\.nuGet\nuget.exe",
        string.Format("Pack \"{0}\" -version {1} -OutputDirectory \"{2}\"", nuspecFile, fileVersion, nuspecDir))
        .Output.Trim();
    }

    private static void Main(string[] args)
    {
      foreach (var s in args)
        Console.Write(PackageWithVersion(s));
      Console.ReadLine();
    }
  }
}