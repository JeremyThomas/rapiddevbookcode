using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using Northwind.Win.NorthwindODataSRSharedTypes;

namespace Northwind.Win
{
  public partial class FrmEntityBrowser : FrmPersistantLocation
  {
    public FrmEntityBrowser()
    {
      InitializeComponent();


      var dataAccessAdapter = new DataAccessAdapter();
      usrCntrlEntityBrowser1.Initialize(new LinqMetaData(dataAccessAdapter));
      //Done in CommonEntityBase  CacheController.RegisterCache(dataAccessAdapter.ConnectionString, new ResultsetCache()); 
      Text += string.Format(" - {0}", ProfilerHelper.OrmProfilerStatus);
    }

    private void toolStripButtonRemote_Click(object sender, EventArgs e)
    {
      try
      {
        var baseAddress = ConfigurationManager.AppSettings["WcfDataServiceUrl"];
        var uri = new Uri(baseAddress); // + typeof(LLBLGenProODataService).Name);
        var llblGenProODataService = new LLBLGenProODataService(uri, new LinqMetaData());
        usrCntrlEntityBrowser1.Initialize(llblGenProODataService, llblGenProODataService.GetDataServiceQueryableForEntity);
      }
      catch (Exception ex)
      {
        Application.OnThreadException(ex);
      }
    }
  }
}