using System;
using System.ComponentModel;

namespace AW.Helper.TypeConverters
{

	/// <summary>
	///   Converts a nullable number into nullable Int16 in Oracle
	/// </summary>
	public class SmallIntegerNumericConverter : BaseNumericConverter<Int16>
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		///   Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

	/// <inheritdoc />
	/// <summary>
	///   Converts a number into Int32 in Oracle
	/// </summary>
	public class IntegerNonNullNumericConverter : BaseNumericConverter<Int32>
	{
	}

	/// <inheritdoc />
	/// <summary>
	///   Converts a nullable number into nullable Int32 in Oracle
	/// </summary>
	public class IntegerNumericConverter : IntegerNonNullNumericConverter
	{
		#region Overrides of BaseNumericConverter<decimal>

		/// <summary>
		///   Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected override object ConvertFromNull(ITypeDescriptorContext context)
		{
			return null;
		}

		#endregion
	}

}