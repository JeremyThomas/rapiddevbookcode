using System.Data.OleDb;
using AW.Helper;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  public static class Factories
  {
    public static DataAccessAdapterBase CreateDataAccessAdapterOleDbConnectionString(string oleDbConnectionString)
    {
      var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(oleDbConnectionString);
      var connectionStringBuilder = DataHelper.ConvertConnectionStringBuilder(oleDbConnectionStringBuilder, DataHelper.GetDBSourceType(oleDbConnectionString));
      return new DataAccessAdapter(connectionStringBuilder.ConnectionString);
    }

    public static DataAccessAdapterBase CreateDataAccessAdapter2(string oleDbConnectionString)
    {
      var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(oleDbConnectionString);
      var connectionStringBuilder = DataHelper.ConvertConnectionStringBuilder(oleDbConnectionStringBuilder, DataHelper.GetDBSourceType(oleDbConnectionString));
      return new DataAccessAdapter(connectionStringBuilder.ConnectionString);
    }

    public static DataAccessAdapterBase CreateDataAccessAdapter()
    {
      return new DataAccessAdapter();
    }

    public static DataAccessAdapterBase CreateDataAccessAdapter(string connectionString)
    {
      return new DataAccessAdapter(connectionString);
    }

    public static LinqMetaData CreateLinqMetaData()
    {
      return new LinqMetaData(CreateDataAccessAdapter());
    }

    public static LinqMetaData CreateLinqMetaData(string connectionString)
    {
      return new LinqMetaData(CreateDataAccessAdapter(connectionString));
    }
  }
}
