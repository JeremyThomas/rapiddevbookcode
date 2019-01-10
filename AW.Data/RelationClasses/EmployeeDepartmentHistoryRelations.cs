﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: EmployeeDepartmentHistory. </summary>
	public partial class EmployeeDepartmentHistoryRelations
	{
		/// <summary>CTor</summary>
		public EmployeeDepartmentHistoryRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeDepartmentHistoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DepartmentEntityUsingDepartmentID);
			toReturn.Add(this.EmployeeEntityUsingEmployeeID);
			toReturn.Add(this.ShiftEntityUsingShiftID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and DepartmentEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.DepartmentID - Department.DepartmentID
		/// </summary>
		public virtual IEntityRelation DepartmentEntityUsingDepartmentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Department", false);
				relation.AddEntityFieldPair(DepartmentFields.DepartmentID, EmployeeDepartmentHistoryFields.DepartmentID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DepartmentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.EmployeeID - Employee.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeeDepartmentHistoryFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and ShiftEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.ShiftID - Shift.ShiftID
		/// </summary>
		public virtual IEntityRelation ShiftEntityUsingShiftID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Shift", false);
				relation.AddEntityFieldPair(ShiftFields.ShiftID, EmployeeDepartmentHistoryFields.ShiftID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShiftEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeDepartmentHistoryRelations
	{
		internal static readonly IEntityRelation DepartmentEntityUsingDepartmentIDStatic = new EmployeeDepartmentHistoryRelations().DepartmentEntityUsingDepartmentID;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIDStatic = new EmployeeDepartmentHistoryRelations().EmployeeEntityUsingEmployeeID;
		internal static readonly IEntityRelation ShiftEntityUsingShiftIDStatic = new EmployeeDepartmentHistoryRelations().ShiftEntityUsingShiftID;

		/// <summary>CTor</summary>
		static StaticEmployeeDepartmentHistoryRelations()
		{
		}
	}
}
