using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ObjectSourceVisualizer
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

    public Restriction( string entityName, string alternateKeyName, params string[] includeProperties)
      :this(entityName, includeProperties )
    {
      AlternateKeyName = alternateKeyName;
    }
  }


  /// <summary>
  /// https://github.com/jefflomax/csharp-object-to-object-literal
  /// </summary>
  public static class ObjectToObjectLiteral
  {
    public static string NewLine = Environment.NewLine;
    public static string KeyProperty = "Key";
    private enum ListType { Unknown, Intrinsic, Class } ;

    public class Entity
    {
      public Type Type { get; set; }
      public long Key { get; set; }
      public string Path { get; set; }

      public Entity(object obj, string path)
      {
        Type = obj.GetType();
        var keyProperty = Type.GetProperty(ObjectToObjectLiteral.KeyProperty);
        Key = (keyProperty == null)
          ? 0
          : Convert.ToInt64(keyProperty.GetValue(obj));
        Path = (path.Length == 0)
          ? UniqueName
          : path;
      }

      public string UniqueName
      {
        get { return string.Format("{0}{1}", Type.Name, Key); }
      }
    }

    /// <summary>
    /// Compare Entities on Type and Key only
    /// </summary>
    public class EntityEqualityComparer : IEqualityComparer<Entity>
    {
      public bool Equals( Entity lhs, Entity rhs )
      {
        if (lhs == null && rhs == null)
          return true;

        if (lhs == null || rhs == null)
          return false;

        return lhs.Type == rhs.Type && lhs.Key == rhs.Key;
      }

      public int GetHashCode( Entity entity)
      {
        return ( entity == null )
          ? 0
          : entity.Type.GetHashCode() + entity.Key.GetHashCode();
      }
    }

    /// <summary>
    /// Convert NHibernate .NET object graph to C# Object Literal Contructor
    /// </summary>
    /// <param name="obj">Object graph to serialize to C# Object Literal Constructor</param>
    /// <param name="globalExcludeProperties">Properties to globally exculde</param>
    /// <param name="entityRestrictions">Entities to serialize as a limited set of properties, useful to limit depth of traversal</param>
    /// <returns>string containing Object Literal Constructor</returns>
    public static string ToObjectInitializer
    (
      Object obj,
      string globalExcludeProperties,
      params Restriction[] entityRestrictions
    )
    {
      var sb = new StringBuilder(1024);

      // Maintain a list of each entity encountered.  This is used to
      // prevent "parent" or duplicate references from causing an
      // infinite loop.  If the entity is a parent relationship, NHibernate
      // will have the same reference on both objects, but if it is simply
      // a second reference it will have a different reference
      var entityMap = new Dictionary<Entity, Entity>
      (
        new EntityEqualityComparer()
      );

      // Place Entity Names with Property limitations in a dictionary
      // with a HashSet of Properties to include as the value
      Dictionary<string, HashSet<string>> restrictions = entityRestrictions
        .ToDictionary(k => k.EntityName, v => v.IncludeProperties);

      // Place properties to globally exclude in a HashSet
      HashSet<string> excludeProperties = new HashSet<string>
      (
        globalExcludeProperties.Split(',')
      );

      sb.Append("// Object Literal" + NewLine);

      if (excludeProperties.Any() )
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

      var rootEntity = new Entity(obj, string.Empty);

      sb.Append("var ");
      WalkObject
      (
        obj,
        sb,
        entityMap,
        restrictions,
        excludeProperties,
        level: 0,
        parent: rootEntity.UniqueName
      );

      return sb.ToString();
    }

    /// <summary>
    /// Create string of 0 or more Tab characters
    /// </summary>
    /// <param name="count">count of Tabs</param>
    /// <returns></returns>
    private static string Tabs(int count)
    {
      return new String('\t', count);
    }

    /// <summary>
    /// Walk a NHibernate hydrated .NET object graph, returning a C# 3.0 Object Literal
    /// Constructor of public properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="sb"></param>
    /// <param name="entityMap"></param>
    /// <param name="restrictions"></param>
    /// <param name="excludeProperties"></param>
    /// <param name="level"></param>
    /// <param name="parent"></param>
    /// <returns></returns>
    private static void WalkObject
    (
      Object obj,
      StringBuilder sb,
      Dictionary<Entity, Entity> entityMap,
      Dictionary<string, HashSet<string>> restrictions,
      HashSet<string> excludeProperties,
      int level,
      string parent
    )
    {
      if (obj == null)
      {
        sb.Append("// NULL Object passed to WalkObject");
        return;
      }

      var type = obj.GetType();
      var properties = type.GetProperties();
      var workingTypeName = type.Name;

      var entity = new Entity(obj, parent);

      // NHibernate uses EntityNameProxy to lazily hydrate objects
      // Need an improved way to strip the Proxy? from the object name
      if (workingTypeName.EndsWith("Proxy"))
      {
        workingTypeName = workingTypeName.Substring(0, workingTypeName.Length - "Proxy".Length);
      }
      else if ( workingTypeName.EndsWith("Proxy1") || workingTypeName.EndsWith("Proxy2"))
      {
        workingTypeName = workingTypeName.Substring(0, workingTypeName.Length - "Proxy1".Length);
      }


      // Company specific code
      // This class can't be constructed with an Object Literal, so
      // special case it and emit a constructor
      if (type.BaseType.FullName.Equals("place.your.assembly.name.including.base.class.or.class.here"))
      {
        string temp = sb.ToString();

        var enumValue = type.GetProperty("Value").GetValue(obj);
        var enumName = type.GetProperty("DisplayName").GetValue(obj);
        sb.AppendFormat("{0} = new {1}({2},\"{3}\");{4}", parent, workingTypeName, enumValue, enumName,NewLine);
        return;
      }

      Entity canonicalEntity;
      if (entityMap.TryGetValue(entity, out canonicalEntity))
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

      bool isRestricted = restrictions.ContainsKey(workingTypeName);
      HashSet<string> includeProperties = (isRestricted)
        ? restrictions[workingTypeName]
        : null;

      bool skipEntity = (isRestricted)
        ? includeProperties.Count == 0
        : false;

      if (skipEntity) // TODO: Not Tested
        return;

      entityMap.Add(entity,entity);

      // Emit Object with all base type  properties
      sb.AppendFormat("{0} = new {1}{2}{3}{{{4}", parent, workingTypeName, NewLine, Tabs(level),NewLine);

      bool appendComma = false;
      foreach (var property in properties)
      {
        if( SkipProperty(property,isRestricted,includeProperties,excludeProperties))
        {
          continue;
        }

        if( IsBaseType(property.PropertyType))
        {
          if (appendComma)
          {
            sb.Append("," + NewLine + Tabs(level+1));
          }
          else
          {
            sb.Append(Tabs(level+1));
            appendComma = true;
          }
          HandleBaseTypes(property, obj, sb, level);
        }
      }

      sb.AppendFormat("{0}{1}}};{2}", NewLine, Tabs(level),NewLine);

      // Emit all class types and lists, assiging into the parent class/path
      foreach (var property in properties)
      {
        if (SkipProperty(property, isRestricted, includeProperties, excludeProperties))
        {
          continue;
        }

        var pt = property.PropertyType;
        var propertyName = property.Name;
        var name = pt.Name;

        if (!IsBaseType(property.PropertyType))
        {
          var interfaces = property.PropertyType.GetInterfaces();
          var isIList = interfaces.Contains(typeof(IList));
          var isEnumerable = property.PropertyType.FullName.StartsWith("System.Collections.Generic.IEnumerable");
          var isCollection = property.PropertyType.FullName.StartsWith("System.Collections.Generic.IList");

          if (isIList || isCollection || isEnumerable)
          {
            var list = (IList)property.GetValue(obj, null);

            if (property.PropertyType.IsArray ) // aka typeof(System.Array)
            {
              var listTypeName = property.PropertyType.Name; // includes []
              var listItemType = property.PropertyType.GetElementType();

              var parentPath = ParentPath(parent, property.Name);
              string listParent = string.Format("{0} = new {1}", parentPath, listTypeName);

              if( list.Count == 0 )
              {
                sb.AppendLine(listParent + " {};");
              }
              else
              {
                WalkList(list, listItemType, sb, entityMap, restrictions, excludeProperties, level + 1, parentPath, listParent);
              }
            }
            else if (list != null && list.Count > 0)
            {
              // List<T> and Collection<T> can be quite complex.  T could be a Nullable<T>
              // or a Dictionary<T,T>.  Currently this code handles only simple types
              // not nullables

              bool isGeneric = property.PropertyType.IsGenericType;
              bool isGenericTypeDefinition = property.PropertyType.IsGenericTypeDefinition;
              bool isGenericType = property.PropertyType.IsGenericType;

              var genericArgumentList = property.PropertyType.GetGenericArguments();
              if( genericArgumentList.Length == 0 )
              {
                throw new Exception("Cannot process list "+ property.Name);
              }

              var firstGenericType = genericArgumentList[0];
              var listItemType = firstGenericType.UnderlyingSystemType;
              var listTypeName = firstGenericType.Name;

              var parentPath = ParentPath(parent, property.Name);
              string listParent = string.Format("{0} = new List<{1}>", parentPath, listTypeName);
              WalkList(list, listItemType, sb, entityMap, restrictions, excludeProperties, level + 1, parentPath, listParent);
            }
            else
            {
              var listTypeName = property.PropertyType.GetGenericArguments()[0].Name;
              sb.AppendFormat
              (
                "{0}.{1} = new List<{2}>();{3}",
                parent,
                property.Name,
                listTypeName,
                NewLine
              );
            }
          }
          else
          {
            // Recurse into class
            try
            {
            var value = property.GetValue(obj);
            WalkObject
            (
              value,
              sb,
              entityMap,
              restrictions,
              excludeProperties,
              level + 1,
              ParentPath( parent, propertyName)
            );
            }
            catch (Exception)
            {
            }

          }
        }
      }
    }// WalkObject

    private static string ParentPath( string parent, string propertyName )
    {
      return (parent.Length == 0)
        ? propertyName
        : parent + "." + propertyName ;
    }

    private static bool SkipProperty( PropertyInfo property, bool isRestricted, HashSet<string> includeProperties, HashSet<string> exclude)
    {
      if (isRestricted && !includeProperties.Contains(property.Name))
      {
        return true;
      }
      if (exclude.Contains(property.Name))
      {
        return true;
      }

      return false;
    }

    // System types handled as primitives
    private static HashSet<System.Type> baseTypes = new HashSet<System.Type>
    (
      new System.Type[]
      {
        typeof(String),
        typeof(Int16), typeof(Int32), typeof(Int64),
        typeof(Single), typeof(Double),
        typeof(Decimal),
        typeof(Boolean),
        typeof(DateTime),
        typeof(byte[])
      }
    );


    private static bool IsBaseType( System.Type propertyType )
    {
      if (baseTypes.Contains(propertyType))
      {
        return true;
      }

      if (propertyType.IsEnum)
      {
        return true;
      }

      var name = propertyType.Name;
      var isNullable = propertyType.IsGenericType &&
        propertyType.GetGenericTypeDefinition() == typeof(Nullable<>);
      if (isNullable)
      {
        var underlyingSystemType = propertyType.GetGenericArguments()[0].UnderlyingSystemType;

        if( baseTypes.Contains(underlyingSystemType))
          return true;

        name = propertyType.GetGenericArguments()[0].Name;
      }
      return false;
    }

    private static string FormatType( object obj )
    {
      var type = obj.GetType();

      if( type == typeof(Int16) || type == typeof(Int32))
      {
        return obj.ToString();
      }
      
      if( type == typeof(Int64))
      {
        return obj.ToString()+"L";
      }

      if( type == typeof(String))
      {
        return '"' + Convert.ToString(obj)
          .Replace(@"\", @"\\")
          .Replace("\"", "\\\"")
          .Replace("\r", "\\r")
          .Replace("\n", "\\n")
          + '"' ;
      }

      if( type == typeof(Single) )
      {
        return obj.ToString()+"F";
      }

      if( type == typeof(Double))
      {
        return obj.ToString() + "D";
      }

      if( type == typeof(Decimal))
      {
        return obj.ToString() + "m";
      }

      if( type == typeof(Boolean))
      {
        bool boolWork = false;
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

      if( type == typeof(DateTime))
      {
        DateTime workDate = Convert.ToDateTime(obj);
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
        else
        {
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
      }

      return obj.ToString();
    }

    private static bool HandleBaseTypes(PropertyInfo property, Object obj, StringBuilder sb, int level)
    {
      var pt = property.PropertyType;
      var name = pt.Name;
      var value = property.GetValue(obj);

      var isNullable = pt.IsGenericType && pt.GetGenericTypeDefinition() == typeof(Nullable<>);
      if (isNullable)
      {
        name = pt.GetGenericArguments()[0].Name;
        if (property.GetValue(obj) == null)
        {
          sb.AppendFormat("{0} = null", property.Name);
          return true;
        }
      }

      if (pt == typeof (byte[]))
      {
        var ba = (byte[]) value;
        var s = String.Join(",", ba.Select(b => b.ToString() ));

        sb.AppendFormat("{0} = new byte[]{{{1}}}", property.Name, s);
        return true;
      }

      if (pt.IsEnum)
      {
        sb.AppendFormat("{0} = {1}.{2}", property.Name, pt.Name, property.GetValue(obj));
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
          sb.AppendFormat("{0} = {1}", property.Name, FormatType(value));
          return true;

        // Byte, SByte, Char, TimeSpan ?
      }

      return false;
    } // HandleBaseTypes



    private static void WalkList
    (
      IList list,
      Type listItemType,
      StringBuilder sb,
      Dictionary<Entity, Entity> entityMap,
      Dictionary<string, HashSet<string>> restrictions,
      HashSet<string> exclude,
      int level,
      string parent,
      string listParent
    )
    {
      bool appendComma = false ;

      ListType processType = ListType.Unknown;
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
      foreach (object obj in list)
      {
        if( processType == ListType.Intrinsic)
        {
          if (appendComma)
          {
            sb.Append(",");
          }
          appendComma = true;
          sb.AppendFormat("{0}", FormatType(obj));
        }
        else if ( processType == ListType.Class)
        {
          // Lookup to see if this entity has ref'ed
          var listEntity = new Entity(obj, string.Empty);

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
              level,
              parent: listEntity.UniqueName
            );
          }
        }
      }


      if( processType == ListType.Intrinsic)
      {
        sb.AppendLine("};");
      }
      else if ( processType == ListType.Class)
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
        sb.Append("};" + NewLine);
      }

    }// WalkList
  }// class ObjectToObjectLiteral
}
 
