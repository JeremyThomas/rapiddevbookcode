﻿using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Win32;

namespace AW.Helper
{
  /// <summary>
  ///   http://www.OrmProfiler.com
  /// </summary>
  public static class ProfilerHelper
  {
    /// <summary>
    ///   SD.Tools.OrmProfiler.Interceptor
    /// </summary>
    public const string OrmProfilerAssemblyString = "SD.Tools.OrmProfiler.Interceptor";

    /// <summary>
    ///   SD.Tools.OrmProfiler.Interceptor.NET45
    /// </summary>
    public const string OrmProfilerAssemblyString45 = OrmProfilerAssemblyString + ".NET45";

    public const string OrmProfilerAssemblyFileName = OrmProfilerAssemblyString + ".dll";
    public const string OrmProfilerAssemblyFileName45 = OrmProfilerAssemblyString45 + ".dll";

    /// <summary>
    ///   SD.Tools.OrmProfiler.Interceptor.InterceptorCore
    /// </summary>
    public const string OrmProfilerInterceptorTypeName = OrmProfilerAssemblyString + ".InterceptorCore";

    /// <summary>
    ///   SD.Tools.OrmProfiler.Interceptor.InterceptorCore, SD.Tools.OrmProfiler.Interceptor.dll
    /// </summary>
    public const string OrmProfilerInterceptorAssemblyQualifiedTypeName = OrmProfilerInterceptorTypeName + ", " + OrmProfilerAssemblyString;

    /// <summary>
    ///   SD.Tools.OrmProfiler.Interceptor.InterceptorCore, SD.Tools.OrmProfiler.Interceptor.NET45.dll
    /// </summary>
    public const string OrmProfilerInterceptorAssemblyQualifiedTypeName45 = OrmProfilerInterceptorTypeName + ", " + OrmProfilerAssemblyString45;

    /// <summary>
    ///   Initialize
    /// </summary>
    public const string InitializeMethodName = "Initialize";

    /// <summary>
    ///   ORMProfilerEnabled
    /// </summary>
    public const string OrmProfilerAppSettingsName = "ORMProfilerEnabled";

    /// <summary>
    ///   Solutions Design\ORM Profiler v1.5
    /// </summary>
    public const string SolutionsDesignOrmProfilerPath = @"Solutions Design\ORM Profiler v1.5";

    static ProfilerHelper()
    {
      OrmProfilerStatus = "ORMProfiler has not been Initialized";
    }

    /// <summary>
    ///   Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
    /// </summary>
    /// <remarks>
    ///   SD.Tools.OrmProfiler.Interceptor.dll, SD.Tools.OrmProfiler.Shared.dll SD.Tools.BCLExtensions.dll,
    ///   SD.Tools.Algorithmia.dll need to be able to be loaded
    /// </remarks>
    /// <returns> true if Initialize took place </returns>
    public static bool InitializeOrmProfiler()
    {
      try
      {
        var interceptorType = GetInterceptorType();
        OrmProfilerStatus = null;
        var interceptorCoreInitialize = InterceptorCoreInitialize(interceptorType);
        if (!string.IsNullOrWhiteSpace(OrmProfilerStatus))
          return interceptorCoreInitialize;
        string interceptorTypeName = null;
        if (interceptorType != null)
          interceptorTypeName = interceptorType.Assembly.FullName.Substring(0, interceptorType.Assembly.FullName.LastIndexOf(','));
        OrmProfilerStatus = string.Format("OrmProfiler {0}, {1}", interceptorCoreInitialize ? "enabled" : "disabled", interceptorTypeName);
        return interceptorCoreInitialize;
      }
      catch (Exception e)
      {
        OrmProfilerStatus = "Error Initializing OrmProfiler " + e.Message;
        GeneralHelper.TraceOut(e);
        return false;
      }
    }

    public static bool DbProviderFactoryIsWrappedByOrmProfiler(DataRow providerRow)
    {
      return providerRow != null && providerRow[3].ToString().Contains(OrmProfilerAssemblyString);
    }

    public static bool DbProviderFactoryIsWrappedByOrmProfiler(string providerInvariantName)
    {
      var dbProviderFactoryIsWrappedByOrmProfiler = DbProviderFactories.GetFactoryClasses()
        .Rows.OfType<DataRow>().FirstOrDefault(f => f.ItemArray[0].Equals(providerInvariantName));
      return DbProviderFactoryIsWrappedByOrmProfiler(dbProviderFactoryIsWrappedByOrmProfiler);
    }

    /// <summary>
    ///   Tests wether the databases provider factory is wrapped by orm profiler.
    /// </summary>
    /// <param name="systemDataType">Type in the System.Data namespace associated with DbProviderFactory.</param>
    /// <returns></returns>
    public static bool DbProviderFactoryIsWrappedByOrmProfiler(Type systemDataType)
    {
      return systemDataType.Namespace.Equals(OrmProfilerAssemblyString);
    }

    private static Type GetInterceptorType()
    {
      Type interceptorType = null;
      if (Environment.Version.Major == 4 && Environment.Version.Revision >= 18051) //.NET45 installed
        interceptorType = Type.GetType(OrmProfilerInterceptorAssemblyQualifiedTypeName45);
      return interceptorType ?? (Type.GetType(OrmProfilerInterceptorAssemblyQualifiedTypeName));
    }

    /// <summary>
    ///   Initializes the ORM Profiler. Reflected version of InterceptorCore.Initialize(ApplicationName);
    /// </summary>
    /// <param name="interceptorType"> The interceptorType type. </param>
    public static bool InterceptorCoreInitialize(Type interceptorType)
    {
      if (interceptorType == null)
      {
        OrmProfilerStatus = "OrmProfiler Assemblies not Found";
        return false;
      }

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

    public static string OrmProfilerStatus { get; private set; }

    /// <summary>
    ///   Gets the name of the application(as used by the Profiler).
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

    /// <summary>
    /// Gets the orm profiler path.
    /// </summary>
    /// <remarks>From https://llblgenlinqpad.codeplex.com</remarks>
    /// <returns></returns>
    public static string GetOrmProfilerPath()
    {
      var opsnapshotRegistration = Registry.GetValue("HKEY_CLASSES_ROOT\\.opsnapshot", string.Empty, null);
      if (opsnapshotRegistration == null)
        return null;
      var realRegistryKey = opsnapshotRegistration as string;
      if (realRegistryKey == null)
        return null;
      var iconPath = Registry.GetValue(string.Format("HKEY_CLASSES_ROOT\\{0}\\DefaultIcon", realRegistryKey), string.Empty, null) as string;
      if (iconPath == null)
        return null;
      iconPath = iconPath.Substring(0, iconPath.Length - 2);
      var ormProfilerPath = Path.GetDirectoryName(iconPath);
      return Directory.Exists(ormProfilerPath) ? ormProfilerPath : null;
    }
  }
}