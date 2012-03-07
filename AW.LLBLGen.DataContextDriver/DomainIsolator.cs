using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;
using AW.Helper;

namespace AW.LLBLGen.DataContextDriver
{
	/// <summary>
	/// 	From LinqPad
	/// </summary>
	internal class DomainIsolator : IDisposable
	{
		/// <summary>
		/// LINQPadPath
		/// </summary>
		public const string LinqpadPath = "LINQPadPath";

		internal const string ProbePaths = "ProbePaths";

		/// <summary>
		/// SD.LLBLGen.Pro
		/// </summary>
		public const string LlblgenProNameSpace = "SD.LLBLGen.Pro";

		/// <summary>
		/// LINQPad
		/// </summary>
		private const string LinqpadAssemblyName = "LINQPad";

		/// <summary>
		/// linqpad,
		/// </summary>
		public static readonly string LinqpadAssemblyNameStart = LinqpadAssemblyName.ToLowerInvariant() + ",";

		private readonly AppDomain _domain;

		public AppDomain Domain
		{
			get { return _domain; }
		}

		public DomainIsolator(string friendlyName)
			: this(friendlyName, new AppDomainSetup
			                     	{
			                     		ApplicationBase = AppDomain.CurrentDomain.BaseDirectory
			                     	})
		{
		}

		public DomainIsolator(string friendlyName, AppDomainSetup setup)
			: this(AppDomain.CreateDomain(friendlyName, null, setup, new PermissionSet(PermissionState.Unrestricted), new StrongName[0]))
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
			_domain.SetData(LinqpadPath, linqPadPath);
			_domain.SetData(ProbePaths, AppDomain.CurrentDomain.GetData(ProbePaths));
			var fullName = typeof (AddAssemblyResolver).FullName;
			if (fullName != null) ((AddAssemblyResolver) _domain.CreateInstanceFromAndUnwrap(typeof (AddAssemblyResolver).Assembly.Location, fullName)).Go();
		}

		public DomainIsolator(AppDomain domain)
		{
			_domain = domain;
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
			var fullName = typeof (T).FullName;
			if (fullName != null)
			try
			{
				 return (T) _domain.CreateInstanceFromAndUnwrap(typeof (T).Assembly.Location, fullName);
			}
			catch (FileNotFoundException)
			{
				return (T) _domain.CreateInstanceAndUnwrap(typeof (T).Assembly.FullName, fullName);
			}
			return null;
		}

		public void Dispose()
		{
			UnloadAppDomain(_domain, 3);
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
				if (args.Name.ToLowerInvariant().StartsWith(LinqpadAssemblyNameStart))
				{
					var linqpadPath = AppDomain.CurrentDomain.GetData(LinqpadPath) as string;
					if (!String.IsNullOrEmpty(linqpadPath))
						return Assembly.LoadFrom(linqpadPath);
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
				return (assemblyName.Name.IndexOf(LlblgenProNameSpace, StringComparison.Ordinal) < 0
				        || assemblyName.Version.ToString().Contains(Constants.LLBLVersion));
			}

			public void Go()
			{
				AddLINQPadAssemblyResolver();
			}
		}

		internal static void UnloadAppDomain(AppDomain d, int attempts)
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