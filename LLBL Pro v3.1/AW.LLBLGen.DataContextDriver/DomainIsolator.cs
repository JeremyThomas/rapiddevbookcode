using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace AW.LLBLGen.DataContextDriver
{
	/// <summary>
	/// 	From LinqPad
	/// </summary>
	internal class DomainIsolator : IDisposable
	{
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
			if (AppDomain.CurrentDomain.GetData("LINQPadPath") == null)
				return;
			var linqPadAssembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault(a => a.FullName.Contains("LINQPad"));
			if (linqPadAssembly != null) 
				_domain.SetData("LINQPadPath", linqPadAssembly.Location);
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
			catch (FileNotFoundException ex)
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

			private static readonly Dictionary<string, Assembly> _libs = new Dictionary<string, Assembly>();

			internal static void AddLINQPadAssemblyResolver()
			{
				if (_linqPadAssemblyResolverAdded)
					return;
				_linqPadAssemblyResolverAdded = true;
				AppDomain.CurrentDomain.AssemblyResolve += (ResolveEventHandler) ((sender, args) =>
				                                                                  	{
				                                                                  		if (args.Name.ToLowerInvariant().StartsWith("linqpad,"))
				                                                                  		{
				                                                                  			var local_0 = AppDomain.CurrentDomain.GetData("LINQPadPath") as string;
				                                                                  			if (!string.IsNullOrEmpty(local_0))
				                                                                  				return Assembly.LoadFrom(local_0);
				                                                                  		}
				                                                                  		if (args.Name == "Ionic.Zip.Reduced, Version=1.7.2.12, Culture=neutral, PublicKeyToken=791165b13cf84eca" || args.Name == "ActiproSoftware.SyntaxEditor.Net20, Version=4.0.277.0, Culture=neutral, PublicKeyToken=21a821480e210563" || (args.Name == "ActiproSoftware.WinUICore.Net20, Version=1.0.96.0, Culture=neutral, PublicKeyToken=1eba893a2bc55de5" || args.Name == "ActiproSoftware.Shared.Net20, Version=1.0.96.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9") || (args.Name == "ActiproSoftware.SyntaxEditor.Addons.DotNet.Net20, Version=4.0.277.0, Culture=neutral, PublicKeyToken=21a821480e210563" || args.Name == "DotNetLanguage, Version=4.9.0.0, Culture=neutral, PublicKeyToken=53cd1b2bfe1e886e") || args.Name == "System.Data.Services.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")
				                                                                  			return FindAssem(sender, args);
				                                                                  		else
				                                                                  			return (Assembly) null;
				                                                                  	});
			}

			internal static Assembly FindAssem(object sender, ResolveEventArgs args)
			{
				var str = args.Name.ToLowerInvariant();
				if (!str.Contains("actipro") && !str.Contains("dotnetlanguage") && (!str.Contains("mono.cecil") && !str.Contains("resources")) && (!str.Contains("icsharpcode") && !str.Contains("ionic.zip")) && !str.Contains("data.services.design"))
					return null;
				var key = new AssemblyName(args.Name).Name;
				if (key.EndsWith(".resources", StringComparison.OrdinalIgnoreCase))
					return null;
				if (key.Contains("sources"))
					key = key + "4";
				if (_libs.ContainsKey(key))
					return _libs[key];
				var manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LINQPad.assemblies." + key + ".bin");
				if (manifestResourceStream == null)
					return null;
				using (manifestResourceStream)
				{
					using (var deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						var assembly = Assembly.Load(new BinaryReader(deflateStream).ReadBytes(2000000));
						_libs[key] = assembly;
						return assembly;
					}
				}
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