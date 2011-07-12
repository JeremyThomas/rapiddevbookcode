using System.ComponentModel;

namespace Northwind.DAL.EntityClasses
{
	internal interface IOrderDetailMetadata
	{
		[Description("Quantity description attribute")]
		[DisplayName("Quantity DisplayName")]
		object Quantity { get; set; }

		[Description("UnitPrice description attribute")]
		[DisplayName("UnitPrice DisplayName")]
		object UnitPrice { get; set; }
	}
}