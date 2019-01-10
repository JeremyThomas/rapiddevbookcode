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
	/// <summary>Class which represents a row in the typed view 'CategorySalesFor1997'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetCategorySalesFor1997TypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class CategorySalesFor1997Row : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CategorySalesFor1997Row"/> class.</summary>
		public CategorySalesFor1997Row()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CategoryName field.</summary>
		public System.String CategoryName { get; set; }
		/// <summary>Gets or sets the CategorySales field.</summary>
		public Nullable<System.Decimal> CategorySales { get; set; }
		#endregion
	}
}

