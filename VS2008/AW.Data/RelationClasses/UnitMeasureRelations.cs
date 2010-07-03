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
	/// <summary>Implements the static Relations variant for the entity: UnitMeasure. </summary>
	public partial class UnitMeasureRelations
	{
		/// <summary>CTor</summary>
		public UnitMeasureRelations()
		{
		}

		/// <summary>Gets all relations of the UnitMeasureEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BillOfMaterialsEntityUsingUnitMeasureCode);
			toReturn.Add(this.ProductEntityUsingWeightUnitMeasureCode);
			toReturn.Add(this.ProductEntityUsingSizeUnitMeasureCode);
			toReturn.Add(this.ProductVendorEntityUsingUnitMeasureCode);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and BillOfMaterialsEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - BillOfMaterials.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation BillOfMaterialsEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfMaterials" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, BillOfMaterialsFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialsEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - Product.WeightUnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingWeightUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Product_" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.WeightUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - Product.SizeUnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingSizeUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Product" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.SizeUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - ProductVendor.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendor" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductVendorFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
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
