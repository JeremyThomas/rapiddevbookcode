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
	/// <summary>Implements the static Relations variant for the entity: ProductModel. </summary>
	public partial class ProductModelRelations
	{
		/// <summary>CTor</summary>
		public ProductModelRelations()
		{
		}

		/// <summary>Gets all relations of the ProductModelEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductModelID);
			toReturn.Add(this.ProductModelIllustrationEntityUsingProductModelID);
			toReturn.Add(this.ProductModelProductDescriptionCultureEntityUsingProductModelID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelID - Product.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelIllustrationEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelID - ProductModelIllustration.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductModelIllustrationEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelIllustrations" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductModelIllustrationFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelIllustrationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelID - ProductModelProductDescriptionCulture.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelProductDescriptionCultures" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductModelProductDescriptionCultureFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", false);
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
