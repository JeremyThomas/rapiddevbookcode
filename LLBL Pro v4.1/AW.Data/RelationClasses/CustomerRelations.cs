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
	/// <summary>Implements the relations factory for the entity: Customer. </summary>
	public partial class CustomerRelations : IRelationFactory
	{
		/// <summary>CTor</summary>
		public CustomerRelations()
		{
		}

		/// <summary>Gets all relations of the CustomerEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerAddressEntityUsingCustomerID);
			toReturn.Add(this.SalesOrderHeaderEntityUsingCustomerID);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Customer.CustomerID - CustomerAddress.CustomerID
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerAddresses" , true);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, CustomerAddressFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Customer.CustomerID - SalesOrderHeader.CustomerID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, SalesOrderHeaderFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Customer.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, CustomerFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				return relation;
			}
		}



		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and IndividualEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>		
		internal IEntityRelation RelationToSubTypeIndividualEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, true);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, IndividualFields.CustomerID);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and StoreEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>		
		internal IEntityRelation RelationToSubTypeStoreEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, true);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, StoreFields.CustomerID);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			switch(subTypeEntityName)
			{
				case "IndividualEntity":
					return this.RelationToSubTypeIndividualEntity;
				case "StoreEntity":
					return this.RelationToSubTypeStoreEntity;
				default:
					return null;
			}
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public virtual IEntityRelation GetSuperTypeRelation()
		{
			return null;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCustomerRelations
	{
		internal static readonly IEntityRelation CustomerAddressEntityUsingCustomerIDStatic = new CustomerRelations().CustomerAddressEntityUsingCustomerID;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingCustomerIDStatic = new CustomerRelations().SalesOrderHeaderEntityUsingCustomerID;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIDStatic = new CustomerRelations().SalesTerritoryEntityUsingTerritoryID;

		/// <summary>CTor</summary>
		static StaticCustomerRelations()
		{
		}
	}
}
