using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace AW.DebugVisualizers
{
  public sealed partial class FormDebuggerVisualizerInstaller : Form
  {
    private readonly string _destinationFileNameAll;
    private readonly string _destinationFileNameUser;
    private static readonly FileInfo SourceVisualizerFileInfo = new FileInfo(Application.ExecutablePath);
    private static readonly FileVersionInfo SourceVisualizerFileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
    private static readonly string SourceFileName = Path.GetFileName(Application.ExecutablePath);
    private FileInfo _destinationVisualizerFileInfoAll;
    private FileInfo _destinationVisualizerFileInfoUser;

    public FormDebuggerVisualizerInstaller()
    {
      InitializeComponent();
      var microsoftVisualStudioDebuggerVisualizersAssembly = Assembly.GetAssembly(typeof (IDialogVisualizerService));
      var fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly = FileVersionInfo.GetVersionInfo(microsoftVisualStudioDebuggerVisualizersAssembly.Location);
      var visualStudioVersion = VisualStudioHelper.GetVisualStudioVersion(fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly.ProductMajorPart);
   
      labelVersion.Text = "This is version " + SourceVisualizerFileVersionInfo.ProductVersion + " for "
                          + fileVersionInfoMicrosoftVisualStudioDebuggerVisualizersAssembly.ProductName + ". Last modified: " + SourceVisualizerFileInfo.LastWriteTime;

      linkLabelAll.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersDir(visualStudioVersion);
      linkLabelAll.Links.Add(0, linkLabelAll.Text.Length, linkLabelAll.Text);
      linkLabelUser.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersUserDir(visualStudioVersion);
      linkLabelUser.Links.Add(0, linkLabelUser.Text.Length, linkLabelUser.Text);
      _destinationFileNameAll = Path.Combine(linkLabelAll.Text, SourceFileName);
      _destinationFileNameUser = Path.Combine(linkLabelUser.Text, SourceFileName);
      GetAllStatus();
      GetUserStatus();
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
      var visualizerFileInfoUser = new FileInfo(destinationFileName);
      if (visualizerFileInfoUser.Exists)
      {
        var fileVersionInfo = FileVersionInfo.GetVersionInfo(destinationFileName);
        statusLabel.Text = "Installed. Version:" + fileVersionInfo.ProductVersion + " Last modified: " + visualizerFileInfoUser.LastWriteTime;
      }
      return visualizerFileInfoUser;
    }

    private static FileInfo CopyVisualizer(FileInfo sourceVisualizerFileInfo, FileInfo destinationVisualizerFileInfo, Control statusLabel)
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
  }
}