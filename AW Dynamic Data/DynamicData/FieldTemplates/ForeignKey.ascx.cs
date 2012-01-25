using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using System.Collections.Generic;
using System.Text;

namespace AW_Dynamic_Data
{
	public partial class ForeignKeyField : System.Web.DynamicData.FieldTemplateUserControl
	{
		private bool _allowNavigation = true;
		private string _navigateUrl;

		public string NavigateUrl
		{
			get
			{
				return _navigateUrl;
			}
			set
			{
				_navigateUrl = value;
			}
		}

		public bool AllowNavigation
		{
			get
			{
				return _allowNavigation;
			}
			set
			{
				_allowNavigation = value;
			}
		}

		protected string GetDisplayString()
		{
			List<object> fkValues = new List<object>();
			foreach (string name in ForeignKeyColumn.ForeignKeyNames)
			{
				fkValues.Add(DataBinder.GetPropertyValue(Row, name));
			}
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < fkValues.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(", ");
				}
				object value = fkValues[i];
				if (value == null)
				{
					value = DBNull.Value;
				}
				builder.Append(value.ToString());
			}
			if (builder.Length > 0)
			{
				return FormatFieldValue(string.Format("View {0} ({1})", ForeignKeyColumn.Name, builder.ToString()));
			}
			else
			{
				return "None";
			}
		}

		protected string GetNavigateUrl()
		{
			if (!AllowNavigation)
			{
				return null;
			}

			if (String.IsNullOrEmpty(NavigateUrl))
			{
				return ForeignKeyPath;
			}
			else
			{
				return BuildForeignKeyPath(NavigateUrl);
			}
		}
	}

}
