using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Humanizer;

namespace AW.Helper
{
  public static class GeneralHelper
  {
    static GeneralHelper()
    {
      if (!Trace.Listeners.Cast<TraceListener>().Any(tl => tl.Name.Equals("Default")))
        Trace.Listeners.Add(new DefaultTraceListener());
    }

    public const string StringJoinSeparator = ", ";

    #region Debuging

    /// <summary>
    ///   Sends a msg to the Win32 debug output and prefixs it with the name off the method that called TraceOut
    /// </summary>
    /// <param name="msg"> The message. </param>
    public static void TraceOut(string msg)
    {
      //Debugger.Log(0, "Trace", msg);
      Trace.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    public static void DebugOut(string msg)
    {
      Debug.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    /// <summary>
    ///   Traces out the exception and the InnerMostException.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns>InnerMostException</returns>
    public static Exception TraceOut(this Exception exception)
    {
      foreach (var exceptionInStack in GetExceptionAndInners(exception))
        Trace.WriteLine(exceptionInStack.Message);
      return exception.GetBaseException();
    }

    #endregion

    public static void ApplicationOutputLogLine(string lineToLog, string source, bool isVerboseMessage, bool appendNewLine)
    {
      if (appendNewLine)
        Trace.WriteLine(lineToLog);
      else
        Trace.Write(lineToLog);
    }

    /// <summary>
    ///   Converts the string to the enum - generic.
    /// </summary>
    /// <typeparam name="T">Enum or nullable enum </typeparam>
    /// <param name="strOfEnum"> The string version of the enum. </param>
    /// <returns> </returns>
    public static T ToEnum<T>(this string strOfEnum)
    {
      return String.IsNullOrEmpty(strOfEnum) ? default(T) : (T) StringToEnum(strOfEnum, (typeof (T)));
    }

    /// <summary>
    ///   Converts the string to the enum, using Humanize if needed.
    /// </summary>
    /// <param name="strOfEnum">The string of enum.</param>
    /// <param name="enumType">Type of the enum or nullable enum.</param>
    /// <param name="throwException">if set to <c>true</c> throw exception if cannot be converted.</param>
    /// <returns></returns>
    public static object StringToEnum(string strOfEnum, Type enumType, bool throwException = true)
    {
      var coreType = MetaDataHelper.GetCoreType(enumType);
      if (Enum.IsDefined(coreType, strOfEnum))
        return Enum.Parse(coreType, strOfEnum, true);
      Enum value = null;
      try
      {
        value = strOfEnum.DehumanizeTo(coreType, OnNoMatch.ReturnsNull);
      }
      catch (FileNotFoundException e)
      {
        TraceOut(e);
      }
      return value ?? (coreType == enumType && throwException ? Enum.Parse(coreType, strOfEnum, true) : null);
      //Throw exception if null and type is not nullable and throwException flag is true
    }

    /// <summary>
    ///   Enums as an enumerable.
    /// </summary>
    /// <typeparam name="TEnum"> The type of the enum. </typeparam>
    /// <see cref="http://weblogs.asp.net/alnurismail/archive/2008/10/06/c-iterating-through-an-enum.aspx" />
    /// <returns> Enums as enumerable </returns>
    public static TEnum[] EnumAsEnumerable<TEnum>(params TEnum[] enumsToExclude)
    {
      var type = typeof(TEnum);
      var enumType = MetaDataHelper.GetCoreType(type);
      var nothingToExclude = enumsToExclude.IsNullOrEmpty();
      if (enumType == typeof(Enum))
      {
        if (!nothingToExclude)
          enumType = MetaDataHelper.GetCoreType(enumsToExclude[0].GetType());
        CheckIsEnum(enumType);
      }
      if (!(enumType.IsEnum))
        throw new ArgumentException(String.Format("typeof({0}).IsEnum == false", enumType), "TEnum");

      TEnum[] enumAsEnumerable;
      var values = Enum.GetValues(enumType);
      if (enumType == type)
        enumAsEnumerable = (TEnum[])values;
      else
      {
        enumAsEnumerable = (values.Cast<TEnum>()).ToArray();
        //enumAsEnumerable = ConvertArray<TEnum>(values);
      }
      return nothingToExclude ? enumAsEnumerable : enumAsEnumerable.Except(enumsToExclude).ToArray();
    }

    public static void CheckIsEnum(Type enumType)
    {
      if (enumType == typeof (Enum))
        throw new ArgumentException("typeof(TEnum) == System.Enum", "enumType");
      if (!(enumType.IsEnum))
        throw new ArgumentException(String.Format("typeof({0}).IsEnum == false", enumType), "enumType");
    }

#pragma warning disable 1584,1711,1572,1581,1580
    /// <summary>
    ///   Turns an enum member into a human readable string using humanizer; e.g. AnonymousUser -&gt; Anonymous user.
    ///   It also honors DescriptionAttribute data annotation
    /// </summary>
    /// <param name="value">The enum member to be humanized</param>
    /// <returns>
    ///   The string version of an enum with spaces in it as required.
    /// </returns>
    /// <remarks>
    ///   Because humanizer is a PCL assembly it can have trouble loading at times, in which case there is a full back
    ///   code to do a simpler version.
    ///   One example is using LINQPad with shadow assemblies on, the workaround is to have humanizer in the LINQPad Plugins
    ///   directory
    /// </remarks>
    /// <see cref="https://github.com/AutoMapper/AutoMapper/issues/383" />
    /// <see
    ///   cref="https://connect.microsoft.com/VisualStudio/feedback/details/779370/vs2012-incorrectly-resolves-mscorlib-version-when-referencing-pcl-assembly" />
    /// <see cref="http://stackoverflow.com/questions/13871267/unable-to-resolve-assemblies-that-use-portable-class-libraries" />
    /// <see
    ///   cref="http://stackoverflow.com/questions/18277499/could-not-load-file-or-assembly-system-core-version-2-0-5-0-exception-wh?lq=1" />
    /// <see cref="https://github.com/Fody/Costura/issues/30" />
#pragma warning restore 1584,1711,1572,1581,1580
    public static string EnumToString(this Enum value)
    {
      if (value == null) return null;
      try
      {
        return value.Humanize();
      }
      catch (FileNotFoundException e)
      {
        TraceOut(e);
        var description = GetDescription(value);
        return String.IsNullOrEmpty(description) ? value.ToString() : description;
      }
    }

    /// <summary>
    ///   Retrieves an list of the values of the constants in a specified enumeration plus and additional constant not in the
    ///   enum
    ///   for use in nulling out an enum.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    /// <returns></returns>
    public static IList EnumsGetAsNullableValues(Type enumType)
    {
      CheckIsEnum(enumType);
      var enumAsEnumerable = Enum.GetValues(enumType);
      var nullableType = MetaDataHelper.CreateNullableType(enumType);
      var list = MetaDataHelper.CreateList(nullableType);
      var nulledEnum = Enum.ToObject(enumType, enumAsEnumerable.Length + 1);
      list.Add(nulledEnum);
      foreach (var item in enumAsEnumerable)
        list.Add(item);
      return list;
    }

    /// <summary>
    ///   Retrieves an list of the values of the constants in a specified enumeration plus and additional constant not in the
    ///   enum
    ///   for use in nulling out an enum from a combobox.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    /// <returns></returns>
    public static IList EnumsGetValuesPlusUndefined(Type enumType)
    {
      CheckIsEnum(enumType);
      var enumAsEnumerable = Enum.GetValues(enumType);
      var list = MetaDataHelper.CreateList(enumType, enumAsEnumerable);
      var nulledEnum = GetLargestUndefinedEnumValue(enumType);
      list.Insert(0, nulledEnum);
      return list;
    }

    /// <summary>
    ///   Gets the largest undefined enum value.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    /// <returns></returns>
    private static object GetLargestUndefinedEnumValue(Type enumType)
    {
      dynamic maxValue = GetMaxValue(Enum.GetUnderlyingType(enumType));
      while (Enum.IsDefined(enumType, maxValue))
      {
        if (maxValue == 0)
          return 0; //Should never happen
        maxValue = maxValue - 1;
      }
      var undefinedEnum = Enum.ToObject(enumType, maxValue);
      return undefinedEnum;
    }

    public static IConvertible GetMaxValue(Type primitiveType)
    {
      IConvertible maxValue;
      var typeCode = Type.GetTypeCode(primitiveType);
      switch (typeCode)
      {
        case TypeCode.Byte:
          maxValue = byte.MaxValue;
          break;
        case TypeCode.Char:
          maxValue = char.MaxValue;
          break;
        case TypeCode.DateTime:
          maxValue = DateTime.MaxValue;
          break;
        case TypeCode.Decimal:
          maxValue = decimal.MaxValue;
          break;
        case TypeCode.Double:
          maxValue = decimal.MaxValue;
          break;
        case TypeCode.Int16:
          maxValue = short.MaxValue;
          break;
        case TypeCode.Int32:
          maxValue = int.MaxValue;
          break;
        case TypeCode.Int64:
          maxValue = long.MaxValue;
          break;
        case TypeCode.SByte:
          maxValue = sbyte.MaxValue;
          break;
        case TypeCode.Single:
          maxValue = float.MaxValue;
          break;
        case TypeCode.UInt16:
          maxValue = ushort.MaxValue;
          break;
        case TypeCode.UInt32:
          maxValue = uint.MaxValue;
          break;
        case TypeCode.UInt64:
          maxValue = ulong.MaxValue;
          break;
        default:
          maxValue = 0;
          break;
      }

      return maxValue;
    }

    /// <summary>
    ///   Gets the description of an object if it has one else returns null.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    public static string GetDescription(object value)
    {
      if (value == null) return null;
      var fi = value.GetType().GetField(value.ToString());
      if (fi == null) return null;
      var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);
      return (attributes.Length > 0) ? attributes[0].Description : null;
    }

    public static string JoinAsString<T>(this IEnumerable<T> input)
    {
      return JoinAsString(input, StringJoinSeparator);
    }

    public static string JoinAsString<T>(this IEnumerable<T> input, string separator)
    {
      var ar = input.Select(i => Convert.ToString(i)).ToArray();
      return Join(separator, ar);
    }

    /// <summary>
    ///   Joins an array of non empty strings together as one string with a separator between each non empty original string.
    /// </summary>
    /// <param name="separator"> The separator. </param>
    /// <param name="values"> The values. </param>
    /// <returns> </returns>
    public static string Join(String separator, params String[] values)
    {
      return String.Join(separator, values.Where(s => !String.IsNullOrEmpty(s)).ToArray());
    }

    public static string JoinDistinct(String separator, params String[] values)
    {
      return Join(separator, values.Distinct().ToArray());
    }

    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="pageIndex"> Index of the page. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int pageIndex, int pageSize)
    {
      return enumerable.Skip(pageIndex*pageSize).Take(pageSize);
    }

    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="queryable"> The query able. </param>
    /// <param name="pageIndex"> Index of the page. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IQueryable<T> SkipTake<T>(this IQueryable<T> queryable, int pageIndex, int pageSize)
    {
      return queryable.Skip(pageIndex*pageSize).Take(pageSize);
    }

