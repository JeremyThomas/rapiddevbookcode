using System;
using System.Configuration;
using System.Globalization;
using System.Reflection;

namespace AW.Helper
{
	/// <summary>
	/// 	http://www.ormprofiler.com
	/// </summary>
	public static class ProfilerHelper
	{
		public const string OrmprofilerAssemblyString = "SD.Tools.OrmProfiler.Interceptor";
		public const string OrmprofilerInterceptorTypeName = OrmprofilerAssemblyString + ".InterceptorCore";
		public const string OrmprofilerInterceptorAssemblyQualifiedTypeName = OrmprofilerInterceptorTypeName + ", " + OrmprofilerAssemblyString;
		public const string InitializeMethodName = "Initialize";
		public const string OrmprofilerAppSettingsName = "ORMProfiler";

		/// <summary>
		/// 	Initializes the ORM profiler if enabled with the AppSetting ORMProfiler in the config file 
		///   and the assemblies: SD.Tools.OrmProfiler.Interceptor.dll, SD.Tools.OrmProfiler.Shared.dll SD.Tools.BCLExtensions.dll, SD.Tools.Algorithmia.dll can be loaded
		/// </summary>
		/// <returns> </returns>
		public static bool InitializeOrmProfilerIfEnabled()
		{
			return OrmProfilerEnabled() && InitializeOrmProfiler();
		}

		/// <summary>
		/// 	Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
		/// </summary>
		/// <returns> true if Initialize took place </returns>
		public static bool InitializeOrmProfiler()
		{
			try
			{
				var interceptor = Type.GetType(OrmprofilerInterceptorAssemblyQualifiedTypeName);
				if (interceptor != null)
				{
					interceptor.InvokeMember(InitializeMethodName,
					                         BindingFlags.Public |
					                         BindingFlags.InvokeMethod |
					                         BindingFlags.Static,
					                         null, null, new[] {ApplicationName}, CultureInfo.CurrentUICulture);
					return true;
				}
			}
			catch (Exception e)
			{
				GeneralHelper.TraceOut(e.Message);
			}
			return false;
		}

		/// <summary>
		/// 	Returns whether the ORM profiler is enabled with the AppSetting ORMProfiler in the config file.
		/// </summary>
		/// <returns> </returns>
		public static bool OrmProfilerEnabled()
		{
			var ormProfilerAppSetting = ConfigurationManager.AppSettings[OrmprofilerAppSettingsName];
			Boolean ormProfilerEnabled;
			Boolean.TryParse(ormProfilerAppSetting, out ormProfilerEnabled);
			return ormProfilerEnabled;
		}

		/// <summary>
		/// 	Gets the name of the application(as used by the Profiler).
		/// </summary>
		/// <value> The name of the application. </value>
		public static string ApplicationName
		{
			get { return AppDomain.CurrentDomain.FriendlyName; }
		}
	}
}