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
	/// <summary>Class which represents a row in the typed view 'CustomerAndSuppliersByCity'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetCustomerAndSuppliersByCityTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class CustomerAndSuppliersByCityRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CustomerAndSuppliersByCityRow"/> class.</summary>
		public CustomerAndSuppliersByCityRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the City field.</summary>
		public System.String City { get; set; }
		/// <summary>Gets or sets the CompanyName field.</summary>
		public System.String CompanyName { get; set; }
		/// <summary>Gets or sets the ContactName field.</summary>
		public System.String ContactName { get; set; }
		/// <summary>Gets or sets the Relationship field.</summary>
		public System.String Relationship { get; set; }
		#endregion
	}
}

