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
	/// <summary>Implements the static Relations variant for the entity: Currency. </summary>
	public partial class CurrencyRelations
	{
		/// <summary>CTor</summary>
		public CurrencyRelations()
		{
		}

		/// <summary>Gets all relations of the CurrencyEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CurrencyRateEntityUsingFromCurrencyCode);
			toReturn.Add(this.CurrencyRateEntityUsingToCurrencyCode);
			toReturn.Add(this.CountryRegionCurrencyEntityUsingCurrencyCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CurrencyRateEntity over the 1:n relation they have, using the relation between the fields:
		/// Currency.CurrencyCode - CurrencyRate.FromCurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyRateEntityUsingFromCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CurrencyRates" , true);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.FromCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CurrencyRateEntity over the 1:n relation they have, using the relation between the fields:
		/// Currency.CurrencyCode - CurrencyRate.ToCurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyRateEntityUsingToCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CurrencyRates_" , true);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.ToCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CountryRegionCurrencyEntity over the 1:n relation they have, using the relation between the fields:
		/// Currency.CurrencyCode - CountryRegionCurrency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CountryRegionCurrencyEntityUsingCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CountryRegionCurrencies" , true);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CountryRegionCurrencyFields.CurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionCurrencyEntity", false);
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
