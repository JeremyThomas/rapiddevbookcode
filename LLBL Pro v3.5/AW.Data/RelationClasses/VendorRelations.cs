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
	/// <summary>Implements the relations factory for the entity: Vendor. </summary>
	public partial class VendorRelations
	{
		/// <summary>CTor</summary>
		public VendorRelations()
		{
		}

		/// <summary>Gets all relations of the VendorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductVendorEntityUsingVendorID);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingVendorID);
			toReturn.Add(this.VendorAddressEntityUsingVendorID);
			toReturn.Add(this.VendorContactEntityUsingVendorID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorID - ProductVendor.VendorID
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(VendorFields.VendorID, ProductVendorFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorID - PurchaseOrderHeader.VendorID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(VendorFields.VendorID, PurchaseOrderHeaderFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and VendorAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorID - VendorAddress.VendorID
		/// </summary>
		public virtual IEntityRelation VendorAddressEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorAddresses" , true);
				relation.AddEntityFieldPair(VendorFields.VendorID, VendorAddressFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and VendorContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorID - VendorContact.VendorID
		/// </summary>
		public virtual IEntityRelation VendorContactEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorContacts" , true);
				relation.AddEntityFieldPair(VendorFields.VendorID, VendorContactFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", false);
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
	internal static class StaticVendorRelations
	{
		internal static readonly IEntityRelation ProductVendorEntityUsingVendorIDStatic = new VendorRelations().ProductVendorEntityUsingVendorID;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingVendorIDStatic = new VendorRelations().PurchaseOrderHeaderEntityUsingVendorID;
		internal static readonly IEntityRelation VendorAddressEntityUsingVendorIDStatic = new VendorRelations().VendorAddressEntityUsingVendorID;
		internal static readonly IEntityRelation VendorContactEntityUsingVendorIDStatic = new VendorRelations().VendorContactEntityUsingVendorID;

		/// <summary>CTor</summary>
		static StaticVendorRelations()
		{
		}
	}
}
