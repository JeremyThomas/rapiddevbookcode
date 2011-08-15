using System.ComponentModel;

namespace Northwind.DAL.EntityClasses
{
	internal interface IOrderDetailMetadata
	{
		[Description("Quantity IOrderDetailMetadata description attribute")]
		[DisplayName("Quantity IOrderDetailMetadata DisplayName")]
		object Quantity { get; set; }

		[Description("UnitPrice IOrderDetailMetadata description attribute")]
		[DisplayName("UnitPrice IOrderDetailMetadata DisplayName")]
		object UnitPrice { get; set; }

		[Description("Order IOrderDetailMetadata description attribute")]
		[DisplayName("Order IOrderDetailMetadata DisplayName")]
		object Order { get; set; }

		[Description("Product IOrderDetailMetadata description attribute")]
		[DisplayName("Product IOrderDetailMetadata DisplayName")]
		object Product { get; set; }
	}
}