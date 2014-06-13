using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
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
  public partial class AboutBox : Form
  {
    public AboutBox(string moreInfo)
    {
      InitializeComponent();
      AppMoreInfo += moreInfo;
    }

    private bool _IsPainted;
    private string _EntryAssemblyName;
    private string _CallingAssemblyName;
    private string _ExecutingAssemblyName;
    private Assembly _EntryAssembly;
    private NameValueCollection _EntryAssemblyAttribCollection;

    // <summary>
    // returns the entry assembly for the current application domain
    // </summary>
    // <remarks>
    // This is usually read-only, but in some weird cases (Smart Client apps) 
    // you won't have an entry assembly, so you may want to set this manually.
    // </remarks>
    public Assembly AppEntryAssembly
    {
      get { return _EntryAssembly; }
      set { _EntryAssembly = value; }
    }

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
        {
          AppDescriptionLabel.Visible = false;
        }
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
        {
          AppVersionLabel.Visible = false;
        }
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
        {
          AppCopyrightLabel.Visible = false;
        }
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
        if (string.IsNullOrEmpty(value))
        {
          MoreRichTextBox.Visible = false;
        }
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
    private DateTime AssemblyLastWriteTime(Assembly a)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(a.Location))
          return DateTime.MaxValue;
        return File.GetLastWriteTime(a.Location);
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
    private DateTime AssemblyBuildDate(Assembly a, bool ForceFileDate)
    {
      var AssemblyVersion = a.GetName().Version;
      DateTime dt;

      if (ForceFileDate)
      {
        dt = AssemblyLastWriteTime(a);
      }
      else
      {
        dt = DateTime.Parse("01/01/2000").AddDays(AssemblyVersion.Build).AddSeconds(AssemblyVersion.Revision*2);
        if (TimeZone.IsDaylightSavingTime(dt, TimeZone.CurrentTimeZone.GetDaylightChanges(dt.Year)))
        {
          dt = dt.AddHours(1);
        }
        if (dt > DateTime.Now || AssemblyVersion.Build < 730 || AssemblyVersion.Revision == 0)
        {
          dt = AssemblyLastWriteTime(a);
        }
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
    private NameValueCollection AssemblyAttribs(Assembly a)
    {
      string theName;
      var nvc = new NameValueCollection();
      var r = new Regex(@"(\.Assembly|\.)(?<Name>[^.]*)Attribute$", RegexOptions.IgnoreCase);

      foreach (var attrib in a.GetCustomAttributes(false))
      {
        var TypeName = attrib.GetType().ToString();
        theName = r.Match(TypeName).Groups["Name"].ToString();
        string Value;
        switch (TypeName)
        {
          case "System.CLSCompliantAttribute":
            Value = ((CLSCompliantAttribute) attrib).IsCompliant.ToString();
            break;
          case "System.Diagnostics.DebuggableAttribute":
            Value = ((DebuggableAttribute) attrib).IsJITTrackingEnabled.ToString();
            break;
          case "System.Reflection.AssemblyCompanyAttribute":
            Value = ((AssemblyCompanyAttribute) attrib).Company;
            break;
          case "System.Reflection.AssemblyConfigurationAttribute":
            Value = ((AssemblyConfigurationAttribute) attrib).Configuration;
            break;
          case "System.Reflection.AssemblyCopyrightAttribute":
            Value = ((AssemblyCopyrightAttribute) attrib).Copyright;
            break;
          case "System.Reflection.AssemblyDefaultAliasAttribute":
            Value = ((AssemblyDefaultAliasAttribute) attrib).DefaultAlias;
            break;
          case "System.Reflection.AssemblyDelaySignAttribute":
            Value = ((AssemblyDelaySignAttribute) attrib).DelaySign.ToString();
            break;
          case "System.Reflection.AssemblyDescriptionAttribute":
            Value = ((AssemblyDescriptionAttribute) attrib).Description;
            break;
          case "System.Reflection.AssemblyInformationalVersionAttribute":
            Value = ((AssemblyInformationalVersionAttribute) attrib).InformationalVersion;
            break;
          case "System.Reflection.AssemblyKeyFileAttribute":
            Value = ((AssemblyKeyFileAttribute) attrib).KeyFile;
            break;
          case "System.Reflection.AssemblyProductAttribute":
            Value = ((AssemblyProductAttribute) attrib).Product;
            break;
          case "System.Reflection.AssemblyTrademarkAttribute":
            Value = ((AssemblyTrademarkAttribute) attrib).Trademark;
            break;
          case "System.Reflection.AssemblyTitleAttribute":
            Value = ((AssemblyTitleAttribute) attrib).Title;
            break;
          case "System.Resources.NeutralResourcesLanguageAttribute":
            Value = ((NeutralResourcesLanguageAttribute) attrib).CultureName;
            break;
          case "System.Resources.SatelliteContractVersionAttribute":
            Value = ((SatelliteContractVersionAttribute) attrib).Version;
            break;
          case "System.Runtime.InteropServices.ComCompatibleVersionAttribute":
          {
            var x = ((ComCompatibleVersionAttribute) attrib);
            Value = x.MajorVersion + "." + x.MinorVersion + "." + x.RevisionNumber + "." + x.BuildNumber;
            break;
          }
          case "System.Runtime.InteropServices.ComVisibleAttribute":
            Value = ((ComVisibleAttribute) attrib).Value.ToString();
            break;
          case "System.Runtime.InteropServices.GuidAttribute":
            Value = ((GuidAttribute) attrib).Value;
            break;
          case "System.Runtime.InteropServices.TypeLibVersionAttribute":
          {
            var x = ((TypeLibVersionAttribute) attrib);
            Value = x.MajorVersion + "." + x.MinorVersion;
            break;
          }
          case "System.Security.AllowPartiallyTrustedCallersAttribute":
            Value = "(Present)";
            break;
          default:
            // debug.writeline("** unknown assembly attribute '" + TypeName + "'")
            Value = TypeName;
            break;
        }

        if (nvc[theName] == null)
        {
          nvc.Add(theName, Value);
        }
      }

      // add some extra values that are not in the AssemblyInfo, but nice to have
      // codebase
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
        if (a.GetName().Version.Major == 0 && a.GetName().Version.Minor == 0)
        {
          nvc.Add("Version", "(unknown)");
        }
        else
        {
          nvc.Add("Version", a.GetName().Version.ToString());
        }
      }
      catch (Exception)
      {
        nvc.Add("Version", "(unknown)");
      }

      nvc.Add("FullName", a.FullName);

      return nvc;
    }

    // <summary>
    // reads an HKLM Windows Registry key value
    // </summary>
    private string RegistryHklmValue(string KeyName, string SubKeyRef)
    {
      try
      {
        var rk = Registry.LocalMachine.OpenSubKey(KeyName);
        if (rk != null) return (string) rk.GetValue(SubKeyRef, "");
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
      {
        strSysInfoPath = RegistryHklmValue(@"SOFTWARE\Microsoft\Shared Tools\MSINFO", "PATH");
      }

      if (strSysInfoPath == "")
      {
        MessageBox.Show("System Information is unavailable at this time." +
                        Environment.NewLine +
                        Environment.NewLine +
                        "(couldn't find path for Microsoft System Information Tool in the registry.)",
          Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        Process.Start(strSysInfoPath);
      }
      catch (Exception)
      {
        MessageBox.Show("System Information is unavailable at this time." +
                        Environment.NewLine +
                        Environment.NewLine +
                        "(couldn't launch '" + strSysInfoPath + "')",
          Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
    }

    // <summary>
    // populate a listview with the specified key and value strings
    // </summary>
    private void Populate(ListView lvw, string Key, string Value)
    {
      if (Value == "")
        return;
      var lvi = new ListViewItem();
      lvi.Text = Key;
      lvi.SubItems.Add(Value);
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
      Populate(AppInfoListView, "Entry Assembly", _EntryAssemblyName);
      Populate(AppInfoListView, "Executing Assembly", _ExecutingAssemblyName);
      Populate(AppInfoListView, "Calling Assembly", _CallingAssemblyName);
    }

    // <summary>
    // populate Assembly Information listview with ALL assemblies
    // </summary>
    private void PopulateAssemblies()
    {
      foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
      {
        PopulateAssemblySummary(a);
      }
      AssemblyNamesComboBox.SelectedIndex = AssemblyNamesComboBox.FindStringExact(_EntryAssemblyName);
    }

    // <summary>
    // populate Assembly Information listview with summary view for a specific assembly
    // </summary>
    private void PopulateAssemblySummary(Assembly a)
    {
      var nvc = AssemblyAttribs(a);

      var strAssemblyName = a.GetName().Name;

      var lvi = new ListViewItem();
      lvi.Text = strAssemblyName;
      lvi.Tag = strAssemblyName;
      if (strAssemblyName == _CallingAssemblyName)
      {
        lvi.Text += " (calling)";
      }
      if (strAssemblyName == _ExecutingAssemblyName)
      {
        lvi.Text += " (executing)";
      }
      if (strAssemblyName == _EntryAssemblyName)
      {
        lvi.Text += " (entry)";
      }
      lvi.SubItems.Add(nvc["version"]);
      lvi.SubItems.Add(nvc["builddate"]);
      lvi.SubItems.Add(nvc["codebase"]);
      //lvi.SubItems.Add(AssemblyVersion(a))
      //lvi.SubItems.Add(AssemblyBuildDatestring(a, true))
      //lvi.SubItems.Add(AssemblyCodeBase(a))
      AssemblyInfoListView.Items.Add(lvi);
      AssemblyNamesComboBox.Items.Add(strAssemblyName);
    }

    // <summary>
    // retrieves a cached value from the entry assembly attribute lookup collection
    // </summary>
    private string EntryAssemblyAttrib(string strName)
    {
      if (_EntryAssemblyAttribCollection[strName] == null)
      {
        return "<Assembly: Assembly" + strName + "(\"\")>";
      }
      return _EntryAssemblyAttribCollection[strName];
    }

    // <summary>
    // Populate all the form labels with tokenized text
    // </summary>
    private void PopulateLabels()
    {
      // get entry assembly attribs
      _EntryAssemblyAttribCollection = AssemblyAttribs(_EntryAssembly);

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
      }
      if (AppCopyrightLabel.Visible)
      {
        AppCopyrightLabel.Text = ReplaceTokens(AppCopyrightLabel.Text);
      }
      if (AppVersionLabel.Visible)
      {
        AppVersionLabel.Text = ReplaceTokens(AppVersionLabel.Text);
      }
      if (AppDateLabel.Visible)
      {
        AppDateLabel.Text = ReplaceTokens(AppDateLabel.Text);
      }
      if (MoreRichTextBox.Visible)
      {
        MoreRichTextBox.Text = ReplaceTokens(MoreRichTextBox.Text);
      }
    }

    // <summary>
    // perform assemblyinfo to string replacements on labels
    // </summary>
    private string ReplaceTokens(string s)
    {
      s = s.Replace("%title%", EntryAssemblyAttrib("title"));
      s = s.Replace("%copyright%", EntryAssemblyAttrib("copyright"));
      s = s.Replace("%description%", EntryAssemblyAttrib("description"));
      s = s.Replace("%company%", EntryAssemblyAttrib("company"));
      s = s.Replace("%product%", EntryAssemblyAttrib("product"));
      s = s.Replace("%trademark%", EntryAssemblyAttrib("trademark"));
      s = s.Replace("%year%", DateTime.Now.Year.ToString());
      s = s.Replace("%version%", EntryAssemblyAttrib("version"));
      s = s.Replace("%builddate%", EntryAssemblyAttrib("builddate"));
      return s;
    }

    // <summary>
    // populate details for a single assembly
    // </summary>
    private void PopulateAssemblyDetails(Assembly a, ListView lvw)
    {
      lvw.Items.Clear();

      // this assembly property is only available in framework versions 1.1+
      Populate(lvw, "Image Runtime Version", a.ImageRuntimeVersion);
      Populate(lvw, "Loaded from GAC", a.GlobalAssemblyCache.ToString());

      var nvc = AssemblyAttribs(a);
      foreach (string strKey in nvc)
      {
        Populate(lvw, strKey, nvc[strKey]);
      }
    }

    // <summary>
    // matches assembly by Assembly.GetName.Name; returns nothing if no match
    // </summary>
    private Assembly MatchAssemblyByName(string AssemblyName)
    {
      foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
      {
        if (a.GetName().Name == AssemblyName)
        {
          return a;
        }
      }
      return null;
    }

    // <summary>
    // things to do when form is loaded
    // </summary>
    private void AboutBox_Load(object sender, EventArgs e)
    {
      // if the user didn't provide an assembly, try to guess which one is the entry assembly
      if (_EntryAssembly == null)
      {
        _EntryAssembly = Assembly.GetEntryAssembly();
      }
      if (_EntryAssembly == null)
      {
        _EntryAssembly = Assembly.GetExecutingAssembly();
      }

      _ExecutingAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
      _CallingAssemblyName = Assembly.GetCallingAssembly().GetName().Name;
      try
      {
        // for web hosted apps, GetEntryAssembly = nothing
        _EntryAssemblyName = _EntryAssembly.GetName().Name;
      }
      catch (Exception ex)
      {
        ex.TraceOut();
      }

      TabPanelDetails.Visible = false;
      if (!MoreRichTextBox.Visible)
      {
        Height = Height - MoreRichTextBox.Height;
      }
    }

    // <summary>
    // things to do when form is FIRST painted
    // </summary>
    private void AboutBox_Paint(object sender, PaintEventArgs e)
    {
      if (!_IsPainted)
      {
        _IsPainted = true;
        Application.DoEvents();
        Cursor.Current = Cursors.WaitCursor;
        PopulateLabels();
        Cursor.Current = Cursors.Default;
      }
    }

    // <summary>
    // expand about dialog to show additional advanced details
    // </summary>
    private void DetailsButton_Click(object sender, EventArgs e)
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
    private void SysInfoButton_Click(object sender, EventArgs e)
    {
      ShowSysInfo();
    }

    // <summary>
    // if an assembly is double-clicked, go to the detail page for that assembly
    // </summary>
    private void AssemblyInfoListView_DoubleClick(object sender, EventArgs e)
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
    private void AssemblyNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      var strAssemblyName = Convert.ToString(AssemblyNamesComboBox.SelectedItem);
      PopulateAssemblyDetails(MatchAssemblyByName(strAssemblyName), AssemblyDetailsListView);
    }

    // <summary>
    // sort the assembly list by column
    // </summary>
    private void AssemblyInfoListView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      var intTargetCol = e.Column + 1;

      if (AssemblyInfoListView.Tag != null)
      {
        if (Math.Abs(Convert.ToInt32(AssemblyInfoListView.Tag)) == intTargetCol)
        {
          intTargetCol = -Convert.ToInt32(AssemblyInfoListView.Tag);
        }
      }
      AssemblyInfoListView.Tag = intTargetCol;
      AssemblyInfoListView.ListViewItemSorter = new ListViewItemComparer(intTargetCol, true);
    }

    // <summary>
    // launch any http:// or mailto: links clicked in the body of the rich text box
    // </summary>
    private void MoreRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
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
      private readonly bool _IsAscending = true;

      public ListViewItemComparer()
      {
        _intCol = 0;
        _IsAscending = true;
      }

      public ListViewItemComparer(int column, bool ascending)
      {
        _IsAscending = column >= 0 && @ascending;
        _intCol = Math.Abs(column) - 1;
      }

      public int Compare(object x, object y)
      {
        var intResult =
          string.Compare(((ListViewItem) x).SubItems[_intCol].Text, ((ListViewItem) y).SubItems[_intCol].Text);

        if (_IsAscending)
        {
          return intResult;
        }
        return -intResult;
      }
    }

    private void TabPanelDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (TabPanelDetails.SelectedTab == TabPageAssemblyDetails)
        AssemblyNamesComboBox.Focus();
    }
  }
}