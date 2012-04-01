//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.IO;
using AW.Helper;
using AW.Winforms.Helpers.Properties;
using Microsoft.Data.ConnectionUI;

namespace AW.Winforms.Helpers.ConnectionUI.SqlCeDataProvider
{
	public class SqlCeConnectionProperties : AdoDotNetConnectionProperties
	{
		public SqlCeConnectionProperties()
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
				return extension == null || (extension.Equals(".sdf", StringComparison.OrdinalIgnoreCase));
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
			var testString = ToTestString();

			// Create a connection object
			var connection = new SqlCeConnection();

			// Try to open it
			try
			{
				connection.ConnectionString = ToFullString();
				connection.Open();
			}
			catch (SqlCeException e)
			{
				// Customize the error message for upgrade required
				if (e.NativeError == IntDatabaseFileNeedsUpgrading)
					throw new InvalidOperationException(Resources.SqlCeConnectionProperties_FileNeedsUpgrading);
				throw;
			}
			finally
			{
				connection.Dispose();
			}
		}

		private const int IntDatabaseFileNeedsUpgrading = 25138;
	}

	class SqlCeConnection40Properties : SqlCeConnectionProperties
	{
		#region Overrides of SqlCeConnectionProperties

		public override void Test()
		{
			var testString = ToTestString();

			// Create a connection object
			var connection = DbProviderFactories.GetFactory(SqlCe.SqlserverCE40ProviderInvariantName).CreateConnection();
			// Try to open it
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

		#endregion
	}
}