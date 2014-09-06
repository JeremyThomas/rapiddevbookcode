using System;
using System.Linq;
using System.Windows.Forms;
using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Services.WCF.Host
{
  public partial class WcfDataServiceManager : Form
  {
    public WcfDataServiceManager()
    {
      // if you're using the ORM Profiler, uncomment the line below and add a reference to the interceptor dll.
      // SD.Tools.OrmProfiler.Interceptor.InterceptorCore.Initialize("WCF Host");

      InitializeComponent();
      CommonEntityBase.Initialize();
      start_Click(this, null);
    }

    private void start_Click(object sender, EventArgs e)
    {
      var serviceHost = WcfDataServiceHost.StartService();
      if (serviceHost.State == System.ServiceModel.CommunicationState.Opened)
      {
        linkLabelWsdl.Text = serviceHost.BaseAddresses.First().ToString();
        linkLabelWsdl.Links.Add(0, linkLabelWsdl.Text.Length, linkLabelWsdl.Text);
        _serviceState.Text = "Opened";
      }
    }

    private void stop_Click(object sender, EventArgs e)
    {
      if (WcfDataServiceHost.StopService())
      {
        _serviceState.Text = "Closed";
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      WcfDataServiceHost.StopService();
    }

    private void linkLabelWsdl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(linkLabelWsdl.Links[0].LinkData.ToString());
      linkLabelWsdl.LinkVisited = true;
    }
  }
}