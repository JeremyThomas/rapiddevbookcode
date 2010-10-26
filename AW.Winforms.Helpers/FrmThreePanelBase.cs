using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Winforms.Helpers
{
	public partial class FrmThreePanelBase : Form
	{
		protected ApplicationSettingsBase Settings;
		protected string WindowSettingsName;
		private SettingsPropertyValue _windowSettingsSettingsProperty;

		public FrmThreePanelBase()
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

		protected SettingsPropertyValue WindowSettingsSettingsProperty
		{
			get { return _windowSettingsSettingsProperty ?? (_windowSettingsSettingsProperty = GeneralHelper.GetSetting(Settings, WindowSettingsName)); }
		}

		private void FrmThreePanelBase_Load(object sender, EventArgs e)
		{
			if (WindowSettings != null)
				WindowSettings.Restore(this, splitContainerVertical, splitContainerHorizontal);
		}

		private void FrmThreePanelBase_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (WindowSettings == null)
				WindowSettings = new WindowSettings();
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (WindowSettings != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
			WindowSettings.Record(this, splitContainerVertical, splitContainerHorizontal);
		}

		private void FrmThreePanelBase_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save();
			if (Settings != null)
				Settings.Save();
		}
	}
}