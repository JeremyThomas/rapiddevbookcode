using AW.Helper.LLBL;
using Northwind.DAL.Linq;

namespace Northwind.DAL.Services
{
  public class NorthwindPersistence : AdapterPersistence
  {
    public NorthwindPersistence()
      : base(Factories.CreateDataAccessAdapter, new NorthwindQueryableProvider())
    {
    }
  }
}