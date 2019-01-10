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
	/// <summary>Class which represents a row in the typed view 'ProductSalesFor1997'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetProductSalesFor1997TypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class ProductSalesFor1997Row : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductSalesFor1997Row"/> class.</summary>
		public ProductSalesFor1997Row()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CategoryName field.</summary>
		public System.String CategoryName { get; set; }
		/// <summary>Gets or sets the ProductName field.</summary>
		public System.String ProductName { get; set; }
		/// <summary>Gets or sets the ProductSales field.</summary>
		public Nullable<System.Decimal> ProductSales { get; set; }
		#endregion
	}
}

