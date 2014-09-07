using System.Web.Mvc;
using GH.Northwind.Web.Models;

namespace GH.Northwind.Web.ModelBinders
{
  public class SuppliersCategoriesBinder : IModelBinder
  {
    private const string sessionKey = "SuppliersCategoriesModel";

    public object BindModel(ControllerContext controllerContext,
      ModelBindingContext bindingContext)
    {
      // get the model from the session 
      var suppliersCategoriesModel =
        (SuppliersCategoriesModel) controllerContext.HttpContext.Session[sessionKey];

      if (suppliersCategoriesModel == null)
      {
        suppliersCategoriesModel = new SuppliersCategoriesModel();
        controllerContext.HttpContext.Session[sessionKey] = suppliersCategoriesModel;
      }
      return suppliersCategoriesModel;
    }
  }
}