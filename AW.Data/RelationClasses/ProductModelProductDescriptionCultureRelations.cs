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
	/// <summary>Implements the relations factory for the entity: ProductModelProductDescriptionCulture. </summary>
	public partial class ProductModelProductDescriptionCultureRelations
	{
		/// <summary>CTor</summary>
		public ProductModelProductDescriptionCultureRelations()
		{
		}

		/// <summary>Gets all relations of the ProductModelProductDescriptionCultureEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CultureEntityUsingCultureID);
			toReturn.Add(this.ProductDescriptionEntityUsingProductDescriptionID);
			toReturn.Add(this.ProductModelEntityUsingProductModelID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and CultureEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductModelProductDescriptionCulture.CultureID - Culture.CultureID
		/// </summary>
		public virtual IEntityRelation CultureEntityUsingCultureID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Culture", false);
				relation.AddEntityFieldPair(CultureFields.CultureID, ProductModelProductDescriptionCultureFields.CultureID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CultureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and ProductDescriptionEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductModelProductDescriptionCulture.ProductDescriptionID - ProductDescription.ProductDescriptionID
		/// </summary>
		public virtual IEntityRelation ProductDescriptionEntityUsingProductDescriptionID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductDescription", false);
				relation.AddEntityFieldPair(ProductDescriptionFields.ProductDescriptionID, ProductModelProductDescriptionCultureFields.ProductDescriptionID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDescriptionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and ProductModelEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductModelProductDescriptionCulture.ProductModelID - ProductModel.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductModelEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductModel", false);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductModelProductDescriptionCultureFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", true);
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
	internal static class StaticProductModelProductDescriptionCultureRelations
	{
		internal static readonly IEntityRelation CultureEntityUsingCultureIDStatic = new ProductModelProductDescriptionCultureRelations().CultureEntityUsingCultureID;
		internal static readonly IEntityRelation ProductDescriptionEntityUsingProductDescriptionIDStatic = new ProductModelProductDescriptionCultureRelations().ProductDescriptionEntityUsingProductDescriptionID;
		internal static readonly IEntityRelation ProductModelEntityUsingProductModelIDStatic = new ProductModelProductDescriptionCultureRelations().ProductModelEntityUsingProductModelID;

		/// <summary>CTor</summary>
		static StaticProductModelProductDescriptionCultureRelations()
		{
		}
	}
}
