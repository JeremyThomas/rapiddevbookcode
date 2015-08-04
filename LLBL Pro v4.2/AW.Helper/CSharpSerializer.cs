using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using AW.Helper.Properties;

namespace AW.Helper
{
  public class Restriction
  {
    public string EntityName { get; set; }
    public HashSet<string> IncludeProperties { get; set; }
    public string AlternateKeyName { get; set; } // TODO: Implement

    public Restriction(string entityName, params string[] includeProperties)
    {
      EntityName = entityName;
      IncludeProperties = new HashSet<string>(includeProperties);
      AlternateKeyName = null;
    }

    public Restriction(string entityName, string alternateKeyName, params string[] includeProperties)
      : this(entityName, includeProperties)
    {
      AlternateKeyName = alternateKeyName;
    }
  }

  public enum OutputFormat
  {
    Compileable,
    LinqpadProgram,
    Snippet
  }

  /// <summary>
  ///   https://github.com/jefflomax/csharp-object-to-object-literal
  /// </summary>
  public static class CSharpSerializer
  {
    public const string ResultClassName = "ResultContainer";
    public const string ResultMethodName = "Result";
    public static string NewLine = Environment.NewLine;
    public static string KeyProperty = "Key";

    public static readonly string FileHeader1 = "using System;" + NewLine +
                                                "using System.Collections.Generic;" + NewLine +
                                                "using AW.Helper;" + NewLine;


    public static readonly string FileHeader2 = NewLine + "public static class " + ResultClassName + NewLine +
                                                "{" + NewLine + "public  static object " + ResultMethodName + "() " + NewLine +
                                                "{";

    public static void SetPropertiesToExcludeIfEmpty(string propertiesToExclude)
    {
      if (string.IsNullOrWhiteSpace(Settings.Default.PropertiesToExclude))
        Settings.Default.PropertiesToExclude = propertiesToExclude;
    }

    private enum ListType
    {
      Unknown,
      Intrinsic,
      Class
    };

    public class Entity
    {
      public Type Type { get; set; }
      public long Key { get; set; }
      public string Path { get; set; }

      public Entity(object obj, string path)
      {
        Type = obj.GetType();
        var keyProperty = Type.GetProperty(KeyProperty);
        Key = (keyProperty == null)
          ? obj.GetHashCode()
          : Convert.ToInt64(keyProperty.GetValue(obj));
        Path = (path.Length == 0)
          ? UniqueName
          : path;
      }

      public static string FirstCharacterToLower(string str)
      {
        if (String.IsNullOrEmpty(str) || Char.IsLower(str, 0))
          return str;

        return Char.ToLowerInvariant(str[0]) + str.Substring(1);
      }

      public string UniqueName
      {
        get { return FirstCharacterToLower(Type.Name.Before("`", Type.Name)) + Key; }
      }

      public override string ToString()
      {
        return Path;
      }
    }

    /// <summary>
    ///   Compare Entities on Type and Key only
    /// </summary>
    public class EntityEqualityComparer : IEqualityComparer<Entity>
    {
      public bool Equals(Entity lhs, Entity rhs)
      {
        if (lhs == null && rhs == null)
          return true;

        if (lhs == null || rhs == null)
          return false;

        return lhs.Type == rhs.Type && lhs.Key == rhs.Key;
      }

      public int GetHashCode(Entity entity)
      {
        return (entity == null)
          ? 0
          : entity.Type.GetHashCode() + entity.Key.GetHashCode();
      }
    }

