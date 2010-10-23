using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;

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
					return Settings[WindowSettingsName] as WindowSettings;
				return null;
			}
			set
			{
				if (HasSetting(WindowSettingsName))
					Settings[WindowSettingsName] = value;
			}
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
