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
	/// <summary>Implements the static Relations variant for the entity: CurrencyRate. </summary>
	public partial class CurrencyRateRelations
	{
		/// <summary>CTor</summary>
		public CurrencyRateRelations()
		{
		}

		/// <summary>Gets all relations of the CurrencyRateEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderEntityUsingCurrencyRateId);

			toReturn.Add(this.CurrencyEntityUsingToCurrencyCode);
			toReturn.Add(this.CurrencyEntityUsingFromCurrencyCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// CurrencyRate.CurrencyRateId - SalesOrderHeader.CurrencyRateId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCurrencyRateId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeader" , true);
				relation.AddEntityFieldPair(CurrencyRateFields.CurrencyRateId, SalesOrderHeaderFields.CurrencyRateId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields:
		/// CurrencyRate.ToCurrencyCode - Currency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyEntityUsingToCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Currency_", false);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.ToCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields:
		/// CurrencyRate.FromCurrencyCode - Currency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyEntityUsingFromCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Currency", false);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.FromCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
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
