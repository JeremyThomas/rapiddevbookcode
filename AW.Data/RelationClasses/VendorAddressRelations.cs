///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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
	/// <summary>Implements the relations factory for the entity: VendorAddress. </summary>
	public partial class VendorAddressRelations
	{
		/// <summary>CTor</summary>
		public VendorAddressRelations()
		{
		}

		/// <summary>Gets all relations of the VendorAddressEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AddressEntityUsingAddressID);
			toReturn.Add(this.AddressTypeEntityUsingAddressTypeID);
			toReturn.Add(this.VendorEntityUsingVendorID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between VendorAddressEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorAddress.AddressID - Address.AddressID
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Address", false);
				relation.AddEntityFieldPair(AddressFields.AddressID, VendorAddressFields.AddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between VendorAddressEntity and AddressTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorAddress.AddressTypeID - AddressType.AddressTypeID
		/// </summary>
		public virtual IEntityRelation AddressTypeEntityUsingAddressTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AddressType", false);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeID, VendorAddressFields.AddressTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between VendorAddressEntity and VendorEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorAddress.VendorID - Vendor.VendorID
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vendor", false);
				relation.AddEntityFieldPair(VendorFields.VendorID, VendorAddressFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", true);
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
	internal static class StaticVendorAddressRelations
	{
		internal static readonly IEntityRelation AddressEntityUsingAddressIDStatic = new VendorAddressRelations().AddressEntityUsingAddressID;
		internal static readonly IEntityRelation AddressTypeEntityUsingAddressTypeIDStatic = new VendorAddressRelations().AddressTypeEntityUsingAddressTypeID;
		internal static readonly IEntityRelation VendorEntityUsingVendorIDStatic = new VendorAddressRelations().VendorEntityUsingVendorID;

		/// <summary>CTor</summary>
		static StaticVendorAddressRelations()
		{
		}
	}
}
