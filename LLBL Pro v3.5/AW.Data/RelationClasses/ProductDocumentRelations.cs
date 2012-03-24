///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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
	/// <summary>Implements the relations factory for the entity: ProductDocument. </summary>
	public partial class ProductDocumentRelations
	{
		/// <summary>CTor</summary>
		public ProductDocumentRelations()
		{
		}

		/// <summary>Gets all relations of the ProductDocumentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DocumentEntityUsingDocumentID);
			toReturn.Add(this.ProductEntityUsingProductID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductDocumentEntity and DocumentEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductDocument.DocumentID - Document.DocumentID
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingDocumentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Document", false);
				relation.AddEntityFieldPair(DocumentFields.DocumentID, ProductDocumentFields.DocumentID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDocumentEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductDocumentEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductDocument.ProductID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductDocumentFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDocumentEntity", true);
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
	internal static class StaticProductDocumentRelations
	{
		internal static readonly IEntityRelation DocumentEntityUsingDocumentIDStatic = new ProductDocumentRelations().DocumentEntityUsingDocumentID;
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new ProductDocumentRelations().ProductEntityUsingProductID;

		/// <summary>CTor</summary>
		static StaticProductDocumentRelations()
		{
		}
	}
}
