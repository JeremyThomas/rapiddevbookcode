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
		/// 	SqlCeClient
		/// </summary>
		internal const string ShortDisplayName = "SqlCeClient";

		/// <summary>
		/// 	SqlCeClient4.0
		/// </summary>
		internal const string ShortDisplayName40 = ShortDisplayName + Version40;

		/// <summary>
		/// 	3.5
		/// </summary>
		internal const string Version35 = "3.5";

		/// <summary>
		/// 	4.0
		/// </summary>
		internal const string Version40 = "4.0";

		/// <summary>
		/// 	Microsoft SQL Server Compact
		/// </summary>
		internal const string DisplayNameBase = "Microsoft SQL Server Compact ";

		/// <summary>
		/// 	Microsoft SQL Server Compact 3.5
		/// </summary>
		internal const string DisplayName35 = DisplayNameBase + Version35;

		/// <summary>
		/// 	Microsoft SQL Server Compact 4.0
		/// </summary>
		internal const string DisplayName40 = DisplayNameBase + Version40;

		/// <summary>
		/// 	System.Data.SqlCeClient
		/// </summary>
		internal const string Name = "System.Data." + ShortDisplayName;

		/// <summary>
		/// 	System.Data.SqlServerCe.4.0
		/// </summary>
		public const string SqlserverCE40ProviderInvariantName = "System.Data.SqlServerCe.4.0";

		private static DataSource _sqlCeDataSource;

		public static DataSource SqlCeDataSource
		{
			get
			{
				if (_sqlCeDataSource == null)
				{
					_sqlCeDataSource = new DataSource(ShortDisplayName, DisplayName35);
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
					var dataProviderSqlEverywhereDescription = string.Format(Resources.DataProvider_SqlEverywhere_Description, Version35);
					var descriptions = new Dictionary<string, string> {{SqlCeDataSource.Name, dataProviderSqlEverywhereDescription}};
					var uiControls = new Dictionary<string, Type> {{String.Empty, typeof (SqlCeConnectionUIControl)}};
					_sqlCeDataProvider = new DataProvider(
						Name,
						string.Format(Resources.DataProvider_SqlEverywhere, Version35),
						ShortDisplayName,
						dataProviderSqlEverywhereDescription,
						typeof (SqlCeConnection),
						descriptions,
						uiControls,
						typeof (SqlCeConnectionProperties));
				}
				return _sqlCeDataProvider;
			}
		}

		private static DataSource _sqlCeDataSource40;

		public static DataSource SqlCeDataSource40
		{
			get
			{
				if (_sqlCeDataSource40 == null)
				{
					_sqlCeDataSource40 = new DataSource(ShortDisplayName40, DisplayName40);
					_sqlCeDataSource40.Providers.Add(SqlCeDataProvider40);
				}
				return _sqlCeDataSource40;
			}
		}

		private static DataProvider _sqlCeDataProvider40;

		public static DataProvider SqlCeDataProvider40
		{
			get
			{
				if (_sqlCeDataProvider40 == null)
				{
					var dataProviderSqlEverywhereDescription = string.Format(Resources.DataProvider_SqlEverywhere_Description, Version40);
					var descriptions = new Dictionary<string, string> {{SqlCeDataSource40.Name, dataProviderSqlEverywhereDescription}};
					var uiControls = new Dictionary<string, Type> {{String.Empty, typeof (SqlCeConnectionUIControl)}};
					_sqlCeDataProvider40 = new DataProvider(
						Name,
						string.Format(Resources.DataProvider_SqlEverywhere, Version40),
						ShortDisplayName40,
						dataProviderSqlEverywhereDescription,
						null, //Not used
						descriptions,
						uiControls,
						typeof (SqlCeConnection40Properties));
				}
				return _sqlCeDataProvider40;
			}
		}
	}
}