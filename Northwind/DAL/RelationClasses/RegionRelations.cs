///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
// Code is generated on: Thursday, 3 February 2011 11:46:46 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Region. </summary>
	public partial class RegionRelations
	{
		/// <summary>CTor</summary>
		public RegionRelations()
		{
		}

		/// <summary>Gets all relations of the RegionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TerritoryEntityUsingRegionId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RegionEntity and TerritoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Region.RegionId - Territory.RegionId
		/// </summary>
		public virtual IEntityRelation TerritoryEntityUsingRegionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Territories" , true);
				relation.AddEntityFieldPair(RegionFields.RegionId, TerritoryFields.RegionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoryEntity", false);
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
