using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using Northwind.DAL.EntityClasses;

namespace Northwind.Business.WCF.Host
{
  public partial class WcfServiceManager : Form
  {
    public WcfServiceManager()
    {
      // if you're using the ORM Profiler, uncomment the line below and add a reference to the interceptor dll.
      // SD.Tools.OrmProfiler.Interceptor.InterceptorCore.Initialize("WCF Host");

      InitializeComponent();
      CommonEntityBase.Initialize();
      start_Click(this, null);
    }

    private void start_Click(object sender, EventArgs e)
    {
      var serviceHosts = WcfServiceHost.StartService();
      tableLayoutPanelMetaData.RowCount = 0;
      foreach (var serviceHost in serviceHosts)
      {
        if (serviceHost.State == CommunicationState.Opened)
        {
          tableLayoutPanelMetaData.RowCount++;
          var linkLabelWsdl = new LinkLabel {AutoSize = true};
          linkLabelWsdl.LinkClicked += linkLabelWsdl_LinkClicked;
          tableLayoutPanelMetaData.Controls.Add(linkLabelWsdl);
          tableLayoutPanelMetaData.SetRow(linkLabelWsdl, tableLayoutPanelMetaData.RowCount - 1);
          linkLabelWsdl.Text = serviceHost.BaseAddresses.First().ToString();
          linkLabelWsdl.Links.Add(0, linkLabelWsdl.Text.Length, linkLabelWsdl.Text);
          _serviceState.Text = "Opened";
        }
      }
    }

    private void stop_Click(object sender, EventArgs e)
    {
      if (WcfServiceHost.StopService())
        _serviceState.Text = "Closed";
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      WcfServiceHost.StopService();
    }

    private static void linkLabelWsdl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(e.Link.LinkData.ToString());
      e.Link.Visited = true;
    }
  }
}