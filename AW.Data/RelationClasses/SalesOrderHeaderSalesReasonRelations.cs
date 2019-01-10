///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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
	/// <summary>Implements the relations factory for the entity: SalesOrderHeaderSalesReason. </summary>
	public partial class SalesOrderHeaderSalesReasonRelations
	{
		/// <summary>CTor</summary>
		public SalesOrderHeaderSalesReasonRelations()
		{
		}

		/// <summary>Gets all relations of the SalesOrderHeaderSalesReasonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderEntityUsingSalesOrderID);
			toReturn.Add(this.SalesReasonEntityUsingSalesReasonID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderSalesReasonEntity and SalesOrderHeaderEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeaderSalesReason.SalesOrderID - SalesOrderHeader.SalesOrderID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesOrderHeader", false);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderID, SalesOrderHeaderSalesReasonFields.SalesOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderSalesReasonEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderSalesReasonEntity and SalesReasonEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeaderSalesReason.SalesReasonID - SalesReason.SalesReasonID
		/// </summary>
		public virtual IEntityRelation SalesReasonEntityUsingSalesReasonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesReason", false);
				relation.AddEntityFieldPair(SalesReasonFields.SalesReasonID, SalesOrderHeaderSalesReasonFields.SalesReasonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesReasonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderSalesReasonEntity", true);
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
	internal static class StaticSalesOrderHeaderSalesReasonRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesOrderIDStatic = new SalesOrderHeaderSalesReasonRelations().SalesOrderHeaderEntityUsingSalesOrderID;
		internal static readonly IEntityRelation SalesReasonEntityUsingSalesReasonIDStatic = new SalesOrderHeaderSalesReasonRelations().SalesReasonEntityUsingSalesReasonID;

		/// <summary>CTor</summary>
		static StaticSalesOrderHeaderSalesReasonRelations()
		{
		}
	}
}
