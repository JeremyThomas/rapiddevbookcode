﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the static Relations variant for the entity: CountryRegionCurrency. </summary>
	public partial class CountryRegionCurrencyRelations
	{
		/// <summary>CTor</summary>
		public CountryRegionCurrencyRelations()
		{
		}

		/// <summary>Gets all relations of the CountryRegionCurrencyEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CountryRegionEntityUsingCountryRegionCode);
			toReturn.Add(this.CurrencyEntityUsingCurrencyCode);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CountryRegionCurrencyEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields:
		/// CountryRegionCurrency.CountryRegionCode - CountryRegion.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CountryRegion", false);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, CountryRegionCurrencyFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionCurrencyEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CountryRegionCurrencyEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields:
		/// CountryRegionCurrency.CurrencyCode - Currency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyEntityUsingCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Currency", false);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CountryRegionCurrencyFields.CurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionCurrencyEntity", true);
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
