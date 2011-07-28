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
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Application = System.Windows.Forms.Application;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// 	Interaction logic for ConnectionDialog.xaml
	/// </summary>
	public partial class ConnectionDialog : INotifyPropertyChanged
	{
		#region Fields

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
		public const string TitleChooseLLBLEntityAssembly = "Choose LLBL entity assembly";
		public const string TitleChooseCustomType = "Choose LinqMetaData or ElementCreatorCore Type";
		public const string TitleChooseDataAccessAdapterAssembly = "Choose Data Access Adapter assembly";
		public const string TitleChooseFactoryAssembly = "Choose the assembly containing the factory method";
		public const string TitleChooseApplicationConfigFile = "Choose application config file";
		public const string TitleChooseExtraAssembly = "Choose extra assembly";
		public const string TitleChooseFactoryMethod = "Choose factory method";
		private const string LlblgenProNameSpace = "SD.LLBLGen.Pro";

		public static readonly string AdditionalAssembliesToolTip = "The driver adds these assemblies to the ones LINQPad provides"
		                                                            + Environment.NewLine +
		                                                            LLBLGenStaticDriver.AdditionalAssemblies.JoinAsString()
		                                                            + Environment.NewLine +
		                                                            "If you want any additional assemblies add them in here, with or with out a path.";

		public static readonly string AdditionalNamespacesToolTip = "The driver adds these namespaces to the ones LINQPad provides"
		                                                            + Environment.NewLine +
		                                                            LLBLGenStaticDriver.AdditionalNamespaces.JoinAsString()
		                                                            + "If you want any additional namespaces add them in here.";

		private static readonly LLBLConnectionType[] AdapterConnectionTypes = new[]
		                                                                      	{
		                                                                      		LLBLConnectionType.Adapter,
		                                                                      		LLBLConnectionType.AdapterFactory
		                                                                      	};

		private readonly bool _isNewConnection;
		private ObservableCollection<ValueTypeWrapper<string>> _additionalAssemblies;
		private bool _providerHasBeenSet;
		private static readonly Type IdataAccessAdapterType = typeof (IDataAccessAdapter);
		private static readonly Type IlinqMetaDataType = typeof (ILinqMetaData);
		private static readonly Type IelementCreatorCoreType = typeof (IElementCreatorCore);

		#endregion

		#region Properties

		public IConnectionInfo CxInfo { get; private set; }

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
				if (CxInfo.DatabaseInfo.Provider != value ||
				    string.Equals(value, "System.Data.SqlClient", StringComparison.InvariantCultureIgnoreCase))
				{
					_providerHasBeenSet = value != "";
					CxInfo.DatabaseInfo.Provider = value;
					OnPropertyChanged("Provider");
				}
			}
		}

		public IEnumerable<string> DbProviderFactoryNames { get; set; }

		public ObservableCollection<ValueTypeWrapper<string>> AdditionalNamespaces { get; set; }

		public ObservableCollection<ValueTypeWrapper<string>> AdditionalAssemblies
		{
			get
			{
				return _additionalAssemblies ??
				       (_additionalAssemblies =
				        new ObservableCollection<ValueTypeWrapper<string>>(
				        	Settings.Default.AdditionalAssemblies.CreateStringWrapperForBinding()));
			}
		}

		#endregion

		#region General

		public ConnectionDialog()
		{
			InitializeComponent();
		}

		public ConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			CxInfo = cxInfo;
			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += MyResolveEventHandler;
			AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainAssemblyResolve;
			_isNewConnection = isNewConnection;
			DbProviderFactoryNames = (new[] {""}).Union(DbProviderFactories.GetFactoryClasses().Rows.OfType<DataRow>().Select(r => r["InvariantName"])).
				Cast<string>().ToList();

			AdditionalNamespaces =
				new ObservableCollection<ValueTypeWrapper<string>>(Settings.Default.AdditionalNamespaces.CreateStringWrapperForBinding());
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
			if (DialogResult.GetValueOrDefault() && !string.IsNullOrEmpty(CxInfo.DatabaseInfo.CustomCxString) &&
			    string.IsNullOrEmpty(providerComboBox.Text))
				switch (MessageBox.Show("Database Provider has not been set!" + Environment.NewLine
				                        + "This is required to execute SQL" + Environment.NewLine
				                        + "Do you wish to close anyway?", "Do you wish to close?", MessageBoxButton.YesNo))
				{
					case MessageBoxResult.Yes:
						break;
					case MessageBoxResult.No:
						e.Cancel = true;
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			Settings.Default.ConnectionDialogPlacement = this.GetPlacement();
			Settings.Default.Save();
			AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= MyResolveEventHandler;
			AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomainAssemblyResolve;
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
			catch (Exception)
			{
				Close();
			}
		}

		#endregion

		#region LLBL Connection Tab

		private void BrowseAppConfig(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = TitleChooseApplicationConfigFile,
			             		Filter = "Config files (*.config)|*.config|All files (*.*)|*.*",
			             		DefaultExt = ".config",
			             	};

			if (dialog.ShowDialog() == true)
				CxInfo.AppConfigPath = dialog.FileName;
		}

		private string CheckCustomAssemblyIsTheRightVersion(string customType, string interfaceTypeName)
		{
			try
			{
				var customAssembly = Assembly.LoadFile(CxInfo.CustomTypeInfo.CustomAssemblyPath);
				var type = customAssembly.GetType(customType);
				if (!(IlinqMetaDataType.IsAssignableFrom(type) || IelementCreatorCoreType.IsAssignableFrom(type)))
				{
					var fullName = type.FullName.IndexOf("Linq") > -1 ? IlinqMetaDataType.FullName : IelementCreatorCoreType.FullName;
					MessageBox.Show(string.Format("An implementation of {0} was found <{1}>, but it was not for {2}", fullName,
					                              type.FullName,
					                              Constants.LLBLGenNameVersion));
					return "";
				}
			}
			catch (FileLoadException e)
			{
				if (e.FileName.Contains(LlblgenProNameSpace) && !e.Message.Contains(Constants.LLBLVersion))
				{
					var assemblyName = new AssemblyName(e.FileName);
					MessageBox.Show(string.Format("An implementation of {0} was found <{1}>, but it was not for {2} instead it was for version {3}",
					                              IdataAccessAdapterType.FullName, customType, Constants.LLBLGenNameVersion,
					                              assemblyName.Version));
					return "";
				}
				GeneralHelper.TraceOut(e.Message);
			}
			return customType;
		}

		private Assembly CurrentDomainAssemblyResolve(object sender, ResolveEventArgs args)
		{
			var assemblyName = new AssemblyName(args.Name);
			var shortAssemblyName = assemblyName.Name;
			//if (shortAssemblyName.Contains("SD.LLBLGen.Pro"))
			//{
			//  var firstOrDefault = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == shortAssemblyName);
			//  return firstOrDefault;
			//}
			if (File.Exists(CxInfo.CustomTypeInfo.CustomAssemblyPath) && (shortAssemblyName.IndexOf(LlblgenProNameSpace) < 0
			                                                              || assemblyName.Version.ToString().Contains(Constants.LLBLVersion)))
			{
				var directoryName = Path.GetDirectoryName(CxInfo.CustomTypeInfo.CustomAssemblyPath);
				var path = Path.Combine(directoryName, shortAssemblyName) + ".dll";
				if (File.Exists(path))
					return Assembly.LoadFile(path);
			}
			return null;
		}

		private Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
		{
			var shortAssemblyName = new AssemblyName(args.Name).Name;
			var firstOrDefault = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName == args.Name);
			if (firstOrDefault != null)
				return Assembly.ReflectionOnlyLoad(firstOrDefault.Location);
			if (File.Exists(CxInfo.CustomTypeInfo.CustomAssemblyPath))
			{
				var directoryName = Path.GetDirectoryName(CxInfo.CustomTypeInfo.CustomAssemblyPath);
				var path = Path.Combine(directoryName, shortAssemblyName) + ".dll";
				if (File.Exists(path))
					return Assembly.ReflectionOnlyLoad(path);
			}
			//  // Look in the GAC.  It may not be there, so we need to catch
			//  // FileNotFoundException.
			//  // As an optimization, don't probe in the GAC if the public
			//  // key token is null, because by definition the assembly
			//  // can't be in the GAC.
			if (!args.Name.Contains("PublicKeyToken=null"))
			{
				try
				{
					return Assembly.ReflectionOnlyLoad(args.Name);
				}
				catch (FileNotFoundException)
				{
				}

				try
				{
					// As a final effort, look in the GAC after appying loader policy.
					// This lets us resolves references for assemblies built against an older version of the framework.
					return Assembly.ReflectionOnlyLoad(AppDomain.CurrentDomain.ApplyPolicy(args.Name));
				}
				catch (FileNotFoundException)
				{
				}
			}
			return null;
		}

		private void BrowseAssembly(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = TitleChooseLLBLEntityAssembly,
			             		DefaultExt = ".dll",
			             		FileName = CxInfo.CustomTypeInfo.CustomAssemblyPath,
			             		Filter = "Assemblies (*.dll)|*.dll|All files (*.*)|*.*"
			             	};

			if (File.Exists(CxInfo.CustomTypeInfo.CustomAssemblyPath))
				dialog.InitialDirectory = Path.GetDirectoryName(CxInfo.CustomTypeInfo.CustomAssemblyPath);

			if (dialog.ShowDialog() == true)
			{
				CxInfo.CustomTypeInfo.CustomAssemblyPath = dialog.FileName;
				var customTypes = GetLinqMetaDataTypes();

				switch (customTypes.Length)
				{
					case 1:
						SetCustomTypeName(customTypes[0]);
						break;
					case 0:
						SetCustomTypeName("");
						break;
				}
			}
		}

		private void SetCustomTypeName(string customType)
		{
			CxInfo.CustomTypeInfo.CustomTypeName = customType;
			LLBLConnectionType = IsSelfServicing(CxInfo)
			                     	? LLBLConnectionType == LLBLConnectionType.AdapterFactory
			                     	  	? LLBLConnectionType
			                     	  	: LLBLConnectionType.Adapter
			                     	: LLBLConnectionType.SelfServicing;
			OnPropertyChanged("ConnectionTypeVisibility");
		}

		public static bool IsSelfServicing(IConnectionInfo connectionInfo)
		{
			var selfServicingEntities =
				connectionInfo.CustomTypeInfo.GetCustomTypesInAssembly(LlblgenProNameSpace + ".ORMSupportClasses.EntityBase");
			return selfServicingEntities.IsNullOrEmpty();
		}

		private void ChooseType(object sender, RoutedEventArgs e)
		{
			var customTypes = GetLinqMetaDataTypes();
			if (customTypes.Length == 1)
			{
				SetCustomTypeName(customTypes[0]);
				return;
			}
			if (customTypes.Length == 0)
			{
				SetCustomTypeName("");
				return;
			}
			var result = (string) Dialogs.PickFromList(TitleChooseCustomType, customTypes);
			if (result != null)
				SetCustomTypeName(CxInfo.CustomTypeInfo.CustomTypeName);
		}

		private string[] GetLinqMetaDataTypes()
		{
			if (CxInfo.CustomTypeInfo.CustomAssemblyPath.Length == 0)
			{
				MessageBox.Show("First enter a path to an assembly containing LLBL entities.");
				return null;
			}

			if (!File.Exists(CxInfo.CustomTypeInfo.CustomAssemblyPath))
			{
				MessageBox.Show("File '" + CxInfo.CustomTypeInfo.CustomAssemblyPath + "' does not exist.");
				return null;
			}
			var interfaceTypeName = IlinqMetaDataType.FullName;
			string[] customTypes;
			try
			{
				customTypes = CxInfo.CustomTypeInfo.GetCustomTypesInAssembly(interfaceTypeName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error obtaining custom types");
				BreakIntoDebugger();
				return null;
			}
			if (customTypes.Length == 0)
			{
				interfaceTypeName = IelementCreatorCoreType.FullName;
				customTypes = CxInfo.CustomTypeInfo.GetCustomTypesInAssembly(interfaceTypeName);
				if (customTypes.Length == 0)
					MessageBox.Show("There are no public types in that assembly that implement ILinqMetaData or IElementCreatorCore.",
					                "Wrong Assembly chosen");
				else
				{
					MessageBox.Show("There are no public types in that assembly that implement ILinqMetaData but there is an implementation of IElementCreatorCore.");
				}
			}
			if (customTypes.Length == 1)
			{
				customTypes[0] = CheckCustomAssemblyIsTheRightVersion(customTypes[0], interfaceTypeName);
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
					             		DefaultExt = ".dll",
					             		FileName = element.Value,
					             		Title =
					             			hl.TargetName.Equals(ElementNameFactoryAssembly)
					             				? TitleChooseFactoryAssembly
					             				: TitleChooseDataAccessAdapterAssembly,
					             		Filter = "Assemblies (*.dll)|*.dll|All files (*.*)|*.*"
					             	};
					if (File.Exists(element.Value))
						dialog.InitialDirectory = Path.GetDirectoryName(element.Value);
					if (dialog.ShowDialog() == true)
					{
						element.Value = dialog.FileName;
						if (hl.TargetName.Contains("Type"))
						{
							var dataAccessAdapterAssembly = Assembly.LoadFile(dialog.FileName);
							try
							{
								var customTypes = GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly);
								if (customTypes.Count() == 1)
									CxInfo.DriverData.SetElementValue(hl.TargetName.Replace("Assembly", "Type"), customTypes.First());
							}
							catch (Exception ex)
							{
								BreakIntoDebugger();
								GeneralHelper.TraceOut(ex.Message);
								return;
							}
						}
						else
						{
							ChooseAdapterOrFactoryClass(sender, e);
						}
					}
				}
			}
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(Assembly dataAccessAdapterAssembly)
		{
			try
			{
				return GetDataAccessAdapterTypeNames(dataAccessAdapterAssembly.GetTypes());
			}
			catch (FileLoadException e)
			{
				if (e.FileName.Contains(LlblgenProNameSpace) && !e.Message.Contains(Constants.LLBLVersion))
				{
					var assemblyName = new AssemblyName(e.FileName);
					//MessageBox.Show(string.Format("An implementation of {0} was found <{1}>, but it was not for {2}", interfaceTypeName,
					//                    customType,
					//                    Constants.LLBLGenNameVersion));
					//MessageBox.Show(string.Format("An implementation of {0} was found <{1}>, but it was not for {2} instead it was for version {3}",
					//        IdataAccessAdapterType.FullName, customType, Constants.LLBLGenNameVersion,
					//        assemblyName.Version));
					return Enumerable.Empty<string>();
				}
				GeneralHelper.TraceOut(e.Message);
			}
			catch (ReflectionTypeLoadException ex)
			{
				var loaderException = ex.LoaderExceptions[0];
				if (loaderException.Message.Contains(LlblgenProNameSpace) && !loaderException.Message.Contains(Constants.LLBLVersion))
					MessageBox.Show(string.Format("The assembly {0} is not for {1}", dataAccessAdapterAssembly.Location, Constants.LLBLGenNameVersion));
				else
					//Dialogs.PickFromList("An array of assemblies in this application domain.",
					//             AppDomain.CurrentDomain.GetAssemblies().OrderBy(a => a.FullName).ToArray());
					MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine +
					                ex.LoaderExceptions.Select(le => le.Message).Distinct().JoinAsString(Environment.NewLine),
					                "Error obtaining adapter types");
			}
			return Enumerable.Empty<string>();
		}

		private static IEnumerable<string> GetDataAccessAdapterTypeNames(IEnumerable<Type> types)
		{
			var implementers = types.FilterByClassIsAssignableTo(IdataAccessAdapterType);
			if (!implementers.Any())
			{
				implementers = types.FilterByImplements(IdataAccessAdapterType.FullName);
				if (implementers.Any())
				{
					var implementer = implementers.First();

					var assembly = implementer.GetInterface(IdataAccessAdapterType.FullName).Assembly;
					var assemblyName = new AssemblyName(assembly.FullName);
					MessageBox.Show(string.Format("An implementation of {0} was found <{1}>, but it was not for {2} instead it was for version {3}",
					                              IdataAccessAdapterType.FullName, implementer.FullName, Constants.LLBLGenNameVersion,
					                              assemblyName.Version));
					implementers = Enumerable.Empty<Type>();
				}
				else
				{
					MessageBox.Show("There are no public types in that assembly that implement IDataAccessAdapter.");
				}
			}
			return implementers.Select(t => t.FullName);
		}

		private void ChooseAdapterOrFactoryClass(object sender, RoutedEventArgs e)
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

				IEnumerable<string> customTypes;
				try
				{
					var dataAccessAdapterAssembly = LoadAssembly(assemPath);
					var types = dataAccessAdapterAssembly.GetTypes();
					customTypes = LLBLConnectionType == LLBLConnectionType.Adapter
					              	? GetDataAccessAdapterTypeNames(types)
					              	: types.Select(t => t.FullName).OrderBy(s => s);
				}
				catch (ReflectionTypeLoadException ex)
				{
					var loaderException = ex.LoaderExceptions[0];
					if (loaderException.Message.Contains(LlblgenProNameSpace) && !loaderException.Message.Contains(Constants.LLBLVersion))
						MessageBox.Show(string.Format("The assembly {0} is not for {1}", assemPath, Constants.LLBLGenNameVersion));
					else
						//Dialogs.PickFromList("An array of assemblies in this application domain.",
						//             AppDomain.CurrentDomain.GetAssemblies().OrderBy(a => a.FullName).ToArray());
						MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine +
						                ex.LoaderExceptions.Select(le => le.Message).Distinct().JoinAsString(Environment.NewLine),
						                "Error obtaining adapter types");
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error obtaining adapter types: " + ex.Message);
					BreakIntoDebugger();
					return;
				}
				if (customTypes.Count() == 1)
					CxInfo.DriverData.SetElementValue(hl.TargetName, customTypes.First());
				else if (customTypes.Count() == 0)
				{
					CxInfo.DriverData.SetElementValue(hl.TargetName, "");
				}
				else
				{
					var result = (string) Dialogs.PickFromList("Choose " + hl.TargetName, customTypes.ToArray());
					if (result != null)
					{
						CxInfo.DriverData.SetElementValue(hl.TargetName, result);
						ChooseAdapterFactoryMethod(sender, e);
					}
				}
			}
		}

		private static Assembly LoadAssembly(string assemPath)
		{
			try
			{
				return Assembly.LoadFile(assemPath);
			}
			catch (ReflectionTypeLoadException)
			{
				return Assembly.LoadFrom(assemPath);
			}
		}

		private void ChooseAdapterFactoryMethod(object sender, RoutedEventArgs e)
		{
			try
			{
				var factoryTypeName = GetDriverDataValue(CxInfo, ElementNameFactoryType);
				if (!string.IsNullOrEmpty(factoryTypeName))
				{
					var factoryAssemblyPath = GetDriverDataValue(CxInfo, ElementNameFactoryAssembly);
					var factoryAdapterAssembly = Assembly.LoadFile(factoryAssemblyPath);
					if (factoryAdapterAssembly == null)
						throw new ApplicationException("Factory assembly: " + factoryAssemblyPath + " could not be loaded!");
					var factoryType = factoryAdapterAssembly.GetType(factoryTypeName);
					if (factoryType == null)
					{
						factoryAdapterAssembly.GetTypes();
						throw new ApplicationException(string.Format("Factory type: {0} could not be loaded from: {1}!", factoryTypeName,
						                                             factoryAssemblyPath));
					}
					var methodInfos = factoryType.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
					var validMethods = from m in methodInfos
					                   let ps = m.GetParameters()
					                   where
					                   	ps.Length == 1 && ps.Single().ParameterType == typeof (string) &&
					                   	m.ReturnType.Implements(IdataAccessAdapterType)
					                   select m;
					var count = validMethods.Count();
					if (count == 1)
					{
						var methodInfo = validMethods.Single();
						if (IdataAccessAdapterType.IsAssignableFrom(methodInfo.ReturnType))
						{
							CxInfo.DriverData.SetElementValue(ElementNameFactoryMethod, methodInfo.Name);
						}
						else
						{
							var assembly = methodInfo.ReturnType.GetInterface(IdataAccessAdapterType.FullName).Assembly;
							var assemblyName = new AssemblyName(assembly.FullName);
							MessageBox.Show(
								string.Format("A method with a return type of {0} was found <{1}>, but it was not for {2} instead it was for version {3}",
								              IdataAccessAdapterType.FullName, methodInfo.Name, Constants.LLBLGenNameVersion,
								              assemblyName.Version));
							CxInfo.DriverData.SetElementValue(ElementNameFactoryMethod, "");
						}
					}
					else
					{
						var result = (MethodInfo) Dialogs.PickFromList(TitleChooseFactoryMethod, validMethods.ToArray());
						if (result != null)
							CxInfo.DriverData.SetElementValue(ElementNameFactoryMethod, result.Name);
						else
						{
							Dialogs.PickFromList("An array of assemblies in this application domain.",
							                     AppDomain.CurrentDomain.GetAssemblies().OrderBy(a => a.FullName).ToArray());
						}
					}
				}
			}
			catch (Exception ex)
			{
				Application.OnThreadException(ex);
			}
		}

		#endregion

		#region Other Tabs

		[Conditional("DEBUGX")]
		private static void BreakIntoDebugger()
		{
			Debugger.Break();
		}

		private void ChooseAssemblies(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog
			             	{
			             		Title = TitleChooseExtraAssembly,
			             		DefaultExt = ".dll",
			             		Filter = "Assemblies (*.dll)|*.dll|All files (*.*)|*.*",
			             		Multiselect = true
			             	};

			if (dialog.ShowDialog() == true)
				foreach (var fileName in dialog.FileNames
					.Where(fileName => !LLBLGenStaticDriver.AdditionalAssemblies.Contains(Path.GetFileName(fileName))).
					CreateStringWrapperForBinding()
					.Where(fileName => !AdditionalAssemblies.Contains(fileName))
					)
				{
					AdditionalAssemblies.Add(fileName);
				}
		}

		private void AddQuerySpec(object sender, RoutedEventArgs e)
		{
			ValueTypeWrapper<string>.Add(AdditionalAssemblies, "SD.LLBLGen.Pro.QuerySpec.dll");
			ValueTypeWrapper<string>.Add(AdditionalNamespaces, "SD.LLBLGen.Pro.QuerySpec",
			                             "SD.LLBLGen.Pro.QuerySpec.SelfServicing", "SD.LLBLGen.Pro.QuerySpec.Adapter");
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
		}

		private void buttonClearAdditionalClick(object sender, RoutedEventArgs e)
		{
			AdditionalNamespaces.Clear();
			AdditionalAssemblies.Clear();
		}

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
			if (string.IsNullOrEmpty(providerComboBox.Text))
				MessageBox.Show("Provider has not been set" + Environment.NewLine + "Choose from list.");
			else
				try
				{
					var dbProviderFactory = DbProviderFactories.GetFactory(CxInfo.DatabaseInfo.Provider);
					var connectionStringBuilder = dbProviderFactory.CreateConnectionStringBuilder();
					if (connectionStringBuilder == null)
						connectionStringBuilder = new DbConnectionStringBuilder {ConnectionString = CxInfo.DatabaseInfo.CustomCxString};
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
					Application.OnThreadException(ex);
				}
		}

		#endregion

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
	}

	public enum LLBLConnectionType
	{
		Unknown,
		SelfServicing,
		Adapter,
		[Description("Adapter Factory")] AdapterFactory
	}
}