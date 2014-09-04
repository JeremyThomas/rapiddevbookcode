using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.DAL.EntityClasses;

namespace GH.Northwind.Web.Models
{
    public class AllProductsModel
    {
        public List<ProductEntity> Products { get; set; }
        public ProductEntity ProductById(int id)
        {
            return Products.Where(p => p.ProductId == id).First();
        }
    }
}