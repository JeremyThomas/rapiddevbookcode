///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: SalesOrderHistory. </summary>
	public partial class SalesOrderHistoryRelations : TransactionHistoryRelations
	{
		/// <summary>CTor</summary>
		public SalesOrderHistoryRelations()
		{
		}

		/// <summary>Gets all relations of the SalesOrderHistoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = base.GetAllRelations();
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesOrderHistoryEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHistory.ProductID - Product.ProductID
		/// </summary>
		public override IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, SalesOrderHistoryFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public override IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesOrderHistoryRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new SalesOrderHistoryRelations().ProductEntityUsingProductID;

		/// <summary>CTor</summary>
		static StaticSalesOrderHistoryRelations()
		{
		}
	}
}
