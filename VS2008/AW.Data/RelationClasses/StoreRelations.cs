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
	/// <summary>Implements the static Relations variant for the entity: Store. </summary>
	public partial class StoreRelations
	{
		/// <summary>CTor</summary>
		public StoreRelations()
		{
		}

		/// <summary>Gets all relations of the StoreEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StoreContactEntityUsingCustomerID);
			toReturn.Add(this.CustomerEntityUsingCustomerID);
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and StoreContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Store.CustomerID - StoreContact.CustomerID
		/// </summary>
		public virtual IEntityRelation StoreContactEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreContact" , true);
				relation.AddEntityFieldPair(StoreFields.CustomerID, StoreContactFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and CustomerEntity over the 1:1 relation they have, using the relation between the fields:
		/// Store.CustomerID - Customer.CustomerID
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Customer", false);



				relation.AddEntityFieldPair(CustomerFields.CustomerID, StoreFields.CustomerID);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields:
		/// Store.SalesPersonID - SalesPerson.SalesPersonID
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesPerson", false);
				relation.AddEntityFieldPair(SalesPersonFields.SalesPersonID, StoreFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
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
