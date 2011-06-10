using System.Linq;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace Northwind.DAL.Linq
{
	public static class Prefetches
	{
		public static IQueryable<CustomerEntity> PrefetchCustomerCustomerDemoCustomerDemographic(this DataSource2<CustomerEntity> customerEntities)
		{
			return customerEntities.WithPath(cp => cp.Prefetch<CustomerCustomerDemoEntity>(c => c.CustomerCustomerDemos).SubPath(p => p.Prefetch(c => c.CustomerDemographic)));
		}

		public static IQueryable<CustomerEntity> PrefetchCustomerCustomerDemographic(this DataSource2<CustomerEntity> customerEntities)
		{
			return customerEntities.WithPath(cp => cp.Prefetch<CustomerDemographicEntity>(c => c. CustomerDemographics));
		}

		public static IQueryable<CustomerEntity> PrefetchOrderOrderDetailProduct(this DataSource2<CustomerEntity> customerEntities)
		{
			return customerEntities.WithPath(cp => cp.Prefetch<OrderEntity>(c => c.Orders).SubPath(i => i.Prefetch<OrderDetailEntity>(inv => inv.OrderDetails).SubPath(f => f.Prefetch(f1 => f1.Product))));
		}

		public static IQueryable<ProductEntity> PrefetchOrderDetailOrderCustomer(this DataSource2<ProductEntity> productEntities)
		{
			return productEntities.WithPath(cp => cp.Prefetch<OrderDetailEntity>(c => c.OrderDetails).SubPath(p => p.Prefetch<OrderEntity>(c => c.Order).SubPath(o => o.Prefetch(or => or.Customer))));
		}
	}
}