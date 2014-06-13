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
	/// <summary>Implements the relations factory for the entity: SalesPerson. </summary>
	public partial class SalesPersonRelations : EmployeeRelations
	{
		/// <summary>CTor</summary>
		public SalesPersonRelations()
		{
		}

		/// <summary>Gets all relations of the SalesPersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = base.GetAllRelations();
			toReturn.Add(this.SalesOrderHeaderEntityUsingSalesPersonID);
			toReturn.Add(this.SalesPersonQuotaHistoryEntityUsingSalesPersonID);
			toReturn.Add(this.SalesTerritoryHistoryEntityUsingSalesPersonID);
			toReturn.Add(this.StoreEntityUsingSalesPersonID);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - Employee.ManagerID
		/// </summary>
		public override IEntityRelation EmployeeEntityUsingManagerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Manages" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, EmployeeFields.ManagerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - EmployeeAddress.EmployeeID
		/// </summary>
		public override IEntityRelation EmployeeAddressEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeAddresses" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, EmployeeAddressFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - EmployeeDepartmentHistory.EmployeeID
		/// </summary>
		public override IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeDepartmentHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, EmployeeDepartmentHistoryFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeePayHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - EmployeePayHistory.EmployeeID
		/// </summary>
		public override IEntityRelation EmployeePayHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeePayHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, EmployeePayHistoryFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeePayHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and JobCandidateEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - JobCandidate.EmployeeID
		/// </summary>
		public override IEntityRelation JobCandidateEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "JobCandidates" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, JobCandidateFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobCandidateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - PurchaseOrderHeader.EmployeeID
		/// </summary>
		public override IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, PurchaseOrderHeaderFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - SalesOrderHeader.SalesPersonID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, SalesOrderHeaderFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesPersonQuotaHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - SalesPersonQuotaHistory.SalesPersonID
		/// </summary>
		public virtual IEntityRelation SalesPersonQuotaHistoryEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesPersonQuotaHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, SalesPersonQuotaHistoryFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonQuotaHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - SalesTerritoryHistory.SalesPersonID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTerritoryHistories" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, SalesTerritoryHistoryFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and StoreEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesPerson.EmployeeID - Store.SalesPersonID
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Stores" , true);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, StoreFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesPerson.ManagerID - Employee.EmployeeID
		/// </summary>
		public override IEntityRelation EmployeeEntityUsingEmployeeIDManagerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Manager", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, SalesPersonFields.ManagerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesPerson.ContactID - Contact.ContactID
		/// </summary>
		public override IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, SalesPersonFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesPerson.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, SalesPersonFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesPersonEntity and EmployeeEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>
		internal IEntityRelation RelationToSuperTypeEmployeeEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, SalesPersonFields.EmployeeID);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}

		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			return null;
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public override IEntityRelation GetSuperTypeRelation()
		{
			return this.RelationToSuperTypeEmployeeEntity;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesPersonRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingManagerIDStatic = new SalesPersonRelations().EmployeeEntityUsingManagerID;
		internal static readonly IEntityRelation EmployeeAddressEntityUsingEmployeeIDStatic = new SalesPersonRelations().EmployeeAddressEntityUsingEmployeeID;
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeIDStatic = new SalesPersonRelations().EmployeeDepartmentHistoryEntityUsingEmployeeID;
		internal static readonly IEntityRelation EmployeePayHistoryEntityUsingEmployeeIDStatic = new SalesPersonRelations().EmployeePayHistoryEntityUsingEmployeeID;
		internal static readonly IEntityRelation JobCandidateEntityUsingEmployeeIDStatic = new SalesPersonRelations().JobCandidateEntityUsingEmployeeID;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeIDStatic = new SalesPersonRelations().PurchaseOrderHeaderEntityUsingEmployeeID;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesPersonIDStatic = new SalesPersonRelations().SalesOrderHeaderEntityUsingSalesPersonID;
		internal static readonly IEntityRelation SalesPersonQuotaHistoryEntityUsingSalesPersonIDStatic = new SalesPersonRelations().SalesPersonQuotaHistoryEntityUsingSalesPersonID;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingSalesPersonIDStatic = new SalesPersonRelations().SalesTerritoryHistoryEntityUsingSalesPersonID;
		internal static readonly IEntityRelation StoreEntityUsingSalesPersonIDStatic = new SalesPersonRelations().StoreEntityUsingSalesPersonID;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIDManagerIDStatic = new SalesPersonRelations().EmployeeEntityUsingEmployeeIDManagerID;
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new SalesPersonRelations().ContactEntityUsingContactID;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIDStatic = new SalesPersonRelations().SalesTerritoryEntityUsingTerritoryID;

		/// <summary>CTor</summary>
		static StaticSalesPersonRelations()
		{
		}
	}
}
