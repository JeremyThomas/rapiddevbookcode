using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.Forms
{
  public partial class WcfServiceManager : Form
  {
    private readonly Func<IEnumerable<ServiceHost>> _startService;
    private readonly Func<bool> _stopservice;

    public WcfServiceManager()
    {
      // if you're using the ORM Profiler, uncomment the line below and add a reference to the interceptor dll.
      // SD.Tools.OrmProfiler.Interceptor.InterceptorCore.Initialize("WCF Host");
      //      CommonEntityBase.Initialize();

      InitializeComponent();
    }

    public WcfServiceManager(Func<IEnumerable<ServiceHost>> startService, Func<bool> stopservice) : this()
    {
      _startService = startService;
      _stopservice = stopservice;      
      start_Click(this, null);
    }

    private void start_Click(object sender, EventArgs e)
    {
      var serviceHosts = _startService();
      ClearTableLayoutPanel();
      foreach (var serviceHost in serviceHosts.Where(serviceHost => serviceHost.State == CommunicationState.Opened))
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

    private void stop_Click(object sender, EventArgs e)
    {
      if (_stopservice())
      {
        _serviceState.Text = "Closed";
        ClearTableLayoutPanel();
      }
    }

    private void ClearTableLayoutPanel()
    {
      tableLayoutPanelMetaData.Controls.Clear();
      tableLayoutPanelMetaData.RowCount = 0;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      _stopservice();
    }

    private static void linkLabelWsdl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(e.Link.LinkData.ToString());
      e.Link.Visited = true;
    }
  }
}