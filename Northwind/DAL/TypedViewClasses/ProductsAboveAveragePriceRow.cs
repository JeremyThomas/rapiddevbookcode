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
	/// <summary>Class which represents a row in the typed view 'ProductsAboveAveragePrice'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetProductsAboveAveragePriceTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class ProductsAboveAveragePriceRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductsAboveAveragePriceRow"/> class.</summary>
		public ProductsAboveAveragePriceRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ProductName field.</summary>
		public System.String ProductName { get; set; }
		/// <summary>Gets or sets the UnitPrice field.</summary>
		public Nullable<System.Decimal> UnitPrice { get; set; }
		#endregion
	}
}