    /// <summary>
    ///   Convert .NET object graph to C# source code
    /// </summary>
    /// <param name="obj">Object graph to serialize to C# Object Literal Constructor</param>
    /// <param name="outputFormat"></param>
    /// <param name="globalExcludeProperties">Properties to globally exculde</param>
    /// <param name="entityRestrictions">
    ///   Entities to serialize as a limited set of properties, useful to limit depth of
    ///   traversal
    /// </param>
    /// <returns>
    ///   string containing Object Literal Constructor
    /// </returns>
    public static string SerializeToCSharp
      (
      this object obj,
      OutputFormat outputFormat = OutputFormat.Compileable,
      string globalExcludeProperties = "",
      params Restriction[] entityRestrictions
      )
    {
      var asFragment = outputFormat == OutputFormat.Snippet;
      var sb = new StringBuilder(1024);

      // Maintain a list of each entity encountered.  This is used to
      // prevent "parent" or duplicate references from causing an
      // infinite loop.  If the entity is a parent relationship, NHibernate
      // will have the same reference on both objects, but if it is simply
      // a second reference it will have a different reference
      var entityMap = new Dictionary<Entity, Entity>(
        new EntityEqualityComparer()
        );

      // Place Entity Names with Property limitations in a dictionary
      // with a HashSet of Properties to include as the value
      var restrictions = entityRestrictions
        .ToDictionary(k => k.EntityName, v => v.IncludeProperties);

      if (String.IsNullOrWhiteSpace(globalExcludeProperties) && obj.GetType().GetTypeAndParentTypes().Last().FullName.Contains("LLBL"))
        globalExcludeProperties = "Fields,EntityFactoryToUse";

        // Place properties to globally exclude in a HashSet
        var collection = String.IsNullOrWhiteSpace(globalExcludeProperties) ? new string[0] : globalExcludeProperties.Split(',');
      var excludeProperties = new HashSet<string>(collection);

      sb.Append("// Object Literal" + NewLine);

      if (excludeProperties.Any())
      {
        sb.Append("// Globally Excluded Properties:" + NewLine);
        sb.Append("//  " + globalExcludeProperties + NewLine);
      }

      if (restrictions.Count > 0)
      {
        // Comment the restricted entities
        sb.Append("// Restricted Entities:" + NewLine);
        foreach (var restriction in entityRestrictions)
        {
          sb.AppendFormat(@"// {0}{1}", restriction.EntityName, NewLine);
          sb.AppendFormat
            (
              @"//  Allowed Properties: {0}{1}",
              String.Join(",", restriction.IncludeProperties),
              NewLine
            );
        }
      }

      switch (outputFormat)
      {
        case OutputFormat.Compileable:
          var type = obj.GetType();
          sb.AppendLine(FileHeader1 + "using " + type.Namespace + ";");
          if (type.IsGenericType)
            foreach (var genericTypeArgument in type.GenericTypeArguments)
            {
              sb.AppendLine("using " + genericTypeArgument.Namespace + ";");
            }
          else
          {
            var enumerable = obj as IEnumerable;
            if (enumerable != null)
            {
              var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
              sb.AppendLine("using " + itemType.Namespace + ";");
            }
          }
          break;
        case OutputFormat.LinqpadProgram:
          sb.AppendLine(@"void Main()");
          sb.AppendLine(@"{");
          sb.AppendLine(string.Format(@"	{0}.{1}().Dump();", ResultClassName, ResultMethodName));
          sb.AppendLine(@"}");
          break;
      }

      if (!asFragment)
      {
        sb.AppendLine(NewLine + FileHeader2);
      }

      var rootEntity = new Entity(obj, String.Empty);

      sb.Append("var ");
      var parent = rootEntity.UniqueName;
      WalkObject
        (
          obj,
          sb,
          entityMap,
          restrictions,
          excludeProperties, 0, parent, false);
      if (!asFragment)
      {
        sb.AppendLine(string.Format("{0}return {1};{0}}}}}", NewLine, rootEntity.UniqueName));
      }
      return sb.ToString();
    }

    /// <summary>
    ///   Create string of 0 or more Tab characters
    /// </summary>
    /// <param name="count">count of Tabs</param>
    /// <returns></returns>
    private static string Tabs(int count)
    {
      return new String('\t', count);
    }

