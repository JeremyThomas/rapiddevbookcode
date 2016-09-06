using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AW.Helper;
using Microsoft.Win32;

namespace AW.Winforms.Helpers.Forms
{
  /// <summary>
  ///   Generic, self-contained About Box dialog
  /// </summary>
  /// <remarks>
  ///   Jeff Atwood
  ///   http://www.codinghorror.com
  ///   converted to C# by Scott Ferguson
  ///   http://www.forestmoon.com
  /// </remarks>
  [SuppressMessage("ReSharper", "CatchAllClause")]
  public partial class AboutBox : FrmPersistantLocation
  {
    public AboutBox(string moreInfo)
    {
      InitializeComponent();
      AppMoreInfo += moreInfo;
    }

    public static void ShowAboutBox(IWin32Window owner = null)
    {
      ShowAboutBox(owner, Environment.NewLine + Environment.NewLine + "https://rapiddevbookcode.codeplex.com/documentation" + Environment.NewLine);
    }

    public static void ShowAboutBox(IWin32Window owner, string productVersion, params object[] lines)
    {
      ShowAboutBox(owner, productVersion, (IEnumerable<object>)lines);
    }

    public static void ShowAboutBox(IWin32Window owner, string productVersion, IEnumerable<object> lines)
    {
      ShowAboutBox(owner, MoreInfo(productVersion, lines));
    }

    private static void ShowAboutBox(IWin32Window owner, string moreInfo)
    {
      var ab = new AboutBox(moreInfo);
      ab.ShowDialog(owner);
    }

    public static string MoreInfo(string productVersion, params object[] lines)
    {
      return MoreInfo(productVersion, (IEnumerable<object>)lines);
    }

    private static string MoreInfo(string productVersion, IEnumerable<object> lines)
    {
      var assembly = Assembly.GetEntryAssembly();
      var moreInfo = Environment.NewLine + Environment.NewLine + "Product Version: " + (assembly.GetInformationalVersionAttribute() ?? productVersion)
                     + Environment.NewLine + "File Version: " + assembly.GetVersion();
      return lines.Aggregate(moreInfo, (current, url) => current + Environment.NewLine + Environment.NewLine + url + Environment.NewLine);
    }

    private bool _isPainted;
    private string _entryAssemblyName;
    private string _callingAssemblyName;
    private string _executingAssemblyName;
    private NameValueCollection _entryAssemblyAttributeCollection;

    // <summary>
    // returns the entry assembly for the current application domain
    // </summary>
    // <remarks>
    // This is usually read-only, but in some weird cases (Smart Client apps) 
    // you won't have an entry assembly, so you may want to set this manually.
    // </remarks>
    public Assembly AppEntryAssembly { get; set; }

    // <summary>
    // single line of text to show in the application title section of the about box dialog
    // </summary>
    // <remarks>
    // defaults to "%title%" 
    // %title% = Assembly: AssemblyTitle
    // </remarks>
    public string AppTitle
    {
      get { return AppTitleLabel.Text; }
      set { AppTitleLabel.Text = value; }
    }

    // <summary>
    // single line of text to show in the description section of the about box dialog
    // </summary>
    // <remarks>
    // defaults to "%description%"
    // %description% = Assembly: AssemblyDescription
    // </remarks>
    public string AppDescription
    {
      get { return AppDescriptionLabel.Text; }
      set
      {
        if (value == "")
          AppDescriptionLabel.Visible = false;
        else
        {
          AppDescriptionLabel.Visible = true;
          AppDescriptionLabel.Text = value;
        }
      }
    }

    // <summary>
    // single line of text to show in the version section of the about dialog
    // </summary>
    // <remarks>
    // defaults to "Version %version%"
    // %version% = Assembly: AssemblyVersion
    // </remarks>
    public string AppVersion
    {
      get { return AppVersionLabel.Text; }
      set
      {
        if (value == "")
          AppVersionLabel.Visible = false;
        else
        {
          AppVersionLabel.Visible = true;
          AppVersionLabel.Text = value;
        }
      }
    }

