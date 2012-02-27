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
		public const string LinqpadPath = "LINQPadPath";
		public const string ProbePaths = "ProbePaths";
		public const string LlblgenProNameSpace = "SD.LLBLGen.Pro";
		private const string LinqpadAssemblyName = "LINQPad";

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
			((AddAssemblyResolver) _domain.CreateInstanceFromAndUnwrap(typeof (AddAssemblyResolver).Assembly.Location, typeof (AddAssemblyResolver).FullName)).Go();
		}

		public DomainIsolator(AppDomain domain)
		{
			_domain = domain;
		}


		public T GetInstance<T>() where T : MarshalByRefObject
		{
			try
			{
				return (T) _domain.CreateInstanceFromAndUnwrap(typeof (T).Assembly.Location, typeof (T).FullName);
			}
			catch (FileNotFoundException)
			{
				return (T) _domain.CreateInstanceAndUnwrap(typeof (T).Assembly.FullName, typeof (T).FullName);
			}
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
				AppDomain.CurrentDomain.AssemblyResolve += (ResolveEventHandler) ((sender, args) =>
				                                                                  	{
				                                                                  		if (args.Name.ToLowerInvariant().StartsWith("linqpad,"))
				                                                                  		{
																																								var linqpadPath = AppDomain.CurrentDomain.GetData(LinqpadPath) as string;
				                                                                  			if (!String.IsNullOrEmpty(linqpadPath))
				                                                                  				return Assembly.LoadFrom(linqpadPath);
				                                                                  		}
				                                                                  		var assemblyName = new AssemblyName(args.Name);
				                                                                  		var shortAssemblyName = assemblyName.Name;
				                                                                  		var probePaths = AppDomain.CurrentDomain.GetData(ProbePaths) as List<string>;
				                                                                  		if (probePaths != null)
				                                                                  			return (from probePath in probePaths where (shortAssemblyName.IndexOf(LlblgenProNameSpace) < 0 
																																													|| assemblyName.Version.ToString().Contains(Constants.LLBLVersion)) 
																																												select Path.Combine(probePath, shortAssemblyName) + ".dll" 
																																												into path 
																																												where File.Exists(path) 
																																												select Assembly.LoadFrom(path)).FirstOrDefault();
				                                                                  		return null;
				                                                                  	});
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
				catch (AppDomainUnloadedException ex)
				{
					return;
				}
				catch (CannotUnloadAppDomainException ex)
				{
				}
			}
		}
	}
}