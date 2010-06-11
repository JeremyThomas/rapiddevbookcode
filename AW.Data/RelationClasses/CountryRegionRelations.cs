///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
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
	/// <summary>Implements the static Relations variant for the entity: CountryRegion. </summary>
	public partial class CountryRegionRelations
	{
		/// <summary>CTor</summary>
		public CountryRegionRelations()
		{
		}

		/// <summary>Gets all relations of the CountryRegionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CountryRegionCurrencyEntityUsingCountryRegionCode);
			toReturn.Add(this.StateProvinceEntityUsingCountryRegionCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and CountryRegionCurrencyEntity over the 1:n relation they have, using the relation between the fields:
		/// CountryRegion.CountryRegionCode - CountryRegionCurrency.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionCurrencyEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CountryRegionCurrencies" , true);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, CountryRegionCurrencyFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionCurrencyEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields:
		/// CountryRegion.CountryRegionCode - StateProvince.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StateProvinces" , true);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, StateProvinceFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", true);
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
