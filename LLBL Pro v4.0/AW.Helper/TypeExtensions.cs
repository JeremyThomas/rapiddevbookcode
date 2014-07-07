using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AW.Helper
{
  /// <summary>
  ///   http://www.codeproject.com/Tips/621812/User-friendly-names-for-Types
  /// </summary>
  public static class TypeExtensions
  {
    // ReSharper disable StringLiteralTypo
    private static readonly Dictionary<Type, string> KeywordTypes = new Dictionary<Type, string>
    {
      {typeof (void), "void"},
      {typeof (bool), "bool"},
      {typeof (char), "char"},
      {typeof (byte), "byte"},
      {typeof (sbyte), "sbyte"},
      {typeof (short), "short"},
      {typeof (ushort), "ushort"},
      {typeof (int), "int"},
      {typeof (uint), "uint"},
      {typeof (long), "long"},
      {typeof (ulong), "ulong"},
      {typeof (float), "float"},
      {typeof (double), "double"},
      {typeof (decimal), "decimal"},
      {typeof (string), "string"},
      {typeof (object), "object"}
    };

// ReSharper restore StringLiteralTypo
    public static string GetKeyword(this Type type)
    {
      if (type == null) return null;
      string result;
      KeywordTypes.TryGetValue(type, out result);
      return result;
    }

    public static string FriendlyName(this Type type, bool useKeywords = true, bool showGenericArguments = true, bool showDeclaringType = true, bool compactNullable = true)
    {
      if (type == null) return string.Empty;
      var b = new StringBuilder();
      BuildFriendlyName(b, type, useKeywords, showGenericArguments, showDeclaringType, compactNullable);
      return b.ToString();
    }

    private static void BuildFriendlyName(StringBuilder builder, Type type, bool useKeywords, bool showGenericArguments, bool showDeclaringType, bool compactNullable)
    {
      var isBasic = true;
      if (showDeclaringType && type.IsNested && !type.IsGenericParameter)
      {
        BuildFriendlyName(builder, type.DeclaringType, useKeywords, showGenericArguments, true, compactNullable);
        builder.Append('.');
      }
      if (type.IsArray)
      {
        isBasic = false;
        BuildFriendlyName(builder, type.GetElementType(), useKeywords, showGenericArguments, showDeclaringType, compactNullable);
        builder.Append('[');
        for (var rank = type.GetArrayRank(); rank > 1; --rank) builder.Append(',');
        builder.Append(']');
      }
      if (type.IsPointer)
      {
        isBasic = false;
        BuildFriendlyName(builder, type.GetElementType(), useKeywords, showGenericArguments, showDeclaringType, compactNullable);
        builder.Append('*');
      }
      if (type.IsGenericParameter)
      {
        isBasic = false;
        var gpAttributes = type.GenericParameterAttributes;
        if ((gpAttributes & GenericParameterAttributes.Covariant) == GenericParameterAttributes.Covariant)
        {
          builder.Append("out ");
        }
        else if ((gpAttributes & GenericParameterAttributes.Contravariant) == GenericParameterAttributes.Contravariant)
        {
          builder.Append("in ");
        }
        builder.Append(type.Name);
      }
      if (type.IsGenericType)
      {
        isBasic = false;
        var name = type.Name;
        var index = name.IndexOf('`');
        name = name.Substring(0, index);
        if (type.IsSealed && type.Namespace == null && name.Contains("AnonymousType"))
        {
          builder.Append(name);
        }
        else if (type.IsGenericTypeDefinition)
        {
          builder.Append(name).Append('<');
// ReSharper disable once IdentifierTypo
          var args = type.GetGenericArguments();
          if (showGenericArguments)
          {
            for (var i = 0; i < args.Length; ++i)
            {
              if (i > 0) builder.Append(", ");
              BuildFriendlyName(builder, args[i], useKeywords, true, showDeclaringType, compactNullable);
            }
          }
          else
          {
            for (var i = 0; i < args.Length - 1; ++i)
            {
              builder.Append(',');
            }
          }
          builder.Append('>');
        }
        else
        {
          var isNullable = compactNullable && type.GetGenericTypeDefinition() == typeof (Nullable<>);
          if (isNullable)
          {
            BuildFriendlyName(builder, Nullable.GetUnderlyingType(type), useKeywords, showGenericArguments, showDeclaringType, true);
            builder.Append('?');
          }
          else
          {
            builder.Append(name).Append('<');
// ReSharper disable once IdentifierTypo
            var args = type.GetGenericArguments();
            for (var i = 0; i < args.Length; ++i)
            {
              if (i > 0) builder.Append(", ");
              BuildFriendlyName(builder, args[i], useKeywords, showGenericArguments, showDeclaringType, compactNullable);
            }
            builder.Append('>');
          }
        }
      }
      if (isBasic)
      {
        var keyword = useKeywords ? GetKeyword(type) : null;
        builder.Append(keyword ?? type.Name);
      }
    }
  }
}