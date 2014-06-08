using System;
using System.Collections.Generic;
using System.Linq;

namespace AW.Helper.TypeConverters
{
  public static class TypeConverterHelper
  {
    /// <summary>
    ///   List of all the integer types apart from Char
    /// </summary>
    public static readonly IList<TypeCode> IntegralTypes = new[]
    {
      TypeCode.SByte, TypeCode.Byte, TypeCode.UInt16, TypeCode.Int16, TypeCode.UInt32,
      TypeCode.Int32, TypeCode.UInt64, TypeCode.Int64
    }; //, TypeCode.Char

    public static readonly IList<TypeCode> UnsignedIntegralTypes = new[]
    {
      TypeCode.Byte, TypeCode.UInt16, TypeCode.UInt32, TypeCode.UInt64
    };

    /// <summary>
    ///   List of all the non integer numeric types
    /// </summary>
    public static readonly IList<TypeCode> NonIntegralNumericTypes = new[] {TypeCode.Double, TypeCode.Single, TypeCode.Decimal};

    /// <summary>
    ///   List of all the numeric types
    /// </summary>
    public static readonly IEnumerable<TypeCode> NumericTypes = IntegralTypes.Concat(NonIntegralNumericTypes);

    /// <summary>
    ///   List of all the types that can be converted to a number
    /// </summary>
    public static readonly IEnumerable<TypeCode> NumericalConversionTypes = NumericTypes.Concat(new[] {TypeCode.String});

    /// <summary>
    ///   Determines whether the specified an object is null or a DBNull.
    /// </summary>
    /// <param name="anObject">An object.</param>
    /// <returns>
    ///   <c>true</c> if the specified an object is null; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNull(object anObject)
    {
      return (anObject == null || Convert.IsDBNull(anObject));
    }

    public static Type GetType(TypeCode typeCode)
    {
      return Type.GetType("System." + typeCode);
    }
  }
}