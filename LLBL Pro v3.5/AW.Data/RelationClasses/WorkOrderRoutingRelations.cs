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
	/// <summary>Implements the relations factory for the entity: WorkOrderRouting. </summary>
	public partial class WorkOrderRoutingRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderRoutingRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderRoutingEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LocationEntityUsingLocationID);
			toReturn.Add(this.WorkOrderEntityUsingWorkOrderID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and LocationEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderRouting.LocationID - Location.LocationID
		/// </summary>
		public virtual IEntityRelation LocationEntityUsingLocationID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Location", false);
				relation.AddEntityFieldPair(LocationFields.LocationID, WorkOrderRoutingFields.LocationID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and WorkOrderEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderRouting.WorkOrderID - WorkOrder.WorkOrderID
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingWorkOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrder", false);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderID, WorkOrderRoutingFields.WorkOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", true);
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
	internal static class StaticWorkOrderRoutingRelations
	{
		internal static readonly IEntityRelation LocationEntityUsingLocationIDStatic = new WorkOrderRoutingRelations().LocationEntityUsingLocationID;
		internal static readonly IEntityRelation WorkOrderEntityUsingWorkOrderIDStatic = new WorkOrderRoutingRelations().WorkOrderEntityUsingWorkOrderID;

		/// <summary>CTor</summary>
		static StaticWorkOrderRoutingRelations()
		{
		}
	}
}
