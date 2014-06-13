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
	/// <summary>Implements the relations factory for the entity: SalesPersonQuotaHistory. </summary>
	public partial class SalesPersonQuotaHistoryRelations
	{
		/// <summary>CTor</summary>
		public SalesPersonQuotaHistoryRelations()
		{
		}

		/// <summary>Gets all relations of the SalesPersonQuotaHistoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesPersonQuotaHistoryEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesPersonQuotaHistory.SalesPersonID - SalesPerson.EmployeeID
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesPerson", false);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, SalesPersonQuotaHistoryFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonQuotaHistoryEntity", true);
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
	internal static class StaticSalesPersonQuotaHistoryRelations
	{
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIDStatic = new SalesPersonQuotaHistoryRelations().SalesPersonEntityUsingSalesPersonID;

		/// <summary>CTor</summary>
		static StaticSalesPersonQuotaHistoryRelations()
		{
		}
	}
}
