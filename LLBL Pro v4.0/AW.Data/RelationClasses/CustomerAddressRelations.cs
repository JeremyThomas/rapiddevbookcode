///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: CustomerAddress. </summary>
	public partial class CustomerAddressRelations
	{
		/// <summary>CTor</summary>
		public CustomerAddressRelations()
		{
		}

		/// <summary>Gets all relations of the CustomerAddressEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AddressEntityUsingAddressID);
			toReturn.Add(this.AddressTypeEntityUsingAddressTypeID);
			toReturn.Add(this.CustomerEntityUsingCustomerID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CustomerAddressEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// CustomerAddress.AddressID - Address.AddressID
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Address", false);
				relation.AddEntityFieldPair(AddressFields.AddressID, CustomerAddressFields.AddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CustomerAddressEntity and AddressTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// CustomerAddress.AddressTypeID - AddressType.AddressTypeID
		/// </summary>
		public virtual IEntityRelation AddressTypeEntityUsingAddressTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AddressType", false);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeID, CustomerAddressFields.AddressTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CustomerAddressEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields:
		/// CustomerAddress.CustomerID - Customer.CustomerID
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Customer", false);
				relation.AddEntityFieldPair(CustomerFields.CustomerID, CustomerAddressFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", true);
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
	internal static class StaticCustomerAddressRelations
	{
		internal static readonly IEntityRelation AddressEntityUsingAddressIDStatic = new CustomerAddressRelations().AddressEntityUsingAddressID;
		internal static readonly IEntityRelation AddressTypeEntityUsingAddressTypeIDStatic = new CustomerAddressRelations().AddressTypeEntityUsingAddressTypeID;
		internal static readonly IEntityRelation CustomerEntityUsingCustomerIDStatic = new CustomerAddressRelations().CustomerEntityUsingCustomerID;

		/// <summary>CTor</summary>
		static StaticCustomerAddressRelations()
		{
		}
	}
}
