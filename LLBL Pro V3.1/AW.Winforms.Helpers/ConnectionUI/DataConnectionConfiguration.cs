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
		/// <summary>
		/// DataConnection.xml
		/// </summary>
		private const string ConfigFileName = @"DataConnection.xml";

		/// <summary>
		/// DataSourceSelection
		/// </summary>
		private const string DatasourceSelectionElementName = "DataSourceSelection";

		/// <summary>
		/// SelectedSource
		/// </summary>
		private const string SelectedSourceElementName = "SelectedSource";

		/// <summary>
		/// SelectedProvider
		/// </summary>
		private const string SelectedProviderElementName = "SelectedProvider";

		private readonly string _fullFilePath;
		private readonly XDocument _xDoc;

		// Available data sources:
		private IDictionary<string, DataSource> _dataSources;

		// Available data providers: 
		private IDictionary<string, DataProvider> _dataProviders;

		//static DataConnectionConfiguration()
		//{
		//  AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;
		//}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="path">Configuration file path.</param>
		public DataConnectionConfiguration(string path)
		{
			_fullFilePath = !String.IsNullOrEmpty(path) ? Path.GetFullPath(Path.Combine(path, ConfigFileName)) : Path.Combine(Environment.CurrentDirectory, ConfigFileName);
			if (!String.IsNullOrEmpty(_fullFilePath) && File.Exists(_fullFilePath))
				_xDoc = XDocument.Load(_fullFilePath);
			else
			{
				_xDoc = new XDocument();
				_xDoc.Add(new XElement("ConnectionDialog", new XElement(DatasourceSelectionElementName)));
			}

			RootElement = _xDoc.Root;
		}

		public XElement RootElement { get; set; }

		public void LoadConfiguration(DataConnectionDialog dialog)
		{
			DataSource.AddStandardDataSources(dialog);
			AddDataSources(dialog, SqlCe.SqlCeDataSource);
			//AddDataSources(dialog, CreateSQLiteDataSource());
			////Oracle Data Provider for .NETOracle Data Provider for .NETOracle.DataAccess.Client

			//AddDataSources(dialog, CreateDataSource("Oracle.DataAccess.Client", "Oracle Data Provider for .NET", "Oracle Database",
			//                                        "Oracle Database",
			//                                        @"C:\app\jeremy.thomas\product\11.2.0\client_1\odt\vs2010\Oracle.VsDevTools.DLL"));

			_dataSources = new Dictionary<string, DataSource>();
			_dataProviders = new Dictionary<string, DataProvider>();
			foreach (var dataSource in dialog.DataSources)
			{
				_dataSources.Add(dataSource.Name ?? dataSource.DisplayName, dataSource);
				foreach (var dataProvider in dataSource.Providers)
				{
					if (!_dataProviders.ContainsKey(dataProvider.Name))
						_dataProviders.Add(dataProvider.Name, dataProvider);
				}
			}

			DataSource ds;
			var dsName = GetSelectedSource();
			if (!String.IsNullOrEmpty(dsName) && _dataSources.TryGetValue(dsName, out ds))
				dialog.SelectedDataSource = ds;

			DataProvider dp;
			var dpName = GetSelectedProvider();
			if (!String.IsNullOrEmpty(dpName) && _dataProviders.TryGetValue(dpName, out dp))
				dialog.SelectedDataProvider = dp;
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
						dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
				}
				else
					foreach (var dataProvider in dataSource.Providers)
					{
						existing.Providers.Add(dataProvider);
						dialog.UnspecifiedDataSource.Providers.Add(dataProvider);
					}
			}
		}

		public void SaveConfiguration(DataConnectionDialog dcd)
		{
			if (dcd.SaveSelection)
			{
				var ds = dcd.SelectedDataSource;
				if (ds != null)
					SaveSelectedSource(ds == dcd.UnspecifiedDataSource ? ds.DisplayName : ds.Name);
				var dp = dcd.SelectedDataProvider;
				if (dp != null)
					SaveSelectedProvider(dp.Name);
				_xDoc.Save(_fullFilePath);
			}
		}

		private XElement DataSourceSelectionElement
		{
			get
			{
				try
				{
					return RootElement.Element(DatasourceSelectionElementName);
				}
				catch
				{
					return null;
				}
			}
		}

		private string GetDataSourceSelectionElement(string elementName)
		{
			var xElem = DataSourceSelectionElement;
			if (xElem != null)
				try
				{
					var sourceElem = xElem.Element(elementName);
					if (sourceElem != null)
						return sourceElem.Value;
				}
				catch
				{
					return null;
				}
			return null;
		}

		public string GetSelectedSource()
		{
			return GetDataSourceSelectionElement(SelectedSourceElementName);
		}

		public string GetSelectedProvider()
		{
			return GetDataSourceSelectionElement(SelectedProviderElementName);
			;
		}

		public void SaveSelectedSource(string source)
		{
			if (!String.IsNullOrEmpty(source))
				try
				{
					var xElem = DataSourceSelectionElement;
					if (xElem != null)
					{
						var sourceElem = xElem.Element(SelectedSourceElementName);
						if (sourceElem != null)
							sourceElem.Value = source;
						else
							xElem.Add(new XElement(SelectedSourceElementName, source));
					}
				}
				catch
				{
				}
		}

		public void SaveSelectedProvider(string provider)
		{
			if (!String.IsNullOrEmpty(provider))
				try
				{
					var xElem = DataSourceSelectionElement;
					var sourceElem = xElem.Element(SelectedProviderElementName);
					if (sourceElem != null)
						sourceElem.Value = provider;
					else
						xElem.Add(new XElement(SelectedProviderElementName, provider));
				}
				catch
				{
				}
		}

		//SQLite Data Provider .Net Framework Data Provider for SQLite System.Data.SQLite 
		private DataSource CreateSQLiteDataSource()
		{
			return CreateDataSource("System.Data.SQLite", ".NET Framework Data Provider for SQLite", "SQLite Database File",
			                        ".NET Framework Data Provider for SQLite", @"C:\Program Files (x86)\SQLite.NET\bin\Designer\SQLite.Designer.DLL");
		}

		private static DataSource CreateDataSource(string providerInvariantName, string displayName, string shortDisplayName,
		                                           string description, string designerAssemblyPath)
		{
			try
			{
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