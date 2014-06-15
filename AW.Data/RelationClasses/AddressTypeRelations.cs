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
	/// <summary>Implements the relations factory for the entity: AddressType. </summary>
	public partial class AddressTypeRelations
	{
		/// <summary>CTor</summary>
		public AddressTypeRelations()
		{
		}

		/// <summary>Gets all relations of the AddressTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.VendorAddressEntityUsingAddressTypeID);
			toReturn.Add(this.CustomerAddressEntityUsingAddressTypeID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressTypeEntity and VendorAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// AddressType.AddressTypeID - VendorAddress.AddressTypeID
		/// </summary>
		public virtual IEntityRelation VendorAddressEntityUsingAddressTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorAddresses" , true);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeID, VendorAddressFields.AddressTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressTypeEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// AddressType.AddressTypeID - CustomerAddress.AddressTypeID
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingAddressTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerAddresses" , true);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeID, CustomerAddressFields.AddressTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
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
	internal static class StaticAddressTypeRelations
	{
		internal static readonly IEntityRelation VendorAddressEntityUsingAddressTypeIDStatic = new AddressTypeRelations().VendorAddressEntityUsingAddressTypeID;
		internal static readonly IEntityRelation CustomerAddressEntityUsingAddressTypeIDStatic = new AddressTypeRelations().CustomerAddressEntityUsingAddressTypeID;

		/// <summary>CTor</summary>
		static StaticAddressTypeRelations()
		{
		}
	}
}
