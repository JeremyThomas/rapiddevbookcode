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
	/// <summary>Implements the relations factory for the entity: WorkOrder. </summary>
	public partial class WorkOrderRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.WorkOrderRoutingEntityUsingWorkOrderID);
			toReturn.Add(this.ProductEntityUsingProductID);
			toReturn.Add(this.ScrapReasonEntityUsingScrapReasonID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrder.WorkOrderID - WorkOrderRouting.WorkOrderID
		/// </summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingWorkOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderRoutings" , true);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderID, WorkOrderRoutingFields.WorkOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.ProductID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, WorkOrderFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ScrapReasonEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.ScrapReasonID - ScrapReason.ScrapReasonID
		/// </summary>
		public virtual IEntityRelation ScrapReasonEntityUsingScrapReasonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ScrapReason", false);
				relation.AddEntityFieldPair(ScrapReasonFields.ScrapReasonID, WorkOrderFields.ScrapReasonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ScrapReasonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
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
	internal static class StaticWorkOrderRelations
	{
		internal static readonly IEntityRelation WorkOrderRoutingEntityUsingWorkOrderIDStatic = new WorkOrderRelations().WorkOrderRoutingEntityUsingWorkOrderID;
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new WorkOrderRelations().ProductEntityUsingProductID;
		internal static readonly IEntityRelation ScrapReasonEntityUsingScrapReasonIDStatic = new WorkOrderRelations().ScrapReasonEntityUsingScrapReasonID;

		/// <summary>CTor</summary>
		static StaticWorkOrderRelations()
		{
		}
	}
}
