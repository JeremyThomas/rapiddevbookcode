﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: ProductDescription. </summary>
	public partial class ProductDescriptionRelations
	{
		/// <summary>CTor</summary>
		public ProductDescriptionRelations()
		{
		}

		/// <summary>Gets all relations of the ProductDescriptionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductModelProductDescriptionCultureEntityUsingProductDescriptionID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductDescriptionEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductDescription.ProductDescriptionID - ProductModelProductDescriptionCulture.ProductDescriptionID
		/// </summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductDescriptionID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelProductDescriptionCultures" , true);
				relation.AddEntityFieldPair(ProductDescriptionFields.ProductDescriptionID, ProductModelProductDescriptionCultureFields.ProductDescriptionID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDescriptionEntity", true);
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
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductDescriptionRelations
	{
		internal static readonly IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductDescriptionIDStatic = new ProductDescriptionRelations().ProductModelProductDescriptionCultureEntityUsingProductDescriptionID;

		/// <summary>CTor</summary>
		static StaticProductDescriptionRelations()
		{
		}
	}
}
