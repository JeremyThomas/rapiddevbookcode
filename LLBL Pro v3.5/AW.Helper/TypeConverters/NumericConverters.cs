using System;
using System.ComponentModel;

namespace AW.Helper.TypeConverters
{
	/// <summary>
	/// Converts a number into Decimal in Oracle
	/// </summary>
	public class DecimalNonNullableNumericConverter : BaseNumericConverter<Decimal>
	{
	}

	/// <summary>
	/// Converts a nullable number into nullable Decimal in Oracle
	/// </summary>
	public class DecimalNumericConverter : DecimalNonNullableNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		/// Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <summary>
	/// Converts a number into Single in Oracle
	/// </summary>
	public class SingleNonNullNumericConverter : BaseNumericConverter<Single>
	{
	}

	/// <summary>
	/// Converts a nullable number into nullable Single in Oracle
	/// </summary>
	public class SingleNumericConverter : SingleNonNullNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		/// Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <summary>
	/// Converts a number into Int16 in Oracle
	/// </summary>
	public class SmallIntegerNonNullNumericConverter : BaseNumericConverter<Int16>
	{
	}

	/// <summary>
	/// Converts a nullable number into nullable Int16 in Oracle
	/// </summary>
	public class SmallIntegerNumericConverter : SmallIntegerNonNullNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		/// Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <summary>
	/// Converts a number into Int32 in Oracle
	/// </summary>
	public class IntegerNonNullNumericConverter : BaseNumericConverter<Int32>
	{
	}

	/// <summary>
	/// Converts a nullable number into nullable Int32 in Oracle
	/// </summary>
	public class IntegerNumericConverter : IntegerNonNullNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		/// Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <summary>
	/// Converts number into Byte in Oracle
	/// </summary>
	public class ByteNonNullNumericConverter : BaseNumericConverter<Byte>
	{
	}

	/// <summary>
	/// Converts nullable number into nullable Byte in Oracle
	/// </summary>
	public class ByteNumericConverter : ByteNonNullNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		/// Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <summary>
	/// Converts number into string in Oracle
	/// </summary>
	public class StringNumericConverter : BaseNumericConverter<String>
	{
	}
}