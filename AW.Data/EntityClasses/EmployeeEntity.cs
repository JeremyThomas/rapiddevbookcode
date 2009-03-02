///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'Employee'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : EmployeeEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public EmployeeEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeID):
			base(employeeID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 employeeID, IPrefetchPath prefetchPathToUse):
			base(employeeID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeID, IValidator validator):
			base(employeeID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static EmployeeCollection GetEmployees()
        {
            RelationCollection Relations = new RelationCollection();
            Relations.Add(EmployeeEntity.Relations.ContactEntityUsingContactID);
            ISortExpression LastFirstAlpha = 
                (ContactFields.LastName  | SortOperator.Ascending)
              & (ContactFields.FirstName | SortOperator.Ascending);
            EmployeeCollection Employees = new EmployeeCollection();
            Employees.GetMulti(null,0, LastFirstAlpha,Relations);
            return Employees;
        }
        public string EmployeeDisplayName
        {
            get
            {
               return this.Contact.LastName + ", " + this.Contact.FirstName;
            }
        }
            public static int AddBonusVacationHours(
                DateTime HireDateAfter,
                int SalariedHours,
                int NonSalariedHours)
            {
                Transaction MyTransaction = new Transaction(
                    System.Data.IsolationLevel.RepeatableRead, "MyTransaction");
                int RowsAffected = 0;
                try
                {
                    EmployeeCollection Salaried = new EmployeeCollection();
                    MyTransaction.Add(Salaried);
                    IPredicateExpression SalariedPred = 
                        new PredicateExpression();
                    SalariedPred.Add(
                        (EmployeeFields.HireDate >= HireDateAfter) &
                        (EmployeeFields.SalariedFlag == true));
                    Salaried.GetMulti(SalariedPred);
                    foreach (EmployeeEntity Employee in Salaried)
                    {
                        Employee.VacationHours += Convert.ToInt16(SalariedHours);
                    }
                    RowsAffected += Salaried.SaveMulti();
                    EmployeeCollection NonSalaried = new EmployeeCollection();
                    MyTransaction.Add(NonSalaried);
                    IPredicateExpression NonSalariedPred = 
                        new PredicateExpression();
                    NonSalariedPred.Add(
                        (EmployeeFields.HireDate >= HireDateAfter) &
                        (EmployeeFields.SalariedFlag == false));
                    NonSalaried.GetMulti(NonSalariedPred);
                    foreach (EmployeeEntity Employee in NonSalaried)
                    {
                        Employee.VacationHours += Convert.ToInt16(NonSalariedHours);
                    }
                    RowsAffected += NonSalaried.SaveMulti();
                    MyTransaction.Commit();
                    }
                catch (Exception err)
                {
                    MyTransaction.Rollback();
                    throw new ApplicationException(
                        "Error adding vacation hours: " + err.Message);
                }
                finally
                {
                    MyTransaction.Dispose();
                }
                return RowsAffected;
            }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
