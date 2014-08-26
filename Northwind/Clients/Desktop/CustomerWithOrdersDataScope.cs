using Northwind.DAL;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Client.Winforms
{
	/// <summary>
	/// Scope which controls the data maintained in the form. 
	/// </summary>
	public class CustomerWithOrdersDataScope : DataScope
	{
		#region Class Member Declarations
		private CustomerEntity _customer;
		private INorthwindService _dalService;
		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerWithOrdersDataScope"/> class.
		/// </summary>
		public CustomerWithOrdersDataScope(INorthwindService service)
		{
			_dalService = service;
		}


		/// <summary>
		/// Saves the changes.
		/// </summary>
		internal bool SaveChanges()
		{
			return this.CommitChanges(u => _dalService.CommitCustomerManagerChanges((UnitOfWork2)u));
		}


		/// <summary>
		/// Called right before the FetchData method calls FetchDataImpl.
		/// </summary>
		protected override void OnBeforeFetchData()
		{
			base.OnBeforeFetchData();
			// reset scope's data. 
			this.Reset();
		}


		/// <summary>
		/// The implementation of the fetch method. In this method, fetch the data for the scope. Use the TrackQuery methods to make sure
		/// all entities fetched in this method are tracked by the scope.
		/// </summary>
		/// <param name="fetchMethodParameters">The fetch method parameters.</param>
		/// <returns>
		/// true if the fetch was successful, false otherwise
		/// </returns>
		protected override bool FetchDataImpl(params object[] fetchMethodParameters)
		{
			// fetch it from service.
			_customer = _dalService.GetCustomerWithFullOrders(fetchMethodParameters[0] as string) as CustomerEntity;
			// ... and attach it. All entities reachable from _customer are attached as well. 
			if(_customer != null)
			{
				Attach(_customer);
			}
			return _customer != null;
		}


		/// <summary>
		/// Called when toDelete is about to be deleted. Use this method to specify work to be done by the scope to avoid FK constraint issues.
		/// workData is meant to collect this work. It can either be additional entities to delete prior to 'toDelete', or a list of
		/// relations which are used to create cascading delete actions executed prior to the delete action of toDelete.
		/// </summary>
		/// <param name="toDelete">To delete.</param>
		/// <param name="workData">The work data.</param>
		protected override void OnEntityDelete(IEntityCore toDelete, WorkDataCollector workData)
		{
			switch((EntityType)toDelete.LLBLGenProEntityTypeValue)
			{
				case EntityType.OrderEntity:
					// even though we fetch all order detail rows for an order, we add the relationship so we don't miss
					// any order details which are added by another user. 
					workData.Add(OrderEntity.Relations.OrderDetailEntityUsingOrderId);
					break;
			}
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets the customer.
		/// </summary>
		public CustomerEntity Customer
		{
			get { return _customer; }
		}
		#endregion
	}
}
