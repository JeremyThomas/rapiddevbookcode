///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations : IRelationFactory
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
			toReturn.Add(this.EmployeeDepartmentHistoryEntityUsingEmployeeID);
			toReturn.Add(this.EmployeePayHistoryEntityUsingEmployeeID);
			toReturn.Add(this.JobCandidateEntityUsingEmployeeID);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingEmployeeID);
			toReturn.Add(this.EmployeeEntityUsingEmployeeIDManagerID);
			toReturn.Add(this.ContactEntityUsingContactID);
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

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - EmployeeDepartmentHistory.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeDepartmentHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeeDepartmentHistoryFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeePayHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - EmployeePayHistory.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeePayHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeePayHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, EmployeePayHistoryFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeePayHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and JobCandidateEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - JobCandidate.EmployeeID
		/// </summary>
		public virtual IEntityRelation JobCandidateEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "JobCandidates" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, JobCandidateFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobCandidateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeID - PurchaseOrderHeader.EmployeeID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, PurchaseOrderHeaderFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
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



		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and SalesPersonEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>		
		internal IEntityRelation RelationToSubTypeSalesPersonEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, SalesPersonFields.EmployeeID);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			switch(subTypeEntityName)
			{
				case "SalesPersonEntity":
					return this.RelationToSubTypeSalesPersonEntity;
				default:
					return null;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public virtual IEntityRelation GetSuperTypeRelation()
		{
			return null;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingManagerIDStatic = new EmployeeRelations().EmployeeEntityUsingManagerID;
		internal static readonly IEntityRelation EmployeeAddressEntityUsingEmployeeIDStatic = new EmployeeRelations().EmployeeAddressEntityUsingEmployeeID;
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeIDStatic = new EmployeeRelations().EmployeeDepartmentHistoryEntityUsingEmployeeID;
		internal static readonly IEntityRelation EmployeePayHistoryEntityUsingEmployeeIDStatic = new EmployeeRelations().EmployeePayHistoryEntityUsingEmployeeID;
		internal static readonly IEntityRelation JobCandidateEntityUsingEmployeeIDStatic = new EmployeeRelations().JobCandidateEntityUsingEmployeeID;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeIDStatic = new EmployeeRelations().PurchaseOrderHeaderEntityUsingEmployeeID;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIDManagerIDStatic = new EmployeeRelations().EmployeeEntityUsingEmployeeIDManagerID;
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new EmployeeRelations().ContactEntityUsingContactID;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations()
		{
		}
	}
}