    // <summary>
    // single line of text to show in the copyright section of the about dialog
    // </summary>
    // <remarks>
    // defaults to "Copyright © %year%, %company%"
    // %company% = Assembly: AssemblyCompany
    // %year% = current 4-digit year
    // </remarks>
    public string AppCopyright
    {
      get { return AppCopyrightLabel.Text; }
      set
      {
        if (value == "")
          AppCopyrightLabel.Visible = false;
        else
        {
          AppCopyrightLabel.Visible = true;
          AppCopyrightLabel.Text = value;
        }
      }
    }

    // <summary>
    // intended for the default 32x32 application icon to appear in the upper left of the about dialog
    // </summary>
    // <remarks>
    // if you open this form using .ShowDialog(Owner), the icon can be derived from the owning form
    // </remarks>
    public Image AppImage
    {
      get { return ImagePictureBox.Image; }
      set { ImagePictureBox.Image = value; }
    }

    // <summary>
    // multiple lines of miscellaneous text to show in rich text box
    // </summary>
    // <remarks>
    // defaults to "%product% is %copyright%, %trademark%"
    // %product% = Assembly: AssemblyProduct
    // %copyright% = Assembly: AssemblyCopyright
    // %trademark% = Assembly: AssemblyTrademark
    // </remarks>
    private string AppMoreInfo
    {
      get { return MoreRichTextBox.Text; }
      set
      {
        if (String.IsNullOrEmpty(value))
          MoreRichTextBox.Visible = false;
        else
        {
          MoreRichTextBox.Visible = true;
          MoreRichTextBox.Text = value;
        }
      }
    }

    // <summary>
    // determines if the "Details" (advanced assembly details) button is shown
    // </summary>
    public bool AppDetailsButton
    {
      get { return DetailsButton.Visible; }
      set { DetailsButton.Visible = value; }
    }

    // <summary>
    // exception-safe retrieval of LastWriteTime for this assembly.
    // </summary>
    // <returns>File.GetLastWriteTime, or DateTime.MaxValue if exception was encountered.</returns>
    private static DateTime AssemblyLastWriteTime(Assembly a)
    {
      if (a.IsDynamic) return DateTime.MaxValue;
      try
      {
        return String.IsNullOrWhiteSpace(a.Location) ? DateTime.MaxValue : File.GetLastWriteTime(a.Location);
      }
      catch (Exception)
      {
        return DateTime.MaxValue;
      }
    }

    // <summary>
    // returns DateTime this Assembly was last built. Will attempt to calculate from build number, if possible. 
    // If not, the actual LastWriteTime on the assembly file will be returned.
    // </summary>
    // <param name="a">Assembly to get build date for</param>
    // <param name="ForceFileDate">Don't attempt to use the build number to calculate the date</param>
    // <returns>DateTime this assembly was last built</returns>
    private static DateTime AssemblyBuildDate(Assembly a, bool forceFileDate)
    {
      var assemblyVersion = a.GetName().Version;
      DateTime dt;

      if (forceFileDate)
        dt = AssemblyLastWriteTime(a);
      else
      {
        dt = DateTime.Parse("01/01/2000").AddDays(assemblyVersion.Build).AddSeconds(assemblyVersion.Revision*2);
        if (TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)))
          dt = dt.AddHours(1);
        if (dt > DateTime.Now || assemblyVersion.Build < 730 || assemblyVersion.Revision == 0)
          dt = AssemblyLastWriteTime(a);
      }

