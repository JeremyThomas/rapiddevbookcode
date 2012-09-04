using System.Linq;
using System.Web.Mvc;
using ListIISApps.Models;

namespace ListIISApps.Controllers
{
  public class HomeController : Controller
  {
    private static string _previousUrl;

    public ActionResult Index()
    {
      HandleRefresh();
      string host = null;
      if (HttpContext.Request.Url != null) host = HttpContext.Request.Url.Host;
      ViewBag.Message = string.Format("List Of Applications on IIS ({0})", host);
      return View(ServerManagerVM.ServerManagerVms);
    }

    /// <summary>
    /// If the same URL is hit twice in a row refresh
    /// </summary>
    private void HandleRefresh()
    {
      if (_previousUrl == HttpContext.Request.RawUrl)
        ServerManagerVM.Refresh();
      else
        _previousUrl = HttpContext.Request.RawUrl;
    }

    public ActionResult Details(string path)
    {
      HandleRefresh();
      return View(ServerManagerVM.ServerManagerVms.FirstOrDefault(s => s.Application.Path == path));
    }
  }
}