using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AW.Helper;

namespace AW.DebugVisualizers
{
  public partial class FormDebuggerVisualizerInstaller : Form
  {
    private readonly string _destFileNameAll;
    private readonly string _destFileNameUser;

    public FormDebuggerVisualizerInstaller()
    {
      InitializeComponent();
      linkLabelAll.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersDir(VisualStudioVersion.VS2013);
      linkLabelAll.Links.Add(0, linkLabelAll.Text.Length, linkLabelAll.Text);
      linkLabelUser.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersUserDir(VisualStudioVersion.VS2013);
      linkLabelUser.Links.Add(0, linkLabelUser.Text.Length, linkLabelUser.Text);
      _destFileNameAll = DestFileNameAll();
      _destFileNameUser = DestFileNameUser();
      GetAllStatus();
      GetUserStatus();
      linkLabelWebSite.Links.Add(234, linkLabelWebSite.Text.Length,"https://rapiddevbookcode.codeplex.com/wikipage?title=EnumerableDebugVisualizer");
    }

    private void GetAllStatus()
    {
      var targetVisualizerFileInfoAll = new FileInfo(_destFileNameAll);
      if (targetVisualizerFileInfoAll.Exists)
        labelStatusAll.Text = "Installed";
    }

    private void GetUserStatus()
    {
      var targetVisualizerFileInfoUser = new FileInfo(_destFileNameUser);
      if (targetVisualizerFileInfoUser.Exists)
        labelStatusUser.Text = "Installed";
    }

    private void buttonInstallAllUsers_Click(object sender, EventArgs e)
    {
      try
      {
        File.Copy(Application.ExecutablePath, _destFileNameAll);
        GetAllStatus();
      }
      catch (UnauthorizedAccessException ex)
      {
        labelStatusAll.Text = ex.Message;
      }
    }

    private void buttonInstallCurrentUser_Click(object sender, EventArgs e)
    {
      try
      {
        File.Copy(Application.ExecutablePath, _destFileNameUser);
        GetUserStatus();
      }
      catch (IOException ex)
      {
        var sourceVisualizerFileInfo = new FileInfo(Application.ExecutablePath);
        var targetVisualizerFileInfo = new FileInfo(_destFileNameUser);
        if (sourceVisualizerFileInfo.LastWriteTime > targetVisualizerFileInfo.LastWriteTime)
        {
          File.Copy(Application.ExecutablePath, _destFileNameUser, true);
          GetUserStatus();
        }
        else
          labelStatusUser.Text = ex.Message;
      }
    }

    private string DestFileNameAll()
    {
      return Path.Combine(linkLabelAll.Text, Path.GetFileName(Application.ExecutablePath));
    }

    private string DestFileNameUser()
    {
      return Path.Combine(linkLabelUser.Text, Path.GetFileName(Application.ExecutablePath));
    }

    private void linkLabelAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(e.Link.LinkData.ToString());
    }
  }
}