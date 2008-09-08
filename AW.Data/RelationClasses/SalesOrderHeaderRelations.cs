﻿///////////////////////////////////////////////////////////////
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
			toReturn.Add(this.SalesOrderDetailEntityUsingSalesOrderId);

			toReturn.Add(this.AddressEntityUsingBillToAddressId);
			toReturn.Add(this.AddressEntityUsingShipToAddressId);
			toReturn.Add(this.ContactEntityUsingContactId);
			toReturn.Add(this.CreditCardEntityUsingCreditCardId);
			toReturn.Add(this.CurrencyRateEntityUsingCurrencyRateId);
			toReturn.Add(this.CustomerEntityUsingCustomerId);
			toReturn.Add(this.CustomerViewRelatedEntityUsingCustomerId);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryId);
			toReturn.Add(this.ShipMethodEntityUsingShipMethodId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesOrderHeader.SalesOrderId - SalesOrderDetail.SalesOrderId
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingSalesOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderDetail" , true);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderId, SalesOrderDetailFields.SalesOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.BillToAddressId - Address.AddressId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingBillToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Address", false);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.BillToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipToAddressId - Address.AddressId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingShipToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Address_", false);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.ShipToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ContactId - Contact.ContactId
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactId, SalesOrderHeaderFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CreditCardId - CreditCard.CreditCardId
		/// </summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CreditCard", false);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardId, SalesOrderHeaderFields.CreditCardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CurrencyRateEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CurrencyRateId - CurrencyRate.CurrencyRateId
		/// </summary>
		public virtual IEntityRelation CurrencyRateEntityUsingCurrencyRateId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CurrencyRate", false);
				relation.AddEntityFieldPair(CurrencyRateFields.CurrencyRateId, SalesOrderHeaderFields.CurrencyRateId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerId - Customer.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Customer", false);
				relation.AddEntityFieldPair(CustomerFields.CustomerId, SalesOrderHeaderFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerViewRelatedEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerId - CustomerViewRelated.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerViewRelatedEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CustomerViewRelated", false);
				relation.AddEntityFieldPair(CustomerViewRelatedFields.CustomerId, SalesOrderHeaderFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerViewRelatedEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.TerritoryId - SalesTerritory.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesOrderHeaderFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipMethodId - ShipMethod.ShipMethodId
		/// </summary>
		public virtual IEntityRelation ShipMethodEntityUsingShipMethodId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ShipMethod", false);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodId, SalesOrderHeaderFields.ShipMethodId);
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
