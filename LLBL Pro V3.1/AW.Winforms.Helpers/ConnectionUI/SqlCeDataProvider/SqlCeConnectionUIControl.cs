//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;
using Microsoft.Data.ConnectionUI;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace AW.Winforms.Helpers.ConnectionUI.SqlCeDataProvider
{
	/// <summary>
	/// 	Represents the connection UI control for the SQL Server Compact provider.
	/// </summary>
	internal partial class SqlCeConnectionUIControl : UserControl, IDataConnectionUIControl
	{
		private bool _loading;

		private SqlCeConnectionProperties _properties;
		private string _version;

		public SqlCeConnectionUIControl()
		{
			InitializeComponent();
			RightToLeft = RightToLeft.Inherit;

			// Disable the active sync radio button for standalone connection dialog.
			activeSyncRadioButton.Enabled = false;
			createButton.Enabled = false;
		}

		public static string MobileDevicePrefix
		{
			get { return  @"Mobile Device\"; }
		}

		public void Initialize(IDataConnectionProperties connectionProperties)
		{
			if (connectionProperties == null)
				throw new ArgumentNullException("connectionProperties");
			var properties = connectionProperties as SqlCeConnectionProperties;
			if (properties == null)
				throw new ArgumentException(Resources.SqlCeConnectionUIControl_InvalidConnectionProperties);
			_properties = properties;
			_version = _properties is SqlCeConnection40Properties ? SqlCe.Version40 : SqlCe.Version35;
		}

		public void LoadProperties()
		{
			_loading = true;
			myComputerRadioButton.Checked = true;
			if (_properties != null)
			{
				databaseTextBox.Text = _properties[DataHelper.DbPropDataSource] as string;
				passwordTextBox.Text = _properties[DataHelper.DbpropAuthPassword] as string;
				savePasswordCheckBox.Checked = (bool) _properties[DataHelper.DbpropAuthPersistSensitiveAuthinfo];
			}
			_loading = false;
		}

		private void myComputerRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			databaseTextBox_TextChanged(sender, e);
		}

		private void activeSyncRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			databaseTextBox_TextChanged(sender, e);
		}

		private void databaseTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!_loading)
			{
				var dataSource = databaseTextBox.Text.Trim();
				if (activeSyncRadioButton.Checked)
					dataSource = Path.Combine(MobileDevicePrefix, dataSource);
				if (dataSource.Length == 0)
					dataSource = null;
				_properties[DataHelper.DbPropDataSource] = dataSource;
			}
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			if (myComputerRadioButton.Checked)
			{
				//
				// We're exploring the desktop, let's use an OpenFileDialog
				//
				using (var fileDialog = new OpenFileDialog())
				{
					fileDialog.Title = string.Format(Resources.SqlConnectionUIControl_BrowseFileTitle, _version);
					fileDialog.Multiselect = false;
					if (_properties != null && String.IsNullOrEmpty(_properties[DataHelper.DbPropDataSource] as string))
						fileDialog.InitialDirectory = InitialDirectory;
					fileDialog.RestoreDirectory = true;
					fileDialog.Filter = string.Format(Resources.SqlConnectionUIControl_BrowseFileFilter, _version);
					fileDialog.DefaultExt = Resources.SqlConnectionUIControl_BrowseFileDefaultExt;
					if (fileDialog.ShowDialog() == DialogResult.OK)
					{
						if (_properties != null) _properties[DataHelper.DbPropDataSource] = fileDialog.FileName.Trim();
						LoadProperties();
					}
				}
			}
		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!_loading)
			{
				_properties[DataHelper.DbpropAuthPassword] = (passwordTextBox.Text.Length > 0) ? passwordTextBox.Text : null;
				passwordTextBox.Text = passwordTextBox.Text; // forces reselection of all text
			}
		}

		private void savePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!_loading)
				_properties[DataHelper.DbpropAuthPersistSensitiveAuthinfo] = savePasswordCheckBox.Checked;
		}

		private void TrimControlText(object sender, EventArgs e)
		{
			var c = sender as Control;
			if (c != null) c.Text = c.Text.Trim();
		}

		private string InitialDirectory
		{
			get
			{
				var path = GetPathToSamples("", _version);
				if (!Directory.Exists(path) && GeneralHelper.Is64BitOperatingSystem)
					return GetPathToSamples(@"Wow6432Node\", _version);
				return path;
			}
		}

		private static string GetPathToSamples(string wow6432Node, string version)
		{
			string path = null;

			var sqlCEBaseRegKey = Registry.LocalMachine.OpenSubKey(
				@"SOFTWARE\" + wow6432Node + @"Microsoft\Microsoft SQL Server Compact Edition\v" + version);
			if (sqlCEBaseRegKey != null)
				using (sqlCEBaseRegKey)
				{
					path = sqlCEBaseRegKey.GetValue("InstallDir") as string;
					if (path != null)
						path = Path.Combine(path, "Samples");
				}
			return path;
		}
	}
}