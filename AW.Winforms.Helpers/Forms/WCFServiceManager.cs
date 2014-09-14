using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
      if (ToggleOnOff.Text == "Start WCF Service")
      {
        var serviceHosts = _startService();
        ClearTableLayoutPanel();
        foreach (var serviceHost in serviceHosts.Where(serviceHost => serviceHost.State == CommunicationState.Opened).OrderBy(serviceHost => serviceHost.Description.Name))
        {
          //Next, add a row.  Only do this when once, when creating the first column
          if (tableLayoutPanelMetaData.RowCount == 0)
            tableLayoutPanelMetaData.RowStyles.Add(new RowStyle(SizeType.AutoSize));
          tableLayoutPanelMetaData.RowCount++;
          var linkLabelWsdl = new LinkLabel {AutoSize = true};
          linkLabelWsdl.LinkClicked += linkLabelWsdl_LinkClicked;
          tableLayoutPanelMetaData.Controls.Add(linkLabelWsdl);
          linkLabelWsdl.Dock = DockStyle.Fill;
          tableLayoutPanelMetaData.SetRow(linkLabelWsdl, tableLayoutPanelMetaData.RowCount - 1);
          linkLabelWsdl.Text = serviceHost.BaseAddresses.First().ToString();
          linkLabelWsdl.Links.Add(0, linkLabelWsdl.Text.Length, linkLabelWsdl.Text);
          _serviceState.Text = "Opened";
        }
        ToggleOnOff.Text = "Stop WCF Service";
        ToggleOnOff.BackColor = Color.LightCoral;
      }
      else if (_stopservice())
      {
        _serviceState.Text = "Closed";
        ClearTableLayoutPanel();
        ToggleOnOff.Text = "Start WCF Service";
        ToggleOnOff.BackColor = Color.PaleGreen;
      }
    }


    //http://softwaredevelopmentforecm.wordpress.com/2011/01/18/dynamically-generating-a-tablelayoutpanel/
    private void ClearTableLayoutPanel()
    {
      //Clear out the existing controls, we are generating a new table layout
      tableLayoutPanelMetaData.Controls.Clear();

      //Clear out the existing row and column styles
      tableLayoutPanelMetaData.ColumnStyles.Clear();
      tableLayoutPanelMetaData.RowStyles.Clear();
      tableLayoutPanelMetaData.RowCount = 0;
      //First add a column
      tableLayoutPanelMetaData.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
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