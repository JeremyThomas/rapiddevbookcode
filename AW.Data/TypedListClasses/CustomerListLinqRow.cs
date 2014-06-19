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

namespace AW.Data.TypedListClasses
{
	/// <summary>Class which represents a row in the typed list 'Sales.CustomerListLinq'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="AW.Data.Linq.LinqMetaData.GetCustomerListLinqTypedList"/>.
	/// Contains the following entity definition(s):
	/// Entity: Person.Address. <br/>
	/// Entity: Person.AddressType. <br/>
	/// Entity: Person.Contact. <br/>
	/// Entity: Person.CountryRegion. <br/>
	/// Entity: Person.StateProvince. <br/>
	/// Entity: Sales.Customer. <br/>
	/// Entity: Sales.CustomerAddress. <br/>
	/// Entity: Sales.Individual. <br/>
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class CustomerListLinqRow 
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="CustomerListLinqRow"/> class.</summary>
		public CustomerListLinqRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets the AddressLine1 field. Mapped onto 'Person.Address.AddressLine1'</summary>
		public System.String AddressLine1 { get; set; }
		/// <summary>Gets the AddressLine2 field. Mapped onto 'Person.Address.AddressLine2'</summary>
		public System.String AddressLine2 { get; set; }
		/// <summary>Gets the City field. Mapped onto 'Person.Address.City'</summary>
		public System.String City { get; set; }
		/// <summary>Gets the AddressType field. Mapped onto 'Person.AddressType.Name'</summary>
		public System.String AddressType { get; set; }
		/// <summary>Gets the Title field. Mapped onto 'Person.Contact.Title'</summary>
		public System.String Title { get; set; }
		/// <summary>Gets the FirstName field. Mapped onto 'Person.Contact.FirstName'</summary>
		public System.String FirstName { get; set; }
		/// <summary>Gets the MiddleName field. Mapped onto 'Person.Contact.MiddleName'</summary>
		public System.String MiddleName { get; set; }
		/// <summary>Gets the LastName field. Mapped onto 'Person.Contact.LastName'</summary>
		public System.String LastName { get; set; }
		/// <summary>Gets the Suffix field. Mapped onto 'Person.Contact.Suffix'</summary>
		public System.String Suffix { get; set; }
		/// <summary>Gets the EmailAddress field. Mapped onto 'Person.Contact.EmailAddress'</summary>
		public System.String EmailAddress { get; set; }
		/// <summary>Gets the EmailPromotion field. Mapped onto 'Person.Contact.EmailPromotion'</summary>
		public AW.Data.EmailPromotion EmailPromotion { get; set; }
		/// <summary>Gets the CountryRegionName field. Mapped onto 'Person.StateProvince.Name'</summary>
		public System.String CountryRegionName { get; set; }
		/// <summary>Gets the StateProvinceName field. Mapped onto 'Person.CountryRegion.Name'</summary>
		public System.String StateProvinceName { get; set; }
		/// <summary>Gets the CustomerId field. Mapped onto 'Sales.Customer.CustomerID'</summary>
		public System.Int32 CustomerId { get; set; }
		#endregion
	}
}

