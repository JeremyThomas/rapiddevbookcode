using AW.Helper;
using AW.Winforms.Helpers;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;

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
  }
}