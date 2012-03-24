using System;
using System.Web.DynamicData;

namespace Dynamic_Data
{
	public partial class FilterUserControl : FilterUserControlBase
	{
		public event EventHandler SelectedIndexChanged
		{
			add { DropDownList1.SelectedIndexChanged += value; }
			remove { DropDownList1.SelectedIndexChanged -= value; }
		}

		public override string SelectedValue
		{
			get { return DropDownList1.SelectedValue; }
		}

		protected void Page_Init(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				PopulateListControl(DropDownList1);

				// Set the initial value if there is one
				if (!String.IsNullOrEmpty(InitialValue))
					DropDownList1.SelectedValue = InitialValue;
			}
		}
	}
}