    public static int GetPageCount(int pageSize, int totalItemCount)
    {
      if (totalItemCount > 0)
        return (int) Math.Ceiling(totalItemCount/(double) pageSize);
      return 0;
    }

    public static void AddWithErrorInfo<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
    {
      try
      {
        dict.Add(key, value);
      }
      catch (ArgumentException e)
      {
        throw new ArgumentException(e.Message + " Key is : " + key, e);
      }
    }

    public static DataTable CopyToDataTable(this IEnumerable source)
    {
      return CopyToDataTable(source, MetaDataHelper.GetPropertiesToSerialize);
    }

    public static DataTable CopyToDataTable(IEnumerable source, PropertyDescriptorGenerator propertyDescriptorGenerator)
    {
      var dataView = source as DataView;
      if (dataView != null && dataView.Table != null)
        return dataView.Table;
      return new ObjectShredder(propertyDescriptorGenerator).Shred(source, null, null);
    }

    public static DataTable StripTypeColumns(this DataTable source)
    {
      var dataColumnsToRemove = source.Columns.OfType<DataColumn>().Where(dc => !dc.DataType.IsSerializable || dc.DataType == typeof (Type)).ToList();
      foreach (var dataColumn in dataColumnsToRemove)
        source.Columns.Remove(dataColumn);
      return source;
    }

