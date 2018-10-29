using System;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ApplicationCore;

namespace AW.LLBLGen.Plugins
{
	public partial class RenameRelatedFieldsControl: UserControl, IPluginConfigurationControl
	{
		public RenameRelatedFieldsControl()
		{
			InitializeComponent();
			labelDescription.Text = RenameRelatedFieldsPlugin.Description;
		}

		#region Implementation of IPluginConfigurationControl

		public event EventHandler DataIsValid;
#pragma warning disable
		public event EventHandler DataIsInvalid;
#pragma warning restore

		#endregion

		private void RenameRelatedFieldsControl_Load(object sender, EventArgs e)
		{
			DataIsValid?.Invoke(this, new EventArgs());
		}
	}
}