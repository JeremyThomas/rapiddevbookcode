using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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
	public partial class ConnectionDialog : INotifyPropertyChanged
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
		public const string ElementNameUseFields = "UseFields";

		public IConnectionInfo CxInfo { get; private set; }

		public ConnectionDialog()
		{
			InitializeComponent();
		}

		public ConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			CxInfo = cxInfo;
			var factoryClasses = DbProviderFactories.GetFactoryClasses().Rows.OfType<DataRow>().Select(r => r["InvariantName"]).Cast<string>();
			DbProviderFactoryNames = factoryClasses.ToList();
			AdditionalNamespaces = Settings.Default.AdditionalNamespaces.CreateStringWrapperForBinding();
			if (isNewConnection)
			{
				CreateDriverDataElements(cxInfo);

				CxInfo.AppConfigPath = Settings.Default.DefaultApplicationConfig;
				CxInfo.DatabaseInfo.CustomCxString = Settings.Default.DefaultDatabaseConnection;
				CxInfo.CustomTypeInfo.CustomAssemblyPath = Settings.Default.DefaultLinqMetaDataAssembly;
				CxInfo.CustomTypeInfo.CustomTypeName = Settings.Default.DefaultLinqMetaData;
				CxInfo.DisplayName = Settings.Default.DefaultDisplayName;
			}
			else
			{
				UpGradeDriverDataElements(cxInfo);
			}
			DataContext = this;
			InitializeComponent();
		//	providerComboBox.DataContext = this;
		//	comboBoxConnectionType.DataContext = this;
		//	txtTypeName.DataContext = this;
		//	DockPanelTypeName.DataContext = this;
			//AdditionalAssembliesDataGrid.DataContext = this;
			//AdditionalNamespacesDataGrid.DataContext = this;
		}

		/// <summary>
		/// Gets the CustomTypeNameVisibility.
		/// </summary>
		/// <value>The CustomTypeNameVisibility.</value>
		public Visibility CustomTypeNameVisibility
		{
			get { return string.IsNullOrEmpty(txtAssemblyPath.Text) ? Visibility.Collapsed : Visibility.Visible; }
		}

		/// <summary>
		/// Gets the ConnectionTypeVisibility.
		/// </summary>
		/// <value>The ConnectionTypeVisibility.</value>
		public Visibility ConnectionTypeVisibility
		{
			get
			{
				return AdapterConnectionTypes.Contains(LLBLConnectionType) ? Visibility.Visible : Visibility.Collapsed;
			}
		}

		public LLBLConnectionType LLBLConnectionType
		{
			get
			{
				if (string.IsNullOrEmpty(CxInfo.CustomTypeInfo.CustomTypeName))
					return LLBLConnectionType = LLBLConnectionType.Unknown;
				int connectionTypeIndex;
				if (int.TryParse(GetDriverDataValue(ElementNameConnectionType), out connectionTypeIndex))
					return (LLBLConnectionType) connectionTypeIndex;
				return LLBLConnectionType.Unknown;
			}
			set
			{
				var connectionType = ((int) value).ToString();
				if (connectionType != GetDriverDataValue(ElementNameConnectionType))
				{
					SetDriverDataValue(ElementNameConnectionType, connectionType);
					OnPropertyChanged("LLBLConnectionType");
				}
			}
		}

		public IEnumerable<string> DbProviderFactoryNames { get; set; }

		public List<ValueTypeWrapper<string>> AdditionalNamespaces { get; set; }

		private List<ValueTypeWrapper<string>> _additionalAssemblies;
		private static readonly LLBLConnectionType[] AdapterConnectionTypes = new[] { LLBLConnectionType.Adapter, LLBLConnectionType.AdapterFactory };

		public List<ValueTypeWrapper<string>> AdditionalAssemblies
		{
			get { return _additionalAssemblies ?? (_additionalAssemblies = Settings.Default.AdditionalAssemblies.CreateStringWrapperForBinding()); }
		}

		private static void CreateDriverDataElements(IConnectionInfo cxInfo)
		{
			CreateElementIfNeeded(cxInfo, ElementNameAdaptertype, Settings.Default.DefaultAdapterType);
			CreateElementIfNeeded(cxInfo, ElementNameAdapterAssembly, Settings.Default.DefaultAdapterAssembly);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryMethod, Settings.Default.DefaultDataAccessAdapterFactoryMethod);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryType, Settings.Default.DefaultDataAccessAdapterFactoryType);
			CreateElementIfNeeded(cxInfo, ElementNameFactoryAssembly, Settings.Default.DefaultDataAccessAdapterFactoryAssembly);
			CreateElementIfNeeded(cxInfo, ElementNameConnectionType, Settings.Default.DefaultConnectionType.ToString());
			CreateElementIfNeeded(cxInfo, ElementNameUseFields, true.ToString());
		}

		public static void UpGradeDriverDataElements(IConnectionInfo cxInfo)
		{
			var adaptertypeName = GetDriverDataValue(cxInfo, ElementNameAdaptertype);
			if (string.IsNullOrEmpty(adaptertypeName))
				CreateElementIfNeeded(cxInfo, ElementNameConnectionType, ((int) LLBLConnectionType.SelfServicing).ToString());
			else if (adaptertypeName == cxInfo.DatabaseInfo.DbVersion)
			{
				CreateElementIfNeeded(cxInfo, ElementNameFactoryMethod, cxInfo.DatabaseInfo.Provider);
				CreateElementIfNeeded(cxInfo, ElementNameFactoryType, cxInfo.DatabaseInfo.DbVersion);
				CreateElementIfNeeded(cxInfo, ElementNameFactoryAssembly, cxInfo.CustomTypeInfo.CustomMetadataPath);
				CreateElementIfNeeded(cxInfo, ElementNameConnectionType, ((int) LLBLConnectionType.AdapterFactory).ToString());
				cxInfo.DatabaseInfo.Provider = null;
				cxInfo.DatabaseInfo.DbVersion = null;
				cxInfo.DriverData.Element(ElementNameAdaptertype).Value = string.Empty;
			}
			else
			{
				CreateElementIfNeeded(cxInfo, ElementNameAdaptertype, null);
				CreateElementIfNeeded(cxInfo, ElementNameAdapterAssembly, cxInfo.CustomTypeInfo.CustomMetadataPath);
				CreateElementIfNeeded(cxInfo, ElementNameConnectionType, ((int) LLBLConnectionType.Adapter).ToString());
			}
			CreateElementIfNeeded(cxInfo, ElementNameUseFields, true.ToString());
			cxInfo.CustomTypeInfo.CustomMetadataPath = null;
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

		public void SetDriverDataValue(string elementName, string value)
		{
			CreateElementIfNeeded(CxInfo, elementName, null);
// ReSharper disable PossibleNullReferenceException
			CxInfo.DriverData.Element(elementName).Value = value;
// ReSharper restore PossibleNullReferenceException
		}

		public static string GetDriverDataValue(IConnectionInfo cxInfo, string elementName)
		{
			var xElement = cxInfo.DriverData.Element(elementName);
			return xElement != null ? xElement.Value : null;
		}

		public string GetDriverDataValue(string elementName)
		{
			return GetDriverDataValue(CxInfo, elementName);
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
			var settingsViewSource = ((CollectionViewSource) (FindResource("settingsViewSource")));
			settingsViewSource.Source = new List<Settings> {Settings.Default};
		}

		private void btnSaveDefault_Click(object sender, RoutedEventArgs e)
		{
			Settings.Default.DefaultDataAccessAdapterFactoryMethod = GetDriverDataValue(ElementNameFactoryMethod);
			Settings.Default.DefaultDataAccessAdapterFactoryType = GetDriverDataValue(ElementNameFactoryType);
			Settings.Default.DefaultDataAccessAdapterFactoryAssembly = GetDriverDataValue(ElementNameFactoryAssembly);

			Settings.Default.DefaultApplicationConfig = CxInfo.AppConfigPath;
			Settings.Default.DefaultDatabaseConnection = CxInfo.DatabaseInfo.CustomCxString;
			Settings.Default.DefaultLinqMetaDataAssembly = CxInfo.CustomTypeInfo.CustomAssemblyPath;
			Settings.Default.DefaultLinqMetaData = CxInfo.CustomTypeInfo.CustomTypeName;

			Settings.Default.DefaultDisplayName = CxInfo.DisplayName;

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
			if (AdditionalAssemblies != null)
			{
				Settings.Default.AdditionalAssemblies = new StringCollection();
				Settings.Default.AdditionalAssemblies.AddRange(AdditionalAssemblies.UnWrap().ToArray());
			}
			if (AdditionalNamespaces != null)
			{
				Settings.Default.AdditionalNamespaces = new StringCollection();
				Settings.Default.AdditionalNamespaces.AddRange(AdditionalNamespaces.UnWrap().ToArray());
			}

			DialogResult = true;
		}

		private void BrowseAssembly(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = "Choose LLBL entity assembly",
			             		DefaultExt = ".dll",
			             		FileName = CxInfo.CustomTypeInfo.CustomAssemblyPath
			             	};

			if (dialog.ShowDialog() == true)
			{
				CxInfo.CustomTypeInfo.CustomAssemblyPath = dialog.FileName;
				var customTypes = GetLinqMetaDataTypes();

				if (customTypes.Length == 1)
				{
					SetCustomTypeName(customTypes[0]);
				}
			}
		}

		private void SetCustomTypeName(string customType)
		{
			CxInfo.CustomTypeInfo.CustomTypeName = customType;
			var selfServicingEntities = CxInfo.CustomTypeInfo.GetCustomTypesInAssembly("SD.LLBLGen.Pro.ORMSupportClasses.EntityBase");
			LLBLConnectionType = selfServicingEntities.IsNullOrEmpty() ? LLBLConnectionType.Adapter : LLBLConnectionType.SelfServicing;
			OnPropertyChanged("ConnectionTypeVisibility");
		}

		private void ChooseType(object sender, RoutedEventArgs e)
		{
			var customTypes = GetLinqMetaDataTypes();
			if (customTypes.Length == 1)
			{
				SetCustomTypeName(customTypes[0]);
				return;
			}

			var result = (string) Dialogs.PickFromList("Choose Custom Type", customTypes);
			if (result != null)
				SetCustomTypeName(CxInfo.CustomTypeInfo.CustomTypeName);
		}

		private string[] GetLinqMetaDataTypes()
		{
			var assemPath = CxInfo.CustomTypeInfo.CustomAssemblyPath;
			if (assemPath.Length == 0)
			{
				MessageBox.Show("First enter a path to an assembly.");
				return null;
			}

			if (!File.Exists(assemPath))
			{
				MessageBox.Show("File '" + assemPath + "' does not exist.");
				return null;
			}

			string[] customTypes;
			try
			{
				customTypes = CxInfo.CustomTypeInfo.GetCustomTypesInAssembly("SD.LLBLGen.Pro.LinqSupportClasses.ILinqMetaData");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error obtaining custom types: " + ex.Message);
				Debugger.Break();
				return null;
			}
			if (customTypes.Length == 0)
			{
				MessageBox.Show("There are no public types in that assembly that implement ILinqMetaData.");
				Debugger.Break();
				return customTypes;
			}
			return customTypes;
		}

		private void BrowseDataAccessAdapterAssembly(object sender, RoutedEventArgs e)
		{
			var hl = sender as Hyperlink;
			if (hl != null)
			{
				var element = CxInfo.DriverData.Element(hl.TargetName);
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
								CxInfo.DriverData.SetElementValue(hl.TargetName.Replace("Assembly", "Type"), customTypes.First());
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
				CxInfo.AppConfigPath = dialog.FileName;
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
					customTypes = hl.TargetName == ElementNameAdaptertype ? GetDataAccessAdapterTypeNamesBothWays(types) : types.Select(t => t.FullName).ToArray();
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
					CxInfo.DriverData.SetElementValue(hl.TargetName, customTypes.First());
				else
				{
					var result = (string) Dialogs.PickFromList("Choose " + hl.TargetName, customTypes);
					if (result != null)
						CxInfo.DriverData.SetElementValue(hl.TargetName, result);
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

		private static string GetAdditionalAssemblies(XContainer additionalAssembliesElement)
		{
			return additionalAssembliesElement.Elements().Select(e => e.Value).JoinAsString();
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
					AddAssembly(CxInfo, fileName);
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
				connection.ConnectionString = CxInfo.DatabaseInfo.CustomCxString;
				if (mydlg.PromptEdit(connection))
					ProcessConnection(connection);
			}
		}

		private void ProcessConnection(_Connection connection)
		{
			var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder {ConnectionString = connection.ConnectionString};
			if (oleDbConnectionStringBuilder.PersistSecurityInfo)
			{
				connection.Open("", "", "", 0);
				if (connection.State == 1)
				{
					CxInfo.DatabaseInfo.CustomCxString = connection.ConnectionString;
					connection.Close();
					connection.Open();
				}
			}
			else
			{
				CxInfo.DatabaseInfo.CustomCxString = connection.ConnectionString;
				connection.Open();
			}
		}

		private void buttonClear_Click(object sender, RoutedEventArgs e)
		{
			Settings.Default.Reset();
		}

		#region Implementation of INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		private void txtAssemblyPath_TextChanged(object sender, TextChangedEventArgs e)
		{
			OnPropertyChanged("CustomTypeNameVisibility");
		}
	}

	public enum LLBLConnectionType
	{
		Unknown,
		SelfServicing,
		Adapter,
	 [Description("Adapter Factory")]
		AdapterFactory
	}
}