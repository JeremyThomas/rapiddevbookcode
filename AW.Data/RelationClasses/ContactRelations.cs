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
using System.Collections;
using System.Collections.Generic;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Contact. </summary>
	public partial class ContactRelations
	{
		/// <summary>CTor</summary>
		public ContactRelations()
		{
		}

		/// <summary>Gets all relations of the ContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingContactId);
			toReturn.Add(this.IndividualEntityUsingContactId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingContactId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - Employee.ContactId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employee" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, EmployeeFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and IndividualEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - Individual.ContactId
		/// </summary>
		public virtual IEntityRelation IndividualEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Individual" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, IndividualFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - SalesOrderHeader.ContactId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeader" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, SalesOrderHeaderFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
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
