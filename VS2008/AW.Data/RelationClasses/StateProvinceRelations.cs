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
	/// <summary>Implements the static Relations variant for the entity: StateProvince. </summary>
	public partial class StateProvinceRelations
	{
		/// <summary>CTor</summary>
		public StateProvinceRelations()
		{
		}

		/// <summary>Gets all relations of the StateProvinceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AddressEntityUsingStateProvinceID);
			toReturn.Add(this.SalesTaxRateEntityUsingStateProvinceID);

			toReturn.Add(this.CountryRegionEntityUsingCountryRegionCode);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and AddressEntity over the 1:n relation they have, using the relation between the fields:
		/// StateProvince.StateProvinceID - Address.StateProvinceID
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingStateProvinceID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Addresses" , true);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceID, AddressFields.StateProvinceID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and SalesTaxRateEntity over the 1:n relation they have, using the relation between the fields:
		/// StateProvince.StateProvinceID - SalesTaxRate.StateProvinceID
		/// </summary>
		public virtual IEntityRelation SalesTaxRateEntityUsingStateProvinceID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTaxRate" , true);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceID, SalesTaxRateFields.StateProvinceID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTaxRateEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields:
		/// StateProvince.CountryRegionCode - CountryRegion.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CountryRegion", false);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, StateProvinceFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// StateProvince.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, StateProvinceFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
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
