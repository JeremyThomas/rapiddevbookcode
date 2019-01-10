///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using Northwind.DAL.DTO;	

namespace Northwind.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'AlphabeticalListOfProduct'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetAlphabeticalListOfProductTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class AlphabeticalListOfProductRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="AlphabeticalListOfProductRow"/> class.</summary>
		public AlphabeticalListOfProductRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CategoryId field.</summary>
		public Nullable<System.Int32> CategoryId { get; set; }
		/// <summary>Gets or sets the CategoryName field.</summary>
		public System.String CategoryName { get; set; }
		/// <summary>Gets or sets the Discontinued field.</summary>
		public System.Boolean Discontinued { get; set; }
		/// <summary>Gets or sets the ProductId field.</summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the ProductName field.</summary>
		public System.String ProductName { get; set; }
		/// <summary>Gets or sets the QuantityPerUnit field.</summary>
		public System.String QuantityPerUnit { get; set; }
		/// <summary>Gets or sets the ReorderLevel field.</summary>
		public Nullable<System.Int16> ReorderLevel { get; set; }
		/// <summary>Gets or sets the SupplierId field.</summary>
		public Nullable<System.Int32> SupplierId { get; set; }
		/// <summary>Gets or sets the UnitPrice field.</summary>
		public Nullable<System.Decimal> UnitPrice { get; set; }
		/// <summary>Gets or sets the UnitsInStock field.</summary>
		public Nullable<System.Int16> UnitsInStock { get; set; }
		/// <summary>Gets or sets the UnitsOnOrder field.</summary>
		public Nullable<System.Int16> UnitsOnOrder { get; set; }
		#endregion
	}
}

