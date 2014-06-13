using System;
using System.Web.UI;

namespace AW_Dynamic_Data {
    public partial class EmailAddressField : System.Web.DynamicData.FieldTemplateUserControl {
        protected override void OnDataBinding(EventArgs e) {
            string url = FieldValueString;
            if (!url.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase)) {
                url = "mailto:" + url;
            }
            HyperLink1.NavigateUrl = url;
        }

        public override Control DataControl {
            get {
                return HyperLink1;
            }
        }

    }
}
