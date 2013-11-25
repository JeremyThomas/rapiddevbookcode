using System;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dynamic_Data
{
	public partial class Details : Page
	{
		protected MetaTable table;

		protected void Page_Init(object sender, EventArgs e)
		{
			DynamicDataManager1.RegisterControl(DetailsView1);
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			table = DetailsDataSource.GetTable();
			Title = table.DisplayName;
			ListHyperLink.NavigateUrl = table.ListActionPath;
		}

		protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
		{
			if (e.Exception == null || e.ExceptionHandled)
			{
				Response.Redirect(table.ListActionPath);
			}
		}
	}
}