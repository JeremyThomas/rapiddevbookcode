using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Linq;
using ADODB;
using AW.Helper;
using AW.LLBLGen.DataContextDriver.Properties;
using AW.Winforms.Helpers;
using LINQPad.Extensibility.DataContext;
using LINQPad.Extensibility.DataContext.UI;
using Microsoft.Win32;
using MSDASC;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// 	Interaction logic for ConnectionDialog.xaml
	/// </summary>
	public partial class ConnectionDialog
	{
		/// <summary>
		/// AdapterType
		/// </summary>
		public const string ElementNameAdaptertype = "AdapterType";

		public const string ElementNameAdapterAssembly = "AdapterAssembly";

		/// <summary>
		/// AdditionalAssemblies
		/// </summary>
		public const string ElementNameAdditionalassemblies = "AdditionalAssemblies";

		public const string ElementNameConnectionType = "ConnectionType";
		public const string ElementNameFactoryMethod = "FactoryMethod";
		public const string ElementNameFactoryType = "FactoryType";
		public const string ElementNameFactoryAssembly = "FactoryAssembly";


		private readonly IConnectionInfo _cxInfo;

		public ConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			_cxInfo = cxInfo;
			DataContext = cxInfo;
			InitializeComponent();
			if (isNewConnection)
			{
				CreateDriverDataElements(cxInfo);

				_cxInfo.AppConfigPath = Settings.Default.DefaultApplicationConfig;
				_cxInfo.DatabaseInfo.CustomCxString = Settings.Default.DefaultDatabaseConnection;
				_cxInfo.CustomTypeInfo.CustomAssemblyPath = Settings.Default.DefaultLinqMetaDataAssembly;
				_cxInfo.CustomTypeInfo.CustomTypeName = Settings.Default.DefaultLinqMetaData;
				_cxInfo.DisplayName = Settings.Default.DefaultDisplayName;
			}
			else
			{
				UpGradeDriverDataElements(cxInfo);
			}
//      var factoryClasses = DbProviderFactories.GetFactoryClasses().Rows
//.OfType<DataRow>()
//.Select(r => r["InvariantName"])
//.ToArray();
//      foreach (var item in factoryClasses)
//      {
//        comboBoxDatabaseProvider.Items.Add(item);
//      }
		}

		private static void CreateDriverDataElements(IConnectionInfo cxInfo)
		{
			CreateElementIfNeeded(cxInfo, ElementNameAdaptertype, Settings.Default.DefaultAdapterType);
			CreateElementIfNeeded(cxInfo, ElementNameAdapterAssembly, Settings.Default.DefaultAdapterAssembly);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryMethod, Settings.Default.DefaultDataAccessAdapterFactoryMethod);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryType, Settings.Default.DefaultDataAccessAdapterFactoryType);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryAssembly, Settings.Default.DefaultDataAccessAdapterFactoryAssembly);
			CreateElementIfNeeded(cxInfo, ElementNameConnectionType, Settings.Default.DefaultConnectionType.ToString());
			//CreateElementIfNeeded(cxInfo, ElementNameAdaptertype, Settings.Default.DefaultDataAccessAdapterFactoryType);
		}

		public static void UpGradeDriverDataElements(IConnectionInfo cxInfo)
		{
			CreateElementIfNeeded(cxInfo, ElementNameAdaptertype, null);
			CreateElementIfNeeded(cxInfo, ElementNameAdapterAssembly, cxInfo.CustomTypeInfo.CustomMetadataPath);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryMethod, cxInfo.DatabaseInfo.Provider);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryType, cxInfo.DatabaseInfo.DbVersion);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryAssembly, cxInfo.CustomTypeInfo.CustomMetadataPath);
			CreateElementIfNeeded(cxInfo, ElementNameConnectionType, null);
			cxInfo.CustomTypeInfo.CustomMetadataPath = null;
			cxInfo.DatabaseInfo.Provider = null;
			cxInfo.DatabaseInfo.DbVersion = null;
		}

		private static void CreateElementIfNeeded(IConnectionInfo cxInfo, string elementName, string defaultValue)
		{
			if (cxInfo.DriverData.Element(elementName) == null)
			{
				var xElement = new XElement(elementName);
				if (defaultValue != null)
					xElement.Value = defaultValue;
				cxInfo.DriverData.Add(xElement);
			}
		}

		public static string GetDriverDataValue(IConnectionInfo cxInfo, string elementName)
		{
			var xElement = cxInfo.DriverData.Element(elementName);
			if (xElement != null) return xElement.Value;
			return null;
		}

		public string GetDriverDataValue(string elementName)
		{
			return GetDriverDataValue(_cxInfo, elementName);
		}

		protected override void OnSourceInitialized(EventArgs e)
		{
			base.OnSourceInitialized(e);
			this.SetPlacement(Settings.Default.ConnectionDialogPlacement);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			base.OnSourceInitialized(e);
			this.SetPlacement(Settings.Default.ConnectionDialogPlacement);
			//System.Windows.Data.CollectionViewSource iConnectionInfoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iConnectionInfoViewSource")));
			// Load data by setting the CollectionViewSource.Source property:
			// iConnectionInfoViewSource.Source = [generic data source]
		}

		private void btnSaveDefault_Click(object sender, RoutedEventArgs e)
		{
			Settings.Default.DefaultDataAccessAdapterFactoryMethod = GetDriverDataValue(ElementNameFactoryMethod);
			Settings.Default.DefaultDataAccessAdapterFactoryType = GetDriverDataValue(ElementNameFactoryType);
			Settings.Default.DefaultDataAccessAdapterFactoryAssembly = GetDriverDataValue(ElementNameFactoryAssembly);

			Settings.Default.DefaultApplicationConfig = _cxInfo.AppConfigPath;
			Settings.Default.DefaultDatabaseConnection = _cxInfo.DatabaseInfo.CustomCxString;
			Settings.Default.DefaultLinqMetaDataAssembly = _cxInfo.CustomTypeInfo.CustomAssemblyPath;
			Settings.Default.DefaultLinqMetaData = _cxInfo.CustomTypeInfo.CustomTypeName;

			Settings.Default.DefaultDisplayName = _cxInfo.DisplayName;

			Settings.Default.DefaultAdapterType = GetDriverDataValue(ElementNameAdaptertype);
			Settings.Default.DefaultAdapterAssembly = GetDriverDataValue(ElementNameAdaptertype);
			int connectionTypeIndex;
			if (int.TryParse(GetDriverDataValue(ElementNameConnectionType), out connectionTypeIndex))
				Settings.Default.DefaultConnectionType = connectionTypeIndex;

			Settings.Default.Save();
		}

		private void Window_Closing(object sender, CancelEventArgs e)
		{
			Settings.Default.ConnectionDialogPlacement = this.GetPlacement();
			Settings.Default.Save();
		}

		private void btnOK_Click(object sender, RoutedEventArgs e)
		{
			_cxInfo.DatabaseInfo.CustomCxString = textBoxDatabaseConnectionString.Text;
			DialogResult = true;
		}

		private void BrowseAssembly(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = "Choose LLBL entity assembly",
			             		DefaultExt = ".dll",
			             	};

			if (dialog.ShowDialog() == true)
			{
				_cxInfo.CustomTypeInfo.CustomAssemblyPath = dialog.FileName;
				string[] customTypes;
				try
				{
					customTypes = _cxInfo.CustomTypeInfo.GetCustomTypesInAssembly("SD.LLBLGen.Pro.LinqSupportClasses.ILinqMetaData");

					if (customTypes.Length == 1)
						_cxInfo.CustomTypeInfo.CustomTypeName = customTypes[0];
				}
				catch (Exception)
				{
					Debugger.Break();
					return;
				}
			}
		}

		private void BrowseDataAccessAdapterAssembly(object sender, RoutedEventArgs e)
		{
			var hl = sender as Hyperlink;
			if (hl != null)
			{
				var element = _cxInfo.DriverData.Element(hl.TargetName);
				if (element != null)
				{
					var dialog = new OpenFileDialog
					             	{
					             		Title = "Choose Data Access Adapter assembly",
					             		DefaultExt = ".dll",
					             		FileName = element.Value
					             	};

					if (dialog.ShowDialog() == true)
					{
						element.Value = dialog.FileName;
						//var dataAccessAdapterAssembly  = Assembly.ReflectionOnlyLoadFrom(_cxInfo.CustomTypeInfo.CustomMetadataPath);
						var dataAccessAdapterAssembly = Assembly.LoadFrom(dialog.FileName);
						try
						{
							var customTypes = GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly);
							if (customTypes.Count() == 1)
								_cxInfo.DriverData.SetElementValue(hl.TargetName.Replace("Assembly", "Type"), customTypes.First());
						}
						catch (Exception)
						{
							Debugger.Break();
							return;
						}
					}
				}
			}
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(Assembly dataAccessAdapterAssembly)
		{
			return GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly.GetTypes());
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(IEnumerable<Type> types)
		{
			return types.Where(t => typeof (IDataAccessAdapter).IsAssignableFrom(t) && t.IsClass).Select(t => t.FullName);
		}

		private static string[] GetDataAccessAdapterTypeNamesBothWays(IEnumerable<Type> types)
		{
			var customTypes = GetDataAccessAdapterTypeNames(types).ToArray();
			if (customTypes.Length == 0)
				customTypes = GetDataAccessAdapterTypeNamesByName(types).ToArray();
			return customTypes;
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNamesByName(IEnumerable<Type> types)
		{
			return types.Where(t => t.Name.Contains("DataAccessAdapter") && t.IsClass).Select(t => t.FullName);
		}

		private void BrowseAppConfig(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = "Choose application config file",
			             		DefaultExt = ".config",
			             	};

			if (dialog.ShowDialog() == true)
				_cxInfo.AppConfigPath = dialog.FileName;
		}

		private void ChooseType(object sender, RoutedEventArgs e)
		{
			var assemPath = _cxInfo.CustomTypeInfo.CustomAssemblyPath;
			if (assemPath.Length == 0)
			{
				MessageBox.Show("First enter a path to an assembly.");
				return;
			}

			if (!File.Exists(assemPath))
			{
				MessageBox.Show("File '" + assemPath + "' does not exist.");
				return;
			}

			string[] customTypes;
			try
			{
				customTypes = _cxInfo.CustomTypeInfo.GetCustomTypesInAssembly("SD.LLBLGen.Pro.LinqSupportClasses.ILinqMetaData");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error obtaining custom types: " + ex.Message);
				Debugger.Break();
				return;
			}
			if (customTypes.Length == 0)
			{
				MessageBox.Show("There are no public types in that assembly that implement ILinqMetaData.");
				Debugger.Break();
				return;
			}
			if (customTypes.Length == 1)
			{
				_cxInfo.CustomTypeInfo.CustomTypeName = customTypes[0];
				return;
			}

			var result = (string) Dialogs.PickFromList("Choose Custom Type", customTypes);
			if (result != null) _cxInfo.CustomTypeInfo.CustomTypeName = result;
		}

		private void ChooseAdapter(object sender, RoutedEventArgs e)
		{
			var hl = sender as Hyperlink;
			if (hl != null)
			{
				var assemPath = GetDriverDataValue(hl.TargetName.Replace("Type", "Assembly"));
				if (assemPath.Length == 0)
				{
					MessageBox.Show("First enter a path to an assembly.");
					return;
				}

				if (!File.Exists(assemPath))
				{
					MessageBox.Show("File '" + assemPath + "' does not exist.");
					return;
				}

				string[] customTypes;
				try
				{
					var dataAccessAdapterAssembly = Assembly.LoadFrom(assemPath);
					var types = dataAccessAdapterAssembly.GetTypes();
					if (hl.TargetName == ElementNameAdaptertype)
						customTypes = GetDataAccessAdapterTypeNamesBothWays(types);
					else
					{
						customTypes = types.Select(t => t.FullName).ToArray();
					}
				}
				catch (ReflectionTypeLoadException ex)
				{
					customTypes = GetDataAccessAdapterTypeNamesBothWays(ex.Types);
					if (customTypes.Length == 0)
					{
						MessageBox.Show("Error obtaining adapter types: " + ex.Message + Environment.NewLine +
						                ex.LoaderExceptions.Select(le => le.Message).JoinAsString(Environment.NewLine));
						Debugger.Break();
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error obtaining adapter types: " + ex.Message);
					Debugger.Break();
					return;
				}
				if (customTypes.Length == 0)
				{
					MessageBox.Show("There are no public types in that assembly that implement IDataAccessAdapter.");
					Debugger.Break();
					return;
				}
				if (customTypes.Length == 1)
					_cxInfo.DriverData.SetElementValue(hl.TargetName, customTypes.First());
				else
				{
					var result = (string) Dialogs.PickFromList("Choose " + hl.TargetName, customTypes);
					if (result != null)
						_cxInfo.DriverData.SetElementValue(hl.TargetName, result);
				}
			}
		}

		public static void AddAssembly(IConnectionInfo connectionInfo, string assemblyName)
		{
			if (string.IsNullOrEmpty(assemblyName))
				return;
			GeneralHelper.TraceOut(assemblyName);
			assemblyName = Path.GetFileName(assemblyName);
			if (connectionInfo.DriverData == null)
				return;
			var additionalAssembliesElement = connectionInfo.DriverData.Element(ElementNameAdditionalassemblies);
			if (additionalAssembliesElement == null)
			{
				additionalAssembliesElement = new XElement(ElementNameAdditionalassemblies);
				connectionInfo.DriverData.Add(additionalAssembliesElement);
			}

			var c = (from e in additionalAssembliesElement.Elements()
			         where e.Value == assemblyName
			         select e).Count();

			if (c == 0)
				additionalAssembliesElement.Add(new XElement("AssemblyName") {Value = assemblyName});
			connectionInfo.DatabaseInfo.Database = GetAdditionalAssemblies(additionalAssembliesElement);
		}

		private static string GetAdditionalAssemblies(XElement additionalAssembliesElement)
		{
			var y = from e in additionalAssembliesElement.Elements()
			        select e.Value;
			var additionalAssemblies = y.JoinAsString();
			return additionalAssemblies;
		}

		public static string GetAdditionalAssemblies(IConnectionInfo connectionInfo)
		{
			if (connectionInfo.DriverData == null)
				return null;
			var additionalAssembliesElement = connectionInfo.DriverData.Element(ElementNameAdditionalassemblies);
			if (additionalAssembliesElement == null)
				return null;
			return GetAdditionalAssemblies(additionalAssembliesElement);
		}

		private void ChooseAssemblies(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = "Choose extra assembly",
			             		DefaultExt = ".dll",
			             		Multiselect = true
			             	};

			if (dialog.ShowDialog() == true)
			{
				foreach (var fileName in dialog.FileNames)
				{
					AddAssembly(_cxInfo, fileName);
				}
			}
		}

		private void DataBaseConnectionDialog(object sender, RoutedEventArgs e)
		{
			var mydlg = new DataLinks();
			var adoType = Type.GetTypeFromProgID("ADODB.Connection");
			if (adoType == null)
			{
				//Cast the generic object that PromptNew returns to an ADODB._Connection.
				ProcessConnection((_Connection) mydlg.PromptNew());
			}
			else
			{
				var connection = (_Connection) Activator.CreateInstance(adoType);
				connection.ConnectionString = _cxInfo.DatabaseInfo.CustomCxString;
				if (mydlg.PromptEdit(connection))
					ProcessConnection(connection);
			}
		}

		private void ProcessConnection(_Connection connection)
		{
			var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder();
			oleDbConnectionStringBuilder.ConnectionString = connection.ConnectionString;
			if (oleDbConnectionStringBuilder.PersistSecurityInfo)
			{
				connection.Open("", "", "", 0);
				if (connection.State == 1)
				{
					_cxInfo.DatabaseInfo.CustomCxString = connection.ConnectionString;
					connection.Close();
					connection.Open();
				}
			}
			else
			{
				_cxInfo.DatabaseInfo.CustomCxString = connection.ConnectionString;
				connection.Open();
			}
		}
	}

	internal enum LLBLConnectionType
	{
		SelfServicing,
		Adapter,
		AdapterFactory
	}
}