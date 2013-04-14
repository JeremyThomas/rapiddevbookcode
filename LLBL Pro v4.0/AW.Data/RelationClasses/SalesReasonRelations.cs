﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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
	/// <summary>Implements the relations factory for the entity: SalesReason. </summary>
	public partial class SalesReasonRelations
	{
		/// <summary>CTor</summary>
		public SalesReasonRelations()
		{
		}

		/// <summary>Gets all relations of the SalesReasonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderSalesReasonEntityUsingSalesReasonID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesReasonEntity and SalesOrderHeaderSalesReasonEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesReason.SalesReasonID - SalesOrderHeaderSalesReason.SalesReasonID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesReasonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaderSalesReasons" , true);
				relation.AddEntityFieldPair(SalesReasonFields.SalesReasonID, SalesOrderHeaderSalesReasonFields.SalesReasonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesReasonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderSalesReasonEntity", false);
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
	internal static class StaticSalesReasonRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesReasonIDStatic = new SalesReasonRelations().SalesOrderHeaderSalesReasonEntityUsingSalesReasonID;

		/// <summary>CTor</summary>
		static StaticSalesReasonRelations()
		{
		}
	}
}
