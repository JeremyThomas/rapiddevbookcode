using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AW.LLBLGen.DataContextDriver.Static
{
	public class LLBLConnectionTypeToVisibilityConverter : IValueConverter
	{
		public LLBLConnectionType LLBLConnectionType { get; set; }


		private object VisibilityToLLBLConnectionType(object value)
		{
			if (!(value is Visibility))

				return DependencyProperty.UnsetValue;


			return (((Visibility)value) == Visibility.Visible) ? LLBLConnectionType : LLBLConnectionType.Unknown;
		}


		private object LLBLConnectionTypeToVisibility(object value)
		{
			if (!(value is LLBLConnectionType))
			{
				var intVal = System.Convert.ToInt32(value);
				value = intVal;
				//return DependencyProperty.UnsetValue;
			}


			return ((LLBLConnectionType)value == LLBLConnectionType)
			       	? Visibility.Visible
			       	: Visibility.Collapsed;
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