using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ListIISApps.Models;
using Microsoft.Web.Administration;

namespace ListIISApps.Controllers
{
  
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "List Of Applications on IIS";
      var x = ServerManagerVM.GetServerManagerVms();
      return View(x);
    }
  }
}