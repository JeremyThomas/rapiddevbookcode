//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using AW.Winforms.Helpers.Properties;
using Microsoft.Data.ConnectionUI;

namespace AW.Winforms.Helpers.ConnectionUI.SqlCeDataProvider
{
	public class SqlCe
	{
		/// <summary>
		/// SqlCeClient
		/// </summary>
		internal const string ShortDisplayName = "SqlCeClient";

		/// <summary>
		/// 3.5
		/// </summary>
		internal const string Version = "3.5";

		/// <summary>
		/// Microsoft SQL Server Compact 3.5
		/// </summary>
		internal const string DisplayName = "Microsoft SQL Server Compact " + Version;

		/// <summary>
		/// System.Data.SqlCeClient
		/// </summary>
		internal const string Name = "System.Data.SqlCeClient";

		private static DataSource _sqlCeDataSource;

		public static DataSource SqlCeDataSource
		{
			get
			{
				if (_sqlCeDataSource == null)
				{
					_sqlCeDataSource = new DataSource(ShortDisplayName, DisplayName);
					_sqlCeDataSource.Providers.Add(SqlCeDataProvider);
				}
				return _sqlCeDataSource;
			}
		}
		
		private static DataProvider _sqlCeDataProvider;

		public static DataProvider SqlCeDataProvider
		{
			get
			{
				if (_sqlCeDataProvider == null)
				{
					var descriptions = new Dictionary<string, string> {{SqlCeDataSource.Name, Resources.DataProvider_SqlEverywhere_Description}};
					var uiControls = new Dictionary<string, Type> {{String.Empty, typeof (SqlCeConnectionUIControl)}};
					_sqlCeDataProvider = new DataProvider(
						Name,
						Resources.DataProvider_SqlEverywhere,
						ShortDisplayName,
						Resources.DataProvider_SqlEverywhere_Description,
						typeof (SqlCeConnection),
						descriptions,
						uiControls,
						typeof (SqlCeConnectionProperties));
				}
				return _sqlCeDataProvider;
			}
		}
	}
}