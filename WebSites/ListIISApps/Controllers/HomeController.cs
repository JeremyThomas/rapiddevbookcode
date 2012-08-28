using System.Linq;
using System.Web.Mvc;
using Microsoft.Web.Administration;

namespace ListIISApps.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "List Of Applications on IIS";
      var mgr = new ServerManager();

      var x = mgr.Sites.SelectMany(s => s.Applications);
      return View(x);
    }
  }
}