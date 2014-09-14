using Northwind.DAL.HelperClasses;

namespace Northwind.DAL.Services
{
  public class NorthwindPersistence : AdapterPersistence
  {
    public NorthwindPersistence()
      : base(Factories.CreateDataAccessAdapter)
    {
    }
  }
}