using System;
using System.Linq;
using System.ServiceModel;
using System.Web.Mvc;
using AW.Helper;
using GH.Northwind.Web.Models;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;

namespace GH.Northwind.Web.Controllers
{
  public class NorthwindController : Controller
  {
    //  private readonly ILogger<NorthwindController> Log = Log<NorthwindController>.LogProvider;
    private static INorthwindSvr _northwindSvr;

    public static INorthwindSvr NorthwindSvr
    {
      get
      {
        if (_northwindSvr == null)
          throw new ApplicationException("NorthwindController.NorthwindSvr: NorthwindSvr is null.");
        return _northwindSvr;
      }
      set { _northwindSvr = value; }
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult AllProducts(AllProductsModel allProductsModel)
    {
      try
      {
        allProductsModel.Products = NorthwindSvr.GetProducts();
        return View(allProductsModel.Products);
      }
      catch (FaultException<Exception> e)
      {
        GeneralHelper.DebugOut("Web.NorthwindController.AllProducts(...) Error from Business service layer: " + e.Message);
        throw;
      }
      catch (FaultException ex)
      {
        GeneralHelper.DebugOut("Web.NorthwindController.AllProducts(...) Error from Business service layer: " + ex.Message);
        throw;
      }
      catch (Exception exx)
      {
        GeneralHelper.DebugOut("Web.NorthwindController.AllProducts(...) Error: " + exx.Message);
        throw;
      }
    }

    //
    // GET: /NorthwindSvr/Details/5

    public ActionResult DetailsProduct(int? id, AllProductsModel allProductsModel, SuppliersCategoriesModel model)
    {
      ProductEntity p = null;
      p = id == null ? allProductsModel.ProductById((int) TempData["id"]) : allProductsModel.ProductById(id.Value);
      if (p.Supplier == null) p.Supplier = model.SupplierList.Where(s => s.SupplierId == p.SupplierId).DefaultIfEmpty(null).First();
      if (p.Category == null) p.Category = model.CategoryList.Where(c => c.CategoryId == p.CategoryId).DefaultIfEmpty(null).First();
      return View(p);
    }


    //
    // GET: /NorthwindSvr/Create

    public ActionResult CreateProduct(SuppliersCategoriesModel model)
    {
      ViewBag.SuppliersCategoriesModel = model;
      return View(new ProductEntity());
    }

    //
    // POST: /NorthwindSvr/Create

    [HttpPost]
    public ActionResult CreateProduct(ProductEntity p, AllProductsModel allProductsModel)
    {
      NorthwindSvr.InsertProduct(p, true);
      TempData["id"] = p.ProductId;
      allProductsModel.Products.Insert(allProductsModel.Products.Count, p);
      return RedirectToAction("DetailsProduct");
    }

    //
    // GET: /NorthwindSvr/Edit/5

    public ActionResult EditProduct(int id, AllProductsModel allProductsModel, SuppliersCategoriesModel suppliersCategoriesModel)
    {
      var p = allProductsModel.ProductById(id);
      ViewBag.SuppliersCategoriesModel = suppliersCategoriesModel;
      return View(p);
    }

    //
    // POST: /NorthwindSvr/Edit/5

    [HttpPost]
    public ActionResult EditProduct(ProductEntity p, SuppliersCategoriesModel suppliersCategoriesModel)
    {
      NorthwindSvr.UpdateProduct(p, true);
      ViewBag.SuppliersCategoriesModel = suppliersCategoriesModel;
      return View(p);
    }

    //
    // GET: /NorthwindSvr/Delete/5

    public ActionResult DeleteProduct(int id)
    {
      var p = NorthwindSvr.GetProductById(id);
      return View(p);
    }

    //
    // POST: /NorthwindSvr/Delete/5

    [HttpPost]
    public ActionResult DeleteProduct(int id, FormCollection collection)
    {
      NorthwindSvr.DeleteProduct(id, true);
      return RedirectToAction("AllProducts");
    }
  }
}