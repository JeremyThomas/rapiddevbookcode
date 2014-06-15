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
	/// <summary>Implements the relations factory for the entity: SalesOrderHeader. </summary>
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
			toReturn.Add(this.SalesOrderHeaderSalesReasonEntityUsingSalesOrderID);
			toReturn.Add(this.AddressEntityUsingBillToAddressID);
			toReturn.Add(this.AddressEntityUsingShipToAddressID);
			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.ShipMethodEntityUsingShipMethodID);
			toReturn.Add(this.CreditCardEntityUsingCreditCardID);
			toReturn.Add(this.CurrencyRateEntityUsingCurrencyRateID);
			toReturn.Add(this.CustomerEntityUsingCustomerID);
			toReturn.Add(this.CustomerViewRelatedEntityUsingCustomerID);
			toReturn.Add(this.IndividualEntityUsingCustomerID);
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonID);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryID);
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

		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderHeaderSalesReasonEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesOrderHeader.SalesOrderID - SalesOrderHeaderSalesReason.SalesOrderID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaderSalesReasons" , true);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderID, SalesOrderHeaderSalesReasonFields.SalesOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderSalesReasonEntity", false);
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
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and IndividualEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerID - Individual.CustomerID
		/// </summary>
		public virtual IEntityRelation IndividualEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Individual", false);
				relation.AddEntityFieldPair(IndividualFields.CustomerID, SalesOrderHeaderFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.SalesPersonID - SalesPerson.EmployeeID
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesPerson", false);
				relation.AddEntityFieldPair(SalesPersonFields.EmployeeID, SalesOrderHeaderFields.SalesPersonID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
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
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesOrderHeaderRelations
	{
		internal static readonly IEntityRelation SalesOrderDetailEntityUsingSalesOrderIDStatic = new SalesOrderHeaderRelations().SalesOrderDetailEntityUsingSalesOrderID;
		internal static readonly IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesOrderIDStatic = new SalesOrderHeaderRelations().SalesOrderHeaderSalesReasonEntityUsingSalesOrderID;
		internal static readonly IEntityRelation AddressEntityUsingBillToAddressIDStatic = new SalesOrderHeaderRelations().AddressEntityUsingBillToAddressID;
		internal static readonly IEntityRelation AddressEntityUsingShipToAddressIDStatic = new SalesOrderHeaderRelations().AddressEntityUsingShipToAddressID;
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new SalesOrderHeaderRelations().ContactEntityUsingContactID;
		internal static readonly IEntityRelation ShipMethodEntityUsingShipMethodIDStatic = new SalesOrderHeaderRelations().ShipMethodEntityUsingShipMethodID;
		internal static readonly IEntityRelation CreditCardEntityUsingCreditCardIDStatic = new SalesOrderHeaderRelations().CreditCardEntityUsingCreditCardID;
		internal static readonly IEntityRelation CurrencyRateEntityUsingCurrencyRateIDStatic = new SalesOrderHeaderRelations().CurrencyRateEntityUsingCurrencyRateID;
		internal static readonly IEntityRelation CustomerEntityUsingCustomerIDStatic = new SalesOrderHeaderRelations().CustomerEntityUsingCustomerID;
		internal static readonly IEntityRelation CustomerViewRelatedEntityUsingCustomerIDStatic = new SalesOrderHeaderRelations().CustomerViewRelatedEntityUsingCustomerID;
		internal static readonly IEntityRelation IndividualEntityUsingCustomerIDStatic = new SalesOrderHeaderRelations().IndividualEntityUsingCustomerID;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIDStatic = new SalesOrderHeaderRelations().SalesPersonEntityUsingSalesPersonID;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIDStatic = new SalesOrderHeaderRelations().SalesTerritoryEntityUsingTerritoryID;

		/// <summary>CTor</summary>
		static StaticSalesOrderHeaderRelations()
		{
		}
	}
}
