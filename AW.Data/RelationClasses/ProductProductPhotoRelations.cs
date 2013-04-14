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
	/// <summary>Implements the relations factory for the entity: ProductProductPhoto. </summary>
	public partial class ProductProductPhotoRelations
	{
		/// <summary>CTor</summary>
		public ProductProductPhotoRelations()
		{
		}

		/// <summary>Gets all relations of the ProductProductPhotoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductID);
			toReturn.Add(this.ProductPhotoEntityUsingProductPhotoID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductProductPhotoEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductProductPhoto.ProductID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductProductPhotoFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductProductPhotoEntity and ProductPhotoEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductProductPhoto.ProductPhotoID - ProductPhoto.ProductPhotoID
		/// </summary>
		public virtual IEntityRelation ProductPhotoEntityUsingProductPhotoID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductPhoto", false);
				relation.AddEntityFieldPair(ProductPhotoFields.ProductPhotoID, ProductProductPhotoFields.ProductPhotoID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductPhotoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", true);
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
	internal static class StaticProductProductPhotoRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new ProductProductPhotoRelations().ProductEntityUsingProductID;
		internal static readonly IEntityRelation ProductPhotoEntityUsingProductPhotoIDStatic = new ProductProductPhotoRelations().ProductPhotoEntityUsingProductPhotoID;

		/// <summary>CTor</summary>
		static StaticProductProductPhotoRelations()
		{
		}
	}
}
