using System.Linq;
using AW.Data.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.Linq
{
  partial class LinqMetaData: IContextAwareElement
  {
    static LinqMetaData()
    {
      CommonEntityBase.Initialize();
    }

    public LinqMetaData(Context context)
    {
      ContextToUse = context;
    }

    public static LinqMetaData CreateWithContext()
    {
      return new LinqMetaData(new Context());
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