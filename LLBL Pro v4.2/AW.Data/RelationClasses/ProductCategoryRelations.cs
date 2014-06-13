///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
	/// <summary>Implements the relations factory for the entity: ProductCategory. </summary>
	public partial class ProductCategoryRelations
	{
		/// <summary>CTor</summary>
		public ProductCategoryRelations()
		{
		}

		/// <summary>Gets all relations of the ProductCategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductSubcategoryEntityUsingProductCategoryID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductCategoryEntity and ProductSubcategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductCategory.ProductCategoryID - ProductSubcategory.ProductCategoryID
		/// </summary>
		public virtual IEntityRelation ProductSubcategoryEntityUsingProductCategoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductSubcategories" , true);
				relation.AddEntityFieldPair(ProductCategoryFields.ProductCategoryID, ProductSubcategoryFields.ProductCategoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", false);
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
	internal static class StaticProductCategoryRelations
	{
		internal static readonly IEntityRelation ProductSubcategoryEntityUsingProductCategoryIDStatic = new ProductCategoryRelations().ProductSubcategoryEntityUsingProductCategoryID;

		/// <summary>CTor</summary>
		static StaticProductCategoryRelations()
		{
		}
	}
}
