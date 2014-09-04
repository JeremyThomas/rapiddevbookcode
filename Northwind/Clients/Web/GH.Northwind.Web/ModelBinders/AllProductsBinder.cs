using System.Web.Mvc;
using GH.Northwind.Web.Models;

namespace GH.Northwind.Web.ModelBinders
{
    public class AllProductsBinder : IModelBinder
    {
        private const string sessionKey = "AllProductsModel";

        public object BindModel(ControllerContext controllerContext,
                                ModelBindingContext bindingContext)
        {
            // get the model from the session 
            AllProductsModel allProductsModel =
                (AllProductsModel)controllerContext.HttpContext.Session[sessionKey];

            if (allProductsModel == null)
            {
                allProductsModel = new AllProductsModel();
                controllerContext.HttpContext.Session[sessionKey] = allProductsModel;
            }
            return allProductsModel;
        }
    }
}