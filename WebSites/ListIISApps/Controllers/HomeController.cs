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
      var serverManagerVm = ServerManagerVM.ServerManagerVms.FirstOrDefault(s => s.Application.Path == path);
      return View(serverManagerVm);
    }
  }
}