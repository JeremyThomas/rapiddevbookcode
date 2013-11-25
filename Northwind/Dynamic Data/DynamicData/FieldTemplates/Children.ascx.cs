using System;
using System.Web.DynamicData;
using System.Web.UI;

namespace Dynamic_Data
{
	public partial class ChildrenField : FieldTemplateUserControl
	{
		private bool _allowNavigation = true;

		public string NavigateUrl { get; set; }

		public bool AllowNavigation
		{
			get { return _allowNavigation; }
			set { _allowNavigation = value; }
		}

		protected void Page_Load(object sender, EventArgs e)
		{
      HyperLink1.Text = "View " + Column.DisplayName;
		}

		protected string GetChildrenPath()
		{
			if (!AllowNavigation)
			{
				return null;
			}

			if (String.IsNullOrEmpty(NavigateUrl))
			{
				return ChildrenPath;
			}
			else
			{
				return BuildChildrenPath(NavigateUrl);
			}
		}

		public override Control DataControl
		{
			get { return HyperLink1; }
		}
	}
}