///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using Northwind.DAL.DTO;	

namespace Northwind.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'SalesByCategory'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetSalesByCategoryTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class SalesByCategoryRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SalesByCategoryRow"/> class.</summary>
		public SalesByCategoryRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets the CategoryId field.</summary>
		public System.Int32 CategoryId { get; set; }
		/// <summary>Gets the CategoryName field.</summary>
		public System.String CategoryName { get; set; }
		/// <summary>Gets the ProductName field.</summary>
		public System.String ProductName { get; set; }
		/// <summary>Gets the ProductSales field.</summary>
		public Nullable<System.Decimal> ProductSales { get; set; }
		#endregion
	}
}

