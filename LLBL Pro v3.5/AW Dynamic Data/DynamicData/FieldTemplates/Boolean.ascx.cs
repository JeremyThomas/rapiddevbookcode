using System;
using System.Web.DynamicData;
using System.Web.UI;

namespace AW_Dynamic_Data
{
	public partial class BooleanField : FieldTemplateUserControl
	{
		protected override void OnDataBinding(EventArgs e)
		{
			base.OnDataBinding(e);

			var val = FieldValue;
			if (val != null)
				CheckBox1.Checked = (bool) val;
		}

		public override Control DataControl
		{
			get { return CheckBox1; }
		}
	}
}