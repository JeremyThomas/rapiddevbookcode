using System;
using System.Collections.Generic;
using System.Text;
using System.Web.DynamicData;
using System.Web.UI;

namespace AW_Dynamic_Data
{
	public partial class ForeignKeyField : FieldTemplateUserControl
	{
		private bool _allowNavigation = true;

		public string NavigateUrl { get; set; }

		public bool AllowNavigation
		{
			get { return _allowNavigation; }
			set { _allowNavigation = value; }
		}

		protected string GetDisplayString()
		{
			var fkValues = new List<object>();
			foreach (var name in ForeignKeyColumn.ForeignKeyNames)
			{
				fkValues.Add(DataBinder.GetPropertyValue(Row, name));
			}
			var builder = new StringBuilder();
			for (var i = 0; i < fkValues.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(", ");
				}
				var value = fkValues[i];
				if (value == null)
				{
					value = DBNull.Value;
				}
				builder.Append(value.ToString());
			}
			if (builder.Length > 0)
			{
        return FormatFieldValue(string.Format("View {0} ({1})", ForeignKeyColumn.DisplayName, builder));
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