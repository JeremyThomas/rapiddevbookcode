using System.IO;
using System.Windows.Forms;
using AW.Helper;

namespace AW.DebugVisualizers
{
  public partial class FormDebuggerVisualizerInstaller : Form
  {
    private readonly string _destFileNameAll;

    public FormDebuggerVisualizerInstaller()
    {
      InitializeComponent();
      linkLabelAll.Text = VisualStudioHelper.GetVisualStudioDebuggerVisualizersDir(VisualStudioVersion.VS2013);
      linkLabelAll.Links.Add(0, linkLabelAll.Text.Length, linkLabelAll.Text);
      _destFileNameAll = DestFileNameAll();
      GetAllStatus();
      linkLabelWebSite.Links.Add(235, 313); //"https://rapiddevbookcode.codeplex.com/wikipage?title=EnumerableDebugVisualizer"
    }

    private void GetAllStatus()
    {
      var targetVisualizerFileInfoAll = new FileInfo(_destFileNameAll);
      if (targetVisualizerFileInfoAll.Exists)
        labelStatusAll.Text = "Installed";
    }

    private void label1_Click(object sender, System.EventArgs e)
    {

    }

    private void buttonInstallAllUsers_Click(object sender, System.EventArgs e)
    {
      File.Copy(Application.ExecutablePath, _destFileNameAll);
      GetAllStatus();
    }

    private string DestFileNameAll()
    {
      return Path.Combine(linkLabelAll.Text, Path.GetFileName(Application.ExecutablePath));
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }

    private void linkLabelAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }
  }
}
