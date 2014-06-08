//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Data.Common;
using System.IO;
using AW.Helper;
using Microsoft.Data.ConnectionUI;

namespace AW.Winforms.Helpers.ConnectionUI.SqlCeDataProvider
{
  public class SqlCeConnectionProperties : AdoDotNetConnectionProperties
  {
    protected SqlCeConnectionProperties()
      : base("System.Data.SqlClient")
    {
    }

    public override bool IsComplete
    {
      get
      {
        var dataSource = this[DataHelper.DbPropDataSource] as string;
        if (String.IsNullOrEmpty(dataSource))
          return false;
        // Ensure file extension: 
        var extension = Path.GetExtension(dataSource);
        return (extension.Equals(".sdf", StringComparison.OrdinalIgnoreCase));
      }
    }

    protected override string ToTestString()
    {
      var savedPooling = (bool) ConnectionStringBuilder[DataHelper.DbPropPooling];
      var wasDefault = !ConnectionStringBuilder.ShouldSerialize(DataHelper.DbPropPooling);
      ConnectionStringBuilder[DataHelper.DbPropPooling] = false;
      var testString = ConnectionStringBuilder.ConnectionString;
      ConnectionStringBuilder[DataHelper.DbPropPooling] = savedPooling;
      if (wasDefault)
        ConnectionStringBuilder.Remove(DataHelper.DbPropPooling);
      return testString;
    }

    public override void Test()
    {
      DoTest(SqlCe.SqlserverCE35ProviderInvariantName);
    }

    internal void DoTest(string providerInvariantName)
    {
      var testString = ToTestString();
      // Create a connection object
      var connection = DbProviderFactories.GetFactory(providerInvariantName).CreateConnection();
      // Try to open it			
      if (connection != null)
        try
        {
          connection.ConnectionString = ToFullString();
          connection.Open();
        }
        finally
        {
          connection.Dispose();
        }
    }
  }

  internal class SqlCeConnection40Properties : SqlCeConnectionProperties
  {
    #region Overrides of SqlCeConnectionProperties

    public override void Test()
    {
      // Try to open it
      DoTest(SqlCe.SqlserverCE40ProviderInvariantName);
    }

    #endregion
  }
}