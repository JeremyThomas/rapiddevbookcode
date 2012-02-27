using System;
using System.Configuration;
using System.Globalization;
using System.Reflection;

namespace AW.Helper
{
	/// <summary>
	/// 	http://www.OrmProfiler.com
	/// </summary>
	public static class ProfilerHelper
	{
		/// <summary>
		/// SD.Tools.OrmProfiler.Interceptor
		/// </summary>
		public const string OrmProfilerAssemblyString = "SD.Tools.OrmProfiler.Interceptor";
		public const string OrmProfilerAssemblyFileName = OrmProfilerAssemblyString + ".dll";
		/// <summary>
		/// SD.Tools.OrmProfiler.Interceptor.InterceptorCore
		/// </summary>
		public const string OrmProfilerInterceptorTypeName = OrmProfilerAssemblyString + ".InterceptorCore";
		/// <summary>
		/// SD.Tools.OrmProfiler.Interceptor.InterceptorCore, SD.Tools.OrmProfiler.Interceptor.dll
		/// </summary>
		public const string OrmProfilerInterceptorAssemblyQualifiedTypeName = OrmProfilerInterceptorTypeName + ", " + OrmProfilerAssemblyString;
		/// <summary>
		/// Initialize
		/// </summary>
		public const string InitializeMethodName = "Initialize";
		/// <summary>
		/// ORMProfiler
		/// </summary>
		public const string OrmProfilerAppSettingsName = "ORMProfiler";
		/// <summary>
		/// Solutions Design\ORM Profiler v1.0
		/// </summary>
		public const string SolutionsDesignOrmProfilerPath = @"Solutions Design\ORM Profiler v1.0";

		/// <summary>
		/// 	Initializes the ORM profiler if enabled with the AppSetting ORM Profiler in the config file and the assemblies: 
		///   SD.Tools.OrmProfiler.Interceptor.dll, SD.Tools.OrmProfiler.Shared.dll SD.Tools.BCLExtensions.dll, SD.Tools.Algorithmia.dll can be loaded
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
				return InterceptorCoreInitialize(Type.GetType(OrmProfilerInterceptorAssemblyQualifiedTypeName));
			}
			catch (Exception e)
			{
				GeneralHelper.TraceOut(e.Message);	
				return false;
			}
		}

		/// <summary>
		/// 	Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
		/// </summary>
		/// <param name="interceptor"> The interceptor type. </param>
		public static bool InterceptorCoreInitialize(Type interceptor)
		{
			if (interceptor == null)
				return false;
			interceptor.InvokeMember(InitializeMethodName,
			                         BindingFlags.Public |
			                         BindingFlags.InvokeMethod |
			                         BindingFlags.Static,
			                         null, null, new[] {ApplicationName}, CultureInfo.CurrentUICulture);
			//MetaDataHelper.AddSelfAssemblyResolverIfNeeded(interceptor);
			return true;
		}

		/// <summary>
		/// 	Returns whether the ORM Profiler is enabled with the AppSetting OrmProfiler in the config file.
		/// </summary>
		/// <returns> </returns>
		public static bool OrmProfilerEnabled()
		{
			var ormProfilerAppSetting = ConfigurationManager.AppSettings[OrmProfilerAppSettingsName];
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