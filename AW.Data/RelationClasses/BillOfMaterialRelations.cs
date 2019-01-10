///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
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
	/// <summary>Implements the relations factory for the entity: BillOfMaterial. </summary>
	public partial class BillOfMaterialRelations
	{
		/// <summary>CTor</summary>
		public BillOfMaterialRelations()
		{
		}

		/// <summary>Gets all relations of the BillOfMaterialEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductAssemblyID);
			toReturn.Add(this.ProductEntityUsingComponentID);
			toReturn.Add(this.UnitMeasureEntityUsingUnitMeasureCode);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.ProductAssemblyID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductAssemblyID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductAssembly", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialFields.ProductAssemblyID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.ComponentID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingComponentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductComponent", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialFields.ComponentID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.UnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, BillOfMaterialFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
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
	internal static class StaticBillOfMaterialRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductAssemblyIDStatic = new BillOfMaterialRelations().ProductEntityUsingProductAssemblyID;
		internal static readonly IEntityRelation ProductEntityUsingComponentIDStatic = new BillOfMaterialRelations().ProductEntityUsingComponentID;
		internal static readonly IEntityRelation UnitMeasureEntityUsingUnitMeasureCodeStatic = new BillOfMaterialRelations().UnitMeasureEntityUsingUnitMeasureCode;

		/// <summary>CTor</summary>
		static StaticBillOfMaterialRelations()
		{
		}
	}
}