    /// <summary>
    ///   Walk a NHibernate hydrated .NET object graph, returning a C# 3.0 Object Literal
    ///   Constructor of public properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="sb"></param>
    /// <param name="entityMap"></param>
    /// <param name="restrictions"></param>
    /// <param name="excludeProperties"></param>
    /// <param name="level"></param>
    /// <param name="parent"></param>
    /// <param name="isListInit"></param>
    /// <returns></returns>
    private static void WalkObject
      (
      Object obj,
      StringBuilder sb,
      Dictionary<Entity, Entity> entityMap,
      Dictionary<string, HashSet<string>> restrictions,
      HashSet<string> excludeProperties,
      int level,
      string parent, bool isListInit)
    {
      if (obj == null)
      {
        sb.AppendLine("// NULL Object passed to WalkObject");
        return;
      }

      var type = obj.GetType();
      var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
        .Where(p => p.CanRead && (p.CanWrite || p.PropertyType.Implements(typeof (ICollection))) && !p.GetCustomAttributes(false).Any(a => a is XmlIgnoreAttribute)).ToList();
      var workingTypeName = type.FriendlyName();

      var entity = new Entity(obj, parent);

      // NHibernate uses EntityNameProxy to lazily hydrate objects
      // Need an improved way to strip the Proxy? from the object name
      if (workingTypeName.EndsWith("Proxy"))
      {
        workingTypeName = workingTypeName.Substring(0, workingTypeName.Length - "Proxy".Length);
      }
      else if (workingTypeName.EndsWith("Proxy1") || workingTypeName.EndsWith("Proxy2"))
      {
        workingTypeName = workingTypeName.Substring(0, workingTypeName.Length - "Proxy1".Length);
      }

      // Company specific code
      // This class can't be constructed with an Object Literal, so
      // special case it and emit a constructor
      if (type.BaseType != null && type.BaseType.FullName.Equals("place.your.assembly.name.including.base.class.or.class.here"))
      {
        var temp = sb.ToString();

        var enumValue = type.GetProperty("Value").GetValue(obj);
        var enumName = type.GetProperty("DisplayName").GetValue(obj);
        sb.AppendFormat("{0} = new {1}({2},\"{3}\");{4}", parent, workingTypeName, enumValue, enumName, NewLine);
        return;
      }

      Entity canonicalEntity;
      if (!isListInit && entityMap.TryGetValue(entity, out canonicalEntity))
      {
        // Entity has already been processed, such as a parent reference.  Emit at it's
        // original definition

        sb.AppendFormat
          (
            "{0} = {1};{2}",
            parent,
            canonicalEntity.Path,
            NewLine
          );
        return;
      }

      var isRestricted = restrictions.ContainsKey(workingTypeName);
      var includeProperties = (isRestricted)
        ? restrictions[workingTypeName]
        : null;

      var skipEntity = (isRestricted) && includeProperties.Count == 0;

      if (skipEntity) // TODO: Not Tested
        return;
      //  if (!isListInit)
      if (entityMap.ContainsKey(entity))
        return;
      entityMap.Add(entity, entity);

      // Emit Object with all base type  properties
      if (string.IsNullOrWhiteSpace(parent))
        sb.AppendFormat("new {1}{2}{3}{{{4}", parent, workingTypeName, NewLine, Tabs(level), NewLine);
      else
        sb.AppendFormat("{0} = new {1}{2}{3}{{{4}", parent, workingTypeName, NewLine, Tabs(level), NewLine);

      var enumerable1 = obj as IEnumerable;
      if (enumerable1 != null && !(obj is string))
      {
        WalkList(enumerable1, MetaDataHelper.GetEnumerableItemType(enumerable1), sb, entityMap, restrictions, excludeProperties, level + 1);
        sb.AppendFormat("{0}{1}}};{2}", NewLine, Tabs(level), NewLine);
      }
      else
      {
        var appendComma = false;
        foreach (var property in properties)
        {
          if (SkipProperty(property, isRestricted, includeProperties, excludeProperties))
          {
            continue;
          }

          if (IsBaseType(property.PropertyType))
          {
            var tabs = Tabs(level + 1);
            if (appendComma)
            {
              var comma = "," + NewLine + tabs;
              sb.Append(comma);
            }
            else
            {
              sb.Append(tabs);
            }
            appendComma = HandleBaseTypes(property, obj, sb, level);
          }
        }
        var endOfClassFormat = isListInit ? "{0}{1}}},{2}" : "{0}{1}}}{2};{2}";
        if (!isListInit)
          sb.AppendFormat(endOfClassFormat, NewLine, Tabs(level), NewLine);

        // Emit all class types and lists, assiging into the parent class/path
        foreach (var property in properties)
        {
          if (SkipProperty(property, isRestricted, includeProperties, excludeProperties))
          {
            continue;
          }

          var pt = property.PropertyType;
          var propertyName = property.Name;

          if (!IsBaseType(pt))
          {
            var interfaces = pt.GetInterfaces();
            var isIList = interfaces.Contains(typeof (IList));
            var isEnumerable = pt.FullName.StartsWith("System.Collections.Generic.IEnumerable");
            var isCollection = pt.FullName.StartsWith("System.Collections.Generic.IList");
            //  if (!isListInit)
            if (isIList || isCollection || isEnumerable)
            {
              var enumerable = (IEnumerable) property.GetValue(obj, null);
              var list = enumerable as ICollection;

              if (list == null)
              {
                if (property.CanWrite)
                  sb.AppendFormat("{0}.{1} = null;{2}", parent, property.Name, NewLine);
              }
              else if (pt.IsArray) // aka typeof(System.Array)
              {
                var listTypeName = pt.Name; // includes []
                var listItemType = pt.GetElementType();

                var parentPath = ParentPath(parent, property.Name);
                string listParent = null;
                if (property.CanWrite)
                  listParent = String.Format("{0} = new {1}", parentPath, listTypeName);
                else
                {
                  listParent = String.Format("{0}.AddRangeDistinct(new []", parentPath);
                }

                if (list.Count == 0)
                {
                  if (property.CanWrite)
                    sb.AppendLine(listParent + " {};");
                }
                else
                {
                  WalkList(list, listItemType, sb, entityMap, restrictions, excludeProperties, level + 1, parentPath, listParent);
                }
              }
              else
              {
                var genericArguments = pt.GetGenericArguments();
                if (list.Count > 0)
                {
                  // List<T> and Collection<T> can be quite complex.  T could be a Nullable<T>
                  // or a Dictionary<T,T>.  Currently this code handles only simple types
                  // not nullables
                  var indexBeforeList = sb.Length;
                  if (isListInit)
                  {
                    var tabs = Tabs(level + 1);
                    if (appendComma)
                    {
                      var comma = "," + NewLine + tabs;
                      sb.Append(comma);
                    }
                    else
                    {
                      sb.Append(tabs);
                    }
                  }

                  var isGeneric = pt.IsGenericType;
                  var isGenericTypeDefinition = pt.IsGenericTypeDefinition;
                  var isGenericType = pt.IsGenericType;
                  Type listItemType;
                  string listParent = null;
                  var parentPath = isListInit ? property.Name : ParentPath(parent, property.Name);
                  if (genericArguments.Length == 0)
                  {
                    listItemType = ListBindingHelper.GetListItemType(list);
                    if (property.CanWrite)
                      listParent = String.Format("{0} = new {1}", parentPath, pt);
                    else
                    {
                      listParent = String.Format("{0}.AddRangeDistinct(new []", parentPath);
                    }
                  }
                  else
                  {
                    var firstGenericType = genericArguments[0];

                    listItemType = firstGenericType.UnderlyingSystemType;

                    var listTypeName = firstGenericType.Name;
                    if (property.CanWrite)
                      listParent = String.Format("{0} = new List<{1}>", parentPath, listTypeName);
                    else
                    {
                      if (isListInit)
                      {
                        sb.AppendFormat("{0} = {{", parentPath);
                        listParent = "";
                      }
                      else
                        listParent = String.Format("{0}.AddRangeDistinct(new []", parentPath);
                    }
                  }

                 var numAdded= WalkList(list, listItemType, sb, entityMap, restrictions, excludeProperties, level + 1, parentPath, listParent);
                  if (numAdded == 0)
                    sb.Remove(indexBeforeList, sb.Length- indexBeforeList);
                  else
                  {
                    appendComma = false;
                  }
                }
                else if (property.CanWrite)
                  if (genericArguments.Any())
                  {
                    var listTypeName = genericArguments[0].Name;
                    sb.AppendFormat
                      (
                        "{0}.{1} = new List<{2}>();{3}",
                        parent,
                        property.Name,
                        listTypeName,
                        NewLine
                      );
                  }
                  else
                  {
                    sb.AppendFormat
                      (
                        "{0}.{1} = new {2}();{3}",
                        parent,
                        property.Name,
                        pt,
                        NewLine);
                  }
              }
            }
            else
            {
              // Recurse into class
              try
              {
                var value = property.GetValue(obj);
                if (value != null)
                {
                  if (isListInit)
                  {
                    var tabs = Tabs(level + 1);
                    if (appendComma)
                    {
                      var comma = "," + NewLine + tabs;
                      sb.Append(comma);
                    }
                    else
                    {
                      sb.Append(tabs);
                    }
                  }
                  WalkObject
                    (
                      value,
                      sb,
                      entityMap,
                      restrictions,
                      excludeProperties,
                      level + 1,
                      ParentPath(parent, propertyName, isListInit), isListInit);
                  if (isListInit)
                    appendComma = false;
                }
              }
              catch (Exception e)
              {
                sb.AppendLine("//" + e.Message);
              }
            }
          }
        }
        if (isListInit)
          sb.AppendFormat(endOfClassFormat, NewLine, Tabs(level), NewLine);
      }
    } // WalkObject

