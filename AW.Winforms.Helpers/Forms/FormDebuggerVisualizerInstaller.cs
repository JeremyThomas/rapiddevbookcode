using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Winforms.Helpers.Forms
{
  public sealed partial class FormDebuggerVisualizerInstaller : FrmPersistantLocation
  {
    private readonly string _destinationFileNameAll;
    private readonly string _destinationFileNameUser;
    private static readonly FileInfo SourceVisualizerFileInfo = new FileInfo(Application.ExecutablePath);
    private static readonly FileVersionInfo SourceVisualizerFileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
    private static readonly string SourceFileName = Path.GetFileName(Application.ExecutablePath);
    private FileInfo _destinationVisualizerFileInfoAll;
    private FileInfo _destinationVisualizerFileInfoUser;
    private readonly string _title;

    public FormDebuggerVisualizerInstaller()
    {
      InitializeComponent();
    }

    /// <exception cref="ArgumentOutOfRangeException"><paramref /> is less than zero or greater than the length of this instance. </exception>
    /// <exception cref="ArgumentNullException"><paramref /> is null. </exception>
    /// <exception cref="NotSupportedException">The current assembly is a dynamic assembly, represented by an <see cref="T:System.Reflection.Emit.AssemblyBuilder" /> object. </exception>
    /// <exception cref="FileNotFoundException">The file specified cannot be found. </exception>
    /// <exception cref="IOException"><see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot initialize the data. </exception>
    /// <exception cref="PlatformNotSupportedException">The current operating system is not Windows NT or later.</exception>
    public FormDebuggerVisualizerInstaller(Type dialogVisualizerServiceType, string title, string description) : this()
    {
      var microsoftVisualStudioDebuggerVisualizersAssembly = Assembly.GetAssembly(dialogVisualizerServiceType);
      var fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly = FileVersionInfo.GetVersionInfo(microsoftVisualStudioDebuggerVisualizersAssembly.Location);
      var visualStudioVersion = VisualStudioHelper.GetVisualStudioVersion(fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly.ProductMajorPart);

      labelVersion.Text = string.Format("This is version {0} for {1}. Last modified: {2}", SourceVisualizerFileVersionInfo.ProductVersion,
        fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly.ProductName, SourceVisualizerFileInfo.LastWriteTime);

      linkLabelAll.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersDir(visualStudioVersion);
      linkLabelAll.Links.Add(0, linkLabelAll.Text.Length, linkLabelAll.Text);
      linkLabelUser.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersUserDir(visualStudioVersion);
      linkLabelUser.Links.Add(0, linkLabelUser.Text.Length, linkLabelUser.Text);
      _destinationFileNameAll = Path.Combine(linkLabelAll.Text, SourceFileName);
      try
      {
        _destinationFileNameUser = Path.Combine(linkLabelUser.Text, SourceFileName);
      }
      catch (ArgumentException)
      {
      }
      GetAllStatus();
      GetUserStatus();
      _title = title;
      Text = string.Format("{0} Installer", _title);
      linkLabelWebSite.Text = description;
      var indexOfHyperLink = linkLabelWebSite.Text.IndexOf("https", StringComparison.Ordinal);
      linkLabelWebSite.Links.Add(indexOfHyperLink, linkLabelWebSite.Text.Length,
        linkLabelWebSite.Text.Substring(indexOfHyperLink));
    }

    private void GetAllStatus()
    {
      _destinationVisualizerFileInfoAll = GetStatus(_destinationFileNameAll, labelStatusAll);
    }

    private void GetUserStatus()
    {
      _destinationVisualizerFileInfoUser = GetStatus(_destinationFileNameUser, labelStatusUser);
    }

    private static FileInfo GetStatus(string destinationFileName, Control statusLabel)
    {
      if (destinationFileName == null)
        return null;
      var visualizerFileInfoUser = new FileInfo(destinationFileName);
      if (visualizerFileInfoUser.Exists)
      {
        var fileVersionInfo = FileVersionInfo.GetVersionInfo(destinationFileName);
        statusLabel.Text = string.Format("Installed. Version:{0} Last modified: {1}", fileVersionInfo.ProductVersion, visualizerFileInfoUser.LastWriteTime);
      }
      return visualizerFileInfoUser;
    }

    private static FileInfo CopyVisualizer(FileSystemInfo sourceVisualizerFileInfo, FileSystemInfo destinationVisualizerFileInfo, Control statusLabel)
    {
      if (destinationVisualizerFileInfo.Exists && sourceVisualizerFileInfo.LastWriteTime > destinationVisualizerFileInfo.LastWriteTime)
        File.Copy(Application.ExecutablePath, destinationVisualizerFileInfo.FullName, true);
      else
        File.Copy(Application.ExecutablePath, destinationVisualizerFileInfo.FullName);
      return GetStatus(destinationVisualizerFileInfo.FullName, statusLabel);
    }

    private void buttonInstallAllUsers_Click(object sender, EventArgs e)
    {
      try
      {
        _destinationVisualizerFileInfoAll = CopyVisualizer(SourceVisualizerFileInfo, _destinationVisualizerFileInfoAll, labelStatusAll);
      }
      catch (UnauthorizedAccessException ex)
      {
        labelStatusAll.Text = ex.Message;
      }
      catch (IOException ex)
      {
        labelStatusUser.Text = ex.Message;
      }
    }

    private void buttonInstallCurrentUser_Click(object sender, EventArgs e)
    {
      try
      {
        _destinationVisualizerFileInfoUser = CopyVisualizer(SourceVisualizerFileInfo, _destinationVisualizerFileInfoUser, labelStatusUser);
      }
      catch (IOException ex)
      {
        labelStatusUser.Text = ex.Message;
      }
    }

    private void linkLabelAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(e.Link.LinkData.ToString());
    }

    private void buttonAbout_Click(object sender, EventArgs e)
    {
      AboutBox.ShowAboutBox(this);
    }

    private void buttonRegistered_Click(object sender, EventArgs e)
    {
      var debuggerVisualizerAttributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof (DebuggerVisualizerAttribute), false);
      var form = new FrmPersistantLocation { Icon = Icon,
        Text = string.Format("These are {0} classes that the {1} is registered to display", debuggerVisualizerAttributes.Length, _title),
        Width = this.Width
      };
      var textBox = new TextBox
      {
        Dock = DockStyle.Fill,
        Multiline = true,
        ReadOnly = true,
        ScrollBars = ScrollBars.Both,
        WordWrap = false,
        Text = debuggerVisualizerAttributes.OfType<DebuggerVisualizerAttribute>().Select(dv => dv.TargetTypeName).JoinAsString(Environment.NewLine)
      };
      form.Controls.Add(textBox);
      form.ShowDialog();
    }
  }
}