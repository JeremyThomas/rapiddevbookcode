using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace AW.Winforms.Helpers
{
	public partial class FrmThreePanelBase : Form
	{
		protected ApplicationSettingsBase Settings;
		protected string WindowSettingsName;

		public FrmThreePanelBase()
		{
			InitializeComponent();
		}

		protected WindowSettings WindowSettings
		{
			get
			{
				if (HasSetting(WindowSettingsName))
					if (WindowSettingsSettingsProperty != null)
						return WindowSettingsSettingsProperty.PropertyValue as WindowSettings;
				return null;
			}
			set
			{
				if (HasSetting(WindowSettingsName))
					if (WindowSettingsSettingsProperty != null) 
					WindowSettingsSettingsProperty.PropertyValue = value;
			}
		}

		protected SettingsPropertyValue WindowSettingsSettingsProperty
		{
			get { return HasSetting(WindowSettingsName) ? GetSetting(WindowSettingsName) : null; }
		}

		private SettingsPropertyValue GetSetting(string settingsName)
		{
			if (string.IsNullOrEmpty(settingsName) || Settings == null || Settings.PropertyValues == null)
				return null;
			return Settings.PropertyValues[settingsName];
		}

		private bool HasSetting(string settingsName)
		{
			return !string.IsNullOrEmpty(settingsName) && Settings != null && Settings.Properties.OfType<SettingsProperty>().Any(sp => sp.Name == settingsName);
		}

		private void FrmThreePanelBase_Load(object sender, EventArgs e)
		{
			if (WindowSettings != null)
			{
				WindowSettings.Restore(this, splitContainerVertical, splitContainerHorizontal);
			}
		}

		private void FrmThreePanelBase_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (WindowSettings == null)
			{
				WindowSettings = new WindowSettings();
			}
			WindowSettings.Record(this, splitContainerVertical, splitContainerHorizontal);
			//var dataBinding = this.DataBindings["WindowSettings"];
			//if (dataBinding != null)
			//{
			//  Settings = dataBinding.DataSource as System.Configuration.ApplicationSettingsBase;
			//  //settings.
			//  if (Settings != null)
			//  {
			//    Settings[dataBinding.BindingMemberInfo.BindingField] = WindowSettings;
			//  }
		}

		private void FrmThreePanelBase_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save();
			if (Settings != null)
				Settings.Save();
		}
	}
}