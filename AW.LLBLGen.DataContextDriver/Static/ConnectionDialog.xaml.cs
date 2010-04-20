using System;
using System.IO;
using System.Windows;
using LINQPad.Extensibility.DataContext;
using LINQPad.Extensibility.DataContext.UI;
using Microsoft.Win32;

namespace AW.LLBLGen.DataContextDriver.Static
{
  /// <summary>
  /// Interaction logic for ConnectionDialog.xaml
  /// </summary>
  public partial class ConnectionDialog
  {
    private readonly IConnectionInfo _cxInfo;

    public ConnectionDialog(IConnectionInfo cxInfo)
    {
      _cxInfo = cxInfo;
      DataContext = cxInfo.CustomTypeInfo;
      InitializeComponent();
    }

    private void btnOK_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
    }

    private void BrowseAssembly(object sender, RoutedEventArgs e)
    {
      var dialog = new OpenFileDialog
                     {
                       Title = "Choose custom assembly",
                       DefaultExt = ".dll",
                     };

      if (dialog.ShowDialog() == true)
        _cxInfo.CustomTypeInfo.CustomAssemblyPath = dialog.FileName;
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
        return;
      }
      if (customTypes.Length == 0)
      {
        MessageBox.Show("There are no public types in that assembly."); // based on.........
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
  }
}