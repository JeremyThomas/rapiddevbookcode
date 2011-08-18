using System.ComponentModel;

namespace Northwind.DAL.EntityClasses
{
	public static class StringConstants
	{
		public const string QuantityDescription= "Quantity IOrderDetailMetadata description attribute";
		public const string QuantityDisplayName = "Quantity IOrderDetailMetadata DisplayName";
	
		public const string UnitPriceDescription = "UnitPrice IOrderDetailMetadata description attribute";
		public const string UnitPriceDisplayName = "UnitPrice IOrderDetailMetadata DisplayName";

		public const string OrderDescription = "Order IOrderDetailMetadata description attribute";
		public const string OrderDisplayName = "Order IOrderDetailMetadata DisplayName";

		public const string ProductDescription = "Product IOrderDetailMetadata description attribute";
		public const string ProductDisplayName = "Product IOrderDetailMetadata DisplayName";
	}


	internal interface IOrderDetailMetadata
	{
		[Description(StringConstants.QuantityDescription)]
		[DisplayName(StringConstants.QuantityDisplayName)]
		object Quantity { get; set; }

		[Description(StringConstants.UnitPriceDescription)]
		[DisplayName(StringConstants.UnitPriceDisplayName)]
		object UnitPrice { get; set; }

		[Description(StringConstants.OrderDescription)]
		[DisplayName(StringConstants.OrderDisplayName)]
		object Order { get; set; }

		[Description(StringConstants.ProductDescription)]
		[DisplayName(StringConstants.ProductDisplayName)]
		object Product { get; set; }
	}
}