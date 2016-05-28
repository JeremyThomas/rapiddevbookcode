using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using AW.Helper;

namespace AW.LLBLGen.DataContextDriver
{
  /// <summary>
  ///   From LinqPad
  /// </summary>
  internal class DomainIsolator : IDisposable
  {
    /// <summary>
    ///   LINQPadPath
    /// </summary>
    private const string LinqpadPath = "LINQPadPath";

    private const string ProbePaths = "ProbePaths";

    /// <summary>
    ///   SD.LLBLGen.Pro
    /// </summary>
    public const string LlblgenProNameSpace = "SD.LLBLGen.Pro";

    /// <summary>
    ///   LINQPad
    /// </summary>
    private const string LinqpadAssemblyName = "LINQPad";

    /// <summary>
    ///   LINQPad
    /// </summary>
    private const string LinqpadCommonAssemblyName = LinqpadAssemblyName + ".Common";

    /// <summary>
    ///   linqpad,
    /// </summary>
    private static readonly string LinqpadAssemblyNameStart = LinqpadAssemblyName.ToLowerInvariant() + ",";

    /// <summary>
    ///   linqpad,
    /// </summary>
    private static readonly string LinqpadCommonAssemblyNameStart = LinqpadCommonAssemblyName.ToLowerInvariant() + ",";

    public AppDomain Domain { get; set; }

    public DomainIsolator(string friendlyName, Stream assemblyStream = null)
      : this(friendlyName, new AppDomainSetup
      {
        ApplicationBase = AppDomain.CurrentDomain.BaseDirectory
      }, assemblyStream)
    {
    }

    public DomainIsolator(string friendlyName, AppDomainSetup setup, Stream assemblyStream = null)
      : this(AppDomain.CreateDomain(friendlyName, null, setup, new PermissionSet(PermissionState.Unrestricted)))
    {
      var linqPadPath = AppDomain.CurrentDomain.GetData(LinqpadPath);
      if (linqPadPath == null)
      {
        var linqPadAssembly = AppDomain.CurrentDomain.GetAssemblies().GetAssembly(LinqpadAssemblyName);
        if (linqPadAssembly != null)
        {
          linqPadPath = linqPadAssembly.Location;
          AppDomain.CurrentDomain.SetData(LinqpadPath, linqPadPath);
        }
      }
      Domain.SetData(LinqpadPath, linqPadPath);
      Domain.SetData(ProbePaths, AppDomain.CurrentDomain.GetData(ProbePaths));
      var fullName = typeof(AddAssemblyResolver).FullName;
      if (fullName != null) ((AddAssemblyResolver) Domain.CreateInstanceFromAndUnwrap(typeof(AddAssemblyResolver).Assembly.Location, fullName)).Go();
      if (assemblyStream != null)
        using (assemblyStream)
        {
          var data = new byte[assemblyStream.Length];
          assemblyStream.Read(data, 0, data.Length);
          Assembly.Load(data);
        }
    }

    private DomainIsolator(AppDomain domain)
    {
      Domain = domain;
    }

    public void AddProbePaths(params string[] assemblies)
    {
      var probePaths = new List<string>();
      foreach (var directoryName in assemblies.Where(File.Exists).Select(Path.GetDirectoryName).Where(directoryName => !probePaths.Contains(directoryName)))
        probePaths.Add(directoryName);
      Domain.SetData(ProbePaths, probePaths);
    }

    public T GetInstance<T>() where T : MarshalByRefObject
    {
      var fullName = typeof(T).FullName;
      if (fullName != null)
        try
        {
          return (T) Domain.CreateInstanceFromAndUnwrap(typeof(T).Assembly.Location, fullName);
        }
        catch (FileNotFoundException)
        {
          return (T) Domain.CreateInstanceAndUnwrap(typeof(T).Assembly.FullName, fullName);
        }
      return null;
    }

    public void Dispose()
    {
      UnloadAppDomain(Domain, 3);
    }

    private class AddAssemblyResolver : MarshalByRefObject
    {
      private static bool _linqPadAssemblyResolverAdded;

      private static void AddLINQPadAssemblyResolver()
      {
        if (_linqPadAssemblyResolverAdded)
          return;
        _linqPadAssemblyResolverAdded = true;
        AppDomain.CurrentDomain.AssemblyResolve += ResolveEventHandler;
      }

      private static Assembly ResolveEventHandler(object sender, ResolveEventArgs args)
      {
        var name = args.Name.ToLowerInvariant();
        if (name.StartsWith(LinqpadAssemblyNameStart))
        {
          var linqpadPath = AppDomain.CurrentDomain.GetData(LinqpadPath) as string;
          if (!String.IsNullOrEmpty(linqpadPath))
            return Assembly.LoadFrom(linqpadPath);
        }
        if (name.StartsWith(LinqpadCommonAssemblyNameStart))
        {
          var assembly = MetaDataHelper.GetAssembly(name);
          if (assembly != null)
            return assembly;
          var linqPadAssembly = AppDomain.CurrentDomain.GetAssemblies().GetAssembly(LinqpadAssemblyName);

          var deflateAssembly = DeflateAssembly(linqPadAssembly, LinqpadCommonAssemblyName);
          if (deflateAssembly == null)
            return null;
          return Assembly.Load(deflateAssembly);
        }

        var assemblyName = new AssemblyName(args.Name);
        var probePaths = AppDomain.CurrentDomain.GetData(ProbePaths) as IEnumerable<string>;
        if (probePaths != null)
          return (from probePath in probePaths
            where IfLLBLVersionIsCorrect(assemblyName)
            select MetaDataHelper.GetAssemblyLocation(probePath, assemblyName.Name)
            into path
            where File.Exists(path)
            select Assembly.LoadFrom(path)).FirstOrDefault();
        return null;
      }

      private static bool IfLLBLVersionIsCorrect(AssemblyName assemblyName)
      {
        return assemblyName.Name.IndexOf(LlblgenProNameSpace, StringComparison.Ordinal) < 0
               || assemblyName.Version.ToString().Contains(Constants.LLBLVersion);
      }

      public void Go()
      {
        AddLINQPadAssemblyResolver();
      }
    }

    #region InternalAssemblyResolver

    internal static byte[] DeflateAssembly(Assembly assembly, string shortName)
    {
      return DecompressResource(assembly, "LINQPad.assemblies." + shortName + ".bin");
    }

    public static byte[] DecompressResource(Assembly assembly, string resourceName)
    {
      using (var memoryStream = new MemoryStream())
        return DecompressResource(assembly, resourceName, memoryStream) ? memoryStream.ToArray() : null;
    }

    public static bool DecompressResource(Assembly assembly, string resourceName, Stream outputStream)
    {
      var buffer = new byte[65536];
      if (assembly == null)
        return false;
      using (var manifestResourceStream = assembly.GetManifestResourceStream(resourceName))
      {
        if (manifestResourceStream == null)
          return false;
        using (var deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
        {
          while (true)
          {
            var count = deflateStream.Read(buffer, 0, buffer.Length);
            if (count != 0)
              outputStream.Write(buffer, 0, count);
            else
              break;
          }
          return true;
        }
      }
    }

    #endregion

    private static void UnloadAppDomain(AppDomain d, int attempts)
    {
      for (var index = 0; index < attempts; ++index)
      {
        if (index > 0)
          Thread.Sleep(100*index);
        try
        {
          AppDomain.Unload(d);
          return;
        }
        catch (AppDomainUnloadedException)
        {
          return;
        }
        catch (CannotUnloadAppDomainException)
        {
        }
      }
    }
  }
}