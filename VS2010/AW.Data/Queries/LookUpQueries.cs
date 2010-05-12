using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

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
      var relations = new RelationCollection {EmployeeEntityBase.Relations.ContactEntityUsingContactID};
      ISortExpression lastFirstAlpha = (ContactFields.LastName | SortOperator.Ascending) & (ContactFields.FirstName | SortOperator.Ascending);
      var employees = new EmployeeCollection();
      IPrefetchPath prefetch = new PrefetchPath((int) EntityType.EmployeeEntity) {EmployeeEntityBase.PrefetchPathContact};
      var includeFields = new IncludeFieldsList(ContactFields.LastName, ContactFields.FirstName, EmployeeFields.EmployeeID);
      employees.GetMulti(null, 0, lastFirstAlpha, relations, prefetch, includeFields,0,0);
      return employees;
    }

    public static CollectionCore<EmployeeEntity> GetEmployeesLinq()
    {
      var employeeQuery = from employee in MetaSingletons.MetaData.Employee
                          orderby employee.Contact.LastName , employee.Contact.FirstName
                          select employee;
      return employeeQuery.WithPath(p => p.Prefetch(e => e.Contact)).ToEntityCollection();
    }
  }
}