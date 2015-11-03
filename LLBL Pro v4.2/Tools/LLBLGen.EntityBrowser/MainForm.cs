using System;
using System.Configuration;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.ConnectionUI;
using Microsoft.Data.ConnectionUI;
using Northwind.DAL.Services;

namespace LLBLGen.EntityBrowser
{
  public partial class MainForm : FrmPersistantLocation
  {
    public MainForm()
    {
      InitializeComponent();
      if (ConfigurationManager.ConnectionStrings.Count > 0)
      {
        var connectionStringSettings = ConfigurationManager.ConnectionStrings[ConfigurationManager.ConnectionStrings.Count - 1];
        var linqMetaData = Factories.CreateLinqMetaData(connectionStringSettings.ConnectionString);
        usrCntrlEntityBrowser1.Initialize(linqMetaData);
        Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
        var tabPage = tabControl.TabPages[0];
        tabPage.Name = connectionStringSettings.Name;
        tabPage.Text = tabPage.Name;
      }
    }

    private void toolStripButtonAddConnection_Click(object sender, EventArgs e)
    {
      var dcd = new DataConnectionDialog();
      var dcs = new DataConnectionConfiguration(null);
      dcs.LoadConfiguration(dcd);
      var browserConnection = new BrowserConnection();
      DataConnectionConfiguration.SelectDataProvider(dcd, browserConnection.Provider);

      if (dcd.SelectedDataProvider != null)
        dcd.ConnectionString = browserConnection.ConnectionString;
      if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
      {
        browserConnection.ConnectionString = dcd.ConnectionString;
        if (dcd.SelectedDataProvider != null)
        {
          browserConnection.Provider = dcd.SelectedDataProvider.Name;
          var connectionStringSettings = new ConnectionStringSettings("connection" + ConfigurationManager.ConnectionStrings.Count, browserConnection.ConnectionString);
          ConfigurationManager.ConnectionStrings.Add(connectionStringSettings);
          var linqMetaData = Factories.CreateLinqMetaData(browserConnection.ConnectionString);
          usrCntrlEntityBrowser1.Initialize(linqMetaData);
        }
      }
    }
  }

  internal class BrowserConnection
  {
    public string Provider { get; set; }
    public string ConnectionString { get; set; }
  }
}