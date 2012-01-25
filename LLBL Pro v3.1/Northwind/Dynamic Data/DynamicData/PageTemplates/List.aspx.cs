using System;
using System.Web.DynamicData;
using System.Web.UI;

namespace Dynamic_Data
{
	public partial class List : Page
	{
		protected MetaTable table;

		protected void Page_Init(object sender, EventArgs e)
		{
			DynamicDataManager1.RegisterControl(GridView1, true /*setSelectionFromUrl*/);
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			table = GridDataSource.GetTable();
			Title = table.DisplayName;
			InsertHyperLink.NavigateUrl = table.GetActionPath(PageAction.Insert);

			// Disable various options if the table is readonly
			if (table.IsReadOnly)
			{
				GridView1.Columns[0].Visible = false;
				InsertHyperLink.Visible = false;
			}
		}

		protected void OnFilterSelectedIndexChanged(object sender, EventArgs e)
		{
			GridView1.PageIndex = 0;
		}
	}
}