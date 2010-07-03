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
	/// <summary>Implements the static Relations variant for the entity: BillOfMaterials. </summary>
	public partial class BillOfMaterialsRelations
	{
		/// <summary>CTor</summary>
		public BillOfMaterialsRelations()
		{
		}

		/// <summary>Gets all relations of the BillOfMaterialsEntity as a list of IEntityRelation objects.</summary>
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



		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialsEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterials.ProductAssemblyID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductAssemblyID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product_", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialsFields.ProductAssemblyID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialsEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialsEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterials.ComponentID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingComponentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialsFields.ComponentID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialsEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialsEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterials.UnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, BillOfMaterialsFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialsEntity", true);
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
