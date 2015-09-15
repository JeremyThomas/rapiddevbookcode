using System.Data.Services;
using System.Data.Services.Common;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.ODataSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  public class NorthwindODataService : LLBLGenProODataServiceBase<LinqMetaData>
  {
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(DataServiceConfiguration config)
    {
      config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
      config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
      config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
      config.UseVerboseErrors = true;
    }

    protected override LinqMetaData CreateLinqMetaDataInstance()
    {
      var linqMetaDataInstance = Factories.CreateLinqMetaData();
      return linqMetaDataInstance;
    }

    protected override ITransactionController CreateTransactionControllerInstance()
    {
      return Factories.CreateDataAccessAdapter();
    }

    protected override IUnitOfWorkCore CreateUnitOfWorkInstance()
    {
      // adapter
      return new UnitOfWork2();
    }

    #region Overrides of LLBLGenProODataServiceBase<LinqMetaData>

    /// <summary>
    ///   Gets the container namespace. This is used in the $metadata response. By default it returns the namespace of the TLinqMetaData type.
    /// </summary>
    protected override string ContainerNamespace
    {
      get { return "Northwind.DAL.EntityClasses"; }
    }

    #endregion
  }
}