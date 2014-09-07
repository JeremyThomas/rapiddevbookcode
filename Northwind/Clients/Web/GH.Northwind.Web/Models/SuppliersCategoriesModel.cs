using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GH.Northwind.Web.Controllers;
using Northwind.DAL.EntityClasses;

namespace GH.Northwind.Web.Models
{
  public class SuppliersCategoriesModel
  {
    private SelectList _suppliers = null;
    private SelectList _categories = null;
    private List<SupplierEntity> _supplierList = null;
    private List<CategoryEntity> _categoryList = null;

    public List<SupplierEntity> SupplierList
    {
      get
      {
        if (_supplierList == null) _supplierList = NorthwindController.NorthwindSvr.GetSuppliers();
        return _supplierList;
      }
    }

    public List<CategoryEntity> CategoryList
    {
      get
      {
        if (_categoryList == null) _categoryList = NorthwindController.NorthwindSvr.GetProductCategories();
        return _categoryList;
      }
    }

    public SelectList Suppliers
    {
      get
      {
        if (_suppliers == null)
        {
          var selectListSuppliers =
            from c in SupplierList
            select new SelectListItem
            {
              Selected = false,
              Text = c.CompanyName,
              Value = c.SupplierId.ToString()
            };
          _suppliers = new SelectList(selectListSuppliers, "Value", "Text");
        }
        return _suppliers;
      }
      set { _suppliers = value; }
    }


    public SelectList Categories
    {
      get
      {
        if (_categories == null)
        {
          var selectListCategory =
            from c in CategoryList
            select new SelectListItem
            {
              Selected = false,
              Text = c.CategoryName,
              Value = c.CategoryId.ToString()
            };
          _categories = new SelectList(selectListCategory, "Value", "Text");
        }
        return _categories;
      }
      set { _categories = value; }
    }
  }
}