using System.Data.OleDb;
using AW.Helper;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
	public static class Factories
	{
		public static DataAccessAdapterBase CreateDataAccessAdapter(string oleDbConnectionString)
		{
			var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(oleDbConnectionString);
			var connectionStringBuilder = DataHelper.ConvertConnectionStringBuilder(oleDbConnectionStringBuilder, DataHelper.GetDBSourceType(oleDbConnectionString));
			return new DataAccessAdapter(connectionStringBuilder.ConnectionString);
		}
	}
}
