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
	/// <summary>Class which represents a row in the typed view 'OrderDetailsExtended'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetOrderDetailsExtendedTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class OrderDetailsExtendedRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="OrderDetailsExtendedRow"/> class.</summary>
		public OrderDetailsExtendedRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets the Discount field.</summary>
		public System.Single Discount { get; set; }
		/// <summary>Gets the ExtendedPrice field.</summary>
		public Nullable<System.Decimal> ExtendedPrice { get; set; }
		/// <summary>Gets the OrderId field.</summary>
		public System.Int32 OrderId { get; set; }
		/// <summary>Gets the ProductId field.</summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets the ProductName field.</summary>
		public System.String ProductName { get; set; }
		/// <summary>Gets the Quantity field.</summary>
		public System.Int16 Quantity { get; set; }
		/// <summary>Gets the UnitPrice field.</summary>
		public System.Decimal UnitPrice { get; set; }
		#endregion
	}
}

