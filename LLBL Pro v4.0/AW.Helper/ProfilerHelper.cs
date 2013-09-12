using System;
using System.Configuration;
using System.Data.Common;
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
    /// <summary>
    /// SD.Tools.OrmProfiler.Interceptor.NET45
    /// </summary>
    public const string OrmProfilerAssemblyString45 = OrmProfilerAssemblyString + ".NET45";
    public const string OrmProfilerAssemblyFileName = OrmProfilerAssemblyString + ".dll";
    public const string OrmProfilerAssemblyFileName45 = OrmProfilerAssemblyString45 + ".dll";
    /// <summary>
    /// SD.Tools.OrmProfiler.Interceptor.InterceptorCore
    /// </summary>
    public const string OrmProfilerInterceptorTypeName = OrmProfilerAssemblyString + ".InterceptorCore";

    /// <summary>
    /// SD.Tools.OrmProfiler.Interceptor.InterceptorCore, SD.Tools.OrmProfiler.Interceptor.dll
    /// </summary>
    public const string OrmProfilerInterceptorAssemblyQualifiedTypeName = OrmProfilerInterceptorTypeName + ", " + OrmProfilerAssemblyString;
    /// <summary>
    /// SD.Tools.OrmProfiler.Interceptor.InterceptorCore, SD.Tools.OrmProfiler.Interceptor.NET45.dll
    /// </summary>
    public const string OrmProfilerInterceptorAssemblyQualifiedTypeName45 = OrmProfilerInterceptorTypeName + ", " + OrmProfilerAssemblyString45;
    /// <summary>
    /// Initialize
    /// </summary>
    public const string InitializeMethodName = "Initialize";
    /// <summary>
    /// ORMProfilerEnabled
    /// </summary>
    public const string OrmProfilerAppSettingsName = "ORMProfilerEnabled";
    /// <summary>
    /// Solutions Design\ORM Profiler v1.1
    /// </summary>
    public const string SolutionsDesignOrmProfilerPath = @"Solutions Design\ORM Profiler v1.1";
    /// <summary>
    /// Solutions Design\ORM Profiler v1.5
    /// </summary>
    public const string SolutionsDesignOrmProfilerPath15 = @"Solutions Design\ORM Profiler v1.5";

    /// <summary>
    /// 	Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
    /// </summary>
    /// <remarks>SD.Tools.OrmProfiler.Interceptor.dll, SD.Tools.OrmProfiler.Shared.dll SD.Tools.BCLExtensions.dll, SD.Tools.Algorithmia.dll need to be able to be loaded</remarks>
    /// <returns> true if Initialize took place </returns>
    public static bool InitializeOrmProfiler()
    {
      try
      {
        return InterceptorCoreInitialize(GetInterceptorType());
      }
      catch (Exception e)
      {
        GeneralHelper.TraceOut(e.Message);	
        return false;
      }
    }

    private static Type GetInterceptorType()
    {
      Type interceptorType = null;
      if (Environment.Version.Major == 4 && Environment.Version.Revision >= 18051) //.NET45 installed
        interceptorType = Type.GetType(OrmProfilerInterceptorAssemblyQualifiedTypeName45);
      return interceptorType ?? (Type.GetType(OrmProfilerInterceptorAssemblyQualifiedTypeName));
    }

    /// <summary>
    /// 	Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
    /// </summary>
    /// <param name="interceptorType"> The interceptorType type. </param>
    public static bool InterceptorCoreInitialize(Type interceptorType)
    {
      if (interceptorType == null)
        return false;
      var result = interceptorType.InvokeMember(InitializeMethodName,
                               BindingFlags.Public |
                               BindingFlags.InvokeMethod |
                               BindingFlags.Static,
                               null, null, new object[] {ApplicationName}, CultureInfo.CurrentUICulture);
      MetaDataHelper.AddSelfAssemblyResolverIfNeeded(interceptorType);
      if (result is bool)
        return (bool) result;
      return true;
    }

    /// <summary>
    /// 	Gets the name of the application(as used by the Profiler).
    /// </summary>
    /// <value> The name of the application. </value>
    public static string ApplicationName
    {
      get { return AppDomain.CurrentDomain.FriendlyName; }
    }

    public static DbCommand GetWrappedCommand(DbCommand dbCommand)
    {
      var fieldInfo = dbCommand.GetType().GetField("_wrappedCommand", BindingFlags.NonPublic | BindingFlags.Instance);
      if (fieldInfo != null) return fieldInfo.GetValue(dbCommand) as DbCommand;
      return dbCommand;
    }
  }
}