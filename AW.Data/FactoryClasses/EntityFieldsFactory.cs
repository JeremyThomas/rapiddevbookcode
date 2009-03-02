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
using System.Data;
using AW.Data;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>
	/// Generates IEntityFields instances for different kind of Entities. 
	/// This class is generated. Do not modify.
	/// </summary>
	public partial class EntityFieldsFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldsFactory()
		{
		}


		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateEntityFieldsObject(AW.Data.EntityType relatedEntityType)
		{
			IEntityFields fieldsToReturn=null;
			IInheritanceInfoProvider inheritanceProvider = InheritanceInfoProviderSingleton.GetInstance();
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			switch(relatedEntityType)
			{
				case AW.Data.EntityType.AddressEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "AddressEntity");
					break;
				case AW.Data.EntityType.AddressTypeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "AddressTypeEntity");
					break;
				case AW.Data.EntityType.ContactEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "ContactEntity");
					break;
				case AW.Data.EntityType.CountryRegionEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CountryRegionEntity");
					break;
				case AW.Data.EntityType.CreditCardEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CreditCardEntity");
					break;
				case AW.Data.EntityType.CurrencyEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CurrencyEntity");
					break;
				case AW.Data.EntityType.CurrencyRateEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CurrencyRateEntity");
					break;
				case AW.Data.EntityType.CustomerEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CustomerEntity");
					break;
				case AW.Data.EntityType.CustomerAddressEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CustomerAddressEntity");
					break;
				case AW.Data.EntityType.CustomerViewRelatedEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "CustomerViewRelatedEntity");
					break;
				case AW.Data.EntityType.EmployeeEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "EmployeeEntity");
					break;
				case AW.Data.EntityType.EmployeeAddressEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "EmployeeAddressEntity");
					break;
				case AW.Data.EntityType.IndividualEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "IndividualEntity");
					break;
				case AW.Data.EntityType.ProductEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "ProductEntity");
					break;
				case AW.Data.EntityType.SalesOrderDetailEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "SalesOrderDetailEntity");
					break;
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "SalesOrderHeaderEntity");
					break;
				case AW.Data.EntityType.SalesTerritoryEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "SalesTerritoryEntity");
					break;
				case AW.Data.EntityType.ShipMethodEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "ShipMethodEntity");
					break;
				case AW.Data.EntityType.SpecialOfferEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "SpecialOfferEntity");
					break;
				case AW.Data.EntityType.SpecialOfferProductEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "SpecialOfferProductEntity");
					break;
				case AW.Data.EntityType.StateProvinceEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, persistenceProvider, "StateProvinceEntity");
					break;
			}
			return fieldsToReturn;
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			IPersistenceInfoProvider persistenceProvider = PersistenceInfoProviderSingleton.GetInstance();
			return fieldProvider.GetEntityFieldsArray(entityName, persistenceProvider);
		}

		/// <summary>General factory entrance method which will return a TypedView EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedTypedViewType">The type of typed view the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateTypedViewEntityFieldsObject(TypedViewType relatedTypedViewType)
		{
			IEntityFields fieldsToReturn=null;
			switch(relatedTypedViewType)
			{
				case TypedViewType.CustomerViewTypedView:
					fieldsToReturn = CreateCustomerViewTypedViewEntityFields();
					break;
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CustomerViewEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateCustomerViewTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)CustomerViewFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CustomerViewTypedView"));
			for(int i=0;i<(int)CustomerViewFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CustomerViewFieldIndex)i);
			}
			return fieldsToReturn;
		}

		#region Included Code

		#endregion
	}
}
