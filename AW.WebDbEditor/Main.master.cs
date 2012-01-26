using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses; //PredicateExpression

public partial class Main : System.Web.UI.MasterPage
{
    private bool _safariUserAgent = false;
    private bool _Initialized = false;

    // FIXED in VS 2010 generated code (also for .Net 2.0)!!!
    // This is necessary because Safari and Chrome browsers don't display the Menu control correctly.
    // All webpages displaying an ASP.NET menu control must inherit this class.
    protected override void AddedControl(Control control, int index)
    {
        if (!_Initialized)
        {
            _Initialized = true;
            _safariUserAgent = (Request.UserAgent.IndexOf("Safari", StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        if (_safariUserAgent)
        {
            Request.Browser.Adapters.Clear();
        }
        base.AddedControl(control, index);
    }

    protected void Page_Load(object sender, EventArgs e)
	{
	}
}
