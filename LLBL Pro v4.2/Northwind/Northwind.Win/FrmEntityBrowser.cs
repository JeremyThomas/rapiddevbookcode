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
        //var webClient = new WebClient();
        //var openRead = webClient.OpenRead(llblGenProODataService.Employee.RequestUri);
        //  llblGenProODataService.BeginExecute<Northwind.DAL.EntityClasses.EmployeeEntity>(llblGenProODataService.Employee.RequestUri, handleResult, null);
        // llblGenProODataService.Execute<object>(llblGenProODataService.Employee.RequestUri);


        var employee = llblGenProODataService.Employee;
        var employeeEntities = employee.Execute();
        //  var categoryEntities = llblGenProODataService.Category.Execute();

     //   var dataServiceContext = new SampleServiceCtx(uri);
        //var category = dataServiceContext.CreateQuery<CategoryEntity>("Category");
        var enumerable = llblGenProODataService.Category.Execute();
        var first = enumerable.First();
        usrCntrlEntityBrowser1.Initialize(llblGenProODataService);
      }
      catch (Exception ex)
      {
        Application.OnThreadException(ex);
      }
    }
  }
}