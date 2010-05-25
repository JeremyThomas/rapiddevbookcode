using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Xml.Linq;
using AW.Helper;
using LINQPad.Extensibility.DataContext;
using LINQPad.Extensibility.DataContext.UI;
using Microsoft.Win32;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// 	Interaction logic for ConnectionDialog.xaml
	/// </summary>
	public partial class ConnectionDialog
	{
		private readonly IConnectionInfo _cxInfo;

		public ConnectionDialog(IConnectionInfo cxInfo)
		{
			_cxInfo = cxInfo;
			DataContext = cxInfo;
			InitializeComponent();
//      var factoryClasses = DbProviderFactories.GetFactoryClasses().Rows
//.OfType<DataRow>()
//.Select(r => r["InvariantName"])
//.ToArray();
//      foreach (var item in factoryClasses)
//      {
//        comboBoxDatabaseProvider.Items.Add(item);
//      }

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
					System.Diagnostics.Debugger.Break();
					return;
				}
			}
		}

		private void BrowseDataAccessAdapterAssembly(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			{
				Title = "Choose Data Access Adapter assembly",
				DefaultExt = ".dll",
			};

			if (dialog.ShowDialog() == true)
			{
				_cxInfo.CustomTypeInfo.CustomMetadataPath = dialog.FileName;
				//var dataAccessAdapterAssembly  = Assembly.ReflectionOnlyLoadFrom(_cxInfo.CustomTypeInfo.CustomMetadataPath);
				var dataAccessAdapterAssembly = Assembly.LoadFrom(_cxInfo.CustomTypeInfo.CustomMetadataPath);
				try
				{
					var customTypes = GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly);
					if (customTypes.Count() == 1)
						AdapterType = customTypes.First();
				}
				catch (Exception)
				{
					System.Diagnostics.Debugger.Break();
					return;
				}
			}
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(Assembly dataAccessAdapterAssembly)
		{
			return GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly.GetTypes());
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(IEnumerable<Type> types)
		{
			return types.Where(t => typeof(IDataAccessAdapter).IsAssignableFrom(t) && t.IsClass).Select(t => t.FullName);
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
			return types.Where(t => t.Name.Contains("DataAccessAdapter")).Select(t => t.FullName);
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
				System.Diagnostics.Debugger.Break();
				return;
			}
			if (customTypes.Length == 0)
			{
				MessageBox.Show("There are no public types in that assembly."); // based on.........
				System.Diagnostics.Debugger.Break();
				return;
			}
			if (customTypes.Length == 1)
			{
				_cxInfo.CustomTypeInfo.CustomTypeName = customTypes[0];
				return;
			}

			var result = (string)Dialogs.PickFromList("Choose Custom Type", customTypes);
			if (result != null) _cxInfo.CustomTypeInfo.CustomTypeName = result;
		}

		private void ChooseAdapter(object sender, RoutedEventArgs e)
		{
			var assemPath = _cxInfo.CustomTypeInfo.CustomMetadataPath;
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
				var dataAccessAdapterAssembly = Assembly.LoadFrom(_cxInfo.CustomTypeInfo.CustomMetadataPath);
				var types = dataAccessAdapterAssembly.GetTypes();
				customTypes = GetDataAccessAdapterTypeNamesBothWays(types);
			}
			catch (ReflectionTypeLoadException ex)
			{
				customTypes = GetDataAccessAdapterTypeNamesBothWays(ex.Types);
				if (customTypes.Length == 0)
				{
					MessageBox.Show("Error obtaining adapter types: " + ex.Message + Environment.NewLine +
					                ex.LoaderExceptions.Select(le => le.Message).JoinAsString(Environment.NewLine));
					System.Diagnostics.Debugger.Break();
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error obtaining adapter types: " + ex.Message);
				System.Diagnostics.Debugger.Break();
				return;
			}
			if (customTypes.Length == 0)
			{
				MessageBox.Show("There are no public types in that assembly that implement IDataAccessAdapter.");
				System.Diagnostics.Debugger.Break();
				return;
			}

			if (customTypes.Length == 1)
				AdapterType = customTypes.First();
			else
			{
				var result = (string)Dialogs.PickFromList("Choose adapter Type", customTypes);
				if (result != null)
					AdapterType = result;
			}
		}

		public string AdapterType
		{
			get
			{
				return GetAdapterType(_cxInfo);
			}
			set { SetAdapterType(_cxInfo, value); }
		}

		public static string GetAdapterType(IConnectionInfo connectionInfo)
		{
			if (connectionInfo.DriverData == null)
				return null;
			var adapterType = connectionInfo.DriverData.Element("AdapterType");
			return adapterType == null ? null : adapterType.Value;
		}

		public static void SetAdapterType(IConnectionInfo connectionInfo, string adapterType)
		{
			if (string.IsNullOrEmpty(adapterType))
				return;
			GeneralHelper.TraceOut(adapterType);
			if (connectionInfo.DriverData == null)
				return;
			var adapterTypeElement = connectionInfo.DriverData.Element("AdapterType");
			if (adapterTypeElement == null)
				connectionInfo.DriverData.Add(new XElement("AdapterType") { Value = adapterType });
			else
			{
				adapterTypeElement.Value = adapterType;
			}
			connectionInfo.DatabaseInfo.DbVersion = adapterType;
		}


		public static void AddAssembly(IConnectionInfo connectionInfo, string assemblyName)
		{
			if (string.IsNullOrEmpty(assemblyName))
				return;
			GeneralHelper.TraceOut(assemblyName);
			assemblyName = Path.GetFileName(assemblyName);
			if (connectionInfo.DriverData == null)
				return;
			var additionalAssembliesElement = connectionInfo.DriverData.Element("AdditionalAssemblies");
			if (additionalAssembliesElement == null)
			{
				additionalAssembliesElement = new XElement("AdditionalAssemblies");
				connectionInfo.DriverData.Add(additionalAssembliesElement);
			}

			var c = (from e in additionalAssembliesElement.Elements()
							 where e.Value == assemblyName
							 select e).Count();

			if (c == 0)
				additionalAssembliesElement.Add(new XElement("AssemblyName") { Value = assemblyName });
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
			var additionalAssembliesElement = connectionInfo.DriverData.Element("AdditionalAssemblies");
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

	}
}