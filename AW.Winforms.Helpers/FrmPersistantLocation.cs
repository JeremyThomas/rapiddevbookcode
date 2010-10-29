using System;
using System.Configuration;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers
{
	public partial class FrmPersistantLocation : Form
	{
		private SettingsPropertyValue _windowSettingsSettingsProperty;
		private string _windowSettingsName;

		public string WindowSettingsName
		{
			get
			{
				if (string.IsNullOrEmpty(_windowSettingsName))
					_windowSettingsName = Name + "WindowSettings";
				return _windowSettingsName;
			}
			set { _windowSettingsName = value; }
		}

		public FrmPersistantLocation()
		{
			InitializeComponent();
		}

		protected WindowSettings WindowSettings
		{
			get
			{
				if (WindowSettingsSettingsProperty != null)
					return WindowSettingsSettingsProperty.PropertyValue as WindowSettings;
				return null;
			}
			set
			{
				if (WindowSettingsSettingsProperty != null)
					WindowSettingsSettingsProperty.PropertyValue = value;
			}
		}

		protected virtual SplitContainer[] Splitters
		{
			get { return null; }
		}

		protected SettingsPropertyValue WindowSettingsSettingsProperty
		{
			get { return _windowSettingsSettingsProperty ?? (_windowSettingsSettingsProperty = GeneralHelper.GetSetting(Settings.Default, WindowSettingsName, typeof (WindowSettings))); }
		}

		private void FrmPersistantLocation_Load(object sender, EventArgs e)
		{
			if (WindowSettings != null)
				WindowSettings.Restore(this, Splitters);
		}

		private void FrmPersistantLocation_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (WindowSettings == null)
				WindowSettings = new WindowSettings();
			// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (WindowSettings != null)
				// ReSharper restore ConditionIsAlwaysTrueOrFalse
				WindowSettings.Record(this, Splitters);
		}

		private void FrmPersistantLocation_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Save();
		}
	}
}