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

namespace AW.Data.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'Sales.CustomerViewQuerySpec'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="AW.Data.FactoryClasses.QueryFactory.GetCustomerViewQuerySpecTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class CustomerViewQuerySpecRow : PocoBase, IIndividualCustomer
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CustomerViewQuerySpecRow"/> class.</summary>
		public CustomerViewQuerySpecRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the AddressLine1 field.</summary>
		public System.String AddressLine1 { get; set; }
		/// <summary>Gets or sets the AddressLine2 field.</summary>
		public System.String AddressLine2 { get; set; }
		/// <summary>Gets or sets the AddressType field.</summary>
		public System.String AddressType { get; set; }
		/// <summary>Gets or sets the City field.</summary>
		public System.String City { get; set; }
		/// <summary>Gets or sets the CountryRegionName field.</summary>
		public System.String CountryRegionName { get; set; }
		/// <summary>Gets or sets the CustomerId field.</summary>
		public System.Int32 CustomerId { get; set; }
		/// <summary>Gets or sets the Demographics field.</summary>
		public System.String Demographics { get; set; }
		/// <summary>Gets or sets the EmailAddress field.</summary>
		public System.String EmailAddress { get; set; }
		/// <summary>Gets or sets the EmailPromotion field.</summary>
		public AW.Data.EmailPromotion EmailPromotion { get; set; }
		/// <summary>Gets or sets the FirstName field.</summary>
		public System.String FirstName { get; set; }
		/// <summary>Gets or sets the LastName field.</summary>
		public System.String LastName { get; set; }
		/// <summary>Gets or sets the MiddleName field.</summary>
		public System.String MiddleName { get; set; }
		/// <summary>Gets or sets the Phone field.</summary>
		public System.String Phone { get; set; }
		/// <summary>Gets or sets the PostalCode field.</summary>
		public System.String PostalCode { get; set; }
		/// <summary>Gets or sets the StateProvinceName field.</summary>
		public System.String StateProvinceName { get; set; }
		/// <summary>Gets or sets the Suffix field.</summary>
		public System.String Suffix { get; set; }
		/// <summary>Gets or sets the Title field.</summary>
		public System.String Title { get; set; }
		#endregion
	}
}

