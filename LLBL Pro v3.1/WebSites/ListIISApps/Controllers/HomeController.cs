using System.Linq;
using System.Web.Mvc;
using ListIISApps.Models;

namespace ListIISApps.Controllers
{
  
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "List Of Applications on IIS";
      return View(ServerManagerVM.ServerManagerVms);
    }

    public ActionResult Details(string path)
    {
      ServerManagerVM serverManagerVm = null;
      foreach (ServerManagerVM s in ServerManagerVM.ServerManagerVms)
      {
        if (s.Application.Path == path)
        {
          serverManagerVm = s;
          break;
        }
      }
      return View(serverManagerVm);
    }
  }
}