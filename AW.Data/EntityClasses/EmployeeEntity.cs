///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Sunday, November 06, 2005 1:19:31 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;

using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.ValidatorClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
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
		public EmployeeEntity():base(new PropertyDescriptorFactory(), new EmployeeEntityFactory())
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeId):
			base(employeeId)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 employeeId, IPrefetchPath prefetchPathToUse):
			base(employeeId, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeId, EmployeeValidator validator):
			base(employeeId, validator)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntity(System.Int32 employeeId, EmployeeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(employeeId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static EmployeeCollection GetEmployees()
        {
            RelationCollection Relations = new RelationCollection();
            Relations.Add(EmployeeEntity.Relations.ContactEntityUsingContactId);
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
