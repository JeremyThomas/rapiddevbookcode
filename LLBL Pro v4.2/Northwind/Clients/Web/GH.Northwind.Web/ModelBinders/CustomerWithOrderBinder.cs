using System.Web.Mvc;
using GH.Northwind.Web.Models;

namespace GH.Northwind.Web.ModelBinders
{
    public class CustomerWithOrderBinder : IModelBinder
    {
        private const string sessionKey = "CustomerWithOrderModel";

        public object BindModel(ControllerContext controllerContext,
                                ModelBindingContext bindingContext)
        {
            // get the model from the session 
            CustomerWithOrderModel customerWithOrder =
                (CustomerWithOrderModel) controllerContext.HttpContext.Session[sessionKey];

            if (customerWithOrder == null)
            {
                customerWithOrder = new CustomerWithOrderModel();
                controllerContext.HttpContext.Session[sessionKey] = customerWithOrder;
            }
            return customerWithOrder;
        }
    }
}