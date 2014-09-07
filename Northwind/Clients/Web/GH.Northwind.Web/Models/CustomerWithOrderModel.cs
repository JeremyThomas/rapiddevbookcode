using System.Collections.Generic;
using Northwind.DAL.EntityClasses;

namespace GH.Northwind.Web.Models
{
  public class CustomerWithOrderModel
  {
    public CustomerWithOrderModel()
    {
      OrderDetails = new Queue<OrderDetailEntity>();
    }

    public CustomerEntity Customer { get; set; }
    public OrderEntity Order { get; set; }
    public Queue<OrderDetailEntity> OrderDetails { get; set; }
  }
}