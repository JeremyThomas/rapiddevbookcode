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
	/// <summary>Class which represents a row in the typed view 'OrdersQry'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="Northwind.DAL.Linq.LinqMetaData.GetOrdersQryTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class OrdersQryRow : PocoBase
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="OrdersQryRow"/> class.</summary>
		public OrdersQryRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the Address field.</summary>
		public System.String Address { get; set; }
		/// <summary>Gets or sets the City field.</summary>
		public System.String City { get; set; }
		/// <summary>Gets or sets the CompanyName field.</summary>
		public System.String CompanyName { get; set; }
		/// <summary>Gets or sets the Country field.</summary>
		public System.String Country { get; set; }
		/// <summary>Gets or sets the CustomerId field.</summary>
		public System.String CustomerId { get; set; }
		/// <summary>Gets or sets the EmployeeId field.</summary>
		public Nullable<System.Int32> EmployeeId { get; set; }
		/// <summary>Gets or sets the Freight field.</summary>
		public Nullable<System.Decimal> Freight { get; set; }
		/// <summary>Gets or sets the OrderDate field.</summary>
		public Nullable<System.DateTime> OrderDate { get; set; }
		/// <summary>Gets or sets the OrderId field.</summary>
		public System.Int32 OrderId { get; set; }
		/// <summary>Gets or sets the PostalCode field.</summary>
		public System.String PostalCode { get; set; }
		/// <summary>Gets or sets the Region field.</summary>
		public System.String Region { get; set; }
		/// <summary>Gets or sets the RequiredDate field.</summary>
		public Nullable<System.DateTime> RequiredDate { get; set; }
		/// <summary>Gets or sets the ShipAddress field.</summary>
		public System.String ShipAddress { get; set; }
		/// <summary>Gets or sets the ShipCity field.</summary>
		public System.String ShipCity { get; set; }
		/// <summary>Gets or sets the ShipCountry field.</summary>
		public System.String ShipCountry { get; set; }
		/// <summary>Gets or sets the ShipName field.</summary>
		public System.String ShipName { get; set; }
		/// <summary>Gets or sets the ShippedDate field.</summary>
		public Nullable<System.DateTime> ShippedDate { get; set; }
		/// <summary>Gets or sets the ShipPostalCode field.</summary>
		public System.String ShipPostalCode { get; set; }
		/// <summary>Gets or sets the ShipRegion field.</summary>
		public System.String ShipRegion { get; set; }
		/// <summary>Gets or sets the ShipVia field.</summary>
		public Nullable<System.Int32> ShipVia { get; set; }
		#endregion
	}
}

