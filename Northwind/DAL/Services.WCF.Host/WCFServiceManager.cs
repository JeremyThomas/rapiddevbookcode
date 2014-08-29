using System;
using System.Windows.Forms;

namespace Services.WCF.Host
{
  public partial class WcfServiceManager : Form
  {
    public WcfServiceManager()
    {
      // if you're using the ORM Profiler, uncomment the line below and add a reference to the interceptor dll.
      // SD.Tools.OrmProfiler.Interceptor.InterceptorCore.Initialize("WCF Host");

      InitializeComponent();
      start_Click(this, null);
    }

    private void start_Click(object sender, EventArgs e)
    {
      if (WcfDataServiceHost.StartService())
      {
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
  }
}