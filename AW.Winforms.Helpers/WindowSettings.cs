using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace AW.Winforms.Helpers
{
		/* Author: Don Kirkby http://donkirkby.googlecode.com/
		 * Released under the MIT licence http://www.opensource.org/licenses/mit-license.php
		 * Installation:
		 * - Copy this file into your project.
		 * - Change the namespace above to match your project's namespace.
		 * - Compile your project.
		 * - Edit the project properties using the Project Properties... item in 
		 * the project menu.
		 * - Go to the settings tab.
		 * - Add a new setting for each form whose position you want to save, and 
		 * type a name for it like MainFormPosition.
		 * - In the type column, select Browse... from the bottom of the list.
		 * - You won't see WindowSettings in the list, but you can just type the
		 * namespace and class name, and click OK. For example, if you changed this
		 * class's namespace to UltimateApp, then you would type 
		 * UltimateApp.WindowSettings and click OK.
		 * - Add Load and FormClosing event handlers to any forms you want to save.
		 * See the forms in this project for example code.
		 * - Add a call to Settings.Default.Save() somewhere in your shutdown code.
		 * The FormClosed event of your main form is a good spot. If you have 
		 * subforms open, you may have to explicitly call their FormClosing events 
		 * when shutting down the app, because they're not called by default.
		 */
		/// <summary>
		/// Serializes a window's location, size, state, and any splitter 
		/// positions to a single application setting. Then you can just create a 
		/// setting of this type for each form in the application, save on close, 
		/// and restore on load.
		/// </summary>
		[Serializable()]
		//[TypeConverter(typeof(WindowSettingsConverter))]
		public class WindowSettings
		{
				public Point Location { get; set; }
				public Size Size { get; set; }
				public FormWindowState WindowState { get; set; }
				public int[] SplitterDistances { get; set; }
				public int[] SplitterSizes { get; set; }

				public WindowSettings()
				{
						// default to an invalid location
						Location = new Point(Int32.MinValue, Int32.MinValue);
				}

				public void Record(Form form, params SplitContainer[] splitters)
				{
						bool shouldRecordSplitters;
						if (form == null)
						{
								shouldRecordSplitters =
										splitters.Length > 0 &&
										splitters[0].FindForm().WindowState != FormWindowState.Minimized;
						}
						else
						{
								switch (form.WindowState)
								{
										case FormWindowState.Maximized:
												RecordWindowPosition(form.RestoreBounds);
												shouldRecordSplitters = true;
												break;
										case FormWindowState.Normal:
												shouldRecordSplitters =
														RecordWindowPosition(form.Bounds);
												break;
										default:
												// Don't record anything when closing while minimized.
												return;
								}
								WindowState = form.WindowState;
						}

						if (shouldRecordSplitters)
						{
								RecordSplitters(splitters);
						}

				}

				/// <summary>
				/// Restore a form's position and that of several splitters.
				/// </summary>
				/// <param name="form"></param>
				/// <param name="splitters">The splitters to restore. You can change some entries
				/// to null if you no longer use that position in the list.</param>
				public void Restore(Form form, params SplitContainer[] splitters)
				{
						if (form == null)
						{
								RestoreSplitters(splitters);
						}
						else if (IsOnScreen(Location, Size))
						{
								form.Location = Location;
								form.Size = Size;
								form.WindowState = WindowState;
								RestoreSplitters(splitters);
						}
						else
						{
								form.WindowState = WindowState;
						}
				}

				private void RestoreSplitters(SplitContainer[] splitters)
				{
						for (
								int i = 0; 
								i < splitters.Length && 
								SplitterDistances != null &&
								i < SplitterDistances.Length; 
								i++)
						{
								var splitter = splitters[i];
								if (splitter == null)
								{
										continue;
								}
								int splitterDistance = SplitterDistances[i];
								if (SplitterSizes != null)
								{
										splitterDistance =
												splitterDistance * GetSplitterSize(splitter) / SplitterSizes[i];
								}
								int splitterSize = GetSplitterSize(splitter);
								bool isDistanceLegal =
										splitter.Panel1MinSize <= splitterDistance
										&& splitterDistance <= splitterSize - splitter.Panel2MinSize;
								if (isDistanceLegal)
								{
										splitter.SplitterDistance = splitterDistance;
								}
						}
				}

				private static int GetSplitterSize(SplitContainer splitter)
				{
						int splitterSize =
								splitter.Orientation == Orientation.Vertical
								? splitter.Width
								: splitter.Height;
						return splitterSize;
				}

				private bool RecordWindowPosition(Rectangle bounds)
				{
						bool isOnScreen = IsOnScreen(bounds.Location, bounds.Size);
						if (isOnScreen)
						{
								Location = bounds.Location;
								Size = bounds.Size;
						}
						return isOnScreen;
				}

				private void RecordSplitters(SplitContainer[] splitters)
				{
						SplitterDistances = new int[splitters.Length];
						SplitterSizes = new int[splitters.Length];
						for (int i = 0; i < splitters.Length; i++)
						{
								if (splitters[i] != null)
								{
										SplitterDistances[i] = splitters[i].SplitterDistance;
										SplitterSizes[i] = GetSplitterSize(splitters[i]);
								}
						}
				}

				private bool IsOnScreen(Point location, Size size)
				{
						return IsOnScreen(location) && IsOnScreen(location + size);
				}

				private bool IsOnScreen(Point location)
				{
						foreach (var screen in Screen.AllScreens)
						{
								Rectangle workingArea = new Rectangle(
										screen.WorkingArea.Location, 
										screen.WorkingArea.Size);
								workingArea.Inflate(1, 1);
								if (workingArea.Contains(location))
								{
										return true;
								}
						}
						return false;
				}

		}

	class WindowSettingsConverter:ExpandableObjectConverter{
		#region Overrides of TypeConverter

		/// <summary>
		/// Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.
		/// </summary>
		/// <returns>
		/// true if this converter can perform the conversion; otherwise, false.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. 
		///                 </param><param name="sourceType">A <see cref="T:System.Type"/> that represents the type you want to convert from. 
		///                 </param>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return (sourceType == typeof(string)) || base.CanConvertFrom(context, sourceType);

		}

		/// <summary>
		/// Returns whether this converter can convert the object to the specified type, using the specified context.
		/// </summary>
		/// <returns>
		/// true if this converter can perform the conversion; otherwise, false.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. 
		///                 </param><param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to. 
		///                 </param>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			bool canConvert = (destinationType == typeof(InstanceDescriptor)) || (destinationType == typeof(string));

			if (!canConvert)
				canConvert = base.CanConvertFrom(context, destinationType);

			return canConvert;;
		}


		/// <summary>
		/// Converts the given object to the type of this converter, using the specified context and culture information.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the converted value.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. 
		///                 </param><param name="culture">The <see cref="T:System.Globalization.CultureInfo"/> to use as the current culture. 
		///                 </param><param name="value">The <see cref="T:System.Object"/> to convert. 
		///                 </param><exception cref="T:System.NotSupportedException">The conversion cannot be performed. 
		///                 </exception>
		//public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		//{
		//  if (value is string)
		//  {
		//    return null;
		//  }
		//  return base.ConvertFrom(context, culture, value);
		//}

		/// <summary>
		/// Converts the given value object to the specified type, using the specified context and culture information.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the converted value.
		/// </returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context. 
		///                 </param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/>. If null is passed, the current culture is assumed. 
		///                 </param><param name="value">The <see cref="T:System.Object"/> to convert. 
		///                 </param><param name="destinationType">The <see cref="T:System.Type"/> to convert the <paramref name="value"/> parameter to. 
		///                 </param><exception cref="T:System.ArgumentNullException">The <paramref name="destinationType"/> parameter is null. 
		///                 </exception><exception cref="T:System.NotSupportedException">The conversion cannot be performed. 
		///                 </exception>
		//public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		//{
		//  if (value is WindowSettings)
		//    return value.ToString();
		//  return base.ConvertTo(context, culture, value, destinationType);
		//}

		#endregion
	}
}
