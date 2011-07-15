//------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using AW.Helper;
using AW.Winforms.Helpers.ConnectionUI.SqlCeDataProvider;
using Microsoft.Data.ConnectionUI;

namespace AW.Winforms.Helpers.ConnectionUI
{
	/// <summary>
	/// Provide a default implementation for the storage of DataConnection Dialog UI configuration.
	/// </summary>
	public class DataConnectionConfiguration : IDataConnectionConfiguration
	{
		private const string configFileName = @"DataConnection.xml";
		private readonly string fullFilePath;
		private readonly XDocument xDoc;

		// Available data sources:
		private IDictionary<string, DataSource> dataSources;

		// Available data providers: 
		private IDictionary<string, DataProvider> dataProviders;

		static DataConnectionConfiguration()
		{
			AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="path">Configuration file path.</param>
		public DataConnectionConfiguration(string path)
		{
			fullFilePath = !String.IsNullOrEmpty(path) ? Path.GetFullPath(Path.Combine(path, configFileName)) : Path.Combine(Environment.CurrentDirectory, configFileName);
			if (!String.IsNullOrEmpty(fullFilePath) && File.Exists(fullFilePath))
			{
				xDoc = XDocument.Load(fullFilePath);
			}
			else
			{
				xDoc = new XDocument();
				xDoc.Add(new XElement("ConnectionDialog", new XElement("DataSourceSelection")));
			}

			RootElement = xDoc.Root;
		}

		public XElement RootElement { get; set; }

		public void LoadConfiguration(DataConnectionDialog dialog)
		{
			DataSource.AddStandardDataSources(dialog);
			//dialog.DataSources.Add(DataSource.SqlDataSource);
			//dialog.DataSources.Add(DataSource.SqlFileDataSource);
			//dialog.DataSources.Add(DataSource.OracleDataSource);
			//dialog.DataSources.Add(DataSource.AccessDataSource);
			//dialog.DataSources.Add(DataSource.OdbcDataSource);
			//dialog.DataSources.Add(SqlCe.SqlCeDataSource);
			AddDataSources(dialog, SqlCe.SqlCeDataSource);
			AddDataSources(dialog, CreateSQLiteDataSource());
			//Oracle Data Provider for .NETOracle Data Provider for .NETOracle.DataAccess.Client

			AddDataSources(dialog, CreateDataSource("Oracle.DataAccess.Client", "Oracle Data Provider for .NET", "Oracle Database",
			                                        "Oracle Database",
			                                        @"C:\app\jeremy.thomas\product\11.2.0\client_1\odt\vs2010\Oracle.VsDevTools.DLL"));

			//dialog.UnspecifiedDataSource.Providers.Add(SqlCe.SqlCeDataProvider);
			//dialog.UnspecifiedDataSource.Providers.Add(DataProvider.SqlDataProvider);
			//dialog.UnspecifiedDataSource.Providers.Add(DataProvider.OracleDataProvider);
			//dialog.UnspecifiedDataSource.Providers.Add(DataProvider.OleDBDataProvider);
			//dialog.UnspecifiedDataSource.Providers.Add(DataProvider.OdbcDataProvider);
			//dialog.DataSources.Add(dialog.UnspecifiedDataSource);
			dataSources = new Dictionary<string, DataSource>();
			dataProviders = new Dictionary<string, DataProvider>();
			foreach (var dataSource in dialog.DataSources)
			{
				dataSources.Add(dataSource.Name ?? dataSource.DisplayName, dataSource);
				foreach (var dataProvider in dataSource.Providers)
				{
					if (!dataProviders.ContainsKey(dataProvider.Name))
						dataProviders.Add(dataProvider.Name, dataProvider);
				}
			}
			//this.dataSources.Add(DataSource.SqlDataSource.Name, DataSource.SqlDataSource);
			//this.dataSources.Add(DataSource.SqlFileDataSource.Name, DataSource.SqlFileDataSource);
			//this.dataSources.Add(DataSource.OracleDataSource.Name, DataSource.OracleDataSource);
			//this.dataSources.Add(DataSource.AccessDataSource.Name, DataSource.AccessDataSource);
			//this.dataSources.Add(DataSource.OdbcDataSource.Name, DataSource.OdbcDataSource);
			//this.dataSources.Add(SqlCe.SqlCeDataSource.Name, SqlCe.SqlCeDataSource);
			//this.dataSources.Add(dialog.UnspecifiedDataSource.DisplayName, dialog.UnspecifiedDataSource);


			//this.dataProviders.Add(DataProvider.SqlDataProvider.Name, DataProvider.SqlDataProvider);
			//this.dataProviders.Add(DataProvider.OracleDataProvider.Name, DataProvider.OracleDataProvider);
			//this.dataProviders.Add(DataProvider.OleDBDataProvider.Name, DataProvider.OleDBDataProvider);
			//this.dataProviders.Add(DataProvider.OdbcDataProvider.Name, DataProvider.OdbcDataProvider);
			//this.dataProviders.Add(SqlCe.SqlCeDataProvider.Name, SqlCe.SqlCeDataProvider);


			DataSource ds = null;
			var dsName = GetSelectedSource();
			if (!String.IsNullOrEmpty(dsName) && dataSources.TryGetValue(dsName, out ds))
			{
				dialog.SelectedDataSource = ds;
			}

			DataProvider dp = null;
			var dpName = GetSelectedProvider();
			if (!String.IsNullOrEmpty(dpName) && dataProviders.TryGetValue(dpName, out dp))
			{
				dialog.SelectedDataProvider = dp;
			}
		}

		private static void AddDataSources(DataConnectionDialog dialog, DataSource dataSource)
		{
			if (dataSource != null)
			{
				var existing = dialog.DataSources.FirstOrDefault(ds => ds.DisplayName == dataSource.DisplayName);
				if (existing == null)
				{
					dialog.DataSources.Add(dataSource);
					foreach (var dataProvider in dataSource.Providers)
					{
						dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
					}
				}
				else
				{
					foreach (var dataProvider in dataSource.Providers)
					{
						existing.Providers.Add(dataProvider);
						dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
					}
				}
			}
		}

		public void SaveConfiguration(DataConnectionDialog dcd)
		{
			if (dcd.SaveSelection)
			{
				var ds = dcd.SelectedDataSource;
				if (ds != null)
				{
					SaveSelectedSource(ds == dcd.UnspecifiedDataSource ? ds.DisplayName : ds.Name);
				}
				var dp = dcd.SelectedDataProvider;
				if (dp != null)
				{
					SaveSelectedProvider(dp.Name);
				}

				xDoc.Save(fullFilePath);
			}
		}

		public string GetSelectedSource()
		{
			try
			{
				var xElem = RootElement.Element("DataSourceSelection");
				var sourceElem = xElem.Element("SelectedSource");
				if (sourceElem != null)
				{
					return sourceElem.Value;
				}
			}
			catch
			{
				return null;
			}
			return null;
		}

		public string GetSelectedProvider()
		{
			try
			{
				var xElem = RootElement.Element("DataSourceSelection");
				var providerElem = xElem.Element("SelectedProvider");
				if (providerElem != null)
				{
					return providerElem.Value;
				}
			}
			catch
			{
				return null;
			}
			return null;
		}

		public void SaveSelectedSource(string source)
		{
			if (!String.IsNullOrEmpty(source))
			{
				try
				{
					var xElem = RootElement.Element("DataSourceSelection");
					var sourceElem = xElem.Element("SelectedSource");
					if (sourceElem != null)
					{
						sourceElem.Value = source;
					}
					else
					{
						xElem.Add(new XElement("SelectedSource", source));
					}
				}
				catch
				{
				}
			}
		}

		public void SaveSelectedProvider(string provider)
		{
			if (!String.IsNullOrEmpty(provider))
			{
				try
				{
					var xElem = RootElement.Element("DataSourceSelection");
					var sourceElem = xElem.Element("SelectedProvider");
					if (sourceElem != null)
					{
						sourceElem.Value = provider;
					}
					else
					{
						xElem.Add(new XElement("SelectedProvider", provider));
					}
				}
				catch
				{
				}
			}
		}

		//SQLite Data Provider .Net Framework Data Provider for SQLite System.Data.SQLite 
		private DataSource CreateSQLiteDataSource()
		{
			return CreateDataSource("System.Data.SQLite", ".NET Framework Data Provider for SQLite", "SQLite Database File",
			                        ".NET Framework Data Provider for SQLite", @"C:\Program Files (x86)\SQLite.NET\bin\Designer\SQLite.Designer.DLL");
		}

		private DataSource CreateDataSource(string providerInvariantName, string displayName, string shortDisplayName,
		                                    string description, string designerAssemblyPath)
		{
			try
			{
				//var currentDomain = AppDomain.CurrentDomain;
				//	currentDomain.CreateInstance("SQLite.Designer.DLL", "SQLiteConnectionUIControl");

				var sqLiteDesigner = Assembly.LoadFrom(designerAssemblyPath);
				if (sqLiteDesigner != null)
				{
					var types = sqLiteDesigner.GetTypes();

					var dataConnectionUIControlType = types.FilterByImplements("IDataConnectionUIControl").FirstOrDefault()
					                                  ?? sqLiteDesigner.GetType("SQLite.Designer.SQLiteConnectionUIControl");
					var typeSqLiteConnectionProperties = sqLiteDesigner.GetType("SQLite.Designer.SQLiteConnectionProperties");

					var assignable = types.FilterByImplements("IDataConnectionProperties").FirstOrDefault() ?? typeSqLiteConnectionProperties;

				var dbProviderFactory = DbProviderFactories.GetFactory(providerInvariantName);
				var dbConnection = dbProviderFactory.CreateConnection();
					var dataSource2 = CreateDataSource(providerInvariantName, displayName, shortDisplayName,
					                                   description, dbConnection.GetType(),
					                                   assignable, dataConnectionUIControlType);
					return dataSource2;
				}
			}
			catch (Exception e)
			{
				GeneralHelper.TraceOut(e.Message);
				return null;
			}
			return null;
		}

		private static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
		{
			var shortAssemblyName = new AssemblyName(args.Name).Name;
			if (shortAssemblyName.Contains("SQLite"))
				return Assembly.LoadFrom(@"C:\Program Files (x86)\SQLite.NET\bin\Designer\" + shortAssemblyName);
			if (args.Name.Contains("9.0"))
				return Assembly.LoadFrom(@"C:\Program Files (x86)\Microsoft Visual Studio 9.0\Common7\IDE\Microsoft.VisualStudio.Data.dll");
			if (args.Name.Contains(".resources"))
				return null;
			return Assembly.LoadFrom(@"C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\" + shortAssemblyName);
			;
		}

		public static DataSource CreateDataSource(string name, string displayName, string shortDisplayName,
		                                          string description, Type targetConnectionType,
		                                          Type connectionPropertiesType, Type dataConnectionUIControlType)
		{
			var dataSource = new DataSource(name, description);
			dataSource.Providers.Add(CreateDataProvider(name, displayName, shortDisplayName, description,
			                                            targetConnectionType, connectionPropertiesType, dataConnectionUIControlType));
			return dataSource;
		}

		private static DataProvider CreateDataProvider(string name, string displayName, string shortDisplayName, string description,
		                                               Type targetConnectionType, Type connectionPropertiesType, Type dataConnectionUIControlType)
		{
			var descriptions = new Dictionary<string, string> {{name, description}};

			var uiControls = new Dictionary<string, Type> {{String.Empty, dataConnectionUIControlType}};

			return new DataProvider(
				name,
				displayName,
				shortDisplayName,
				description,
				targetConnectionType,
				descriptions,
				uiControls,
				connectionPropertiesType);
		}
	}
}