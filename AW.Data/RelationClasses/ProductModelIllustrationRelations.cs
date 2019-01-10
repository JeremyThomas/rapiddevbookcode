///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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
	/// <summary>Implements the relations factory for the entity: ProductModelIllustration. </summary>
	public partial class ProductModelIllustrationRelations
	{
		/// <summary>CTor</summary>
		public ProductModelIllustrationRelations()
		{
		}

		/// <summary>Gets all relations of the ProductModelIllustrationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.IllustrationEntityUsingIllustrationID);
			toReturn.Add(this.ProductModelEntityUsingProductModelID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductModelIllustrationEntity and IllustrationEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductModelIllustration.IllustrationID - Illustration.IllustrationID
		/// </summary>
		public virtual IEntityRelation IllustrationEntityUsingIllustrationID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Illustration", false);
				relation.AddEntityFieldPair(IllustrationFields.IllustrationID, ProductModelIllustrationFields.IllustrationID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IllustrationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelIllustrationEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductModelIllustrationEntity and ProductModelEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductModelIllustration.ProductModelID - ProductModel.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductModelEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductModel", false);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductModelIllustrationFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelIllustrationEntity", true);
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
	internal static class StaticProductModelIllustrationRelations
	{
		internal static readonly IEntityRelation IllustrationEntityUsingIllustrationIDStatic = new ProductModelIllustrationRelations().IllustrationEntityUsingIllustrationID;
		internal static readonly IEntityRelation ProductModelEntityUsingProductModelIDStatic = new ProductModelIllustrationRelations().ProductModelEntityUsingProductModelID;

		/// <summary>CTor</summary>
		static StaticProductModelIllustrationRelations()
		{
		}
	}
}
