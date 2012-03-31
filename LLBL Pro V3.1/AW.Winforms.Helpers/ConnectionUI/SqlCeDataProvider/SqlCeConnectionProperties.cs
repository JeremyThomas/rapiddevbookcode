//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;
using AW.Winforms.Helpers.Properties;
using Microsoft.Data.ConnectionUI;
using Microsoft.SqlServerCe.Client;

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
				var dataSource = this["Data Source"] as string;
				if (String.IsNullOrEmpty(dataSource))
					return false;
				// Ensure file extension: 
				var extension = Path.GetExtension(dataSource);
				return extension == null || (extension.Equals(".sdf", StringComparison.OrdinalIgnoreCase));
			}
		}

		protected override string ToTestString()
		{
			var savedPooling = (bool) ConnectionStringBuilder["Pooling"];
			var wasDefault = !ConnectionStringBuilder.ShouldSerialize("Pooling");
			ConnectionStringBuilder["Pooling"] = false;
			var testString = ConnectionStringBuilder.ConnectionString;
			ConnectionStringBuilder["Pooling"] = savedPooling;
			if (wasDefault)
				ConnectionStringBuilder.Remove("Pooling");
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
				if (e.Number == m_intDatabaseFileNeedsUpgrading)
					throw new InvalidOperationException(Resources.SqlCeConnectionProperties_FileNeedsUpgrading);
				throw;
			}
			finally
			{
				connection.Dispose();
			}
		}

		private const int m_intDatabaseFileNeedsUpgrading = 25138;
	}
}