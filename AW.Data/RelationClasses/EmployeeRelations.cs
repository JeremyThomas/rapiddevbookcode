///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:24 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
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
	/// <summary>Implements the static Relations variant for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingManagerID);
			toReturn.Add(this.EmployeeAddressEntityUsingEmployeeID);

			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.EmployeeEntityUsingEmployeeIDManagerID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - Employee.ManagerID
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingManagerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Manages" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeeFields.ManagerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - EmployeeAddress.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeeAddressEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeAddresses" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeeAddressFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeAddressEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// Employee.ContactID - Contact.ContactID
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, EmployeeFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// Employee.ManagerID - Employee.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeIDManagerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Manager", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeeFields.ManagerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
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
}
