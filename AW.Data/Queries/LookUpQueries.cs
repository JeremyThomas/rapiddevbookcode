using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;

namespace AW.Data.Queries
{
  public static class LookUpQueries
  {
    public static CountryRegionCollection GetCountryRegionCollection()
    {
      return CountryRegionEntity.GetCountryRegionCollection();
    }

    public static StateProvinceCollection GetStateProvinceCollection()
    {
      return StateProvinceEntity.GetStateProvinceCollection();
    }

    public static EmployeeCollection GetEmployees()
    {
      return EmployeeEntity.GetEmployees();
    }
  }
}