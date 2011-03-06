using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AW.LLBLGen.DataContextDriver.Static
{
	public class LLBLConnectionTypeToVisibilityConverter : IValueConverter
	{
		public LLBLConnectionType LLBLConnectionType { get; set; }

		public bool Invert { get; set; }

		private object VisibilityToLLBLConnectionType(object value)
		{
			if (!(value is Visibility))
				return DependencyProperty.UnsetValue;
			return (((Visibility)value) == Visibility.Visible) ? LLBLConnectionType : LLBLConnectionType.Unknown;
		}

		private object LLBLConnectionTypeToVisibility(object value)
		{
			if (!(value is LLBLConnectionType))
				if (string.Empty.Equals(value))
					value = Static.LLBLConnectionType.Unknown;
				else
					value = System.Convert.ToInt32(value);

			return (LLBLConnectionType)value == LLBLConnectionType
				? Invert ? Visibility.Collapsed : Visibility.Visible
							: Invert ? Visibility.Visible : Visibility.Collapsed;
		}


		public object Convert(object value, Type targetType,
		                      object parameter, CultureInfo culture)
		{
			return LLBLConnectionTypeToVisibility(value);
		}


		public object ConvertBack(object value, Type targetType,
		                          object parameter, CultureInfo culture)
		{
			return VisibilityToLLBLConnectionType(value);
		}
	}
}