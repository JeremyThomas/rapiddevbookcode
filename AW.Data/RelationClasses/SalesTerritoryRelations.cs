///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
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
	/// <summary>Implements the relations factory for the entity: SalesTerritory. </summary>
	public partial class SalesTerritoryRelations
	{
		/// <summary>CTor</summary>
		public SalesTerritoryRelations()
		{
		}

		/// <summary>Gets all relations of the SalesTerritoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StateProvinceEntityUsingTerritoryID);
			toReturn.Add(this.CustomerEntityUsingTerritoryID);
			toReturn.Add(this.SalesOrderHeaderEntityUsingTerritoryID);
			toReturn.Add(this.SalesPersonEntityUsingTerritoryID);
			toReturn.Add(this.SalesTerritoryHistoryEntityUsingTerritoryID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryID - StateProvince.TerritoryID
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StateProvinces" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, StateProvinceFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryID - Customer.TerritoryID
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Customers" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, CustomerFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryID - SalesOrderHeader.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, SalesOrderHeaderFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesPersonEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryID - SalesPerson.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesPeople" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, SalesPersonFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryID - SalesTerritoryHistory.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTerritoryHistories" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, SalesTerritoryHistoryFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryHistoryEntity", false);
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
	internal static class StaticSalesTerritoryRelations
	{
		internal static readonly IEntityRelation StateProvinceEntityUsingTerritoryIDStatic = new SalesTerritoryRelations().StateProvinceEntityUsingTerritoryID;
		internal static readonly IEntityRelation CustomerEntityUsingTerritoryIDStatic = new SalesTerritoryRelations().CustomerEntityUsingTerritoryID;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingTerritoryIDStatic = new SalesTerritoryRelations().SalesOrderHeaderEntityUsingTerritoryID;
		internal static readonly IEntityRelation SalesPersonEntityUsingTerritoryIDStatic = new SalesTerritoryRelations().SalesPersonEntityUsingTerritoryID;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryIDStatic = new SalesTerritoryRelations().SalesTerritoryHistoryEntityUsingTerritoryID;

		/// <summary>CTor</summary>
		static StaticSalesTerritoryRelations()
		{
		}
	}
}