    private static string ParentPath(string parent, string propertyName, bool isListInit = false)
    {
      return (isListInit  || parent.Length == 0)
        ? propertyName
        : parent + "." + propertyName;
    }

    private static bool SkipProperty(PropertyInfo property, bool isRestricted, ICollection<string> includeProperties, IEnumerable<string> exclude)
    {
      if (isRestricted && !includeProperties.Contains(property.Name))
      {
        return true;
      }
      return exclude.Any(nameToExclude => property.Name.Equals(nameToExclude));
      //if (exclude.Contains(property.Name))
      //{
      //  return true;
      //}
    }

    // System types handled as primitives
    private static readonly HashSet<Type> BaseTypes = new HashSet<Type>(
      new[]
      {
        typeof (String),
        typeof (Int16), typeof (Int32), typeof (Int64),
        typeof (Single), typeof (Double),
        typeof (Decimal),
        typeof (Boolean),
        typeof (DateTime),
        typeof (byte[])
      }
      );

    private static bool IsBaseType(Type propertyType)
    {
      propertyType = MetaDataHelper.GetCoreType(propertyType);
      return BaseTypes.Contains(propertyType) || propertyType.IsEnum;
    }

    private static string FormatType(object obj)
    {
      if (obj == null)
      {
        return "// NULL Object passed to FormatType";
      }
      var type = obj.GetType();

      if (type == typeof (Int16) || type == typeof (Int32))
      {
        return obj.ToString();
      }

      if (type == typeof (Int64))
      {
        return obj + "L";
      }

      if (type == typeof (String))
      {
        return '"' + Convert.ToString(obj)
          .Replace(@"\", @"\\")
          .Replace("\"", "\\\"")
          .Replace("\r", "\\r")
          .Replace("\n", "\\n")
               + '"';
      }

      if (type == typeof (Single))
      {
        return obj + "F";
      }

      if (type == typeof (Double))
      {
        return obj + "D";
      }

      if (type == typeof (Decimal))
      {
        return obj + "m";
      }

      if (type == typeof (Boolean))
      {
        var boolWork = false;
        try
        {
          boolWork = Convert.ToBoolean(obj);
        }
        catch (Exception)
        {
          boolWork = false;
        }
        return (boolWork) ? "true" : "false";
      }

      if (type == typeof (DateTime))
      {
        var workDate = Convert.ToDateTime(obj);
        if (workDate.Hour == 0 && workDate.Minute == 0 && workDate.Second == 0)
        {
          return String.Format
            (
              "new DateTime({0},{1},{2})",
              workDate.Year,
              workDate.Month,
              workDate.Day
            );
        }
        return String.Format
          (
            "new DateTime({0},{1},{2},{3},{4},{5})",
            workDate.Year,
            workDate.Month,
            workDate.Day,
            workDate.Hour,
            workDate.Minute,
            workDate.Second
          );
      }

      return obj.ToString();
    }

    private static bool HandleBaseTypes(PropertyInfo property, Object obj, StringBuilder sb, int level)
    {
      var pt = MetaDataHelper.GetCoreType(property.PropertyType);
      var name = pt.Name;
      object value = null;
      try
      {
        value = property.GetValue(obj);
      }
      catch (Exception)
      {
      }
      if (value == null)
      {
        //  sb.AppendFormat("{0} = null", property.Name);
        //return true;
        return false;
      }
      var isNullable = pt.IsGenericType && pt.GetGenericTypeDefinition() == typeof (Nullable<>);
      if (isNullable)
      {
        name = pt.GetGenericArguments()[0].Name;
      }

      if (pt == typeof (byte[]))
      {
        var ba = (byte[]) value;
        var s = String.Join(",", ba.Select(b => b.ToString()));

        sb.AppendFormat("{0} = new byte[]{{{1}}}", property.Name, s);
        return true;
      }

      if (pt.IsEnum)
      {
        sb.AppendFormat("{0} = {1}.{2}", property.Name, pt.Name, value);
        return true;
      }

      switch (name)
      {
        case "Int16":
        case "Int32":
        case "Int64":
        case "Single":
        case "Double":
        case "Boolean":
        case "DateTime":
        case "String":
        case "Decimal":
          sb.AppendFormat("{0} = {1}", property.Name, FormatType(value));
          return true;

        // Byte, SByte, Char, TimeSpan ?
      }

      return false;
    } // HandleBaseTypes


    private static int WalkList
      (
      IEnumerable list,
      Type listItemType,
      StringBuilder sb,
      Dictionary<Entity, Entity> entityMap,
      Dictionary<string, HashSet<string>> restrictions,
      HashSet<string> exclude,
      int level,
      string parent = "",
      string listParent = ""
      )
    {
      var appendComma = false;

      ListType processType;
      if (IsBaseType(listItemType))
      {
        processType = ListType.Intrinsic;
        sb.Append(listParent + " {");
      }
      else
      {
        processType = ListType.Class;
      }

      var listEntities = new List<Entity>();
     var intrinsicCount = 0;
      var entityMapForList = new HashSet<Entity>(new EntityEqualityComparer());
      var isListItem = String.IsNullOrWhiteSpace(listParent);
      if (isListItem) //Want breadth first
      {
        foreach (var obj in list)
        {
          switch (processType)
          {
             case ListType.Class:
            {
              // Lookup to see if this entity has ref'ed
              var listEntity = new Entity(obj, String.Empty);
              if (!entityMap.ContainsKey(listEntity))
              {
                  entityMapForList.Add(listEntity);
                  entityMap.Add(listEntity, listEntity);
                }
            }
              break;
          }
        }
        foreach (var obj in list)
        {
          switch (processType)
          {
            case ListType.Intrinsic:
              if (appendComma)
              {
                sb.Append(",");
              }
              appendComma = true;
              sb.AppendFormat("{0}", FormatType(obj));
              intrinsicCount++;
              break;
            case ListType.Class:
              {
                // Lookup to see if this entity has ref'ed
                var listEntity = new Entity(obj, String.Empty);
                if (entityMapForList.Contains(listEntity))
                {
                  entityMap.Remove(listEntity);
                  listEntities.Add(listEntity);
                  WalkObject
                    (
                      obj,
                      sb,
                      entityMap,
                      restrictions,
                      exclude,
                      level, "", true);
                }
              }
              break;
          }
        }
      }
      else
        foreach (var obj in list)
        {
          switch (processType)
          {
            case ListType.Intrinsic:
              if (appendComma)
              {
                sb.Append(",");
              }
              appendComma = true;
              sb.AppendFormat("{0}", FormatType(obj));
              intrinsicCount++;
              break;
            case ListType.Class:
            {
              // Lookup to see if this entity has ref'ed
              var listEntity = new Entity(obj, String.Empty);

              Entity canonicalEntity;
              if (entityMap.TryGetValue(listEntity, out canonicalEntity))
              {
                listEntities.Add(canonicalEntity);
              }
              else
              {
                listEntities.Add(listEntity);
                sb.AppendFormat("{0}var ", Tabs(level));
                WalkObject
                  (
                    obj,
                    sb,
                    entityMap,
                    restrictions,
                    exclude,
                    level, listEntity.UniqueName, false);
              }
            }
              break;
          }
        }

      if (processType == ListType.Intrinsic)
      {
        if (listParent != null && listParent.Contains("("))
          sb.AppendLine("});");
        else
          sb.AppendLine("};");
      }
      else if (processType == ListType.Class)
        if (isListItem)
        {
          if (!String.IsNullOrWhiteSpace(parent))
            sb.Append("}," + NewLine);
        }
        else
        {
          appendComma = false;
          sb.Append(listParent + " {");
          foreach (var listEntity in listEntities)
          {
            if (appendComma)
            {
              sb.Append(",");
            }
            appendComma = true;

            sb.Append(listEntity.Path);
          }
          if (listParent.Contains("("))
            sb.Append("});" + NewLine);
          else
            sb.Append("};" + NewLine);
        }
      return listEntities.Count+ intrinsicCount;
    } // WalkList
  } // class ObjectToObjectLiteral
}