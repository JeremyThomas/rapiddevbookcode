using System.Web.DynamicData;
using System.Web.UI;

namespace Dynamic_Data
{
	public partial class TextField : FieldTemplateUserControl
	{
		public override Control DataControl
		{
			get { return Literal1; }
		}
	}
}