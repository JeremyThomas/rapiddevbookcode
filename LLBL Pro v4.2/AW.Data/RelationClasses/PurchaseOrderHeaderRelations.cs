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
	/// <summary>Implements the relations factory for the entity: PurchaseOrderHeader. </summary>
	public partial class PurchaseOrderHeaderRelations
	{
		/// <summary>CTor</summary>
		public PurchaseOrderHeaderRelations()
		{
		}

		/// <summary>Gets all relations of the PurchaseOrderHeaderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PurchaseOrderDetailEntityUsingPurchaseOrderID);
			toReturn.Add(this.EmployeeEntityUsingEmployeeID);
			toReturn.Add(this.ShipMethodEntityUsingShipMethodID);
			toReturn.Add(this.VendorEntityUsingVendorID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and PurchaseOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.PurchaseOrderID - PurchaseOrderDetail.PurchaseOrderID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderDetailEntityUsingPurchaseOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderDetails" , true);
				relation.AddEntityFieldPair(PurchaseOrderHeaderFields.PurchaseOrderID, PurchaseOrderDetailFields.PurchaseOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.EmployeeID - Employee.EmployeeID
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeID, PurchaseOrderHeaderFields.EmployeeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.ShipMethodID - ShipMethod.ShipMethodID
		/// </summary>
		public virtual IEntityRelation ShipMethodEntityUsingShipMethodID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ShipMethod", false);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodID, PurchaseOrderHeaderFields.ShipMethodID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and VendorEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.VendorID - Vendor.VendorID
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vendor", false);
				relation.AddEntityFieldPair(VendorFields.VendorID, PurchaseOrderHeaderFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
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
	internal static class StaticPurchaseOrderHeaderRelations
	{
		internal static readonly IEntityRelation PurchaseOrderDetailEntityUsingPurchaseOrderIDStatic = new PurchaseOrderHeaderRelations().PurchaseOrderDetailEntityUsingPurchaseOrderID;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIDStatic = new PurchaseOrderHeaderRelations().EmployeeEntityUsingEmployeeID;
		internal static readonly IEntityRelation ShipMethodEntityUsingShipMethodIDStatic = new PurchaseOrderHeaderRelations().ShipMethodEntityUsingShipMethodID;
		internal static readonly IEntityRelation VendorEntityUsingVendorIDStatic = new PurchaseOrderHeaderRelations().VendorEntityUsingVendorID;

		/// <summary>CTor</summary>
		static StaticPurchaseOrderHeaderRelations()
		{
		}
	}
}
