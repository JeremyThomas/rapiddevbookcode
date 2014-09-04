using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            SuppliersCategoriesModel suppliersCategoriesModel =
                (SuppliersCategoriesModel)controllerContext.HttpContext.Session[sessionKey];

            if (suppliersCategoriesModel == null)
            {
                suppliersCategoriesModel = new SuppliersCategoriesModel();
                controllerContext.HttpContext.Session[sessionKey] = suppliersCategoriesModel;
            }
            return suppliersCategoriesModel;
        }
    }
}