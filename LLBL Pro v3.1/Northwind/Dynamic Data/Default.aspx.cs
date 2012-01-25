using System;
using System.Collections;
using System.Web.DynamicData;
using System.Web.UI;

namespace Dynamic_Data
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			IList visibleTables = MetaModel.Default.VisibleTables;
			if (visibleTables.Count == 0)
			{
				throw new InvalidOperationException("There are no accessible tables. Make sure that at least one data model is registered in Global.asax and scaffolding is enabled or implement custom pages.");
			}
			Menu1.DataSource = visibleTables;
			Menu1.DataBind();
		}
	}
}