    public static DataTable StripNonSerializables(this DataTable source)
    {
      foreach (var dataColumn in source.Columns.OfType<DataColumn>().Where(dc => dc.DataType == typeof (object)))
      {
        var column = dataColumn;
        foreach (var row in source.Rows.OfType<DataRow>().Where(row => row[column] != null && !row[column].GetType().IsSerializable))
          row[dataColumn] = null;
      }
      return source;
    }

    /// <summary>
    ///   Copies enumerable to a data table.
    /// </summary>
    /// <see cref="http://msdn.microsoft.com/en-us/library/bb669096.aspx" />
    /// <typeparam name="T"> </typeparam>
    /// <param name="source"> The source. </param>
    /// <returns> </returns>
    public static DataTable CopyToDataTable<T>(this IEnumerable<T> source)
    {
      return CopyToDataTable(source, null, null);
    }

    public static DataTable CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption? options)
    {
      return new ObjectShredder(MetaDataHelper.GetPropertiesToSerialize).Shred(source, table, options);
    }

    /// <summary>
    ///   Convert a List{T} to a DataTable.
    /// </summary>
    public static DataTable ToDataTable<T>(List<T> items)
    {
      var tb = new DataTable(typeof (T).Name);
      var props = typeof (T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

      foreach (var prop in props)
      {
        var t = MetaDataHelper.GetCoreType(prop.PropertyType);
        tb.Columns.Add(prop.Name, t);
      }

      foreach (var item in items)
      {
        var values = new object[props.Length];
        for (var i = 0; i < props.Length; i++)
        {
          values[i] = props[i].GetValue(item, null);
        }
        tb.Rows.Add(values);
      }
      return tb;
    }

    /// <summary>
    ///   returns null if empty.
    /// </summary>
    /// <see cref="http://haacked.com/archive/2010/06/16/null-or-empty-coalescing.aspx" />
    /// <param name="items"> The items. </param>
    /// <returns> </returns>
    public static IEnumerable<T> AsNullIfEmpty<T>(this IEnumerable<T> items)
    {
      return items == null || !items.Any() ? null : items;
    }

    /// <summary>
    ///   Determines whether the specified IEnumerable is null or empty.
    /// </summary>
    /// <see cref="http://haacked.com/archive/2010/06/10/checking-for-empty-enumerations.aspx" />
    /// <typeparam name="T"> </typeparam>
    /// <param name="items"> The items. </param>
    /// <returns> <c>true</c> if specified IEnumerable is null or empty; otherwise, <c>false</c> . </returns>
    public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
    {
      return items is ICollection ? ((ICollection) items).Count == 0 : items.AsNullIfEmpty() == null;
    }

    public static bool IsNullOrEmpty(ICollection collection)
    {
      return collection == null || collection.Count == 0;
    }

    /// <summary>
    ///   Determines whether the specified enumerable has any items.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <returns> </returns>
    public static bool Any(IEnumerable enumerable)
    {
      return Any(enumerable, false);
    }

    public static bool Any(ICollection collection)
    {
      return !IsNullOrEmpty(collection);
    }

    /// <summary>
    ///   Determines whether the specified enumerable has any items.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="reset"> if set to <c>true</c> reset the enumerator if there are any items found. </param>
    /// <returns> </returns>
    public static bool Any(IEnumerable enumerable, bool reset)
    {
      var collection = enumerable as ICollection;
      if (collection != null)
        return Any(collection);
      var enumerator = enumerable.GetEnumerator();
      var any = enumerator.MoveNext();
      if (any && reset)
        try
        {
          enumerator.Reset();
        }
        catch (NotSupportedException)
        {
        }
      return any;
    }

    public static IEnumerable<ValueTypeWrapper<string>> CreateStringWrapperForBinding(this StringCollection strings)
    {
      return CreateStringWrapperForBinding(strings.AsEnumerable());
    }

    public static IEnumerable<ValueTypeWrapper<string>> CreateStringWrapperForBinding(this IEnumerable<string> strings)
    {
      return ValueTypeWrapper<string>.CreateWrapperForBinding(strings);
    }

    public static IEnumerable<string> AsEnumerable(this StringCollection strings)
    {
      return strings == null ? null : strings.Cast<string>();
    }

    public static IEnumerable<T> UnWrap<T>(this IEnumerable<ValueTypeWrapper<T>> values)
    {
      return ValueTypeWrapper<T>.UnWrap(values);
    }

    /// <summary>
    ///   Adds an item to the specified array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array">The array.</param>
    /// <param name="item">The item.</param>
    /// <returns>The array with the item added</returns>
    public static T[] Add<T>(this T[] array, T item)
    {
      var list = array.ToList();
      list.Add(item);
      return list.ToArray();
    }

    public static Array Add(Array array, object item)
    {
      var list = MetaDataHelper.ConvertToList(array);
      if (list.IsFixedSize)
        list = MetaDataHelper.CreateList(MetaDataHelper.GetEnumerableItemType(array), array);
      list.Add(item);
      return MetaDataHelper.ConvertToArray(list);
    }

    /// <summary>
    /// Adds the range specified to an ICollection(Of T) typed container.
    /// 
    /// </summary>
    /// <typeparam name="T">type of the element in the Collection</typeparam><param name="container">The container.</param><param name="rangeToAdd">The range to add.</param>
    public static void AddRange<T>(this ICollection<T> container, IEnumerable<T> rangeToAdd)
    {
      if (container == null || rangeToAdd == null)
        return;
      foreach (var obj in rangeToAdd)
        container.Add(obj);
    }
    
    /// <summary>
    ///   Adds the range of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="range">The range.</param>
    /// <returns></returns>
    public static ICollection<T> AddRange<T>(this ICollection<T> list, params T[] range)
    {
      if (range != null)
        list.AddRange((IEnumerable<T>)range);
      return list;
    }

    /// <summary>
    ///   does an Add distinct by checking if the list contains the item first before adding each item in the range.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="range">The range.</param>
    /// <param name="comparer">The comparer.</param>
    /// <returns></returns>
    public static ICollection<T> AddRangeDistinct<T>(this ICollection<T> list, IEnumerable<T> range, IEqualityComparer<T> comparer)
    {
      foreach (var item in range)
        list.AddDistinct(item, comparer);
      return list;
    }

    /// <summary>
    ///   Adds the range of items to the Collection if they are not already present.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="range">The range.</param>
    /// <returns></returns>
    public static ICollection<T> AddRangeDistinct<T>(this ICollection<T> list, params T[] range)
    {
      if (range != null)
        list.AddRangeDistinct((IEnumerable<T>)range);
      return list;
    }

    /// <summary>
    ///   does an Add distinct by checking if the list contains the item first before adding each item in the range.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public static ICollection<T> AddRangeDistinct<T>(this ICollection<T> list, IEnumerable<T> range)
    {
      foreach (var item in range)
        list.AddDistinct(item);
      return list;
    }

    /// <summary>
    ///   Does a contains check before adding.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="item">The item.</param>
    /// <param name="comparer">The comparer.</param>
    /// <returns></returns>
    public static ICollection<T> AddDistinct<T>(this ICollection<T> list, T item, IEqualityComparer<T> comparer)
    {
      if (!list.Contains(item, comparer))
        list.Add(item);
      return list;
    }

    /// <summary>
    ///   Does a contains check before adding.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public static ICollection<T> AddDistinct<T>(this ICollection<T> list, T item)
    {
      if (!list.Contains(item))
        list.Add(item);
      return list;
    }

    public static IList AddDistinct(this IList list, object item)
    {
      if (!list.Contains(item))
        list.Add(item);
      return list;
    }

    #region Settings

    public static IEnumerable<string> GetStringCollection(SettingValueElement element)
    {
      if (element != null)
      {
        var xml = element.ValueXml.InnerXml;
        var xs = new XmlSerializer(typeof (StringCollection));
        return ((StringCollection) xs.Deserialize(new XmlTextReader(xml, XmlNodeType.Element, null))).AsEnumerable();
      }
      return null;
    }

    public static IEnumerable<string> GetStringCollection(string oldPathValue, string newPathValue, string settingName)
    {
      return GetStringCollection(GetUserSetting(oldPathValue, newPathValue, settingName));
    }

    public static Configuration GetExeConfiguration()
    {
      return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
    }

    public static Configuration GetExeConfiguration(string fileName)
    {
      return File.Exists(fileName) ? ConfigurationManager.OpenExeConfiguration(fileName) : null;
    }

    public static Configuration OpenMappedMachineConfiguration(string fileName)
    {
      if (File.Exists(fileName))
      {
        var fileMap = new ConfigurationFileMap(fileName);
        var configuration = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
        return configuration;
      }
      return null;
    }

    public static Configuration OpenMappedExeConfiguration(string fileName)
    {
      if (File.Exists(fileName))
      {
        var fileMap = new ExeConfigurationFileMap
        {
          LocalUserConfigFilename = fileName,
          ExeConfigFilename = fileName,
          MachineConfigFilename = fileName,
          RoamingUserConfigFilename = fileName
        };
        var configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        return configuration;
      }
      return null;
    }

    public static SettingValueElement GetUserSetting(string oldPathValue, string newPathValue, string settingName)
    {
      var configuration = GetExeConfiguration();
      if (configuration.HasFile)
        return GetUserSetting(configuration, settingName);
      return GetUserSettingCopyIfNeed(configuration.FilePath, configuration.FilePath.Replace(oldPathValue, newPathValue), settingName);
    }

    public static SettingValueElement GetUserSettingCopyIfNeed(string oldFilePath, string newFilePath, string settingName)
    {
      var configuration = OpenMappedMachineConfiguration(newFilePath);
      if (configuration == null)
      {
        TraceOut(newFilePath);
        return null;
      }
      var userSettingsGroup = configuration.SectionGroups[@"userSettings"];
      if (userSettingsGroup == null)
      {
        File.Copy(newFilePath, oldFilePath);
        return null; //But will work next time
      }
      return GetSetting(userSettingsGroup, settingName);
    }

    public static SettingValueElement GetUserSetting(string fileName, string settingName)
    {
      var configuration = OpenMappedMachineConfiguration(fileName);
      if (configuration == null)
      {
        TraceOut(fileName);
        return null;
      }
      return GetUserSetting(configuration, settingName);
    }

    private static SettingValueElement GetUserSetting(Configuration configuration, string settingName)
    {
      var configurationSectionGroup = configuration.SectionGroups[@"userSettings"];
      return GetSetting(configurationSectionGroup, settingName);
    }

    private static SettingValueElement GetSetting(ConfigurationSectionGroup configurationSectionGroup, string settingName)
    {
      var settingElement = GetSettingElement(configurationSectionGroup, settingName);
      return settingElement == null ? null : settingElement.Value;
    }

    private static SettingElement GetSettingElement(ConfigurationSectionGroup @group, string settingName)
    {
      if (@group == null)
        return null;
      // find client section
      var clientSection = @group.Sections[0] as ClientSettingsSection;
      return clientSection == null ? null : clientSection.Settings.Get(settingName);
    }

    public static bool HasSetting(ApplicationSettingsBase applicationSettingsBase, string settingName)
    {
      return HasSettingsAndName(applicationSettingsBase, settingName)
             && (applicationSettingsBase.Properties.OfType<SettingsProperty>().Any(sp => sp.Name == settingName)
                 || applicationSettingsBase.PropertyValues.OfType<SettingsPropertyValue>().Any(pv => pv.Name == settingName));
    }

    private static bool HasSettingsAndName(ApplicationSettingsBase applicationSettingsBase, string settingName)
    {
      return !String.IsNullOrEmpty(settingName) && applicationSettingsBase != null;
    }

    public static SettingsPropertyValue GetSetting(ApplicationSettingsBase applicationSettingsBase, string settingName)
    {
      if (HasSetting(applicationSettingsBase, settingName))
      {
        var settingsPropertyValue = applicationSettingsBase.PropertyValues[settingName];
        if (settingsPropertyValue == null)
        {
          applicationSettingsBase[settingName] = applicationSettingsBase[settingName]; //To force load
          settingsPropertyValue = applicationSettingsBase.PropertyValues[settingName];
        }
        return settingsPropertyValue;
      }
      return null;
    }

    public static SettingsPropertyValue GetSetting(ApplicationSettingsBase applicationSettingsBase, string settingName, Type settingType)
    {
      var settingsPropertyValue = GetSetting(applicationSettingsBase, settingName);
      if (settingsPropertyValue == null && HasSettingsAndName(applicationSettingsBase, settingName))
      {
        AddSettingsProperty(applicationSettingsBase, settingName, settingType);
        settingsPropertyValue = GetSetting(applicationSettingsBase, settingName);
      }
      return settingsPropertyValue;
    }

    public static void AddSettingsProperty(ApplicationSettingsBase applicationSettingsBase, string settingName, Type settingType)
    {
      var settingsProperty = new SettingsProperty(settingName)
      {
        PropertyType = settingType,
        Provider = applicationSettingsBase.Providers.Cast<SettingsProvider>().FirstOrDefault(),
        SerializeAs = SettingsSerializeAs.Xml
      };
      settingsProperty.Attributes.Add(typeof (UserScopedSettingAttribute), new UserScopedSettingAttribute());
      applicationSettingsBase.Properties.Add(settingsProperty);
    }

    #endregion

    public static void ThrowInnerException(Exception exception)
    {
      if (exception.InnerException != null)
        ThrowInnerException(exception.InnerException);
      throw exception;
    }

    /// <summary>
    ///   Gets the exception followed by all the inner exceptions.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns></returns>
    public static IEnumerable<Exception> GetExceptionAndInners(Exception exception)
    {
      //Need to create overload where child is not Enumerable LinqToObjectsExtensionMethods.DescendantsAndSelf(exception, e => e.InnerException);
      while (exception != null)
      {
        yield return exception;
        exception = exception.InnerException;
      }
    }

    /// <summary>
    ///   Clones the object graph.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="graph">The graph.</param>
    /// <returns></returns>
    public static T CloneObject<T>(T graph)
    {
      var ms = new MemoryStream();
      var bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
      bf.Serialize(ms, graph);
      ms.Seek(0, SeekOrigin.Begin);
      var oOut = bf.Deserialize(ms);
      ms.Close();
      return (T) oOut;
    }

    /// <summary>
    ///   Gets the OS architecture.
    ///   if .net 4 could use Environment.Is64BitOperatingSystem
    ///   http://stackoverflow.com/questions/336633/how-to-detect-windows-64-bit-platform-with-net
    /// </summary>
    /// <returns> 32 or 64 </returns>
    internal static int GetOSArchitecture()
    {
      var pa = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
      return ((String.IsNullOrEmpty(pa) || String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? 32 : 64);
    }

    /// <summary>
    ///   Gets a value indicating whether [is64 bit operating system].
    ///   if .net 4 could use Environment.Is64BitOperatingSystem
    ///   http://stackoverflow.com/questions/336633/how-to-detect-windows-64-bit-platform-with-net
    /// </summary>
    /// <value> <c>true</c> if [is64 bit operating system]; otherwise, <c>false</c> . </value>
    public static bool Is64BitOperatingSystem
    {
      get { return GetOSArchitecture() == 64; }
    }

    public static IEnumerable<string> FilterByFileExists(params string[] filePaths)
    {
      return filePaths.Where(File.Exists);
    }

    public static bool Contains(this string source, string value, StringComparison comp)
    {
      if (String.IsNullOrEmpty(value) || String.IsNullOrEmpty(source)) return false;
      return source.IndexOf(value, comp) >= 0;
    }

    /// <summary>
    ///   Returns a value indicating whether the specified System.String object occurs
    ///   within this string - case-insensitive.
    ///   This is mapped to SQL so can be used in Linq-To-DB, see Northwind.DAL.Oracle.DataAccessAdapter
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="value">The string to seek.</param>
    /// <returns>
    ///   true if the value parameter occurs within this string, or if value is the
    ///   empty string (""); otherwise, false.
    /// </returns>
    public static bool ContainsIgnoreCase(this string source, string value)
    {
      return source.Contains(value, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    ///   Determines whether this string and a specified System.String object have the same value - case-insensitive.
    ///   This is mapped to SQL so can be used in Linq-To-DB, see Northwind.DAL.Oracle.DataAccessAdapter
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="value">The value.</param>
    /// <returns>true if the value of the value parameter is the same as this string; otherwise, false.</returns>
    /// <exception cref="System.NullReferenceException">This string is null.</exception>
    public static bool EqualsIgnoreCase(this string source, string value)
    {
      return source.Equals(value, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    ///   Get string value before [first] delimiter.
    /// </summary>
    public static string Before(this string value, string delimiter,string valueIfnotFound="")
    {
      var posA = value.IndexOf(delimiter, StringComparison.Ordinal);
      return posA == -1 ? valueIfnotFound : value.Substring(0, posA);
    }

    public static string After(this string value, string delimiter, string valueIfnotFound = "")
    {
      var posA = value.IndexOf(delimiter, StringComparison.Ordinal);
      if (posA == -1) return valueIfnotFound;
      var pos = posA + delimiter.Length;
      return value.Substring(pos, value.Length - pos);
    }

    /// <summary>
    ///   Surrounds the string with a char if not already.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="surroundingChar">The surrounding character.</param>
    /// <returns></returns>
    public static string SurroundWithIfNotAlready(this string value, char surroundingChar)
    {
      if (value.IsNullOrEmpty())
        return value;
      if (value.First() != surroundingChar)
        value = surroundingChar + value;
      if (value.Last() != surroundingChar)
        value = value + surroundingChar;
      return value;
    }

    public static IQueryable WhereDynamic(this IQueryable source, Expression lambdaExpression)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (lambdaExpression == null)
        throw new ArgumentNullException("lambdaExpression");
      return source.Provider.CreateQuery(Expression.Call(typeof(Queryable), "Where", new[]
      {
        source.ElementType
      }, source.Expression, (Expression)Expression.Quote(lambdaExpression)));
    }

    public static IQueryable OrderByDynamic(this IQueryable source, Expression expression, bool ascending = true)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (expression == null)
        throw new ArgumentNullException("expression");
      const string str1 = "OrderBy";
      const string str2 = "OrderByDescending";
      var newExpression = (Expression)Expression.Call(typeof(Queryable), ascending ? str1 : str2, new[]
      {
        source.ElementType,
        expression.Type
      }, source.Expression, Expression.Quote(expression));
      return source.Provider.CreateQuery(newExpression);
    }
  }
}