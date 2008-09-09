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
	/// <summary>Implements the static Relations variant for the entity: SalesTerritory. </summary>
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
			toReturn.Add(this.CustomerEntityUsingTerritoryId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingTerritoryId);
			toReturn.Add(this.StateProvinceEntityUsingTerritoryId);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - Customer.TerritoryId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Customer" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, CustomerFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - SalesOrderHeader.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeader" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesOrderHeaderFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - StateProvince.TerritoryId
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StateProvince" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, StateProvinceFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
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
