using System;
using System.Collections.Specialized;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AW_Dynamic_Data
{
	public partial class ForeignKey_EditField : FieldTemplateUserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (DropDownList1.Items.Count == 0)
			{
				if (!Column.IsRequired)
				{
					DropDownList1.Items.Add(new ListItem("[Not Set]", ""));
				}

				PopulateListControl(DropDownList1);
			}
		}

		protected override void OnDataBinding(EventArgs e)
		{
			base.OnDataBinding(e);

			if (Mode == DataBoundControlMode.Edit)
			{
				var foreignkey = ForeignKeyColumn.GetForeignKeyString(Row);
				var item = DropDownList1.Items.FindByValue(foreignkey);
				if (item != null)
				{
					DropDownList1.SelectedValue = foreignkey;
				}
			}
		}

		protected override void ExtractValues(IOrderedDictionary dictionary)
		{
			// If it's an empty string, change it to null
			var val = DropDownList1.SelectedValue;
			if (val == String.Empty)
				val = null;

			ExtractForeignKey(dictionary, val);
		}

		public override Control DataControl
		{
			get { return DropDownList1; }
		}
	}
}