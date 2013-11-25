using System.Linq;
using AW.Data.EntityClasses;

namespace AW.Data.Linq
{
  partial class LinqMetaData
  {
    static LinqMetaData()
    {
      CommonEntityBase.Initialize();
    }

    public static void Initialize()
    {
    }

    public IQueryable<PurchaseOrderHistoryEntity> PurchaseOrderHistoryTs
    {
      get { return PurchaseOrderHistory.Cast<PurchaseOrderHistoryEntity>(); }
    }

    public IQueryable<SalesOrderHistoryEntity> SalesOrderHistoryTs
    {
      get { return SalesOrderHistory.Cast<SalesOrderHistoryEntity>(); }
    }

    public IQueryable<WorkOrderHistoryEntity> WorkOrderHistoryTs
    {
      get { return WorkOrderHistory.Cast<WorkOrderHistoryEntity>(); }
    }
  }
}