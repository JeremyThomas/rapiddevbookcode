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
using AW.Data.FactoryClasses;
using AW.Data.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the inheritanceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the InheritanceInfoProviderBase class is threadsafe.</remarks>
	public static class InheritanceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IInheritanceInfoProvider _providerInstance = new InheritanceInfoProviderCore();
		#endregion
		
		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static InheritanceInfoProviderSingleton() { }

		/// <summary>Gets the singleton instance of the InheritanceInfoProviderCore</summary>
		/// <returns>Instance of the InheritanceInfoProvider.</returns>
		public static IInheritanceInfoProvider GetInstance()
		{
			return _providerInstance;
		}

		#region Custom InheritanceInfoProviderSingleton code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomInheritanceInfoProviderSingletonCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
	}

	/// <summary>Actual implementation of the InheritanceInfoProvider. Used by singleton wrapper.</summary>
	internal class InheritanceInfoProviderCore : InheritanceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="InheritanceInfoProviderCore"/> class.</summary>
		internal InheritanceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.AddEntityInfo("EmployeeEntity", string.Empty, new EmployeeRelations(), new EmployeeEntityFactory());
			this.AddEntityInfo("PurchaseOrderHistoryEntity", "TransactionHistoryEntity", new PurchaseOrderHistoryEntityFactory(), (int)PurchaseOrderHistoryFieldIndex.TransactionType, "P");
			this.AddEntityInfo("SalesOrderHistoryEntity", "TransactionHistoryEntity", new SalesOrderHistoryEntityFactory(), (int)SalesOrderHistoryFieldIndex.TransactionType, "S");
			this.AddEntityInfo("TransactionHistoryEntity", string.Empty, new TransactionHistoryEntityFactory(), (int)TransactionHistoryFieldIndex.TransactionType, "A");
			this.AddEntityInfo("WorkOrderHistoryEntity", "TransactionHistoryEntity", new WorkOrderHistoryEntityFactory(), (int)WorkOrderHistoryFieldIndex.TransactionType, "W");
			this.AddEntityInfo("CustomerEntity", string.Empty, new CustomerRelations(), new CustomerEntityFactory());
			this.AddEntityInfo("IndividualEntity", "CustomerEntity", new IndividualRelations(), new IndividualEntityFactory(), 1-1);
			this.AddEntityInfo("SalesPersonEntity", "EmployeeEntity", new SalesPersonRelations(), new SalesPersonEntityFactory(), 1-1);
			this.AddEntityInfo("StoreEntity", "CustomerEntity", new StoreRelations(), new StoreEntityFactory(), 1-1);
			base.BuildHierarchyInfoStore();
		}

		/// <summary>Gets the entity fields for the entity passed in. Only the fields defined in the entity are returned</summary>
		/// <param name="entityName">Name of the entity to grab the fields for</param>
		/// <returns>array of IEntityFieldCore fields</returns>
		public override IEntityFieldCore[] GetEntityFields(string entityName)
		{
			return EntityFieldsFactory.CreateFields(entityName);
		}
	}
}