      return dt;
    }

    // <summary>
    // returns string name / string value pair of all attribs
    // for specified assembly
    // </summary>
    // <remarks>
    // note that Assembly* values are pulled from AssemblyInfo file in project folder
    //
    // Trademark       = AssemblyTrademark string
    // Debuggable      = true
    // GUID            = 7FDF68D5-8C6F-44C9-B391-117B5AFB5467
    // CLSCompliant    = true
    // Product         = AssemblyProduct string
    // Copyright       = AssemblyCopyright string
    // Company         = AssemblyCompany string
    // Description     = AssemblyDescription string
    // Title           = AssemblyTitle string
    // </remarks>
    private static NameValueCollection AssemblyAttributes(Assembly a)
    {
      var nvc = new NameValueCollection();
      var r = new Regex(@"(\.Assembly|\.)(?<Name>[^.]*)Attribute$", RegexOptions.IgnoreCase);

      foreach (var attribute in a.GetCustomAttributes(false))
      {
        var typeName = attribute.GetType().ToString();
        var theName = r.Match(typeName).Groups["Name"].ToString();
        string value;
        switch (typeName)
        {
          case "System.CLSCompliantAttribute":
            value = ((CLSCompliantAttribute) attribute).IsCompliant.ToString();
            break;
          case "System.Diagnostics.DebuggableAttribute":
            value = ((DebuggableAttribute) attribute).IsJITTrackingEnabled.ToString();
            break;
          case "System.Reflection.AssemblyCompanyAttribute":
            value = ((AssemblyCompanyAttribute) attribute).Company;
            break;
          case "System.Reflection.AssemblyConfigurationAttribute":
            value = ((AssemblyConfigurationAttribute) attribute).Configuration;
            break;
          case "System.Reflection.AssemblyCopyrightAttribute":
            value = ((AssemblyCopyrightAttribute) attribute).Copyright;
            break;
          case "System.Reflection.AssemblyDefaultAliasAttribute":
            value = ((AssemblyDefaultAliasAttribute) attribute).DefaultAlias;
            break;
          case "System.Reflection.AssemblyDelaySignAttribute":
            value = ((AssemblyDelaySignAttribute) attribute).DelaySign.ToString();
            break;
          case "System.Reflection.AssemblyDescriptionAttribute":
            value = ((AssemblyDescriptionAttribute) attribute).Description;
            break;
          case "System.Reflection.AssemblyInformationalVersionAttribute":
            value = ((AssemblyInformationalVersionAttribute) attribute).InformationalVersion;
            break;
          case "System.Reflection.AssemblyVersionAttribute":
            value = ((AssemblyVersionAttribute) attribute).Version;
            break;
          case "System.Reflection.AssemblyFileVersionAttribute":
            value = ((AssemblyFileVersionAttribute) attribute).Version;
            break;
          case "System.Reflection.AssemblyKeyFileAttribute":
            value = ((AssemblyKeyFileAttribute) attribute).KeyFile;
            break;
          case "System.Reflection.AssemblyProductAttribute":
            value = ((AssemblyProductAttribute) attribute).Product;
            break;
          case "System.Reflection.AssemblyTrademarkAttribute":
            value = ((AssemblyTrademarkAttribute) attribute).Trademark;
            break;
          case "System.Reflection.AssemblyTitleAttribute":
            value = ((AssemblyTitleAttribute) attribute).Title;
            break;
          case "System.Resources.NeutralResourcesLanguageAttribute":
            value = ((NeutralResourcesLanguageAttribute) attribute).CultureName;
            break;
          case "System.Resources.SatelliteContractVersionAttribute":
            value = ((SatelliteContractVersionAttribute) attribute).Version;
            break;
          case "System.Runtime.InteropServices.ComCompatibleVersionAttribute":
          {
            var x = (ComCompatibleVersionAttribute) attribute;
            value = x.MajorVersion + "." + x.MinorVersion + "." + x.RevisionNumber + "." + x.BuildNumber;
            break;
          }
          case "System.Runtime.InteropServices.ComVisibleAttribute":
            value = ((ComVisibleAttribute) attribute).Value.ToString();
            break;
          case "System.Runtime.InteropServices.GuidAttribute":
            value = ((GuidAttribute) attribute).Value;
            break;
          case "System.Runtime.InteropServices.TypeLibVersionAttribute":
          {
            var x = (TypeLibVersionAttribute) attribute;
            value = x.MajorVersion + "." + x.MinorVersion;
            break;
          }
          case "System.Security.AllowPartiallyTrustedCallersAttribute":
            value = "(Present)";
            break;
          case "System.Runtime.Versioning.TargetFrameworkAttribute":
            value = ((TargetFrameworkAttribute) attribute).FrameworkDisplayName;
            break;
          case "System.Runtime.CompilerServices.RuntimeCompatibilityAttribute":
            value = ((RuntimeCompatibilityAttribute) attribute).WrapNonExceptionThrows.ToString();
            break;
          case "System.Runtime.CompilerServices.CompilationRelaxationsAttribute":
            value = ((CompilationRelaxationsAttribute) attribute).CompilationRelaxations.ToString();
            break;
          case "System.Runtime.CompilerServices.InternalsVisibleToAttribute":
          case "System.Security.SecurityRulesAttribute":
          case "System.Runtime.CompilerServices.ExtensionAttribute":
          case "System.Reflection.AssemblyMetadataAttribute":
          case "System.Security.Permissions.SecurityPermissionAttribute":
          case "System.Security.SecurityCriticalAttribute":
          case "System.Net.DnsPermissionAttribute":
          case "System.Runtime.InteropServices.BestFitMappingAttribute":
          case "System.EnterpriseServices.ApplicationIDAttribute":
          case "System.EnterpriseServices.ApplicationNameAttribute":
          case "System.Runtime.CompilerServices.DefaultDependencyAttribute":
          case "System.Runtime.CompilerServices.DependencyAttribute":
          case "System.Runtime.CompilerServices.StringFreezingAttribute":
          case "System.Drawing.BitmapSuffixInSatelliteAssemblyAttribute":
          case "System.Runtime.ConstrainedExecution.ReliabilityContractAttribute":
          case "System.Runtime.InteropServices.ImportedFromTypeLibAttribute":
          case "System.Security.SecurityTransparentAttribute":
          case "System.Reflection.AssemblySignatureKeyAttribute":
          case "System.Reflection.AssemblyKeyNameAttribute":
            value = MetaDataHelper.GetReadablePropertiesAndValuesAsString(attribute);
            break;
          case "System.Security.Permissions.FileIOPermissionAttribute":
          case "System.Security.Permissions.EnvironmentPermissionAttribute":
            value = MetaDataHelper.GetReadablePropertiesAndValuesAsString(attribute, "All", "ViewAndModify");
            break;
          default:
            var readablePropertiesAndValuesAsString = MetaDataHelper.GetReadablePropertiesAndValuesAsString(attribute);
            GeneralHelper.TraceOut("** unknown assembly attribute '" + typeName + "' " + readablePropertiesAndValuesAsString);
            value = readablePropertiesAndValuesAsString;
            break;
        }

        if (nvc[theName] == null)
          nvc.Add(theName, value);
      }

      // add some extra values that are not in the AssemblyInfo, but nice to have
      // codebase

      if (!a.IsDynamic)
        try
        {
          nvc.Add("CodeBase", a.CodeBase.Replace("file:///", ""));
        }
        catch (NotSupportedException)
        {
          nvc.Add("CodeBase", "(not supported)");
        }
      // build date
      var dt = AssemblyBuildDate(a, false);
      nvc.Add("BuildDate", dt == DateTime.MaxValue ? "(unknown)" : dt.ToString("yyyy-MM-dd hh:mm tt"));
      // location

      if (!a.IsDynamic)
        try
        {
          nvc.Add("Location", a.Location);
        }
        catch (NotSupportedException)
        {
          nvc.Add("Location", "(not supported)");
        }
      // version
      try
      {
        var version = a.GetName().Version;
        if (version.Major == 0 && version.Minor == 0)
          AddVersionUnknown(nvc);
        else
          nvc.Add("Version", version.ToString());
      }
      catch (Exception)
      {
        AddVersionUnknown(nvc);
      }
      nvc.Add("FullName", a.FullName);
      return nvc;
    }

    private static void AddVersionUnknown(NameValueCollection nvc)
    {
      var location = nvc["Location"];
      if (!String.IsNullOrWhiteSpace(location) && location != "(not supported)" && File.Exists(location))
      {
        var fileVersionInfo = FileVersionInfo.GetVersionInfo(location);
      }
      nvc.Add("Version", "(unknown)");
    }

    // <summary>
    // reads an HKLM Windows Registry key value
    // </summary>
    private static string RegistryHklmValue(string keyName, string subKeyRef)
    {
      try
      {
        var rk = Registry.LocalMachine.OpenSubKey(keyName);
        if (rk != null)
          return (string) rk.GetValue(subKeyRef, "");
      }
      catch (Exception)
      {
        return "";
      }
      return "";
    }

    // <summary>
    // launch the MSInfo "system information" application (works on XP, 2003, and Vista)
    // </summary>
    private void ShowSysInfo()
    {
      var strSysInfoPath = RegistryHklmValue(@"SOFTWARE\Microsoft\Shared Tools Location", "MSINFO");
      if (strSysInfoPath == "")
        strSysInfoPath = RegistryHklmValue(@"SOFTWARE\Microsoft\Shared Tools\MSINFO", "PATH");
      if (strSysInfoPath == "")
      {
        MessageBox.Show(String.Format("System Information is unavailable at this time.{0}{0}(couldn't find path for Microsoft System Information Tool in the registry.)", Environment.NewLine),
          Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      try
      {
        Process.Start(strSysInfoPath);
      }
      catch (Exception)
      {
        MessageBox.Show(String.Format("System Information is unavailable at this time.{0}{0}(couldn't launch '{1}')", Environment.NewLine, strSysInfoPath),
          Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
    }

    // <summary>
    // populate a listview with the specified key and value strings
    // </summary>
    private static void Populate(ListView lvw, string key, string value)
    {
      if (value == "")
        return;
      var lvi = new ListViewItem {Text = key};
      lvi.SubItems.Add(value);
      lvw.Items.Add(lvi);
    }

    // <summary>
    // populates the Application Information listview
    // </summary>
    private void PopulateAppInfo()
    {
      var d = AppDomain.CurrentDomain;
      Populate(AppInfoListView, "Application Name", d.SetupInformation.ApplicationName);
      Populate(AppInfoListView, "Application Base", d.SetupInformation.ApplicationBase);
      Populate(AppInfoListView, "Cache Path", d.SetupInformation.CachePath);
      Populate(AppInfoListView, "Configuration File", d.SetupInformation.ConfigurationFile);
      Populate(AppInfoListView, "Dynamic Base", d.SetupInformation.DynamicBase);
      Populate(AppInfoListView, "Friendly Name", d.FriendlyName);
      Populate(AppInfoListView, "License File", d.SetupInformation.LicenseFile);
      Populate(AppInfoListView, "private Bin Path", d.SetupInformation.PrivateBinPath);
      Populate(AppInfoListView, "Shadow Copy Directories", d.SetupInformation.ShadowCopyDirectories);
      Populate(AppInfoListView, " ", " ");
      Populate(AppInfoListView, "Entry Assembly", _entryAssemblyName);
      Populate(AppInfoListView, "Executing Assembly", _executingAssemblyName);
      Populate(AppInfoListView, "Calling Assembly", _callingAssemblyName);
    }

    // <summary>
    // populate Assembly Information listview with ALL assemblies
    // </summary>
    private void PopulateAssemblies()
    {
      foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        PopulateAssemblySummary(a);
      AssemblyNamesComboBox.SelectedIndex = AssemblyNamesComboBox.FindStringExact(_entryAssemblyName);
    }

    // <summary>
    // populate Assembly Information listview with summary view for a specific assembly
    // </summary>
    private void PopulateAssemblySummary(Assembly a)
    {
      var strAssemblyName = a.GetName().Name;
      var lvi = new ListViewItem
      {
        Text = strAssemblyName,
        Tag = strAssemblyName
      };
      if (strAssemblyName == _callingAssemblyName)
        lvi.Text += " (calling)";
      if (strAssemblyName == _executingAssemblyName)
        lvi.Text += " (executing)";
      if (strAssemblyName == _entryAssemblyName)
        lvi.Text += " (entry)";
      try
      {
        var nvc = AssemblyAttributes(a);
        lvi.SubItems.Add(nvc["version"]);
        lvi.SubItems.Add(nvc["builddate"]);
        lvi.SubItems.Add(nvc["codebase"]);
      }
      catch (Exception e)
      {
        lvi.Text += e.GetBaseException().Message;
      }

      //lvi.SubItems.Add(AssemblyVersion(a))
      //lvi.SubItems.Add(AssemblyBuildDatestring(a, true))
      //lvi.SubItems.Add(AssemblyCodeBase(a))
      AssemblyInfoListView.Items.Add(lvi);
      AssemblyNamesComboBox.Items.Add(strAssemblyName);
    }

    // <summary>
    // retrieves a cached value from the entry assembly attribute lookup collection
    // </summary>
    private string EntryAssemblyAttribute(string strName)
    {
      if (_entryAssemblyAttributeCollection[strName] == null)
        return ""; //<Assembly: Assembly" + strName + "(\"\")>
      return _entryAssemblyAttributeCollection[strName];
    }

    // <summary>
    // Populate all the form labels with tokenized text
    // </summary>
    private void PopulateLabels()
    {
      // get entry assembly attribs
      _entryAssemblyAttributeCollection = AssemblyAttributes(AppEntryAssembly);

      // set icon from parent, if present
      if (Owner == null)
      {
        ImagePictureBox.Visible = false;
        AppTitleLabel.Left = AppCopyrightLabel.Left;
        AppDescriptionLabel.Left = AppCopyrightLabel.Left;
      }
      else
      {
        Icon = Owner.Icon;
        ImagePictureBox.Image = Icon.ToBitmap();
      }
      // replace all labels and window title
      Text = ReplaceTokens(Text);
      AppTitleLabel.Text = ReplaceTokens(AppTitleLabel.Text);
      if (AppDescriptionLabel.Visible)
      {
        AppDescriptionLabel.Text = ReplaceTokens(AppDescriptionLabel.Text);
        var toGrow = TextRenderer.MeasureText(AppDescriptionLabel.Text, AppDescriptionLabel.Font).Width + AppDescriptionLabel.Left - ClientSize.Width;
        if (toGrow > 0)
          Width = Width + toGrow;
      }
      if (AppCopyrightLabel.Visible)
        AppCopyrightLabel.Text = ReplaceTokens(AppCopyrightLabel.Text);
      if (AppVersionLabel.Visible)
        AppVersionLabel.Text = ReplaceTokens(AppVersionLabel.Text);
      if (AppDateLabel.Visible)
        AppDateLabel.Text = ReplaceTokens(AppDateLabel.Text);
      if (MoreRichTextBox.Visible)
        MoreRichTextBox.Text = ReplaceTokens(MoreRichTextBox.Text);
    }

    // <summary>
    // perform assemblyinfo to string replacements on labels
    // </summary>
    private string ReplaceTokens(string s)
    {
      s = s.Replace("%title%", EntryAssemblyAttribute("title"));
      s = s.Replace("%copyright%", EntryAssemblyAttribute("copyright"));
      s = s.Replace("%description%", EntryAssemblyAttribute("description"));
      s = s.Replace("%company%", EntryAssemblyAttribute("company"));
      s = s.Replace("%product%", EntryAssemblyAttribute("product"));
      s = s.Replace("%trademark%", EntryAssemblyAttribute("trademark"));
      s = s.Replace("%year%", DateTime.Now.Year.ToString());
      s = s.Replace("%version%", EntryAssemblyAttribute("version"));
      s = s.Replace("%builddate%", EntryAssemblyAttribute("builddate"));
      return s;
    }

    // <summary>
    // populate details for a single assembly
    // </summary>
    private static void PopulateAssemblyDetails(Assembly a, ListView lvw)
    {
      lvw.Items.Clear();

      // this assembly property is only available in framework versions 1.1+
      Populate(lvw, "Image Runtime Version", a.ImageRuntimeVersion);
      Populate(lvw, "Loaded from GAC", a.GlobalAssemblyCache.ToString());
      try
      {
        var nvc = AssemblyAttributes(a);
        foreach (string strKey in nvc)
          Populate(lvw, strKey, nvc[strKey]);
      }
      catch (Exception e)
      {
        Populate(lvw, e.GetType().ToString(), e.Message);
      }
    }

    // <summary>
    // matches assembly by Assembly.GetName.Name; returns nothing if no match
    // </summary>
    private static Assembly MatchAssemblyByName(string assemblyName)
    {
      return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName);
    }

    // <summary>
    // things to do when form is loaded
    // </summary>
    private void AboutBoxLoad(object sender, EventArgs e)
    {
      // if the user didn't provide an assembly, try to guess which one is the entry assembly
      if (AppEntryAssembly == null)
        AppEntryAssembly = Assembly.GetEntryAssembly();
      if (AppEntryAssembly == null)
        AppEntryAssembly = Assembly.GetExecutingAssembly();

      _executingAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
      _callingAssemblyName = Assembly.GetCallingAssembly().GetName().Name;
      try
      {
        // for web hosted apps, GetEntryAssembly = nothing
        _entryAssemblyName = AppEntryAssembly.GetName().Name;
      }
      catch (Exception ex)
      {
        ex.TraceOut();
      }

      TabPanelDetails.Visible = false;
      if (!MoreRichTextBox.Visible)
        Height = Height - MoreRichTextBox.Height;
    }

    // <summary>
    // things to do when form is FIRST painted
    // </summary>
    private void AboutBoxPaint(object sender, PaintEventArgs e)
    {
      if (!_isPainted)
      {
        _isPainted = true;
        Application.DoEvents();
        Cursor.Current = Cursors.WaitCursor;
        PopulateLabels();
        Cursor.Current = Cursors.Default;
      }
    }

    // <summary>
    // expand about dialog to show additional advanced details
    // </summary>
    private void DetailsButtonClick(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      DetailsButton.Visible = false;
      SuspendLayout();
      MaximizeBox = true;
      FormBorderStyle = FormBorderStyle.Sizable;
      SizeGripStyle = SizeGripStyle.Show;
      Size = new Size(580, Size.Height + 200);
      MoreRichTextBox.Visible = false;
      TabPanelDetails.Visible = true;
      SysInfoButton.Visible = true;
      PopulateAssemblies();
      PopulateAppInfo();
      CenterToParent();
      ResumeLayout();
      Cursor.Current = Cursors.Default;
    }

    // <summary>
    // for detailed system info, launch the external Microsoft system info app
    // </summary>
    private void SysInfoButtonClick(object sender, EventArgs e)
    {
      ShowSysInfo();
    }

    // <summary>
    // if an assembly is double-clicked, go to the detail page for that assembly
    // </summary>
    private void AssemblyInfoListViewDoubleClick(object sender, EventArgs e)
    {
      if (AssemblyInfoListView.SelectedItems.Count > 0)
      {
        var strAssemblyName = Convert.ToString(AssemblyInfoListView.SelectedItems[0].Tag);
        AssemblyNamesComboBox.SelectedIndex = AssemblyNamesComboBox.FindStringExact(strAssemblyName);
        TabPanelDetails.SelectedTab = TabPageAssemblyDetails;
      }
    }

    // <summary>
    // if a new assembly is selected from the combo box, show details for that assembly
    // </summary>
    private void AssemblyNamesComboBoxSelectedIndexChanged(object sender, EventArgs e)
    {
      var strAssemblyName = Convert.ToString(AssemblyNamesComboBox.SelectedItem);
      PopulateAssemblyDetails(MatchAssemblyByName(strAssemblyName), AssemblyDetailsListView);
    }

    // <summary>
    // sort the assembly list by column
    // </summary>
    private void AssemblyInfoListViewColumnClick(object sender, ColumnClickEventArgs e)
    {
      var intTargetCol = e.Column + 1;
      if (AssemblyInfoListView.Tag != null && Math.Abs(Convert.ToInt32(AssemblyInfoListView.Tag)) == intTargetCol)
        intTargetCol = -Convert.ToInt32(AssemblyInfoListView.Tag);
      AssemblyInfoListView.Tag = intTargetCol;
      AssemblyInfoListView.ListViewItemSorter = new ListViewItemComparer(intTargetCol, true);
    }

    // <summary>
    // launch any http:// or mailto: links clicked in the body of the rich text box
    // </summary>
    private void MoreRichTextBoxLinkClicked(object sender, LinkClickedEventArgs e)
    {
      try
      {
        Process.Start(e.LinkText);
      }
      catch (Exception ex)
      {
        ex.TraceOut();
      }
    }

    // <summary>
    // things to do when the selected tab is changed
    // </summary>
    private class ListViewItemComparer : IComparer
    {
      private readonly int _intCol;
      private readonly bool _isAscending;

      public ListViewItemComparer(int column, bool ascending)
      {
        _isAscending = column >= 0 && ascending;
        _intCol = Math.Abs(column) - 1;
      }

      public int Compare(object x, object y)
      {
        var intResult = String.CompareOrdinal(((ListViewItem) x).SubItems[_intCol].Text, ((ListViewItem) y).SubItems[_intCol].Text);

        if (_isAscending)
          return intResult;
        return -intResult;
      }
    }

    private void TabPanelDetailsSelectedIndexChanged(object sender, EventArgs e)
    {
      if (TabPanelDetails.SelectedTab == TabPageAssemblyDetails)
        AssemblyNamesComboBox.Focus();
    }
  }
}