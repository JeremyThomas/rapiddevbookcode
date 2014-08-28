using System.Data.Services;
using System.Data.Services.Common;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ODataSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  public class NorthwindODataService : LLBLGenProODataServiceBase<LinqMetaData>
  {
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(DataServiceConfiguration config)
    {
      // TODO: set rules to indicate which entity sets and service operations 
      // are visible, updatable, etc.
      // Examples:
      // config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
      // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
      config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
    }

    protected override LinqMetaData CreateLinqMetaDataInstance()
    {
      return new LinqMetaData(new DataAccessAdapter());
    }

    protected override ITransactionController CreateTransactionControllerInstance()
    {
      return new DataAccessAdapter();
    }

    protected override IUnitOfWorkCore CreateUnitOfWorkInstance()
    {
      // adapter
      return new UnitOfWork2();
    }
  }
}