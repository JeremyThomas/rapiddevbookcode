using System;
using System.ComponentModel;

namespace AW.Helper.TypeConverters
{
	/// <inheritdoc />
	/// <summary>
	/// Definition of the Int32Int64Converter. This converter uses 'Int32' as its core type and converts any Int64 value to and from Int32
	/// </summary>
	/// <remarks>This class defines a System Type Converter, which means it is not able to convert any value, but defines which types can be
	/// converted to/from using this type converter. System type converters are used by the LLBLGen Pro designer to define type conversions
	/// and are mapped to real type converters / type conversion code by framework definition files for the target frameworks which support
	/// the type converters.
	/// <br /><br />
	/// Accepted types are: Int64</remarks>
	[Description("Converter with as core type System.Int32, for mapping a field with a .NET type System.Int32 onto a Int64 database field")]
	[DesignOnly(true)]
	public class Int32Int64Converter : SystemTypeConverterBase
	{
		/// <inheritdoc />
		/// <summary>
		/// Checks the type if it's usable to convert to/from for this type converter.
		/// </summary>
		/// <param name="typeToCheck"></param>
		/// <returns>
		/// true if the type is usable for this type converter, false otherwise
		/// </returns>
		protected override bool CheckType(Type typeToCheck)
		{
			switch (typeToCheck.FullName)
			{
				case "System.Int64":
					return true;
				default:
					return false;
			}
		}


		/// <inheritdoc />
		/// <summary>
		/// Creates an instance of the Type that this <see cref="T:System.ComponentModel.TypeConverter" /> is associated with (int)
		/// </summary>
		/// <param name="context">ignored.</param>
		/// <param name="propertyValues">ignored.</param>
		/// <returns>
		/// An <see cref="T:System.Object" /> of type int. It always returns 0 for this converter.
		/// </returns>
		public override object CreateInstance(ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
		{
			return 0;
		}
	}

	/// <inheritdoc />
	/// <summary>
	/// Definition of the Int16IntConverter. This converter uses 'Int16' as its core type and converts any Int32 or Int64 value to and from Int16
	/// </summary>
	/// <remarks>This class defines a System Type Converter, which means it is not able to convert any value, but defines which types can be
	/// converted to/from using this type converter. System type converters are used by the LLBLGen Pro designer to define type conversions
	/// and are mapped to real type converters / type conversion code by framework definition files for the target frameworks which support
	/// the type converters.
	/// <br /><br />
	/// Accepted types are: Int64</remarks>
	[Description("Converter with as core type System.Int16, for mapping a field with a .NET type System.Int16 onto a Int32 or Int64 database field")]
	public class Int16IntConverter : SystemTypeConverterBase
	{
		/// <inheritdoc />
		/// <summary>
		/// Checks the type if it's usable to convert to/from for this type converter.
		/// </summary>
		/// <param name="typeToCheck"></param>
		/// <returns>
		/// true if the type is usable for this type converter, false otherwise
		/// </returns>
		protected override bool CheckType(Type typeToCheck)
		{
			switch (typeToCheck.FullName)
			{
				case "System.Int64":
				case "System.Int32":
					return true;
				default:
					return false;
			}
		}


		/// <inheritdoc />
		/// <summary>
		/// Creates an instance of the Type that this <see cref="T:System.ComponentModel.TypeConverter" /> is associated with (int)
		/// </summary>
		/// <param name="context">ignored.</param>
		/// <param name="propertyValues">ignored.</param>
		/// <returns>
		/// An <see cref="T:System.Object" /> of type int. It always returns 0 for this converter.
		/// </returns>
		public override object CreateInstance(ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
		{
			return 0;
		}
	}
}



























