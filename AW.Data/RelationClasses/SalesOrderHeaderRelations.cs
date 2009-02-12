///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:24 p.m.
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
	/// <summary>Implements the static Relations variant for the entity: SalesOrderHeader. </summary>
	public partial class SalesOrderHeaderRelations
	{
		/// <summary>CTor</summary>
		public SalesOrderHeaderRelations()
		{
		}

		/// <summary>Gets all relations of the SalesOrderHeaderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderDetailEntityUsingSalesOrderID);

			toReturn.Add(this.AddressEntityUsingShipToAddressID);
			toReturn.Add(this.AddressEntityUsingBillToAddressID);
			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.CreditCardEntityUsingCreditCardID);
			toReturn.Add(this.CurrencyRateEntityUsingCurrencyRateID);
			toReturn.Add(this.CustomerEntityUsingCustomerID);
			toReturn.Add(this.CustomerViewRelatedEntityUsingCustomerID);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryID);
			toReturn.Add(this.ShipMethodEntityUsingShipMethodID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesOrderHeader.SalesOrderID - SalesOrderDetail.SalesOrderID
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderDetails" , true);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderID, SalesOrderDetailFields.SalesOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipToAddressID - Address.AddressID
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingShipToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ShippingAddress", false);
				relation.AddEntityFieldPair(AddressFields.AddressID, SalesOrderHeaderFields.ShipToAddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.BillToAddressID - Address.AddressID
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingBillToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BillingAddress", false);
				relation.AddEntityFieldPair(AddressFields.AddressID, SalesOrderHeaderFields.BillToAddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ContactID - Contact.ContactID
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, SalesOrderHeaderFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CreditCardID - CreditCard.CreditCardID
		/// </summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CreditCard", false);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardID, SalesOrderHeaderFields.CreditCardID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CurrencyRateEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CurrencyRateID - CurrencyRate.CurrencyRateID
		/// </summary>
		public virtual IEntityRelation CurrencyRateEntityUsingCurrencyRateID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CurrencyRate", false);
				relation.AddEntityFieldPair(CurrencyRateFields.CurrencyRateID, SalesOrderHeaderFields.CurrencyRateID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerID - Customer.CustomerID
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Customer", false);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, SalesOrderHeaderFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerViewRelatedEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerID - CustomerViewRelated.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerViewRelatedEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CustomerViewRelated", false);
				relation.AddEntityFieldPair(CustomerViewRelatedFields.CustomerId, SalesOrderHeaderFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerViewRelatedEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryID, SalesOrderHeaderFields.TerritoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipMethodID - ShipMethod.ShipMethodID
		/// </summary>
		public virtual IEntityRelation ShipMethodEntityUsingShipMethodID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ShipMethod", false);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodID, SalesOrderHeaderFields.ShipMethodID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
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
