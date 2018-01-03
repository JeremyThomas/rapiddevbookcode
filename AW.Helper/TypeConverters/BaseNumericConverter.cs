using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace AW.Helper.TypeConverters
{
	/// <inheritdoc />
	public class BaseNumericConverter<T> : TypeConverter
	{
		#region Overrides of TypeConverter

		/// <inheritdoc />
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == null)
				throw new ArgumentNullException(nameof(sourceType));
			return base.CanConvertFrom(context, sourceType) || TypeConverterHelper.NumericalConversionTypes.Contains(Type.GetTypeCode(sourceType));
		}

		/// <inheritdoc />
		/// <summary>
		///   Returns whether this converter can convert the object to the specified type, using the specified context.
		/// </summary>
		/// <returns>
		///   true if this converter can perform the conversion; otherwise, false.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to. </param>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == null)
				throw new ArgumentNullException(nameof(destinationType));
			return base.CanConvertTo(context, destinationType) || TypeConverterHelper.NumericalConversionTypes.Contains(Type.GetTypeCode(destinationType));
		}

		/// <inheritdoc />
		/// <summary>
		///   Converts the given object to the type of this converter, using the specified context and culture information.
		/// </summary>
		/// <returns>
		///   An <see cref="T:System.Object" /> that represents the converted value.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use as the current culture. </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (Convert.IsDBNull(value))
				return value;
			return TypeConverterHelper.IsNull(value) ? ConvertFromNull(context) : Convert.ChangeType(value, typeof (T), culture);
		}

		/// <summary>
		///   Converts null to a default value of the type, override to convert null to null.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns></returns>
		protected virtual object ConvertFromNull(ITypeDescriptorContext context)
		{
// ReSharper disable once AssignNullToNotNullAttribute
			return CreateInstance(context, null);
		}

		/// <inheritdoc />
		/// <summary>
		///   Converts the given value object to the specified type, using the specified context and culture information.
		/// </summary>
		/// <returns>
		///   An <see cref="T:System.Object" /> that represents the converted value.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">
		///   A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is
		///   assumed.
		/// </param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="destinationType" /> parameter is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return TypeConverterHelper.IsNull(value) ? null : Convert.ChangeType(value, destinationType, culture);
		}

		/// <inheritdoc />
		/// <summary>
		///   Creates an instance of the type that this <see cref="T:System.ComponentModel.TypeConverter" /> is associated with,
		///   using the specified context, given a set of property values for the object.
		/// </summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary" /> of new property values.</param>
		/// <returns>
		///   An <see cref="T:System.Object" /> representing the given <see cref="T:System.Collections.IDictionary" />, or null if
		///   the object cannot be created. This method always returns null.
		/// </returns>
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return default(T);
		}

		#endregion
	}
}