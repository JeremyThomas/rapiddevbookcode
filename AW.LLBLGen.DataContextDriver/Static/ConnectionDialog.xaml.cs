using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Xml.Linq;
using AW.Helper;
using AW.LLBLGen.DataContextDriver.Properties;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.ConnectionUI;
using LINQPad.Extensibility.DataContext;
using LINQPad.Extensibility.DataContext.UI;
using Microsoft.Data.ConnectionUI;
using Microsoft.Win32;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// 	Interaction logic for ConnectionDialog.xaml
	/// </summary>
	public partial class ConnectionDialog : INotifyPropertyChanged
	{
		private readonly bool _isNewConnection;
		private bool _providerHasBeenSet;

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

		public static readonly string AdditionalAssembliesToolTip = "The driver adds these assemblies to the ones LINQPad provides"
		                                                            + Environment.NewLine + LLBLGenStaticDriver.AdditionalAssemblies.JoinAsString()
		                                                            + Environment.NewLine + "If you want any additional assemblies add them in here, with or with out a path.";

		public static readonly string AdditionalNamespacesToolTip = "The driver adds these namespaces to the ones LINQPad provides"
		                                                            + Environment.NewLine + LLBLGenStaticDriver.AdditionalNamespaces.JoinAsString()
		                                                            + "If you want any additional namespaces add them in here.";

		public IConnectionInfo CxInfo { get; private set; }

		public ConnectionDialog()
		{
			InitializeComponent();
		}

		public ConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			_isNewConnection = isNewConnection;
			CxInfo = cxInfo;
			DbProviderFactoryNames = (new[] {""}).Union(DbProviderFactories.GetFactoryClasses().Rows.OfType<DataRow>().Select(r => r["InvariantName"])).Cast<string>().ToList();

			AdditionalNamespaces = new ObservableCollection<ValueTypeWrapper<string>>(Settings.Default.AdditionalNamespaces.CreateStringWrapperForBinding());
			if (isNewConnection)
			{
				CreateDriverDataElements(cxInfo);

				CxInfo.AppConfigPath = Settings.Default.DefaultApplicationConfig;
				CxInfo.DatabaseInfo.CustomCxString = Settings.Default.DefaultDatabaseConnection;
				Provider = Settings.Default.DefaultProvider;
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
			get { return AdapterConnectionTypes.Contains(LLBLConnectionType) ? Visibility.Visible : Visibility.Collapsed; }
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

		public string Provider
		{
			get { return _providerHasBeenSet || !_isNewConnection ? CxInfo.DatabaseInfo.Provider : ""; }
			set
			{
				if (CxInfo.DatabaseInfo.Provider != value || string.Equals(value, "System.Data.SqlClient", StringComparison.InvariantCultureIgnoreCase))
				{
					_providerHasBeenSet = value != "";
					CxInfo.DatabaseInfo.Provider = value;
					OnPropertyChanged("Provider");
				}
			}
		}

		public IEnumerable<string> DbProviderFactoryNames { get; set; }

		public ObservableCollection<ValueTypeWrapper<string>> AdditionalNamespaces { get; set; }

		private ObservableCollection<ValueTypeWrapper<string>> _additionalAssemblies;
		private static readonly LLBLConnectionType[] AdapterConnectionTypes = new[] {LLBLConnectionType.Adapter, LLBLConnectionType.AdapterFactory};

		public ObservableCollection<ValueTypeWrapper<string>> AdditionalAssemblies
		{
			get { return _additionalAssemblies ?? (_additionalAssemblies = new ObservableCollection<ValueTypeWrapper<string>>(Settings.Default.AdditionalAssemblies.CreateStringWrapperForBinding())); }
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
			Settings.Default.DefaultProvider = Provider;
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

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
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

			try
			{
				DialogResult = true;
			}
			catch (Exception )
			{
				Close();
			}
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
			return types.Where(t => t != null && !String.IsNullOrEmpty(t.Name) && t.Name.Contains("DataAccessAdapter") && t.IsClass).Select(t => t.FullName);
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
						MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine +
						                ex.LoaderExceptions.Select(le => le.Message).JoinAsString(Environment.NewLine), "Error obtaining adapter types");
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

		private void ChooseAssemblies(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = "Choose extra assembly",
			             		DefaultExt = ".dll",
			             		Multiselect = true
			             	};

			if (dialog.ShowDialog() == true)
				foreach (var fileName in dialog.FileNames
					.Where(fileName => !LLBLGenStaticDriver.AdditionalAssemblies.Contains(Path.GetFileName(fileName))).CreateStringWrapperForBinding()
					.Where(fileName => !AdditionalAssemblies.Contains(fileName))
					)
				{
					AdditionalAssemblies.Add(fileName);
				}
		}

		private void DataBaseConnectionDialog(object sender, RoutedEventArgs e)
		{
			var dcd = new DataConnectionDialog();
			var dcs = new DataConnectionConfiguration(null);
			dcs.LoadConfiguration(dcd);

			var dataProvider = dcd.UnspecifiedDataSource.Providers.FirstOrDefault(p => p.Name == Provider);
			if (dataProvider != null)
			{
				dcd.SelectedDataSource = dcd.UnspecifiedDataSource;
				dcd.SelectedDataProvider = dataProvider;
			}

			if (dcd.SelectedDataProvider != null)
				dcd.ConnectionString = CxInfo.DatabaseInfo.CustomCxString;
			if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
			{
				CxInfo.DatabaseInfo.CustomCxString = dcd.ConnectionString;
				if (dcd.SelectedDataProvider != null)
					Provider = dcd.SelectedDataProvider.Name;
			}
			//dcs.SaveConfiguration(dcd);
		}

		private void buttonClear_Click(object sender, RoutedEventArgs e)
		{
			Settings.Default.Reset();
			AdditionalNamespaces.Clear();
			AdditionalAssemblies.Clear();
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

		private void SetConnectionString_Click(object sender, RoutedEventArgs e)
		{
			CxInfo.DatabaseInfo.CustomCxString = CxInfo.DatabaseInfo.GetCxString();
		}

		private void GetConnectionString_Click(object sender, RoutedEventArgs e)
		{
	   try
			{
				var dbProviderFactory = DbProviderFactories.GetFactory(CxInfo.DatabaseInfo.Provider);
				var connectionStringBuilder = dbProviderFactory.CreateConnectionStringBuilder();
				if (connectionStringBuilder == null)
					connectionStringBuilder = new DbConnectionStringBuilder { ConnectionString = CxInfo.DatabaseInfo.CustomCxString };
				else
					connectionStringBuilder.ConnectionString = CxInfo.DatabaseInfo.CustomCxString;
				if (connectionStringBuilder.ContainsKey("data source"))
					CxInfo.DatabaseInfo.Server = Convert.ToString(connectionStringBuilder["data source"]);
				if (connectionStringBuilder.ContainsKey("initial catalog"))
					CxInfo.DatabaseInfo.Database = Convert.ToString(connectionStringBuilder["initial catalog"]);
				if (connectionStringBuilder.ContainsKey("initial file name"))
					CxInfo.DatabaseInfo.AttachFileName = Convert.ToString(connectionStringBuilder["initial file name"]);
				if (connectionStringBuilder.ContainsKey("user id"))
					CxInfo.DatabaseInfo.UserName = Convert.ToString(connectionStringBuilder["user id"]);
				if (connectionStringBuilder.ContainsKey("password"))
					CxInfo.DatabaseInfo.Password = Convert.ToString(connectionStringBuilder["password"]);
			}
			catch (Exception ex)
			{
				System.Windows.Forms.Application.OnThreadException(ex);
			}
		}
	}

	public enum LLBLConnectionType
	{
		Unknown,
		SelfServicing,
		Adapter,
		[Description("Adapter Factory")] AdapterFactory
	}
}