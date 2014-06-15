///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
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
	/// <summary>Implements the relations factory for the entity: Store. </summary>
	public partial class StoreRelations : CustomerRelations
	{
		/// <summary>CTor</summary>
		public StoreRelations()
		{
		}

		/// <summary>Gets all relations of the StoreEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = base.GetAllRelations();
			toReturn.Add(this.StoreContactEntityUsingCustomerID);
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Store.CustomerID - CustomerAddress.CustomerID
		/// </summary>
		public override IEntityRelation CustomerAddressEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerAddresses" , true);
				relation.AddEntityFieldPair(StoreFields.CustomerID, CustomerAddressFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Store.CustomerID - SalesOrderHeader.CustomerID
		/// </summary>
		public override IEntityRelation SalesOrderHeaderEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(StoreFields.CustomerID, SalesOrderHeaderFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and StoreContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Store.CustomerID - StoreContact.CustomerID
		/// </summary>
		public virtual IEntityRelation StoreContactEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreContacts" , true);
				relation.AddEntityFieldPair(StoreFields.CustomerID, StoreContactFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields:
		/// Store.SalesPersonID - SalesPerson.EmployeeID
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesPerson", false);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, StoreFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Store.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public override IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, StoreFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and CustomerEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>
		internal IEntityRelation RelationToSuperTypeCustomerEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, false);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, StoreFields.CustomerID);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}

		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			return null;
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public override IEntityRelation GetSuperTypeRelation()
		{
			return this.RelationToSuperTypeCustomerEntity;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticStoreRelations
	{
		internal static readonly IEntityRelation CustomerAddressEntityUsingCustomerIDStatic = new StoreRelations().CustomerAddressEntityUsingCustomerID;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingCustomerIDStatic = new StoreRelations().SalesOrderHeaderEntityUsingCustomerID;
		internal static readonly IEntityRelation StoreContactEntityUsingCustomerIDStatic = new StoreRelations().StoreContactEntityUsingCustomerID;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIDStatic = new StoreRelations().SalesPersonEntityUsingSalesPersonID;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIDStatic = new StoreRelations().SalesTerritoryEntityUsingTerritoryID;

		/// <summary>CTor</summary>
		static StaticStoreRelations()
		{
		}
	}
}
