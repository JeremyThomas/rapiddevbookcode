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
	/// <summary>Implements the static Relations variant for the entity: Location. </summary>
	public partial class LocationRelations
	{
		/// <summary>CTor</summary>
		public LocationRelations()
		{
		}

		/// <summary>Gets all relations of the LocationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductInventoryEntityUsingLocationID);
			toReturn.Add(this.WorkOrderRoutingEntityUsingLocationID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LocationEntity and ProductInventoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Location.LocationID - ProductInventory.LocationID
		/// </summary>
		public virtual IEntityRelation ProductInventoryEntityUsingLocationID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductInventories" , true);
				relation.AddEntityFieldPair(LocationFields.LocationID, ProductInventoryFields.LocationID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductInventoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LocationEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields:
		/// Location.LocationID - WorkOrderRouting.LocationID
		/// </summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingLocationID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderRoutings" , true);
				relation.AddEntityFieldPair(LocationFields.LocationID, WorkOrderRoutingFields.LocationID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", false);
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
