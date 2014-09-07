using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AW.Helper;
using GH.Northwind.Web.Controllers;
using GH.Northwind.Web.ModelBinders;
using GH.Northwind.Web.Models;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;

namespace GH.Northwind.Web
{
  // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
  // visit http://go.microsoft.com/?LinkId=9394801

  public class MvcApplication : HttpApplication
  {
    private Action _serviceCleanup;

    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }

    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      /*routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );*/

      routes.MapRoute(
        "Default", // Route name
        "{controller}/{action}/{id}", // URL with parameters
        new {controller = "Northwind", action = "AllProducts", id = UrlParameter.Optional} // Parameter defaults
        );
    }

    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      RegisterGlobalFilters(GlobalFilters.Filters);
      RegisterRoutes(RouteTable.Routes);
      var usenTier = ConfigurationSettings.AppSettings["N-Tier"] == "true";
      var serviceAndCleanup = WcfUtility.CreateService<INorthwindSvr>(usenTier, "Northwind.Business.dll", "Northwind.Business.NorthwindSvr");
      _serviceCleanup = serviceAndCleanup.Item2;
      NorthwindController.NorthwindSvr = serviceAndCleanup.Item1;
      System.Web.Mvc.ModelBinders.Binders.Add(typeof (CustomerWithOrderModel), new CustomerWithOrderBinder());
      System.Web.Mvc.ModelBinders.Binders.Add(typeof (AllProductsModel), new AllProductsBinder());
      System.Web.Mvc.ModelBinders.Binders.Add(typeof (SuppliersCategoriesModel), new SuppliersCategoriesBinder());
      System.Web.Mvc.ModelBinders.Binders.Add(typeof (CommonEntityBase), new LLBLGenModelBinder());
    }
  }
}